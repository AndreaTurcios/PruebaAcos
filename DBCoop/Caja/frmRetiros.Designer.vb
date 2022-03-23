<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetiros
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
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me._TipoDocPtdo = New DevExpress.XtraEditors.LookUpEdit
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me._PersonaAutorizada = New DevExpress.XtraEditors.LookUpEdit
        Me.leFormaPago = New DevExpress.XtraEditors.LookUpEdit
        Me._NroCtaAhorro = New DevExpress.XtraEditors.ButtonEdit
        Me._fecRetiro = New DevExpress.XtraEditors.DateEdit
        Me._DocIdentidad = New DevExpress.XtraEditors.TextEdit
        Me._NroDocumento = New DevExpress.XtraEditors.TextEdit
        Me._Monto = New DevExpress.XtraEditors.TextEdit
        Me._LineaLibreta = New DevExpress.XtraEditors.TextEdit
        Me._saldoDisponible = New DevExpress.XtraEditors.TextEdit
        Me._Saldo = New DevExpress.XtraEditors.TextEdit
        Me._FecUltMov = New DevExpress.XtraEditors.TextEdit
        Me._NombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.teNumeroDoc = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.sbVer = New DevExpress.XtraEditors.SimpleButton
        Me.sbVerFotografia = New DevExpress.XtraEditors.SimpleButton
        Me.sbVerFirma = New DevExpress.XtraEditors.SimpleButton
        Me.teSaldoDeudasFiador = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoDisponible = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoDeudas = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoAportaciones = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoAhorros = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        CType(Me._TipoDocPtdo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._PersonaAutorizada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroCtaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._fecRetiro.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._fecRetiro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._DocIdentidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroDocumento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._saldoDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FecUltMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoDeudasFiador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoDeudas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoAportaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoAhorros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(336, 23)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl15.TabIndex = 5
        Me.LabelControl15.Text = "Id de la Cuenta:"
        '
        '_TipoDocPtdo
        '
        Me._TipoDocPtdo.EnterMoveNextControl = True
        Me._TipoDocPtdo.Location = New System.Drawing.Point(190, 253)
        Me._TipoDocPtdo.Name = "_TipoDocPtdo"
        Me._TipoDocPtdo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._TipoDocPtdo.Properties.ReadOnly = True
        Me._TipoDocPtdo.Size = New System.Drawing.Size(325, 20)
        Me._TipoDocPtdo.TabIndex = 11
        '
        'teIdCuenta
        '
        Me.teIdCuenta.Enabled = False
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(415, 20)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdCuenta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 1
        '
        '_PersonaAutorizada
        '
        Me._PersonaAutorizada.EnterMoveNextControl = True
        Me._PersonaAutorizada.Location = New System.Drawing.Point(190, 293)
        Me._PersonaAutorizada.Name = "_PersonaAutorizada"
        Me._PersonaAutorizada.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._PersonaAutorizada.Size = New System.Drawing.Size(325, 20)
        Me._PersonaAutorizada.TabIndex = 13
        '
        'leFormaPago
        '
        Me.leFormaPago.EnterMoveNextControl = True
        Me.leFormaPago.Location = New System.Drawing.Point(190, 126)
        Me.leFormaPago.Name = "leFormaPago"
        Me.leFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFormaPago.Size = New System.Drawing.Size(324, 20)
        Me.leFormaPago.TabIndex = 6
        '
        '_NroCtaAhorro
        '
        Me._NroCtaAhorro.EditValue = ""
        Me._NroCtaAhorro.EnterMoveNextControl = True
        Me._NroCtaAhorro.Location = New System.Drawing.Point(190, 20)
        Me._NroCtaAhorro.Name = "_NroCtaAhorro"
        Me._NroCtaAhorro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._NroCtaAhorro.Size = New System.Drawing.Size(100, 20)
        Me._NroCtaAhorro.TabIndex = 0
        '
        '_fecRetiro
        '
        Me._fecRetiro.EditValue = Nothing
        Me._fecRetiro.EnterMoveNextControl = True
        Me._fecRetiro.Location = New System.Drawing.Point(190, 174)
        Me._fecRetiro.Name = "_fecRetiro"
        Me._fecRetiro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._fecRetiro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._fecRetiro.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._fecRetiro.Size = New System.Drawing.Size(100, 20)
        Me._fecRetiro.TabIndex = 8
        '
        '_DocIdentidad
        '
        Me._DocIdentidad.EnterMoveNextControl = True
        Me._DocIdentidad.Location = New System.Drawing.Point(190, 314)
        Me._DocIdentidad.Name = "_DocIdentidad"
        Me._DocIdentidad.Size = New System.Drawing.Size(100, 20)
        Me._DocIdentidad.TabIndex = 14
        '
        '_NroDocumento
        '
        Me._NroDocumento.EnterMoveNextControl = True
        Me._NroDocumento.Location = New System.Drawing.Point(190, 274)
        Me._NroDocumento.Name = "_NroDocumento"
        Me._NroDocumento.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._NroDocumento.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._NroDocumento.Properties.ReadOnly = True
        Me._NroDocumento.Size = New System.Drawing.Size(100, 20)
        Me._NroDocumento.TabIndex = 12
        '
        '_Monto
        '
        Me._Monto.EditValue = 0
        Me._Monto.EnterMoveNextControl = True
        Me._Monto.Location = New System.Drawing.Point(190, 197)
        Me._Monto.Name = "_Monto"
        Me._Monto.Properties.Appearance.Options.UseTextOptions = True
        Me._Monto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Monto.Properties.Mask.EditMask = "n2"
        Me._Monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Monto.Size = New System.Drawing.Size(100, 20)
        Me._Monto.TabIndex = 9
        '
        '_LineaLibreta
        '
        Me._LineaLibreta.EnterMoveNextControl = True
        Me._LineaLibreta.Location = New System.Drawing.Point(190, 232)
        Me._LineaLibreta.Name = "_LineaLibreta"
        Me._LineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._LineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._LineaLibreta.Size = New System.Drawing.Size(100, 20)
        Me._LineaLibreta.TabIndex = 10
        '
        '_saldoDisponible
        '
        Me._saldoDisponible.EditValue = 0
        Me._saldoDisponible.EnterMoveNextControl = True
        Me._saldoDisponible.Location = New System.Drawing.Point(415, 77)
        Me._saldoDisponible.Name = "_saldoDisponible"
        Me._saldoDisponible.Properties.Appearance.Options.UseTextOptions = True
        Me._saldoDisponible.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._saldoDisponible.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._saldoDisponible.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._saldoDisponible.Properties.Mask.EditMask = "c2"
        Me._saldoDisponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._saldoDisponible.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._saldoDisponible.Properties.ReadOnly = True
        Me._saldoDisponible.Size = New System.Drawing.Size(100, 20)
        Me._saldoDisponible.TabIndex = 4
        '
        '_Saldo
        '
        Me._Saldo.EditValue = 0
        Me._Saldo.Enabled = False
        Me._Saldo.EnterMoveNextControl = True
        Me._Saldo.Location = New System.Drawing.Point(190, 100)
        Me._Saldo.Name = "_Saldo"
        Me._Saldo.Properties.Appearance.Options.UseTextOptions = True
        Me._Saldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Saldo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._Saldo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._Saldo.Properties.Mask.EditMask = "n2"
        Me._Saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Saldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Saldo.Properties.ReadOnly = True
        Me._Saldo.Size = New System.Drawing.Size(100, 20)
        Me._Saldo.TabIndex = 5
        '
        '_FecUltMov
        '
        Me._FecUltMov.Enabled = False
        Me._FecUltMov.EnterMoveNextControl = True
        Me._FecUltMov.Location = New System.Drawing.Point(190, 76)
        Me._FecUltMov.Name = "_FecUltMov"
        Me._FecUltMov.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._FecUltMov.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._FecUltMov.Properties.ReadOnly = True
        Me._FecUltMov.Size = New System.Drawing.Size(100, 20)
        Me._FecUltMov.TabIndex = 3
        '
        '_NombreCliente
        '
        Me._NombreCliente.Enabled = False
        Me._NombreCliente.EnterMoveNextControl = True
        Me._NombreCliente.Location = New System.Drawing.Point(190, 55)
        Me._NombreCliente.Name = "_NombreCliente"
        Me._NombreCliente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._NombreCliente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._NombreCliente.Size = New System.Drawing.Size(324, 20)
        Me._NombreCliente.TabIndex = 2
        '
        'teNumeroDoc
        '
        Me.teNumeroDoc.EnterMoveNextControl = True
        Me.teNumeroDoc.Location = New System.Drawing.Point(190, 152)
        Me.teNumeroDoc.Name = "teNumeroDoc"
        Me.teNumeroDoc.Properties.ReadOnly = True
        Me.teNumeroDoc.Size = New System.Drawing.Size(152, 20)
        Me.teNumeroDoc.TabIndex = 7
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(65, 317)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(122, 13)
        Me.LabelControl12.TabIndex = 0
        Me.LabelControl12.Text = "Documento de Identidad:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(89, 296)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl11.TabIndex = 0
        Me.LabelControl11.Text = "Persona Autorizada:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(94, 277)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl10.TabIndex = 0
        Me.LabelControl10.Text = "No. de Documento:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(33, 256)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(154, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Tipo de Documento Presentado:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 235)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(175, 13)
        Me.LabelControl8.TabIndex = 0
        Me.LabelControl8.Text = "No. Linea para Impresion en Libreta:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(108, 201)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl14.TabIndex = 0
        Me.LabelControl14.Text = "Monto a Retirar:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(105, 177)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl7.TabIndex = 0
        Me.LabelControl7.Text = "Fecha del Retiro:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(333, 79)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Text = "Saldo Disponible:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(76, 103)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "Saldo Actual Ahorrado:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(60, 80)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Fecha del Ult. Movimiento:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(83, 58)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Nombre del Asociado:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(63, 155)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Número de Comprobante:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(93, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Numero de Cuenta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 129)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(155, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tipo de Retiro o Forma de Pago:"
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(530, 323)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 15
        Me.cmdGuardar.Text = "&Guardar"
        '
        'sbVer
        '
        Me.sbVer.Location = New System.Drawing.Point(349, 151)
        Me.sbVer.Name = "sbVer"
        Me.sbVer.Size = New System.Drawing.Size(175, 23)
        Me.sbVer.TabIndex = 16
        Me.sbVer.Text = "Ver &Documentos"
        '
        'sbVerFotografia
        '
        Me.sbVerFotografia.Location = New System.Drawing.Point(349, 177)
        Me.sbVerFotografia.Name = "sbVerFotografia"
        Me.sbVerFotografia.Size = New System.Drawing.Size(175, 23)
        Me.sbVerFotografia.TabIndex = 17
        Me.sbVerFotografia.Text = "Ver &Fotografia"
        '
        'sbVerFirma
        '
        Me.sbVerFirma.Location = New System.Drawing.Point(349, 204)
        Me.sbVerFirma.Name = "sbVerFirma"
        Me.sbVerFirma.Size = New System.Drawing.Size(175, 23)
        Me.sbVerFirma.TabIndex = 18
        Me.sbVerFirma.Text = "&Ver Firma"
        '
        'teSaldoDeudasFiador
        '
        Me.teSaldoDeudasFiador.EditValue = 0
        Me.teSaldoDeudasFiador.EnterMoveNextControl = True
        Me.teSaldoDeudasFiador.Location = New System.Drawing.Point(390, 365)
        Me.teSaldoDeudasFiador.Name = "teSaldoDeudasFiador"
        Me.teSaldoDeudasFiador.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoDeudasFiador.Properties.Appearance.Options.UseFont = True
        Me.teSaldoDeudasFiador.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoDeudasFiador.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoDeudasFiador.Properties.Mask.EditMask = "n2"
        Me.teSaldoDeudasFiador.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoDeudasFiador.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoDeudasFiador.Properties.ReadOnly = True
        Me.teSaldoDeudasFiador.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoDeudasFiador.TabIndex = 142
        '
        'LabelControl40
        '
        Me.LabelControl40.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl40.Location = New System.Drawing.Point(292, 370)
        Me.LabelControl40.Name = "LabelControl40"
        Me.LabelControl40.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl40.TabIndex = 141
        Me.LabelControl40.Text = "Deudas Fiador:"
        '
        'teSaldoDisponible
        '
        Me.teSaldoDisponible.EditValue = 0
        Me.teSaldoDisponible.EnterMoveNextControl = True
        Me.teSaldoDisponible.Location = New System.Drawing.Point(390, 389)
        Me.teSaldoDisponible.Name = "teSaldoDisponible"
        Me.teSaldoDisponible.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoDisponible.Properties.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.teSaldoDisponible.Properties.Appearance.Options.UseFont = True
        Me.teSaldoDisponible.Properties.Appearance.Options.UseForeColor = True
        Me.teSaldoDisponible.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoDisponible.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoDisponible.Properties.Mask.EditMask = "n2"
        Me.teSaldoDisponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoDisponible.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoDisponible.Properties.ReadOnly = True
        Me.teSaldoDisponible.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoDisponible.TabIndex = 140
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelControl25.Location = New System.Drawing.Point(336, 392)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(50, 16)
        Me.LabelControl25.TabIndex = 139
        Me.LabelControl25.Text = "Liquido:"
        '
        'teSaldoDeudas
        '
        Me.teSaldoDeudas.EditValue = 0
        Me.teSaldoDeudas.EnterMoveNextControl = True
        Me.teSaldoDeudas.Location = New System.Drawing.Point(390, 342)
        Me.teSaldoDeudas.Name = "teSaldoDeudas"
        Me.teSaldoDeudas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoDeudas.Properties.Appearance.Options.UseFont = True
        Me.teSaldoDeudas.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoDeudas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoDeudas.Properties.Mask.EditMask = "n2"
        Me.teSaldoDeudas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoDeudas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoDeudas.Properties.ReadOnly = True
        Me.teSaldoDeudas.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoDeudas.TabIndex = 138
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl24.Location = New System.Drawing.Point(296, 345)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl24.TabIndex = 137
        Me.LabelControl24.Text = "Saldo Deudas:"
        '
        'teSaldoAportaciones
        '
        Me.teSaldoAportaciones.EditValue = 0
        Me.teSaldoAportaciones.EnterMoveNextControl = True
        Me.teSaldoAportaciones.Location = New System.Drawing.Point(190, 365)
        Me.teSaldoAportaciones.Name = "teSaldoAportaciones"
        Me.teSaldoAportaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoAportaciones.Properties.Appearance.Options.UseFont = True
        Me.teSaldoAportaciones.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoAportaciones.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoAportaciones.Properties.Mask.EditMask = "n2"
        Me.teSaldoAportaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoAportaciones.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoAportaciones.Properties.ReadOnly = True
        Me.teSaldoAportaciones.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoAportaciones.TabIndex = 136
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl23.Location = New System.Drawing.Point(57, 368)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(131, 16)
        Me.LabelControl23.TabIndex = 135
        Me.LabelControl23.Text = "Saldo Aportaciones:"
        '
        'teSaldoAhorros
        '
        Me.teSaldoAhorros.EditValue = 0
        Me.teSaldoAhorros.EnterMoveNextControl = True
        Me.teSaldoAhorros.Location = New System.Drawing.Point(190, 342)
        Me.teSaldoAhorros.Name = "teSaldoAhorros"
        Me.teSaldoAhorros.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoAhorros.Properties.Appearance.Options.UseFont = True
        Me.teSaldoAhorros.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoAhorros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoAhorros.Properties.Mask.EditMask = "n2"
        Me.teSaldoAhorros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoAhorros.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoAhorros.Properties.ReadOnly = True
        Me.teSaldoAhorros.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoAhorros.TabIndex = 134
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl16.Location = New System.Drawing.Point(90, 345)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(97, 16)
        Me.LabelControl16.TabIndex = 133
        Me.LabelControl16.Text = "Saldo Ahorros:"
        '
        'frmRetiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 414)
        Me.Controls.Add(Me.teSaldoDeudasFiador)
        Me.Controls.Add(Me.LabelControl40)
        Me.Controls.Add(Me.teSaldoDisponible)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.teSaldoDeudas)
        Me.Controls.Add(Me.LabelControl24)
        Me.Controls.Add(Me.teSaldoAportaciones)
        Me.Controls.Add(Me.LabelControl23)
        Me.Controls.Add(Me.teSaldoAhorros)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.sbVerFirma)
        Me.Controls.Add(Me.sbVerFotografia)
        Me.Controls.Add(Me.sbVer)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me._TipoDocPtdo)
        Me.Controls.Add(Me._NroCtaAhorro)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.leFormaPago)
        Me.Controls.Add(Me._saldoDisponible)
        Me.Controls.Add(Me._FecUltMov)
        Me.Controls.Add(Me._Saldo)
        Me.Controls.Add(Me._NombreCliente)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me._PersonaAutorizada)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me._fecRetiro)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me._Monto)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me._DocIdentidad)
        Me.Controls.Add(Me._NroDocumento)
        Me.Controls.Add(Me._LineaLibreta)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teNumeroDoc)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl3)
        Me.KeyPreview = True
        Me.Name = "frmRetiros"
        Me.Text = "RETIROS DE AHORRO"
        CType(Me._TipoDocPtdo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._PersonaAutorizada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroCtaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._fecRetiro.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._fecRetiro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._DocIdentidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroDocumento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._saldoDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FecUltMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoDeudasFiador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoDeudas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoAportaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoAhorros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _fecRetiro As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _DocIdentidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NroDocumento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _LineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _saldoDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumeroDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _NroCtaAhorro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents leFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _PersonaAutorizada As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _Monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _TipoDocPtdo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents _FecUltMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbVerFotografia As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbVerFirma As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teSaldoDeudasFiador As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoDeudas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoAportaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoAhorros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
End Class
