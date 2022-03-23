<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmComparativoAnualColac
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
        Me.leIndicador = New DevExpress.XtraEditors.LookUpEdit
        Me.lcTecnico = New DevExpress.XtraEditors.LabelControl
        Me.lcIndicador = New DevExpress.XtraEditors.LabelControl
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.seAnio)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.leIndicador)
        Me.GroupControl1.Controls.Add(Me.lcIndicador)
        Me.GroupControl1.Controls.Add(Me.lcTecnico)
        Me.GroupControl1.Size = New System.Drawing.Size(463, 147)
        '
        'leIndicador
        '
        Me.leIndicador.EnterMoveNextControl = True
        Me.leIndicador.Location = New System.Drawing.Point(129, 76)
        Me.leIndicador.Name = "leIndicador"
        Me.leIndicador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leIndicador.Size = New System.Drawing.Size(285, 20)
        Me.leIndicador.TabIndex = 1
        '
        'lcTecnico
        '
        Me.lcTecnico.Location = New System.Drawing.Point(86, 79)
        Me.lcTecnico.Name = "lcTecnico"
        Me.lcTecnico.Size = New System.Drawing.Size(40, 13)
        Me.lcTecnico.TabIndex = 6
        Me.lcTecnico.Text = "Técnico:"
        Me.lcTecnico.Visible = False
        '
        'lcIndicador
        '
        Me.lcIndicador.Location = New System.Drawing.Point(78, 79)
        Me.lcIndicador.Name = "lcIndicador"
        Me.lcIndicador.Size = New System.Drawing.Size(49, 13)
        Me.lcIndicador.TabIndex = 8
        Me.lcIndicador.Text = "Indicador:"
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(129, 50)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 9
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(102, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Año:"
        '
        'ind_frmComparativoAnualColac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 172)
        Me.Name = "ind_frmComparativoAnualColac"
        Me.Text = "Comparativo Anual Colac"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leIndicador As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcIndicador As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcTecnico As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
