<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDepositos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDepositos))
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me._FechaDeposito = New DevExpress.XtraEditors.DateEdit()
        Me._FecUltMov = New DevExpress.XtraEditors.TextEdit()
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit()
        Me._Nombre = New DevExpress.XtraEditors.TextEdit()
        Me._Saldo = New DevExpress.XtraEditors.TextEdit()
        Me._LineaLibreta = New DevExpress.XtraEditors.TextEdit()
        Me._SaldoDisponible = New DevExpress.XtraEditors.TextEdit()
        Me._Monto = New DevExpress.XtraEditors.TextEdit()
        Me.leFormaPago = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me._NroCtaAhorro = New DevExpress.XtraEditors.ButtonEdit()
        Me._Observa = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.teNumeroDoc = New DevExpress.XtraEditors.TextEdit()
        CType(Me._FechaDeposito.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaDeposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FecUltMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Nombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._LineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SaldoDisponible.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroCtaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Observa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(517, 274)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 12
        Me.cmdGuardar.Text = "&Guardar"
        '
        '_FechaDeposito
        '
        Me._FechaDeposito.EditValue = Nothing
        Me._FechaDeposito.EnterMoveNextControl = True
        Me._FechaDeposito.Location = New System.Drawing.Point(185, 155)
        Me._FechaDeposito.Name = "_FechaDeposito"
        Me._FechaDeposito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaDeposito.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me._FechaDeposito.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaDeposito.Size = New System.Drawing.Size(100, 20)
        Me._FechaDeposito.TabIndex = 9
        '
        '_FecUltMov
        '
        Me._FecUltMov.Enabled = False
        Me._FecUltMov.EnterMoveNextControl = True
        Me._FecUltMov.Location = New System.Drawing.Point(492, 64)
        Me._FecUltMov.Name = "_FecUltMov"
        Me._FecUltMov.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._FecUltMov.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._FecUltMov.Properties.ReadOnly = True
        Me._FecUltMov.Size = New System.Drawing.Size(100, 20)
        Me._FecUltMov.TabIndex = 4
        '
        'teIdCuenta
        '
        Me.teIdCuenta.Enabled = False
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(492, 12)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdCuenta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 1
        '
        '_Nombre
        '
        Me._Nombre.Enabled = False
        Me._Nombre.EnterMoveNextControl = True
        Me._Nombre.Location = New System.Drawing.Point(185, 38)
        Me._Nombre.Name = "_Nombre"
        Me._Nombre.Properties.AllowFocused = False
        Me._Nombre.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._Nombre.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._Nombre.Properties.ReadOnly = True
        Me._Nombre.Size = New System.Drawing.Size(407, 20)
        Me._Nombre.TabIndex = 2
        '
        '_Saldo
        '
        Me._Saldo.EditValue = 0
        Me._Saldo.Enabled = False
        Me._Saldo.EnterMoveNextControl = True
        Me._Saldo.Location = New System.Drawing.Point(185, 64)
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
        Me._Saldo.TabIndex = 3
        '
        '_LineaLibreta
        '
        Me._LineaLibreta.EnterMoveNextControl = True
        Me._LineaLibreta.Location = New System.Drawing.Point(492, 85)
        Me._LineaLibreta.Name = "_LineaLibreta"
        Me._LineaLibreta.Properties.Appearance.Options.UseForeColor = True
        Me._LineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._LineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._LineaLibreta.Size = New System.Drawing.Size(52, 20)
        Me._LineaLibreta.TabIndex = 6
        '
        '_SaldoDisponible
        '
        Me._SaldoDisponible.EditValue = 0
        Me._SaldoDisponible.Enabled = False
        Me._SaldoDisponible.EnterMoveNextControl = True
        Me._SaldoDisponible.Location = New System.Drawing.Point(185, 85)
        Me._SaldoDisponible.Name = "_SaldoDisponible"
        Me._SaldoDisponible.Properties.Appearance.Options.UseTextOptions = True
        Me._SaldoDisponible.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._SaldoDisponible.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._SaldoDisponible.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._SaldoDisponible.Properties.Mask.EditMask = "n2"
        Me._SaldoDisponible.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._SaldoDisponible.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._SaldoDisponible.Properties.ReadOnly = True
        Me._SaldoDisponible.Size = New System.Drawing.Size(100, 20)
        Me._SaldoDisponible.TabIndex = 5
        '
        '_Monto
        '
        Me._Monto.EditValue = 0
        Me._Monto.EnterMoveNextControl = True
        Me._Monto.Location = New System.Drawing.Point(185, 177)
        Me._Monto.Name = "_Monto"
        Me._Monto.Properties.Appearance.Options.UseTextOptions = True
        Me._Monto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Monto.Properties.Mask.EditMask = "n2"
        Me._Monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Monto.Size = New System.Drawing.Size(100, 20)
        Me._Monto.TabIndex = 10
        '
        'leFormaPago
        '
        Me.leFormaPago.EnterMoveNextControl = True
        Me.leFormaPago.Location = New System.Drawing.Point(185, 108)
        Me.leFormaPago.Name = "leFormaPago"
        Me.leFormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFormaPago.Size = New System.Drawing.Size(304, 20)
        Me.leFormaPago.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 110)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(168, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tipo de Depósito o Forma de Pago:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(350, 67)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(139, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Fecha del Ultimo Movimiento:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(411, 15)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl12.TabIndex = 3
        Me.LabelControl12.Text = "Id de la Cuenta:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(299, 88)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl10.TabIndex = 3
        Me.LabelControl10.Text = "No. de Línea para Impresión en Libreta:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(88, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Nombre del Cliente:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(82, 16)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl9.TabIndex = 3
        Me.LabelControl9.Text = "No. Cuenta Ahorros:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(119, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Saldo Actual:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(26, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(156, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Saldo Disponible (No pignorado):"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(87, 158)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl6.TabIndex = 3
        Me.LabelControl6.Text = "Fecha del Deposito:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(90, 180)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Monto a Depositar:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(35, 210)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(147, 13)
        Me.LabelControl11.TabIndex = 3
        Me.LabelControl11.Text = "Observaciones o Comentarios:"
        '
        '_NroCtaAhorro
        '
        Me._NroCtaAhorro.EditValue = ""
        Me._NroCtaAhorro.EnterMoveNextControl = True
        Me._NroCtaAhorro.Location = New System.Drawing.Point(185, 12)
        Me._NroCtaAhorro.Name = "_NroCtaAhorro"
        Me._NroCtaAhorro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me._NroCtaAhorro.Size = New System.Drawing.Size(100, 20)
        Me._NroCtaAhorro.TabIndex = 0
        '
        '_Observa
        '
        Me._Observa.EnterMoveNextControl = True
        Me._Observa.Location = New System.Drawing.Point(185, 206)
        Me._Observa.Name = "_Observa"
        Me._Observa.Size = New System.Drawing.Size(407, 53)
        Me._Observa.TabIndex = 11
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(78, 135)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "No. de Comprobante:"
        '
        'teNumeroDoc
        '
        Me.teNumeroDoc.EditValue = ""
        Me.teNumeroDoc.EnterMoveNextControl = True
        Me.teNumeroDoc.Location = New System.Drawing.Point(185, 132)
        Me.teNumeroDoc.Name = "teNumeroDoc"
        Me.teNumeroDoc.Size = New System.Drawing.Size(100, 20)
        Me.teNumeroDoc.TabIndex = 13
        '
        'FrmDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 303)
        Me.Controls.Add(Me.teNumeroDoc)
        Me.Controls.Add(Me._NroCtaAhorro)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me._Observa)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me._Nombre)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me._FechaDeposito)
        Me.Controls.Add(Me._SaldoDisponible)
        Me.Controls.Add(Me._Monto)
        Me.Controls.Add(Me._LineaLibreta)
        Me.Controls.Add(Me._Saldo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.leFormaPago)
        Me.Controls.Add(Me._FecUltMov)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmDepositos"
        Me.Text = "DEPÓSITOS"
        CType(Me._FechaDeposito.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaDeposito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FecUltMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Nombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._LineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SaldoDisponible.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroCtaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Observa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _FechaDeposito As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _FecUltMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Nombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _LineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _SaldoDisponible As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents leFormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _NroCtaAhorro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents _Observa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumeroDoc As DevExpress.XtraEditors.TextEdit
End Class
