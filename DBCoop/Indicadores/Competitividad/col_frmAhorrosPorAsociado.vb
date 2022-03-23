Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmAhorrosPorAsociado
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este indicador está muy relacionado con el impacto que puede " + _
"tener la Cooperativa en sus asociados y mide cuántos ahorros tiene el asociado " + _
"en la Cooperativa (considera tanto el ahorro a la vista, los depósitos a " + _
"plazo y otros instrumentos de captación cuando los mismos sean ofrecidos " + _
"por la Cooperativa)."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("AhorrosPorAsociado")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        TextEdit1.EditValue = 0
        TextEdit2.EditValue = 0
        teSituacionAct.EditValue = 0.0
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

            '''Agregando los comentarios según los rangos (RADIOGROUP)
            'Dim rgi As New DevExpress.XtraEditors.Controls.RadioGroupItem
            'rgi.Description = TextoRango
            'rgi.Value = contadorR
            'rgResultados.Properties.Items.Add(rgi)


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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As New DataTable
        dt = blIndicador.AhorrosPorAsociado(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = CInt(dt.Rows(0).Item("Saldo"))
        TextEdit2.EditValue = CInt(dt.Rows(0).Item("ClienteAhorro"))
        teSituacionAct.EditValue = dt.Rows(0).Item("Salarios")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Salarios")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El nivel de ahorro del asociado está muy relacionado con la " + _
"confianza que deposita en la Cooperativa, con la competitividad de los " + _
"productos de ahorro de la cooperativa con relación a otros intermediarios " + _
"de la zona (seguridad, liquidez, flexibilidad, rendimiento) y con el grado " + _
"de desarrollo que como intermediario financiero ha alcanzado la Cooperativa." + Chr(13) + "A medida " + _
"que la Cooperativa aumenta la oferta de productos de ahorro, aumenta el nivel " + _
"de ahorro de los asociados, lo que le permite a la Cooperativa depender ; " + _
"menos de crédito externo y de aportaciones sociales."
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La mayoría de las Cooperativas cuenta sólo con productos " + _
  "genéricos de ahorro (ahorro a la vista y a plazo en libreta) por lo " + _
  "que una tarea inicial será aumentar sus productos, particularmente " + _
  "los de más largo plazo."
            Case 2
                meTexto.EditValue = "Las cooperativas deben mejorar las condiciones de contratación de " + _
  "los ahorros, especialmente la tasa de interés y la forma como los mismos " + _
  "se hacen líquidos."
            Case 3
                meTexto.EditValue = "La imagen es determinante en la confianza del consumidor, por " + _
  "lo que la Cooperativa debe actuar para que el asociado la vea como un " + _
  "intermediario competente, transparente, socialmente responsable " + _
  "y comprometido con el bienestar del asociado."
            Case 4
                meTexto.EditValue = "Cooperativas que logren atraer un grupo importante de " + _
  "asociados ahorradores netos, pueden tener una buena oportunidad " + _
  "de alcanzar éxito e impacto en su comunidad, razón por la que esta " + _
  "acción debe tener prioridad, siempre que no se concentren en unos " + _
  "pocos asociados."
        End Select
    End Sub
End Class