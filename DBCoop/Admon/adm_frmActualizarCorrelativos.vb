Imports DBCoopBL
Public Class adm_frmActualizarCorrelativos
    Dim bl As New AdmonBLL(), ds As DataSet
    Private Sub adm_frmActualizarCorrelativos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.adm_Sucursales(leSucursal, "")
        CargaControles(gIdSucursal)
    End Sub

    Private Sub btActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btActualizar.Click
        If MsgBox("¿Está seguro de actualizar éstos correlativos?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If
        bl.ActualizaCorrelativos(teNumAsociado.EditValue, teFactura.EditValue, teDepRet.EditValue, teRec.EditValue, teSolRet.EditValue, teNumVale.EditValue, teResoluciones.EditValue, leSucursal.EditValue)
        MsgBox("Correlativos actualizados", MsgBoxStyle.Information, "Nota")
    End Sub

    Private Sub leSucursal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leSucursal.EditValueChanged
        CargaControles(leSucursal.EditValue)
    End Sub
    Private Sub CargaControles(ByVal IdSucursal As Integer)
        ds = bl.ObtieneCorrelativos(IdSucursal)
        teNumAsociado.EditValue = ds.Tables(0).Rows(0).Item("UltimoValor")
        teFactura.EditValue = ds.Tables(1).Rows(0).Item("CorrelativoPago")
        teDepRet.EditValue = ds.Tables(1).Rows(0).Item("CorrelativoDeposito")
        teRec.EditValue = ds.Tables(1).Rows(0).Item("CorrelativoIngresos")
        teSolRet.EditValue = ds.Tables(2).Rows(0).Item("UltimoValor")
        teNumVale.EditValue = ds.Tables(3).Rows(0).Item("UltimoValor")
        teResoluciones.EditValue = ds.Tables(4).Rows(0).Item("UltimoValor")
    End Sub
End Class