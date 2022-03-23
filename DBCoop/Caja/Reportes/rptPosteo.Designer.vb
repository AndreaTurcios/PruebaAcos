<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPosteo
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlComprobante = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlValor = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCuenta = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCajero = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.xrlCajero, Me.XrLabel11, Me.XrLabel6, Me.XrLabel3, Me.xrlCuenta, Me.XrLabel2, Me.xrlComprobante, Me.xrlFecha, Me.xrlValor, Me.XrLabel5, Me.XrPageInfo2})
        Me.PageHeader.HeightF = 670.8751!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlComprobante
        '
        Me.xrlComprobante.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlComprobante.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.xrlComprobante.LocationFloat = New DevExpress.Utils.PointFloat(307.2083!, 17.00002!)
        Me.xrlComprobante.Name = "xrlComprobante"
        Me.xrlComprobante.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlComprobante.SizeF = New System.Drawing.SizeF(85.70831!, 16.0!)
        Me.xrlComprobante.StylePriority.UseBorders = False
        Me.xrlComprobante.StylePriority.UseFont = False
        Me.xrlComprobante.StylePriority.UseTextAlignment = False
        Me.xrlComprobante.Text = "xrlComprobante"
        Me.xrlComprobante.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlFecha
        '
        Me.xrlFecha.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFecha.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.xrlFecha.LocationFloat = New DevExpress.Utils.PointFloat(232.5!, 63.24998!)
        Me.xrlFecha.Name = "xrlFecha"
        Me.xrlFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFecha.SizeF = New System.Drawing.SizeF(82.70831!, 15.0!)
        Me.xrlFecha.StylePriority.UseBorders = False
        Me.xrlFecha.StylePriority.UseFont = False
        Me.xrlFecha.StylePriority.UseTextAlignment = False
        Me.xrlFecha.Text = "xrlFecha"
        Me.xrlFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlValor
        '
        Me.xrlValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlValor.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.xrlValor.LocationFloat = New DevExpress.Utils.PointFloat(380.3334!, 64.25001!)
        Me.xrlValor.Name = "xrlValor"
        Me.xrlValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlValor.SizeF = New System.Drawing.SizeF(75.99991!, 16.0!)
        Me.xrlValor.StylePriority.UseBorders = False
        Me.xrlValor.StylePriority.UseFont = False
        Me.xrlValor.StylePriority.UseTextAlignment = False
        Me.xrlValor.Text = "xrlValor"
        Me.xrlValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(169.2084!, 17.00002!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(128.0!, 16.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "No. Comprobante:"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrPageInfo2.Format = "{0:hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(428.125!, 85.25014!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(75.0!, 16.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 1.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(169.625!, 41.24998!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(63.41667!, 16.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Cuenta:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCuenta
        '
        Me.xrlCuenta.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlCuenta.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.xrlCuenta.LocationFloat = New DevExpress.Utils.PointFloat(239.5!, 42.24998!)
        Me.xrlCuenta.Name = "xrlCuenta"
        Me.xrlCuenta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCuenta.SizeF = New System.Drawing.SizeF(85.70831!, 16.0!)
        Me.xrlCuenta.StylePriority.UseBorders = False
        Me.xrlCuenta.StylePriority.UseFont = False
        Me.xrlCuenta.StylePriority.UseTextAlignment = False
        Me.xrlCuenta.Text = "xrlCuenta"
        Me.xrlCuenta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(169.2084!, 64.25001!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(58.41667!, 15.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Fecha:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(321.2083!, 64.24998!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(55.41669!, 15.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Valor:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel11
        '
        Me.XrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel11.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(171.625!, 85.25014!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(62.41667!, 15.0!)
        Me.XrLabel11.StylePriority.UseBorders = False
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "Cajero:"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCajero
        '
        Me.xrlCajero.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlCajero.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.xrlCajero.LocationFloat = New DevExpress.Utils.PointFloat(239.5!, 85.25014!)
        Me.xrlCajero.Name = "xrlCajero"
        Me.xrlCajero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCajero.SizeF = New System.Drawing.SizeF(134.7083!, 16.0!)
        Me.xrlCajero.StylePriority.UseBorders = False
        Me.xrlCajero.StylePriority.UseFont = False
        Me.xrlCajero.StylePriority.UseTextAlignment = False
        Me.xrlCajero.Text = "xrlCajero"
        Me.xrlCajero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Courier New", 9.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(379.3334!, 85.25017!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(45.41669!, 15.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Hora:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptPosteo
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.ReportFooter, Me.PageHeader, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "EstadoCuenta"
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(40, 41, 0, 1)
        Me.PageHeight = 925
        Me.PageWidth = 685
        Me.PaperKind = System.Drawing.Printing.PaperKind.A5Extra
        Me.SnapGridSize = 5.0!
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrlComprobante As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCuenta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCajero As DevExpress.XtraReports.UI.XRLabel
End Class
