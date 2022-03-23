Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aho_frmListadoCuentasInactivas
    Dim blAhorro As New DBCoopBL.AhorrosBLL()



    Private Sub aho_frmListadoCuentasInactivas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFecha.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
    End Sub

    Private Sub aho_frmListadoCuentasInactivas_Reporte() Handles Me.Reporte
        Dim rpt As New aho_rptListadoCuentasInactivas
        rpt.DataSource = blAhorro.rptListadoCuentaInactivas(leSucursal.EditValue, deFecha.EditValue, leTipoCuenta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "AL " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmListadoCuentasInactivas_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptListadoCuentaInactivas(leSucursal.EditValue, deFecha.EditValue, leTipoCuenta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
