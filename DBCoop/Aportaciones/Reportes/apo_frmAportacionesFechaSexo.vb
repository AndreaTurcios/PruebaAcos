Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class apo_frmAportacionesFechaSexo
    Dim blAporta As New AportacionesBLL()


    Private Sub apo_frmAportacionesFechaSexo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub

    Private Sub apo_frmAportacionesFechaSexo_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptAportacionFechaSexo
        rpt.DataSource = blAporta.rptAportacionesFechaSexo(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub apo_frmAportacionesFechaSexo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptAportacionesFechaSexo(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub


End Class
