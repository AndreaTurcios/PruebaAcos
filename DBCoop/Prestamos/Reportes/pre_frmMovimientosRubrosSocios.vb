Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmMovimientosRubros
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()
    Dim blAsoc As New DBCoopBL.AsociadosBLL()

    Private Sub pre_frmListadoDescuentosPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesdeFecha.EditValue = Today
        deHastaFecha.EditValue = Today
        teIdAsociado.EditValue = 0
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CRÉDITO Y SALDOS A FAVOR --")
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptListadosaldosSocios
        rpt.DataSource = blPrestamo.rptListadoSaldosSocios(leSucursal.EditValue, deDesdeFecha.EditValue _
                        , deHastaFecha.EditValue, teIdAsociado.EditValue, leLinea.EditValue, ceIncluyeAportacion.EditValue, ceIncluyeAhorros.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "SALDO DE SOCIOS POR FECHAS Y RUBROS"
        rpt.xrlcDelAl.Text = FechaToString(deDesdeFecha.EditValue, deHastaFecha.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            teIdAsociado.EditValue = 0
            Exit Sub
        End If

        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            teIdAsociado.EditValue = 0
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoSaldosSocios(leSucursal.EditValue, deDesdeFecha.EditValue, deHastaFecha.EditValue, teIdAsociado.EditValue, leLinea.EditValue, ceIncluyeAportacion.EditValue, ceIncluyeAhorros.EditValue), "")
    End Sub

End Class
