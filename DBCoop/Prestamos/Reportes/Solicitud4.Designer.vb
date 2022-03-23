<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Solicitud4
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrlFechaIngreso = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine33 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel96 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine24 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine13 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine25 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine26 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel41 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel46 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine27 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine28 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel47 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel50 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel51 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine10 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine32 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel64 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel79 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel80 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCuotaAporta = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombreSolicta = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel87 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.DsPrestamos1 = New Bravio.dsPrestamos
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.XrLine4 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine11 = New DevExpress.XtraReports.UI.XRLine
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFechaIngreso, Me.XrLabel7, Me.XrLabel6, Me.XrLine2, Me.XrLine1, Me.XrLine33, Me.XrLabel13, Me.XrLabel1, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel96, Me.XrLine24, Me.XrLine13, Me.XrLabel38, Me.XrLine25, Me.XrLabel40, Me.XrLine26, Me.XrLabel41, Me.XrLabel46, Me.XrLine27, Me.XrLine28, Me.XrLabel47, Me.XrLabel50, Me.XrLabel51, Me.XrLine10, Me.XrLabel21, Me.XrLabel17, Me.XrLine32, Me.XrLabel64, Me.XrLabel79, Me.XrLabel80, Me.xrlCuotaAporta, Me.xrlNombreSolicta, Me.XrLabel87})
        Me.Detail.HeightF = 306.9583!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlFechaIngreso
        '
        Me.xrlFechaIngreso.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.FechaIngresoTrabajo", "{0:dd/MM/yyyy}")})
        Me.xrlFechaIngreso.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFechaIngreso.LocationFloat = New DevExpress.Utils.PointFloat(238.6461!, 106.6251!)
        Me.xrlFechaIngreso.Name = "xrlFechaIngreso"
        Me.xrlFechaIngreso.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFechaIngreso.SizeF = New System.Drawing.SizeF(182.2498!, 19.0!)
        Me.xrlFechaIngreso.StylePriority.UseFont = False
        Me.xrlFechaIngreso.Text = "xrlFechaIngreso"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(12.81196!, 235.3123!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(735.0317!, 18.99995!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "obligación por lo que me comprometo: cancelar la deuda de esta persona, si no lo " & _
            "hace en el periodo establecido."
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(316.8542!, 213.3124!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(430.9995!, 18.99995!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = ".Y estoy de acuerdo en formar la solicitud como CODEUDOR de  dicha "
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(227.7918!, 149.6251!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(519.6031!, 2.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(226.7918!, 125.6251!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(519.6031!, 2.0!)
        '
        'XrLine33
        '
        Me.XrLine33.LocationFloat = New DevExpress.Utils.PointFloat(556.3536!, 285.9583!)
        Me.XrLine33.Name = "XrLine33"
        Me.XrLine33.SizeF = New System.Drawing.SizeF(190.6667!, 2.0!)
        '
        'XrLabel13
        '
        Me.XrLabel13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(540.6866!, 266.9583!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(17.58401!, 19.0!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.Text = "F."
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(576.187!, 287.9583!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(138.1667!, 19.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "Firma Codeudor"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel5
        '
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.DepartamentoLabora")})
        Me.XrLabel5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(223.7918!, 78.7916!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(511.6031!, 19.00001!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "XrLabel5"
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.Direccion")})
        Me.XrLabel4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(149.271!, 53.54166!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(586.5828!, 19.00001!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "XrLabel4"
        '
        'XrLabel3
        '
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.FechaExpedicion", "{0:dd/MM/yyyy}")})
        Me.XrLabel3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(565.6866!, 29.83324!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(182.2498!, 19.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "XrLabel3"
        '
        'XrLabel96
        '
        Me.XrLabel96.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.NombresApellidos")})
        Me.XrLabel96.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel96.LocationFloat = New DevExpress.Utils.PointFloat(73.6883!, 0.0!)
        Me.XrLabel96.Name = "XrLabel96"
        Me.XrLabel96.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel96.SizeF = New System.Drawing.SizeF(672.8218!, 19.0!)
        Me.XrLabel96.StylePriority.UseFont = False
        Me.XrLabel96.Text = "XrLabel96"
        '
        'XrLine24
        '
        Me.XrLine24.LocationFloat = New DevExpress.Utils.PointFloat(12.81231!, 207.9375!)
        Me.XrLine24.Name = "XrLine24"
        Me.XrLine24.SizeF = New System.Drawing.SizeF(631.2911!, 2.083328!)
        '
        'XrLine13
        '
        Me.XrLine13.LocationFloat = New DevExpress.Utils.PointFloat(125.688!, 229.3123!)
        Me.XrLine13.Name = "XrLine13"
        Me.XrLine13.SizeF = New System.Drawing.SizeF(179.5825!, 3.000076!)
        '
        'XrLabel38
        '
        Me.XrLabel38.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(10.39552!, 0.9999599!)
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(59.37415!, 19.0!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.Text = "NOMBRE:"
        '
        'XrLine25
        '
        Me.XrLine25.LocationFloat = New DevExpress.Utils.PointFloat(70.68831!, 19.87499!)
        Me.XrLine25.Name = "XrLine25"
        Me.XrLine25.SizeF = New System.Drawing.SizeF(675.8217!, 2.0!)
        '
        'XrLabel40
        '
        Me.XrLabel40.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(11.0206!, 29.83319!)
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(44.62503!, 19.00002!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.Text = "D.U.I."
        '
        'XrLine26
        '
        Me.XrLine26.LocationFloat = New DevExpress.Utils.PointFloat(57.23025!, 47.62475!)
        Me.XrLine26.Name = "XrLine26"
        Me.XrLine26.SizeF = New System.Drawing.SizeF(216.7485!, 3.083435!)
        '
        'XrLabel41
        '
        Me.XrLabel41.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel41.LocationFloat = New DevExpress.Utils.PointFloat(286.6454!, 29.83319!)
        Me.XrLabel41.Name = "XrLabel41"
        Me.XrLabel41.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel41.SizeF = New System.Drawing.SizeF(94.62504!, 19.00002!)
        Me.XrLabel41.StylePriority.UseFont = False
        Me.XrLabel41.Text = "EXTENDIDO EN"
        '
        'XrLabel46
        '
        Me.XrLabel46.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel46.LocationFloat = New DevExpress.Utils.PointFloat(10.39552!, 55.54164!)
        Me.XrLabel46.Name = "XrLabel46"
        Me.XrLabel46.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel46.SizeF = New System.Drawing.SizeF(135.1667!, 19.0!)
        Me.XrLabel46.StylePriority.UseFont = False
        Me.XrLabel46.Text = "DIRECCIÓN PERSONAL"
        '
        'XrLine27
        '
        Me.XrLine27.LocationFloat = New DevExpress.Utils.PointFloat(383.8537!, 49.83321!)
        Me.XrLine27.Name = "XrLine27"
        Me.XrLine27.SizeF = New System.Drawing.SizeF(362.8331!, 2.0!)
        '
        'XrLine28
        '
        Me.XrLine28.LocationFloat = New DevExpress.Utils.PointFloat(149.271!, 73.45832!)
        Me.XrLine28.Name = "XrLine28"
        Me.XrLine28.SizeF = New System.Drawing.SizeF(598.5827!, 2.0!)
        '
        'XrLabel47
        '
        Me.XrLabel47.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel47.LocationFloat = New DevExpress.Utils.PointFloat(10.81223!, 81.7917!)
        Me.XrLabel47.Name = "XrLabel47"
        Me.XrLabel47.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel47.SizeF = New System.Drawing.SizeF(208.1667!, 19.0!)
        Me.XrLabel47.StylePriority.UseFont = False
        Me.XrLabel47.Text = "DEPARTAMENTO EN QUE LABORA"
        '
        'XrLabel50
        '
        Me.XrLabel50.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel50.LocationFloat = New DevExpress.Utils.PointFloat(646.7703!, 191.0208!)
        Me.XrLabel50.Name = "XrLabel50"
        Me.XrLabel50.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel50.SizeF = New System.Drawing.SizeF(101.1667!, 19.0!)
        Me.XrLabel50.StylePriority.UseFont = False
        Me.XrLabel50.Text = "para un crédito"
        '
        'XrLabel51
        '
        Me.XrLabel51.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel51.LocationFloat = New DevExpress.Utils.PointFloat(10.81223!, 165.6251!)
        Me.XrLabel51.Name = "XrLabel51"
        Me.XrLabel51.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel51.SizeF = New System.Drawing.SizeF(490.0108!, 19.0!)
        Me.XrLabel51.StylePriority.UseFont = False
        Me.XrLabel51.Text = "Hago constar que he tomado debida nota de la solicitud de crédito de el Sr.(a):"
        '
        'XrLine10
        '
        Me.XrLine10.LocationFloat = New DevExpress.Utils.PointFloat(222.0003!, 99.79169!)
        Me.XrLine10.Name = "XrLine10"
        Me.XrLine10.SizeF = New System.Drawing.SizeF(525.6031!, 2.0!)
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(11.81223!, 129.6251!)
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(213.5408!, 19.0!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.Text = "CUOTA MENSUAL QUE APORTA: $"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(11.76023!, 105.6251!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(215.0825!, 19.0!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "FECHA DE INGRESO A LA EMPRESA:"
        '
        'XrLine32
        '
        Me.XrLine32.LocationFloat = New DevExpress.Utils.PointFloat(501.5425!, 184.625!)
        Me.XrLine32.Name = "XrLine32"
        Me.XrLine32.SizeF = New System.Drawing.SizeF(244.4575!, 2.0!)
        '
        'XrLabel64
        '
        Me.XrLabel64.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel64.LocationFloat = New DevExpress.Utils.PointFloat(12.81231!, 212.3124!)
        Me.XrLabel64.Name = "XrLabel64"
        Me.XrLabel64.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel64.SizeF = New System.Drawing.SizeF(112.2082!, 18.99994!)
        Me.XrLabel64.StylePriority.UseFont = False
        Me.XrLabel64.Text = "por el valor de  $"
        '
        'XrLabel79
        '
        Me.XrLabel79.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.NroDocumento")})
        Me.XrLabel79.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel79.LocationFloat = New DevExpress.Utils.PointFloat(65.23024!, 27.83323!)
        Me.XrLabel79.Name = "XrLabel79"
        Me.XrLabel79.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel79.SizeF = New System.Drawing.SizeF(195.7482!, 19.0!)
        Me.XrLabel79.StylePriority.UseFont = False
        Me.XrLabel79.Text = "XrLabel79"
        '
        'XrLabel80
        '
        Me.XrLabel80.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.LugarExpedicion")})
        Me.XrLabel80.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel80.LocationFloat = New DevExpress.Utils.PointFloat(386.8537!, 29.83322!)
        Me.XrLabel80.Name = "XrLabel80"
        Me.XrLabel80.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel80.SizeF = New System.Drawing.SizeF(172.2498!, 19.0!)
        Me.XrLabel80.StylePriority.UseFont = False
        Me.XrLabel80.Text = "XrLabel80"
        '
        'xrlCuotaAporta
        '
        Me.xrlCuotaAporta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.CuotaAportacion", "{0:n2}")})
        Me.xrlCuotaAporta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlCuotaAporta.LocationFloat = New DevExpress.Utils.PointFloat(238.6461!, 129.6251!)
        Me.xrlCuotaAporta.Name = "xrlCuotaAporta"
        Me.xrlCuotaAporta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCuotaAporta.SizeF = New System.Drawing.SizeF(125.7499!, 19.0!)
        Me.xrlCuotaAporta.StylePriority.UseFont = False
        Me.xrlCuotaAporta.StylePriority.UseTextAlignment = False
        Me.xrlCuotaAporta.Text = "xrlCuotaAporta"
        Me.xrlCuotaAporta.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'xrlNombreSolicta
        '
        Me.xrlNombreSolicta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.NombreSolicitante")})
        Me.xrlNombreSolicta.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNombreSolicta.LocationFloat = New DevExpress.Utils.PointFloat(13.81231!, 187.625!)
        Me.xrlNombreSolicta.Name = "xrlNombreSolicta"
        Me.xrlNombreSolicta.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreSolicta.SizeF = New System.Drawing.SizeF(618.2911!, 17.99988!)
        Me.xrlNombreSolicta.StylePriority.UseFont = False
        Me.xrlNombreSolicta.Text = "xrlNombreSolicta"
        '
        'XrLabel87
        '
        Me.XrLabel87.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "SolicitudPrestamoFiadores.MontoSolicitado", "{0:n2}")})
        Me.XrLabel87.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel87.LocationFloat = New DevExpress.Utils.PointFloat(149.271!, 210.3123!)
        Me.XrLabel87.Name = "XrLabel87"
        Me.XrLabel87.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel87.SizeF = New System.Drawing.SizeF(115.7499!, 19.0!)
        Me.XrLabel87.StylePriority.UseFont = False
        Me.XrLabel87.StylePriority.UseTextAlignment = False
        Me.XrLabel87.Text = "XrLabel87"
        Me.XrLabel87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsPrestamos1
        '
        Me.DsPrestamos1.DataSetName = "dsPrestamos"
        Me.DsPrestamos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine4, Me.XrLine3, Me.XrLabel15, Me.XrLine11})
        Me.ReportFooter.HeightF = 71.875!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'XrLine4
        '
        Me.XrLine4.LocationFloat = New DevExpress.Utils.PointFloat(25.55191!, 67.58334!)
        Me.XrLine4.Name = "XrLine4"
        Me.XrLine4.SizeF = New System.Drawing.SizeF(722.4481!, 2.083336!)
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(25.55191!, 42.5833!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(722.4481!, 2.083336!)
        '
        'XrLabel15
        '
        Me.XrLabel15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(25.55191!, 3.0!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(113.0103!, 18.9999!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "OBSERVACIONES:"
        '
        'XrLine11
        '
        Me.XrLine11.LocationFloat = New DevExpress.Utils.PointFloat(139.5623!, 19.41607!)
        Me.XrLine11.Name = "XrLine11"
        Me.XrLine11.SizeF = New System.Drawing.SizeF(608.8326!, 2.0!)
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Solicitud4
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageFooter})
        Me.DataMember = "SolicitudPrestamoFiadores"
        Me.DataSource = Me.DsPrestamos1
        Me.Margins = New System.Drawing.Printing.Margins(25, 27, 0, 0)
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLine13 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine24 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel96 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsPrestamos1 As Bravio.dsPrestamos
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLine27 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel46 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel41 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine26 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine25 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine10 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel51 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel50 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel47 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine28 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine32 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel64 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel87 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombreSolicta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCuotaAporta As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel80 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel79 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine33 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine11 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine4 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents xrlFechaIngreso As DevExpress.XtraReports.UI.XRLabel
End Class
