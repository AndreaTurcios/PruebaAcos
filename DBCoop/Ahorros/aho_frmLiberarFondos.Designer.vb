<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmLiberarFondos
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
        Me.gcMov = New DevExpress.XtraGrid.GridControl
        Me.gvMov = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcValor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcIdMov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNumeroDoc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcApellidos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcPignorado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkPignorado = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.sbAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.sbSalir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkPignorado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcMov
        '
        Me.gcMov.Location = New System.Drawing.Point(12, 12)
        Me.gcMov.MainView = Me.gvMov
        Me.gcMov.Name = "gcMov"
        Me.gcMov.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkPignorado})
        Me.gcMov.Size = New System.Drawing.Size(984, 294)
        Me.gcMov.TabIndex = 59
        Me.gcMov.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMov})
        '
        'gvMov
        '
        Me.gvMov.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcFecha, Me.gcValor, Me.gcIdCuenta, Me.gcIdMov, Me.gcNumeroDoc, Me.gcCuenta, Me.gcNombre, Me.gcApellidos, Me.gcObservaciones, Me.gcPignorado})
        Me.gvMov.GridControl = Me.gcMov
        Me.gvMov.Name = "gvMov"
        Me.gvMov.OptionsView.ShowAutoFilterRow = True
        Me.gvMov.OptionsView.ShowGroupPanel = False
        '
        'gcFecha
        '
        Me.gcFecha.Caption = "Fecha"
        Me.gcFecha.FieldName = "Fecha"
        Me.gcFecha.Name = "gcFecha"
        Me.gcFecha.OptionsColumn.ReadOnly = True
        Me.gcFecha.Visible = True
        Me.gcFecha.VisibleIndex = 5
        Me.gcFecha.Width = 94
        '
        'gcValor
        '
        Me.gcValor.Caption = "Valor"
        Me.gcValor.FieldName = "Valor"
        Me.gcValor.Name = "gcValor"
        Me.gcValor.OptionsColumn.ReadOnly = True
        Me.gcValor.Visible = True
        Me.gcValor.VisibleIndex = 6
        Me.gcValor.Width = 94
        '
        'gcIdCuenta
        '
        Me.gcIdCuenta.Caption = "Id Cuenta"
        Me.gcIdCuenta.FieldName = "IdCuenta"
        Me.gcIdCuenta.Name = "gcIdCuenta"
        Me.gcIdCuenta.OptionsColumn.ReadOnly = True
        '
        'gcIdMov
        '
        Me.gcIdMov.Caption = "Id Mov"
        Me.gcIdMov.FieldName = "IdMov"
        Me.gcIdMov.Name = "gcIdMov"
        Me.gcIdMov.OptionsColumn.ReadOnly = True
        '
        'gcNumeroDoc
        '
        Me.gcNumeroDoc.Caption = "No. Comprobante"
        Me.gcNumeroDoc.FieldName = "NumeroDoc"
        Me.gcNumeroDoc.Name = "gcNumeroDoc"
        Me.gcNumeroDoc.OptionsColumn.ReadOnly = True
        Me.gcNumeroDoc.Visible = True
        Me.gcNumeroDoc.VisibleIndex = 3
        Me.gcNumeroDoc.Width = 97
        '
        'gcCuenta
        '
        Me.gcCuenta.Caption = "Numero Cuenta"
        Me.gcCuenta.FieldName = "Numero"
        Me.gcCuenta.Name = "gcCuenta"
        Me.gcCuenta.OptionsColumn.ReadOnly = True
        Me.gcCuenta.Visible = True
        Me.gcCuenta.VisibleIndex = 0
        Me.gcCuenta.Width = 92
        '
        'gcNombre
        '
        Me.gcNombre.Caption = "Nombres"
        Me.gcNombre.FieldName = "Nombres"
        Me.gcNombre.Name = "gcNombre"
        Me.gcNombre.OptionsColumn.ReadOnly = True
        Me.gcNombre.Visible = True
        Me.gcNombre.VisibleIndex = 1
        Me.gcNombre.Width = 178
        '
        'gcApellidos
        '
        Me.gcApellidos.Caption = "Apellidos"
        Me.gcApellidos.FieldName = "Apellidos"
        Me.gcApellidos.Name = "gcApellidos"
        Me.gcApellidos.OptionsColumn.ReadOnly = True
        Me.gcApellidos.Visible = True
        Me.gcApellidos.VisibleIndex = 2
        Me.gcApellidos.Width = 185
        '
        'gcObservaciones
        '
        Me.gcObservaciones.Caption = "Observaciones"
        Me.gcObservaciones.FieldName = "Observaciones"
        Me.gcObservaciones.Name = "gcObservaciones"
        Me.gcObservaciones.OptionsColumn.ReadOnly = True
        Me.gcObservaciones.Visible = True
        Me.gcObservaciones.VisibleIndex = 4
        Me.gcObservaciones.Width = 169
        '
        'gcPignorado
        '
        Me.gcPignorado.Caption = "Pignorado"
        Me.gcPignorado.ColumnEdit = Me.chkPignorado
        Me.gcPignorado.FieldName = "Pignorado"
        Me.gcPignorado.Name = "gcPignorado"
        Me.gcPignorado.OptionsColumn.ReadOnly = True
        Me.gcPignorado.Visible = True
        Me.gcPignorado.VisibleIndex = 7
        Me.gcPignorado.Width = 57
        '
        'chkPignorado
        '
        Me.chkPignorado.AutoHeight = False
        Me.chkPignorado.Name = "chkPignorado"
        '
        'sbAceptar
        '
        Me.sbAceptar.Location = New System.Drawing.Point(690, 312)
        Me.sbAceptar.Name = "sbAceptar"
        Me.sbAceptar.Size = New System.Drawing.Size(163, 30)
        Me.sbAceptar.TabIndex = 60
        Me.sbAceptar.Text = "Proceder a Liberar"
        '
        'sbSalir
        '
        Me.sbSalir.Location = New System.Drawing.Point(862, 312)
        Me.sbSalir.Name = "sbSalir"
        Me.sbSalir.Size = New System.Drawing.Size(134, 30)
        Me.sbSalir.TabIndex = 61
        Me.sbSalir.Text = "Salir"
        '
        'aho_frmLiberarFondos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1008, 382)
        Me.Controls.Add(Me.sbSalir)
        Me.Controls.Add(Me.sbAceptar)
        Me.Controls.Add(Me.gcMov)
        Me.Name = "aho_frmLiberarFondos"
        Me.Text = "Liberar Fondos o Depósitos en Compensación"
        Me.Controls.SetChildIndex(Me.gcMov, 0)
        Me.Controls.SetChildIndex(Me.sbAceptar, 0)
        Me.Controls.SetChildIndex(Me.sbSalir, 0)
        CType(Me.gcMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMov, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkPignorado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcMov As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMov As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcValor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkPignorado As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents gcIdCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcIdMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNumeroDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcApellidos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPignorado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sbAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbSalir As DevExpress.XtraEditors.SimpleButton

End Class
