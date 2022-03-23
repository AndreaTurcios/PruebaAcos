<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRequisicion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRequisicion))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me._Monto = New DevExpress.XtraEditors.TextEdit
        Me._NroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._Observa = New DevExpress.XtraEditors.MemoEdit
        Me._Fecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.cmdGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Observa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Fecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(40, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "No. de Comprobante:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me._Monto)
        Me.GroupBox1.Controls.Add(Me._NroComprobante)
        Me.GroupBox1.Controls.Add(Me._Observa)
        Me.GroupBox1.Controls.Add(Me._Fecha)
        Me.GroupBox1.Controls.Add(Me.LabelControl4)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.LabelControl2)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 218)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        '_Monto
        '
        Me._Monto.EditValue = 0
        Me._Monto.EnterMoveNextControl = True
        Me._Monto.Location = New System.Drawing.Point(150, 91)
        Me._Monto.Name = "_Monto"
        Me._Monto.Properties.Appearance.Options.UseTextOptions = True
        Me._Monto.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me._Monto.Properties.Mask.EditMask = "n2"
        Me._Monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._Monto.Properties.Mask.UseMaskAsDisplayFormat = True
        Me._Monto.Size = New System.Drawing.Size(100, 20)
        Me._Monto.TabIndex = 2
        '
        '_NroComprobante
        '
        Me._NroComprobante.EnterMoveNextControl = True
        Me._NroComprobante.Location = New System.Drawing.Point(150, 39)
        Me._NroComprobante.Name = "_NroComprobante"
        Me._NroComprobante.Size = New System.Drawing.Size(100, 20)
        Me._NroComprobante.TabIndex = 0
        '
        '_Observa
        '
        Me._Observa.EnterMoveNextControl = True
        Me._Observa.Location = New System.Drawing.Point(150, 117)
        Me._Observa.Name = "_Observa"
        Me._Observa.Properties.MaxLength = 150
        Me._Observa.Size = New System.Drawing.Size(319, 78)
        Me._Observa.TabIndex = 3
        '
        '_Fecha
        '
        Me._Fecha.EditValue = Nothing
        Me._Fecha.EnterMoveNextControl = True
        Me._Fecha.Location = New System.Drawing.Point(150, 65)
        Me._Fecha.Name = "_Fecha"
        Me._Fecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._Fecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._Fecha.Properties.ReadOnly = True
        Me._Fecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._Fecha.Size = New System.Drawing.Size(100, 20)
        Me._Fecha.TabIndex = 1
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
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(387, 242)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(121, 23)
        Me.cmdGuardar.TabIndex = 0
        Me.cmdGuardar.Text = "Guardar e Imprimir"
        '
        'frmRequisicion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 282)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRequisicion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REQUISICION DE EFECTIVO"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me._Monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Observa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Fecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Fecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents _NroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _Observa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents _Fecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _Monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdGuardar As DevExpress.XtraEditors.SimpleButton
End Class
