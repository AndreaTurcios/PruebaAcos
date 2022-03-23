<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class apo_frmLiquidacionAsociados
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(apo_frmLiquidacionAsociados))
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaEntrega = New DevExpress.XtraEditors.DateEdit
        Me.gcRefinancia = New DevExpress.XtraGrid.GridControl
        Me.gvRefinancia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCapital = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcInteres = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcMoratorio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSeguro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcOtros = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcTotalAbono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdPrestamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.leTipoGarantia = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.teNumAsociado = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me._FechaIngCliente = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.gcAhorros = New DevExpress.XtraGrid.GridControl
        Me.gvAhorros = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValorCol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.teValor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.teAportacionesLiquida = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teSaldoAhorros = New DevExpress.XtraEditors.TextEdit
        Me.teSaldoAportaciones = New DevExpress.XtraEditors.TextEdit
        Me.teSaldoDeudas = New DevExpress.XtraEditors.TextEdit
        Me.teLiquido = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.teNumSolicitud = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.teIdSolicitud = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.teCta01 = New DevExpress.XtraEditors.TextEdit
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.deFechaEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRefinancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRefinancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaIngCliente.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FechaIngCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAhorros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAhorros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAportacionesLiquida.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoAhorros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoAportaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldoDeudas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLiquido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(37, 82)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl12.TabIndex = 114
        Me.LabelControl12.Text = "Fecha de Retiro:"
        '
        'deFechaEntrega
        '
        Me.deFechaEntrega.EditValue = Nothing
        Me.deFechaEntrega.Enabled = False
        Me.deFechaEntrega.EnterMoveNextControl = True
        Me.deFechaEntrega.Location = New System.Drawing.Point(121, 79)
        Me.deFechaEntrega.Name = "deFechaEntrega"
        Me.deFechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaEntrega.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaEntrega.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.deFechaEntrega.TabIndex = 4
        '
        'gcRefinancia
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gcRefinancia.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcRefinancia.Location = New System.Drawing.Point(17, 263)
        Me.gcRefinancia.MainView = Me.gvRefinancia
        Me.gcRefinancia.Name = "gcRefinancia"
        Me.gcRefinancia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.leTipoGarantia})
        Me.gcRefinancia.Size = New System.Drawing.Size(606, 100)
        Me.gcRefinancia.TabIndex = 134
        Me.gcRefinancia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRefinancia})
        '
        'gvRefinancia
        '
        Me.gvRefinancia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNumero, Me.gcCapital, Me.gcInteres, Me.gcMoratorio, Me.gcSeguro, Me.gcOtros, Me.gcTotalAbono, Me.gcIdPrestamo, Me.GridColumn1})
        Me.gvRefinancia.GridControl = Me.gcRefinancia
        Me.gvRefinancia.Name = "gvRefinancia"
        Me.gvRefinancia.OptionsView.ShowGroupPanel = False
        '
        'gcNumero
        '
        Me.gcNumero.Caption = "No. Prestamo"
        Me.gcNumero.FieldName = "Numero"
        Me.gcNumero.Name = "gcNumero"
        Me.gcNumero.OptionsColumn.ReadOnly = True
        Me.gcNumero.Visible = True
        Me.gcNumero.VisibleIndex = 0
        Me.gcNumero.Width = 91
        '
        'gcCapital
        '
        Me.gcCapital.Caption = "Saldo Capital"
        Me.gcCapital.FieldName = "SaldoCapital"
        Me.gcCapital.Name = "gcCapital"
        Me.gcCapital.OptionsColumn.ReadOnly = True
        Me.gcCapital.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcCapital.Visible = True
        Me.gcCapital.VisibleIndex = 1
        Me.gcCapital.Width = 81
        '
        'gcInteres
        '
        Me.gcInteres.Caption = "Saldo Interes"
        Me.gcInteres.FieldName = "SaldoInteres"
        Me.gcInteres.Name = "gcInteres"
        Me.gcInteres.OptionsColumn.ReadOnly = True
        Me.gcInteres.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcInteres.Visible = True
        Me.gcInteres.VisibleIndex = 2
        Me.gcInteres.Width = 72
        '
        'gcMoratorio
        '
        Me.gcMoratorio.Caption = "Int. Moratorio"
        Me.gcMoratorio.FieldName = "SaldoInteresMora"
        Me.gcMoratorio.Name = "gcMoratorio"
        Me.gcMoratorio.OptionsColumn.ReadOnly = True
        Me.gcMoratorio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcMoratorio.Visible = True
        Me.gcMoratorio.VisibleIndex = 3
        Me.gcMoratorio.Width = 83
        '
        'gcSeguro
        '
        Me.gcSeguro.Caption = "Seguro Prestamo"
        Me.gcSeguro.FieldName = "SaldoSeguro"
        Me.gcSeguro.Name = "gcSeguro"
        Me.gcSeguro.OptionsColumn.ReadOnly = True
        Me.gcSeguro.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcSeguro.Visible = True
        Me.gcSeguro.VisibleIndex = 4
        Me.gcSeguro.Width = 96
        '
        'gcOtros
        '
        Me.gcOtros.Caption = "Saldo Otros"
        Me.gcOtros.FieldName = "SaldoOtros"
        Me.gcOtros.Name = "gcOtros"
        Me.gcOtros.OptionsColumn.ReadOnly = True
        Me.gcOtros.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcOtros.Visible = True
        Me.gcOtros.VisibleIndex = 5
        Me.gcOtros.Width = 73
        '
        'gcTotalAbono
        '
        Me.gcTotalAbono.Caption = "Total a Abonar"
        Me.gcTotalAbono.FieldName = "TotalAbonar"
        Me.gcTotalAbono.Name = "gcTotalAbono"
        Me.gcTotalAbono.OptionsColumn.ReadOnly = True
        Me.gcTotalAbono.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcTotalAbono.Visible = True
        Me.gcTotalAbono.VisibleIndex = 6
        Me.gcTotalAbono.Width = 92
        '
        'gcIdPrestamo
        '
        Me.gcIdPrestamo.Caption = "Id. Prestamo"
        Me.gcIdPrestamo.FieldName = "IdPrestamo"
        Me.gcIdPrestamo.Name = "gcIdPrestamo"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Linea"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'leTipoGarantia
        '
        Me.leTipoGarantia.AutoHeight = False
        Me.leTipoGarantia.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoGarantia.Name = "leTipoGarantia"
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(401, 430)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 16
        Me.sbGuardar.Text = "&Aplicar Retiro"
        '
        'teNumAsociado
        '
        Me.teNumAsociado.Enabled = False
        Me.teNumAsociado.EnterMoveNextControl = True
        Me.teNumAsociado.Location = New System.Drawing.Point(121, 33)
        Me.teNumAsociado.Name = "teNumAsociado"
        Me.teNumAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumAsociado.Size = New System.Drawing.Size(100, 20)
        Me.teNumAsociado.TabIndex = 158
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 36)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl5.TabIndex = 162
        Me.LabelControl5.Text = "Número de Asociado:"
        '
        'teIdAsociado
        '
        Me.teIdAsociado.EnterMoveNextControl = True
        Me.teIdAsociado.Location = New System.Drawing.Point(227, 33)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(100, 20)
        Me.teIdAsociado.TabIndex = 159
        '
        'teNombreAsociado
        '
        Me.teNombreAsociado.EnterMoveNextControl = True
        Me.teNombreAsociado.Location = New System.Drawing.Point(121, 56)
        Me.teNombreAsociado.Name = "teNombreAsociado"
        Me.teNombreAsociado.Properties.ReadOnly = True
        Me.teNombreAsociado.Size = New System.Drawing.Size(402, 20)
        Me.teNombreAsociado.TabIndex = 160
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(76, 59)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl9.TabIndex = 161
        Me.LabelControl9.Text = "Nombre:"
        '
        '_FechaIngCliente
        '
        Me._FechaIngCliente.EditValue = Nothing
        Me._FechaIngCliente.EnterMoveNextControl = True
        Me._FechaIngCliente.Location = New System.Drawing.Point(423, 79)
        Me._FechaIngCliente.Name = "_FechaIngCliente"
        Me._FechaIngCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._FechaIngCliente.Properties.ReadOnly = True
        Me._FechaIngCliente.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me._FechaIngCliente.Size = New System.Drawing.Size(100, 20)
        Me._FechaIngCliente.TabIndex = 164
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(280, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(141, 13)
        Me.LabelControl1.TabIndex = 163
        Me.LabelControl1.Text = "Fecha de Ingreso del Cliente:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(15, 109)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(117, 14)
        Me.LabelControl2.TabIndex = 166
        Me.LabelControl2.Text = "Ahorros a Liquidar:"
        '
        'gcAhorros
        '
        GridLevelNode2.RelationName = "Level1"
        Me.gcAhorros.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gcAhorros.Location = New System.Drawing.Point(15, 129)
        Me.gcAhorros.MainView = Me.gvAhorros
        Me.gcAhorros.Name = "gcAhorros"
        Me.gcAhorros.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.teValor})
        Me.gcAhorros.Size = New System.Drawing.Size(508, 111)
        Me.gcAhorros.TabIndex = 165
        Me.gcAhorros.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAhorros, Me.GridView1})
        '
        'gvAhorros
        '
        Me.gvAhorros.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn15, Me.gcValorCol, Me.GridColumn17, Me.GridColumn6})
        Me.gvAhorros.GridControl = Me.gcAhorros
        Me.gvAhorros.Name = "gvAhorros"
        Me.gvAhorros.OptionsView.ShowFooter = True
        Me.gvAhorros.OptionsView.ShowGroupPanel = False
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "No. Cuenta"
        Me.GridColumn15.FieldName = "Numero"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.AllowEdit = False
        Me.GridColumn15.OptionsColumn.AllowFocus = False
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 0
        Me.GridColumn15.Width = 125
        '
        'gcValorCol
        '
        Me.gcValorCol.Caption = "Saldo Actual"
        Me.gcValorCol.ColumnEdit = Me.teValor
        Me.gcValorCol.DisplayFormat.FormatString = "{0:c2}"
        Me.gcValorCol.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValorCol.FieldName = "SaldoActual"
        Me.gcValorCol.Name = "gcValorCol"
        Me.gcValorCol.OptionsColumn.AllowEdit = False
        Me.gcValorCol.OptionsColumn.AllowFocus = False
        Me.gcValorCol.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SaldoActual", "{0:c2}")})
        Me.gcValorCol.Visible = True
        Me.gcValorCol.VisibleIndex = 1
        Me.gcValorCol.Width = 93
        '
        'teValor
        '
        Me.teValor.AutoHeight = False
        Me.teValor.Name = "teValor"
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "IdSolicitud"
        Me.GridColumn17.FieldName = "IdSolicitud"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "IdCuenta"
        Me.GridColumn6.FieldName = "IdCuenta"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gcAhorros
        Me.GridView1.Name = "GridView1"
        '
        'teAportacionesLiquida
        '
        Me.teAportacionesLiquida.EditValue = 0
        Me.teAportacionesLiquida.Enabled = False
        Me.teAportacionesLiquida.EnterMoveNextControl = True
        Me.teAportacionesLiquida.Location = New System.Drawing.Point(423, 103)
        Me.teAportacionesLiquida.Name = "teAportacionesLiquida"
        Me.teAportacionesLiquida.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teAportacionesLiquida.Properties.Appearance.Options.UseFont = True
        Me.teAportacionesLiquida.Properties.Appearance.Options.UseTextOptions = True
        Me.teAportacionesLiquida.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teAportacionesLiquida.Properties.Mask.EditMask = "n2"
        Me.teAportacionesLiquida.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teAportacionesLiquida.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teAportacionesLiquida.Properties.ReadOnly = True
        Me.teAportacionesLiquida.Size = New System.Drawing.Size(100, 23)
        Me.teAportacionesLiquida.TabIndex = 168
        '
        'LabelControl69
        '
        Me.LabelControl69.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl69.Location = New System.Drawing.Point(272, 107)
        Me.LabelControl69.Name = "LabelControl69"
        Me.LabelControl69.Size = New System.Drawing.Size(149, 14)
        Me.LabelControl69.TabIndex = 167
        Me.LabelControl69.Text = "Aportaciones a Liquidar:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(17, 243)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(102, 14)
        Me.LabelControl3.TabIndex = 169
        Me.LabelControl3.Text = "Saldo de Deudas"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Location = New System.Drawing.Point(39, 371)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(110, 14)
        Me.LabelControl4.TabIndex = 170
        Me.LabelControl4.Text = "Saldo de Ahorros:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Location = New System.Drawing.Point(7, 397)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(142, 14)
        Me.LabelControl6.TabIndex = 171
        Me.LabelControl6.Text = "Saldo de Aportaciones:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Location = New System.Drawing.Point(43, 422)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(106, 14)
        Me.LabelControl7.TabIndex = 172
        Me.LabelControl7.Text = "Saldo de Deudas:"
        '
        'teSaldoAhorros
        '
        Me.teSaldoAhorros.EditValue = 0
        Me.teSaldoAhorros.Enabled = False
        Me.teSaldoAhorros.EnterMoveNextControl = True
        Me.teSaldoAhorros.Location = New System.Drawing.Point(155, 369)
        Me.teSaldoAhorros.Name = "teSaldoAhorros"
        Me.teSaldoAhorros.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoAhorros.Properties.Appearance.Options.UseFont = True
        Me.teSaldoAhorros.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoAhorros.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoAhorros.Properties.Mask.EditMask = "n2"
        Me.teSaldoAhorros.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoAhorros.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoAhorros.Properties.ReadOnly = True
        Me.teSaldoAhorros.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoAhorros.TabIndex = 173
        '
        'teSaldoAportaciones
        '
        Me.teSaldoAportaciones.EditValue = 0
        Me.teSaldoAportaciones.Enabled = False
        Me.teSaldoAportaciones.EnterMoveNextControl = True
        Me.teSaldoAportaciones.Location = New System.Drawing.Point(155, 393)
        Me.teSaldoAportaciones.Name = "teSaldoAportaciones"
        Me.teSaldoAportaciones.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoAportaciones.Properties.Appearance.Options.UseFont = True
        Me.teSaldoAportaciones.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoAportaciones.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoAportaciones.Properties.Mask.EditMask = "n2"
        Me.teSaldoAportaciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoAportaciones.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoAportaciones.Properties.ReadOnly = True
        Me.teSaldoAportaciones.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoAportaciones.TabIndex = 174
        '
        'teSaldoDeudas
        '
        Me.teSaldoDeudas.EditValue = 0
        Me.teSaldoDeudas.Enabled = False
        Me.teSaldoDeudas.EnterMoveNextControl = True
        Me.teSaldoDeudas.Location = New System.Drawing.Point(155, 418)
        Me.teSaldoDeudas.Name = "teSaldoDeudas"
        Me.teSaldoDeudas.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teSaldoDeudas.Properties.Appearance.Options.UseFont = True
        Me.teSaldoDeudas.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldoDeudas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldoDeudas.Properties.Mask.EditMask = "n2"
        Me.teSaldoDeudas.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldoDeudas.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldoDeudas.Properties.ReadOnly = True
        Me.teSaldoDeudas.Size = New System.Drawing.Size(100, 23)
        Me.teSaldoDeudas.TabIndex = 175
        '
        'teLiquido
        '
        Me.teLiquido.EditValue = 0
        Me.teLiquido.Enabled = False
        Me.teLiquido.EnterMoveNextControl = True
        Me.teLiquido.Location = New System.Drawing.Point(155, 442)
        Me.teLiquido.Name = "teLiquido"
        Me.teLiquido.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teLiquido.Properties.Appearance.Options.UseFont = True
        Me.teLiquido.Properties.Appearance.Options.UseTextOptions = True
        Me.teLiquido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teLiquido.Properties.Mask.EditMask = "n2"
        Me.teLiquido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teLiquido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teLiquido.Properties.ReadOnly = True
        Me.teLiquido.Size = New System.Drawing.Size(100, 23)
        Me.teLiquido.TabIndex = 177
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Location = New System.Drawing.Point(88, 447)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 14)
        Me.LabelControl10.TabIndex = 176
        Me.LabelControl10.Text = "LIQUIDEZ:"
        '
        'teNumSolicitud
        '
        Me.teNumSolicitud.EnterMoveNextControl = True
        Me.teNumSolicitud.Location = New System.Drawing.Point(121, 12)
        Me.teNumSolicitud.Name = "teNumSolicitud"
        Me.teNumSolicitud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.teNumSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.teNumSolicitud.TabIndex = 179
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(42, 15)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl26.TabIndex = 180
        Me.LabelControl26.Text = "Solicitud Retiro:"
        '
        'teIdSolicitud
        '
        Me.teIdSolicitud.EnterMoveNextControl = True
        Me.teIdSolicitud.Location = New System.Drawing.Point(227, 12)
        Me.teIdSolicitud.Name = "teIdSolicitud"
        Me.teIdSolicitud.Properties.ReadOnly = True
        Me.teIdSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.teIdSolicitud.TabIndex = 178
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(259, 375)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl8.TabIndex = 181
        Me.LabelControl8.Text = "Cuenta por Cobrar:"
        '
        'teCta01
        '
        Me.teCta01.Enabled = False
        Me.teCta01.Location = New System.Drawing.Point(357, 390)
        Me.teCta01.Name = "teCta01"
        Me.teCta01.Size = New System.Drawing.Size(266, 20)
        Me.teCta01.TabIndex = 183
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(357, 368)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(133, 20)
        Me.beCta01.TabIndex = 182
        '
        'apo_frmLiquidacionAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 500)
        Me.Controls.Add(Me.teCta01)
        Me.Controls.Add(Me.beCta01)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.teNumSolicitud)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.teIdSolicitud)
        Me.Controls.Add(Me.teLiquido)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.teSaldoDeudas)
        Me.Controls.Add(Me.teSaldoAportaciones)
        Me.Controls.Add(Me.teSaldoAhorros)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.teAportacionesLiquida)
        Me.Controls.Add(Me.LabelControl69)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.gcAhorros)
        Me.Controls.Add(Me._FechaIngCliente)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teNumAsociado)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teIdAsociado)
        Me.Controls.Add(Me.teNombreAsociado)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.gcRefinancia)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.deFechaEntrega)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Aportaciones"
        Me.Name = "apo_frmLiquidacionAsociados"
        Me.OptionId = "001003"
        Me.Text = "Liquidacion Asociados"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.deFechaEntrega, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.gcRefinancia, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl9, 0)
        Me.Controls.SetChildIndex(Me.teNombreAsociado, 0)
        Me.Controls.SetChildIndex(Me.teIdAsociado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.teNumAsociado, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me._FechaIngCliente, 0)
        Me.Controls.SetChildIndex(Me.gcAhorros, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl69, 0)
        Me.Controls.SetChildIndex(Me.teAportacionesLiquida, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.teSaldoAhorros, 0)
        Me.Controls.SetChildIndex(Me.teSaldoAportaciones, 0)
        Me.Controls.SetChildIndex(Me.teSaldoDeudas, 0)
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.teLiquido, 0)
        Me.Controls.SetChildIndex(Me.teIdSolicitud, 0)
        Me.Controls.SetChildIndex(Me.LabelControl26, 0)
        Me.Controls.SetChildIndex(Me.teNumSolicitud, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.beCta01, 0)
        Me.Controls.SetChildIndex(Me.teCta01, 0)
        CType(Me.deFechaEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRefinancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRefinancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaIngCliente.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FechaIngCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAhorros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAhorros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAportacionesLiquida.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoAhorros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoAportaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldoDeudas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLiquido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNumSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents gcRefinancia As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvRefinancia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leTipoGarantia As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcCapital As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcInteres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMoratorio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSeguro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOtros As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcIdPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teNumAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _FechaIngCliente As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcAhorros As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAhorros As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValorCol As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teValor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents teAportacionesLiquida As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teSaldoAhorros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSaldoAportaciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teSaldoDeudas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teLiquido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcTotalAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teNumSolicitud As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdSolicitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teCta01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
End Class
