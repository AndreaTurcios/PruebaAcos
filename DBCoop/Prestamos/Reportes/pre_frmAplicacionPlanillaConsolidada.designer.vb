<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmAplicacionPlanillaConsolidada
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaContable = New DevExpress.XtraEditors.DateEdit
        Me.sbMuestra = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoPlanilla = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leTipoPlanilla)
        Me.GroupControl1.Controls.Add(Me.LabelControl64)
        Me.GroupControl1.Controls.Add(Me.sbMuestra)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.deFechaContable)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Size = New System.Drawing.Size(578, 277)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Fecha Contable Planilla:"
        '
        'deFechaContable
        '
        Me.deFechaContable.EditValue = Nothing
        Me.deFechaContable.Enabled = False
        Me.deFechaContable.EnterMoveNextControl = True
        Me.deFechaContable.Location = New System.Drawing.Point(150, 72)
        Me.deFechaContable.Name = "deFechaContable"
        Me.deFechaContable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaContable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaContable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaContable.Size = New System.Drawing.Size(100, 20)
        Me.deFechaContable.TabIndex = 5
        '
        'sbMuestra
        '
        Me.sbMuestra.Location = New System.Drawing.Point(252, 74)
        Me.sbMuestra.Name = "sbMuestra"
        Me.sbMuestra.Size = New System.Drawing.Size(28, 18)
        Me.sbMuestra.TabIndex = 64
        Me.sbMuestra.Text = "...."
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(28, 100)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl7.TabIndex = 63
        Me.LabelControl7.Text = "Fecha Aplicación Planilla:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.Enabled = False
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(150, 98)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 6
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(30, 44)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl64.TabIndex = 143
        Me.LabelControl64.Text = "Tipo de Planilla a Envíar:"
        Me.LabelControl64.Visible = False
        '
        'leTipoPlanilla
        '
        Me.leTipoPlanilla.EnterMoveNextControl = True
        Me.leTipoPlanilla.Location = New System.Drawing.Point(150, 41)
        Me.leTipoPlanilla.Name = "leTipoPlanilla"
        Me.leTipoPlanilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoPlanilla.Size = New System.Drawing.Size(301, 20)
        Me.leTipoPlanilla.TabIndex = 144
        Me.leTipoPlanilla.Visible = False
        '
        'pre_frmAplicacionPlanillaConsolidada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(578, 302)
        Me.Name = "pre_frmAplicacionPlanillaConsolidada"
        Me.Text = "Listado de Descuentos de Planilla (Consolidado)"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaContable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sbMuestra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoPlanilla As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl

End Class
