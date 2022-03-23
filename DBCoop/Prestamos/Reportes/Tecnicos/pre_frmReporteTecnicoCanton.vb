Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmReporteTecnicoCanton
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmReporteTecnicoCanton_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.adm_Cantones(leCanton, "", "-- TODAS LAS COMUNIDADES --")
    End Sub

    Private Sub pre_frmReporteTecnicoCanton_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptTecnicoCanton
        rpt.DataSource = blPrestamo.rptDetalleCarteraTecnicoCanton(leSucursal.EditValue, leTecnico.EditValue, leCanton.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmReporteTecnicoCanton_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptDetalleCarteraTecnicoCanton(leSucursal.EditValue, leTecnico.EditValue, leTecnico.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
