<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmPrestamosSaldosFacturas
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
        Me.leLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leLinea)
        Me.GroupControl1.Controls.Add(Me.LabelControl28)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Size = New System.Drawing.Size(617, 182)
        '
        'leLinea
        '
        Me.leLinea.EnterMoveNextControl = True
        Me.leLinea.Location = New System.Drawing.Point(167, 50)
        Me.leLinea.Name = "leLinea"
        Me.leLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLinea.Size = New System.Drawing.Size(365, 20)
        Me.leLinea.TabIndex = 149
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(27, 53)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl28.TabIndex = 154
        Me.LabelControl28.Text = "Seleccione Linea de Crédito:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(167, 76)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 151
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(99, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 152
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'pre_frmPrestamosSaldosFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(617, 207)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmPrestamosSaldosFacturas"
        Me.Text = "Préstamos Por Facturación Pendientes de Cobro"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
