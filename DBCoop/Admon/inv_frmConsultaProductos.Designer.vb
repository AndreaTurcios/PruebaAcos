<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inv_frmConsultaProductos
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inv_frmConsultaProductos))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teGrupo = New DevExpress.XtraEditors.TextEdit
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teSubGrupo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teUnidad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.teMarca = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teUnidadesPre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.teTalla = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teColor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.teEstilo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.teProveedor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.meInfo = New DevExpress.XtraEditors.MemoEdit
        Me.gcProductos = New DevExpress.XtraGrid.GridControl
        Me.gvProd = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPr = New DevExpress.XtraGrid.GridControl
        Me.gvPr = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcIdPrecio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rileIdPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcEx = New DevExpress.XtraGrid.GridControl
        Me.gvEx = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.teGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSubGrupo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUnidadesPre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTalla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teEstilo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meInfo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rileIdPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcEx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvEx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(105, 294)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Grupo:"
        '
        'teGrupo
        '
        Me.teGrupo.Location = New System.Drawing.Point(140, 290)
        Me.teGrupo.Name = "teGrupo"
        Me.teGrupo.Properties.ReadOnly = True
        Me.teGrupo.Size = New System.Drawing.Size(270, 20)
        Me.teGrupo.TabIndex = 1
        '
        'peFoto
        '
        Me.peFoto.Location = New System.Drawing.Point(594, 290)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFoto.Size = New System.Drawing.Size(300, 300)
        ToolTipTitleItem1.Text = "Imagen del producto"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.peFoto.SuperTip = SuperToolTip1
        Me.peFoto.TabIndex = 12
        Me.peFoto.ToolTipTitle = "Doble clic para cambiar o cargar imagen"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(83, 314)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Sub-Grupo:"
        '
        'teSubGrupo
        '
        Me.teSubGrupo.Location = New System.Drawing.Point(140, 311)
        Me.teSubGrupo.Name = "teSubGrupo"
        Me.teSubGrupo.Properties.ReadOnly = True
        Me.teSubGrupo.Size = New System.Drawing.Size(270, 20)
        Me.teSubGrupo.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(49, 336)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Unidad de Medida:"
        '
        'teUnidad
        '
        Me.teUnidad.Location = New System.Drawing.Point(140, 332)
        Me.teUnidad.Name = "teUnidad"
        Me.teUnidad.Properties.ReadOnly = True
        Me.teUnidad.Size = New System.Drawing.Size(270, 20)
        Me.teUnidad.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(105, 356)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = "Marca:"
        '
        'teMarca
        '
        Me.teMarca.Location = New System.Drawing.Point(140, 353)
        Me.teMarca.Name = "teMarca"
        Me.teMarca.Properties.ReadOnly = True
        Me.teMarca.Size = New System.Drawing.Size(270, 20)
        Me.teMarca.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(84, 461)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Proveedor:"
        '
        'teUnidadesPre
        '
        Me.teUnidadesPre.Location = New System.Drawing.Point(140, 437)
        Me.teUnidadesPre.Name = "teUnidadesPre"
        Me.teUnidadesPre.Properties.ReadOnly = True
        Me.teUnidadesPre.Size = New System.Drawing.Size(270, 20)
        Me.teUnidadesPre.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(112, 378)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Talla:"
        '
        'teTalla
        '
        Me.teTalla.Location = New System.Drawing.Point(140, 374)
        Me.teTalla.Name = "teTalla"
        Me.teTalla.Properties.ReadOnly = True
        Me.teTalla.Size = New System.Drawing.Size(270, 20)
        Me.teTalla.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(109, 419)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl7.TabIndex = 1
        Me.LabelControl7.Text = "Color:"
        '
        'teColor
        '
        Me.teColor.Location = New System.Drawing.Point(140, 416)
        Me.teColor.Name = "teColor"
        Me.teColor.Properties.ReadOnly = True
        Me.teColor.Size = New System.Drawing.Size(270, 20)
        Me.teColor.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(109, 399)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl8.TabIndex = 1
        Me.LabelControl8.Text = "Estilo:"
        '
        'teEstilo
        '
        Me.teEstilo.Location = New System.Drawing.Point(140, 395)
        Me.teEstilo.Name = "teEstilo"
        Me.teEstilo.Properties.ReadOnly = True
        Me.teEstilo.Size = New System.Drawing.Size(270, 20)
        Me.teEstilo.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(6, 440)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl9.TabIndex = 1
        Me.LabelControl9.Text = "Unidades por Presentación:"
        '
        'teProveedor
        '
        Me.teProveedor.Location = New System.Drawing.Point(140, 458)
        Me.teProveedor.Name = "teProveedor"
        Me.teProveedor.Properties.ReadOnly = True
        Me.teProveedor.Size = New System.Drawing.Size(270, 20)
        Me.teProveedor.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(31, 483)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl10.TabIndex = 1
        Me.LabelControl10.Text = "Información Adicional:"
        '
        'meInfo
        '
        Me.meInfo.Location = New System.Drawing.Point(140, 479)
        Me.meInfo.Name = "meInfo"
        Me.meInfo.Properties.ReadOnly = True
        Me.meInfo.Size = New System.Drawing.Size(270, 69)
        Me.meInfo.TabIndex = 10
        '
        'gcProductos
        '
        Me.gcProductos.Location = New System.Drawing.Point(2, 2)
        Me.gcProductos.MainView = Me.gvProd
        Me.gcProductos.Name = "gcProductos"
        Me.gcProductos.Size = New System.Drawing.Size(591, 286)
        Me.gcProductos.TabIndex = 0
        Me.gcProductos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProd})
        '
        'gvProd
        '
        Me.gvProd.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.gvProd.GridControl = Me.gcProductos
        Me.gvProd.Name = "gvProd"
        Me.gvProd.OptionsBehavior.Editable = False
        Me.gvProd.OptionsView.ShowAutoFilterRow = True
        Me.gvProd.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cód.Producto"
        Me.GridColumn1.FieldName = "IdProducto"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 184
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nombre"
        Me.GridColumn2.FieldName = "Nombre"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 377
        '
        'gcPr
        '
        Me.gcPr.Location = New System.Drawing.Point(594, 2)
        Me.gcPr.MainView = Me.gvPr
        Me.gcPr.Name = "gcPr"
        Me.gcPr.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rileIdPrecio})
        Me.gcPr.Size = New System.Drawing.Size(300, 140)
        Me.gcPr.TabIndex = 11
        Me.gcPr.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPr})
        '
        'gvPr
        '
        Me.gvPr.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcIdPrecio, Me.gcValor})
        Me.gvPr.GridControl = Me.gcPr
        Me.gvPr.Name = "gvPr"
        Me.gvPr.OptionsBehavior.Editable = False
        Me.gvPr.OptionsView.ShowGroupPanel = False
        '
        'gcIdPrecio
        '
        Me.gcIdPrecio.Caption = "Precio"
        Me.gcIdPrecio.ColumnEdit = Me.rileIdPrecio
        Me.gcIdPrecio.FieldName = "IdPrecio"
        Me.gcIdPrecio.Name = "gcIdPrecio"
        Me.gcIdPrecio.OptionsColumn.AllowEdit = False
        Me.gcIdPrecio.Visible = True
        Me.gcIdPrecio.VisibleIndex = 0
        Me.gcIdPrecio.Width = 167
        '
        'rileIdPrecio
        '
        Me.rileIdPrecio.AutoHeight = False
        Me.rileIdPrecio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rileIdPrecio.Name = "rileIdPrecio"
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.DisplayFormat.FormatString = "###,##0.0000"
        Me.gcValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValor.FieldName = "Precio"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 1
        Me.gcValor.Width = 112
        '
        'gcEx
        '
        Me.gcEx.Location = New System.Drawing.Point(594, 148)
        Me.gcEx.MainView = Me.gvEx
        Me.gcEx.Name = "gcEx"
        Me.gcEx.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.gcEx.Size = New System.Drawing.Size(300, 140)
        Me.gcEx.TabIndex = 13
        Me.gcEx.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvEx})
        '
        'gvEx
        '
        Me.gvEx.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.gvEx.GridControl = Me.gcEx
        Me.gvEx.Name = "gvEx"
        Me.gvEx.OptionsBehavior.Editable = False
        Me.gvEx.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Bodega"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn3.FieldName = "IdPrecio"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 167
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Saldo"
        Me.GridColumn4.DisplayFormat.FormatString = "###,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Precio"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 112
        '
        'inv_frmConsultaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 592)
        Me.Controls.Add(Me.gcEx)
        Me.Controls.Add(Me.gcPr)
        Me.Controls.Add(Me.gcProductos)
        Me.Controls.Add(Me.meInfo)
        Me.Controls.Add(Me.peFoto)
        Me.Controls.Add(Me.teUnidad)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teUnidadesPre)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teColor)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.teProveedor)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.teEstilo)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teTalla)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teMarca)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.teSubGrupo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teGrupo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "inv_frmConsultaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta de productos"
        CType(Me.teGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSubGrupo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUnidadesPre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTalla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teEstilo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meInfo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rileIdPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcEx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvEx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teGrupo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSubGrupo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teUnidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teUnidadesPre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTalla As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teColor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teEstilo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meInfo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gcProductos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvProd As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPr As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPr As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcIdPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rileIdPrecio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcEx As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvEx As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
