Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports System.Math
Public Class frmReimprimePago
    Dim blCaja As New PrestamosBLL()
    Dim elAportacion As coo_Aportaciones
    Dim elAhorro As coo_CuentasAhorroMov
    Dim entPago As coo_PrestamosDetalle
    Dim entAsociado As coo_Asociados


    Private Sub frmReimprimePago_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btIdPrestamo.Focus()
    End Sub

    Private Sub frmReimprimePago_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmReimprimePago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        _FechaContable.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        _FechaPago.EditValue = _FechaContable.EditValue
    End Sub

    Private Sub CargaCombos()
        objCombos.cooPtmoFmaPago(_FormaPago)
    End Sub

    Private Sub btIdPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btIdPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        btIdPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        btIdPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub btIdPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btIdPrestamo.Validated

        If SiEsNulo(btIdPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim entPrestamo = blCaja.coo_PrestamosSelectByNumero(btIdPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If teIdPrestamo.Text = 0 Then
            Exit Sub
        End If
        If entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If

        btIdPrestamo.Enabled = False
        elAportacion = New coo_Aportaciones
        elAhorro = New coo_CuentasAhorroMov
        entAsociado = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teIdMov.EditValue = blCaja.GetUltMovPrestamo(entPrestamo.IdPrestamo)
        entPago = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, teIdMov.EditValue)
        With entPago
            _FormaPago.EditValue = .IdFormaPago
            _Asociado.EditValue = entAsociado.Nombres & " " & entAsociado.Apellidos
            _NumeroComprobante.EditValue = .Numero
            _FechaPago.EditValue = .Fecha
            _FechaOtorgamiento.EditValue = entPrestamo.FechaOtorgado
            _MontoAplicar.EditValue = Abs(.ImportePagado)
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

    Private Sub cmdAplicarPago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdAplicarPago.Click
        Dim entLineaPrestamo As coo_Prestamos
        entLineaPrestamo = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        If entLineaPrestamo.IdLinea = 14 Then
            Exit Sub
        End If
        If MsgBox("Desea imprimir la factura de pago?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
            Exit Sub
        End If
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

        Dim sDecimal = String.Format("{0:c}", Format(CDec(_MontoAplicar.EditValue), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        rpt.xrlTotalPagado.Text = Format(CDec(_MontoAplicar.EditValue), "##,##0.00")
        rpt.xrlFechaContable.Text = _FechaContable.EditValue
        rpt.xrlNombre.Text = _Asociado.EditValue
        rpt.xrlNumeroAsociado.Text = entAsociado.Numero
        rpt.xrlDireccion.Text = entAsociado.Direccion
        rpt.xrlFechaOtorgado.Text = _FechaOtorgamiento.EditValue
        rpt.xrlLinea.Text = entLinea.Nombre
        rpt.xrlFuente.Text = entFuente.Nombre
        rpt.xrlNumeroPrestamo.Text = btIdPrestamo.EditValue
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
        rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAportacion + entDetalle.CuotaAhorro + entDetalle.ValorSeguroPagado
        rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
        rpt.xrlCantidadLetras.Text = Num2Text(Int(_MontoAplicar.EditValue)) & " " & sDecimal & " DÓLARES"
        Rpt.ShowPreviewDialog()

    End Sub
End Class