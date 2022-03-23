<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apo_frmEstadoCuentaAyuda
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
        Me.deDesde = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teDui = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teNumAsociado = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.deHasta = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDui.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deDesde)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.teDui)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.teIdAsociado)
        Me.GroupControl1.Controls.Add(Me.teNombreAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.teNumAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Size = New System.Drawing.Size(632, 195)
        '
        'deDesde
        '
        Me.deDesde.EditValue = Nothing
        Me.deDesde.EnterMoveNextControl = True
        Me.deDesde.Location = New System.Drawing.Point(150, 121)
        Me.deDesde.Name = "deDesde"
        Me.deDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesde.Size = New System.Drawing.Size(83, 20)
        Me.deDesde.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(81, 124)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 38
        Me.LabelControl5.Text = "Desde Fecha:"
        '
        'teDui
        '
        Me.teDui.Location = New System.Drawing.Point(150, 97)
        Me.teDui.Name = "teDui"
        Me.teDui.Properties.ReadOnly = True
        Me.teDui.Size = New System.Drawing.Size(100, 20)
        Me.teDui.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(125, 100)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "DUI:"
        '
        'teNombreAsociado
        '
        Me.teNombreAsociado.Location = New System.Drawing.Point(150, 74)
        Me.teNombreAsociado.Name = "teNombreAsociado"
        Me.teNombreAsociado.Properties.ReadOnly = True
        Me.teNombreAsociado.Size = New System.Drawing.Size(402, 20)
        Me.teNombreAsociado.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(43, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Nombre del Asociado:"
        '
        'teNumAsociado
        '
        Me.teNumAsociado.EditValue = ""
        Me.teNumAsociado.EnterMoveNextControl = True
        Me.teNumAsociado.Location = New System.Drawing.Point(150, 30)
        Me.teNumAsociado.Name = "teNumAsociado"
        Me.teNumAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teNumAsociado.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(45, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl8.TabIndex = 32
        Me.LabelControl8.Text = "Número de Asociado:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(70, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 32
        Me.LabelControl2.Text = "Id del Asociado:"
        '
        'teIdAsociado
        '
        Me.teIdAsociado.Location = New System.Drawing.Point(150, 52)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teIdAsociado.TabIndex = 1
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(469, 121)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(83, 20)
        Me.deHasta.TabIndex = 39
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(400, 124)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 40
        Me.LabelControl4.Text = "Hasta Fecha:"
        '
        'apo_frmEstadoCuentaAyuda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(632, 220)
        Me.Modulo = "Aportaciones"
        Me.Name = "apo_frmEstadoCuentaAyuda"
        Me.Text = "Estado de Cuenta Aportes de Ayuda Funeraria"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDui.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDui As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl

End Class
