Imports DBCoopBL
Public Class adm_frmGenerarPartida
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        leSucursal.EditValue = gIdSucursal
        leSucursal.Properties.ReadOnly = True
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        If ChecTelefonia.Checked = True Then
            If MsgBox("Está seguro(a) de generar la partida Telefonia Movil?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                Dim msj2 As String = ""
                msj2 = blPres.PartidaTelefonia(deFecha.EditValue, objMenu.User)
                If msj2 = "Ok" Then
                    MsgBox("La Partida  ha sido generada con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox(String.Format("No fue posible Contabilizar los Descuentos Telefonia {0}{1}", Chr(13), msj2), MsgBoxStyle.Critical)
                    Return
                End If
            End If
        Else
            If MsgBox("Está seguro(a) de generar la partida contable?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                Dim msj2 As String = ""
                msj2 = blPres.PartidaCargaPlanilla(3, deFecha.EditValue, objMenu.User)
                If msj2 = "Ok" Then
                    MsgBox("La Partida  ha sido generada con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj2), MsgBoxStyle.Critical)
                    Return
                End If
            End If
        End If
    End Sub
End Class
