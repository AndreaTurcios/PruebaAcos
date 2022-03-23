<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmRevertirPlanilla
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.btProceder = New DevExpress.XtraEditors.SimpleButton
        Me.sbMuestra = New DevExpress.XtraEditors.SimpleButton
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaContable = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.ChecTelefonia = New DevExpress.XtraEditors.CheckEdit
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecTelefonia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(94, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Sucursal:"
        Me.LabelControl1.Visible = False
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(140, 32)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(234, 20)
        Me.leSucursal.TabIndex = 5
        Me.leSucursal.Visible = False
        '
        'btProceder
        '
        Me.btProceder.Location = New System.Drawing.Point(140, 155)
        Me.btProceder.Name = "btProceder"
        Me.btProceder.Size = New System.Drawing.Size(75, 23)
        Me.btProceder.TabIndex = 7
        Me.btProceder.Text = "Proceder"
        '
        'sbMuestra
        '
        Me.sbMuestra.Location = New System.Drawing.Point(242, 91)
        Me.sbMuestra.Name = "sbMuestra"
        Me.sbMuestra.Size = New System.Drawing.Size(28, 18)
        Me.sbMuestra.TabIndex = 69
        Me.sbMuestra.Text = "...."
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.Enabled = False
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(140, 115)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 66
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 117)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl7.TabIndex = 68
        Me.LabelControl7.Text = "Fecha Aplicación Planilla:"
        '
        'deFechaContable
        '
        Me.deFechaContable.EditValue = Nothing
        Me.deFechaContable.Enabled = False
        Me.deFechaContable.EnterMoveNextControl = True
        Me.deFechaContable.Location = New System.Drawing.Point(140, 89)
        Me.deFechaContable.Name = "deFechaContable"
        Me.deFechaContable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaContable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaContable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaContable.Size = New System.Drawing.Size(100, 20)
        Me.deFechaContable.TabIndex = 65
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl2.TabIndex = 67
        Me.LabelControl2.Text = "Fecha Contable Planilla:"
        '
        'ChecTelefonia
        '
        Me.ChecTelefonia.Location = New System.Drawing.Point(257, 115)
        Me.ChecTelefonia.Name = "ChecTelefonia"
        Me.ChecTelefonia.Properties.Caption = "Descuento Telefonía"
        Me.ChecTelefonia.Size = New System.Drawing.Size(150, 19)
        Me.ChecTelefonia.TabIndex = 151
        '
        'gc
        '
        Me.gc.Location = New System.Drawing.Point(413, 35)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(381, 156)
        Me.gc.TabIndex = 152
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'adm_frmRevertirPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Controls.Add(Me.gc)
        Me.Controls.Add(Me.ChecTelefonia)
        Me.Controls.Add(Me.sbMuestra)
        Me.Controls.Add(Me.deHasta)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.deFechaContable)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btProceder)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl1)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmRevertirPlanilla"
        Me.OptionId = "001015"
        Me.Text = "Revertir Planilla de Descuentos"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.btProceder, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.deFechaContable, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.deHasta, 0)
        Me.Controls.SetChildIndex(Me.sbMuestra, 0)
        Me.Controls.SetChildIndex(Me.ChecTelefonia, 0)
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecTelefonia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btProceder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbMuestra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaContable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChecTelefonia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView

End Class
