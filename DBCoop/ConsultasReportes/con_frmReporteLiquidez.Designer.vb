<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class con_frmReporteLiquidez
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
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.seEjercicio = New DevExpress.XtraEditors.SpinEdit()
        Me.meMes = New DevExpress.XtraScheduler.UI.MonthEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.seEjercicio)
        Me.GroupControl1.Controls.Add(Me.meMes)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(867, 286)
        Me.GroupControl1.TabIndex = 0
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(104, 55)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(57, 62)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Sucursal:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(47, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 70
        Me.LabelControl5.Text = "Mes y Año:"
        '
        'seEjercicio
        '
        Me.seEjercicio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seEjercicio.Location = New System.Drawing.Point(208, 81)
        Me.seEjercicio.Name = "seEjercicio"
        Me.seEjercicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.seEjercicio.Properties.DisplayFormat.FormatString = "n0"
        Me.seEjercicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seEjercicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.seEjercicio.Properties.Mask.EditMask = "n0"
        Me.seEjercicio.Size = New System.Drawing.Size(73, 20)
        Me.seEjercicio.TabIndex = 69
        '
        'meMes
        '
        Me.meMes.Location = New System.Drawing.Point(104, 81)
        Me.meMes.Name = "meMes"
        Me.meMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meMes.Size = New System.Drawing.Size(100, 20)
        Me.meMes.TabIndex = 68
        '
        'con_frmReporteLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(867, 314)
        Me.Name = "con_frmReporteLiquidez"
        Me.Text = "Reporte de Liquidez"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seEjercicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seEjercicio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents meMes As DevExpress.XtraScheduler.UI.MonthEdit

End Class
