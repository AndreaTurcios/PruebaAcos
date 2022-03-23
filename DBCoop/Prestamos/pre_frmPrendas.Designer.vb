<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmPrendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmPrendas))
        Me.teChasis = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.teMotor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teValorAproximado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.teColor = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.teSerie = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.teModelo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.teMarca = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.teTipoPrenda = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.teDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.teChasis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMotor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValorAproximado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teModelo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMarca.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTipoPrenda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teChasis
        '
        Me.teChasis.EnterMoveNextControl = True
        Me.teChasis.Location = New System.Drawing.Point(142, 154)
        Me.teChasis.Name = "teChasis"
        Me.teChasis.Size = New System.Drawing.Size(172, 20)
        Me.teChasis.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(105, 157)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl2.TabIndex = 173
        Me.LabelControl2.Text = "Chasis:"
        '
        'teMotor
        '
        Me.teMotor.EnterMoveNextControl = True
        Me.teMotor.Location = New System.Drawing.Point(142, 130)
        Me.teMotor.Name = "teMotor"
        Me.teMotor.Size = New System.Drawing.Size(261, 20)
        Me.teMotor.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(108, 134)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl1.TabIndex = 172
        Me.LabelControl1.Text = "Motor:"
        '
        'teValorAproximado
        '
        Me.teValorAproximado.EditValue = 0
        Me.teValorAproximado.EnterMoveNextControl = True
        Me.teValorAproximado.Location = New System.Drawing.Point(142, 178)
        Me.teValorAproximado.Name = "teValorAproximado"
        Me.teValorAproximado.Properties.Appearance.Options.UseTextOptions = True
        Me.teValorAproximado.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValorAproximado.Properties.Mask.EditMask = "n2"
        Me.teValorAproximado.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValorAproximado.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValorAproximado.Size = New System.Drawing.Size(101, 20)
        Me.teValorAproximado.TabIndex = 7
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(52, 181)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl38.TabIndex = 171
        Me.LabelControl38.Text = "Valor Aproximado:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(647, 186)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 9
        Me.sbGuardar.Text = "&Guardar"
        '
        'teColor
        '
        Me.teColor.EnterMoveNextControl = True
        Me.teColor.Location = New System.Drawing.Point(142, 107)
        Me.teColor.Name = "teColor"
        Me.teColor.Size = New System.Drawing.Size(172, 20)
        Me.teColor.TabIndex = 4
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(111, 111)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl25.TabIndex = 169
        Me.LabelControl25.Text = "Color:"
        '
        'teSerie
        '
        Me.teSerie.EnterMoveNextControl = True
        Me.teSerie.Location = New System.Drawing.Point(142, 84)
        Me.teSerie.Name = "teSerie"
        Me.teSerie.Size = New System.Drawing.Size(261, 20)
        Me.teSerie.TabIndex = 3
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(112, 88)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl27.TabIndex = 168
        Me.LabelControl27.Text = "Serie:"
        '
        'teModelo
        '
        Me.teModelo.EnterMoveNextControl = True
        Me.teModelo.Location = New System.Drawing.Point(142, 61)
        Me.teModelo.Name = "teModelo"
        Me.teModelo.Size = New System.Drawing.Size(261, 20)
        Me.teModelo.TabIndex = 2
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(102, 65)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl30.TabIndex = 167
        Me.LabelControl30.Text = "Modelo:"
        '
        'teMarca
        '
        Me.teMarca.EnterMoveNextControl = True
        Me.teMarca.Location = New System.Drawing.Point(142, 37)
        Me.teMarca.Name = "teMarca"
        Me.teMarca.Size = New System.Drawing.Size(261, 20)
        Me.teMarca.TabIndex = 1
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(107, 40)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl31.TabIndex = 166
        Me.LabelControl31.Text = "Marca:"
        '
        'teTipoPrenda
        '
        Me.teTipoPrenda.EnterMoveNextControl = True
        Me.teTipoPrenda.Location = New System.Drawing.Point(142, 13)
        Me.teTipoPrenda.Name = "teTipoPrenda"
        Me.teTipoPrenda.Size = New System.Drawing.Size(490, 20)
        Me.teTipoPrenda.TabIndex = 0
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(64, 16)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl42.TabIndex = 165
        Me.LabelControl42.Text = "Tipo de Prenda:"
        '
        'teDescripcion
        '
        Me.teDescripcion.EnterMoveNextControl = True
        Me.teDescripcion.Location = New System.Drawing.Point(142, 201)
        Me.teDescripcion.Name = "teDescripcion"
        Me.teDescripcion.Size = New System.Drawing.Size(490, 20)
        Me.teDescripcion.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(82, 204)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 175
        Me.LabelControl3.Text = "Descripción:"
        '
        'pre_frmPrendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 241)
        Me.Controls.Add(Me.teDescripcion)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teChasis)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teMotor)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teValorAproximado)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.teColor)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.teSerie)
        Me.Controls.Add(Me.LabelControl27)
        Me.Controls.Add(Me.teModelo)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.teMarca)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.teTipoPrenda)
        Me.Controls.Add(Me.LabelControl42)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmPrendas"
        Me.Text = "Ingreso de Prendas"
        CType(Me.teChasis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMotor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValorAproximado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSerie.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teModelo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMarca.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTipoPrenda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teChasis As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMotor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teValorAproximado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teColor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSerie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teModelo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teMarca As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTipoPrenda As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
