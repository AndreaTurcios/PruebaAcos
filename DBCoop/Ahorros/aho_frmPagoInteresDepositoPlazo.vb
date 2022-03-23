Imports DBCoopBL
Public Class aho_frmPagoInteresDepositoPlazo
    Dim blAhorro As New AhorrosBLL()

    Private Sub aho_frmPagoInteresDepositoPlazo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
    End Sub

    Private Sub cmdAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        Dim msj As String = ""
        If blAhorro.ExisteCapitalizacionPlazo(deFecha.EditValue, gIdSucursal) > 0 Then
            MsgBox("Ya se ha ejecutado una capitalización en ésta fecha" + Chr(13) + "Si requiere volver a ejecutarla debe contactar con I.T.", MsgBoxStyle.Critical)
            Return
        End If

        If MsgBox("Está seguro(a) de realizar la capitalización?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Return
        End If

        msj = blAhorro.CapitalizacionPlazo(deFecha.EditValue, gIdSucursal, objMenu.User)
        If msj = "" Then
            MsgBox("Capitalización realizada con éxito", MsgBoxStyle.Information, "Nota")
        Else
            MsgBox(String.Format("No fue posible realizar la capitalización{0}{0}Reporte el siguiente mensaje a I.T.{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            Return
        End If
        Close()
    End Sub
End Class
