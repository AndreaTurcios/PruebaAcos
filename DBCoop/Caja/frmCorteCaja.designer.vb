<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorteCaja
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCorteCaja))
        Me.deFechaCorte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.gcArqueo = New DevExpress.XtraGrid.GridControl
        Me.gvArqueo = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teFacturas = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.teAnuladas = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teTotal = New DevExpress.XtraEditors.TextEdit
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.gcCheques = New DevExpress.XtraGrid.GridControl
        Me.gvCheques = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcIdCorte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcBanco = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumeroCheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAnombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValorCheque = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumeroCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFacturas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAnuladas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deFechaCorte
        '
        Me.deFechaCorte.EditValue = Nothing
        Me.deFechaCorte.EnterMoveNextControl = True
        Me.deFechaCorte.Location = New System.Drawing.Point(122, 28)
        Me.deFechaCorte.Name = "deFechaCorte"
        Me.deFechaCorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCorte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaCorte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.deFechaCorte.TabIndex = 2
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(40, 31)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Fecha del Corte:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(122, 3)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(76, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Sucursal:"
        '
        'gcArqueo
        '
        Me.gcArqueo.Location = New System.Drawing.Point(122, 71)
        Me.gcArqueo.MainView = Me.gvArqueo
        Me.gcArqueo.Name = "gcArqueo"
        Me.gcArqueo.Size = New System.Drawing.Size(305, 295)
        Me.gcArqueo.TabIndex = 5
        Me.gcArqueo.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArqueo, Me.GridView2})
        '
        'gvArqueo
        '
        Me.gvArqueo.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcValor, Me.gcCantidad, Me.gcTotal, Me.gcNombre})
        Me.gvArqueo.GridControl = Me.gcArqueo
        Me.gvArqueo.Name = "gvArqueo"
        Me.gvArqueo.OptionsView.ShowGroupPanel = False
        '
        'gcValor
        '
        Me.gcValor.Caption = "Denominación"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.OptionsColumn.AllowFocus = False
        Me.gcValor.OptionsColumn.ReadOnly = True
        '
        'gcCantidad
        '
        Me.gcCantidad.Caption = "Cantidad"
        Me.gcCantidad.FieldName = "Cantidad"
        Me.gcCantidad.Name = "gcCantidad"
        Me.gcCantidad.Visible = True
        Me.gcCantidad.VisibleIndex = 1
        '
        'gcTotal
        '
        Me.gcTotal.Caption = "Total"
        Me.gcTotal.FieldName = "Total"
        Me.gcTotal.Name = "gcTotal"
        Me.gcTotal.OptionsColumn.AllowFocus = False
        Me.gcTotal.OptionsColumn.ReadOnly = True
        Me.gcTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcTotal.Visible = True
        Me.gcTotal.VisibleIndex = 2
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Denominacion"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.OptionsColumn.ReadOnly = True
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 0
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.gcArqueo
        Me.GridView2.Name = "GridView2"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Facturas Emitidas:"
        '
        'teFacturas
        '
        Me.teFacturas.EditValue = 0
        Me.teFacturas.EnterMoveNextControl = True
        Me.teFacturas.Location = New System.Drawing.Point(122, 49)
        Me.teFacturas.Name = "teFacturas"
        Me.teFacturas.Properties.Appearance.Options.UseTextOptions = True
        Me.teFacturas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teFacturas.Properties.Mask.EditMask = "n0"
        Me.teFacturas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teFacturas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teFacturas.Size = New System.Drawing.Size(100, 20)
        Me.teFacturas.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(233, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl4.TabIndex = 16
        Me.LabelControl4.Text = "Facturas Anuladas:"
        '
        'teAnuladas
        '
        Me.teAnuladas.EditValue = 0
        Me.teAnuladas.EnterMoveNextControl = True
        Me.teAnuladas.Location = New System.Drawing.Point(328, 49)
        Me.teAnuladas.Name = "teAnuladas"
        Me.teAnuladas.Properties.Appearance.Options.UseTextOptions = True
        Me.teAnuladas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teAnuladas.Properties.Mask.EditMask = "n0"
        Me.teAnuladas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teAnuladas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teAnuladas.Size = New System.Drawing.Size(100, 20)
        Me.teAnuladas.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(298, 371)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl5.TabIndex = 18
        Me.LabelControl5.Text = "Total:"
        '
        'teTotal
        '
        Me.teTotal.EditValue = 0
        Me.teTotal.EnterMoveNextControl = True
        Me.teTotal.Location = New System.Drawing.Point(328, 367)
        Me.teTotal.Name = "teTotal"
        Me.teTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.teTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teTotal.Properties.Mask.EditMask = "n2"
        Me.teTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teTotal.Size = New System.Drawing.Size(100, 20)
        Me.teTotal.TabIndex = 19
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(439, 71)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(83, 29)
        Me.sbGuardar.TabIndex = 6
        Me.sbGuardar.Text = "&Guardar"
        '
        'gcCheques
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gcCheques.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcCheques.Location = New System.Drawing.Point(7, 413)
        Me.gcCheques.MainView = Me.gvCheques
        Me.gcCheques.Name = "gcCheques"
        Me.gcCheques.Size = New System.Drawing.Size(624, 92)
        Me.gcCheques.TabIndex = 21
        Me.gcCheques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCheques})
        '
        'gvCheques
        '
        Me.gvCheques.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcIdCorte, Me.gcBanco, Me.gcNumeroCheque, Me.gcAnombre, Me.gcValorCheque, Me.gcNumeroCuenta})
        Me.gvCheques.GridControl = Me.gcCheques
        Me.gvCheques.Name = "gvCheques"
        Me.gvCheques.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gvCheques.OptionsView.ShowGroupPanel = False
        '
        'gcIdCorte
        '
        Me.gcIdCorte.Caption = "Id Corte"
        Me.gcIdCorte.FieldName = "IdCorte"
        Me.gcIdCorte.Name = "gcIdCorte"
        Me.gcIdCorte.Width = 149
        '
        'gcBanco
        '
        Me.gcBanco.Caption = "Nombre Banco"
        Me.gcBanco.FieldName = "NombreBanco"
        Me.gcBanco.Name = "gcBanco"
        Me.gcBanco.Visible = True
        Me.gcBanco.VisibleIndex = 1
        Me.gcBanco.Width = 144
        '
        'gcNumeroCheque
        '
        Me.gcNumeroCheque.Caption = "Numero Cheque"
        Me.gcNumeroCheque.FieldName = "NumeroCheque"
        Me.gcNumeroCheque.Name = "gcNumeroCheque"
        Me.gcNumeroCheque.Visible = True
        Me.gcNumeroCheque.VisibleIndex = 2
        Me.gcNumeroCheque.Width = 97
        '
        'gcAnombre
        '
        Me.gcAnombre.Caption = "A Nombre De"
        Me.gcAnombre.FieldName = "AnombreDe"
        Me.gcAnombre.Name = "gcAnombre"
        Me.gcAnombre.Visible = True
        Me.gcAnombre.VisibleIndex = 3
        Me.gcAnombre.Width = 162
        '
        'gcValorCheque
        '
        Me.gcValorCheque.Caption = "Valor Cheque"
        Me.gcValorCheque.FieldName = "Valor"
        Me.gcValorCheque.Name = "gcValorCheque"
        Me.gcValorCheque.Visible = True
        Me.gcValorCheque.VisibleIndex = 4
        Me.gcValorCheque.Width = 106
        '
        'gcNumeroCuenta
        '
        Me.gcNumeroCuenta.Caption = "Numero Cuenta"
        Me.gcNumeroCuenta.FieldName = "NumeroCuenta"
        Me.gcNumeroCuenta.Name = "gcNumeroCuenta"
        Me.gcNumeroCuenta.Visible = True
        Me.gcNumeroCuenta.VisibleIndex = 0
        Me.gcNumeroCuenta.Width = 94
        '
        'sbEliminar
        '
        Me.sbEliminar.ImageIndex = 32
        Me.sbEliminar.ImageList = Me.LargeImages
        Me.sbEliminar.Location = New System.Drawing.Point(637, 413)
        Me.sbEliminar.Name = "sbEliminar"
        Me.sbEliminar.Size = New System.Drawing.Size(37, 33)
        Me.sbEliminar.TabIndex = 156
        '
        'LargeImages
        '
        Me.LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImages.ImageStream = CType(resources.GetObject("LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.LargeImages.Images.SetKeyName(0, "Users.png")
        Me.LargeImages.Images.SetKeyName(1, "preferences-contact-list.png")
        Me.LargeImages.Images.SetKeyName(2, "preferences-desktop-theme-2.png")
        Me.LargeImages.Images.SetKeyName(3, "preferences-desktop-iconthemes-2.png")
        Me.LargeImages.Images.SetKeyName(4, "emblem-advertisement-dollar.png")
        Me.LargeImages.Images.SetKeyName(5, "emblem-money.png")
        Me.LargeImages.Images.SetKeyName(6, "emblem-shared.png")
        Me.LargeImages.Images.SetKeyName(7, "gpe-edit.png")
        Me.LargeImages.Images.SetKeyName(8, "contacts.png")
        Me.LargeImages.Images.SetKeyName(9, "DictionaryReader.app.png")
        Me.LargeImages.Images.SetKeyName(10, "disksearch.png")
        Me.LargeImages.Images.SetKeyName(11, "displayconfig.png")
        Me.LargeImages.Images.SetKeyName(12, "gnome-mahjongg.png")
        Me.LargeImages.Images.SetKeyName(13, "document-open-7.png")
        Me.LargeImages.Images.SetKeyName(14, "archive-insert-directory.png")
        Me.LargeImages.Images.SetKeyName(15, "bookmark-new-list.png")
        Me.LargeImages.Images.SetKeyName(16, "bookmarks-organize.png")
        Me.LargeImages.Images.SetKeyName(17, "configure-2.png")
        Me.LargeImages.Images.SetKeyName(18, "configure-3.png")
        Me.LargeImages.Images.SetKeyName(19, "configure.png")
        Me.LargeImages.Images.SetKeyName(20, "contact-new-2.png")
        Me.LargeImages.Images.SetKeyName(21, "contact-new-3.png")
        Me.LargeImages.Images.SetKeyName(22, "debug-step-instruction.png")
        Me.LargeImages.Images.SetKeyName(23, "debug-step-out.png")
        Me.LargeImages.Images.SetKeyName(24, "document-new-3.png")
        Me.LargeImages.Images.SetKeyName(25, "document-new-5.png")
        Me.LargeImages.Images.SetKeyName(26, "document-new-6.png")
        Me.LargeImages.Images.SetKeyName(27, "document-new-7.png")
        Me.LargeImages.Images.SetKeyName(28, "document-open-2.png")
        Me.LargeImages.Images.SetKeyName(29, "document-open-6.png")
        Me.LargeImages.Images.SetKeyName(30, "db_remove.png")
        Me.LargeImages.Images.SetKeyName(31, "db_add.png")
        Me.LargeImages.Images.SetKeyName(32, "dialog-no.png")
        Me.LargeImages.Images.SetKeyName(33, "archive-insert.png")
        Me.LargeImages.Images.SetKeyName(34, "archive-extract.png")
        Me.LargeImages.Images.SetKeyName(35, "view-split-left-right-2.png")
        Me.LargeImages.Images.SetKeyName(36, "Money_32.png")
        Me.LargeImages.Images.SetKeyName(37, "Money_Transportation_32 (1).png")
        Me.LargeImages.Images.SetKeyName(38, "money-32.png")
        Me.LargeImages.Images.SetKeyName(39, "Money-Delete-32.png")
        Me.LargeImages.Images.SetKeyName(40, "money_32 (1).png")
        Me.LargeImages.Images.SetKeyName(41, "coins_delete.png")
        Me.LargeImages.Images.SetKeyName(42, "libreta.png")
        Me.LargeImages.Images.SetKeyName(43, "animals-feather_4.png")
        Me.LargeImages.Images.SetKeyName(44, "emblem-shared.png")
        Me.LargeImages.Images.SetKeyName(45, "gobby.png")
        Me.LargeImages.Images.SetKeyName(46, "printer-6.png")
        Me.LargeImages.Images.SetKeyName(47, "dialog-error-2.png")
        Me.LargeImages.Images.SetKeyName(48, "emblem-unreadable-2.png")
        Me.LargeImages.Images.SetKeyName(49, "archive-remove.png")
        Me.LargeImages.Images.SetKeyName(50, "user-delete-2.png")
        '
        'frmCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 523)
        Me.Controls.Add(Me.sbEliminar)
        Me.Controls.Add(Me.gcCheques)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teTotal)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.teAnuladas)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teFacturas)
        Me.Controls.Add(Me.gcArqueo)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deFechaCorte)
        Me.Controls.Add(Me.LabelControl7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCorteCaja"
        Me.Text = "Corte de Caja"
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFacturas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAnuladas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCheques, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deFechaCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcArqueo As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArqueo As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teFacturas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAnuladas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCheques As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCheques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcIdCorte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcBanco As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumeroCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAnombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValorCheque As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumeroCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LargeImages As DevExpress.Utils.ImageCollection
End Class
