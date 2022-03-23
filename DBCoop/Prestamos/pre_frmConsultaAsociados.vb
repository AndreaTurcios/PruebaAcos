Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmConsultaAsociados
    Dim blPresta As New DBCoopBL.PrestamosBLL()
    Dim blAporta As New AportacionesBLL()
    Dim blAhorro As New AhorrosBLL()
    Dim blAsoc As New AsociadosBLL()

    Private Sub pre_frmConsultaAsociados_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Sub sbDatos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        Dim rpt As New pre_rptDatosAsociado

        rpt.DataSource = blPresta.rptDatosAsociado(IdAsociado, Today)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub sbAportacion_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        Dim rpt As New apo_rptEstadoCuentaAportacion

        rpt.DataSource = blAporta.rptEstadoCuentaAportacion(IdAsociado, Today)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub sbAhorros_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton3.Click
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        Dim rpt As New aho_rptListadoCuentasGeneral

        rpt.DataSource = blAhorro.rptListadoCuentaAhorroAsociado(Today, IdAsociado)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "AL " & FechaToString(Today, Today)
        rpt.xrlSucursal.Text = "-- TODAS LAS SUCURSALES --"
        rpt.ShowPreviewDialog()
    End Sub
    Private Sub sbPrestamo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        Dim rpt As New pre_rptHistorialPrestamos

        rpt.DataSource = blPresta.rptHistorialPrestamo(IdAsociado, Today, ceIncluirCancelados.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosAsociadoParaConsulta(teNombre.EditValue, teApellido.EditValue, ceincluir.editvalue)
        gc.DataSource = dt
        If dt.Rows.Count = 0 Then
            MsgBox("La información ingresada no generaró ningún dato. Pruebe con otra Consulta", MsgBoxStyle.Critical)
        End If
        gv.BestFitColumns()
    End Sub

    Private Sub sbVerDocumentos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerDocumentos.Click
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        pre_frmVerDocumentosAsociado.IdAsociado = IdAsociado
        pre_frmVerDocumentosAsociado.ShowDialog()
    End Sub
End Class
