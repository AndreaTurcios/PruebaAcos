<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmTrasladoPrestamos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmTrasladoPrestamos))
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.seTasaInteres = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.beNoPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.teAsociado = New DevExpress.XtraEditors.TextEdit
        Me.teSaldoCapital = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoInteres = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.teMoratorio = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoCartera = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.seTasaMora = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.chkCancelarAhorro = New DevExpress.XtraEditors.CheckEdit
        Me.chkNuevo = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.rdoTipoCambio = New DevExpress.XtraEditors.RadioGroup
        Me.teCostas = New DevExpress.XtraEditors.TextEdit
        Me.deFechaPrimer = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.seTasaInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoCapital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMoratorio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoCartera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasaMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkCancelarAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkNuevo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rdoTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCostas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimer.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(491, 288)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(148, 33)
        Me.sbGuardar.TabIndex = 12
        Me.sbGuardar.Text = "&Aceptar Cambio"
        '
        'seTasaInteres
        '
        Me.seTasaInteres.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasaInteres.EnterMoveNextControl = True
        Me.seTasaInteres.Location = New System.Drawing.Point(211, 227)
        Me.seTasaInteres.Name = "seTasaInteres"
        Me.seTasaInteres.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasaInteres.Properties.Mask.EditMask = "P2"
        Me.seTasaInteres.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasaInteres.Size = New System.Drawing.Size(84, 20)
        Me.seTasaInteres.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 230)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl3.TabIndex = 160
        Me.LabelControl3.Text = "Tasa de Interes con la que se Traslada:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(210, 58)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(115, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 159
        Me.LabelControl2.Text = "Fecha de Traslado:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(141, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 158
        Me.LabelControl1.Text = "A Nombre de:"
        '
        'beNoPrestamo
        '
        Me.beNoPrestamo.EnterMoveNextControl = True
        Me.beNoPrestamo.Location = New System.Drawing.Point(210, 12)
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
        Me.LabelControl6.Location = New System.Drawing.Point(103, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl6.TabIndex = 157
        Me.LabelControl6.Text = "Numero de Préstamo:"
        '
        'teAsociado
        '
        Me.teAsociado.Location = New System.Drawing.Point(210, 35)
        Me.teAsociado.Name = "teAsociado"
        Me.teAsociado.Properties.ReadOnly = True
        Me.teAsociado.Size = New System.Drawing.Size(440, 20)
        Me.teAsociado.TabIndex = 1
        '
        'teSaldoCapital
        '
        Me.teSaldoCapital.EditValue = 0
        Me.teSaldoCapital.EnterMoveNextControl = True
        Me.teSaldoCapital.Location = New System.Drawing.Point(210, 83)
        Me.teSaldoCapital.Name = "teSaldoCapital"
        Me.teSaldoCapital.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoCapital.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoCapital.Properties.Mask.EditMask = "n2"
        Me.teSaldoCapital.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoCapital.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoCapital.Properties.ReadOnly = True
        Me.teSaldoCapital.Size = New System.Drawing.Size(83, 20)
        Me.teSaldoCapital.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(112, 86)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl7.TabIndex = 183
        Me.LabelControl7.Text = "Saldo del Préstamo:"
        '
        'teSaldoInteres
        '
        Me.teSaldoInteres.EditValue = 0
        Me.teSaldoInteres.EnterMoveNextControl = True
        Me.teSaldoInteres.Location = New System.Drawing.Point(210, 107)
        Me.teSaldoInteres.Name = "teSaldoInteres"
        Me.teSaldoInteres.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoInteres.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoInteres.Properties.Mask.EditMask = "n2"
        Me.teSaldoInteres.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoInteres.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoInteres.Properties.ReadOnly = True
        Me.teSaldoInteres.Size = New System.Drawing.Size(83, 20)
        Me.teSaldoInteres.TabIndex = 4
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(113, 111)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl8.TabIndex = 185
        Me.LabelControl8.Text = "Saldo de Intereses:"
        '
        'teMoratorio
        '
        Me.teMoratorio.EditValue = 0
        Me.teMoratorio.EnterMoveNextControl = True
        Me.teMoratorio.Location = New System.Drawing.Point(210, 131)
        Me.teMoratorio.Name = "teMoratorio"
        Me.teMoratorio.Properties.Appearance.Options.UseTextOptions = True
        Me.teMoratorio.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMoratorio.Properties.Mask.EditMask = "n2"
        Me.teMoratorio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMoratorio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMoratorio.Properties.ReadOnly = True
        Me.teMoratorio.Size = New System.Drawing.Size(83, 20)
        Me.teMoratorio.TabIndex = 5
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(75, 134)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl9.TabIndex = 187
        Me.LabelControl9.Text = "Saldo de Interes Moratorio:"
        '
        'leTipoCartera
        '
        Me.leTipoCartera.EnterMoveNextControl = True
        Me.leTipoCartera.Location = New System.Drawing.Point(210, 174)
        Me.leTipoCartera.Name = "leTipoCartera"
        Me.leTipoCartera.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCartera.Size = New System.Drawing.Size(292, 20)
        Me.leTipoCartera.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(56, 157)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(239, 13)
        Me.LabelControl11.TabIndex = 189
        Me.LabelControl11.Text = "Tipo de Cartera donde se Trasladara el Préstamo:"
        '
        'seTasaMora
        '
        Me.seTasaMora.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasaMora.EnterMoveNextControl = True
        Me.seTasaMora.Location = New System.Drawing.Point(211, 252)
        Me.seTasaMora.Name = "seTasaMora"
        Me.seTasaMora.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasaMora.Properties.Mask.EditMask = "P2"
        Me.seTasaMora.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasaMora.Size = New System.Drawing.Size(84, 20)
        Me.seTasaMora.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(45, 255)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl10.TabIndex = 191
        Me.LabelControl10.Text = "Nueva Tasa de Interes Moratorio:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(117, 279)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl12.TabIndex = 193
        Me.LabelControl12.Text = "Costas Procesales:"
        '
        'chkCancelarAhorro
        '
        Me.chkCancelarAhorro.AutoSizeInLayoutControl = True
        Me.chkCancelarAhorro.Location = New System.Drawing.Point(209, 204)
        Me.chkCancelarAhorro.Name = "chkCancelarAhorro"
        Me.chkCancelarAhorro.Properties.Caption = "Cancelar Ahorros y Aportaciones"
        Me.chkCancelarAhorro.Size = New System.Drawing.Size(200, 19)
        Me.chkCancelarAhorro.TabIndex = 194
        Me.chkCancelarAhorro.Visible = False
        '
        'chkNuevo
        '
        Me.chkNuevo.AutoSizeInLayoutControl = True
        Me.chkNuevo.Location = New System.Drawing.Point(209, 302)
        Me.chkNuevo.Name = "chkNuevo"
        Me.chkNuevo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkNuevo.Properties.Appearance.Options.UseFont = True
        Me.chkNuevo.Properties.Caption = "CREAR UN NUEVO PRÉSTAMO"
        Me.chkNuevo.Size = New System.Drawing.Size(200, 19)
        Me.chkNuevo.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(404, 255)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl5.TabIndex = 197
        Me.LabelControl5.Text = "Tipo de Cambio:"
        '
        'rdoTipoCambio
        '
        Me.rdoTipoCambio.Location = New System.Drawing.Point(484, 250)
        Me.rdoTipoCambio.Name = "rdoTipoCambio"
        Me.rdoTipoCambio.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.rdoTipoCambio.Properties.Appearance.Options.UseBackColor = True
        Me.rdoTipoCambio.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Definir"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Eliminar")})
        Me.rdoTipoCambio.Size = New System.Drawing.Size(155, 22)
        Me.rdoTipoCambio.TabIndex = 11
        '
        'teCostas
        '
        Me.teCostas.EditValue = 0
        Me.teCostas.EnterMoveNextControl = True
        Me.teCostas.Location = New System.Drawing.Point(210, 276)
        Me.teCostas.Name = "teCostas"
        Me.teCostas.Properties.Appearance.Options.UseTextOptions = True
        Me.teCostas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCostas.Properties.Mask.EditMask = "n2"
        Me.teCostas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCostas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCostas.Size = New System.Drawing.Size(83, 20)
        Me.teCostas.TabIndex = 198
        '
        'deFechaPrimer
        '
        Me.deFechaPrimer.EditValue = Nothing
        Me.deFechaPrimer.EnterMoveNextControl = True
        Me.deFechaPrimer.Location = New System.Drawing.Point(550, 58)
        Me.deFechaPrimer.Name = "deFechaPrimer"
        Me.deFechaPrimer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaPrimer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaPrimer.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaPrimer.Size = New System.Drawing.Size(100, 20)
        Me.deFechaPrimer.TabIndex = 199
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(386, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(162, 13)
        Me.LabelControl4.TabIndex = 200
        Me.LabelControl4.Text = "Fecha Primer Descurnto Traslado:"
        '
        'pre_frmTrasladoPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(688, 369)
        Me.Controls.Add(Me.deFechaPrimer)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.teCostas)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.rdoTipoCambio)
        Me.Controls.Add(Me.chkNuevo)
        Me.Controls.Add(Me.chkCancelarAhorro)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.seTasaMora)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.leTipoCartera)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.teMoratorio)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.teSaldoInteres)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teSaldoCapital)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.seTasaInteres)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.beNoPrestamo)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teAsociado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmTrasladoPrestamos"
        Me.OptionId = "003007"
        Me.Text = "Traslado de Préstamos Cartera"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.teAsociado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.beNoPrestamo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.seTasaInteres, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.teSaldoCapital, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.teSaldoInteres, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.teMoratorio, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.leTipoCartera, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.seTasaMora, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.chkCancelarAhorro, 0)
        Me.Controls.SetChildIndex(Me.chkNuevo, 0)
        Me.Controls.SetChildIndex(Me.rdoTipoCambio, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.teCostas, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.deFechaPrimer, 0)
        CType(Me.seTasaInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoCapital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMoratorio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoCartera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasaMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkCancelarAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkNuevo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rdoTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCostas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimer.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents seTasaInteres As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beNoPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSaldoCapital As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoInteres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMoratorio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoCartera As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seTasaMora As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkCancelarAhorro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNuevo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rdoTipoCambio As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents teCostas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deFechaPrimer As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl

End Class
