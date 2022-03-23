<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pre_rptListadoAplicacionPlanilla
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
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrlSaldoFavor = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlSaldoDeudas = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlSaldoOtros = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine7 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine16 = New DevExpress.XtraReports.UI.XRLine
        Me.xrlEmpresa = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlCentroCosto = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.DsPrestamos1 = New Bravio.dsPrestamos
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLine15 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine5 = New DevExpress.XtraReports.UI.XRLine
        Me.xrlComentario = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine6 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine9 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine12 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.Pre_rptListadoAplicacionPlanilla21 = New Bravio.pre_rptListadoAplicacionPlanilla2
        Me.XrLine17 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine14 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine8 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pre_rptListadoAplicacionPlanilla21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlSaldoFavor, Me.XrLabel5, Me.XrLabel15, Me.xrlSaldoDeudas, Me.XrLabel3, Me.xrlSaldoOtros, Me.XrLine7, Me.XrLine10, Me.XrLine13, Me.XrLine16})
        Me.Detail.HeightF = 24.33333!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlSaldoFavor
        '
        Me.xrlSaldoFavor.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoFavor", "{0:$0.00}")})
        Me.xrlSaldoFavor.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlSaldoFavor.LocationFloat = New DevExpress.Utils.PointFloat(157.5417!, 2.000028!)
        Me.xrlSaldoFavor.Name = "xrlSaldoFavor"
        Me.xrlSaldoFavor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoFavor.SizeF = New System.Drawing.SizeF(78.99998!, 19.0!)
        Me.xrlSaldoFavor.StylePriority.UseFont = False
        Me.xrlSaldoFavor.StylePriority.UseTextAlignment = False
        Me.xrlSaldoFavor.Text = "[SaldoFavor]"
        Me.xrlSaldoFavor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.DescripcionDeudas")})
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(252.0!, 2.000028!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(212.0!, 19.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel15
        '
        Me.XrLabel15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.DescripcionFavor")})
        Me.XrLabel15.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(13.74998!, 2.000028!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(142.0!, 19.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "XrLabel15"
        '
        'xrlSaldoDeudas
        '
        Me.xrlSaldoDeudas.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoDeudas", "{0:$0.00}")})
        Me.xrlSaldoDeudas.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlSaldoDeudas.LocationFloat = New DevExpress.Utils.PointFloat(466.0!, 2.000028!)
        Me.xrlSaldoDeudas.Name = "xrlSaldoDeudas"
        Me.xrlSaldoDeudas.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoDeudas.SizeF = New System.Drawing.SizeF(84.33337!, 19.0!)
        Me.xrlSaldoDeudas.StylePriority.UseFont = False
        Me.xrlSaldoDeudas.StylePriority.UseTextAlignment = False
        Me.xrlSaldoDeudas.Text = "[SaldoDeudas]"
        Me.xrlSaldoDeudas.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.DescripcionOtros")})
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(554.3334!, 2.000028!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(115.0!, 19.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'xrlSaldoOtros
        '
        Me.xrlSaldoOtros.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoOtros", "{0:$0.00}")})
        Me.xrlSaldoOtros.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.xrlSaldoOtros.LocationFloat = New DevExpress.Utils.PointFloat(669.3334!, 2.000028!)
        Me.xrlSaldoOtros.Name = "xrlSaldoOtros"
        Me.xrlSaldoOtros.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoOtros.SizeF = New System.Drawing.SizeF(69.33337!, 19.0!)
        Me.xrlSaldoOtros.StylePriority.UseFont = False
        Me.xrlSaldoOtros.StylePriority.UseTextAlignment = False
        Me.xrlSaldoOtros.Text = "[SaldoOtros]"
        Me.xrlSaldoOtros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine7
        '
        Me.XrLine7.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine7.LocationFloat = New DevExpress.Utils.PointFloat(742.9165!, 0.0000140667!)
        Me.XrLine7.Name = "XrLine7"
        Me.XrLine7.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLine10
        '
        Me.XrLine10.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 0.0!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLine13
        '
        Me.XrLine13.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine13.LocationFloat = New DevExpress.Utils.PointFloat(552.2083!, 0.0!)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'XrLine16
        '
        Me.XrLine16.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine16.LocationFloat = New DevExpress.Utils.PointFloat(244.0!, 0.0000140667!)
        Me.XrLine16.Name = "XrLine16"
        Me.XrLine16.SizeF = New System.Drawing.SizeF(2.083374!, 24.33331!)
        '
        'xrlEmpresa
        '
        Me.xrlEmpresa.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrlEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(13.74998!, 2.0!)
        Me.xrlEmpresa.Name = "xrlEmpresa"
        Me.xrlEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlEmpresa.SizeF = New System.Drawing.SizeF(695.0!, 22.0!)
        Me.xrlEmpresa.StylePriority.UseFont = False
        Me.xrlEmpresa.StylePriority.UseTextAlignment = False
        Me.xrlEmpresa.Text = "xrlEmpresa"
        Me.xrlEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(57.08333!, 109.0!)
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
        Me.PageHeader.HeightF = 17.00001!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCentroCosto
        '
        Me.xrlCentroCosto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlCentroCosto.LocationFloat = New DevExpress.Utils.PointFloat(13.74998!, 23.99999!)
        Me.xrlCentroCosto.Name = "xrlCentroCosto"
        Me.xrlCentroCosto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCentroCosto.SizeF = New System.Drawing.SizeF(695.0!, 14.0!)
        Me.xrlCentroCosto.StylePriority.UseFont = False
        Me.xrlCentroCosto.StylePriority.UseTextAlignment = False
        Me.xrlCentroCosto.Text = "AVISO DE APLICACION DE DESCUENTO EN PLANILLA"
        Me.xrlCentroCosto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 38.04166!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 68.75!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'DsPrestamos1
        '
        Me.DsPrestamos1.DataSetName = "dsPrestamos"
        Me.DsPrestamos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine15, Me.XrLine5, Me.xrlComentario, Me.xrlEmpresa, Me.xrlCentroCosto, Me.XrLabel10, Me.XrLabel4, Me.XrLabel7, Me.XrLine6, Me.XrLine9, Me.XrLine12})
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("IdAsociado", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 129.5833!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'XrLine15
        '
        Me.XrLine15.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine15.LocationFloat = New DevExpress.Utils.PointFloat(244.0!, 108.25!)
        Me.XrLine15.Name = "XrLine15"
        Me.XrLine15.SizeF = New System.Drawing.SizeF(2.083374!, 21.33331!)
        '
        'XrLine5
        '
        Me.XrLine5.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 106.1667!)
        Me.XrLine5.Name = "XrLine5"
        Me.XrLine5.SizeF = New System.Drawing.SizeF(738.0!, 2.083334!)
        '
        'xrlComentario
        '
        Me.xrlComentario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlComentario.LocationFloat = New DevExpress.Utils.PointFloat(13.75002!, 64.99998!)
        Me.xrlComentario.Name = "xrlComentario"
        Me.xrlComentario.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlComentario.SizeF = New System.Drawing.SizeF(693.9168!, 17.0!)
        Me.xrlComentario.StylePriority.UseFont = False
        Me.xrlComentario.StylePriority.UseTextAlignment = False
        Me.xrlComentario.Text = "Comentario"
        Me.xrlComentario.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopJustify
        '
        'XrLabel4
        '
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(316.75!, 109.0!)
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
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(586.4166!, 109.1667!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(121.0!, 16.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "Otros"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLine6
        '
        Me.XrLine6.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine6.LocationFloat = New DevExpress.Utils.PointFloat(742.9166!, 107.1667!)
        Me.XrLine6.Name = "XrLine6"
        Me.XrLine6.SizeF = New System.Drawing.SizeF(2.083374!, 21.33331!)
        '
        'XrLine9
        '
        Me.XrLine9.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine9.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 107.1667!)
        Me.XrLine9.Name = "XrLine9"
        Me.XrLine9.SizeF = New System.Drawing.SizeF(2.083374!, 21.33331!)
        '
        'XrLine12
        '
        Me.XrLine12.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine12.LocationFloat = New DevExpress.Utils.PointFloat(552.2083!, 107.1667!)
        Me.XrLine12.Name = "XrLine12"
        Me.XrLine12.SizeF = New System.Drawing.SizeF(2.083374!, 22.33331!)
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(13.74998!, 7.0!)
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
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoFavor")})
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(157.5417!, 7.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(78.99997!, 19.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel8.Summary = XrSummary1
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoDeudas")})
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(466.0!, 7.0!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(84.33337!, 19.0!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel9.Summary = XrSummary2
        Me.XrLabel9.Text = "XrLabel9"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel11
        '
        Me.XrLabel11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "AplicacionDescPlanilla.SaldoOtros")})
        Me.XrLabel11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(669.3333!, 7.0!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(69.33337!, 19.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.XrLabel11.Summary = XrSummary3
        Me.XrLabel11.Text = "XrLabel11"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel12
        '
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(252.0!, 7.0!)
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
        'XrLabel14
        '
        Me.XrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(554.3334!, 7.0!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(76.0!, 16.0!)
        Me.XrLabel14.StylePriority.UseBorders = False
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "Total Otros"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(153.1667!, 0.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(81.37498!, 2.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(455.9584!, 0.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(92.37497!, 2.0!)
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(645.2919!, 0.0!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(95.375!, 2.0!)
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(6.999998!, 28.0!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(737.0!, 2.083334!)
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(14.99999!, 43.99999!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(400.3334!, 16.00002!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Sus nuevos saldos después de esta aplicación:"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport1, Me.XrLine17, Me.XrLine14, Me.XrLine8, Me.XrLabel1, Me.XrLabel8, Me.XrLabel9, Me.XrLabel11, Me.XrLabel12, Me.XrLabel14, Me.XrLine2, Me.XrLine1, Me.XrLine3, Me.XrLine4, Me.XrLabel16, Me.XrLine11})
        Me.GroupFooter1.HeightF = 101.0417!
        Me.GroupFooter1.Name = "GroupFooter1"
        Me.GroupFooter1.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(4.00001!, 64.00007!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.Pre_rptListadoAplicacionPlanilla21
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(738.0!, 22.99998!)
        '
        'XrLine17
        '
        Me.XrLine17.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine17.LocationFloat = New DevExpress.Utils.PointFloat(244.0!, 0.0!)
        Me.XrLine17.Name = "XrLine17"
        Me.XrLine17.SizeF = New System.Drawing.SizeF(2.083374!, 29.33331!)
        '
        'XrLine14
        '
        Me.XrLine14.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine14.LocationFloat = New DevExpress.Utils.PointFloat(552.2083!, 0.0!)
        Me.XrLine14.Name = "XrLine14"
        Me.XrLine14.SizeF = New System.Drawing.SizeF(2.083374!, 29.33331!)
        '
        'XrLine8
        '
        Me.XrLine8.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine8.LocationFloat = New DevExpress.Utils.PointFloat(742.9166!, 0.0!)
        Me.XrLine8.Name = "XrLine8"
        Me.XrLine8.SizeF = New System.Drawing.SizeF(2.083374!, 29.33331!)
        '
        'XrLine11
        '
        Me.XrLine11.LineDirection = DevExpress.XtraReports.UI.LineDirection.Vertical
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(6.083368!, 0.0!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(2.0!, 29.3333!)
        '
        'pre_rptListadoAplicacionPlanilla
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageFooter, Me.PageHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1, Me.GroupHeader1, Me.GroupFooter1})
        Me.DataMember = "AplicacionDescPlanilla"
        Me.DataSource = Me.DsPrestamos1
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(59, 40, 38, 40)
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pre_rptListadoAplicacionPlanilla21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrlSaldoFavor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlSaldoDeudas As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents DsPrestamos1 As Bravio.dsPrestamos
    Friend WithEvents xrlCentroCosto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlSaldoOtros As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents xrlComentario As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine5 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine6 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine7 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine8 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine9 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine16 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine15 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine12 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine14 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine17 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Private WithEvents Pre_rptListadoAplicacionPlanilla21 As Bravio.pre_rptListadoAplicacionPlanilla2
End Class
