<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmCrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmCrearUsuario))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teId = New DevExpress.XtraEditors.TextEdit
        Me.tePass = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teApellidos = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.teNombres = New DevExpress.XtraEditors.TextEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.leTipoUsuario = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teConPass = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.ceVerCorte = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.leImpresoras = New DevExpress.XtraEditors.LookUpEdit
        CType(Me.teId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teApellidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teConPass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceVerCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leImpresoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(87, 14)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Identificación:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(95, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Contraseña:"
        '
        'teId
        '
        Me.teId.Location = New System.Drawing.Point(157, 11)
        Me.teId.Name = "teId"
        Me.teId.Size = New System.Drawing.Size(196, 20)
        Me.teId.TabIndex = 0
        '
        'tePass
        '
        Me.tePass.EditValue = ""
        Me.tePass.Location = New System.Drawing.Point(157, 32)
        Me.tePass.Name = "tePass"
        Me.tePass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tePass.Size = New System.Drawing.Size(196, 20)
        Me.tePass.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(58, 128)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Nombre del Usuario:"
        '
        'teApellidos
        '
        Me.teApellidos.Location = New System.Drawing.Point(157, 145)
        Me.teApellidos.Name = "teApellidos"
        Me.teApellidos.Size = New System.Drawing.Size(196, 20)
        Me.teApellidos.TabIndex = 5
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(53, 148)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Apellidos del Usuario:"
        '
        'teNombres
        '
        Me.teNombres.Location = New System.Drawing.Point(157, 124)
        Me.teNombres.Name = "teNombres"
        Me.teNombres.Size = New System.Drawing.Size(196, 20)
        Me.teNombres.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(120, 245)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(90, 28)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "&Guardar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(214, 245)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(90, 28)
        Me.SimpleButton2.TabIndex = 10
        Me.SimpleButton2.Text = "&Regresar"
        '
        'leTipoUsuario
        '
        Me.leTipoUsuario.EnterMoveNextControl = True
        Me.leTipoUsuario.Location = New System.Drawing.Point(157, 93)
        Me.leTipoUsuario.Name = "leTipoUsuario"
        Me.leTipoUsuario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoUsuario.Size = New System.Drawing.Size(196, 20)
        Me.leTipoUsuario.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(77, 96)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 38
        Me.LabelControl5.Text = "Tipo de Usuario:"
        '
        'teConPass
        '
        Me.teConPass.EditValue = ""
        Me.teConPass.Location = New System.Drawing.Point(157, 62)
        Me.teConPass.Name = "teConPass"
        Me.teConPass.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.teConPass.Size = New System.Drawing.Size(196, 20)
        Me.teConPass.TabIndex = 2
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(49, 65)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(106, 13)
        Me.LabelControl6.TabIndex = 39
        Me.LabelControl6.Text = "Confirma Contraseña:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(18, 175)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(137, 13)
        Me.LabelControl7.TabIndex = 38
        Me.LabelControl7.Text = "Sucursal a la que Pertenece:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(157, 171)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(196, 20)
        Me.leSucursal.TabIndex = 6
        '
        'ceVerCorte
        '
        Me.ceVerCorte.Location = New System.Drawing.Point(157, 222)
        Me.ceVerCorte.Name = "ceVerCorte"
        Me.ceVerCorte.Properties.Caption = "Puede ver el corte de caja"
        Me.ceVerCorte.Size = New System.Drawing.Size(196, 19)
        Me.ceVerCorte.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(29, 199)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(126, 13)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "Impresor predeterminado:"
        '
        'leImpresoras
        '
        Me.leImpresoras.EnterMoveNextControl = True
        Me.leImpresoras.Location = New System.Drawing.Point(157, 197)
        Me.leImpresoras.Name = "leImpresoras"
        Me.leImpresoras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leImpresoras.Size = New System.Drawing.Size(196, 20)
        Me.leImpresoras.TabIndex = 7
        '
        'adm_frmCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 284)
        Me.Controls.Add(Me.ceVerCorte)
        Me.Controls.Add(Me.teConPass)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.leImpresoras)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.leTipoUsuario)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "adm_frmCrearUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Creación de usuarios"
        CType(Me.teId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teApellidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teConPass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceVerCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leImpresoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tePass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teApellidos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leTipoUsuario As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teConPass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ceVerCorte As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leImpresoras As DevExpress.XtraEditors.LookUpEdit
End Class
