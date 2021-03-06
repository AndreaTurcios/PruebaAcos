Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmAntiguedadFuente
    Dim bl As New PrestamosBLL()


    Private Sub pre_frmAntiguedadFuente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.coo_Fuentes(leFuente, "-- TODAS LAS FUENTES --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_PrestamosClasificacion(leAntiguedad, "-- TODAS LAS CLASIFICACIONES --")
    End Sub

    Private Sub pre_frmAntiguedadFuente_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptAntiguedadFuente
        rpt.DataSource = bl.rptAntiguedadPorFuente(leSucursal.EditValue, leFuente.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        'rpt.xrlTipoPlazo.Text = IIf(rgPlazo.EditValue = 1, "PRÉSTAMOS A CORTO PLAZO", "PRÉSTAMOS A LARGO PLAZO")
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlClasificacion.Text = leAntiguedad.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmAntiguedadLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptAntiguedadPorFuente(leSucursal.EditValue, leFuente.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
