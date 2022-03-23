Imports DevExpress.XtraReports.UI
Imports System.Math
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmAnularPago
    Dim blPres As New PrestamosBLL()
    Dim blAporta As New AportacionesBLL()
    Dim blAdmon As New AdmonBLL()
    'Dim elAportacion As coo_Aportaciones
    'Dim elAhorro As coo_CuentasAhorroMov
    Dim entPago As coo_PrestamosDetalle
    Dim entAsociado As coo_Asociados
    'Dim entSucursal As New adm_Sucursales

    Private Sub frmReimprimePago_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btNumPrestamo.Focus()
    End Sub

    Private Sub frmReimprimePago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmReimprimePago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_FormasPagoCaja(_FormaPago, "")
        _FechaContable.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        _FechaPago.EditValue = _FechaContable.EditValue
    End Sub


    Private Sub btIdPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btNumPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        btNumPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        btNumPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub btNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btNumPrestamo.Validated
        Dim IdMov As Integer
        If SiEsNulo(btNumPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim entPrestamo = blPres.coo_PrestamosSelectByNumero(btNumPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If teIdPrestamo.EditValue = 0 Or entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If


        'elAportacion = New coo_Aportaciones
        'elAhorro = New coo_CuentasAhorroMov
        entAsociado = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        IdMov = blPres.GetUltMovPrestamo(entPrestamo.IdPrestamo)
        entPago = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, IdMov)
        With entPago
            _FormaPago.EditValue = .IdFormaPago
            _Asociado.EditValue = entAsociado.Nombres & " " & entAsociado.Apellidos
            teIdMov.EditValue = .IdMov
            _NumeroComprobante.EditValue = .Numero
            _FechaPago.EditValue = .Fecha
            _FechaOtorgamiento.EditValue = entPrestamo.FechaOtorgado
            _MontoAplicar.EditValue = .ImportePagado
            _FechaContable.EditValue = .FechaContable
            _ImporteCuotaAhorro.EditValue = .CuotaAhorro
            _ImporteCuotaAportacion.EditValue = .CuotaAportacion
            _DeberSerInteres.EditValue = .InteresPagado
            _ImporteCapital.EditValue = .CapitalPagado
            _ImporteSeguro.EditValue = .ValorSeguroPagado
            _DeberSerMora.EditValue = .InteresMoraPagado
            _ImporteOtros.EditValue = .OtrosPagado
            _ImporteManejo.EditValue = .ManejoPagado
        End With
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        Close()
    End Sub

    Private Sub cmdReImprimirPago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btReImprimirPago.Click

        If teIdPrestamo.EditValue = 0 Then
            Exit Sub
        End If
        Dim entLineaPrestamo As coo_Prestamos
        entLineaPrestamo = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)

        Dim entAsociado As New coo_Asociados
        Dim entLinea As New coo_Lineas
        Dim entFuente As New coo_Fuentes
        Dim entPrestamo As New coo_Prestamos
        Dim entDetalle As New coo_PrestamosDetalle
        Dim rpt As New pre_rptFacturaPago

        entPrestamo = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        entAsociado = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
        entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
        entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(teIdPrestamo.EditValue, teIdMov.EditValue)

        'cambio realizado para re-imprimir las notas de cargo o valores que vienen en negativo
        Dim TotalPago As Decimal = Abs(_MontoAplicar.EditValue)

        Dim sDecimal = String.Format("{0:c}", Format(TotalPago, "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

        rpt.xrlTotalPagado.Text = Format(_MontoAplicar.EditValue, "##,##0.00")
        rpt.xrlFechaContable.Text = _FechaContable.EditValue
        rpt.xrlNombre.Text = _Asociado.EditValue
        rpt.xrlNumeroAsociado.Text = entAsociado.Numero
        rpt.xrlDireccion.Text = entAsociado.Direccion
        rpt.xrlFechaOtorgado.Text = _FechaOtorgamiento.EditValue
        rpt.xrlLinea.Text = entLinea.Nombre
        rpt.xrlFuente.Text = entFuente.Nombre
        rpt.xrlNumeroPrestamo.Text = btNumPrestamo.EditValue
        If entPrestamo.IdTipoCartera = 3 Then
            rpt.xrlTipoCartera.Text = "PRESTAMO SANEADO"
        Else
            rpt.xrlTipoCartera.Text = ""
        End If
        rpt.xrlTasaInteres.Text = entPrestamo.TasaInteres
        rpt.xrlNuevoSaldo.Text = Format(CDec(entDetalle.SaldoCapital), "##,##0.00")
        rpt.xrlCapitalPagado.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
        rpt.xrlSaldoCapital.Text = Format(CDec(entDetalle.SaldoCapital + entDetalle.CapitalPagado), "##,##0.00")
        rpt.xrlInteresPendiente.Text = entDetalle.InteresPendiente
        rpt.xrlFechaUltPago.Text = ""
        rpt.xrlFechaVencimiento.Text = entPrestamo.FechaVencimiento
        rpt.xrlMontoOtorgado.Text = Format(CDec(entPrestamo.MontoAprobado), "##,##0.00")
        rpt.xrlComprobante.Text = _NumeroComprobante.EditValue
        rpt.xrlCapital.Text = entDetalle.CapitalPagado
        rpt.xrlAportacion.Text = entDetalle.CuotaAportacion
        rpt.xrlAhorro.Text = entDetalle.CuotaAhorro
        rpt.xrlInteres.Text = entDetalle.InteresPagado
        rpt.xrlInteresMora.Text = entDetalle.InteresMoraPagado
        rpt.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
        rpt.xrlManejo.Text = entDetalle.ManejoPagado
        rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
        rpt.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
        rpt.xrlCantidadLetras.Text = Num2Text(Int(TotalPago)) & " " & sDecimal & " DÓLARES"
        rpt.ShowPreviewDialog()

    End Sub

    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEliminar.Click
        Dim msj As String = ""
        Dim IdMovAporta As Integer
        Dim entPres2 As New coo_Prestamos
        If teIdPrestamo.EditValue <= 0 Then
            Exit Sub
        End If
        If teIdMov.EditValue <= 0 Then
            Exit Sub
        End If
        Dim Fecha As Date = objFunciones.GetFechaContable(gIdSucursal)
        If Fecha > _FechaContable.EditValue Then
            MsgBox("No es posible anular el último pago. Corresponde a un período ya cerrado", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        entPres2 = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        If _ImporteCuotaAportacion.EditValue > 0.0 Then
            IdMovAporta = blPres.GetIdMovAportacionPrestamo("P/" & _NumeroComprobante.EditValue, entPres2.IdAsociado)
            If IdMovAporta < blAporta.GetUltMovAporta(entPres2.IdAsociado) Then
                MsgBox("El Movimiento a eliminar tiene movimientos posteriores o No existe", MsgBoxStyle.Critical, "No es posible eliminar")
                Exit Sub
            End If
        End If

        If MsgBox("Está seguro(a) de eliminar el pago?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_PrestamosDetalleDeleteByPK(teIdPrestamo.EditValue, teIdMov.EditValue)
                If IdMovAporta > 0 Then
                    objTablas.coo_AportacionesDeleteByPK(entPres2.IdAsociado, IdMovAporta)
                End If
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El pago fue eliminado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar el pago de préstamo" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
        Close()
    End Sub
End Class