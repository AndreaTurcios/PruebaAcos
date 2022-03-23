<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_RichTextLogo
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_RichTextLogo))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrContenido = New DevExpress.XtraReports.UI.XRRichText
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.XrLogoSuc = New DevExpress.XtraReports.UI.XRPictureBox
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        CType(Me.xrContenido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrContenido})
        Me.Detail.HeightF = 23.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrContenido
        '
        Me.xrContenido.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 0.0!)
        Me.xrContenido.Name = "xrContenido"
        Me.xrContenido.SerializableRtfString = resources.GetString("xrContenido.SerializableRtfString")
        Me.xrContenido.SizeF = New System.Drawing.SizeF(743.0!, 23.0!)
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLogoSuc})
        Me.TopMargin.HeightF = 146.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLogoSuc
        '
        Me.XrLogoSuc.LocationFloat = New DevExpress.Utils.PointFloat(26.0!, 43.0!)
        Me.XrLogoSuc.Name = "XrLogoSuc"
        Me.XrLogoSuc.SizeF = New System.Drawing.SizeF(700.0!, 100.0!)
        Me.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 53.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rpt_RichTextLogo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 146, 53)
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.xrContenido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrContenido As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents XrLogoSuc As DevExpress.XtraReports.UI.XRPictureBox
End Class
