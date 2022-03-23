Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmCrecimientoPrestamos
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Se ha determinado que el mayor activo productivo para " + _
"una Cooperativa lo representa la cartera de préstamos, es por " + _
"ello que resulta de suma importancia conocer su comportamiento; " + _
"no sólo midiendo la calidad de la cartera a través de los niveles " + _
"de morosidad y provisión, sino a través de su variación porcentual " + _
"de un periodo con respecto al otro, a fin de observar si ha existido " + _
"un crecimiento o un decrecimiento."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("CrecimientoDePrestamos")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
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


    Private Sub sbResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbResultado.Click
        Dim Valor As Decimal
        Valor = blIndicador.CrecimientoPrestamos(seAnio.EditValue, meMes.EditValue)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "El ajustar la oferta de servicios de crédito a " + _
  "las necesidades de los asociados, siempre es una buena " + _
  "medida para hacer crecer sanamente la cartera."
            Case 2
                meTexto.EditValue = "El poder comprarle a los asociados saldos de operaciones " + _
  "de crédito que tienen con otros intermediarios financieros, es a " + _
  "su vez una forma bastante sana de crecer.  El asociado se ve " + _
  "beneficiado de una cuota global un tanto más baja y la Cooperativa " + _
  "de un crecimiento de su cartera con asociados."
            Case 3
                meTexto.EditValue = "Una forma alternativa de mejorar el nivel de la cartera, " + _
  "es mejorar el nivel de la cartera, es mejorar las condiciones de " + _
  "los contratos de créditos de cara al asociado, haciendo más " + _
  "competitivo su producto.  Temas como aumentar el plazo, definir " + _
  "cupos en lugar de créditos como tal, liberar determinados trámites " + _
  "e incluso garantías, son algunas alternativas."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El crecimiento en crédito debe siempre ser cuidadoso, " + _
"ya que fuertes crecimientos en créditos por lo general son " + _
"acompañados de un crecimiento igual o más que proporcional en " + _
"la morosidad, con lo que la organización lejos de ganar pierde.  " + _
"En algunos casos la prudencia llama a reducir carteras que " + _
"presentan en ese momento riesgos mayores a los acostumbrados, lo " + _
"que debe hacerse incluso sacrificando el total de créditos.  Lo " + _
"anterior lleva a que la Cooperativa cuando desee crecer sea muy " + _
"cuidadosa de la forma de cómo lo hace, porque algunas veces se " + _
"crece atendiendo nuevas poblaciones, pero luego se llega a la " + _
"conclusión de que esas poblaciones tienen problemas de morosidad " + _
"y como el cliente es asociado a la vez, no es fácil desmontarlas " + _
"cuando así lo demanda la prudencia empresarial."
    End Sub
End Class