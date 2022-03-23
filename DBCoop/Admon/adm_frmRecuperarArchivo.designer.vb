<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adm_frmRecuperarArchivo
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.deFecha = New DevExpress.XtraEditors.DateEdit()
        Me.btProceder = New DevExpress.XtraEditors.SimpleButton()
        Me.btArchivoSucursal = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl()
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sbAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.leTipoArchivo = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.TeNumeroFactura = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.ChecCargaExcel = New DevExpress.XtraEditors.CheckEdit()
        Me.BtnGenerarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckAbono = New DevExpress.XtraEditors.CheckEdit()
        Me.GCTelefonia = New DevExpress.XtraGrid.GridControl()
        Me.GVTelefonia = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gc = New DevExpress.XtraGrid.GridControl()
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNumeroAsociado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNombres = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcApellidos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIdAsociado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcIdUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcNombreUbicacion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btArchivoSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeNumeroFactura.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChecCargaExcel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckAbono.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCTelefonia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVTelefonia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 28)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Fecha Aplicación:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(99, 25)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 6
        '
        'btProceder
        '
        Me.btProceder.Location = New System.Drawing.Point(412, 29)
        Me.btProceder.Name = "btProceder"
        Me.btProceder.Size = New System.Drawing.Size(82, 23)
        Me.btProceder.TabIndex = 7
        Me.btProceder.Text = "Cargar Datos"
        '
        'btArchivoSucursal
        '
        Me.btArchivoSucursal.EnterMoveNextControl = True
        Me.btArchivoSucursal.Location = New System.Drawing.Point(306, 25)
        Me.btArchivoSucursal.Name = "btArchivoSucursal"
        Me.btArchivoSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.btArchivoSucursal.Size = New System.Drawing.Size(93, 20)
        Me.btArchivoSucursal.TabIndex = 138
        Me.btArchivoSucursal.Visible = False
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(207, 29)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl64.TabIndex = 139
        Me.LabelControl64.Text = "Archivo de Sucursal:"
        Me.LabelControl64.Visible = False
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'sbAplicar
        '
        Me.sbAplicar.Location = New System.Drawing.Point(695, 6)
        Me.sbAplicar.Name = "sbAplicar"
        Me.sbAplicar.Size = New System.Drawing.Size(112, 32)
        Me.sbAplicar.TabIndex = 141
        Me.sbAplicar.Text = "Aplicar Descuentos"
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(99, 3)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(301, 20)
        Me.leSucursal.TabIndex = 142
        Me.leSucursal.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(49, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 143
        Me.LabelControl1.Text = "Sucursal:"
        Me.LabelControl1.Visible = False
        '
        'leTipoArchivo
        '
        Me.leTipoArchivo.EnterMoveNextControl = True
        Me.leTipoArchivo.Location = New System.Drawing.Point(99, 49)
        Me.leTipoArchivo.Name = "leTipoArchivo"
        Me.leTipoArchivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoArchivo.Size = New System.Drawing.Size(301, 20)
        Me.leTipoArchivo.TabIndex = 150
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(32, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 149
        Me.LabelControl4.Text = "Tipo Archivo:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(813, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 32)
        Me.SimpleButton1.TabIndex = 151
        Me.SimpleButton1.Text = "Socios sin Cuenta AH "
        '
        'TeNumeroFactura
        '
        Me.TeNumeroFactura.EnterMoveNextControl = True
        Me.TeNumeroFactura.Location = New System.Drawing.Point(737, 45)
        Me.TeNumeroFactura.Name = "TeNumeroFactura"
        Me.TeNumeroFactura.Size = New System.Drawing.Size(185, 20)
        Me.TeNumeroFactura.TabIndex = 153
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(654, 48)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl26.TabIndex = 154
        Me.LabelControl26.Text = "Numero Factura:"
        '
        'ChecCargaExcel
        '
        Me.ChecCargaExcel.EnterMoveNextControl = True
        Me.ChecCargaExcel.Location = New System.Drawing.Point(410, 10)
        Me.ChecCargaExcel.Name = "ChecCargaExcel"
        Me.ChecCargaExcel.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChecCargaExcel.Properties.Appearance.Options.UseFont = True
        Me.ChecCargaExcel.Properties.Caption = "Cargar Datos desde Excel"
        Me.ChecCargaExcel.Size = New System.Drawing.Size(183, 19)
        Me.ChecCargaExcel.TabIndex = 155
        Me.ChecCargaExcel.TabStop = False
        '
        'BtnGenerarExcel
        '
        Me.BtnGenerarExcel.Image = Global.Bravio.My.Resources.Resources.page_excel1
        Me.BtnGenerarExcel.Location = New System.Drawing.Point(813, 6)
        Me.BtnGenerarExcel.Name = "BtnGenerarExcel"
        Me.BtnGenerarExcel.Size = New System.Drawing.Size(109, 32)
        Me.BtnGenerarExcel.TabIndex = 156
        Me.BtnGenerarExcel.Text = "Generar Excel .."
        '
        'CheckAbono
        '
        Me.CheckAbono.EnterMoveNextControl = True
        Me.CheckAbono.Location = New System.Drawing.Point(99, 72)
        Me.CheckAbono.Name = "CheckAbono"
        Me.CheckAbono.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckAbono.Properties.Appearance.Options.UseFont = True
        Me.CheckAbono.Properties.Caption = "Archivo de Abono Telefonico"
        Me.CheckAbono.Size = New System.Drawing.Size(183, 19)
        Me.CheckAbono.TabIndex = 157
        Me.CheckAbono.TabStop = False
        '
        'GCTelefonia
        '
        Me.GCTelefonia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GCTelefonia.Location = New System.Drawing.Point(0, 99)
        Me.GCTelefonia.MainView = Me.GVTelefonia
        Me.GCTelefonia.Name = "GCTelefonia"
        Me.GCTelefonia.Size = New System.Drawing.Size(925, 388)
        Me.GCTelefonia.TabIndex = 158
        Me.GCTelefonia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVTelefonia})
        '
        'GVTelefonia
        '
        Me.GVTelefonia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn6, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17})
        Me.GVTelefonia.GridControl = Me.GCTelefonia
        Me.GVTelefonia.Name = "GVTelefonia"
        Me.GVTelefonia.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GVTelefonia.OptionsView.ShowAutoFilterRow = True
        Me.GVTelefonia.OptionsView.ShowFooter = True
        Me.GVTelefonia.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "IdAsociado"
        Me.GridColumn10.FieldName = "IdAsociado"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Número Asociado"
        Me.GridColumn7.FieldName = "Numero"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 0
        Me.GridColumn7.Width = 91
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Nombres"
        Me.GridColumn8.FieldName = "Nombres"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.ReadOnly = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 108
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Apellidos"
        Me.GridColumn9.FieldName = "Apellidos"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 129
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Telefono"
        Me.GridColumn6.FieldName = "Telefono"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Numero Factura"
        Me.GridColumn11.FieldName = "NumeroFactura"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Width = 92
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Valor Total Factura"
        Me.GridColumn12.DisplayFormat.FormatString = "n2"
        Me.GridColumn12.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn12.FieldName = "ValorTotalFactura"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorTotalFactura", "{0:c2}")})
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.GridColumn12.Width = 99
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Valor Iva"
        Me.GridColumn13.FieldName = "ValorIva"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorIva", "{0:c2}")})
        Me.GridColumn13.Width = 97
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Valor Seguridad"
        Me.GridColumn14.FieldName = "ValorSeguridad"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorSeguridad", "{0:c2}")})
        Me.GridColumn14.Width = 98
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Valor Comision"
        Me.GridColumn15.FieldName = "ValorComicion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ValorComicion", "{0:c2}")})
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        Me.GridColumn15.Width = 79
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Total"
        Me.GridColumn16.FieldName = "Total"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.AllowEdit = False
        Me.GridColumn16.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "{0:c2}")})
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        Me.GridColumn16.Width = 114
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Sub-Total"
        Me.GridColumn17.DisplayFormat.FormatString = "n2"
        Me.GridColumn17.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn17.FieldName = "SubTotal"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "{0:c2}")})
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gc.Location = New System.Drawing.Point(0, -296)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(925, 395)
        Me.gc.TabIndex = 159
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.gcNumeroAsociado, Me.gcNombres, Me.gcApellidos, Me.GridColumn4, Me.GridColumn5, Me.gcDescuento, Me.gcIdAsociado, Me.gcIdUbicacion, Me.gcNombreUbicacion, Me.GridColumn1, Me.GridColumn2})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "No."
        Me.GridColumn3.FieldName = "Num"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        '
        'gcNumeroAsociado
        '
        Me.gcNumeroAsociado.Caption = "Número Asociado"
        Me.gcNumeroAsociado.FieldName = "Numero"
        Me.gcNumeroAsociado.Name = "gcNumeroAsociado"
        Me.gcNumeroAsociado.OptionsColumn.ReadOnly = True
        Me.gcNumeroAsociado.Visible = True
        Me.gcNumeroAsociado.VisibleIndex = 1
        Me.gcNumeroAsociado.Width = 100
        '
        'gcNombres
        '
        Me.gcNombres.Caption = "Nombres"
        Me.gcNombres.FieldName = "Nombres"
        Me.gcNombres.Name = "gcNombres"
        Me.gcNombres.OptionsColumn.ReadOnly = True
        Me.gcNombres.Visible = True
        Me.gcNombres.VisibleIndex = 2
        Me.gcNombres.Width = 253
        '
        'gcApellidos
        '
        Me.gcApellidos.Caption = "Apellidos"
        Me.gcApellidos.FieldName = "Apellidos"
        Me.gcApellidos.Name = "gcApellidos"
        Me.gcApellidos.OptionsColumn.ReadOnly = True
        Me.gcApellidos.Visible = True
        Me.gcApellidos.VisibleIndex = 3
        Me.gcApellidos.Width = 289
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Aportaciones"
        Me.GridColumn4.FieldName = "Aportaciones"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aportaciones", "{0:c2}")})
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Ahorros"
        Me.GridColumn5.FieldName = "Ahorros"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ahorros", "{0:c2}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        '
        'gcDescuento
        '
        Me.gcDescuento.Caption = "Préstamos"
        Me.gcDescuento.DisplayFormat.FormatString = "{0:c2}"
        Me.gcDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcDescuento.FieldName = "Prestamos"
        Me.gcDescuento.Name = "gcDescuento"
        Me.gcDescuento.OptionsColumn.ReadOnly = True
        Me.gcDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Prestamos", "{0:c2}")})
        Me.gcDescuento.Visible = True
        Me.gcDescuento.VisibleIndex = 6
        Me.gcDescuento.Width = 119
        '
        'gcIdAsociado
        '
        Me.gcIdAsociado.Caption = "IdAsociado"
        Me.gcIdAsociado.FieldName = "IdAsociado"
        Me.gcIdAsociado.Name = "gcIdAsociado"
        '
        'gcIdUbicacion
        '
        Me.gcIdUbicacion.Caption = "IdUbicacion"
        Me.gcIdUbicacion.FieldName = "IdUbicacion"
        Me.gcIdUbicacion.Name = "gcIdUbicacion"
        '
        'gcNombreUbicacion
        '
        Me.gcNombreUbicacion.Caption = "NombreUbicacion"
        Me.gcNombreUbicacion.FieldName = "NombreUbicacion"
        Me.gcNombreUbicacion.Name = "gcNombreUbicacion"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "NumeroPrestamo"
        Me.GridColumn1.FieldName = "NumeroPrestamo"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "IdPrestamo"
        Me.GridColumn2.FieldName = "IdPrestamo"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'adm_frmRecuperarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(925, 515)
        Me.Controls.Add(Me.gc)
        Me.Controls.Add(Me.GCTelefonia)
        Me.Controls.Add(Me.CheckAbono)
        Me.Controls.Add(Me.BtnGenerarExcel)
        Me.Controls.Add(Me.ChecCargaExcel)
        Me.Controls.Add(Me.TeNumeroFactura)
        Me.Controls.Add(Me.LabelControl26)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.leTipoArchivo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.sbAplicar)
        Me.Controls.Add(Me.btArchivoSucursal)
        Me.Controls.Add(Me.LabelControl64)
        Me.Controls.Add(Me.btProceder)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.LabelControl2)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmRecuperarArchivo"
        Me.OptionId = "001010"
        Me.Text = "Recuperar Archivo Descuentos Planilla"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.btProceder, 0)
        Me.Controls.SetChildIndex(Me.LabelControl64, 0)
        Me.Controls.SetChildIndex(Me.btArchivoSucursal, 0)
        Me.Controls.SetChildIndex(Me.sbAplicar, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.leTipoArchivo, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl26, 0)
        Me.Controls.SetChildIndex(Me.TeNumeroFactura, 0)
        Me.Controls.SetChildIndex(Me.ChecCargaExcel, 0)
        Me.Controls.SetChildIndex(Me.BtnGenerarExcel, 0)
        Me.Controls.SetChildIndex(Me.CheckAbono, 0)
        Me.Controls.SetChildIndex(Me.GCTelefonia, 0)
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.deFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btArchivoSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeNumeroFactura.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChecCargaExcel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckAbono.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCTelefonia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVTelefonia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btProceder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btArchivoSucursal As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sbAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoArchivo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TeNumeroFactura As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ChecCargaExcel As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BtnGenerarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CheckAbono As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GCTelefonia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVTelefonia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumeroAsociado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdAsociado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombreUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

End Class
