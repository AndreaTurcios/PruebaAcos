<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmClientesPorTecnico
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
        Me.ceIncluir = New DevExpress.XtraEditors.CheckEdit
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.ceIncluir)
        Me.GroupControl1.Controls.Add(Me.leTecnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(691, 221)
        '
        'ceIncluir
        '
        Me.ceIncluir.AutoSizeInLayoutControl = True
        Me.ceIncluir.Location = New System.Drawing.Point(115, 121)
        Me.ceIncluir.Name = "ceIncluir"
        Me.ceIncluir.Properties.Caption = "Incluir Préstamos Cancelados"
        Me.ceIncluir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ceIncluir.Size = New System.Drawing.Size(200, 19)
        Me.ceIncluir.TabIndex = 146
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(117, 63)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Size = New System.Drawing.Size(365, 20)
        Me.leTecnico.TabIndex = 144
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(74, 66)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 145
        Me.LabelControl4.Text = "Técnico:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(117, 89)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 150
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(50, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(117, 37)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 152
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(70, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 153
        Me.LabelControl1.Text = "Sucursal:"
        '
        'pre_frmClientesPorTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(691, 246)
        Me.Name = "pre_frmClientesPorTecnico"
        Me.Text = "Clientes Atendidos por Tecnico"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ceIncluir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
