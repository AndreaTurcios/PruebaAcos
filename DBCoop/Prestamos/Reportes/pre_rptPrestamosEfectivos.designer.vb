<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class pre_rptPrestamosEfectivos
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
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.DsPrestamos1 = New Bravio.dsPrestamos
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombreAsociado2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlRecibe = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlValor2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.xrlAutorizacion = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrlNombreAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlID = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlTitulo1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlEmpresa = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFechaEntrega = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlValor = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsPrestamos1
        '
        Me.DsPrestamos1.DataSetName = "dsPrestamos"
        Me.DsPrestamos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 35.83333!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 30.20833!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel12, Me.xrlNombreAsociado2, Me.xrlFecha, Me.xrlRecibe, Me.xrlValor2, Me.XrLabel9, Me.XrShape1, Me.XrLabel8, Me.XrLine3, Me.xrlAutorizacion, Me.XrLabel7, Me.XrLabel6, Me.XrLine2, Me.XrLabel5, Me.XrLine1, Me.xrlNombreAsociado, Me.xrlID, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.xrlTitulo1, Me.xrlEmpresa, Me.xrlFechaEntrega, Me.xrlValor})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PageHeader.HeightF = 949.0416!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseFont = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel10
        '
        Me.XrLabel10.AutoWidth = True
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel10.CanGrow = False
        Me.XrLabel10.CanShrink = True
        Me.XrLabel10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(220.1666!, 265.4792!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(361.167!, 16.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.Text = "( Este monto no puede ser mayor al 20% del sueldo)"
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel12
        '
        Me.XrLabel12.AutoWidth = True
        Me.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel12.CanGrow = False
        Me.XrLabel12.CanShrink = True
        Me.XrLabel12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(354.1039!, 926.1249!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(361.167!, 16.0!)
        Me.XrLabel12.StylePriority.UseBorders = False
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "(Favor firmar cuando reciba el efectivo por parte de Acosiemens)"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNombreAsociado2
        '
        Me.xrlNombreAsociado2.AutoWidth = True
        Me.xrlNombreAsociado2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNombreAsociado2.CanGrow = False
        Me.xrlNombreAsociado2.CanShrink = True
        Me.xrlNombreAsociado2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNombreAsociado2.LocationFloat = New DevExpress.Utils.PointFloat(382.3335!, 896.2291!)
        Me.xrlNombreAsociado2.Name = "xrlNombreAsociado2"
        Me.xrlNombreAsociado2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreAsociado2.SizeF = New System.Drawing.SizeF(332.9373!, 19.0!)
        Me.xrlNombreAsociado2.StylePriority.UseBorders = False
        Me.xrlNombreAsociado2.StylePriority.UseFont = False
        Me.xrlNombreAsociado2.StylePriority.UseTextAlignment = False
        Me.xrlNombreAsociado2.Text = "xrlNombreAsociado"
        Me.xrlNombreAsociado2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'xrlFecha
        '
        Me.xrlFecha.AutoWidth = True
        Me.xrlFecha.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFecha.CanGrow = False
        Me.xrlFecha.CanShrink = True
        Me.xrlFecha.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFecha.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 838.6458!)
        Me.xrlFecha.Name = "xrlFecha"
        Me.xrlFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFecha.SizeF = New System.Drawing.SizeF(363.7918!, 16.0!)
        Me.xrlFecha.StylePriority.UseBorders = False
        Me.xrlFecha.StylePriority.UseFont = False
        Me.xrlFecha.StylePriority.UseTextAlignment = False
        Me.xrlFecha.Text = "xrlFecha"
        Me.xrlFecha.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlRecibe
        '
        Me.xrlRecibe.AutoWidth = True
        Me.xrlRecibe.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlRecibe.CanGrow = False
        Me.xrlRecibe.CanShrink = True
        Me.xrlRecibe.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlRecibe.LocationFloat = New DevExpress.Utils.PointFloat(42.91663!, 748.3957!)
        Me.xrlRecibe.Name = "xrlRecibe"
        Me.xrlRecibe.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlRecibe.SizeF = New System.Drawing.SizeF(672.3541!, 50.375!)
        Me.xrlRecibe.StylePriority.UseBorders = False
        Me.xrlRecibe.StylePriority.UseFont = False
        Me.xrlRecibe.StylePriority.UseTextAlignment = False
        Me.xrlRecibe.Text = "xrlRecibe"
        Me.xrlRecibe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlValor2
        '
        Me.xrlValor2.AutoWidth = True
        Me.xrlValor2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlValor2.CanGrow = False
        Me.xrlValor2.CanShrink = True
        Me.xrlValor2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlValor2.LocationFloat = New DevExpress.Utils.PointFloat(403.1668!, 698.3958!)
        Me.xrlValor2.Name = "xrlValor2"
        Me.xrlValor2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlValor2.SizeF = New System.Drawing.SizeF(74.66684!, 18.0!)
        Me.xrlValor2.StylePriority.UseBorders = False
        Me.xrlValor2.StylePriority.UseFont = False
        Me.xrlValor2.StylePriority.UseTextAlignment = False
        Me.xrlValor2.Text = "xrlValor2"
        Me.xrlValor2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel9
        '
        Me.XrLabel9.AutoWidth = True
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel9.CanGrow = False
        Me.XrLabel9.CanShrink = True
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(328.7086!, 698.3958!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(71.66685!, 18.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Por US$:"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrShape1
        '
        Me.XrShape1.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(306.7086!, 691.3958!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle1
        Me.XrShape1.SizeF = New System.Drawing.SizeF(202.125!, 34.5!)
        Me.XrShape1.StylePriority.UseBorders = False
        '
        'XrLabel8
        '
        Me.XrLabel8.AutoWidth = True
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel8.CanGrow = False
        Me.XrLabel8.CanShrink = True
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(538.3958!, 616.0625!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(125.6251!, 16.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "Firma del Solicitante"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(485.0625!, 612.2708!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(230.2083!, 2.083344!)
        '
        'xrlAutorizacion
        '
        Me.xrlAutorizacion.AutoWidth = True
        Me.xrlAutorizacion.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlAutorizacion.CanGrow = False
        Me.xrlAutorizacion.CanShrink = True
        Me.xrlAutorizacion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlAutorizacion.LocationFloat = New DevExpress.Utils.PointFloat(42.91665!, 484.8958!)
        Me.xrlAutorizacion.Name = "xrlAutorizacion"
        Me.xrlAutorizacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAutorizacion.SizeF = New System.Drawing.SizeF(672.3541!, 50.375!)
        Me.xrlAutorizacion.StylePriority.UseBorders = False
        Me.xrlAutorizacion.StylePriority.UseFont = False
        Me.xrlAutorizacion.StylePriority.UseTextAlignment = False
        Me.xrlAutorizacion.Text = "xrlAutorizacion"
        Me.xrlAutorizacion.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel7
        '
        Me.XrLabel7.AutoWidth = True
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel7.CanGrow = False
        Me.XrLabel7.CanShrink = True
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 468.1875!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(209.5417!, 15.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "AUTORIZACION DE DESCUENTO:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel6
        '
        Me.XrLabel6.AutoWidth = True
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel6.CanGrow = False
        Me.XrLabel6.CanShrink = True
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(509.9373!, 421.7916!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(185.6251!, 16.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Autorizado Recursos Humanos"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(485.0625!, 417.7083!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(230.2083!, 2.083344!)
        '
        'XrLabel5
        '
        Me.XrLabel5.AutoWidth = True
        Me.XrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel5.CanGrow = False
        Me.XrLabel5.CanShrink = True
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(94.79159!, 352.0417!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(125.6251!, 16.0!)
        Me.XrLabel5.StylePriority.UseBorders = False
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "Firma del Solicitante"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 347.9583!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(230.2083!, 2.083344!)
        '
        'xrlNombreAsociado
        '
        Me.xrlNombreAsociado.AutoWidth = True
        Me.xrlNombreAsociado.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlNombreAsociado.CanGrow = False
        Me.xrlNombreAsociado.CanShrink = True
        Me.xrlNombreAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNombreAsociado.LocationFloat = New DevExpress.Utils.PointFloat(220.1666!, 193.5626!)
        Me.xrlNombreAsociado.Name = "xrlNombreAsociado"
        Me.xrlNombreAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreAsociado.SizeF = New System.Drawing.SizeF(500.4166!, 19.0!)
        Me.xrlNombreAsociado.StylePriority.UseBorders = False
        Me.xrlNombreAsociado.StylePriority.UseFont = False
        Me.xrlNombreAsociado.StylePriority.UseTextAlignment = False
        Me.xrlNombreAsociado.Text = "xrlNombreAsociado"
        Me.xrlNombreAsociado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'xrlID
        '
        Me.xrlID.AutoWidth = True
        Me.xrlID.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlID.CanGrow = False
        Me.xrlID.CanShrink = True
        Me.xrlID.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlID.LocationFloat = New DevExpress.Utils.PointFloat(220.1666!, 156.2083!)
        Me.xrlID.Name = "xrlID"
        Me.xrlID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlID.SizeF = New System.Drawing.SizeF(183.2085!, 19.0!)
        Me.xrlID.StylePriority.UseBorders = False
        Me.xrlID.StylePriority.UseFont = False
        Me.xrlID.StylePriority.UseTextAlignment = False
        Me.xrlID.Text = "xrlID"
        Me.xrlID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.AutoWidth = True
        Me.XrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel4.CanGrow = False
        Me.XrLabel4.CanShrink = True
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 230.0209!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(123.5417!, 19.0!)
        Me.XrLabel4.StylePriority.UseBorders = False
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "Monto Solicitado:"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.AutoWidth = True
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel3.CanGrow = False
        Me.XrLabel3.CanShrink = True
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 193.5626!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(156.0417!, 19.0!)
        Me.XrLabel3.StylePriority.UseBorders = False
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Nombre del Empleado:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.AutoWidth = True
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.CanShrink = True
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 156.2083!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(134.0417!, 19.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ID de Solicitud:"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.AutoWidth = True
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.CanShrink = True
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 122.5!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(134.0417!, 19.0!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Fecha de Solicitud:"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlTitulo1
        '
        Me.xrlTitulo1.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.xrlTitulo1.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 58.99999!)
        Me.xrlTitulo1.Name = "xrlTitulo1"
        Me.xrlTitulo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTitulo1.SizeF = New System.Drawing.SizeF(650.0!, 21.99999!)
        Me.xrlTitulo1.StylePriority.UseFont = False
        Me.xrlTitulo1.StylePriority.UseTextAlignment = False
        Me.xrlTitulo1.Text = "SOLICITUD DE PRESTAMO AUTOMATICO"
        Me.xrlTitulo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlEmpresa
        '
        Me.xrlEmpresa.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold)
        Me.xrlEmpresa.LocationFloat = New DevExpress.Utils.PointFloat(42.91676!, 32.0!)
        Me.xrlEmpresa.Name = "xrlEmpresa"
        Me.xrlEmpresa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlEmpresa.SizeF = New System.Drawing.SizeF(650.0!, 24.0!)
        Me.xrlEmpresa.StylePriority.UseFont = False
        Me.xrlEmpresa.StylePriority.UseTextAlignment = False
        Me.xrlEmpresa.Text = "xrlEmpresa"
        Me.xrlEmpresa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlFechaEntrega
        '
        Me.xrlFechaEntrega.AutoWidth = True
        Me.xrlFechaEntrega.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlFechaEntrega.CanGrow = False
        Me.xrlFechaEntrega.CanShrink = True
        Me.xrlFechaEntrega.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFechaEntrega.LocationFloat = New DevExpress.Utils.PointFloat(220.1666!, 122.5!)
        Me.xrlFechaEntrega.Name = "xrlFechaEntrega"
        Me.xrlFechaEntrega.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFechaEntrega.SizeF = New System.Drawing.SizeF(500.4166!, 18.99999!)
        Me.xrlFechaEntrega.StylePriority.UseBorders = False
        Me.xrlFechaEntrega.StylePriority.UseFont = False
        Me.xrlFechaEntrega.StylePriority.UseTextAlignment = False
        Me.xrlFechaEntrega.Text = "xrlFechaEntrega"
        Me.xrlFechaEntrega.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'xrlValor
        '
        Me.xrlValor.AutoWidth = True
        Me.xrlValor.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.xrlValor.CanGrow = False
        Me.xrlValor.CanShrink = True
        Me.xrlValor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlValor.LocationFloat = New DevExpress.Utils.PointFloat(220.1666!, 230.0209!)
        Me.xrlValor.Name = "xrlValor"
        Me.xrlValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlValor.SizeF = New System.Drawing.SizeF(503.7502!, 18.99998!)
        Me.xrlValor.StylePriority.UseBorders = False
        Me.xrlValor.StylePriority.UseFont = False
        Me.xrlValor.StylePriority.UseTextAlignment = False
        Me.xrlValor.Text = "xrlValor"
        Me.xrlValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft
        '
        'pre_rptPrestamosEfectivos
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.PageFooter, Me.PageHeader, Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(43, 65, 36, 30)
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.SnapGridSize = 3.125!
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DsPrestamos1 As Bravio.dsPrestamos
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrlFechaEntrega As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlTitulo1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlEmpresa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombreAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlID As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrlAutorizacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrlValor2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombreAsociado2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlRecibe As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
End Class
