Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmDetalleCarteraLinea
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmDetalleCarteraLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
    End Sub

    Private Sub pre_frmDetalleCarteraLinea_Reporte() Handles Me.Reporte
        Dim ds As DataSet = blPrestamo.rptDetalleGeneralCarteraLinea(leSucursal.EditValue, leLinea.EditValue, leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        Dim rpt As New pre_rptDetalleCarteraLinea
        rpt.DataSource = ds.Tables(0)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue).ToUpper()
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.xrlSucursal.Text = leSucursal.Text
        Dim Saldo As Decimal, Mora As Decimal
        Saldo = ds.Tables(1).Rows(0).Item("SaldoCapital")
        Mora = ds.Tables(1).Rows(0).Item("CapitalMora")
        If Mora > 0 Then
            rpt.xrlPorcMora.Text = Format(Decimal.Round(Mora / Saldo * 100, 2), "##0.00")
        End If
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub pre_frmDetalleCarteraLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptDetalleGeneralCarteraLinea(leSucursal.EditValue, leLinea.EditValue, _
leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue).Tables(0), "")
    End Sub
End Class
