Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Text
Imports System
Imports System.IO
Imports System.Net.Mail

Public Class aso_frmEstadoCuentaGeneral
    Dim blAporta As New AportacionesBLL()
    Dim blAsoc As New AsociadosBLL()
    Dim myBL As New AdmonBLL
    Dim dtParam As DataTable = myBL.ObtieneParametros()
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)



    Private Sub apo_frmEstadoCuentaAportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        deFecha.EditValue = Today
        teIdAsociado.EditValue = 0
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If teIdAsociado.EditValue = 0 Then
            teIdAsociado.EditValue = 0
            teNombreAsociado.EditValue = ""
        End If
        If teNumAsociado.EditValue = "" Then
            teIdAsociado.EditValue = 0
            teNombreAsociado.EditValue = ""
        End If
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        If entAsociados.IdAsociado = 0 And teNumAsociado.EditValue <> "" Then
            teIdAsociado.EditValue = 0
            teNombreAsociado.EditValue = ""
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If


        teIdAsociado.EditValue = entAsociados.IdAsociado
        teNombreAsociado.EditValue = entAsociados.Nombres + " " + entAsociados.Apellidos
    End Sub

    Private Sub apo_frmEstadoCuentaAportacion_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptEstadoCuentaAportacion(teIdAsociado.EditValue, deFecha.EditValue), "")
    End Sub
    Private Sub apo_frmEstadoCuentaAportacion_Report_Click() Handles Me.Reporte
        'If teIdAsociado.EditValue = 0 Then
        '    MsgBox("No se ha especificado el número de asociado", MsgBoxStyle.Exclamation, "Nota")
        '    Exit Sub
        'End If

        Dim rpt As New aso_rptEstadoCuentaGeneral

        rpt.DataSource = blAporta.rptEstadoCuentaGeneral(teIdAsociado.EditValue, deFecha.EditValue, False, False)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlHastaFecha.Text = "SALDOS HASTA LA FECHA: " + Format(deFecha.EditValue, "dd/MM/yyyy")
        rpt.xrlEncargadoCoop.Text = entSucursal.Responsable
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.xrlNotas.Text = meComentario.EditValue
        rpt.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim dtAsociados As New DataTable
        Dim dt As New DataTable
        Dim IdAsociado As Integer = -1
        Dim msj As String = ""
        If teIdAsociado.EditValue > 0 Then
            IdAsociado = teIdAsociado.EditValue
        End If

        dtAsociados = blAporta.rptEstadoCuentaGeneral(teIdAsociado.EditValue, deFecha.EditValue, True, False)

        For Each row As DataRow In dtAsociados.Rows
            Dim mensaje As New StringBuilder()
            Dim TotalIngresos As Decimal = 0.0
            Dim TotalDescuentos As Decimal = 0.0
            dt = blAporta.rptEstadoCuentaGeneral(row("IdAsociado"), deFecha.EditValue, False, True)
            Dim sAsunto As String = "Estado de Cuenta Consolidaddo " & row("Nombre") & " , a Fecha: " & Format(deFecha.EditValue, "dd/MM/yyyy")
            mensaje.AppendLine("<center>")
            mensaje.AppendLine("<h2>" & gsNombre_Empresa & "</h2>")
            mensaje.AppendLine("<br>")
            mensaje.AppendLine("<h3>ESTADO DE CUENTA CONSOLIDADO</h3>")
            mensaje.AppendLine("<br>")
            mensaje.AppendLine("<h3>" & "SALDOS HASTA LA FECHA: " & (FechaToString(deFecha.EditValue, deFecha.EditValue)).ToUpper() & "</h3>")
            mensaje.AppendLine("</center>")
            mensaje.AppendLine("<table border='0' style='width: 80%; margin: 0 auto;'>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h4> No. de Asociado: " & row("Nombre") & "</h4>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h4> Nombre: " & row("Nombre") & "</h4>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h4> Teléfono: " & row("Telefonos") & "</h4>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h4> Dirección: " & row("Direccion") & "</h4>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h4> Fecha de Ingreso: " & (FechaToString(row("FechaIngreso"), row("FechaIngreso")).ToUpper()) & "</h4>")
            mensaje.AppendLine("</table>")

            mensaje.AppendLine("<table border='1' style='width: 80%; margin: 0 auto;'>")
            mensaje.AppendLine("<tr><td style='text-align: center;color: #fff;background-color: #000;'><h3> AHORROS PERSONALES DEL ASOCIADO </h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3> VALOR </h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3> SALDOS DE PRÉSTAMOS OTORGADOS </h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3> VALOR </h3></td></tr>")

            For Each row2 As DataRow In dt.Rows
                If row2("Valor") > 0.0 Or row2("abValor") > 0.0 Then
                    mensaje.AppendLine("<tr><td style='text-align: left'><h4>" & row2("abNombre") & "</h4></td>")
                    mensaje.AppendLine("<td style='text-align: left'><h4>" & Format(CDec(row2("abValor")), "##,##0.00") & " </h4></td>")
                    mensaje.AppendLine("<td style='text-align: left'><h4>" & row2("Nombre") & "</h4></td>")
                    mensaje.AppendLine("<td style='text-align: left'><h4>" & Format(CDec(row2("Valor")), "##,##0.00") & "</h4></td></tr>")
                    TotalIngresos = TotalIngresos + SiEsNulo(row2("abValor"), 0.0)
                    TotalDescuentos = TotalDescuentos + SiEsNulo(row2("Valor"), 0.0)
                End If
            Next
            mensaje.AppendLine("<tr><td style='text-align: center;color: #fff;background-color: #000;'><h3> TOTAL AHORROS: </h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3>" & Format(CDec(TotalIngresos), "##,##0.00") & "</h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3> TOTAL SALDOS PRÉSTAMOS </h3></td>")
            mensaje.AppendLine("<td style='text-align: center;color: #fff;background-color: #000;'><h3>" & Format(CDec(TotalDescuentos), "##,##0.00") & "</h3></td></tr>")
            mensaje.AppendLine("</table>")
            mensaje.AppendLine("<br>")

            mensaje.AppendLine("<table border='1' style='width: 80%; margin: 0 auto;'>")
            mensaje.AppendLine("<tr><td style='text-align: left'><h2> SALDO DISPONIBLE  US$: </h2>")
            mensaje.AppendLine("<td style='text-align: left'><h2>" & Format(CDec(TotalIngresos - TotalDescuentos), "##,##0.00") & "</h2></td></tr>")
            mensaje.AppendLine("</table>")
            'EnviarCorreo(mensaje, row("CorreoElectronico"), sAsunto)
            'msj = msj & EnviarCorreo(mensaje, row("CorreoElectronico"), sAsunto)
            pbcPorcentaje.PerformStep()
            pbcPorcentaje.Update()
        Next
        If msj = "" Then
            MessageBox.Show("Correos enviados exitosamente", "Exito!", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Error en envio de Correos", "Exito!", MessageBoxButtons.OK)
        End If
        Close()

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If teIdAsociado.EditValue = 0 Then
            If MsgBox("Está seguro(a) de enviar masivamente por e-mail los estados de cuenta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            If MsgBox("Está seguro(a) de enviar por e-mail el estado de cuenta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        Dim dtAsociados As New DataTable
        Dim dt As New DataTable
        Dim IdAsociado As Integer = -1
        Dim msj As String = ""
        Dim Mensaje As String = "Estado de Cuenta Consolidado " & gsNombre_Empresa & " a Fecha: " + Format(deFecha.EditValue, "dd/MM/yyyy")
        If teIdAsociado.EditValue > 0 Then
            IdAsociado = teIdAsociado.EditValue
        End If

        dtAsociados = blAporta.rptEstadoCuentaGeneral(teIdAsociado.EditValue, deFecha.EditValue, True, False)

        For Each row As DataRow In dtAsociados.Rows
            'If row("CorreoElectronico") = "" Then
            '    Exit For
            'End If
            msj &= EnviarCorreo("Estado de cuenta", row("CorreoElectronico"), "Estado de Cuenta", row("IdAsociado"))
            pbcPorcentaje.PerformStep()
            pbcPorcentaje.Update()
        Next

        If msj = "" Then
            MessageBox.Show("Correos enviados exitosamente", "Exito!", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Error en envio de Correos", "Exito!", MessageBoxButtons.OK)
        End If
        Close()

    End Sub
    Public Function EnviarCorreo(ByVal Mensaje As String, ByVal Correo As String, ByVal Asunto As String, ByVal IdAsociado As Integer) As String
        Dim myBL As New DBCoopBL.AdmonBLL()
        Dim dtParam As DataTable = myBL.ObtieneParametros()
        Dim _Message As New MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient


        Dim report As New aso_rptEstadoCuentaGeneral
        report.DataSource = blAporta.rptEstadoCuentaGeneral(IdAsociado, deFecha.EditValue, False, False)
        report.DataMember = ""
        report.xrlEmpresa.Text = gsNombre_Empresa
        report.xrlHastaFecha.Text = "SALDOS HASTA LA FECHA: " + Format(deFecha.EditValue, "dd/MM/yyyy")
        report.xrlEncargadoCoop.Text = entSucursal.Responsable
        report.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        report.xrlNotas.Text = meComentario.EditValue
        report.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand

        ''CONFIGURACIÓN DEL SMTP
        _SMTP.Credentials = New System.Net.NetworkCredential(dtParam.Rows(0).Item("Email"), dtParam.Rows(0).Item("EmailPassword"))
        _SMTP.Host = dtParam.Rows(0).Item("ServerEmail")
        ''_SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = dtParam.Rows(0).Item("PortEmail")
        ''587
        _SMTP.EnableSsl = dtParam.Rows(0).Item("Ssl")
        ''_SMTP.EnableSsl = True

        ' ARCHIVO ADJUNTO
        ' Create a new memory stream and export the report into it as PDF.
        Dim mem As MemoryStream = New MemoryStream()
        report.ExportToPdf(mem)

        ' Create a new attachment and put the PDF report into it.
        mem.Seek(0, System.IO.SeekOrigin.Begin)
        Dim att As Attachment = New Attachment(mem, "EstadoCuenta.pdf", "application/pdf")

        ' Create a new message and attach the PDF report to it.
        _Message.Attachments.Add(att)

        ''CONFIGURACIÓN DEL MENSAJE
        _Message.[To].Add(Correo)
        _Message.From = New System.Net.Mail.MailAddress(dtParam.Rows(0).Item("Email"), gsNombre_Empresa, System.Text.Encoding.UTF8)
        ''"Itosa08$"
        ''"planillaito@gmail.com"
        _Message.Subject = Asunto
        ''_Message.SubjectEncoding = System.Text.Encoding.UTF8
        _Message.Body = Mensaje.ToString()
        ''  _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.High
        _Message.IsBodyHtml = True

        ''ENVIO DE CORREO
        Try
            _SMTP.Send(_Message)
            mem.Close()
            mem.Flush()
            Return ""
        Catch ex As System.Net.Mail.SmtpException
            MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
            Return ex.ToString
        End Try
    End Function
 
End Class
