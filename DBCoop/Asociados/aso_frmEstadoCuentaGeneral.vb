Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Text
Imports System
Imports System.IO
Imports System.Net.Mail
Imports System.Net

Public Class aso_frmEstadoCuentaGeneral
    Dim blAporta As New AportacionesBLL()
    Dim blAsoc As New AsociadosBLL()
    Dim myBL As New AdmonBLL
    Dim blCaja As New CajaBusiness
    Dim blPrestamo As Prestamo
    Dim dtParam As DataTable = myBL.ObtieneParametros()
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim thread As Threading.Thread


    Private Sub apo_frmEstadoCuentaAportacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Fecha As Date
        deFecha.EditValue = Today
        Fecha = deFecha.EditValue
        teIdAsociado.EditValue = 0
        LabelControl6.Visible = chkDesgloze.Checked
        teSerie.Visible = chkDesgloze.Checked
        objCombos.coo_ReferenciaPago(leReferencia, Fecha.Month, Fecha.Year)
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
        If chkDesgloze.Checked = False Then
            Dim rpt As New aso_rptEstadoCuentaGeneral

            Dim Template = Application.StartupPath & "\Plantillas\aso_rptEstadoCuentaGeneral.repx"
            If FileIO.FileSystem.FileExists(Template) Then
                rpt.LoadLayout(Template)
            End If
            rpt.DataSource = blAporta.rptEstadoCuentaGeneral(teIdAsociado.EditValue, deFecha.EditValue, False, False)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlHastaFecha.Text = "SALDOS HASTA LA FECHA: " + Format(deFecha.EditValue, "dd/MM/yyyy")
            rpt.xrlEncargadoCoop.Text = entSucursal.Responsable
            rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
            rpt.xrlNotas.Text = meComentario.EditValue
            rpt.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            rpt.ShowPreviewDialog()
        Else
            Dim dt As DataTable
            dt = blAporta.rptPrestamosPagoDesgloze(leReferencia.EditValue, teIdAsociado.EditValue, False)
            If dt.Rows.Count > 10 Then
                If MsgBox("Se imprimira " & dt.Rows.Count & "Detalles de Pago , Desea Continuar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            For i = 0 To dt.Rows.Count - 1
                Dim entAsociado As New coo_Asociados
                Dim entLinea As New coo_Lineas, entFuente As New coo_Fuentes
                Dim entPrestamo As New coo_Prestamos, entDetalle As New coo_PrestamosDetalle
                Dim rpt As New pre_rptFacturaPago
                Dim IdMov As Integer

                IdMov = blCaja.UltMovReferencia(leReferencia.EditValue, dt.Rows(i).Item("Idprestamo"))
                entPrestamo = objTablas.coo_PrestamosSelectByPK(dt.Rows(i).Item("Idprestamo"))
                entAsociado = objTablas.coo_AsociadosSelectByPK(dt.Rows(i).Item("IdAsociado"))
                entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
                entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
                entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(dt.Rows(i).Item("Idprestamo"), IdMov)

                Dim sDecimal = String.Format("{0:c}", Format(CDec(entDetalle.ImportePagado), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlTotalPagado.Text = Format(CDec(entDetalle.ImportePagado), "##,##0.00")
                rpt.xrlFechaContable.Text = entDetalle.FechaContable
                rpt.xrlNombre.Text = entAsociado.Nombres & " " & entAsociado.Apellidos
                rpt.xrlNumeroAsociado.Text = entAsociado.Numero
                rpt.xrlDireccion.Text = entAsociado.Direccion
                rpt.xrlIdMov.Text = (entDetalle.IdMov - 1)
                rpt.xrlFechaOtorgado.Text = entPrestamo.FechaOtorgado
                rpt.xrlLinea.Text = entLinea.Nombre
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
                rpt.xrlFuente.Text = entFuente.Nombre
                rpt.xrlNumeroPrestamo.Text = entPrestamo.Numero

                If entPrestamo.IdTipoCartera = 3 Then
                    rpt.xrlTipoCartera.Text = "PRESTAMO SANEADO"
                Else
                    rpt.xrlTipoCartera.Text = ""
                End If


                rpt.xrlTasaInteres.Text = dt.Rows(i).Item("TasaInteres")
                rpt.xrlNuevoSaldo.Text = Format(CDec(entDetalle.SaldoCapital), "##,##0.00")
                rpt.xrlCapitalPagado.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
                rpt.xrlSaldoCapital.Text = Format(CDec(entDetalle.SaldoCapital + entDetalle.CapitalPagado), "##,##0.00")
                rpt.xrlInteresPendiente.Text = entDetalle.InteresPendiente
                rpt.xrlFechaUltPago.Text = entDetalle.Fecha
                rpt.xrlFechaVencimiento.Text = entPrestamo.FechaVencimiento
                rpt.xrlMontoOtorgado.Text = Format(CDec(entPrestamo.MontoAprobado), "##,##0.00")
                rpt.xrlComprobante.Text = entDetalle.Numero
                rpt.xrlCapital.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
                rpt.xrlAportacion.Text = entDetalle.CuotaAportacion
                rpt.xrlAhorro.Text = entDetalle.CuotaAhorro
                rpt.xrlInteres.Text = entDetalle.InteresPagado
                rpt.xrlInteresMora.Text = entDetalle.InteresMoraPagado
                rpt.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
                rpt.xrlManejo.Text = entDetalle.ManejoPagado
                rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
                rpt.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
                rpt.xrlValorCuota.Text = Format(CDec(entPrestamo.ValorCuota), "##,##0.00")
                rpt.xrlNumCuotas.Text = entPrestamo.NumCuotas
                rpt.ShowPrintMarginsWarning = False
                rpt.xrlCantidadLetras.Text = Num2Text(Int(entDetalle.ImportePagado)) & " " & sDecimal & " DÓLARES"
                rpt.ShowPreviewDialog()
            Next
            End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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
        If meComentario.EditValue = "" Then
            MsgBox("Debe Especificar un comentario !!", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        If teIdAsociado.EditValue = 0 Then
            If chkDesgloze.Checked = True Then
                If MsgBox("Está seguro(a) de enviar masivamente por e-mail el detalle del pago de los prestamos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else
                If MsgBox("Está seguro(a) de enviar masivamente por e-mail los estados de cuenta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        Else
            If chkDesgloze.Checked = True Then
                If MsgBox("Está seguro(a) de enviar por e-mail el detalle del pago de los prestamos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else
                If MsgBox("Está seguro(a) de enviar por e-mail el estado de cuenta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If
            Control.CheckForIllegalCrossThreadCalls = False
            thread = New Threading.Thread(AddressOf Enviar)
            thread.Start()
    End Sub

    Public Sub Enviar()
        Dim dtAsociados As New DataTable
        Dim dt As New DataTable
        Dim IdAsociado As Integer = -1
        Dim msj As String = ""


        If chkDesgloze.Checked = False Then
            '   Mensaje = "Estado de Cuenta Consolidado " & gsNombre_Empresa & " a Fecha: " + Format(deFecha.EditValue, "dd/MM/yyyy")
            If teIdAsociado.EditValue > 0 Then
                IdAsociado = teIdAsociado.EditValue
            End If
            dtAsociados = blAporta.rptEstadoCuentaGeneral(teIdAsociado.EditValue, deFecha.EditValue, True, False)

            For Each row As DataRow In dtAsociados.Rows
                Dim mensaje As New StringBuilder()
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Buen día")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Estimado Socio " & dtAsociados.Rows(0).Item("Nombre"))
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Reciba un cordial saludo de Acosiemens")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<b>--> N° de Asociado  :</b>        " & dtAsociados.Rows(0).Item("NumeroAsociado").ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<b>--> Calculos hasta  :</b>        " & Format(deFecha.EditValue, "dd/MM/yyyy").ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<b>--> Comentario      :</b>        " & meComentario.EditValue.ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("A continuación se le adjunta su estado de cuenta.")

                msj &= EnviarCorreo(mensaje, row("CorreoElectronico"), "Estado de Cuenta", row("IdAsociado"))
                pbcPorcentaje.PerformStep()
                pbcPorcentaje.Update()
            Next
        Else
            ' Mensaje = "DETALLE DE PAGO AL PRESTAMO"
            If teIdAsociado.EditValue > 0 Then
                IdAsociado = teIdAsociado.EditValue
            End If
            dt = blAporta.rptPrestamosPagoDesgloze(leReferencia.EditValue, teIdAsociado.EditValue, True)
            For Each row As DataRow In dt.Rows
                Dim mensaje As New StringBuilder()
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Buen día")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Estimado Socio " & teNombreAsociado.EditValue.ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("Reciba un cordial saludo de Acosiemens")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<b>--> N° de Referencia  :</b>        " & leReferencia.EditValue.ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<b>--> Comentario        :</b>        " & meComentario.EditValue.ToString)
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("<br>")
                mensaje.AppendLine("A continuación se le adjunta su Comprobante de pago.")

                msj &= EnviarCorreoDetallePrestamos(mensaje, row("CorreoElectronico"), "Desgloze de pago a Prestamo", row("Idprestamo"), row("IdAsociado"))
                pbcPorcentaje.PerformStep()
                pbcPorcentaje.Update()
            Next

        End If

        If msj = "" Then
            MessageBox.Show("Correos enviados exitosamente", "Exito!", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Error en envio de Correos", "Nota!", MessageBoxButtons.OK)
        End If
    End Sub

    Public Function EnviarCorreo(ByVal Mensaje As StringBuilder, ByVal Correo As String, ByVal Asunto As String, ByVal IdAsociado As Integer) As String
        Dim myBL As New DBCoopBL.AdmonBLL()
        Dim dtParam As DataTable = myBL.ObtieneParametros()
        Dim _Message As New MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient

        Dim report As New aso_rptEstadoCuentaGeneral

        Dim Template = Application.StartupPath & "\Plantillas\aso_rptEstadoCuentaGeneral.repx"
        If FileIO.FileSystem.FileExists(Template) Then
            report.LoadLayout(Template)
        End If
        report.DataSource = blAporta.rptEstadoCuentaGeneral(IdAsociado, deFecha.EditValue, False, False)
        report.DataMember = ""
        report.xrlEmpresa.Text = gsNombre_Empresa
        report.xrlHastaFecha.Text = "SALDOS HASTA LA FECHA: " + Format(deFecha.EditValue, "dd/MM/yyyy")
        report.xrlEncargadoCoop.Text = entSucursal.Responsable
        report.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        report.xrlNotas.Text = meComentario.EditValue
        report.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand

        Dim Email As String
        Email = dtParam.Rows(0).Item("Email")
        Dim Pas As String
        Pas = dtParam.Rows(0).Item("EmailPassword")
        ''CONFIGURACIÓN DEL SMTP
        _SMTP.Credentials = New System.Net.NetworkCredential(Email, Pas)
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
    Public Function EnviarCorreoDetallePrestamos(ByVal Mensaje As StringBuilder, ByVal Correo As String, ByVal Asunto As String, ByVal Idprestamo As Integer, ByVal IdAsociado As Integer) As String
        Dim myBL As New DBCoopBL.AdmonBLL()
        Dim dtParam As DataTable = myBL.ObtieneParametros()
        Dim _Message As New MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        Dim entAsociado As New coo_Asociados
        Dim entLinea As New coo_Lineas, entFuente As New coo_Fuentes
        Dim entPrestamo As New coo_Prestamos, entDetalle As New coo_PrestamosDetalle
        Dim rpt As New pre_rptFacturaPago
        Dim IdMov As Integer

        IdMov = blCaja.UltMovReferencia(leReferencia.EditValue, Idprestamo)
        entPrestamo = objTablas.coo_PrestamosSelectByPK(Idprestamo)
        entAsociado = objTablas.coo_AsociadosSelectByPK(IdAsociado)
        entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
        entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
        entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(Idprestamo, IdMov)

        Dim sDecimal = String.Format("{0:c}", Format(CDec(entDetalle.ImportePagado), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        rpt.xrlTotalPagado.Text = Format(CDec(entDetalle.ImportePagado), "##,##0.00")
        rpt.xrlFechaContable.Text = entDetalle.FechaContable
        rpt.xrlNombre.Text = entAsociado.Nombres & " " & entAsociado.Apellidos
        rpt.xrlNumeroAsociado.Text = entAsociado.Numero
        rpt.xrlDireccion.Text = entAsociado.Direccion
        rpt.xrlIdMov.Text = (entDetalle.IdMov - 1)

        rpt.xrlFechaOtorgado.Text = entPrestamo.FechaOtorgado
        rpt.xrlLinea.Text = entLinea.Nombre
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.xrlFuente.Text = entFuente.Nombre
        rpt.xrlNumeroPrestamo.Text = entPrestamo.Numero

        If entPrestamo.IdTipoCartera = 3 Then
            rpt.xrlTipoCartera.Text = "PRESTAMO SANEADO"
        Else
            rpt.xrlTipoCartera.Text = ""
        End If

        rpt.xrlTasaInteres.Text = entPrestamo.TasaInteres
        rpt.xrlNuevoSaldo.Text = Format(CDec(entDetalle.SaldoCapital), "##,##0.00")
        rpt.xrlCapitalPagado.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
        rpt.xrlSaldoCapital.Text = Format(CDec(entDetalle.SaldoCapital + entDetalle.CapitalPagado), "##,##0.00")
        rpt.xrlInteresPendiente.Text = entDetalle.InteresPendiente
        rpt.xrlFechaUltPago.Text = entDetalle.Fecha
        rpt.xrlFechaVencimiento.Text = entPrestamo.FechaVencimiento
        rpt.xrlMontoOtorgado.Text = Format(CDec(entPrestamo.MontoAprobado), "##,##0.00")
        rpt.xrlComprobante.Text = entDetalle.Numero
        rpt.xrlCapital.Text = entDetalle.CapitalPagado
        rpt.xrlAportacion.Text = entDetalle.CuotaAportacion
        rpt.xrlAhorro.Text = entDetalle.CuotaAhorro
        rpt.xrlInteres.Text = entDetalle.InteresPagado
        rpt.xrlInteresMora.Text = entDetalle.InteresMoraPagado
        rpt.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
        rpt.xrlManejo.Text = entDetalle.ManejoPagado
        rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
        rpt.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
        rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
        rpt.xrlValorCuota.Text = Format(CDec(entPrestamo.ValorCuota), "##,##0.00")
        rpt.xrlNumCuotas.Text = entPrestamo.NumCuotas
        rpt.PrinterName = gsImpresorDefault
        rpt.xrlCantidadLetras.Text = Num2Text(Int(entDetalle.ImportePagado)) & " " & sDecimal & " DÓLARES"

        '=====================================
        Dim Email As String
        Email = dtParam.Rows(0).Item("Email")
        Dim Pas As String
        Pas = dtParam.Rows(0).Item("EmailPassword")
        ''CONFIGURACIÓN DEL SMTP
        _SMTP.Credentials = New System.Net.NetworkCredential(Email, Pas)
        _SMTP.Host = dtParam.Rows(0).Item("ServerEmail")
        ''_SMTP.Host = "smtp.gmail.com"
        _SMTP.Port = dtParam.Rows(0).Item("PortEmail")
        ''587
        _SMTP.EnableSsl = dtParam.Rows(0).Item("Ssl")
        ''_SMTP.EnableSsl = True
        ' ARCHIVO ADJUNTO
        ' Create a new memory stream and export the report into it as PDF.
        Dim mem As MemoryStream = New MemoryStream()
        rpt.ExportToPdf(mem)
        ' Create a new attachment and put the PDF report into it.
        mem.Seek(0, System.IO.SeekOrigin.Begin)
        Dim att As Attachment = New Attachment(mem, "DesglosePago" & Idprestamo & ".pdf", "application/pdf")
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

    Private Sub chkDesgloze_CheckedChanged(sender As Object, e As EventArgs) Handles chkDesgloze.CheckedChanged
        LabelControl6.Visible = chkDesgloze.Checked
        leReferencia.Visible = chkDesgloze.Checked
    End Sub

    Private Sub deFecha_EditValueChanged(sender As Object, e As EventArgs) Handles deFecha.EditValueChanged
        If deFecha.EditValue Is Nothing Then
            Exit Sub
        End If
        Dim fecha As Date
        fecha = deFecha.EditValue
        objCombos.coo_ReferenciaPago(leReferencia, fecha.Month, fecha.Year)
    End Sub
End Class
