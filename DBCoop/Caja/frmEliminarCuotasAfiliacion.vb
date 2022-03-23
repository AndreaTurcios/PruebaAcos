Imports CajaBL
Public Class frmEliminarCuotasAfiliacion
    Dim blCaja As New CajaBusiness()


    Private Sub frmEliminarCuotasAfiliacion_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEliminarCuotaAfiliacion_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        gc.DataSource = blCaja.ObtenerAfiliacionesAplicadas(gIdSucursal, blCaja.GetFechaContable(gIdSucursal))
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGuardar.Click
        Dim FechaContable As Date = blCaja.GetFechaContable(gIdSucursal)
        If MsgBox("Desea Eliminar el Ingreso de Afiliación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim IdAsociado As Integer = gv.GetFocusedRowCellValue(gv.Columns("IdAsociado"))
            blCaja.RevertirEstadoAfiliacion(IdAsociado)
            gc.DataSource = blCaja.ObtenerAfiliacionesAplicadas(gIdSucursal, FechaContable)
            Close()
        End If
    End Sub

End Class