<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAportaciones
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
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me._Monto = New DevExpress.XtraEditors.TextEdit
        Me.teNumero = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me._FechaMov = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me._FechaUltMov = New DevExpress.XtraEditors.TextEdit
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me._FechaIngCliente = New DevExpress.XtraEditors.TextEdit
        Me._NombreCliente = New DevExpress.XtraEditors.TextEdit
        Me._TipoAportacion = New DevExpress.XtraEditors.LookUpEdit
        Me._FormaPago = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teLineaLibreta = New DevExpress.XtraEditors.TextEdit
        Me._Diferencia = New DevExpress.XtraEditors.TextEdit
        Me._SaldoDebeSer = New DevExpress.XtraEditors.TextEdit
        Me._NumeroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._saldo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1.SuspendLayout()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaMov.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaUltMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaIngCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._TipoAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FormaPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Diferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._SaldoDebeSer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._saldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(562, 258)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 29)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "&Guardar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._Monto)
        Me.GroupBox1.Controls.Add(Me.teNumero)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me._FechaMov)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me._FechaUltMov)
        Me.GroupBox1.Controls.Add(Me.teIdAsociado)
        Me.GroupBox1.Controls.Add(Me._FechaIngCliente)
        Me.GroupBox1.Controls.Add(Me._NombreCliente)
        Me.GroupBox1.Controls.Add(Me._TipoAportacion)
        Me.GroupBox1.Controls.Add(Me._FormaPago)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.teLineaLibreta)
        Me.GroupBox1.Controls.Add(Me._Diferencia)
        Me.GroupBox1.Controls.Add(Me._SaldoDebeSer)
        Me.GroupBox1.Controls.Add(Me._NumeroComprobante)
        Me.GroupBox1.Controls.Add(Me._saldo)
        Me.GroupBox1.Controls.Add(Me.LabelControl12)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 238)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        '_Monto
        '
        Me._Monto.EditValue = 0
        Me._Monto.EnterMoveNextControl = True
        Me._Monto.Location = New System.Drawing.Point(202, 182)
        Me._Monto.Name = "_Monto"
        Me._Monto.Properties.Appearance.Options.UseTextOptions = True
        Me._Monto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Monto.Properties.Mask.EditMask = "n2"
        Me._Monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Monto.Size = New System.Drawing.Size(100, 20)
        Me._Monto.TabIndex = 10
        '
        'teNumero
        '
        Me.teNumero.EditValue = ""
        Me.teNumero.EnterMoveNextControl = True
        Me.teNumero.Location = New System.Drawing.Point(202, 15)
        Me.teNumero.Name = "teNumero"
        Me.teNumero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumero.Size = New System.Drawing.Size(100, 20)
        Me.teNumero.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(99, 18)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Código del Asociado:"
        '
        '_FechaMov
        '
        Me._FechaMov.EditValue = Nothing
        Me._FechaMov.EnterMoveNextControl = True
        Me._FechaMov.Location = New System.Drawing.Point(202, 157)
        Me._FechaMov.Name = "_FechaMov"
        Me._FechaMov.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaMov.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaMov.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaMov.Size = New System.Drawing.Size(100, 20)
        Me._FechaMov.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(75, 113)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl2.TabIndex = 14
        Me.LabelControl2.Text = "Número de Comprobante:"
        '
        '_FechaUltMov
        '
        Me._FechaUltMov.Enabled = False
        Me._FechaUltMov.EnterMoveNextControl = True
        Me._FechaUltMov.Location = New System.Drawing.Point(202, 206)
        Me._FechaUltMov.Name = "_FechaUltMov"
        Me._FechaUltMov.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._FechaUltMov.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._FechaUltMov.Size = New System.Drawing.Size(100, 20)
        Me._FechaUltMov.TabIndex = 12
        '
        'teIdAsociado
        '
        Me.teIdAsociado.Enabled = False
        Me.teIdAsociado.EnterMoveNextControl = True
        Me.teIdAsociado.Location = New System.Drawing.Point(504, 15)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdAsociado.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdAsociado.Size = New System.Drawing.Size(100, 20)
        Me.teIdAsociado.TabIndex = 1
        '
        '_FechaIngCliente
        '
        Me._FechaIngCliente.Enabled = False
        Me._FechaIngCliente.EnterMoveNextControl = True
        Me._FechaIngCliente.Location = New System.Drawing.Point(504, 64)
        Me._FechaIngCliente.Name = "_FechaIngCliente"
        Me._FechaIngCliente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._FechaIngCliente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._FechaIngCliente.Size = New System.Drawing.Size(100, 20)
        Me._FechaIngCliente.TabIndex = 4
        '
        '_NombreCliente
        '
        Me._NombreCliente.Enabled = False
        Me._NombreCliente.EnterMoveNextControl = True
        Me._NombreCliente.Location = New System.Drawing.Point(202, 37)
        Me._NombreCliente.Name = "_NombreCliente"
        Me._NombreCliente.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._NombreCliente.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._NombreCliente.Size = New System.Drawing.Size(402, 20)
        Me._NombreCliente.TabIndex = 2
        '
        '_TipoAportacion
        '
        Me._TipoAportacion.EnterMoveNextControl = True
        Me._TipoAportacion.Location = New System.Drawing.Point(202, 132)
        Me._TipoAportacion.Name = "_TipoAportacion"
        Me._TipoAportacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._TipoAportacion.Size = New System.Drawing.Size(283, 20)
        Me._TipoAportacion.TabIndex = 7
        '
        '_FormaPago
        '
        Me._FormaPago.EnterMoveNextControl = True
        Me._FormaPago.Location = New System.Drawing.Point(202, 88)
        Me._FormaPago.Name = "_FormaPago"
        Me._FormaPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FormaPago.Size = New System.Drawing.Size(283, 20)
        Me._FormaPago.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(72, 209)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(127, 13)
        Me.LabelControl7.TabIndex = 11
        Me.LabelControl7.Text = "Fecha del Ult. Movimiento:"
        '
        'teLineaLibreta
        '
        Me.teLineaLibreta.EditValue = 0
        Me.teLineaLibreta.EnterMoveNextControl = True
        Me.teLineaLibreta.Location = New System.Drawing.Point(504, 206)
        Me.teLineaLibreta.Name = "teLineaLibreta"
        Me.teLineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLineaLibreta.Size = New System.Drawing.Size(100, 20)
        Me.teLineaLibreta.TabIndex = 13
        '
        '_Diferencia
        '
        Me._Diferencia.EditValue = 0
        Me._Diferencia.Enabled = False
        Me._Diferencia.EnterMoveNextControl = True
        Me._Diferencia.Location = New System.Drawing.Point(504, 182)
        Me._Diferencia.Name = "_Diferencia"
        Me._Diferencia.Properties.Appearance.Options.UseTextOptions = True
        Me._Diferencia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Diferencia.Properties.Mask.EditMask = "n2"
        Me._Diferencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Diferencia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Diferencia.Size = New System.Drawing.Size(100, 20)
        Me._Diferencia.TabIndex = 11
        '
        '_SaldoDebeSer
        '
        Me._SaldoDebeSer.EditValue = 0
        Me._SaldoDebeSer.Enabled = False
        Me._SaldoDebeSer.EnterMoveNextControl = True
        Me._SaldoDebeSer.Location = New System.Drawing.Point(504, 157)
        Me._SaldoDebeSer.Name = "_SaldoDebeSer"
        Me._SaldoDebeSer.Properties.Appearance.Options.UseTextOptions = True
        Me._SaldoDebeSer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._SaldoDebeSer.Properties.Mask.EditMask = "n2"
        Me._SaldoDebeSer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._SaldoDebeSer.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._SaldoDebeSer.Size = New System.Drawing.Size(100, 20)
        Me._SaldoDebeSer.TabIndex = 9
        '
        '_NumeroComprobante
        '
        Me._NumeroComprobante.EditValue = ""
        Me._NumeroComprobante.EnterMoveNextControl = True
        Me._NumeroComprobante.Location = New System.Drawing.Point(202, 110)
        Me._NumeroComprobante.Name = "_NumeroComprobante"
        Me._NumeroComprobante.Size = New System.Drawing.Size(100, 20)
        Me._NumeroComprobante.TabIndex = 6
        '
        '_saldo
        '
        Me._saldo.EditValue = 0
        Me._saldo.Enabled = False
        Me._saldo.EnterMoveNextControl = True
        Me._saldo.Location = New System.Drawing.Point(202, 64)
        Me._saldo.Name = "_saldo"
        Me._saldo.Properties.Appearance.Options.UseTextOptions = True
        Me._saldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._saldo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me._saldo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me._saldo.Properties.Mask.EditMask = "n2"
        Me._saldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._saldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._saldo.Size = New System.Drawing.Size(100, 20)
        Me._saldo.TabIndex = 3
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(449, 185)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl12.TabIndex = 9
        Me.LabelControl12.Text = "Diferencia:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(325, 211)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(176, 13)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "No. de línea para impresin en libreta:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(382, 160)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(119, 13)
        Me.LabelControl10.TabIndex = 10
        Me.LabelControl10.Text = "Saldo que debería tener:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(360, 67)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl9.TabIndex = 5
        Me.LabelControl9.Text = "Fecha de Ingreso del Cliente:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(116, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl6.TabIndex = 7
        Me.LabelControl6.Text = "Monto a Aportar:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(92, 160)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Fecha del Movimiento:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 91)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Tipo de Ingreso o Forma de Pago:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(88, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "Saldo Actual Aportado:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(105, 135)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl13.TabIndex = 12
        Me.LabelControl13.Text = "Tipo de Aportación:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(420, 18)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl14.TabIndex = 12
        Me.LabelControl14.Text = "Id. del Asociado:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(95, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "Nombre del Asociado:"
        '
        'frmAportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdGuardar)
        Me.KeyPreview = True
        Me.Name = "frmAportaciones"
        Me.Text = "INGRESO DE APORTACIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaMov.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaUltMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaIngCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._TipoAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FormaPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Diferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._SaldoDebeSer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._saldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _FechaMov As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _NombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumero As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents _FormaPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teLineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Diferencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _SaldoDebeSer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NumeroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _saldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _TipoAportacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _Monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _FechaIngCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _FechaUltMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
End Class
