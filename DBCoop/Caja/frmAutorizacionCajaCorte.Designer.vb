<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAutorizacionCajaCorte
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
        Me.teContrasenia = New DevExpress.XtraEditors.TextEdit
        Me.teUserId = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdCancel = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAceptar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teContrasenia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teUserId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teContrasenia
        '
        Me.teContrasenia.EditValue = ""
        Me.teContrasenia.EnterMoveNextControl = True
        Me.teContrasenia.Location = New System.Drawing.Point(138, 46)
        Me.teContrasenia.Name = "teContrasenia"
        Me.teContrasenia.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.teContrasenia.Size = New System.Drawing.Size(147, 20)
        Me.teContrasenia.TabIndex = 1
        '
        'teUserId
        '
        Me.teUserId.EditValue = ""
        Me.teUserId.EnterMoveNextControl = True
        Me.teUserId.Location = New System.Drawing.Point(138, 22)
        Me.teUserId.Name = "teUserId"
        Me.teUserId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teUserId.Size = New System.Drawing.Size(147, 20)
        Me.teUserId.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(23, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Contraseña de Acceso:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Identificación de Usuario:"
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(164, 84)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(103, 23)
        Me.cmdCancel.TabIndex = 3
        Me.cmdCancel.Text = "&Cancelar"
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(55, 84)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(103, 23)
        Me.cmdAceptar.TabIndex = 2
        Me.cmdAceptar.Text = "Aceptar"
        '
        'frmAutorizacionCajaCorte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 120)
        Me.Controls.Add(Me.teContrasenia)
        Me.Controls.Add(Me.teUserId)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdAceptar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAutorizacionCajaCorte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Autorización"
        CType(Me.teContrasenia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teUserId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teContrasenia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teUserId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAceptar As DevExpress.XtraEditors.SimpleButton
End Class
