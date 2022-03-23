<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pre_rptFacturaIngresos
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
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.xrlConceptoExento = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNoSujeto = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlDui = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlComprobante = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotalPagado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotalGravado = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotalExento2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotalExento = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrlGravado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlDireccion = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumeroAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFechaContable = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTotalOtros = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlExento = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlOtrosIngresos = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlconceptoGravado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlConceptoOtrosIngresos = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlConceptoNoSujeto = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCantidadLetras = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombre = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrlIva = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlSaldo = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'xrlConceptoExento
        '
        Me.xrlConceptoExento.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlConceptoExento.CanGrow = False
        Me.xrlConceptoExento.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlConceptoExento.LocationFloat = New DevExpress.Utils.PointFloat(1.58337!, 343.7917!)
        Me.xrlConceptoExento.Name = "xrlConceptoExento"
        Me.xrlConceptoExento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlConceptoExento.SizeF = New System.Drawing.SizeF(310.9999!, 19.0!)
        Me.xrlConceptoExento.StylePriority.UseBorders = False
        Me.xrlConceptoExento.StylePriority.UseFont = False
        Me.xrlConceptoExento.StylePriority.UseTextAlignment = False
        Me.xrlConceptoExento.Text = "xrlConceptoExento"
        Me.xrlConceptoExento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlSaldo, Me.xrlIva, Me.XrLabel1, Me.xrlNoSujeto, Me.xrlDui, Me.xrlComprobante, Me.xrlTotalPagado, Me.xrlTotalGravado, Me.XrLabel10, Me.XrLabel9, Me.xrlTotalExento2, Me.xrlTotalExento, Me.XrLine1, Me.xrlGravado, Me.xrlDireccion, Me.xrlNumeroAsociado, Me.xrlFechaContable, Me.xrlTotalOtros, Me.xrlExento, Me.xrlOtrosIngresos, Me.xrlconceptoGravado, Me.xrlConceptoOtrosIngresos, Me.xrlConceptoExento, Me.xrlConceptoNoSujeto, Me.xrlCantidadLetras, Me.xrlNombre, Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PageHeader.HeightF = 689.6251!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseFont = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(506.9374!, 223.1667!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(116.7083!, 16.99998!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "No. Comprobante"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNoSujeto
        '
        Me.xrlNoSujeto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNoSujeto.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlNoSujeto.LocationFloat = New DevExpress.Utils.PointFloat(437.5!, 267.9376!)
        Me.xrlNoSujeto.Name = "xrlNoSujeto"
        Me.xrlNoSujeto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNoSujeto.SizeF = New System.Drawing.SizeF(71.00002!, 18.0!)
        Me.xrlNoSujeto.StylePriority.UseBorders = False
        Me.xrlNoSujeto.StylePriority.UseFont = False
        Me.xrlNoSujeto.StylePriority.UseTextAlignment = False
        Me.xrlNoSujeto.Text = "xrlNoSujeto"
        Me.xrlNoSujeto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlDui
        '
        Me.xrlDui.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlDui.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlDui.LocationFloat = New DevExpress.Utils.PointFloat(622.3333!, 148.8333!)
        Me.xrlDui.Name = "xrlDui"
        Me.xrlDui.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlDui.SizeF = New System.Drawing.SizeF(90.7083!, 14.0!)
        Me.xrlDui.StylePriority.UseBorders = False
        Me.xrlDui.StylePriority.UseFont = False
        Me.xrlDui.StylePriority.UseTextAlignment = False
        Me.xrlDui.Text = "xrlDui"
        Me.xrlDui.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlComprobante
        '
        Me.xrlComprobante.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlComprobante.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlComprobante.LocationFloat = New DevExpress.Utils.PointFloat(629.0833!, 223.1667!)
        Me.xrlComprobante.Name = "xrlComprobante"
        Me.xrlComprobante.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlComprobante.SizeF = New System.Drawing.SizeF(85.70831!, 16.99998!)
        Me.xrlComprobante.StylePriority.UseBorders = False
        Me.xrlComprobante.StylePriority.UseFont = False
        Me.xrlComprobante.StylePriority.UseTextAlignment = False
        Me.xrlComprobante.Text = "xrlComprobante"
        Me.xrlComprobante.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlTotalPagado
        '
        Me.xrlTotalPagado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotalPagado.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlTotalPagado.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 610.1041!)
        Me.xrlTotalPagado.Name = "xrlTotalPagado"
        Me.xrlTotalPagado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotalPagado.SizeF = New System.Drawing.SizeF(78.99988!, 18.0!)
        Me.xrlTotalPagado.StylePriority.UseBorders = False
        Me.xrlTotalPagado.StylePriority.UseFont = False
        Me.xrlTotalPagado.StylePriority.UseTextAlignment = False
        Me.xrlTotalPagado.Text = "xrlTotalPagado"
        Me.xrlTotalPagado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlTotalGravado
        '
        Me.xrlTotalGravado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotalGravado.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlTotalGravado.LocationFloat = New DevExpress.Utils.PointFloat(617.5001!, 586.1042!)
        Me.xrlTotalGravado.Name = "xrlTotalGravado"
        Me.xrlTotalGravado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotalGravado.SizeF = New System.Drawing.SizeF(77.99988!, 17.0!)
        Me.xrlTotalGravado.StylePriority.UseBorders = False
        Me.xrlTotalGravado.StylePriority.UseFont = False
        Me.xrlTotalGravado.StylePriority.UseTextAlignment = False
        Me.xrlTotalGravado.Text = "xrlTotalGravado"
        Me.xrlTotalGravado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 550.1042!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(77.99988!, 14.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "0.0"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 530.1042!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(77.99988!, 15.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "0.0"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlTotalExento2
        '
        Me.xrlTotalExento2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotalExento2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlTotalExento2.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 569.1042!)
        Me.xrlTotalExento2.Name = "xrlTotalExento2"
        Me.xrlTotalExento2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotalExento2.SizeF = New System.Drawing.SizeF(77.99988!, 17.0!)
        Me.xrlTotalExento2.StylePriority.UseBorders = False
        Me.xrlTotalExento2.StylePriority.UseFont = False
        Me.xrlTotalExento2.StylePriority.UseTextAlignment = False
        Me.xrlTotalExento2.Text = "xrlTotalExento2"
        Me.xrlTotalExento2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlTotalExento
        '
        Me.xrlTotalExento.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotalExento.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlTotalExento.LocationFloat = New DevExpress.Utils.PointFloat(513.5001!, 530.1042!)
        Me.xrlTotalExento.Name = "xrlTotalExento"
        Me.xrlTotalExento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotalExento.SizeF = New System.Drawing.SizeF(78.99988!, 17.0!)
        Me.xrlTotalExento.StylePriority.UseBorders = False
        Me.xrlTotalExento.StylePriority.UseFont = False
        Me.xrlTotalExento.StylePriority.UseTextAlignment = False
        Me.xrlTotalExento.Text = "xrlTotalExento"
        Me.xrlTotalExento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(330.0!, 486.5001!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(75.33334!, 2.0!)
        '
        'xrlGravado
        '
        Me.xrlGravado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlGravado.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlGravado.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 364.6042!)
        Me.xrlGravado.Name = "xrlGravado"
        Me.xrlGravado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlGravado.SizeF = New System.Drawing.SizeF(77.99988!, 19.0!)
        Me.xrlGravado.StylePriority.UseBorders = False
        Me.xrlGravado.StylePriority.UseFont = False
        Me.xrlGravado.StylePriority.UseTextAlignment = False
        Me.xrlGravado.Text = "xrlGravado"
        Me.xrlGravado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlDireccion
        '
        Me.xrlDireccion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlDireccion.CanGrow = False
        Me.xrlDireccion.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlDireccion.LocationFloat = New DevExpress.Utils.PointFloat(364.1667!, 147.8333!)
        Me.xrlDireccion.Name = "xrlDireccion"
        Me.xrlDireccion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlDireccion.SizeF = New System.Drawing.SizeF(253.6249!, 16.0!)
        Me.xrlDireccion.StylePriority.UseBorders = False
        Me.xrlDireccion.StylePriority.UseFont = False
        Me.xrlDireccion.StylePriority.UseTextAlignment = False
        Me.xrlDireccion.Text = "xrlDireccion"
        Me.xrlDireccion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNumeroAsociado
        '
        Me.xrlNumeroAsociado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNumeroAsociado.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlNumeroAsociado.LocationFloat = New DevExpress.Utils.PointFloat(583.5834!, 124.8333!)
        Me.xrlNumeroAsociado.Name = "xrlNumeroAsociado"
        Me.xrlNumeroAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumeroAsociado.SizeF = New System.Drawing.SizeF(131.2083!, 18.0!)
        Me.xrlNumeroAsociado.StylePriority.UseBorders = False
        Me.xrlNumeroAsociado.StylePriority.UseFont = False
        Me.xrlNumeroAsociado.StylePriority.UseTextAlignment = False
        Me.xrlNumeroAsociado.Text = "xrlNumeroAsociado"
        Me.xrlNumeroAsociado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlFechaContable
        '
        Me.xrlFechaContable.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFechaContable.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlFechaContable.LocationFloat = New DevExpress.Utils.PointFloat(66.9584!, 126.8333!)
        Me.xrlFechaContable.Name = "xrlFechaContable"
        Me.xrlFechaContable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFechaContable.SizeF = New System.Drawing.SizeF(108.625!, 18.0!)
        Me.xrlFechaContable.StylePriority.UseBorders = False
        Me.xrlFechaContable.StylePriority.UseFont = False
        Me.xrlFechaContable.StylePriority.UseTextAlignment = False
        Me.xrlFechaContable.Text = "xrlFechaContable"
        Me.xrlFechaContable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlTotalOtros
        '
        Me.xrlTotalOtros.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlTotalOtros.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlTotalOtros.LocationFloat = New DevExpress.Utils.PointFloat(333.5833!, 488.5001!)
        Me.xrlTotalOtros.Name = "xrlTotalOtros"
        Me.xrlTotalOtros.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTotalOtros.SizeF = New System.Drawing.SizeF(69.99992!, 20.0!)
        Me.xrlTotalOtros.StylePriority.UseBorders = False
        Me.xrlTotalOtros.StylePriority.UseFont = False
        Me.xrlTotalOtros.StylePriority.UseTextAlignment = False
        Me.xrlTotalOtros.Text = "xrlTotalOtros"
        Me.xrlTotalOtros.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlExento
        '
        Me.xrlExento.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlExento.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlExento.LocationFloat = New DevExpress.Utils.PointFloat(528.5833!, 340.7917!)
        Me.xrlExento.Name = "xrlExento"
        Me.xrlExento.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlExento.SizeF = New System.Drawing.SizeF(66.99991!, 19.0!)
        Me.xrlExento.StylePriority.UseBorders = False
        Me.xrlExento.StylePriority.UseFont = False
        Me.xrlExento.StylePriority.UseTextAlignment = False
        Me.xrlExento.Text = "xrlExento"
        Me.xrlExento.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlOtrosIngresos
        '
        Me.xrlOtrosIngresos.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlOtrosIngresos.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlOtrosIngresos.LocationFloat = New DevExpress.Utils.PointFloat(333.5833!, 304.5417!)
        Me.xrlOtrosIngresos.Name = "xrlOtrosIngresos"
        Me.xrlOtrosIngresos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlOtrosIngresos.SizeF = New System.Drawing.SizeF(71.00002!, 17.0!)
        Me.xrlOtrosIngresos.StylePriority.UseBorders = False
        Me.xrlOtrosIngresos.StylePriority.UseFont = False
        Me.xrlOtrosIngresos.StylePriority.UseTextAlignment = False
        Me.xrlOtrosIngresos.Text = "xrlOtrosIngresos"
        Me.xrlOtrosIngresos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlconceptoGravado
        '
        Me.xrlconceptoGravado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlconceptoGravado.CanGrow = False
        Me.xrlconceptoGravado.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlconceptoGravado.LocationFloat = New DevExpress.Utils.PointFloat(1.58337!, 366.7917!)
        Me.xrlconceptoGravado.Name = "xrlconceptoGravado"
        Me.xrlconceptoGravado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlconceptoGravado.SizeF = New System.Drawing.SizeF(310.9999!, 19.0!)
        Me.xrlconceptoGravado.StylePriority.UseBorders = False
        Me.xrlconceptoGravado.StylePriority.UseFont = False
        Me.xrlconceptoGravado.StylePriority.UseTextAlignment = False
        Me.xrlconceptoGravado.Text = "xrlconceptoGravado"
        Me.xrlconceptoGravado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlConceptoOtrosIngresos
        '
        Me.xrlConceptoOtrosIngresos.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlConceptoOtrosIngresos.CanGrow = False
        Me.xrlConceptoOtrosIngresos.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlConceptoOtrosIngresos.LocationFloat = New DevExpress.Utils.PointFloat(1.58337!, 304.5417!)
        Me.xrlConceptoOtrosIngresos.Name = "xrlConceptoOtrosIngresos"
        Me.xrlConceptoOtrosIngresos.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlConceptoOtrosIngresos.SizeF = New System.Drawing.SizeF(183.0!, 31.25003!)
        Me.xrlConceptoOtrosIngresos.StylePriority.UseBorders = False
        Me.xrlConceptoOtrosIngresos.StylePriority.UseFont = False
        Me.xrlConceptoOtrosIngresos.StylePriority.UseTextAlignment = False
        Me.xrlConceptoOtrosIngresos.Text = "xrlConceptoOtrosIngresos"
        Me.xrlConceptoOtrosIngresos.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlConceptoNoSujeto
        '
        Me.xrlConceptoNoSujeto.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlConceptoNoSujeto.CanGrow = False
        Me.xrlConceptoNoSujeto.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlConceptoNoSujeto.LocationFloat = New DevExpress.Utils.PointFloat(1.58337!, 268.7917!)
        Me.xrlConceptoNoSujeto.Name = "xrlConceptoNoSujeto"
        Me.xrlConceptoNoSujeto.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlConceptoNoSujeto.SizeF = New System.Drawing.SizeF(310.9999!, 19.0!)
        Me.xrlConceptoNoSujeto.StylePriority.UseBorders = False
        Me.xrlConceptoNoSujeto.StylePriority.UseFont = False
        Me.xrlConceptoNoSujeto.StylePriority.UseTextAlignment = False
        Me.xrlConceptoNoSujeto.Text = "xrlConceptoNoSujeto"
        Me.xrlConceptoNoSujeto.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCantidadLetras
        '
        Me.xrlCantidadLetras.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlCantidadLetras.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlCantidadLetras.LocationFloat = New DevExpress.Utils.PointFloat(54.58337!, 177.4375!)
        Me.xrlCantidadLetras.Name = "xrlCantidadLetras"
        Me.xrlCantidadLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCantidadLetras.SizeF = New System.Drawing.SizeF(319.9999!, 18.0!)
        Me.xrlCantidadLetras.StylePriority.UseBorders = False
        Me.xrlCantidadLetras.StylePriority.UseFont = False
        Me.xrlCantidadLetras.StylePriority.UseTextAlignment = False
        Me.xrlCantidadLetras.Text = "xrlCantidadLetras"
        Me.xrlCantidadLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNombre
        '
        Me.xrlNombre.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNombre.CanGrow = False
        Me.xrlNombre.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlNombre.LocationFloat = New DevExpress.Utils.PointFloat(54.58337!, 147.8333!)
        Me.xrlNombre.Name = "xrlNombre"
        Me.xrlNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombre.SizeF = New System.Drawing.SizeF(296.1249!, 17.0!)
        Me.xrlNombre.StylePriority.UseBorders = False
        Me.xrlNombre.StylePriority.UseFont = False
        Me.xrlNombre.StylePriority.UseTextAlignment = False
        Me.xrlNombre.Text = "xrlNombre"
        Me.xrlNombre.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.XrPageInfo2.Format = "{0:hh:mm tt}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(17.58341!, 586.1042!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(84.0!, 15.0!)
        Me.XrPageInfo2.StylePriority.UseFont = False
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.XrPageInfo1.Format = "{0:dd/MM/yyyy}"
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(17.58341!, 571.1042!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(84.0!, 15.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportFooter
        '
        Me.ReportFooter.HeightF = 0.0!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 1.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlIva
        '
        Me.xrlIva.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlIva.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlIva.LocationFloat = New DevExpress.Utils.PointFloat(617.5!, 392.8542!)
        Me.xrlIva.Name = "xrlIva"
        Me.xrlIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlIva.SizeF = New System.Drawing.SizeF(77.99988!, 19.0!)
        Me.xrlIva.StylePriority.UseBorders = False
        Me.xrlIva.StylePriority.UseFont = False
        Me.xrlIva.StylePriority.UseTextAlignment = False
        Me.xrlIva.Text = "xrlIva"
        Me.xrlIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlSaldo
        '
        Me.xrlSaldo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlSaldo.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.xrlSaldo.LocationFloat = New DevExpress.Utils.PointFloat(258.0!, 543.1459!)
        Me.xrlSaldo.Name = "xrlSaldo"
        Me.xrlSaldo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldo.SizeF = New System.Drawing.SizeF(69.99992!, 20.0!)
        Me.xrlSaldo.StylePriority.UseBorders = False
        Me.xrlSaldo.StylePriority.UseFont = False
        Me.xrlSaldo.StylePriority.UseTextAlignment = False
        Me.xrlSaldo.Text = "0.0"
        Me.xrlSaldo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'pre_rptFacturaIngresos
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
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrlConceptoExento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrlComprobante As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalPagado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalGravado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalExento2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalExento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrlGravado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlDireccion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumeroAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFechaContable As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTotalOtros As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlExento As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlOtrosIngresos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlconceptoGravado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlConceptoOtrosIngresos As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlConceptoNoSujeto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCantidadLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrlDui As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNoSujeto As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlSaldo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlIva As DevExpress.XtraReports.UI.XRLabel
End Class
