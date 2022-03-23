Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class con_frmAnalisisDepositosPlazo
    Dim bl As New ReportesBL()
    Private Sub con_frmAnalisisDepositosPlazo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        deDesde.EditValue = Today
        deHasta.EditValue = Today
    End Sub

    Private Sub con_frmAnalisisDepositosPlazo_Reporte() Handles Me.Reporte
        Dim dt As DataTable = bl.rptAnalisisDepositosPlazo(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        Dim rpt As New con_rptListadoDepositosPlazosIntPagados() With {.DataSource = dt, .DataMember = ""}
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "ANÁLISIS DE DEPÓSITOS A PLAZO - " & leSucursal.Text
        rpt.xrlPeriodo.Text = (FechaToString(deDesde.EditValue, deHasta.EditValue)).ToUpper
        rpt.ShowPreview()
    End Sub
End Class
