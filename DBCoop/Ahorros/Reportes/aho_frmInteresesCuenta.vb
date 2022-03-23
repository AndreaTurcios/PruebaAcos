Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmInteresesCuenta
    Dim blAhorro As New DBCoopBL.AhorrosBLL()
    Dim blCaja As New DBCoopBL.TableBusiness()
    Dim funCaja As New DBCoopBL.FuncionesBLL()
    Dim cn As New DBCoopBL.AdmonBLL()


    Private Sub aho_frmInteresesCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
    End Sub

    Private Sub aho_frmInteresesCuenta_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptInteresCuentaCapitalizado
        rpt.DataSource = blAhorro.rptInteresCuentaCapitalizado(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmInteresesCuenta_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptInteresCuentaCapitalizado(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
