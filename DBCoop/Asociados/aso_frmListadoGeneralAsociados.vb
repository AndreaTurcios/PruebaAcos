Imports DevExpress.XtraReports.UI
Public Class aso_frmListadoGeneralAsociados
    Dim blAporta As New DBCoopBL.AportacionesBLL()


    Private Sub apo_frmListadoGeneralAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub

    Private Sub apo_frmListadoGeneralAsociados_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociados
        rpt.DataSource = blAporta.rptListadoGeneralAsociados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO GENERAL DE ASOCIADOS"
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoGeneralAsociados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoGeneralAsociados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
