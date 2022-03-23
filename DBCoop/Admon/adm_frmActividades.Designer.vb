<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmActividades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmActividades))
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcIdRubro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.leRubro = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gcId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Left
        Me.gc.Location = New System.Drawing.Point(0, 0)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.leRubro})
        Me.gc.Size = New System.Drawing.Size(786, 332)
        Me.gc.TabIndex = 5
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcIdRubro, Me.gcId, Me.gcNombre})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.NewItemRowText = "Click aquí para ingresar nueva forma de pago. Esc para cancelar"
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcIdRubro
        '
        Me.gcIdRubro.Caption = "Rubro"
        Me.gcIdRubro.ColumnEdit = Me.leRubro
        Me.gcIdRubro.FieldName = "IdRubro"
        Me.gcIdRubro.Name = "gcIdRubro"
        Me.gcIdRubro.Visible = True
        Me.gcIdRubro.VisibleIndex = 0
        Me.gcIdRubro.Width = 133
        '
        'leRubro
        '
        Me.leRubro.AutoHeight = False
        Me.leRubro.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leRubro.Name = "leRubro"
        '
        'gcId
        '
        Me.gcId.Caption = "Id. Actividad"
        Me.gcId.FieldName = "IdActividad"
        Me.gcId.Name = "gcId"
        Me.gcId.Visible = True
        Me.gcId.VisibleIndex = 1
        Me.gcId.Width = 95
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Nombre"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 2
        Me.gcNombre.Width = 308
        '
        'adm_frmActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.gc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmActividades"
        Me.OptionId = "001006"
        Me.Text = "Actividades Económicas de los Asociados"
        Me.TipoFormulario = 2
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leRubro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdRubro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leRubro As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
