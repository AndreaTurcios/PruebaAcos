Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
'Imports CajaBL
Public Class pre_frmGeneracionCartas
    Dim blPres As New PrestamosBLL(), blAdmon As New AdmonBLL()
    Dim blCaja As New CajaBusiness(), bl As New TableBusiness()
    Dim entSolicitud As coo_Solicitudes, entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim SaldoDebeSer As Decimal, CapitalMora As Decimal
    Dim CuotaSeguro As Decimal, CuotaManejo As Decimal
    Dim CuotaOtros As Decimal, DiasCalculoInteres As Integer
    Dim DiasCalculoMora As Integer, DebeSerInteres As Decimal
    Dim DebeSerMora As Decimal = 0.0, CuotaAhorro1 As Decimal = 0.0, CuotaAhorro2 As Decimal = 0.0

    Dim entDocRtf As coo_Documentos, dtParam As DataTable = blAdmon.ObtieneParametros()
    Dim CuotaAportacion = dtParam.Rows(0).Item("CuotaAportacion")
    Private blPrestamo As New Prestamo

    Private Sub pre_frmGeneracionCartas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_Lineas(leLinea, "")
        objCombos.coo_Tecnicos(leTecnico, "")
        objCombos.coo_Fuentes(leFinanciamiento, "")
        objCombos.coo_GarantiasFiador(leFiador, "", "")
        deFechaCarta.EditValue = Today
        teComision.EditValue = 0.0
    End Sub

    Private Sub beNumPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        beNumPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        beNumPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub beNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumPrestamo.Validated
        Dim entAsociados As New coo_Asociados
        Dim entPrestamo As New coo_Prestamos

        Dim NumeroPrestamo As String
        If beNumPrestamo.EditValue = "" Then
            NumeroPrestamo = Nothing
        Else
            NumeroPrestamo = beNumPrestamo.EditValue
        End If
        entPrestamo = blPres.coo_PrestamosSelectByNumero(NumeroPrestamo)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        entSolicitud = bl.coo_SolicitudesSelectByPK(entPrestamo.IdSolicitud)
        deFechaAprobado.EditValue = entPrestamo.FechaAprobado
        entAsociados = bl.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teNombre.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)
        teMontoAprobado.EditValue = entPrestamo.MontoAprobado
        teSaldo.EditValue = blPres.GetSaldoCapitalPrestamo(entPrestamo.IdPrestamo)
        seTasa.EditValue = entPrestamo.TasaInteres
        seNumCuotas.EditValue = entPrestamo.NumCuotas
        teValorCuota.EditValue = entPrestamo.ValorCuota
        rgFormaPago.EditValue = entPrestamo.IdFormaPago
        seFrecuencia.EditValue = entPrestamo.FrecuenciaPago
        leLinea.EditValue = entPrestamo.IdLinea
        teDestino.EditValue = entSolicitud.Destino
        leTecnico.EditValue = entPrestamo.IdTecnico
        leFinanciamiento.EditValue = entPrestamo.IdFuente
        Dim Condicion As String = "IdSolicitud=" & entPrestamo.IdSolicitud
        objCombos.coo_GarantiasFiador(leFiador, Condicion, "")
    End Sub

    Private Sub btRecordatorio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btRecordatorio.Click

        If teIdPrestamo.EditValue <= 0 Or beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar el préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim FechaPago As String = InputBox("Fecha del Próximo Pago", "Digite", "")
        If FechaPago = "" Then
            Return
        End If

        Dim LugarFecha As String = entSucursal.Ciudad
        LugarFecha &= ", " & Today.Day()
        LugarFecha &= " de " & ObtieneMesString(Today.Month)
        LugarFecha &= " de " & Today.Year()


        'este codigo solo se ejecuta si hay algún cambio
        'Dim textoRTF As String = RetornaRtf("C:\DevNet\BravioCoop\BravioApp\Plantillas\Carta_Recordatorio.rtf")
        'entDocRtf = New coo_Documentos
        'entDocRtf.Documento = "Carta_Recordatorio"
        'entDocRtf.Contenido = textoRTF
        'bl.coo_DocumentosUpdate(entDocRtf)
        'quitar luego éste codigo

        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_Recordatorio")
        Dim Texto As String = entDocRtf.Contenido
        Texto = Texto.Replace("[Aportaciones]", Format(0.0, "###,##0.00"))
        Texto = Texto.Replace("[Cuota_Ahorro]", Format(0.0, "###,##0.00"))
        Texto = Texto.Replace("[Cuota_Ahorro2]", Format(0.0, "###,##0.00"))
        Texto = Texto.Replace("[Cuota_Credito]", Format(teValorCuota.EditValue, "###,##0.00"))
        Texto = Texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        Texto = Texto.Replace("[Fecha_Pago]", FechaPago)
        Texto = Texto.Replace("[Linea_Credito]", leLinea.Text)
        Texto = Texto.Replace("[Lugar_Fecha]", LugarFecha)
        Texto = Texto.Replace("[Monto_Credito]", Format(teMontoAprobado.EditValue, "###,##0.00"))
        Texto = Texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        Texto = Texto.Replace("[Total_Pagar]", Format(teValorCuota.EditValue, "###,##0.00"))

        Dim rpt As New pre_rptRichTextLogo
        rpt.XrEscrito.Rtf = Texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.ShowPreview()
    End Sub

    Private Sub btCobro1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCobro1.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar un Préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        
        Dim LugarFecha As String = entSucursal.Ciudad & ", " & Today.Day
        LugarFecha &= " de " & ObtieneMesString(Today.Month)
        LugarFecha += " de " & Today.Year

        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroI")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Aportaciones]", CuotaAportacion)
        texto = texto.Replace("[Comisiones]", teComision.EditValue)
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Int_Mora]", DebeSerMora)
        texto = texto.Replace("[Int_Normal]", DebeSerInteres)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", teMontoAprobado.EditValue)
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Saldo_Capital]", teSaldo.EditValue)
        texto = texto.Replace("[Seguro_Prestamo]", CuotaSeguro)
        texto = texto.Replace("[Total_Adeudado]", Format(CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue, "###,##0.00"))
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        rpt.ShowPreview()


        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroI_Fiador")
        texto = entDocRtf.Contenido
        texto = texto.Replace("[Aportaciones]", Format(CuotaAportacion, "###,##0.00"))
        texto = texto.Replace("[Comisiones]", Format(teComision.EditValue, "###,##0.00"))
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Int_Mora]", Format(DebeSerMora, "###,##0.00"))
        texto = texto.Replace("[Int_Normal]", DebeSerInteres)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", Format(teMontoAprobado.EditValue, "###,##0.00"))
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Saldo_Capital]", Format(teSaldo.EditValue, "###,##0.00"))
        texto = texto.Replace("[Seguro_Prestamo]", Format(CuotaSeguro, "###,##0.00"))
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[Total_Adeudado]", Format(CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue, "###,##0.00"))
        texto = texto.Replace("[Nombre_Fiador]", leFiador.Text)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt2 As New pre_rptRichText
        rpt2.xrEscrito.Rtf = texto
        rpt2.ShowPreview()
    End Sub

    Private Sub btCobro2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCobro2.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNumPrestamo.EditValue = "" Then
            MsgBox("Debe Seleccionar un Préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        
        Dim FechaPresentarse As String = InputBox("Fecha en la que debe de Presentarse", "Digite Fecha", "")
        If FechaPresentarse = "" Then
            MsgBox("No se definió la fecha que se debe presentar", MsgBoxStyle.Critical, "Error")
            Return
        End If
        'Carta I para el deudor
        Dim LugarFecha As String = entSucursal.Ciudad & ", " & Today.Day
        LugarFecha &= " de " & ObtieneMesString(Today.Month)
        LugarFecha &= " de " & Today.Year

        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroII")

        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Aportaciones]", CuotaAportacion)
        texto = texto.Replace("[Comisiones]", teComision.EditValue)
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Int_Mora]", DebeSerMora)
        texto = texto.Replace("[Int_Normal]", DebeSerInteres)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", teMontoAprobado.EditValue)
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Saldo_Capital]", teSaldo.EditValue)
        texto = texto.Replace("[Seguro_Prestamo]", CuotaSeguro)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[Total_Adeudado]", CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue)
        texto = texto.Replace("[Fecha_Presentarse]", FechaPresentarse)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt1 As New pre_rptRichText
        rpt1.xrEscrito.Rtf = texto
        rpt1.ShowPreview()

        'Carta II para el Fiador
        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroII_Fiador")
        texto = entDocRtf.Contenido
        texto = texto.Replace("[Aportaciones]", CuotaAportacion)
        texto = texto.Replace("[Comisiones]", teComision.EditValue)
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Int_Mora]", DebeSerMora)
        texto = texto.Replace("[Int_Normal]", DebeSerInteres)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", teMontoAprobado.EditValue)
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Saldo_Capital]", teSaldo.EditValue)
        texto = texto.Replace("[Seguro_Prestamo]", CuotaSeguro)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[Total_Adeudado]", CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue)
        texto = texto.Replace("[Nombre_Fiador]", leFiador.Text)
        texto = texto.Replace("[Fecha_Presentarse]", FechaPresentarse)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt2 As New pre_rptRichText
        rpt2.xrEscrito.Rtf = texto
        rpt2.ShowPreview()
    End Sub

    Private Sub btCobro3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCobro3.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim NombreAbogado As String = InputBox("Nombre del Abogado", "Digite", "")
        Dim TelefonoAbogado As String = InputBox("Teléfono del Abogado", "Digite", "")

        If TelefonoAbogado = "" Or NombreAbogado = "" Then
            MsgBox("no especificó algún dato del abogado", MsgBoxStyle.Information, "Nota")
        End If

        Dim LugarFecha As String = entSucursal.Ciudad & ", " & Today.Day
        LugarFecha += " de " + ObtieneMesString(Today.Month)
        LugarFecha += " de " + Today.Year.ToString

        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroIII")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Capital_Mora]", CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue)
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", teMontoAprobado.EditValue)
        texto = texto.Replace("[Nombre_Abogado]", NombreAbogado)
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Telefono_Abogado]", TelefonoAbogado)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        rpt.ShowPreview()

        'Carta de Cobro III para el fiador
        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_CobroIII_Fiador")
        texto = entDocRtf.Contenido
        texto = texto.Replace("[Capital_Mora]", Format(CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro1 + teComision.EditValue, "###,##0.00"))
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", Format(teMontoAprobado.EditValue, "###,##0.00"))
        texto = texto.Replace("[Nombre_Abogado]", NombreAbogado)
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Nombre_Fiador]", leFiador.Text)
        texto = texto.Replace("[Telefono_Abogado]", TelefonoAbogado)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt2 As New pre_rptRichText
        rpt2.xrEscrito.Rtf = texto
        rpt2.ShowPreview()
    End Sub

    Private Sub btUltimatun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btUltimatun.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un Préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar un Préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim FechaPresentarse As String = InputBox("Fecha en la que debe de Presentarse", "Digite Fecha", "")
        If FechaPresentarse = "" Then
            MsgBox("No se definió la fecha que se debe presentar", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim LugarFecha As String = entSucursal.Ciudad & ", " & Today.Day
        LugarFecha &= " de " & ObtieneMesString(Today.Month)
        LugarFecha &= " de " & Today.Year

        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_Ultimatun")
        Dim texto As String = entDocRtf.Contenido

        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Fecha_Presentarse]", FechaPresentarse)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", Format(teMontoAprobado.EditValue, "###,##0.00"))
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        rpt.ShowPreview()

        'Generar Carta de Ultimatum del Fiador
        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_Ultimatun_Fiador")
        texto = entDocRtf.Contenido
        texto = texto.Replace("[Fecha_Desembolso]", deFechaAprobado.EditValue)
        texto = texto.Replace("[Fecha_Presentarse]", FechaPresentarse)
        texto = texto.Replace("[Linea_Credito]", leLinea.Text)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Credito]", Format(teMontoAprobado.EditValue, "###,##0.00"))
        texto = texto.Replace("[Nombre_Asociado]", teNombre.EditValue)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt2 As New pre_rptRichText
        rpt2.xrEscrito.Rtf = texto
        rpt2.ShowPreview()
    End Sub

    Private Sub sbAcuerdos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAcuerdos.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        pre_frmAcuerdosAsociado.IdPrestamo = teIdPrestamo.EditValue
        pre_frmAcuerdosAsociado.ShowDialog()
    End Sub

    Private Sub CalculaPrestamoSSS()
        Dim entPrestamo As coo_Prestamos = blPres.coo_PrestamosSelectByNumero(beNumPrestamo.EditValue)

        blPrestamo.FechaAmortizacion = deFechaCarta.EditValue
        blPrestamo.CargaPrestamo(entPrestamo.IdPrestamo)
        With blPrestamo
            .FechaContable = deFechaCarta.EditValue
            .FechaAmortizacion = deFechaCarta.EditValue
            .DiasPorAnio = giDiasPorAnioPrestamo
            .CalculaUltimoPago()
            .CalculaCuotaBaseMora()
            .CalculaCuotaDeberSer()

            SaldoDebeSer = .CuotaDeberSer.ImporteSaldo
            CapitalMora = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0.0)

            .ImporteAbonoPago = .CuotaBaseMora.ImporteCuota
            'Cuota base para calculo de otros importes

            With .CuotaDeberSer
                CuotaAportacion = .ImporteCuotaAportacion
                CuotaAhorro1 = .ImporteCuotaAhorro
                CuotaSeguro = .ImporteCuotaSeguro
                CuotaManejo = .ImporteCuotaManejo
                CuotaOtros = .ImporteCuotaOtros
            End With

            '-- Estado de cuenta
            DiasCalculoInteres = DateDiff(DateInterval.Day, .UltimoPago.Fecha, .FechaAmortizacion)
            DiasCalculoMora = blCaja.GetDiasMora(entPrestamo.IdPrestamo, deFechaCarta.EditValue)
            ''Cuando arrastro saldo de interes en mora pendiente, tomo los dias de calculo de mora desde el ultimo pago realizado
            If .UltimoPago.ImporteDeudaMora > 0.0 Or .UltimoPago.ImporteMora > 0 Then
                DiasCalculoMora = DiasCalculoInteres
            End If
            DiasCalculoMora = Min(DiasCalculoMora, blCaja.GetDiasMora(entPrestamo.IdPrestamo, deFechaCarta.EditValue))

            'Si va adelantado en el pago la mora el calculo de mora es 0
            Dim ImporteSaldoCalculoMora As Decimal = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0)
            Dim ImporteSaldoCalculoInteres As Decimal = .UltimoPago.ImporteSaldo

            'Calcula las tasas diarias
            Dim TasaInteres As Decimal = .TasaInteresAnual / 100 * DiasCalculoInteres / 365
            Dim TasaMora As Decimal = .TasaInteresMora / 100 * DiasCalculoMora / giDiasPorAnioPrestamo

            DebeSerInteres = .UltimoPago.ImporteDeudaInteres + Round(ImporteSaldoCalculoInteres * TasaInteres, 2)
            DebeSerMora = .UltimoPago.ImporteDeudaMora + Round(ImporteSaldoCalculoMora * TasaMora, 2)
            .NoInteres = False
            .CalculaAmortizacion()
            With .PagoActual
                CuotaSeguro = .ImporteCuotaSeguro
            End With
        End With
    End Sub

    Private Sub btListadoSeguimiento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btListadoSeguimiento.Click
        pre_frmListadoSeguimientos.ShowDialog()
    End Sub

    Private Sub sbListadoAcuerdos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbListadoAcuerdos.Click
        pre_frmListadoAcuerdos.ShowDialog()
    End Sub

    Private Sub sbSeguimiento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSeguimiento.Click
        Dim entPres As New coo_Prestamos
        Dim entSol As New coo_Solicitudes
        entPres = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        entSol = objTablas.coo_SolicitudesSelectByPK(entPres.IdSolicitud)

        If entSol.RequiereSeguimiento = False Then
            MsgBox("El Préstamo no Requiere seguimiento", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        pre_frmSeguimientosPrestamo.IdPrestamo = teIdPrestamo.EditValue
        pre_frmSeguimientosPrestamo.ShowDialog()
    End Sub

    Private Sub sbFiniquito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbFiniquito.Click

        If teIdPrestamo.EditValue <= 0 Or beNumPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar el préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If teSaldo.EditValue > 0.0 Then
            MsgBox("El prestamo aún tiene saldo pendiente. Imposible Generar Finiquito", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim entPres As New coo_Prestamos
        Dim entAso As New coo_Asociados
        entPres = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        entAso = objTablas.coo_AsociadosSelectByPK(entPres.IdAsociado)

        Dim LugarFecha As String = entSucursal.Ciudad
        LugarFecha &= ", " & Today.Day()
        LugarFecha &= " de " & ObtieneMesString(Today.Month)
        LugarFecha &= " de " & Today.Year()


        entDocRtf = bl.coo_DocumentosSelectByPK("Finiquito")
        Dim Texto As String = entDocRtf.Contenido
        Dim sDecimal = String.Format("{0:c}", Format(CDec(teMontoAprobado.EditValue), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/10"

        Dim FechaCancelacion As DateTime = blPres.ObtieneFechaCancelacion(entPres.IdPrestamo)

        Texto = Texto.Replace("[Lugar_Fecha]", LugarFecha)
        Texto = Texto.Replace("[Asociado]", String.Format("{0} {1}", entAso.Nombres, entAso.Apellidos))
        Texto = Texto.Replace("[Asociado2]", String.Format("{0} {1}", entAso.Nombres, entAso.Apellidos))
        Texto = Texto.Replace("[Asociado3]", String.Format("{0} {1}", entAso.Nombres, entAso.Apellidos))
        Texto = Texto.Replace("[Documento]", entAso.NumeroDocumento)
        Texto = Texto.Replace("[Num_Prestamo]", beNumPrestamo.EditValue)
        Texto = Texto.Replace("[Monto_Prestamo]", Num2Text(Int(teMontoAprobado.EditValue)) & " " & sDecimal)
        Texto = Texto.Replace("[Fecha_Cancelacion]", Format(FechaCancelacion, "dd/MM/yyyy"))


        Dim rpt As New pre_rptRichText
        rpt.XrEscrito.Rtf = Texto
        'rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.ShowPreview()


    End Sub
End Class
