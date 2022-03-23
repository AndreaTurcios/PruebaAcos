<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmGenerador
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
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leIndicador = New DevExpress.XtraEditors.LookUpEdit
        Me.lcIndicador = New DevExpress.XtraEditors.LabelControl
        Me.lcTecnico = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.seAnio)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.leIndicador)
        Me.GroupControl1.Controls.Add(Me.lcIndicador)
        Me.GroupControl1.Controls.Add(Me.lcTecnico)
        Me.GroupControl1.Controls.Add(Me.sbToExcel)
        Me.GroupControl1.Controls.Add(Me.sbMostrarOcultar)
        Me.GroupControl1.Controls.Add(Me.sbGenerar)
        Me.GroupControl1.Controls.Add(Me.gc)
        Me.GroupControl1.Size = New System.Drawing.Size(1076, 463)
        Me.GroupControl1.Text = "Cuadro de Mando Indicadores"
        '
        'sbToExcel
        '
        Me.sbToExcel.Location = New System.Drawing.Point(392, 83)
        Me.sbToExcel.Name = "sbToExcel"
        Me.sbToExcel.Size = New System.Drawing.Size(107, 23)
        Me.sbToExcel.TabIndex = 21
        Me.sbToExcel.Text = "Exportar a Excel"
        '
        'sbMostrarOcultar
        '
        Me.sbMostrarOcultar.Location = New System.Drawing.Point(184, 84)
        Me.sbMostrarOcultar.Name = "sbMostrarOcultar"
        Me.sbMostrarOcultar.Size = New System.Drawing.Size(170, 23)
        Me.sbMostrarOcultar.TabIndex = 23
        Me.sbMostrarOcultar.Text = "Ocultar Selector de Columnas"
        '
        'sbGenerar
        '
        Me.sbGenerar.Location = New System.Drawing.Point(68, 83)
        Me.sbGenerar.Name = "sbGenerar"
        Me.sbGenerar.Size = New System.Drawing.Size(100, 23)
        Me.sbGenerar.TabIndex = 20
        Me.sbGenerar.Text = "Generar..."
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
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(68, 33)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 27
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(41, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "Año:"
        '
        'leIndicador
        '
        Me.leIndicador.EnterMoveNextControl = True
        Me.leIndicador.Location = New System.Drawing.Point(68, 59)
        Me.leIndicador.Name = "leIndicador"
        Me.leIndicador.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leIndicador.Size = New System.Drawing.Size(285, 20)
        Me.leIndicador.TabIndex = 24
        '
        'lcIndicador
        '
        Me.lcIndicador.Location = New System.Drawing.Point(17, 62)
        Me.lcIndicador.Name = "lcIndicador"
        Me.lcIndicador.Size = New System.Drawing.Size(49, 13)
        Me.lcIndicador.TabIndex = 26
        Me.lcIndicador.Text = "Indicador:"
        '
        'lcTecnico
        '
        Me.lcTecnico.Location = New System.Drawing.Point(25, 62)
        Me.lcTecnico.Name = "lcTecnico"
        Me.lcTecnico.Size = New System.Drawing.Size(40, 13)
        Me.lcTecnico.TabIndex = 25
        Me.lcTecnico.Text = "Técnico:"
        Me.lcTecnico.Visible = False
        '
        'ind_frmGenerador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1076, 488)
        Me.Name = "ind_frmGenerador"
        Me.Text = "Cuadro de Mando Indicadores"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leIndicador.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sbToExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbMostrarOcultar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leIndicador As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lcIndicador As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lcTecnico As DevExpress.XtraEditors.LabelControl

End Class
