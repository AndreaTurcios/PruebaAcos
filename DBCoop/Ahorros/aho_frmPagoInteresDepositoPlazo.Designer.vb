<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmPagoInteresDepositoPlazo
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
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btProceder = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btProceder)
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 289)
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(187, 37)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.ReadOnly = True
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(83, 20)
        Me.deFecha.TabIndex = 52
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(43, 40)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(138, 13)
        Me.LabelControl5.TabIndex = 53
        Me.LabelControl5.Text = "Fecha para Ejecutar Calculo:"
        '
        'btProceder
        '
        Me.btProceder.Location = New System.Drawing.Point(187, 66)
        Me.btProceder.Name = "btProceder"
        Me.btProceder.Size = New System.Drawing.Size(167, 26)
        Me.btProceder.TabIndex = 54
        Me.btProceder.Text = "&Proceder con el cálculo"
        '
        'aho_frmPagoInteresDepositoPlazo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 314)
        Me.Modulo = "Ahorros"
        Me.Name = "aho_frmPagoInteresDepositoPlazo"
        Me.Text = "Pago de Intereses Depositos a Plazo"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btProceder As DevExpress.XtraEditors.SimpleButton

End Class
