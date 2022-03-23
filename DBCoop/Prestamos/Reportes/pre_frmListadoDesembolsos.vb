Imports DevExpress.XtraReports.UI
Imports DBCoopBL

Public Class pre_frmListadoDesembolsos
    Dim blPrestamo As New PrestamosBLL()
    
    Private Sub pre_frmListadoDesembolsos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Lineas(cboLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
        ceIncluye.EditValue = False
    End Sub

    Private Sub pre_frmListadoDesembolsos_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptListadoDesembolsos
        rpt.DataSource = blPrestamo.rptListadoDesembolsos(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deDesde.EditValue, deHasta.EditValue, ceIncluye.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlTecnico.Text = leTecnico.Text
        rpt.xrlFuente.Text = leFinanciamiento.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoDesembolsos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoDesembolsos(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deDesde.EditValue, deHasta.EditValue, ceIncluye.EditValue), "")
    End Sub
End Class
