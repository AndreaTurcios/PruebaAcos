<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmConsolidadoCarteraFuente
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
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoCartera = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.chkIncluir = New DevExpress.XtraEditors.CheckEdit
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.leFinanciamiento = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoCartera.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leFinanciamiento)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.leTipoCartera)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.chkIncluir)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(622, 202)
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(200, 110)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 163
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(132, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 167
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'leTipoCartera
        '
        Me.leTipoCartera.EnterMoveNextControl = True
        Me.leTipoCartera.Location = New System.Drawing.Point(200, 84)
        Me.leTipoCartera.Name = "leTipoCartera"
        Me.leTipoCartera.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCartera.Size = New System.Drawing.Size(365, 20)
        Me.leTipoCartera.TabIndex = 162
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(64, 87)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(132, 13)
        Me.LabelControl1.TabIndex = 166
        Me.LabelControl1.Text = "Seleccione Tipo de Cartera:"
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoSizeInLayoutControl = True
        Me.chkIncluir.Location = New System.Drawing.Point(198, 147)
        Me.chkIncluir.Name = "chkIncluir"
        Me.chkIncluir.Properties.Caption = "Incluir Prestamos Cancelados"
        Me.chkIncluir.Size = New System.Drawing.Size(200, 19)
        Me.chkIncluir.TabIndex = 164
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(200, 34)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 161
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(152, 37)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 165
        Me.LabelControl4.Text = "Sucursal:"
        '
        'leFinanciamiento
        '
        Me.leFinanciamiento.EnterMoveNextControl = True
        Me.leFinanciamiento.Location = New System.Drawing.Point(200, 58)
        Me.leFinanciamiento.Name = "leFinanciamiento"
        Me.leFinanciamiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leFinanciamiento.Size = New System.Drawing.Size(365, 20)
        Me.leFinanciamiento.TabIndex = 168
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(15, 61)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(180, 13)
        Me.LabelControl6.TabIndex = 169
        Me.LabelControl6.Text = "Seleccione Fuente de Financiamiento:"
        '
        'pre_frmConsolidadoCarteraFuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(622, 227)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmConsolidadoCarteraFuente"
        Me.Text = "Consolidado Cartera por Fuente"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoCartera.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leFinanciamiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoCartera As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIncluir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leFinanciamiento As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl

End Class
