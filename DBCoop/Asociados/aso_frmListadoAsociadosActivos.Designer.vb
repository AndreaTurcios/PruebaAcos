<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aso_frmListadoAsociadosActivos
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
        Me.deDesde = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.chkEnvio = New DevExpress.XtraEditors.CheckEdit
        Me.chkDividendos = New DevExpress.XtraEditors.CheckEdit
        Me.chkFuneraria = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkEnvio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDividendos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFuneraria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.chkFuneraria)
        Me.GroupControl1.Controls.Add(Me.chkDividendos)
        Me.GroupControl1.Controls.Add(Me.chkEnvio)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.deDesde)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 222)
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(372, 82)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 50
        '
        'deDesde
        '
        Me.deDesde.EditValue = Nothing
        Me.deDesde.EnterMoveNextControl = True
        Me.deDesde.Location = New System.Drawing.Point(107, 82)
        Me.deDesde.Name = "deDesde"
        Me.deDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesde.Size = New System.Drawing.Size(100, 20)
        Me.deDesde.TabIndex = 49
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(304, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Hasta Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(37, 85)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 51
        Me.LabelControl1.Text = "Desde Fecha:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(107, 51)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 47
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(59, 54)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Sucursal:"
        '
        'chkEnvio
        '
        Me.chkEnvio.Location = New System.Drawing.Point(176, 119)
        Me.chkEnvio.Name = "chkEnvio"
        Me.chkEnvio.Properties.Caption = "Mostrar Solo Asociados sin Envio de Descuento"
        Me.chkEnvio.Size = New System.Drawing.Size(255, 19)
        Me.chkEnvio.TabIndex = 53
        '
        'chkDividendos
        '
        Me.chkDividendos.Location = New System.Drawing.Point(176, 143)
        Me.chkDividendos.Name = "chkDividendos"
        Me.chkDividendos.Properties.Caption = "Mostrar Solo Asociados Excluidos de Dividendos"
        Me.chkDividendos.Size = New System.Drawing.Size(255, 19)
        Me.chkDividendos.TabIndex = 54
        '
        'chkFuneraria
        '
        Me.chkFuneraria.Location = New System.Drawing.Point(176, 169)
        Me.chkFuneraria.Name = "chkFuneraria"
        Me.chkFuneraria.Properties.Caption = "Mostrar solo Asociados Excluidos de Reparto de Ayuda Funeraria"
        Me.chkFuneraria.Size = New System.Drawing.Size(347, 19)
        Me.chkFuneraria.TabIndex = 55
        '
        'aso_frmListadoAsociadosActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 247)
        Me.Name = "aso_frmListadoAsociadosActivos"
        Me.Text = "Listado de Asociados Activos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkEnvio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDividendos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFuneraria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkEnvio As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkFuneraria As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkDividendos As DevExpress.XtraEditors.CheckEdit

End Class
