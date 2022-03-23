Imports DBCoopBL
Imports DevExpress.XtraReports.UI
Imports System

Public Class adm_frmLogin
    Private NumIntentos As Integer = 0
    Dim bl As AdmonBLL
    Dim blCaja As New CajaBusiness

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.SkinName)
    End Sub

    Private Sub sbOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbOk.Click
        Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(tePassword.Text)
        Dim inArray As Byte() = provider.ComputeHash(bytes)
        provider.Clear()
        'encripto el password
        Dim sPassWord As String = Convert.ToBase64String(inArray)
        'MsgBox(sPassWord)
        bl = New AdmonBLL()
        'If Not bl.ValidarUsuario(teUserName.Text, sPassWord, iNum_Intentos) Then
        '    MsgBox("Usuario o contraseña mal ingresados", MsgBoxStyle.Critical)
        '    iNum_Intentos = +1
        '    Return
        'End If
        Dim msj As String = bl.ValidarUsuario(teUserName.EditValue, sPassWord)
        If msj <> "Ok" Then
            If msj = "No" Then
                MsgBox("Usuario o contraseña mal ingresados", MsgBoxStyle.Critical)
                NumIntentos += 1
                If NumIntentos = 3 Then
                    End
                    Close()
                End If
                Return
            Else
                MsgBox(String.Format("SE DETECTO UN ERROR DE CONEXIÓN{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
                Return
            End If
        End If
        CrearObjetos()
        CrearVariablesGlobales()
        Dim dt As DataTable = bl.ObtenerSucursalUsuario(teUserName.EditValue)
        gIdSucursal = dt.Rows(0).Item("IdSucursal")

        objMenu.FechaContable = Format(objFunciones.GetFechaContable(gIdSucursal), "dd/MM/yyyy")
        objMenu.User = teUserName.Text
        objMenu.Sucursal = dt.Rows(0).Item("Nombre")
        gsImpresorDefault = blCaja.ObtenerImpresorDefault(objMenu.User)
        Application.EnableVisualStyles()
        Close()
    End Sub

    Private Sub sbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancel.Click
        End
    End Sub
End Class
