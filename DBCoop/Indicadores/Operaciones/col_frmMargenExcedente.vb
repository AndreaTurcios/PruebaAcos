Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmMargenExcedente
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Mide la relación entre los ingresos totales y el gasto " + _
"total, llevando el resultado a compararlo con el ingreso total, " + _
"de tal forma que se pueda mirar si la organización está mostrando " + _
"ganancias o pérdidas y qué nivel tienen éstas."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("MargenDeExcedente")
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
        Valor = blIndicador.rptIndicador(39, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Éstos deben estar adecuadamente presupuestados y en " + _
  "dimensión con el tamaño de la Cooperativa.  Si la actividad " + _
  "económica se contrae, éstos deben hacerlo también.  Cuando la " + _
  "cooperativa crece es cuando más cuidado debe tener con los " + _
  "gastos, porque lo esperado es que crezca en productividad y no " + _
  "en costos."
            Case 2
                meTexto.EditValue = "Algunas cooperativas cuentan con la posibilidad de " + _
  "generar más ingresos vía la prestación de otros servicios, como " + _
  "el arriendo parcial de oficinas, la cobranza de recibos de " + _
  "servicios públicos."
            Case 3
                meTexto.EditValue = "Las cooperativas deben estar a su vez en la capacidad " + _
  "de desprenderse de todas aquellas actividades que no están " + _
  "directamente relacionadas con la prestación de servicios de " + _
  "intermediación financiera."
            Case 4
                meTexto.EditValue = "A su vez, se debe prestar atención a políticas y acuerdos " + _
  "que se establecieron para épocas de utilidades, pero que no tienen " + _
  "sentido en épocas de crisis, tales como los montos de las dietas " + _
  "de reunión, subsidios para estudios, pago de hora extra y otros " + _
  "similares."
            Case 5
                meTexto.EditValue = "Algunas cooperativas prestan servicios sociales sumamente " + _
  "valiosos para la comunidad, pero lo hacen con pérdidas, lo que " + _
  "afecta el desempeño de la organización.  Lo ideal es fijar el " + _
  "precio adecuado por dichos servicios y disponer a la par de un " + _
  "sistema de becas o subsidios, los que se brindan si existen las " + _
  "condiciones económicas."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Toda Coopearativa debe mantener un margen de excente positivo " + _
"para su buena marcha y éste debe ser de tal tamaño que permita una " + _
"adecuada remuneración de los aportes sociales, el crecimiento de patrimonio " + _
"institucional y el desarrollo de la labor de educación y bienestar social. " + _
"Por lo anterior, este índice es considerado también un índice de alerta " + _
"temprana." + Chr(13) + "Como el índice constituye en sí un resumen de su gestión, el control " + _
"del mismo es a su vez el control de todas las variables en la organización." + Chr(13) + _
"Cuando una Cooperativa aplica las Normas Internacionales de Contabilidad " + _
"(conocidas como NIC's), sus ingresos estacionales, tales como comisiones " + _
"por préstamos se ven bastante normalizados, con lo que la calidad del índice " + _
"aumenta." + Chr(13) + "Es un índice que se ve muy afectado a la vez por la estacionalidad " + _
"de los ingresos y gastos, por lo que su estilo debe ser concebido a partir  " + _
"de varios meses y no de un mes en particular."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 39
        ind_frmFormulasFinancieras.cIndice = "MARGEN DE EXCEDENTE"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class