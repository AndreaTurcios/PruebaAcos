﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmFormasPagoCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmFormasPagoCaja))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.rgAbonoCargo = New DevExpress.XtraEditors.RadioGroup
        Me.tePrefijo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
        Me.teCta01 = New DevExpress.XtraEditors.TextEdit
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teIdTipo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.rgAbonoCargo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePrefijo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.rgAbonoCargo)
        Me.PanelControl1.Controls.Add(Me.tePrefijo)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl58)
        Me.PanelControl1.Controls.Add(Me.teCta01)
        Me.PanelControl1.Controls.Add(Me.beCta01)
        Me.PanelControl1.Controls.Add(Me.LabelControl27)
        Me.PanelControl1.Controls.Add(Me.teNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.teIdTipo)
        Me.PanelControl1.Controls.Add(Me.LabelControl59)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(853, 207)
        Me.PanelControl1.TabIndex = 3
        '
        'rgAbonoCargo
        '
        Me.rgAbonoCargo.EditValue = 1
        Me.rgAbonoCargo.Location = New System.Drawing.Point(157, 127)
        Me.rgAbonoCargo.Name = "rgAbonoCargo"
        Me.rgAbonoCargo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Abono/Ingreso"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cargo/Egreso")})
        Me.rgAbonoCargo.Size = New System.Drawing.Size(286, 27)
        Me.rgAbonoCargo.TabIndex = 5
        '
        'tePrefijo
        '
        Me.tePrefijo.EnterMoveNextControl = True
        Me.tePrefijo.Location = New System.Drawing.Point(157, 76)
        Me.tePrefijo.Name = "tePrefijo"
        Me.tePrefijo.Size = New System.Drawing.Size(87, 20)
        Me.tePrefijo.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(119, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 100
        Me.LabelControl1.Text = "Prefijo:"
        '
        'LabelControl58
        '
        Me.LabelControl58.Location = New System.Drawing.Point(80, 134)
        Me.LabelControl58.Name = "LabelControl58"
        Me.LabelControl58.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl58.TabIndex = 96
        Me.LabelControl58.Text = "Tipo Aplicación:"
        '
        'teCta01
        '
        Me.teCta01.Enabled = False
        Me.teCta01.Location = New System.Drawing.Point(323, 101)
        Me.teCta01.Name = "teCta01"
        Me.teCta01.Size = New System.Drawing.Size(495, 20)
        Me.teCta01.TabIndex = 4
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(157, 101)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(160, 20)
        Me.beCta01.TabIndex = 3
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(69, 105)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl27.TabIndex = 77
        Me.LabelControl27.Text = "Cuenta Contable:"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(157, 51)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(358, 20)
        Me.teNombre.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(113, 55)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 74
        Me.LabelControl3.Text = "Nombre:"
        '
        'teIdTipo
        '
        Me.teIdTipo.EnterMoveNextControl = True
        Me.teIdTipo.Location = New System.Drawing.Point(157, 25)
        Me.teIdTipo.Name = "teIdTipo"
        Me.teIdTipo.Size = New System.Drawing.Size(87, 20)
        Me.teIdTipo.TabIndex = 0
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(61, 28)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl59.TabIndex = 73
        Me.LabelControl59.Text = "Id. Forma de Pago:"
        '
        'adm_frmFormasPagoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(853, 232)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmFormasPagoCaja"
        Me.OptionId = "001003"
        Me.Text = "Formas de Pago en Caja"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.rgAbonoCargo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePrefijo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teCta01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdTipo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tePrefijo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgAbonoCargo As DevExpress.XtraEditors.RadioGroup

End Class
