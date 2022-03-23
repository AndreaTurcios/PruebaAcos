<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmEliminaComprob
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
        Me.teIdMov = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaHoraCreacion = New DevExpress.XtraEditors.DateEdit
        Me.teTipoAplicacion = New DevExpress.XtraEditors.TextEdit
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.teSaldo = New DevExpress.XtraEditors.TextEdit
        Me.teValor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaMov = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teNumeroComprobante = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.teCreadoPor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.teAsociado = New DevExpress.XtraEditors.TextEdit
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaContable = New DevExpress.XtraEditors.DateEdit
        Me.btReImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teIdMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaHoraCreacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaHoraCreacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTipoAplicacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaMov.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaMov.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCreadoPor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.teIdCuenta)
        Me.GroupControl1.Controls.Add(Me.deFechaContable)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.teAsociado)
        Me.GroupControl1.Controls.Add(Me.beNumeroCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.teCreadoPor)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.teIdMov)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.deFechaHoraCreacion)
        Me.GroupControl1.Controls.Add(Me.teTipoAplicacion)
        Me.GroupControl1.Controls.Add(Me.btReImprimir)
        Me.GroupControl1.Controls.Add(Me.cmdEliminar)
        Me.GroupControl1.Controls.Add(Me.teSaldo)
        Me.GroupControl1.Controls.Add(Me.teValor)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deFechaMov)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.teNumeroComprobante)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 254)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Eliminar depósitos y retiros"
        '
        'teIdMov
        '
        Me.teIdMov.Location = New System.Drawing.Point(474, 95)
        Me.teIdMov.Name = "teIdMov"
        Me.teIdMov.Properties.ReadOnly = True
        Me.teIdMov.Size = New System.Drawing.Size(101, 20)
        Me.teIdMov.TabIndex = 4
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(384, 98)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl6.TabIndex = 50
        Me.LabelControl6.Text = "Id del Movimiento:"
        '
        'deFechaHoraCreacion
        '
        Me.deFechaHoraCreacion.EditValue = Nothing
        Me.deFechaHoraCreacion.Location = New System.Drawing.Point(175, 139)
        Me.deFechaHoraCreacion.Name = "deFechaHoraCreacion"
        Me.deFechaHoraCreacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaHoraCreacion.Properties.ReadOnly = True
        Me.deFechaHoraCreacion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaHoraCreacion.Size = New System.Drawing.Size(203, 20)
        Me.deFechaHoraCreacion.TabIndex = 7
        '
        'teTipoAplicacion
        '
        Me.teTipoAplicacion.Location = New System.Drawing.Point(175, 116)
        Me.teTipoAplicacion.Name = "teTipoAplicacion"
        Me.teTipoAplicacion.Properties.ReadOnly = True
        Me.teTipoAplicacion.Size = New System.Drawing.Size(101, 20)
        Me.teTipoAplicacion.TabIndex = 5
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Enabled = False
        Me.cmdEliminar.Location = New System.Drawing.Point(372, 222)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(100, 26)
        Me.cmdEliminar.TabIndex = 12
        Me.cmdEliminar.Text = "&Eliminar"
        '
        'teSaldo
        '
        Me.teSaldo.EditValue = 0
        Me.teSaldo.Location = New System.Drawing.Point(474, 182)
        Me.teSaldo.Name = "teSaldo"
        Me.teSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldo.Properties.Mask.EditMask = "n2"
        Me.teSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldo.Properties.ReadOnly = True
        Me.teSaldo.Size = New System.Drawing.Size(100, 20)
        Me.teSaldo.TabIndex = 11
        '
        'teValor
        '
        Me.teValor.EditValue = 0
        Me.teValor.Location = New System.Drawing.Point(175, 182)
        Me.teValor.Name = "teValor"
        Me.teValor.Properties.Appearance.Options.UseTextOptions = True
        Me.teValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValor.Properties.Mask.EditMask = "n2"
        Me.teValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValor.Properties.ReadOnly = True
        Me.teValor.Size = New System.Drawing.Size(83, 20)
        Me.teValor.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(70, 185)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Valor del Movimiento:"
        '
        'deFechaMov
        '
        Me.deFechaMov.EditValue = Nothing
        Me.deFechaMov.Location = New System.Drawing.Point(175, 160)
        Me.deFechaMov.Name = "deFechaMov"
        Me.deFechaMov.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaMov.Properties.ReadOnly = True
        Me.deFechaMov.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaMov.Size = New System.Drawing.Size(83, 20)
        Me.deFechaMov.TabIndex = 8
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(65, 163)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl7.TabIndex = 47
        Me.LabelControl7.Text = "Fecha del Movimiento:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(83, 119)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl14.TabIndex = 46
        Me.LabelControl14.Text = "Tipo de Aplicación:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(48, 98)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl2.TabIndex = 44
        Me.LabelControl2.Text = "Número de Comprobante:"
        '
        'teNumeroComprobante
        '
        Me.teNumeroComprobante.EditValue = ""
        Me.teNumeroComprobante.EnterMoveNextControl = True
        Me.teNumeroComprobante.Location = New System.Drawing.Point(175, 95)
        Me.teNumeroComprobante.Name = "teNumeroComprobante"
        Me.teNumeroComprobante.Properties.ReadOnly = True
        Me.teNumeroComprobante.Size = New System.Drawing.Size(100, 20)
        Me.teNumeroComprobante.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(67, 142)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl5.TabIndex = 52
        Me.LabelControl5.Text = "Fecha/Hora Creación:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(409, 185)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl10.TabIndex = 51
        Me.LabelControl10.Text = "Saldo Actual:"
        '
        'teCreadoPor
        '
        Me.teCreadoPor.Location = New System.Drawing.Point(474, 116)
        Me.teCreadoPor.Name = "teCreadoPor"
        Me.teCreadoPor.Properties.ReadOnly = True
        Me.teCreadoPor.Size = New System.Drawing.Size(135, 20)
        Me.teCreadoPor.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(414, 119)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Creado Por:"
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EditValue = "0"
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(278, 34)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 1
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(68, 63)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl11.TabIndex = 92
        Me.LabelControl11.Text = "Nombre del Asociado:"
        '
        'teAsociado
        '
        Me.teAsociado.Location = New System.Drawing.Point(175, 60)
        Me.teAsociado.Name = "teAsociado"
        Me.teAsociado.Properties.ReadOnly = True
        Me.teAsociado.Size = New System.Drawing.Size(440, 20)
        Me.teAsociado.TabIndex = 2
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(175, 34)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(99, 20)
        Me.beNumeroCuenta.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(78, 37)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl12.TabIndex = 91
        Me.LabelControl12.Text = "Número de Cuenta:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(393, 163)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl9.TabIndex = 95
        Me.LabelControl9.Text = "Fecha Contable:"
        '
        'deFechaContable
        '
        Me.deFechaContable.EditValue = Nothing
        Me.deFechaContable.EnterMoveNextControl = True
        Me.deFechaContable.Location = New System.Drawing.Point(474, 160)
        Me.deFechaContable.Name = "deFechaContable"
        Me.deFechaContable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaContable.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaContable.Properties.ReadOnly = True
        Me.deFechaContable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaContable.Size = New System.Drawing.Size(100, 20)
        Me.deFechaContable.TabIndex = 9
        '
        'btReImprimir
        '
        Me.btReImprimir.Location = New System.Drawing.Point(478, 222)
        Me.btReImprimir.Name = "btReImprimir"
        Me.btReImprimir.Size = New System.Drawing.Size(100, 26)
        Me.btReImprimir.TabIndex = 13
        Me.btReImprimir.Text = "Re-Imprimir"
        '
        'aho_frmEliminaComprob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 279)
        Me.Modulo = "Ahorros"
        Me.Name = "aho_frmEliminaComprob"
        Me.Text = "Eliminar"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teIdMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaHoraCreacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaHoraCreacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTipoAplicacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaMov.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaMov.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCreadoPor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaContable.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaContable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teIdMov As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaHoraCreacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teTipoAplicacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaMov As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumeroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCreadoPor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents deFechaContable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btReImprimir As DevExpress.XtraEditors.SimpleButton

End Class
