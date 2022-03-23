<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pre_frmVerFotoAsociado
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
        Me.peFoto = New DevExpress.XtraEditors.PictureEdit
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'peFoto
        '
        Me.peFoto.Location = New System.Drawing.Point(75, 12)
        Me.peFoto.Name = "peFoto"
        Me.peFoto.Properties.ShowMenu = False
        Me.peFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.peFoto.Size = New System.Drawing.Size(482, 391)
        Me.peFoto.TabIndex = 4
        '
        'pre_frmVerFotoAsociado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 420)
        Me.Controls.Add(Me.peFoto)
        Me.Name = "pre_frmVerFotoAsociado"
        Me.Text = "Visualización Fotografia Asociado"
        CType(Me.peFoto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents peFoto As DevExpress.XtraEditors.PictureEdit
End Class
