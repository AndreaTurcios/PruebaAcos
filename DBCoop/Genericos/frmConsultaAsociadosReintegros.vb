Imports DBCoopBL
Public Class frmConsultaAsociadosReintegros
    Dim blAsoc As New AsociadosBLL()

    Private Sub frmConsultaAsociados_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        teNombre.Focus()
    End Sub
    Private Sub frmConsultaAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        NumAsociado = gv.GetFocusedRowCellValue("Numero")
        IdAsociado = gv.GetFocusedRowCellValue("IdAsociado")
        ValorReintegro = gv.GetFocusedRowCellValue("ValorReintegro")
        FechaPlanilla = gv.GetFocusedRowCellValue("FechaPlanilla")
        IdPlanillaDescuento = gv.GetFocusedRowCellValue("IdPlanilla")
        Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            NumAsociado = gv.GetFocusedRowCellValue("Numero")
            IdAsociado = gv.GetFocusedRowCellValue("IdAsociado")
            Nombre = gv.GetFocusedRowCellValue("Nombres") + " " + gv.GetFocusedRowCellValue("Apellidos")
            ValorReintegro = gv.GetFocusedRowCellValue("ValorReintegro")
            FechaPlanilla = gv.GetFocusedRowCellValue("FechaPlanilla")
            IdPlanillaDescuento = gv.GetFocusedRowCellValue("IdPlanilla")
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
    Private _IdPlanillaDescuento As Integer
    Public Property IdPlanillaDescuento() As Integer
        Get
            Return _IdPlanillaDescuento
        End Get
        Set(ByVal value As Integer)
            _IdPlanillaDescuento = value
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
    Private _ValorReintegro As Decimal
    Public Property ValorReintegro() As Decimal
        Get
            Return _ValorReintegro
        End Get
        Set(ByVal value As Decimal)
            _ValorReintegro = value
        End Set
    End Property
    Private _FechaPlanilla As DateTime
    Public Property FechaPlanilla() As DateTime
        Get
            Return _FechaPlanilla
        End Get
        Set(ByVal value As DateTime)
            _FechaPlanilla = value
        End Set
    End Property
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGenerar.Click
        If teNombre.EditValue = "" And teApellido.EditValue = "" Then
            MsgBox("No ha especificado ningún dato para consultar", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosAsociadoParaConsultaReintegro(teNombre.EditValue, teApellido.EditValue)
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