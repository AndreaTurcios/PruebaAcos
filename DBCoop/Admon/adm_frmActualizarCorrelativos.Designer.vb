<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmActualizarCorrelativos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmActualizarCorrelativos))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNumAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.teNumVale = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teSolRet = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.teRec = New DevExpress.XtraEditors.TextEdit
        Me.teDepRet = New DevExpress.XtraEditors.TextEdit
        Me.teFactura = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.teResoluciones = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teNumVale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSolRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDepRet.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teResoluciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(66, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No. de Asociado:"
        '
        'teNumAsociado
        '
        Me.teNumAsociado.Location = New System.Drawing.Point(151, 24)
        Me.teNumAsociado.Name = "teNumAsociado"
        Me.teNumAsociado.Size = New System.Drawing.Size(100, 20)
        Me.teNumAsociado.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(92, 29)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Sucursal:"
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(139, 26)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(279, 20)
        Me.leSucursal.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.teResoluciones)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.teNumVale)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.teSolRet)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.teRec)
        Me.GroupControl1.Controls.Add(Me.teDepRet)
        Me.GroupControl1.Controls.Add(Me.teFactura)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 63)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(467, 206)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Ultimo Correlativo por Documento"
        '
        'teNumVale
        '
        Me.teNumVale.Location = New System.Drawing.Point(139, 147)
        Me.teNumVale.Name = "teNumVale"
        Me.teNumVale.Size = New System.Drawing.Size(100, 20)
        Me.teNumVale.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(48, 150)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Vales de Efectivo:"
        '
        'teSolRet
        '
        Me.teSolRet.Location = New System.Drawing.Point(139, 121)
        Me.teSolRet.Name = "teSolRet"
        Me.teSolRet.Size = New System.Drawing.Size(100, 20)
        Me.teSolRet.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(45, 124)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Solicitud de Retiro:"
        '
        'teRec
        '
        Me.teRec.Location = New System.Drawing.Point(139, 95)
        Me.teRec.Name = "teRec"
        Me.teRec.Size = New System.Drawing.Size(100, 20)
        Me.teRec.TabIndex = 3
        '
        'teDepRet
        '
        Me.teDepRet.Location = New System.Drawing.Point(139, 72)
        Me.teDepRet.Name = "teDepRet"
        Me.teDepRet.Size = New System.Drawing.Size(100, 20)
        Me.teDepRet.TabIndex = 3
        '
        'teFactura
        '
        Me.teFactura.Location = New System.Drawing.Point(139, 49)
        Me.teFactura.Name = "teFactura"
        Me.teFactura.Size = New System.Drawing.Size(100, 20)
        Me.teFactura.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(52, 98)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl5.TabIndex = 0
        Me.LabelControl5.Text = "Recibo Corriente:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(39, 76)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Depósitos y Retiros:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(72, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Recibo Pago:"
        '
        'btActualizar
        '
        Me.btActualizar.Location = New System.Drawing.Point(151, 278)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(100, 23)
        Me.btActualizar.TabIndex = 4
        Me.btActualizar.Text = "Actualizar"
        '
        'teResoluciones
        '
        Me.teResoluciones.Location = New System.Drawing.Point(139, 173)
        Me.teResoluciones.Name = "teResoluciones"
        Me.teResoluciones.Size = New System.Drawing.Size(100, 20)
        Me.teResoluciones.TabIndex = 9
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(25, 176)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(109, 13)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = "Resoluciones Créditos:"
        '
        'adm_frmActualizarCorrelativos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 306)
        Me.Controls.Add(Me.btActualizar)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.teNumAsociado)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adm_frmActualizarCorrelativos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ultimos correlativos"
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teNumVale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSolRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDepRet.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teResoluciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teRec As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teDepRet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teSolRet As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumVale As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teResoluciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
