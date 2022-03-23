Imports System
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmModificaUsuario
    Dim myBL As New TableBusiness()
    Dim entUser As New adm_Usuarios

    Dim _IdUsuario As String = 0
    Public Property IdUsuario() As String
        Get
            Return _IdUsuario
        End Get
        Set(ByVal value As String)
            _IdUsuario = value
        End Set
    End Property


    Private Sub adm_frmModificaUsuario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_TipoUsuario(leTipoUsuario)
        objCombos.adm_Sucursales(leSucursal, "")
        entUser = myBL.adm_UsuariosSelectByPK(IdUsuario)
        leTipoUsuario.EditValue = CInt(entUser.TipoUsuario)
        leSucursal.EditValue = CInt(entUser.IdSucursal)
        teId.EditValue = entUser.IdUsuario
        teApellidos.EditValue = entUser.Apellidos
        teNombres.EditValue = entUser.Nombre
        ceVerCorte.EditValue = entUser.PuedeVerCorte
    End Sub



    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If tePass.EditValue = "" Then
            MsgBox("Debe de especificar la contraseña Anterior del usuario", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        If teNewPass.EditValue = "" Then
            MsgBox("Debe de especificar la Nueva contraseña del usuario", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        If teConPass.EditValue = "" Then
            MsgBox("Debe de Confirmar la Nueva contraseña del usuario", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        If teConPass.EditValue <> teNewPass.EditValue Then
            MsgBox("La Nueva Contraseña no coincide con la confirmación", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        Dim entUser As New adm_Usuarios
        entUser = myBL.adm_UsuariosSelectByPK(IdUsuario)
        Dim Provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim Bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(tePass.EditValue)
        Dim inArray As Byte() = Provider.ComputeHash(Bytes)
        Provider.Clear()
        'encripto el password
        Dim sAnteriorPassWord As String = Convert.ToBase64String(inArray)
        If sAnteriorPassWord <> entUser.Clave Then
            MsgBox("La contraseña Anterior no coincide", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        Dim ProviderNew As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim BytesNew As Byte() = System.Text.Encoding.UTF8.GetBytes(teNewPass.EditValue)
        Dim inArrayNew As Byte() = ProviderNew.ComputeHash(BytesNew)
        ProviderNew.Clear()
        'encripto el password
        Dim sPassWord As String = Convert.ToBase64String(inArrayNew)

        entUser.IdUsuario = teId.EditValue
        entUser.Nombre = teNombres.EditValue
        entUser.Apellidos = teApellidos.EditValue
        entUser.Clave = sPassWord
        entUser.FechaCreacion = Today
        entUser.FechaVencimiento = Today
        entUser.Estado = 1
        entUser.TipoUsuario = leTipoUsuario.EditValue
        entUser.IdSucursal = leSucursal.EditValue
        entUser.PuedeVerCorte = ceVerCorte.EditValue
        myBL.adm_UsuariosUpdate(entUser)
        MsgBox("El usuario ha sido guardado", MsgBoxStyle.Information, "Nota")
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

End Class