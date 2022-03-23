<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmCuadroMora
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
        Me.seProvision = New DevExpress.XtraEditors.SpinEdit
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.lcTecnico = New DevExpress.XtraEditors.LabelControl
        Me.rgTipo = New DevExpress.XtraEditors.RadioGroup
        Me.lcSucursal = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.seProvision.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.seProvision)
        Me.GroupControl1.Controls.Add(Me.rgTipo)
        Me.GroupControl1.Controls.Add(Me.leTecnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.lcSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.lcTecnico)
        Me.GroupControl1.Size = New System.Drawing.Size(653, 190)
        '
        'seProvision
        '
        Me.seProvision.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seProvision.EnterMoveNextControl = True
        Me.seProvision.Location = New System.Drawing.Point(135, 136)
        Me.seProvision.Name = "seProvision"
        Me.seProvision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seProvision.Properties.Mask.EditMask = "n2"
        Me.seProvision.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seProvision.Size = New System.Drawing.Size(84, 20)
        Me.seProvision.TabIndex = 3
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(135, 70)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Size = New System.Drawing.Size(285, 20)
        Me.leTecnico.TabIndex = 1
        Me.leTecnico.Visible = False
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(135, 70)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(285, 20)
        Me.leSucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(85, 139)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Provisión:"
        '
        'lcTecnico
        '
        Me.lcTecnico.Location = New System.Drawing.Point(92, 73)
        Me.lcTecnico.Name = "lcTecnico"
        Me.lcTecnico.Size = New System.Drawing.Size(40, 13)
        Me.lcTecnico.TabIndex = 6
        Me.lcTecnico.Text = "Técnico:"
        Me.lcTecnico.Visible = False
        '
        'rgTipo
        '
        Me.rgTipo.EditValue = 1
        Me.rgTipo.EnterMoveNextControl = True
        Me.rgTipo.Location = New System.Drawing.Point(135, 37)
        Me.rgTipo.Name = "rgTipo"
        Me.rgTipo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Sucursal"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Técnico")})
        Me.rgTipo.Size = New System.Drawing.Size(189, 25)
        Me.rgTipo.TabIndex = 0
        '
        'lcSucursal
        '
        Me.lcSucursal.Location = New System.Drawing.Point(88, 73)
        Me.lcSucursal.Name = "lcSucursal"
        Me.lcSucursal.Size = New System.Drawing.Size(44, 13)
        Me.lcSucursal.TabIndex = 8
        Me.lcSucursal.Text = "Sucursal:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(70, 43)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl1.TabIndex = 9
        Me.LabelControl1.Text = "Generar por:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(99, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Fecha:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = New Date(2012, 1, 10, 9, 53, 57, 622)
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(135, 99)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 2
        '
        'pre_frmCuadroMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 215)
        Me.Name = "pre_frmCuadroMora"
        Me.Text = "Cuadro de Mora"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.seProvision.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents seProvision As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents rgTipo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcSucursal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcTecnico As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
