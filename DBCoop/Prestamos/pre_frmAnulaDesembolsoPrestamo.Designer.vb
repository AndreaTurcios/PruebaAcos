<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmAnulaDesembolsoPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmAnulaDesembolsoPrestamo))
        Me.teMontoLiquido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.teNumSolicitud = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.seNumeroDesembolso = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.teNombre = New DevExpress.XtraEditors.TextEdit()
        Me.teIdSolicitudFondo = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.teMontoDesembolsado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.teNumeroPrestamo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit()
        Me.teNumeroComprobante = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.teNumCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaDesembolso = New DevExpress.XtraEditors.DateEdit()
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoDesembolsado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesembolso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teMontoLiquido
        '
        Me.teMontoLiquido.EditValue = 0
        Me.teMontoLiquido.EnterMoveNextControl = True
        Me.teMontoLiquido.Location = New System.Drawing.Point(249, 212)
        Me.teMontoLiquido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teMontoLiquido.Name = "teMontoLiquido"
        Me.teMontoLiquido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.teMontoLiquido.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.teMontoLiquido.Properties.Appearance.Options.UseFont = True
        Me.teMontoLiquido.Properties.Appearance.Options.UseForeColor = True
        Me.teMontoLiquido.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoLiquido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoLiquido.Properties.Mask.EditMask = "n2"
        Me.teMontoLiquido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoLiquido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoLiquido.Size = New System.Drawing.Size(152, 28)
        Me.teMontoLiquido.TabIndex = 223
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(50, 216)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(198, 19)
        Me.LabelControl9.TabIndex = 224
        Me.LabelControl9.Text = "Monto Liquido Desembolso:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(490, 113)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 19)
        Me.LabelControl2.TabIndex = 222
        Me.LabelControl2.Text = "Fecha de Solicitud:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(634, 110)
        Me.deFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Size = New System.Drawing.Size(150, 26)
        Me.deFecha.TabIndex = 220
        '
        'teNumSolicitud
        '
        Me.teNumSolicitud.EnterMoveNextControl = True
        Me.teNumSolicitud.Location = New System.Drawing.Point(250, 107)
        Me.teNumSolicitud.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teNumSolicitud.Name = "teNumSolicitud"
        Me.teNumSolicitud.Size = New System.Drawing.Size(150, 26)
        Me.teNumSolicitud.TabIndex = 219
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 111)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(221, 19)
        Me.LabelControl1.TabIndex = 221
        Me.LabelControl1.Text = "Número de Solicitud Préstamo:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(250, 269)
        Me.sbGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(260, 45)
        Me.sbGuardar.TabIndex = 216
        Me.sbGuardar.Text = "&Eliminar Desembolso"
        '
        'seNumeroDesembolso
        '
        Me.seNumeroDesembolso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumeroDesembolso.EnterMoveNextControl = True
        Me.seNumeroDesembolso.Location = New System.Drawing.Point(250, 143)
        Me.seNumeroDesembolso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.seNumeroDesembolso.Name = "seNumeroDesembolso"
        Me.seNumeroDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seNumeroDesembolso.Size = New System.Drawing.Size(74, 28)
        Me.seNumeroDesembolso.TabIndex = 214
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(102, 148)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(144, 19)
        Me.LabelControl5.TabIndex = 218
        Me.LabelControl5.Text = "No. de Desembolso:"
        '
        'teNombre
        '
        Me.teNombre.Enabled = False
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(411, 39)
        Me.teNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(483, 26)
        Me.teNombre.TabIndex = 215
        '
        'teIdSolicitudFondo
        '
        Me.teIdSolicitudFondo.EnterMoveNextControl = True
        Me.teIdSolicitudFondo.Location = New System.Drawing.Point(250, 39)
        Me.teIdSolicitudFondo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teIdSolicitudFondo.Name = "teIdSolicitudFondo"
        Me.teIdSolicitudFondo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teIdSolicitudFondo.Size = New System.Drawing.Size(150, 26)
        Me.teIdSolicitudFondo.TabIndex = 213
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(98, 42)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(144, 19)
        Me.LabelControl10.TabIndex = 217
        Me.LabelControl10.Text = "Solicitud de Fondos:"
        '
        'teMontoDesembolsado
        '
        Me.teMontoDesembolsado.EditValue = 0
        Me.teMontoDesembolsado.EnterMoveNextControl = True
        Me.teMontoDesembolsado.Location = New System.Drawing.Point(634, 209)
        Me.teMontoDesembolsado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teMontoDesembolsado.Name = "teMontoDesembolsado"
        Me.teMontoDesembolsado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.teMontoDesembolsado.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.teMontoDesembolsado.Properties.Appearance.Options.UseFont = True
        Me.teMontoDesembolsado.Properties.Appearance.Options.UseForeColor = True
        Me.teMontoDesembolsado.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoDesembolsado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoDesembolsado.Properties.Mask.EditMask = "n2"
        Me.teMontoDesembolsado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoDesembolsado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoDesembolsado.Size = New System.Drawing.Size(152, 28)
        Me.teMontoDesembolsado.TabIndex = 225
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(466, 213)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(158, 19)
        Me.LabelControl3.TabIndex = 226
        Me.LabelControl3.Text = "Monto Desembolsado:"
        '
        'teNumeroPrestamo
        '
        Me.teNumeroPrestamo.EnterMoveNextControl = True
        Me.teNumeroPrestamo.Location = New System.Drawing.Point(636, 143)
        Me.teNumeroPrestamo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teNumeroPrestamo.Name = "teNumeroPrestamo"
        Me.teNumeroPrestamo.Size = New System.Drawing.Size(150, 26)
        Me.teNumeroPrestamo.TabIndex = 227
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(470, 148)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(156, 19)
        Me.LabelControl4.TabIndex = 228
        Me.LabelControl4.Text = "Número de Préstamo:"
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.EnterMoveNextControl = True
        Me.teIdPrestamo.Location = New System.Drawing.Point(790, 143)
        Me.teIdPrestamo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Size = New System.Drawing.Size(104, 26)
        Me.teIdPrestamo.TabIndex = 229
        '
        'teNumeroComprobante
        '
        Me.teNumeroComprobante.EnterMoveNextControl = True
        Me.teNumeroComprobante.Location = New System.Drawing.Point(250, 178)
        Me.teNumeroComprobante.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teNumeroComprobante.Name = "teNumeroComprobante"
        Me.teNumeroComprobante.Size = New System.Drawing.Size(150, 26)
        Me.teNumeroComprobante.TabIndex = 230
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(60, 183)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(186, 19)
        Me.LabelControl6.TabIndex = 231
        Me.LabelControl6.Text = "Número de Comprobante:"
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(790, 175)
        Me.teIdCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Size = New System.Drawing.Size(104, 26)
        Me.teIdCuenta.TabIndex = 234
        '
        'teNumCuenta
        '
        Me.teNumCuenta.EnterMoveNextControl = True
        Me.teNumCuenta.Location = New System.Drawing.Point(636, 175)
        Me.teNumCuenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.teNumCuenta.Name = "teNumCuenta"
        Me.teNumCuenta.Size = New System.Drawing.Size(150, 26)
        Me.teNumCuenta.TabIndex = 232
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(490, 180)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(132, 19)
        Me.LabelControl7.TabIndex = 233
        Me.LabelControl7.Text = "Cuenta de Ahorro:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(80, 77)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(159, 19)
        Me.LabelControl8.TabIndex = 236
        Me.LabelControl8.Text = "Fecha de Desembolso:"
        '
        'deFechaDesembolso
        '
        Me.deFechaDesembolso.EditValue = Nothing
        Me.deFechaDesembolso.Location = New System.Drawing.Point(250, 73)
        Me.deFechaDesembolso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.deFechaDesembolso.Name = "deFechaDesembolso"
        Me.deFechaDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDesembolso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFechaDesembolso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaDesembolso.Size = New System.Drawing.Size(150, 26)
        Me.deFechaDesembolso.TabIndex = 235
        '
        'pre_frmAnulaDesembolsoPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.ClientSize = New System.Drawing.Size(1010, 383)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.deFechaDesembolso)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.teNumCuenta)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.teNumeroComprobante)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.teNumeroPrestamo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.teMontoDesembolsado)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teMontoLiquido)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.teNumSolicitud)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.seNumeroDesembolso)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdSolicitudFondo)
        Me.Controls.Add(Me.LabelControl10)
        Me.IconOptions.Icon = CType(resources.GetObject("pre_frmAnulaDesembolsoPrestamo.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "pre_frmAnulaDesembolsoPrestamo"
        Me.Text = "Anula Desembolso Préstamo"
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.teIdSolicitudFondo, 0)
        Me.Controls.SetChildIndex(Me.teNombre, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.seNumeroDesembolso, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.teNumSolicitud, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.teMontoLiquido, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.teMontoDesembolsado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.teNumeroPrestamo, 0)
        Me.Controls.SetChildIndex(Me.teIdPrestamo, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.teNumeroComprobante, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.teNumCuenta, 0)
        Me.Controls.SetChildIndex(Me.teIdCuenta, 0)
        Me.Controls.SetChildIndex(Me.deFechaDesembolso, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoDesembolsado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesembolso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teMontoLiquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNumSolicitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents seNumeroDesembolso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdSolicitudFondo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMontoDesembolsado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumeroPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumeroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaDesembolso As DevExpress.XtraEditors.DateEdit

End Class
