Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmFiadores
    Dim entFiador As coo_GarantiasFiador
    Dim _IdSolicitud As Integer = 0
    Dim _IdGarantia As Integer = 0
    Dim bl As New PrestamosBLL()
    Dim blAporta As New AportacionesBLL()
    Dim blAdmon As New AdmonBLL()
    Dim blCaja As New TableBusiness()
    Dim entObligacionFiador As List(Of coo_FiadoresObligacion)
    Dim entBienesFiador As List(Of coo_FiadoresBien)
    Dim entReferenciasFiador As List(Of coo_FiadoresReferencia)
    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Public Property IdGarantia() As Integer
        Get
            Return _IdGarantia
        End Get
        Set(ByVal value As Integer)
            _IdGarantia = value
        End Set
    End Property

    Private Sub pre_frmFiadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        CargaControles(0)
        gcObligaciones.DataSource = bl.GetObligacionesFiador(IdSolicitud, IdGarantia)
        gcBienes.DataSource = bl.GetBienesFiador(IdSolicitud, IdGarantia)
        gcReferencias.DataSource = bl.GetReferenciasFiador(IdSolicitud, IdGarantia)
        teTotalIngresos.Properties.ReadOnly = True
        teTotalEgresos.Properties.ReadOnly = True
        teLiquidez.Properties.ReadOnly = True
        teNombres.Focus()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_TipoTrabajo(cboTipoTrabajo, "")
        objCombos.coo_Profesiones(cboProfesion)
        objCombos.adm_Departamentos(cboDepartamento)
        objCombos.adm_Municipios(cboMunicipio, "")
        objCombos.adm_Cantones(cboCanton, "", "")
        objCombos.adm_Sexo(cboSexo)
        objCombos.adm_EstadoCivil(cboEstadoCivil)
        objCombos.adm_TipoContratacion(leContratacion, "")
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entFiador = objTablas.coo_GarantiasFiadorSelectByPK(IdSolicitud, IdGarantia)
        If entFiador.NombresApellidos = "" Then
            teIdAsociado.EditValue = 0
            teNombres.EditValue = ""
            teDocumento.EditValue = ""
            teLugarExpedicion.EditValue = ""
            deFechaExpedicion.EditValue = Today
            cboProfesion.EditValue = 1
            teNit.EditValue = ""
            teDireccion.EditValue = ""
            cboDepartamento.EditValue = ""
            cboMunicipio.EditValue = ""
            cboCanton.EditValue = ""
            teTelefono.EditValue = ""
            deFechaNacimiento.EditValue = Today
            cboSexo.EditValue = 1
            cboEstadoCivil.EditValue = 1
            teNumeroHijos.EditValue = 0
            chkCasaPropia.EditValue = True

            cboTipoTrabajo.EditValue = 1
            teLugarTrabajo.EditValue = ""
            teDireccionTrabajo.EditValue = ""
            teTelefonoTrabajo.EditValue = ""
            leContratacion.EditValue = 1
            teTiempoNegocio.EditValue = ""

            teSueldo.EditValue = 0.0
            teComision.EditValue = 0.0
            teNegocio.EditValue = 0.0
            teOtrosIngresos.EditValue = 0.0
            teGastosVida.EditValue = 0.0
            tePagoObligaciones.EditValue = 0.0
            teGastosNegocio.EditValue = 0.0
            teOtrosEgresos.EditValue = 0.0
            teTotalIngresos_Validated(teTotalIngresos, New System.ComponentModel.CancelEventArgs)
            teTiempoConocer.EditValue = ""
            chkEsFamiliar.EditValue = False
            teParentesco.EditValue = ""
            sePorcentajeCubre.EditValue = 0.0
        Else
            With entFiador
                teIdAsociado.EditValue = .IdAsociado
                teNombres.EditValue = .NombresApellidos
                teDocumento.EditValue = .NroDocumento
                teLugarExpedicion.EditValue = .LugarExpedicion
                deFechaExpedicion.EditValue = .FechaExpedicion
                cboProfesion.EditValue = .IdProfesion
                teNit.EditValue = .Nit
                teDireccion.EditValue = .Direccion
                cboDepartamento.EditValue = .IdDepartamento
                cboMunicipio.EditValue = .IdMunicipio
                cboCanton.EditValue = .IdCanton
                teTelefono.EditValue = .Telefonos
                deFechaNacimiento.EditValue = .FechaNacimiento
                cboSexo.EditValue = .IdSexo
                cboEstadoCivil.EditValue = .IdEstadoCivil
                teNumeroHijos.EditValue = .PersonasSostiene
                chkCasaPropia.EditValue = .ViveCasaPropia

                cboTipoTrabajo.EditValue = .TipoTrabajo
                teLugarTrabajo.EditValue = .NombreTrabajo
                teDireccionTrabajo.EditValue = .DireccionTrabajo
                teTelefonoTrabajo.EditValue = .TelefonoTrabajo
                leContratacion.EditValue = .TipoContratacion
                teTiempoNegocio.EditValue = .TiempoTrabajo

                teSueldo.EditValue = .SalarioMensual
                teComision.EditValue = .Comisiones
                teNegocio.EditValue = .IngresosNegocio
                teOtrosIngresos.EditValue = .OtrosIngresos
                teGastosVida.EditValue = .GastosVida
                tePagoObligaciones.EditValue = .PagoObligaciones
                teGastosNegocio.EditValue = .GastosNegocio
                teOtrosEgresos.EditValue = .OtrosGastos
                teTotalIngresos_Validated(teTotalIngresos, New System.ComponentModel.CancelEventArgs)

                gcObligaciones.DataSource = bl.GetObligacionesFiador(IdSolicitud, IdGarantia)
                gcBienes.DataSource = bl.GetBienesFiador(IdSolicitud, IdGarantia)
                gcReferencias.DataSource = bl.GetReferenciasFiador(IdSolicitud, IdGarantia)
                teTiempoConocer.EditValue = .TiempoConocer
                chkEsFamiliar.EditValue = .EsFamiliar
                teParentesco.EditValue = .Parentesco
                sePorcentajeCubre.EditValue = .PorcentajeCubre
            End With
        End If
    End Sub

    Private Sub sbPrestamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbPrestamo.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""

        If bl.ExisteFiadorSolicitud(IdSolicitud, IdGarantia) > 0 Then
            msj = bl.UpdateFiadorSolicitud(entFiador, entObligacionFiador, entBienesFiador, entReferenciasFiador)
            If msj = "" Then
                MsgBox("El Fiador ha sido actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar el Fiador{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaFiadorSolicitud(entFiador, entObligacionFiador, entBienesFiador, entReferenciasFiador)
            If msj = "" Then
                MsgBox("El Fiador ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el Fiador" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If
        Me.Close()
    End Sub

    Function DatosValidos() As Boolean
        If teNombres.EditValue = "" Then
            MsgBox("Debe especificar el Nombre del Fiador" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNombres.Focus()
            Return False
        End If
        If cboCanton.Text = "" Then
            MsgBox("Debe especificar el Cantón del Fiador" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            cboCanton.Focus()
            Return False
        End If
        If cboProfesion.Text = "" Then
            MsgBox("Debe especificar la Profesion del Fiador" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            cboProfesion.Focus()
            Return False
        End If
        If cboEstadoCivil.Text = "" Then
            MsgBox("Debe especificar el Estado Civil" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            cboProfesion.Focus()
            Return False
        End If
        If teDocumento.Text = "" Then
            MsgBox("Debe especificar el Número de Dui del Fiador" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teDocumento.Focus()
            Return False
        End If
        If teNit.Text = "" Then
            MsgBox("Debe especificar el Número de Nit del Fiador" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNit.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entFiador
            .IdGarantia = IdGarantia
            .IdSolicitud = IdSolicitud
            .IdAsociado = teIdAsociado.EditValue
            .NombresApellidos = teNombres.EditValue
            .NroDocumento = teDocumento.EditValue
            .LugarExpedicion = teLugarExpedicion.EditValue
            .FechaExpedicion = deFechaExpedicion.EditValue
            .IdProfesion = cboProfesion.EditValue
            .Nit = teNit.EditValue
            .Direccion = teDireccion.EditValue
            .IdDepartamento = cboDepartamento.EditValue
            .IdMunicipio = cboMunicipio.EditValue
            .IdCanton = cboCanton.EditValue
            .Telefonos = teTelefono.EditValue
            .FechaNacimiento = deFechaNacimiento.EditValue
            .IdSexo = cboSexo.EditValue
            .IdEstadoCivil = cboEstadoCivil.EditValue
            .PersonasSostiene = teNumeroHijos.EditValue
            .ViveCasaPropia = chkCasaPropia.EditValue
            .TipoTrabajo = cboTipoTrabajo.EditValue
            .NombreTrabajo = teLugarTrabajo.EditValue
            .DireccionTrabajo = teDireccionTrabajo.EditValue
            .TelefonoTrabajo = teTelefonoTrabajo.EditValue
            .TipoContratacion = leContratacion.EditValue
            .TiempoTrabajo = teTiempoNegocio.EditValue

            .SalarioMensual = teSueldo.EditValue
            .Comisiones = teComision.EditValue
            .IngresosNegocio = teNegocio.EditValue
            .OtrosIngresos = teOtrosIngresos.EditValue
            .GastosVida = teGastosVida.EditValue
            .PagoObligaciones = tePagoObligaciones.EditValue
            .GastosNegocio = teGastosNegocio.EditValue
            .OtrosGastos = teOtrosEgresos.EditValue
            .TiempoConocer = teTiempoConocer.EditValue
            .EsFamiliar = chkEsFamiliar.EditValue
            .Parentesco = teParentesco.EditValue
            .PorcentajeCubre = sePorcentajeCubre.EditValue
        End With
        entObligacionFiador = New List(Of coo_FiadoresObligacion)
        For i = 0 To gvObligaciones.DataRowCount - 1
            Dim entDetalle As New coo_FiadoresObligacion
            With entDetalle
                .IdFiador = IdGarantia  ' Se asigna en la capa de datos
                .IdObligacion = i
                .Acreedor = gvObligaciones.GetRowCellValue(i, "Acreedor")
                .MontoDeuda = gvObligaciones.GetRowCellValue(i, "MontoDeuda")
                .SaldoActual = gvObligaciones.GetRowCellValue(i, "SaldoActual")
                .AbonoMensual = gvObligaciones.GetRowCellValue(i, "AbonoMensual")
            End With
            entObligacionFiador.Add(entDetalle)
        Next
        entBienesFiador = New List(Of coo_FiadoresBien)
        For i = 0 To gvBienes.DataRowCount - 1
            Dim entDetalleA As New coo_FiadoresBien
            With entDetalleA
                .IdFiador = IdGarantia  ' Se asigna en la capa de datos
                .IdBien = i
                .DescripcionPropiedad = gvBienes.GetRowCellValue(i, "DescripcionPropiedad")
                .Direccion = gvBienes.GetRowCellValue(i, "Direccion")
                .ValorAproximado = gvBienes.GetRowCellValue(i, "ValorAproximado")
                .hipotecado = gvBienes.GetRowCellValue(i, "hipotecado")
            End With
            entBienesFiador.Add(entDetalleA)
        Next
        entReferenciasFiador = New List(Of coo_FiadoresReferencia)
        For i = 0 To gvReferencias.DataRowCount - 1
            Dim entDetalleR As New coo_FiadoresReferencia
            With entDetalleR
                .IdFiador = IdGarantia  ' Se asigna en la capa de datos
                .IdReferencia = i
                .Nombre = gvReferencias.GetRowCellValue(i, "Nombre")
                .Direccion = gvReferencias.GetRowCellValue(i, "Direccion")
                .Parentesco = gvReferencias.GetRowCellValue(i, "Parentesco")
            End With
            entReferenciasFiador.Add(entDetalleR)
        Next
    End Sub

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        objCombos.adm_Municipios(cboMunicipio, cboDepartamento.EditValue)
    End Sub

    Private Sub cboMunicipio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.EditValueChanged
        objCombos.adm_Cantones(cboCanton, cboMunicipio.EditValue, "")
    End Sub

    Private Sub teIdAsociado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated
        Dim entAsociados As New coo_Asociados
        Dim IdAsociado As Integer
        If teIdAsociado.EditValue = Nothing Then
            IdAsociado = Nothing
        Else
            IdAsociado = teIdAsociado.EditValue
        End If
        entAsociados = blCaja.coo_AsociadosSelectByPK(IdAsociado)
        teIdAsociado.EditValue = entAsociados.IdAsociado
        teNombres.EditValue = entAsociados.Nombres & " " & entAsociados.Apellidos
        teDocumento.EditValue = entAsociados.NumeroDocumento
        teLugarExpedicion.EditValue = entAsociados.LugarExpedicion
        deFechaExpedicion.EditValue = entAsociados.FechaExpedicion
        cboProfesion.EditValue = entAsociados.IdProfesion
        teNit.EditValue = entAsociados.Nit
        teDireccion.EditValue = entAsociados.Direccion
        cboDepartamento.EditValue = entAsociados.IdDepartamento
        cboMunicipio.EditValue = entAsociados.IdMunicipio
        cboCanton.EditValue = entAsociados.IdCanton
        teTelefono.EditValue = entAsociados.Telefonos
        deFechaNacimiento.EditValue = entAsociados.FechaNacimiento
        cboSexo.EditValue = entAsociados.IdSexo
        cboEstadoCivil.EditValue = entAsociados.IdEstadoCivil
        teNumeroHijos.EditValue = entAsociados.NumeroHijos
        chkCasaPropia.EditValue = True
        teLugarTrabajo.EditValue = entAsociados.LugarTrabajo
        teDireccionTrabajo.EditValue = entAsociados.DireccionTrabajo
        teTelefonoTrabajo.EditValue = entAsociados.TelefonoTrabajo


        Dim entSaldoCredito As DataTable = blAporta.rptSolicitudRetiro(entAsociados.IdAsociado, Today)
        teSaldoAhorros.EditValue = 0.0
        teSaldoAportaciones.EditValue = 0.0
        teSaldoDeudas.EditValue = 0.0
        teSaldoDeudasFiador.EditValue = 0.0
        teSaldoDisponible.EditValue = 0.0



        teSaldoAhorros.EditValue = entSaldoCredito.Rows(0).Item("TotalAhorro")
        teSaldoAportaciones.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones")
        teSaldoDeudas.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")
        teSaldoDeudasFiador.EditValue = entSaldoCredito.Rows(0).Item("SaldoComoFiador")
        teSaldoDisponible.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones") - (entSaldoCredito.Rows(0).Item("TotalDeducciones") + entSaldoCredito.Rows(0).Item("SaldoComoFiador"))


    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teIdAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub teTotalIngresos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teTotalIngresos.Validated, teSueldo.Validated, teComision.Validated, teNegocio.Validated, teOtrosIngresos.Validated, teGastosVida.Validated, tePagoObligaciones.Validated, teGastosNegocio.Validated, teOtrosEgresos.Validated
        teTotalIngresos.EditValue = teSueldo.EditValue + teComision.EditValue + teNegocio.EditValue + teOtrosIngresos.EditValue
        teTotalEgresos.EditValue = teGastosVida.EditValue + tePagoObligaciones.EditValue + teGastosNegocio.EditValue + teOtrosEgresos.EditValue
        teLiquidez.EditValue = teTotalIngresos.EditValue - teTotalEgresos.EditValue
    End Sub


    Private Sub sbAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAlerta.Click
        adm_frmAlertas2.ShowDialog()
    End Sub
End Class