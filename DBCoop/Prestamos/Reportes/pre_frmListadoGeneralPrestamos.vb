Imports DevExpress.XtraReports.UI
Public Class pre_frmListadoGeneralPrestamos
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()


    Private Sub pre_frmListadoGeneralPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Lineas(cboLinea, "-- TODAS LAS LINEAS DE CREDITO --")
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.coo_Fuentes(leFinanciamiento, "-- TODAS LAS FUENTES DE FINANCIAMIENTO --")
    End Sub

    Private Sub pre_frmListadoGeneralPrestamos_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptListadoGeneralPrestamos
        rpt.DataSource = blPrestamo.rptListadoGeneralPrestamos(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        If chkIncluir.EditValue = True Then
            rpt.xrlTitulo.Text = "Incluye Préstamos Cancelados"
        Else
            rpt.xrlTitulo.Text = "No Incluye Préstamos Cancelados"
        End If
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlLinea.Text = cboLinea.Text
        rpt.xrlTecnico.Text = leTecnico.Text
        rpt.xrlFuente.Text = leFinanciamiento.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoGeneralPrestamos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoGeneralPrestamos(leSucursal.EditValue, cboLinea.EditValue, _
        leTecnico.EditValue, leFinanciamiento.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
