Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Diagnostics
Imports System.Math
Public Class pre_frmPrestamosEfectivo
    Dim entPresEfectivo As coo_PrestamosEfectivo
    Dim entCancelacion As New List(Of coo_PrestamosDetalle)
    Dim entPresRefinancia As List(Of coo_PrestamoEfectivoRefinancia)
    Dim bl As New PrestamosBLL()
    Dim blCaja As New CajaBusiness
    Dim blAdmon As New AdmonBLL()
    ReadOnly blAporta As New AportacionesBLL(), blAhorro As New AhorrosBLL()
    Dim entLiquidacion As New coo_PrestamosDesembolso
    Dim entPrestamo As New coo_Prestamos, entDesembolso As New coo_PrestamosDetalle
    Dim entPlanPago As New List(Of coo_PrestamosPlanPagos)
    Dim entSolFondos As New coo_SolicitudFondos
    Dim blAsoc As New AsociadosBLL(), dtParam As DataTable = blAporta.ObtenerParametrosGenerales(), ds As DataSet
    Dim entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso), entLinea As coo_Lineas, IdAsociado As Integer


    Private Sub pre_frmSolicitudPrestamo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        teIdSolicitud.EditValue = objFunciones.ObtenerUltimoId("coo_PrestamosEfectivo", "IdSolicitud")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Private Sub pre_frmSolicitudPrestamo_Nuevo() Handles Me.Nuevo
        IdAsociado = teIdAsociado.EditValue

        ActivarControles(True)
        entPresEfectivo = New coo_PrestamosEfectivo

        teIdSolicitud.EditValue = 0
        teNumSolicitud.EditValue = ""
        teNumVale.EditValue = 0
        teNumAsociado.EditValue = ""
        teIdAsociado.EditValue = 0
        teNombreAsociado.EditValue = ""
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deFechaPrimerPago.EditValue = Today
        teMontoSolicitado.EditValue = 0.0
        rgFormaPago.EditValue = 1
        seTasa.EditValue = 0.0
        sePlazoCuotas.EditValue = 1
        cboLinea.EditValue = 1
        leFinanciamiento.EditValue = 1
        leTipoCredito.EditValue = 1
        rgTipoAplicacion.EditValue = 3
        seFrecuencia.EditValue = 1
        teValorCuota.EditValue = 0.0
        deFechaPosibleDesembolso.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        meObservaciones.EditValue = ""
        'teSaldoAhorros.EditValue = 0.0
        'teSaldoAportaciones.EditValue = 0.0
        'teSaldoDeudas.EditValue = 0.0
        'teSaldoDisponible.EditValue = 0.0
        'teSaldoPendiente.EditValue = 0.0
        'teSaldoCaja.EditValue = 0.0
        rgTipoCuota.EditValue = 1
        Dim FechaDescuentosPla As Date = bl.FechaDescuentoActiva()
        deFechaPrimerPago.EditValue = FechaDescuentosPla

        ds = blAdmon.ObtieneCorrelativos(gIdSucursal)
        teNumVale.EditValue = ds.Tables(3).Rows(0).Item("UltimoValor") + 1

        Dim entLin = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)
        seTasa.EditValue = entLin.TasaInteres
        chkDescPlanilla.EditValue = True
        teNumAsociado.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Guardar() Handles Me.Guardar
        If teMontoSolicitado.EditValue <= 75 Then
            seTasa.EditValue = 0.0
        End If
        CalcularCuota()
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = bl.InsertaSolicitudPrestamoEfectivo(entPresEfectivo, entPrestamo, entDesembolso _
            , entPlanPago, entLiquidacion, entPresRefinancia, entCancelacion) ', entSolFondos

            If msj = "" Then
                MsgBox("La solicitud ha sido guardada con éxito", MsgBoxStyle.Information)
                teIdSolicitud.EditValue = entPresEfectivo.IdSolicitud
            Else
                MsgBox(String.Format("No fue posible actualizar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            Dim IdPrestamo As Integer = bl.ExisteNumPrestamo(teNumSolicitud.EditValue)

            msj = bl.UpdateSolicitudPrestamoEfectivo(entPresEfectivo, entPrestamo, entDesembolso, entPlanPago _
            , entLiquidacion, IdPrestamo)
            If msj = "" Then
                MsgBox("La solicitud de crédito ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la solicitud de crédito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If

        IdAsociado = teIdAsociado.EditValue
        LimpiarPantalla()
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Consulta() Handles Me.Consulta
        frmConsultaPrestamosEfectivos.ShowDialog()
        teIdSolicitud.EditValue = frmConsultaPrestamosEfectivos.IdSolicitud
        teNumSolicitud.EditValue = frmConsultaPrestamosEfectivos.NumeroSol
        CargaControles(0)

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Editar() Handles Me.Editar

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > deFecha.EditValue Then
            MsgBox("No es posible modificar el préstamo en efectivo, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            MostrarModoInicial()
            ActivarControles(False)
            Exit Sub
        End If

        If entPresEfectivo.IdSucursal <> gIdSucursal Then
            MsgBox("No puede modificar solicitudes de otra sucursal", MsgBoxStyle.Critical, "Nota")
            MostrarModoInicial()
            ActivarControles(False)
            Return
        End If

        If entPresEfectivo.Anulado Then
            MsgBox(String.Format("El Prestamo se encuentra anulado", Chr(13)), MsgBoxStyle.Critical, "Error al Modificar")
            MostrarModoInicial()
            ActivarControles(False)
            Return
        End If

        ActivarControles(True)
        teNumSolicitud.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Revertir() Handles Me.Revertir
        teIdAsociado.EditValue = IdAsociado
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Reporte() Handles Me.Reporte
        Dim entSuc As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        Dim entUbicaciones As coo_UbicacionesAsociados = objTablas.coo_UbicacionesAsociadosSelectByPK(entAso.IdUbicacion)
        Dim IdPrestamo As Integer = bl.ExisteNumPrestamo(teNumSolicitud.EditValue)
        Dim entPlanPagos As coo_PrestamosPlanPagos = objTablas.coo_PrestamosPlanPagosSelectByPK(IdPrestamo, 1)
        Dim rpt As New pre_rptPrestamosEfectivos()
        'rpt.xrlCantidadLetras.Text = ""

        Dim sDecimal = String.Format("{0:c}", Format(CDec(teMontoSolicitado.EditValue), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"


        Dim Comentario As String = sePlazoCuotas.EditValue.ToString + " Pagos de " & entPlanPagos.Capital & If(rgFormaPago.EditValue = 1, ", Mensual ", ", Quincenal ")
        Comentario += ", Iniciando " & Format(deFechaPrimerPago.EditValue, "dd/MM/yyyy") + " , Planilla a Descontar: "

        Comentario += " Ordinaria"
        rpt.xrlEmpresa.Text = gsNombre_Empresa

        rpt.xrlValor.Text = Num2Text(Int(teMontoSolicitado.EditValue)) & " " & sDecimal & " DÓLARES"
        rpt.xrlValor.Text += " ( USD " + Format(teMontoSolicitado.EditValue, "###,###.00") + " )"
        rpt.xrlID.Text = teIdSolicitud.EditValue.ToString()
        rpt.xrlValor2.Text = Format(teMontoSolicitado.EditValue, "###,###.00")
        rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
        rpt.xrlNombreAsociado2.Text = teNombreAsociado.EditValue
        rpt.xrlFechaEntrega.Text = ObtinesDiaString(Weekday(deFecha.EditValue)) + ", " + FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.xrlFecha.Text = ObtinesDiaString(Weekday(Today)) + ", " + FechaToString(Today, Today)

        Dim Autorizacion As String = "", Recibe As String = ""
        Autorizacion = "Por la presente autorizo a " + entUbicaciones.Nombre + " para que descuente de mi sueldo en una sola cuota el valor de US$ " + Format(teMontoSolicitado.EditValue, "###,###.00")
        Autorizacion += " correspondiente al total del préstamo automático adquirido en esta fecha con " + blAdmon.ObtieneParametros.Rows(0).Item("NombreEmpresa")

        Recibe = "Recibí de " + blAdmon.ObtieneParametros.Rows(0).Item("NombreEmpresa") + " la cantidad de "
        Recibe += Num2Text(Int(teMontoSolicitado.EditValue)) & " " & sDecimal & " DÓLARES" + " ( USD " + Format(teMontoSolicitado.EditValue, "###,###.00") + " )"
        Recibe += " en conceto de pago de préstamo automático de Solicitud No. " + teIdSolicitud.EditValue.ToString()
        Recibe += "concedido a mi persona este día, para ser descontado en su totalidad en el próximo pago que reciba de mi empleador"

        rpt.xrlAutorizacion.Text = Autorizacion
        rpt.xrlRecibe.Text = Recibe
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Eliminar() Handles Me.Eliminar
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > deFecha.EditValue Then
            MsgBox("No es posible eliminar el préstamo en efectivo, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End If

        If entPresEfectivo.Anulado Then
            MsgBox(String.Format("El Prestamo se encuentra anulado", Chr(13)), MsgBoxStyle.Critical, "Error al Eliminar")
            Exit Sub
        End If

        'If bl.ExisteSolicitudPresEfectivo(teIdSolicitud.EditValue) > 0 Then
        '    MsgBox("La solicitud ya le fue aplicada a prestamos. No es posible Eliminarla", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If

        If MsgBox("Está seguro(a) de eliminar la Solicitud de Crédito en Efectivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                Dim IdPrestamo As Integer = bl.ExisteNumPrestamo(teNumSolicitud.EditValue)
                Dim IdSolFondos As Integer = bl.ObtenerIdSolFondosEfectivo(teIdSolicitud.EditValue)

                objTablas.coo_PrestamosEfectivoDeleteByPK(teIdSolicitud.EditValue)
                objTablas.coo_PrestamosPlanPagosDeleteByPrestamo(IdPrestamo)
                objTablas.coo_PrestamosDetalleDeleteByPK(IdPrestamo, 1)
                objTablas.coo_PrestamosDeleteByPK(IdPrestamo)
                objTablas.coo_PrestamosDesembolsoDeleteByPK(0, IdPrestamo)

            Catch ex As Exception
                msj = ex.Message()
            End Try

            If msj = "" Then
                MsgBox("La Solicitud ha sido elminada con éxito", MsgBoxStyle.Information, "Nota")
                teIdSolicitud.EditValue -= 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Function DatosValidos() As Boolean
        If teNumAsociado.EditValue = "" Then
            MsgBox(String.Format("No se ha especificado el número de asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If
        If teNumSolicitud.EditValue = "" Then
            MsgBox(String.Format("Es necesario especificar el número de Solicitud de Crédito{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumSolicitud.Focus()
            Return False
        End If
        If SiEsNulo(deFecha.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha de la solicitud{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If

        If teNumVale.EditValue = 0 Then
            MsgBox(String.Format("Es necesario especificar el número de Vale {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumVale.Focus()
            Return False
        End If

        If SiEsNulo(deFechaPrimerPago.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha del primer descuento{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If

        If seTasa.EditValue <= 0 And teMontoSolicitado.EditValue > 75 Then
            MsgBox(String.Format("No se ha especificado la tasa de interés{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            seTasa.Focus()
            Return False
        End If
        If teMontoSolicitado.EditValue <= 0 Then
            MsgBox(String.Format("No se ha definido el monto solicitado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teMontoSolicitado.Focus()
            Return False
        End If
        If sePlazoCuotas.EditValue = 0 Then
            MsgBox(String.Format("Falta especificar el número de Cuotas{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            sePlazoCuotas.Focus()
            Return False
        End If
        If seFrecuencia.EditValue = 0 Then
            MsgBox(String.Format("Falta especificar la Frecuencia del Pago{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            seFrecuencia.Focus()
            Return False
        End If

        If cboLinea.Text = "" Then
            MsgBox(String.Format("No se ha definido la Línea de Crédito{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            cboLinea.Focus()
            Return False
        End If

        If leFinanciamiento.Text = "" Then
            MsgBox(String.Format("Falta especificar la Fuente de Financiamiento{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            leFinanciamiento.Focus()
            Return False
        End If
        If leTipoCredito.Text = "" Then
            MsgBox(String.Format("Falta especificar el Tipo de Préstamo{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            leFinanciamiento.Focus()
            Return False
        End If

        If bl.ExisteNumeroSolicitudPresEfectivo(teNumSolicitud.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe un número de solicitud con el número asignado", MsgBoxStyle.Critical)
            Return False
        End If

        'Dim entAsocia As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        'If entAsocia.CuotaPresEfectivo < teMontoSolicitado.EditValue Then
        '    MsgBox("El monto a solicitar es mayor al maximo permitido del asociado.", MsgBoxStyle.Critical)
        '    Return False
        'End If

        If bl.ExisteNumPrestamo(teNumSolicitud.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe el número de Préstamo", MsgBoxStyle.Critical)
            Return False
        End If

        '' VALIDO SI TIENE DISPONIBILIDAD EL ASOCIADO Ó NO TIENE SALDO PENDIENTE DE DESCUENTOS PASADOS

        'If teSaldoDisponible.EditValue < 0.0 Or teSaldoDisponible.EditValue < teMontoSolicitado.EditValue Then
        '    Dim PorLiquidez As Decimal = 0.0
        '    Dim Disponible As Decimal = teSaldoDisponible.EditValue * -1

        '    If teSaldoAportaciones.EditValue > 0.0 Then
        '        PorLiquidez = Decimal.Round(Round(Disponible / teSaldoAportaciones.EditValue, 2) * 100, 2)
        '    Else
        '        PorLiquidez = 0.0
        '    End If


        '    If PorLiquidez > 20 Then
        '        If MsgBox("El Asociado tiene un porcentaje liquidez de " + PorLiquidez.ToString + "% de sobregiro, Desea Autorizar para Continuar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
        '            Return False
        '        End If

        '        Dim forma As New aso_frmAutoriza
        '        forma.tePass.EditValue = ""
        '        forma.ShowDialog()

        '        Dim ClaveAutoriza As String = forma.tePass.EditValue
        '        Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        '        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
        '        Dim inArray As Byte() = provider.ComputeHash(bytes)
        '        provider.Clear()

        '        Dim sPassWord As String = Convert.ToBase64String(inArray)
        '        Dim Respuesta As String = blAdmon.ValidarUsuario("GERENTE", sPassWord)

        '        If Respuesta <> "Ok" Then
        '            MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
        '            Return False
        '        End If
        '    End If
        'End If

        'Dim CantidadDisponible As Decimal = (entAsocia.CuotaPresEfectivo - teSaldoPendiente.EditValue)
        'If teMontoSolicitado.EditValue > CantidadDisponible Then
        '    If MsgBox("El asociado solo tiene disponible $ " + CantidadDisponible.ToString + " , Desea Autorizar para Continuar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
        '        Return False
        '    End If

        '    Dim forma As New aso_frmAutoriza
        '    forma.tePass.EditValue = ""
        '    forma.ShowDialog()

        '    Dim ClaveAutoriza As String = forma.tePass.EditValue
        '    Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        '    Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
        '    Dim inArray As Byte() = provider.ComputeHash(bytes)
        '    provider.Clear()

        '    Dim sPassWord As String = Convert.ToBase64String(inArray)
        '    Dim Respuesta As String = blAdmon.ValidarUsuario("GERENTE", sPassWord)

        '    If Respuesta <> "Ok" Then
        '        MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
        '        Return False
        '    End If
        'End If

        ''VERIFICO SI LA FECHA DEL PRIMER PAGO ESTA HABIL AUN
        Dim FechaDescuentosPla As Date = bl.FechaDescuentoActiva()
        'If FechaDescuentosPla = Nothing Then
        '    MsgBox(String.Format("No hay ninguna fecha disponible para descuentos {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Return False
        'End If

        'If deFechaPrimerPago.EditValue < FechaDescuentosPla Then
        '    MsgBox(String.Format("La fecha del primer pago es menor a la fecha del del próximo descuento {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Return False
        'End If
        Return True
    End Function

    Private Sub LimpiarPantalla()
        entLiquidacion = New coo_PrestamosDesembolso
        entPrestamo = New coo_Prestamos
        entDesembolso = New coo_PrestamosDetalle
        entPlanPago = New List(Of coo_PrestamosPlanPagos)
        entSolFondos = New coo_SolicitudFondos
        entEmisionDesembolso = New List(Of coo_SolicitudesEmisionDesembolso)
    End Sub

    Private Sub CargaEntidades()

        With entPresEfectivo
            .IdSolicitud = teIdSolicitud.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .Numero = teNumSolicitud.EditValue
            .FechaSolicitud = deFecha.EditValue
            .MontoSolicitado = teMontoSolicitado.EditValue
            .TasaInteres = seTasa.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .IdLinea = cboLinea.EditValue
            .IdFuente = leFinanciamiento.EditValue
            .IdTipoCredito = leTipoCredito.EditValue
            .NumVale = teNumVale.EditValue
            .FechaPosibleDesembolso = deFechaPosibleDesembolso.EditValue
            .IdSucursal = gIdSucursal
            .ValorCuota = teValorCuota.EditValue
            .Observaciones = meObservaciones.EditValue
            .IdPlanilla = rgTipoAplicacion.EditValue
            .AplicaDescuento = chkDescPlanilla.EditValue

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With


        'LLENO LAS ENTIDADES DEL PRESTAMO
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        Dim pres As New Prestamo()
        Dim IdPrestamo As Integer, SaldoCapital As Decimal
        Dim NumeroPrestamo As String = teNumSolicitud.EditValue
        IdPrestamo = 0

        With pres
            .CapitalInicial = teMontoSolicitado.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = 0
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = 0.0
            .ImporteCuotaManejo = 0.0
            .ImporteCuotaAportacion = 0.0
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .Efectivo = True
            .CalculaPlanPagos()
        End With

        With entPrestamo
            .IdSolicitud = 0
            .IdPresEfectivo = teIdSolicitud.EditValue
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .Numero = NumeroPrestamo
            .MontoAprobado = teMontoSolicitado.EditValue
            .FechaAprobado = deFecha.EditValue
            .FechaOtorgado = deFechaPosibleDesembolso.EditValue
            .MontoDesembolsado = teMontoSolicitado.EditValue
            .MesesGracia = 0
            .DiasMoraGracia = 3
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .NumCuotas = sePlazoCuotas.EditValue
            .TasaInteres = seTasa.EditValue
            .TasaMora = 0
            .CuotaGestion = 0.0
            .ValorCuota = teValorCuota.EditValue
            .CuotaAportacion = 0.0
            .CuotaAhorro = 0.0
            .CuotaManejo = 0.0
            .CuotaOtros = 0.0
            .TasaSeguro = pres.TasaSeguroDeuda
            .TipoCuota = 2 ' la 2 es especial apra los prestamos automaticos
            .IdTipoAplicacion = rgTipoAplicacion.EditValue

            If .IdFormaPago = 1 Then
                .FechaVencimiento = DateAdd(DateInterval.Month, (pres.FrecuenciaPago * pres.NumeroCuotas), pres.FechaOtorgamiento)
            Else
                .FechaVencimiento = DateAdd(DateInterval.Day, (pres.FrecuenciaPago * pres.NumeroCuotas), pres.FechaOtorgamiento)
            End If

            .IdDepartamento = entAso.IdDepartamento
            .IdMunicipio = entAso.IdMunicipio
            .IdCanton = entAso.IdCanton
            .IdTecnico = 1
            .IdLinea = cboLinea.EditValue
            .IdFuente = leFinanciamiento.EditValue
            .IdTipoCartera = 1
            .IdSucursal = gIdSucursal
            .IdTipoPrestamo = 1
            .IdEstado = 1
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .ModificadoPor = objMenu.User
            .FechaHoraModificacion = Now
            .AplicaDescuento = chkDescPlanilla.EditValue
        End With

        With entLiquidacion
            .IdSolicitudFondo = 0
            .IdSolicitud = 0
            .IdDesembolso = 99
            .MontoDesembolso = teMontoSolicitado.EditValue
            .LiquidoDesembolso = teMontoSolicitado.EditValue
            .NumeroPrestamo = NumeroPrestamo
            .NumeroComprobante = "" 'se definirá en la DL
            .IdCuenta = 0
            .FechaMovimiento = deFechaPosibleDesembolso.EditValue
            .TipoDesembolso = 1
        End With


        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        With entDesembolso
            .IdPrestamo = IdPrestamo
            .ReferenciaPago = ""
            .Numero = "" 'se definirá en la DL
            .Fecha = deFechaPosibleDesembolso.EditValue
            .TipoAplicacion = 0
            .FechaContable = dFechaContable
            .ImportePagado = teMontoSolicitado.EditValue
            .CapitalPagado = 0.0
            SaldoCapital = 0
            .SaldoCapital = SaldoCapital + teMontoSolicitado.EditValue
            .DiasCalcInteres = 0
            .DiasCalcMora = 0
            .InteresPagado = 0.0
            .InteresPendiente = 0.0
            .InteresMoraPagado = 0.0
            .InteresMoraPendiente = 0.0
            .ValorSeguroPagado = 0.0
            .ValorSeguroPendiente = 0.0
            .ManejoPagado = 0.0
            .ManejoPendiente = 0.0
            .OtrosPagado = 0.0
            .OtrosPendiente = 0.0
            .CuotaAhorro = 0.0
            .CuotaAportacion = 0.0
            .ComisionCobranza = 0.0
            .Gestion = 0.0
            .TasaInteres = seTasa.EditValue
            .TasaInteresMora = 0
            .IdFormaPago = 1
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With

        For Each detalle As Cuota In pres.PlanPago
            Dim entDetalle As New coo_PrestamosPlanPagos
            entDetalle.NumCuota = detalle.NumeroCuota
            entDetalle.Fecha = detalle.FechaPago
            entDetalle.Valor = detalle.ImporteCuota
            entDetalle.TasaInteres = detalle.TasaInteres
            entDetalle.TasaMora = detalle.TasaMora
            entDetalle.Interes = detalle.ImporteInteres
            entDetalle.Capital = detalle.ImporteCapital
            entDetalle.Saldo = detalle.ImporteSaldo
            entDetalle.CuotaAportacion = detalle.ImporteCuotaAportacion
            entDetalle.CuotaAhorro = detalle.ImporteCuotaAhorro
            entDetalle.CuotaManejo = detalle.ImporteCuotaManejo
            entDetalle.CuotaOtros = detalle.ImporteCuotaOtros
            entDetalle.TasaSeguro = detalle.TasaSeguro
            entDetalle.CuotaSeguro = detalle.ImporteCuotaSeguro
            entPlanPago.Add(entDetalle)
        Next

        entPresRefinancia = New List(Of coo_PrestamoEfectivoRefinancia)
        For i = 0 To gvPrestamos.DataRowCount - 1
            Dim entDetalleA As New coo_PrestamoEfectivoRefinancia
            With entDetalleA
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .Correlativo = i
                .IdPrestamo = gvPrestamos.GetRowCellValue(i, "IdPrestamo")
                .Numero = gvPrestamos.GetRowCellValue(i, "Numero")
                .IdLinea = gvPrestamos.GetRowCellValue(i, "IdLinea")
                .SaldoCapital = gvPrestamos.GetRowCellValue(i, "SaldoCapital")
                .SaldoInteres = gvPrestamos.GetRowCellValue(i, "SaldoInteres")
                .SaldoInteresMora = gvPrestamos.GetRowCellValue(i, "SaldoInteresMora")
                .SaldoOtros = gvPrestamos.GetRowCellValue(i, "SaldoOtros")
                .SaldoSeguro = gvPrestamos.GetRowCellValue(i, "SaldoSeguro")
            End With
            entPresRefinancia.Add(entDetalleA)
        Next

        'entCancelacion = New List(Of coo_PrestamosDetalle)
        'For i = 0 To gvPrestamos.DataRowCount - 1
        '    Dim entDetalle5 As New coo_PrestamosDetalle
        '    With entDetalle5
        '        .IdPrestamo = gvPrestamos.GetRowCellValue(i, "IdPrestamo")
        '        .IdMov = blCaja.GetUltMovPrestamo(gvPrestamos.GetRowCellValue(i, "IdPrestamo")) + 1
        '        .TipoAplicacion = 1
        '        .ReferenciaPago = ""
        '        .Numero = "R/" & NumeroPrestamo & "/" 'La R es por Refinanciamiento
        '        .Fecha = deFecha.EditValue
        '        .FechaContable = deFecha.EditValue
        '        .ImportePagado = gvPrestamos.GetRowCellValue(i, "SaldoCapital") + gvPrestamos.GetRowCellValue(i, "SaldoInteres") + gvPrestamos.GetRowCellValue(i, "SaldoInteresMora") + gvPrestamos.GetRowCellValue(i, "SaldoSeguro") + gvPrestamos.GetRowCellValue(i, "SaldoOtros")
        '        .CapitalPagado = gvPrestamos.GetRowCellValue(i, "SaldoCapital")
        '        .SaldoCapital = 0.0
        '        .DiasCalcInteres = 0
        '        .DiasCalcMora = 0
        '        .InteresPagado = gvPrestamos.GetRowCellValue(i, "SaldoInteres")
        '        .InteresPendiente = 0.0
        '        .InteresMoraPagado = gvPrestamos.GetRowCellValue(i, "SaldoInteresMora")
        '        .InteresMoraPendiente = 0.0
        '        .ValorSeguroPagado = gvPrestamos.GetRowCellValue(i, "SaldoSeguro")
        '        .ValorSeguroPendiente = 0.0
        '        .ManejoPagado = 0.0
        '        .ManejoPendiente = 0.0
        '        .OtrosPagado = 0.0
        '        .OtrosPendiente = 0.0
        '        .CuotaAhorro = 0.0
        '        .CuotaAportacion = 0.0
        '        .TasaInteres = 0.0
        '        .TasaInteresMora = 0.0
        '        .IdFormaPago = 4
        '        .IdSucursal = gIdSucursal
        '        .CreadoPor = objMenu.User
        '        .FechaHoraCreacion = Now
        '    End With
        '    entCancelacion.Add(entDetalle5)
        'Next
    End Sub


    Private Sub sbInformacionAsociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbInformacionAsociado.Click
        Dim rpt As New pre_rptHistorialPrestamos
        rpt.DataSource = bl.rptHistorialPrestamo(teIdAsociado.EditValue, Today, 0)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()

        Dim rpt2 As New apo_rptEstadoCuentaAportacion
        rpt2.DataSource = blAporta.rptEstadoCuentaAportacion(teIdAsociado.EditValue, Today)
        rpt2.DataMember = ""
        rpt2.xrlEmpresa.Text = gsNombre_Empresa
        rpt2.ShowPreviewDialog()

        Dim rpt3 As New aho_rptListadoCuentasGeneral
        rpt3.DataSource = blAhorro.rptListadoCuentaAhorroAsociado(Today, teIdAsociado.EditValue)
        rpt3.DataMember = ""
        rpt3.xrlEmpresa.Text = gsNombre_Empresa
        rpt3.xrlTitulo.Text = "AL " & FechaToString(Today, Today)
        rpt3.xrlSucursal.Text = "-- TODAS LAS SUCURSALES --"
        rpt3.ShowPreviewDialog()
    End Sub



    Private Sub sbAutorizacionGerencia_Click(ByVal sender As Object, ByVal e As EventArgs)
        pre_frmDictamenGerencia.IdSolicitud = teIdSolicitud.EditValue
        pre_frmDictamenGerencia.ShowDialog()

        Dim rpt5 As New pre_rptAutorizacionGerencia
        rpt5.DataSource = bl.rptAutorizacionGerencia(teIdSolicitud.EditValue)
        rpt5.DataMember = ""
        rpt5.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt5.XrSubreport1.ReportSource.DataSource = bl.rptDictamenTecnicoFiadores(teIdSolicitud.EditValue)
        rpt5.XrSubreport2.ReportSource.DataSource = bl.rptSolicitudPrestamoGarantia(teIdSolicitud.EditValue)
        rpt5.xrlEmpresa.Text = gsNombre_Empresa
        rpt5.ShowPreviewDialog()

        Dim Rpt6 As New pre_rptResolucionConsejo
        Rpt6.DataSource = bl.rptResolucionConsejo(teIdSolicitud.EditValue)
        Rpt6.DataMember = ""
        Rpt6.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        Rpt6.XrSubreport1.ReportSource.DataSource = bl.rptDictamenTecnicoFiadores(teIdSolicitud.EditValue)
        Rpt6.XrSubreport2.ReportSource.DataSource = bl.rptSolicitudPrestamoGarantia(teIdSolicitud.EditValue)
        Rpt6.xrlEmpresa.Text = gsNombre_Empresa
        Rpt6.ShowPreviewDialog()
    End Sub

    Private Sub sbGenerarPlan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGenerarPlan.Click
        Dim pres As New Prestamo()
        With pres
            .CapitalInicial = teMontoSolicitado.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = 0
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = 0
            .ImporteCuotaManejo = 0
            .ImporteCuotaAportacion = 0
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .Efectivo = True

            .CalculaPlanPagos()
            Dim rpt As New pre_rptPlanPago
            Dim plan As New DataTable
            plan.Columns.Add("NumeroCuota").DataType = Type.GetType("System.Int32")
            plan.Columns.Add("FechaPago").DataType = Type.GetType("System.DateTime")
            plan.Columns.Add("ImporteCuota").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteCuotaSeguro").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteCuotaAportacion").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteCuotaAhorro").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteCuotaManejo").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteInteres").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteCapital").DataType = Type.GetType("System.Decimal")
            plan.Columns.Add("ImporteSaldo").DataType = Type.GetType("System.Decimal")
            Dim workRow As DataRow
            For Each detalle As Cuota In pres.PlanPago
                workRow = plan.NewRow()
                workRow("NumeroCuota") = detalle.NumeroCuota
                workRow("FechaPago") = detalle.FechaPago
                workRow("ImporteCuota") = detalle.ImporteCuota
                workRow("ImporteCuotaSeguro") = detalle.ImporteCuotaSeguro
                workRow("ImporteCuotaAportacion") = detalle.ImporteCuotaAportacion
                workRow("ImporteCuotaAhorro") = detalle.ImporteCuotaAhorro
                workRow("ImporteCuotaManejo") = detalle.ImporteCuotaManejo
                workRow("ImporteInteres") = detalle.ImporteInteres
                workRow("ImporteCapital") = detalle.ImporteCapital
                workRow("ImporteSaldo") = detalle.ImporteSaldo
                plan.Rows.Add(workRow)
            Next
            rpt.DataSource = plan
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlMontoOtorgado.Text = teMontoSolicitado.EditValue
            rpt.xrlNumeroCuotas.Text = sePlazoCuotas.EditValue
            rpt.xrlTasa.Text = seTasa.EditValue
            rpt.xrlFormaPago.Text = IIf(rgFormaPago.EditValue = 1, "Mensual", "Por días")
            rpt.xrlFechaOtorgado.Text = deFechaPosibleDesembolso.Text
            rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
            rpt.xrlUsuario.Text = objMenu.User
            rpt.ShowPreviewDialog()
            plan.Dispose()
            rpt.Dispose()
        End With
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        If teNumSolicitud.Properties.ReadOnly = False Then
            frmConsultaAsociados.ShowDialog()
            teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
            teNumAsociado_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated, teIdAsociado.Validated

        If teIdAsociado.EditValue = 0 Then
            Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
            If dt.Rows.Count = 0 Then
                Exit Sub
            End If
            teIdAsociado.EditValue = dt.Rows(0).Item("IdAsociado")
        End If

        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            Dim dtAlerta As DataTable = blAdmon.GetAlertasAsociadoSolicitud(teIdAsociado.EditValue, deFecha.EditValue)
            If dtAlerta.Rows.Count > 0 Then
                Dim sDescripcion As String
                sDescripcion = dtAlerta.Rows(0).Item("Descripcion")
                MsgBox("Este Cliente tiene una Alerta Definida" & Chr(13) & "ALERTA: " & sDescripcion, MsgBoxStyle.Information)
                If dtAlerta.Rows(0).Item("Contrasenia") = True Then

                    Dim forma As New aso_frmAutoriza
                    forma.tePass.EditValue = ""
                    forma.ShowDialog()

                    Dim ClaveAutoriza As String = forma.tePass.EditValue
                    Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
                    Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
                    Dim inArray As Byte() = provider.ComputeHash(bytes)
                    provider.Clear()

                    Dim sPassWord As String = Convert.ToBase64String(inArray)
                    Dim Respuesta As String = blAdmon.ValidarUsuario("GERENTE", sPassWord)

                    If Respuesta <> "Ok" Then
                        MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            End If
        End If

        teNumAsociado.EditValue = entAsociado.Numero
        teNombreAsociado.EditValue = entAsociado.Nombres + " " + entAsociado.Apellidos

        If entPresEfectivo.Anulado Then
            teNombreAsociado.EditValue = "***PRESTAMOS ANULADO ***"
        End If

        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            teNumSolicitud.EditValue = entAsociado.Numero & "EF" & (blAsoc.MaxCorrelativoSolEfectivo(entAsociado.Numero) + 1).ToString.PadLeft(4, "0")
        End If


        'VERIFICO LOS SALDOS DEL ASOCIADO
        'teSaldoAhorros.EditValue = 0.0
        'teSaldoAportaciones.EditValue = 0.0
        'teSaldoDeudas.EditValue = 0.0
        'teSaldoDisponible.EditValue = 0.0
        'teSaldoPendiente.EditValue = 0.0
        'teSaldoCaja.EditValue = 0.0

        'If teIdAsociado.EditValue > 0 And Not SiEsNulo(deFechaPosibleDesembolso.EditValue, Nothing) = Nothing Then
        '    Dim entSaldoCredito As DataTable = blAporta.rptSolicitudRetiro(teIdAsociado.EditValue, deFechaPosibleDesembolso.EditValue)
        '    teSaldoAhorros.EditValue = entSaldoCredito.Rows(0).Item("TotalAhorro")
        '    teSaldoAportaciones.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones")
        '    teSaldoDeudas.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")
        '    teSaldosFiador.EditValue = entSaldoCredito.Rows(0).Item("SaldoComoFiador")
        '    teSaldoDisponible.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones") - entSaldoCredito.Rows(0).Item("TotalDeducciones")
        '    teSaldoPendiente.EditValue = entSaldoCredito.Rows(0).Item("DescuentosPendiente")
        '    teSaldoCaja.EditValue = bl.ObtenerSaldoCaja(deFecha.EditValue)
        'End If

        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            gcPrestamos.DataSource = bl.GetSaldoPrestamoRapidoAsociado(teIdAsociado.EditValue, deFecha.EditValue, cboLinea.EditValue, 0, 0)
        End If

    End Sub
    Private Sub CargaCombos()
        objCombos.coo_LineasEfectivo(cboLinea, "TipoLinea=1", "")
        objCombos.coo_Fuentes(leFinanciamiento, "")
        objCombos.coo_TipoCredito(leTipoCredito, "")
        objCombos.coo_Lineas(leLinea, "")
    End Sub
    Private Sub ActivarControles(ByVal Tipo As Boolean)
        teIdSolicitud.Properties.ReadOnly = True
        teNumAsociado.Properties.ReadOnly = Not Tipo
        teNumSolicitud.Properties.ReadOnly = Not Tipo
        teNumVale.Properties.ReadOnly = Not Tipo
        deFecha.Properties.ReadOnly = Not Tipo

        For Each ctrl In XtraTabPage7.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.RadioGroup Then
                CType(ctrl, DevExpress.XtraEditors.RadioGroup).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.PictureEdit Then
                CType(ctrl, DevExpress.XtraEditors.PictureEdit).Properties.ReadOnly = Not Tipo
            End If
        Next

        teNombreAsociado.Properties.ReadOnly = True
        teValorCuota.Properties.ReadOnly = True
        sePlazoCuotas.Properties.ReadOnly = True
        seFrecuencia.Properties.ReadOnly = True
    End Sub
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdSolicitudStart As Integer = 0
        Dim IdSolicitudEnd As Integer = 0
        If TipoAvance = -1 Then
            IdSolicitudStart = objFunciones.ObtenerPrimerId("coo_PrestamosEfectivo ", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudStart Then
                teIdSolicitud.EditValue += 1
            End If
        End If
        If TipoAvance = 1 Then
            IdSolicitudEnd = objFunciones.ObtenerUltimoId("coo_PrestamosEfectivo ", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudEnd Then
                teIdSolicitud.EditValue -= 1
            End If
        End If
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        teIdSolicitud.EditValue = bl.ObtenerIdSolicitudEfectivo(teIdSolicitud.EditValue, TipoAvance)
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        entPresEfectivo = objTablas.coo_PrestamosEfectivoSelectByPK(teIdSolicitud.EditValue)
        With entPresEfectivo
            teIdSolicitud.EditValue = .IdSolicitud
            teIdAsociado.EditValue = .IdAsociado
            'teNumAsociado.EditValue = .Numero
            teNumAsociado_Validated(teIdAsociado, New EventArgs)
            teNumSolicitud.EditValue = .Numero
            teNumVale.EditValue = .NumVale
            deFecha.EditValue = .FechaSolicitud
            deFechaPrimerPago.EditValue = .FechaPrimerPago
            meObservaciones.EditValue = .Observaciones
            teMontoSolicitado.EditValue = .MontoSolicitado
            seTasa.EditValue = .TasaInteres
            sePlazoCuotas.EditValue = .NumeroCuotas
            rgFormaPago.EditValue = .IdFormaPago
            seFrecuencia.EditValue = .FrecuenciaPago
            rgTipoCuota.EditValue = .TipoCuota
            cboLinea.EditValue = .IdLinea
            rgTipoAplicacion.EditValue = .IdPlanilla
            leFinanciamiento.EditValue = .IdFuente
            leTipoCredito.EditValue = .IdTipoCredito
            deFechaPosibleDesembolso.EditValue = .FechaPosibleDesembolso
            teValorCuota.EditValue = .ValorCuota
            chkDescPlanilla.EditValue = .AplicaDescuento
        End With
        gcPrestamos.DataSource = bl.GetSaldoPrestamoRapidoAsociado(teIdAsociado.EditValue, deFecha.EditValue, cboLinea.EditValue, 0, teIdSolicitud.EditValue)
    End Sub



    Private Sub CalcularCuota()
        Dim ValorCuota As Decimal = 0.0, CuotaSeguro As Decimal = 0.0, MaxSeguro As Decimal = 0.0
        If teMontoSolicitado.EditValue = 0 Or sePlazoCuotas.EditValue = 0 Or deFechaPosibleDesembolso.EditValue = Nothing _
         Or rgFormaPago.EditValue = 0 Or seFrecuencia.EditValue = 0 Then
            teValorCuota.EditValue = 0.0
            Exit Sub
        End If
        'If teMontoSolicitado.EditValue <= 75 Then
        '    seTasa.EditValue = 0.0
        'End If

        Dim pres As New Prestamo()
        With pres
            .CapitalInicial = teMontoSolicitado.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = 0
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = 0
            .ImporteCuotaManejo = 0
            .ImporteCuotaAportacion = 0
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .Efectivo = True

            .CalculaPlanPagos()
            teValorCuota.EditValue = pres.ValorCuota
        End With
    End Sub

    Private Sub teMontoSolicitado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoSolicitado.EditValueChanged
        CalcularCuota()
        teNumAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub sePlazoCuotas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sePlazoCuotas.EditValueChanged
        ' CalculaCuotaAhorro()
    End Sub

    Private Sub seTasa_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTasa.EditValueChanged
        ' CalculaCuotaAhorro()
        CalcularCuota()
    End Sub

    Private Sub teMontoSolicitado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoSolicitado.Validated, _
    seTasa.Validated, deFechaPosibleDesembolso.Validated, sePlazoCuotas.Validated, rgFormaPago.Validated, seFrecuencia.Validated, _
       rgTipoCuota.EditValueChanged

        If teMontoSolicitado.EditValue <= 75 Then
            seTasa.EditValue = 0
        End If
        CalcularCuota()
    End Sub


    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub deFechaPosibleDesembolso_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deFechaPosibleDesembolso.EditValueChanged
        teNumAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub rgFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgFormaPago.SelectedIndexChanged
        CalcularCuota()
    End Sub

    Private Sub cboLinea_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLinea.EditValueChanged
        Dim entLin = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)
        seTasa.EditValue = entLin.TasaInteres
        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            gcPrestamos.DataSource = bl.GetSaldoPrestamoRapidoAsociado(teIdAsociado.EditValue, deFecha.EditValue, cboLinea.EditValue, 0, 0)
        End If
    End Sub

    Private Sub sbAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAnular.Click

        If Not rbMenu.qbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            Exit Sub
        End If

        If entPresEfectivo.Anulado Then
            MsgBox(String.Format("El Prestamo ya se encuentra anulado", Chr(13)), MsgBoxStyle.Critical, "Error al Anular")
            Exit Sub
        End If

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If dFechaContable > deFecha.EditValue Then
        '    MsgBox("No es posible anular el préstamo en efectivo, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al anular el registro")
        '    Exit Sub
        'End If

        Dim UltMovPrestamo As Integer
        Dim IdPrestamo As Integer = bl.ExisteNumPrestamo(teNumSolicitud.EditValue)
        UltMovPrestamo = bl.GetUltMovPrestamo(IdPrestamo)

        If UltMovPrestamo > 1 Then
            MsgBox("El Prestamo ya posee Pagos , No es posible anularlo", MsgBoxStyle.Critical, "Imposible continuar")
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de anular el Crédito en Efectivo?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            IdPrestamo = bl.ExisteNumPrestamo(teNumSolicitud.EditValue)
            Dim IdSolFondos As Integer = bl.ObtenerIdSolFondosEfectivo(teIdSolicitud.EditValue)
            bl.AnulaPresEfectivo(teIdSolicitud.EditValue, IdPrestamo)

            If msj = "" Then
                MsgBox("El prestamo ha sido anulado con éxito", MsgBoxStyle.Information, "Nota")
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible anular el crédito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub teNumAsociado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.EditValueChanged

    End Sub
End Class
