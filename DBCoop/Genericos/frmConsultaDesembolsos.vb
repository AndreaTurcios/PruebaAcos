Imports DBCoopBL
Public Class frmConsultaDesembolsos
    Dim blPres As New PrestamosBLL()

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gc.DoubleClick
        IdSolicitudFondo = gv.GetFocusedRowCellValue("IdSolicitudFondo")
        Close()
    End Sub

    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            IdSolicitudFondo = gv.GetFocusedRowCellValue("IdSolicitudFondo")
            Close()
        End If
    End Sub

    Private Sub frmConsultaAsociados_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub PanelControl1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles PanelControl1.Paint

    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blPres.DesembolsosParaConsulta(teNombre.EditValue, teApellido.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("La información ingresada no generó ningún dato. Pruebe con otra consulta", MsgBoxStyle.Critical)
        End If
        gc.DataSource = dt
        gv.BestFitColumns()
    End Sub

    Private _IdSolicitudFondo As Integer
    Public Property IdSolicitudFondo() As Integer
        Get
            Return _IdSolicitudFondo
        End Get
        Set(ByVal value As Integer)
            _IdSolicitudFondo = value
        End Set
    End Property

End Class