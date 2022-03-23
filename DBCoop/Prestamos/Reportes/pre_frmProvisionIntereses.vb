Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmProvisionIntereses
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmProvisionIntereses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub


    Private Sub pre_frmProvisionIntereses_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptProvisionIntereses
        rpt.DataSource = blPrestamo.rptProvisionIntereses(leSucursal.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmProvisionIntereses_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptProvisionIntereses(leSucursal.EditValue, deHasta.EditValue), "")
    End Sub

End Class
