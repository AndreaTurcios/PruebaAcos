Imports DBCoopBL

Public Class frmConsulta
    Dim blFunciones As New FuncionesBLL
    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.DataSource = blFunciones.GetConsulta(sSQL)
    End Sub

    Private _sSQL As String
    Public Property sSQL() As String
        Get
            Return _sSQL
        End Get
        Set(ByVal value As String)
            _sSQL = value
        End Set
    End Property


    Private _Codigo As String
    Public ReadOnly Property Codigo() As String
        Get
            Return _Codigo
        End Get
    End Property

    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.DoubleClick
        _Codigo = gv.GetFocusedRowCellValue(gv.Columns(0))

        Me.Close()
        Me.Dispose()
    End Sub


End Class