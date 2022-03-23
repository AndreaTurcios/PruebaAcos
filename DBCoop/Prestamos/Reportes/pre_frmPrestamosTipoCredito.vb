Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosTipoCredito
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmPrestamosTipoCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.coo_TipoCredito(leTipoCredito, "-- TODOS LOS TIPOS DE CRÉDITO")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptPrestamosTipoCredito
        rpt.DataSource = blPrestamo.rptPrestamosTipoCredito(leTipoCredito.EditValue, _
        leLinea.EditValue, leFinanciamiento.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCredito.Text = leTipoCredito.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptPrestamosTipoCredito(leTipoCredito.EditValue, _
        leLinea.EditValue, leFinanciamiento.EditValue, deHasta.EditValue), "")
    End Sub
End Class
