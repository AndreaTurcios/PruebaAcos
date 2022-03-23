<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pre_rptRichTextLogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pre_rptRichTextLogo))
        Me.XrEscrito = New DevExpress.XtraReports.UI.XRRichText
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.XrLogoSuc = New DevExpress.XtraReports.UI.XRPictureBox
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.DsPrestamos2 = New Bravio.dsPrestamos
        CType(Me.XrEscrito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrestamos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'XrEscrito
        '
        Me.XrEscrito.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrEscrito.LocationFloat = New DevExpress.Utils.PointFloat(9.0!, 1.291672!)
        Me.XrEscrito.Name = "XrEscrito"
        Me.XrEscrito.SerializableRtfString = resources.GetString("XrEscrito.SerializableRtfString")
        Me.XrEscrito.SizeF = New System.Drawing.SizeF(760.0!, 16.74999!)
        Me.XrEscrito.StylePriority.UseBorders = False
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrEscrito})
        Me.Detail.HeightF = 19.87502!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLogoSuc})
        Me.TopMarginBand1.HeightF = 147.0833!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'XrLogoSuc
        '
        Me.XrLogoSuc.Image = CType(resources.GetObject("XrLogoSuc.Image"), System.Drawing.Image)
        Me.XrLogoSuc.LocationFloat = New DevExpress.Utils.PointFloat(13.54165!, 27.08332!)
        Me.XrLogoSuc.Name = "XrLogoSuc"
        Me.XrLogoSuc.SizeF = New System.Drawing.SizeF(750.0!, 120.0!)
        Me.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 35.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'DsPrestamos2
        '
        Me.DsPrestamos2.DataSetName = "dsPrestamos"
        Me.DsPrestamos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pre_rptRichTextLogo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "PagareDeudor"
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(40, 34, 147, 35)
        Me.Name = "pre_rptRichTextLogo"
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.XrEscrito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrestamos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrEscrito As DevExpress.XtraReports.UI.XRRichText
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents XrLogoSuc As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents DsPrestamos2 As Bravio.dsPrestamos
End Class
