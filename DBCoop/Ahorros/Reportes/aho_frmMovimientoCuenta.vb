Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmMovimientoCuenta
    Dim blAhorro As New AhorrosBLL()

    Private Sub aho_frmMovimientoCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
    End Sub

    Private Sub aho_frmMovimientoCuenta_Reporte_Click() Handles Me.Reporte
        Dim rpt As New aho_rptMovimientoCuenta
        rpt.DataSource = blAhorro.rptMovimientoCuentaAhorro(teIdCuenta.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub beNumeroCuenta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroCuenta.ButtonClick
        frmConsultaCuentasAhorro.ShowDialog()
        beNumeroCuenta.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        beNumeroCuenta_Validated(e, New EventArgs)
    End Sub


    Private Sub beNumeroCuenta_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNumeroCuenta.Validated
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
        Dim entCuentaCorriente As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entCuentaCorriente.IdAsociado)
        teAsociado.EditValue = String.Format("{0}, {1} {2}", entCuentaCorriente.Numero, entAsociados.Nombres, entAsociados.Apellidos)
    End Sub


    Private Sub aho_frmMovimientoCuenta_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptMovimientoCuentaAhorro(teIdCuenta.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
