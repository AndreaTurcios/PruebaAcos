Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class apo_frmEstadoCuentaAyuda
    Dim blAporta As New AportacionesBLL()
    Dim blAsoc As New AsociadosBLL()

    Private Sub apo_frmEstadoCuentaAportacion_Report_Click() Handles Me.Reporte
        If teIdAsociado.EditValue = 0 Then
            MsgBox("No se ha especificado el número de asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        Dim rpt As New apo_rptEstadoCuentaAyuda
        rpt.DataSource = blAporta.rptEstadoCuentaAyuda(teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlPeriodo.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub apo_frmEstadoCuentaAportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deDesde.EditValue = Today
        deHasta.EditValue = Today
        teIdAsociado.EditValue = 0
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

    Private Sub apo_frmEstadoCuentaAportacion_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptEstadoCuentaAyuda(teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
