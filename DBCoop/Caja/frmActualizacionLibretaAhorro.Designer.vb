<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizacionLibretaAhorro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizacionLibretaAhorro))
        Me.sbAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdTipo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcImpreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkImpreso = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.gcIdCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumeroDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcSaldo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.teLineaLibreta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.sbCambio = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.beNumeroCuenta = New DevExpress.XtraEditors.ButtonEdit
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.teIdCuenta = New DevExpress.XtraEditors.TextEdit
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbAceptar
        '
        Me.sbAceptar.Location = New System.Drawing.Point(168, 425)
        Me.sbAceptar.Name = "sbAceptar"
        Me.sbAceptar.Size = New System.Drawing.Size(147, 31)
        Me.sbAceptar.TabIndex = 59
        Me.sbAceptar.Text = "Proceder a imprimir..."
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(17, 128)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkImpreso})
        Me.gcMov.Size = New System.Drawing.Size(362, 294)
        Me.gcMov.TabIndex = 58
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcIdTipo, Me.gcValor, Me.gcImpreso, Me.gcIdCuenta, Me.gcIdMov, Me.gcNumeroDoc, Me.gcSaldo})
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
        Me.gcFecha.Width = 95
        '
        'gcIdTipo
        '
        Me.gcIdTipo.Caption = "Tipo"
        Me.gcIdTipo.FieldName = "IdTipo"
        Me.gcIdTipo.Name = "gcIdTipo"
        Me.gcIdTipo.OptionsColumn.ReadOnly = True
        Me.gcIdTipo.Visible = True
        Me.gcIdTipo.VisibleIndex = 1
        Me.gcIdTipo.Width = 70
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.OptionsColumn.ReadOnly = True
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 2
        Me.gcValor.Width = 96
        '
        'gcImpreso
        '
        Me.gcImpreso.Caption = "Impreso?"
        Me.gcImpreso.ColumnEdit = Me.chkImpreso
        Me.gcImpreso.FieldName = "Impreso"
        Me.gcImpreso.Name = "gcImpreso"
        Me.gcImpreso.Visible = True
        Me.gcImpreso.VisibleIndex = 3
        Me.gcImpreso.Width = 80
        '
        'chkImpreso
        '
        Me.chkImpreso.AutoHeight = False
        Me.chkImpreso.Name = "chkImpreso"
        '
        'gcIdCuenta
        '
        Me.gcIdCuenta.Caption = "Id Cuenta"
        Me.gcIdCuenta.FieldName = "IdCuenta"
        Me.gcIdCuenta.Name = "gcIdCuenta"
        '
        'gcIdMov
        '
        Me.gcIdMov.Caption = "Id Mov"
        Me.gcIdMov.FieldName = "IdMov"
        Me.gcIdMov.Name = "gcIdMov"
        '
        'gcNumeroDoc
        '
        Me.gcNumeroDoc.Caption = "Numero Doc"
        Me.gcNumeroDoc.FieldName = "NumeroDoc"
        Me.gcNumeroDoc.Name = "gcNumeroDoc"
        '
        'gcSaldo
        '
        Me.gcSaldo.Caption = "GridColumn1"
        Me.gcSaldo.FieldName = "Saldo"
        Me.gcSaldo.Name = "gcSaldo"
        '
        'teLineaLibreta
        '
        Me.teLineaLibreta.EditValue = 1
        Me.teLineaLibreta.EnterMoveNextControl = True
        Me.teLineaLibreta.Location = New System.Drawing.Point(180, 64)
        Me.teLineaLibreta.Name = "teLineaLibreta"
        Me.teLineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLineaLibreta.Properties.Mask.EditMask = "n0"
        Me.teLineaLibreta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teLineaLibreta.Size = New System.Drawing.Size(37, 20)
        Me.teLineaLibreta.TabIndex = 57
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(6, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(171, 13)
        Me.LabelControl11.TabIndex = 56
        Me.LabelControl11.Text = "No. de Línea a imprimir en la libreta:"
        '
        'sbCambio
        '
        Me.sbCambio.Location = New System.Drawing.Point(168, 89)
        Me.sbCambio.Name = "sbCambio"
        Me.sbCambio.Size = New System.Drawing.Size(147, 24)
        Me.sbCambio.TabIndex = 55
        Me.sbCambio.Text = "Cambio de Libreta"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(90, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Nombre Asociado:"
        '
        'teNombreCliente
        '
        Me.teNombreCliente.EnterMoveNextControl = True
        Me.teNombreCliente.Location = New System.Drawing.Point(180, 38)
        Me.teNombreCliente.Name = "teNombreCliente"
        Me.teNombreCliente.Properties.ReadOnly = True
        Me.teNombreCliente.Size = New System.Drawing.Size(351, 20)
        Me.teNombreCliente.TabIndex = 53
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(83, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Numero de Cuenta:"
        '
        'beNumeroCuenta
        '
        Me.beNumeroCuenta.EnterMoveNextControl = True
        Me.beNumeroCuenta.Location = New System.Drawing.Point(180, 12)
        Me.beNumeroCuenta.Name = "beNumeroCuenta"
        Me.beNumeroCuenta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroCuenta.Size = New System.Drawing.Size(143, 20)
        Me.beNumeroCuenta.TabIndex = 51
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(385, 148)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(138, 28)
        Me.sbImprimir.TabIndex = 60
        Me.sbImprimir.Text = "Re-Imprimir Comprob.."
        '
        'teIdCuenta
        '
        Me.teIdCuenta.EditValue = 0
        Me.teIdCuenta.EnterMoveNextControl = True
        Me.teIdCuenta.Location = New System.Drawing.Point(325, 12)
        Me.teIdCuenta.Name = "teIdCuenta"
        Me.teIdCuenta.Properties.ReadOnly = True
        Me.teIdCuenta.Size = New System.Drawing.Size(114, 20)
        Me.teIdCuenta.TabIndex = 53
        '
        'frmActualizacionLibretaAhorro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 462)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.sbAceptar)
        Me.Controls.Add(Me.gcMov)
        Me.Controls.Add(Me.teLineaLibreta)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.sbCambio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teIdCuenta)
        Me.Controls.Add(Me.teNombreCliente)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.beNumeroCuenta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmActualizacionLibretaAhorro"
        Me.Text = "Actualizar Libreta de Ahorro"
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdTipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcImpreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkImpreso As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcIdCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teLineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sbCambio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beNumeroCuenta As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcNumeroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcSaldo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents teIdCuenta As DevExpress.XtraEditors.TextEdit
End Class
