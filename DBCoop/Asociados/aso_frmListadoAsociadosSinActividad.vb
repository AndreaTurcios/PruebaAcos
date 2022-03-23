Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAsociadosSinActividad
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoAsociadosActivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.adm_TiposPlanilla(lePlanilla, "--TODOS LOS TIPOS DE PLANILLAS--")
    End Sub
    Private Sub apo_frmListadoAsociadosActivos_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociadosSinActividad
        rpt.DataSource = blAporta.rptListadoAsociadosSinActividad(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS SIN ACTIVIDAD EN APORTACIONES"
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text & "   TIPO DE PLANILLA:   " & lePlanilla.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoAsociadosActivos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosSinActividad(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
