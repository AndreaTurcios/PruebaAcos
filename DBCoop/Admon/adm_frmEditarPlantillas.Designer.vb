<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmEditarPlantillas
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.btEditar = New DevExpress.XtraEditors.SimpleButton
        Me.cboPlantilla = New DevExpress.XtraEditors.ComboBoxEdit
        CType(Me.cboPlantilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(59, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Plantilla a editar:"
        '
        'btEditar
        '
        Me.btEditar.Location = New System.Drawing.Point(143, 78)
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(75, 23)
        Me.btEditar.TabIndex = 7
        Me.btEditar.Text = "Editar"
        '
        'cboPlantilla
        '
        Me.cboPlantilla.Location = New System.Drawing.Point(143, 32)
        Me.cboPlantilla.Name = "cboPlantilla"
        Me.cboPlantilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboPlantilla.Size = New System.Drawing.Size(275, 20)
        Me.cboPlantilla.TabIndex = 8
        '
        'adm_frmEditarPlantillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 164)
        Me.Controls.Add(Me.cboPlantilla)
        Me.Controls.Add(Me.btEditar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmEditarPlantillas"
        Me.OptionId = "001010"
        Me.Text = "Editor Plantillas"
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.btEditar, 0)
        Me.Controls.SetChildIndex(Me.cboPlantilla, 0)
        CType(Me.cboPlantilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btEditar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cboPlantilla As DevExpress.XtraEditors.ComboBoxEdit

End Class
