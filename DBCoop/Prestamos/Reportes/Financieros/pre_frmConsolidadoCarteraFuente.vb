Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmConsolidadoCarteraFuente
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmConsolidadoCarteraFuente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO--")
    End Sub

    Private Sub pre_frmConsolidadoCarteraFuente_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptConsolidadoCarteraFuente
        rpt.DataSource = blPrestamo.rptConsolidadoCarteraFuente(leSucursal.EditValue, leFinanciamiento.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.XrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmConsolidadoCarteraFuente_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptConsolidadoCarteraFuente(leSucursal.EditValue, leFinanciamiento.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
