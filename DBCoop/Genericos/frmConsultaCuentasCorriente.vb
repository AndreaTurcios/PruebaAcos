Imports CajaBL
Public Class frmConsultaCuentasCorriente
    Dim blAho As New CajaBusiness()


    Private Sub frmConsultaAsociados_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        gc.DataSource = blAho.ConsultaCuentaCorriente(IdAsociado)
        gv.BestFitColumns()
    End Sub

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gc.DoubleClick
        IdCuenta = gv.GetFocusedRowCellValue("IdCuenta")
        Numero = gv.GetFocusedRowCellValue("Numero")
        Me.Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            IdCuenta = gv.GetFocusedRowCellValue("IdCuenta")
            Numero = gv.GetFocusedRowCellValue("Numero")
            Me.Close()
        End If
    End Sub
    Private _IdAsociado As Integer
    Public Property IdAsociado() As Integer
        Get
            Return _IdAsociado
        End Get
        Set(ByVal value As Integer)
            _IdAsociado = value
        End Set
    End Property

    Private _Numero As String
    Public Property Numero() As String
        Get
            Return _Numero
        End Get
        Set(ByVal value As String)
            _Numero = value
        End Set
    End Property


    Private _IdCuenta As Integer
    Public Property IdCuenta() As Integer
        Get
            Return _IdCuenta
        End Get
        Set(ByVal value As Integer)
            _IdCuenta = value
        End Set
    End Property


    Private Sub frmConsultaAsociados_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class