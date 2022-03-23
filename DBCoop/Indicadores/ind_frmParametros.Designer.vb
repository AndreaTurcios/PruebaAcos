<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ind_frmParametros
    Inherits Bravio.gen_frmBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ind_frmParametros))
        Me.gcDetalle = New DevExpress.XtraGrid.GridControl
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcMes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAnio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdParametro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombreMes = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.leVariable = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcDetalle
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gcDetalle.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcDetalle.Location = New System.Drawing.Point(83, 59)
        Me.gcDetalle.MainView = Me.gvDetalle
        Me.gcDetalle.Name = "gcDetalle"
        Me.gcDetalle.Size = New System.Drawing.Size(324, 296)
        Me.gcDetalle.TabIndex = 134
        Me.gcDetalle.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalle})
        '
        'gvDetalle
        '
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcMes, Me.gcValor, Me.gcAnio, Me.gcIdParametro, Me.gcNombreMes})
        Me.gvDetalle.GridControl = Me.gcDetalle
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsView.ShowFooter = True
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        '
        'gcMes
        '
        Me.gcMes.Caption = "Mes"
        Me.gcMes.FieldName = "Mes"
        Me.gcMes.Name = "gcMes"
        Me.gcMes.OptionsColumn.ReadOnly = True
        Me.gcMes.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcMes.Width = 230
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Valor", "{0:n2}")})
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 1
        Me.gcValor.Width = 109
        '
        'gcAnio
        '
        Me.gcAnio.Caption = "Año"
        Me.gcAnio.FieldName = "Anio"
        Me.gcAnio.Name = "gcAnio"
        Me.gcAnio.Width = 106
        '
        'gcIdParametro
        '
        Me.gcIdParametro.Caption = "Id. Parametro"
        Me.gcIdParametro.FieldName = "IdParametro"
        Me.gcIdParametro.Name = "gcIdParametro"
        '
        'gcNombreMes
        '
        Me.gcNombreMes.Caption = "Mes"
        Me.gcNombreMes.FieldName = "NombreMes"
        Me.gcNombreMes.Name = "gcNombreMes"
        Me.gcNombreMes.OptionsColumn.ReadOnly = True
        Me.gcNombreMes.Visible = True
        Me.gcNombreMes.VisibleIndex = 0
        Me.gcNombreMes.Width = 197
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(297, 360)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 16
        Me.sbGuardar.Text = "&Guardar"
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(109, 35)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 158
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(83, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 159
        Me.LabelControl1.Text = "Año:"
        '
        'leVariable
        '
        Me.leVariable.EnterMoveNextControl = True
        Me.leVariable.Location = New System.Drawing.Point(109, 9)
        Me.leVariable.Name = "leVariable"
        Me.leVariable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leVariable.Size = New System.Drawing.Size(297, 20)
        Me.leVariable.TabIndex = 184
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(52, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl4.TabIndex = 185
        Me.LabelControl4.Text = "Parametro:"
        '
        'ind_frmParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 434)
        Me.Controls.Add(Me.leVariable)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.seAnio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.gcDetalle)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Préstamos"
        Me.Name = "ind_frmParametros"
        Me.OptionId = "003002"
        Me.Text = "Parametros Indicadores"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.gcDetalle, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.seAnio, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.leVariable, 0)
        CType(Me.gcDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gcDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcMes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAnio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcIdParametro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leVariable As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcNombreMes As DevExpress.XtraGrid.Columns.GridColumn
End Class
