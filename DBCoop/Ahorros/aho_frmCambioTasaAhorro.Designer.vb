<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmCambioTasaAhorro
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
        Me.teAsociado = New DevExpress.XtraEditors.TextEdit
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.seTasa = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.btCambio = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.btCambio)
        Me.GroupControl1.Controls.Add(Me.seTasa)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.teIdCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.teAsociado)
        Me.GroupControl1.Controls.Add(Me.beNumeroCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 196)
        '
        'teAsociado
        '
        Me.teAsociado.Location = New System.Drawing.Point(143, 65)
        Me.teAsociado.Name = "teAsociado"
        Me.teAsociado.Properties.ReadOnly = True
        Me.teAsociado.Size = New System.Drawing.Size(440, 20)
        Me.teAsociado.TabIndex = 81
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(143, 39)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(99, 20)
        Me.beNumeroCuenta.TabIndex = 80
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(45, 42)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl6.TabIndex = 82
        Me.LabelControl6.Text = "Número de Cuenta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(35, 68)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 83
        Me.LabelControl1.Text = "Nombre del Asociado:"
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EditValue = "0"
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(246, 39)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 88
        '
        'seTasa
        '
        Me.seTasa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasa.EnterMoveNextControl = True
        Me.seTasa.Location = New System.Drawing.Point(142, 91)
        Me.seTasa.Name = "seTasa"
        Me.seTasa.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasa.Properties.Mask.EditMask = "P2"
        Me.seTasa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasa.Size = New System.Drawing.Size(100, 20)
        Me.seTasa.TabIndex = 89
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(29, 94)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl4.TabIndex = 90
        Me.LabelControl4.Text = "Tasa de Interés Anual:"
        '
        'btCambio
        '
        Me.btCambio.Location = New System.Drawing.Point(140, 120)
        Me.btCambio.Name = "btCambio"
        Me.btCambio.Size = New System.Drawing.Size(162, 44)
        Me.btCambio.TabIndex = 91
        Me.btCambio.Text = "Aceptar Cambio Tasa"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(352, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(194, 13)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Text = "** Cero para Cambiar Todas las cuentas"
        '
        'aho_frmCambioTasaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 221)
        Me.Modulo = "Ahorros"
        Me.Name = "aho_frmCambioTasaAhorro"
        Me.Text = "Cambio Tasa Interes Ahorro"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents teAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents seTasa As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btCambio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl

End Class
