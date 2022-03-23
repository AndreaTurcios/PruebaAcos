<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aso_frmCambioValorPresEfectivo
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
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btCambio = New DevExpress.XtraEditors.SimpleButton
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teNumAsociado = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.rgOpcion = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teMotivo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgOpcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMotivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.teMotivo)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.rgOpcion)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.teIdAsociado)
        Me.GroupControl1.Controls.Add(Me.teNombreAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.teNumAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.btCambio)
        Me.GroupControl1.Controls.Add(Me.seTasa)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 357)
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(142, 209)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "d"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Size = New System.Drawing.Size(100, 20)
        Me.seTasa.TabIndex = 89
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(73, 211)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl4.TabIndex = 90
        Me.LabelControl4.Text = "Nuevo Valor:"
        '
        'btCambio
        '
        Me.btCambio.Location = New System.Drawing.Point(143, 278)
        Me.btCambio.Name = "btCambio"
        Me.btCambio.Size = New System.Drawing.Size(162, 44)
        Me.btCambio.TabIndex = 91
        Me.btCambio.Text = "Aceptar Cambio "
        '
        'teIdAsociado
        '
        Me.teIdAsociado.Location = New System.Drawing.Point(142, 56)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teIdAsociado.TabIndex = 93
        '
        'teNombreAsociado
        '
        Me.teNombreAsociado.Location = New System.Drawing.Point(142, 78)
        Me.teNombreAsociado.Name = "teNombreAsociado"
        Me.teNombreAsociado.Properties.ReadOnly = True
        Me.teNombreAsociado.Size = New System.Drawing.Size(402, 20)
        Me.teNombreAsociado.TabIndex = 94
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 82)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 97
        Me.LabelControl3.Text = "Nombre del Asociado:"
        '
        'teNumAsociado
        '
        Me.teNumAsociado.EditValue = ""
        Me.teNumAsociado.EnterMoveNextControl = True
        Me.teNumAsociado.Location = New System.Drawing.Point(142, 34)
        Me.teNumAsociado.Name = "teNumAsociado"
        Me.teNumAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teNumAsociado.TabIndex = 92
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(58, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Id del Asociado:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(33, 37)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl8.TabIndex = 96
        Me.LabelControl8.Text = "Número de Asociado:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(282, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(162, 13)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Text = "En blanco para actualizar todos..."
        '
        'rgOpcion
        '
        Me.rgOpcion.Location = New System.Drawing.Point(142, 104)
        Me.rgOpcion.Name = "rgOpcion"
        Me.rgOpcion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Prestamo en Efectivo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Aportaciones"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ahorro"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Ayuda Funeraria")})
        Me.rgOpcion.Size = New System.Drawing.Size(145, 96)
        Me.rgOpcion.TabIndex = 99
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(102, 110)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl5.TabIndex = 100
        Me.LabelControl5.Text = "Rubro:"
        '
        'teMotivo
        '
        Me.teMotivo.Location = New System.Drawing.Point(142, 235)
        Me.teMotivo.Name = "teMotivo"
        Me.teMotivo.Size = New System.Drawing.Size(402, 20)
        Me.teMotivo.TabIndex = 101
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(46, 238)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl6.TabIndex = 102
        Me.LabelControl6.Text = "Motivo de Cambio:"
        '
        'aso_frmCambioValorPresEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 382)
        Me.Modulo = "Asociados"
        Me.Name = "aso_frmCambioValorPresEfectivo"
        Me.Text = "Actualizar Descuentos Socios"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgOpcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMotivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btCambio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgOpcion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMotivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl

End Class
