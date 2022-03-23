<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmDictamenGerencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmDictamenGerencia))
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.meRecomendacion = New DevExpress.XtraEditors.MemoEdit
        Me.teTipoTramite = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.meOtrasCondiciones = New DevExpress.XtraEditors.MemoEdit
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.meRecomendacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTipoTramite.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meOtrasCondiciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl6.TabIndex = 141
        Me.LabelControl6.Text = "Recomendaciones:"
        '
        'meRecomendacion
        '
        Me.meRecomendacion.EnterMoveNextControl = True
        Me.meRecomendacion.Location = New System.Drawing.Point(108, 31)
        Me.meRecomendacion.Name = "meRecomendacion"
        Me.meRecomendacion.Size = New System.Drawing.Size(449, 101)
        Me.meRecomendacion.TabIndex = 140
        '
        'teTipoTramite
        '
        Me.teTipoTramite.EnterMoveNextControl = True
        Me.teTipoTramite.Location = New System.Drawing.Point(108, 147)
        Me.teTipoTramite.Name = "teTipoTramite"
        Me.teTipoTramite.Size = New System.Drawing.Size(449, 20)
        Me.teTipoTramite.TabIndex = 142
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(24, 150)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl34.TabIndex = 143
        Me.LabelControl34.Text = "Tipo de Tramite:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 186)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(249, 13)
        Me.LabelControl1.TabIndex = 145
        Me.LabelControl1.Text = "Otras Condiciones que complementan la Resolución:"
        '
        'meOtrasCondiciones
        '
        Me.meOtrasCondiciones.EnterMoveNextControl = True
        Me.meOtrasCondiciones.Location = New System.Drawing.Point(108, 205)
        Me.meOtrasCondiciones.Name = "meOtrasCondiciones"
        Me.meOtrasCondiciones.Size = New System.Drawing.Size(449, 93)
        Me.meOtrasCondiciones.TabIndex = 144
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(108, 304)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(137, 40)
        Me.sbGuardar.TabIndex = 165
        Me.sbGuardar.Text = "&Guardar"
        '
        'pre_frmDictamenGerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 352)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.meOtrasCondiciones)
        Me.Controls.Add(Me.teTipoTramite)
        Me.Controls.Add(Me.LabelControl34)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.meRecomendacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmDictamenGerencia"
        Me.Text = "Resolución y Recomendaciones Gerencia"
        CType(Me.meRecomendacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTipoTramite.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meOtrasCondiciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meRecomendacion As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents teTipoTramite As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents meOtrasCondiciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
End Class
