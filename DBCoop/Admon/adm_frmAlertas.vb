Imports DBCoopBL
Imports DBCoopEL.TableEntities


Public Class adm_frmAlertas
    Dim entAlerta As coo_Alertas
    Dim blAdmon As New AdmonBLL
    Dim blAso As New AsociadosBLL(), dtParam As DataTable = blAdmon.ObtieneParametros()
    Dim blPres As New PrestamosBLL
    Dim IdAlerta As Integer = 0

    Private Sub pre_frmAlertas_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        teIdAlerta.EditValue = objFunciones.ObtenerUltimoId("COO_Alertas", "IdAlerta")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Private Sub pre_frmAlertas_New_Click() Handles Me.Nuevo
        IdAlerta = teIdAlerta.EditValue
        ActivarControles(True)
        entAlerta = New coo_Alertas

        teIdAlerta.EditValue = objFunciones.ObtenerUltimoId("Coo_Alertas", "IdAlerta") + 1
        teNumCliente.EditValue = ""
        teIdCliente.EditValue = 0
        teNombreCliente.EditValue = ""
        beNumPrestamo.EditValue = ""
        teIdPrestamo.EditValue = 0
        deFechaDefinicion.EditValue = Today
        deFechaVencimiento.EditValue = Today
        leProceso.EditValue = 1
        chkClave.EditValue = False
        teAlerta.EditValue = ""
        teNumCliente.Focus()
    End Sub
    Private Sub pre_frmAlertas_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = blAdmon.InsertaAlertas(entAlerta)
            If msj = "" Then
                MsgBox("La Alerta ha sido guardada con éxito", MsgBoxStyle.Information)
                teIdAlerta.EditValue = entAlerta.IdAlerta
            Else
                MsgBox(String.Format("No fue posible actualizar la Alerta{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = blAdmon.UpdateAlerta(entAlerta)
            If msj = "" Then
                MsgBox("La Alerta ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la Alerta{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        IdAlerta = teIdAlerta.EditValue
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub pre_frmAlertas_Query_Click() Handles Me.Consulta
        teIdAlerta.EditValue = objConsultas.ConsultaAlertas(frmConsultas)
        CargaControles(0)
    End Sub
    Private Sub pre_frmAlertas_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teNumCliente.Focus()
    End Sub
    Private Sub pre_frmAlertas_Undo_Click() Handles Me.Revertir
        teIdAlerta.EditValue = IdAlerta
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub pre_frmAlertas_Report_Click() Handles Me.Reporte

    End Sub
    Private Sub pre_frmAlertas_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar la Alerta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_AlertasDeleteByPK(teIdAlerta.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Alerta ha sido eliminada con éxito", MsgBoxStyle.Information)
                teIdAlerta.EditValue -= 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar la Alerta{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub
    Function DatosValidos() As Boolean
        If teNumCliente.EditValue = "" Then
            MsgBox(String.Format("No se ha especificado el número de Asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumCliente.Focus()
            Return False
        End If
        If beNumPrestamo.EditValue = "" And (leProceso.EditValue = 3 Or leProceso.EditValue = 4) Then
            MsgBox(String.Format("Es necesario especificar el número de Préstamo{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            beNumPrestamo.Focus()
            Return False
        End If
        If SiEsNulo(deFechaDefinicion.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha de Definicion de la Alerta{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaDefinicion.Focus()
            Return False
        End If
        If teIdCliente.EditValue = 0 Then
            MsgBox(String.Format("Falta especificar el Codigo de Cliente{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumCliente.Focus()
            Return False
        End If
        If leProceso.Text = "" Then
            MsgBox(String.Format("Falta especificar el proceso donde aplicara la Alerta{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            leProceso.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub CargaEntidades()
        With entAlerta
            .IdAlerta = teIdAlerta.EditValue
            .IdAsociado = teIdCliente.EditValue
            .IdPrestamo = teIdPrestamo.EditValue
            .FechaDefinicion = deFechaDefinicion.EditValue
            .FechaVencimiento = deFechaVencimiento.EditValue
            .ProcesoAplica = leProceso.EditValue
            .Descripcion = teAlerta.EditValue
            .Contrasenia = chkClave.EditValue
            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With
    End Sub
    Private Sub teNumCliente_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumCliente.ButtonClick
        If teNumCliente.Properties.ReadOnly = False Then
            frmConsultaAsociados.ShowDialog()
            teIdCliente.EditValue = frmConsultaAsociados.IdAsociado
            teNumCliente_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub teNumCliente_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumCliente.Validated, teIdCliente.Validated
        If teIdCliente.EditValue = 0 Then
            Dim dt As DataTable = blAso.DatosGeneralesAsociadoPorNumero(teNumCliente.EditValue)
            If dt.Rows.Count = 0 Then
                Exit Sub
            End If
            teIdCliente.EditValue = dt.Rows(0).Item("IdCliente")
        End If
        Dim entClientes As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdCliente.EditValue)
        teNumCliente.EditValue = entClientes.Numero
        teNombreCliente.EditValue = entClientes.Nombres + " " + entClientes.Apellidos
    End Sub
    Private Sub CargaCombos()
        objCombos.pre_TiposAlerta(leProceso, "")
    End Sub
    Private Sub ActivarControles(ByVal Tipo As Boolean)
        teIdAlerta.Properties.ReadOnly = True
        teIdCliente.Properties.ReadOnly = True
        teNombreCliente.Properties.ReadOnly = True
        beNumPrestamo.Properties.ReadOnly = Not Tipo
        teIdPrestamo.Properties.ReadOnly = True
        deFechaDefinicion.Properties.ReadOnly = Not Tipo
        deFechaVencimiento.Properties.ReadOnly = Not Tipo
        teNumCliente.Properties.ReadOnly = Not Tipo
        leProceso.Properties.ReadOnly = Not Tipo
        teAlerta.Properties.ReadOnly = Not Tipo
        chkClave.Properties.ReadOnly = Not Tipo
    End Sub
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim Prestamo As New coo_Prestamos
        Dim IdAlertaStart As Integer = 0
        Dim IdAlertaEnd As Integer = 0
        If TipoAvance = -1 Then
            IdAlertaStart = objFunciones.ObtenerPrimerId("Coo_Alertas", "IdAlerta")
            If teIdAlerta.EditValue = IdAlertaStart Then
                teIdAlerta.EditValue += 1
            End If
        End If
        If TipoAvance = 1 Then
            IdAlertaEnd = objFunciones.ObtenerUltimoId("Coo_Alertas", "IdAlerta")
            If teIdAlerta.EditValue = IdAlertaEnd Then
                teIdAlerta.EditValue -= 1
            End If
        End If
        If teIdAlerta.EditValue = 0 Then
            Exit Sub
        End If
        teIdAlerta.EditValue = blAdmon.ObtenerIdAlerta(teIdAlerta.EditValue, TipoAvance)
        If teIdAlerta.EditValue = 0 Then
            Exit Sub
        End If
        entAlerta = objTablas.coo_AlertasSelectByPK(teIdAlerta.EditValue)
        Prestamo = objTablas.coo_PrestamosSelectByPK(entAlerta.IdPrestamo)
        With entAlerta
            teIdAlerta.EditValue = .IdAlerta
            teIdCliente.EditValue = .IdAsociado
            teNumCliente_Validated(teIdCliente, New EventArgs)
            teIdPrestamo.EditValue = .IdPrestamo
            beNumPrestamo.EditValue = Prestamo.Numero
            beNumPrestamo_Validated(teIdPrestamo, New EventArgs)
            deFechaDefinicion.EditValue = .FechaDefinicion
            deFechaVencimiento.EditValue = .FechaVencimiento
            leProceso.EditValue = .ProcesoAplica
            teAlerta.EditValue = .Descripcion
            chkClave.EditValue = .Contrasenia
        End With
    End Sub

    Private Sub beNumPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumPrestamo.ButtonClick
        If teNumCliente.Properties.ReadOnly = False Then
            frmConsultaPrestamos.ShowDialog()
            beNumPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
            beNumPrestamo_Validated(e, New EventArgs)
        End If
    End Sub

    Private Sub beNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumPrestamo.Validated
        Dim entAsociado As New coo_Asociados
        Dim entPrestamo As New coo_Prestamos

        Dim NumeroPrestamo As String
        If beNumPrestamo.EditValue = "" Then
            NumeroPrestamo = Nothing
        Else
            NumeroPrestamo = beNumPrestamo.EditValue
        End If
        entPrestamo = blPres.coo_PrestamosSelectByNumero(NumeroPrestamo)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If entPrestamo.IdPrestamo > 1 Then
            If entPrestamo.IdAsociado <> teIdCliente.EditValue Then
                MsgBox(String.Format("El Préstamo Seleccionado no Pertenece al Asociado{0}", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                beNumPrestamo.Focus()
                beNumPrestamo.EditValue = ""
                teIdPrestamo.EditValue = 0
            End If
        Else
            beNumPrestamo.EditValue = ""
            teIdPrestamo.EditValue = 0
        End If
    End Sub
End Class
