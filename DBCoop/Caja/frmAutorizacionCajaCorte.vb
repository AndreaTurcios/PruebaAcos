Imports System
Imports CajaBL
Public Class frmAutorizacionCajaCorte
    Dim blCaja As New CajaBusiness()
    Private Sub cmdCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdCancel.Click
        Close()
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAceptar.Click
        Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(teContrasenia.EditValue)
        Dim inArray As Byte() = provider.ComputeHash(bytes)
        provider.Clear()
        'encripto el password
        Dim Contrasenia As String = Convert.ToBase64String(inArray)

        AccesoAutorizado = blCaja.VerificaUsuarioCajeroVerCorte(teUserId.EditValue, Contrasenia)
        If Not AccesoAutorizado Then
            MsgBox("Este usuario no está autorizado para ejecutar la acción solicitada", MsgBoxStyle.Critical, "Error")
        End If
        Close()
    End Sub

    Private _Acceso As Boolean
    Public Property AccesoAutorizado() As Boolean
        Get
            Return _Acceso
        End Get
        Set(ByVal value As Boolean)
            _Acceso = value
        End Set
    End Property
End Class