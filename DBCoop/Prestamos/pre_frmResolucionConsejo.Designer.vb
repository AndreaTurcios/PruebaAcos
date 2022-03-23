<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmResolucionConsejo
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmResolucionConsejo))
        Me.cboEstado = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.meResolucion = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.meRecomendaciones = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.meOtrasCondiciones = New DevExpress.XtraEditors.MemoEdit
        Me.teMonto = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.seNumeroCuotas = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.rgFormaPago = New DevExpress.XtraEditors.RadioGroup
        Me.seFrecuencia = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.teTipoTramite = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teCuotaAportacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teCuotaManejo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.teCuotaAhorro = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.chkIncluirSeguro = New DevExpress.XtraEditors.CheckEdit
        Me.seMesesGracia = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.teValorCuota = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
        Me.cboLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.sbSalir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teActa = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaPrimerPago = New DevExpress.XtraEditors.DateEdit
        CType(Me.cboEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meResolucion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meRecomendaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meOtrasCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMonto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumeroCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTipoTramite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuotaManejo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluirSeguro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seMesesGracia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValorCuota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teActa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEstado
        '
        Me.cboEstado.EnterMoveNextControl = True
        Me.cboEstado.Location = New System.Drawing.Point(144, 230)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEstado.Size = New System.Drawing.Size(182, 20)
        Me.cboEstado.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(62, 234)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Tipo Resolución:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(107, 257)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Fecha:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(144, 255)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(89, 20)
        Me.deFecha.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(24, 100)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 13)
        Me.LabelControl3.TabIndex = 137
        Me.LabelControl3.Text = "Resolución del Consejo:"
        '
        'meResolucion
        '
        Me.meResolucion.EnterMoveNextControl = True
        Me.meResolucion.Location = New System.Drawing.Point(144, 98)
        Me.meResolucion.Name = "meResolucion"
        Me.meResolucion.Size = New System.Drawing.Size(470, 41)
        Me.meResolucion.TabIndex = 3
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(48, 30)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl42.TabIndex = 133
        Me.LabelControl42.Text = "Recomendaciones:"
        '
        'meRecomendaciones
        '
        Me.meRecomendaciones.EnterMoveNextControl = True
        Me.meRecomendaciones.Location = New System.Drawing.Point(144, 28)
        Me.meRecomendaciones.Name = "meRecomendaciones"
        Me.meRecomendaciones.Size = New System.Drawing.Size(470, 40)
        Me.meRecomendaciones.TabIndex = 1
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(15, 144)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(251, 13)
        Me.LabelControl6.TabIndex = 133
        Me.LabelControl6.Text = "Otras Condiciones que Complementan la Resolución:"
        '
        'meOtrasCondiciones
        '
        Me.meOtrasCondiciones.EnterMoveNextControl = True
        Me.meOtrasCondiciones.Location = New System.Drawing.Point(144, 163)
        Me.meOtrasCondiciones.Name = "meOtrasCondiciones"
        Me.meOtrasCondiciones.Size = New System.Drawing.Size(470, 57)
        Me.meOtrasCondiciones.TabIndex = 4
        '
        'teMonto
        '
        Me.teMonto.EditValue = 0
        Me.teMonto.EnterMoveNextControl = True
        Me.teMonto.Location = New System.Drawing.Point(144, 281)
        Me.teMonto.Name = "teMonto"
        Me.teMonto.Properties.Appearance.Options.UseTextOptions = True
        Me.teMonto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMonto.Properties.Mask.EditMask = "n2"
        Me.teMonto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMonto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMonto.Size = New System.Drawing.Size(91, 20)
        Me.teMonto.TabIndex = 7
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(106, 285)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl38.TabIndex = 145
        Me.LabelControl38.Text = "Monto:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(249, 336)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl8.TabIndex = 151
        Me.LabelControl8.Text = "Forma de Pago:"
        '
        'seNumeroCuotas
        '
        Me.seNumeroCuotas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumeroCuotas.EnterMoveNextControl = True
        Me.seNumeroCuotas.Location = New System.Drawing.Point(144, 333)
        Me.seNumeroCuotas.Name = "seNumeroCuotas"
        Me.seNumeroCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seNumeroCuotas.Properties.Mask.EditMask = "f0"
        Me.seNumeroCuotas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seNumeroCuotas.Size = New System.Drawing.Size(64, 20)
        Me.seNumeroCuotas.TabIndex = 13
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(47, 337)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl9.TabIndex = 150
        Me.LabelControl9.Text = "Número de Cuotas:"
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(328, 281)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "P2"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Size = New System.Drawing.Size(70, 20)
        Me.seTasa.TabIndex = 8
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(245, 285)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl10.TabIndex = 149
        Me.LabelControl10.Text = "Tasa de Interés:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(429, 404)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(97, 29)
        Me.sbGuardar.TabIndex = 19
        Me.sbGuardar.Text = "&Guardar"
        '
        'rgFormaPago
        '
        Me.rgFormaPago.EditValue = 1
        Me.rgFormaPago.EnterMoveNextControl = True
        Me.rgFormaPago.Location = New System.Drawing.Point(328, 333)
        Me.rgFormaPago.Name = "rgFormaPago"
        Me.rgFormaPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Quincenal")})
        Me.rgFormaPago.Size = New System.Drawing.Size(161, 20)
        Me.rgFormaPago.TabIndex = 14
        '
        'seFrecuencia
        '
        Me.seFrecuencia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seFrecuencia.EnterMoveNextControl = True
        Me.seFrecuencia.Location = New System.Drawing.Point(144, 359)
        Me.seFrecuencia.Name = "seFrecuencia"
        Me.seFrecuencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seFrecuencia.Properties.Mask.EditMask = "n0"
        Me.seFrecuencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seFrecuencia.Size = New System.Drawing.Size(64, 20)
        Me.seFrecuencia.TabIndex = 15
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(42, 362)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl31.TabIndex = 155
        Me.LabelControl31.Text = "Frecuencia de Pago:"
        '
        'teTipoTramite
        '
        Me.teTipoTramite.EnterMoveNextControl = True
        Me.teTipoTramite.Location = New System.Drawing.Point(144, 72)
        Me.teTipoTramite.Name = "teTipoTramite"
        Me.teTipoTramite.Size = New System.Drawing.Size(470, 20)
        Me.teTipoTramite.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(60, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl1.TabIndex = 180
        Me.LabelControl1.Text = "Tipo de Tramite:"
        '
        'teCuotaAportacion
        '
        Me.teCuotaAportacion.EditValue = 0
        Me.teCuotaAportacion.EnterMoveNextControl = True
        Me.teCuotaAportacion.Location = New System.Drawing.Point(529, 281)
        Me.teCuotaAportacion.Name = "teCuotaAportacion"
        Me.teCuotaAportacion.Properties.Appearance.Options.UseTextOptions = True
        Me.teCuotaAportacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCuotaAportacion.Properties.Mask.EditMask = "n2"
        Me.teCuotaAportacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCuotaAportacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCuotaAportacion.Size = New System.Drawing.Size(81, 20)
        Me.teCuotaAportacion.TabIndex = 9
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(438, 285)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl7.TabIndex = 182
        Me.LabelControl7.Text = "Cuota Aportación:"
        '
        'teCuotaManejo
        '
        Me.teCuotaManejo.EditValue = 0
        Me.teCuotaManejo.EnterMoveNextControl = True
        Me.teCuotaManejo.Location = New System.Drawing.Point(144, 307)
        Me.teCuotaManejo.Name = "teCuotaManejo"
        Me.teCuotaManejo.Properties.Appearance.Options.UseTextOptions = True
        Me.teCuotaManejo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCuotaManejo.Properties.Mask.EditMask = "n2"
        Me.teCuotaManejo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCuotaManejo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCuotaManejo.Size = New System.Drawing.Size(91, 20)
        Me.teCuotaManejo.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(69, 311)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl4.TabIndex = 184
        Me.LabelControl4.Text = "Cuota Manejo:"
        '
        'teCuotaAhorro
        '
        Me.teCuotaAhorro.EditValue = 0
        Me.teCuotaAhorro.EnterMoveNextControl = True
        Me.teCuotaAhorro.Location = New System.Drawing.Point(328, 308)
        Me.teCuotaAhorro.Name = "teCuotaAhorro"
        Me.teCuotaAhorro.Properties.Appearance.Options.UseTextOptions = True
        Me.teCuotaAhorro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teCuotaAhorro.Properties.Mask.EditMask = "n2"
        Me.teCuotaAhorro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teCuotaAhorro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teCuotaAhorro.Size = New System.Drawing.Size(83, 20)
        Me.teCuotaAhorro.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(256, 311)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 186
        Me.LabelControl5.Text = "Cuota Ahorro:"
        '
        'chkIncluirSeguro
        '
        Me.chkIncluirSeguro.EditValue = True
        Me.chkIncluirSeguro.EnterMoveNextControl = True
        Me.chkIncluirSeguro.Location = New System.Drawing.Point(476, 310)
        Me.chkIncluirSeguro.Name = "chkIncluirSeguro"
        Me.chkIncluirSeguro.Properties.Caption = "Incluir Seguro de Deuda"
        Me.chkIncluirSeguro.Size = New System.Drawing.Size(137, 19)
        Me.chkIncluirSeguro.TabIndex = 12
        '
        'seMesesGracia
        '
        Me.seMesesGracia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seMesesGracia.EnterMoveNextControl = True
        Me.seMesesGracia.Location = New System.Drawing.Point(328, 359)
        Me.seMesesGracia.Name = "seMesesGracia"
        Me.seMesesGracia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seMesesGracia.Properties.Mask.EditMask = "n0"
        Me.seMesesGracia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seMesesGracia.Size = New System.Drawing.Size(64, 20)
        Me.seMesesGracia.TabIndex = 16
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(237, 362)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl13.TabIndex = 189
        Me.LabelControl13.Text = "Periodo de Gracia:"
        '
        'teValorCuota
        '
        Me.teValorCuota.EditValue = 0
        Me.teValorCuota.EnterMoveNextControl = True
        Me.teValorCuota.Location = New System.Drawing.Point(144, 383)
        Me.teValorCuota.Name = "teValorCuota"
        Me.teValorCuota.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.teValorCuota.Properties.Appearance.Options.UseFont = True
        Me.teValorCuota.Properties.Appearance.Options.UseTextOptions = True
        Me.teValorCuota.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValorCuota.Properties.Mask.EditMask = "n2"
        Me.teValorCuota.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValorCuota.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValorCuota.Size = New System.Drawing.Size(101, 21)
        Me.teValorCuota.TabIndex = 17
        '
        'LabelControl45
        '
        Me.LabelControl45.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl45.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl45.Location = New System.Drawing.Point(64, 386)
        Me.LabelControl45.Name = "LabelControl45"
        Me.LabelControl45.Size = New System.Drawing.Size(76, 14)
        Me.LabelControl45.TabIndex = 191
        Me.LabelControl45.Text = "Valor Cuota:"
        '
        'cboLinea
        '
        Me.cboLinea.EnterMoveNextControl = True
        Me.cboLinea.Location = New System.Drawing.Point(144, 409)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLinea.Size = New System.Drawing.Size(247, 20)
        Me.cboLinea.TabIndex = 18
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(58, 413)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl32.TabIndex = 193
        Me.LabelControl32.Text = "Línea de Crédito:"
        '
        'sbSalir
        '
        Me.sbSalir.Location = New System.Drawing.Point(532, 404)
        Me.sbSalir.Name = "sbSalir"
        Me.sbSalir.Size = New System.Drawing.Size(97, 29)
        Me.sbSalir.TabIndex = 20
        Me.sbSalir.Text = "&Salir"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(57, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl2.TabIndex = 196
        Me.LabelControl2.Text = "Numero de Acta:"
        '
        'teActa
        '
        Me.teActa.Enabled = False
        Me.teActa.EnterMoveNextControl = True
        Me.teActa.Location = New System.Drawing.Point(144, 4)
        Me.teActa.Name = "teActa"
        Me.teActa.Size = New System.Drawing.Size(92, 20)
        Me.teActa.TabIndex = 0
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(437, 262)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl14.TabIndex = 197
        Me.LabelControl14.Text = "Fecha Prime Pago:"
        '
        'deFechaPrimerPago
        '
        Me.deFechaPrimerPago.EditValue = Nothing
        Me.deFechaPrimerPago.Location = New System.Drawing.Point(529, 259)
        Me.deFechaPrimerPago.Name = "deFechaPrimerPago"
        Me.deFechaPrimerPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaPrimerPago.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaPrimerPago.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaPrimerPago.Size = New System.Drawing.Size(81, 20)
        Me.deFechaPrimerPago.TabIndex = 198
        '
        'pre_frmResolucionConsejo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 445)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.deFechaPrimerPago)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teActa)
        Me.Controls.Add(Me.sbSalir)
        Me.Controls.Add(Me.cboLinea)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.teValorCuota)
        Me.Controls.Add(Me.LabelControl45)
        Me.Controls.Add(Me.seMesesGracia)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.chkIncluirSeguro)
        Me.Controls.Add(Me.teCuotaAhorro)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teCuotaManejo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.teCuotaAportacion)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teTipoTramite)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.rgFormaPago)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.meResolucion)
        Me.Controls.Add(Me.meOtrasCondiciones)
        Me.Controls.Add(Me.seFrecuencia)
        Me.Controls.Add(Me.LabelControl42)
        Me.Controls.Add(Me.meRecomendaciones)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.seNumeroCuotas)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.seTasa)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.teMonto)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.LabelControl11)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmResolucionConsejo"
        Me.Text = "Recomendación y Resolucion del  Consejo de Administración"
        CType(Me.cboEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meResolucion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meRecomendaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meOtrasCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMonto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumeroCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTipoTramite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuotaAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuotaManejo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCuotaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluirSeguro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seMesesGracia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValorCuota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teActa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimerPago.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaPrimerPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboEstado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meRecomendaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meResolucion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meOtrasCondiciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents teMonto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seNumeroCuotas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgFormaPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents seFrecuencia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTipoTramite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCuotaAportacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCuotaManejo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCuotaAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIncluirSeguro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents seMesesGracia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teValorCuota As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teActa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaPrimerPago As DevExpress.XtraEditors.DateEdit
End Class
