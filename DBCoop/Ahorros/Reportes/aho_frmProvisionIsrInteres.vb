Imports DevExpress.XtraReports.UI
Imports DBCoopBL


Public Class aho_frmProvisionIsrInteres
    Dim blAhorro As New AhorrosBLL()
    

    Private Sub aho_frmProvisionIsrInteres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub aho_frmProvisionIsrInteres_Report_Click() Handles Me.Reporte
        Dim dt As DataTable = blAhorro.rptProvisionIsr(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue)
        If dt.Rows.Count < 1 Then
            MsgBox("No existen datos para Generar Reporte", MsgBoxStyle.Critical, "Advertencia")
            Exit Sub
        End If
        Dim rpt As New aho_rptProvisionIsr
        rpt.DataSource = dt
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlReporte.Text = "INFORME DE IMPUESTO SOBRE LA RENTA PROVISIONADO POR INTERESES"
        rpt.xrlTitulo.Text = String.Format("Correspondiente al mes de {0} de {1}", MonthEdit1.Text, SpinEdit1.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmProvisionIsrInteres_ReporteExcel() Handles Me.ReporteExcel
        Dim dt As DataTable = blAhorro.rptProvisionIsr(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue)
        DataTableToExcel(dt, "")
    End Sub
End Class
