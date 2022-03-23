<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmListadoPagosLinea
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
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.leLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.cboForma = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.deDesde = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboForma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.leLinea)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.leTecnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl28)
        Me.GroupControl1.Controls.Add(Me.cboForma)
        Me.GroupControl1.Controls.Add(Me.LabelControl32)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.deDesde)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 232)
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(199, 40)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 159
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(87, 44)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl4.TabIndex = 170
        Me.LabelControl4.Text = "Seleccione la Sucursal:"
        '
        'leLinea
        '
        Me.leLinea.EnterMoveNextControl = True
        Me.leLinea.Location = New System.Drawing.Point(200, 94)
        Me.leLinea.Name = "leLinea"
        Me.leLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLinea.Size = New System.Drawing.Size(365, 20)
        Me.leLinea.TabIndex = 161
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(60, 97)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl6.TabIndex = 169
        Me.LabelControl6.Text = "Seleccione Linea de Crédito:"
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(200, 68)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Size = New System.Drawing.Size(365, 20)
        Me.leTecnico.TabIndex = 160
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(102, 71)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl28.TabIndex = 168
        Me.LabelControl28.Text = "Seleccione Técnico:"
        '
        'cboForma
        '
        Me.cboForma.EnterMoveNextControl = True
        Me.cboForma.Location = New System.Drawing.Point(200, 123)
        Me.cboForma.Name = "cboForma"
        Me.cboForma.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboForma.Size = New System.Drawing.Size(284, 20)
        Me.cboForma.TabIndex = 162
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(55, 126)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(140, 13)
        Me.LabelControl32.TabIndex = 167
        Me.LabelControl32.Text = "Seleccione la Forma de Pago:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(384, 158)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 164
        '
        'deDesde
        '
        Me.deDesde.EditValue = Nothing
        Me.deDesde.EnterMoveNextControl = True
        Me.deDesde.Location = New System.Drawing.Point(199, 158)
        Me.deDesde.Name = "deDesde"
        Me.deDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesde.Size = New System.Drawing.Size(100, 20)
        Me.deDesde.TabIndex = 163
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(316, 162)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 166
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(129, 161)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 165
        Me.LabelControl5.Text = "Desde Fecha:"
        '
        'pre_frmListadoPagosLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 257)
        Me.Name = "pre_frmListadoPagosLinea"
        Me.Text = "Listado de pagos por Linea"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboForma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboForma As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl

End Class
