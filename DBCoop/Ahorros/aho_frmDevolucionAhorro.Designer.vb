<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmDevolucionAhorro
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.leTipoCuenta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.seDescuento = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.seDescuentoAPartir = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seDescuentoAPartir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.seDescuentoAPartir)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.seDescuento)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.leTipoCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Size = New System.Drawing.Size(624, 229)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(78, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "Saldos Hasta Fecha:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(148, 181)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(171, 33)
        Me.SimpleButton1.TabIndex = 3
        Me.SimpleButton1.Text = "Ejecutar Devolución..."
        '
        'leTipoCuenta
        '
        Me.leTipoCuenta.EnterMoveNextControl = True
        Me.leTipoCuenta.Location = New System.Drawing.Point(183, 87)
        Me.leTipoCuenta.Name = "leTipoCuenta"
        Me.leTipoCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCuenta.Size = New System.Drawing.Size(365, 20)
        Me.leTipoCuenta.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(84, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 50
        Me.LabelControl2.Text = "Seleccione Cuenta:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(183, 43)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 0
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(183, 65)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(135, 68)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 107
        Me.LabelControl4.Text = "Sucursal:"
        '
        'seDescuento
        '
        Me.seDescuento.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDescuento.Location = New System.Drawing.Point(183, 114)
        Me.seDescuento.Name = "seDescuento"
        Me.seDescuento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seDescuento.Properties.Mask.EditMask = "n"
        Me.seDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seDescuento.Size = New System.Drawing.Size(87, 20)
        Me.seDescuento.TabIndex = 173
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(73, 118)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl3.TabIndex = 172
        Me.LabelControl3.Text = "Descuento Papeleria:"
        '
        'seDescuentoAPartir
        '
        Me.seDescuentoAPartir.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seDescuentoAPartir.Location = New System.Drawing.Point(183, 136)
        Me.seDescuentoAPartir.Name = "seDescuentoAPartir"
        Me.seDescuentoAPartir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seDescuentoAPartir.Properties.Mask.EditMask = "n"
        Me.seDescuentoAPartir.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seDescuentoAPartir.Size = New System.Drawing.Size(87, 20)
        Me.seDescuentoAPartir.TabIndex = 175
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(22, 139)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(156, 13)
        Me.LabelControl10.TabIndex = 174
        Me.LabelControl10.Text = "Descontar papeleria a Partir de :"
        '
        'aho_frmDevolucionAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(624, 254)
        Me.Name = "aho_frmDevolucionAhorro"
        Me.Text = "Devolucion Ahorro "
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seDescuentoAPartir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leTipoCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seDescuento As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seDescuentoAPartir As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl

End Class
