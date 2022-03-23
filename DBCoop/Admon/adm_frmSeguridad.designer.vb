<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmSeguridad
    Inherits Bravio.gen_frmBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmSeguridad))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.sbModifica = New DevExpress.XtraEditors.SimpleButton
        Me.sbCrearUsuario = New DevExpress.XtraEditors.SimpleButton
        Me.cmdCargarMenu = New DevExpress.XtraEditors.SimpleButton
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.cmdControlTotal = New DevExpress.XtraEditors.SimpleButton
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.lblModulo = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.CheckBoxDelete = New System.Windows.Forms.CheckBox
        Me.lblMenu = New System.Windows.Forms.Label
        Me.CheckBoxUpdate = New System.Windows.Forms.CheckBox
        Me.CheckBoxInsert = New System.Windows.Forms.CheckBox
        Me.PictureBox5 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.NavBar = New DevExpress.XtraNavBar.NavBarControl
        Me.nvModulos = New DevExpress.XtraNavBar.NavBarGroup
        Me.nvUsuarios = New DevExpress.XtraNavBar.NavBarGroup
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.TreeViewMenu = New System.Windows.Forms.TreeView
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NavBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sbImprimir)
        Me.GroupControl1.Controls.Add(Me.sbModifica)
        Me.GroupControl1.Controls.Add(Me.sbCrearUsuario)
        Me.GroupControl1.Controls.Add(Me.cmdCargarMenu)
        Me.GroupControl1.Controls.Add(Me.cmdSalir)
        Me.GroupControl1.Controls.Add(Me.cmdControlTotal)
        Me.GroupControl1.Controls.Add(Me.lblUsuario)
        Me.GroupControl1.Controls.Add(Me.lblModulo)
        Me.GroupControl1.Controls.Add(Me.PictureBox2)
        Me.GroupControl1.Controls.Add(Me.PictureBox1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1026, 79)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Modulos y Usuarios"
        '
        'sbImprimir
        '
        Me.sbImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbImprimir.Image = Global.Bravio.My.Resources.Resources.Printer
        Me.sbImprimir.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.sbImprimir.Location = New System.Drawing.Point(383, 28)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(108, 43)
        Me.sbImprimir.TabIndex = 2
        Me.sbImprimir.Text = "Imprimir"
        '
        'sbModifica
        '
        Me.sbModifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbModifica.Image = Global.Bravio.My.Resources.Resources.Edit
        Me.sbModifica.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.sbModifica.Location = New System.Drawing.Point(607, 28)
        Me.sbModifica.Name = "sbModifica"
        Me.sbModifica.Size = New System.Drawing.Size(96, 43)
        Me.sbModifica.TabIndex = 4
        Me.sbModifica.Text = "Mod. Usuario"
        '
        'sbCrearUsuario
        '
        Me.sbCrearUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbCrearUsuario.Image = Global.Bravio.My.Resources.Resources.Add
        Me.sbCrearUsuario.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
        Me.sbCrearUsuario.Location = New System.Drawing.Point(497, 28)
        Me.sbCrearUsuario.Name = "sbCrearUsuario"
        Me.sbCrearUsuario.Size = New System.Drawing.Size(108, 43)
        Me.sbCrearUsuario.TabIndex = 3
        Me.sbCrearUsuario.Text = "Crear Usuario"
        '
        'cmdCargarMenu
        '
        Me.cmdCargarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCargarMenu.Image = Global.Bravio.My.Resources.Resources.FillUpHS
        Me.cmdCargarMenu.Location = New System.Drawing.Point(706, 28)
        Me.cmdCargarMenu.Name = "cmdCargarMenu"
        Me.cmdCargarMenu.Size = New System.Drawing.Size(90, 43)
        Me.cmdCargarMenu.TabIndex = 5
        Me.cmdCargarMenu.Text = "Cargar Menu"
        '
        'cmdSalir
        '
        Me.cmdSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSalir.Image = Global.Bravio.My.Resources.Resources.Delete
        Me.cmdSalir.Location = New System.Drawing.Point(904, 28)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(117, 43)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "&Eliminar Usuario"
        '
        'cmdControlTotal
        '
        Me.cmdControlTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdControlTotal.Image = Global.Bravio.My.Resources.Resources.CarGuard
        Me.cmdControlTotal.Location = New System.Drawing.Point(798, 28)
        Me.cmdControlTotal.Name = "cmdControlTotal"
        Me.cmdControlTotal.Size = New System.Drawing.Size(104, 43)
        Me.cmdControlTotal.TabIndex = 6
        Me.cmdControlTotal.Text = "Control Total"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(238, 44)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(34, 17)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "S/N"
        '
        'lblModulo
        '
        Me.lblModulo.AutoSize = True
        Me.lblModulo.BackColor = System.Drawing.Color.Transparent
        Me.lblModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModulo.Location = New System.Drawing.Point(51, 45)
        Me.lblModulo.Name = "lblModulo"
        Me.lblModulo.Size = New System.Drawing.Size(34, 17)
        Me.lblModulo.TabIndex = 0
        Me.lblModulo.Text = "S/N"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(200, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cmdCancelar)
        Me.GroupControl2.Controls.Add(Me.cmdGuardar)
        Me.GroupControl2.Controls.Add(Me.CheckBoxDelete)
        Me.GroupControl2.Controls.Add(Me.lblMenu)
        Me.GroupControl2.Controls.Add(Me.CheckBoxUpdate)
        Me.GroupControl2.Controls.Add(Me.CheckBoxInsert)
        Me.GroupControl2.Controls.Add(Me.PictureBox5)
        Me.GroupControl2.Controls.Add(Me.PictureBox4)
        Me.GroupControl2.Controls.Add(Me.PictureBox3)
        Me.GroupControl2.Controls.Add(Me.StatusStrip1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl2.Location = New System.Drawing.Point(0, 280)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1026, 103)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Permisos por Opcion de Menu"
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdCancelar.Location = New System.Drawing.Point(929, 23)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(91, 49)
        Me.cmdCancelar.TabIndex = 7
        Me.cmdCancelar.Text = "Cancelar "
        Me.cmdCancelar.Visible = False
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdGuardar.Image = Global.Bravio.My.Resources.Resources.Save
        Me.cmdGuardar.Location = New System.Drawing.Point(834, 23)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(89, 49)
        Me.cmdGuardar.TabIndex = 3
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.Visible = False
        '
        'CheckBoxDelete
        '
        Me.CheckBoxDelete.AutoSize = True
        Me.CheckBoxDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxDelete.Location = New System.Drawing.Point(556, 38)
        Me.CheckBoxDelete.Name = "CheckBoxDelete"
        Me.CheckBoxDelete.Size = New System.Drawing.Size(85, 21)
        Me.CheckBoxDelete.TabIndex = 6
        Me.CheckBoxDelete.Text = "&Eliminar"
        Me.CheckBoxDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxDelete.UseVisualStyleBackColor = True
        Me.CheckBoxDelete.Visible = False
        '
        'lblMenu
        '
        Me.lblMenu.BackColor = System.Drawing.Color.PeachPuff
        Me.lblMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.Location = New System.Drawing.Point(5, 23)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(180, 49)
        Me.lblMenu.TabIndex = 2
        Me.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckBoxUpdate
        '
        Me.CheckBoxUpdate.AutoSize = True
        Me.CheckBoxUpdate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxUpdate.Location = New System.Drawing.Point(416, 38)
        Me.CheckBoxUpdate.Name = "CheckBoxUpdate"
        Me.CheckBoxUpdate.Size = New System.Drawing.Size(70, 21)
        Me.CheckBoxUpdate.TabIndex = 5
        Me.CheckBoxUpdate.Text = "Editar"
        Me.CheckBoxUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxUpdate.UseVisualStyleBackColor = True
        Me.CheckBoxUpdate.Visible = False
        '
        'CheckBoxInsert
        '
        Me.CheckBoxInsert.AutoSize = True
        Me.CheckBoxInsert.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckBoxInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxInsert.Location = New System.Drawing.Point(248, 38)
        Me.CheckBoxInsert.Name = "CheckBoxInsert"
        Me.CheckBoxInsert.Size = New System.Drawing.Size(85, 21)
        Me.CheckBoxInsert.TabIndex = 4
        Me.CheckBoxInsert.Text = "&Agregar"
        Me.CheckBoxInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBoxInsert.UseVisualStyleBackColor = True
        Me.CheckBoxInsert.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(519, 31)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(370, 31)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(210, 31)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(2, 79)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1022, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'NavBar
        '
        Me.NavBar.ActiveGroup = Me.nvModulos
        Me.NavBar.AllowSelectedLink = True
        Me.NavBar.ContentButtonHint = Nothing
        Me.NavBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.NavBar.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.nvModulos, Me.nvUsuarios})
        Me.NavBar.LargeImages = Me.ImageCollection1
        Me.NavBar.Location = New System.Drawing.Point(0, 79)
        Me.NavBar.Name = "NavBar"
        Me.NavBar.OptionsNavPane.ExpandedWidth = 185
        Me.NavBar.Size = New System.Drawing.Size(185, 201)
        Me.NavBar.SmallImages = Me.ImageCollection1
        Me.NavBar.TabIndex = 4
        Me.NavBar.Text = "NavBarControl1"
        Me.NavBar.View = New DevExpress.XtraNavBar.ViewInfo.NavigationPaneViewInfoRegistrator
        '
        'nvModulos
        '
        Me.nvModulos.Caption = "MODULOS"
        Me.nvModulos.Expanded = True
        Me.nvModulos.Name = "nvModulos"
        '
        'nvUsuarios
        '
        Me.nvUsuarios.Caption = "USUARIOS"
        Me.nvUsuarios.Name = "nvUsuarios"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'GroupControl3
        '
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.Left
        Me.GroupControl3.Controls.Add(Me.TreeViewMenu)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(185, 79)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(841, 201)
        Me.GroupControl3.TabIndex = 5
        Me.GroupControl3.Text = "Estructura del Menu"
        '
        'TreeViewMenu
        '
        Me.TreeViewMenu.CheckBoxes = True
        Me.TreeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeViewMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeViewMenu.HotTracking = True
        Me.TreeViewMenu.Indent = 30
        Me.TreeViewMenu.ItemHeight = 20
        Me.TreeViewMenu.Location = New System.Drawing.Point(23, 2)
        Me.TreeViewMenu.Margin = New System.Windows.Forms.Padding(20)
        Me.TreeViewMenu.Name = "TreeViewMenu"
        Me.TreeViewMenu.Size = New System.Drawing.Size(816, 197)
        Me.TreeViewMenu.TabIndex = 6
        Me.TreeViewMenu.Visible = False
        '
        'adm_frmSeguridad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 411)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.NavBar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmSeguridad"
        Me.OptionId = "001001"
        Me.ShowInTaskbar = False
        Me.Text = "Seguridad"
        Me.TipoFormulario = 3
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupControl2, 0)
        Me.Controls.SetChildIndex(Me.NavBar, 0)
        Me.Controls.SetChildIndex(Me.GroupControl3, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NavBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NavBar As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents nvModulos As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents nvUsuarios As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblModulo As System.Windows.Forms.Label
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmdControlTotal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckBoxDelete As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxInsert As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblMenu As System.Windows.Forms.Label
    Friend WithEvents cmdCargarMenu As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbCrearUsuario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbModifica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TreeViewMenu As System.Windows.Forms.TreeView
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton

End Class
