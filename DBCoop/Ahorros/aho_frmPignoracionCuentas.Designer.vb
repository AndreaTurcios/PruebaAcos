<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmPignoracionCuentas
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
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.teAsociado = New DevExpress.XtraEditors.TextEdit
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldo = New DevExpress.XtraEditors.TextEdit
        Me.teValor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.teMontoOtorgado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoCapital = New DevExpress.XtraEditors.TextEdit
        Me._FechaOtorgamiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaVencimiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.sbAceptar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoOtorgado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoCapital.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EditValue = "0"
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(265, 22)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 1
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(55, 49)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl11.TabIndex = 97
        Me.LabelControl11.Text = "Nombre del Asociado:"
        '
        'teAsociado
        '
        Me.teAsociado.Location = New System.Drawing.Point(162, 46)
        Me.teAsociado.Name = "teAsociado"
        Me.teAsociado.Properties.ReadOnly = True
        Me.teAsociado.Size = New System.Drawing.Size(343, 20)
        Me.teAsociado.TabIndex = 2
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(162, 22)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(99, 20)
        Me.beNumeroCuenta.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(65, 25)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl12.TabIndex = 96
        Me.LabelControl12.Text = "Número de Cuenta:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(96, 72)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl10.TabIndex = 99
        Me.LabelControl10.Text = "Saldo Actual:"
        '
        'teSaldo
        '
        Me.teSaldo.EditValue = 0
        Me.teSaldo.Location = New System.Drawing.Point(161, 69)
        Me.teSaldo.Name = "teSaldo"
        Me.teSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldo.Properties.Mask.EditMask = "n2"
        Me.teSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldo.Properties.ReadOnly = True
        Me.teSaldo.Size = New System.Drawing.Size(82, 20)
        Me.teSaldo.TabIndex = 3
        '
        'teValor
        '
        Me.teValor.EditValue = 0
        Me.teValor.Location = New System.Drawing.Point(161, 93)
        Me.teValor.Name = "teValor"
        Me.teValor.Properties.Appearance.Options.UseTextOptions = True
        Me.teValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValor.Properties.Mask.EditMask = "n2"
        Me.teValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValor.Size = New System.Drawing.Size(83, 20)
        Me.teValor.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(72, 96)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl4.TabIndex = 101
        Me.LabelControl4.Text = "Monto a Pignorar:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(54, 124)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 103
        Me.LabelControl1.Text = "Número de Préstamo:"
        '
        'btNumPrestamo
        '
        Me.btNumPrestamo.EnterMoveNextControl = True
        Me.btNumPrestamo.Location = New System.Drawing.Point(161, 121)
        Me.btNumPrestamo.Name = "btNumPrestamo"
        Me.btNumPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btNumPrestamo.Properties.Mask.EditMask = "n0"
        Me.btNumPrestamo.Size = New System.Drawing.Size(114, 20)
        Me.btNumPrestamo.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(74, 149)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl8.TabIndex = 107
        Me.LabelControl8.Text = "Monto Otorgado:"
        '
        'teMontoOtorgado
        '
        Me.teMontoOtorgado.EditValue = 0
        Me.teMontoOtorgado.EnterMoveNextControl = True
        Me.teMontoOtorgado.Location = New System.Drawing.Point(161, 146)
        Me.teMontoOtorgado.Name = "teMontoOtorgado"
        Me.teMontoOtorgado.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoOtorgado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoOtorgado.Properties.Mask.EditMask = "n2"
        Me.teMontoOtorgado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoOtorgado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoOtorgado.Properties.ReadOnly = True
        Me.teMontoOtorgado.Size = New System.Drawing.Size(86, 20)
        Me.teMontoOtorgado.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(334, 148)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl3.TabIndex = 109
        Me.LabelControl3.Text = "Saldo de Capital:"
        '
        'teSaldoCapital
        '
        Me.teSaldoCapital.EditValue = 0
        Me.teSaldoCapital.EnterMoveNextControl = True
        Me.teSaldoCapital.Location = New System.Drawing.Point(419, 145)
        Me.teSaldoCapital.Name = "teSaldoCapital"
        Me.teSaldoCapital.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoCapital.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoCapital.Properties.Mask.EditMask = "n2"
        Me.teSaldoCapital.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoCapital.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoCapital.Properties.ReadOnly = True
        Me.teSaldoCapital.Size = New System.Drawing.Size(86, 20)
        Me.teSaldoCapital.TabIndex = 8
        '
        '_FechaOtorgamiento
        '
        Me._FechaOtorgamiento.EditValue = Nothing
        Me._FechaOtorgamiento.EnterMoveNextControl = True
        Me._FechaOtorgamiento.Location = New System.Drawing.Point(161, 171)
        Me._FechaOtorgamiento.Name = "_FechaOtorgamiento"
        Me._FechaOtorgamiento.Properties.AllowFocused = False
        Me._FechaOtorgamiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me._FechaOtorgamiento.Properties.Appearance.Options.UseBackColor = True
        Me._FechaOtorgamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaOtorgamiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaOtorgamiento.Properties.ReadOnly = True
        Me._FechaOtorgamiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaOtorgamiento.Size = New System.Drawing.Size(86, 20)
        Me._FechaOtorgamiento.TabIndex = 9
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(56, 176)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl21.TabIndex = 111
        Me.LabelControl21.Text = "Fecha Otrogamiento:"
        '
        'deFechaVencimiento
        '
        Me.deFechaVencimiento.EditValue = Nothing
        Me.deFechaVencimiento.EnterMoveNextControl = True
        Me.deFechaVencimiento.Location = New System.Drawing.Point(419, 169)
        Me.deFechaVencimiento.Name = "deFechaVencimiento"
        Me.deFechaVencimiento.Properties.AllowFocused = False
        Me.deFechaVencimiento.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.deFechaVencimiento.Properties.Appearance.Options.UseBackColor = True
        Me.deFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaVencimiento.Properties.ReadOnly = True
        Me.deFechaVencimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaVencimiento.Size = New System.Drawing.Size(86, 20)
        Me.deFechaVencimiento.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(309, 172)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl5.TabIndex = 113
        Me.LabelControl5.Text = "Fecha de Vencimiento:"
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Enabled = False
        Me.teIdPrestamo.EnterMoveNextControl = True
        Me.teIdPrestamo.Location = New System.Drawing.Point(419, 119)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdPrestamo.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(84, 20)
        Me.teIdPrestamo.TabIndex = 6
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(349, 122)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl14.TabIndex = 115
        Me.LabelControl14.Text = "Id. Prestamo:"
        '
        'sbAceptar
        '
        Me.sbAceptar.Location = New System.Drawing.Point(387, 196)
        Me.sbAceptar.Name = "sbAceptar"
        Me.sbAceptar.Size = New System.Drawing.Size(119, 40)
        Me.sbAceptar.TabIndex = 116
        Me.sbAceptar.Text = "Aceptar"
        '
        'aho_frmPignoracionCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(533, 268)
        Me.Controls.Add(Me.sbAceptar)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.deFechaVencimiento)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me._FechaOtorgamiento)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teSaldoCapital)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teMontoOtorgado)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btNumPrestamo)
        Me.Controls.Add(Me.teValor)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.teSaldo)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.teAsociado)
        Me.Controls.Add(Me.beNumeroCuenta)
        Me.Controls.Add(Me.LabelControl12)
        Me.Name = "aho_frmPignoracionCuentas"
        Me.Text = "Pignoración de Cuentas"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.beNumeroCuenta, 0)
        Me.Controls.SetChildIndex(Me.teAsociado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.teIdCuenta, 0)
        Me.Controls.SetChildIndex(Me.teSaldo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.teValor, 0)
        Me.Controls.SetChildIndex(Me.btNumPrestamo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.teMontoOtorgado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.teSaldoCapital, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.LabelControl21, 0)
        Me.Controls.SetChildIndex(Me._FechaOtorgamiento, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.deFechaVencimiento, 0)
        Me.Controls.SetChildIndex(Me.LabelControl14, 0)
        Me.Controls.SetChildIndex(Me.teIdPrestamo, 0)
        Me.Controls.SetChildIndex(Me.sbAceptar, 0)
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoOtorgado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoCapital.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaOtorgamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btNumPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMontoOtorgado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoCapital As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _FechaOtorgamiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbAceptar As DevExpress.XtraEditors.SimpleButton

End Class
