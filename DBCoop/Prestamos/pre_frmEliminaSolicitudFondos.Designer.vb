<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmEliminaSolicitudFondos
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
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.seNumeroDesembolso = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.teIdSolicitudFondo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.teNumSolicitud = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teMontoLiquido = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(184, 110)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(173, 31)
        Me.sbGuardar.TabIndex = 204
        Me.sbGuardar.Text = "&Proceder a Eliminar"
        '
        'seNumeroDesembolso
        '
        Me.seNumeroDesembolso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumeroDesembolso.EnterMoveNextControl = True
        Me.seNumeroDesembolso.Location = New System.Drawing.Point(184, 62)
        Me.seNumeroDesembolso.Name = "seNumeroDesembolso"
        Me.seNumeroDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seNumeroDesembolso.Size = New System.Drawing.Size(49, 20)
        Me.seNumeroDesembolso.TabIndex = 195
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(85, 65)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl5.TabIndex = 206
        Me.LabelControl5.Text = "No. de Desembolso:"
        '
        'teNombre
        '
        Me.teNombre.Enabled = False
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(291, 12)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(395, 20)
        Me.teNombre.TabIndex = 196
        '
        'teIdSolicitudFondo
        '
        Me.teIdSolicitudFondo.EnterMoveNextControl = True
        Me.teIdSolicitudFondo.Location = New System.Drawing.Point(184, 12)
        Me.teIdSolicitudFondo.Name = "teIdSolicitudFondo"
        Me.teIdSolicitudFondo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teIdSolicitudFondo.Size = New System.Drawing.Size(100, 20)
        Me.teIdSolicitudFondo.TabIndex = 194
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(3, 15)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(178, 13)
        Me.LabelControl10.TabIndex = 205
        Me.LabelControl10.Text = "Correlativo de la Solicitud de Fondos:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(389, 37)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 208
        '
        'teNumSolicitud
        '
        Me.teNumSolicitud.EnterMoveNextControl = True
        Me.teNumSolicitud.Location = New System.Drawing.Point(184, 37)
        Me.teNumSolicitud.Name = "teNumSolicitud"
        Me.teNumSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.teNumSolicitud.TabIndex = 207
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(33, 40)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(146, 13)
        Me.LabelControl1.TabIndex = 209
        Me.LabelControl1.Text = "Número de Solicitud Préstamo:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(296, 40)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl2.TabIndex = 210
        Me.LabelControl2.Text = "Fecha de Solicitud:"
        '
        'teMontoLiquido
        '
        Me.teMontoLiquido.EditValue = 0
        Me.teMontoLiquido.EnterMoveNextControl = True
        Me.teMontoLiquido.Location = New System.Drawing.Point(389, 63)
        Me.teMontoLiquido.Name = "teMontoLiquido"
        Me.teMontoLiquido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.teMontoLiquido.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.teMontoLiquido.Properties.Appearance.Options.UseFont = True
        Me.teMontoLiquido.Properties.Appearance.Options.UseForeColor = True
        Me.teMontoLiquido.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoLiquido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoLiquido.Properties.Mask.EditMask = "n2"
        Me.teMontoLiquido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoLiquido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoLiquido.Size = New System.Drawing.Size(101, 20)
        Me.teMontoLiquido.TabIndex = 211
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(256, 66)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl9.TabIndex = 212
        Me.LabelControl9.Text = "Monto Liquido Desembolso:"
        '
        'pre_frmEliminaSolicitudFondos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(706, 185)
        Me.Controls.Add(Me.teMontoLiquido)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.teNumSolicitud)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.seNumeroDesembolso)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdSolicitudFondo)
        Me.Controls.Add(Me.LabelControl10)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmEliminaSolicitudFondos"
        Me.OptionId = "003004"
        Me.Text = "Anular Solicitud Fondos"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.teIdSolicitudFondo, 0)
        Me.Controls.SetChildIndex(Me.teNombre, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.seNumeroDesembolso, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.teNumSolicitud, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.teMontoLiquido, 0)
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSolicitudFondo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoLiquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents seNumeroDesembolso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdSolicitudFondo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teNumSolicitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMontoLiquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl

End Class
