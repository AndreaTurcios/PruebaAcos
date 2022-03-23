Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmConsolidadoGeneralCartera
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmConsolidadoGeneralCartera_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
    End Sub

    Private Sub pre_frmConsolidadoGeneralCartera_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptConsolidadoGeneralCartera
        rpt.DataSource = blPrestamo.rptConsolidadoGeneralCartera(leSucursal.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmConsolidadoGeneralCartera_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptConsolidadoGeneralCartera(leSucursal.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
