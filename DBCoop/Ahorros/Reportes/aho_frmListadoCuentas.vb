Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmListadoCuentas
    Dim blAhorro As New AhorrosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()


    Private Sub aho_frmListadoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFecha.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
        objCombos.aso_TiposRelacion(leTipoCliente, "-- TODOS --")
    End Sub

    Private Sub aho_frmListadoCuentas_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptListadoCuentasGeneral
        rpt.DataSource = blAhorro.rptListadoCuentaAhorro(leSucursal.EditValue, deFecha.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "AL " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmListadoCuentas_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptListadoCuentaAhorro(leSucursal.EditValue, deFecha.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
