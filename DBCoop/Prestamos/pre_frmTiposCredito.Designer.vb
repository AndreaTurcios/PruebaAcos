<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmTiposCredito
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
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.gc.Size = New System.Drawing.Size(728, 335)
        Me.gc.TabIndex = 3
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcId, Me.gcNombre, Me.GridColumn1, Me.GridColumn2})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Click aquí para ingresar nueva forma de pago. Esc para cancelar"
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcId
        '
        Me.gcId.Caption = "Id. Tipo Prestamo"
        Me.gcId.FieldName = "IdTipoPrestamo"
        Me.gcId.Name = "gcId"
        Me.gcId.Visible = True
        Me.gcId.VisibleIndex = 0
        Me.gcId.Width = 119
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Nombre"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 1
        Me.gcNombre.Width = 417
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Desde Monto"
        Me.GridColumn1.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Desde"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 105
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Hasta Monto"
        Me.GridColumn2.DisplayFormat.FormatString = "{0:n2}"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Hasta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 108
        '
        'pre_frmTiposCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.gc)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmTiposCredito"
        Me.OptionId = "001001"
        Me.Text = "Tipos de Prestamo"
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
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
