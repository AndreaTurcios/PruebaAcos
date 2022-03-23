Public Class frmConsultaDetalle

    Private Sub frmConsultaDetalle_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        gv.Columns.Clear()
    End Sub

    Private Sub ConsultaFactura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            gc.DataSource = ds.Tables(0)
            gv.Columns("FechaHoraCreacion").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
            gv.Columns("FechaHoraCreacion").DisplayFormat.FormatString = "g"
            gv.BestFitColumns()

        Catch ex As Exception

        End Try
    End Sub

    Private _ds As DataSet
    Public Property ds() As DataSet
        Get
            Return _ds
        End Get
        Set(ByVal value As DataSet)
            _ds = value
        End Set
    End Property


    Private _IdCodigo As Integer
    Public Property IdCodigo() As Integer
        Get
            Return _IdCodigo
        End Get
        Set(ByVal value As Integer)
            _IdCodigo = value
        End Set
    End Property
    Private _PrimaryKey As String
    Public Property PrimaryKey() As String
        Get
            Return _PrimaryKey
        End Get
        Set(ByVal value As String)
            _PrimaryKey = value
        End Set
    End Property


    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.DoubleClick
        PrimaryKey = SiEsNulo(PrimaryKey, "")
        If PrimaryKey = "" Then
            IdCodigo = gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns(0).FieldName)
        Else
            IdCodigo = gv.GetRowCellValue(gv.FocusedRowHandle, PrimaryKey)
        End If
        Me.Hide()
    End Sub

End Class