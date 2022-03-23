Imports CajaBL
Public Class frmConsultaSolicitudFondos
    Dim blPres As New CajaBusiness()


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

    Private _IdSolicitudFondo As Integer
    Public Property IdSolicitudFondo() As Integer
        Get
            Return _IdSolicitudFondo
        End Get
        Set(ByVal value As Integer)
            _IdSolicitudFondo = value
        End Set
    End Property

    Private Sub frmConsultaAsociados_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmConsultaSolicitudFondos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        gc.DataSource = blPres.SolicitudFondosParaConsulta()
        gv.BestFitColumns()
    End Sub
End Class