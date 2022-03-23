<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreCorteCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreCorteCaja))
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaCorte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(119, 12)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 18
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(72, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Sucursal:"
        '
        'deFechaCorte
        '
        Me.deFechaCorte.EditValue = Nothing
        Me.deFechaCorte.EnterMoveNextControl = True
        Me.deFechaCorte.Location = New System.Drawing.Point(119, 41)
        Me.deFechaCorte.Name = "deFechaCorte"
        Me.deFechaCorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCorte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaCorte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.deFechaCorte.TabIndex = 16
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(36, 44)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Fecha del Corte:"
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(119, 80)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(119, 40)
        Me.sbImprimir.TabIndex = 21
        Me.sbImprimir.Text = "Imprimir"
        '
        'frmPreCorteCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 168)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deFechaCorte)
        Me.Controls.Add(Me.LabelControl7)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPreCorteCaja"
        Me.Text = "Pre-Corte Caja"
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
End Class
