Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmClientesPorTecnico
    Dim bl As New PrestamosBLL()

    Private Sub pre_frmClientesPorTecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        deHasta.EditValue = Today
    End Sub

    Private Sub pre_frmClientesPorTecnico_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptClientesPorTecnico
        rpt.DataSource = bl.rptPrestamosPorTecnico(leSucursal.EditValue, leTecnico.EditValue, deHasta.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub pre_frmClientesPorTecnico_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptPrestamosPorTecnico(leSucursal.EditValue, leTecnico.EditValue, deHasta.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
