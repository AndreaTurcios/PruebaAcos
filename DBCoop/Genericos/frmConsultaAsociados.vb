Imports DBCoopBL
Public Class frmConsultaAsociados
    Dim blAsoc As New AsociadosBLL()

    Private Sub frmConsultaAsociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        teNombre.Focus()
    End Sub
    Private Sub frmConsultaAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        NumAsociado = gv.GetFocusedRowCellValue("Numero")
        IdAsociado = gv.GetFocusedRowCellValue("IdAsociado")
        Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            NumAsociado = gv.GetFocusedRowCellValue("Numero")
            IdAsociado = gv.GetFocusedRowCellValue("IdAsociado")
            Nombre = gv.GetFocusedRowCellValue("Nombres") + " " + gv.GetFocusedRowCellValue("Apellidos")
            Close()
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
    Private _NumAsociado As String
    Public Property NumAsociado() As String
        Get
            Return _NumAsociado
        End Get
        Set(ByVal value As String)
            _NumAsociado = value
        End Set
    End Property
    Private _Nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosAsociadoParaConsulta(teNombre.EditValue, teApellido.EditValue, ceIncluir.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("La información ingresada no generó ningún dato. Pruebe con otra consulta", MsgBoxStyle.Critical)
        End If
        gc.DataSource = dt
        gv.BestFitColumns()
    End Sub
    Private Sub frmConsultaAsociados_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class