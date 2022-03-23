<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmBoletasDevolucion
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoCuenta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leCentroCosto = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.spAnio = New DevExpress.XtraEditors.SpinEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.spAnio)
        Me.GroupControl1.Controls.Add(Me.leCentroCosto)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.leTipoCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(639, 214)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(58, 135)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Ejercicio:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(107, 51)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(57, 54)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Sucursal:"
        '
        'leTipoCuenta
        '
        Me.leTipoCuenta.EnterMoveNextControl = True
        Me.leTipoCuenta.Location = New System.Drawing.Point(106, 105)
        Me.leTipoCuenta.Name = "leTipoCuenta"
        Me.leTipoCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCuenta.Size = New System.Drawing.Size(365, 20)
        Me.leTipoCuenta.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 109)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Seleccione Cuenta:"
        '
        'leCentroCosto
        '
        Me.leCentroCosto.EnterMoveNextControl = True
        Me.leCentroCosto.Location = New System.Drawing.Point(107, 73)
        Me.leCentroCosto.Name = "leCentroCosto"
        Me.leCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCentroCosto.Size = New System.Drawing.Size(365, 20)
        Me.leCentroCosto.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(18, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl3.TabIndex = 114
        Me.LabelControl3.Text = "Centro de Costo:"
        '
        'spAnio
        '
        Me.spAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.spAnio.Location = New System.Drawing.Point(106, 132)
        Me.spAnio.Name = "spAnio"
        Me.spAnio.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spAnio.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spAnio.Properties.DisplayFormat.FormatString = "n0"
        Me.spAnio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spAnio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.spAnio.Properties.Mask.EditMask = "n0"
        Me.spAnio.Size = New System.Drawing.Size(73, 20)
        Me.spAnio.TabIndex = 115
        '
        'aho_frmBoletasDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(639, 239)
        Me.Name = "aho_frmBoletasDevolucion"
        Me.Text = "Impresión Boletas Devolución Ahorro"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leCentroCosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spAnio As DevExpress.XtraEditors.SpinEdit

End Class
