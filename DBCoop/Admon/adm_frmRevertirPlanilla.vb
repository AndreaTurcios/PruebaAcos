Imports DBCoopBL
Public Class adm_frmRevertirPlanilla
    Dim bl As New AdmonBLL()
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        leSucursal.EditValue = gIdSucursal
        leSucursal.Properties.ReadOnly = True
        deFechaContable.EditValue = Today
        deHasta.EditValue = Today
        gc.DataSource = blPrestamo.ConsultaPeriodosTelefonos()
        deFechaContable.Enabled = True
        gc.Visible = False
        deHasta.Enabled = True
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        If ChecTelefonia.Checked = True Then

            Dim msj As String = ""
            msj = bl.adm_RevierteDescuentoTelefonico(deHasta.EditValue)
            If msj = "" Then
                MsgBox("Los Descuentos se Eliminaron con éxito", MsgBoxStyle.Information, "Nota")
                Close()
            Else
                MsgBox(String.Format("Se generó un error al momento de realizar la reversión{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            End If
        Else
            Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
            If dFechaContable > deFechaContable.EditValue Then
                MsgBox("El período ya esta cerrado", MsgBoxStyle.Information, "Nota")
                Exit Sub
            End If

            If blPrestamo.ValidaReversionPlanilla(deFechaContable.EditValue, deHasta.EditValue, 1) > 0 Then
                MsgBox("No es Posible revertir la Planilla, Ya se ingresaron movimientos despues de la Aplicación", MsgBoxStyle.Critical)
                Return
            End If

            If MsgBox(String.Format("Está seguro(a) de continuar con la Reversión?", Chr(13)), MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim msj As String = ""
            msj = bl.adm_ReviertePlanilla(deFechaContable.EditValue, deHasta.EditValue)
            If msj = "Ok" Then
                MsgBox("La reversión se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
                Close()
            Else
                MsgBox(String.Format("Se generó un error al momento de realizar la reversión{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            End If
        End If
        gc.DataSource = blPrestamo.ConsultaPeriodosTelefonos()
    End Sub
    Private Sub sbMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbMuestra.Click
        deFechaContable.EditValue = objConsultas.ConsultaPlanillasAplicadas(frmConsultas)
        deHasta.EditValue = blPrestamo.FechaPlanilla(deFechaContable.EditValue)
    End Sub

    Private Sub ChecTelefonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecTelefonia.CheckedChanged
        If ChecTelefonia.Checked = True Then
            deFechaContable.Enabled = False
            sbMuestra.Enabled = False
            leSucursal.Enabled = False
            gc.Visible = True
            deHasta.Enabled = True
        Else
            deFechaContable.Enabled = True
            deHasta.Enabled = True
            sbMuestra.Enabled = True
            leSucursal.Enabled = True
            gc.Visible = False
        End If

    End Sub
End Class
