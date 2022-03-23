<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmVerFirmasAsociado
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
        Me.peFirma1 = New DevExpress.XtraEditors.PictureEdit
        Me.peFirma2 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.peFirma3 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.peFirma1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFirma2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peFirma3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'peFirma1
        '
        Me.peFirma1.Location = New System.Drawing.Point(22, 27)
        Me.peFirma1.Name = "peFirma1"
        Me.peFirma1.Properties.ShowMenu = False
        Me.peFirma1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFirma1.Size = New System.Drawing.Size(329, 219)
        Me.peFirma1.TabIndex = 4
        '
        'peFirma2
        '
        Me.peFirma2.Location = New System.Drawing.Point(409, 27)
        Me.peFirma2.Name = "peFirma2"
        Me.peFirma2.Properties.ShowMenu = False
        Me.peFirma2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFirma2.Size = New System.Drawing.Size(313, 219)
        Me.peFirma2.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Location = New System.Drawing.Point(125, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(122, 16)
        Me.LabelControl8.TabIndex = 71
        Me.LabelControl8.Text = "Firma Autorizada 1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Location = New System.Drawing.Point(512, 5)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(122, 16)
        Me.LabelControl1.TabIndex = 72
        Me.LabelControl1.Text = "Firma Autorizada 2"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(320, 250)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(122, 16)
        Me.LabelControl3.TabIndex = 76
        Me.LabelControl3.Text = "Firma Autorizada 3"
        '
        'peFirma3
        '
        Me.peFirma3.Location = New System.Drawing.Point(233, 269)
        Me.peFirma3.Name = "peFirma3"
        Me.peFirma3.Properties.ShowMenu = False
        Me.peFirma3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFirma3.Size = New System.Drawing.Size(310, 229)
        Me.peFirma3.TabIndex = 75
        '
        'pre_frmVerFirmasAsociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 520)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.peFirma3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.peFirma2)
        Me.Controls.Add(Me.peFirma1)
        Me.Name = "pre_frmVerFirmasAsociado"
        Me.Text = "Visualización de Firmas"
        CType(Me.peFirma1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFirma2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peFirma3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents peFirma1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents peFirma2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents peFirma3 As DevExpress.XtraEditors.PictureEdit
End Class
