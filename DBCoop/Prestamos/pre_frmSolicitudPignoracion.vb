Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmSolicitudPignoracion
    Dim entPignorada As coo_GarantiasCuentaPignorada
    Dim _IdSolicitud As Integer = 0
    Dim _IdGarantia As Integer = 0
    Dim _IdAsociado As Integer = 0
    Dim bl As New PrestamosBLL()
    Dim blAhorros As New AhorrosBLL()
    Dim blCaja As New TableBusiness()

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

    Public Property IdAsociado() As Integer
        Get
            Return _IdAsociado
        End Get
        Set(ByVal value As Integer)
            _IdAsociado = value
        End Set
    End Property

    Private Sub pre_frmSolicitudPignoracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles(0)
        teValorPignorado.Focus()
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entPignorada = objTablas.coo_GarantiasCuentaPignoradaSelectByPK(IdSolicitud, IdGarantia)
        If entPignorada.IdCuenta = 0 Then
            teIdCuenta.EditValue = 0
            beNumeroCuenta.EditValue = ""
            teIdAsociado.EditValue = IdAsociado
            teNombres.EditValue = ""
            teValorPignorado.EditValue = 0.0
        Else
            With entPignorada
                teIdCuenta.EditValue = .IdCuenta
                beNumeroCuenta.EditValue = .NumeroCuenta
                teIdAsociado.EditValue = .IdAsociado
                teNombres.EditValue = .Nombres
                teValorPignorado.EditValue = .ValorPignorado
            End With
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If bl.ExisteCuentaPignoradaSolicitud(IdSolicitud, IdGarantia) > 0 Then
            msj = bl.ActualizarCuentaPignoradaSolicitud(entPignorada)
            If msj = "" Then
                MsgBox("La cuenta pignorada ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la cuenta pignorada" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaCuentaPignoradaSolicitud(entPignorada)
            If msj = "" Then
                MsgBox("La Cuenta pignorada ha sido guardada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la Cuenta Pignorada" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If
        Me.Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim dFechaContable As New Date
        Dim entSaldoAhorro As New coo_UltMovAhorro
        Dim entCuentaP As New coo_GarantiasCuentaPignorada
        If teIdCuenta.EditValue <= 0 Then
            MsgBox("Debes especificar el Id de Cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNumeroCuenta.Focus()
            Return False
        End If
        If teValorPignorado.Text <= 0 Then
            MsgBox("Debes especificar el Valor Pignorado de la Cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teValorPignorado.Focus()
            Return False
        End If

        If teIdAsociado.Text <> IdAsociado Then
            MsgBox("La Cuenta No coincide con el Asociado de la Solicitud" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNumeroCuenta.Focus()
            Return False
        End If
        entSaldoAhorro = blAhorros.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        If teValorPignorado.EditValue > entSaldoAhorro.SaldoDisponible Then
            MsgBox("El Valor a Pignorar no Coincide con el Saldo de la Cuenta " + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNumeroCuenta.Focus()
            Return False
        End If
        entCuentaP = blAhorros.coo_spGarantiasCuentaPignoradaSelectByPK(teIdCuenta.EditValue)
        If Not (entCuentaP.Nombres = "") Then
            If entCuentaP.IdCuenta = teIdCuenta.EditValue Then
                If entCuentaP.IdGarantia = IdGarantia Then
                    If entCuentaP.Aplicado = True Then
                        MsgBox("Esta cuenta ya fue Pignorada con la Solicitud " + (entCuentaP.IdSolicitud).ToString + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                        beNumeroCuenta.Focus()
                        Return False
                    End If
                Else
                    MsgBox("Esta cuenta ya fue Pignorada en esta Solicitud " + (entCuentaP.IdSolicitud).ToString + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                    beNumeroCuenta.Focus()
                    Return False
                End If
            Else
                If entCuentaP.Aplicado = True Then
                    MsgBox("Esta cuenta ya fue Pignorada con la Solicitud " + (entCuentaP.IdSolicitud).ToString + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                    beNumeroCuenta.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entPignorada
            .IdGarantia = IdGarantia
            .IdSolicitud = IdSolicitud
            .IdCuenta = teIdCuenta.EditValue
            .NumeroCuenta = beNumeroCuenta.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .Nombres = teNombres.EditValue
            .ValorPignorado = teValorPignorado.EditValue
        End With
    End Sub

    Private Sub btIdCuenta_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles beNumeroCuenta.Click
        teIdCuenta.EditValue = objConsultas.ConsultaCuentaAhorro(frmConsultas, IdAsociado)
        btIdCuenta_Validated(e, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub btIdCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuenta.Validated
        Dim entCuenta As coo_CuentasAhorro
        Dim entAsociados As New coo_Asociados
        Dim entSaldoAhorro As New coo_UltMovAhorro
        Dim IdCuentaCte As Integer
        If teIdCuenta.EditValue = Nothing Then
            IdCuentaCte = Nothing
        Else
            IdCuentaCte = teIdCuenta.EditValue
        End If
        entCuenta = blCaja.coo_CuentasAhorroSelectByPK(IdCuentaCte)
        entSaldoAhorro = blAhorros.coo_UltMovAhorroSelectBy(IdCuentaCte)
        teIdCuenta.EditValue = entCuenta.IdCuenta
        entAsociados = blCaja.coo_AsociadosSelectByPK(entCuenta.IdAsociado)
        beNumeroCuenta.EditValue = entCuenta.Numero
        teIdAsociado.EditValue = entCuenta.IdAsociado
        teNombres.EditValue = entAsociados.Nombres & " " & entAsociados.Apellidos
        teValorPignorado.EditValue = entSaldoAhorro.SaldoDisponible
    End Sub
End Class