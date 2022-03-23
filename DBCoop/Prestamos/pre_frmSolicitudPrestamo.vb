Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL
Imports System.Diagnostics
Public Class pre_frmSolicitudPrestamo
    Dim entSolicitud As coo_Solicitudes
    Dim bl As New PrestamosBLL()
    Dim blAdmon As New AdmonBLL()
    ReadOnly blAporta As New AportacionesBLL(), blAhorro As New AhorrosBLL()
    Dim blAsoc As New AsociadosBLL(), dtParam As DataTable = blAporta.ObtenerParametrosGenerales()
    Dim entObligaciones As List(Of coo_SolicitudesObligacion)
    Dim entBienes As List(Of coo_SolicitudesBien), IdAsociado As Integer = 0
    Dim entReferencias As List(Of coo_SolicitudesReferencia)
    Dim entGarantias As List(Of coo_SolicitudesGarantias)
    Dim entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso), entLinea As coo_Lineas
    Dim entDetalleIngresos As List(Of coo_SolicitudesDetalleIngresos)
    Dim entDetalleGastos As List(Of coo_SolicitudesDetalleGastos)

    Private Sub pre_frmSolicitudPrestamo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        teIdSolicitud.EditValue = objFunciones.ObtenerUltimoId("COO_Solicitudes", "IdSolicitud")
        CargaControles(0)
        gcObligaciones.DataSource = bl.GetObligacionesSolicitud(teIdSolicitud.EditValue)
        gcBienes.DataSource = bl.GetBienesSolicitud(teIdSolicitud.EditValue)
        gcReferencias.DataSource = bl.GetReferenciasSolicitud(teIdSolicitud.EditValue)
        gcGarantias.DataSource = bl.GetGarantiasSolicitud(teIdSolicitud.EditValue)
        gcDesembolso.DataSource = bl.GetEmisionDesembolso(teIdSolicitud.EditValue)

        'gcDetalleIngresos.DataSource = bl.GetDetalleIngresosSolicitud(teIdSolicitud.EditValue)
        'gcDetalleGastos.DataSource = bl.GetDetalleGastosSolicitud(teIdSolicitud.EditValue)
        ActivarControles(False)
    End Sub

    Private Sub pre_frmSolicitudPrestamo_Nuevo() Handles Me.Nuevo
        IdAsociado = teIdAsociado.EditValue
        gvObligaciones.CancelUpdateCurrentRow()
        gvObligaciones.AddNewRow()
        gvBienes.CancelUpdateCurrentRow()
        gvBienes.AddNewRow()
        gvReferencias.CancelUpdateCurrentRow()
        gvReferencias.AddNewRow()
        gvGarantias.CancelUpdateCurrentRow()
        gvGarantias.AddNewRow()
        gvDesembolso.CancelUpdateCurrentRow()
        gvDesembolso.AddNewRow()
        'gvDetalleIngresos.CancelUpdateCurrentRow()
        'gvDetalleIngresos.AddNewRow()
        'gvDetalleGastos.CancelUpdateCurrentRow()
        'gvDetalleGastos.AddNewRow()

        ActivarControles(True)
        entSolicitud = New coo_Solicitudes

        gcObligaciones.DataSource = bl.GetObligacionesSolicitud(-1)
        gcBienes.DataSource = bl.GetBienesSolicitud(-1)
        gcReferencias.DataSource = bl.GetReferenciasSolicitud(-1)
        gcGarantias.DataSource = bl.GetGarantiasSolicitud(-1)
        gcDesembolso.DataSource = bl.GetEmisionDesembolso(-1)

        'gcDetalleIngresos.DataSource = bl.GetDetalleIngresosSolicitud(-1)
        'gcDetalleGastos.DataSource = bl.GetDetalleGastosSolicitud(-1)

        teIdSolicitud.EditValue = 0 'objFunciones.ObtenerUltimoId("Coo_Solicitudes", "IdSolicitud") + 1
        teNumSolicitud.EditValue = ""
        teNumAsociado.EditValue = ""
        teIdAsociado.EditValue = 0
        teNombreAsociado.EditValue = ""
        deFecha.EditValue = Today
        deFechaRecepcion.EditValue = Today
        cboTipoTrabajo.EditValue = 1
        teLugarTrabajo.EditValue = ""
        teDireccionTrabajo.EditValue = ""
        teTelefonoTrabajo.EditValue = ""
        teCargo.EditValue = ""
        teTiempoNegocio.EditValue = ""
        teSueldo.EditValue = 0.0
        teComision.EditValue = 0.0
        teNegocio.EditValue = 0.0
        teOtrosIngresos.EditValue = 0.0
        teAlimentacion.EditValue = 0.0
        teCasa.EditValue = 0.0
        teServicios.EditValue = 0.0
        teOtrosPrestamos.EditValue = 0.0
        teColegiatura.EditValue = 0.0
        teTransporte.EditValue = 0.0
        teTarjetaCredito.EditValue = 0.0

        teTotalIngresos.EditValue = 0.0
        teTotalEgresos.EditValue = 0.0
        teLiquidez.EditValue = 0.0

        teEfectivo.EditValue = 0.0
        teBancos.EditValue = 0.0
        teCuentaCobrar.EditValue = 0.0
        teMercancias.EditValue = 0.0
        teBienesInmuebles.EditValue = 0.0
        teOtrosBienes.EditValue = 0.0
        teTotalActivos.EditValue = 0.0
        tePrestamosPagar.EditValue = 0.0
        teCuentasPagar.EditValue = 0.0
        teProveedores.EditValue = 0.0
        teTotalPasivo.EditValue = 0.0
        teCapital.EditValue = 0.0
        tePasivoCapital.EditValue = 0.0


        teMontoSolicitado.EditValue = 0.0
        rgFormaPago.EditValue = 1
        rgTipoAplicacion.EditValue = 3
        seTasa.EditValue = 0.0
        sePlazoCuotas.EditValue = 1
        teDetalleFormaPago.EditValue = ""
        teDestino.EditValue = ""
        cboLinea.EditValue = 1
        leTecnico.EditValue = 1
        leFinanciamiento.EditValue = 1
        leTipoCredito.EditValue = 1
        teCuotaAportacion.EditValue = dtParam.Rows(0).Item("CuotaAportacion")
        teValorCuota.EditValue = 0.0
        teCuotaAhorro.EditValue = 0.0
        teTasaManejo.EditValue = 0.0
        chkIncluirSeguro.EditValue = True
        chkDescPlanilla.EditValue = True
        deFechaPosibleDesembolso.EditValue = Today
        leTipoContratacion.EditValue = 1
        teJefeInmediato.EditValue = ""
        teCapitalInvertido.EditValue = 0.0
        teDireccionNegocio.EditValue = ""
        teTelefonoNegocio.EditValue = ""
        teCasasComerciales.EditValue = ""
        deFechaPrimerPago.EditValue = Today
        cboLinea.EditValue = 1
        seFrecuencia.EditValue = 1
        Dim FechaDescuentosPla As Date = bl.FechaDescuentoActiva()
        deFechaPrimerPago.EditValue = FechaDescuentosPla


        teNumAsociado.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Guardar() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = bl.InsertaSolicitudPrestamo(entSolicitud, entObligaciones, entBienes, entReferencias, entGarantias _
                                              , entEmisionDesembolso)
            If msj = "" Then
                MsgBox("La solicitud ha sido guardada con éxito", MsgBoxStyle.Information)
                teIdSolicitud.EditValue = entSolicitud.IdSolicitud
            Else
                MsgBox(String.Format("No fue posible actualizar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = bl.UpdateSolicitudPrestamo(entSolicitud, entObligaciones, entBienes, entReferencias, entGarantias, entEmisionDesembolso)
            If msj = "" Then
                MsgBox("La solicitud de crédito ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la solicitud de crédito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        IdAsociado = teIdAsociado.EditValue
        gcGarantias.DataSource = bl.GetGarantiasSolicitud(teIdSolicitud.EditValue)
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Consulta() Handles Me.Consulta
        frmConsultaSolicitudes.ShowDialog()
        teIdSolicitud.EditValue = frmConsultaSolicitudes.IdSolicitud
        teNumSolicitud.EditValue = frmConsultaSolicitudes.NumeroSol
        CargaControles(0)

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Editar() Handles Me.Editar
        If bl.ExisteSolicitudFondos(teIdSolicitud.EditValue) > 0 Then
            MsgBox("A la solicitud ya le fue aplicada la Solicitud de Fondos, No es Posible Modicarla", MsgBoxStyle.Critical)
            Return
        End If
        If entSolicitud.IdSucursal <> gIdSucursal Then
            MsgBox("No puede modificar solicitudes de otra sucursal", MsgBoxStyle.Critical, "Nota")
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

        Dim rpt As New rptSolicitudPrestamo1() With {.DataSource = bl.rptSolicitudPrestamo(teIdSolicitud.EditValue), .DataMember = ""}
        rpt.XrSubreport1.ReportSource.DataSource = bl.GetFiadoresSolicitudPrestamo(teIdSolicitud.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport2.ReportSource.DataSource = bl.GetSaldosPrestamos(0, teIdAsociado.EditValue, deFecha.EditValue, True, "")
        rpt.XrSubreport2.ReportSource.DataMember = ""
        rpt.xrlDesembolso.Text = Format(teTarjetaCredito.EditValue, "###,###.00")
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        'rpt.xrlFecha.Text = dtParam.Rows(0).Item("Municipio") & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        'rpt.xrlSucursal.Text = gsNombre_Sucursal
        'rpt.xrlCorrel.Text = "Correlativo: " & Format(teIdSolicitud.EditValue, "###,###")
        rpt.ShowPreviewDialog()

        'Dim rpt2 As New rptSolicitudPrestamo2() With {.DataSource = bl.rptSolicitudPrestamo(teIdSolicitud.EditValue), .DataMember = ""}
        'rpt2.XrSubreport1.ReportSource.DataSource = bl.GetBienesSolicitud(teIdSolicitud.EditValue)
        'rpt2.XrSubreport1.ReportSource.DataMember = ""
        'rpt2.XrSubreport2.ReportSource.DataSource = bl.GetObligacionesSolicitud(teIdSolicitud.EditValue)
        'rpt2.XrSubreport2.ReportSource.DataMember = ""
        'rpt2.xrlFecha.Text = entSucursal.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        'rpt2.xrlFecha2.Text = FechaToString(deFecha.EditValue, deFecha.EditValue)
        'rpt2.ShowPreviewDialog()





        'Dim entSuc As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        'Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)

        'If entLinea.TipoLinea = 2 Then
        '    Dim rpt As New Solicitud1() With {.DataSource = bl.rptSolicitudPrestamo(teIdSolicitud.EditValue), .DataMember = ""}
        '    rpt.xrlLugarFecha.Text = entSuc.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        '    rpt.xrlTasaInteres.Text = seTasa.EditValue / 12
        '    rpt.xrlEmpresa.Text = gsNombre_Empresa
        '    rpt.xrlNombreLargo.Text = dtParam.Rows(0).Item("NombreLargo")
        '    rpt.XrSubreport1.ReportSource.DataSource = bl.rptSolicitudPrestamoFiadores(teIdSolicitud.EditValue)
        '    rpt.XrSubreport1.ReportSource.DataMember = ""
        '    rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        '    rpt.ShowPreviewDialog()
        'Else
        '    Dim rpt As New Solicitud3() With {.DataSource = bl.rptSolicitudPrestamo(teIdSolicitud.EditValue), .DataMember = ""}
        '    rpt.xrlLugarFecha.Text = entSuc.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)

        '    rpt.xrlEmpresa.Text = gsNombre_Empresa
        '    rpt.xrlNombreLargo.Text = dtParam.Rows(0).Item("NombreLargo")
        '    rpt.XrSubreport1.ReportSource.DataSource = bl.rptSolicitudPrestamoFiadores(teIdSolicitud.EditValue)
        '    rpt.XrSubreport1.ReportSource.DataMember = ""
        '    rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        '    rpt.ShowPreviewDialog()
        'End If

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Eliminar() Handles Me.Eliminar
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > Today Then
            MsgBox("No es posible eliminar la Solicitud de Crédito, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End If
        If bl.ExisteSolicitudFondos(teIdSolicitud.EditValue) > 0 Then
            MsgBox("La solicitud ya le fue aplicada la solicitud de fondos. No es posible Eliminarla", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Está seguro(a) de eliminar la Solicitud de Crédito?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_SolicitudesDeleteByPK(teIdSolicitud.EditValue)
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
        'Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If deFecha.EditValue < dFechaContable Then
        '    MsgBox("Fecha de la solicitud incorrecta. Período ya cerrado", MsgBoxStyle.Critical, "Error")
        '    deFecha.Focus()
        '    Return False
        'End If
        If seTasa.EditValue <= 0 And gsNombre_Empresa.StartsWith("ACAPRO") Then
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
        If leTecnico.Text = "" Then
            MsgBox(String.Format("Falta especificar el Técnico asignado que atenderá al cliente{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            leTecnico.Focus()
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



        For i = 0 To gvGarantias.DataRowCount - 1
            If SiEsNulo(gvGarantias.GetRowCellValue(i, "Concepto"), Nothing) = Nothing Then
                MsgBox(String.Format("Debes especificar el Concepto de la Garantia {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                Return False
            End If
            If SiEsNulo(gvGarantias.GetRowCellValue(i, "IdTipo"), -1) = -1 Then
                MsgBox(String.Format("Debes especificar el Tipo de Garantia {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                Return False
            End If
        Next



        'If teLiquidez.EditValue <= 0.0 Then
        '    MsgBox("El Valor de Liquidez debe ser Positivo", MsgBoxStyle.Critical)
        '    Return False
        'End If

        If bl.ExisteNumeroSolicitud(teNumSolicitud.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe un número de solicitud con el número asignado", MsgBoxStyle.Critical)
            Return False
        End If
        If bl.ExisteSolicitudFondos(teIdSolicitud.EditValue) > 0 Then
            MsgBox("La solicitud ya tiene aplicada la Solicitud de Fondos", MsgBoxStyle.Critical)
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

        ' VALIDO QUE SI EL ASOCIADO NO APLICA COMISION, NO SELE PROGRAME UN DESCUENTO DE ESE TIPO
        Dim ProgramoComision As Boolean = False
        Dim ProgramoOrdinaria1 As Boolean = False
        Dim ProgramoOrdinaria2 As Boolean = False
        Dim ProgramacionEjecutivos As Boolean = False

        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        If ProgramoComision And entAsociado.AplicaComision = False Then
            MsgBox(String.Format("El asociado no aplica a descuentos por comisión {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Return False
        End If

        'los ejecutivos solo aplican a planilla de ejecutivos
        Dim IdPlanillaSocio As Integer = bl.AplicaEjecutivos(teIdAsociado.EditValue)
        If IdPlanillaSocio = 3 Then
            If Not ProgramacionEjecutivos Then
                MsgBox("El asociado solo aplica a planilla de Ejecutivos", MsgBoxStyle.Critical)
                Return False
            End If
        End If
        If IdPlanillaSocio <> 3 Then
            If ProgramacionEjecutivos Then
                MsgBox("El asociado no aplica a planilla de Ejecutivos", MsgBoxStyle.Critical)
                Return False
            End If
        End If

        ' NO PUEDE SECCIONAR CUOTAS SI ES mensual y lleva comision
        Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)

        If rgFormaPago.EditValue = 1 Then
            If rgTipoAplicacion.EditValue = 1 Then
                MsgBox("Los prestamos a largo plazo no pueden seccionar sus cuotas", MsgBoxStyle.Critical)
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entSolicitud
            .IdSolicitud = teIdSolicitud.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .Numero = teNumSolicitud.EditValue
            .FechaSolicitud = deFecha.EditValue
            .FechaRecepcion = deFechaRecepcion.EditValue
            .TipoTrabajo = cboTipoTrabajo.EditValue
            .NombreTrabajo = teLugarTrabajo.EditValue
            .DireccionTrabajo = teDireccionTrabajo.EditValue
            .TelefonoTrabajo = teTelefonoTrabajo.EditValue
            .CargoTrabajo = teCargo.EditValue
            .TiempoTrabajo = teTiempoNegocio.EditValue
            .SalarioMensual = teSueldo.EditValue
            .Comisiones = teComision.EditValue
            .IngresosNegocio = teNegocio.EditValue
            .OtrosIngresos = teOtrosIngresos.EditValue
            .Casa = teCasa.EditValue
            .Alimentacion = teAlimentacion.EditValue
            .Servicios = teServicios.EditValue
            .OtrosPrestamos = teOtrosPrestamos.EditValue
            .Colegiatura = teColegiatura.EditValue
            .Transporte = teTransporte.EditValue
            .TarjetaCredito = teTarjetaCredito.EditValue
            .Efectivo = teEfectivo.EditValue
            .Bancos = teBancos.EditValue
            .CuentasCobrar = teCuentaCobrar.EditValue
            .Mercaderias = teMercancias.EditValue
            .BienesInmuebles = teBienesInmuebles.EditValue
            .OtrosBienes = teOtrosBienes.EditValue
            .PrestamosPagar = tePrestamosPagar.EditValue
            .CuentasPagar = tePrestamosPagar.EditValue
            .Proveedores = teProveedores.EditValue
            .Capital = teCapital.EditValue

            .MontoSolicitado = teMontoSolicitado.EditValue
            .TasaInteres = seTasa.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .IdTipoAplicacion = rgTipoAplicacion.EditValue
            .DetalleFormaPago = teDetalleFormaPago.EditValue
            .IdLinea = cboLinea.EditValue
            .Destino = teDestino.EditValue
            .IdTecnico = leTecnico.EditValue
            .IdFuente = leFinanciamiento.EditValue
            .IdTipoCredito = leTipoCredito.EditValue
            .FechaPosibleDesembolso = deFechaPosibleDesembolso.EditValue
            .IdSucursal = gIdSucursal
            .CuotaAportacion = teCuotaAportacion.EditValue
            .CuotaAhorro = teCuotaAhorro.EditValue
            .CuotaManejo = teTasaManejo.EditValue
            .IncluyeTasaSeguro = chkIncluirSeguro.EditValue
            .AplicaDescuento = chkDescPlanilla.EditValue
            .ProyeccionVenta = 0 'teProyeccionVenta.EditValue
            .ConceptoProyeccionVenta = 0 'meConceptoVenta.EditValue
            .ProyeccionGastos = 0 'teProyeccionGastos.EditValue
            .ConceptoProyeccionGastos = 0 'meConceptoGastos.EditValue
            .ValorCuota = teValorCuota.EditValue
            .RequiereSeguimiento = False
            .TipoContratacion = leTipoContratacion.EditValue
            .JefeInmediato = teJefeInmediato.EditValue
            .CapitalInvertido = teCapitalInvertido.EditValue
            .DireccionNegocio = teDireccionNegocio.EditValue
            .TelefonoNegocio = teTelefonoNegocio.EditValue
            .CasasComerciales = teCasasComerciales.EditValue
            .FechaPrimerPago = deFechaPrimerPago.EditValue



            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With
        entObligaciones = New List(Of coo_SolicitudesObligacion)
        For i = 0 To gvObligaciones.DataRowCount - 1
            Dim entDetalle As New coo_SolicitudesObligacion
            With entDetalle
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .IdObligacion = i
                .Acreedor = gvObligaciones.GetRowCellValue(i, "Acreedor")
                .Direccion = gvObligaciones.GetRowCellValue(i, "Direccion")
                .MontoDeuda = gvObligaciones.GetRowCellValue(i, "MontoDeuda")
                .SaldoActual = gvObligaciones.GetRowCellValue(i, "SaldoActual")
                .AbonoMensual = gvObligaciones.GetRowCellValue(i, "AbonoMensual")
            End With
            entObligaciones.Add(entDetalle)
        Next
        entBienes = New List(Of coo_SolicitudesBien)
        For i = 0 To gvBienes.DataRowCount - 1
            Dim entDetalleA As New coo_SolicitudesBien
            With entDetalleA
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .IdBien = i
                .DescripcionPropiedad = gvBienes.GetRowCellValue(i, "DescripcionPropiedad")
                .Direccion = gvBienes.GetRowCellValue(i, "Direccion")
                .ValorAproximado = gvBienes.GetRowCellValue(i, "ValorAproximado")
                .Hipotecado = gvBienes.GetRowCellValue(i, "Hipotecado")
                .PagoMensual = gvBienes.GetRowCellValue(i, "PagoMensual")
            End With
            entBienes.Add(entDetalleA)
        Next
        entReferencias = New List(Of coo_SolicitudesReferencia)
        For i = 0 To gvReferencias.DataRowCount - 1
            Dim entDetalleR As New coo_SolicitudesReferencia
            With entDetalleR
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .IdReferencia = i
                .Nombre = gvReferencias.GetRowCellValue(i, "Nombre")
                .Direccion = gvReferencias.GetRowCellValue(i, "Direccion")
                .Parentesco = gvReferencias.GetRowCellValue(i, "Parentesco")
                .Telefono = gvReferencias.GetRowCellValue(i, "Telefono")
                .LugarTrabajo = gvReferencias.GetRowCellValue(i, "LugarTrabajo")
            End With
            entReferencias.Add(entDetalleR)
        Next
        entGarantias = New List(Of coo_SolicitudesGarantias)
        For i = 0 To gvGarantias.DataRowCount - 1
            Dim entDetalleG As New coo_SolicitudesGarantias
            With entDetalleG
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .Correlativo = i
                .Concepto = gvGarantias.GetRowCellValue(i, "Concepto")
                .IdTipo = gvGarantias.GetRowCellValue(i, "IdTipo")
            End With
            entGarantias.Add(entDetalleG)
        Next

        entEmisionDesembolso = New List(Of coo_SolicitudesEmisionDesembolso)
        For i = 0 To gvDesembolso.DataRowCount - 1
            Dim entDetalleD As New coo_SolicitudesEmisionDesembolso
            With entDetalleD
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .IdEmision = i
                .Nombre = gvDesembolso.GetRowCellValue(i, "Nombre")
                .Valor = gvDesembolso.GetRowCellValue(i, "Valor")
            End With
            entEmisionDesembolso.Add(entDetalleD)
        Next
    End Sub

    Private Sub teTotalIngresos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teTotalIngresos.Validated, teSueldo.Validated, teComision.Validated, teNegocio.Validated, teOtrosIngresos.Validated, teAlimentacion.Validated, teCasa.Validated, teServicios.Validated, teOtrosPrestamos.Validated, teColegiatura.Validated, teTransporte.Validated
        teTotalIngresos.EditValue = teSueldo.EditValue + teComision.EditValue + teNegocio.EditValue + teOtrosIngresos.EditValue
        teTotalEgresos.EditValue = teAlimentacion.EditValue + teCasa.EditValue + teServicios.EditValue + teOtrosPrestamos.EditValue + teColegiatura.EditValue + teTransporte.EditValue '+ teTarjetaCredito.EditValue
        teLiquidez.EditValue = teTotalIngresos.EditValue - teTotalEgresos.EditValue
    End Sub

    Private Sub sbIngresarGarantia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbIngresarGarantia.Click
        If teNumAsociado.Properties.ReadOnly = False Then
            Exit Sub
        End If
        Dim IdGarantia As Integer = SiEsNulo(gvGarantias.GetFocusedRowCellValue("Correlativo"), 0)
        Dim TipoGarantia As Integer = SiEsNulo(gvGarantias.GetFocusedRowCellValue("IdTipo"), 0)

        If TipoGarantia = 1 Then
            pre_frmFiadores.IdSolicitud = teIdSolicitud.EditValue
            pre_frmFiadores.IdGarantia = IdGarantia
            pre_frmFiadores.ShowDialog()
        End If
        If TipoGarantia = 2 Then
            pre_frmHipotecas.IdSolicitud = teIdSolicitud.EditValue
            pre_frmHipotecas.IdGarantia = IdGarantia
            pre_frmHipotecas.ShowDialog()
        End If
        If TipoGarantia = 3 Then
            pre_frmPrendas.IdSolicitud = teIdSolicitud.EditValue
            pre_frmPrendas.IdGarantia = IdGarantia
            pre_frmPrendas.ShowDialog()
        End If
        If TipoGarantia = 4 Then
            pre_frmSolicitudPignoracion.IdSolicitud = teIdSolicitud.EditValue
            pre_frmSolicitudPignoracion.IdGarantia = IdGarantia
            pre_frmSolicitudPignoracion.IdAsociado = teIdAsociado.EditValue
            pre_frmSolicitudPignoracion.ShowDialog()
        End If
    End Sub

    Private Sub sbEliminarGarantia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbEliminarGarantia.Click

        If MsgBox("Está seguro(a) de eliminar ésta garantía?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Return
        End If
        Dim IdGarantia As Integer = SiEsNulo(gvGarantias.GetFocusedRowCellValue("Correlativo"), 0)
        Dim TipoGarantia As Integer = gvGarantias.GetFocusedRowCellValue("IdTipo")
        If IdGarantia = 0 Then
            MsgBox("No se ha definido ninguna garantía", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        objTablas.coo_SolicitudesGarantiasDeleteByPK(teIdSolicitud.EditValue, IdGarantia)
        If teNumAsociado.Properties.ReadOnly = True Then
            If TipoGarantia = 1 Then
                objTablas.coo_GarantiasFiadorDeleteByPK(teIdSolicitud.EditValue, IdGarantia)
            End If
            If TipoGarantia = 2 Then
                objTablas.coo_GarantiasHipotecaDeleteByPK(teIdSolicitud.EditValue, IdGarantia)
            End If
            If TipoGarantia = 3 Then
                objTablas.coo_GarantiasPrendariaDeleteByPK(teIdSolicitud.EditValue, IdGarantia)
            End If
            If TipoGarantia = 4 Then
                objTablas.coo_GarantiasCuentaPignoradaDeleteByPK(teIdSolicitud.EditValue, IdGarantia)
            End If
            gcGarantias.DataSource = bl.GetGarantiasSolicitud(teIdSolicitud.EditValue)
        End If
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
        Rpt2.xrlEmpresa.Text = gsNombre_Empresa
        Rpt2.ShowPreviewDialog()

        Dim rpt3 As New aho_rptListadoCuentasGeneral
        rpt3.DataSource = blAhorro.rptListadoCuentaAhorroAsociado(Today, teIdAsociado.EditValue)
        rpt3.DataMember = ""
        rpt3.xrlEmpresa.Text = gsNombre_Empresa
        rpt3.xrlTitulo.Text = "AL " & FechaToString(Today, Today)
        rpt3.xrlSucursal.Text = "-- TODAS LAS SUCURSALES --"
        Rpt3.ShowPreviewDialog()
    End Sub

    Private Sub sbDictamenPromotor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbDictamenPromotor.Click
        pre_frmDictamenTecnico.IdSolicitud = teIdSolicitud.EditValue
        pre_frmDictamenTecnico.MontoPropuesto = teMontoSolicitado.EditValue
        pre_frmDictamenTecnico.CuotasPropuestas = sePlazoCuotas.EditValue
        pre_frmDictamenTecnico.IdFormaPago = rgFormaPago.EditValue
        pre_frmDictamenTecnico.ShowDialog()
        Dim rpt3 As New pre_rptDictamenTecnico1
        Dim rpt4 As New pre_rptDictamenTecnico2
        rpt3.DataSource = bl.GetDictamenTecnico(teIdSolicitud.EditValue)
        rpt3.DataMember = ""
        rpt3.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt3.xrlEmpresa.Text = gsNombre_Empresa
        rpt3.ShowPreviewDialog()


        rpt4.DataSource = bl.rptDictamenTecnico2(teIdSolicitud.EditValue)
        rpt4.DataMember = ""
        rpt4.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt4.XrSubreport1.ReportSource.DataSource = bl.rptDictamenTecnicoFiadores(teIdSolicitud.EditValue)
        rpt4.XrSubreport1.ReportSource.DataMember = ""
        rpt4.XrSubreport2.ReportSource.DataSource = bl.rptSolicitudPrestamoGarantia(teIdSolicitud.EditValue)
        rpt4.XrSubreport2.ReportSource.DataMember = ""
        rpt4.xrlEmpresa.Text = gsNombre_Empresa
        rpt4.xrlFecha.Text = FechaToString(Today, Today)
        rpt4.ShowPreviewDialog()

    End Sub

    Private Sub sbAutorizacionGerencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAutorizacionGerencia.Click
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
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = teCuotaAhorro.EditValue
            .ImporteCuotaManejo = teTasaManejo.EditValue
            .ImporteCuotaAportacion = teCuotaAportacion.EditValue
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue

            Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(cboLinea.EditValue)
            If entLinea.CuotaSinCentavos Then
                .CuotaSinCentavos = True
            End If

            If chkIncluirSeguro.EditValue = True Then
                .TasaSeguroDeuda = dtParam.Rows(0).Item("TasaSeguro")
            End If
          
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

    Private Sub sbVerDocumentos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbVerDocumentos.Click
        pre_frmVerDocumentosAsociado.IdAsociado = teIdAsociado.EditValue
        pre_frmVerDocumentosAsociado.ShowDialog()
    End Sub

    Private Sub sbImprimeGarantia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimeGarantia.Click

        If teNumAsociado.Properties.ReadOnly = False Then
            Exit Sub
        End If

        If gvGarantias.GetFocusedRowCellValue("IdTipo") > 1 Then
            MsgBox("No existe documento de impresión para la garantía seleccionada", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim IdGarantia As Integer = gvGarantias.GetFocusedRowCellValue("Correlativo")

        Dim rpt As New pre_rptSolicitudFiador
        rpt.DataSource = bl.rptSolicitudFiador(teIdSolicitud.EditValue, IdGarantia)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = FechaToString(Today, Today)
        rpt.XrSubreport1.ReportSource.DataSource = bl.GetObligacionesFiador(teIdSolicitud.EditValue, IdGarantia)
        rpt.XrSubreport2.ReportSource.DataSource = bl.GetReferenciasFiador(teIdSolicitud.EditValue, IdGarantia)
        rpt.XrSubreport3.ReportSource.DataSource = bl.rptFiadorBien(teIdSolicitud.EditValue, IdGarantia)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub sbAprobacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAprobacion.Click
        If bl.ExisteSolicitudFondos(teIdSolicitud.EditValue) > 0 Then
            MsgBox("La solicitud ya le fue aplicada la solicitud de Fondos", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

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
        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            teLugarTrabajo.EditValue = entAsociado.LugarTrabajo
            teDireccionTrabajo.EditValue = entAsociado.DireccionTrabajo
            teTelefonoTrabajo.EditValue = entAsociado.TelefonoTrabajo
            teCargo.EditValue = entAsociado.CargoTrabajo
            teNumSolicitud.EditValue = entAsociado.Numero & "-" & (entAsociado.CorrelativoSolicitud + 1).ToString.PadLeft(2, "0")
        End If
    End Sub
    Private Sub CargaCombos()
        objCombos.adm_tipoTrabajo(cboTipoTrabajo, "")
        objCombos.coo_LineasEfectivo(cboLinea, "TipoLinea<>1", "")
        objCombos.coo_Tecnicos(leTecnico, "")
        objCombos.coo_Fuentes(leFinanciamiento, "")
        objCombos.coo_TipoCredito(leTipoCredito, "")
        objCombos.coo_TiposGarantia(leTipoGarantia, "")
        objCombos.adm_TiposContratacion(leTipoContratacion, "")
    End Sub
    Private Sub ActivarControles(ByVal Tipo As Boolean)
        teIdSolicitud.Properties.ReadOnly = True
        gvObligaciones.OptionsBehavior.Editable = Tipo
        gvBienes.OptionsBehavior.Editable = Tipo
        gvReferencias.OptionsBehavior.Editable = Tipo
        gvGarantias.OptionsBehavior.Editable = Tipo
        gvDesembolso.OptionsBehavior.Editable = Tipo
        'gvDetalleIngresos.OptionsBehavior.Editable = Tipo
        'gvDetalleGastos.OptionsBehavior.Editable = Tipo

        teNumAsociado.Properties.ReadOnly = Not Tipo
        teNumSolicitud.Properties.ReadOnly = Not Tipo
        deFecha.Properties.ReadOnly = Not Tipo
        deFechaRecepcion.Properties.ReadOnly = Not Tipo
        sbAprobacion.Enabled = Not Tipo

        For Each ctrl In XtraTabPage1.Controls
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
        For Each ctrl In XtraTabPage2.Controls
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



        For Each ctrl In XtraTabPage10.Controls
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

        sbIngresarGarantia.Enabled = Not Tipo
        sbEliminarGarantia.Enabled = Not Tipo
        sbImprimeGarantia.Enabled = Not Tipo
        sbDictamenPromotor.Enabled = Not Tipo
        sbAutorizacionGerencia.Enabled = Not Tipo
        'sbEliminarGasto.Enabled = Tipo
        'sbEliminarIngreso.Enabled = Tipo
        'sbImprimirHoja.Enabled = Not Tipo
        teCuotaAhorro.Enabled = Not gsNombre_Empresa.StartsWith("ACAPRO")
        teTasaManejo.Enabled = Not gsNombre_Empresa.StartsWith("ACAPRO")

        teNombreAsociado.Properties.ReadOnly = True
        teTotalIngresos.Properties.ReadOnly = True
        teTotalEgresos.Properties.ReadOnly = True
        teLiquidez.Properties.ReadOnly = True
        teValorCuota.Properties.ReadOnly = True
        teTotalActivos.Properties.ReadOnly = True
        teTotalPasivo.Properties.ReadOnly = True
        tePasivoCapital.Properties.ReadOnly = True
    End Sub
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdSolicitudStart As Integer = 0
        Dim IdSolicitudEnd As Integer = 0
        If TipoAvance = -1 Then
            IdSolicitudStart = objFunciones.ObtenerPrimerId("Coo_Solicitudes", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudStart Then
                teIdSolicitud.EditValue += 1
            End If
        End If
        If TipoAvance = 1 Then
            IdSolicitudEnd = objFunciones.ObtenerUltimoId("Coo_Solicitudes", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudEnd Then
                teIdSolicitud.EditValue -= 1
            End If
        End If
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        teIdSolicitud.EditValue = bl.ObtenerIdSolicitud(teIdSolicitud.EditValue, TipoAvance)
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        entSolicitud = objTablas.coo_SolicitudesSelectByPK(teIdSolicitud.EditValue)
        With entSolicitud
            teIdSolicitud.EditValue = .IdSolicitud
            teIdAsociado.EditValue = .IdAsociado
            'teNumAsociado.EditValue = .Numero
            teNumAsociado_Validated(teIdAsociado, New EventArgs)
            teNumSolicitud.EditValue = .Numero
            deFecha.EditValue = .FechaSolicitud
            deFechaRecepcion.EditValue = .FechaRecepcion
            deFechaPrimerPago.EditValue = .FechaPrimerPago
            cboTipoTrabajo.EditValue = .TipoTrabajo
            teLugarTrabajo.EditValue = .NombreTrabajo
            teDireccionTrabajo.EditValue = .DireccionTrabajo
            teTelefonoTrabajo.EditValue = .TelefonoTrabajo
            teCargo.EditValue = .CargoTrabajo
            teTiempoNegocio.EditValue = .TiempoTrabajo

            teSueldo.EditValue = .SalarioMensual
            teComision.EditValue = .Comisiones
            teNegocio.EditValue = .IngresosNegocio
            teOtrosIngresos.EditValue = .OtrosIngresos
            teCasa.EditValue = .Casa
            teAlimentacion.EditValue = .Alimentacion
            teServicios.EditValue = .Servicios
            teOtrosPrestamos.EditValue = .OtrosPrestamos
            teColegiatura.EditValue = .Colegiatura
            teTransporte.EditValue = .Transporte
            teTarjetaCredito.EditValue = .TarjetaCredito

            teTotalIngresos_Validated(teTotalIngresos, New EventArgs)

            teEfectivo.EditValue = .Efectivo
            teBancos.EditValue = .Bancos
            teCuentaCobrar.EditValue = .CuentasCobrar
            teMercancias.EditValue = .Mercaderias
            teBienesInmuebles.EditValue = .BienesInmuebles
            teOtrosBienes.EditValue = .OtrosBienes
            tePrestamosPagar.EditValue = .PrestamosPagar
            teCuentasPagar.EditValue = .CuentasPagar
            teProveedores.EditValue = .Proveedores
            teCapital.EditValue = .Capital
            teTotalActivos_Validated(teTotalActivos, New EventArgs)


            gcObligaciones.DataSource = bl.GetObligacionesSolicitud(.IdSolicitud)
            gcBienes.DataSource = bl.GetBienesSolicitud(.IdSolicitud)
            gcReferencias.DataSource = bl.GetReferenciasSolicitud(.IdSolicitud)
            gcGarantias.DataSource = bl.GetGarantiasSolicitud(.IdSolicitud)
            gcDesembolso.DataSource = bl.GetEmisionDesembolso(.IdSolicitud)

            'gcDetalleIngresos.DataSource = bl.GetDetalleIngresosSolicitud(.IdSolicitud)
            'gcDetalleGastos.DataSource = bl.GetDetalleGastosSolicitud(.IdSolicitud)
            teMontoSolicitado.EditValue = .MontoSolicitado
            seTasa.EditValue = .TasaInteres
            sePlazoCuotas.EditValue = .NumeroCuotas
            rgFormaPago.EditValue = .IdFormaPago
            seFrecuencia.EditValue = .FrecuenciaPago
            rgTipoCuota.EditValue = .TipoCuota
            rgTipoAplicacion.EditValue = .IdTipoAplicacion
            teDetalleFormaPago.EditValue = .DetalleFormaPago
            cboLinea.EditValue = .IdLinea
            teDestino.EditValue = .Destino
            leTecnico.EditValue = .IdTecnico
            leFinanciamiento.EditValue = .IdFuente
            leTipoCredito.EditValue = .IdTipoCredito
            deFechaPosibleDesembolso.EditValue = .FechaPosibleDesembolso
            teCuotaAportacion.EditValue = .CuotaAportacion
            teTasaManejo.EditValue = .CuotaManejo
            teCuotaAhorro.EditValue = .CuotaAhorro
            chkIncluirSeguro.EditValue = .IncluyeTasaSeguro
            chkDescPlanilla.EditValue = .AplicaDescuento

            'teProyeccionVenta.EditValue = .ProyeccionVenta
            'meConceptoVenta.EditValue = .ConceptoProyeccionVenta
            'teProyeccionGastos.EditValue = .ProyeccionGastos
            'meConceptoGastos.EditValue = .ConceptoProyeccionGastos
            teValorCuota.EditValue = .ValorCuota
            leTipoContratacion.EditValue = .TipoContratacion
            teJefeInmediato.EditValue = .JefeInmediato
            teCapitalInvertido.EditValue = .CapitalInvertido
            teDireccionNegocio.EditValue = .DireccionNegocio
            teTelefonoNegocio.EditValue = .TelefonoNegocio
            teCasasComerciales.EditValue = .CasasComerciales


        End With
    End Sub


    Private Sub sbImprimirHoja_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim rpt As New pre_rptSolvenciaEconomica
        rpt.DataSource = bl.rptSolvenciaEconomica(teIdSolicitud.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.XrSubreport1.ReportSource.DataSource = bl.rptSolvenciaEconomicaDetalle(teIdSolicitud.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub CalcularCuota()
        Dim ValorCuota As Decimal = 0.0, CuotaSeguro As Decimal = 0.0, MaxSeguro As Decimal = 0.0
        If teMontoSolicitado.EditValue = 0 Or sePlazoCuotas.EditValue = 0 Or deFechaPosibleDesembolso.EditValue = Nothing _
         Or rgFormaPago.EditValue = 0 Or seFrecuencia.EditValue = 0 Then
            teValorCuota.EditValue = 0.0
            Exit Sub
        End If
        Dim pres As New Prestamo()
        With pres
            .CapitalInicial = teMontoSolicitado.EditValue
            .NumeroCuotas = sePlazoCuotas.EditValue
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFechaPosibleDesembolso.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = teCuotaAhorro.EditValue
            .ImporteCuotaManejo = teTasaManejo.EditValue
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
                If teMontoSolicitado.EditValue > MaxSeguro Then
                    CuotaSeguro = Decimal.Round(MaxSeguro * dtParam.Rows(0).Item("TasaSeguro") / 1000, 2)
                Else
                    CuotaSeguro = Decimal.Round(teMontoSolicitado.EditValue * dtParam.Rows(0).Item("TasaSeguro") / 1000, 2)
                End If
            End If
            .CalculaPlanPagos()
            'ValorCuota = pres.PagoCalculado + teCuotaAportacion.EditValue + teCuotaAhorro.EditValue + teTasaManejo.EditValue + CuotaSeguro
            teValorCuota.EditValue = pres.ValorCuota
        End With
    End Sub

    Private Sub teMontoSolicitado_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoSolicitado.EditValueChanged
        Dim dt As New DataTable
        dt = objTablas.coo_TiposPrestamoSelectAll
        teTarjetaCredito.EditValue = teMontoSolicitado.EditValue

        For i = 0 To dt.Rows.Count - 1
            If teMontoSolicitado.EditValue > dt.Rows(i).Item("Desde") And teMontoSolicitado.EditValue <= dt.Rows(i).Item("Hasta") Then
                leTipoCredito.EditValue = dt.Rows(i).Item("IdTipoPrestamo")
            End If
        Next

        CalculaCuotaAhorro()
    End Sub

    Private Sub sePlazoCuotas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sePlazoCuotas.EditValueChanged
        CalculaCuotaAhorro()
    End Sub

    Private Sub seTasa_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTasa.EditValueChanged
        CalculaCuotaAhorro()
    End Sub

    Private Sub teMontoSolicitado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoSolicitado.Validated, _
    seTasa.Validated, deFechaPosibleDesembolso.Validated, sePlazoCuotas.Validated, rgFormaPago.Validated, seFrecuencia.Validated, _
    teCuotaAportacion.Validated, teTasaManejo.Validated, teCuotaAhorro.Validated, chkIncluirSeguro.Validated, rgTipoCuota.EditValueChanged
        CalcularCuota()
    End Sub

    Private Sub CalculaCuotaAhorro()
        teCuotaAhorro.EditValue = 0.0
        'If sePlazoCuotas.EditValue > 0.0 Then
        '    teCuotaAhorro.EditValue = Decimal.Round(teMontoSolicitado.EditValue * (seTasa.EditValue / 100) / sePlazoCuotas.EditValue, 2)
        'End If
    End Sub

    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub teTotalActivos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teTotalActivos.Validated, teEfectivo.Validated, teBancos.Validated, teCuentaCobrar.Validated, teMercancias.Validated, teBienesInmuebles.Validated, teOtrosBienes.Validated, tePrestamosPagar.Validated, teCuentasPagar.Validated, teProveedores.Validated, teCapital.Validated, tePasivoCapital.Validated
        teTotalActivos.EditValue = teEfectivo.EditValue + teBancos.EditValue + teCuentaCobrar.EditValue + teMercancias.EditValue + teBienesInmuebles.EditValue + teOtrosBienes.EditValue
        teTotalPasivo.EditValue = tePrestamosPagar.EditValue + teCuentasPagar.EditValue + teProveedores.EditValue
        tePasivoCapital.EditValue = tePrestamosPagar.EditValue + teCuentasPagar.EditValue + teProveedores.EditValue + teCapital.EditValue
    End Sub

    Private Sub sbAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAlerta.Click
        If rbMenu.qbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            Exit Sub
        End If
        adm_frmAlertas2.ShowDialog()
    End Sub

End Class

