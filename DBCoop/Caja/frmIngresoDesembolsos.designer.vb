<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoDesembolsos
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoDesembolsos))
        Me.teMontoDesembolso = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.deFechaDesembolso = New DevExpress.XtraEditors.DateEdit()
        Me.seNumeroDesembolso = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.teNombre = New DevExpress.XtraEditors.TextEdit()
        Me.teIdSolicitudFondo = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.teNumeroPrestamo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.beNoCuentaAhorro = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.teMontoLiquido = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.teIdCuentaAhorro = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.teLineaLibreta = New DevExpress.XtraEditors.TextEdit()
        Me.sbCalculadora = New DevExpress.XtraEditors.SimpleButton()
        Me.leTipoDesembolso = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.teMontoDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesembolso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoCuentaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuentaAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teMontoDesembolso
        '
        Me.teMontoDesembolso.EditValue = 0
        Me.teMontoDesembolso.EnterMoveNextControl = True
        Me.teMontoDesembolso.Location = New System.Drawing.Point(137, 78)
        Me.teMontoDesembolso.Name = "teMontoDesembolso"
        Me.teMontoDesembolso.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoDesembolso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoDesembolso.Properties.Mask.EditMask = "n2"
        Me.teMontoDesembolso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoDesembolso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoDesembolso.Size = New System.Drawing.Size(101, 20)
        Me.teMontoDesembolso.TabIndex = 4
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(27, 82)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl38.TabIndex = 159
        Me.LabelControl38.Text = "Monto a Desembolsar:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(26, 60)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl12.TabIndex = 156
        Me.LabelControl12.Text = "Fecha de Desembolso:"
        '
        'deFechaDesembolso
        '
        Me.deFechaDesembolso.EditValue = Nothing
        Me.deFechaDesembolso.EnterMoveNextControl = True
        Me.deFechaDesembolso.Location = New System.Drawing.Point(137, 56)
        Me.deFechaDesembolso.Name = "deFechaDesembolso"
        Me.deFechaDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDesembolso.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFechaDesembolso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaDesembolso.Size = New System.Drawing.Size(100, 20)
        Me.deFechaDesembolso.TabIndex = 2
        '
        'seNumeroDesembolso
        '
        Me.seNumeroDesembolso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumeroDesembolso.EnterMoveNextControl = True
        Me.seNumeroDesembolso.Location = New System.Drawing.Point(137, 34)
        Me.seNumeroDesembolso.Name = "seNumeroDesembolso"
        Me.seNumeroDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seNumeroDesembolso.Size = New System.Drawing.Size(49, 20)
        Me.seNumeroDesembolso.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(38, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl5.TabIndex = 154
        Me.LabelControl5.Text = "No. de Desembolso:"
        '
        'teNombre
        '
        Me.teNombre.Enabled = False
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(244, 12)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(395, 20)
        Me.teNombre.TabIndex = 1
        '
        'teIdSolicitudFondo
        '
        Me.teIdSolicitudFondo.EnterMoveNextControl = True
        Me.teIdSolicitudFondo.Location = New System.Drawing.Point(137, 12)
        Me.teIdSolicitudFondo.Name = "teIdSolicitudFondo"
        Me.teIdSolicitudFondo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teIdSolicitudFondo.Properties.Mask.EditMask = "n0"
        Me.teIdSolicitudFondo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teIdSolicitudFondo.Size = New System.Drawing.Size(106, 20)
        Me.teIdSolicitudFondo.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(38, 15)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl10.TabIndex = 151
        Me.LabelControl10.Text = "Solicitud de Fondos:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(234, 165)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(147, 31)
        Me.sbGuardar.TabIndex = 9
        Me.sbGuardar.Text = "&Aplicar desembolso"
        '
        'teNumeroPrestamo
        '
        Me.teNumeroPrestamo.EnterMoveNextControl = True
        Me.teNumeroPrestamo.Location = New System.Drawing.Point(418, 56)
        Me.teNumeroPrestamo.Name = "teNumeroPrestamo"
        Me.teNumeroPrestamo.Size = New System.Drawing.Size(101, 20)
        Me.teNumeroPrestamo.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(311, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 184
        Me.LabelControl2.Text = "Número de Préstamo:"
        '
        'beNoCuentaAhorro
        '
        Me.beNoCuentaAhorro.EnterMoveNextControl = True
        Me.beNoCuentaAhorro.Location = New System.Drawing.Point(418, 103)
        Me.beNoCuentaAhorro.Name = "beNoCuentaAhorro"
        Me.beNoCuentaAhorro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beNoCuentaAhorro.Size = New System.Drawing.Size(100, 20)
        Me.beNoCuentaAhorro.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(267, 106)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(148, 13)
        Me.LabelControl8.TabIndex = 188
        Me.LabelControl8.Text = "Cuenta de Ahorro a Depositar:"
        '
        'teMontoLiquido
        '
        Me.teMontoLiquido.EditValue = 0
        Me.teMontoLiquido.EnterMoveNextControl = True
        Me.teMontoLiquido.Location = New System.Drawing.Point(137, 103)
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
        Me.teMontoLiquido.Size = New System.Drawing.Size(101, 20)
        Me.teMontoLiquido.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(6, 106)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(128, 13)
        Me.LabelControl9.TabIndex = 190
        Me.LabelControl9.Text = "Monto Líquido a Depositar:"
        '
        'teIdCuentaAhorro
        '
        Me.teIdCuentaAhorro.EditValue = 0
        Me.teIdCuentaAhorro.Enabled = False
        Me.teIdCuentaAhorro.EnterMoveNextControl = True
        Me.teIdCuentaAhorro.Location = New System.Drawing.Point(524, 103)
        Me.teIdCuentaAhorro.Name = "teIdCuentaAhorro"
        Me.teIdCuentaAhorro.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdCuentaAhorro.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdCuentaAhorro.Properties.ReadOnly = True
        Me.teIdCuentaAhorro.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuentaAhorro.TabIndex = 192
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(225, 132)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(190, 13)
        Me.LabelControl1.TabIndex = 193
        Me.LabelControl1.Text = "No. de Línea para Impresión en Libreta:"
        '
        'teLineaLibreta
        '
        Me.teLineaLibreta.EditValue = 1
        Me.teLineaLibreta.EnterMoveNextControl = True
        Me.teLineaLibreta.Location = New System.Drawing.Point(418, 129)
        Me.teLineaLibreta.Name = "teLineaLibreta"
        Me.teLineaLibreta.Properties.Appearance.Options.UseForeColor = True
        Me.teLineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLineaLibreta.Properties.Mask.EditMask = "n0"
        Me.teLineaLibreta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teLineaLibreta.Size = New System.Drawing.Size(44, 20)
        Me.teLineaLibreta.TabIndex = 8
        '
        'sbCalculadora
        '
        Me.sbCalculadora.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbCalculadora.Appearance.Options.UseFont = True
        Me.sbCalculadora.Image = Global.Bravio.My.Resources.Resources.accessories_calculator_3
        Me.sbCalculadora.Location = New System.Drawing.Point(545, 42)
        Me.sbCalculadora.Name = "sbCalculadora"
        Me.sbCalculadora.Size = New System.Drawing.Size(41, 43)
        Me.sbCalculadora.TabIndex = 194
        Me.sbCalculadora.TabStop = False
        '
        'leTipoDesembolso
        '
        Me.leTipoDesembolso.EnterMoveNextControl = True
        Me.leTipoDesembolso.Location = New System.Drawing.Point(418, 79)
        Me.leTipoDesembolso.Name = "leTipoDesembolso"
        Me.leTipoDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoDesembolso.Size = New System.Drawing.Size(204, 20)
        Me.leTipoDesembolso.TabIndex = 195
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(317, 82)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl13.TabIndex = 196
        Me.LabelControl13.Text = "Tipo de Desembolso:"
        '
        'frmIngresoDesembolsos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 209)
        Me.Controls.Add(Me.leTipoDesembolso)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.sbCalculadora)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teLineaLibreta)
        Me.Controls.Add(Me.teIdCuentaAhorro)
        Me.Controls.Add(Me.teMontoLiquido)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.beNoCuentaAhorro)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teNumeroPrestamo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.teMontoDesembolso)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.deFechaDesembolso)
        Me.Controls.Add(Me.seNumeroDesembolso)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdSolicitudFondo)
        Me.Controls.Add(Me.LabelControl10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmIngresoDesembolsos"
        Me.Text = "Entrega de Desembolsos"
        CType(Me.teMontoDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesembolso.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoCuentaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuentaAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teMontoDesembolso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaDesembolso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents seNumeroDesembolso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdSolicitudFondo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teNumeroPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beNoCuentaAhorro As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMontoLiquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuentaAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teLineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbCalculadora As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leTipoDesembolso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
End Class
