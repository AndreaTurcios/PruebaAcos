Imports DBCoopBL
Imports DBCoopEL.TableEntities



Public Class aho_frmDevolucionAhorro
    Dim blAhorro As New AhorrosBLL()


    Private Sub aho_frmCapitalizacionIntereses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_TiposCuenta(leTipoCuenta, "-- TODAS LAS CUENTAS DE AHORRO --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        seDescuento.EditValue = 0.0
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
        Dim msj As String

        If MsgBox("Está seguro(a) de realizar la devolución de ahorro?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        msj = blAhorro.DevolucionAhorro(deFecha.EditValue, leTipoCuenta.EditValue, leSucursal.EditValue, seDescuento.EditValue, seDescuentoAPartir.EditValue, objMenu.User)
        If msj = "" Then
            MsgBox("Devolución realizada con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("No fue posible realizar la devolución" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If
        Me.Close()
    End Sub

End Class
