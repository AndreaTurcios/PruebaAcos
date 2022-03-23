<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pre_rptListadoAplicacionPlanilla2
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrlSaldoFavor2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlSaldoDeudas2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine16 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine15 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.xrlFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine14 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine17 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine
        Me.DsPrestamos1 = New Bravio.dsPrestamos
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlSaldoFavor2, Me.XrLabel5, Me.XrLabel15, Me.xrlSaldoDeudas2, Me.XrLine10, Me.XrLine13, Me.XrLine16})
        Me.Detail.HeightF = 24.33332!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlSaldoFavor2
        '
        Me.xrlSaldoFavor2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoFavorFin", "{0:$0.00}")})
        Me.xrlSaldoFavor2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlSaldoFavor2.LocationFloat = New DevExpress.Utils.PointFloat(154.5417!, 2.000028!)
        Me.xrlSaldoFavor2.Name = "xrlSaldoFavor2"
        Me.xrlSaldoFavor2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoFavor2.SizeF = New System.Drawing.SizeF(78.99998!, 19.0!)
        Me.xrlSaldoFavor2.StylePriority.UseFont = False
        Me.xrlSaldoFavor2.StylePriority.UseTextAlignment = False
        Me.xrlSaldoFavor2.Text = "xrlSaldoFavor2"
        Me.xrlSaldoFavor2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.DescripcionDeudas")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(248.0!, 2.000028!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(198.0!, 19.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.DescripcionFavor")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(10.74998!, 2.000028!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(142.0!, 19.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "XrLabel15"
        '
        'xrlSaldoDeudas2
        '
        Me.xrlSaldoDeudas2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoDeudasFin", "{0:$0.00}")})
        Me.xrlSaldoDeudas2.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlSaldoDeudas2.LocationFloat = New DevExpress.Utils.PointFloat(448.0!, 2.000028!)
        Me.xrlSaldoDeudas2.Name = "xrlSaldoDeudas2"
        Me.xrlSaldoDeudas2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoDeudas2.SizeF = New System.Drawing.SizeF(84.33337!, 19.0!)
        Me.xrlSaldoDeudas2.StylePriority.UseFont = False
        Me.xrlSaldoDeudas2.StylePriority.UseTextAlignment = False
        Me.xrlSaldoDeudas2.Text = "xrlSaldoDeudas2"
        Me.xrlSaldoDeudas2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine10
        '
        Me.XrLine10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(1.999994!, 0.0!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLine13
        '
        Me.XrLine13.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine13.LocationFloat = New DevExpress.Utils.PointFloat(549.2083!, 0.0!)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLine16
        '
        Me.XrLine16.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine16.LocationFloat = New DevExpress.Utils.PointFloat(242.0!, 0.0000140667!)
        Me.XrLine16.Name = "XrLine16"
        Me.XrLine16.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 27.08333!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 40.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine8, Me.XrLabel10, Me.XrLine5, Me.XrLine15, Me.XrLabel4, Me.XrLine12, Me.XrLabel2})
        Me.PageHeader.HeightF = 26.72916!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine8
        '
        Me.XrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(1.916634!, 1.31251!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(54.08334!, 3.145826!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "Saldos a su favor"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(3.0!, 0.3125134!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(548.0!, 2.083334!)
        '
        'XrLine15
        '
        Me.XrLine15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine15.LocationFloat = New DevExpress.Utils.PointFloat(242.0!, 2.395849!)
        Me.XrLine15.Name = "XrLine15"
        Me.XrLine15.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(295.75!, 3.145826!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Préstamos"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine12
        '
        Me.XrLine12.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(549.2083!, 2.312513!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(2.083374!, 23.33331!)
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(557.2917!, 9.645812!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ATENCION"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 12.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFecha, Me.XrLabel8, Me.XrLine1, Me.XrLine2, Me.XrLabel12, Me.XrLabel9, Me.XrLine4, Me.XrLabel1, Me.XrLine14, Me.XrLine17, Me.XrLine11})
        Me.ReportFooter.HeightF = 33.33333!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'xrlFecha
        '
        Me.xrlFecha.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFecha.LocationFloat = New DevExpress.Utils.PointFloat(557.2916!, 0.3333421!)
        Me.xrlFecha.Multiline = True
        Me.xrlFecha.Name = "xrlFecha"
        Me.xrlFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFecha.SizeF = New System.Drawing.SizeF(172.0417!, 16.0!)
        Me.xrlFecha.StylePriority.UseBorders = False
        Me.xrlFecha.StylePriority.UseFont = False
        Me.xrlFecha.StylePriority.UseTextAlignment = False
        Me.xrlFecha.Text = "Fecha"
        Me.xrlFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoFavorFin")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(154.5417!, 9.000007!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(78.99997!, 19.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel8.Summary = XrSummary1
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(437.9584!, 3.000005!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(92.37497!, 2.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(150.1667!, 3.000005!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(81.37498!, 2.0!)
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(248.0!, 9.000007!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "Total a Préstamos"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoDeudasFin")})
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(448.0!, 9.000007!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(84.33337!, 19.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel9.Summary = XrSummary2
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(4.000002!, 28.00001!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(546.0!, 2.0!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.74998!, 9.000007!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Total a su favor"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine14
        '
        Me.XrLine14.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine14.LocationFloat = New DevExpress.Utils.PointFloat(549.2083!, 0.0!)
        Me.XrLine14.Name = "XrLine14"
        Me.XrLine14.SizeF = New System.Drawing.SizeF(2.083374!, 29.33331!)
        '
        'XrLine17
        '
        Me.XrLine17.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine17.LocationFloat = New DevExpress.Utils.PointFloat(242.0!, 0.0!)
        Me.XrLine17.Name = "XrLine17"
        Me.XrLine17.SizeF = New System.Drawing.SizeF(2.083374!, 29.33331!)
        '
        'XrLine11
        '
        Me.XrLine11.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(2.000001!, 0.0!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(2.0!, 29.3333!)
        '
        'DsPrestamos1
        '
        Me.DsPrestamos1.DataSetName = "dsPrestamos"
        Me.DsPrestamos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pre_rptListadoAplicacionPlanilla2
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.PageHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "AplicacionDescPlanilla"
        Me.DataSource = Me.DsPrestamos1
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(59, 40, 12, 40)
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrlSaldoFavor2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlSaldoDeudas2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DsPrestamos1 As Bravio.dsPrestamos
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine16 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine14 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine17 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFecha As DevExpress.XtraReports.UI.XRLabel
End Class
