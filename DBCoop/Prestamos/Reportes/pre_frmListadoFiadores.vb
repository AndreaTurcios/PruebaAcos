Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class pre_frmListadoFiadores
    Dim blPrestamo As New PrestamosBLL()
    Dim blCaja As New TableBusiness()
    
    Private Sub pre_frmListadoFiadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
btDuiFiador.EditValue=""
teIdAsociado.editvalue=0
teNumAsociado.editvalue=""
    End Sub

    Private Sub pre_frmListadoFiadores_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptListadoFiadores
        rpt.DataSource = blPrestamo.rptListadoFiadores(btDuiFiador.EditValue, teIdAsociado.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
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
        If teIdAsociado.EditValue = 0 Then
            Exit Sub
        End If

        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        ' Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)

        If entAsociados.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If


        teIdAsociado.EditValue = entAsociados.IdAsociado
        teNombreCliente.EditValue = entAsociados.Nombres + " " + entAsociados.Apellidos
    End Sub

    Private Sub btDuiFiador_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btDuiFiador.MouseClick
        If btDuiFiador.Text = "" Then
            btDuiFiador.EditValue = objConsultas.ConsultaFiadores(frmConsultas)
        End If
        btDuiFiador_Validating(e, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub btDuiFiador_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles btDuiFiador.Validating
        If btDuiFiador.Text = "" Then
            e.Cancel = False
            Exit Sub
        End If
        Dim EntFiador As coo_GarantiasFiador = blPrestamo.coo_FiadoresSelectByDui(btDuiFiador.EditValue)
        If EntFiador.NombresApellidos = "" Then
            e.Cancel = True
            Exit Sub
        End If
        With EntFiador
            teFiador.EditValue = .NombresApellidos
        End With
    End Sub

    Private Sub pre_frmListadoFiadores_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoFiadores(btDuiFiador.EditValue, teIdAsociado.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
