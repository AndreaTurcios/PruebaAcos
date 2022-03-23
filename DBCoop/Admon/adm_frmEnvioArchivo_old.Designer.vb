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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.leTipoPlanilla = New DevExpress.XtraEditors.LookUpEdit
        Me.btGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.ceDetalle = New DevExpress.XtraEditors.CheckEdit
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.ceEnvioAhorro = New DevExpress.XtraEditors.CheckEdit
        Me.leTipoArchivo = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceDetalle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceEnvioAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.leSucursal.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(47, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Fecha de Envío:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(129, 39)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 6
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(8, 69)
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
        Me.leTipoPlanilla.Location = New System.Drawing.Point(128, 66)
        Me.leTipoPlanilla.Name = "leTipoPlanilla"
        Me.leTipoPlanilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoPlanilla.Size = New System.Drawing.Size(301, 20)
        Me.leTipoPlanilla.TabIndex = 142
        '
        'btGenerar
        '
        Me.btGenerar.Location = New System.Drawing.Point(205, 118)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(97, 23)
        Me.btGenerar.TabIndex = 143
        Me.btGenerar.Text = "Generar Datos...."
        '
        'ceDetalle
        '
        Me.ceDetalle.Location = New System.Drawing.Point(190, 151)
        Me.ceDetalle.Name = "ceDetalle"
        Me.ceDetalle.Properties.Caption = "Ver Reporte Detallado"
        Me.ceDetalle.Size = New System.Drawing.Size(127, 19)
        Me.ceDetalle.TabIndex = 144
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(184, 200)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 23)
        Me.SimpleButton1.TabIndex = 145
        Me.SimpleButton1.Text = "Aplicar Datos Enviados"
        '
        'ceEnvioAhorro
        '
        Me.ceEnvioAhorro.EditValue = True
        Me.ceEnvioAhorro.Location = New System.Drawing.Point(190, 175)
        Me.ceEnvioAhorro.Name = "ceEnvioAhorro"
        Me.ceEnvioAhorro.Properties.Caption = "Enviar Descuento de Ahorro"
        Me.ceEnvioAhorro.Size = New System.Drawing.Size(163, 19)
        Me.ceEnvioAhorro.TabIndex = 146
        '
        'leTipoArchivo
        '
        Me.leTipoArchivo.EnterMoveNextControl = True
        Me.leTipoArchivo.Location = New System.Drawing.Point(128, 92)
        Me.leTipoArchivo.Name = "leTipoArchivo"
        Me.leTipoArchivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoArchivo.Size = New System.Drawing.Size(301, 20)
        Me.leTipoArchivo.TabIndex = 148
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(61, 95)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl3.TabIndex = 147
        Me.LabelControl3.Text = "Tipo Archivo:"
        '
        'adm_frmEnvioArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(673, 265)
        Me.Controls.Add(Me.leTipoArchivo)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.ceEnvioAhorro)
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
        Me.Controls.SetChildIndex(Me.ceEnvioAhorro, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.leTipoArchivo, 0)
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceDetalle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceEnvioAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ceEnvioAhorro As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leTipoArchivo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
