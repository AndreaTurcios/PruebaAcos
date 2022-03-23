Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmListadoCuentasMesTipo
    Dim blAhorro As New AhorrosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()

    Private Sub aho_frmListadoCuentasMesTipo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.aso_TiposRelacion(leTipoCliente, "-- TODOS --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub aho_frmListadoCuentasMesTipo_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptListadoCuentasGeneral
        rpt.DataSource = blAhorro.rptListadoCuentaMesTipo(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = ("Correspondiente al mes de " & MonthEdit1.Text & " de " & SpinEdit1.EditValue).ToString.ToUpper()
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub aho_frmListadoCuentasMesTipo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptListadoCuentaMesTipo(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, chkIncluir.EditValue), "")
    End Sub

    Private Sub LabelControl5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl5.Click

    End Sub

    Private Sub leCentroCosto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leCentroCosto.EditValueChanged

    End Sub
End Class
