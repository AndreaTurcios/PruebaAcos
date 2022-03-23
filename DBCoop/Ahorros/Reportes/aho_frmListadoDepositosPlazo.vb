Imports DevExpress.XtraReports.UI
Imports DBCoopBL

Public Class aho_frmListadoDepositosPlazo
    Dim blAhorro As New AhorrosBLL()
    

    Private Sub aho_frmListadoDepositosPlazo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCuentaPlazo(leTipoCuenta, "-- TODOS LOS DEPOSITOS A PLAZO --")
        objCombos.adm_EstadoSocio(leTipoCliente, "-- TODOS LOS TIPOS DE ASOCIADO --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub

    Private Sub aho_frmListadoDepositosPlazo_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptListadoDepositosPlazo
        rpt.DataSource = blAhorro.rptListadoDepositosPlazo(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub aho_frmListadoDepositosPlazo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptListadoDepositosPlazo(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leTipoCliente.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
