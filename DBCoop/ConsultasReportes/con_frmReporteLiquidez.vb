Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class con_frmReporteLiquidez
    Dim bl As New ReportesBL()
    Private Sub con_frmReporteLiquidez_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.adm_Sucursales(leSucursal, "")
        meMes.EditValue = Month(Today)
        seEjercicio.EditValue = Year(Today)
    End Sub

    Private Sub con_frmReporteLiquidez_Reporte() Handles Me.Reporte
        Dim dt As DataTable = bl.rptReporteLiquidez(leSucursal.EditValue, meMes.EditValue, seEjercicio.EditValue)
        Dim rpt As New con_rptReporteLiquidez ' With {.DataSource = dt, .DataMember = ""}
        rpt.DataSource = dt
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "REPORTE DE LIQUIDEZ - " & leSucursal.Text
        rpt.xrlPeriodo.Text = String.Format("SALDOS AL MES DE {0} DE {1}", ObtieneMesString(meMes.Month).ToUpper, seEjercicio.EditValue)
        rpt.ShowPreview()
    End Sub
End Class
