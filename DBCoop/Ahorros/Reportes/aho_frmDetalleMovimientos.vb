Imports DevExpress.XtraReports.UI
Imports DBCoopBL

Public Class aho_frmDetalleMovimientos
    Dim blAhorro As New AhorrosBLL()
    
    Private Sub aho_frmDetalleMovimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub

    Private Sub aho_frmDetalleMovimientos_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptDetalleMovimientos
        rpt.DataSource = blAhorro.rptDetalleMovimientos(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlDesde.Text = deDesde.EditValue
        rpt.xrlHasta.Text = deHasta.EditValue
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmDetalleMovimientos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptDetalleMovimientos(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
