<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmActualizaPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmActualizaPrestamo))
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.cmdSalir = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rgTipoAplicacion = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.teValorCuota = New DevExpress.XtraEditors.TextEdit
        Me._FechaPrimerPago = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teGestion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.leCanton = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.leFuente = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.teMontoPrestamo = New DevExpress.XtraEditors.TextEdit
        Me._FechaOtorgamiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.leLinea = New DevExpress.XtraEditors.LookUpEdit
        Me._Cliente = New DevExpress.XtraEditors.TextEdit
        Me.btAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.rgFormaPago = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.rgTipoAplicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValorCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teGestion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCanton.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFuente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Cliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Enabled = False
        Me.teIdPrestamo.EnterMoveNextControl = True
        Me.teIdPrestamo.Location = New System.Drawing.Point(432, 5)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdPrestamo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.teIdPrestamo.TabIndex = 41
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(366, 8)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl14.TabIndex = 42
        Me.LabelControl14.Text = "Correlativo:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(50, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 40
        Me.LabelControl1.Text = "Número de Préstamo:"
        '
        'btNumPrestamo
        '
        Me.btNumPrestamo.EnterMoveNextControl = True
        Me.btNumPrestamo.Location = New System.Drawing.Point(157, 5)
        Me.btNumPrestamo.Name = "btNumPrestamo"
        Me.btNumPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btNumPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.btNumPrestamo.Size = New System.Drawing.Size(114, 20)
        Me.btNumPrestamo.TabIndex = 39
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(313, 324)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(110, 23)
        Me.cmdSalir.TabIndex = 38
        Me.cmdSalir.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rgTipoAplicacion)
        Me.GroupBox1.Controls.Add(Me.LabelControl44)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.teValorCuota)
        Me.GroupBox1.Controls.Add(Me._FechaPrimerPago)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.teGestion)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.leCanton)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.leFuente)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.leTecnico)
        Me.GroupBox1.Controls.Add(Me.LabelControl38)
        Me.GroupBox1.Controls.Add(Me.teMontoPrestamo)
        Me.GroupBox1.Controls.Add(Me._FechaOtorgamiento)
        Me.GroupBox1.Controls.Add(Me.LabelControl21)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.leLinea)
        Me.GroupBox1.Controls.Add(Me._Cliente)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(545, 244)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'rgTipoAplicacion
        '
        Me.rgTipoAplicacion.EditValue = 1
        Me.rgTipoAplicacion.EnterMoveNextControl = True
        Me.rgTipoAplicacion.Location = New System.Drawing.Point(158, 209)
        Me.rgTipoAplicacion.Name = "rgTipoAplicacion"
        Me.rgTipoAplicacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Ambas Quincenas"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "1a Quincena"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "2a. Quincena")})
        Me.rgTipoAplicacion.Size = New System.Drawing.Size(340, 23)
        Me.rgTipoAplicacion.TabIndex = 161
        '
        'LabelControl44
        '
        Me.LabelControl44.Location = New System.Drawing.Point(29, 215)
        Me.LabelControl44.Name = "LabelControl44"
        Me.LabelControl44.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl44.TabIndex = 162
        Me.LabelControl44.Text = "Forma de Pago de Cuota:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(95, 189)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl6.TabIndex = 62
        Me.LabelControl6.Text = "Valor Cuota:"
        '
        'teValorCuota
        '
        Me.teValorCuota.EditValue = 0
        Me.teValorCuota.EnterMoveNextControl = True
        Me.teValorCuota.Location = New System.Drawing.Point(158, 186)
        Me.teValorCuota.Name = "teValorCuota"
        Me.teValorCuota.Properties.AllowFocused = False
        Me.teValorCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.teValorCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValorCuota.Properties.DisplayFormat.FormatString = "n2"
        Me.teValorCuota.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teValorCuota.Properties.LookAndFeel.SkinName = "McSkin"
        Me.teValorCuota.Size = New System.Drawing.Size(86, 20)
        Me.teValorCuota.TabIndex = 61
        '
        '_FechaPrimerPago
        '
        Me._FechaPrimerPago.EditValue = Nothing
        Me._FechaPrimerPago.EnterMoveNextControl = True
        Me._FechaPrimerPago.Location = New System.Drawing.Point(382, 162)
        Me._FechaPrimerPago.Name = "_FechaPrimerPago"
        Me._FechaPrimerPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaPrimerPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaPrimerPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaPrimerPago.Size = New System.Drawing.Size(87, 20)
        Me._FechaPrimerPago.TabIndex = 60
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(258, 167)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(120, 13)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Fecha Primer Descuento:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 165)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl7.TabIndex = 57
        Me.LabelControl7.Text = "Cuota Gestión Extra Judicial:"
        '
        'teGestion
        '
        Me.teGestion.EditValue = 0
        Me.teGestion.EnterMoveNextControl = True
        Me.teGestion.Location = New System.Drawing.Point(158, 162)
        Me.teGestion.Name = "teGestion"
        Me.teGestion.Properties.AllowFocused = False
        Me.teGestion.Properties.Appearance.Options.UseTextOptions = True
        Me.teGestion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teGestion.Properties.DisplayFormat.FormatString = "n2"
        Me.teGestion.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teGestion.Properties.LookAndFeel.SkinName = "McSkin"
        Me.teGestion.Size = New System.Drawing.Size(86, 20)
        Me.teGestion.TabIndex = 56
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(116, 139)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl5.TabIndex = 52
        Me.LabelControl5.Text = "Canton:"
        '
        'leCanton
        '
        Me.leCanton.EnterMoveNextControl = True
        Me.leCanton.Location = New System.Drawing.Point(158, 136)
        Me.leCanton.Name = "leCanton"
        Me.leCanton.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCanton.Size = New System.Drawing.Size(311, 20)
        Me.leCanton.TabIndex = 51
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(115, 116)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl4.TabIndex = 50
        Me.LabelControl4.Text = "Fuente:"
        '
        'leFuente
        '
        Me.leFuente.EnterMoveNextControl = True
        Me.leFuente.Location = New System.Drawing.Point(158, 113)
        Me.leFuente.Name = "leFuente"
        Me.leFuente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFuente.Size = New System.Drawing.Size(311, 20)
        Me.leFuente.TabIndex = 49
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(115, 93)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl8.TabIndex = 48
        Me.LabelControl8.Text = "Tecnico:"
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(158, 90)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Size = New System.Drawing.Size(311, 20)
        Me.leTecnico.TabIndex = 47
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(56, 47)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl38.TabIndex = 30
        Me.LabelControl38.Text = "Monto del Préstamo:"
        '
        'teMontoPrestamo
        '
        Me.teMontoPrestamo.EditValue = 0
        Me.teMontoPrestamo.EnterMoveNextControl = True
        Me.teMontoPrestamo.Location = New System.Drawing.Point(158, 44)
        Me.teMontoPrestamo.Name = "teMontoPrestamo"
        Me.teMontoPrestamo.Properties.AllowFocused = False
        Me.teMontoPrestamo.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoPrestamo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoPrestamo.Properties.DisplayFormat.FormatString = "n2"
        Me.teMontoPrestamo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.teMontoPrestamo.Properties.LookAndFeel.SkinName = "McSkin"
        Me.teMontoPrestamo.Properties.ReadOnly = True
        Me.teMontoPrestamo.Size = New System.Drawing.Size(86, 20)
        Me.teMontoPrestamo.TabIndex = 13
        '
        '_FechaOtorgamiento
        '
        Me._FechaOtorgamiento.EditValue = Nothing
        Me._FechaOtorgamiento.EnterMoveNextControl = True
        Me._FechaOtorgamiento.Location = New System.Drawing.Point(383, 44)
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
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(278, 49)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl21.TabIndex = 32
        Me.LabelControl21.Text = "Fecha Otrogamiento:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(63, 71)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Linea de Préstamo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(90, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "A nombre de:"
        '
        'leLinea
        '
        Me.leLinea.EnterMoveNextControl = True
        Me.leLinea.Location = New System.Drawing.Point(158, 68)
        Me.leLinea.Name = "leLinea"
        Me.leLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLinea.Size = New System.Drawing.Size(311, 20)
        Me.leLinea.TabIndex = 1
        '
        '_Cliente
        '
        Me._Cliente.EnterMoveNextControl = True
        Me._Cliente.Location = New System.Drawing.Point(158, 20)
        Me._Cliente.Name = "_Cliente"
        Me._Cliente.Properties.ReadOnly = True
        Me._Cliente.Size = New System.Drawing.Size(311, 20)
        Me._Cliente.TabIndex = 0
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(172, 324)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(120, 23)
        Me.btAceptar.TabIndex = 43
        Me.btAceptar.Text = "Aceptar"
        '
        'rgFormaPago
        '
        Me.rgFormaPago.EditValue = 1
        Me.rgFormaPago.EnterMoveNextControl = True
        Me.rgFormaPago.Location = New System.Drawing.Point(177, 278)
        Me.rgFormaPago.Name = "rgFormaPago"
        Me.rgFormaPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quincenal")})
        Me.rgFormaPago.Size = New System.Drawing.Size(161, 23)
        Me.rgFormaPago.TabIndex = 164
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(48, 284)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl11.TabIndex = 165
        Me.LabelControl11.Text = "Forma de Pago de Cuota:"
        '
        'pre_frmActualizaPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 384)
        Me.Controls.Add(Me.rgFormaPago)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.btAceptar)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btNumPrestamo)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmActualizaPrestamo"
        Me.OptionId = "003005"
        Me.Text = "Actualizar Datos de Préstamos"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmdSalir, 0)
        Me.Controls.SetChildIndex(Me.btNumPrestamo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl14, 0)
        Me.Controls.SetChildIndex(Me.teIdPrestamo, 0)
        Me.Controls.SetChildIndex(Me.btAceptar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.rgFormaPago, 0)
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.rgTipoAplicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValorCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teGestion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCanton.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFuente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Cliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btNumPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents cmdSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _FechaOtorgamiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _Cliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teMontoPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leCanton As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leFuente As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teGestion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _FechaPrimerPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rgFormaPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teValorCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rgTipoAplicacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
End Class
