<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmListadoAcuerdos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.rgTipoListado = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.btVer = New DevExpress.XtraEditors.SimpleButton
        Me.sbExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sbSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(306, 74)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 156
        '
        'deDesde
        '
        Me.deDesde.EditValue = Nothing
        Me.deDesde.EnterMoveNextControl = True
        Me.deDesde.Location = New System.Drawing.Point(121, 74)
        Me.deDesde.Name = "deDesde"
        Me.deDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesde.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesde.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesde.Size = New System.Drawing.Size(100, 20)
        Me.deDesde.TabIndex = 155
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(238, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl3.TabIndex = 158
        Me.LabelControl3.Text = "Hasta Fecha:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(51, 77)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 157
        Me.LabelControl5.Text = "Desde Fecha:"
        '
        'rgTipoListado
        '
        Me.rgTipoListado.EditValue = 1
        Me.rgTipoListado.EnterMoveNextControl = True
        Me.rgTipoListado.Location = New System.Drawing.Point(121, 21)
        Me.rgTipoListado.Name = "rgTipoListado"
        Me.rgTipoListado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Fecha de Acuerdo"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Fecha de Vencimiento")})
        Me.rgTipoListado.Size = New System.Drawing.Size(139, 46)
        Me.rgTipoListado.TabIndex = 172
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(56, 23)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl11.TabIndex = 173
        Me.LabelControl11.Text = "Generar Por:"
        '
        'btVer
        '
        Me.btVer.Location = New System.Drawing.Point(121, 115)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(100, 26)
        Me.btVer.TabIndex = 174
        Me.btVer.Text = "&Ver Informe"
        '
        'sbExcel
        '
        Me.sbExcel.Location = New System.Drawing.Point(227, 115)
        Me.sbExcel.Name = "sbExcel"
        Me.sbExcel.Size = New System.Drawing.Size(100, 26)
        Me.sbExcel.TabIndex = 175
        Me.sbExcel.Text = "&Excel"
        '
        'sbSalir
        '
        Me.sbSalir.Location = New System.Drawing.Point(333, 115)
        Me.sbSalir.Name = "sbSalir"
        Me.sbSalir.Size = New System.Drawing.Size(100, 26)
        Me.sbSalir.TabIndex = 176
        Me.sbSalir.Text = "&Salir"
        '
        'pre_frmListadoAcuerdos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 171)
        Me.Controls.Add(Me.sbSalir)
        Me.Controls.Add(Me.sbExcel)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.rgTipoListado)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.deHasta)
        Me.Controls.Add(Me.deDesde)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl5)
        Me.Name = "pre_frmListadoAcuerdos"
        Me.Text = "Listado de Acuerdos de Cobro"
        CType(Me.deHasta.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents deDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTipoListado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btVer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSalir As DevExpress.XtraEditors.SimpleButton
End Class
