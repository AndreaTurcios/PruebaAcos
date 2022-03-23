<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmInformeAseguradora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmInformeAseguradora))
        Me.deHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.leTipoReporte = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoReporte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupControl1.Size = New System.Drawing.Size(891, 273)
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(219, 54)
        Me.deHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Size = New System.Drawing.Size(150, 26)
        Me.deHasta.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(122, 58)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl3.TabIndex = 147
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(219, 132)
        Me.leSucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(393, 26)
        Me.leSucursal.TabIndex = 149
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(152, 136)
        Me.LabelControl25.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(65, 19)
        Me.LabelControl25.TabIndex = 150
        Me.LabelControl25.Text = "Sucursal:"
        '
        'leTipoReporte
        '
        Me.leTipoReporte.Location = New System.Drawing.Point(219, 92)
        Me.leTipoReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.leTipoReporte.Name = "leTipoReporte"
        Me.leTipoReporte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoReporte.Size = New System.Drawing.Size(393, 26)
        Me.leTipoReporte.TabIndex = 151
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(118, 96)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 19)
        Me.LabelControl1.TabIndex = 152
        Me.LabelControl1.Text = "Tipo Reporte:"
        '
        'pre_frmInformeAseguradora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.ClientSize = New System.Drawing.Size(891, 309)
        Me.Controls.Add(Me.leTipoReporte)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.deHasta)
        Me.Controls.Add(Me.LabelControl3)
        Me.IconOptions.Icon = CType(resources.GetObject("pre_frmInformeAseguradora.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "pre_frmInformeAseguradora"
        Me.Text = "Generación de Informes para Aseguradora"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.deHasta, 0)
        Me.Controls.SetChildIndex(Me.LabelControl25, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.leTipoReporte, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoReporte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoReporte As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
