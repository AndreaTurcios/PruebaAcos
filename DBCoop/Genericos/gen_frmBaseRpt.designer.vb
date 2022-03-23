<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gen_frmBaseRpt
    'Inherits System.Windows.Forms.Form
    Inherits DevExpress.XtraEditors.XtraForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gen_frmBaseRpt))
        Me.cmdReport = New System.Windows.Forms.ToolStripButton
        Me.cmdExit = New System.Windows.Forms.ToolStripButton
        Me.StatusBarModule = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusBarUser = New System.Windows.Forms.ToolStripStatusLabel
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdReport
        '
        Me.cmdReport.Image = Global.Bravio.My.Resources.Resources.Printer
        Me.cmdReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(84, 36)
        Me.cmdReport.Text = "&Reporte"
        '
        'cmdExit
        '
        Me.cmdExit.Image = Global.Bravio.My.Resources.Resources.Log_Off
        Me.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(65, 36)
        Me.cmdExit.Text = "&Salir"
        '
        'StatusBarModule
        '
        Me.StatusBarModule.AutoSize = False
        Me.StatusBarModule.Name = "StatusBarModule"
        Me.StatusBarModule.Size = New System.Drawing.Size(250, 17)
        Me.StatusBarModule.Text = "Módulo:"
        Me.StatusBarModule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusBarUser
        '
        Me.StatusBarUser.Name = "StatusBarUser"
        Me.StatusBarUser.Size = New System.Drawing.Size(50, 17)
        Me.StatusBarUser.Text = "Usuario:"
        Me.StatusBarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupControl1
        '
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(867, 289)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Parámetros del informe"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3})
        Me.BarManager1.MaxItemId = 3
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.BarStaticItem1.Caption = "BarStaticItem1"
        Me.BarStaticItem1.Id = 0
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem1.Width = 250
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.BarStaticItem2.Caption = "BarStaticItem2"
        Me.BarStaticItem2.Id = 1
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem2.Width = 250
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring
        Me.BarStaticItem3.Caption = "BarStaticItem3"
        Me.BarStaticItem3.Id = 2
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem3.Width = 32
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(867, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 289)
        Me.barDockControlBottom.Size = New System.Drawing.Size(867, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 289)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(867, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 289)
        '
        'gen_frmBaseRpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 314)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "gen_frmBaseRpt"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DBCoop"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripButton
    Protected Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents StatusBarModule As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusBarUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
