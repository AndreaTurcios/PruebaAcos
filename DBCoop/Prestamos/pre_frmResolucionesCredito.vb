Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL
Imports DevExpress.XtraReports.UI
Public Class pre_frmResolucionesCredito
    Dim blPres As New PrestamosBLL(), blAdmon As New AdmonBLL()
    Dim bl As New TableBusiness()
    Dim entAsociados As coo_Asociados, entSolicitud As coo_Solicitudes
    Dim entResolucion As coo_Resoluciones, entSolicitudFondo As coo_SolicitudFondos
    Dim entFiadores As New DataTable, IdSolicitudFondo As Integer
    Dim entSucursal As adm_Sucursales = bl.adm_SucursalesSelectByPK(gIdSucursal)
    Dim entDocRtf As coo_Documentos
    Dim entRes As New coo_Resoluciones
    ReadOnly dtParam As DataTable = blAdmon.ObtieneParametros

    Private Sub pre_frmResolucionesCredito_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        objCombos.coo_Lineas(leLinea, "")
        objCombos.coo_Tecnicos(leTecnico, "")
        objCombos.coo_Fuentes(leFinanciamiento, "")
    End Sub
    Private Sub beNumSolicitud_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNoSolicitud.ButtonClick
        '' frmConsultaSolicitudes.SoloPendientes = False
        frmConsultaSolicitudes.ShowDialog()
        beNoSolicitud.EditValue = frmConsultaSolicitudes.NumeroSol
        teIdSolicitud.EditValue = frmConsultaSolicitudes.IdSolicitud
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
        entAsociados = objTablas.coo_AsociadosSelectByPK(entSolicitud.IdAsociado)

        teNombre.EditValue = String.Format("{0} - {1} {2}", entAsociados.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        Dim TasaSeguro As Decimal = 0
        With entSolicitud
            leLinea.EditValue = .IdLinea
            teMontoSolicitado.EditValue = .MontoSolicitado
            deFechaSolicitud.EditValue = .FechaSolicitud
            seNumCuotas.EditValue = .NumeroCuotas
            rgFormaPago.EditValue = .IdFormaPago
            seFrecuencia.EditValue = .FrecuenciaPago
            teDetalleFormaPago.EditValue = .DetalleFormaPago
            teDestino.EditValue = .Destino
            leTecnico.EditValue = .IdTecnico
            leFinanciamiento.EditValue = .IdFuente
            seTasa.EditValue = .TasaInteres
            chkSeguimiento.EditValue = .RequiereSeguimiento
        End With
        IdSolicitudFondo = blPres.GetIdSolicitudFondos(teIdSolicitud.EditValue)
        If IdSolicitudFondo > 0 Then
            entSolicitudFondo = objTablas.coo_SolicitudFondosSelectByPK(IdSolicitudFondo)
        End If
    End Sub

    Private Sub btAprobacionGerencia_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btAprobacionGerencia.Click
        Dim lConsulta As Boolean = False
        frmObtienePassword.TipoUsuario = 4
        frmObtienePassword.Usuario = objMenu.User
        frmObtienePassword.ShowDialog()
        If frmObtienePassword.Acceso = False Then
            If MsgBox("No Posee Permisos para Modificar, Desea Ingresar solo como consulta?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.Yes Then
                lConsulta = True
            Else
                Return
            End If
        End If
        If teIdSolicitud.EditValue < 1 Then
            MsgBox("Debe Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Return
        End If

        'If leLinea.EditValue = 5 Then
        '    MsgBox("El Prestamo es de linea Automatica" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error")
        '    Return
        'End If
        pre_frmResolucionGerencia.IdSolicitud = teIdSolicitud.EditValue
        pre_frmResolucionGerencia.Consulta = lConsulta
        pre_frmResolucionGerencia.ShowDialog()
    End Sub

    Private Sub btAprobacionComite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAprobacionComite.Click
        Dim lConsulta As Boolean = False
        Dim ResolucionComite As coo_Resoluciones = objTablas.coo_ResolucionesSelectByPK(teIdSolicitud.EditValue)
        If ResolucionComite.AutorizaComite = False Then
            MsgBox("Esta solicitud no ha sido revisada por la gerencia" & Chr(13) & "No puede Autorizar o Aprobar el Comite de Créditos", MsgBoxStyle.Critical, "Error")
            Return
        End If
        frmObtienePassword.TipoUsuario = 2
        frmObtienePassword.Usuario = objMenu.User
        frmObtienePassword.ShowDialog()
        If frmObtienePassword.Acceso = False Then
            If MsgBox("No posee permisos para modificar. Desea Ingresar solo como consulta?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.Yes Then
                lConsulta = True
            Else
                Return
            End If
        End If
        If teIdSolicitud.EditValue < 1 Then
            MsgBox("Debe seleccionar una solicitud", MsgBoxStyle.Critical, "Error")
            Return
        End If
        pre_frmResolucionComite.IdSolicitud = teIdSolicitud.EditValue
        pre_frmResolucionComite.Consulta = lConsulta
        pre_frmResolucionComite.ShowDialog()
    End Sub

    Private Sub btAprobacionConsejo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAprobacionConsejo.Click
        Dim lConsulta As Boolean = False
        Dim ResolucionConsejo As coo_Resoluciones = objTablas.coo_ResolucionesSelectByPK(teIdSolicitud.EditValue)
        If ResolucionConsejo.AutorizaConsejo <> True Then
            MsgBox("Esta Solicitud no ha sido revisada por el comite" & Chr(13) & "No puede Autorizar o Aprobar el Consejo de Administración", MsgBoxStyle.Critical, "Error")
            Return
        End If

        frmObtienePassword.TipoUsuario = 1
        frmObtienePassword.Usuario = objMenu.User
        frmObtienePassword.ShowDialog()
        If frmObtienePassword.Acceso = False Then
            If MsgBox("No Posee Permisos para Modificar, Desea Ingresar solo como consulta?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.Yes Then
                lConsulta = True
            Else
                Return
            End If
        End If
        If teIdSolicitud.EditValue < 1 Then
            MsgBox("Debe Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Return
        End If
        pre_frmResolucionConsejo.IdSolicitud = teIdSolicitud.EditValue
        pre_frmResolucionConsejo.Consulta = lConsulta
        pre_frmResolucionConsejo.ShowDialog()
    End Sub

    Private Sub btAprobacionAutomatica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAprobacionAutomatica.Click
        If teIdSolicitud.EditValue < 1 Then
            MsgBox("Debe Seleccionar una Solicitud", MsgBoxStyle.Critical, "Error")
            Return
        End If
        If leLinea.EditValue <> 5 Then
            MsgBox("El préstamo no es de línea automática" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error")
            Return
        End If
        With entRes
            .IdSolicitud = teIdSolicitud.EditValue
            .IdEstado = 1
            .FechaAprobacion = deFechaSolicitud.EditValue
            .TipoTramite = ""
            .RecomendacionGerente = ""
            .ResolucionGerente = ""
            .OtrasGerente = ""
            .FechaResolucionGerente = deFechaSolicitud.EditValue
            .TipoResolucionGerente = 2
            .IdEstado = 2
            .RecomendacionComite = ""
            .ComiteSesion = ""
            .ComiteResolucion = ""
            .ComiteActa = ""
            .OtrasComite = ""
            .FechaResolucionComite = deFechaSolicitud.EditValue
            .TipoResolucionComite = 1
            .RecomendacionConsejo = ""
            .ConsejoSesion = ""
            .ConsejoActa = ""
            .ConsejoResolucion = ""
            .OtrasConsejo = ""
            .FechaResolucionConsejo = deFechaSolicitud.EditValue
            .TipoResolucionConsejo = 1
            .MontoGerente = teMontoSolicitado.EditValue
            .CuotasGerente = seNumCuotas.EditValue
            .TasaGerente = seTasa.EditValue
            .IdFormaPagoGerente = rgFormaPago.EditValue
            .FrecuenciaPagoGerente = seFrecuencia.EditValue
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
            .Aprobada = 1
            .MontoAprobado = teMontoSolicitado.EditValue
            .TasaInteresAprobada = seTasa.EditValue
            .NumeroCuotasAprobada = seNumCuotas.EditValue
            .IdFormaPagoAprobado = rgFormaPago.EditValue
            .FrecuenciaPagoAprobado = seFrecuencia.EditValue
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .FechaHoraModificacion = Now
            .ModificadoPor = objMenu.User
            .IdSucursal = gIdSucursal
        End With
        If blPres.ExisteResolucionSolicitud(teIdSolicitud.EditValue) < 1 Then
            Dim msj As String = ""
            msj = blPres.InsertaResolucionSolicitud(entRes)
            If msj <> "" Then
                MsgBox(String.Format("No fue posible actualizar la resolución{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        End If
        Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Dim dtEstructuras As DataTable = blPres.ObtenerParametrosEstructuras()

        Dim rpt As New pre_rptResolucionGerencia
        rpt.DataMember = ""
        rpt.DataSource = blPres.rptResolucionGerencia(teIdSolicitud.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport1.ReportSource.DataSource = blPres.rptFiadores(teIdSolicitud.EditValue)
        rpt.xrlGerente.Text = entSucursal.Responsable
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFirmante1.Text = dtEstructuras.Rows(0).Item("NombreComite1")
        rpt.xrlFirmante2.Text = dtEstructuras.Rows(0).Item("NombreComite2")
        rpt.xrlFirmante3.Text = dtEstructuras.Rows(0).Item("NombreComite3")
        rpt.xrlFirmante4.Text = dtEstructuras.Rows(0).Item("NombreComite4")
        rpt.xrlResolucion.Text = "RESOLUCION DE LA GERENCIA:"
        rpt.xrlMonto.Text = "MONTO APROBADO:"
        rpt.ShowPreviewDialog()
        Close()
    End Sub

    Private Sub btListadoResoluciones_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btListadoResoluciones.Click
        pre_frmListadoResoluciones.ShowDialog()
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSalir.Click
        Close()
    End Sub

    Private Sub chkSeguimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSeguimiento.EditValueChanged
        If teIdSolicitud.EditValue > 0 Then
            If chkSeguimiento.EditValue = True Then
                blPres.ActualizarSeguimientoSolicitud(teIdSolicitud.EditValue, 1)
            Else
                blPres.ActualizarSeguimientoSolicitud(teIdSolicitud.EditValue, 0)
            End If
        End If
    End Sub
End Class
