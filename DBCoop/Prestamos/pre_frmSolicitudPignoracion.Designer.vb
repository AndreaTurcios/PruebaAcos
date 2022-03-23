<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmSolicitudPignoracion
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmSolicitudPignoracion))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teNombres = New DevExpress.XtraEditors.TextEdit
        Me.teValorPignorado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValorPignorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(48, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 85
        Me.LabelControl2.Text = "Id. Asociado:"
        '
        'teIdAsociado
        '
        Me.teIdAsociado.Location = New System.Drawing.Point(118, 47)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(99, 20)
        Me.teIdAsociado.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl3.TabIndex = 87
        Me.LabelControl3.Text = "A Nombre de:"
        '
        'teNombres
        '
        Me.teNombres.Location = New System.Drawing.Point(118, 72)
        Me.teNombres.Name = "teNombres"
        Me.teNombres.Properties.ReadOnly = True
        Me.teNombres.Size = New System.Drawing.Size(410, 20)
        Me.teNombres.TabIndex = 3
        '
        'teValorPignorado
        '
        Me.teValorPignorado.EditValue = 0
        Me.teValorPignorado.Location = New System.Drawing.Point(118, 98)
        Me.teValorPignorado.Name = "teValorPignorado"
        Me.teValorPignorado.Properties.Appearance.Options.UseTextOptions = True
        Me.teValorPignorado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValorPignorado.Properties.Mask.EditMask = "n2"
        Me.teValorPignorado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValorPignorado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValorPignorado.Size = New System.Drawing.Size(101, 20)
        Me.teValorPignorado.TabIndex = 4
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(33, 101)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl38.TabIndex = 89
        Me.LabelControl38.Text = "Valor Pignorado:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(522, 101)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 5
        Me.sbGuardar.Text = "&Guardar"
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EditValue = "0"
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(220, 23)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(100, 20)
        Me.teIdCuenta.TabIndex = 1
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(117, 23)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(99, 20)
        Me.beNumeroCuenta.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(20, 26)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl12.TabIndex = 99
        Me.LabelControl12.Text = "Número de Cuenta:"
        '
        'pre_frmSolicitudPignoracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 146)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.beNumeroCuenta)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.teValorPignorado)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teNombres)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teIdAsociado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmSolicitudPignoracion"
        Me.Text = "Pignoracion de Cuentas de Ahorro"
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombres.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValorPignorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombres As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teValorPignorado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
End Class
