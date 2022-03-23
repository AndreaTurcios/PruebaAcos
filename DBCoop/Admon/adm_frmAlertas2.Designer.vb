<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmAlertas2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adm_frmAlertas2))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.chkClave = New DevExpress.XtraEditors.CheckEdit
        Me.teAlerta = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaVencimiento = New DevExpress.XtraEditors.DateEdit
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.beNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaDefinicion = New DevExpress.XtraEditors.DateEdit
        Me.teIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.teNombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.teNumCliente = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.leProceso = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.teIdAlerta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlerta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDefinicion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDefinicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAlerta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(182, 267)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 64
        Me.sbGuardar.Text = "&Guardar"
        '
        'chkClave
        '
        Me.chkClave.Location = New System.Drawing.Point(354, 110)
        Me.chkClave.Name = "chkClave"
        Me.chkClave.Properties.Caption = "Solicitar Contraseña"
        Me.chkClave.Size = New System.Drawing.Size(143, 19)
        Me.chkClave.TabIndex = 263
        '
        'teAlerta
        '
        Me.teAlerta.EnterMoveNextControl = True
        Me.teAlerta.Location = New System.Drawing.Point(118, 183)
        Me.teAlerta.Name = "teAlerta"
        Me.teAlerta.Properties.MaxLength = 150
        Me.teAlerta.Size = New System.Drawing.Size(479, 78)
        Me.teAlerta.TabIndex = 253
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 186)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 262
        Me.LabelControl4.Text = "Alerta o Comentario:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl3.TabIndex = 261
        Me.LabelControl3.Text = "Nombre de Asociado:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 136)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl1.TabIndex = 260
        Me.LabelControl1.Text = "Fecha de Vencimiento:"
        '
        'deFechaVencimiento
        '
        Me.deFechaVencimiento.EditValue = Nothing
        Me.deFechaVencimiento.Location = New System.Drawing.Point(118, 133)
        Me.deFechaVencimiento.Name = "deFechaVencimiento"
        Me.deFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaVencimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaVencimiento.Size = New System.Drawing.Size(100, 20)
        Me.deFechaVencimiento.TabIndex = 251
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Location = New System.Drawing.Point(225, 83)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(66, 20)
        Me.teIdPrestamo.TabIndex = 249
        Me.teIdPrestamo.Visible = False
        '
        'beNumPrestamo
        '
        Me.beNumPrestamo.EditValue = ""
        Me.beNumPrestamo.EnterMoveNextControl = True
        Me.beNumPrestamo.Location = New System.Drawing.Point(118, 83)
        Me.beNumPrestamo.Name = "beNumPrestamo"
        Me.beNumPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumPrestamo.Properties.Mask.EditMask = "00-0000-0000"
        Me.beNumPrestamo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.beNumPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.beNumPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.beNumPrestamo.TabIndex = 248
        Me.beNumPrestamo.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 259
        Me.LabelControl2.Text = "Número de Préstamo:"
        Me.LabelControl2.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(17, 112)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl12.TabIndex = 258
        Me.LabelControl12.Text = "Fecha de Definición:"
        '
        'deFechaDefinicion
        '
        Me.deFechaDefinicion.EditValue = Nothing
        Me.deFechaDefinicion.Location = New System.Drawing.Point(118, 108)
        Me.deFechaDefinicion.Name = "deFechaDefinicion"
        Me.deFechaDefinicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDefinicion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaDefinicion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaDefinicion.Size = New System.Drawing.Size(100, 20)
        Me.deFechaDefinicion.TabIndex = 250
        '
        'teIdCliente
        '
        Me.teIdCliente.Location = New System.Drawing.Point(300, 34)
        Me.teIdCliente.Name = "teIdCliente"
        Me.teIdCliente.Properties.ReadOnly = True
        Me.teIdCliente.Size = New System.Drawing.Size(95, 20)
        Me.teIdCliente.TabIndex = 246
        '
        'teNombreCliente
        '
        Me.teNombreCliente.Location = New System.Drawing.Point(118, 59)
        Me.teNombreCliente.Name = "teNombreCliente"
        Me.teNombreCliente.Properties.ReadOnly = True
        Me.teNombreCliente.Size = New System.Drawing.Size(379, 20)
        Me.teNombreCliente.TabIndex = 247
        '
        'teNumCliente
        '
        Me.teNumCliente.EnterMoveNextControl = True
        Me.teNumCliente.Location = New System.Drawing.Point(118, 35)
        Me.teNumCliente.Name = "teNumCliente"
        Me.teNumCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumCliente.Size = New System.Drawing.Size(100, 20)
        Me.teNumCliente.TabIndex = 245
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(223, 37)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl30.TabIndex = 256
        Me.LabelControl30.Text = "Id de Asociado:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl10.TabIndex = 257
        Me.LabelControl10.Text = "Número de Asociado:"
        '
        'leProceso
        '
        Me.leProceso.EnterMoveNextControl = True
        Me.leProceso.Location = New System.Drawing.Point(118, 157)
        Me.leProceso.Name = "leProceso"
        Me.leProceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leProceso.Size = New System.Drawing.Size(215, 20)
        Me.leProceso.TabIndex = 252
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(9, 161)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl33.TabIndex = 254
        Me.LabelControl33.Text = "Proceso al que Aplica:"
        '
        'teIdAlerta
        '
        Me.teIdAlerta.EnterMoveNextControl = True
        Me.teIdAlerta.Location = New System.Drawing.Point(118, 12)
        Me.teIdAlerta.Name = "teIdAlerta"
        Me.teIdAlerta.Size = New System.Drawing.Size(100, 20)
        Me.teIdAlerta.TabIndex = 244
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(68, 15)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl59.TabIndex = 255
        Me.LabelControl59.Text = "Id Alerta:"
        '
        'adm_frmAlertas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 305)
        Me.Controls.Add(Me.chkClave)
        Me.Controls.Add(Me.teAlerta)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.deFechaVencimiento)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.beNumPrestamo)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.deFechaDefinicion)
        Me.Controls.Add(Me.teIdCliente)
        Me.Controls.Add(Me.teNombreCliente)
        Me.Controls.Add(Me.teNumCliente)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.leProceso)
        Me.Controls.Add(Me.LabelControl33)
        Me.Controls.Add(Me.teIdAlerta)
        Me.Controls.Add(Me.LabelControl59)
        Me.Controls.Add(Me.sbGuardar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "adm_frmAlertas2"
        Me.Text = "Ingreso de Alertas"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlerta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDefinicion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDefinicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAlerta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkClave As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents teAlerta As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaDefinicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leProceso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAlerta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
End Class
