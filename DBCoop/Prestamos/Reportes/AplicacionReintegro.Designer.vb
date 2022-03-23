<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AplicacionReintegro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AplicacionReintegro))
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.xrlISSS = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlDui = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombreAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlLugarFecha = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNombreEmpresaLargo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.DsPrestamos1 = New Bravio.dsPrestamos
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.xrlPlanilla = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAportacionDescontar = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlSaldoAportacion = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlObservaciones = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFormaReintegro = New DevExpress.XtraReports.UI.XRLabel
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport
        Me.SolicitudCrucesCuentasDeuda1 = New Bravio.SolicitudCrucesCuentasDeuda
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.AplicacionReintegroFavor1 = New Bravio.AplicacionReintegroFavor
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolicitudCrucesCuentasDeuda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AplicacionReintegroFavor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.04171!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlISSS
        '
        Me.xrlISSS.AutoWidth = True
        Me.xrlISSS.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlISSS.LocationFloat = New DevExpress.Utils.PointFloat(233.8333!, 251.0626!)
        Me.xrlISSS.Name = "xrlISSS"
        Me.xrlISSS.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlISSS.SizeF = New System.Drawing.SizeF(99.25!, 21.00003!)
        Me.xrlISSS.StylePriority.UseFont = False
        Me.xrlISSS.Text = "ISSS"
        '
        'XrLabel9
        '
        Me.XrLabel9.AutoWidth = True
        Me.XrLabel9.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(54.37501!, 364.9167!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(182.7916!, 24.00003!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Cuentas a Favor:"
        '
        'XrLabel4
        '
        Me.XrLabel4.AutoWidth = True
        Me.XrLabel4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(337.4583!, 251.0626!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(432.1666!, 21.00003!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Deseo aplicar el reintegro  descontado en la planilla de :"
        '
        'XrLabel3
        '
        Me.XrLabel3.AutoWidth = True
        Me.XrLabel3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(152.5833!, 251.0626!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(76.25!, 21.00003!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = ", ISSS No."
        '
        'xrlDui
        '
        Me.xrlDui.AutoWidth = True
        Me.xrlDui.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlDui.LocationFloat = New DevExpress.Utils.PointFloat(52.37497!, 251.0626!)
        Me.xrlDui.Name = "xrlDui"
        Me.xrlDui.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlDui.SizeF = New System.Drawing.SizeF(99.25!, 21.00003!)
        Me.xrlDui.StylePriority.UseFont = False
        Me.xrlDui.Text = "Numero DUI"
        '
        'XrLabel2
        '
        Me.XrLabel2.AutoWidth = True
        Me.XrLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(424.2917!, 216.5627!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(344.3333!, 21.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Con Documento Unico de Identidad (DUI) No."
        '
        'xrlNombreAsociado
        '
        Me.xrlNombreAsociado.AutoWidth = True
        Me.xrlNombreAsociado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNombreAsociado.LocationFloat = New DevExpress.Utils.PointFloat(76.54165!, 216.5627!)
        Me.xrlNombreAsociado.Name = "xrlNombreAsociado"
        Me.xrlNombreAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreAsociado.SizeF = New System.Drawing.SizeF(332.9583!, 21.0!)
        Me.xrlNombreAsociado.StylePriority.UseFont = False
        Me.xrlNombreAsociado.Text = "Asociado"
        '
        'XrLabel1
        '
        Me.XrLabel1.AutoWidth = True
        Me.XrLabel1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(52.37497!, 216.5627!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(22.49997!, 21.00002!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Yo"
        '
        'xrlLugarFecha
        '
        Me.xrlLugarFecha.AutoWidth = True
        Me.xrlLugarFecha.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlLugarFecha.LocationFloat = New DevExpress.Utils.PointFloat(189.9585!, 181.8334!)
        Me.xrlLugarFecha.Name = "xrlLugarFecha"
        Me.xrlLugarFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlLugarFecha.SizeF = New System.Drawing.SizeF(555.7084!, 20.0!)
        Me.xrlLugarFecha.StylePriority.UseFont = False
        Me.xrlLugarFecha.Text = "San Salvador"
        '
        'xrlNombreEmpresaLargo
        '
        Me.xrlNombreEmpresaLargo.LocationFloat = New DevExpress.Utils.PointFloat(174.0421!, 49.0834!)
        Me.xrlNombreEmpresaLargo.Name = "xrlNombreEmpresaLargo"
        Me.xrlNombreEmpresaLargo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreEmpresaLargo.SizeF = New System.Drawing.SizeF(610.4167!, 16.0!)
        Me.xrlNombreEmpresaLargo.StylePriority.UseTextAlignment = False
        Me.xrlNombreEmpresaLargo.Text = "NOMBRE EMPRESA LARGO"
        Me.xrlNombreEmpresaLargo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(7.999998!, 3.0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(162.0001!, 125.5833!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrLabel8
        '
        Me.XrLabel8.AutoWidth = True
        Me.XrLabel8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(52.75029!, 181.8334!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(136.0417!, 20.0!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "En la Ciudad de :"
        '
        'XrLabel6
        '
        Me.XrLabel6.AutoWidth = True
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(174.0421!, 78.04171!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(616.958!, 21.00001!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "APLICACION DE REINTEGROS POR DESCUENTOS EN PLANILA"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
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
        Me.ReportFooter.HeightF = 1.041667!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFormaReintegro, Me.XrLabel5, Me.xrlPlanilla, Me.xrlAportacionDescontar, Me.XrLabel18, Me.xrlSaldoAportacion, Me.XrLabel17, Me.xrlObservaciones, Me.XrLabel16, Me.xrlNumAsociado, Me.XrLabel15, Me.XrLine3, Me.XrLine2, Me.XrLine1, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrSubreport2, Me.XrLabel11, Me.XrSubreport1, Me.XrLabel9, Me.XrLabel2, Me.xrlNombreAsociado, Me.XrLabel1, Me.xrlDui, Me.XrLabel3, Me.XrLabel4, Me.xrlISSS, Me.xrlNombreEmpresaLargo, Me.XrLabel8, Me.XrLabel6, Me.xrlLugarFecha, Me.XrPictureBox1})
        Me.PageHeader.HeightF = 742.7083!
        Me.PageHeader.Name = "PageHeader"
        '
        'xrlPlanilla
        '
        Me.xrlPlanilla.AutoWidth = True
        Me.xrlPlanilla.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlPlanilla.LocationFloat = New DevExpress.Utils.PointFloat(53.0421!, 279.6044!)
        Me.xrlPlanilla.Name = "xrlPlanilla"
        Me.xrlPlanilla.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlPlanilla.SizeF = New System.Drawing.SizeF(716.5828!, 21.00003!)
        Me.xrlPlanilla.StylePriority.UseFont = False
        Me.xrlPlanilla.Text = "en la planilla"
        '
        'xrlAportacionDescontar
        '
        Me.xrlAportacionDescontar.AutoWidth = True
        Me.xrlAportacionDescontar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlAportacionDescontar.LocationFloat = New DevExpress.Utils.PointFloat(646.8335!, 398.75!)
        Me.xrlAportacionDescontar.Name = "xrlAportacionDescontar"
        Me.xrlAportacionDescontar.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAportacionDescontar.SizeF = New System.Drawing.SizeF(123.7916!, 21.00003!)
        Me.xrlAportacionDescontar.StylePriority.UseFont = False
        Me.xrlAportacionDescontar.Text = "Saldo de Aportaciones"
        '
        'XrLabel18
        '
        Me.XrLabel18.AutoWidth = True
        Me.XrLabel18.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(389.8958!, 398.75!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(251.7916!, 21.00003!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "Aportaciones a Aumentar:"
        '
        'xrlSaldoAportacion
        '
        Me.xrlSaldoAportacion.AutoWidth = True
        Me.xrlSaldoAportacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlSaldoAportacion.LocationFloat = New DevExpress.Utils.PointFloat(242.1666!, 398.75!)
        Me.xrlSaldoAportacion.Name = "xrlSaldoAportacion"
        Me.xrlSaldoAportacion.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlSaldoAportacion.SizeF = New System.Drawing.SizeF(123.7916!, 21.00003!)
        Me.xrlSaldoAportacion.StylePriority.UseFont = False
        Me.xrlSaldoAportacion.Text = "Saldo de Aportaciones"
        '
        'XrLabel17
        '
        Me.XrLabel17.AutoWidth = True
        Me.XrLabel17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(54.37501!, 398.75!)
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(182.7916!, 21.00003!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.Text = "Saldo de Aportaciones:"
        '
        'xrlObservaciones
        '
        Me.xrlObservaciones.AutoWidth = True
        Me.xrlObservaciones.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlObservaciones.LocationFloat = New DevExpress.Utils.PointFloat(54.37495!, 603.6251!)
        Me.xrlObservaciones.Name = "xrlObservaciones"
        Me.xrlObservaciones.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlObservaciones.SizeF = New System.Drawing.SizeF(714.2501!, 21.0!)
        Me.xrlObservaciones.StylePriority.UseFont = False
        Me.xrlObservaciones.Text = "Observaciones:"
        '
        'XrLabel16
        '
        Me.XrLabel16.AutoWidth = True
        Me.XrLabel16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(54.37501!, 581.0!)
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(134.417!, 21.0!)
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.Text = "Observaciones:"
        '
        'xrlNumAsociado
        '
        Me.xrlNumAsociado.AutoWidth = True
        Me.xrlNumAsociado.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNumAsociado.LocationFloat = New DevExpress.Utils.PointFloat(177.5833!, 150.6667!)
        Me.xrlNumAsociado.Name = "xrlNumAsociado"
        Me.xrlNumAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumAsociado.SizeF = New System.Drawing.SizeF(152.2499!, 21.00003!)
        Me.xrlNumAsociado.StylePriority.UseFont = False
        Me.xrlNumAsociado.Text = "No. Asociado"
        '
        'XrLabel15
        '
        Me.XrLabel15.AutoWidth = True
        Me.XrLabel15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(52.37497!, 151.6667!)
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(111.0417!, 20.0!)
        Me.XrLabel15.StylePriority.UseFont = False
        Me.XrLabel15.Text = "No. Asociado:"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(583.0!, 675.2081!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(195.0!, 2.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(332.625!, 675.2082!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(195.0!, 2.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(42.16665!, 675.2083!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(195.0!, 2.0!)
        '
        'XrLabel14
        '
        Me.XrLabel14.AutoWidth = True
        Me.XrLabel14.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(635.3751!, 677.2083!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(84.25!, 21.00003!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "RECIBIDO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.AutoWidth = True
        Me.XrLabel13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(361.8333!, 677.2083!)
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(139.25!, 21.00003!)
        Me.XrLabel13.StylePriority.UseFont = False
        Me.XrLabel13.StylePriority.UseTextAlignment = False
        Me.XrLabel13.Text = "AUTORIZADO POR "
        Me.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel12
        '
        Me.XrLabel12.AutoWidth = True
        Me.XrLabel12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(106.375!, 677.2083!)
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(60.25!, 21.00003!)
        Me.XrLabel12.StylePriority.UseFont = False
        Me.XrLabel12.StylePriority.UseTextAlignment = False
        Me.XrLabel12.Text = "FIRMA"
        Me.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel11
        '
        Me.XrLabel11.AutoWidth = True
        Me.XrLabel11.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(54.37501!, 489.2083!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(716.2501!, 24.00003!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.Text = "Deudas a Abonar"
        '
        'XrLabel5
        '
        Me.XrLabel5.AutoWidth = True
        Me.XrLabel5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(52.37497!, 321.0624!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(289.6667!, 21.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Forma de Cancelación de Reintegro:"
        '
        'xrlFormaReintegro
        '
        Me.xrlFormaReintegro.AutoWidth = True
        Me.xrlFormaReintegro.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFormaReintegro.LocationFloat = New DevExpress.Utils.PointFloat(345.4583!, 321.0624!)
        Me.xrlFormaReintegro.Name = "xrlFormaReintegro"
        Me.xrlFormaReintegro.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFormaReintegro.SizeF = New System.Drawing.SizeF(422.1667!, 21.0!)
        Me.xrlFormaReintegro.StylePriority.UseFont = False
        Me.xrlFormaReintegro.Text = "Abono a Deudas / Generar Cheque"
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(54.37501!, 532.4375!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = Me.SolicitudCrucesCuentasDeuda1
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(716.2501!, 28.54169!)
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(40.37501!, 438.9167!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.AplicacionReintegroFavor1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(716.2501!, 28.54169!)
        '
        'AplicacionReintegro
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportFooter, Me.PageFooter, Me.PageHeader})
        Me.DataMember = "SolicitudPrestamo"
        Me.DataSource = Me.DsPrestamos1
        Me.Margins = New System.Drawing.Printing.Margins(25, 27, 25, 0)
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.DsPrestamos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolicitudCrucesCuentasDeuda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AplicacionReintegroFavor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsPrestamos1 As Bravio.dsPrestamos
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents xrlNombreEmpresaLargo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombreAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlLugarFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlDui As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlISSS As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents xrlNumAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents SolicitudCrucesCuentasDeuda1 As Bravio.SolicitudCrucesCuentasDeuda
    Friend WithEvents xrlObservaciones As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlAportacionDescontar As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlSaldoAportacion As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlPlanilla As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents AplicacionReintegroFavor1 As Bravio.AplicacionReintegroFavor
    Friend WithEvents xrlFormaReintegro As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
End Class
