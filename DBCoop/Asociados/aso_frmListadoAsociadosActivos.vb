Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAsociadosActivos
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoAsociadosActivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub
    Private Sub apo_frmListadoAsociadosActivos_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociadosActivos
        rpt.DataSource = blAporta.rptListadoAsociadosActivos(leSucursal.EditValue, deDesde.EditValue _
        , deHasta.EditValue, chkEnvio.EditValue, chkDividendos.EditValue, chkFuneraria.EditValue)

        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS ACTIVOS"
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoAsociadosActivos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosActivos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, chkEnvio.EditValue, chkDividendos.EditValue, chkFuneraria.EditValue), "")
    End Sub
End Class
