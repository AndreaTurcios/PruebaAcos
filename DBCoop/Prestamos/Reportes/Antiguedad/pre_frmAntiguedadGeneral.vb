Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmAntiguedadGeneral
    Dim bl As New PrestamosBLL()

    Private Sub pre_frmAntiguedadGeneral_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_PrestamosClasificacion(leAntiguedad, "-- TODAS LAS CLASIFICACIONES --")
    End Sub

    Private Sub pre_frmAntiguedadFuente_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptAntiguedadFuente
        rpt.DataSource = bl.rptAntiguedadGeneral(leSucursal.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlClasificacion.Text = leAntiguedad.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmAntiguedadLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptAntiguedadGeneral(leSucursal.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
