<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmCierreFechasDescuentos
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
        Me.cmdCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.teIdComprobante = New DevExpress.XtraEditors.TextEdit
        Me.beFechaDescuento = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.teIdComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beFechaDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.teIdComprobante)
        Me.GroupControl1.Controls.Add(Me.beFechaDescuento)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.cmdCerrar)
        Me.GroupControl1.Size = New System.Drawing.Size(430, 140)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = ""
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Enabled = False
        Me.cmdCerrar.Location = New System.Drawing.Point(184, 77)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(100, 26)
        Me.cmdCerrar.TabIndex = 12
        Me.cmdCerrar.Text = "&Cerrar"
        '
        'teIdComprobante
        '
        Me.teIdComprobante.EditValue = "0"
        Me.teIdComprobante.EnterMoveNextControl = True
        Me.teIdComprobante.Location = New System.Drawing.Point(257, 39)
        Me.teIdComprobante.Name = "teIdComprobante"
        Me.teIdComprobante.Properties.ReadOnly = True
        Me.teIdComprobante.Size = New System.Drawing.Size(100, 20)
        Me.teIdComprobante.TabIndex = 1
        '
        'beFechaDescuento
        '
        Me.beFechaDescuento.EnterMoveNextControl = True
        Me.beFechaDescuento.Location = New System.Drawing.Point(154, 39)
        Me.beFechaDescuento.Name = "beFechaDescuento"
        Me.beFechaDescuento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beFechaDescuento.Properties.Mask.EditMask = "d"
        Me.beFechaDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.beFechaDescuento.Size = New System.Drawing.Size(99, 20)
        Me.beFechaDescuento.TabIndex = 0
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(46, 42)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl12.TabIndex = 91
        Me.LabelControl12.Text = "Fecha de Descuento:"
        '
        'pre_frmCierreFechasDescuentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(430, 165)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmCierreFechasDescuentos"
        Me.Text = "Cierre Fechas de Descuentos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.teIdComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beFechaDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teIdComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beFechaDescuento As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl

End Class
