<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmIngresosEgresos
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
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deDesde = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.leCajero = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(327, 83)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 32
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(257, 87)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 37
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(123, 34)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 29
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(76, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "Sucursal:"
        '
        'deDesde
        '
        Me.deDesde.EditValue = Nothing
        Me.deDesde.EnterMoveNextControl = True
        Me.deDesde.Location = New System.Drawing.Point(123, 83)
        Me.deDesde.Name = "deDesde"
        Me.deDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesde.Size = New System.Drawing.Size(100, 20)
        Me.deDesde.TabIndex = 31
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(54, 86)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl7.TabIndex = 35
        Me.LabelControl7.Text = "Desde Fecha:"
        '
        'leCajero
        '
        Me.leCajero.EnterMoveNextControl = True
        Me.leCajero.Location = New System.Drawing.Point(123, 60)
        Me.leCajero.Name = "leCajero"
        Me.leCajero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCajero.Size = New System.Drawing.Size(304, 20)
        Me.leCajero.TabIndex = 30
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(84, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Cajero:"
        '
        'pre_frmIngresosEgresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(510, 155)
        Me.Controls.Add(Me.deHasta)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deDesde)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.leCajero)
        Me.Controls.Add(Me.LabelControl1)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmIngresosEgresos"
        Me.OptionId = "004004003"
        Me.Text = "Informe de Ingresos y Egresos"
        Me.TipoFormulario = 2
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.leCajero, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.deDesde, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.deHasta, 0)
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leCajero As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
