Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmListadoGeneralPagos
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmListadoGeneralPagos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Tecnicos(leTecnico, "-- TODOS LOS TECNICOS --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
        objCombos.coo_FormasPagoCaja(cboForma, "-- TODAS LAS FORMAS DE PAGO --")
    End Sub

    Private Sub pre_frmListadoGeneralPagos_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptListadoGeneralPagos
        rpt.DataSource = blPrestamo.rptListadoGeneralPagos(leSucursal.EditValue, leTecnico.EditValue, _
        leFinanciamiento.EditValue, cboForma.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlTecnico.Text = leTecnico.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoGeneralPagos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoGeneralPagos(leSucursal.EditValue, leTecnico.EditValue, _
        leFinanciamiento.EditValue, cboForma.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
