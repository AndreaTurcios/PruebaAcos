<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmListadoCuentasInactivas
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
        Me.chkIncluir = New DevExpress.XtraEditors.CheckEdit
        Me.leTipoCuenta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.deFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.chkIncluir)
        Me.GroupControl1.Controls.Add(Me.leTipoCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(626, 185)
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.EnterMoveNextControl = True
        Me.deFecha.Location = New System.Drawing.Point(164, 61)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(83, 20)
        Me.deFecha.TabIndex = 59
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(85, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 60
        Me.LabelControl5.Text = "Hasta la Fecha:"
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoSizeInLayoutControl = True
        Me.chkIncluir.Location = New System.Drawing.Point(162, 130)
        Me.chkIncluir.Name = "chkIncluir"
        Me.chkIncluir.Properties.Caption = "Incluir Cuentas Canceladas"
        Me.chkIncluir.Size = New System.Drawing.Size(156, 19)
        Me.chkIncluir.TabIndex = 58
        '
        'leTipoCuenta
        '
        Me.leTipoCuenta.EnterMoveNextControl = True
        Me.leTipoCuenta.Location = New System.Drawing.Point(164, 87)
        Me.leTipoCuenta.Name = "leTipoCuenta"
        Me.leTipoCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCuenta.Size = New System.Drawing.Size(365, 20)
        Me.leTipoCuenta.TabIndex = 56
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(68, 91)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl2.TabIndex = 57
        Me.LabelControl2.Text = "Seleccione Cuenta:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(164, 37)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 52
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(116, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Sucursal:"
        '
        'aho_frmListadoCuentasInactivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(626, 210)
        Me.Name = "aho_frmListadoCuentasInactivas"
        Me.Text = "Análisis de Cuentas Inactivas"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkIncluir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leTipoCuenta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl

End Class
