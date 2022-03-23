Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL

Public Class frmEliminaOtrosEgresos
    Dim blCaja As New CajaBusiness()
    Dim entSucursal As New adm_Sucursales
    Dim entTipoMovimiento As coo_TiposMovimientoCaja

    Private Sub frmEliminaOtrosEgresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmEliminaOtrosEgresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
    End Sub

    Private Sub CargaCombos()
        With objCombos
            .cooPtmoFmaPago(_FormaPago)
            .coo_AgentesRemesa(_Agente)
            .coo_CuentasGastos(leGasto, -1)
        End With
    End Sub

    Private Sub sbObtener_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbObtener.Click

        Dim entOtrosEgresos As coo_OtrosEgresos
        Dim entAsociado As coo_Asociados
        Dim IdMov As Integer = blCaja.IdMovComprobanteEgreso(_NroComprobante.EditValue)
        entOtrosEgresos = objTablas.coo_OtrosEgresosSelectByPK(IdMov)
        entAsociado = objTablas.coo_AsociadosSelectByPK(entOtrosEgresos.IdAsociado)
        entSucursal = objTablas.adm_SucursalesSelectByPK(entOtrosEgresos.IdSucursal)
        If IdMov > 0 Then
            teIdMov.EditValue = entOtrosEgresos.IdMov
            _FormaPago.EditValue = entOtrosEgresos.IdFormaPago
            _Agente.EditValue = entOtrosEgresos.IdAgenteRemesa
            entTipoMovimiento = objTablas.coo_TiposMovimientoCajaSelectByPK(entOtrosEgresos.IdTipoMovimiento)
            _TipoMovimiento.EditValue = entTipoMovimiento.Nombre
            teSucursal.EditValue = entSucursal.Nombre
            teIdAsociado.EditValue = entOtrosEgresos.IdAsociado
            leGasto.EditValue = entOtrosEgresos.IdCuentaGasto
            If entAsociado.Numero <> "" Then
                _IdAsociado.EditValue = entAsociado.Numero
            Else
                _IdAsociado.EditValue = ""
            End If
            _Nombre.EditValue = entOtrosEgresos.Nombre
            _Remitente.EditValue = entOtrosEgresos.RemitenteRemesa
            _Direccion.EditValue = entAsociado.Direccion
            _dui.EditValue = entAsociado.NumeroDocumento
            _Concepto.EditValue = entOtrosEgresos.Concepto
            _Fecha.EditValue = entOtrosEgresos.Fecha
            _Monto.EditValue = entOtrosEgresos.Valor
            _Iva.EditValue = entOtrosEgresos.Iva
            _Renta.EditValue = entOtrosEgresos.Isr
        Else
            MsgBox("El comprobante no existe", MsgBoxStyle.Critical, "Nota")
            Close()
        End If
    End Sub

    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEliminar.Click
        Dim msj As String = ""
        If _Fecha.EditValue <> blCaja.GetFechaContable(gIdSucursal) Then
            MsgBox("No puede eliminar el documento. La fecha corresponde a un período ya cerrado", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If teIdMov.EditValue <= 0 Then
            MsgBox("Debe seleccionar un comprobante de egreso", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de eliminar el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_OtrosEgresosDeleteByPK(teIdMov.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El documento fue eliminado con Exito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible eliminar el documento{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al eliminar el registro")
            End If
        End If
        Close()
    End Sub

    Private Sub sbReImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbReImprimir.Click

        Dim rpt As New rptPosteo
        rpt.xrlComprobante.Text = _NroComprobante.EditValue
        rpt.xrlCuenta.Text = _IdAsociado.EditValue
        rpt.xrlFecha.Text = _Fecha.EditValue
        rpt.xrlValor.Text = (_Monto.EditValue + _Iva.EditValue).ToString()
        rpt.xrlCajero.Text = objMenu.User
        rpt.PrinterName = gsImpresorDefault
        While True
            rpt.PrintDialog()
            If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Exit While
            End If
        End While
    End Sub
End Class