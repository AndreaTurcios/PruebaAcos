<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmConsultaAsociados
    Inherits Bravio.gen_frmBaseRpt

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
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.gcColumna1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcColumna2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcColumna3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gcColumna4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.btnGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.teApellido = New DevExpress.XtraEditors.TextEdit
        Me.teNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.sbVerDocumentos = New DevExpress.XtraEditors.SimpleButton
        Me.ceIncluir = New DevExpress.XtraEditors.CheckEdit
        Me.ceIncluirCancelados = New DevExpress.XtraEditors.CheckEdit
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teApellido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceIncluirCancelados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ceIncluir)
        Me.GroupControl1.Controls.Add(Me.btnGenerar)
        Me.GroupControl1.Controls.Add(Me.teApellido)
        Me.GroupControl1.Controls.Add(Me.teNombre)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Size = New System.Drawing.Size(1034, 78)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Consulta de Asociados. Clic en lista para seleccionar"
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Left
        Me.gc.Location = New System.Drawing.Point(0, 78)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(784, 238)
        Me.gc.TabIndex = 1
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv, Me.GridView1})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcColumna1, Me.gcColumna2, Me.gcColumna3, Me.gcColumna4})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsView.ShowAutoFilterRow = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'gcColumna1
        '
        Me.gcColumna1.Caption = "Id. Asociado"
        Me.gcColumna1.FieldName = "IdAsociado"
        Me.gcColumna1.Name = "gcColumna1"
        Me.gcColumna1.Visible = True
        Me.gcColumna1.VisibleIndex = 0
        Me.gcColumna1.Width = 79
        '
        'gcColumna2
        '
        Me.gcColumna2.Caption = "Numero Asociado"
        Me.gcColumna2.FieldName = "Numero"
        Me.gcColumna2.Name = "gcColumna2"
        Me.gcColumna2.Visible = True
        Me.gcColumna2.VisibleIndex = 1
        Me.gcColumna2.Width = 101
        '
        'gcColumna3
        '
        Me.gcColumna3.Caption = "Nombre del Asociado"
        Me.gcColumna3.FieldName = "Nombres"
        Me.gcColumna3.Name = "gcColumna3"
        Me.gcColumna3.Visible = True
        Me.gcColumna3.VisibleIndex = 2
        Me.gcColumna3.Width = 277
        '
        'gcColumna4
        '
        Me.gcColumna4.Caption = "Apellidos del Asociado"
        Me.gcColumna4.FieldName = "Apellidos"
        Me.gcColumna4.Name = "gcColumna4"
        Me.gcColumna4.Visible = True
        Me.gcColumna4.VisibleIndex = 3
        Me.gcColumna4.Width = 306
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gc
        Me.GridView1.Name = "GridView1"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(284, 49)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(113, 23)
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar consulta"
        '
        'teApellido
        '
        Me.teApellido.EnterMoveNextControl = True
        Me.teApellido.Location = New System.Drawing.Point(63, 52)
        Me.teApellido.Name = "teApellido"
        Me.teApellido.Size = New System.Drawing.Size(216, 20)
        Me.teApellido.TabIndex = 1
        '
        'teNombre
        '
        Me.teNombre.EditValue = ""
        Me.teNombre.EnterMoveNextControl = True
        Me.teNombre.Location = New System.Drawing.Point(63, 30)
        Me.teNombre.Name = "teNombre"
        Me.teNombre.Size = New System.Drawing.Size(216, 20)
        Me.teNombre.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Apellidos:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Nombres:"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(791, 121)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 23)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "&Datos Generales"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(791, 150)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(123, 23)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "&Ver Aportaciones"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(791, 179)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(123, 23)
        Me.SimpleButton3.TabIndex = 6
        Me.SimpleButton3.Text = "Ver &Ahorros"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(791, 208)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(123, 23)
        Me.SimpleButton4.TabIndex = 6
        Me.SimpleButton4.Text = "Ver &Préstamos"
        '
        'sbVerDocumentos
        '
        Me.sbVerDocumentos.Location = New System.Drawing.Point(791, 263)
        Me.sbVerDocumentos.Name = "sbVerDocumentos"
        Me.sbVerDocumentos.Size = New System.Drawing.Size(123, 22)
        Me.sbVerDocumentos.TabIndex = 20
        Me.sbVerDocumentos.Text = "Ver &Documentos"
        '
        'ceIncluir
        '
        Me.ceIncluir.Location = New System.Drawing.Point(285, 31)
        Me.ceIncluir.Name = "ceIncluir"
        Me.ceIncluir.Properties.Caption = "Incluir socios retirados e inactivos"
        Me.ceIncluir.Size = New System.Drawing.Size(185, 19)
        Me.ceIncluir.TabIndex = 5
        '
        'ceIncluirCancelados
        '
        Me.ceIncluirCancelados.Location = New System.Drawing.Point(790, 237)
        Me.ceIncluirCancelados.Name = "ceIncluirCancelados"
        Me.ceIncluirCancelados.Properties.Caption = "Incluir Prestamos Cancelados"
        Me.ceIncluirCancelados.Size = New System.Drawing.Size(185, 19)
        Me.ceIncluirCancelados.TabIndex = 6
        '
        'pre_frmConsultaAsociados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1034, 341)
        Me.Controls.Add(Me.ceIncluirCancelados)
        Me.Controls.Add(Me.sbVerDocumentos)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.gc)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmConsultaAsociados"
        Me.Text = "Consulta de Informacion de los Asociados"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.gc, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton3, 0)
        Me.Controls.SetChildIndex(Me.SimpleButton4, 0)
        Me.Controls.SetChildIndex(Me.sbVerDocumentos, 0)
        Me.Controls.SetChildIndex(Me.ceIncluirCancelados, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teApellido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceIncluirCancelados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcColumna1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcColumna2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcColumna3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcColumna4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teApellido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents teNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbVerDocumentos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ceIncluir As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ceIncluirCancelados As DevExpress.XtraEditors.CheckEdit

End Class
