<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmCantones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmCantones))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.teIdCanton = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.chkComunidad = New DevExpress.XtraEditors.CheckEdit
        Me.cboMunicipio = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.cboDepartamento = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teCodCanton = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.teIdCanton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkComunidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboMunicipio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCodCanton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.teIdCanton)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.chkComunidad)
        Me.PanelControl1.Controls.Add(Me.cboMunicipio)
        Me.PanelControl1.Controls.Add(Me.LabelControl22)
        Me.PanelControl1.Controls.Add(Me.cboDepartamento)
        Me.PanelControl1.Controls.Add(Me.LabelControl23)
        Me.PanelControl1.Controls.Add(Me.teNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.teCodCanton)
        Me.PanelControl1.Controls.Add(Me.LabelControl59)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(882, 332)
        Me.PanelControl1.TabIndex = 68
        '
        'teIdCanton
        '
        Me.teIdCanton.EnterMoveNextControl = True
        Me.teIdCanton.Location = New System.Drawing.Point(151, 24)
        Me.teIdCanton.Name = "teIdCanton"
        Me.teIdCanton.Size = New System.Drawing.Size(87, 20)
        Me.teIdCanton.TabIndex = 80
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(91, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl1.TabIndex = 81
        Me.LabelControl1.Text = "Id Cantón :"
        '
        'chkComunidad
        '
        Me.chkComunidad.Location = New System.Drawing.Point(149, 164)
        Me.chkComunidad.Name = "chkComunidad"
        Me.chkComunidad.Properties.Caption = "Comunidad Rural"
        Me.chkComunidad.Size = New System.Drawing.Size(131, 19)
        Me.chkComunidad.TabIndex = 79
        '
        'cboMunicipio
        '
        Me.cboMunicipio.Location = New System.Drawing.Point(151, 76)
        Me.cboMunicipio.Name = "cboMunicipio"
        Me.cboMunicipio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboMunicipio.Size = New System.Drawing.Size(358, 20)
        Me.cboMunicipio.TabIndex = 76
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(99, 80)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl22.TabIndex = 78
        Me.LabelControl22.Text = "Municipio:"
        '
        'cboDepartamento
        '
        Me.cboDepartamento.Location = New System.Drawing.Point(151, 50)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDepartamento.Size = New System.Drawing.Size(358, 20)
        Me.cboDepartamento.TabIndex = 75
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(75, 54)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl23.TabIndex = 77
        Me.LabelControl23.Text = "Departamento:"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(151, 128)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(358, 20)
        Me.teNombre.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(52, 132)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl3.TabIndex = 74
        Me.LabelControl3.Text = "Nombre del Cantón:"
        '
        'teCodCanton
        '
        Me.teCodCanton.EnterMoveNextControl = True
        Me.teCodCanton.Location = New System.Drawing.Point(151, 102)
        Me.teCodCanton.Name = "teCodCanton"
        Me.teCodCanton.Size = New System.Drawing.Size(87, 20)
        Me.teCodCanton.TabIndex = 0
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(70, 106)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl59.TabIndex = 73
        Me.LabelControl59.Text = "Codigo Cantón :"
        '
        'adm_frmCantones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmCantones"
        Me.OptionId = "001005"
        Me.Text = "Cantones"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.teIdCanton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkComunidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboMunicipio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDepartamento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCodCanton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCodCanton As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboMunicipio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDepartamento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkComunidad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents teIdCanton As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
