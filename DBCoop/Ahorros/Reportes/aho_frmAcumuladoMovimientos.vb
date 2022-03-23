﻿Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmAcumuladoMovimientos
    Dim blAhorro As New AhorrosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()


    Private Sub aho_frmAcumuladoMovimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
    End Sub

    Private Sub aho_frmAcumuladoMovimientos_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptAcumuladoMovimientos
        rpt.DataSource = blAhorro.rptAcumuladoMovimientos(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmAcumuladoMovimientos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptAcumuladoMovimientos(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
