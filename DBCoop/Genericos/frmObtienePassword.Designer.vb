<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmObtienePassword
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.tePassword = New DevExpress.XtraEditors.TextEdit
        Me.teUserName = New DevExpress.XtraEditors.TextEdit
        Me.sbCancel = New DevExpress.XtraEditors.SimpleButton
        Me.sbOk = New DevExpress.XtraEditors.SimpleButton
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 46)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Contraseña:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(39, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 16
        Me.LabelControl1.Text = "Usuario:"
        '
        'tePassword
        '
        Me.tePassword.EditValue = ""
        Me.tePassword.EnterMoveNextControl = True
        Me.tePassword.Location = New System.Drawing.Point(82, 43)
        Me.tePassword.Name = "tePassword"
        Me.tePassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePassword.Size = New System.Drawing.Size(217, 20)
        Me.tePassword.TabIndex = 13
        '
        'teUserName
        '
        Me.teUserName.EditValue = ""
        Me.teUserName.EnterMoveNextControl = True
        Me.teUserName.Location = New System.Drawing.Point(82, 18)
        Me.teUserName.Name = "teUserName"
        Me.teUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teUserName.Size = New System.Drawing.Size(217, 20)
        Me.teUserName.TabIndex = 12
        '
        'sbCancel
        '
        Me.sbCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sbCancel.Location = New System.Drawing.Point(256, 88)
        Me.sbCancel.Name = "sbCancel"
        Me.sbCancel.Size = New System.Drawing.Size(93, 27)
        Me.sbCancel.TabIndex = 15
        Me.sbCancel.Text = "&Cancelar"
        '
        'sbOk
        '
        Me.sbOk.Location = New System.Drawing.Point(153, 88)
        Me.sbOk.Name = "sbOk"
        Me.sbOk.Size = New System.Drawing.Size(93, 27)
        Me.sbOk.TabIndex = 14
        Me.sbOk.Text = "&Aceptar"
        '
        'frmObtienePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 136)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.tePassword)
        Me.Controls.Add(Me.teUserName)
        Me.Controls.Add(Me.sbCancel)
        Me.Controls.Add(Me.sbOk)
        Me.Name = "frmObtienePassword"
        Me.Text = "Autorización"
        CType(Me.tePassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tePassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbOk As DevExpress.XtraEditors.SimpleButton
End Class
