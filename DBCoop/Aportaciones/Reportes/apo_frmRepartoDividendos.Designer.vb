<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apo_frmRepartoDividendos
    Inherits Bravio.gen_frmBaseRpt

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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.sePorcentaje = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.seUtilidad = New DevExpress.XtraEditors.SpinEdit
        Me.sePorcentajeLP = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.sePorcentajeEfectivo = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.seAyuda = New DevExpress.XtraEditors.SpinEdit
        Me.ceIncluir = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.gcLineas = New DevExpress.XtraGrid.GridControl
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPorcenLineas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.teValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ceTodas = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.seDescuento = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.seDescuentoAPartir = New DevExpress.XtraEditors.SpinEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seUtilidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePorcentajeLP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePorcentajeEfectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAyuda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceTodas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDescuentoAPartir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.seDescuentoAPartir)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.seDescuento)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.ceTodas)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.gcLineas)
        Me.GroupControl1.Controls.Add(Me.ceIncluir)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.seAyuda)
        Me.GroupControl1.Controls.Add(Me.sePorcentajeEfectivo)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.sePorcentajeLP)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.seUtilidad)
        Me.GroupControl1.Controls.Add(Me.sePorcentaje)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.SpinEdit1)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(889, 443)
        Me.GroupControl1.TabIndex = 0
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(213, 37)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(411, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(161, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "Sucursal:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(111, 66)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "Ejercicio a Generar:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(213, 64)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n0"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.Mask.EditMask = "n0"
        Me.SpinEdit1.Size = New System.Drawing.Size(87, 20)
        Me.SpinEdit1.TabIndex = 1
        '
        'sePorcentaje
        '
        Me.sePorcentaje.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePorcentaje.Location = New System.Drawing.Point(213, 112)
        Me.sePorcentaje.Name = "sePorcentaje"
        Me.sePorcentaje.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePorcentaje.Properties.Mask.EditMask = "P2"
        Me.sePorcentaje.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sePorcentaje.Size = New System.Drawing.Size(87, 20)
        Me.sePorcentaje.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(80, 115)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl5.TabIndex = 64
        Me.LabelControl5.Text = "Porcentaje de Aportación:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(115, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl3.TabIndex = 66
        Me.LabelControl3.Text = "Utilidad a Repartir:"
        '
        'seUtilidad
        '
        Me.seUtilidad.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seUtilidad.Location = New System.Drawing.Point(213, 90)
        Me.seUtilidad.Name = "seUtilidad"
        Me.seUtilidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seUtilidad.Properties.DisplayFormat.FormatString = "n0"
        Me.seUtilidad.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seUtilidad.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seUtilidad.Properties.Mask.EditMask = "n2"
        Me.seUtilidad.Size = New System.Drawing.Size(87, 20)
        Me.seUtilidad.TabIndex = 2
        '
        'sePorcentajeLP
        '
        Me.sePorcentajeLP.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePorcentajeLP.Location = New System.Drawing.Point(636, 85)
        Me.sePorcentajeLP.Name = "sePorcentajeLP"
        Me.sePorcentajeLP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePorcentajeLP.Properties.Mask.EditMask = "P2"
        Me.sePorcentajeLP.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sePorcentajeLP.Size = New System.Drawing.Size(85, 20)
        Me.sePorcentajeLP.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(523, 88)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl6.TabIndex = 68
        Me.LabelControl6.Text = "Porcentaje de Int. LP:"
        '
        'sePorcentajeEfectivo
        '
        Me.sePorcentajeEfectivo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePorcentajeEfectivo.Location = New System.Drawing.Point(636, 109)
        Me.sePorcentajeEfectivo.Name = "sePorcentajeEfectivo"
        Me.sePorcentajeEfectivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePorcentajeEfectivo.Properties.Mask.EditMask = "P2"
        Me.sePorcentajeEfectivo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sePorcentajeEfectivo.Size = New System.Drawing.Size(85, 20)
        Me.sePorcentajeEfectivo.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(495, 112)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl7.TabIndex = 70
        Me.LabelControl7.Text = "Porcentaje de Int. Efectivo:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(74, 140)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl8.TabIndex = 72
        Me.LabelControl8.Text = "Ayuda Funeraria a Repartir:"
        '
        'seAyuda
        '
        Me.seAyuda.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAyuda.Location = New System.Drawing.Point(213, 137)
        Me.seAyuda.Name = "seAyuda"
        Me.seAyuda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAyuda.Properties.DisplayFormat.FormatString = "n0"
        Me.seAyuda.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seAyuda.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seAyuda.Properties.Mask.EditMask = "n2"
        Me.seAyuda.Size = New System.Drawing.Size(87, 20)
        Me.seAyuda.TabIndex = 71
        '
        'ceIncluir
        '
        Me.ceIncluir.Location = New System.Drawing.Point(306, 137)
        Me.ceIncluir.Name = "ceIncluir"
        Me.ceIncluir.Properties.Caption = "Incluir Asociados que han Hecho Uso de Ayuda Funeraria"
        Me.ceIncluir.Size = New System.Drawing.Size(307, 19)
        Me.ceIncluir.TabIndex = 73
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Location = New System.Drawing.Point(95, 222)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(110, 14)
        Me.LabelControl9.TabIndex = 168
        Me.LabelControl9.Text = "Lineas de Crédito:"
        '
        'gcLineas
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gcLineas.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcLineas.Location = New System.Drawing.Point(213, 212)
        Me.gcLineas.MainView = Me.gvLineas
        Me.gcLineas.Name = "gcLineas"
        Me.gcLineas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.teValor, Me.RepositoryItemTextEdit1})
        Me.gcLineas.Size = New System.Drawing.Size(508, 221)
        Me.gcLineas.TabIndex = 167
        Me.gcLineas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineas, Me.GridView1})
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.gcNombre, Me.gcPorcenLineas, Me.GridColumn1})
        Me.gvLineas.GridControl = Me.gcLineas
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsView.ShowFooter = True
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Id Linea"
        Me.GridColumn15.FieldName = "IdLinea"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        Me.GridColumn15.Width = 54
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Nombre"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.OptionsColumn.AllowEdit = False
        Me.gcNombre.OptionsColumn.AllowFocus = False
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 1
        Me.gcNombre.Width = 378
        '
        'gcPorcenLineas
        '
        Me.gcPorcenLineas.Caption = "Porcentaje %"
        Me.gcPorcenLineas.DisplayFormat.FormatString = "{0:n2}"
        Me.gcPorcenLineas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcPorcenLineas.FieldName = "Porcentaje"
        Me.gcPorcenLineas.Name = "gcPorcenLineas"
        Me.gcPorcenLineas.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Porcentaje", "{0:n2}")})
        Me.gcPorcenLineas.Visible = True
        Me.gcPorcenLineas.VisibleIndex = 2
        Me.gcPorcenLineas.Width = 60
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "TipoLinea"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'teValor
        '
        Me.teValor.AutoHeight = False
        Me.teValor.Name = "teValor"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcLineas
        Me.GridView1.Name = "GridView1"
        '
        'ceTodas
        '
        Me.ceTodas.Location = New System.Drawing.Point(306, 63)
        Me.ceTodas.Name = "ceTodas"
        Me.ceTodas.Properties.Caption = "Incluir Todas las Lineas de Crédito"
        Me.ceTodas.Size = New System.Drawing.Size(307, 19)
        Me.ceTodas.TabIndex = 169
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(103, 178)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl1.TabIndex = 170
        Me.LabelControl1.Text = "Descuento Papeleria:"
        '
        'seDescuento
        '
        Me.seDescuento.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDescuento.Location = New System.Drawing.Point(213, 174)
        Me.seDescuento.Name = "seDescuento"
        Me.seDescuento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seDescuento.Properties.Mask.EditMask = "n"
        Me.seDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seDescuento.Size = New System.Drawing.Size(87, 20)
        Me.seDescuento.TabIndex = 171
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(473, 178)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(156, 13)
        Me.LabelControl10.TabIndex = 172
        Me.LabelControl10.Text = "Descontar papeleria a Partir de :"
        '
        'seDescuentoAPartir
        '
        Me.seDescuentoAPartir.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDescuentoAPartir.Location = New System.Drawing.Point(634, 175)
        Me.seDescuentoAPartir.Name = "seDescuentoAPartir"
        Me.seDescuentoAPartir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seDescuentoAPartir.Properties.Mask.EditMask = "n"
        Me.seDescuentoAPartir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seDescuentoAPartir.Size = New System.Drawing.Size(87, 20)
        Me.seDescuentoAPartir.TabIndex = 173
        '
        'apo_frmRepartoDividendos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(889, 468)
        Me.Name = "apo_frmRepartoDividendos"
        Me.Text = "Reparto de Dividendos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seUtilidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePorcentajeLP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePorcentajeEfectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAyuda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceTodas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDescuentoAPartir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents sePorcentaje As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sePorcentajeEfectivo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sePorcentajeLP As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seUtilidad As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seAyuda As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents ceIncluir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcLineas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gcPorcenLineas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceTodas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents seDescuentoAPartir As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seDescuento As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
