<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmAlertas
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
        Me.teIdAlerta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
        Me.leProceso = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
        Me.teNombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.teNumCliente = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaDefinicion = New DevExpress.XtraEditors.DateEdit
        Me.teIdCliente = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.beNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaVencimiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teAlerta = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.chkClave = New DevExpress.XtraEditors.CheckEdit
        CType(Me.teIdAlerta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leProceso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDefinicion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaDefinicion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAlerta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkClave.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teIdAlerta
        '
        Me.teIdAlerta.EnterMoveNextControl = True
        Me.teIdAlerta.Location = New System.Drawing.Point(137, 13)
        Me.teIdAlerta.Name = "teIdAlerta"
        Me.teIdAlerta.Size = New System.Drawing.Size(100, 20)
        Me.teIdAlerta.TabIndex = 0
        '
        'LabelControl59
        '
        Me.LabelControl59.Location = New System.Drawing.Point(87, 16)
        Me.LabelControl59.Name = "LabelControl59"
        Me.LabelControl59.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl59.TabIndex = 68
        Me.LabelControl59.Text = "Id Alerta:"
        '
        'leProceso
        '
        Me.leProceso.EnterMoveNextControl = True
        Me.leProceso.Location = New System.Drawing.Point(137, 158)
        Me.leProceso.Name = "leProceso"
        Me.leProceso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leProceso.Size = New System.Drawing.Size(215, 20)
        Me.leProceso.TabIndex = 8
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(28, 162)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl33.TabIndex = 65
        Me.LabelControl33.Text = "Proceso al que Aplica:"
        '
        'teNombreCliente
        '
        Me.teNombreCliente.Location = New System.Drawing.Point(137, 60)
        Me.teNombreCliente.Name = "teNombreCliente"
        Me.teNombreCliente.Properties.ReadOnly = True
        Me.teNombreCliente.Size = New System.Drawing.Size(379, 20)
        Me.teNombreCliente.TabIndex = 3
        '
        'teNumCliente
        '
        Me.teNumCliente.EnterMoveNextControl = True
        Me.teNumCliente.Location = New System.Drawing.Point(137, 36)
        Me.teNumCliente.Name = "teNumCliente"
        Me.teNumCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumCliente.Size = New System.Drawing.Size(100, 20)
        Me.teNumCliente.TabIndex = 1
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(31, 39)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl10.TabIndex = 70
        Me.LabelControl10.Text = "Número de Asociado:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(36, 113)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl12.TabIndex = 75
        Me.LabelControl12.Text = "Fecha de Definición:"
        '
        'deFechaDefinicion
        '
        Me.deFechaDefinicion.EditValue = Nothing
        Me.deFechaDefinicion.Location = New System.Drawing.Point(137, 109)
        Me.deFechaDefinicion.Name = "deFechaDefinicion"
        Me.deFechaDefinicion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaDefinicion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaDefinicion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaDefinicion.Size = New System.Drawing.Size(100, 20)
        Me.deFechaDefinicion.TabIndex = 6
        '
        'teIdCliente
        '
        Me.teIdCliente.Location = New System.Drawing.Point(319, 35)
        Me.teIdCliente.Name = "teIdCliente"
        Me.teIdCliente.Properties.ReadOnly = True
        Me.teIdCliente.Size = New System.Drawing.Size(95, 20)
        Me.teIdCliente.TabIndex = 2
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(242, 38)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl30.TabIndex = 70
        Me.LabelControl30.Text = "Id de Asociado:"
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Location = New System.Drawing.Point(244, 84)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(66, 20)
        Me.teIdPrestamo.TabIndex = 5
        Me.teIdPrestamo.Visible = False
        '
        'beNumPrestamo
        '
        Me.beNumPrestamo.EditValue = ""
        Me.beNumPrestamo.EnterMoveNextControl = True
        Me.beNumPrestamo.Location = New System.Drawing.Point(137, 84)
        Me.beNumPrestamo.Name = "beNumPrestamo"
        Me.beNumPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumPrestamo.Properties.Mask.EditMask = "00-0000-0000"
        Me.beNumPrestamo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.beNumPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.beNumPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.beNumPrestamo.TabIndex = 4
        Me.beNumPrestamo.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 88)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 200
        Me.LabelControl2.Text = "Número de Préstamo:"
        Me.LabelControl2.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 137)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl1.TabIndex = 202
        Me.LabelControl1.Text = "Fecha de Vencimiento:"
        '
        'deFechaVencimiento
        '
        Me.deFechaVencimiento.EditValue = Nothing
        Me.deFechaVencimiento.Location = New System.Drawing.Point(137, 134)
        Me.deFechaVencimiento.Name = "deFechaVencimiento"
        Me.deFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaVencimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaVencimiento.Size = New System.Drawing.Size(100, 20)
        Me.deFechaVencimiento.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl3.TabIndex = 203
        Me.LabelControl3.Text = "Nombre de Asociado:"
        '
        'teAlerta
        '
        Me.teAlerta.EnterMoveNextControl = True
        Me.teAlerta.Location = New System.Drawing.Point(137, 184)
        Me.teAlerta.Name = "teAlerta"
        Me.teAlerta.Properties.MaxLength = 150
        Me.teAlerta.Size = New System.Drawing.Size(479, 78)
        Me.teAlerta.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(31, 187)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(100, 13)
        Me.LabelControl4.TabIndex = 242
        Me.LabelControl4.Text = "Alerta o Comentario:"
        '
        'chkClave
        '
        Me.chkClave.Location = New System.Drawing.Point(373, 111)
        Me.chkClave.Name = "chkClave"
        Me.chkClave.Properties.Caption = "Solicitar Contraseña"
        Me.chkClave.Size = New System.Drawing.Size(143, 19)
        Me.chkClave.TabIndex = 243
        '
        'adm_frmAlertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(687, 307)
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
        Me.Modulo = "Administración"
        Me.Name = "adm_frmAlertas"
        Me.OptionId = "001013"
        Me.Text = "Ingreso de Alertas"
        Me.Controls.SetChildIndex(Me.LabelControl59, 0)
        Me.Controls.SetChildIndex(Me.teIdAlerta, 0)
        Me.Controls.SetChildIndex(Me.LabelControl33, 0)
        Me.Controls.SetChildIndex(Me.leProceso, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.LabelControl30, 0)
        Me.Controls.SetChildIndex(Me.teNumCliente, 0)
        Me.Controls.SetChildIndex(Me.teNombreCliente, 0)
        Me.Controls.SetChildIndex(Me.teIdCliente, 0)
        Me.Controls.SetChildIndex(Me.deFechaDefinicion, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.beNumPrestamo, 0)
        Me.Controls.SetChildIndex(Me.teIdPrestamo, 0)
        Me.Controls.SetChildIndex(Me.deFechaVencimiento, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.teAlerta, 0)
        Me.Controls.SetChildIndex(Me.chkClave, 0)
        CType(Me.teIdAlerta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leProceso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDefinicion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaDefinicion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAlerta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkClave.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teIdAlerta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNumCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaDefinicion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents leProceso As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAlerta As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkClave As DevExpress.XtraEditors.CheckEdit

End Class
