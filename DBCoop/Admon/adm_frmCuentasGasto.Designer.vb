<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmCuentasGasto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmCuentasGasto))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cboRubro = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teCta01 = New DevExpress.XtraEditors.TextEdit
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.teCta01)
        Me.PanelControl1.Controls.Add(Me.beCta01)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.teIdCuenta)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.cboRubro)
        Me.PanelControl1.Controls.Add(Me.LabelControl23)
        Me.PanelControl1.Controls.Add(Me.teNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(842, 166)
        Me.PanelControl1.TabIndex = 68
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(151, 24)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Size = New System.Drawing.Size(87, 20)
        Me.teIdCuenta.TabIndex = 80
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(91, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 81
        Me.LabelControl1.Text = "Id Cuenta :"
        '
        'cboRubro
        '
        Me.cboRubro.Location = New System.Drawing.Point(151, 50)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboRubro.Size = New System.Drawing.Size(358, 20)
        Me.cboRubro.TabIndex = 75
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(113, 53)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl23.TabIndex = 77
        Me.LabelControl23.Text = "Rubro:"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(151, 75)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(358, 20)
        Me.teNombre.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(105, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 74
        Me.LabelControl3.Text = "Nombre:"
        '
        'teCta01
        '
        Me.teCta01.Enabled = False
        Me.teCta01.Location = New System.Drawing.Point(317, 101)
        Me.teCta01.Name = "teCta01"
        Me.teCta01.Size = New System.Drawing.Size(495, 20)
        Me.teCta01.TabIndex = 83
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(151, 101)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(160, 20)
        Me.beCta01.TabIndex = 82
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(63, 105)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl27.TabIndex = 84
        Me.LabelControl27.Text = "Cuenta Contable:"
        '
        'adm_frmCuentasGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(842, 191)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmCuentasGasto"
        Me.OptionId = "001005"
        Me.Text = "Cuentas Gasto"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboRubro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboRubro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCta01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl

End Class
