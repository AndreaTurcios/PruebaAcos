<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmFondosCaja
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
        Me.gcId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Left
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(882, 335)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcId, Me.GridColumn5, Me.gcNombre, Me.gcValor, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Click aquí para ingresar nueva forma de pago. Esc para cancelar"
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcId
        '
        Me.gcId.Caption = "Id. Comprobante"
        Me.gcId.FieldName = "IdComprobante"
        Me.gcId.Name = "gcId"
        Me.gcId.Visible = True
        Me.gcId.VisibleIndex = 0
        Me.gcId.Width = 108
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Fecha"
        Me.gcNombre.FieldName = "Fecha"
        Me.gcNombre.GroupFormat.FormatString = "d"
        Me.gcNombre.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 2
        Me.gcNombre.Width = 209
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor del Fondo"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.GroupFormat.FormatString = "n2"
        Me.gcValor.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValor.Name = "gcValor"
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 3
        Me.gcValor.Width = 407
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
        Me.GridColumn5.Caption = "Referencia"
        Me.GridColumn5.FieldName = "Referencia"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 140
        '
        'pre_frmFondosCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.gc)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmFondosCaja"
        Me.OptionId = "001007"
        Me.Text = "Fondos de Caja Prestamos en Efectivo"
        Me.TipoFormulario = 2
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

End Class
