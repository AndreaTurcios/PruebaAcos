Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosSaldosFacturas
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmPrestamosTipoCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptPrestamosSaldosFacturas
        rpt.DataSource = blPrestamo.rptPrestamosSaldosFacturas(leLinea.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptPrestamosSaldosFacturas(leLinea.EditValue, deHasta.EditValue), "")
    End Sub
End Class
