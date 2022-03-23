<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminaLiquidacionCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminaLiquidacionCompras))
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaCorte = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me._monto = New DevExpress.XtraEditors.TextEdit
        Me._NroComprobante = New DevExpress.XtraEditors.TextEdit
        Me._observa = New DevExpress.XtraEditors.MemoEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teIdOperacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.cmdEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdOperacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(152, 10)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(106, 13)
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
        Me.deFechaCorte.Location = New System.Drawing.Point(152, 84)
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
        Me.LabelControl7.Location = New System.Drawing.Point(110, 87)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Fecha :"
        '
        '_monto
        '
        Me._monto.Enabled = False
        Me._monto.EnterMoveNextControl = True
        Me._monto.Location = New System.Drawing.Point(152, 107)
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
        Me._NroComprobante.Location = New System.Drawing.Point(152, 34)
        Me._NroComprobante.Name = "_NroComprobante"
        Me._NroComprobante.Size = New System.Drawing.Size(100, 20)
        Me._NroComprobante.TabIndex = 2
        '
        '_observa
        '
        Me._observa.Enabled = False
        Me._observa.EnterMoveNextControl = True
        Me._observa.Location = New System.Drawing.Point(152, 131)
        Me._observa.Name = "_observa"
        Me._observa.Properties.MaxLength = 150
        Me._observa.Properties.ReadOnly = True
        Me._observa.Size = New System.Drawing.Size(317, 48)
        Me._observa.TabIndex = 24
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(96, 133)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Concepto:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 109)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(115, 13)
        Me.LabelControl3.TabIndex = 19
        Me.LabelControl3.Text = "Monto de la Liquidación:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(42, 37)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "No. de Comprobante:"
        '
        'teIdOperacion
        '
        Me.teIdOperacion.Enabled = False
        Me.teIdOperacion.EnterMoveNextControl = True
        Me.teIdOperacion.Location = New System.Drawing.Point(356, 33)
        Me.teIdOperacion.Name = "teIdOperacion"
        Me.teIdOperacion.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teIdOperacion.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teIdOperacion.Properties.ReadOnly = True
        Me.teIdOperacion.Size = New System.Drawing.Size(100, 20)
        Me.teIdOperacion.TabIndex = 25
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(266, 36)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl14.TabIndex = 26
        Me.LabelControl14.Text = "Id. Comprobante :"
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(152, 185)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(100, 36)
        Me.cmdEliminar.TabIndex = 29
        Me.cmdEliminar.Text = "&Eliminar"
        '
        'teNombre
        '
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(152, 59)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(304, 20)
        Me.teNombre.TabIndex = 30
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(106, 62)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl6.TabIndex = 31
        Me.LabelControl6.Text = "Nombre:"
        '
        'frmEliminaLiquidacionCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 236)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cmdEliminar)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmEliminaLiquidacionCompras"
        Me.Text = "Elimina Liquidacion Anticipos"
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaCorte.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._monto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NroComprobante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._observa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdOperacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaCorte As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _monto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _NroComprobante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _observa As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdOperacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
