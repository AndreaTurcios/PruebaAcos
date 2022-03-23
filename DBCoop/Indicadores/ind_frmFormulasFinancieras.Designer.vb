<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmFormulasFinancieras
    Inherits Bravio.gen_frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ind_frmFormulasFinancieras))
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.rgTipoOperacion = New DevExpress.XtraEditors.RadioGroup
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        Me.LblCuenta = New DevExpress.XtraEditors.LabelControl
        Me.teFormula = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teValor = New DevExpress.XtraEditors.TextEdit
        Me.LblValor = New DevExpress.XtraEditors.LabelControl
        Me.sbSuma = New DevExpress.XtraEditors.SimpleButton
        Me.sbResta = New DevExpress.XtraEditors.SimpleButton
        Me.sbDivision = New DevExpress.XtraEditors.SimpleButton
        Me.sbMulti = New DevExpress.XtraEditors.SimpleButton
        Me.sbCierraParentesis = New DevExpress.XtraEditors.SimpleButton
        Me.sbAbreParentesis = New DevExpress.XtraEditors.SimpleButton
        Me.sbLimpiar = New DevExpress.XtraEditors.SimpleButton
        Me.sbSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.rgTipoOperacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teFormula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(191, 161)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(140, 30)
        Me.sbGuardar.TabIndex = 16
        Me.sbGuardar.Text = "&Guardar Formula"
        '
        'rgTipoOperacion
        '
        Me.rgTipoOperacion.EditValue = 1
        Me.rgTipoOperacion.Location = New System.Drawing.Point(27, 12)
        Me.rgTipoOperacion.Name = "rgTipoOperacion"
        Me.rgTipoOperacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Cuenta Contable"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Valor de Usuario")})
        Me.rgTipoOperacion.Size = New System.Drawing.Size(165, 56)
        Me.rgTipoOperacion.TabIndex = 186
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(225, 47)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(133, 20)
        Me.beCta01.TabIndex = 187
        '
        'LblCuenta
        '
        Me.LblCuenta.Location = New System.Drawing.Point(227, 31)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(85, 13)
        Me.LblCuenta.TabIndex = 188
        Me.LblCuenta.Text = "Cuenta Contable:"
        '
        'teFormula
        '
        Me.teFormula.EnterMoveNextControl = True
        Me.teFormula.Location = New System.Drawing.Point(193, 89)
        Me.teFormula.Name = "teFormula"
        Me.teFormula.Properties.MaxLength = 150
        Me.teFormula.Properties.ReadOnly = True
        Me.teFormula.Size = New System.Drawing.Size(429, 63)
        Me.teFormula.TabIndex = 243
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(147, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 244
        Me.LabelControl2.Text = "Formula:"
        '
        'teValor
        '
        Me.teValor.EditValue = 0
        Me.teValor.EnterMoveNextControl = True
        Me.teValor.Location = New System.Drawing.Point(226, 46)
        Me.teValor.Name = "teValor"
        Me.teValor.Properties.Appearance.Options.UseTextOptions = True
        Me.teValor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValor.Properties.Mask.EditMask = "n2"
        Me.teValor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValor.Size = New System.Drawing.Size(111, 20)
        Me.teValor.TabIndex = 245
        '
        'LblValor
        '
        Me.LblValor.Location = New System.Drawing.Point(228, 31)
        Me.LblValor.Name = "LblValor"
        Me.LblValor.Size = New System.Drawing.Size(28, 13)
        Me.LblValor.TabIndex = 246
        Me.LblValor.Text = "Valor:"
        '
        'sbSuma
        '
        Me.sbSuma.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbSuma.Appearance.Options.UseFont = True
        Me.sbSuma.Location = New System.Drawing.Point(27, 92)
        Me.sbSuma.Name = "sbSuma"
        Me.sbSuma.Size = New System.Drawing.Size(32, 28)
        Me.sbSuma.TabIndex = 247
        Me.sbSuma.Text = "+"
        '
        'sbResta
        '
        Me.sbResta.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbResta.Appearance.Options.UseFont = True
        Me.sbResta.Location = New System.Drawing.Point(65, 92)
        Me.sbResta.Name = "sbResta"
        Me.sbResta.Size = New System.Drawing.Size(32, 28)
        Me.sbResta.TabIndex = 248
        Me.sbResta.Text = "-"
        '
        'sbDivision
        '
        Me.sbDivision.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbDivision.Appearance.Options.UseFont = True
        Me.sbDivision.Location = New System.Drawing.Point(65, 126)
        Me.sbDivision.Name = "sbDivision"
        Me.sbDivision.Size = New System.Drawing.Size(32, 28)
        Me.sbDivision.TabIndex = 250
        Me.sbDivision.Text = "/"
        '
        'sbMulti
        '
        Me.sbMulti.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbMulti.Appearance.Options.UseFont = True
        Me.sbMulti.Location = New System.Drawing.Point(27, 126)
        Me.sbMulti.Name = "sbMulti"
        Me.sbMulti.Size = New System.Drawing.Size(32, 28)
        Me.sbMulti.TabIndex = 249
        Me.sbMulti.Text = "*"
        '
        'sbCierraParentesis
        '
        Me.sbCierraParentesis.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbCierraParentesis.Appearance.Options.UseFont = True
        Me.sbCierraParentesis.Location = New System.Drawing.Point(65, 160)
        Me.sbCierraParentesis.Name = "sbCierraParentesis"
        Me.sbCierraParentesis.Size = New System.Drawing.Size(32, 28)
        Me.sbCierraParentesis.TabIndex = 252
        Me.sbCierraParentesis.Text = ")"
        '
        'sbAbreParentesis
        '
        Me.sbAbreParentesis.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbAbreParentesis.Appearance.Options.UseFont = True
        Me.sbAbreParentesis.Location = New System.Drawing.Point(27, 160)
        Me.sbAbreParentesis.Name = "sbAbreParentesis"
        Me.sbAbreParentesis.Size = New System.Drawing.Size(32, 28)
        Me.sbAbreParentesis.TabIndex = 251
        Me.sbAbreParentesis.Text = "("
        '
        'sbLimpiar
        '
        Me.sbLimpiar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbLimpiar.Appearance.Options.UseFont = True
        Me.sbLimpiar.Location = New System.Drawing.Point(340, 161)
        Me.sbLimpiar.Name = "sbLimpiar"
        Me.sbLimpiar.Size = New System.Drawing.Size(136, 30)
        Me.sbLimpiar.TabIndex = 253
        Me.sbLimpiar.Text = "&Limpiar Formula"
        '
        'sbSalir
        '
        Me.sbSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbSalir.Appearance.Options.UseFont = True
        Me.sbSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.sbSalir.Location = New System.Drawing.Point(486, 161)
        Me.sbSalir.Name = "sbSalir"
        Me.sbSalir.Size = New System.Drawing.Size(137, 30)
        Me.sbSalir.TabIndex = 254
        Me.sbSalir.Text = "&Salir Sin Guardar"
        '
        'ind_frmFormulasFinancieras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.sbSalir
        Me.ClientSize = New System.Drawing.Size(646, 241)
        Me.Controls.Add(Me.sbSalir)
        Me.Controls.Add(Me.sbLimpiar)
        Me.Controls.Add(Me.sbCierraParentesis)
        Me.Controls.Add(Me.sbAbreParentesis)
        Me.Controls.Add(Me.sbDivision)
        Me.Controls.Add(Me.sbMulti)
        Me.Controls.Add(Me.sbResta)
        Me.Controls.Add(Me.sbSuma)
        Me.Controls.Add(Me.teValor)
        Me.Controls.Add(Me.LblValor)
        Me.Controls.Add(Me.teFormula)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.beCta01)
        Me.Controls.Add(Me.LblCuenta)
        Me.Controls.Add(Me.rgTipoOperacion)
        Me.Controls.Add(Me.sbGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Préstamos"
        Me.Name = "ind_frmFormulasFinancieras"
        Me.OptionId = "003002"
        Me.Text = "Formulas Financieras"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.rgTipoOperacion, 0)
        Me.Controls.SetChildIndex(Me.LblCuenta, 0)
        Me.Controls.SetChildIndex(Me.beCta01, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.teFormula, 0)
        Me.Controls.SetChildIndex(Me.LblValor, 0)
        Me.Controls.SetChildIndex(Me.teValor, 0)
        Me.Controls.SetChildIndex(Me.sbSuma, 0)
        Me.Controls.SetChildIndex(Me.sbResta, 0)
        Me.Controls.SetChildIndex(Me.sbMulti, 0)
        Me.Controls.SetChildIndex(Me.sbDivision, 0)
        Me.Controls.SetChildIndex(Me.sbAbreParentesis, 0)
        Me.Controls.SetChildIndex(Me.sbCierraParentesis, 0)
        Me.Controls.SetChildIndex(Me.sbLimpiar, 0)
        Me.Controls.SetChildIndex(Me.sbSalir, 0)
        CType(Me.rgTipoOperacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teFormula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgTipoOperacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LblCuenta As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teFormula As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teValor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblValor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbSuma As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbResta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbDivision As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbMulti As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbCierraParentesis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbAbreParentesis As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbLimpiar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSalir As DevExpress.XtraEditors.SimpleButton
End Class
