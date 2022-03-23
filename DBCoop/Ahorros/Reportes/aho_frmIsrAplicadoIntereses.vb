Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmIsrAplicadoIntereses
    Dim blAhorro As New AhorrosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()

    Private Sub aho_frmIsrAplicadoIntereses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub aho_frmIsrAplicadoIntereses_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptProvisionIsr
        rpt.DataSource = blAhorro.rptIsrAplicadoInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlReporte.Text = "INFORME DE IMPUESTO SOBRE LA RENTA CALCULADO A INTERESES"
        rpt.xrlTitulo.Text = "Correspondiente al mes de " & MonthEdit1.Text & " de " & SpinEdit1.EditValue
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub



    Private Sub aho_frmIsrAplicadoIntereses_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptIsrAplicadoInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue), "")
    End Sub
End Class
