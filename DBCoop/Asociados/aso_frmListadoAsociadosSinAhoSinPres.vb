Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAsociadosSinAhoSinPres
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoAsociadosActivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub
    Private Sub apo_frmListadoAsociadosActivos_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociadosSinActividad
        rpt.DataSource = blAporta.rptListadoAsociadosSinAhorrosPrestamos(leSucursal.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS SIN USO DE AHORROS Y PRESTAMOS"
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoAsociadosActivos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosSinAhorrosPrestamos(leSucursal.EditValue, deHasta.EditValue), "")
    End Sub
End Class
