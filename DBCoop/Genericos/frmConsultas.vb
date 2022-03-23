Public Class frmConsultas
    Dim dv As DataView

    Private Sub frmConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gv.Columns.Clear()
        gc.DataSource = New DataView(cnsDataTable)
        ValCodigo = ""
        gv.BestFitColumns()
        gv.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
    End Sub

    Private _cnsDatatable As DataTable
    Public Property cnsDataTable() As DataTable
        Get
            Return _cnsDatatable
        End Get
        Set(ByVal value As DataTable)
            _cnsDatatable = value
        End Set
    End Property

    Private _Descripcion As String
    Public Property Descripcion() As String
        Get
            Return _Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property


    Private _Codigo As String
    Public Property Codigo() As String
        Get
            Return _Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property


    Private _ValCodigo As String
    Public Property ValCodigo() As String
        Get
            Return _ValCodigo
        End Get
        Set(ByVal value As String)
            _ValCodigo = value
        End Set
    End Property

    Private Sub gc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gc.DoubleClick
        ValCodigo = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns(0))
        'Codigo = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns(1))
        Me.Close()
    End Sub


    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValCodigo = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns(0))
            'Codigo = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns(1))
            Me.Close()
        End If
    End Sub


End Class