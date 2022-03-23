Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmDictamenGerencia
    Dim entDictamen As coo_DictamenGerencia
    Dim _IdSolicitud As Integer = 0
    Dim bl As New PrestamosBLL()

    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Private Sub pre_frmDictamenGerencia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles(0)
        meRecomendacion.Focus()
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entDictamen = objTablas.coo_DictamenGerenciaSelectByPK(IdSolicitud)
        If entDictamen.RecomendacionGerencia = "" Then
            meRecomendacion.EditValue = ""
            teTipoTramite.EditValue = ""
            meOtrasCondiciones.EditValue = ""
        Else
            With entDictamen
                meRecomendacion.EditValue = .RecomendacionGerencia
                teTipoTramite.EditValue = .TipoTramite
                meOtrasCondiciones.EditValue = .OtrasCondiciones
            End With
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""

        If bl.ExisteDictamenGerencia(IdSolicitud) > 0 Then
            msj = bl.UpdateDictamenGerencia(entDictamen)
            If msj = "" Then
                MsgBox("El Dictamen de Gerencia ha sido actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el Dictamen de Gerencia" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaDictamenGerencia(entDictamen)
            If msj = "" Then
                MsgBox("El Dictamen de Gerencia ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el Dictamen de Gerencia" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If
        Close()

    End Sub

    Function DatosValidos() As Boolean
        'If meRecomendacion.EditValue = "" Then
        '    MsgBox("Debe especificar la Resolución de Gerencia" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    meRecomendacion.Focus()
        '    Return False
        'End If
        'If teTipoTramite.Text = "" Then
        '    MsgBox("Debe especificar el Tipo de Trámite del préstamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    teTipoTramite.Focus()
        '    Return False
        'End If
        'If meOtrasCondiciones.Text = "" Then
        '    MsgBox("Debe especificar otras condiciones" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    meOtrasCondiciones.Focus()
        '    Return False
        'End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entDictamen
            .IdSolicitud = IdSolicitud
            .RecomendacionGerencia = meRecomendacion.EditValue
            .TipoTramite = teTipoTramite.EditValue
            .OtrasCondiciones = meOtrasCondiciones.EditValue
        End With
    End Sub

End Class