Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAyudaFuneraria
    Dim blAporta As New DBCoopBL.AportacionesBLL()
    Dim blAsoc As New DBCoopBL.AsociadosBLL()

    Private Sub apo_frmListadoIngresosAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        teIdAsociado.EditValue = 0
    End Sub
    Private Sub apo_frmListadoIngresosAsociados_Report_Click() Handles Me.Reporte

        If teIdAsociado.EditValue = 0 Then
            MsgBox("Debe de especificar el número del asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim rpt As New aso_rptListadoAyudaFuneraria
        rpt.DataSource = blAporta.rptListadoAyudaFuneraria(teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE AYUDA FUNERARIA POR ASOCIADO"
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            Exit Sub
        End If

        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
            teDui.EditValue = .Item("NumeroDocumento")
        End With
    End Sub
    Private Sub aso_frmListadoIngresosAsociados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAyudaFuneraria(teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
