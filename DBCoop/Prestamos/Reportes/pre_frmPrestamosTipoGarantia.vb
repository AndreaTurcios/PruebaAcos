Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosTipoGarantia
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmPrestamosTipoGarantia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.coo_TiposGarantia(leTipoGarantia, "-- TODOS LOS TIPOS DE GARANTIA")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.adm_TipoPlazo(cboTipoPlazo, "-- CONSOLIDADO --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
    End Sub

    Private Sub pre_frmPrestamosTipoGarantia_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptPrestamosTipoGarantia
        rpt.DataSource = blPrestamo.rptPrestamosTipoGarantia(leTipoGarantia.EditValue, cboTipoPlazo.EditValue, _
        leLinea.EditValue, leFinanciamiento.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlGarantia.Text = leTipoGarantia.Text
        rpt.xrlPlazo.Text = leFinanciamiento.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmPrestamosTipoGarantia_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptPrestamosTipoGarantia(leTipoGarantia.EditValue, cboTipoPlazo.EditValue, _
        leLinea.EditValue, leFinanciamiento.EditValue, deHasta.EditValue), "")
    End Sub
End Class
