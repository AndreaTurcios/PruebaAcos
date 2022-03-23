<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizacionLibretaAportacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizacionLibretaAportacion))
        Me.sbCambio = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.teNombreCliente = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.beNumeroAsociado = New DevExpress.XtraEditors.ButtonEdit
        Me.teLineaLibreta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcAbono = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcImpreso = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkImpreso = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.gcNumeroDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdAsociado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.sbAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.teIdAsociado = New DevExpress.XtraEditors.TextEdit
        Me.sbImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNumeroAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkImpreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sbCambio
        '
        Me.sbCambio.Location = New System.Drawing.Point(174, 103)
        Me.sbCambio.Name = "sbCambio"
        Me.sbCambio.Size = New System.Drawing.Size(147, 24)
        Me.sbCambio.TabIndex = 46
        Me.sbCambio.Text = "Cambio de Libreta"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(64, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 41
        Me.LabelControl1.Text = "Nombre del Asociado:"
        '
        'teNombreCliente
        '
        Me.teNombreCliente.EnterMoveNextControl = True
        Me.teNombreCliente.Location = New System.Drawing.Point(171, 51)
        Me.teNombreCliente.Name = "teNombreCliente"
        Me.teNombreCliente.Properties.ReadOnly = True
        Me.teNombreCliente.Size = New System.Drawing.Size(351, 20)
        Me.teNombreCliente.TabIndex = 40
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(66, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(102, 13)
        Me.LabelControl2.TabIndex = 39
        Me.LabelControl2.Text = "Numero de Asociado:"
        '
        'beNumeroAsociado
        '
        Me.beNumeroAsociado.EnterMoveNextControl = True
        Me.beNumeroAsociado.Location = New System.Drawing.Point(171, 25)
        Me.beNumeroAsociado.Name = "beNumeroAsociado"
        Me.beNumeroAsociado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beNumeroAsociado.Size = New System.Drawing.Size(150, 20)
        Me.beNumeroAsociado.TabIndex = 38
        '
        'teLineaLibreta
        '
        Me.teLineaLibreta.EditValue = 1
        Me.teLineaLibreta.EnterMoveNextControl = True
        Me.teLineaLibreta.Location = New System.Drawing.Point(171, 77)
        Me.teLineaLibreta.Name = "teLineaLibreta"
        Me.teLineaLibreta.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.teLineaLibreta.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.teLineaLibreta.Properties.Mask.EditMask = "n0"
        Me.teLineaLibreta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.teLineaLibreta.Size = New System.Drawing.Size(48, 20)
        Me.teLineaLibreta.TabIndex = 48
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(11, 80)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(157, 13)
        Me.LabelControl11.TabIndex = 47
        Me.LabelControl11.Text = "No. de línea a imprimir en libreta:"
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(50, 141)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkImpreso})
        Me.gcMov.Size = New System.Drawing.Size(362, 294)
        Me.gcMov.TabIndex = 49
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcCargo, Me.gcAbono, Me.gcImpreso, Me.gcNumeroDoc, Me.gcIdAsociado, Me.gcIdMov})
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
        'gcCargo
        '
        Me.gcCargo.Caption = "Cargos"
        Me.gcCargo.FieldName = "Cargo"
        Me.gcCargo.Name = "gcCargo"
        Me.gcCargo.OptionsColumn.ReadOnly = True
        Me.gcCargo.Visible = True
        Me.gcCargo.VisibleIndex = 1
        Me.gcCargo.Width = 94
        '
        'gcAbono
        '
        Me.gcAbono.Caption = "Abonos"
        Me.gcAbono.FieldName = "Abono"
        Me.gcAbono.Name = "gcAbono"
        Me.gcAbono.OptionsColumn.ReadOnly = True
        Me.gcAbono.Visible = True
        Me.gcAbono.VisibleIndex = 2
        Me.gcAbono.Width = 83
        '
        'gcImpreso
        '
        Me.gcImpreso.Caption = "Impreso?"
        Me.gcImpreso.ColumnEdit = Me.chkImpreso
        Me.gcImpreso.FieldName = "Impreso"
        Me.gcImpreso.Name = "gcImpreso"
        Me.gcImpreso.Visible = True
        Me.gcImpreso.VisibleIndex = 3
        Me.gcImpreso.Width = 69
        '
        'chkImpreso
        '
        Me.chkImpreso.AutoHeight = False
        Me.chkImpreso.Name = "chkImpreso"
        '
        'gcNumeroDoc
        '
        Me.gcNumeroDoc.Caption = "NumeroDoc"
        Me.gcNumeroDoc.FieldName = "NumeroDoc"
        Me.gcNumeroDoc.Name = "gcNumeroDoc"
        '
        'gcIdAsociado
        '
        Me.gcIdAsociado.Caption = "IdAsociado"
        Me.gcIdAsociado.FieldName = "IdAsociado"
        Me.gcIdAsociado.Name = "gcIdAsociado"
        '
        'gcIdMov
        '
        Me.gcIdMov.Caption = "IdMov"
        Me.gcIdMov.FieldName = "IdMov"
        Me.gcIdMov.Name = "gcIdMov"
        '
        'sbAceptar
        '
        Me.sbAceptar.Location = New System.Drawing.Point(157, 438)
        Me.sbAceptar.Name = "sbAceptar"
        Me.sbAceptar.Size = New System.Drawing.Size(137, 32)
        Me.sbAceptar.TabIndex = 50
        Me.sbAceptar.Text = "&Proceder a imprimir..."
        '
        'teIdAsociado
        '
        Me.teIdAsociado.EditValue = 0
        Me.teIdAsociado.EnterMoveNextControl = True
        Me.teIdAsociado.Location = New System.Drawing.Point(327, 25)
        Me.teIdAsociado.Name = "teIdAsociado"
        Me.teIdAsociado.Properties.ReadOnly = True
        Me.teIdAsociado.Size = New System.Drawing.Size(114, 20)
        Me.teIdAsociado.TabIndex = 54
        '
        'sbImprimir
        '
        Me.sbImprimir.Location = New System.Drawing.Point(437, 161)
        Me.sbImprimir.Name = "sbImprimir"
        Me.sbImprimir.Size = New System.Drawing.Size(138, 28)
        Me.sbImprimir.TabIndex = 61
        Me.sbImprimir.Text = "Re-Imprimir Comprob.."
        '
        'frmActualizacionLibretaAportacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 476)
        Me.Controls.Add(Me.sbImprimir)
        Me.Controls.Add(Me.teIdAsociado)
        Me.Controls.Add(Me.sbAceptar)
        Me.Controls.Add(Me.gcMov)
        Me.Controls.Add(Me.teLineaLibreta)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.sbCambio)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.teNombreCliente)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.beNumeroAsociado)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmActualizacionLibretaAportacion"
        Me.Text = "Actualización de Libretas"
        CType(Me.teNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNumeroAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teLineaLibreta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkImpreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbCambio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents beNumeroAsociado As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents teLineaLibreta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAbono As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcImpreso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkImpreso As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcIdAsociado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teIdAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcNumeroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbImprimir As DevExpress.XtraEditors.SimpleButton
End Class
