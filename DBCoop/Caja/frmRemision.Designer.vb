<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRemision
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
        Me.chkFinal = New DevExpress.XtraEditors.CheckEdit
        Me._monto = New DevExpress.XtraEditors.TextEdit
        Me._NroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._observa = New DevExpress.XtraEditors.MemoEdit
        Me._fecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1.SuspendLayout()
        CType(Me.chkFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(389, 251)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(121, 23)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar e Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFinal)
        Me.GroupBox1.Controls.Add(Me._monto)
        Me.GroupBox1.Controls.Add(Me._NroComprobante)
        Me.GroupBox1.Controls.Add(Me._observa)
        Me.GroupBox1.Controls.Add(Me._fecha)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 235)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'chkFinal
        '
        Me.chkFinal.Location = New System.Drawing.Point(147, 204)
        Me.chkFinal.Name = "chkFinal"
        Me.chkFinal.Properties.Caption = "Remision Final"
        Me.chkFinal.Size = New System.Drawing.Size(103, 20)
        Me.chkFinal.TabIndex = 4
        '
        '_monto
        '
        Me._monto.EnterMoveNextControl = True
        Me._monto.Location = New System.Drawing.Point(150, 91)
        Me._monto.Name = "_monto"
        Me._monto.Properties.Mask.EditMask = "n2"
        Me._monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._monto.Size = New System.Drawing.Size(100, 20)
        Me._monto.TabIndex = 2
        '
        '_NroComprobante
        '
        Me._NroComprobante.EditValue = ""
        Me._NroComprobante.EnterMoveNextControl = True
        Me._NroComprobante.Location = New System.Drawing.Point(150, 39)
        Me._NroComprobante.Name = "_NroComprobante"
        Me._NroComprobante.Size = New System.Drawing.Size(100, 20)
        Me._NroComprobante.TabIndex = 0
        '
        '_observa
        '
        Me._observa.EnterMoveNextControl = True
        Me._observa.Location = New System.Drawing.Point(150, 117)
        Me._observa.Name = "_observa"
        Me._observa.Properties.MaxLength = 150
        Me._observa.Size = New System.Drawing.Size(317, 76)
        Me._observa.TabIndex = 3
        '
        '_fecha
        '
        Me._fecha.EditValue = Nothing
        Me._fecha.EnterMoveNextControl = True
        Me._fecha.Location = New System.Drawing.Point(150, 65)
        Me._fecha.Name = "_fecha"
        Me._fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._fecha.Properties.ReadOnly = True
        Me._fecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._fecha.Size = New System.Drawing.Size(100, 20)
        Me._fecha.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(73, 120)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Observaciones"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 94)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Monto de la Operacion:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(111, 68)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No. de Comprobante:"
        '
        'frmRemision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 287)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.KeyPreview = True
        Me.Name = "frmRemision"
        Me.Text = "REMISION DE EFECTIVO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.chkFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _observa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents _fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkFinal As DevExpress.XtraEditors.CheckEdit
End Class
