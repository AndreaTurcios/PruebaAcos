Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL
Public Class pre_frmResolucionConsejo
    Dim entResolucion As coo_Resoluciones
    Dim _IdSolicitud As Integer = 0, ds As DataSet
    Dim bl As New PrestamosBLL()
    ReadOnly blAporta As New AportacionesBLL()
    Dim dtParam As DataTable = blAporta.ObtenerParametrosGenerales()
    Dim blAdmon As New AdmonBLL(), entSol As coo_Solicitudes

    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Private _Consulta As System.Boolean
    Public Property Consulta() As System.Boolean
        Get
            Return _Consulta
        End Get
        Set(ByVal value As System.Boolean)
            _Consulta = value
        End Set
    End Property


    Private Sub pre_frmResolucionConsejo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        entSol = objTablas.coo_SolicitudesSelectByPK(IdSolicitud)
        CargaControles(0)
        ActivarControles()
        CalcularCuota()
        cboEstado.Focus()
        ds = blAdmon.ObtieneCorrelativos(gIdSucursal)
        teActa.EditValue = ds.Tables(4).Rows(0).Item("UltimoValor") + 1
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_EstadoSolicitud(cboEstado, "")
        objCombos.coo_Lineas(cboLinea, "")
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entResolucion = objTablas.coo_ResolucionesSelectByPK(IdSolicitud)

        If entResolucion.IdFormaPagoConsejo = 0 Then
            cboEstado.EditValue = 1
            teActa.EditValue = ""
            meRecomendaciones.EditValue = ""
            teTipoTramite.EditValue = ""
            meResolucion.EditValue = ""
            meOtrasCondiciones.EditValue = ""
            deFecha.EditValue = entSol.FechaSolicitud
            teMonto.EditValue = entSol.MontoSolicitado
            deFechaPrimerPago.EditValue = entSol.FechaPrimerPago

            seTasa.EditValue = entSol.TasaInteres
            teCuotaAportacion.EditValue = entSol.CuotaAportacion
            teCuotaManejo.EditValue = entSol.CuotaManejo
            teCuotaAhorro.EditValue = entSol.CuotaAhorro
            chkIncluirSeguro.EditValue = entSol.IncluyeTasaSeguro
            seNumeroCuotas.EditValue = entSol.NumeroCuotas
            rgFormaPago.EditValue = entSol.IdFormaPago
            seFrecuencia.EditValue = entSol.FrecuenciaPago
            seMesesGracia.EditValue = 0
            teValorCuota.EditValue = entSol.ValorCuota
            cboLinea.EditValue = entSol.IdLinea
            CargaEntidadVacia()
            If bl.ExisteResolucionSolicitud(IdSolicitud) < 1 Then
                Dim msj As String = ""
                msj = bl.InsertaResolucionSolicitud(entResolucion)
                If msj <> "" Then
                    MsgBox(String.Format("No fue posible actualizar la resolución{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                    Return
                End If
            End If
        Else
            With entResolucion
                cboEstado.EditValue = .TipoResolucionConsejo
                meRecomendaciones.EditValue = .RecomendacionConsejo
                teActa.EditValue = .ConsejoActa
                teTipoTramite.EditValue = .TipoTramite
                meResolucion.EditValue = .ConsejoResolucion
                meOtrasCondiciones.EditValue = .OtrasConsejo
                deFecha.EditValue = .FechaResolucionConsejo
                teMonto.EditValue = .MontoConsejo
                seTasa.EditValue = .TasaConsejo
                teCuotaAportacion.EditValue = entSol.CuotaAportacion
                teCuotaManejo.EditValue = entSol.CuotaManejo
                teCuotaAhorro.EditValue = entSol.CuotaAhorro
                chkIncluirSeguro.EditValue = entSol.IncluyeTasaSeguro
                seNumeroCuotas.EditValue = .CuotasConsejo
                rgFormaPago.EditValue = .IdFormaPagoConsejo
                seFrecuencia.EditValue = .FrecuenciaPagoConsejo
                seMesesGracia.EditValue = .MesGraciaConsejo
                teValorCuota.EditValue = entSol.ValorCuota
                cboLinea.EditValue = entSol.IdLinea
            End With

        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If

        entResolucion.IdEstado = cboEstado.EditValue
        entResolucion.ConsejoActa = teActa.EditValue
        entResolucion.ConsejoResolucion = meResolucion.EditValue
        entResolucion.RecomendacionConsejo = meRecomendaciones.EditValue
        entResolucion.OtrasConsejo = meOtrasCondiciones.EditValue
        entResolucion.MontoConsejo = teMonto.EditValue
        entResolucion.TasaConsejo = seTasa.EditValue
        entResolucion.CuotasConsejo = seNumeroCuotas.EditValue
        entResolucion.FrecuenciaPagoConsejo = seFrecuencia.EditValue
        entResolucion.IdFormaPagoConsejo = rgFormaPago.EditValue
        entResolucion.MesGraciaConsejo = seMesesGracia.EditValue
        entResolucion.TipoTramite = teTipoTramite.EditValue
        entResolucion.FechaResolucionConsejo = deFecha.EditValue

        If cboEstado.EditValue = 2 Then  'la solicitud es aprobada por el consejo de admon
            entResolucion.FechaAprobacion = deFecha.EditValue
            entResolucion.MontoAprobado = teMonto.EditValue
            entResolucion.AutorizaComite = True
            entResolucion.AutorizaGerencia = False
            entResolucion.AutorizaConsejo = True
            entResolucion.Aprobada = True
            entResolucion.NumeroCuotasAprobada = seNumeroCuotas.EditValue
            entResolucion.TasaInteresAprobada = seTasa.EditValue
            entResolucion.IdFormaPagoAprobado = rgFormaPago.EditValue
            entResolucion.FrecuenciaPagoAprobado = seFrecuencia.EditValue
            bl.ActualizaActaResolucion(teActa.EditValue)
        End If
        If cboEstado.EditValue = 4 Then  'denegada
            entResolucion.FechaAprobacion = Nothing
            entResolucion.MontoAprobado = 0
            entResolucion.Aprobada = False
            entResolucion.NumeroCuotasAprobada = 0
            entResolucion.TasaInteresAprobada = 0
        End If

        objTablas.coo_ResolucionesUpdate(entResolucion)

        If MsgBox("¿Imprimir resolución del consejo?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Dim dtEstructuras As DataTable = bl.ObtenerParametrosEstructuras()

        Dim rpt As New pre_rptResolucionConsejoAdministracion
        rpt.DataMember = ""
        rpt.DataSource = bl.rptResolucionConsejoAdministracion(IdSolicitud)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport1.ReportSource.DataSource = bl.rptFiadores(IdSolicitud)
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
        Close()
    End Sub

    Function DatosValidos() As Boolean
        If meRecomendaciones.Text = "" Then
            MsgBox(String.Format("Debe especificar una Recomendación {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            meRecomendaciones.Focus()
            Return False
        End If
        If teMonto.EditValue <= 0 And cboEstado.EditValue <> 3 Then
            MsgBox(String.Format("Debe especificar el Monto a Aprobar{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teMonto.Focus()
            Return False
        End If

        'VERIFICO SI LA FECHA DEL PRIMER PAGO ESTA HABIL AUN
        Dim FechaDescuentosPla As Date = bl.FechaDescuentoActiva()
        If FechaDescuentosPla = Nothing Then
            MsgBox(String.Format("No hay ninguna fecha disponible para descuentos {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Return False
        End If

        If deFechaPrimerPago.EditValue < FechaDescuentosPla Then
            MsgBox(String.Format("La fecha del primer pago es menor a la fecha del del próximo descuento {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Return False
        End If

        Dim EntLin As coo_Lineas = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)



        If seTasa.EditValue = 0 And cboEstado.EditValue <> 3 And EntLin.TipoLinea <> 3 Then
            MsgBox("Debe de especificar la Tasa de Interés para el préstamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            seTasa.Focus()
            Return False
        End If

        If cboLinea.EditValue = 10 Then
            MsgBox("El Prestamo es Automatico , no necesita recomendación" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            Return False
        End If

        If seNumeroCuotas.EditValue <= 0 And cboEstado.EditValue <> 3 Then
            MsgBox("Debe especificar el Número de cuotas para El Prestamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            seNumeroCuotas.Focus()
            Return False
        End If
        If deFecha.EditValue < entSol.FechaSolicitud Then
            MsgBox("La Fecha de Aprobación no Puede ser Inferior a la fecha de la Solicitud" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            seNumeroCuotas.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidadVacia()
        With entResolucion
            .IdSolicitud = IdSolicitud
            .IdEstado = 1
            .FechaAprobacion = deFecha.EditValue
            .TipoTramite = teTipoTramite.EditValue
            .RecomendacionGerente = ""
            .ResolucionGerente = ""
            .OtrasGerente = ""
            .FechaResolucionGerente = deFecha.EditValue
            .TipoResolucionGerente = 1
            .RecomendacionComite = ""
            .ComiteSesion = ""
            .ComiteResolucion = ""
            .ComiteActa = ""
            .OtrasComite = ""
            .FechaResolucionComite = deFecha.EditValue
            .TipoResolucionComite = 1
            .RecomendacionConsejo = ""
            .ConsejoSesion = ""
            .ConsejoActa = ""
            .ConsejoResolucion = ""
            .OtrasConsejo = ""
            .FechaResolucionConsejo = deFecha.EditValue
            .TipoResolucionConsejo = 1
            .MontoGerente = 0
            .CuotasGerente = 0
            .TasaGerente = 0
            .IdFormaPagoGerente = 1
            .FrecuenciaPagoGerente = 1
            .MesGraciaGerente = 0
            .MontoComite = 0
            .CuotasComite = 0
            .TasaComite = 0
            .IdFormaPagoComite = 1
            .FrecuenciaPagoComite = 1
            .MesGraciaComite = 0
            .MontoConsejo = 0
            .CuotasConsejo = 0
            .TasaConsejo = 0
            .IdFormaPagoConsejo = 1
            .FrecuenciaPagoConsejo = 1
            .MesGraciaConsejo = 0
            .AutorizaGerencia = 0
            .AutorizaComite = 0
            .AutorizaConsejo = 0
            .Aprobada = 0
            .MontoAprobado = 0
            .TasaInteresAprobada = 0
            .NumeroCuotasAprobada = 0
            .IdFormaPagoAprobado = 1
            .FrecuenciaPagoAprobado = 1
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .FechaHoraModificacion = Now
            .ModificadoPor = objMenu.User
            .IdSucursal = gIdSucursal
        End With
    End Sub

    Private Sub ActivarControles()
        teActa.Properties.ReadOnly = Consulta
        meRecomendaciones.Properties.ReadOnly = Consulta
        teTipoTramite.Properties.ReadOnly = False
        meResolucion.Properties.ReadOnly = Consulta
        meOtrasCondiciones.Properties.ReadOnly = Consulta
        cboEstado.Properties.ReadOnly = Consulta
        deFecha.Properties.ReadOnly = Consulta
        teMonto.Properties.ReadOnly = Consulta
        seTasa.Properties.ReadOnly = Consulta
        teCuotaAportacion.Properties.ReadOnly = Consulta
        teCuotaManejo.Properties.ReadOnly = Consulta
        teCuotaAhorro.Properties.ReadOnly = Consulta
        chkIncluirSeguro.Properties.ReadOnly = Consulta
        seNumeroCuotas.Properties.ReadOnly = Consulta
        rgFormaPago.Properties.ReadOnly = Consulta
        seFrecuencia.Properties.ReadOnly = Consulta
        seMesesGracia.Properties.ReadOnly = Consulta
        teValorCuota.Properties.ReadOnly = True
        cboLinea.Properties.ReadOnly = True
    End Sub

    Private Sub CalcularCuota()
        Dim ValorCuota As Decimal = 0.0
        Dim CuotaSeguro As Decimal = 0.0
        Dim maxSeguro As Decimal = 0.0
        If teMonto.EditValue = 0 Or seNumeroCuotas.EditValue = 0 Or deFecha.EditValue = Nothing _
         Or rgFormaPago.EditValue = 0 Or seFrecuencia.EditValue = 0 Then
            teValorCuota.EditValue = 0.0
            Exit Sub
        End If
        Dim pres As New Prestamo()
        With pres
            .CapitalInicial = teMonto.EditValue
            .NumeroCuotas = seNumeroCuotas.EditValue
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFecha.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = 2
            .ImporteCuotaAhorro = teCuotaAhorro.EditValue
            .ImporteCuotaManejo = teCuotaManejo.EditValue
            .ImporteCuotaAportacion = teCuotaAportacion.EditValue
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue

            Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)
            If entLinea.CuotaSinCentavos Then
                .CuotaSinCentavos = True
            End If

            If chkIncluirSeguro.EditValue = True Then
                MaxSeguro = dtParam.Rows(0).Item("MaximoAsegurablePrestamo")
                .TasaSeguroDeuda = dtParam.Rows(0).Item("TasaSeguro")
                If teMonto.EditValue > maxSeguro Then
                    CuotaSeguro = Decimal.Round(maxSeguro * dtParam.Rows(0).Item("TasaSeguro") / 1000, 2)
                Else
                    CuotaSeguro = Decimal.Round(teMonto.EditValue * dtParam.Rows(0).Item("TasaSeguro") / 1000, 2)
                End If
            End If
            .CalculaPlanPagos()
            teValorCuota.EditValue = pres.ValorCuota
        End With
    End Sub

    Private Sub teMonto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMonto.Validated, _
    seTasa.Validated, deFecha.Validated, seNumeroCuotas.Validated, rgFormaPago.Validated, seFrecuencia.Validated, _
    teCuotaAportacion.Validated, teCuotaManejo.Validated, teCuotaAhorro.Validated, chkIncluirSeguro.Validated
        If teMonto.EditValue > entSol.MontoSolicitado Then
            If MsgBox("El Monto sobrepasa el Valor Solicitado, Desea Continuar?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
                teMonto.EditValue = entSol.MontoSolicitado
            End If
        End If
        CalcularCuota()
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSalir.Click
        Close()
    End Sub

    'Private Sub cboEstado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstado.EditValueChanged
    '    If cboEstado.EditValue = 3 Then
    '        teMonto.EditValue = 0
    '        seTasa.EditValue = 0
    '        sePlazoCuotas.EditValue = 1
    '        rgFormaPago.EditValue = 1
    '        seFrecuencia.EditValue = 1
    '        seMesesGracia.EditValue = 0
    '        teValorCuota.EditValue = 0
    '    Else
    '        teMonto.EditValue = entSol.MontoSolicitado
    '        seTasa.EditValue = entSol.TasaInteres
    '        sePlazoCuotas.EditValue = entSol.NumeroCuotas
    '        rgFormaPago.EditValue = entSol.IdFormaPago
    '        seFrecuencia.EditValue = entSol.FrecuenciaPago
    '        teValorCuota.EditValue = entSol.ValorCuota
    '    End If
    'End Sub
End Class