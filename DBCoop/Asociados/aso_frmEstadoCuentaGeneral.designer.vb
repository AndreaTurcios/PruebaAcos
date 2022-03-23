<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aso_frmEstadoCuentaGeneral
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
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.teNumAsociado = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.pbcPorcentaje = New DevExpress.XtraEditors.ProgressBarControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.meComentario = New DevExpress.XtraEditors.MemoEdit()
        Me.chkDesgloze = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.teSerie = New DevExpress.XtraEditors.TextEdit()
        Me.leReferencia = New DevExpress.XtraEditors.LookUpEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meComentario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkDesgloze.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leReferencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leReferencia)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.teSerie)
        Me.GroupControl1.Controls.Add(Me.chkDesgloze)
        Me.GroupControl1.Controls.Add(Me.meComentario)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton2)
        Me.GroupControl1.Controls.Add(Me.pbcPorcentaje)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.teIdAsociado)
        Me.GroupControl1.Controls.Add(Me.teNombreAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.teNumAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Size = New System.Drawing.Size(632, 311)
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(150, 97)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Size = New System.Drawing.Size(134, 20)
        Me.deFecha.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 105)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(123, 13)
        Me.LabelControl5.TabIndex = 38
        Me.LabelControl5.Text = "Consultar hasta la Fecha:"
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
        Me.LabelControl3.Location = New System.Drawing.Point(43, 82)
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
        Me.teNumAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.teNumAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teNumAsociado.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(45, 37)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl8.TabIndex = 32
        Me.LabelControl8.Text = "Número de Asociado:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(70, 59)
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
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(290, 59)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(138, 11)
        Me.LabelControl4.TabIndex = 39
        Me.LabelControl4.Text = "* En blanco para todos los Socios"
        '
        'pbcPorcentaje
        '
        Me.pbcPorcentaje.Location = New System.Drawing.Point(150, 230)
        Me.pbcPorcentaje.Name = "pbcPorcentaje"
        Me.pbcPorcentaje.Size = New System.Drawing.Size(402, 27)
        Me.pbcPorcentaje.TabIndex = 146
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(150, 201)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(134, 23)
        Me.SimpleButton2.TabIndex = 5
        Me.SimpleButton2.Text = "Enviar por e-Mail"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(88, 136)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 148
        Me.LabelControl1.Text = "Comentario:"
        '
        'meComentario
        '
        Me.meComentario.Location = New System.Drawing.Point(150, 120)
        Me.meComentario.Name = "meComentario"
        Me.meComentario.Size = New System.Drawing.Size(402, 58)
        Me.meComentario.TabIndex = 4
        '
        'chkDesgloze
        '
        Me.chkDesgloze.Location = New System.Drawing.Point(150, 263)
        Me.chkDesgloze.Name = "chkDesgloze"
        Me.chkDesgloze.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkDesgloze.Properties.Appearance.Options.UseFont = True
        Me.chkDesgloze.Properties.Caption = "Detalle de Pago"
        Me.chkDesgloze.Size = New System.Drawing.Size(134, 19)
        Me.chkDesgloze.TabIndex = 149
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(53, 293)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl6.TabIndex = 151
        Me.LabelControl6.Text = "Referencia de Pago"
        '
        'teSerie
        '
        Me.teSerie.EnterMoveNextControl = True
        Me.teSerie.Location = New System.Drawing.Point(524, 284)
        Me.teSerie.Name = "teSerie"
        Me.teSerie.Size = New System.Drawing.Size(28, 20)
        Me.teSerie.TabIndex = 150
        Me.teSerie.Visible = False
        '
        'leReferencia
        '
        Me.leReferencia.EnterMoveNextControl = True
        Me.leReferencia.Location = New System.Drawing.Point(153, 288)
        Me.leReferencia.Name = "leReferencia"
        Me.leReferencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leReferencia.Size = New System.Drawing.Size(347, 20)
        Me.leReferencia.TabIndex = 152
        '
        'aso_frmEstadoCuentaGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(632, 339)
        Me.Modulo = "Asociados"
        Me.Name = "aso_frmEstadoCuentaGeneral"
        Me.Text = "Estado de Cuenta General"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meComentario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkDesgloze.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leReferencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pbcPorcentaje As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meComentario As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkDesgloze As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents leReferencia As DevExpress.XtraEditors.LookUpEdit

End Class
