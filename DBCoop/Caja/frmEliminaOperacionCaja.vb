Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmEliminaOperacionCaja

    Dim blCaja As New CajaBusiness()
    Dim entOperacion As New coo_OperacionesCaja
    Dim FechaContable As DateTime

    Private Sub frmEliminaOperacionCaja_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _NroComprobante.Focus()
    End Sub

    Private Sub frmEliminaOperacionCaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmEliminaOperacionCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "")
        objCombos.cooTipoOperacionCaja(leTipoOperacion)
    End Sub

    Private Sub _NroComprobante_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _NroComprobante.Validated
        If _NroComprobante.EditValue = "" Then
            teIdOperacion.EditValue = 0
            _monto.EditValue = 0.0
            _observa.EditValue = ""
            Exit Sub
        End If
        entOperacion = blCaja.coo_OperacionesCajaSelectByNumero(leSucursal.EditValue, _NroComprobante.EditValue, leTipoOperacion.EditValue)
        If entOperacion.Numero = "" Then
            teIdOperacion.EditValue = 0
            _monto.EditValue = 0.0
            _observa.EditValue = ""
            MsgBox("No Existe la Operacion de Caja", MsgBoxStyle.Critical)
            Exit Sub
        End If
        teIdOperacion.EditValue = entOperacion.IdOperacion
        leCajero.EditValue = entOperacion.CreadoPor
        deFechaCorte.EditValue = entOperacion.Fecha
        _monto.EditValue = entOperacion.Monto
        _observa.EditValue = entOperacion.Concepto
    End Sub

    Private Sub leTipoOperacion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leTipoOperacion.EditValueChanged
        _NroComprobante.EditValue = ""
        _NroComprobante_Validated(e, New EventArgs)
    End Sub

    Private Sub leSucursal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leSucursal.EditValueChanged
        _NroComprobante.EditValue = ""
        _NroComprobante_Validated(e, New EventArgs)
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        Dim msj As String = ""
        If teIdOperacion.EditValue <= 0 Then
            MsgBox("No Existe la Operación de Caja", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        FechaContable = blCaja.GetFechaContable(gIdSucursal)
        If deFechaCorte.EditValue <> FechaContable Then
            MsgBox("No es posible eliminar la operación, la fecha corresponde a un período ya cerrado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        If MsgBox("¿Está seguro(a) de eliminar la operación de caja?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_OperacionesCajaDeleteByPK(teIdOperacion.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Operación fue eliminada con Exito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar la Operación" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al eliminar el registro")
            End If
        End If
        Close()
    End Sub
    
End Class