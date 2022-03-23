<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmDeduccionesPrestamo
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.teValor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.cboTipoCalculo = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.chkAplicaIva = New DevExpress.XtraEditors.CheckEdit
        Me.teCta01 = New DevExpress.XtraEditors.TextEdit
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teIdDeduccion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboTipoCalculo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAplicaIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdDeduccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.teValor)
        Me.PanelControl1.Controls.Add(Me.LabelControl26)
        Me.PanelControl1.Controls.Add(Me.cboTipoCalculo)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.chkAplicaIva)
        Me.PanelControl1.Controls.Add(Me.teCta01)
        Me.PanelControl1.Controls.Add(Me.beCta01)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.teNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.teIdDeduccion)
        Me.PanelControl1.Controls.Add(Me.LabelControl59)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(736, 216)
        Me.PanelControl1.TabIndex = 3
        '
        'teValor
        '
        Me.teValor.EditValue = 0
        Me.teValor.EnterMoveNextControl = True
        Me.teValor.Location = New System.Drawing.Point(144, 149)
        Me.teValor.Name = "teValor"
        Me.teValor.Properties.Appearance.Options.UseTextOptions = True
        Me.teValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValor.Properties.Mask.EditMask = "n2"
        Me.teValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValor.Size = New System.Drawing.Size(83, 20)
        Me.teValor.TabIndex = 5
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(109, 152)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl26.TabIndex = 143
        Me.LabelControl26.Text = "Valor:"
        '
        'cboTipoCalculo
        '
        Me.cboTipoCalculo.EnterMoveNextControl = True
        Me.cboTipoCalculo.Location = New System.Drawing.Point(143, 123)
        Me.cboTipoCalculo.Name = "cboTipoCalculo"
        Me.cboTipoCalculo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipoCalculo.Size = New System.Drawing.Size(182, 20)
        Me.cboTipoCalculo.TabIndex = 4
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(61, 126)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 140
        Me.LabelControl11.Text = "Tipo de Calculo:"
        '
        'chkAplicaIva
        '
        Me.chkAplicaIva.Location = New System.Drawing.Point(143, 98)
        Me.chkAplicaIva.Name = "chkAplicaIva"
        Me.chkAplicaIva.Properties.Caption = "Aplica Iva"
        Me.chkAplicaIva.Size = New System.Drawing.Size(131, 20)
        Me.chkAplicaIva.TabIndex = 81
        Me.chkAplicaIva.TabStop = False
        '
        'teCta01
        '
        Me.teCta01.Enabled = False
        Me.teCta01.Location = New System.Drawing.Point(311, 64)
        Me.teCta01.Name = "teCta01"
        Me.teCta01.Size = New System.Drawing.Size(398, 20)
        Me.teCta01.TabIndex = 3
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(145, 64)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(160, 20)
        Me.beCta01.TabIndex = 2
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(52, 68)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl27.TabIndex = 77
        Me.LabelControl27.Text = "Cuenta Contable:"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(145, 38)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(358, 20)
        Me.teNombre.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(100, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 74
        Me.LabelControl3.Text = "Nombre:"
        '
        'teIdDeduccion
        '
        Me.teIdDeduccion.EnterMoveNextControl = True
        Me.teIdDeduccion.Location = New System.Drawing.Point(145, 12)
        Me.teIdDeduccion.Name = "teIdDeduccion"
        Me.teIdDeduccion.Size = New System.Drawing.Size(87, 20)
        Me.teIdDeduccion.TabIndex = 0
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(71, 15)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl59.TabIndex = 73
        Me.LabelControl59.Text = "Id. Deducción:"
        '
        'pre_frmDeduccionesPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(736, 244)
        Me.Controls.Add(Me.PanelControl1)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmDeduccionesPrestamo"
        Me.OptionId = "001005"
        Me.Text = "Tipos de Deducciones Préstamos"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboTipoCalculo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAplicaIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdDeduccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teCta01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdDeduccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkAplicaIva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboTipoCalculo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl

End Class
