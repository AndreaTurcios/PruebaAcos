<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmSolicitudFondos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmSolicitudFondos))
        Me.teIdSolicitud = New DevExpress.XtraEditors.TextEdit
        Me.beNoSolicitud = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.seNumeroDesembolso = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaEntrega = New DevExpress.XtraEditors.DateEdit
        Me.sbCalcular = New DevExpress.XtraEditors.SimpleButton
        Me.teMontoDesembolso = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
        Me.gcRefinancia = New DevExpress.XtraGrid.GridControl
        Me.gvRefinancia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCapital = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcInteres = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcMoratorio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSeguro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcOtros = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdPrestamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.leTipoGarantia = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.seTasaCapitalizacion = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.cboCapitalizacion = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.teAportacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.sePorcentajeAhorro = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teAhorro = New DevExpress.XtraEditors.TextEdit
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.gcDeducciones = New DevExpress.XtraGrid.GridControl
        Me.gvDeducciones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.teDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.gcGravado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAplicaIva = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.teTotalDeducciones = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.teIva = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.sbEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.teRefinancia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.sbCalculadora = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoSolicitud.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teMontoDesembolso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcRefinancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvRefinancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoGarantia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seTasaCapitalizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCapitalizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAportacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sePorcentajeAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAhorro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTotalDeducciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teRefinancia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teIdSolicitud
        '
        Me.teIdSolicitud.Location = New System.Drawing.Point(228, 4)
        Me.teIdSolicitud.Name = "teIdSolicitud"
        Me.teIdSolicitud.Properties.ReadOnly = True
        Me.teIdSolicitud.Size = New System.Drawing.Size(66, 20)
        Me.teIdSolicitud.TabIndex = 1
        '
        'beNoSolicitud
        '
        Me.beNoSolicitud.EditValue = ""
        Me.beNoSolicitud.EnterMoveNextControl = True
        Me.beNoSolicitud.Location = New System.Drawing.Point(121, 4)
        Me.beNoSolicitud.Name = "beNoSolicitud"
        Me.beNoSolicitud.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNoSolicitud.Size = New System.Drawing.Size(100, 20)
        Me.beNoSolicitud.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(20, 7)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl10.TabIndex = 73
        Me.LabelControl10.Text = "Número de Solicitud:"
        '
        'seNumeroDesembolso
        '
        Me.seNumeroDesembolso.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seNumeroDesembolso.EnterMoveNextControl = True
        Me.seNumeroDesembolso.Location = New System.Drawing.Point(121, 25)
        Me.seNumeroDesembolso.Name = "seNumeroDesembolso"
        Me.seNumeroDesembolso.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seNumeroDesembolso.Size = New System.Drawing.Size(49, 20)
        Me.seNumeroDesembolso.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 28)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl5.TabIndex = 112
        Me.LabelControl5.Text = "No. de Desembolso:"
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(29, 49)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl12.TabIndex = 114
        Me.LabelControl12.Text = "Fecha de Entrega:"
        '
        'deFechaEntrega
        '
        Me.deFechaEntrega.EditValue = Nothing
        Me.deFechaEntrega.EnterMoveNextControl = True
        Me.deFechaEntrega.Location = New System.Drawing.Point(121, 46)
        Me.deFechaEntrega.Name = "deFechaEntrega"
        Me.deFechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaEntrega.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaEntrega.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaEntrega.Size = New System.Drawing.Size(100, 20)
        Me.deFechaEntrega.TabIndex = 4
        '
        'sbCalcular
        '
        Me.sbCalcular.Location = New System.Drawing.Point(120, 70)
        Me.sbCalcular.Name = "sbCalcular"
        Me.sbCalcular.Size = New System.Drawing.Size(200, 24)
        Me.sbCalcular.TabIndex = 5
        Me.sbCalcular.Text = "Calcular Saldos de Refinanciamiento"
        '
        'teMontoDesembolso
        '
        Me.teMontoDesembolso.EditValue = 0
        Me.teMontoDesembolso.EnterMoveNextControl = True
        Me.teMontoDesembolso.Location = New System.Drawing.Point(518, 74)
        Me.teMontoDesembolso.Name = "teMontoDesembolso"
        Me.teMontoDesembolso.Properties.Appearance.Options.UseTextOptions = True
        Me.teMontoDesembolso.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teMontoDesembolso.Properties.Mask.EditMask = "n2"
        Me.teMontoDesembolso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teMontoDesembolso.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teMontoDesembolso.Size = New System.Drawing.Size(101, 20)
        Me.teMontoDesembolso.TabIndex = 6
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(408, 77)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(107, 13)
        Me.LabelControl38.TabIndex = 133
        Me.LabelControl38.Text = "Monto a Desembolsar:"
        '
        'gcRefinancia
        '
        GridLevelNode1.RelationName = "Level1"
        Me.gcRefinancia.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.gcRefinancia.Location = New System.Drawing.Point(13, 98)
        Me.gcRefinancia.MainView = Me.gvRefinancia
        Me.gcRefinancia.Name = "gcRefinancia"
        Me.gcRefinancia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit2, Me.leTipoGarantia})
        Me.gcRefinancia.Size = New System.Drawing.Size(606, 100)
        Me.gcRefinancia.TabIndex = 134
        Me.gcRefinancia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvRefinancia})
        '
        'gvRefinancia
        '
        Me.gvRefinancia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNumero, Me.gcCapital, Me.gcInteres, Me.gcMoratorio, Me.gcSeguro, Me.gcOtros, Me.gcIdPrestamo})
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
        Me.gcNumero.Width = 103
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
        Me.gcCapital.Width = 99
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
        Me.gcInteres.Width = 85
        '
        'gcMoratorio
        '
        Me.gcMoratorio.Caption = "Interes Moratorio"
        Me.gcMoratorio.FieldName = "SaldoInteresMora"
        Me.gcMoratorio.Name = "gcMoratorio"
        Me.gcMoratorio.OptionsColumn.ReadOnly = True
        Me.gcMoratorio.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcMoratorio.Visible = True
        Me.gcMoratorio.VisibleIndex = 3
        Me.gcMoratorio.Width = 98
        '
        'gcSeguro
        '
        Me.gcSeguro.Caption = "Seguro Prestamo"
        Me.gcSeguro.FieldName = "SaldoSeguro"
        Me.gcSeguro.Name = "gcSeguro"
        Me.gcSeguro.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcSeguro.Visible = True
        Me.gcSeguro.VisibleIndex = 4
        Me.gcSeguro.Width = 94
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
        Me.gcOtros.Width = 106
        '
        'gcIdPrestamo
        '
        Me.gcIdPrestamo.Caption = "Id. Prestamo"
        Me.gcIdPrestamo.FieldName = "IdPrestamo"
        Me.gcIdPrestamo.Name = "gcIdPrestamo"
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
        'seTasaCapitalizacion
        '
        Me.seTasaCapitalizacion.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seTasaCapitalizacion.EnterMoveNextControl = True
        Me.seTasaCapitalizacion.Location = New System.Drawing.Point(161, 230)
        Me.seTasaCapitalizacion.Name = "seTasaCapitalizacion"
        Me.seTasaCapitalizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seTasaCapitalizacion.Properties.Mask.EditMask = "P2"
        Me.seTasaCapitalizacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.seTasaCapitalizacion.Size = New System.Drawing.Size(84, 20)
        Me.seTasaCapitalizacion.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 233)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl4.TabIndex = 136
        Me.LabelControl4.Text = "% de Capitalización a Aplicar:"
        '
        'cboCapitalizacion
        '
        Me.cboCapitalizacion.EnterMoveNextControl = True
        Me.cboCapitalizacion.Location = New System.Drawing.Point(437, 230)
        Me.cboCapitalizacion.Name = "cboCapitalizacion"
        Me.cboCapitalizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCapitalizacion.Size = New System.Drawing.Size(182, 20)
        Me.cboCapitalizacion.TabIndex = 8
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(315, 233)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl11.TabIndex = 138
        Me.LabelControl11.Text = "Aplicar Capitalización a?:"
        '
        'teAportacion
        '
        Me.teAportacion.EditValue = 0
        Me.teAportacion.EnterMoveNextControl = True
        Me.teAportacion.Location = New System.Drawing.Point(161, 252)
        Me.teAportacion.Name = "teAportacion"
        Me.teAportacion.Properties.Appearance.Options.UseTextOptions = True
        Me.teAportacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teAportacion.Properties.Mask.EditMask = "n2"
        Me.teAportacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teAportacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teAportacion.Size = New System.Drawing.Size(83, 20)
        Me.teAportacion.TabIndex = 9
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(91, 255)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl26.TabIndex = 141
        Me.LabelControl26.Text = "Aportaciones:"
        '
        'sePorcentajeAhorro
        '
        Me.sePorcentajeAhorro.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.sePorcentajeAhorro.EnterMoveNextControl = True
        Me.sePorcentajeAhorro.Location = New System.Drawing.Point(161, 274)
        Me.sePorcentajeAhorro.Name = "sePorcentajeAhorro"
        Me.sePorcentajeAhorro.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.sePorcentajeAhorro.Properties.Mask.EditMask = "P2"
        Me.sePorcentajeAhorro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.sePorcentajeAhorro.Size = New System.Drawing.Size(84, 20)
        Me.sePorcentajeAhorro.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(48, 278)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl1.TabIndex = 143
        Me.LabelControl1.Text = "% de Ahorro a Aplicar:"
        '
        'teAhorro
        '
        Me.teAhorro.EditValue = 0
        Me.teAhorro.EnterMoveNextControl = True
        Me.teAhorro.Location = New System.Drawing.Point(246, 274)
        Me.teAhorro.Name = "teAhorro"
        Me.teAhorro.Properties.Appearance.Options.UseTextOptions = True
        Me.teAhorro.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teAhorro.Properties.Mask.EditMask = "n2"
        Me.teAhorro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teAhorro.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teAhorro.Size = New System.Drawing.Size(101, 20)
        Me.teAhorro.TabIndex = 11
        '
        'teIdCuenta
        '
        Me.teIdCuenta.Location = New System.Drawing.Point(537, 274)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(82, 20)
        Me.teIdCuenta.TabIndex = 13
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(430, 274)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(101, 20)
        Me.beNumeroCuenta.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(362, 278)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl6.TabIndex = 147
        Me.LabelControl6.Text = "Num. Cuenta:"
        '
        'gcDeducciones
        '
        GridLevelNode2.RelationName = "Level1"
        Me.gcDeducciones.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.gcDeducciones.Location = New System.Drawing.Point(15, 320)
        Me.gcDeducciones.MainView = Me.gvDeducciones
        Me.gcDeducciones.Name = "gcDeducciones"
        Me.gcDeducciones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.teDescuento})
        Me.gcDeducciones.Size = New System.Drawing.Size(606, 114)
        Me.gcDeducciones.TabIndex = 148
        Me.gcDeducciones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDeducciones})
        '
        'gvDeducciones
        '
        Me.gvDeducciones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNombre, Me.gcValor, Me.gcGravado, Me.gcAplicaIva})
        Me.gvDeducciones.GridControl = Me.gcDeducciones
        Me.gvDeducciones.Name = "gvDeducciones"
        Me.gvDeducciones.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvDeducciones.OptionsView.ShowGroupPanel = False
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Descripcion"
        Me.gcNombre.FieldName = "Nombre"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.OptionsColumn.AllowEdit = False
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 0
        Me.gcNombre.Width = 476
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.ColumnEdit = Me.teDescuento
        Me.gcValor.DisplayFormat.FormatString = "n2"
        Me.gcValor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 1
        Me.gcValor.Width = 109
        '
        'teDescuento
        '
        Me.teDescuento.AutoHeight = False
        Me.teDescuento.Mask.EditMask = "n2"
        Me.teDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.teDescuento.Name = "teDescuento"
        '
        'gcGravado
        '
        Me.gcGravado.Caption = "Gravado"
        Me.gcGravado.FieldName = "Gravado"
        Me.gcGravado.Name = "gcGravado"
        Me.gcGravado.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'gcAplicaIva
        '
        Me.gcAplicaIva.Caption = "Aplica Iva"
        Me.gcAplicaIva.FieldName = "AplicaIva"
        Me.gcAplicaIva.Name = "gcAplicaIva"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(44, 301)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(117, 18)
        Me.LabelControl2.TabIndex = 149
        Me.LabelControl2.Text = "DEDUCCIONES:"
        '
        'sbGuardar
        '
        Me.sbGuardar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.sbGuardar.Appearance.Options.UseFont = True
        Me.sbGuardar.Location = New System.Drawing.Point(52, 441)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(109, 35)
        Me.sbGuardar.TabIndex = 16
        Me.sbGuardar.Text = "&Guardar"
        '
        'teTotalDeducciones
        '
        Me.teTotalDeducciones.EditValue = 0
        Me.teTotalDeducciones.EnterMoveNextControl = True
        Me.teTotalDeducciones.Location = New System.Drawing.Point(521, 440)
        Me.teTotalDeducciones.Name = "teTotalDeducciones"
        Me.teTotalDeducciones.Properties.Appearance.Options.UseTextOptions = True
        Me.teTotalDeducciones.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teTotalDeducciones.Properties.Mask.EditMask = "n2"
        Me.teTotalDeducciones.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teTotalDeducciones.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teTotalDeducciones.Size = New System.Drawing.Size(83, 20)
        Me.teTotalDeducciones.TabIndex = 15
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(427, 444)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl3.TabIndex = 152
        Me.LabelControl3.Text = "Total Deducciones:"
        '
        'teIva
        '
        Me.teIva.EditValue = 0
        Me.teIva.EnterMoveNextControl = True
        Me.teIva.Location = New System.Drawing.Point(335, 440)
        Me.teIva.Name = "teIva"
        Me.teIva.Properties.Appearance.Options.UseTextOptions = True
        Me.teIva.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teIva.Properties.Mask.EditMask = "n2"
        Me.teIva.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teIva.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teIva.Size = New System.Drawing.Size(83, 20)
        Me.teIva.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(312, 443)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl7.TabIndex = 154
        Me.LabelControl7.Text = "Iva:"
        '
        'teNombre
        '
        Me.teNombre.Location = New System.Drawing.Point(300, 4)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(319, 20)
        Me.teNombre.TabIndex = 2
        '
        'sbEliminar
        '
        Me.sbEliminar.Image = Global.Bravio.My.Resources.Resources.Delete
        Me.sbEliminar.Location = New System.Drawing.Point(622, 118)
        Me.sbEliminar.Name = "sbEliminar"
        Me.sbEliminar.Size = New System.Drawing.Size(37, 33)
        Me.sbEliminar.TabIndex = 155
        '
        'teRefinancia
        '
        Me.teRefinancia.EditValue = 0
        Me.teRefinancia.EnterMoveNextControl = True
        Me.teRefinancia.Location = New System.Drawing.Point(518, 202)
        Me.teRefinancia.Name = "teRefinancia"
        Me.teRefinancia.Properties.Appearance.Options.UseTextOptions = True
        Me.teRefinancia.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teRefinancia.Properties.Mask.EditMask = "n2"
        Me.teRefinancia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teRefinancia.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teRefinancia.Size = New System.Drawing.Size(101, 20)
        Me.teRefinancia.TabIndex = 156
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(400, 205)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl8.TabIndex = 157
        Me.LabelControl8.Text = "Total Refinanciamiento:"
        '
        'sbCalculadora
        '
        Me.sbCalculadora.Image = Global.Bravio.My.Resources.Resources.accessories_calculator_3
        Me.sbCalculadora.Location = New System.Drawing.Point(254, 27)
        Me.sbCalculadora.Name = "sbCalculadora"
        Me.sbCalculadora.Size = New System.Drawing.Size(40, 40)
        Me.sbCalculadora.TabIndex = 158
        '
        'pre_frmSolicitudFondos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 527)
        Me.Controls.Add(Me.sbCalculadora)
        Me.Controls.Add(Me.teRefinancia)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.sbEliminar)
        Me.Controls.Add(Me.teIva)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.teTotalDeducciones)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.gcDeducciones)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.beNumeroCuenta)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.teAhorro)
        Me.Controls.Add(Me.sePorcentajeAhorro)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teAportacion)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.cboCapitalizacion)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.seTasaCapitalizacion)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.gcRefinancia)
        Me.Controls.Add(Me.teMontoDesembolso)
        Me.Controls.Add(Me.LabelControl38)
        Me.Controls.Add(Me.sbCalcular)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.deFechaEntrega)
        Me.Controls.Add(Me.seNumeroDesembolso)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdSolicitud)
        Me.Controls.Add(Me.beNoSolicitud)
        Me.Controls.Add(Me.LabelControl10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmSolicitudFondos"
        Me.OptionId = "003002"
        Me.Text = "Solicitud de Fondos"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl10, 0)
        Me.Controls.SetChildIndex(Me.beNoSolicitud, 0)
        Me.Controls.SetChildIndex(Me.teIdSolicitud, 0)
        Me.Controls.SetChildIndex(Me.teNombre, 0)
        Me.Controls.SetChildIndex(Me.LabelControl5, 0)
        Me.Controls.SetChildIndex(Me.seNumeroDesembolso, 0)
        Me.Controls.SetChildIndex(Me.deFechaEntrega, 0)
        Me.Controls.SetChildIndex(Me.LabelControl12, 0)
        Me.Controls.SetChildIndex(Me.sbCalcular, 0)
        Me.Controls.SetChildIndex(Me.LabelControl38, 0)
        Me.Controls.SetChildIndex(Me.teMontoDesembolso, 0)
        Me.Controls.SetChildIndex(Me.gcRefinancia, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.seTasaCapitalizacion, 0)
        Me.Controls.SetChildIndex(Me.LabelControl11, 0)
        Me.Controls.SetChildIndex(Me.cboCapitalizacion, 0)
        Me.Controls.SetChildIndex(Me.LabelControl26, 0)
        Me.Controls.SetChildIndex(Me.teAportacion, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.sePorcentajeAhorro, 0)
        Me.Controls.SetChildIndex(Me.teAhorro, 0)
        Me.Controls.SetChildIndex(Me.LabelControl6, 0)
        Me.Controls.SetChildIndex(Me.beNumeroCuenta, 0)
        Me.Controls.SetChildIndex(Me.teIdCuenta, 0)
        Me.Controls.SetChildIndex(Me.gcDeducciones, 0)
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.sbGuardar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.teTotalDeducciones, 0)
        Me.Controls.SetChildIndex(Me.LabelControl7, 0)
        Me.Controls.SetChildIndex(Me.teIva, 0)
        Me.Controls.SetChildIndex(Me.sbEliminar, 0)
        Me.Controls.SetChildIndex(Me.LabelControl8, 0)
        Me.Controls.SetChildIndex(Me.teRefinancia, 0)
        Me.Controls.SetChildIndex(Me.sbCalculadora, 0)
        CType(Me.teIdSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoSolicitud.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seNumeroDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaEntrega.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teMontoDesembolso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcRefinancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvRefinancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoGarantia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seTasaCapitalizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCapitalizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAportacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sePorcentajeAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAhorro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTotalDeducciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teRefinancia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teIdSolicitud As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNoSolicitud As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents seNumeroDesembolso As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents sbCalcular As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teMontoDesembolso As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents seTasaCapitalizacion As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCapitalizacion As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAportacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sePorcentajeAhorro As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAhorro As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDeducciones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDeducciones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teTotalDeducciones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIva As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcGravado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAplicaIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcIdPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teRefinancia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents sbCalculadora As DevExpress.XtraEditors.SimpleButton
End Class
