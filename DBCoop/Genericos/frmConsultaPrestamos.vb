Imports DBCoopBL
Public Class frmConsultaPrestamos
    Dim blPres As New PrestamosBLL

    Private Sub frmConsultaPrestamos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        teNombre.Focus()
    End Sub
    Private Sub frmConsultaPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        NumPrestamo = gv.GetFocusedRowCellValue("Numero")
        IdPrestamo = gv.GetFocusedRowCellValue("IdPrestamo")
        Me.Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            NumPrestamo = gv.GetFocusedRowCellValue("Numero")
            IdPrestamo = gv.GetFocusedRowCellValue("IdPrestamo")
            Me.Close()
        End If
    End Sub
    Private _NumPrestamo As String
    Public Property NumPrestamo() As String
        Get
            Return _NumPrestamo
        End Get
        Set(ByVal value As String)
            _NumPrestamo = value
        End Set
    End Property
    Private _IdPrestamo As Integer
    Public Property IdPrestamo() As Integer
        Get
            Return _IdPrestamo
        End Get
        Set(ByVal value As Integer)
            _IdPrestamo = value
        End Set
    End Property

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim dt As DataTable
        dt = blPres.coo_PrestamoParaConsulta(teNombre.EditValue, teApellido.EditValue, Today, ceIncluir.EditValue)
        gc.DataSource = dt
        If dt.Rows.Count = 0 Then
            MsgBox("No Existe Prestamo para Este Asociado, Pruebe con otra Consulta", MsgBoxStyle.Critical)
        End If
        gv.BestFitColumns()
    End Sub
    Private Sub frmConsultaPrestamos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class