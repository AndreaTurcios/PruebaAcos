Imports DBCoopBL
Public Class adm_frmCierreDia
    Dim bl As New AdmonBLL()
    
    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        leSucursal.EditValue = gIdSucursal
        leSucursal.Properties.ReadOnly = True
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        If MsgBox(String.Format("Ya no podrá registrar ningúna operación con ésta fecha{0}Está seguro(a) de continuar con el cierre?", Chr(13)), MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim msj As String = ""
        msj = bl.adm_CierreSucursal(leSucursal.EditValue, deFecha.EditValue, objMenu.User, False)
        If msj = "Ok" Then
            MsgBox("El cierre se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
            deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
            Close()
        Else
            MsgBox(String.Format("Se generó un error al momento de realizar el cierre{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
        End If
    End Sub
End Class
