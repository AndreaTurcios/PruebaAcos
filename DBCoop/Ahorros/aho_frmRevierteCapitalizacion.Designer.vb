<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmRevierteCapitalizacion
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.MonthEdit1 = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SpinEdit1)
        Me.GroupControl1.Controls.Add(Me.MonthEdit1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Size = New System.Drawing.Size(597, 224)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Período que se revierte:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Enabled = False
        Me.SpinEdit1.Location = New System.Drawing.Point(274, 48)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.SpinEdit1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n0"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.Mask.EditMask = "n0"
        Me.SpinEdit1.Size = New System.Drawing.Size(73, 20)
        Me.SpinEdit1.TabIndex = 33
        '
        'MonthEdit1
        '
        Me.MonthEdit1.Enabled = False
        Me.MonthEdit1.Location = New System.Drawing.Point(176, 48)
        Me.MonthEdit1.Name = "MonthEdit1"
        Me.MonthEdit1.Properties.AllowFocused = False
        Me.MonthEdit1.Properties.AppearanceDisabled.BorderColor = System.Drawing.Color.Black
        Me.MonthEdit1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.MonthEdit1.Properties.AppearanceDisabled.Options.UseBorderColor = True
        Me.MonthEdit1.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.MonthEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MonthEdit1.Size = New System.Drawing.Size(92, 20)
        Me.MonthEdit1.TabIndex = 32
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(175, 86)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(171, 33)
        Me.SimpleButton1.TabIndex = 31
        Me.SimpleButton1.Text = "Ejecutar Reversion..."
        '
        'aho_frmRevierteCapitalizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(597, 252)
        Me.Modulo = "Ahorros"
        Me.Name = "aho_frmRevierteCapitalizacion"
        Me.Text = "Revertir Capitalización de Intereses"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MonthEdit1 As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton

End Class
