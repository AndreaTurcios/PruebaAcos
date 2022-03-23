Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmDetalleGeneralCartera
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmDetalleGeneralCartera_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
        objCombos.adm_Cantones(leCanton, "", "-- TODAS LAS COMUNIDADES --")
    End Sub

    Private Sub pre_frmDetalleGeneralCartera_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptDetalleGeneralCartera
        rpt.DataSource = blPrestamo.rptDetalleGeneralCartera(leSucursal.EditValue, leLinea.EditValue, _
        leFinanciamiento.EditValue, leCanton.EditValue, leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper()
        rpt.xrlTipoCredito.Text = leTipoCartera.Text
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmDetalleGeneralCartera_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptDetalleGeneralCartera(leSucursal.EditValue, leLinea.EditValue, _
        leFinanciamiento.EditValue, leCanton.EditValue, leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
