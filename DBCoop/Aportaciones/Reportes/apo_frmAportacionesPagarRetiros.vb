Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class apo_frmAportacionesPagarRetiros
    Dim blAporta As New AportacionesBLL()


    Private Sub apo_frmAportacionesPagarRetiros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = Today
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub

    Private Sub apo_frmAportacionesPagarRetiros_Report_Click() Handles Me.Reporte

        Dim rpt As New apo_rptAportacionesPagarRetiros
        rpt.DataSource = blAporta.rptAportacionesPorPagarRetiroTotal(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub apo_frmAportacionesPagarRetiros_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptAportacionesPorPagarRetiroTotal(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
