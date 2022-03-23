Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosRegistrados
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmPrestamosRegistrados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Lineas(cboLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
        ceExcluir.EditValue = True
    End Sub

    Private Sub pre_frmPrestamosRegistrados_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptPrestamosRegistrados
        rpt.DataSource = blPrestamo.rptPrestamosRegistrados(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deDesde.EditValue, deHasta.EditValue, ceExcluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = (FechaToString(deDesde.EditValue, deHasta.EditValue)).ToUpper()
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlLinea.Text = cboLinea.Text
        rpt.xrlTecnico.Text = leTecnico.Text
        rpt.xrlFuente.Text = leFinanciamiento.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmPrestamosRegistrados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptPrestamosRegistrados(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deDesde.EditValue, deHasta.EditValue, ceExcluir.EditValue), "")
    End Sub
End Class
