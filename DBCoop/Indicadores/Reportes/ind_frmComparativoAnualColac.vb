Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class ind_frmComparativoAnualColac
    Dim bl As New IndicadoresBLL
    Private Sub ind_frmComparativoAnualColac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.col_Variables(leIndicador, "-- TODAS LOS INDICADORES --")
        seAnio.EditValue = Year(Now)
    End Sub

    Private Sub ind_frmComparativoAnualColac_Reporte() Handles Me.Reporte
        Dim rpt As New ind_rptComparativoAnualColac
        rpt.DataSource = bl.rptComparativoAnualColac(seAnio.EditValue, leIndicador.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "REPORTE INDICADORES COLAC "
        rpt.xrlTitulo2.Text = "AÑO: " & seAnio.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmCuadroMora_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptComparativoAnualColac(seAnio.EditValue, leIndicador.EditValue), "")
    End Sub
End Class