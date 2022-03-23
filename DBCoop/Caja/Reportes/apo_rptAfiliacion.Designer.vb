<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class apo_rptAfiliacion
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
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.xrlFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlApellido = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumero = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTramite = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlOtros = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlIngreso = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCantidadLetras = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombre = New DevExpress.XtraReports.UI.XRLabel
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 1.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(531.0!, 114.9167!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(75.0!, 16.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrPageInfo2.Format = "{0:hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(531.0!, 130.9167!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(75.0!, 16.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'xrlFecha
        '
        Me.xrlFecha.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFecha.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlFecha.LocationFloat = New DevExpress.Utils.PointFloat(470.0!, 204.5416!)
        Me.xrlFecha.Name = "xrlFecha"
        Me.xrlFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFecha.SizeF = New System.Drawing.SizeF(193.0!, 19.0!)
        Me.xrlFecha.StylePriority.UseBorders = False
        Me.xrlFecha.StylePriority.UseFont = False
        Me.xrlFecha.StylePriority.UseTextAlignment = False
        Me.xrlFecha.Text = "xrlFecha"
        Me.xrlFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlApellido, Me.xrlNumero, Me.xrlTotal, Me.xrlTramite, Me.xrlOtros, Me.xrlIngreso, Me.XrLabel8, Me.XrLabel7, Me.XrLabel5, Me.xrlCantidadLetras, Me.xrlNombre, Me.xrlFecha, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageHeader.HeightF = 476.1249!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlApellido
        '
        Me.xrlApellido.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlApellido.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlApellido.LocationFloat = New DevExpress.Utils.PointFloat(471.0417!, 262.5624!)
        Me.xrlApellido.Name = "xrlApellido"
        Me.xrlApellido.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlApellido.SizeF = New System.Drawing.SizeF(159.9166!, 16.0!)
        Me.xrlApellido.StylePriority.UseBorders = False
        Me.xrlApellido.StylePriority.UseFont = False
        Me.xrlApellido.StylePriority.UseTextAlignment = False
        Me.xrlApellido.Text = "xrlApellido"
        Me.xrlApellido.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNumero
        '
        Me.xrlNumero.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNumero.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlNumero.LocationFloat = New DevExpress.Utils.PointFloat(635.0!, 261.6458!)
        Me.xrlNumero.Name = "xrlNumero"
        Me.xrlNumero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumero.SizeF = New System.Drawing.SizeF(68.99994!, 19.0!)
        Me.xrlNumero.StylePriority.UseBorders = False
        Me.xrlNumero.StylePriority.UseFont = False
        Me.xrlNumero.StylePriority.UseTextAlignment = False
        Me.xrlNumero.Text = "xrlNumero"
        Me.xrlNumero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlTotal
        '
        Me.xrlTotal.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotal.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlTotal.LocationFloat = New DevExpress.Utils.PointFloat(296.5834!, 433.0625!)
        Me.xrlTotal.Name = "xrlTotal"
        Me.xrlTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotal.SizeF = New System.Drawing.SizeF(103.9999!, 19.0!)
        Me.xrlTotal.StylePriority.UseBorders = False
        Me.xrlTotal.StylePriority.UseFont = False
        Me.xrlTotal.StylePriority.UseTextAlignment = False
        Me.xrlTotal.Text = "xrlTotal"
        Me.xrlTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlTramite
        '
        Me.xrlTramite.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTramite.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlTramite.LocationFloat = New DevExpress.Utils.PointFloat(295.5833!, 289.7918!)
        Me.xrlTramite.Name = "xrlTramite"
        Me.xrlTramite.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTramite.SizeF = New System.Drawing.SizeF(104.0!, 19.0!)
        Me.xrlTramite.StylePriority.UseBorders = False
        Me.xrlTramite.StylePriority.UseFont = False
        Me.xrlTramite.StylePriority.UseTextAlignment = False
        Me.xrlTramite.Text = "xrlTramite"
        Me.xrlTramite.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlOtros
        '
        Me.xrlOtros.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlOtros.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlOtros.LocationFloat = New DevExpress.Utils.PointFloat(295.5833!, 313.0625!)
        Me.xrlOtros.Name = "xrlOtros"
        Me.xrlOtros.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlOtros.SizeF = New System.Drawing.SizeF(103.9999!, 19.0!)
        Me.xrlOtros.StylePriority.UseBorders = False
        Me.xrlOtros.StylePriority.UseFont = False
        Me.xrlOtros.StylePriority.UseTextAlignment = False
        Me.xrlOtros.Text = "xrlOtros"
        Me.xrlOtros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlIngreso
        '
        Me.xrlIngreso.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlIngreso.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlIngreso.LocationFloat = New DevExpress.Utils.PointFloat(294.5833!, 263.5416!)
        Me.xrlIngreso.Name = "xrlIngreso"
        Me.xrlIngreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlIngreso.SizeF = New System.Drawing.SizeF(103.0!, 19.0!)
        Me.xrlIngreso.StylePriority.UseBorders = False
        Me.xrlIngreso.StylePriority.UseFont = False
        Me.xrlIngreso.StylePriority.UseTextAlignment = False
        Me.xrlIngreso.Text = "xrlIngreso"
        Me.xrlIngreso.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(29.58341!, 312.0625!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(151.9999!, 19.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "OTROS"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(29.58337!, 288.7918!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(151.9999!, 19.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "TRAMITE AFILIACION"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(28.5834!, 262.5417!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(151.0!, 19.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "INGRESO ASOCIADO"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCantidadLetras
        '
        Me.xrlCantidadLetras.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlCantidadLetras.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlCantidadLetras.LocationFloat = New DevExpress.Utils.PointFloat(467.9999!, 293.7917!)
        Me.xrlCantidadLetras.Name = "xrlCantidadLetras"
        Me.xrlCantidadLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCantidadLetras.SizeF = New System.Drawing.SizeF(271.9167!, 19.0!)
        Me.xrlCantidadLetras.StylePriority.UseBorders = False
        Me.xrlCantidadLetras.StylePriority.UseFont = False
        Me.xrlCantidadLetras.StylePriority.UseTextAlignment = False
        Me.xrlCantidadLetras.Text = "xrlCantidadLetras"
        Me.xrlCantidadLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNombre
        '
        Me.xrlNombre.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNombre.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.xrlNombre.LocationFloat = New DevExpress.Utils.PointFloat(471.0!, 231.7917!)
        Me.xrlNombre.Name = "xrlNombre"
        Me.xrlNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombre.SizeF = New System.Drawing.SizeF(268.9166!, 19.0!)
        Me.xrlNombre.StylePriority.UseBorders = False
        Me.xrlNombre.StylePriority.UseFont = False
        Me.xrlNombre.StylePriority.UseTextAlignment = False
        Me.xrlNombre.Text = "xrlNombre"
        Me.xrlNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'apo_rptAfiliacion
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.ReportFooter, Me.PageHeader, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "EstadoCuenta"
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(40, 41, 0, 1)
        Me.SnapGridSize = 5.0!
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents xrlFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrlNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCantidadLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTramite As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlOtros As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlIngreso As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlApellido As DevExpress.XtraReports.UI.XRLabel
End Class
