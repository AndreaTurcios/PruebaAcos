Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmDetalleCarteraComunidad
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmDetalleCarteraComunidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        objCombos.adm_Cantones(leCanton, "", "-- TODAS LAS COMUNIDADES --")
    End Sub

    Private Sub pre_frmDetalleCarteraComunidad_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptDetalleCarteraComunidad
        rpt.DataSource = blPrestamo.rptDetalleCarteraCanton(leSucursal.EditValue, leCanton.EditValue, leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmDetalleCarteraComunidad_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptDetalleCarteraCanton(leSucursal.EditValue, leCanton.EditValue, leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
