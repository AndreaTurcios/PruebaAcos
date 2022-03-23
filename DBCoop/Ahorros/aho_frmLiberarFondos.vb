Imports DBCoopBL
Public Class aho_frmLiberarFondos
    Dim bl As New AhorrosBLL()

    Private Sub aho_frmLiberarFondos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gcMov.DataSource = bl.GetDepositosPignorados(gIdSucursal)
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbSalir.Click
        Close()
    End Sub


    Private Sub sbAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAceptar.Click
        Dim msj As String = ""
        If MsgBox("Desea Liberar el Depósito o Fondo ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Liberar") = MsgBoxResult.Yes Then
            msj = bl.LiberarFondoDeposito(gvMov.GetFocusedRowCellValue(gvMov.Columns("IdCuenta")), gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov")))
            If msj = "" Then
                gcMov.DataSource = bl.GetDepositosPignorados(gIdSucursal)
            Else
                MsgBox(String.Format("No fue Posible Liberar los Fondos de Ahorro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
    End Sub
End Class
