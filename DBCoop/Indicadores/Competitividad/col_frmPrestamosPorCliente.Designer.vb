<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class col_frmPrestamosPorCliente
    Inherits Bravio.gen_frmBaseRpt

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(col_frmPrestamosPorCliente))
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
        Me.LinearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Me.LinearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Me.LinearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Me.LinearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Me.sbDefinicion = New DevExpress.XtraEditors.SimpleButton
        Me.sbAfecta = New DevExpress.XtraEditors.SimpleButton
        Me.meTexto = New DevExpress.XtraEditors.MemoEdit
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.meMes = New DevExpress.XtraScheduler.UI.MonthEdit
        Me.seAnio = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.teSituacionAct = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.rgCorreciones = New DevExpress.XtraEditors.RadioGroup
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.icboResultado = New DevExpress.XtraEditors.ImageComboBoxEdit
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meTexto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.teSituacionAct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgCorreciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icboResultado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.icboResultado)
        Me.GroupControl1.Controls.Add(Me.rgCorreciones)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.meTexto)
        Me.GroupControl1.Controls.Add(Me.sbAfecta)
        Me.GroupControl1.Controls.Add(Me.sbDefinicion)
        Me.GroupControl1.Controls.Add(Me.GaugeControl1)
        Me.GroupControl1.Size = New System.Drawing.Size(867, 504)
        '
        'GaugeControl1
        '
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.LinearGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(12, 26)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(412, 228)
        Me.GaugeControl1.TabIndex = 0
        '
        'LinearGauge1
        '
        Me.LinearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.LinearScaleBackgroundLayerComponent1})
        Me.LinearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 400, 216)
        Me.LinearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.LinearScaleLevelComponent1})
        Me.LinearGauge1.Name = "LinearGauge1"
        Me.LinearGauge1.Orientation = DevExpress.XtraGauges.Core.Model.ScaleOrientation.Horizontal
        Me.LinearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.LinearScaleComponent1})
        '
        'LinearScaleBackgroundLayerComponent1
        '
        Me.LinearScaleBackgroundLayerComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleBackgroundLayerComponent1.Name = "bg1"
        Me.LinearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497!, 0.135!)
        Me.LinearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497!, 0.865!)
        Me.LinearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style9
        Me.LinearScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'LinearScaleComponent1
        '
        Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LinearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 33.0!)
        Me.LinearScaleComponent1.MajorTickCount = 5
        Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = 6.0!
        Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_3
        Me.LinearScaleComponent1.MajorTickmark.TextOffset = 35.0!
        Me.LinearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
        Me.LinearScaleComponent1.MaxValue = 4.0!
        Me.LinearScaleComponent1.MinorTickCount = 0
        Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = 6.0!
        Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_2
        Me.LinearScaleComponent1.Name = "scale1"
        Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 217.0!)
        Me.LinearScaleComponent1.Value = 4.0!
        '
        'LinearScaleLevelComponent1
        '
        Me.LinearScaleLevelComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleLevelComponent1.Name = "level1"
        Me.LinearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style7
        Me.LinearScaleLevelComponent1.ZOrder = -50
        '
        'sbDefinicion
        '
        Me.sbDefinicion.Location = New System.Drawing.Point(430, 35)
        Me.sbDefinicion.Name = "sbDefinicion"
        Me.sbDefinicion.Size = New System.Drawing.Size(98, 23)
        Me.sbDefinicion.TabIndex = 1
        Me.sbDefinicion.Text = "Definición"
        '
        'sbAfecta
        '
        Me.sbAfecta.Location = New System.Drawing.Point(539, 35)
        Me.sbAfecta.Name = "sbAfecta"
        Me.sbAfecta.Size = New System.Drawing.Size(98, 23)
        Me.sbAfecta.TabIndex = 2
        Me.sbAfecta.Text = "Cómo se Afecta"
        '
        'meTexto
        '
        Me.meTexto.Location = New System.Drawing.Point(12, 260)
        Me.meTexto.Name = "meTexto"
        Me.meTexto.Size = New System.Drawing.Size(625, 80)
        Me.meTexto.TabIndex = 7
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.meMes)
        Me.GroupControl3.Controls.Add(Me.seAnio)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Location = New System.Drawing.Point(430, 67)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(207, 83)
        Me.GroupControl3.TabIndex = 19
        Me.GroupControl3.Text = "Fecha"
        '
        'meMes
        '
        Me.meMes.Location = New System.Drawing.Point(58, 52)
        Me.meMes.Name = "meMes"
        Me.meMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meMes.Size = New System.Drawing.Size(112, 20)
        Me.meMes.TabIndex = 10
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(58, 28)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Año"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(31, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mes"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Location = New System.Drawing.Point(431, 156)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(206, 98)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Fórmula"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(30, 70)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(123, 23)
        Me.SimpleButton1.TabIndex = 19
        Me.SimpleButton1.Text = "Ver Resultado..."
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl8.Location = New System.Drawing.Point(94, 40)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(87, 26)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Asociados Activos en Créditos"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(93, 27)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "     Cartera Total    "
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl6.Location = New System.Drawing.Point(78, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(8, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "="
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl5.Location = New System.Drawing.Point(9, 26)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(68, 26)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Préstasmos por Asociados"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.teSituacionAct)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Controls.Add(Me.TextEdit2)
        Me.GroupControl4.Controls.Add(Me.LabelControl10)
        Me.GroupControl4.Controls.Add(Me.TextEdit1)
        Me.GroupControl4.Controls.Add(Me.LabelControl9)
        Me.GroupControl4.Location = New System.Drawing.Point(370, 346)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(267, 128)
        Me.GroupControl4.TabIndex = 20
        Me.GroupControl4.Text = "Datos"
        '
        'teSituacionAct
        '
        Me.teSituacionAct.Location = New System.Drawing.Point(157, 84)
        Me.teSituacionAct.Name = "teSituacionAct"
        Me.teSituacionAct.Properties.ReadOnly = True
        Me.teSituacionAct.Size = New System.Drawing.Size(100, 20)
        Me.teSituacionAct.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(74, 87)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Situación Actual"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(157, 58)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit2.TabIndex = 3
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(16, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(134, 13)
        Me.LabelControl10.TabIndex = 2
        Me.LabelControl10.Text = "Clientes Activos en Créditos"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(157, 32)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Mask.EditMask = "n2"
        Me.TextEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(86, 35)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "Cartera Total"
        '
        'rgCorreciones
        '
        Me.rgCorreciones.Location = New System.Drawing.Point(11, 404)
        Me.rgCorreciones.Name = "rgCorreciones"
        Me.rgCorreciones.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(1, Short), "Aumento de los recursos disponibles"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(2, Short), "Mejora de las condiciones de crédito"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(3, Short), "Nuevos servicios de crédito")})
        Me.rgCorreciones.Size = New System.Drawing.Size(353, 70)
        Me.rgCorreciones.TabIndex = 23
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(14, 362)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(350, 39)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = "La Cooperativa debe actuar activando la oferta de crédito vía el aumento de los r" & _
            "ecursos disponibles, así como activando la demanda de créditos por parte de los " & _
            "asociados"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Location = New System.Drawing.Point(14, 345)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(161, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Cómo Corregir Desviaciones:"
        '
        'icboResultado
        '
        Me.icboResultado.Location = New System.Drawing.Point(652, 64)
        Me.icboResultado.Name = "icboResultado"
        Me.icboResultado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icboResultado.Properties.LargeImages = Me.ImageCollection1
        Me.icboResultado.Size = New System.Drawing.Size(112, 20)
        Me.icboResultado.TabIndex = 24
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "rojo.png")
        Me.ImageCollection1.Images.SetKeyName(1, "amarillo.png")
        Me.ImageCollection1.Images.SetKeyName(2, "azul.png")
        Me.ImageCollection1.Images.SetKeyName(3, "verde.png")
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LabelControl12.Location = New System.Drawing.Point(652, 45)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Text = "Valores deseado"
        '
        'col_frmPrestamosPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 529)
        Me.Name = "col_frmPrestamosPorCliente"
        Me.Text = "Préstamos por Asociados"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LinearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meTexto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.meMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.seAnio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.teSituacionAct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgCorreciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icboResultado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents sbAfecta As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents sbDefinicion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents meTexto As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LinearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
    Private WithEvents LinearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
    Private WithEvents LinearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
    Private WithEvents LinearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents meMes As DevExpress.XtraScheduler.UI.MonthEdit
    Friend WithEvents seAnio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents teSituacionAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgCorreciones As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents icboResultado As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
End Class
