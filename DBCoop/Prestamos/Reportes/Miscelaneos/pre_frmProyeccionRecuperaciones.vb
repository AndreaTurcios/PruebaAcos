Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmProyeccionRecuperaciones
    Dim bl As New PrestamosBLL()


    Private Sub pre_frmProyeccionRecuperaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub pre_frmProyeccionRecuperaciones_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptProyeccionRecuperaciones
        rpt.DataSource = bl.rptProyeccionRecuperaciones(leSucursal.EditValue, SpinEdit1.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "CORRESPONDIENTE AL AÑO:" & SpinEdit1.Text
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmProyeccionRecuperaciones_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptProyeccionRecuperaciones(leSucursal.EditValue, SpinEdit1.EditValue), "")
    End Sub

End Class
