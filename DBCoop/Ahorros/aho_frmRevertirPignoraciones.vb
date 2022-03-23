Imports DBCoopBL
Public Class aho_frmRevertirPignoraciones
    Dim bl As New AhorrosBLL
    Private Sub aho_frmRevertirPignoraciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.DataSource = bl.ObtenerPignoraciones(gIdSucursal)
        gv.BestFitColumns()
    End Sub

    Private Sub btRevertir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btRevertir.Click
        Dim Id As Integer = SiEsNulo(gv.GetFocusedRowCellValue("IdPignoracion"), 0)
        If Id = 0 Then
            MsgBox("No se ha seleccionado ninguna cuenta", MsgBoxStyle.Critical, "Imposible continuar")
            Exit Sub
        End If
        If MsgBox("Está seguro(a) de revertir ésta pignoración?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If
        If bl.RevertirPignoracion(Id, objMenu.User) > 0 Then
            MsgBox("La reversión se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
            gc.DataSource = bl.ObtenerPignoraciones(gIdSucursal)
            gv.BestFitColumns()
        Else
            MsgBox("No se pudo realizar la reversión de la pignoración", MsgBoxStyle.Information, "Nota")
        End If
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImprimir.Click
        gc.ShowPrintPreview()
    End Sub
End Class
