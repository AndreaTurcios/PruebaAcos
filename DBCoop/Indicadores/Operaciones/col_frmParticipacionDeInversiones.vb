Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmParticipacionDeInversiones
    Dim TextoArray(0) As String
    Dim TextoArray2(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim blIndicador As New IndicadoresBLL()
    Dim bl As New DBCoopBL.TableBusiness
    Dim Definicion As String = "Este índice tiene dos formas de medirlo y las dos son relevantes para " + _
"la toma de las decisiones.  La primera es medirlo con relación a los activos " + _
"totales, lo cual mostraría cuál es el grado de desviación de recursos de la " + _
"finalidad básica que es la intermediación financiera cooperativa, y la segunda " + _
"es medirlo en función del patrimonio total de la organización, y reflejaría " + _
"cuánto de los recursos de la cooperativa está asociado a proyectos de su interés."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        Me.GaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl2.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("ParticipacionDeInversiones")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        ConfigurandoIndicador2()
    End Sub
    Sub ConfigurandoIndicador()
        LinearScaleComponent1.MinValue = ent.ValorInicial
        LinearScaleComponent1.MaxValue = ent.ValorFinal
        LinearScaleComponent1.MajorTickCount = ent.Escala


        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos.Split(";")
        Dim Rango As String
        Dim contadorR As Integer = 0
        icboResultado.Properties.Items.Clear()
        icboResultado2.Properties.Items.Clear()
        For Each Rango In Rangos
            LSR = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim VariablesRango() As String = Rango.Split("|")
            Dim variable As String
            Dim contadorV As Integer = 0
            Dim TextoRango As String = ""
            Dim TextoResultadoRango As String = ""
            LSR.Name = "Range" + contadorR.ToString.Trim
            ''Agregando los comentarios según los rangos (IMAGECOMBOBOX)
            Dim ItemLista As New DevExpress.XtraEditors.Controls.ImageComboBoxItem

            For Each variable In VariablesRango
                Select Case contadorV
                    Case 0
                        LSR.StartValue = Val(variable)
                        TextoRango = "(" + variable.Trim + " - "
                    Case 1
                        LSR.EndValue = Val(variable)
                        TextoRango += variable.Trim + ")"
                    Case 2
                        Dim Color As String = ""
                        Select Case variable
                            Case "R"
                                Color = "Color:Red"
                                ItemLista.ImageIndex = 0
                            Case "A"
                                Color = "Color:Yellow"
                                ItemLista.ImageIndex = 1
                            Case "B"
                                Color = "Color:Blue"
                                ItemLista.ImageIndex = 2
                            Case "V"
                                Color = "Color:Green"
                                ItemLista.ImageIndex = 3
                        End Select
                        LSR.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(Color)
                    Case 3
                        TextoResultadoRango = variable.Trim
                End Select
                contadorV += 1
            Next
            ''Agrengano los rangos del indicador
            Me.LinearScaleComponent1.Ranges.Add(LSR)


            ItemLista.Value = contadorR
            ItemLista.Description = TextoRango
            Me.icboResultado.Properties.Items.Add(ItemLista)
            ''Agregando el texto al array según los rangos.
            TextoArray(contadorR) = TextoResultadoRango
            contadorR += 1
            ReDim Preserve TextoArray(contadorR)
        Next
        Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 7)
    End Sub
    Private Sub icboResultado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icboResultado.SelectedIndexChanged
        If Me.icboResultado.EditValue >= 0 Then
            Me.meTexto.EditValue = TextoArray(Me.icboResultado.EditValue)
        End If
    End Sub

    Sub ConfigurandoIndicador2()
        LinearScaleComponent2.MinValue = ent.ValorInicial2
        LinearScaleComponent2.MaxValue = ent.ValorFinal2
        LinearScaleComponent2.MajorTickCount = ent.Escala2


        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos2.Split(";")
        Dim Rango As String
        Dim contadorR As Integer = 0
        For Each Rango In Rangos
            LSR = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim VariablesRango() As String = Rango.Split("|")
            Dim variable As String
            Dim contadorV As Integer = 0
            Dim TextoRango As String = ""
            Dim TextoResultadoRango As String = ""
            LSR.Name = "Range" + contadorR.ToString.Trim
            ''Agregando los comentarios según los rangos (IMAGECOMBOBOX)
            Dim ItemLista As New DevExpress.XtraEditors.Controls.ImageComboBoxItem

            For Each variable In VariablesRango
                Select Case contadorV
                    Case 0
                        LSR.StartValue = Val(variable)
                        TextoRango = "(" + variable.Trim + " - "
                    Case 1
                        LSR.EndValue = Val(variable)
                        TextoRango += variable.Trim + ")"
                    Case 2
                        Dim Color As String = ""
                        Select Case variable
                            Case "R"
                                Color = "Color:Red"
                                ItemLista.ImageIndex = 0
                            Case "A"
                                Color = "Color:Yellow"
                                ItemLista.ImageIndex = 1
                            Case "B"
                                Color = "Color:Blue"
                                ItemLista.ImageIndex = 2
                            Case "V"
                                Color = "Color:Green"
                                ItemLista.ImageIndex = 3
                        End Select
                        LSR.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(Color)
                    Case 3
                        TextoResultadoRango = variable.Trim
                End Select
                contadorV += 1
            Next
            ''Agrengano los rangos del indicador
            Me.LinearScaleComponent2.Ranges.Add(LSR)


            ItemLista.Value = contadorR
            ItemLista.Description = TextoRango
            Me.icboResultado2.Properties.Items.Add(ItemLista)
            ''Agregando el texto al array según los rangos.
            TextoArray2(contadorR) = TextoResultadoRango
            contadorR += 1
            ReDim Preserve TextoArray2(contadorR)
        Next
        Me.LinearScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 7)
    End Sub


    Private Sub sbResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbResultado1.Click
        Dim Valor As Decimal
        Valor = blIndicador.rptIndicador(33, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = round(Valor * 1, 2)
        LinearScaleComponent1.Value = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una de las alternativas es solicitar autorización de la Asamblea " + _
  "cada vez que se desea participar en una inversión Intercooperativa, de tal " + _
  "forma que los asociados sean conscientes de la decisión que se está adoptando."
            Case 2
                meTexto.EditValue = "Concentrar las inversiones en aquellas que realmente producen valor " + _
  "agregado para el asociado y que complementan los servicios financieros " + _
  "de la organización."
            Case 3
                meTexto.EditValue = "Crear reservas especiales para la realización de inversiones y " + _
  "separarlas del capital patrimonial destinado al negocio financiero.  Esto " + _
  "permite que si la inversión no resulta favorable no afecte la operación " + _
  "de la organización."
            Case 4
                meTexto.EditValue = "Crear una nueva organización que asuma el desarrollo del negocio, " + _
  "donde se constituya a su vez un nuevo capital y una nueva estructura " + _
  "de decisión y costos."
            Case 5
                meTexto.EditValue = "Otra alternativa es que la inversión se lleve al gasto y se contabilice " + _
  "como tal.  Esto es especialmente importante cuando la inversión es de mucho riesgo, " + _
  "o totalmente fuera del negocio de la Cooperativa."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "En algunas legislaciones, sobre todo las que regulan la operación de las " + _
"cooperativas, se procura que este rubro tenga el menor valor posible, ya que se " + _
"estima que las cooperativas de ahorro y crédito deben estar dedicadas de manera " + _
"exclusiva a la actividad de intermediación financiera con sus asociados.  En " + _
"otras, se considera que la desviación de patrimonio a inversiones no debe ser " + _
"superior al 25% del patimonio de la organización, considerándose que el restante " + _
"75% debe estar respaldando precisamente la actividad de intermediación." + Chr(13) + "Se considera, " + _
"sin embargo, que las inversiones son necesarias y relevantes en el diario quehacer " + _
"de la Cooperativa, por cuanto permiten la profundización del sistema cooperativo. " + _
"Así, las cooperativas deben realizar aportes sociales en sus organismos de " + _
"integración nacional e internacional y deben invertir en sus empresas."
    End Sub

    Private Sub icboResultado2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icboResultado2.SelectedIndexChanged
        If Me.icboResultado2.EditValue >= 0 Then
            Me.meTexto.EditValue = TextoArray(Me.icboResultado2.EditValue)
        End If
    End Sub

    Private Sub sbVerFormula1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula1.Click
        ind_frmFormulasFinancieras.IdFormula = 33
        ind_frmFormulasFinancieras.cIndice = "PARTICIPACION DE INVERSIONES ACTIVOS"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub

    Private Sub sbVerFormula2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula2.Click
        ind_frmFormulasFinancieras.IdFormula = 34
        ind_frmFormulasFinancieras.cIndice = "PARTICIPACION DE INVERSIONES PATRIMONIO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub

    Private Sub sbResultado2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbResultado2.Click
        Dim Valor As Decimal
        Valor = blIndicador.rptIndicador(34, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct2.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent2.Value = Round(Valor * 1, 2)
    End Sub
End Class