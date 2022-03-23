Imports DBCoopBL
Public Class frmConsultaSolicitudesAprobadas
    Dim blPres As New PrestamosBLL()
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blPres.ConsultaSolicitudesAprobadas(teNombre.EditValue, teApellido.EditValue, SoloPendientes)
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
        NoSolicitud = gv.GetFocusedRowCellValue("Numero")
        IdSolicitud = gv.GetFocusedRowCellValue("IdSolicitud")
        Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            NoSolicitud = gv.GetFocusedRowCellValue("Numero")
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
    Private _NoSolicitud As String
    Public Property NoSolicitud() As String
        Get
            Return _NoSolicitud
        End Get
        Set(ByVal value As String)
            _NoSolicitud = value
        End Set
    End Property
    Private _SoloPendientes As Integer
    Public Property SoloPendientes() As Boolean
        Get
            Return _SoloPendientes
        End Get
        Set(ByVal value As Boolean)
            _SoloPendientes = value
        End Set
    End Property
End Class