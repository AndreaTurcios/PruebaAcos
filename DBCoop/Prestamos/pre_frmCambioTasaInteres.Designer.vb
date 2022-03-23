<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmCambioTasaInteres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmCambioTasaInteres))
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teAsociado = New DevExpress.XtraEditors.TextEdit
        Me.beNoPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.rdoTipoTasa = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.rdoTipoCambio = New DevExpress.XtraEditors.RadioGroup
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.cboLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoTipoTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(188, 73)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl2.TabIndex = 101
        Me.LabelControl2.Text = "Cambiar tasa a partir de la Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(119, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 99
        Me.LabelControl1.Text = "A Nombre de:"
        '
        'teAsociado
        '
        Me.teAsociado.Location = New System.Drawing.Point(188, 48)
        Me.teAsociado.Name = "teAsociado"
        Me.teAsociado.Properties.ReadOnly = True
        Me.teAsociado.Size = New System.Drawing.Size(440, 20)
        Me.teAsociado.TabIndex = 1
        '
        'beNoPrestamo
        '
        Me.beNoPrestamo.EnterMoveNextControl = True
        Me.beNoPrestamo.Location = New System.Drawing.Point(188, 23)
        Me.beNoPrestamo.Name = "beNoPrestamo"
        Me.beNoPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNoPrestamo.Properties.Mask.EditMask = "00-0000-0000"
        Me.beNoPrestamo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.beNoPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.beNoPrestamo.Size = New System.Drawing.Size(136, 20)
        Me.beNoPrestamo.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(81, 26)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl6.TabIndex = 98
        Me.LabelControl6.Text = "Numero de Préstamo:"
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(188, 98)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "P2"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Size = New System.Drawing.Size(84, 20)
        Me.seTasa.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(71, 101)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl3.TabIndex = 145
        Me.LabelControl3.Text = "Nuevo Valor de la Tasa:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(118, 154)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 147
        Me.LabelControl4.Text = "Tipo de Tasa:"
        '
        'rdoTipoTasa
        '
        Me.rdoTipoTasa.EditValue = 0
        Me.rdoTipoTasa.Location = New System.Drawing.Point(188, 150)
        Me.rdoTipoTasa.Name = "rdoTipoTasa"
        Me.rdoTipoTasa.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.rdoTipoTasa.Properties.Appearance.Options.UseBackColor = True
        Me.rdoTipoTasa.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Interes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Moratoria")})
        Me.rdoTipoTasa.Size = New System.Drawing.Size(155, 22)
        Me.rdoTipoTasa.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(108, 181)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl5.TabIndex = 149
        Me.LabelControl5.Text = "Tipo de Cambio:"
        '
        'rdoTipoCambio
        '
        Me.rdoTipoCambio.EditValue = 0
        Me.rdoTipoCambio.Location = New System.Drawing.Point(188, 176)
        Me.rdoTipoCambio.Name = "rdoTipoCambio"
        Me.rdoTipoCambio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.rdoTipoCambio.Properties.Appearance.Options.UseBackColor = True
        Me.rdoTipoCambio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Definir"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Eliminar")})
        Me.rdoTipoCambio.Size = New System.Drawing.Size(155, 22)
        Me.rdoTipoCambio.TabIndex = 5
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(185, 212)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(148, 33)
        Me.sbGuardar.TabIndex = 6
        Me.sbGuardar.Text = "&Aceptar Cambio"
        '
        'cboLinea
        '
        Me.cboLinea.EnterMoveNextControl = True
        Me.cboLinea.Location = New System.Drawing.Point(188, 124)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLinea.Size = New System.Drawing.Size(332, 20)
        Me.cboLinea.TabIndex = 150
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(102, 128)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl32.TabIndex = 151
        Me.LabelControl32.Text = "Línea de Crédito:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(330, 26)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(213, 13)
        Me.LabelControl7.TabIndex = 152
        Me.LabelControl7.Text = "** En blanco para cambiar todos los créditos"
        '
        'pre_frmCambioTasaInteres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(704, 295)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cboLinea)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.rdoTipoCambio)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.rdoTipoTasa)
        Me.Controls.Add(Me.seTasa)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.beNoPrestamo)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teAsociado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmCambioTasaInteres"
        Me.OptionId = "003006"
        Me.Text = "Cambio de Tasa a Préstamos"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.teAsociado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.beNoPrestamo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.seTasa, 0)
        Me.Controls.SetChildIndex(Me.rdoTipoTasa, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.rdoTipoCambio, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl32, 0)
        Me.Controls.SetChildIndex(Me.cboLinea, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoTipoTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNoPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdoTipoTasa As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdoTipoCambio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl

End Class
