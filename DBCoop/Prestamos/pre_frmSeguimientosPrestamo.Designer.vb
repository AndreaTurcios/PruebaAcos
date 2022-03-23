<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmSeguimientosPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_frmSeguimientosPrestamo))
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.beNumPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
        Me.deFechaVisita = New DevExpress.XtraEditors.DateEdit
        Me.teSaldo = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNota = New DevExpress.XtraEditors.MemoEdit
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSeguimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.meAcuerdo = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.gcIdSeguimiento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCreadoPor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.sbEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.sbRegresar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVisita.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deFechaVisita.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNota.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meAcuerdo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'teNombre
        '
        Me.teNombre.Location = New System.Drawing.Point(343, 8)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Properties.ReadOnly = True
        Me.teNombre.Size = New System.Drawing.Size(281, 20)
        Me.teNombre.TabIndex = 200
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Location = New System.Drawing.Point(290, 8)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(50, 20)
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
        Me.LabelControl29.Location = New System.Drawing.Point(90, 34)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl29.TabIndex = 228
        Me.LabelControl29.Text = "Fecha de la Visita:"
        '
        'deFechaVisita
        '
        Me.deFechaVisita.EditValue = Nothing
        Me.deFechaVisita.EnterMoveNextControl = True
        Me.deFechaVisita.Location = New System.Drawing.Point(184, 31)
        Me.deFechaVisita.Name = "deFechaVisita"
        Me.deFechaVisita.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deFechaVisita.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deFechaVisita.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.deFechaVisita.Size = New System.Drawing.Size(100, 20)
        Me.deFechaVisita.TabIndex = 0
        '
        'teSaldo
        '
        Me.teSaldo.EditValue = 0
        Me.teSaldo.EnterMoveNextControl = True
        Me.teSaldo.Location = New System.Drawing.Point(523, 31)
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
        Me.LabelControl12.Location = New System.Drawing.Point(440, 35)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl12.TabIndex = 237
        Me.LabelControl12.Text = "Saldo de Capital:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(70, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 13)
        Me.LabelControl1.TabIndex = 240
        Me.LabelControl1.Text = "Notas de Seguimiento:"
        '
        'teNota
        '
        Me.teNota.EnterMoveNextControl = True
        Me.teNota.Location = New System.Drawing.Point(183, 55)
        Me.teNota.Name = "teNota"
        Me.teNota.Properties.MaxLength = 150
        Me.teNota.Size = New System.Drawing.Size(442, 78)
        Me.teNota.TabIndex = 2
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(12, 157)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.meAcuerdo})
        Me.gcMov.Size = New System.Drawing.Size(614, 192)
        Me.gcMov.TabIndex = 244
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcSaldo, Me.gcSeguimiento, Me.gcIdSeguimiento, Me.gcCreadoPor})
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
        Me.gcFecha.Width = 104
        '
        'gcSaldo
        '
        Me.gcSaldo.Caption = "Saldo"
        Me.gcSaldo.FieldName = "Saldo"
        Me.gcSaldo.Name = "gcSaldo"
        Me.gcSaldo.OptionsColumn.ReadOnly = True
        Me.gcSaldo.Visible = True
        Me.gcSaldo.VisibleIndex = 1
        Me.gcSaldo.Width = 77
        '
        'gcSeguimiento
        '
        Me.gcSeguimiento.Caption = "Seguimiento"
        Me.gcSeguimiento.ColumnEdit = Me.meAcuerdo
        Me.gcSeguimiento.FieldName = "Seguimiento"
        Me.gcSeguimiento.Name = "gcSeguimiento"
        Me.gcSeguimiento.OptionsColumn.ReadOnly = True
        Me.gcSeguimiento.Visible = True
        Me.gcSeguimiento.VisibleIndex = 2
        Me.gcSeguimiento.Width = 307
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
        'gcCreadoPor
        '
        Me.gcCreadoPor.Caption = "Hecho Por"
        Me.gcCreadoPor.FieldName = "CreadoPor"
        Me.gcCreadoPor.Name = "gcCreadoPor"
        Me.gcCreadoPor.Visible = True
        Me.gcCreadoPor.VisibleIndex = 3
        Me.gcCreadoPor.Width = 108
        '
        'sbGuardar
        '
        Me.sbGuardar.Location = New System.Drawing.Point(637, 158)
        Me.sbGuardar.Name = "sbGuardar"
        Me.sbGuardar.Size = New System.Drawing.Size(106, 33)
        Me.sbGuardar.TabIndex = 4
        Me.sbGuardar.Text = "&Guardar"
        '
        'sbEliminar
        '
        Me.sbEliminar.Location = New System.Drawing.Point(637, 203)
        Me.sbEliminar.Name = "sbEliminar"
        Me.sbEliminar.Size = New System.Drawing.Size(106, 33)
        Me.sbEliminar.TabIndex = 5
        Me.sbEliminar.Text = "&Quitar"
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(636, 246)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(106, 33)
        Me.sbImprimir.TabIndex = 7
        Me.sbImprimir.Text = "&Imprimir"
        '
        'sbRegresar
        '
        Me.sbRegresar.Location = New System.Drawing.Point(636, 288)
        Me.sbRegresar.Name = "sbRegresar"
        Me.sbRegresar.Size = New System.Drawing.Size(106, 33)
        Me.sbRegresar.TabIndex = 8
        Me.sbRegresar.Text = "&Regresar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 138)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(157, 13)
        Me.LabelControl2.TabIndex = 245
        Me.LabelControl2.Text = "--SEGUIMIENTOS REALIZADOS--"
        '
        'pre_frmSeguimientosPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(759, 366)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.sbRegresar)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.sbEliminar)
        Me.Controls.Add(Me.sbGuardar)
        Me.Controls.Add(Me.gcMov)
        Me.Controls.Add(Me.teNota)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teSaldo)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl29)
        Me.Controls.Add(Me.deFechaVisita)
        Me.Controls.Add(Me.teNombre)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.beNumPrestamo)
        Me.Controls.Add(Me.LabelControl10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "pre_frmSeguimientosPrestamo"
        Me.Text = "Seguimiento del Préstamo"
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVisita.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deFechaVisita.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNota.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents deFechaVisita As DevExpress.XtraEditors.DateEdit
    Friend WithEvents teSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNota As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSeguimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdSeguimiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents meAcuerdo As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents sbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbRegresar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcCreadoPor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
