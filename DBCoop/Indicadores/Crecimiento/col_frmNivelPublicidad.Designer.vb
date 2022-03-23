<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class col_frmNivelPublicidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(col_frmNivelPublicidad))
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
        Me.sbResultado = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl
        Me.teSituacionAct = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.icboResultado = New DevExpress.XtraEditors.ImageComboBoxEdit
        Me.teCta01 = New DevExpress.XtraEditors.TextEdit
        Me.beCta01 = New DevExpress.XtraEditors.ButtonEdit
        Me.LblCuenta = New DevExpress.XtraEditors.LabelControl
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
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icboResultado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.teCta01)
        Me.GroupControl1.Controls.Add(Me.beCta01)
        Me.GroupControl1.Controls.Add(Me.LblCuenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.icboResultado)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(Me.meTexto)
        Me.GroupControl1.Controls.Add(Me.sbAfecta)
        Me.GroupControl1.Controls.Add(Me.sbDefinicion)
        Me.GroupControl1.Controls.Add(Me.GaugeControl1)
        Me.GroupControl1.Size = New System.Drawing.Size(763, 504)
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
        Me.LinearScaleComponent1.MajorTickCount = 6
        Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = 6.0!
        Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_3
        Me.LinearScaleComponent1.MajorTickmark.TextOffset = 35.0!
        Me.LinearScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.BottomToTop
        Me.LinearScaleComponent1.MaxValue = 50.0!
        Me.LinearScaleComponent1.MinorTickCount = 0
        Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = 6.0!
        Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style7_2
        Me.LinearScaleComponent1.Name = "scale1"
        Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 217.0!)
        Me.LinearScaleComponent1.Value = 20.0!
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
        Me.sbDefinicion.Size = New System.Drawing.Size(64, 23)
        Me.sbDefinicion.TabIndex = 1
        Me.sbDefinicion.Text = "Definición"
        '
        'sbAfecta
        '
        Me.sbAfecta.Location = New System.Drawing.Point(499, 35)
        Me.sbAfecta.Name = "sbAfecta"
        Me.sbAfecta.Size = New System.Drawing.Size(86, 23)
        Me.sbAfecta.TabIndex = 2
        Me.sbAfecta.Text = "Cómo se Afecta"
        '
        'meTexto
        '
        Me.meTexto.Location = New System.Drawing.Point(12, 260)
        Me.meTexto.Name = "meTexto"
        Me.meTexto.Size = New System.Drawing.Size(695, 80)
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
        Me.GroupControl3.Size = New System.Drawing.Size(153, 83)
        Me.GroupControl3.TabIndex = 19
        Me.GroupControl3.Text = "Fecha"
        '
        'meMes
        '
        Me.meMes.Location = New System.Drawing.Point(32, 52)
        Me.meMes.Name = "meMes"
        Me.meMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.meMes.Size = New System.Drawing.Size(112, 20)
        Me.meMes.TabIndex = 10
        '
        'seAnio
        '
        Me.seAnio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.seAnio.Location = New System.Drawing.Point(32, 28)
        Me.seAnio.Name = "seAnio"
        Me.seAnio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.seAnio.Size = New System.Drawing.Size(71, 20)
        Me.seAnio.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Año"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 55)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Mes"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.sbResultado)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Location = New System.Drawing.Point(431, 156)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(276, 96)
        Me.GroupControl2.TabIndex = 18
        Me.GroupControl2.Text = "Fórmula"
        '
        'sbResultado
        '
        Me.sbResultado.Location = New System.Drawing.Point(17, 66)
        Me.sbResultado.Name = "sbResultado"
        Me.sbResultado.Size = New System.Drawing.Size(159, 23)
        Me.sbResultado.TabIndex = 19
        Me.sbResultado.Text = "Ver Resultado..."
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl8.Location = New System.Drawing.Point(77, 47)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(130, 13)
        Me.LabelControl8.TabIndex = 18
        Me.LabelControl8.Text = "Gasto Publicidad Anterior"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Location = New System.Drawing.Point(9, 33)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(262, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "Gasto Publicidad Total - Gasto Publicidad Anterior X100"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.teSituacionAct)
        Me.GroupControl4.Controls.Add(Me.LabelControl11)
        Me.GroupControl4.Location = New System.Drawing.Point(589, 67)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(118, 83)
        Me.GroupControl4.TabIndex = 20
        Me.GroupControl4.Text = "Datos"
        '
        'teSituacionAct
        '
        Me.teSituacionAct.Location = New System.Drawing.Point(5, 54)
        Me.teSituacionAct.Name = "teSituacionAct"
        Me.teSituacionAct.Properties.ReadOnly = True
        Me.teSituacionAct.Size = New System.Drawing.Size(100, 20)
        Me.teSituacionAct.TabIndex = 5
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(5, 35)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 4
        Me.LabelControl11.Text = "Situación Actual"
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl4.Location = New System.Drawing.Point(14, 362)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(688, 52)
        Me.LabelControl4.TabIndex = 22
        Me.LabelControl4.Text = resources.GetString("LabelControl4.Text")
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
        Me.LabelControl12.Location = New System.Drawing.Point(589, 22)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl12.TabIndex = 25
        Me.LabelControl12.Text = "Valores deseado"
        '
        'icboResultado
        '
        Me.icboResultado.Location = New System.Drawing.Point(589, 41)
        Me.icboResultado.Name = "icboResultado"
        Me.icboResultado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.icboResultado.Properties.LargeImages = Me.ImageCollection1
        Me.icboResultado.Size = New System.Drawing.Size(119, 20)
        Me.icboResultado.TabIndex = 24
        '
        'teCta01
        '
        Me.teCta01.Enabled = False
        Me.teCta01.Location = New System.Drawing.Point(283, 446)
        Me.teCta01.Name = "teCta01"
        Me.teCta01.Size = New System.Drawing.Size(423, 20)
        Me.teCta01.TabIndex = 197
        '
        'beCta01
        '
        Me.beCta01.Location = New System.Drawing.Point(144, 446)
        Me.beCta01.Name = "beCta01"
        Me.beCta01.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.beCta01.Size = New System.Drawing.Size(133, 20)
        Me.beCta01.TabIndex = 195
        '
        'LblCuenta
        '
        Me.LblCuenta.Location = New System.Drawing.Point(18, 449)
        Me.LblCuenta.Name = "LblCuenta"
        Me.LblCuenta.Size = New System.Drawing.Size(120, 13)
        Me.LblCuenta.TabIndex = 196
        Me.LblCuenta.Text = "Cuenta Gasto Publicidad:"
        '
        'col_frmNivelPublicidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 529)
        Me.Name = "col_frmNivelPublicidad"
        Me.Text = "Nivel de Publicidad"
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
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icboResultado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.teCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.beCta01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents sbResultado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents teSituacionAct As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents icboResultado As DevExpress.XtraEditors.ImageComboBoxEdit
    Friend WithEvents teCta01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents beCta01 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LblCuenta As DevExpress.XtraEditors.LabelControl
End Class
