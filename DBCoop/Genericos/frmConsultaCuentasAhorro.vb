Imports CajaBL
Public Class frmConsultaCuentasAhorro
    Dim blAho As New CajaBusiness()

    Private Sub frmConsultaAsociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        teNombre.Focus()
    End Sub
    Private Sub frmConsultaAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        Numero = gv.GetFocusedRowCellValue("Numero")
        IdCuenta = gv.GetFocusedRowCellValue("IdCuenta")
        Me.Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            Numero = gv.GetFocusedRowCellValue("Numero")
            IdCuenta = gv.GetFocusedRowCellValue("IdCuenta")
            Me.Close()
        End If
    End Sub
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

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        Dim dt As DataTable
        dt = blAho.CuentaAhorroParaConsulta(teNombre.EditValue, teApellido.EditValue, Today, chkCuenta.EditValue)
        gc.DataSource = dt
        If dt.Rows.Count = 0 Then
            MsgBox("No Existe Cuenta para Este Asociado, Pruebe con otra Consulta", MsgBoxStyle.Critical)
        End If
        gv.BestFitColumns()
    End Sub
    Private Sub frmConsultaAsociados_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LabelControl3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelControl3.Click

    End Sub
End Class