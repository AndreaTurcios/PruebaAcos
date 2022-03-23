<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmProvisionIntereses
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
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
        Me.MonthEdit1 = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.chkIncluirInt = New DevExpress.XtraEditors.CheckEdit
        Me.chkIncluirDep = New DevExpress.XtraEditors.CheckEdit
        Me.leCentroCosto = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MonthEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluirInt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIncluirDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.leCentroCosto)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.chkIncluirDep)
        Me.GroupControl1.Controls.Add(Me.chkIncluirInt)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.SpinEdit1)
        Me.GroupControl1.Controls.Add(Me.MonthEdit1)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(621, 190)
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(135, 37)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(89, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl4.TabIndex = 125
        Me.LabelControl4.Text = "Sucursal:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(45, 96)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl1.TabIndex = 128
        Me.LabelControl1.Text = "Mes a Provisionar:"
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(239, 92)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n0"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.Mask.EditMask = "n0"
        Me.SpinEdit1.Size = New System.Drawing.Size(73, 20)
        Me.SpinEdit1.TabIndex = 3
        '
        'MonthEdit1
        '
        Me.MonthEdit1.Location = New System.Drawing.Point(135, 92)
        Me.MonthEdit1.Name = "MonthEdit1"
        Me.MonthEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MonthEdit1.Size = New System.Drawing.Size(100, 20)
        Me.MonthEdit1.TabIndex = 2
        '
        'chkIncluirInt
        '
        Me.chkIncluirInt.AutoSizeInLayoutControl = True
        Me.chkIncluirInt.Location = New System.Drawing.Point(133, 127)
        Me.chkIncluirInt.Name = "chkIncluirInt"
        Me.chkIncluirInt.Properties.Caption = "Incluir Cuentas sin Interéses"
        Me.chkIncluirInt.Size = New System.Drawing.Size(163, 19)
        Me.chkIncluirInt.TabIndex = 3
        '
        'chkIncluirDep
        '
        Me.chkIncluirDep.AutoSizeInLayoutControl = True
        Me.chkIncluirDep.Location = New System.Drawing.Point(133, 152)
        Me.chkIncluirDep.Name = "chkIncluirDep"
        Me.chkIncluirDep.Properties.Caption = "Incluir Certificados de Depósitos"
        Me.chkIncluirDep.Size = New System.Drawing.Size(185, 19)
        Me.chkIncluirDep.TabIndex = 129
        '
        'leCentroCosto
        '
        Me.leCentroCosto.EnterMoveNextControl = True
        Me.leCentroCosto.Location = New System.Drawing.Point(135, 59)
        Me.leCentroCosto.Name = "leCentroCosto"
        Me.leCentroCosto.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCentroCosto.Size = New System.Drawing.Size(365, 20)
        Me.leCentroCosto.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(50, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 131
        Me.LabelControl2.Text = "Centro de Costo:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(350, 140)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(147, 33)
        Me.SimpleButton1.TabIndex = 132
        Me.SimpleButton1.Text = "Generar Partida Contable ..."
        '
        'aho_frmProvisionIntereses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(621, 215)
        Me.Name = "aho_frmProvisionIntereses"
        Me.Text = "Provisión de Interéses de Ahorros"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MonthEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluirInt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIncluirDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents MonthEdit1 As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents chkIncluirInt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkIncluirDep As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leCentroCosto As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton

End Class
