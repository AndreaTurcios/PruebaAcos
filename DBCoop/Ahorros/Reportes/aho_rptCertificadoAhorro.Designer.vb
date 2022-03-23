<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class aho_rptCertificadoAhorro
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
        Me.xrlNombreAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.XrSubreport2 = New DevExpress.XtraReports.UI.XRSubreport
        Me.Aho_rptBeneficiariosPlazo1 = New Bravio.aho_rptBeneficiariosPlazo
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.xrlTasa = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlForma1 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumCuentaCorriente = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumero = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlValor = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCiudad = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlForma2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFechaVence = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAutorizado2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlCantidadLetras = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlAutorizado1 = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand
        Me.xrlPlazo = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumeroAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        CType(Me.Aho_rptBeneficiariosPlazo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'xrlNombreAsociado
        '
        Me.xrlNombreAsociado.AutoWidth = True
        Me.xrlNombreAsociado.CanGrow = False
        Me.xrlNombreAsociado.CanShrink = True
        Me.xrlNombreAsociado.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNombreAsociado.LocationFloat = New DevExpress.Utils.PointFloat(109.5417!, 140.9792!)
        Me.xrlNombreAsociado.Name = "xrlNombreAsociado"
        Me.xrlNombreAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombreAsociado.SizeF = New System.Drawing.SizeF(405.0!, 16.0!)
        Me.xrlNombreAsociado.StylePriority.UseFont = False
        Me.xrlNombreAsociado.StylePriority.UseTextAlignment = False
        Me.xrlNombreAsociado.Text = "xrlNombreAsociado"
        Me.xrlNombreAsociado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrSubreport2})
        Me.BottomMarginBand1.HeightF = 180.25!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrSubreport2
        '
        Me.XrSubreport2.LocationFloat = New DevExpress.Utils.PointFloat(97.16669!, 1.854162!)
        Me.XrSubreport2.Name = "XrSubreport2"
        Me.XrSubreport2.ReportSource = Me.Aho_rptBeneficiariosPlazo1
        Me.XrSubreport2.SizeF = New System.Drawing.SizeF(634.75!, 21.0!)
        '
        'XrLabel11
        '
        Me.XrLabel11.AutoWidth = True
        Me.XrLabel11.CanGrow = False
        Me.XrLabel11.CanShrink = True
        Me.XrLabel11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(137.4167!, 428.3125!)
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(15.33333!, 16.0!)
        Me.XrLabel11.StylePriority.UseFont = False
        Me.XrLabel11.StylePriority.UseTextAlignment = False
        Me.XrLabel11.Text = "X"
        Me.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Detail
        '
        Me.Detail.HeightF = 0.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlTasa
        '
        Me.xrlTasa.AutoWidth = True
        Me.xrlTasa.CanGrow = False
        Me.xrlTasa.CanShrink = True
        Me.xrlTasa.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlTasa.LocationFloat = New DevExpress.Utils.PointFloat(253.7083!, 220.9791!)
        Me.xrlTasa.Name = "xrlTasa"
        Me.xrlTasa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlTasa.SizeF = New System.Drawing.SizeF(36.33334!, 16.99997!)
        Me.xrlTasa.StylePriority.UseFont = False
        Me.xrlTasa.StylePriority.UseTextAlignment = False
        Me.xrlTasa.Text = "6.00%"
        Me.xrlTasa.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlForma1
        '
        Me.xrlForma1.AutoWidth = True
        Me.xrlForma1.CanGrow = False
        Me.xrlForma1.CanShrink = True
        Me.xrlForma1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlForma1.LocationFloat = New DevExpress.Utils.PointFloat(164.125!, 475.7709!)
        Me.xrlForma1.Name = "xrlForma1"
        Me.xrlForma1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlForma1.SizeF = New System.Drawing.SizeF(37.33333!, 16.0!)
        Me.xrlForma1.StylePriority.UseFont = False
        Me.xrlForma1.StylePriority.UseTextAlignment = False
        Me.xrlForma1.Text = "XX"
        Me.xrlForma1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrlForma1.Visible = False
        '
        'xrlNumCuentaCorriente
        '
        Me.xrlNumCuentaCorriente.AutoWidth = True
        Me.xrlNumCuentaCorriente.CanGrow = False
        Me.xrlNumCuentaCorriente.CanShrink = True
        Me.xrlNumCuentaCorriente.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNumCuentaCorriente.LocationFloat = New DevExpress.Utils.PointFloat(383.75!, 427.3125!)
        Me.xrlNumCuentaCorriente.Name = "xrlNumCuentaCorriente"
        Me.xrlNumCuentaCorriente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumCuentaCorriente.SizeF = New System.Drawing.SizeF(140.375!, 16.0!)
        Me.xrlNumCuentaCorriente.StylePriority.UseFont = False
        Me.xrlNumCuentaCorriente.StylePriority.UseTextAlignment = False
        Me.xrlNumCuentaCorriente.Text = "xrlNumCuentaCorriente"
        Me.xrlNumCuentaCorriente.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNumero
        '
        Me.xrlNumero.AutoWidth = True
        Me.xrlNumero.CanGrow = False
        Me.xrlNumero.CanShrink = True
        Me.xrlNumero.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.xrlNumero.LocationFloat = New DevExpress.Utils.PointFloat(569.2916!, 110.9792!)
        Me.xrlNumero.Name = "xrlNumero"
        Me.xrlNumero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumero.SizeF = New System.Drawing.SizeF(140.375!, 24.0!)
        Me.xrlNumero.StylePriority.UseFont = False
        Me.xrlNumero.StylePriority.UseTextAlignment = False
        Me.xrlNumero.Text = "xrlNumero"
        Me.xrlNumero.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlValor
        '
        Me.xrlValor.AutoWidth = True
        Me.xrlValor.CanGrow = False
        Me.xrlValor.CanShrink = True
        Me.xrlValor.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlValor.LocationFloat = New DevExpress.Utils.PointFloat(527.2916!, 165.7709!)
        Me.xrlValor.Name = "xrlValor"
        Me.xrlValor.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlValor.SizeF = New System.Drawing.SizeF(105.375!, 16.99997!)
        Me.xrlValor.StylePriority.UseFont = False
        Me.xrlValor.StylePriority.UseTextAlignment = False
        Me.xrlValor.Text = "xrlValor"
        Me.xrlValor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCiudad
        '
        Me.xrlCiudad.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlCiudad.LocationFloat = New DevExpress.Utils.PointFloat(61.8959!, 585.4167!)
        Me.xrlCiudad.Name = "xrlCiudad"
        Me.xrlCiudad.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCiudad.SizeF = New System.Drawing.SizeF(347.0833!, 17.0!)
        Me.xrlCiudad.StylePriority.UseFont = False
        Me.xrlCiudad.StylePriority.UseTextAlignment = False
        Me.xrlCiudad.Text = "xrlCiudad"
        Me.xrlCiudad.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlForma2
        '
        Me.xrlForma2.AutoWidth = True
        Me.xrlForma2.CanGrow = False
        Me.xrlForma2.CanShrink = True
        Me.xrlForma2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlForma2.LocationFloat = New DevExpress.Utils.PointFloat(255.6458!, 476.7709!)
        Me.xrlForma2.Name = "xrlForma2"
        Me.xrlForma2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlForma2.SizeF = New System.Drawing.SizeF(37.33333!, 16.0!)
        Me.xrlForma2.StylePriority.UseFont = False
        Me.xrlForma2.StylePriority.UseTextAlignment = False
        Me.xrlForma2.Text = "XX"
        Me.xrlForma2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.xrlForma2.Visible = False
        '
        'xrlFechaVence
        '
        Me.xrlFechaVence.AutoWidth = True
        Me.xrlFechaVence.CanGrow = False
        Me.xrlFechaVence.CanShrink = True
        Me.xrlFechaVence.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlFechaVence.LocationFloat = New DevExpress.Utils.PointFloat(189.0625!, 243.3125!)
        Me.xrlFechaVence.Name = "xrlFechaVence"
        Me.xrlFechaVence.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFechaVence.SizeF = New System.Drawing.SizeF(101.375!, 16.99997!)
        Me.xrlFechaVence.StylePriority.UseFont = False
        Me.xrlFechaVence.StylePriority.UseTextAlignment = False
        Me.xrlFechaVence.Text = "xrlFechaVence"
        Me.xrlFechaVence.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(514.0834!, 165.7709!)
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(9.583313!, 16.99997!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.StylePriority.UseTextAlignment = False
        Me.XrLabel18.Text = "$"
        Me.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrlAutorizado2
        '
        Me.xrlAutorizado2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlAutorizado2.LocationFloat = New DevExpress.Utils.PointFloat(462.8333!, 705.8751!)
        Me.xrlAutorizado2.Name = "xrlAutorizado2"
        Me.xrlAutorizado2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAutorizado2.SizeF = New System.Drawing.SizeF(236.8333!, 17.0!)
        Me.xrlAutorizado2.StylePriority.UseFont = False
        Me.xrlAutorizado2.StylePriority.UseTextAlignment = False
        Me.xrlAutorizado2.Text = "xrlAutorizado2"
        Me.xrlAutorizado2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlCantidadLetras
        '
        Me.xrlCantidadLetras.AutoWidth = True
        Me.xrlCantidadLetras.CanGrow = False
        Me.xrlCantidadLetras.CanShrink = True
        Me.xrlCantidadLetras.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlCantidadLetras.LocationFloat = New DevExpress.Utils.PointFloat(104.875!, 198.7708!)
        Me.xrlCantidadLetras.Name = "xrlCantidadLetras"
        Me.xrlCantidadLetras.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlCantidadLetras.SizeF = New System.Drawing.SizeF(587.0!, 16.99997!)
        Me.xrlCantidadLetras.StylePriority.UseFont = False
        Me.xrlCantidadLetras.StylePriority.UseTextAlignment = False
        Me.xrlCantidadLetras.Text = "xrlCantidadLetras"
        Me.xrlCantidadLetras.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlAutorizado1
        '
        Me.xrlAutorizado1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlAutorizado1.LocationFloat = New DevExpress.Utils.PointFloat(170.3542!, 705.875!)
        Me.xrlAutorizado1.Name = "xrlAutorizado1"
        Me.xrlAutorizado1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlAutorizado1.SizeF = New System.Drawing.SizeF(236.8333!, 17.0!)
        Me.xrlAutorizado1.StylePriority.UseFont = False
        Me.xrlAutorizado1.StylePriority.UseTextAlignment = False
        Me.xrlAutorizado1.Text = "xrlAutorizado1"
        Me.xrlAutorizado1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'xrlPlazo
        '
        Me.xrlPlazo.AutoWidth = True
        Me.xrlPlazo.CanGrow = False
        Me.xrlPlazo.CanShrink = True
        Me.xrlPlazo.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlPlazo.LocationFloat = New DevExpress.Utils.PointFloat(516.2916!, 220.9791!)
        Me.xrlPlazo.Name = "xrlPlazo"
        Me.xrlPlazo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlPlazo.SizeF = New System.Drawing.SizeF(175.5834!, 16.99997!)
        Me.xrlPlazo.StylePriority.UseFont = False
        Me.xrlPlazo.StylePriority.UseTextAlignment = False
        Me.xrlPlazo.Text = "xrlPlazo"
        Me.xrlPlazo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNumeroAsociado
        '
        Me.xrlNumeroAsociado.AutoWidth = True
        Me.xrlNumeroAsociado.CanGrow = False
        Me.xrlNumeroAsociado.CanShrink = True
        Me.xrlNumeroAsociado.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xrlNumeroAsociado.LocationFloat = New DevExpress.Utils.PointFloat(109.5417!, 162.7709!)
        Me.xrlNumeroAsociado.Name = "xrlNumeroAsociado"
        Me.xrlNumeroAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumeroAsociado.SizeF = New System.Drawing.SizeF(105.375!, 16.99997!)
        Me.xrlNumeroAsociado.StylePriority.UseFont = False
        Me.xrlNumeroAsociado.StylePriority.UseTextAlignment = False
        Me.xrlNumeroAsociado.Text = "0003156"
        Me.xrlNumeroAsociado.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlAutorizado2, Me.XrLabel11, Me.xrlAutorizado1, Me.xrlForma2, Me.xrlForma1, Me.xrlNumCuentaCorriente, Me.xrlFechaVence, Me.xrlPlazo, Me.xrlTasa, Me.xrlCantidadLetras, Me.xrlValor, Me.xrlNumeroAsociado, Me.XrLabel18, Me.xrlNombreAsociado, Me.xrlNumero, Me.xrlCiudad})
        Me.PageHeader.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.PageHeader.HeightF = 722.9583!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.StylePriority.UseFont = False
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'aho_rptCertificadoAhorro
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.PageFooter, Me.PageHeader, Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "CertificadoAhorro"
        Me.DrawGrid = False
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 180)
        Me.ShowPrintMarginsWarning = False
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me.Aho_rptBeneficiariosPlazo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents XrSubreport2 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents xrlNombreAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents xrlTasa As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlForma1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumCuentaCorriente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlValor As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCiudad As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlForma2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFechaVence As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlAutorizado2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlCantidadLetras As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlAutorizado1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents xrlPlazo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumeroAsociado As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Private WithEvents Aho_rptBeneficiariosPlazo1 As Bravio.aho_rptBeneficiariosPlazo
End Class
