<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmReportesEstadisticos
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.RadioGroup1 = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.chkIncluir = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.chkIncluir)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.RadioGroup1)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Size = New System.Drawing.Size(513, 362)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(30, 34)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Tipo de Informe:"
        '
        'RadioGroup1
        '
        Me.RadioGroup1.EditValue = 0
        Me.RadioGroup1.Location = New System.Drawing.Point(113, 31)
        Me.RadioGroup1.Name = "RadioGroup1"
        Me.RadioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Por Fuente de Financiamiento"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "por Linea de Prestamo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Por Municipio"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Por Tecnico"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Por Periodo de Plazo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Por Sexo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Por Rango de Edad"), New DevExpress.XtraEditors.Controls.RadioGroupItem(7, "Por Forma de Pago")})
        Me.RadioGroup1.Size = New System.Drawing.Size(289, 217)
        Me.RadioGroup1.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(46, 258)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 0
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.Location = New System.Drawing.Point(113, 255)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(89, 20)
        Me.deHasta.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(66, 284)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Sucursal:"
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(113, 281)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(289, 20)
        Me.leSucursal.TabIndex = 4
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoSizeInLayoutControl = True
        Me.chkIncluir.Location = New System.Drawing.Point(111, 315)
        Me.chkIncluir.Name = "chkIncluir"
        Me.chkIncluir.Properties.Caption = "Incluir Préstamos Cancelados"
        Me.chkIncluir.Size = New System.Drawing.Size(200, 19)
        Me.chkIncluir.TabIndex = 5
        '
        'pre_frmReportesEstadisticos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 387)
        Me.Name = "pre_frmReportesEstadisticos"
        Me.Text = "Reportes Estadísticos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.RadioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RadioGroup1 As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIncluir As DevExpress.XtraEditors.CheckEdit

End Class
