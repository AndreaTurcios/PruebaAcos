<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmModificaUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmModificaUsuario))
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.teNombres = New DevExpress.XtraEditors.TextEdit()
        Me.teApellidos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tePass = New DevExpress.XtraEditors.TextEdit()
        Me.teId = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.teNewPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.teConPass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.leTipoUsuario = New DevExpress.XtraEditors.LookUpEdit()
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.ceVerCorte = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNewPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teConPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceVerCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(84, 142)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Tipo de Usuario:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(258, 249)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(90, 28)
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "&Regresar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(164, 249)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(90, 28)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "&Guardar"
        '
        'teNombres
        '
        Me.teNombres.Location = New System.Drawing.Point(165, 169)
        Me.teNombres.Name = "teNombres"
        Me.teNombres.Size = New System.Drawing.Size(197, 20)
        Me.teNombres.TabIndex = 6
        '
        'teApellidos
        '
        Me.teApellidos.Location = New System.Drawing.Point(165, 190)
        Me.teApellidos.Name = "teApellidos"
        Me.teApellidos.Size = New System.Drawing.Size(197, 20)
        Me.teApellidos.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(60, 193)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Apellidos del Usuario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(65, 172)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Nombre del Usuario:"
        '
        'tePass
        '
        Me.tePass.EditValue = ""
        Me.tePass.Location = New System.Drawing.Point(165, 36)
        Me.tePass.Name = "tePass"
        Me.tePass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePass.Size = New System.Drawing.Size(197, 20)
        Me.tePass.TabIndex = 1
        '
        'teId
        '
        Me.teId.Location = New System.Drawing.Point(165, 15)
        Me.teId.Name = "teId"
        Me.teId.Properties.ReadOnly = True
        Me.teId.Size = New System.Drawing.Size(197, 20)
        Me.teId.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(61, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(101, 13)
        Me.LabelControl2.TabIndex = 42
        Me.LabelControl2.Text = "Contraseña anterior:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(94, 18)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "Identificación:"
        '
        'teNewPass
        '
        Me.teNewPass.EditValue = ""
        Me.teNewPass.Location = New System.Drawing.Point(165, 62)
        Me.teNewPass.Name = "teNewPass"
        Me.teNewPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.teNewPass.Size = New System.Drawing.Size(197, 20)
        Me.teNewPass.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(68, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Nueva Contraseña:"
        '
        'teConPass
        '
        Me.teConPass.EditValue = ""
        Me.teConPass.Location = New System.Drawing.Point(165, 87)
        Me.teConPass.Name = "teConPass"
        Me.teConPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.teConPass.Size = New System.Drawing.Size(197, 20)
        Me.teConPass.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(52, 90)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl7.TabIndex = 54
        Me.LabelControl7.Text = "Confirmar Contraseña:"
        '
        'leTipoUsuario
        '
        Me.leTipoUsuario.Location = New System.Drawing.Point(165, 139)
        Me.leTipoUsuario.Name = "leTipoUsuario"
        Me.leTipoUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoUsuario.Size = New System.Drawing.Size(197, 20)
        Me.leTipoUsuario.TabIndex = 5
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(165, 113)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(197, 20)
        Me.leSucursal.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(118, 116)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl8.TabIndex = 56
        Me.LabelControl8.Text = "Sucursal:"
        '
        'ceVerCorte
        '
        Me.ceVerCorte.Location = New System.Drawing.Point(166, 216)
        Me.ceVerCorte.Name = "ceVerCorte"
        Me.ceVerCorte.Properties.Caption = "Puede ver el corte de caja"
        Me.ceVerCorte.Size = New System.Drawing.Size(196, 19)
        Me.ceVerCorte.TabIndex = 57
        '
        'adm_frmModificaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 284)
        Me.Controls.Add(Me.ceVerCorte)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.leTipoUsuario)
        Me.Controls.Add(Me.teConPass)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.teNewPass)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.teNombres)
        Me.Controls.Add(Me.teApellidos)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tePass)
        Me.Controls.Add(Me.teId)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adm_frmModificaUsuario"
        Me.Text = "Modificar Usuarios"
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNewPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teConPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceVerCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tePass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNewPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teConPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceVerCorte As DevExpress.XtraEditors.CheckEdit
End Class
