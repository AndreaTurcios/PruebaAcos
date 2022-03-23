Imports CajaBL
Public Class inv_frmConsultaProductos
    Dim blInventa As New CajaBusiness()
    Dim Prod As DataTable
    Private Sub inv_frmConsultaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gvProd.Columns.Clear()
        gcProductos.DataSource = New DataView(cnsDataTable)
        IdProducto = ""
        gvProd.BestFitColumns()
        gvProd.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
        objCombos.inv_Precios(rileIdPrecio)
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
    Private _IdProducto As String = ""
    Public Property IdProducto() As String
        Get
            Return _IdProducto
        End Get
        Set(ByVal value As String)
            _IdProducto = value
        End Set
    End Property

    Private Sub gvProd_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvProd.FocusedRowChanged
        IdProducto = gvProd.GetRowCellValue(gvProd.FocusedRowHandle, "IdProducto")
        Prod = blInventa.inv_GeneralesProducto(IdProducto)
        If Prod.Rows.Count = 0 Then
            Exit Sub
        End If
        gcPr.DataSource = blInventa.inv_ObtienePrecios(IdProducto)

        teGrupo.EditValue = Prod.Rows(0).Item("Grupo")
        teSubGrupo.EditValue = Prod.Rows(0).Item("SubGrupo")
        teUnidad.EditValue = Prod.Rows(0).Item("UnidadMedida")
        teMarca.EditValue = Prod.Rows(0).Item("Marca")
        teProveedor.EditValue = Prod.Rows(0).Item("Proveedor")
        teColor.EditValue = Prod.Rows(0).Item("Color")
        teTalla.EditValue = Prod.Rows(0).Item("Talla")
        teEstilo.EditValue = Prod.Rows(0).Item("Estilo")
        teUnidadesPre.EditValue = Prod.Rows(0).Item("UnidadesPresentacion")
        meInfo.EditValue = Prod.Rows(0).Item("InformacionAdicional")
        Dim ArchivoImagen As String = Prod.Rows(0).Item("ArchivoImagen")
        If Not FileIO.FileSystem.FileExists(ArchivoImagen) Or ArchivoImagen = "" Then
            peFoto.Image = Nothing
        Else
            Dim bm As New Bitmap(ArchivoImagen)
            peFoto.Image = bm
        End If
    End Sub

    Private Sub gvProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            IdProducto = gvProd.GetRowCellValue(gvProd.FocusedRowHandle, "IdProducto")
            Me.Close()
        End If
    End Sub

    Private Sub gcProductos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gcProductos.DoubleClick
        IdProducto = gvProd.GetRowCellValue(gvProd.FocusedRowHandle, "IdProducto")

        Me.Close()
    End Sub
End Class