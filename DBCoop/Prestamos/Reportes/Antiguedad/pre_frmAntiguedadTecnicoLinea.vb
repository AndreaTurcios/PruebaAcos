Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmAntiguedadTecnicoLinea
    Dim bl As New PrestamosBLL()


    Private Sub pre_frmAntiguedadTecnicoLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.coo_Tecnicos(leTecnico, "TODOS LOS TECNICOS")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LÍNEAS --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_PrestamosClasificacion(leAntiguedad, "-- TODAS LAS CLASIFICACIONES --")
    End Sub

    Private Sub pre_frmAntiguedadLinea_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptAntiguedadTecnicoLinea
        rpt.DataSource = bl.rptAntiguedadTecnicoLinea(leSucursal.EditValue, leTecnico.EditValue, leLinea.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " + (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.xrlNombreTecnico.Text = leTecnico.Text
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlClasificacion.Text = leAntiguedad.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmAntiguedadLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptAntiguedadTecnicoLinea(leSucursal.EditValue, leTecnico.EditValue, leLinea.EditValue, leAntiguedad.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
