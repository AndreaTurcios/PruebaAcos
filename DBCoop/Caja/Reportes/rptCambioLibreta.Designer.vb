<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCambioLibreta
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.xrlNombre = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlNumero = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.xrlNumeroAsociado = New DevExpress.XtraReports.UI.XRLabel
        Me.xrlFecha = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 31.25!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrlFecha, Me.xrlNumeroAsociado, Me.xrlNombre, Me.xrlNumero})
        Me.TopMargin.HeightF = 227.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNombre
        '
        Me.xrlNombre.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.xrlNombre.LocationFloat = New DevExpress.Utils.PointFloat(56.62482!, 106.625!)
        Me.xrlNombre.Name = "xrlNombre"
        Me.xrlNombre.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNombre.SizeF = New System.Drawing.SizeF(487.5417!, 17.99999!)
        Me.xrlNombre.StylePriority.UseFont = False
        Me.xrlNombre.Text = "xrlAnombreDe"
        '
        'xrlNumero
        '
        Me.xrlNumero.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrlNumero.LocationFloat = New DevExpress.Utils.PointFloat(318.9582!, 31.62497!)
        Me.xrlNumero.Name = "xrlNumero"
        Me.xrlNumero.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumero.SizeF = New System.Drawing.SizeF(253.2083!, 20.0!)
        Me.xrlNumero.StylePriority.UseFont = False
        Me.xrlNumero.Text = "xrlNumero"
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrlNumeroAsociado
        '
        Me.xrlNumeroAsociado.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.xrlNumeroAsociado.LocationFloat = New DevExpress.Utils.PointFloat(89.22917!, 128.1667!)
        Me.xrlNumeroAsociado.Name = "xrlNumeroAsociado"
        Me.xrlNumeroAsociado.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlNumeroAsociado.SizeF = New System.Drawing.SizeF(138.2083!, 20.0!)
        Me.xrlNumeroAsociado.StylePriority.UseFont = False
        Me.xrlNumeroAsociado.Text = "xrlNumeroAsociado"
        '
        'xrlFecha
        '
        Me.xrlFecha.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.xrlFecha.LocationFloat = New DevExpress.Utils.PointFloat(345.8958!, 126.1667!)
        Me.xrlFecha.Name = "xrlFecha"
        Me.xrlFecha.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrlFecha.SizeF = New System.Drawing.SizeF(128.2706!, 20.0!)
        Me.xrlFecha.StylePriority.UseFont = False
        Me.xrlFecha.Text = "xrlFecha"
        '
        'rptCambioLibreta
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(65, 100, 227, 100)
        Me.ShowPrintMarginsWarning = False
        Me.SnapGridSize = 5.0!
        Me.SnapToGrid = False
        Me.Version = "11.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents xrlNumero As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNombre As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlFecha As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xrlNumeroAsociado As DevExpress.XtraReports.UI.XRLabel
End Class
