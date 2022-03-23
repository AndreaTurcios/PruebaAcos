
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmInformeAseguradora
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmInformeAseguradora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_TiposModulo(leTipoReporte, "")
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES--")
    End Sub

    Private Sub pre_frmInformeAseguradora_Reporte() Handles Me.Reporte
        If leTipoReporte.EditValue = 1 Then
            Dim rpt As New pre_rptInformeAseguradora
            rpt.DataSource = blPrestamo.rptInformeAseguradora(deHasta.EditValue, leSucursal.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        End If
        If leTipoReporte.EditValue = 2 Then
            Dim rpt As New pre_rptInformeAseguradoraAportacion
            rpt.DataSource = blPrestamo.rptInformeAseguradoraAportacion(deHasta.EditValue, leSucursal.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        End If
        If leTipoReporte.EditValue = 3 Then
            Dim rpt As New pre_rptInformeAseguradoraAportacion
            If MsgBox("Desea Incluir las cuentas a Plazo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "?") = MsgBoxResult.Yes Then
                rpt.DataSource = blPrestamo.rptInformeAseguradoraAhorro(deHasta.EditValue, leSucursal.EditValue, True)
            Else
                rpt.DataSource = blPrestamo.rptInformeAseguradoraAhorro(deHasta.EditValue, leSucursal.EditValue, False)
            End If
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlTitulo.Text = "AHORROS ASEGURADOS"
            rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        End If

    End Sub


    Private Sub pre_frmInformeAseguradora_ReporteExcel() Handles Me.ReporteExcel
        If leTipoReporte.EditValue = 1 Then
            DataTableToExcel(blPrestamo.rptInformeAseguradora(deHasta.EditValue, leSucursal.EditValue), "")
        End If
        If leTipoReporte.EditValue = 2 Then
            DataTableToExcel(blPrestamo.rptInformeAseguradoraAportacion(deHasta.EditValue, leSucursal.EditValue), "")
        End If
        If leTipoReporte.EditValue = 3 Then
            If MsgBox("Desea Incluir las cuentas a Plazo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "?") = MsgBoxResult.Yes Then
                DataTableToExcel(blPrestamo.rptInformeAseguradoraAhorro(deHasta.EditValue, leSucursal.EditValue, True), "")
            Else
                DataTableToExcel(blPrestamo.rptInformeAseguradoraAhorro(deHasta.EditValue, leSucursal.EditValue, False), "")
            End If
        End If

    End Sub
End Class
