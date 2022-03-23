<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmEnvioArchivo
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.leTipoPlanilla = New DevExpress.XtraEditors.LookUpEdit()
        Me.btGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.ceDetalle = New DevExpress.XtraEditors.CheckEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.leCentro = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.ceIncluirSaldo = New DevExpress.XtraEditors.CheckEdit()
        Me.ChecTelefonia = New DevExpress.XtraEditors.CheckEdit()
        Me.cheAplicaPlanilla = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceDetalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCentro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluirSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecTelefonia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cheAplicaPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(80, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Sucursal:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(128, 12)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(301, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Fecha de Envío:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(128, 58)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 2
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(8, 86)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl64.TabIndex = 139
        Me.LabelControl64.Text = "Tipo de Planilla a Envíar:"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'leTipoPlanilla
        '
        Me.leTipoPlanilla.EnterMoveNextControl = True
        Me.leTipoPlanilla.Location = New System.Drawing.Point(128, 83)
        Me.leTipoPlanilla.Name = "leTipoPlanilla"
        Me.leTipoPlanilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoPlanilla.Size = New System.Drawing.Size(301, 20)
        Me.leTipoPlanilla.TabIndex = 3
        '
        'btGenerar
        '
        Me.btGenerar.Location = New System.Drawing.Point(208, 197)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(125, 23)
        Me.btGenerar.TabIndex = 4
        Me.btGenerar.Text = "Generar Datos a RRHH"
        '
        'ceDetalle
        '
        Me.ceDetalle.Location = New System.Drawing.Point(199, 152)
        Me.ceDetalle.Name = "ceDetalle"
        Me.ceDetalle.Properties.Caption = "Reporte Detallado"
        Me.ceDetalle.Size = New System.Drawing.Size(128, 19)
        Me.ceDetalle.TabIndex = 144
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 146)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 145
        Me.SimpleButton1.Text = "Aplicar Datos Enviados"
        Me.SimpleButton1.Visible = False
        '
        'leCentro
        '
        Me.leCentro.EnterMoveNextControl = True
        Me.leCentro.Location = New System.Drawing.Point(128, 34)
        Me.leCentro.Name = "leCentro"
        Me.leCentro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCentro.Size = New System.Drawing.Size(301, 20)
        Me.leCentro.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl3.TabIndex = 147
        Me.LabelControl3.Text = "Centro de Costo:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(201, 227)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(138, 23)
        Me.SimpleButton2.TabIndex = 148
        Me.SimpleButton2.Text = "Archivo para Aplicar CSV"
        '
        'ceIncluirSaldo
        '
        Me.ceIncluirSaldo.Location = New System.Drawing.Point(199, 130)
        Me.ceIncluirSaldo.Name = "ceIncluirSaldo"
        Me.ceIncluirSaldo.Properties.Caption = "Incluir Saldo de Préstamos"
        Me.ceIncluirSaldo.Size = New System.Drawing.Size(150, 19)
        Me.ceIncluirSaldo.TabIndex = 149
        '
        'ChecTelefonia
        '
        Me.ChecTelefonia.Location = New System.Drawing.Point(199, 109)
        Me.ChecTelefonia.Name = "ChecTelefonia"
        Me.ChecTelefonia.Properties.Caption = "Reporte de Telefonía"
        Me.ChecTelefonia.Size = New System.Drawing.Size(150, 19)
        Me.ChecTelefonia.TabIndex = 150
        '
        'cheAplicaPlanilla
        '
        Me.cheAplicaPlanilla.Location = New System.Drawing.Point(199, 173)
        Me.cheAplicaPlanilla.Name = "cheAplicaPlanilla"
        Me.cheAplicaPlanilla.Properties.Caption = "No descontados en planilla"
        Me.cheAplicaPlanilla.Size = New System.Drawing.Size(158, 19)
        Me.cheAplicaPlanilla.TabIndex = 151
        '
        'adm_frmEnvioArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(673, 305)
        Me.Controls.Add(Me.cheAplicaPlanilla)
        Me.Controls.Add(Me.ChecTelefonia)
        Me.Controls.Add(Me.ceIncluirSaldo)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.leCentro)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.ceDetalle)
        Me.Controls.Add(Me.btGenerar)
        Me.Controls.Add(Me.leTipoPlanilla)
        Me.Controls.Add(Me.LabelControl64)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmEnvioArchivo"
        Me.OptionId = "001010"
        Me.Text = "Enviar Archivo Descuentos Planilla"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.LabelControl64, 0)
        Me.Controls.SetChildIndex(Me.leTipoPlanilla, 0)
        Me.Controls.SetChildIndex(Me.btGenerar, 0)
        Me.Controls.SetChildIndex(Me.ceDetalle, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.leCentro, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
        Me.Controls.SetChildIndex(Me.ceIncluirSaldo, 0)
        Me.Controls.SetChildIndex(Me.ChecTelefonia, 0)
        Me.Controls.SetChildIndex(Me.cheAplicaPlanilla, 0)
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceDetalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCentro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluirSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecTelefonia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cheAplicaPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents leTipoPlanilla As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceDetalle As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leCentro As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceIncluirSaldo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ChecTelefonia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cheAplicaPlanilla As DevExpress.XtraEditors.CheckEdit

End Class
