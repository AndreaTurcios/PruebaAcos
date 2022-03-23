<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmGeneraIndicadores
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
        Me.leIndicador = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leVariable = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.sbVer = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sbVer)
        Me.GroupControl1.Controls.Add(Me.leIndicador)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.leVariable)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 186)
        '
        'leIndicador
        '
        Me.leIndicador.EnterMoveNextControl = True
        Me.leIndicador.Location = New System.Drawing.Point(88, 81)
        Me.leIndicador.Name = "leIndicador"
        Me.leIndicador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leIndicador.Size = New System.Drawing.Size(331, 20)
        Me.leIndicador.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(38, 84)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl1.TabIndex = 184
        Me.LabelControl1.Text = "Indicador:"
        '
        'leVariable
        '
        Me.leVariable.EnterMoveNextControl = True
        Me.leVariable.Location = New System.Drawing.Point(88, 39)
        Me.leVariable.Name = "leVariable"
        Me.leVariable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leVariable.Size = New System.Drawing.Size(331, 20)
        Me.leVariable.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(40, 42)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl4.TabIndex = 183
        Me.LabelControl4.Text = "Variables:"
        '
        'sbVer
        '
        Me.sbVer.Location = New System.Drawing.Point(441, 36)
        Me.sbVer.Name = "sbVer"
        Me.sbVer.Size = New System.Drawing.Size(98, 65)
        Me.sbVer.TabIndex = 185
        Me.sbVer.Text = "Ver Indicador"
        '
        'ind_frmGeneraIndicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 211)
        Me.Modulo = "Préstamos"
        Me.Name = "ind_frmGeneraIndicadores"
        Me.Text = "Generar Indicadores"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leIndicador As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leVariable As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbVer As DevExpress.XtraEditors.SimpleButton

End Class
