<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmEstadoCuentaPrestamo
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
        Me.deHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.teNombreAsociado = New DevExpress.XtraEditors.TextEdit()
        Me.beNoPrestamo = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.teTitulo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.sbAcuerdos = New DevExpress.XtraEditors.SimpleButton()
        Me.teIdPrestamo = New DevExpress.XtraEditors.TextEdit()
        Me.sbGenerarPlan = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.deHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teTitulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sbGenerarPlan)
        Me.GroupControl1.Controls.Add(Me.teIdPrestamo)
        Me.GroupControl1.Controls.Add(Me.sbAcuerdos)
        Me.GroupControl1.Controls.Add(Me.deHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.teTitulo)
        Me.GroupControl1.Controls.Add(Me.teNombreAsociado)
        Me.GroupControl1.Controls.Add(Me.beNoPrestamo)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Size = New System.Drawing.Size(629, 201)
        Me.GroupControl1.TabIndex = 0
        '
        'deHasta
        '
        Me.deHasta.EditValue = Nothing
        Me.deHasta.EnterMoveNextControl = True
        Me.deHasta.Location = New System.Drawing.Point(126, 133)
        Me.deHasta.Name = "deHasta"
        Me.deHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.deHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.deHasta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.deHasta.Size = New System.Drawing.Size(100, 20)
        Me.deHasta.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(59, 136)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Hasta Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(57, 85)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 91
        Me.LabelControl1.Text = "A Nombre de:"
        '
        'teNombreAsociado
        '
        Me.teNombreAsociado.EnterMoveNextControl = True
        Me.teNombreAsociado.Location = New System.Drawing.Point(126, 82)
        Me.teNombreAsociado.Name = "teNombreAsociado"
        Me.teNombreAsociado.Properties.ReadOnly = True
        Me.teNombreAsociado.Size = New System.Drawing.Size(440, 20)
        Me.teNombreAsociado.TabIndex = 1
        '
        'beNoPrestamo
        '
        Me.beNoPrestamo.EnterMoveNextControl = True
        Me.beNoPrestamo.Location = New System.Drawing.Point(126, 56)
        Me.beNoPrestamo.Name = "beNoPrestamo"
        Me.beNoPrestamo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.beNoPrestamo.Properties.Mask.PlaceHolder = Global.Microsoft.VisualBasic.ChrW(45)
        Me.beNoPrestamo.Size = New System.Drawing.Size(136, 20)
        Me.beNoPrestamo.TabIndex = 0
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(19, 59)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl6.TabIndex = 90
        Me.LabelControl6.Text = "Numero de Préstamo:"
        '
        'teTitulo
        '
        Me.teTitulo.EditValue = "ESTADO DE CUENTA DE PRÉSTAMO"
        Me.teTitulo.EnterMoveNextControl = True
        Me.teTitulo.Location = New System.Drawing.Point(126, 107)
        Me.teTitulo.Name = "teTitulo"
        Me.teTitulo.Size = New System.Drawing.Size(440, 20)
        Me.teTitulo.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(37, 110)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl3.TabIndex = 91
        Me.LabelControl3.Text = "Título del informe:"
        '
        'sbAcuerdos
        '
        Me.sbAcuerdos.Location = New System.Drawing.Point(291, 139)
        Me.sbAcuerdos.Name = "sbAcuerdos"
        Me.sbAcuerdos.Size = New System.Drawing.Size(135, 24)
        Me.sbAcuerdos.TabIndex = 5
        Me.sbAcuerdos.Text = "&Acuerdos del Cliente"
        '
        'teIdPrestamo
        '
        Me.teIdPrestamo.Location = New System.Drawing.Point(266, 56)
        Me.teIdPrestamo.Name = "teIdPrestamo"
        Me.teIdPrestamo.Properties.ReadOnly = True
        Me.teIdPrestamo.Size = New System.Drawing.Size(66, 20)
        Me.teIdPrestamo.TabIndex = 4
        '
        'sbGenerarPlan
        '
        Me.sbGenerarPlan.Location = New System.Drawing.Point(430, 139)
        Me.sbGenerarPlan.Name = "sbGenerarPlan"
        Me.sbGenerarPlan.Size = New System.Drawing.Size(135, 24)
        Me.sbGenerarPlan.TabIndex = 6
        Me.sbGenerarPlan.Text = "&Generar Plan de Pagos"
        '
        'pre_frmEstadoCuentaPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(629, 226)
        Me.Modulo = "Préstamos"
        Me.Name = "pre_frmEstadoCuentaPrestamo"
        Me.Text = "Estado de Cuenta de Préstamo"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.deHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teNombreAsociado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beNoPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teTitulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teIdPrestamo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teNombreAsociado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beNoPrestamo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents teTitulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbAcuerdos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents teIdPrestamo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sbGenerarPlan As DevExpress.XtraEditors.SimpleButton

End Class
