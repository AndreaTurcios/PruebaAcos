Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Public Class aho_frmEliminaComprob
    Dim blAhorro As New AhorrosBLL()
    Dim bl As New AdmonBLL()

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
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        Dim entCuenta As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entCuenta.IdAsociado)
        teAsociado.EditValue = String.Format("{0}, {1} {2}", entCuenta.Numero, entAsociados.Nombres, entAsociados.Apellidos)

        Dim UltMov As coo_UltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        Dim entMov As coo_CuentasAhorroMov = objTablas.coo_CuentasAhorroMovSelectByPK(teIdCuenta.EditValue, UltMov.IdMov)

        If entMov.IdCuenta = 0 Then
            MsgBox("La cuenta no tiene registros que se puedan eliminar", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        teTipoAplicacion.EditValue = IIf(entMov.IdTipo = 1, "DEPÓSITO", IIf(entMov.IdTipo = 2, "RETIRO", "CAP. INTERESES"))
        teNumeroComprobante.EditValue = entMov.NumeroDoc
        teIdMov.EditValue = entMov.IdMov
        deFechaMov.EditValue = entMov.Fecha
        deFechaContable.EditValue = entMov.FechaContable
        teValor.EditValue = entMov.Valor
        teSaldo.EditValue = entMov.Saldo
        teCreadoPor.EditValue = entMov.CreadoPor
        deFechaHoraCreacion.EditValue = entMov.FechaHoraCreacion
        cmdEliminar.Enabled = True
    End Sub

    Private Sub cmdEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdEliminar.Click
        If teNumeroComprobante.Text = "" Then
            MsgBox("Numero de documento en blanco", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        Dim Fecha As Date = objFunciones.GetFechaContable(gIdSucursal)
        If deFechaMov.EditValue < Fecha Then
            MsgBox("El deposito corresponde a un período ya cerrado", MsgBoxStyle.Critical, "Imposible continuar")
            Exit Sub
        End If
        Dim UltMov As coo_UltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        Dim entMov As coo_CuentasAhorroMov = objTablas.coo_CuentasAhorroMovSelectByPK(teIdCuenta.EditValue, UltMov.IdMov)
        If UltMov.IdMov <> teIdMov.EditValue Then
            MsgBox("No es Posible elliminar el movimiento existen movimientos Posteriores", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If entMov.IdTipo > 2 Then
            MsgBox("Solamente se pueden eliminar depósitos o retiros", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If MsgBox("Está seguro(a) de eliminar la aplicación?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            objTablas.coo_CuentasAhorroMovDeleteByPK(teIdCuenta.EditValue, teIdMov.EditValue)
            MsgBox("El documento ha sido elminado con éxito", MsgBoxStyle.Information, "Nota")
        Catch ex As Exception

            MsgBox("No fue posible eliminar el documento" + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        beNumeroCuenta.EditValue = ""
        teNumeroComprobante.EditValue = ""
        teIdCuenta.EditValue = 0
        teTipoAplicacion.EditValue = ""
        teIdMov.EditValue = 0
        deFechaMov.EditValue = Nothing
        deFechaHoraCreacion.EditValue = Nothing
        teValor.EditValue = 0.0
        teSaldo.EditValue = 0.0
        cmdEliminar.Enabled = False
        beNumeroCuenta.Focus()
    End Sub

    Private Sub btReImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btReImprimir.Click
        If MsgBox("Desea imprimir el comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If teTipoAplicacion.EditValue <> "RETIRO" Then
                Dim rpt As New aho_rptDepositoAhorro
                Dim sDecimal = String.Format("{0:c}", Format(CDec(teValor.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.DataSource = blAhorro.rptDepositoAhorro(teNumeroComprobante.EditValue, teIdCuenta.EditValue)
                rpt.xrlMensaje.Text = bl.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
                rpt.xrlLugarFecha.Text = bl.ObtieneParametros.Rows(0).Item("Municipio") + ", " + FechaToString(deFechaMov.EditValue, deFechaMov.EditValue)
                rpt.xrlCantidadLetras.Text = Num2Text(Int(teValor.EditValue)) & " " & sDecimal & " DÓLARES"
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                While True
                    rpt.ShowPreviewDialog()
                    If MsgBox("¿Generar otra impresión del documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                        Exit While
                    End If
                End While
            Else
                Dim rpt As New aho_rptRetiroAhorro
                Dim sDecimal = String.Format("{0:c}", Format(CDec(teValor.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

                rpt.DataSource = blAhorro.rptRetiroAhorro(teNumeroComprobante.EditValue, teIdCuenta.EditValue)
                rpt.xrlMensaje.Text = bl.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
                rpt.xrlLugarFecha.Text = bl.ObtieneParametros.Rows(0).Item("Municipio") + ", " + FechaToString(deFechaMov.EditValue, deFechaMov.EditValue)
                rpt.xrlCantidadLetras.Text = Num2Text(Int(teValor.EditValue)) & " " & sDecimal & " DÓLARES"
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                While True
                    rpt.ShowPreviewDialog()
                    If MsgBox("¿Generar otra impresión del documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                        Exit While
                    End If
                End While
            End If
        End If
    End Sub


End Class
