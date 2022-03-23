Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmAplicacionPlanillaConsolidada
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()
    Dim blAsoc As New DBCoopBL.AsociadosBLL()

    Private Sub pre_frmListadoDescuentosPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFechaContable.EditValue = Today
        deHasta.EditValue = Today
        objCombos.adm_TiposPlanilla(leTipoPlanilla, "-- TODAS LAS PLANILLAS --")
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptAplicacionPlanillaConsolidada
        rpt.DataSource = blPrestamo.rptListadoAplicacionPlanillaConsolidado(-1, deFechaContable.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlPlanilla.Text = "INCLUYE TODAS LAS PLANILLAS" '"Planilla: " + leTipoPlanilla.Text
        rpt.xrlFecha.Text = "Fecha de Aplicación: " + FechaToString(deFechaContable.EditValue, deFechaContable.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoDescuentosPrestamos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoAplicacionPlanillaConsolidado(leTipoPlanilla.EditValue, deFechaContable.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbMuestra.Click
        deFechaContable.EditValue = objConsultas.ConsultaPlanillasAplicadas(frmConsultas)
        deHasta.EditValue = blPrestamo.FechaPlanilla(deFechaContable.EditValue)
    End Sub
End Class
