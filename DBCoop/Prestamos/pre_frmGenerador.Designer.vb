<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmGenerador
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
        Me.sbToExcel = New DevExpress.XtraEditors.SimpleButton
        Me.sbMostrarOcultar = New DevExpress.XtraEditors.SimpleButton
        Me.sbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.deFecFin = New DevExpress.XtraEditors.DateEdit
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFecIni = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deFecFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecIni.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecIni.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.leSucursal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.sbToExcel)
        Me.GroupControl1.Controls.Add(Me.sbMostrarOcultar)
        Me.GroupControl1.Controls.Add(Me.sbGenerar)
        Me.GroupControl1.Controls.Add(Me.deFecFin)
        Me.GroupControl1.Controls.Add(Me.gc)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.deFecIni)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Size = New System.Drawing.Size(1076, 463)
        Me.GroupControl1.Text = "Generador Consulta Prestamos"
        '
        'sbToExcel
        '
        Me.sbToExcel.Location = New System.Drawing.Point(421, 45)
        Me.sbToExcel.Name = "sbToExcel"
        Me.sbToExcel.Size = New System.Drawing.Size(107, 23)
        Me.sbToExcel.TabIndex = 21
        Me.sbToExcel.Text = "Exportar a Excel"
        '
        'sbMostrarOcultar
        '
        Me.sbMostrarOcultar.Location = New System.Drawing.Point(210, 76)
        Me.sbMostrarOcultar.Name = "sbMostrarOcultar"
        Me.sbMostrarOcultar.Size = New System.Drawing.Size(170, 23)
        Me.sbMostrarOcultar.TabIndex = 23
        Me.sbMostrarOcultar.Text = "Ocultar Selector de Columnas"
        '
        'sbGenerar
        '
        Me.sbGenerar.Location = New System.Drawing.Point(94, 75)
        Me.sbGenerar.Name = "sbGenerar"
        Me.sbGenerar.Size = New System.Drawing.Size(100, 23)
        Me.sbGenerar.TabIndex = 20
        Me.sbGenerar.Text = "Generar..."
        '
        'deFecFin
        '
        Me.deFecFin.EditValue = Nothing
        Me.deFecFin.Location = New System.Drawing.Point(299, 48)
        Me.deFecFin.Name = "deFecFin"
        Me.deFecFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecFin.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecFin.Size = New System.Drawing.Size(100, 20)
        Me.deFecFin.TabIndex = 18
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gc.Location = New System.Drawing.Point(2, 113)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(1072, 348)
        Me.gc.TabIndex = 15
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(229, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 19
        Me.LabelControl2.Text = "Hasta Fecha:"
        '
        'deFecIni
        '
        Me.deFecIni.EditValue = Nothing
        Me.deFecIni.Location = New System.Drawing.Point(94, 48)
        Me.deFecIni.Name = "deFecIni"
        Me.deFecIni.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecIni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecIni.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecIni.Size = New System.Drawing.Size(100, 20)
        Me.deFecIni.TabIndex = 16
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 51)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl1.TabIndex = 17
        Me.LabelControl1.Text = "Fecha Inicial:"
        '
        'leSucursal
        '
        Me.leSucursal.EnterMoveNextControl = True
        Me.leSucursal.Location = New System.Drawing.Point(94, 25)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(304, 20)
        Me.leSucursal.TabIndex = 28
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(47, 28)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "Sucursal:"
        '
        'pre_frmGenerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1076, 488)
        Me.Name = "pre_frmGenerador"
        Me.Text = "Generador Consulta Prestamos"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deFecFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecIni.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecIni.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sbToExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbMostrarOcultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deFecFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecIni As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl

End Class
