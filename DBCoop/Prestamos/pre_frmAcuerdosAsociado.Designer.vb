<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmAcuerdosAsociado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmAcuerdosAsociado))
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.beNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaAcuerdo = New DevExpress.XtraEditors.DateEdit
        Me.teSaldo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.leTipoCarta = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teAcuerdo = New DevExpress.XtraEditors.MemoEdit
        Me.deFechaVencimiento = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcTipoCarta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAcuerdo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.meAcuerdo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.gcIdSeguimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcFechaVencimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.sbEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.sbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.sbRegresar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaAcuerdo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaAcuerdo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leTipoCarta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teAcuerdo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meAcuerdo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teNombre
        '
        Me.teNombre.Location = New System.Drawing.Point(362, 8)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(367, 20)
        Me.teNombre.TabIndex = 200
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Location = New System.Drawing.Point(290, 8)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(66, 20)
        Me.teIdPrestamo.TabIndex = 199
        '
        'beNumPrestamo
        '
        Me.beNumPrestamo.EditValue = ""
        Me.beNumPrestamo.EnterMoveNextControl = True
        Me.beNumPrestamo.Location = New System.Drawing.Point(184, 8)
        Me.beNumPrestamo.Name = "beNumPrestamo"
        Me.beNumPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumPrestamo.Properties.ReadOnly = True
        Me.beNumPrestamo.Size = New System.Drawing.Size(100, 20)
        Me.beNumPrestamo.TabIndex = 198
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(74, 11)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl10.TabIndex = 201
        Me.LabelControl10.Text = "Número de Préstamo:"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(85, 34)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl29.TabIndex = 228
        Me.LabelControl29.Text = "Fecha del Acuerdo:"
        '
        'deFechaAcuerdo
        '
        Me.deFechaAcuerdo.EditValue = Nothing
        Me.deFechaAcuerdo.EnterMoveNextControl = True
        Me.deFechaAcuerdo.Location = New System.Drawing.Point(184, 31)
        Me.deFechaAcuerdo.Name = "deFechaAcuerdo"
        Me.deFechaAcuerdo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaAcuerdo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaAcuerdo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaAcuerdo.Size = New System.Drawing.Size(100, 20)
        Me.deFechaAcuerdo.TabIndex = 0
        '
        'teSaldo
        '
        Me.teSaldo.EditValue = 0
        Me.teSaldo.EnterMoveNextControl = True
        Me.teSaldo.Location = New System.Drawing.Point(626, 31)
        Me.teSaldo.Name = "teSaldo"
        Me.teSaldo.Properties.Appearance.Options.UseTextOptions = True
        Me.teSaldo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.teSaldo.Properties.Mask.EditMask = "n2"
        Me.teSaldo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teSaldo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.teSaldo.Properties.ReadOnly = True
        Me.teSaldo.Size = New System.Drawing.Size(101, 20)
        Me.teSaldo.TabIndex = 236
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(543, 35)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl12.TabIndex = 237
        Me.LabelControl12.Text = "Saldo de Capital:"
        '
        'leTipoCarta
        '
        Me.leTipoCarta.EnterMoveNextControl = True
        Me.leTipoCarta.Location = New System.Drawing.Point(184, 54)
        Me.leTipoCarta.Name = "leTipoCarta"
        Me.leTipoCarta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.leTipoCarta.Size = New System.Drawing.Size(247, 20)
        Me.leTipoCarta.TabIndex = 1
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(45, 56)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(133, 13)
        Me.LabelControl32.TabIndex = 239
        Me.LabelControl32.Text = "Tipo de Carta que se Envio:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(97, 88)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl1.TabIndex = 240
        Me.LabelControl1.Text = "Acuerdo de Hoy:"
        '
        'teAcuerdo
        '
        Me.teAcuerdo.EnterMoveNextControl = True
        Me.teAcuerdo.Location = New System.Drawing.Point(183, 84)
        Me.teAcuerdo.Name = "teAcuerdo"
        Me.teAcuerdo.Properties.MaxLength = 150
        Me.teAcuerdo.Size = New System.Drawing.Size(546, 78)
        Me.teAcuerdo.TabIndex = 2
        '
        'deFechaVencimiento
        '
        Me.deFechaVencimiento.EditValue = Nothing
        Me.deFechaVencimiento.EnterMoveNextControl = True
        Me.deFechaVencimiento.Location = New System.Drawing.Point(183, 168)
        Me.deFechaVencimiento.Name = "deFechaVencimiento"
        Me.deFechaVencimiento.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaVencimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaVencimiento.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaVencimiento.Size = New System.Drawing.Size(100, 20)
        Me.deFechaVencimiento.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 171)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(168, 13)
        Me.LabelControl2.TabIndex = 243
        Me.LabelControl2.Text = "Fecha de Vencimiento del Acuerdo:"
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(12, 194)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.meAcuerdo})
        Me.gcMov.Size = New System.Drawing.Size(835, 215)
        Me.gcMov.TabIndex = 244
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcTipoCarta, Me.gcSaldo, Me.gcAcuerdo, Me.gcIdSeguimiento, Me.gcFechaVencimiento})
        Me.gvMov.GridControl = Me.gcMov
        Me.gvMov.Name = "gvMov"
        Me.gvMov.OptionsView.ShowGroupPanel = False
        '
        'gcFecha
        '
        Me.gcFecha.Caption = "Fecha"
        Me.gcFecha.FieldName = "Fecha"
        Me.gcFecha.Name = "gcFecha"
        Me.gcFecha.OptionsColumn.ReadOnly = True
        Me.gcFecha.Visible = True
        Me.gcFecha.VisibleIndex = 0
        Me.gcFecha.Width = 87
        '
        'gcTipoCarta
        '
        Me.gcTipoCarta.Caption = "T/C"
        Me.gcTipoCarta.FieldName = "TipoCarta"
        Me.gcTipoCarta.Name = "gcTipoCarta"
        Me.gcTipoCarta.OptionsColumn.ReadOnly = True
        Me.gcTipoCarta.Visible = True
        Me.gcTipoCarta.VisibleIndex = 1
        Me.gcTipoCarta.Width = 43
        '
        'gcSaldo
        '
        Me.gcSaldo.Caption = "Saldo"
        Me.gcSaldo.FieldName = "Saldo"
        Me.gcSaldo.Name = "gcSaldo"
        Me.gcSaldo.OptionsColumn.ReadOnly = True
        Me.gcSaldo.Visible = True
        Me.gcSaldo.VisibleIndex = 2
        Me.gcSaldo.Width = 87
        '
        'gcAcuerdo
        '
        Me.gcAcuerdo.Caption = "Acuerdo"
        Me.gcAcuerdo.ColumnEdit = Me.meAcuerdo
        Me.gcAcuerdo.FieldName = "Acuerdos"
        Me.gcAcuerdo.Name = "gcAcuerdo"
        Me.gcAcuerdo.OptionsColumn.ReadOnly = True
        Me.gcAcuerdo.Visible = True
        Me.gcAcuerdo.VisibleIndex = 3
        Me.gcAcuerdo.Width = 484
        '
        'meAcuerdo
        '
        Me.meAcuerdo.Name = "meAcuerdo"
        '
        'gcIdSeguimiento
        '
        Me.gcIdSeguimiento.Caption = "Id Seguimiento"
        Me.gcIdSeguimiento.FieldName = "IdSeguimiento"
        Me.gcIdSeguimiento.Name = "gcIdSeguimiento"
        Me.gcIdSeguimiento.OptionsColumn.ReadOnly = True
        '
        'gcFechaVencimiento
        '
        Me.gcFechaVencimiento.Caption = "Fec. Vecto."
        Me.gcFechaVencimiento.FieldName = "FechaVencimiento"
        Me.gcFechaVencimiento.Name = "gcFechaVencimiento"
        Me.gcFechaVencimiento.OptionsColumn.ReadOnly = True
        Me.gcFechaVencimiento.Visible = True
        Me.gcFechaVencimiento.VisibleIndex = 4
        Me.gcFechaVencimiento.Width = 116
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(870, 137)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(121, 33)
        Me.sbGuardar.TabIndex = 4
        Me.sbGuardar.Text = "&Guardar Acuerdo"
        '
        'sbEliminar
        '
        Me.sbEliminar.Location = New System.Drawing.Point(870, 182)
        Me.sbEliminar.Name = "sbEliminar"
        Me.sbEliminar.Size = New System.Drawing.Size(121, 33)
        Me.sbEliminar.TabIndex = 5
        Me.sbEliminar.Text = "&Quitar Acuerdo"
        '
        'sbGenerar
        '
        Me.sbGenerar.Location = New System.Drawing.Point(869, 230)
        Me.sbGenerar.Name = "sbGenerar"
        Me.sbGenerar.Size = New System.Drawing.Size(121, 33)
        Me.sbGenerar.TabIndex = 6
        Me.sbGenerar.Text = "Generar &Ficha"
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(869, 279)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(121, 33)
        Me.sbImprimir.TabIndex = 7
        Me.sbImprimir.Text = "&Imprimir Acuerdo"
        '
        'sbRegresar
        '
        Me.sbRegresar.Location = New System.Drawing.Point(869, 328)
        Me.sbRegresar.Name = "sbRegresar"
        Me.sbRegresar.Size = New System.Drawing.Size(121, 33)
        Me.sbRegresar.TabIndex = 8
        Me.sbRegresar.Text = "&Regresar"
        '
        'pre_frmAcuerdosAsociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 419)
        Me.Controls.Add(Me.sbRegresar)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.sbGenerar)
        Me.Controls.Add(Me.sbEliminar)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.gcMov)
        Me.Controls.Add(Me.deFechaVencimiento)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.teAcuerdo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.leTipoCarta)
        Me.Controls.Add(Me.LabelControl32)
        Me.Controls.Add(Me.teSaldo)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl29)
        Me.Controls.Add(Me.deFechaAcuerdo)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.beNumPrestamo)
        Me.Controls.Add(Me.LabelControl10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmAcuerdosAsociado"
        Me.Text = "Acuerdos Asociado"
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaAcuerdo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaAcuerdo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leTipoCarta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teAcuerdo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVencimiento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meAcuerdo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNumPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deFechaAcuerdo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents leTipoCarta As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teAcuerdo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents deFechaVencimiento As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTipoCarta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAcuerdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdSeguimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcFechaVencimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents meAcuerdo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbRegresar As DevExpress.XtraEditors.SimpleButton
End Class
