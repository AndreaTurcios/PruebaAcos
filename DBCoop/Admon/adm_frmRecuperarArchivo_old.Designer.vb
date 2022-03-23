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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.deFecha = New DevExpress.XtraEditors.DateEdit
        Me.btProceder = New DevExpress.XtraEditors.SimpleButton
        Me.btArchivoSucursal = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcNumeroAsociado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombres = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcApellidos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdAsociado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdUbicacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombreUbicacion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbAplicar = New DevExpress.XtraEditors.SimpleButton
        Me.leSucursal = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.leTipoPlanilla = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.leTipoArchivo = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btArchivoSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Fecha Aplicación:"
        '
        'deFecha
        '
        Me.deFecha.EditValue = Nothing
        Me.deFecha.Location = New System.Drawing.Point(125, 31)
        Me.deFecha.Name = "deFecha"
        Me.deFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFecha.Size = New System.Drawing.Size(100, 20)
        Me.deFecha.TabIndex = 6
        '
        'btProceder
        '
        Me.btProceder.Location = New System.Drawing.Point(441, 55)
        Me.btProceder.Name = "btProceder"
        Me.btProceder.Size = New System.Drawing.Size(75, 23)
        Me.btProceder.TabIndex = 7
        Me.btProceder.Text = "Cargar Datos"
        '
        'btArchivoSucursal
        '
        Me.btArchivoSucursal.EnterMoveNextControl = True
        Me.btArchivoSucursal.Location = New System.Drawing.Point(125, 58)
        Me.btArchivoSucursal.Name = "btArchivoSucursal"
        Me.btArchivoSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btArchivoSucursal.Size = New System.Drawing.Size(301, 20)
        Me.btArchivoSucursal.TabIndex = 138
        '
        'LabelControl64
        '
        Me.LabelControl64.Location = New System.Drawing.Point(21, 61)
        Me.LabelControl64.Name = "LabelControl64"
        Me.LabelControl64.Size = New System.Drawing.Size(98, 13)
        Me.LabelControl64.TabIndex = 139
        Me.LabelControl64.Text = "Archivo de Sucursal:"
        '
        'OpenFile
        '
        Me.OpenFile.FileName = "OpenFileDialog1"
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gc.Location = New System.Drawing.Point(0, 110)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(925, 380)
        Me.gc.TabIndex = 140
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcNumeroAsociado, Me.gcNombres, Me.gcApellidos, Me.gcDescuento, Me.gcIdAsociado, Me.gcIdUbicacion, Me.gcNombreUbicacion})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcNumeroAsociado
        '
        Me.gcNumeroAsociado.Caption = "Número Asociado"
        Me.gcNumeroAsociado.FieldName = "Numero"
        Me.gcNumeroAsociado.Name = "gcNumeroAsociado"
        Me.gcNumeroAsociado.OptionsColumn.ReadOnly = True
        Me.gcNumeroAsociado.Visible = True
        Me.gcNumeroAsociado.VisibleIndex = 0
        Me.gcNumeroAsociado.Width = 100
        '
        'gcNombres
        '
        Me.gcNombres.Caption = "Nombres"
        Me.gcNombres.FieldName = "Nombres"
        Me.gcNombres.Name = "gcNombres"
        Me.gcNombres.OptionsColumn.ReadOnly = True
        Me.gcNombres.Visible = True
        Me.gcNombres.VisibleIndex = 1
        Me.gcNombres.Width = 253
        '
        'gcApellidos
        '
        Me.gcApellidos.Caption = "Apellidos"
        Me.gcApellidos.FieldName = "Apellidos"
        Me.gcApellidos.Name = "gcApellidos"
        Me.gcApellidos.OptionsColumn.ReadOnly = True
        Me.gcApellidos.Visible = True
        Me.gcApellidos.VisibleIndex = 2
        Me.gcApellidos.Width = 289
        '
        'gcDescuento
        '
        Me.gcDescuento.Caption = "Valor Descuento"
        Me.gcDescuento.DisplayFormat.FormatString = "{0:c2}"
        Me.gcDescuento.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcDescuento.FieldName = "Descuento"
        Me.gcDescuento.Name = "gcDescuento"
        Me.gcDescuento.OptionsColumn.ReadOnly = True
        Me.gcDescuento.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Descuento", "{0:c2}")})
        Me.gcDescuento.Visible = True
        Me.gcDescuento.VisibleIndex = 3
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
        'sbAplicar
        '
        Me.sbAplicar.Location = New System.Drawing.Point(811, 37)
        Me.sbAplicar.Name = "sbAplicar"
        Me.sbAplicar.Size = New System.Drawing.Size(112, 32)
        Me.sbAplicar.TabIndex = 141
        Me.sbAplicar.Text = "Aplicar Descuentos"
        '
        'leSucursal
        '
        Me.leSucursal.Location = New System.Drawing.Point(483, 5)
        Me.leSucursal.Name = "leSucursal"
        Me.leSucursal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leSucursal.Size = New System.Drawing.Size(114, 20)
        Me.leSucursal.TabIndex = 142
        Me.leSucursal.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(433, 8)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl1.TabIndex = 143
        Me.LabelControl1.Text = "Sucursal:"
        Me.LabelControl1.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(811, 1)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 32)
        Me.SimpleButton1.TabIndex = 144
        Me.SimpleButton1.Text = "Imprimir Reporte"
        '
        'leTipoPlanilla
        '
        Me.leTipoPlanilla.EnterMoveNextControl = True
        Me.leTipoPlanilla.Location = New System.Drawing.Point(125, 5)
        Me.leTipoPlanilla.Name = "leTipoPlanilla"
        Me.leTipoPlanilla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoPlanilla.Size = New System.Drawing.Size(301, 20)
        Me.leTipoPlanilla.TabIndex = 146
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(116, 13)
        Me.LabelControl3.TabIndex = 145
        Me.LabelControl3.Text = "Tipo de Planilla a Envíar:"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(811, 73)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 32)
        Me.SimpleButton2.TabIndex = 147
        Me.SimpleButton2.Text = "Generar Partida"
        '
        'leTipoArchivo
        '
        Me.leTipoArchivo.EnterMoveNextControl = True
        Me.leTipoArchivo.Location = New System.Drawing.Point(125, 81)
        Me.leTipoArchivo.Name = "leTipoArchivo"
        Me.leTipoArchivo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoArchivo.Size = New System.Drawing.Size(301, 20)
        Me.leTipoArchivo.TabIndex = 150
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(58, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 149
        Me.LabelControl4.Text = "Tipo Archivo:"
        '
        'adm_frmRecuperarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(925, 515)
        Me.Controls.Add(Me.leTipoArchivo)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.leTipoPlanilla)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.leSucursal)
        Me.Controls.Add(Me.sbAplicar)
        Me.Controls.Add(Me.gc)
        Me.Controls.Add(Me.btArchivoSucursal)
        Me.Controls.Add(Me.LabelControl64)
        Me.Controls.Add(Me.btProceder)
        Me.Controls.Add(Me.deFecha)
        Me.Controls.Add(Me.LabelControl2)
        Me.Modulo = "Administración"
        Me.Name = "adm_frmRecuperarArchivo"
        Me.OptionId = "001012"
        Me.Text = "Recuperar Archivo Descuentos Planilla"
        Me.TipoFormulario = 3
        Me.Controls.SetChildIndex(Me.LabelControl2, 0)
        Me.Controls.SetChildIndex(Me.deFecha, 0)
        Me.Controls.SetChildIndex(Me.btProceder, 0)
        Me.Controls.SetChildIndex(Me.LabelControl64, 0)
        Me.Controls.SetChildIndex(Me.btArchivoSucursal, 0)
        Me.Controls.SetChildIndex(Me.gc, 0)
        Me.Controls.SetChildIndex(Me.sbAplicar, 0)
        Me.Controls.SetChildIndex(Me.leSucursal, 0)
        Me.Controls.SetChildIndex(Me.LabelControl1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.LabelControl3, 0)
        Me.Controls.SetChildIndex(Me.leTipoPlanilla, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
        Me.Controls.SetChildIndex(Me.LabelControl4, 0)
        Me.Controls.SetChildIndex(Me.leTipoArchivo, 0)
        CType(Me.deFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btArchivoSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leSucursal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoPlanilla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoArchivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btProceder As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btArchivoSucursal As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcNumeroAsociado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombres As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdAsociado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents leSucursal As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcIdUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombreUbicacion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leTipoPlanilla As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents leTipoArchivo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl

End Class
