<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmResolucionesCredito
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
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.teIdSolicitud = New DevExpress.XtraEditors.TextEdit
        Me.beNoSolicitud = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.rgFormaPago = New DevExpress.XtraEditors.RadioGroup
        Me.chkSeguimiento = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.leFinanciamiento = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.teDestino = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.leLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.teDetalleFormaPago = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.seFrecuencia = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.seNumCuotas = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teMontoSolicitado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btAprobacionGerencia = New DevExpress.XtraEditors.SimpleButton
        Me.btAprobacionComite = New DevExpress.XtraEditors.SimpleButton
        Me.btAprobacionConsejo = New DevExpress.XtraEditors.SimpleButton
        Me.btAprobacionAutomatica = New DevExpress.XtraEditors.SimpleButton
        Me.btListadoResoluciones = New DevExpress.XtraEditors.SimpleButton
        Me.sbSalir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaSolicitud = New DevExpress.XtraEditors.DateEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSeguimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDetalleFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumCuotas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoSolicitado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaSolicitud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.deFechaSolicitud)
        Me.GroupControl1.Controls.Add(Me.sbSalir)
        Me.GroupControl1.Controls.Add(Me.btListadoResoluciones)
        Me.GroupControl1.Controls.Add(Me.btAprobacionAutomatica)
        Me.GroupControl1.Controls.Add(Me.btAprobacionConsejo)
        Me.GroupControl1.Controls.Add(Me.btAprobacionComite)
        Me.GroupControl1.Controls.Add(Me.btAprobacionGerencia)
        Me.GroupControl1.Controls.Add(Me.rgFormaPago)
        Me.GroupControl1.Controls.Add(Me.chkSeguimiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.leFinanciamiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.leTecnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl28)
        Me.GroupControl1.Controls.Add(Me.teDestino)
        Me.GroupControl1.Controls.Add(Me.LabelControl27)
        Me.GroupControl1.Controls.Add(Me.leLinea)
        Me.GroupControl1.Controls.Add(Me.LabelControl32)
        Me.GroupControl1.Controls.Add(Me.teDetalleFormaPago)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.seFrecuencia)
        Me.GroupControl1.Controls.Add(Me.LabelControl31)
        Me.GroupControl1.Controls.Add(Me.seNumCuotas)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.teMontoSolicitado)
        Me.GroupControl1.Controls.Add(Me.LabelControl38)
        Me.GroupControl1.Controls.Add(Me.seTasa)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.teNombre)
        Me.GroupControl1.Controls.Add(Me.teIdSolicitud)
        Me.GroupControl1.Controls.Add(Me.beNoSolicitud)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Size = New System.Drawing.Size(873, 327)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Resoluciones de Crédito"
        '
        'teNombre
        '
        Me.teNombre.Location = New System.Drawing.Point(349, 31)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(319, 20)
        Me.teNombre.TabIndex = 2
        '
        'teIdSolicitud
        '
        Me.teIdSolicitud.Location = New System.Drawing.Point(277, 31)
        Me.teIdSolicitud.Name = "teIdSolicitud"
        Me.teIdSolicitud.Properties.ReadOnly = True
        Me.teIdSolicitud.Size = New System.Drawing.Size(66, 20)
        Me.teIdSolicitud.TabIndex = 1
        '
        'beNoSolicitud
        '
        Me.beNoSolicitud.EditValue = ""
        Me.beNoSolicitud.EnterMoveNextControl = True
        Me.beNoSolicitud.Location = New System.Drawing.Point(171, 31)
        Me.beNoSolicitud.Name = "beNoSolicitud"
        Me.beNoSolicitud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNoSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.beNoSolicitud.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(70, 34)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl10.TabIndex = 119
        Me.LabelControl10.Text = "Número de Solicitud:"
        '
        'rgFormaPago
        '
        Me.rgFormaPago.EditValue = 1
        Me.rgFormaPago.EnterMoveNextControl = True
        Me.rgFormaPago.Location = New System.Drawing.Point(171, 141)
        Me.rgFormaPago.Name = "rgFormaPago"
        Me.rgFormaPago.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Por Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por Día")})
        Me.rgFormaPago.Properties.ReadOnly = True
        Me.rgFormaPago.Size = New System.Drawing.Size(161, 20)
        Me.rgFormaPago.TabIndex = 150
        '
        'chkSeguimiento
        '
        Me.chkSeguimiento.EditValue = True
        Me.chkSeguimiento.EnterMoveNextControl = True
        Me.chkSeguimiento.Location = New System.Drawing.Point(169, 288)
        Me.chkSeguimiento.Name = "chkSeguimiento"
        Me.chkSeguimiento.Properties.Caption = "ESTE CRÉDITO REQUIERE SEGUIMIENTO"
        Me.chkSeguimiento.Size = New System.Drawing.Size(227, 19)
        Me.chkSeguimiento.TabIndex = 155
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(45, 143)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl11.TabIndex = 171
        Me.LabelControl11.Text = "Forma de Pago de Cuota:"
        '
        'leFinanciamiento
        '
        Me.leFinanciamiento.EnterMoveNextControl = True
        Me.leFinanciamiento.Location = New System.Drawing.Point(171, 257)
        Me.leFinanciamiento.Name = "leFinanciamiento"
        Me.leFinanciamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFinanciamiento.Properties.ReadOnly = True
        Me.leFinanciamiento.Size = New System.Drawing.Size(332, 20)
        Me.leFinanciamiento.TabIndex = 160
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(41, 259)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl6.TabIndex = 169
        Me.LabelControl6.Text = "Fuente de Financiamiento:"
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(171, 234)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Properties.ReadOnly = True
        Me.leTecnico.Size = New System.Drawing.Size(332, 20)
        Me.leTecnico.TabIndex = 158
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(17, 237)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(151, 13)
        Me.LabelControl28.TabIndex = 168
        Me.LabelControl28.Text = "Técnico o Promotor del Crédito:"
        '
        'teDestino
        '
        Me.teDestino.EnterMoveNextControl = True
        Me.teDestino.Location = New System.Drawing.Point(171, 210)
        Me.teDestino.Name = "teDestino"
        Me.teDestino.Properties.ReadOnly = True
        Me.teDestino.Size = New System.Drawing.Size(468, 20)
        Me.teDestino.TabIndex = 157
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(75, 213)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl27.TabIndex = 167
        Me.LabelControl27.Text = "Destino Económico:"
        '
        'leLinea
        '
        Me.leLinea.EnterMoveNextControl = True
        Me.leLinea.Location = New System.Drawing.Point(171, 187)
        Me.leLinea.Name = "leLinea"
        Me.leLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLinea.Properties.ReadOnly = True
        Me.leLinea.Size = New System.Drawing.Size(332, 20)
        Me.leLinea.TabIndex = 3
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(86, 190)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl32.TabIndex = 166
        Me.LabelControl32.Text = "Línea de Crédito:"
        '
        'teDetalleFormaPago
        '
        Me.teDetalleFormaPago.EnterMoveNextControl = True
        Me.teDetalleFormaPago.Location = New System.Drawing.Point(171, 164)
        Me.teDetalleFormaPago.Name = "teDetalleFormaPago"
        Me.teDetalleFormaPago.Properties.ReadOnly = True
        Me.teDetalleFormaPago.Size = New System.Drawing.Size(468, 20)
        Me.teDetalleFormaPago.TabIndex = 156
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(41, 165)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl9.TabIndex = 165
        Me.LabelControl9.Text = "Detalle de Forma de Pago:"
        '
        'seFrecuencia
        '
        Me.seFrecuencia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seFrecuencia.EnterMoveNextControl = True
        Me.seFrecuencia.Location = New System.Drawing.Point(489, 141)
        Me.seFrecuencia.Name = "seFrecuencia"
        Me.seFrecuencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seFrecuencia.Properties.Mask.EditMask = "n0"
        Me.seFrecuencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seFrecuencia.Properties.ReadOnly = True
        Me.seFrecuencia.Size = New System.Drawing.Size(64, 20)
        Me.seFrecuencia.TabIndex = 151
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(388, 144)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl31.TabIndex = 163
        Me.LabelControl31.Text = "Frecuencia de Pago:"
        '
        'seNumCuotas
        '
        Me.seNumCuotas.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumCuotas.EnterMoveNextControl = True
        Me.seNumCuotas.Location = New System.Drawing.Point(171, 118)
        Me.seNumCuotas.Name = "seNumCuotas"
        Me.seNumCuotas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seNumCuotas.Properties.Mask.EditMask = "n0"
        Me.seNumCuotas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seNumCuotas.Properties.ReadOnly = True
        Me.seNumCuotas.Size = New System.Drawing.Size(64, 20)
        Me.seNumCuotas.TabIndex = 149
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(75, 120)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl5.TabIndex = 164
        Me.LabelControl5.Text = "Número de Cuotas:"
        '
        'teMontoSolicitado
        '
        Me.teMontoSolicitado.EditValue = 0
        Me.teMontoSolicitado.EnterMoveNextControl = True
        Me.teMontoSolicitado.Location = New System.Drawing.Point(171, 75)
        Me.teMontoSolicitado.Name = "teMontoSolicitado"
        Me.teMontoSolicitado.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoSolicitado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoSolicitado.Properties.Mask.EditMask = "n2"
        Me.teMontoSolicitado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoSolicitado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoSolicitado.Properties.ReadOnly = True
        Me.teMontoSolicitado.Size = New System.Drawing.Size(101, 20)
        Me.teMontoSolicitado.TabIndex = 146
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(73, 79)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl38.TabIndex = 162
        Me.LabelControl38.Text = "Cantidad Solicitada:"
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(171, 97)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "P2"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Properties.ReadOnly = True
        Me.seTasa.Size = New System.Drawing.Size(101, 20)
        Me.seTasa.TabIndex = 147
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(58, 101)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 161
        Me.LabelControl4.Text = "Tasa de Interés Anual:"
        '
        'btAprobacionGerencia
        '
        Me.btAprobacionGerencia.Location = New System.Drawing.Point(672, 91)
        Me.btAprobacionGerencia.Name = "btAprobacionGerencia"
        Me.btAprobacionGerencia.Size = New System.Drawing.Size(189, 26)
        Me.btAprobacionGerencia.TabIndex = 4
        Me.btAprobacionGerencia.Text = "Resolución de &Gerencia"
        '
        'btAprobacionComite
        '
        Me.btAprobacionComite.Location = New System.Drawing.Point(672, 121)
        Me.btAprobacionComite.Name = "btAprobacionComite"
        Me.btAprobacionComite.Size = New System.Drawing.Size(189, 26)
        Me.btAprobacionComite.TabIndex = 5
        Me.btAprobacionComite.Text = "Resolución del &Comité de Créditos"
        '
        'btAprobacionConsejo
        '
        Me.btAprobacionConsejo.Location = New System.Drawing.Point(672, 150)
        Me.btAprobacionConsejo.Name = "btAprobacionConsejo"
        Me.btAprobacionConsejo.Size = New System.Drawing.Size(189, 26)
        Me.btAprobacionConsejo.TabIndex = 6
        Me.btAprobacionConsejo.Text = "Resolución del Conse&jo de Admón"
        '
        'btAprobacionAutomatica
        '
        Me.btAprobacionAutomatica.Location = New System.Drawing.Point(672, 180)
        Me.btAprobacionAutomatica.Name = "btAprobacionAutomatica"
        Me.btAprobacionAutomatica.Size = New System.Drawing.Size(189, 26)
        Me.btAprobacionAutomatica.TabIndex = 7
        Me.btAprobacionAutomatica.Text = "Aprobación Au&tomática"
        '
        'btListadoResoluciones
        '
        Me.btListadoResoluciones.Location = New System.Drawing.Point(672, 209)
        Me.btListadoResoluciones.Name = "btListadoResoluciones"
        Me.btListadoResoluciones.Size = New System.Drawing.Size(189, 26)
        Me.btListadoResoluciones.TabIndex = 8
        Me.btListadoResoluciones.Text = "&Listado de Resoluciones"
        '
        'sbSalir
        '
        Me.sbSalir.Location = New System.Drawing.Point(672, 239)
        Me.sbSalir.Name = "sbSalir"
        Me.sbSalir.Size = New System.Drawing.Size(189, 26)
        Me.sbSalir.TabIndex = 184
        Me.sbSalir.Text = "&Salir"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(78, 56)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl12.TabIndex = 186
        Me.LabelControl12.Text = "Fecha de Solicitud:"
        '
        'deFechaSolicitud
        '
        Me.deFechaSolicitud.EditValue = Nothing
        Me.deFechaSolicitud.EnterMoveNextControl = True
        Me.deFechaSolicitud.Location = New System.Drawing.Point(171, 53)
        Me.deFechaSolicitud.Name = "deFechaSolicitud"
        Me.deFechaSolicitud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaSolicitud.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaSolicitud.Properties.ReadOnly = True
        Me.deFechaSolicitud.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.deFechaSolicitud.TabIndex = 185
        '
        'pre_frmResolucionesCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(873, 352)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmResolucionesCredito"
        Me.Text = "Resoluciones de Crédito"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSeguimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDetalleFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seFrecuencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumCuotas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoSolicitado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaSolicitud.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdSolicitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNoSolicitud As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgFormaPago As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents chkSeguimiento As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leFinanciamiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDetalleFormaPago As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seFrecuencia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seNumCuotas As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMontoSolicitado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btAprobacionGerencia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btListadoResoluciones As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAprobacionAutomatica As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAprobacionConsejo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btAprobacionComite As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaSolicitud As DevExpress.XtraEditors.DateEdit

End Class
