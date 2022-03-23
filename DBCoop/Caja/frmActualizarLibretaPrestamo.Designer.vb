<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarLibretaPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizarLibretaPrestamo))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit
        Me.teNombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.beNumeroPrestamo = New DevExpress.XtraEditors.ButtonEdit
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.sbAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcImporte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcImpreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ceImpreso = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.gcIdPrestamo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumeroDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.teLineaLibreta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.sbCambio = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceImpreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(36, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Nombre del Asociado:"
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.EnterMoveNextControl = True
        Me.teIdPrestamo.Location = New System.Drawing.Point(265, 10)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(73, 20)
        Me.teIdPrestamo.TabIndex = 1
        Me.teIdPrestamo.Visible = False
        '
        'teNombreCliente
        '
        Me.teNombreCliente.EnterMoveNextControl = True
        Me.teNombreCliente.Location = New System.Drawing.Point(143, 36)
        Me.teNombreCliente.Name = "teNombreCliente"
        Me.teNombreCliente.Properties.ReadOnly = True
        Me.teNombreCliente.Size = New System.Drawing.Size(431, 20)
        Me.teNombreCliente.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(36, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Numero de Préstamo:"
        '
        'beNumeroPrestamo
        '
        Me.beNumeroPrestamo.EnterMoveNextControl = True
        Me.beNumeroPrestamo.Location = New System.Drawing.Point(143, 10)
        Me.beNumeroPrestamo.Name = "beNumeroPrestamo"
        Me.beNumeroPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroPrestamo.Properties.Mask.EditMask = "00-0000-0000"
        Me.beNumeroPrestamo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.beNumeroPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.beNumeroPrestamo.Size = New System.Drawing.Size(118, 20)
        Me.beNumeroPrestamo.TabIndex = 0
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(441, 63)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(138, 28)
        Me.sbImprimir.TabIndex = 5
        Me.sbImprimir.Text = "Re-Imprimir Comprob."
        '
        'sbAceptar
        '
        Me.sbAceptar.Location = New System.Drawing.Point(441, 152)
        Me.sbAceptar.Name = "sbAceptar"
        Me.sbAceptar.Size = New System.Drawing.Size(138, 28)
        Me.sbAceptar.TabIndex = 6
        Me.sbAceptar.Text = "&Actualizar Libreta"
        Me.sbAceptar.Visible = False
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(12, 61)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ceImpreso})
        Me.gcMov.Size = New System.Drawing.Size(424, 366)
        Me.gcMov.TabIndex = 10
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcNumero, Me.gcImporte, Me.gcSaldo, Me.gcImpreso, Me.gcIdPrestamo, Me.gcIdMov, Me.gcNumeroDoc, Me.GridColumn1, Me.GridColumn2})
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
        Me.gcFecha.Width = 72
        '
        'gcNumero
        '
        Me.gcNumero.Caption = "No. Comprobante"
        Me.gcNumero.FieldName = "Numero"
        Me.gcNumero.Name = "gcNumero"
        Me.gcNumero.OptionsColumn.ReadOnly = True
        Me.gcNumero.Visible = True
        Me.gcNumero.VisibleIndex = 1
        Me.gcNumero.Width = 79
        '
        'gcImporte
        '
        Me.gcImporte.Caption = "Monto Pagado"
        Me.gcImporte.FieldName = "ImportePagado"
        Me.gcImporte.Name = "gcImporte"
        Me.gcImporte.OptionsColumn.ReadOnly = True
        Me.gcImporte.Visible = True
        Me.gcImporte.VisibleIndex = 2
        Me.gcImporte.Width = 78
        '
        'gcSaldo
        '
        Me.gcSaldo.Caption = "Saldo Capital"
        Me.gcSaldo.FieldName = "SaldoCapital"
        Me.gcSaldo.Name = "gcSaldo"
        Me.gcSaldo.OptionsColumn.ReadOnly = True
        Me.gcSaldo.Visible = True
        Me.gcSaldo.VisibleIndex = 3
        Me.gcSaldo.Width = 91
        '
        'gcImpreso
        '
        Me.gcImpreso.Caption = "Impreso?"
        Me.gcImpreso.ColumnEdit = Me.ceImpreso
        Me.gcImpreso.FieldName = "ImpresoLibreta"
        Me.gcImpreso.Name = "gcImpreso"
        Me.gcImpreso.Width = 83
        '
        'ceImpreso
        '
        Me.ceImpreso.AutoHeight = False
        Me.ceImpreso.Name = "ceImpreso"
        '
        'gcIdPrestamo
        '
        Me.gcIdPrestamo.Caption = "IdPrestamo"
        Me.gcIdPrestamo.FieldName = "IdPrestamo"
        Me.gcIdPrestamo.Name = "gcIdPrestamo"
        '
        'gcIdMov
        '
        Me.gcIdMov.Caption = "IdMov"
        Me.gcIdMov.FieldName = "IdMov"
        Me.gcIdMov.Name = "gcIdMov"
        '
        'gcNumeroDoc
        '
        Me.gcNumeroDoc.Caption = "NumeroDoc"
        Me.gcNumeroDoc.FieldName = "NumeroDoc"
        Me.gcNumeroDoc.Name = "gcNumeroDoc"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Interes"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.FieldName = "InteresMora"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'teLineaLibreta
        '
        Me.teLineaLibreta.EditValue = 1
        Me.teLineaLibreta.EnterMoveNextControl = True
        Me.teLineaLibreta.Location = New System.Drawing.Point(485, 220)
        Me.teLineaLibreta.Name = "teLineaLibreta"
        Me.teLineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLineaLibreta.Properties.Mask.EditMask = "n0"
        Me.teLineaLibreta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teLineaLibreta.Size = New System.Drawing.Size(37, 20)
        Me.teLineaLibreta.TabIndex = 3
        Me.teLineaLibreta.Visible = False
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(441, 246)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(171, 13)
        Me.LabelControl11.TabIndex = 9
        Me.LabelControl11.Text = "No. de Línea a imprimir en la libreta:"
        Me.LabelControl11.Visible = False
        '
        'sbCambio
        '
        Me.sbCambio.Location = New System.Drawing.Point(442, 186)
        Me.sbCambio.Name = "sbCambio"
        Me.sbCambio.Size = New System.Drawing.Size(138, 28)
        Me.sbCambio.TabIndex = 4
        Me.sbCambio.Text = "Cambio de Libreta"
        Me.sbCambio.Visible = False
        '
        'frmActualizarLibretaPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 428)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.sbAceptar)
        Me.Controls.Add(Me.gcMov)
        Me.Controls.Add(Me.teLineaLibreta)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.sbCambio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teIdPrestamo)
        Me.Controls.Add(Me.teNombreCliente)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.beNumeroPrestamo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmActualizarLibretaPrestamo"
        Me.Text = "Re-impresión de Comprobantes"
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceImpreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beNumeroPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcImpreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ceImpreso As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcIdPrestamo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumeroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teLineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbCambio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
