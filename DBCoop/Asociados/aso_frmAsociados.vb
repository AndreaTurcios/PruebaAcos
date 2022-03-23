Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraReports.UI
Public Class aso_frmAsociados
    Dim entAsoTelefonia As coo_AsociadosTelefonia
    Dim entAsociado As coo_Asociados
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim blAdmon As New AdmonBLL(), blAporta As New AportacionesBLL()
    Dim blAsociado As New AsociadosBLL()
    Dim dtParam As DataTable = blAdmon.ObtieneParametros()
    Dim entBeneficiario As List(Of coo_AsociadosBeneficiarios), IsDummy1 As Boolean, IsDummy2 As Boolean
    Dim entDocRtf As coo_Documentos
    Dim entDescuentos As List(Of coo_AsociadosDescuentos)
    Private Sub apo_frmAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        teIdAsociado.EditValue = objFunciones.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado")
        CargaControles(0)
        gcBeneficiarios.DataSource = blAporta.GetBeneficiarios(teIdAsociado.EditValue)
        gcDes.DataSource = blAsociado.DescuentosAsociados(teIdAsociado.EditValue)
        gc.DataSource = objTablas.coo_AsociadosTelefoniaSelectAll(teIdAsociado.EditValue)
        TeIdTelefono.EditValue = objFunciones.ObtenerUltimoIdTelefono("coo_AsociadosTelefonia", "IdTelefono", teIdAsociado.EditValue) + 1
        DeFechaAsignacion.EditValue = Today
        DefechaActivacion.EditValue = Today
        DeFechaVencimiento.EditValue = Today
        ChecDatos.Checked = False
        ChecVoz.Checked = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        ActivarControles(False)
    End Sub
    Private Sub apo_frmAsociados_Nuevo() Handles Me.Nuevo
        gvBeneficiarios.CancelUpdateCurrentRow()
        gvBeneficiarios.AddNewRow()

        gvDes.CancelUpdateCurrentRow()
        gvDes.AddNewRow()

        ActivarControles(True)
        entAsociado = New coo_Asociados
        XtraTabControl1.SelectedTabPage = XtraTabPage1 'seleccionamos la primer página
        IsDummy1 = True
        IsDummy2 = True

        gcBeneficiarios.DataSource = blAporta.GetBeneficiarios(-1)
        gcDes.DataSource = blAsociado.DescuentosAsociados(-999)

        teIdAsociado.EditValue = objFunciones.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado") + 1
        teIdAsociado.Properties.ReadOnly = True
        teNumAsociado.EditValue = ""
        rgTipoPersona.SelectedIndex = 0
        teNombres.EditValue = ""
        teApellidos.EditValue = ""
        teRazon.EditValue = ""
        teRepresentante.EditValue = ""
        teConocido.EditValue = ""
        chkCredencial.Checked = False
        leTipoDocumento.EditValue = 1
        teDocumento.EditValue = ""
        deFechaNacimiento.EditValue = Nothing
        teLugarExpedicion.EditValue = ""
        deFechaExpedicion.EditValue = Today
        teIsss.EditValue = ""
        teNit.EditValue = ""
        teOtroDocumento.EditValue = ""
        teLugarNacimiento.EditValue = ""
        teNacionalidad.EditValue = ""
        leSexo.EditValue = 1
        leEstadoCivil.EditValue = 1
        teDireccion.EditValue = ""
        teUbicacion.EditValue = ""
        leDepartamento.EditValue = 1
        leMunicipio.EditValue = 1
        leCanton.EditValue = 1
        teTelefono.EditValue = ""
        teCorreoElectronico.EditValue = ""
        teCelular.EditValue = ""
        teNombreTrabajoAnterior.EditValue = ""
        teTelefonoTrabajoAnterior.EditValue = ""
        chkEnviarEstado.EditValue = True

        'datos del conyuge
        teNombreConyugue.EditValue = ""
        deFechaNacimientoCon.EditValue = Nothing
        teDuiConyuge.EditValue = ""
        teLugarTrabajoCon.EditValue = ""
        teDirTrabajoCon.EditValue = ""
        teTelTrabajoCon.EditValue = ""
        teCargoConyugue.EditValue = ""

        'datos laborales
        teLugarTrabajo.EditValue = ""
        leProfesion.ItemIndex = 0
        teDireccionTrabajo.EditValue = ""
        teCargo.EditValue = ""
        deFecIngresoTrabajo.EditValue = Nothing
        teTelefonoTrabajo.EditValue = ""
        teSalario.EditValue = 0.0
        teSalarioConyugue.EditValue = 0.0
        teOtrosIngresos.EditValue = 0.0
        leActividad.ItemIndex = 0
        teGiro.EditValue = ""
        teIngresos.EditValue = 0.0
        teCuotaPresEfectivo.EditValue = 0.0
        teEstimadoCuentaAhorro.EditValue = 0.0
        teEstimadoAportacion.EditValue = 0.0
        teDepositosPlazo.EditValue = 0.0
        teExcesoCuotaPactada.EditValue = 0.0
        teTransferenciaAhorro.EditValue = 0.0
        XtraTabPage3.Update()

        'otros datos
        teNumeroHijos.EditValue = 0.0
        leTipoVivienda.EditValue = 1
        teDuenioVivienda.EditValue = ""
        teNomRefPersonal1.EditValue = ""
        teDirRefPersonal1.EditValue = ""
        teTelRefPersonal1.EditValue = ""
        chkSocioRefPersonal1.EditValue = False
        chkEnviarDescuentos.EditValue = False
        teNomRefPersonal2.EditValue = ""
        teLugarTrabajoPersonal1.EditValue = ""
        teLugarTrabajoPersonal2.EditValue = ""
        teDirRefPersonal2.EditValue = ""
        teTelRefPersonal2.EditValue = ""
        chkSocioRefPersonal2.EditValue = False
        ceExcluirDividendos.EditValue = False
        ceExcluirFuneraria.EditValue = False
        leTipoVivienda.ItemIndex = 0
        teDuenioVivienda.EditValue = ""
        leSucursal.EditValue = gIdSucursal
        deFechaIngreso.EditValue = Today
        deFechaRetiro.EditValue = Nothing
        leEstado.EditValue = 1
        seCorrelativoSolicitud.EditValue = 0
        peImagen.Image = Nothing
        TeNomAsociado.EditValue = ""
        teNAsociado.EditValue = ""
        ChecAplicaTelefonia.Checked = False
        gc.DataSource = objTablas.coo_AsociadosTelefoniaSelectAll(-1)
        LIM()
        teNumAsociado.Focus()
    End Sub
    Private Sub apo_frmAsociados_Guardar() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If

        If teCuotaPresEfectivo.EditValue = 0.0 Then
            If MsgBox("No ha especificado % de ahorro" + Chr(13) + "Está seguro(a) de guardar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = blAporta.InsertaAsociado(entAsociado, entBeneficiario, entDescuentos)
            If msj = "" Then
                MsgBox("El asociado ha sido guardado con éxito", MsgBoxStyle.Information)
                teIdAsociado.EditValue = entAsociado.IdAsociado
            Else
                MsgBox(String.Format("No fue posible actualizar el registro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = blAporta.UpdateAsociado(entAsociado, entBeneficiario, entDescuentos)
            If msj = "" Then
                MsgBox("El asociado ha sido actualizado con éxito", MsgBoxStyle.Information)
                teIdAsociado.EditValue = entAsociado.IdAsociado
            Else
                MsgBox(String.Format("No fue posible actualizar el registro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub apo_frmAsociados_Revertir() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
        IsDummy1 = False
        IsDummy2 = False
    End Sub
    Private Sub apo_frmAsociados_Editar() Handles Me.Editar
        'If entAsociado.IdSucursal <> gIdSucursal Then
        '    MsgBox("No puedes Modificar El Asociado Pertenece a Otra Sucursal", MsgBoxStyle.Critical)
        '    Return
        'End If
        ActivarControles(True)
        teNumAsociado.Focus()
        LIM()

    End Sub
    Private Sub apo_frmAsociados_Consulta() Handles Me.Consulta
        frmConsultaAsociados.ShowDialog()
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado

        CargaControles(0)
    End Sub
    Private Sub apo_frmAsociados_Eliminar() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar el Asociado?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_AsociadosDeleteByPK(teIdAsociado.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El asociado ha sido elminado con éxito", MsgBoxStyle.Information)
                teIdAsociado.EditValue = teIdAsociado.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar el Asociado{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub
    Private Sub apo_frmAsociados_Reporte() Handles Me.Reporte
        Dim rpt As New aso_rptSolicitudAdmision

        rpt.DataSource = blAporta.rptSolicitudAdmision(teIdAsociado.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlCiudad.Text = String.Format("{0}, {1}", entSucursal.Ciudad, FechaToString(Today, Today))
        'rpt.xrlFecha.Text = Format(Today, "dd/MM/yyyy")
        rpt.xrlConsejo.Text = dtParam.Rows(0).Item("NombreEmpresa")
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.xrlTitulo1.Text = "SOLICITUD DE INGRESO / ASOCIADO No. " + teNumAsociado.EditValue
        rpt.XrSubreport1.ReportSource.DataSource = blAporta.rptAsociadosBeneficiarios(teIdAsociado.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.ShowPreview()
    End Sub

    Private Sub CargaCombos()
        objCombos.coo_TiposDocumento(leTipoDocumento)
        objCombos.adm_Sexo(leSexo)
        objCombos.adm_TipoImpuesto(leTipoImpuesto)
        objCombos.adm_EstadoCivil(leEstadoCivil)
        objCombos.adm_Departamentos(leDepartamento)
        objCombos.adm_Municipios(leMunicipio, leDepartamento.EditValue)
        objCombos.adm_Cantones(leCanton, leMunicipio.EditValue, "")
        objCombos.coo_Profesiones(leProfesionCon)
        objCombos.coo_Profesiones(leProfesion)
        objCombos.coo_RubroActividades(leRubro)
        objCombos.coo_Actividades(leActividad, "")
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.adm_EstadoSocio(leEstado, "")
        objCombos.aso_TiposRelacion(leTipoRelacion, "")
        objCombos.adm_TipoVivienda(leTipoVivienda, "")
        objCombos.adm_TiposPlanilla(lePlanilla, "")
        objCombos.adm_TiposDescuentos(leTipoDescuento, "")
        objCombos.coo_UbicacionesAsociados(leCentro, "")
        objCombos.coo_compania(LeCompania)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdAsociadoStart As Integer = 0
        Dim IdAsociadoEnd As Integer = 0

        If TipoAvance = -1 Then
            IdAsociadoStart = objFunciones.ObtenerPrimerId("COO_ASOCIADOS", "IdAsociado")
            If teIdAsociado.EditValue = IdAsociadoStart Then
                teIdAsociado.EditValue = objFunciones.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado") + 1
            End If
        Else
            IdAsociadoEnd = objFunciones.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado")
            If teIdAsociado.EditValue = IdAsociadoEnd Then
                teIdAsociado.EditValue = objFunciones.ObtenerPrimerId("COO_ASOCIADOS", "IdAsociado") - 1
            End If
        End If



        If TipoAvance = 0 Then

            If teIdAsociado.EditValue = 0 Then ' si es cero cuando entra
                teIdAsociado.EditValue = objFunciones.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado")
            Else ' cuando se utiliza la busqueda 
                teIdAsociado.EditValue = blAporta.ObtenerIdAsociado(teIdAsociado.EditValue, TipoAvance)
            End If

        Else
            teIdAsociado.EditValue = blAporta.ObtenerIdAsociado(teIdAsociado.EditValue, TipoAvance)
        End If



        If teIdAsociado.EditValue = 0 Then
            Exit Sub
        End If
        ''teIdAsociado.EditValue = blAporta.ObtenerIdAsociado(teIdAsociado.EditValue, TipoAvance)
        If teIdAsociado.EditValue = 0 Then
            Exit Sub
        End If
        entAsociado = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        With entAsociado
            teIdAsociado.EditValue = .IdAsociado
            teNumAsociado.EditValue = .Numero
            rgTipoPersona.EditValue = .IdTipoPersona
            teNombres.EditValue = .Nombres
            teApellidos.EditValue = .Apellidos
            teRazon.EditValue = .RazonSocial
            teRepresentante.EditValue = .NombreRepLegal
            teConocido.EditValue = .ConocidoPor
            chkCredencial.Checked = .PresentaCredencial
            leTipoDocumento.EditValue = .IdTipoDocumento
            teDocumento.EditValue = .NumeroDocumento
            teLugarExpedicion.EditValue = .LugarExpedicion
            deFechaExpedicion.EditValue = .FechaExpedicion
            teIsss.EditValue = .IsssAfp
            teNit.EditValue = .Nit
            teOtroDocumento.EditValue = .OtroDocumento
            leTipoImpuesto.EditValue = .TipoImpuesto
            deFechaNacimiento.EditValue = .FechaNacimiento
            teLugarNacimiento.EditValue = .LugarNacimiento
            teNacionalidad.EditValue = .Nacionalidad
            leSexo.EditValue = .IdSexo
            leEstadoCivil.EditValue = .IdEstadoCivil
            teDireccion.EditValue = .Direccion
            teUbicacion.EditValue = .Ubicacion
            leDepartamento.EditValue = .IdDepartamento
            leMunicipio.EditValue = .IdMunicipio
            leRubro.EditValue = .IdRubro
            leCanton.EditValue = .IdCanton
            teTelefono.EditValue = .Telefonos
            teCorreoElectronico.EditValue = .CorreoElectronico
            teNombreConyugue.EditValue = .NombreConyuge
            deFechaNacimientoCon.EditValue = .FechaNacConyuge
            teDuiConyuge.EditValue = .NumDocConyuge
            teLugarTrabajoCon.EditValue = .LugarTrabajoConyuge
            teDirTrabajoCon.EditValue = .DirTrabajoConyuge
            teTelTrabajoCon.EditValue = .TelTrabajoConyuge
            leProfesionCon.EditValue = .IdProfesionConyuge
            leProfesion.EditValue = .IdProfesion
            teLugarTrabajo.EditValue = .LugarTrabajo
            teDireccionTrabajo.EditValue = .DireccionTrabajo
            teCargo.EditValue = .CargoTrabajo
            teCargoConyugue.EditValue = .CargoConyuge
            deFecIngresoTrabajo.EditValue = .FechaIngresoTrabajo
            teTelefonoTrabajo.EditValue = .TelefonoTrabajo
            teSalario.EditValue = .SalarioMensual
            teSalarioConyugue.EditValue = .SalarioConyuge
            teOtrosIngresos.EditValue = .OtrosIngresos
            leActividad.EditValue = .IdActividad
            teGiro.EditValue = .GiroNegocio
            teIngresos.EditValue = .IngresosReportados
            teCuotaPresEfectivo.EditValue = .CuotaPresEfectivo
            teEstimadoCuentaAhorro.EditValue = .Monto1
            teEstimadoAportacion.EditValue = .Monto2
            teDepositosPlazo.EditValue = .Monto3
            teExcesoCuotaPactada.EditValue = .Monto4
            teTransferenciaAhorro.EditValue = .Monto5

            gcBeneficiarios.DataSource = blAporta.GetBeneficiarios(.IdAsociado)
            gcDes.DataSource = blAsociado.DescuentosAsociados(.IdAsociado)

            teNumeroHijos.EditValue = .NumeroHijos
            leTipoVivienda.EditValue = .TipoVivienda
            teDuenioVivienda.EditValue = .PropietarioVivienda
            teNomRefPersonal1.EditValue = .NomReferencia1
            teDirRefPersonal1.EditValue = .DirReferencia1
            teTelRefPersonal1.EditValue = .TelReferencia1
            teLugarTrabajoPersonal1.EditValue = .TrabajoReferencia1
            teLugarTrabajoPersonal2.EditValue = .TrabajoReferencia2
            chkSocioRefPersonal1.EditValue = .EsSocio1
            teNomRefPersonal2.EditValue = .NomReferencia2
            teDirRefPersonal2.EditValue = .DirReferencia2
            teTelRefPersonal2.EditValue = .TelReferencia2
            chkSocioRefPersonal2.EditValue = .EsSocio2
            leSucursal.EditValue = .IdSucursal
            deFechaIngreso.EditValue = .FechaIngreso
            deFechaReIngreso.EditValue = .FechaReIngreso
            deFechaRetiro.EditValue = .FechaRetiro
            leEstado.EditValue = .IdEstado
            leTipoRelacion.EditValue = .IdTipoRelacion
            seCorrelativoSolicitud.EditValue = .CorrelativoSolicitud
            teCelular.EditValue = .Celular
            teNombreTrabajoAnterior.EditValue = .NombreTrabajoAnterior
            teTelefonoTrabajoAnterior.EditValue = .TelefonoTrabajoAnterior
            leCentro.EditValue = .IdUbicacion
            chkEnviarDescuentos.EditValue = .EnviarDescuentos
            chkEnviarEstado.EditValue = .EnviarEstadoCuenta
            ceExcluirDividendos.EditValue = .ExcluirDividendos
            ceExcluirFuneraria.EditValue = .ExcluirDividendosFuneraria
            ChecAplicaTelefonia.EditValue = .AplicaTelefonia
            TeNomAsociado.EditValue = .Nombres
            teNAsociado.EditValue = .Numero
        End With

        'CargaEntidadesTelefonia()
        gc.DataSource = objTablas.coo_AsociadosTelefoniaSelectAll(teIdAsociado.EditValue)
        btVerImagen_Click("", New EventArgs())
    End Sub

    Private Sub ActivarControles(ByVal Tipo As Boolean)
        gvBeneficiarios.OptionsBehavior.Editable = Tipo
        gvDes.OptionsBehavior.Editable = Tipo
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
        Next
        For Each ctrl In XtraTabPage3.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        For Each ctrl In XtraTabPage5.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        For Each ctrl In XtraTabPage6.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        btnAgregar.Enabled = Tipo
        btLim.Enabled = Tipo

        'For Each ctrl In XtraTabPage6.Controls
        '    If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
        '        CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
        '    End If
        '    If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
        '        CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
        '    End If
        '    If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
        '        CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
        '    End If
        '    If TypeOf ctrl Is DevExpress.XtraEditors.PictureEdit Then
        '        CType(ctrl, DevExpress.XtraEditors.PictureEdit).Properties.ReadOnly = Not Tipo
        '    End If
        'Next
        ''seCorrelativoSolicitud.Properties.ReadOnly = True
    End Sub

    Function DatosValidos() As Boolean
        If teNumAsociado.EditValue = "" Then
            DxErrorProvider1.SetError(teNumAsociado, "Debe especificar el Número de asociado. Imposible Continuar")
            Return False
        End If
        If teNombres.EditValue = "" Or teApellidos.EditValue = "" Then
            DxErrorProvider1.SetError(teNombres, "Debe especificar el Nombre y Apellido del Asociado. Imposible Continuar")
            teNombres.Focus()
            Return False
        End If
        If teOtroDocumento.EditValue = "" Then
            If teDocumento.EditValue = "" Or Len(Trim(teDocumento.EditValue)) < 2 Then
                MsgBox(String.Format("Debe especificar el Número de Documento del Asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                teDocumento.Focus()
                Return False
            End If
        End If
        If teDocumento.EditValue = "" Or Len(Trim(teDocumento.EditValue)) < 2 Then
            MsgBox(String.Format("Debe especificar el Número de Documento del Asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teDocumento.Focus()
            Return False
        End If
        If teNit.EditValue = "" Then
            DxErrorProvider1.SetError(teNit, "Debe especificar el NIT del Asociado. Imposible Continuar")
            teNit.Focus()
            Return False
        End If
        If SiEsNulo(deFechaNacimiento.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("Debe especificar la Fecha de Nacimiento del Asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaNacimiento.Focus()
            Return False
        End If
        If teDireccion.EditValue = "" Then
            MsgBox("Debe especificar la Dirección del Asociado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teDireccion.Focus()
            Return False
        End If

        If leCanton.EditValue = "" Then
            MsgBox(String.Format("Debe especificar la Comunidad donde vive el Asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            leCanton.Focus()
            Return False
        End If
        If teTelefono.EditValue = "" Then
            MsgBox("Debe especificar por lo menos un Teléfono donde ubicar al Asociado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teTelefono.Focus()
            Return False
        End If

        If teCorreoElectronico.EditValue <> "" Then
            Dim l_reg As New System.Text.RegularExpressions.Regex("^(([^<;>;()[\]\\.,;:\s@\""]+" & _
       "(\.[^<;>;()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@" & _
       "((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}" & _
       "\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+" & _
       "[a-zA-Z]{2,}))$")
            If Not l_reg.IsMatch(teCorreoElectronico.EditValue) Then
                MsgBox("La cuenta de correo electrónico del asociado es invalida" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                Return False
            End If
        End If

        If blAporta.ExisteNumAsociado(teNumAsociado.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe este número de Asociado", MsgBoxStyle.Critical)
            Return False
        End If
        If leProfesion.EditValue < 1 Then
            If MsgBox("Parece ser que no ha seleccionado una profesión correcta" + Chr(13) + "¿Está seguro(a) de querer continuar?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
                leProfesion.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub CargaEntidades()
        With entAsociado
            .IdAsociado = teIdAsociado.EditValue
            .Numero = teNumAsociado.EditValue
            .IdTipoPersona = rgTipoPersona.EditValue
            .Nombres = teNombres.EditValue
            .Apellidos = teApellidos.EditValue
            .RazonSocial = teRazon.EditValue
            .NombreRepLegal = teRepresentante.EditValue
            .ConocidoPor = teConocido.EditValue
            .PresentaCredencial = chkCredencial.Checked
            .IdUbicacion = leCentro.EditValue
            .IdTipoDocumento = leTipoDocumento.EditValue
            .NumeroDocumento = teDocumento.EditValue
            .LugarExpedicion = teLugarExpedicion.EditValue
            .FechaExpedicion = deFechaExpedicion.EditValue
            .IsssAfp = teIsss.EditValue
            .Nit = teNit.EditValue
            .OtroDocumento = teOtroDocumento.EditValue
            .TipoImpuesto = leTipoImpuesto.EditValue
            .FechaNacimiento = deFechaNacimiento.EditValue
            .LugarNacimiento = teLugarNacimiento.EditValue
            .Nacionalidad = teNacionalidad.EditValue
            .IdSexo = leSexo.EditValue
            .IdEstadoCivil = leEstadoCivil.EditValue
            .Direccion = teDireccion.EditValue
            .Ubicacion = teUbicacion.EditValue
            .IdDepartamento = leDepartamento.EditValue
            .IdMunicipio = leMunicipio.EditValue
            .IdCanton = leCanton.EditValue
            .IdRubro = leRubro.EditValue
            .Telefonos = teTelefono.EditValue
            .CorreoElectronico = teCorreoElectronico.EditValue
            .NombreConyuge = teNombreConyugue.EditValue
            .FechaNacConyuge = deFechaNacimientoCon.EditValue
            .NumDocConyuge = teDuiConyuge.EditValue
            .LugarTrabajoConyuge = teLugarTrabajoCon.EditValue
            .DirTrabajoConyuge = teDirTrabajoCon.EditValue
            .TelTrabajoConyuge = teTelTrabajoCon.EditValue
            .IdProfesionConyuge = leProfesionCon.EditValue
            .IdProfesion = leProfesion.EditValue
            .LugarTrabajo = teLugarTrabajo.EditValue
            .DireccionTrabajo = teDireccionTrabajo.EditValue
            .CargoTrabajo = teCargo.EditValue
            .CargoConyuge = teCargoConyugue.EditValue
            .FechaIngresoTrabajo = deFecIngresoTrabajo.EditValue
            .TelefonoTrabajo = teTelefonoTrabajo.EditValue
            .SalarioMensual = teSalario.EditValue
            .SalarioConyuge = teSalarioConyugue.EditValue
            .OtrosIngresos = teOtrosIngresos.EditValue
            .IdActividad = leActividad.EditValue
            .GiroNegocio = teGiro.EditValue
            .IngresosReportados = teIngresos.EditValue
            .CuotaPresEfectivo = teCuotaPresEfectivo.EditValue
            .Monto1 = teEstimadoCuentaAhorro.EditValue
            .Monto2 = teEstimadoAportacion.EditValue
            .Monto3 = teDepositosPlazo.EditValue
            .Monto4 = teExcesoCuotaPactada.EditValue
            .Monto5 = teTransferenciaAhorro.EditValue
            .NumeroHijos = teNumeroHijos.EditValue
            .TipoVivienda = leTipoVivienda.EditValue
            .PropietarioVivienda = teDuenioVivienda.EditValue
            .NomReferencia1 = teNomRefPersonal1.EditValue
            .DirReferencia1 = teDirRefPersonal1.EditValue
            .TelReferencia1 = teTelRefPersonal1.EditValue
            .TrabajoReferencia1 = teLugarTrabajoPersonal1.EditValue
            .EsSocio1 = chkSocioRefPersonal1.EditValue
            .NomReferencia2 = teNomRefPersonal2.EditValue
            .DirReferencia2 = teDirRefPersonal2.EditValue
            .TelReferencia2 = teTelRefPersonal2.EditValue
            .TrabajoReferencia2 = teLugarTrabajoPersonal2.EditValue
            .EsSocio2 = chkSocioRefPersonal2.EditValue
            .IdSucursal = leSucursal.EditValue
            .FechaIngreso = deFechaIngreso.EditValue
            .FechaReIngreso = deFechaReIngreso.EditValue
            .FechaRetiro = deFechaRetiro.EditValue
            .IdEstado = leEstado.EditValue
            .IdTipoRelacion = leTipoRelacion.EditValue
            .CorrelativoSolicitud = seCorrelativoSolicitud.EditValue
            .Celular = teCelular.EditValue
            .NombreTrabajoAnterior = teNombreTrabajoAnterior.EditValue
            .TelefonoTrabajoAnterior = teTelefonoTrabajoAnterior.EditValue
            .AplicaComision = False
            .EnviarDescuentos = chkEnviarDescuentos.EditValue
            .EnviarEstadoCuenta = chkEnviarEstado.EditValue
            .ExcluirDividendos = ceExcluirDividendos.EditValue
            .ExcluirDividendosFuneraria = ceExcluirFuneraria.EditValue
            .AplicaTelefonia = ChecAplicaTelefonia.EditValue
            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With

        entBeneficiario = New List(Of coo_AsociadosBeneficiarios)
        For i = 0 To gvBeneficiarios.DataRowCount - 1
            Dim entDetalle As New coo_AsociadosBeneficiarios
            With entDetalle
                .IdAsociado = 0  ' Se asigna en la capa de datos
                .IdBeneficiario = i
                .Nombre = gvBeneficiarios.GetRowCellValue(i, "Nombre")
                .Domicilio = gvBeneficiarios.GetRowCellValue(i, "Domicilio")
                .Parentesco = gvBeneficiarios.GetRowCellValue(i, "Parentesco")
                .Porcentaje = gvBeneficiarios.GetRowCellValue(i, "Porcentaje")
            End With
            entBeneficiario.Add(entDetalle)
        Next

        entDescuentos = New List(Of coo_AsociadosDescuentos)
        For i = 0 To gvDes.DataRowCount - 1
            Dim entDetalle As New coo_AsociadosDescuentos
            With entDetalle
                .IdAsociado = 0  ' Se asigna en la capa de datos
                .IdDetalle = i + 1
                .IdPlanilla = gvDes.GetRowCellValue(i, "IdPlanilla")
                .IdRubro = gvDes.GetRowCellValue(i, "IdRubro")
                .Descuento = gvDes.GetRowCellValue(i, "Descuento")
            End With
            entDescuentos.Add(entDetalle)
        Next

    End Sub

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leDepartamento.EditValueChanged
        objCombos.adm_Municipios(leMunicipio, leDepartamento.EditValue)
    End Sub

    Private Sub cboMunicipio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leMunicipio.EditValueChanged
        objCombos.adm_Cantones(leCanton, leMunicipio.EditValue, "")
    End Sub

    Private Sub cboRubro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leRubro.EditValueChanged
        Dim IdRubro As Integer = leRubro.EditValue
        objCombos.coo_Actividades(leActividad, String.Format("IdRubro={0}", IdRubro))
    End Sub

    Private Sub teSalario_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teSalario.EditValueChanged, teOtrosIngresos.EditValueChanged
        teIngresos.EditValue = teSalario.EditValue + teOtrosIngresos.EditValue
    End Sub

    Private Sub btDeclaracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDeclaracion.Click

        Dim dt As DataTable = blAporta.rptDatosDeclaracionJuradaAsociado(teIdAsociado.EditValue)


        Dim entDocRtf As coo_Documentos = objTablas.coo_DocumentosSelectByPK("DeclaracionJuradaAsociado")
        Dim texto As String = entDocRtf.Contenido

        With dt.Rows(0)
            texto = texto.Replace("[Oficina]", .Item("Sucursal"))
            texto = texto.Replace("[Nombre]", .Item("Nombre"))
            texto = texto.Replace("[Origen]", .Item("OrigenFondos"))
            texto = texto.Replace("[Profesion]", .Item("Profesion"))
            texto = texto.Replace("[Monto1]", .Item("Monto1"))
            texto = texto.Replace("[Monto2]", .Item("Monto2"))
            texto = texto.Replace("[Monto3]", .Item("Monto3"))
            texto = texto.Replace("[Monto4]", .Item("Monto4"))
            texto = texto.Replace("[Monto5]", .Item("Monto5"))
            texto = texto.Replace("[Domicilio]", .Item("Domicilio"))
            texto = texto.Replace("[Dui]", .Item("Dui"))
            texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
            texto = texto.Replace("[Nit]", .Item("Nit"))
            texto = texto.Replace("[Fecha]", FechaToString(.Item("FechaIngreso"), .Item("FechaIngreso")))
            texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
            texto = texto.Replace("[NombreEmp]", gsNombre_Empresa)
            texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
            texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))
        End With

        Dim rpt As New pre_rptRichTextLogo
        rpt.XrEscrito.Rtf = texto
        rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
        rpt.ShowPreview()
    End Sub
    Private Sub btnFicha_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFicha.Click
        Dim rpt As New aso_rptFichaAsociado
        rpt.DataSource = blAporta.rptFichaAsociado(teIdAsociado.EditValue)
        rpt.DataMember = ""
        If rgTipoPersona.EditValue = 1 Then
            rpt.xrlPCredencial1.Visible = False
            rpt.xrlPCredencial2.Visible = False
        End If
        rpt.XrPictureBox1.ImageUrl = entSucursal.LogoImageUrl
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl1.SelectedPageChanged
        If IsDummy1 And XtraTabControl1.SelectedTabPageIndex = 1 Then
            leProfesionCon.ItemIndex = 0
            IsDummy1 = False
        End If
        If IsDummy2 And XtraTabControl1.SelectedTabPageIndex = 2 Then
            leProfesion.ItemIndex = 0
            IsDummy2 = False
        End If
    End Sub

    Private Sub sbFolio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbFolio.Click
        Dim rpt As New aso_rptFolioAsociado
        rpt.DataSource = blAsociado.rptFolioAsociado(teIdAsociado.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = dtParam.Rows(0).Item("NombreEmpresa")
        rpt.xrlEmpresaLargo.Text = dtParam.Rows(0).Item("NombreLargo")
        rpt.XrSubreport1.ReportSource.DataSource = blAporta.rptAsociadosBeneficiarios(teIdAsociado.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.ShowPreviewDialog()

        Dim rpt2 As New aso_rptFolioAsociado2
        rpt2.DataSource = blAsociado.rptFolioAsociado(teIdAsociado.EditValue)
        rpt2.XrLabelSocio.Text = teNombres.Text & " " & teApellidos.Text
        rpt2.DataMember = ""
        rpt2.ShowPreviewDialog()
    End Sub

    Private Sub sbTramite_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbTramite.Click
        entDocRtf = objTablas.coo_DocumentosSelectByPK("HojaTramite")
        Dim texto As String = entDocRtf.Contenido
        Dim Nombre As String = ""
        Dim Telefono As String = ""
        Nombre = teNombres.EditValue & " " & teApellidos.EditValue
        Telefono = teTelefono.EditValue
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

    Private Sub btVerImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVerImagen.Click

        Dim FileName As String = dtParam(0).Item("RutaImagenes")
        If rgImagen.EditValue = 1 Then
            FileName &= teNumAsociado.EditValue '"Foto-" & 
        End If


        If rgImagen.EditValue = 2 Then
            FileName &= "Dui-" & teNumAsociado.EditValue
        End If
        If rgImagen.EditValue = 3 Then
            FileName &= "Nit-" & teNumAsociado.EditValue
        End If
        If rgImagen.EditValue = 4 Then
            FileName &= "Firma-" & teNumAsociado.EditValue
        End If

        Dim Archivo As String = FileName
        Archivo = FileName & ".jpg"


        If Not FileIO.FileSystem.FileExists(Archivo) Then
            FileName = ""
        Else
            If Not FileIO.FileSystem.FileExists(Archivo) Then
                Archivo = FileName & ".bmp"
                If Not FileIO.FileSystem.FileExists(Archivo) Then
                    FileName = ""

                Else
                    Archivo = FileName & ".png"
                    If Not FileIO.FileSystem.FileExists(Archivo) Then
                        FileName = ""
                    End If
                End If
            End If
        End If


        If FileName <> "" Then
            Dim bm As New Bitmap(Archivo)
            peImagen.Image = bm
        Else
            peImagen.Image = Nothing
        End If
    End Sub
    Private Sub CargaEntidadesTelefonia()
        Dim entAsoTelefonia As New coo_AsociadosTelefonia
        With entAsoTelefonia
            .IdAsociado = teIdAsociado.EditValue
            .Compania = LeCompania.EditValue
            .Ntelefono = TeNtelefono.EditValue
            .Marca = TeMarca.EditValue
            .Modelo = TeModelo.EditValue
            .Serie = TeSerie.EditValue
            .PlanDatos = ChecDatos.EditValue
            .PlanVoz = ChecVoz.EditValue
            .CapacidadDatos = SpiDatos.EditValue
            .CapacidadVoz = SpiVoz.EditValue
            .FechaActivacion = DefechaActivacion.EditValue
            .FechaVencimiento = DeFechaVencimiento.EditValue
            .FechaAsiganacionMovil = DeFechaAsignacion.EditValue
            .Activo = ChecActivo.EditValue
            If btnAgregar.Text = "Agregar" Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            Else
                .ModificadoPor = objMenu.User
                .FechaHoraModificacion = Now
            End If
        End With
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim entAsoTelefonia1 As New coo_AsociadosTelefonia
        Dim Aso = SiEsNulo(blAsociado.VerificaAsociado(teIdAsociado.EditValue), 0)
        If Aso = 0 Then
            MsgBox("Error de Usuario" + Chr(13) + "Debe de Guardar el Asociado antes de Asignarle Telefonos", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        If TeNtelefono.EditValue = "" Or TeMarca.EditValue = "" Or TeSerie.EditValue = "" Or TeModelo.EditValue = "" Then
            MsgBox("Error de Usuario" + Chr(13) + "No Puede guaradar Sin Numero de Telefono", MsgBoxStyle.Exclamation, "Nota")
            TeNtelefono.Focus()
            Exit Sub
        End If
        If btnAgregar.Text = "Agregar" Then
            TeIdTelefono.EditValue = objFunciones.ObtenerUltimoIdTelefono("coo_AsociadosTelefonia", "IdTelefono", teIdAsociado.EditValue) + 1
        Else
            'TeIdTelefono.EditValue
        End If
        With entAsoTelefonia1
            .IdAsociado = teIdAsociado.EditValue
            .IdTelefono = TeIdTelefono.EditValue
            .Compania = LeCompania.EditValue
            .Ntelefono = TeNtelefono.EditValue
            .NContrato = TeContrato.EditValue
            .Marca = TeMarca.EditValue
            .Modelo = TeModelo.EditValue
            .Serie = TeSerie.EditValue
            .PlanDatos = ChecDatos.Checked
            .PlanVoz = ChecVoz.Checked
            .CapacidadDatos = SpiDatos.EditValue
            .CapacidadVoz = SpiVoz.EditValue
            .FechaActivacion = DefechaActivacion.EditValue
            .FechaVencimiento = DeFechaVencimiento.EditValue
            .FechaAsiganacionMovil = DeFechaAsignacion.EditValue
            .Activo = ChecActivo.EditValue
            If btnAgregar.Text = "Agregar" Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
                .FechaHoraModificacion = Nothing
            Else
                .CreadoPor = Tecreado.EditValue
                .FechaHoraCreacion = decreado.EditValue
                .ModificadoPor = objMenu.User
                .FechaHoraModificacion = Now
            End If
        End With

        If btnAgregar.Text = "Agregar" Then
            objTablas.coo_AsociadosTelefoniaInsert(entAsoTelefonia1)
        Else
            objTablas.coo_AsociadosTelefoniaUpdate(entAsoTelefonia1)
        End If
        gc.DataSource = objTablas.coo_AsociadosTelefoniaSelectAll(teIdAsociado.EditValue)
        TeIdTelefono.EditValue = objFunciones.ObtenerUltimoIdTelefono("coo_AsociadosTelefonia", "IdTelefono", teIdAsociado.EditValue) + 1
        LeCompania.EditValue = 1
        TeNtelefono.EditValue = ""
        TeContrato.EditValue = ""
        TeMarca.EditValue = ""
        DeFechaAsignacion.EditValue = Today
        DefechaActivacion.EditValue = Today
        DeFechaVencimiento.EditValue = Today
        TeSerie.EditValue = ""
        TeModelo.EditValue = ""
        SpiVoz.EditValue = ""
        SpiDatos.EditValue = ""
        ChecActivo.Checked = False
        ChecDatos.Checked = False
        ChecVoz.Checked = False
        btnAgregar.Text = "Agregar"
        TeNtelefono.Focus()
    End Sub
    Private Sub ChecVoz_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecVoz.EditValueChanged
        If ChecVoz.Checked = True Then
            SpiVoz.Enabled = True
        Else
            SpiVoz.Enabled = False
        End If
    End Sub
    Private Sub ChecDatos_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecDatos.EditValueChanged
        If ChecDatos.Checked = True Then
            SpiDatos.Enabled = True
        Else
            SpiDatos.Enabled = False
        End If
    End Sub
    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        If MsgBox("Eliminar Registro" + Chr(13) + "Está seguro(a) de Eliminar el telefono?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim id As Integer = gv.GetRowCellValue(gv.FocusedRowHandle, "IdTelefono")
        objTablas.coo_AsociadosTelefoniaDeleteByPK(teIdAsociado.EditValue, id)
        gv.DeleteSelectedRows()
    End Sub
    Private Sub gc_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        btnAgregar.Text = "Actualizar"
        Dim entAsoTelefonia1 As New coo_AsociadosTelefonia
        Dim id As Integer = gv.GetRowCellValue(gv.FocusedRowHandle, "IdTelefono")
        entAsoTelefonia1 = objTablas.coo_AsociadosTelefoniaSelectByPK(teIdAsociado.EditValue, id)
        With entAsoTelefonia1
            LeCompania.EditValue = .Compania
            TeIdTelefono.EditValue = .IdTelefono
            TeNtelefono.EditValue = .Ntelefono
            TeContrato.EditValue = .NContrato
            TeMarca.EditValue = .Marca
            DeFechaAsignacion.EditValue = .FechaAsiganacionMovil
            DefechaActivacion.EditValue = .FechaActivacion
            DeFechaVencimiento.EditValue = .FechaVencimiento
            TeSerie.EditValue = .Serie
            ChecActivo.EditValue = .Activo
            TeModelo.EditValue = .Modelo
            SpiVoz.EditValue = .CapacidadVoz
            SpiDatos.EditValue = .CapacidadDatos
            ChecDatos.Checked = .PlanDatos
            ChecVoz.Checked = .PlanVoz
            Tecreado.EditValue = .CreadoPor
            decreado.EditValue = .FechaHoraCreacion
        End With

    End Sub
    Private Sub teIdAsociado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teIdAsociado.EditValueChanged
        TeIdTelefono.EditValue = objFunciones.ObtenerUltimoIdTelefono("coo_AsociadosTelefonia", "IdTelefono", teIdAsociado.EditValue)
        Dim entAsoTelefonia1 As New coo_AsociadosTelefonia
        entAsoTelefonia1 = objTablas.coo_AsociadosTelefoniaSelectByPK(teIdAsociado.EditValue, TeIdTelefono.EditValue)
        With entAsoTelefonia1
            LeCompania.EditValue = .Compania
            TeIdTelefono.EditValue = .IdTelefono
            TeNtelefono.EditValue = .Ntelefono
            TeContrato.EditValue = .NContrato
            TeMarca.EditValue = .Marca
            DeFechaAsignacion.EditValue = .FechaAsiganacionMovil
            DefechaActivacion.EditValue = .FechaActivacion
            DeFechaVencimiento.EditValue = .FechaVencimiento
            TeSerie.EditValue = .Serie
            ChecActivo.EditValue = .Activo
            TeModelo.EditValue = .Modelo
            SpiVoz.EditValue = .CapacidadVoz
            SpiDatos.EditValue = .CapacidadDatos
            ChecDatos.Checked = .PlanDatos
            ChecVoz.Checked = .PlanVoz
        End With
    End Sub
    Private Sub LIM()
        LeCompania.EditValue = 1
        TeNtelefono.EditValue = ""
        TeContrato.EditValue = ""
        TeMarca.EditValue = ""
        DeFechaAsignacion.EditValue = Today
        DefechaActivacion.EditValue = Today
        DeFechaVencimiento.EditValue = Today
        TeSerie.EditValue = ""
        TeModelo.EditValue = ""
        SpiVoz.EditValue = ""
        SpiDatos.EditValue = ""
        ChecActivo.Checked = False
        ChecDatos.Checked = False
        ChecVoz.Checked = False
        btnAgregar.Text = "Agregar"
        TeNtelefono.Focus()
    End Sub

    Private Sub btLim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btLim.Click
        LeCompania.EditValue = 1
        TeNtelefono.EditValue = ""
        TeContrato.EditValue = ""
        TeMarca.EditValue = ""
        DeFechaAsignacion.EditValue = Today
        DefechaActivacion.EditValue = Today
        DeFechaVencimiento.EditValue = Today
        TeSerie.EditValue = ""
        TeModelo.EditValue = ""
        SpiVoz.EditValue = ""
        SpiDatos.EditValue = ""
        ChecActivo.Checked = False
        ChecDatos.Checked = False
        ChecVoz.Checked = False
        btnAgregar.Text = "Agregar"
        TeNtelefono.Focus()
    End Sub

    Private Sub gc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gc.Click
        Dim entAsoTelefonia1 As New coo_AsociadosTelefonia
        Dim id As Integer = gv.GetRowCellValue(gv.FocusedRowHandle, "IdTelefono")
        entAsoTelefonia1 = objTablas.coo_AsociadosTelefoniaSelectByPK(teIdAsociado.EditValue, id)
        With entAsoTelefonia1
            LeCompania.EditValue = .Compania
            TeIdTelefono.EditValue = .IdTelefono
            TeNtelefono.EditValue = .Ntelefono
            TeContrato.EditValue = .NContrato
            TeMarca.EditValue = .Marca
            DeFechaAsignacion.EditValue = .FechaAsiganacionMovil
            DefechaActivacion.EditValue = .FechaActivacion
            DeFechaVencimiento.EditValue = .FechaVencimiento
            TeSerie.EditValue = .Serie
            ChecActivo.EditValue = .Activo
            TeModelo.EditValue = .Modelo
            SpiVoz.EditValue = .CapacidadVoz
            SpiDatos.EditValue = .CapacidadDatos
            ChecDatos.Checked = .PlanDatos
            ChecVoz.Checked = .PlanVoz
            Tecreado.EditValue = .CreadoPor
            decreado.EditValue = .FechaHoraCreacion
        End With
        btnAgregar.Text = "Actualizar"
    End Sub

    Private Sub BtnRptTelefonia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRptTelefonia.Click
        Dim Id As Integer
        If ChecIndividual.Checked = True Then
            Id = teIdAsociado.EditValue
        Else
            Id = -1
        End If
        Dim rpt As New pre_rptListadoTelefonia
        rpt.DataSource = blAsociado.ListadoTelefonia(Id)
        If ChecIndividual.Checked = True Then
            rpt.xrlTitulo.Text = "LISTADO DE TELEFONOS DEL ASOCIADO " & teNombres.Text & " " & teApellidos.Text
        Else
            rpt.xrlTitulo.Text = "LISTADO DE TELEFONIA "
        End If
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub
End Class
