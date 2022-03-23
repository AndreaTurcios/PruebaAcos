Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class apo_frmEliminaAportacion
    Dim blAporta As New AportacionesBLL()
    Dim blCaja As New TableBusiness()
    Dim blAsoc As New AsociadosBLL()

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click

        If _NumeroComprobante.Text = "" Or teIdMov.EditValue = 0 Then
            MsgBox("No se ha especificado el número de comprobante", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        Dim UltMov As Integer = blAporta.GetUltMovAporta(teNumeroAsociad.EditValue)
        If teIdMov.EditValue < UltMov Then
            MsgBox("El documento a eliminar tiene movimientos posteriores", MsgBoxStyle.Critical, "No es posible eliminar")
            Exit Sub
        End If

        If _FechaMov.EditValue < deFechaUlt.EditValue Then
            MsgBox("El movimiento a eliminar no es el Ultimo para el Asociado", MsgBoxStyle.Critical, "No es posible eliminar")
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de eliminar el registro de aportación?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            objTablas.coo_AportacionesDeleteByPK(teNumeroAsociad.EditValue, teIdMov.EditValue)
            objTablas.coo_LiquidacionAportacionesDeleteByPK(teNumeroAsociad.EditValue, _NumeroComprobante.EditValue)
        Catch ex As Exception
            MsgBox(String.Format("No fue posible eliminar el Movimiento de Aportación{0}{1}", Chr(13), ex.Message()), MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End Try
        MsgBox("El Movimiento ha sido elminado con éxito", MsgBoxStyle.Information)
        _NumeroComprobante.EditValue = ""
        teNumeroAsociad.EditValue = 0
        teIdMov.EditValue = 0
        teNombreAsociado.EditValue = ""
        teTipo.EditValue = ""
        _FechaMov.EditValue = Nothing
        deFechaUlt.EditValue = Nothing
        teMonto.EditValue = 0.0
        teSaldo.EditValue = 0.0
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teNumeroAsociad.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        With dt.Rows(0)
            teNumeroAsociad.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With

        Dim IdMov As Integer = blAporta.GetUltMovAporta(teNumeroAsociad.EditValue)
        Dim entMov As coo_Aportaciones = objTablas.coo_AportacionesSelectByPK(teNumeroAsociad.EditValue, IdMov)

        If IdMov = 0 Then
            teNumeroAsociad.EditValue = 0
            teNombreAsociado.EditValue = ""
            MsgBox("La cuenta no tiene registros que se puedan eliminar", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        With entMov
            _NumeroComprobante.EditValue = .NumeroDoc
            teNumeroAsociad.EditValue = .IdAsociado
            _FechaMov.EditValue = .Fecha
            teMonto.EditValue = .Cargo + .Abono
            teSaldo.EditValue = .Saldo
            teIdMov.EditValue = .IdMov
            If .Cargo > 0 Then
                teTipo.EditValue = "LIQUIDACION O RETIRO"
            Else
                teTipo.EditValue = "INGRESO DE APORTACION"
            End If

            If blAporta.GetUltFechaAporta(teNumeroAsociad.EditValue) Is Nothing Then
                deFechaUlt.EditValue = Today
            Else
                deFechaUlt.EditValue = blAporta.GetUltFechaAporta(teNumeroAsociad.EditValue)
            End If
        End With

    End Sub

End Class
