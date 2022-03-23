<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmSucursales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmSucursales))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.teCiudad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.seCorrelativo = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.teSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.teTelefono = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teResponsable = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teIdSucursal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.teCiudad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seCorrelativo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTelefono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teResponsable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.teCiudad)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.seCorrelativo)
        Me.PanelControl1.Controls.Add(Me.LabelControl44)
        Me.PanelControl1.Controls.Add(Me.teSerie)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.teTelefono)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.teResponsable)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.teNombre)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.teIdSucursal)
        Me.PanelControl1.Controls.Add(Me.LabelControl59)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(622, 228)
        Me.PanelControl1.TabIndex = 3
        '
        'teCiudad
        '
        Me.teCiudad.EnterMoveNextControl = True
        Me.teCiudad.Location = New System.Drawing.Point(157, 176)
        Me.teCiudad.Name = "teCiudad"
        Me.teCiudad.Size = New System.Drawing.Size(358, 20)
        Me.teCiudad.TabIndex = 6
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(123, 185)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl5.TabIndex = 116
        Me.LabelControl5.Text = "Ciudad:"
        '
        'seCorrelativo
        '
        Me.seCorrelativo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seCorrelativo.EnterMoveNextControl = True
        Me.seCorrelativo.Location = New System.Drawing.Point(157, 151)
        Me.seCorrelativo.Name = "seCorrelativo"
        Me.seCorrelativo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seCorrelativo.Properties.Mask.EditMask = "n0"
        Me.seCorrelativo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seCorrelativo.Size = New System.Drawing.Size(109, 20)
        Me.seCorrelativo.TabIndex = 5
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(77, 160)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl44.TabIndex = 114
        Me.LabelControl44.Text = "Correlativo Pago:"
        '
        'teSerie
        '
        Me.teSerie.EnterMoveNextControl = True
        Me.teSerie.Location = New System.Drawing.Point(157, 125)
        Me.teSerie.Name = "teSerie"
        Me.teSerie.Size = New System.Drawing.Size(109, 20)
        Me.teSerie.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(132, 134)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 104
        Me.LabelControl4.Text = "Serie:"
        '
        'teTelefono
        '
        Me.teTelefono.EnterMoveNextControl = True
        Me.teTelefono.Location = New System.Drawing.Point(157, 100)
        Me.teTelefono.Name = "teTelefono"
        Me.teTelefono.Size = New System.Drawing.Size(109, 20)
        Me.teTelefono.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(114, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 102
        Me.LabelControl2.Text = "Teléfono:"
        '
        'teResponsable
        '
        Me.teResponsable.EnterMoveNextControl = True
        Me.teResponsable.Location = New System.Drawing.Point(157, 76)
        Me.teResponsable.Name = "teResponsable"
        Me.teResponsable.Size = New System.Drawing.Size(358, 20)
        Me.teResponsable.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(95, 86)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 100
        Me.LabelControl1.Text = "Responsable:"
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
        Me.LabelControl3.Location = New System.Drawing.Point(119, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl3.TabIndex = 74
        Me.LabelControl3.Text = "Nombre:"
        '
        'teIdSucursal
        '
        Me.teIdSucursal.EnterMoveNextControl = True
        Me.teIdSucursal.Location = New System.Drawing.Point(157, 25)
        Me.teIdSucursal.Name = "teIdSucursal"
        Me.teIdSucursal.Size = New System.Drawing.Size(87, 20)
        Me.teIdSucursal.TabIndex = 0
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(99, 34)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl59.TabIndex = 73
        Me.LabelControl59.Text = "Id. Sucursal:"
        '
        'adm_frmSucursales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(622, 256)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmSucursales"
        Me.OptionId = "001004"
        Me.Text = "Sucursales"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.teCiudad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seCorrelativo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTelefono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teResponsable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdSucursal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teResponsable As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTelefono As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seCorrelativo As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCiudad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl

End Class
