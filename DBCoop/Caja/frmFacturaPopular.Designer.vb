<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturaPopular
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFacturaPopular))
        Me._formPago = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me._FechaIngreso = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me._NombreAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me._formPago.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaIngreso.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaIngreso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_formPago
        '
        Me._formPago.EnterMoveNextControl = True
        Me._formPago.Location = New System.Drawing.Point(168, 46)
        Me._formPago.Name = "_formPago"
        Me._formPago.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._formPago.Size = New System.Drawing.Size(231, 20)
        Me._formPago.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Tipo de Comprobante:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(168, 20)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(231, 20)
        Me.leSucursal.TabIndex = 20
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(120, 22)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Sucursal:"
        '
        '_FechaIngreso
        '
        Me._FechaIngreso.EditValue = Nothing
        Me._FechaIngreso.EnterMoveNextControl = True
        Me._FechaIngreso.Location = New System.Drawing.Point(168, 69)
        Me._FechaIngreso.Name = "_FechaIngreso"
        Me._FechaIngreso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaIngreso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me._FechaIngreso.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me._FechaIngreso.TabIndex = 22
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(76, 71)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl8.TabIndex = 21
        Me.LabelControl8.Text = "Fecha de Factura:"
        '
        '_NombreAsociado
        '
        Me._NombreAsociado.EnterMoveNextControl = True
        Me._NombreAsociado.Location = New System.Drawing.Point(168, 95)
        Me._NombreAsociado.Name = "_NombreAsociado"
        Me._NombreAsociado.Size = New System.Drawing.Size(333, 20)
        Me._NombreAsociado.TabIndex = 24
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(30, 97)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl5.TabIndex = 23
        Me.LabelControl5.Text = "Emitir Factura a Nombre de:"
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(168, 125)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(119, 40)
        Me.sbImprimir.TabIndex = 25
        Me.sbImprimir.Text = "Imprimir"
        '
        'frmFacturaPopular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 197)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me._NombreAsociado)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me._FechaIngreso)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me._formPago)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmFacturaPopular"
        Me.Text = "Factura Linea Popular"
        CType(Me._formPago.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaIngreso.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaIngreso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _formPago As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _FechaIngreso As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _NombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
End Class
