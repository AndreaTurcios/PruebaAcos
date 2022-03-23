<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmCalculoCuotas
    Inherits Bravio.gen_frmBaseRpt

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
        Me.teMonto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.seNumCuotas = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.teCuotaAportacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teTasaManejo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.teCuotaAhorro = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.ceIncluirSeguro = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.rgFormaPago = New DevExpress.XtraEditors.RadioGroup
        Me.seFrecuencia = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.sbCalculadora = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.rgTipoCuota = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaPrimerPago = New DevExpress.XtraEditors.DateEdit
        Me.chkSinCentavos = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTasaManejo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluirSeguro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSinCentavos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.chkSinCentavos)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.deFechaPrimerPago)
        Me.GroupControl1.Controls.Add(Me.sbCalculadora)
        Me.GroupControl1.Controls.Add(Me.rgTipoCuota)
        Me.GroupControl1.Controls.Add(Me.rgFormaPago)
        Me.GroupControl1.Controls.Add(Me.seFrecuencia)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl31)
        Me.GroupControl1.Controls.Add(Me.LabelControl32)
        Me.GroupControl1.Controls.Add(Me.ceIncluirSeguro)
        Me.GroupControl1.Controls.Add(Me.teNombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.teCuotaAhorro)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.teTasaManejo)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.teCuotaAportacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.seNumCuotas)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.seTasa)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.teMonto)
        Me.GroupControl1.Controls.Add(Me.LabelControl38)
        Me.GroupControl1.Size = New System.Drawing.Size(668, 367)
        '
        'teMonto
        '
        Me.teMonto.EditValue = 0
        Me.teMonto.EnterMoveNextControl = True
        Me.teMonto.Location = New System.Drawing.Point(186, 30)
        Me.teMonto.Name = "teMonto"
        Me.teMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.teMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMonto.Properties.Mask.EditMask = "n2"
        Me.teMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMonto.Size = New System.Drawing.Size(101, 20)
        Me.teMonto.TabIndex = 0
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(100, 33)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl38.TabIndex = 69
        Me.LabelControl38.Text = "Monto Otorgado:"
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(186, 52)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "P2"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Size = New System.Drawing.Size(68, 20)
        Me.seTasa.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(73, 55)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = "Tasa de Interés Anual:"
        '
        'seNumCuotas
        '
        Me.seNumCuotas.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seNumCuotas.EnterMoveNextControl = True
        Me.seNumCuotas.Location = New System.Drawing.Point(186, 74)
        Me.seNumCuotas.Name = "seNumCuotas"
        Me.seNumCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seNumCuotas.Size = New System.Drawing.Size(68, 20)
        Me.seNumCuotas.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(90, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl5.TabIndex = 80
        Me.LabelControl5.Text = "Número de Cuotas:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(107, 171)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 86
        Me.LabelControl11.Text = "Fecha de Inicio:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(186, 168)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 6
        '
        'teCuotaAportacion
        '
        Me.teCuotaAportacion.EditValue = 0
        Me.teCuotaAportacion.EnterMoveNextControl = True
        Me.teCuotaAportacion.Location = New System.Drawing.Point(186, 213)
        Me.teCuotaAportacion.Name = "teCuotaAportacion"
        Me.teCuotaAportacion.Properties.Appearance.Options.UseTextOptions = True
        Me.teCuotaAportacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCuotaAportacion.Properties.Mask.EditMask = "n2"
        Me.teCuotaAportacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCuotaAportacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCuotaAportacion.Size = New System.Drawing.Size(101, 20)
        Me.teCuotaAportacion.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(95, 216)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl3.TabIndex = 88
        Me.LabelControl3.Text = "Cuota Aportación:"
        '
        'teTasaManejo
        '
        Me.teTasaManejo.EditValue = 0
        Me.teTasaManejo.EnterMoveNextControl = True
        Me.teTasaManejo.Location = New System.Drawing.Point(186, 235)
        Me.teTasaManejo.Name = "teTasaManejo"
        Me.teTasaManejo.Properties.Appearance.Options.UseTextOptions = True
        Me.teTasaManejo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teTasaManejo.Properties.Mask.EditMask = "n2"
        Me.teTasaManejo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teTasaManejo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teTasaManejo.Size = New System.Drawing.Size(101, 20)
        Me.teTasaManejo.TabIndex = 9
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(97, 239)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl6.TabIndex = 90
        Me.LabelControl6.Text = "Cuota de Manejo:"
        '
        'teCuotaAhorro
        '
        Me.teCuotaAhorro.EditValue = 0
        Me.teCuotaAhorro.EnterMoveNextControl = True
        Me.teCuotaAhorro.Location = New System.Drawing.Point(186, 256)
        Me.teCuotaAhorro.Name = "teCuotaAhorro"
        Me.teCuotaAhorro.Properties.Appearance.Options.UseTextOptions = True
        Me.teCuotaAhorro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCuotaAhorro.Properties.Mask.EditMask = "n2"
        Me.teCuotaAhorro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCuotaAhorro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCuotaAhorro.Size = New System.Drawing.Size(101, 20)
        Me.teCuotaAhorro.TabIndex = 10
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(99, 259)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl7.TabIndex = 92
        Me.LabelControl7.Text = "Cuora de Ahorro:"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(186, 279)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(468, 20)
        Me.teNombre.TabIndex = 11
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(79, 283)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl9.TabIndex = 96
        Me.LabelControl9.Text = "Nombre del Asociado:"
        '
        'ceIncluirSeguro
        '
        Me.ceIncluirSeguro.EditValue = True
        Me.ceIncluirSeguro.EnterMoveNextControl = True
        Me.ceIncluirSeguro.Location = New System.Drawing.Point(183, 323)
        Me.ceIncluirSeguro.Name = "ceIncluirSeguro"
        Me.ceIncluirSeguro.Properties.Caption = "Incluir Seguro de Deuda"
        Me.ceIncluirSeguro.Size = New System.Drawing.Size(147, 19)
        Me.ceIncluirSeguro.TabIndex = 11
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(75, 100)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl32.TabIndex = 122
        Me.LabelControl32.Text = "Forma de Pago Cuota:"
        '
        'rgFormaPago
        '
        Me.rgFormaPago.EditValue = 1
        Me.rgFormaPago.EnterMoveNextControl = True
        Me.rgFormaPago.Location = New System.Drawing.Point(186, 96)
        Me.rgFormaPago.Name = "rgFormaPago"
        Me.rgFormaPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quincenal")})
        Me.rgFormaPago.Size = New System.Drawing.Size(161, 23)
        Me.rgFormaPago.TabIndex = 3
        '
        'seFrecuencia
        '
        Me.seFrecuencia.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.seFrecuencia.EnterMoveNextControl = True
        Me.seFrecuencia.Location = New System.Drawing.Point(186, 121)
        Me.seFrecuencia.Name = "seFrecuencia"
        Me.seFrecuencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seFrecuencia.Properties.Mask.EditMask = "n0"
        Me.seFrecuencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seFrecuencia.Size = New System.Drawing.Size(64, 20)
        Me.seFrecuencia.TabIndex = 4
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(85, 125)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl31.TabIndex = 125
        Me.LabelControl31.Text = "Frecuencia de Pago:"
        '
        'sbCalculadora
        '
        Me.sbCalculadora.Image = Global.Bravio.My.Resources.Resources.accessories_calculator_3
        Me.sbCalculadora.Location = New System.Drawing.Point(307, 25)
        Me.sbCalculadora.Name = "sbCalculadora"
        Me.sbCalculadora.Size = New System.Drawing.Size(40, 40)
        Me.sbCalculadora.TabIndex = 126
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(112, 148)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl1.TabIndex = 122
        Me.LabelControl1.Text = "Tipo de Cuota:"
        '
        'rgTipoCuota
        '
        Me.rgTipoCuota.EditValue = 1
        Me.rgTipoCuota.EnterMoveNextControl = True
        Me.rgTipoCuota.Location = New System.Drawing.Point(186, 143)
        Me.rgTipoCuota.Name = "rgTipoCuota"
        Me.rgTipoCuota.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Cuota Total Fija"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Cuota por Período"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Capitalizable")})
        Me.rgTipoCuota.Size = New System.Drawing.Size(362, 23)
        Me.rgTipoCuota.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(90, 193)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl2.TabIndex = 128
        Me.LabelControl2.Text = "Fecha Primer Pago:"
        '
        'deFechaPrimerPago
        '
        Me.deFechaPrimerPago.EditValue = Nothing
        Me.deFechaPrimerPago.EnterMoveNextControl = True
        Me.deFechaPrimerPago.Location = New System.Drawing.Point(186, 190)
        Me.deFechaPrimerPago.Name = "deFechaPrimerPago"
        Me.deFechaPrimerPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaPrimerPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaPrimerPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaPrimerPago.Size = New System.Drawing.Size(100, 20)
        Me.deFechaPrimerPago.TabIndex = 7
        '
        'chkSinCentavos
        '
        Me.chkSinCentavos.Location = New System.Drawing.Point(184, 301)
        Me.chkSinCentavos.Name = "chkSinCentavos"
        Me.chkSinCentavos.Properties.Caption = "Cuota sin Centavos"
        Me.chkSinCentavos.Size = New System.Drawing.Size(124, 19)
        Me.chkSinCentavos.TabIndex = 201
        '
        'pre_frmCalculoCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(668, 392)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmCalculoCuotas"
        Me.Text = "Calculo de Tabla de Amortización de Préstamos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTasaManejo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluirSeguro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSinCentavos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seNumCuotas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teCuotaAportacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCuotaAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTasaManejo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceIncluirSeguro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgFormaPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents seFrecuencia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbCalculadora As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgTipoCuota As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaPrimerPago As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkSinCentavos As DevExpress.XtraEditors.CheckEdit

End Class
