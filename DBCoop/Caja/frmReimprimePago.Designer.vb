<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReimprimePago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReimprimePago))
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btIdPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.cmdCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.cmdAplicarPago = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.teIdMov = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me._ImporteOtros = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
        Me._ImporteCapital = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me._ImporteManejo = New DevExpress.XtraEditors.TextEdit
        Me._FechaOtorgamiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me._ImporteSeguro = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me._DeberSerMora = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me._DeberSerInteres = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me._NumeroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._ImporteCuotaAhorro = New DevExpress.XtraEditors.TextEdit
        Me._ImporteCuotaAportacion = New DevExpress.XtraEditors.TextEdit
        Me._FormaPago = New DevExpress.XtraEditors.LookUpEdit
        Me._MontoAplicar = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me._Asociado = New DevExpress.XtraEditors.TextEdit
        Me._FechaContable = New DevExpress.XtraEditors.DateEdit
        Me._FechaPago = New DevExpress.XtraEditors.DateEdit
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.teIdMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteOtros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteCapital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteManejo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteSeguro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DeberSerMora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DeberSerInteres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._ImporteCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._MontoAplicar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Asociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Enabled = False
        Me.teIdPrestamo.EnterMoveNextControl = True
        Me.teIdPrestamo.Location = New System.Drawing.Point(436, 21)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdPrestamo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.teIdPrestamo.TabIndex = 41
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(354, 24)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl14.TabIndex = 42
        Me.LabelControl14.Text = "Id del préstamo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 20)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "Número de Prestamo:"
        '
        'btIdPrestamo
        '
        Me.btIdPrestamo.EnterMoveNextControl = True
        Me.btIdPrestamo.Location = New System.Drawing.Point(157, 17)
        Me.btIdPrestamo.Name = "btIdPrestamo"
        Me.btIdPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btIdPrestamo.Properties.Mask.EditMask = "00-0000-0000"
        Me.btIdPrestamo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.btIdPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.btIdPrestamo.Size = New System.Drawing.Size(114, 20)
        Me.btIdPrestamo.TabIndex = 39
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Location = New System.Drawing.Point(550, 268)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(75, 23)
        Me.cmdCancelar.TabIndex = 38
        Me.cmdCancelar.Text = "Cancelar"
        '
        'cmdAplicarPago
        '
        Me.cmdAplicarPago.Location = New System.Drawing.Point(417, 268)
        Me.cmdAplicarPago.Name = "cmdAplicarPago"
        Me.cmdAplicarPago.Size = New System.Drawing.Size(120, 23)
        Me.cmdAplicarPago.TabIndex = 37
        Me.cmdAplicarPago.Text = "Re-Imprimir Pago"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.teIdMov)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl38)
        Me.GroupBox1.Controls.Add(Me.LabelControl23)
        Me.GroupBox1.Controls.Add(Me._ImporteOtros)
        Me.GroupBox1.Controls.Add(Me.LabelControl37)
        Me.GroupBox1.Controls.Add(Me._ImporteCapital)
        Me.GroupBox1.Controls.Add(Me.LabelControl26)
        Me.GroupBox1.Controls.Add(Me._ImporteManejo)
        Me.GroupBox1.Controls.Add(Me._FechaOtorgamiento)
        Me.GroupBox1.Controls.Add(Me.LabelControl25)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me._ImporteSeguro)
        Me.GroupBox1.Controls.Add(Me.LabelControl24)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me._DeberSerMora)
        Me.GroupBox1.Controls.Add(Me.LabelControl21)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me._DeberSerInteres)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me._NumeroComprobante)
        Me.GroupBox1.Controls.Add(Me._ImporteCuotaAhorro)
        Me.GroupBox1.Controls.Add(Me._ImporteCuotaAportacion)
        Me.GroupBox1.Controls.Add(Me._FormaPago)
        Me.GroupBox1.Controls.Add(Me._MontoAplicar)
        Me.GroupBox1.Controls.Add(Me.TextEdit2)
        Me.GroupBox1.Controls.Add(Me._Asociado)
        Me.GroupBox1.Controls.Add(Me._FechaContable)
        Me.GroupBox1.Controls.Add(Me._FechaPago)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(19, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 226)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'teIdMov
        '
        Me.teIdMov.EnterMoveNextControl = True
        Me.teIdMov.Location = New System.Drawing.Point(496, 42)
        Me.teIdMov.Name = "teIdMov"
        Me.teIdMov.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdMov.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdMov.Properties.ReadOnly = True
        Me.teIdMov.Size = New System.Drawing.Size(86, 20)
        Me.teIdMov.TabIndex = 43
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(415, 46)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl9.TabIndex = 44
        Me.LabelControl9.Text = "Id. del Registro:"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(68, 198)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl38.TabIndex = 30
        Me.LabelControl38.Text = "Otros Gastos:"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(413, 153)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl23.TabIndex = 35
        Me.LabelControl23.Text = "Abono a Capital:"
        '
        '_ImporteOtros
        '
        Me._ImporteOtros.EditValue = 0
        Me._ImporteOtros.EnterMoveNextControl = True
        Me._ImporteOtros.Location = New System.Drawing.Point(138, 195)
        Me._ImporteOtros.Name = "_ImporteOtros"
        Me._ImporteOtros.Properties.AllowFocused = False
        Me._ImporteOtros.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteOtros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteOtros.Properties.DisplayFormat.FormatString = "n2"
        Me._ImporteOtros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._ImporteOtros.Properties.LookAndFeel.SkinName = "McSkin"
        Me._ImporteOtros.Properties.ReadOnly = True
        Me._ImporteOtros.Size = New System.Drawing.Size(86, 20)
        Me._ImporteOtros.TabIndex = 13
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(399, 198)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl37.TabIndex = 30
        Me.LabelControl37.Text = "Gastos por Manejo:"
        '
        '_ImporteCapital
        '
        Me._ImporteCapital.EditValue = 0
        Me._ImporteCapital.EnterMoveNextControl = True
        Me._ImporteCapital.Location = New System.Drawing.Point(496, 149)
        Me._ImporteCapital.Name = "_ImporteCapital"
        Me._ImporteCapital.Properties.AllowFocused = False
        Me._ImporteCapital.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteCapital.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteCapital.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._ImporteCapital.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._ImporteCapital.Properties.DisplayFormat.FormatString = "n2"
        Me._ImporteCapital.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._ImporteCapital.Properties.LookAndFeel.SkinName = "McSkin"
        Me._ImporteCapital.Properties.ReadOnly = True
        Me._ImporteCapital.Size = New System.Drawing.Size(86, 20)
        Me._ImporteCapital.TabIndex = 34
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(48, 176)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl26.TabIndex = 30
        Me.LabelControl26.Text = "Seguro de Deuda:"
        '
        '_ImporteManejo
        '
        Me._ImporteManejo.EditValue = 0
        Me._ImporteManejo.EnterMoveNextControl = True
        Me._ImporteManejo.Location = New System.Drawing.Point(496, 195)
        Me._ImporteManejo.Name = "_ImporteManejo"
        Me._ImporteManejo.Properties.AllowFocused = False
        Me._ImporteManejo.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteManejo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteManejo.Properties.DisplayFormat.FormatString = "n2"
        Me._ImporteManejo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._ImporteManejo.Properties.LookAndFeel.SkinName = "McSkin"
        Me._ImporteManejo.Properties.ReadOnly = True
        Me._ImporteManejo.Size = New System.Drawing.Size(86, 20)
        Me._ImporteManejo.TabIndex = 12
        '
        '_FechaOtorgamiento
        '
        Me._FechaOtorgamiento.EditValue = Nothing
        Me._FechaOtorgamiento.EnterMoveNextControl = True
        Me._FechaOtorgamiento.Location = New System.Drawing.Point(496, 85)
        Me._FechaOtorgamiento.Name = "_FechaOtorgamiento"
        Me._FechaOtorgamiento.Properties.AllowFocused = False
        Me._FechaOtorgamiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me._FechaOtorgamiento.Properties.Appearance.Options.UseBackColor = True
        Me._FechaOtorgamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaOtorgamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaOtorgamiento.Properties.ReadOnly = True
        Me._FechaOtorgamiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaOtorgamiento.Size = New System.Drawing.Size(86, 20)
        Me._FechaOtorgamiento.TabIndex = 4
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(405, 176)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl25.TabIndex = 30
        Me.LabelControl25.Text = "Interes Moratorio:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(51, 131)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl8.TabIndex = 21
        Me.LabelControl8.Text = "Cuota de Ahorro:"
        '
        '_ImporteSeguro
        '
        Me._ImporteSeguro.EditValue = 0
        Me._ImporteSeguro.EnterMoveNextControl = True
        Me._ImporteSeguro.Location = New System.Drawing.Point(138, 172)
        Me._ImporteSeguro.Name = "_ImporteSeguro"
        Me._ImporteSeguro.Properties.AllowFocused = False
        Me._ImporteSeguro.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteSeguro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteSeguro.Properties.DisplayFormat.FormatString = "n2"
        Me._ImporteSeguro.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._ImporteSeguro.Properties.LookAndFeel.SkinName = "McSkin"
        Me._ImporteSeguro.Properties.ReadOnly = True
        Me._ImporteSeguro.Size = New System.Drawing.Size(86, 20)
        Me._ImporteSeguro.TabIndex = 11
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(43, 153)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl24.TabIndex = 30
        Me.LabelControl24.Text = " Intereses Pagado:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(390, 131)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Cuota de Aportación:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(57, 109)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "Monto a Aplicar:"
        '
        '_DeberSerMora
        '
        Me._DeberSerMora.EditValue = 0
        Me._DeberSerMora.EnterMoveNextControl = True
        Me._DeberSerMora.Location = New System.Drawing.Point(496, 173)
        Me._DeberSerMora.Name = "_DeberSerMora"
        Me._DeberSerMora.Properties.AllowFocused = False
        Me._DeberSerMora.Properties.Appearance.Options.UseTextOptions = True
        Me._DeberSerMora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._DeberSerMora.Properties.DisplayFormat.FormatString = "n2"
        Me._DeberSerMora.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._DeberSerMora.Properties.LookAndFeel.SkinName = "McSkin"
        Me._DeberSerMora.Properties.ReadOnly = True
        Me._DeberSerMora.Size = New System.Drawing.Size(86, 20)
        Me._DeberSerMora.TabIndex = 10
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(391, 90)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl21.TabIndex = 32
        Me.LabelControl21.Text = "Fecha Otrogamiento:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(414, 109)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl11.TabIndex = 27
        Me.LabelControl11.Text = "Fecha Contable:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(60, 90)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 31
        Me.LabelControl5.Text = "Fecha de Pago:"
        '
        '_DeberSerInteres
        '
        Me._DeberSerInteres.EditValue = 0
        Me._DeberSerInteres.EnterMoveNextControl = True
        Me._DeberSerInteres.Location = New System.Drawing.Point(138, 149)
        Me._DeberSerInteres.Name = "_DeberSerInteres"
        Me._DeberSerInteres.Properties.AllowFocused = False
        Me._DeberSerInteres.Properties.Appearance.Options.UseTextOptions = True
        Me._DeberSerInteres.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._DeberSerInteres.Properties.DisplayFormat.FormatString = "n2"
        Me._DeberSerInteres.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._DeberSerInteres.Properties.LookAndFeel.SkinName = "McSkin"
        Me._DeberSerInteres.Properties.ReadOnly = True
        Me._DeberSerInteres.Size = New System.Drawing.Size(86, 20)
        Me._DeberSerInteres.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(37, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl4.TabIndex = 32
        Me.LabelControl4.Text = "Referencia de Pago:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(369, 67)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl10.TabIndex = 33
        Me.LabelControl10.Text = "Numero de Comprobante:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(69, 46)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Tipo de Pago:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(70, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "A nombre de:"
        '
        '_NumeroComprobante
        '
        Me._NumeroComprobante.EditValue = ""
        Me._NumeroComprobante.EnterMoveNextControl = True
        Me._NumeroComprobante.Location = New System.Drawing.Point(496, 64)
        Me._NumeroComprobante.Name = "_NumeroComprobante"
        Me._NumeroComprobante.Properties.ReadOnly = True
        Me._NumeroComprobante.Size = New System.Drawing.Size(86, 20)
        Me._NumeroComprobante.TabIndex = 2
        '
        '_ImporteCuotaAhorro
        '
        Me._ImporteCuotaAhorro.EditValue = 0
        Me._ImporteCuotaAhorro.EnterMoveNextControl = True
        Me._ImporteCuotaAhorro.Location = New System.Drawing.Point(138, 128)
        Me._ImporteCuotaAhorro.Name = "_ImporteCuotaAhorro"
        Me._ImporteCuotaAhorro.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteCuotaAhorro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteCuotaAhorro.Properties.Mask.EditMask = "n2"
        Me._ImporteCuotaAhorro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._ImporteCuotaAhorro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._ImporteCuotaAhorro.Properties.ReadOnly = True
        Me._ImporteCuotaAhorro.Size = New System.Drawing.Size(86, 20)
        Me._ImporteCuotaAhorro.TabIndex = 11
        '
        '_ImporteCuotaAportacion
        '
        Me._ImporteCuotaAportacion.EditValue = 0
        Me._ImporteCuotaAportacion.EnterMoveNextControl = True
        Me._ImporteCuotaAportacion.Location = New System.Drawing.Point(496, 128)
        Me._ImporteCuotaAportacion.Name = "_ImporteCuotaAportacion"
        Me._ImporteCuotaAportacion.Properties.Appearance.Options.UseTextOptions = True
        Me._ImporteCuotaAportacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._ImporteCuotaAportacion.Properties.Mask.EditMask = "n2"
        Me._ImporteCuotaAportacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._ImporteCuotaAportacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._ImporteCuotaAportacion.Properties.ReadOnly = True
        Me._ImporteCuotaAportacion.Size = New System.Drawing.Size(86, 20)
        Me._ImporteCuotaAportacion.TabIndex = 9
        '
        '_FormaPago
        '
        Me._FormaPago.EnterMoveNextControl = True
        Me._FormaPago.Location = New System.Drawing.Point(138, 42)
        Me._FormaPago.Name = "_FormaPago"
        Me._FormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FormaPago.Properties.ReadOnly = True
        Me._FormaPago.Size = New System.Drawing.Size(205, 20)
        Me._FormaPago.TabIndex = 1
        '
        '_MontoAplicar
        '
        Me._MontoAplicar.EditValue = ""
        Me._MontoAplicar.EnterMoveNextControl = True
        Me._MontoAplicar.Location = New System.Drawing.Point(138, 106)
        Me._MontoAplicar.Name = "_MontoAplicar"
        Me._MontoAplicar.Properties.Appearance.Options.UseTextOptions = True
        Me._MontoAplicar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._MontoAplicar.Properties.Mask.EditMask = "n2"
        Me._MontoAplicar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._MontoAplicar.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._MontoAplicar.Properties.ReadOnly = True
        Me._MontoAplicar.Size = New System.Drawing.Size(86, 20)
        Me._MontoAplicar.TabIndex = 7
        '
        'TextEdit2
        '
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(138, 64)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(86, 20)
        Me.TextEdit2.TabIndex = 3
        '
        '_Asociado
        '
        Me._Asociado.EnterMoveNextControl = True
        Me._Asociado.Location = New System.Drawing.Point(138, 20)
        Me._Asociado.Name = "_Asociado"
        Me._Asociado.Properties.ReadOnly = True
        Me._Asociado.Size = New System.Drawing.Size(311, 20)
        Me._Asociado.TabIndex = 0
        '
        '_FechaContable
        '
        Me._FechaContable.EditValue = Nothing
        Me._FechaContable.Enabled = False
        Me._FechaContable.EnterMoveNextControl = True
        Me._FechaContable.Location = New System.Drawing.Point(496, 106)
        Me._FechaContable.Name = "_FechaContable"
        Me._FechaContable.Properties.AllowFocused = False
        Me._FechaContable.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me._FechaContable.Properties.Appearance.Options.UseBackColor = True
        Me._FechaContable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaContable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaContable.Properties.ReadOnly = True
        Me._FechaContable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaContable.Size = New System.Drawing.Size(86, 20)
        Me._FechaContable.TabIndex = 6
        '
        '_FechaPago
        '
        Me._FechaPago.EditValue = Nothing
        Me._FechaPago.EnterMoveNextControl = True
        Me._FechaPago.Location = New System.Drawing.Point(138, 85)
        Me._FechaPago.Name = "_FechaPago"
        Me._FechaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaPago.Properties.ReadOnly = True
        Me._FechaPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaPago.Size = New System.Drawing.Size(86, 20)
        Me._FechaPago.TabIndex = 5
        '
        'frmReimprimePago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 301)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btIdPrestamo)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdAplicarPago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmReimprimePago"
        Me.Text = "Re-Impresión de Comprobantes de Pago"
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.teIdMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteOtros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteCapital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteManejo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteSeguro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DeberSerMora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DeberSerInteres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._ImporteCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._MontoAplicar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Asociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btIdPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdAplicarPago As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _FechaOtorgamiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _NumeroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ImporteCuotaAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ImporteCuotaAportacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _FormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _MontoAplicar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Asociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _FechaContable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _FechaPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _DeberSerInteres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _DeberSerMora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ImporteSeguro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ImporteManejo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _ImporteOtros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _ImporteCapital As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
