Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmReportesAuditoria
    Dim bl As New PrestamosBLL
    Private Sub pre_frmReportesAuditoria_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        deDesde.EditValue = CDate(String.Format("01/{0}/{1}", CStr(Today.Month), CStr(Today.Year)))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub

    Private Sub pre_frmReportesAuditoria_Reporte() Handles Me.Reporte
        Dim Tit As String = String.Format("{0} {1}", FechaToString(deDesde.EditValue, deHasta.EditValue).ToUpper(), leSucursal.Text)
        Select Case RadioGroup1.EditValue
            Case 0
                Dim rpt As New pre_rptAuditoria1
                rpt.DataSource = bl.rptInformeAuditoria1(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
            Case 1
                Dim rpt As New pre_rptAuditoria2
                rpt.DataSource = bl.rptInformeAuditoria2(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
            Case 2
                Dim rpt As New pre_rptAuditoria3
                rpt.DataSource = bl.rptInformeAuditoria3(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
            Case 3
                Dim rpt As New pre_rptAuditoria4
                rpt.DataSource = bl.rptInformeAuditoria4(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
            Case 4
                Dim rpt As New pre_rptAuditoria5
                rpt.DataSource = bl.rptInformeAuditoria5(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
            Case 5
                Dim rpt As New pre_rptAuditoria6
                rpt.DataSource = bl.rptInformeAuditoria6(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, teValor.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlPeriodo.Text = Tit
                rpt.ShowPreviewDialog()
        End Select
    End Sub

    Private Sub pre_frmReportesAuditoria_ReporteExcel() Handles Me.ReporteExcel
        Select Case RadioGroup1.EditValue
            Case 0
                DataTableToExcel(bl.rptInformeAuditoria1(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
            Case 1
                DataTableToExcel(bl.rptInformeAuditoria2(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
            Case 2
                DataTableToExcel(bl.rptInformeAuditoria3(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
            Case 3
                DataTableToExcel(bl.rptInformeAuditoria4(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
            Case 4
                DataTableToExcel(bl.rptInformeAuditoria5(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue), "")
            Case 5
                DataTableToExcel(bl.rptInformeAuditoria6(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, teValor.EditValue), "")
        End Select
    End Sub

    Private Sub RadioGroup1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioGroup1.EditValueChanged
        teValor.Visible = RadioGroup1.EditValue = 5
        LabelControl5.Visible = RadioGroup1.EditValue = 5
    End Sub
End Class
