Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmConsolidadoCarteraLinea
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmConsolidadoCarteraLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO--")
    End Sub

    Private Sub pre_frmConsolidadoCarteraLinea_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptConsolidadoCarteraLinea
        rpt.DataSource = blPrestamo.rptConsolidadoCarteraLinea(leSucursal.EditValue, leLinea.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmConsolidadoCarteraLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptConsolidadoCarteraLinea(leSucursal.EditValue, leLinea.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
