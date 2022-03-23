Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmEliminaLiquidacionCompras

    Dim blCaja As New CajaBusiness()
    Dim entLiquidacion As New coo_Liquidaciones
    Dim FechaContable As DateTime

    Private Sub frmEliminaLiquidacionCompras_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _NroComprobante.Focus()
    End Sub

    Private Sub frmEliminaLiquidacionCompras_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEliminaLiquidacionCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
    End Sub

    Private Sub _NroComprobante_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _NroComprobante.Validated
        If _NroComprobante.EditValue = "" Then
            teIdOperacion.EditValue = 0
            _monto.EditValue = 0.0
            _observa.EditValue = ""
            Exit Sub
        End If
        entLiquidacion = blCaja.coo_LiquidacionesSelectByNumero(leSucursal.EditValue, _NroComprobante.EditValue)
        If entLiquidacion.Numero = "" Then
            teIdOperacion.EditValue = 0
            _monto.EditValue = 0.0
            _observa.EditValue = ""
            MsgBox("No Existe la Liquidación", MsgBoxStyle.Critical)
            Exit Sub
        End If
        teIdOperacion.EditValue = entLiquidacion.IdComprobante
        deFechaCorte.EditValue = entLiquidacion.Fecha
        _monto.EditValue = entLiquidacion.Reintegro
        teNombre.EditValue = entLiquidacion.NombreProveedor
        _observa.EditValue = entLiquidacion.Concepto
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim msj As String = ""
        If teIdOperacion.EditValue <= 0 Then
            MsgBox("No Existe el Comprobante de Liquidacion", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        FechaContable = blCaja.GetFechaContable(gIdSucursal)
        ''If deFechaCorte.EditValue <> FechaContable Then
        ''    MsgBox("No es Posible eliminar el Comprobante de Liquidación, El periodo esta Cerrado", MsgBoxStyle.Exclamation, "Nota")
        ''    Exit Sub
        ''End If
        If MsgBox("Está seguro(a) de eliminar el Comprobante de Liquidación?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_LiquidacionesDeleteByPK(teIdOperacion.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El Comprobante de Liquidación fue eliminado con Exito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar el Comprobante de Liquidación" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al eliminar el registro")
            End If
        End If
        Close()
    End Sub

End Class