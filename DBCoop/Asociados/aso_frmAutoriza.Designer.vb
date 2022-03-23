<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aso_frmAutoriza
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aso_frmAutoriza))
        Me.sbCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.tePass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbCancel
        '
        Me.sbCancel.Location = New System.Drawing.Point(104, 62)
        Me.sbCancel.Name = "sbCancel"
        Me.sbCancel.Size = New System.Drawing.Size(75, 23)
        Me.sbCancel.TabIndex = 1
        Me.sbCancel.Text = "Continuar"
        '
        'tePass
        '
        Me.tePass.EditValue = ""
        Me.tePass.Location = New System.Drawing.Point(120, 22)
        Me.tePass.Name = "tePass"
        Me.tePass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePass.Size = New System.Drawing.Size(162, 20)
        Me.tePass.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(9, 25)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl8.TabIndex = 71
        Me.LabelControl8.Text = "Clave de Autorización:"
        '
        'aso_frmAutoriza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 92)
        Me.Controls.Add(Me.tePass)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.sbCancel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aso_frmAutoriza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización"
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tePass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
