Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmActualizarLibretaPrestamo
    Dim blCaja As New CajaBusiness()
    Dim blPres As Prestamo, entPrestamo As coo_Prestamos, entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim entPago As coo_PrestamosDetalle

    Private Sub frmActualizarLibretaPrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btIdPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        beNumeroPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        teIdPrestamo.EditValue = frmConsultaPrestamos.IdPrestamo
        btNumPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub btNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroPrestamo.Validated
        If SiEsNulo(beNumeroPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim NumeroPrestamo As String
        If beNumeroPrestamo.EditValue = "" Then
            NumeroPrestamo = ""
        Else
            NumeroPrestamo = beNumeroPrestamo.EditValue
        End If
        entPrestamo = blCaja.coo_PrestamosSelectByNumero(NumeroPrestamo)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        blPres = New Prestamo
        blPres.FechaAmortizacion = Today()
        blPres.CargaPrestamo(entPrestamo.IdPrestamo)

        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)

        teNombreCliente.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)

        gcMov.DataSource = blCaja.coo_PagosPrestamoParalibreta(teIdPrestamo.EditValue)
        gvMov.MoveLast()
    End Sub

    'Private Sub gvMov_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvMov.RowUpdated
    '    Dim IdMov As Integer, Impreso As Boolean
    '    If gvMov.GetFocusedRowCellValue("IdMov") > -1 Then
    '        IdMov = gvMov.GetFocusedRowCellValue("IdMov")
    '        Impreso = gvMov.GetFocusedRowCellValue("ImpresoLibreta")
    '        Dim msj As String = blCaja.ActualizaImpresoPrestamo(teIdPrestamo.EditValue, IdMov, Impreso)
    '        If msj <> "" Then
    '            MsgBox(String.Format("Error al actualizar{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
    '        End If
    '    End If
    'End Sub


    Private Sub sbImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbImprimir.Click
        If beNumeroPrestamo.EditValue = "" Then
            MsgBox("No se ha especificado el número de préstamo", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        'If teLineaLibreta.EditValue < 0 Or teLineaLibreta.EditValue > entSucursal.LineasLibreta Then
        '    MsgBox("Número de línea incorrecto", MsgBoxStyle.Critical, "Nota")
        '    Exit Sub
        'End If

        'ActualizaLibretaPrestamoPorCodigo(teIdPrestamo.EditValue, teLineaLibreta.EditValue, entSucursal.LineasLibreta)


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
        'Dim IdMov As Integer

        ' IdMov = blCaja.UltMovReferencia(leReferencia.EditValue)
        entPrestamo = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        entAsociado = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
        entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
        entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(teIdPrestamo.EditValue, gvMov.GetFocusedRowCellValue("IdMov"))

        entPago = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, gvMov.GetFocusedRowCellValue("IdMov"))

        Dim sDecimal = String.Format("{0:c}", Format(CDec(entPago.ImportePagado), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        rpt.xrlTotalPagado.Text = Format(CDec(entPago.ImportePagado), "##,##0.00")
        rpt.xrlFechaContable.Text = entPago.FechaContable
        rpt.xrlNombre.Text = teNombreCliente.EditValue
        rpt.xrlNumeroAsociado.Text = entAsociado.Numero
        rpt.xrlDireccion.Text = entAsociado.Direccion
        rpt.xrlIdMov.Text = (entDetalle.IdMov - 1)
        rpt.xrlFechaOtorgado.Text = entPrestamo.FechaOtorgado
        rpt.xrlLinea.Text = entLinea.Nombre
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        ' rpt.XrPictureBox1.ImageUrl = ("RutaLogo")

        rpt.xrlFuente.Text = entFuente.Nombre
        rpt.xrlNumeroPrestamo.Text = beNumeroPrestamo.EditValue

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
        rpt.xrlComprobante.Text = entPago.Numero
        rpt.xrlCapital.Text = entDetalle.CapitalPagado
        rpt.xrlAportacion.Text = entDetalle.CuotaAportacion
        rpt.xrlAhorro.Text = entDetalle.CuotaAhorro
        rpt.xrlInteres.Text = entDetalle.InteresPagado
        rpt.xrlInteresMora.Text = entDetalle.InteresMoraPagado
        rpt.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
        rpt.xrlManejo.Text = entDetalle.ManejoPagado
        'rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAportacion + entDetalle.CuotaAhorro + entDetalle.ValorSeguroPagado
        rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
        rpt.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado

        rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
        rpt.xrlValorCuota.Text = Format(CDec(entPrestamo.ValorCuota), "##,##0.00")
        rpt.xrlNumCuotas.Text = entPrestamo.NumCuotas
        rpt.ShowPrintMarginsWarning = False
        rpt.xrlCantidadLetras.Text = Num2Text(Int(entPago.ImportePagado)) & " " & sDecimal & " DÓLARES"
        rpt.ShowPreviewDialog()


        ' gcMov.DataSource = Nothing
        beNumeroPrestamo.Focus()
    End Sub

    Private Sub frmActualizaLibretaPrestamo_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

End Class