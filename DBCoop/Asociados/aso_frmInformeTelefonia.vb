Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class aso_frmInformeTelefonia
    Dim blAso As New AsociadosBLL()
    Private Sub apo_frmListadoAspirantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.aso_TipoReporteTelefonia(leTipoReporte)
    End Sub

    Private Sub apo_frmListadoAspirantes_Report_Click() Handles Me.Reporte
        If leTipoReporte.EditValue = 1 Then
            Dim rpt As New aso_rptHistoricoTelefonia
            rpt.DataSource = blAso.aso_HistoricoSaldosTelefonia(teIdAsociado.EditValue, TeNTelefono.EditValue, deDesde.EditValue, deHasta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlTitulo.Text = leTipoReporte.Text
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New aso_rptListadoTelefoniaSaldos
            rpt.DataSource = blAso.aso_ListadoSaldosAsociados()
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlTitulo.Text = leTipoReporte.Text
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub aso_frmListadoAspirantes_ReporteExcel() Handles Me.ReporteExcel
        If leTipoReporte.EditValue = 1 Then

        Else
            DataTableToExcel(blAso.aso_ListadoSaldosAsociados(), "")
        End If
    End Sub

    Private Sub teNumAsociado_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub teNumAsociado_Validated(sender As Object, e As EventArgs) Handles teNumAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            Exit Sub
        End If
        If teIdAsociado.EditValue = 0 Then
            Exit Sub
        End If
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        If entAsociados.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        teIdAsociado.EditValue = entAsociados.IdAsociado
        teNombreAsociado.EditValue = entAsociados.Nombres + " " + entAsociados.Apellidos
    End Sub
End Class
