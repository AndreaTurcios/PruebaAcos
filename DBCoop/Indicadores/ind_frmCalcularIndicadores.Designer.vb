<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmCalcularIndicadores
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
        Me.sbCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.meMes = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.sbCalcular)
        Me.GroupControl1.Size = New System.Drawing.Size(468, 158)
        '
        'sbCalcular
        '
        Me.sbCalcular.Location = New System.Drawing.Point(312, 43)
        Me.sbCalcular.Name = "sbCalcular"
        Me.sbCalcular.Size = New System.Drawing.Size(98, 65)
        Me.sbCalcular.TabIndex = 185
        Me.sbCalcular.Text = "Calcular"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.meMes)
        Me.GroupControl3.Controls.Add(Me.seAnio)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Location = New System.Drawing.Point(82, 36)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(207, 83)
        Me.GroupControl3.TabIndex = 186
        Me.GroupControl3.Text = "Fecha"
        '
        'meMes
        '
        Me.meMes.Location = New System.Drawing.Point(58, 52)
        Me.meMes.Name = "meMes"
        Me.meMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meMes.Size = New System.Drawing.Size(112, 20)
        Me.meMes.TabIndex = 10
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(58, 28)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Año"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mes"
        '
        'ind_frmCalcularIndicadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(468, 183)
        Me.Modulo = "Préstamos"
        Me.Name = "ind_frmCalcularIndicadores"
        Me.Text = "Calcular Indicadores"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sbCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents meMes As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl

End Class
