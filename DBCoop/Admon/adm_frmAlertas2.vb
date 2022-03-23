Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmAlertas2
    Dim entAlerta As coo_Alertas
    Dim blAdmon As New AdmonBLL
    Dim blAso As New AsociadosBLL(), dtParam As DataTable = blAdmon.ObtieneParametros()
    Dim blPres As New PrestamosBLL
    Dim IdAlerta As Integer = 0
 

    Private Sub pre_frmFiadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        CargaControles(0)
        teIdAlerta.EditValue = objFunciones.ObtenerUltimoId("COO_Alertas", "IdAlerta")
    End Sub

    Private Sub CargaCombos()
objCombos.pre_TiposAlerta(leProceso, "")
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        IdAlerta = teIdAlerta.EditValue
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

    Private Sub sbPrestamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        msj = blAdmon.InsertaAlertas(entAlerta)
        If msj = "" Then
            MsgBox("La Alerta ha sido guardada con éxito", MsgBoxStyle.Information)
            teIdAlerta.EditValue = entAlerta.IdAlerta
        Else
            MsgBox(String.Format("No fue posible actualizar la Alerta{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If

        Me.Close()
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

            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .ModificadoPor = ""

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

End Class