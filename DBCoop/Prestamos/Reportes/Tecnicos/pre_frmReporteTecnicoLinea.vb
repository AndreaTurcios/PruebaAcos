Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmReporteTecnicoLinea
    Dim bl As New PrestamosBLL()
    Private Sub pre_frmReporteTecnicoLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES --")
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LÍNEAS --")
    End Sub

    Private Sub pre_frmReporteTecnicoLinea_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptTecnicoLinea
        rpt.DataSource = bl.rptDetalleCarteraTecnicoLinea(leSucursal.EditValue, leTecnico.EditValue, leLinea.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlNombreSucursal.Text = leSucursal.Text
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmReporteTecnicoLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptDetalleCarteraTecnicoLinea(leSucursal.EditValue, leTecnico.EditValue, leLinea.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
