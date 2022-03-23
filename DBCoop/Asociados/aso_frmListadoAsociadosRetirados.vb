Imports DevExpress.XtraReports.UI
Public Class aso_frmListadoAsociadosRetirados
    Dim blAporta As New DBCoopBL.AportacionesBLL()


    Private Sub apo_frmListadoAsociadosRetirados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.adm_EstadoSocio(leEstado, "--TODOS LOS ESTADOS DE RETIRADOS--")
    End Sub

    Private Sub apo_frmListadoAsociadosRetirados_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoAsociadosRetirados
        rpt.DataSource = blAporta.rptListadoAsociadosRetirados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leEstado.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS RETIRADOS  " & leEstado.Text
        rpt.xrlTitulo2.Text = leEstado.Text
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoAsociadosRetirados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosRetirados(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leEstado.EditValue), "")
    End Sub
End Class
