<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmListadoGeneralPrestamos
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
        Me.leFinanciamiento = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.leTecnico = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
        Me.cboLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.chkIncluir = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.chkIncluir)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.leFinanciamiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.leTecnico)
        Me.GroupControl1.Controls.Add(Me.LabelControl28)
        Me.GroupControl1.Controls.Add(Me.cboLinea)
        Me.GroupControl1.Controls.Add(Me.LabelControl32)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 217)
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(209, 33)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 135
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(97, 37)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl4.TabIndex = 146
        Me.LabelControl4.Text = "Seleccione la Sucursal:"
        '
        'leFinanciamiento
        '
        Me.leFinanciamiento.EnterMoveNextControl = True
        Me.leFinanciamiento.Location = New System.Drawing.Point(210, 108)
        Me.leFinanciamiento.Name = "leFinanciamiento"
        Me.leFinanciamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFinanciamiento.Size = New System.Drawing.Size(365, 20)
        Me.leFinanciamiento.TabIndex = 138
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(25, 111)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(180, 13)
        Me.LabelControl6.TabIndex = 145
        Me.LabelControl6.Text = "Seleccione Fuente de Financiamiento:"
        '
        'leTecnico
        '
        Me.leTecnico.EnterMoveNextControl = True
        Me.leTecnico.Location = New System.Drawing.Point(210, 82)
        Me.leTecnico.Name = "leTecnico"
        Me.leTecnico.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTecnico.Size = New System.Drawing.Size(365, 20)
        Me.leTecnico.TabIndex = 137
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(112, 85)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl28.TabIndex = 144
        Me.LabelControl28.Text = "Seleccione Técnico:"
        '
        'cboLinea
        '
        Me.cboLinea.EnterMoveNextControl = True
        Me.cboLinea.Location = New System.Drawing.Point(209, 56)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboLinea.Size = New System.Drawing.Size(365, 20)
        Me.cboLinea.TabIndex = 136
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(59, 59)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(146, 13)
        Me.LabelControl32.TabIndex = 143
        Me.LabelControl32.Text = "Seleccione la Linea de Crédito:"
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(209, 134)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 140
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(141, 138)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 142
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoSizeInLayoutControl = True
        Me.chkIncluir.Location = New System.Drawing.Point(207, 170)
        Me.chkIncluir.Name = "chkIncluir"
        Me.chkIncluir.Properties.Caption = "Incluir Prestamos Cancelados"
        Me.chkIncluir.Size = New System.Drawing.Size(200, 19)
        Me.chkIncluir.TabIndex = 147
        '
        'pre_frmListadoGeneralPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 242)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmListadoGeneralPrestamos"
        Me.Text = "Listado General de Préstamos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTecnico.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leFinanciamiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTecnico As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIncluir As DevExpress.XtraEditors.CheckEdit

End Class
