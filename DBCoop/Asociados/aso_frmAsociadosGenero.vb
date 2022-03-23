Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class aso_frmAsociadosGenero
    Dim blAsoc As New AsociadosBLL()

    Private Sub apo_frmAsociadosGenero_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub

    Private Sub apo_frmAsociadosGenero_Report_Click() Handles Me.Reporte
        Dim rpt As New aso_rptAsociadosGenero
        rpt.DataSource = blAsoc.rptAsociadosGenero(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub apo_frmAportacionesFechaSexo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAsoc.rptAsociadosGenero(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
