<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class col_frmPalancaPatrimonial
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
        Me.sbDefinicion = New DevExpress.XtraEditors.SimpleButton
        Me.sbAfecta = New DevExpress.XtraEditors.SimpleButton
        Me.meTexto = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.meMes = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.sbResultado = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.teSituacionAct = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.sbVerFormula = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.meTexto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.teSituacionAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sbVerFormula)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.meTexto)
        Me.GroupControl1.Controls.Add(Me.sbAfecta)
        Me.GroupControl1.Controls.Add(Me.sbDefinicion)
        Me.GroupControl1.Size = New System.Drawing.Size(697, 360)
        '
        'sbDefinicion
        '
        Me.sbDefinicion.Location = New System.Drawing.Point(30, 42)
        Me.sbDefinicion.Name = "sbDefinicion"
        Me.sbDefinicion.Size = New System.Drawing.Size(98, 23)
        Me.sbDefinicion.TabIndex = 1
        Me.sbDefinicion.Text = "Definición"
        '
        'sbAfecta
        '
        Me.sbAfecta.Location = New System.Drawing.Point(139, 42)
        Me.sbAfecta.Name = "sbAfecta"
        Me.sbAfecta.Size = New System.Drawing.Size(98, 23)
        Me.sbAfecta.TabIndex = 2
        Me.sbAfecta.Text = "Cómo se Afecta"
        '
        'meTexto
        '
        Me.meTexto.Location = New System.Drawing.Point(30, 173)
        Me.meTexto.Name = "meTexto"
        Me.meTexto.Size = New System.Drawing.Size(516, 80)
        Me.meTexto.TabIndex = 7
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.meMes)
        Me.GroupControl3.Controls.Add(Me.seAnio)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Location = New System.Drawing.Point(30, 74)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(207, 83)
        Me.GroupControl3.TabIndex = 19
        Me.GroupControl3.Text = "Fecha"
        '
        'meMes
        '
        Me.meMes.Location = New System.Drawing.Point(58, 52)
        Me.meMes.Name = "meMes"
        Me.meMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meMes.Size = New System.Drawing.Size(112, 20)
        Me.meMes.TabIndex = 10
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(58, 28)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Año"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mes"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.sbResultado)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Location = New System.Drawing.Point(307, 61)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(206, 96)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Fórmula"
        '
        'sbResultado
        '
        Me.sbResultado.Location = New System.Drawing.Point(25, 64)
        Me.sbResultado.Name = "sbResultado"
        Me.sbResultado.Size = New System.Drawing.Size(159, 23)
        Me.sbResultado.TabIndex = 19
        Me.sbResultado.Text = "Ver Resultado..."
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl8.Location = New System.Drawing.Point(108, 47)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Activo Total"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(94, 33)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "     Capital Social    "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(80, 38)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "="
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(13, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(65, 26)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Palanca Patrimonial"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.teSituacionAct)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Location = New System.Drawing.Point(279, 259)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(267, 64)
        Me.GroupControl4.TabIndex = 20
        Me.GroupControl4.Text = "Datos"
        '
        'teSituacionAct
        '
        Me.teSituacionAct.Location = New System.Drawing.Point(118, 32)
        Me.teSituacionAct.Name = "teSituacionAct"
        Me.teSituacionAct.Properties.ReadOnly = True
        Me.teSituacionAct.Size = New System.Drawing.Size(100, 20)
        Me.teSituacionAct.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(28, 35)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Situación Actual"
        '
        'sbVerFormula
        '
        Me.sbVerFormula.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbVerFormula.Appearance.Options.UseFont = True
        Me.sbVerFormula.Location = New System.Drawing.Point(561, 61)
        Me.sbVerFormula.Name = "sbVerFormula"
        Me.sbVerFormula.Size = New System.Drawing.Size(121, 41)
        Me.sbVerFormula.TabIndex = 29
        Me.sbVerFormula.Text = "Ver Formula..."
        '
        'col_frmPalancaPatrimonial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 385)
        Me.Name = "col_frmPalancaPatrimonial"
        Me.Text = "Palanca Patrimonial"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.meTexto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.teSituacionAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sbAfecta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbDefinicion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents meTexto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents meMes As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents sbResultado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents teSituacionAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbVerFormula As DevExpress.XtraEditors.SimpleButton
End Class
