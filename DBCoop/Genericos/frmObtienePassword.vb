Imports System
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmObtienePassword
    Private NumIntentos As Integer = 0
    Dim bl As AdmonBLL

    Private _TipoUsuario As Integer
    Public Property TipoUsuario() As Integer
        Get
            Return _TipoUsuario
        End Get
        Set(ByVal value As Integer)
            _TipoUsuario = value
        End Set
    End Property
    Private _Usuario As String
    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Private _Accceso As Boolean
    Public Property Acceso() As Boolean
        Get
            Return _Accceso
        End Get
        Set(ByVal value As Boolean)
            _Accceso = value
        End Set
    End Property

    Private Sub sbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbOk.Click
        Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(tePassword.Text)
        Dim inArray As Byte() = provider.ComputeHash(bytes)
        Dim entUsuario As adm_Usuarios

        provider.Clear()
        'encripto el password
        Dim sPassWord As String = Convert.ToBase64String(inArray)
        'MsgBox(sPassWord)
        bl = New AdmonBLL()
        entUsuario = objTablas.adm_UsuariosSelectByPK(teUserName.EditValue)
        If entUsuario.TipoUsuario <> TipoUsuario Then
            MsgBox("El Tipo de Usuario No corresponde a la Operación", MsgBoxStyle.Critical)
            Acceso = False
            Return
        End If
        Dim msj As String = bl.ValidarUsuario(teUserName.EditValue, sPassWord)
        If msj <> "Ok" Then
            If msj = "No" Then
                MsgBox("Contraseña Incorrecta", MsgBoxStyle.Critical)
                Acceso = False
                Return
            Else
                MsgBox(String.Format("SE DETECTO UN ERROR DE CONEXIÓN{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
                Return
            End If
        Else
            Acceso = True
            Close()
        End If
    End Sub

    Private Sub sbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancel.Click
        Acceso = False
        Close()
    End Sub

    Private Sub frmObtienePassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        teUserName.EditValue = Usuario
        tePassword.EditValue = ""
        Acceso = False
    End Sub
End Class