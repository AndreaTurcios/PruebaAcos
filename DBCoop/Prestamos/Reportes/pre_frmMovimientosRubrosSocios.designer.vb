<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmMovimientosRubros
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
        Me.deDesdeFecha = New DevExpress.XtraEditors.DateEdit
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teNumAsociado = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.deHastaFecha = New DevExpress.XtraEditors.DateEdit
        Me.ceIncluyeAportacion = New DevExpress.XtraEditors.CheckEdit
        Me.ceIncluyeAhorros = New DevExpress.XtraEditors.CheckEdit
        Me.leLinea = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesdeFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deDesdeFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHastaFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHastaFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluyeAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluyeAhorros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leLinea)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.ceIncluyeAhorros)
        Me.GroupControl1.Controls.Add(Me.ceIncluyeAportacion)
        Me.GroupControl1.Controls.Add(Me.deHastaFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.teIdAsociado)
        Me.GroupControl1.Controls.Add(Me.teNombreAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.teNumAsociado)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.deDesdeFecha)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Size = New System.Drawing.Size(578, 277)
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(79, 228)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Desde Fecha:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(150, 49)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(365, 20)
        Me.leSucursal.TabIndex = 0
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(28, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(117, 13)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Sucursal/Departamento:"
        '
        'deDesdeFecha
        '
        Me.deDesdeFecha.EditValue = Nothing
        Me.deDesdeFecha.EnterMoveNextControl = True
        Me.deDesdeFecha.Location = New System.Drawing.Point(150, 226)
        Me.deDesdeFecha.Name = "deDesdeFecha"
        Me.deDesdeFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deDesdeFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deDesdeFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deDesdeFecha.Size = New System.Drawing.Size(116, 20)
        Me.deDesdeFecha.TabIndex = 5
        '
        'teIdAsociado
        '
        Me.teIdAsociado.Location = New System.Drawing.Point(150, 101)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teIdAsociado.TabIndex = 3
        '
        'teNombreAsociado
        '
        Me.teNombreAsociado.Location = New System.Drawing.Point(150, 123)
        Me.teNombreAsociado.Name = "teNombreAsociado"
        Me.teNombreAsociado.Properties.ReadOnly = True
        Me.teNombreAsociado.Size = New System.Drawing.Size(402, 20)
        Me.teNombreAsociado.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(41, 127)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl3.TabIndex = 60
        Me.LabelControl3.Text = "Nombre del Asociado:"
        '
        'teNumAsociado
        '
        Me.teNumAsociado.EditValue = ""
        Me.teNumAsociado.EnterMoveNextControl = True
        Me.teNumAsociado.Location = New System.Drawing.Point(150, 79)
        Me.teNumAsociado.Name = "teNumAsociado"
        Me.teNumAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumAsociado.Size = New System.Drawing.Size(134, 20)
        Me.teNumAsociado.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(68, 104)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl5.TabIndex = 58
        Me.LabelControl5.Text = "Id del Asociado:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(43, 82)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl8.TabIndex = 59
        Me.LabelControl8.Text = "Número de Asociado:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(290, 82)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(157, 13)
        Me.LabelControl6.TabIndex = 61
        Me.LabelControl6.Text = "** En blanco para generar todos"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(81, 254)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl7.TabIndex = 63
        Me.LabelControl7.Text = "Hasta Fecha:"
        '
        'deHastaFecha
        '
        Me.deHastaFecha.EditValue = Nothing
        Me.deHastaFecha.EnterMoveNextControl = True
        Me.deHastaFecha.Location = New System.Drawing.Point(150, 252)
        Me.deHastaFecha.Name = "deHastaFecha"
        Me.deHastaFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHastaFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHastaFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deHastaFecha.Size = New System.Drawing.Size(116, 20)
        Me.deHastaFecha.TabIndex = 6
        '
        'ceIncluyeAportacion
        '
        Me.ceIncluyeAportacion.EditValue = True
        Me.ceIncluyeAportacion.Location = New System.Drawing.Point(149, 181)
        Me.ceIncluyeAportacion.Name = "ceIncluyeAportacion"
        Me.ceIncluyeAportacion.Properties.Caption = "Incluir Aportacion"
        Me.ceIncluyeAportacion.Size = New System.Drawing.Size(111, 19)
        Me.ceIncluyeAportacion.TabIndex = 64
        '
        'ceIncluyeAhorros
        '
        Me.ceIncluyeAhorros.EditValue = True
        Me.ceIncluyeAhorros.Location = New System.Drawing.Point(149, 203)
        Me.ceIncluyeAhorros.Name = "ceIncluyeAhorros"
        Me.ceIncluyeAhorros.Properties.Caption = "Incluir Ahorros"
        Me.ceIncluyeAhorros.Size = New System.Drawing.Size(111, 19)
        Me.ceIncluyeAhorros.TabIndex = 65
        '
        'leLinea
        '
        Me.leLinea.EnterMoveNextControl = True
        Me.leLinea.Location = New System.Drawing.Point(150, 149)
        Me.leLinea.Name = "leLinea"
        Me.leLinea.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leLinea.Size = New System.Drawing.Size(365, 20)
        Me.leLinea.TabIndex = 170
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(10, 152)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(135, 13)
        Me.LabelControl1.TabIndex = 171
        Me.LabelControl1.Text = "Seleccione Linea de Crédito:"
        '
        'pre_frmMovimientosRubros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(578, 302)
        Me.Name = "pre_frmMovimientosRubros"
        Me.Text = "Listado de Saldos por Socios"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesdeFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deDesdeFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHastaFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHastaFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluyeAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluyeAhorros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leLinea.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deDesdeFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deHastaFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceIncluyeAportacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceIncluyeAhorros As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents leLinea As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

End Class
