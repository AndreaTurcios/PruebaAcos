Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class aho_frmReporteCapitalizacion
    Dim blAhorro As New DBCoopBL.AhorrosBLL()
    Dim blCaja As New DBCoopBL.TableBusiness()
    Dim funCaja As New DBCoopBL.FuncionesBLL()
    Dim cn As New DBCoopBL.AdmonBLL()


    Private Sub aho_frmReporteCapitalizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub aho_frmReporteCapitalizacion_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptListadoCapitalizacionInteres
        rpt.DataSource = blAhorro.rptListadoCapitalizacionInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = String.Format("Correspondiente al mes de {0} de {1}", MonthEdit1.Text, SpinEdit1.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmReporteCapitalizacion_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptListadoCapitalizacionInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
