<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmHipotecas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmHipotecas))
        Me.chkGravada = New DevExpress.XtraEditors.CheckEdit
        Me.cboSituacion = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teRegistrada = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.teDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.teArea = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.teDireccion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
        Me.tePropiedad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.teValorPropiedad = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.teNumeroFolio = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNumeroLibro = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.chkGravada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSituacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRegistrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teArea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tePropiedad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValorPropiedad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumeroLibro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkGravada
        '
        Me.chkGravada.Location = New System.Drawing.Point(144, 204)
        Me.chkGravada.Name = "chkGravada"
        Me.chkGravada.Properties.Caption = "Se encuentra Gravada?"
        Me.chkGravada.Size = New System.Drawing.Size(137, 19)
        Me.chkGravada.TabIndex = 8
        '
        'cboSituacion
        '
        Me.cboSituacion.Location = New System.Drawing.Point(146, 229)
        Me.cboSituacion.Name = "cboSituacion"
        Me.cboSituacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSituacion.Size = New System.Drawing.Size(172, 20)
        Me.cboSituacion.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(65, 232)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl5.TabIndex = 143
        Me.LabelControl5.Text = "Situación Actual:"
        '
        'teRegistrada
        '
        Me.teRegistrada.EnterMoveNextControl = True
        Me.teRegistrada.Location = New System.Drawing.Point(146, 130)
        Me.teRegistrada.Name = "teRegistrada"
        Me.teRegistrada.Size = New System.Drawing.Size(172, 20)
        Me.teRegistrada.TabIndex = 5
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(73, 133)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl25.TabIndex = 141
        Me.LabelControl25.Text = "Registrada en:"
        '
        'teDescripcion
        '
        Me.teDescripcion.EnterMoveNextControl = True
        Me.teDescripcion.Location = New System.Drawing.Point(146, 84)
        Me.teDescripcion.Name = "teDescripcion"
        Me.teDescripcion.Size = New System.Drawing.Size(584, 20)
        Me.teDescripcion.TabIndex = 3
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(9, 87)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl27.TabIndex = 134
        Me.LabelControl27.Text = "Descripción de la Propiedad:"
        '
        'teArea
        '
        Me.teArea.EnterMoveNextControl = True
        Me.teArea.Location = New System.Drawing.Point(146, 61)
        Me.teArea.Name = "teArea"
        Me.teArea.Size = New System.Drawing.Size(583, 20)
        Me.teArea.TabIndex = 2
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(40, 65)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl30.TabIndex = 132
        Me.LabelControl30.Text = "Area de la Propiedad:"
        '
        'teDireccion
        '
        Me.teDireccion.EnterMoveNextControl = True
        Me.teDireccion.Location = New System.Drawing.Point(146, 37)
        Me.teDireccion.Name = "teDireccion"
        Me.teDireccion.Size = New System.Drawing.Size(584, 20)
        Me.teDireccion.TabIndex = 1
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(20, 40)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(124, 13)
        Me.LabelControl31.TabIndex = 131
        Me.LabelControl31.Text = "Dirección de la Propiedad:"
        '
        'tePropiedad
        '
        Me.tePropiedad.EnterMoveNextControl = True
        Me.tePropiedad.Location = New System.Drawing.Point(146, 13)
        Me.tePropiedad.Name = "tePropiedad"
        Me.tePropiedad.Size = New System.Drawing.Size(584, 20)
        Me.tePropiedad.TabIndex = 0
        '
        'LabelControl42
        '
        Me.LabelControl42.Location = New System.Drawing.Point(29, 16)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl42.TabIndex = 130
        Me.LabelControl42.Text = "Propiedad a nombre de:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(620, 214)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 10
        Me.sbGuardar.Text = "&Guardar"
        '
        'teValorPropiedad
        '
        Me.teValorPropiedad.EditValue = 0
        Me.teValorPropiedad.EnterMoveNextControl = True
        Me.teValorPropiedad.Location = New System.Drawing.Point(146, 107)
        Me.teValorPropiedad.Name = "teValorPropiedad"
        Me.teValorPropiedad.Properties.Appearance.Options.UseTextOptions = True
        Me.teValorPropiedad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teValorPropiedad.Properties.Mask.EditMask = "n2"
        Me.teValorPropiedad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teValorPropiedad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teValorPropiedad.Size = New System.Drawing.Size(101, 20)
        Me.teValorPropiedad.TabIndex = 4
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(56, 110)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl38.TabIndex = 149
        Me.LabelControl38.Text = "Valor Aproximado:"
        '
        'teNumeroFolio
        '
        Me.teNumeroFolio.EnterMoveNextControl = True
        Me.teNumeroFolio.Location = New System.Drawing.Point(146, 154)
        Me.teNumeroFolio.Name = "teNumeroFolio"
        Me.teNumeroFolio.Size = New System.Drawing.Size(172, 20)
        Me.teNumeroFolio.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(63, 157)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 151
        Me.LabelControl1.Text = "Número de Folio:"
        '
        'teNumeroLibro
        '
        Me.teNumeroLibro.EnterMoveNextControl = True
        Me.teNumeroLibro.Location = New System.Drawing.Point(146, 178)
        Me.teNumeroLibro.Name = "teNumeroLibro"
        Me.teNumeroLibro.Size = New System.Drawing.Size(172, 20)
        Me.teNumeroLibro.TabIndex = 7
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(63, 181)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl2.TabIndex = 153
        Me.LabelControl2.Text = "Número de Libro:"
        '
        'pre_frmHipotecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 261)
        Me.Controls.Add(Me.teNumeroLibro)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teNumeroFolio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teValorPropiedad)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.chkGravada)
        Me.Controls.Add(Me.cboSituacion)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teRegistrada)
        Me.Controls.Add(Me.LabelControl25)
        Me.Controls.Add(Me.teDescripcion)
        Me.Controls.Add(Me.LabelControl27)
        Me.Controls.Add(Me.teArea)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.teDireccion)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.tePropiedad)
        Me.Controls.Add(Me.LabelControl42)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmHipotecas"
        Me.Text = "Ingreso de Hipotecas"
        CType(Me.chkGravada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSituacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRegistrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teArea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tePropiedad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValorPropiedad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroFolio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumeroLibro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkGravada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboSituacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teRegistrada As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teArea As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tePropiedad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teValorPropiedad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumeroFolio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumeroLibro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
