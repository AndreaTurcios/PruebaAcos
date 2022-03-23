<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmVerDocumentosAsociado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.peDui = New DevExpress.XtraEditors.PictureEdit
        Me.peNit = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.peFirma = New DevExpress.XtraEditors.PictureEdit
        CType(Me.peDui.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peNit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFirma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'peDui
        '
        Me.peDui.Location = New System.Drawing.Point(22, 27)
        Me.peDui.Name = "peDui"
        Me.peDui.Properties.ShowMenu = False
        Me.peDui.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peDui.Size = New System.Drawing.Size(329, 219)
        Me.peDui.TabIndex = 4
        '
        'peNit
        '
        Me.peNit.Location = New System.Drawing.Point(409, 27)
        Me.peNit.Name = "peNit"
        Me.peNit.Properties.ShowMenu = False
        Me.peNit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peNit.Size = New System.Drawing.Size(313, 219)
        Me.peNit.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Location = New System.Drawing.Point(144, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl8.TabIndex = 71
        Me.LabelControl8.Text = "Numero DUI"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(557, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(20, 16)
        Me.LabelControl1.TabIndex = 72
        Me.LabelControl1.Text = "NIT"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Location = New System.Drawing.Point(359, 255)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl2.TabIndex = 74
        Me.LabelControl2.Text = "Firma"
        '
        'peFirma
        '
        Me.peFirma.Location = New System.Drawing.Point(210, 274)
        Me.peFirma.Name = "peFirma"
        Me.peFirma.Properties.ShowMenu = False
        Me.peFirma.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFirma.Size = New System.Drawing.Size(337, 229)
        Me.peFirma.TabIndex = 73
        '
        'pre_frmVerDocumentosAsociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 520)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.peFirma)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.peNit)
        Me.Controls.Add(Me.peDui)
        Me.Name = "pre_frmVerDocumentosAsociado"
        Me.Text = "Visualización de Documentos"
        CType(Me.peDui.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peNit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFirma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents peDui As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents peNit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents peFirma As DevExpress.XtraEditors.PictureEdit
End Class
