Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAsociadosInactivos
    Dim blAporta As New AportacionesBLL()


    Private Sub apo_frmListadoAsociadosInactivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub


    Private Sub apo_frmListadoAsociadosInactivos_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociadosActivos
        rpt.DataSource = blAporta.rptListadoAsociadosInactivos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS INACTIVOS"
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoAsociadosInactivos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosInactivos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
