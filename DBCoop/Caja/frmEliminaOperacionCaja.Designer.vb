<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminaOperacionCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminaOperacionCaja))
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaCorte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.leCajero = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me._monto = New DevExpress.XtraEditors.TextEdit
        Me._NroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._observa = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teIdOperacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoOperacion = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leCajero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdOperacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoOperacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(157, 41)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(111, 44)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Sucursal:"
        '
        'deFechaCorte
        '
        Me.deFechaCorte.EditValue = Nothing
        Me.deFechaCorte.Enabled = False
        Me.deFechaCorte.EnterMoveNextControl = True
        Me.deFechaCorte.Location = New System.Drawing.Point(157, 122)
        Me.deFechaCorte.Name = "deFechaCorte"
        Me.deFechaCorte.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaCorte.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaCorte.Properties.ReadOnly = True
        Me.deFechaCorte.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaCorte.Size = New System.Drawing.Size(100, 20)
        Me.deFechaCorte.TabIndex = 16
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(75, 125)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Fecha del Corte:"
        '
        'leCajero
        '
        Me.leCajero.Enabled = False
        Me.leCajero.EnterMoveNextControl = True
        Me.leCajero.Location = New System.Drawing.Point(157, 99)
        Me.leCajero.Name = "leCajero"
        Me.leCajero.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leCajero.Properties.ReadOnly = True
        Me.leCajero.Size = New System.Drawing.Size(304, 20)
        Me.leCajero.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(119, 101)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Cajero:"
        '
        '_monto
        '
        Me._monto.Enabled = False
        Me._monto.EnterMoveNextControl = True
        Me._monto.Location = New System.Drawing.Point(157, 145)
        Me._monto.Name = "_monto"
        Me._monto.Properties.Mask.EditMask = "n2"
        Me._monto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me._monto.Properties.ReadOnly = True
        Me._monto.Size = New System.Drawing.Size(100, 20)
        Me._monto.TabIndex = 23
        '
        '_NroComprobante
        '
        Me._NroComprobante.EditValue = ""
        Me._NroComprobante.EnterMoveNextControl = True
        Me._NroComprobante.Location = New System.Drawing.Point(157, 65)
        Me._NroComprobante.Name = "_NroComprobante"
        Me._NroComprobante.Size = New System.Drawing.Size(100, 20)
        Me._NroComprobante.TabIndex = 2
        '
        '_observa
        '
        Me._observa.Enabled = False
        Me._observa.EnterMoveNextControl = True
        Me._observa.Location = New System.Drawing.Point(157, 169)
        Me._observa.Name = "_observa"
        Me._observa.Properties.MaxLength = 150
        Me._observa.Properties.ReadOnly = True
        Me._observa.Size = New System.Drawing.Size(317, 76)
        Me._observa.TabIndex = 24
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(80, 172)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Observaciones"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(39, 148)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Monto de la Operacion:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(47, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "No. de Comprobante:"
        '
        'teIdOperacion
        '
        Me.teIdOperacion.Enabled = False
        Me.teIdOperacion.EnterMoveNextControl = True
        Me.teIdOperacion.Location = New System.Drawing.Point(361, 64)
        Me.teIdOperacion.Name = "teIdOperacion"
        Me.teIdOperacion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdOperacion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdOperacion.Properties.ReadOnly = True
        Me.teIdOperacion.Size = New System.Drawing.Size(100, 20)
        Me.teIdOperacion.TabIndex = 25
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(283, 67)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl14.TabIndex = 26
        Me.LabelControl14.Text = "Id. Operación :"
        '
        'leTipoOperacion
        '
        Me.leTipoOperacion.EnterMoveNextControl = True
        Me.leTipoOperacion.Location = New System.Drawing.Point(158, 17)
        Me.leTipoOperacion.Name = "leTipoOperacion"
        Me.leTipoOperacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoOperacion.Size = New System.Drawing.Size(304, 20)
        Me.leTipoOperacion.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(64, 20)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl6.TabIndex = 28
        Me.LabelControl6.Text = "Tipo de Operación:"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(157, 251)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(100, 36)
        Me.cmdEliminar.TabIndex = 29
        Me.cmdEliminar.Text = "&Eliminar"
        '
        'frmEliminaOperacionCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 299)
        Me.Controls.Add(Me.cmdEliminar)
        Me.Controls.Add(Me.leTipoOperacion)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teIdOperacion)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me._monto)
        Me.Controls.Add(Me._NroComprobante)
        Me.Controls.Add(Me._observa)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.deFechaCorte)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.leCajero)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmEliminaOperacionCaja"
        Me.Text = "Elimina Operación de Caja"
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leCajero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdOperacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoOperacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leCajero As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _observa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdOperacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoOperacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
End Class
