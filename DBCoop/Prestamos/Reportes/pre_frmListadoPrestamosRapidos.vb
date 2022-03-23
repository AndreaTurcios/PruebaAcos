Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmListadoPrestamosRapidos
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()

    Private Sub pre_frmListadoDescuentosPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = Today
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptListadoPrestamosRapidos
        rpt.DataSource = blPrestamo.rptListadoLiquidacionCaja(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "COBRO DE PRESTAMOS AUTOMÁTICOS"
        rpt.xrlSucursal.Text = "SUCURSAL/DEPARTAMENTO: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text

        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoDescuentosPrestamos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoLiquidacionCaja(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
