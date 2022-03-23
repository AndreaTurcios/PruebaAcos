Imports DevExpress.XtraReports.UI
Imports DBCoopBL

Public Class apo_frmRetiroAsociados
    Dim blAporta As New AportacionesBLL()
    Dim blAsoc As New AsociadosBLL()
    Dim blAdmon As New AdmonBLL()
    Dim bl As New DBCoopBL.FuncionesBLL
    Dim blPres As New PrestamosBLL()
    Dim ds As DataSet

    Private Sub apo_frmRetiroAsociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        deFechaRetiro.EditValue = Today
    End Sub

    Private Sub apo_frmRetiroAsociados_Report_Click() Handles Me.Reporte
        Dim SaldoFiador As Decimal = 0.0
        SaldoFiador = blPres.GetSaldoAsociadoFiador(teDui.EditValue, deFechaRetiro.EditValue)
        If SaldoFiador > 0.0 Then
            MsgBox("El Asociado posee Saldo Pendiente como Fiador", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        Dim rpt As New apo_rptRetiroAsociados
        Dim FechaContable As Date = bl.GetFechaContable(gIdSucursal)

        ds = blAdmon.ObtieneCorrelativos(gIdSucursal)


        rpt.DataSource = blAporta.rptSolicitudRetiro(teIdAsociado.EditValue, FechaContable)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlMotivo.Text = teMotivo.EditValue
        rpt.xrlNumero.Text = ds.Tables(2).Rows(0).Item("UltimoValor") + 1
        rpt.xrlLugarFecha.Text = String.Format("{0}, {1}", blAdmon.ObtieneParametros.Rows(0).Item("Municipio"), FechaToString(Today, Today))
        rpt.ShowPreview()
        blAdmon.ActualizaCorrel("SOLICITUD_RETIRO", ds.Tables(2).Rows(0).Item("UltimoValor") + 1)
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
            teNombreasociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
            teDui.EditValue = .Item("NumeroDocumento")
        End With
    End Sub
End Class
