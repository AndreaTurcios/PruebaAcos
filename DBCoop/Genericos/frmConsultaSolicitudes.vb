Imports DBCoopBL
Public Class frmConsultaSolicitudes
    Dim blPres As New PrestamosBLL()
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blPres.ConsultaSolicitudesByLike(teNombre.EditValue, teApellido.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("La información ingresada no generó ningún dato. Pruebe con otra consulta", MsgBoxStyle.Critical)
        End If
        gc.DataSource = dt
        gv.BestFitColumns()
    End Sub
    Private Sub frmConsultaSolicitudes_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gc.DoubleClick
        NumeroSol = gv.GetFocusedRowCellValue("Numero")
        IdSolicitud = gv.GetFocusedRowCellValue("IdSolicitud")
        Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            NumeroSol = gv.GetFocusedRowCellValue("Numero")
            IdSolicitud = gv.GetFocusedRowCellValue("Idsolicitud")
            Close()
        End If
    End Sub
    Private _IdSolicitud As Integer
    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property
    Private _NumeroSol As String
    Public Property NumeroSol() As String
        Get
            Return _NumeroSol
        End Get
        Set(ByVal value As String)
            _NumeroSol = value
        End Set
    End Property



End Class