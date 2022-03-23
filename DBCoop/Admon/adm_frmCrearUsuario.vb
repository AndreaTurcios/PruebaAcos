Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Drawing.Printing.PrinterSettings
Public Class adm_frmCrearUsuario
    Dim myBL As New TableBusiness()
    Private Sub adm_frmCrearUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tePass.EditValue = ""
        teId.EditValue = ""
        teApellidos.EditValue = ""
        teNombres.EditValue = ""
        objCombos.adm_TipoUsuario(leTipoUsuario)
        objCombos.adm_Sucursales(leSucursal, "")

        Dim i As Integer
        Dim iList As New ArrayList
        Dim pkInstalledPrinters As String

        For i = 0 To InstalledPrinters.Count - 1
            pkInstalledPrinters = InstalledPrinters.Item(i)
            iList.Add(pkInstalledPrinters)
        Next

        leImpresoras.Properties.DataSource = iList

        'Dim pd As New PrintDocument
        'Dim Impresoras As String
        'Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName

        '' recorre las impresoras instaladas  
        'For Each Impresoras In PrinterSettings.InstalledPrinters
        '    leImpresoras.Items.Add(Impresoras.ToString)

        'Next
        '' selecciona la impresora predeterminada  
        'leImpresoras.EditValue = s_Default_Printer
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If teId.EditValue = "" Then
            MsgBox("Debe de especificar la identificación del usuario", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        If tePass.EditValue = "" Then
            MsgBox("Debe de especificar la contraseña del usuario", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        If tePass.EditValue <> teConPass.EditValue Then
            MsgBox("La Confirmacion de contraseña no coincide", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        Dim entUser As New adm_Usuarios
        Dim Provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim Bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(tePass.EditValue)
        Dim inArray As Byte() = provider.ComputeHash(bytes)
        provider.Clear()
        'encripto el password
        Dim sPassWord As String = Convert.ToBase64String(inArray)

        entUser.IdUsuario = teId.EditValue
        entUser.Clave = sPassWord
        entUser.Nombre = teNombres.EditValue
        entUser.Apellidos = teApellidos.EditValue
        entUser.FechaCreacion = Today
        entUser.FechaVencimiento = Today
        entUser.Estado = 1
        entUser.TipoUsuario = leTipoUsuario.EditValue
        entUser.IdSucursal = leSucursal.EditValue
        entUser.PuedeVerCorte = ceVerCorte.Checked
        myBL.adm_UsuariosInsert(entUser)
        MsgBox("El usuario ha sido guardado", MsgBoxStyle.Information, "Nota")
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    
End Class