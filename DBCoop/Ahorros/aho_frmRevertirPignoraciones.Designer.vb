<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aho_frmRevertirPignoraciones
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
        Me.btRevertir = New DevExpress.XtraEditors.SimpleButton
        Me.btImprimir = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btImprimir)
        Me.GroupControl1.Controls.Add(Me.btRevertir)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Size = New System.Drawing.Size(834, 63)
        Me.GroupControl1.Text = "Liberar pignoración"
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 63)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(834, 258)
        Me.gc.TabIndex = 0
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsBehavior.Editable = False
        Me.gv.OptionsView.ShowAutoFilterRow = True
        Me.gv.OptionsView.ShowGroupPanel = False
        '
        'btRevertir
        '
        Me.btRevertir.Location = New System.Drawing.Point(75, 31)
        Me.btRevertir.Name = "btRevertir"
        Me.btRevertir.Size = New System.Drawing.Size(99, 23)
        Me.btRevertir.TabIndex = 0
        Me.btRevertir.Text = "&Revertir"
        '
        'btImprimir
        '
        Me.btImprimir.Location = New System.Drawing.Point(180, 31)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(99, 23)
        Me.btImprimir.TabIndex = 1
        Me.btImprimir.Text = "&Imprimir"
        '
        'aho_frmRevertirPignoraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 346)
        Me.Controls.Add(Me.gc)
        Me.Modulo = "Ahorros"
        Me.Name = "aho_frmRevertirPignoraciones"
        Me.Text = "Liberar o revertir pignoraciones"
        Me.Controls.SetChildIndex(Me.GroupControl1, 0)
        Me.Controls.SetChildIndex(Me.gc, 0)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btRevertir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView

End Class
