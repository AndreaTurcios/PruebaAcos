Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmMargenContribucionSPREADFinanciero
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Constituye el margen de intermediación con el " + _
"que la organización está operando en el mercado."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("MargenDeContribucionSPREADFinanciero")
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
        Dim Valor1 As Decimal
        Valor1 = blIndicador.rptIndicador(37, meMes.EditValue, seAnio.EditValue, 2)
        teDato1.EditValue = Round(Valor1 * 1, 2)
        Dim Valor2 As Decimal
        Valor2 = blIndicador.rptIndicador(38, meMes.EditValue, seAnio.EditValue, 2)
        teDato2.EditValue = Round(Valor2 * 1, 2)
        If Valor2 <> 0 Then
            teSituacionAct.EditValue = Round(Valor1 / Valor2, 2)
            LinearScaleComponent1.Value = Round(Valor1 / Valor2, 2)
        Else
            teSituacionAct.EditValue = 0.0
            LinearScaleComponent1.Value = 0.0
        End If

    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Procure establecer productos de ahorro con los asociados, " + _
  "que por lo general son a tasas de interés más bajas que las tasas " + _
  "de interés de los préstamos, y esto se da porque los depósitos de " + _
  "los asociados por lo general son de bajos montos."
            Case 2
                meTexto.EditValue = "Unido al punto anterior, está la alternativa de inducir a los " + _
  "asociados a determinados ahorros, que una vez alcanzado cierto " + _
  "nivel, desencadenan operaciones de crédito.  Esto no sólo eleva " + _
  "los niveles de ahorro, sino que permite un pago de interéses " + _
  "menor al interés del mercado."
            Case 3
                meTexto.EditValue = "Algunos fondos de interés social son susceptibles de " + _
  "captación, por parte de las cooperativas, y si los aplican a los " + _
  "asociados, como éstos tienen un sentido de pertenencia, manejan " + _
  "niveles de morosidad inferiores a los acostumbrados en este tipo " + _
  "de fondos, con lo que la rentabilidad financiera de la Cooperativa " + _
  "puede tender a subir.  Pero se debe tener la precaución de no " + _
  "mover la Cooperativa a un segmento de mercado diferente al de sus " + _
  "asociados, con el riesgo de alta morosidad y de distorsión de los " + _
  "demás productos financieros."
            Case 4
                meTexto.EditValue = "Otra alternativa es brindar servicios de crédito para " + _
  "segmentos del mercado que son más rentables, como son las tarjetas " + _
  "de Crédito."
            Case 5
                meTexto.EditValue = "La Cooperativa debe observar las tasas de interés a las que " + _
  "capta y a las que coloca para procurar su equilibrio a lo largo del " + _
  "tiempo, ya que el problema de calce de tasas puede ser fatal para la " + _
  "viabilidad y rentabilidad de la organización.  Este problema se presenta " + _
  "sobre todo cuando las tasas de interés están bajando, y donde la Cooperativa " + _
  "cuenta con políticas rígidas o tradicionales de captación que hace que  " + _
  "sus márgenes se estrechen.  Para resolverlo se recomienda dejar claúsulas  " + _
  "que permitan la revisión periódica de las tasas de interés."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El 'Spread' financiero es un indicador de alerta temprana, que " + _
"marca el desempeño de la organización en el corto y el mediano plazo, " + _
"permitiendo que la organización alcance rentabilidad en dicho periodo. " + _
"Lo anterior es mucho más evidente por el hecho de que el desmontaje de " + _
"endeudamiento y  captaciones caras, o la formación de una cartera con " + _
"mayor margen de rentabilidad no es fácil, sobre todo cuando la cooperativa " + _
"tiene un mercado muy acotado, donde ha acostumbrado a sus asociados a " + _
"determinados costos e ingresos de intermediación, y donde no se puede " + _
"(por definición y filosofía), aprovechar mercados emergentes (nuevos) con " + _
"márgenes adicionales." + Chr(13) + "Tanto el ingreso financiero como el egreso financiero " + _
"se ven muy afectados por la calidad de los activos y los pasivos financieros, " + _
"siendo de esperarse que la Cooperativa tenga un adecuado balance en ambos.  " + _
"Sus niveles los determina el mercado y el nivel de las tasas de interés que " + _
"acostumbra cobrar para operaciones activas y pasivas y para cada tipo de " + _
"instrumento financiero.  Así, los niveles deben ser relacionados con los de " + _
"los demás actores del mercado con la corrección del riesgo de las diversas " + _
"instituciones financieras."
    End Sub


End Class