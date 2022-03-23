Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraReports.UI
Public Class pre_frmDocumentosCredito
    Dim blPres As New PrestamosBLL(), blAdmon As New AdmonBLL()
    Dim bl As New TableBusiness()
    Dim entAsociados As coo_Asociados, entSolicitud As coo_Solicitudes
    Dim entResolucion As coo_Resoluciones, entSolicitudFondo As coo_SolicitudFondos
    Dim entFiadores As New DataTable, IdSolicitudFondo As Integer
    Dim entSucursal As adm_Sucursales = bl.adm_SucursalesSelectByPK(gIdSucursal)
    Dim entDocRtf As coo_Documentos
    ReadOnly dtParam As DataTable = blAdmon.ObtieneParametros

    Private Sub pre_frmDocumentosCredito_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        objCombos.coo_Lineas(leLinea, "")
        objCombos.coo_Tecnicos(leTecnico, "")
        objCombos.coo_TipoCredito(leTipoCredito, "")
        objCombos.coo_Fuentes(leFinanciamiento, "")
        teValorCuota.EditValue = 0.0
    End Sub
    Private Sub beNumSolicitud_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNoSolicitud.ButtonClick
        frmConsultaSolicitudesAprobadas.SoloPendientes = False
        frmConsultaSolicitudesAprobadas.ShowDialog()

        beNoSolicitud.EditValue = frmConsultaSolicitudesAprobadas.NoSolicitud
        teIdSolicitud.EditValue = frmConsultaSolicitudesAprobadas.IdSolicitud
        beNumSolicitud_Validated(e, New EventArgs)
    End Sub

    Private Sub beNumSolicitud_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNoSolicitud.Validated
        Dim pres As New Prestamo()


        If beNoSolicitud.EditValue = "" Then
            Exit Sub
        End If

        If teIdSolicitud.EditValue = 0 Then 'fue ingresado manualmente
            teIdSolicitud.EditValue = blPres.ExisteNumeroSolicitud(beNoSolicitud.EditValue) 'retorna cero sino existe
            If teIdSolicitud.EditValue = 0 Then
                MsgBox("El número de solicitud ingresado no existe", MsgBoxStyle.Critical, "Error")
                beNoSolicitud.Focus()
                Exit Sub
            End If
        End If

        entSolicitud = objTablas.coo_SolicitudesSelectByPK(teIdSolicitud.EditValue)
        entResolucion = objTablas.coo_ResolucionesSelectByPK(teIdSolicitud.EditValue)
        gcReferencias.DataSource = blPres.ObtenerFiadores(teIdSolicitud.EditValue)
  
        If entResolucion.IdEstado <> 2 Then
            MsgBox("La solicitud no ha sido aprobada", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        entAsociados = objTablas.coo_AsociadosSelectByPK(entSolicitud.IdAsociado)

        teNombre.EditValue = String.Format("{0} - {1} {2}", entAsociados.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        Dim TasaSeguro As Decimal = 0
        With entSolicitud
            leLinea.EditValue = .IdLinea
            teMontoSolicitado.EditValue = .MontoSolicitado
            teTasaManejo.EditValue = .CuotaManejo
            deFechaPosibleDesembolso.EditValue = .FechaPosibleDesembolso
            seNumCuotas.EditValue = entResolucion.NumeroCuotasAprobada
            rgFormaPago.EditValue = entResolucion.IdFormaPagoAprobado
            seFrecuencia.EditValue = entResolucion.FrecuenciaPagoAprobado
            teCuotaAportacion.EditValue = .CuotaAportacion
            teCuotaAhorro.EditValue = .CuotaOtros
            teTasaManejo.EditValue = .CuotaManejo
            teDetalleFormaPago.EditValue = .DetalleFormaPago
            teDestino.EditValue = .Destino
            leTecnico.EditValue = .IdTecnico
            leTipoCredito.EditValue = .IdTipoCredito
            leFinanciamiento.EditValue = .IdFuente
            seTasa.EditValue = .TasaInteres
            chkIncluirSeguro.EditValue = .IncluyeTasaSeguro
            If .IncluyeTasaSeguro Then
                TasaSeguro = dtParam.Rows(0).Item("TasaSeguro")
            End If
        End With
        IdSolicitudFondo = blPres.GetIdSolicitudFondos(teIdSolicitud.EditValue)
        If IdSolicitudFondo > 0 Then
            entSolicitudFondo = objTablas.coo_SolicitudFondosSelectByPK(IdSolicitudFondo)
            deFechaPosibleDesembolso.EditValue = entSolicitudFondo.FechaEntrega
        End If

        With pres
            .CapitalInicial = teMontoSolicitado.EditValue
            .NumeroCuotas = seNumCuotas.EditValue
            .DiasPorAnio = giDiasPorAnioPrestamo
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .ImporteCuotaAhorro = teCuotaAhorro.EditValue
            .ImporteCuotaManejo = teTasaManejo.EditValue
            .ImporteCuotaAportacion = teCuotaAportacion.EditValue
            .TasaSeguroDeuda = TasaSeguro
            .CalculaPlanPagos()
            teValorCuota.EditValue = entSolicitud.ValorCuota
            'For Each detalle As Cuota In pres.PlanPago
            '    teValorCuota.EditValue = detalle.ImporteCuota
            '    Exit For
            'Next
        End With
    End Sub
    
    Private Sub btGenerarPagare_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btGenerarPagare.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debes Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim Nombre As String = entAsociados.Nombres & " " & entAsociados.Apellidos
        Dim Edad As String = Num2Text(Today.Year - CDate(entAsociados.FechaNacimiento).Year)


        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)
        Dim entMuni As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        Dim entDept As adm_Departamentos = objTablas.adm_DepartamentosSelectByPK(entAsociados.IdDepartamento)
        Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entSolicitud.IdLinea)
        Dim sLinea As String = entLinea.Nombre
        Dim sNumeroAsociado As String = entAsociados.Numero
        Dim sDomicilio As String = entMuni.Nombre + ", " + entDept.Nombre
        Dim entUbicaciones As coo_UbicacionesAsociados = objTablas.coo_UbicacionesAsociadosSelectByPK(entAsociados.IdUbicacion)

        Dim sFiador1 As String = ""
        Dim sEdadFiador1 As String = ""
        Dim sDuiFiador1 As String = ""
        Dim sExtendidoFiador1 As String = ""
        Dim sFechaExtendidoFiador1 As String = ""
        Dim sDomicilioFiador1 As String = ""
        Dim sNitFiador1 As String = ""

        Dim sFiador2 As String = ""
        Dim sEdadFiador2 As String = ""
        Dim sDuiFiador2 As String = ""
        Dim sExtendidoFiador2 As String = ""
        Dim sFechaExtendidoFiador2 As String = ""
        Dim sDomicilioFiador2 As String = ""
        Dim sNitFiador2 As String = ""
        Dim sCentroCosto As String = entUbicaciones.Nombre


        Dim PosGuion = entAsociados.NumeroDocumento.IndexOf("-")
        Dim sNum_Dui As String = ""
        Dim sNit As String = ""
        Dim sExtendidoEn As String = entAsociados.LugarExpedicion
        sNum_Dui = (entAsociados.NumeroDocumento).ToString
        sNit = (entAsociados.Nit).ToString

        Dim sDecimal2 = String.Format("{0:c}", Format(CDec(entResolucion.MontoAprobado), "###,##0.00"))
        sDecimal2 = sDecimal2.Substring(sDecimal2.Length - 2) & "/100"
        Dim MontoLetras As String = Num2Text(Int(entResolucion.MontoAprobado)) & " " & sDecimal2 & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + Format(entResolucion.MontoAprobado, "###,##0.00") + ")"

        Dim sNumCuotas As String = ""
        If entResolucion.FrecuenciaPagoAprobado = 1 Then
            If entResolucion.IdFormaPagoAprobado = 1 Then
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            Else
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            End If
        Else
            If entResolucion.NumeroCuotasAprobada = 1 Then
                sNumCuotas = "AL VENCIMIENTO"
            Else
                If entResolucion.IdFormaPagoAprobado = 1 Then
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " MESES "
                Else
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " DIAS "
                End If
            End If
        End If
        Dim sPlazo As String = Num2Text(entSolicitud.NumeroCuotas * entSolicitud.FrecuenciaPago)
        If entSolicitud.IdFormaPago = 1 Then
            sPlazo += " MESES"
        Else
            sPlazo += " DÍAS"
        End If

        Dim sTasaMora As String = Num2Text(Int(blAdmon.ObtieneParametros.Rows(0).Item("TasaMora")))

        Dim ValorCuota As Decimal = CDec(teValorCuota.EditValue)
        Dim sDecimal = String.Format("{0:c}", Format(CDec(teValorCuota.EditValue), "###,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        Dim sValorCuota As String = Num2Text(Int(ValorCuota)) & " " & sDecimal & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + teValorCuota.EditValue.ToString + ")"
        'Fecha de vencimiento
        Dim FechaVence As Date
        If entResolucion.IdFormaPagoAprobado = 1 Then
            FechaVence = DateAdd(DateInterval.Month, CDbl(entResolucion.NumeroCuotasAprobada * entResolucion.FrecuenciaPagoAprobado), CDate(deFechaPosibleDesembolso.EditValue))
        Else
            FechaVence = DateAdd(DateInterval.Month, CDbl(entResolucion.NumeroCuotasAprobada / 2), CDate(deFechaPosibleDesembolso.EditValue))
        End If
        Dim sFechaVence As String = Num2Text(DatePart(DateInterval.Day, FechaVence))
        sFechaVence += " DE " + ObtieneMesString(DatePart(DateInterval.Month, FechaVence)).ToUpper()
        sFechaVence += " DE " + Num2Text(DatePart(DateInterval.Year, FechaVence))

        sFechaVence.ToUpper()

        Dim sFechaActual As String = Num2Text(DatePart(DateInterval.Day, Today)).ToLower
        sFechaActual += " de " + ObtieneMesString(DatePart(DateInterval.Month, Today)).ToLower
        sFechaActual += " de " + Num2Text(DatePart(DateInterval.Year, Today)).ToLower
        Dim sFechaExtendido As String = CDate(entAsociados.FechaExpedicion).ToString("dd/MM/yyyy")


        Dim nInt1 As Integer = Int(entResolucion.TasaInteresAprobada)
        Dim nInt2 As Integer = (entResolucion.TasaInteresAprobada - nInt1) * 100

        Dim sTasa_Int As String = Num2Text(nInt1)
        If nInt1 <> entResolucion.TasaInteresAprobada Then
            sTasa_Int = sTasa_Int + " PUNTO " + Num2Text(nInt2)
        End If
        ''sTasa_Int += " POR CIENTO ANUAL"

        ''AQUI OBTENGO LA INFORMACION DE LOS FIADORES
        entFiadores = blPres.GetFiadoresSolicitud(teIdSolicitud.EditValue)
        Dim i As Integer = 1
        For Each MiDataRow As DataRow In entFiadores.Rows
            If i = 1 Then
                sFiador1 = MiDataRow("NombresApellidos")
                sEdadFiador1 = Num2Text(Today.Year - MiDataRow("FechaNacimiento").Year)
                sDuiFiador1 = MiDataRow("NroDocumento")
                sExtendidoFiador1 = MiDataRow("LugarExpedicion")
                sFechaExtendidoFiador1 = MiDataRow("FechaExpedicion")
                entDept = objTablas.adm_DepartamentosSelectByPK(MiDataRow("IdDepartamento"))
                entMuni = objTablas.adm_MunicipiosSelectByPK(MiDataRow("IdMunicipio"))
                sDomicilioFiador1 = entMuni.Nombre + ", " + entDept.Nombre
                sNitFiador1 = MiDataRow("Nit")
            End If
            If i = 2 Then
                sFiador2 = MiDataRow("NombresApellidos")
                sEdadFiador2 = Num2Text(Today.Year - MiDataRow("FechaNacimiento").Year)
                sDuiFiador2 = MiDataRow("NroDocumento")
                sExtendidoFiador2 = MiDataRow("LugarExpedicion")
                sFechaExtendidoFiador2 = MiDataRow("FechaExpedicion")
                entDept = objTablas.adm_DepartamentosSelectByPK(MiDataRow("IdDepartamento"))
                entMuni = objTablas.adm_MunicipiosSelectByPK(MiDataRow("IdMunicipio"))
                sDomicilioFiador2 = entMuni.Nombre + ", " + entDept.Nombre
                sNitFiador2 = MiDataRow("Nit")
            End If
            i += 1
        Next

        ''' *--- ESTE CODIGO SE ACTIVA SOLO PARA ACTUALIZAR ALGUN DOCUMENTO DESDE EL RTF *--
        'Dim File As String = "C:\Hoja_Notificacion_Telefonica.rtf"
        'If IO.File.Exists(File) Then
        '    entDocRtf = New coo_Documentos
        '    entDocRtf.Documento = "HojaNotificacionTelefonica"
        '    entDocRtf.Contenido = RetornaRtf(File)
        '    objTablas.coo_DocumentosInsert(entDocRtf)
        '    'objTablas.coo_DocumentosUpdate(entDocRtf)
        'End If

        entDocRtf = bl.coo_DocumentosSelectByPK("PagareDeudor")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[FechaActual]", sFechaActual)
        texto = texto.Replace("[MontoLetras]", MontoLetras)
        texto = texto.Replace("[TasaInteres]", sTasa_Int)
        texto = texto.Replace("[NumCuotas]", sNumCuotas)
        texto = texto.Replace("[FechaVence]", sFechaVence)
        texto = texto.Replace("[Linea]", sLinea)
        texto = texto.Replace("[ValorCuota]", sValorCuota)
        texto = texto.Replace("[TasaMora]", sTasaMora)
        texto = texto.Replace("[Nombre]", Nombre)
        texto = texto.Replace("[Nombre1]", Nombre)
        texto = texto.Replace("[NumeroAsociado]", sNumeroAsociado)
        texto = texto.Replace("[Edad]", Edad)
        texto = texto.Replace("[NumDocumento]", sNum_Dui)
        texto = texto.Replace("[ExtendidoEn]", sExtendidoEn)
        texto = texto.Replace("[FechaExtendido]", sFechaExtendido)
        texto = texto.Replace("[Domicilio]", sDomicilio)
        texto = texto.Replace("[Nit]", sNit)
        texto = texto.Replace("[CentroCosto]", sCentroCosto)

        texto = texto.Replace("[NombreFiador1]", sFiador1)
        texto = texto.Replace("[EdadFiador1]", sEdadFiador1)
        texto = texto.Replace("[NumDocumentoFiador1]", sDuiFiador1)
        texto = texto.Replace("[ExtendidoEnFiador1]", sExtendidoFiador1)
        texto = texto.Replace("[FechaExtendidoFiador1]", sFechaExtendidoFiador1)
        texto = texto.Replace("[DomicilioFiador1]", sDomicilioFiador1)
        texto = texto.Replace("[NitFiador1]", sNitFiador1)

        texto = texto.Replace("[NombreFiador2]", sFiador2)
        texto = texto.Replace("[EdadFiador2]", sEdadFiador2)
        texto = texto.Replace("[NumDocumentoFiador2]", sDuiFiador2)
        texto = texto.Replace("[ExtendidoEnFiador2]", sExtendidoFiador2)
        texto = texto.Replace("[FechaExtendidoFiador2]", sFechaExtendidoFiador2)
        texto = texto.Replace("[DomicilioFiador2]", sDomicilioFiador2)
        texto = texto.Replace("[NitFiador2]", sNitFiador2)


        Dim rpt As New pre_rptRichText
        rpt.XrEscrito.Rtf = texto
        'rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreview()

        'Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(1)

        'Dim NombreFiador As String, EdadFiador As String, MunicipioFiador As String
        'Dim DepartamentoFiador As String, DocumentoFiador As String, ProfesionFiador As String

        'Dim entMunicipioFiador As adm_Municipios, entDepartamentoFiador As adm_Departamentos, entProfesion As coo_Profesiones

        'entFiadores = blPres.GetFiadoresSolicitud(teIdSolicitud.EditValue)
        'Dim i As Integer = 1
        'For Each MiDataRow As DataRow In entFiadores.Rows
        '    NombreFiador = MiDataRow("NombresApellidos")
        '    MsgBox("Se imprimirá ahora el pagaré del fiador -> " & NombreFiador, MsgBoxStyle.Information, "Nota")

        '    EdadFiador = Num2Text(Today.Year - CDate(MiDataRow("FechaNacimiento")).Year)
        '    entMunicipioFiador = objTablas.adm_MunicipiosSelectByPK(MiDataRow("IdMunicipio"))
        '    MunicipioFiador = entMunicipioFiador.Nombre
        '    entDepartamentoFiador = objTablas.adm_DepartamentosSelectByPK(MiDataRow("IdDepartamento"))
        '    DepartamentoFiador = entDepartamentoFiador.Nombre
        '    DocumentoFiador = MiDataRow("NroDocumento")
        '    entProfesion = objTablas.coo_ProfesionesSelectByPK(MiDataRow("IdProfesion"))
        '    ProfesionFiador = entProfesion.Nombre

        '    Dim PosGuion2 = DocumentoFiador.IndexOf("-")
        '    Dim sDUI2 As String = DocumentoFiador
        '    Dim sDUI3 As String = ""
        '    If PosGuion2 < 1 Then
        '        MsgBox("El DUI del fiador está incorrecto", MsgBoxStyle.Information, "Nota")
        '    Else
        '        sDUI2 = sDUI2.Substring(0, PosGuion2)
        '        sDUI3 = DocumentoFiador.Substring(PosGuion2 + 1)
        '    End If
        '    Dim sDigito2 As String = sDUI2.Substring(1, 1)
        '    Dim sNum_Dui2 As String = ""
        '    Dim iCounter2 = 2
        '    While sDigito2 = "0"
        '        sDigito2 = sDUI2.Substring(iCounter2, 1)
        '        iCounter2 += 1
        '        sNum_Dui2 += " CERO "
        '    End While
        '    If sDUI3 = "0" Then
        '        sNum_Dui2 += Num2Text(Val(sDUI2)) + " GUION CERO"
        '    Else
        '        sNum_Dui2 += Num2Text(Val(sDUI2)) + " GUION " + Num2Text(Val(sDUI3))
        '    End If

        '    entDocRtf = bl.coo_DocumentosSelectByPK("PagareCoDeudor")
        '    Dim txt As String = entDocRtf.Contenido

        '    txt = txt.Replace("[Nombre]", NombreFiador)
        '    txt = txt.Replace("[Edad]", EdadFiador)
        '    txt = txt.Replace("[FechaEmision]", sFechaActual)
        '    txt = txt.Replace("[Profesion]", ProfesionFiador)
        '    txt = txt.Replace("[Municipio]", MunicipioFiador)
        '    txt = txt.Replace("[Depto]", DepartamentoFiador)
        '    txt = txt.Replace("[NumDocumento]", sNum_Dui2)
        '    txt = txt.Replace("[NombreDeudor]", Nombre)
        '    txt = txt.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        '    txt = txt.Replace("[NombreCooperativa]", dtParam.Rows(0).Item("NombreLargo"))
        '    txt = txt.Replace("[Empresa]", gsNombre_Empresa)
        '    txt = txt.Replace("[MunicipioEmp]", entSucursal.Ciudad)
        '    'cambiar éste codigo, se debe tener en la tabla sucursales el departamento
        '    txt = txt.Replace("[DeptoEmp]", IIf(gIdSucursal = 2, "CABAÑAS", "CUSCATLÁN"))
        '    txt = txt.Replace("[NumCuotas]", sNumCuotas)
        '    txt = txt.Replace("[MontoLetras]", MontoLetras)
        '    txt = txt.Replace("[ValorCuota]", sValorCuota)
        '    txt = txt.Replace("[Plazo]", sPlazo)
        '    txt = txt.Replace("[FechaVence]", sFechaVence)
        '    txt = txt.Replace("[TasaInteres]", sTasa_Int)
        '    txt = txt.Replace("[TasaMora]", sTasaMora)
        '    txt = txt.Replace("[Ciudad]", entSucursal.Ciudad)
        '    txt = txt.Replace("[FechaActual]", sFechaActual)

        '    Dim rpt1 As New pre_rptRichTextLogo
        '    rpt1.XrEscrito.Rtf = txt
        '    rpt1.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        '    rpt1.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '    rpt1.ShowPreview()
        '    i += 1
        'Next
    End Sub
    
    Private Sub btDeclaracion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btDeclaracion.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim Nombre As String = entAsociados.Nombres + " " + entAsociados.Apellidos
        Dim entMuni As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)

        Dim PosGuion = entAsociados.NumeroDocumento.IndexOf("-")
        Dim sDUI As String = CStr(entAsociados.NumeroDocumento)

        Dim Monto As String = Format(entResolucion.MontoAprobado, "###,##0.00")

        Dim FechaActual As String = Today.Day()
        FechaActual += " de " & ObtieneMesString(Today.Month)
        FechaActual += " de " & Today.Year()

        'sFechaActual.ToUpper()

        Dim LineaCredito As String = leLinea.Text

        Dim sNit As String = CStr(entAsociados.Nit)
        Dim sNumeroPrestamo As String = beNoSolicitud.EditValue
        Dim entSucursal As adm_Sucursales = bl.adm_SucursalesSelectByPK(gIdSucursal)
        Dim sSucursal As String = entSucursal.Nombre
        Dim sOrigenFondos As String = teOrigenFondos.EditValue


        entDocRtf = bl.coo_DocumentosSelectByPK("DeclaracionJuradaPrestamo")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Domicilio]", entMuni.Nombre)
        texto = texto.Replace("[Dui]", sDUI)
        texto = texto.Replace("[Fecha]", FechaActual)
        texto = texto.Replace("[Nit]", sNit)
        texto = texto.Replace("[Monto]", Monto)
        texto = texto.Replace("[LineaCredito]", LineaCredito)
        texto = texto.Replace("[NumPrestamo]", sNumeroPrestamo)
        texto = texto.Replace("[Nombre]", Nombre)
        texto = texto.Replace("[Oficina]", sSucursal)
        texto = texto.Replace("[Origen]", sOrigenFondos)
        texto = texto.Replace("[Profesion]", entProf.Nombre)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[NombreEmpresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        'texto = texto.Replace("[MunicipioEmp]", entParam.Rows(0).Item("Municipio"))
        'texto = texto.Replace("[DeptoEmp]", entParam.Rows(0).Item("Departamento"))
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)

        Dim rpt As New pre_rptRichTextLogo
        rpt.XrEscrito.Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        rpt.ShowPreview()

    End Sub

    Private Sub btCartaDPC_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCartaDPC.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim Nombre As String = entAsociados.Nombres + " " + entAsociados.Apellidos
        Dim entMuni As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)

        Dim PosGuion = entAsociados.NumeroDocumento.IndexOf("-")
        Dim sDUI As String = CStr(entAsociados.NumeroDocumento)

        Dim Monto As String = Format(entResolucion.MontoAprobado, "###,##0.00")

        Dim LugarFecha As String = entSucursal.Ciudad
        LugarFecha &= ", " & Today.Day()
        LugarFecha &= " de " & ObtieneMesString(DatePart(DateInterval.Month, Today))
        LugarFecha &= " de " & Today.Year()

        Dim sNit As String = CStr(entAsociados.Nit)
        Dim sNumeroPrestamo As String = beNoSolicitud.EditValue

        entDocRtf = bl.coo_DocumentosSelectByPK("CartaAutorizacionDPC")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Nombre]", Nombre)
        texto = texto.Replace("[NumeroPrestamo]", sNumeroPrestamo)
        texto = texto.Replace("[Profesion]", entProf.Nombre)
        texto = texto.Replace("[Domicilio]", entMuni.Nombre)
        texto = texto.Replace("[Dui]", sDUI)
        texto = texto.Replace("[Nit]", sNit)
        texto = texto.Replace("[MontoOtorgado]", Monto)
        texto = texto.Replace("[LugarFecha]", LugarFecha)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[NombreEmp]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))


        Dim rpt As New pre_rptRichTextLogo
        rpt.XrEscrito.Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        rpt.ShowPreview()
    End Sub

    Private Sub btGenerarOrden_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btGenerarOrden.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim RecursosHumanos As String = InputBox("Nombre:", "Encargado(a) RRHH", "")

        Dim Nombre As String = entAsociados.Nombres + " " + entAsociados.Apellidos
        Dim Edad As String = Num2Text(Today.Year - CDate(entAsociados.FechaNacimiento).Year)

        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)
        Dim entUbicaciones As coo_UbicacionesAsociados = objTablas.coo_UbicacionesAsociadosSelectByPK(entAsociados.IdUbicacion)

        Dim sDUI As String = entAsociados.NumeroDocumento
        Dim sNIT As String = entAsociados.Nit

        Dim Monto As String = Format(entResolucion.MontoAprobado, "###,##0.00")
        Dim sDecimal2 = String.Format("{0:c}", Format(CDec(entResolucion.MontoAprobado), "###,##0.00"))
        Dim sDecimal3 = String.Format("{0:c}", Format(CDec(entSolicitud.ValorCuota), "###,##0.00"))
        sDecimal2 = sDecimal2.Substring(sDecimal2.Length - 2) & "/100"
        sDecimal3 = sDecimal3.Substring(sDecimal3.Length - 2) & "/100"

        Dim MontoLetras As String = Num2Text(Int(entResolucion.MontoAprobado)) & " " & sDecimal2 & " DÓLARES"
        Dim MontoLetras2 As String = Num2Text(Int(entSolicitud.ValorCuota)) & " " & sDecimal3 & " DÓLARES"
        Dim Cuotas As Integer = entResolucion.NumeroCuotasAprobada
        Dim ValorCuota As String = Format(entSolicitud.ValorCuota, "###,##0.00")
        Dim sPrimerPago As String = ObtieneMesString(Month(entSolicitud.FechaPrimerPago)) + " de " + Year(entSolicitud.FechaPrimerPago).ToString()

        MontoLetras2 = Format(entSolicitud.ValorCuota, "###,##0.00")
        'Dim NumeroReferencia As String = entPrestamo.Numero

        'Dim ValorCuota2 As String = Format(entPlanPagos.Valor, "###,##0.00")
        'Dim sDecimal4 = String.Format("{0:c}", Format(CDec(entPlanPagos.Valor), "###,##0.00"))
        'sDecimal4 = sDecimal4.Substring(sDecimal4.Length - 2) & "/100"

        'Dim MontoLetras3 As String = Num2Text(Int(entPlanPagos.Valor)) & " " & sDecimal4 & " DÓLARES"

        Dim sNumCuotas As String = ""
        If entResolucion.FrecuenciaPagoAprobado = 1 Then
            If entResolucion.IdFormaPagoAprobado = 1 Then
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS MENSUALES"
            Else
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS DIARIAS"
            End If
        Else
            If entResolucion.NumeroCuotasAprobada = 1 Then
                sNumCuotas = "AL VENCIMIENTO"
            Else
                If entResolucion.IdFormaPagoAprobado = 1 Then
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " MESES "
                Else
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " DIAS "
                End If
            End If
        End If
        Dim sPlazo As String = Num2Text(entSolicitud.NumeroCuotas * entSolicitud.FrecuenciaPago)
        If entSolicitud.IdFormaPago = 1 Then
            sPlazo += " MESES"
        Else
            sPlazo += " DÍAS"
        End If
        Dim LugarFecha As String = entSucursal.Ciudad
        LugarFecha &= ", " & Today.Day()
        LugarFecha += " de " & ObtieneMesString(DatePart(DateInterval.Month, Today))
        LugarFecha += " de " & Today.Year()

  

        entDocRtf = bl.coo_DocumentosSelectByPK("Orden_Descuento")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Cant_Letras]", MontoLetras2) ' MontoLetras
        texto = texto.Replace("[Cant_Numero]", Monto)

        texto = texto.Replace("[Edad_Asociado]", Edad)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[No_Dui]", sDUI)
        texto = texto.Replace("[No_Nit]", sNIT)
        texto = texto.Replace("[Cuotas]", Cuotas)
        texto = texto.Replace("[Cuotas2]", Cuotas)
        texto = texto.Replace("[PrimerPago]", sPrimerPago)
        texto = texto.Replace("[Nombre_Asociado]", Nombre)
        texto = texto.Replace("[Nombre_Asociado2]", Nombre)
        texto = texto.Replace("[Nombre_Asociado3]", Nombre)
        texto = texto.Replace("[CentroCosto]", entUbicaciones.Nombre)
        texto = texto.Replace("[CentroCosto2]", entUbicaciones.Nombre)
        texto = texto.Replace("[Plazo_Meses]", sNumCuotas)
        texto = texto.Replace("[Profesion_Asociado]", entProf.Nombre)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[NombreEmp]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))
        texto = texto.Replace("[Encargado]", RecursosHumanos)

        Dim rpt As New pre_rptRichText
        TryCast(rpt.XrEscrito, XRRichText).Rtf = texto
        rpt.ShowPreview()

    End Sub

    Private Sub btResolucionCredito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btResolucionCredito.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sOtrasCondiciones As String = teCondiciones.EditValue
        Dim FechaDesembolso As Date = deFechaPosibleDesembolso.EditValue
        Dim FechaLimite As Date = deFechaLimite.EditValue

        Dim Nombre As String = entAsociados.Nombres + " " + entAsociados.Apellidos
        Dim LugarFecha As String = entSucursal.Ciudad

        Dim Monto As String = Format(entResolucion.MontoAprobado, "###,##0.00")

        Dim MontoSolicitado As String = Format(entSolicitud.MontoSolicitado, "###,##0.00")

        LugarFecha &= ", " & Today.Day().ToString()
        LugarFecha &= " de " + ObtieneMesString(DatePart(DateInterval.Month, Today))
        LugarFecha &= " de " + Today.Year().ToString()


        Dim sNumCuotas As String = ""
        If entResolucion.FrecuenciaPagoAprobado = 1 Then
            If entResolucion.IdFormaPagoAprobado = 1 Then
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS MENSUALES"
            Else
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS DIARIAS"
            End If
        Else
            If entResolucion.NumeroCuotasAprobada = 1 Then
                sNumCuotas = " UNA CUOTA AL VENCIMIENTO"
            Else
                If entResolucion.IdFormaPagoAprobado = 1 Then
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " MESES "
                Else
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " DIAS "
                End If
            End If
        End If
        Dim sPlazo As String = Num2Text(entSolicitud.NumeroCuotas * entSolicitud.FrecuenciaPago)
        If entSolicitud.IdFormaPago = 1 Then
            sPlazo += " MESES"
        Else
            sPlazo += " DÍAS"
        End If
        
        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_Resolucion_Credito")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Condiciones_Adicionales]", sOtrasCondiciones)
        texto = texto.Replace("[Fecha_Desembolso]", FechaDesembolso)
        texto = texto.Replace("[Fecha_Limite]", FechaLimite)
        texto = texto.Replace("[Forma_Pago]", sPlazo)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Monto_Aprobado]", Monto)
        texto = texto.Replace("[Monto_Solicitado]", MontoSolicitado)
        texto = texto.Replace("[Nombre_Asociado]", Nombre)
        texto = texto.Replace("[Plazo]", sPlazo)
        texto = texto.Replace("[Si_Aprobado]", "")
        texto = texto.Replace("[Si_Denegado]", "")
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[Si_Pendiente]", "")
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[NombreEmpresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt As New pre_rptRichTextLogo
        TryCast(rpt.XrEscrito, XRRichText).Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        rpt.ShowPreview()

    End Sub

    Private Sub sbSeguro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSeguro.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim Nombre As String = entAsociados.Nombres + " " + entAsociados.Apellidos

        Dim LugarFecha As String = entSucursal.Ciudad
        Dim Monto As String = Format(entResolucion.MontoAprobado, "###,##0.00")

        LugarFecha &= ", " & DatePart(DateInterval.Day, Today).ToString()
        LugarFecha &= " de " & ObtieneMesString(DatePart(DateInterval.Month, Today))
        LugarFecha &= " de " & DatePart(DateInterval.Year, Today).ToString

        'LugarFecha.ToString.ToUpperInvariant()
        entDocRtf = bl.coo_DocumentosSelectByPK("Carta_Proteccion_Consumidor")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Nombre_Asociado]", Nombre)
        texto = texto.Replace("[Monto_Credito]", Monto)
        texto = texto.Replace("[Lugar_Fecha]", LugarFecha)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        texto = texto.Replace("[Empresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))

        Dim rpt As New pre_rptRichText
        TryCast(rpt.xrEscrito, XRRichText).Rtf = texto

        'rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreview()

    End Sub
    
    Private Sub sbCobroAportaciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCobroAportaciones.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim dtCobroAportacion As DataTable = blPres.rptCobrosAportaciones(teIdSolicitud.EditValue, Today)

        If dtCobroAportacion.Rows.Count = 0 Then
            MsgBox("El Asociado no tiene prestamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim sNumero As String = dtCobroAportacion.Rows(0).Item("Numero")
        Dim sAsociado As String = dtCobroAportacion.Rows(0).Item("NombreAsociado")
        Dim sSaldoPendiente As String = Format(dtCobroAportacion.Rows(0).Item("SaldoPendiente"), "###,##0.00")
        Dim sPrestamoPendiente As String = Format(dtCobroAportacion.Rows(0).Item("PrestamoPendiente"), "###,##0.00")
        Dim sTotal As String = Format(dtCobroAportacion.Rows(0).Item("Total"), "###,##0.00")

        Dim LugarFecha As String = entSucursal.Ciudad

        LugarFecha &= ", " & Today.Day().ToString()
        LugarFecha &= " de " + ObtieneMesString(DatePart(DateInterval.Month, Today))
        LugarFecha &= " de " + Today.Year().ToString()

        entDocRtf = bl.coo_DocumentosSelectByPK("CobroAportaciones")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[LugarFecha]", LugarFecha)
        texto = texto.Replace("[NombreAsociado]", sAsociado)
        texto = texto.Replace("[NumeroAsociado]", sNumero)
        texto = texto.Replace("[Aportacion]", sSaldoPendiente)
        texto = texto.Replace("[Prestamo]", sPrestamoPendiente)
        texto = texto.Replace("[Total]", sTotal)

        Dim rpt As New pre_rptRichTextLogo
        TryCast(rpt.XrEscrito, XRRichText).Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        rpt.ShowPreview()
    End Sub

    Private Sub sbTramiteCredito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbTramiteCredito.Click
        Dim entSol As coo_Solicitudes
        Dim entAso As coo_Asociados
        entSol = objTablas.coo_SolicitudesSelectByPK(teIdSolicitud.EditValue)
        entAso = objTablas.coo_AsociadosSelectByPK(entSol.IdAsociado)
        entDocRtf = objTablas.coo_DocumentosSelectByPK("HojaTramite")
        Dim texto As String = entDocRtf.Contenido
        Dim Nombre As String = ""
        Dim Telefono As String = ""
        Nombre = entAso.Nombres & " " & entAso.Apellidos
        Telefono = entAso.Telefonos
        Dim LugarFecha As String = String.Format("{0}, {1}", entSucursal.Ciudad, FechaToString(Today, Today))
        texto = texto.Replace("[Nombre]", Nombre)
        texto = texto.Replace("[Telefono]", Telefono)
        texto = texto.Replace("[LugarFecha]", LugarFecha)

        Dim rpt As New pre_rptRichTextLogo
        rpt.XrEscrito.Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        rpt.ShowPreview()
    End Sub

    Private Sub sbElaboracionContrato_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbElaboracionContrato.Click
        entDocRtf = objTablas.coo_DocumentosSelectByPK("HojaElaboracionContrato")
        Dim texto As String = entDocRtf.Contenido
        Dim rpt As New pre_rptRichText
        rpt.XrEscrito.Rtf = texto
        rpt.ShowPreview()
    End Sub

    Private Sub sbNotificacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbNotificacion.Click
        entDocRtf = objTablas.coo_DocumentosSelectByPK("HojaNotificacionTelefonica")
        Dim texto As String = entDocRtf.Contenido
        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        rpt.ShowPreview()
    End Sub

    Private Sub sbProtocolo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbProtocolo.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debes Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim Nombre As String = entAsociados.Nombres & " " & entAsociados.Apellidos
        Dim Edad As String = Num2Text(Today.Year - CDate(entAsociados.FechaNacimiento).Year)


        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)
        Dim entMuni As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        Dim entDept As adm_Departamentos = objTablas.adm_DepartamentosSelectByPK(entAsociados.IdDepartamento)
        Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entSolicitud.IdLinea)
        Dim sLinea As String = entLinea.Nombre
        Dim sNumeroAsociado As String = entAsociados.Numero
        Dim sDomicilio As String = entMuni.Nombre

        Dim sFiador1 As String = ""
        Dim sEdadFiador1 As String = ""
        Dim sDuiFiador1 As String = ""
        Dim sExtendidoFiador1 As String = ""
        Dim sFechaExtendidoFiador1 As String = ""
        Dim sDomicilioFiador1 As String = ""
        Dim sNitFiador1 As String = ""

        Dim sFiador2 As String = ""
        Dim sEdadFiador2 As String = ""
        Dim sDuiFiador2 As String = ""
        Dim sExtendidoFiador2 As String = ""
        Dim sFechaExtendidoFiador2 As String = ""
        Dim sDomicilioFiador2 As String = ""
        Dim sNitFiador2 As String = ""

        Dim PosGuion = entAsociados.NumeroDocumento.IndexOf("-")
        Dim sDUI As String = entAsociados.NumeroDocumento
        Dim sDUI1 As String = ""
        Dim sNit As String = ""
        Dim sExtendidoEn As String = ""
        Dim sDigito As String = ""
        Dim sNum_Dui As String = ""
        If PosGuion > -1 Then
            sDUI1 = (entAsociados.NumeroDocumento).Substring(PosGuion + 1)
            sDigito = sDUI.Substring(1, 1)
            sNum_Dui = ""
            sDUI = sDUI.Substring(0, PosGuion)
            Dim iCounter = 2
            While sDigito = "0"
                sDigito = sDUI.Substring(iCounter, 1)
                iCounter += 1
                sNum_Dui += " CERO "
            End While
            If sDUI1 = "0" Then
                sNum_Dui += Num2Text(Val(sDUI)) + " GUION CERO"
            Else
                sNum_Dui += Num2Text(Val(sDUI)) + " GUION " + Num2Text(Val(sDUI1))
            End If
        Else
            sNum_Dui = Num2Text(Val(entAsociados.NumeroDocumento))
        End If


        sNit = (entAsociados.Nit).ToString

        Dim sDecimal2 = String.Format("{0:c}", Format(CDec(entResolucion.MontoAprobado), "##,##0.00"))
        sDecimal2 = sDecimal2.Substring(sDecimal2.Length - 2) & "/100"
        Dim MontoLetras As String = Num2Text(Int(entResolucion.MontoAprobado)) & " " & sDecimal2 & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + entResolucion.MontoAprobado.ToString + ")"

        Dim sNumCuotas As String = ""
        If entResolucion.FrecuenciaPagoAprobado = 1 Then
            If entResolucion.IdFormaPagoAprobado = 1 Then
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            Else
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            End If
        Else
            If entResolucion.NumeroCuotasAprobada = 1 Then
                sNumCuotas = "AL VENCIMIENTO"
            Else
                If entResolucion.IdFormaPagoAprobado = 1 Then
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " MESES "
                Else
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " DIAS "
                End If
            End If
        End If
        Dim sPlazo As String = Num2Text(entSolicitud.NumeroCuotas * entSolicitud.FrecuenciaPago)
        If entSolicitud.IdFormaPago = 1 Then
            sPlazo += " MESES"
        Else
            sPlazo += " DÍAS"
        End If

        Dim sTasaMora As String = Num2Text(Int(blAdmon.ObtieneParametros.Rows(0).Item("TasaMora")))

        Dim ValorCuota As Decimal = CDec(teValorCuota.EditValue)
        Dim sDecimal = String.Format("{0:c}", Format(CDec(teValorCuota.EditValue), "###,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        Dim sValorCuota As String = Num2Text(Int(ValorCuota)) & " " & sDecimal & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + teValorCuota.EditValue.ToString + ")"
        'Fecha de vencimiento
        Dim FechaVence As Date
        If entResolucion.IdFormaPagoAprobado = 1 Then
            FechaVence = DateAdd(DateInterval.Month, CDbl(entResolucion.NumeroCuotasAprobada * entResolucion.FrecuenciaPagoAprobado), CDate(deFechaPosibleDesembolso.EditValue))
        Else
            FechaVence = DateAdd(DateInterval.Day, CDbl(entResolucion.NumeroCuotasAprobada * entResolucion.FrecuenciaPagoAprobado), CDate(deFechaPosibleDesembolso.EditValue))
        End If
        Dim sFechaVence As String = Num2Text(DatePart(DateInterval.Day, FechaVence))
        sFechaVence += " DE " + ObtieneMesString(DatePart(DateInterval.Month, FechaVence)).ToUpper()
        sFechaVence += " DE " + Num2Text(DatePart(DateInterval.Year, FechaVence))

        sFechaVence.ToUpper()

        Dim sFechaActual As String = Num2Text(DatePart(DateInterval.Day, Today)).ToLower
        sFechaActual += " de " + ObtieneMesString(DatePart(DateInterval.Month, Today)).ToLower
        sFechaActual += " de " + Num2Text(DatePart(DateInterval.Year, Today)).ToLower
        Dim sFechaExtendido As String = CDate(entAsociados.FechaExpedicion).ToString("dd/MM/yyyy")


        Dim nInt1 As Integer = Int(entResolucion.TasaInteresAprobada)
        Dim nInt2 As Integer = (entResolucion.TasaInteresAprobada - nInt1) * 100

        Dim sTasa_Int As String = Num2Text(nInt1)
        If nInt1 <> entResolucion.TasaInteresAprobada Then
            sTasa_Int += sTasa_Int + " PUNTO " + Num2Text(nInt2)
        End If
        ''sTasa_Int += " POR CIENTO ANUAL"

        ''AQUI OBTENGO LA INFORMACION DE LOS FIADORES
        entFiadores = blPres.GetFiadoresSolicitud(teIdSolicitud.EditValue)
        Dim i As Integer = 1
        For Each MiDataRow As DataRow In entFiadores.Rows
            If i = 1 Then
                sFiador1 = MiDataRow("NombresApellidos")
                sEdadFiador1 = Num2Text(Today.Year - MiDataRow("FechaNacimiento").Year)
                sDuiFiador1 = MiDataRow("NroDocumento")
                sExtendidoFiador1 = MiDataRow("LugarExpedicion")
                sFechaExtendidoFiador1 = MiDataRow("FechaExpedicion")
                entDept = objTablas.adm_DepartamentosSelectByPK(MiDataRow("IdDepartamento"))
                entMuni = objTablas.adm_MunicipiosSelectByPK(MiDataRow("IdMunicipio"))
                sDomicilioFiador1 = entMuni.Nombre + ", " + entDept.Nombre
                sNitFiador1 = MiDataRow("Nit")
            End If
            If i = 2 Then
                sFiador2 = MiDataRow("NombresApellidos")
                sEdadFiador2 = Num2Text(Today.Year - MiDataRow("FechaNacimiento").Year)
                sDuiFiador2 = MiDataRow("NroDocumento")
                sExtendidoFiador2 = MiDataRow("LugarExpedicion")
                sFechaExtendidoFiador2 = MiDataRow("FechaExpedicion")
                entDept = objTablas.adm_DepartamentosSelectByPK(MiDataRow("IdDepartamento"))
                entMuni = objTablas.adm_MunicipiosSelectByPK(MiDataRow("IdMunicipio"))
                sDomicilioFiador2 = entMuni.Nombre + ", " + entDept.Nombre
                sNitFiador2 = MiDataRow("Nit")
            End If
            i += 1
        Next

        ''' *--- ESTE CODIGO SE ACTIVA SOLO PARA ACTUALIZAR ALGUN DOCUMENTO DESDE EL RTF *--
        'Dim File As String = "C:\Protocolo.rtf"
        'If IO.File.Exists(File) Then
        '    entDocRtf = New coo_Documentos
        '    entDocRtf.Documento = "DocumentoProtocolo"
        '    entDocRtf.Contenido = RetornaRtf(File)
        '    objTablas.coo_DocumentosInsert(entDocRtf)
        '    'objTablas.coo_DocumentosUpdate(entDocRtf)
        'End If

        entDocRtf = bl.coo_DocumentosSelectByPK("DocumentoProtocolo")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[NombreAsociado]", Nombre)
        texto = texto.Replace("[Edad]", Edad)
        texto = texto.Replace("[Profesion]", entProf.Nombre)
        texto = texto.Replace("[Domicilio]", sDomicilio)
        texto = texto.Replace("[Departamento]", entDept.Nombre)
        texto = texto.Replace("[NumeroDui]", sNum_Dui)
        texto = texto.Replace("[NumeroNit]", sNit)
        texto = texto.Replace("[MontoLetras]", MontoLetras)
        texto = texto.Replace("[Plazo]", sNumCuotas)
        texto = texto.Replace("[FechaVence]", sFechaVence)
        texto = texto.Replace("[Linea]", sLinea)
        texto = texto.Replace("[TasaInteres]", sTasa_Int)
        texto = texto.Replace("[TasaMora]", sTasaMora)
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[FechaActual]", sFechaActual)





        texto = texto.Replace("[ValorCuota]", sValorCuota)


        texto = texto.Replace("[NumeroAsociado]", sNumeroAsociado)


        texto = texto.Replace("[ExtendidoEn]", sExtendidoEn)
        texto = texto.Replace("[FechaExtendido]", sFechaExtendido)

        texto = texto.Replace("[NombreFiador1]", sFiador1)
        texto = texto.Replace("[EdadFiador1]", sEdadFiador1)
        texto = texto.Replace("[NumDocumentoFiador1]", sDuiFiador1)
        texto = texto.Replace("[ExtendidoEnFiador1]", sExtendidoFiador1)
        texto = texto.Replace("[FechaExtendidoFiador1]", sFechaExtendidoFiador1)
        texto = texto.Replace("[DomicilioFiador1]", sDomicilioFiador1)
        texto = texto.Replace("[NitFiador1]", sNitFiador1)

        texto = texto.Replace("[NombreFiador2]", sFiador2)
        texto = texto.Replace("[EdadFiador2]", sEdadFiador2)
        texto = texto.Replace("[NumDocumentoFiador2]", sDuiFiador2)
        texto = texto.Replace("[ExtendidoEnFiador2]", sExtendidoFiador2)
        texto = texto.Replace("[FechaExtendidoFiador2]", sFechaExtendidoFiador2)
        texto = texto.Replace("[DomicilioFiador2]", sDomicilioFiador2)
        texto = texto.Replace("[NitFiador2]", sNitFiador2)


        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        'rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreview()


    End Sub

    Private Sub beNoSolicitud_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beNoSolicitud.EditValueChanged

    End Sub


    Private Sub BtPagaFiador_Click(sender As Object, e As EventArgs) Handles BtPagaFiador.Click
        If teIdSolicitud.EditValue <= 0 Then
            MsgBox("Debes Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim IdAsociado As Integer = SiEsNulo(gvReferencias.GetFocusedRowCellValue("IdAsociado"), 0)
        If IdAsociado = 0 Then
            Exit Sub
        End If
        SiEsNulo(gvReferencias.GetFocusedRowCellValue("Valor"), 0)
        Dim entFia As coo_Asociados
        entFia = objTablas.coo_AsociadosSelectByPK(IdAsociado)
        Dim Nombre As String = entFia.Nombres & " " & entFia.Apellidos
        Dim Edad As String = Num2Text(Today.Year - CDate(entFia.FechaNacimiento).Year)

        Dim entProf As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entFia.IdProfesion)
        Dim entMuni As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entFia.IdMunicipio)
        Dim entDept As adm_Departamentos = objTablas.adm_DepartamentosSelectByPK(entFia.IdDepartamento)
        Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entSolicitud.IdLinea)
        Dim sLinea As String = entLinea.Nombre
        Dim sNumeroAsociado As String = entFia.Numero
        Dim sDomicilio As String = entMuni.Nombre + ", " + entDept.Nombre
        Dim entUbicaciones As coo_UbicacionesAsociados = objTablas.coo_UbicacionesAsociadosSelectByPK(entFia.IdUbicacion)

        Dim sFiador1 As String = ""
        Dim sEdadFiador1 As String = ""
        Dim sDuiFiador1 As String = ""
        Dim sExtendidoFiador1 As String = ""
        Dim sFechaExtendidoFiador1 As String = ""
        Dim sDomicilioFiador1 As String = ""
        Dim sNitFiador1 As String = ""

        Dim sFiador2 As String = ""
        Dim sEdadFiador2 As String = ""
        Dim sDuiFiador2 As String = ""
        Dim sExtendidoFiador2 As String = ""
        Dim sFechaExtendidoFiador2 As String = ""
        Dim sDomicilioFiador2 As String = ""
        Dim sNitFiador2 As String = ""
        Dim sCentroCosto As String = entUbicaciones.Nombre


        Dim PosGuion = entFia.NumeroDocumento.IndexOf("-")
        Dim sNum_Dui As String = ""
        Dim sNit As String = ""
        Dim sExtendidoEn As String = entFia.LugarExpedicion
        sNum_Dui = (entFia.NumeroDocumento).ToString
        sNit = (entFia.Nit).ToString

        Dim sDecimal2 = String.Format("{0:c}", Format(CDec(entResolucion.MontoAprobado), "###,##0.00"))
        sDecimal2 = sDecimal2.Substring(sDecimal2.Length - 2) & "/100"
        Dim MontoLetras As String = Num2Text(Int(SiEsNulo(gvReferencias.GetFocusedRowCellValue("Valor"), 0))) & " " & sDecimal2 & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + Format(SiEsNulo(gvReferencias.GetFocusedRowCellValue("Valor"), 0), "###,##0.00") + ")"

        Dim sNumCuotas As String = ""
        If entResolucion.FrecuenciaPagoAprobado = 1 Then
            If entResolucion.IdFormaPagoAprobado = 1 Then
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            Else
                sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada)
            End If
        Else
            If entResolucion.NumeroCuotasAprobada = 1 Then
                sNumCuotas = "AL VENCIMIENTO"
            Else
                If entResolucion.IdFormaPagoAprobado = 1 Then
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " MESES "
                Else
                    sNumCuotas = Num2Text(entResolucion.NumeroCuotasAprobada) + " CUOTAS PAGADERAS CADA " + Num2Text(entResolucion.FrecuenciaPagoAprobado) + " DIAS "
                End If
            End If
        End If
        Dim sPlazo As String = Num2Text(entSolicitud.NumeroCuotas * entSolicitud.FrecuenciaPago)
        If entSolicitud.IdFormaPago = 1 Then
            sPlazo += " MESES"
        Else
            sPlazo += " DÍAS"
        End If

        Dim sTasaMora As String = Num2Text(Int(blAdmon.ObtieneParametros.Rows(0).Item("TasaMora")))

        Dim ValorCuota As Decimal = CDec(teValorCuota.EditValue)
        Dim sDecimal = String.Format("{0:c}", Format(CDec(teValorCuota.EditValue), "###,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        Dim sValorCuota As String = Num2Text(Int(ValorCuota)) & " " & sDecimal & " DÓLARES DE LOS ESTADOS UNIDOS DE AMERICA ($" + teValorCuota.EditValue.ToString + ")"
        'Fecha de vencimiento
        Dim FechaVence As Date
        If entResolucion.IdFormaPagoAprobado = 1 Then
            FechaVence = DateAdd(DateInterval.Month, CDbl(entResolucion.NumeroCuotasAprobada * entResolucion.FrecuenciaPagoAprobado), CDate(deFechaPosibleDesembolso.EditValue))
        Else
            FechaVence = DateAdd(DateInterval.Month, CDbl(entResolucion.NumeroCuotasAprobada / 2), CDate(deFechaPosibleDesembolso.EditValue))
        End If
        Dim sFechaVence As String = Num2Text(DatePart(DateInterval.Day, FechaVence))
        sFechaVence += " DE " + ObtieneMesString(DatePart(DateInterval.Month, FechaVence)).ToUpper()
        sFechaVence += " DE " + Num2Text(DatePart(DateInterval.Year, FechaVence))
        sFechaVence.ToUpper()
        Dim sFechaActual As String = Num2Text(DatePart(DateInterval.Day, Today)).ToLower
        sFechaActual += " de " + ObtieneMesString(DatePart(DateInterval.Month, Today)).ToLower
        sFechaActual += " de " + Num2Text(DatePart(DateInterval.Year, Today)).ToLower
        Dim sFechaExtendido As String = CDate(entFia.FechaExpedicion).ToString("dd/MM/yyyy")


        Dim nInt1 As Integer = Int(entResolucion.TasaInteresAprobada)
        Dim nInt2 As Integer = (entResolucion.TasaInteresAprobada - nInt1) * 100

        Dim sTasa_Int As String = Num2Text(nInt1)
        If nInt1 <> entResolucion.TasaInteresAprobada Then
            sTasa_Int = sTasa_Int + " PUNTO " + Num2Text(nInt2)
        End If
        ''sTasa_Int += " POR CIENTO ANUAL"
        ''AQUI OBTENGO LA INFORMACION DE LOS FIADORES
        entFiadores = blPres.GetFiadoresSolicitud(teIdSolicitud.EditValue)
       
        entDocRtf = bl.coo_DocumentosSelectByPK("PagareCoDeudor")
        Dim texto As String = entDocRtf.Contenido
        texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
        texto = texto.Replace("[FechaActual]", sFechaActual)
        texto = texto.Replace("[MontoLetras]", MontoLetras)
        texto = texto.Replace("[TasaInteres]", sTasa_Int)
        texto = texto.Replace("[NumCuotas]", sNumCuotas)
        texto = texto.Replace("[FechaVence]", sFechaVence)
        texto = texto.Replace("[Profesion]", entProf.Nombre)
        texto = texto.Replace("[Municipio]", entMuni.Nombre)
        texto = texto.Replace("[NombreDeudor]", teNombre.Text)
        texto = texto.Replace("[Depto]", entDept.Nombre)
        texto = texto.Replace("[Tasa]", seTasa.EditValue)
        texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))
        texto = texto.Replace("[MuniciopioEmp]", dtParam.Rows(0).Item("Domicilio"))
        texto = texto.Replace("[NombreEmpresa]", dtParam.Rows(0).Item("NombreEmpresa"))
        texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("ActividadEconomica"))
        texto = texto.Replace("[Linea]", sLinea)
        texto = texto.Replace("[ValorCuota]", sValorCuota)
        texto = texto.Replace("[TasaMora]", sTasaMora)
        texto = texto.Replace("[Nombre]", Nombre)
        texto = texto.Replace("[Nombre1]", Nombre)
        texto = texto.Replace("[NumeroAsociado]", sNumeroAsociado)
        texto = texto.Replace("[Edad]", Edad)
        texto = texto.Replace("[NumDocumento]", sNum_Dui)
        texto = texto.Replace("[ExtendidoEn]", sExtendidoEn)
        texto = texto.Replace("[FechaEmision]", sFechaActual)
        texto = texto.Replace("[Domicilio]", sDomicilio)
        texto = texto.Replace("[Nit]", sNit)
        texto = texto.Replace("[CentroCosto]", sCentroCosto)
        texto = texto.Replace("[NombreFiador1]", sFiador1)
        texto = texto.Replace("[EdadFiador1]", sEdadFiador1)
        texto = texto.Replace("[NumDocumentoFiador1]", sDuiFiador1)
        texto = texto.Replace("[ExtendidoEnFiador1]", sExtendidoFiador1)
        texto = texto.Replace("[FechaExtendidoFiador1]", sFechaExtendidoFiador1)
        texto = texto.Replace("[DomicilioFiador1]", sDomicilioFiador1)
        texto = texto.Replace("[NitFiador1]", sNitFiador1)
        texto = texto.Replace("[NombreFiador2]", sFiador2)
        texto = texto.Replace("[EdadFiador2]", sEdadFiador2)
        texto = texto.Replace("[NumDocumentoFiador2]", sDuiFiador2)
        texto = texto.Replace("[ExtendidoEnFiador2]", sExtendidoFiador2)
        texto = texto.Replace("[FechaExtendidoFiador2]", sFechaExtendidoFiador2)
        texto = texto.Replace("[DomicilioFiador2]", sDomicilioFiador2)
        texto = texto.Replace("[NitFiador2]", sNitFiador2)
        texto = texto.Replace("[Dui]", sNum_Dui)
        texto = texto.Replace("[Plazo]", entFia.Direccion)

        Dim rpt As New pre_rptRichText
        rpt.xrEscrito.Rtf = texto
        rpt.ShowPreview()
    End Sub
End Class
