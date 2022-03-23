Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmConsolidadoCreditosVencidos
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmConsolidadoCreditosVencidos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO--")
    End Sub

    Private Sub pre_frmConsolidadoCreditosVencidos_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptConsolidadoCreditosVencidos
        rpt.DataSource = blPrestamo.rptConsolidadoCreditosVencidos(leSucursal.EditValue, leLinea.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmConsolidadoCarteraLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptConsolidadoCreditosVencidos(leSucursal.EditValue, leLinea.EditValue, deHasta.EditValue), "")
    End Sub
End Class
