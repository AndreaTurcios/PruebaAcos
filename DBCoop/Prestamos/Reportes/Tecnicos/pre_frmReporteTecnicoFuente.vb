Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmReporteTecnicoFuente
    Dim bl As New PrestamosBLL()
    Private Sub pre_frmReporteTecnicoFuente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deHasta.EditValue = Today
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.coo_Fuentes(leFuente, "-- TODAS LAS FUENTES --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES")
    End Sub

    Private Sub pre_frmReporteTecnicoLinea_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptTecnicoFuente
        rpt.DataSource = bl.rptDetalleCarteraTecnicoFuente(leSucursal.EditValue, leTecnico.EditValue, leFuente.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlNombreSucursal.Text = leSucursal.Text
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.xrlNombreSucursal.Text = leTecnico.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmReporteTecnicoFuente_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptDetalleCarteraTecnicoFuente(leSucursal.EditValue, leTecnico.EditValue, leFuente.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
