<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apo_frmGenerarArchivoF915
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sePeriodo = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.sePresenta = New DevExpress.XtraEditors.SpinEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sePeriodo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePresenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.sePresenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.sePeriodo)
        Me.GroupControl1.Size = New System.Drawing.Size(473, 130)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(48, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl2.TabIndex = 48
        Me.LabelControl2.Text = "Periodo que se Genera:"
        '
        'sePeriodo
        '
        Me.sePeriodo.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePeriodo.Location = New System.Drawing.Point(165, 41)
        Me.sePeriodo.Name = "sePeriodo"
        Me.sePeriodo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePeriodo.Properties.DisplayFormat.FormatString = "n0"
        Me.sePeriodo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePeriodo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePeriodo.Properties.Mask.EditMask = "n0"
        Me.sePeriodo.Size = New System.Drawing.Size(73, 20)
        Me.sePeriodo.TabIndex = 47
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(67, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 50
        Me.LabelControl1.Text = "Ejercicio a Generar:"
        '
        'sePresenta
        '
        Me.sePresenta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePresenta.Location = New System.Drawing.Point(165, 67)
        Me.sePresenta.Name = "sePresenta"
        Me.sePresenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePresenta.Properties.DisplayFormat.FormatString = "n0"
        Me.sePresenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePresenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.sePresenta.Properties.Mask.EditMask = "n0"
        Me.sePresenta.Size = New System.Drawing.Size(73, 20)
        Me.sePresenta.TabIndex = 49
        '
        'apo_frmGenerarArchivoF915
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(473, 155)
        Me.Name = "apo_frmGenerarArchivoF915"
        Me.Text = "Generar Archivo F915"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.sePeriodo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePresenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sePresenta As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sePeriodo As DevExpress.XtraEditors.SpinEdit

End Class
