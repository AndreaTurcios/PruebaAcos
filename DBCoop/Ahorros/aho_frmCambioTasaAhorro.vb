Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmCambioTasaAhorro
    Dim blAhorro As New AhorrosBLL()


    Private Sub beNumeroCuenta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroCuenta.ButtonClick
        frmConsultaCuentasAhorro.ShowDialog()
        beNumeroCuenta.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        beNumeroCuenta_Validated(e, New EventArgs)
    End Sub


    Private Sub beNumeroCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuenta.Validated
        If beNumeroCuenta.EditValue = "" Then
            teIdCuenta.EditValue = 0
            Exit Sub
        End If

        teIdCuenta.EditValue = blAhorro.ObtenerIdCuentaByNumero(beNumeroCuenta.EditValue)

        If teIdCuenta.EditValue = 0 Then
            MsgBox("No existe la cuenta especificada", MsgBoxStyle.Exclamation, "Nota")
            beNumeroCuenta.EditValue = ""
            teIdCuenta.EditValue = 0
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        Dim entCuentaCorriente As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entCuentaCorriente.IdAsociado)
        teAsociado.EditValue = String.Format("{0}, {1} {2}", entCuentaCorriente.Numero, entAsociados.Nombres, entAsociados.Apellidos)
    End Sub

    Private Sub btCambio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCambio.Click
        Dim FechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        Dim msj As String = ""

        If seTasa.EditValue <= 0 Then
            MsgBox("Debe colocar una tasa de interes correcta", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

            If MsgBox("Está seguro(a) de Cambiar la Tasa de Ahorro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                msj = blAhorro.CambioTasaAhorro(teIdCuenta.EditValue, seTasa.EditValue, FechaContable, objMenu.User)

                If msj = "Ok" Then
                    MsgBox("El cambio se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
                    Close()
                Else
                    MsgBox(String.Format("Se generó un error al momento de realizar el cambio{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
                End If

            End If

    End Sub
End Class
