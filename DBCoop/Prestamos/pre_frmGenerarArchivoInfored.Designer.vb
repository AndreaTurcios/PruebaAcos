<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmGenerarArchivoInfored
    Inherits Bravio.gen_frmBase

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
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(130, 59)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 2
        Me.sbGuardar.Text = "&Generar"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(130, 25)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(65, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 150
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'pre_frmGenerarArchivoInfored
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(498, 176)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.deHasta)
        Me.Controls.Add(Me.LabelControl3)
        Me.Name = "pre_frmGenerarArchivoInfored"
        Me.Text = "Generar Archivo InfoRed"
        Me.TipoFormulario = 2
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.deHasta, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
