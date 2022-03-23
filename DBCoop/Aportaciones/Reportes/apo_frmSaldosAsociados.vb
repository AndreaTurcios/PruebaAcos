Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class apo_frmSaldosAsociados
    ReadOnly blAporta As New AportacionesBLL()

    Private Sub apo_frmSaldosAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.coo_TipoReporeAportacion(leTipoReporte, "")
    End Sub

    Private Sub apo_frmSaldosAsociados_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptSaldosAsociados
        rpt.DataSource = blAporta.rptSaldosAsociados(leSucursal.EditValue, leCentroCosto.EditValue, deHasta.EditValue, leTipoReporte.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        If leTipoReporte.EditValue = 1 Then
            rpt.xrlTitulo.Text = "SALDOS TOTALES DE APORTACIONES POR ASOCIADO"
        Else
            rpt.xrlTitulo.Text = "SALDOS TOTALES DE AYUDA FUNERARIA POR ASOCIADO"
        End If
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub apo_frmSaldosAsociados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptSaldosAsociados(leSucursal.EditValue, leCentroCosto.EditValue, deHasta.EditValue, leTipoReporte.EditValue), "")
    End Sub
End Class

