Imports DBCoopBL
Public Class aso_frmListadoIngresosAfiliaciones
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoIngresosAfiliaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS AGENCIAS --")
    End Sub
    Private Sub apo_frmListadoIngresosAfiliaciones_Report_Click() Handles Me.Reporte
        Dim rpt As New aso_rptListadoIngresosAfiliaciones
        rpt.DataSource = blAporta.rptListadoIngresosAfiliaciones(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE INGRESOS DE AFILIACIONES"
        rpt.xrlSucursal.Text = "AGENCIA : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoIngresosAfiliaciones_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoIngresosAfiliaciones(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
