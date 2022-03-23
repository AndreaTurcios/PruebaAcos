<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmFechasDescuentos
    Inherits Bravio.gen_frmBase

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
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.gcActivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Left
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.gc.Size = New System.Drawing.Size(882, 335)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn7, Me.gcId, Me.gcActivo, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Click aquí para ingresar nueva forma de pago. Esc para cancelar"
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.gcActivo, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Correlativo"
        Me.GridColumn7.FieldName = "IdComprobante"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        '
        'gcId
        '
        Me.gcId.Caption = "Fecha del Descuento"
        Me.gcId.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.gcId.FieldName = "FechaDescuento"
        Me.gcId.GroupFormat.FormatString = "d"
        Me.gcId.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcId.Name = "gcId"
        Me.gcId.Visible = True
        Me.gcId.VisibleIndex = 1
        Me.gcId.Width = 147
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        Me.RepositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'gcActivo
        '
        Me.gcActivo.Caption = "Activo"
        Me.gcActivo.FieldName = "Activo"
        Me.gcActivo.Name = "gcActivo"
        Me.gcActivo.OptionsColumn.ReadOnly = True
        Me.gcActivo.Visible = True
        Me.gcActivo.VisibleIndex = 2
        Me.gcActivo.Width = 717
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "CreadoPor"
        Me.GridColumn1.FieldName = "CreadoPor"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "FechaHoraCreacion"
        Me.GridColumn2.FieldName = "FechaHoraCreacion"
        Me.GridColumn2.GroupFormat.FormatString = "d"
        Me.GridColumn2.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "ModificadoPor"
        Me.GridColumn3.FieldName = "ModificadoPor"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "FechaHoraModificacion"
        Me.GridColumn4.FieldName = "FechaHoraModificacion"
        Me.GridColumn4.GroupFormat.FormatString = "d"
        Me.GridColumn4.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "CerradoPor"
        Me.GridColumn5.FieldName = "CerradoPor"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "GridColumn6"
        Me.GridColumn6.FieldName = "FechaCerrado"
        Me.GridColumn6.GroupFormat.FormatString = "d"
        Me.GridColumn6.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.Name = "GridColumn6"
        '
        'pre_frmFechasDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.gc)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmFechasDescuentos"
        Me.OptionId = "001008"
        Me.Text = "Fechas de Descuentos en Planilla"
        Me.TipoFormulario = 2
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcActivo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn

End Class
