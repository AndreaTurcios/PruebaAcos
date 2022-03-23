Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoIngresosAsociados
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoIngresosAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub
    Private Sub apo_frmListadoIngresosAsociados_Report_Click() Handles Me.Reporte
        Dim rpt As New aso_rptListadoIngresosAsociados
        rpt.DataSource = blAporta.rptListadoIngresosAsociados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS QUE HAN INGRESADO A LA INSTITUCIÓN"
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoIngresosAsociados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoIngresosAsociados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
