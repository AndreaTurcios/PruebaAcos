Imports DevExpress.XtraReports.UI
Imports DBCoopBL

Public Class con_frmInformeGerencial1
    Dim bl As New ReportesBL()
    Private Sub rep_frmInformeGerencial1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        deFecha.EditValue = Today
    End Sub

    Private Sub rep_frmInformeGerencial1_Reporte() Handles Me.Reporte
        Dim rpt As New con_rptInformeGerencial1
        rpt.DataSource = bl.InformeGerencial1(leSucursal.EditValue, deFecha.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlPeriodo.Text = "AL " & FechaToString(deFecha.EditValue, deFecha.EditValue).ToUpper()
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text

        rpt.ShowPreview()
    End Sub
    Private Sub aho_frmListadoCuentasInactivas_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.InformeGerencial1(leSucursal.EditValue, deFecha.EditValue), "InformeGerencial")
    End Sub
End Class