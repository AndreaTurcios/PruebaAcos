Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmPrestamosPorCliente
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este índice mide el nivel de préstamos por Asociado, " + _
"estableciendo así la capacidad de otorgar crédito que posee la " + _
"Cooperativa.  Si el crédito por Asociado se relaciona con el potencial " + _
"y la necesidad de endeudamiento del Asociado, se puede medir el impacto " + _
"de la Cooperativa en la comunidad."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("PrestamosPorClientes")
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
        dt = blIndicador.PrestamosPorCliente(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = CInt(dt.Rows(0).Item("SaldoCapital"))
        TextEdit2.EditValue = CInt(dt.Rows(0).Item("ClientePrestamo"))
        teSituacionAct.EditValue = dt.Rows(0).Item("Salarios")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Salarios")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Se debe tener la precaución de aislar de un primer análisis a los " + _
"asociados que no tienen operaciones de crédito en la Cooperativa." + Chr(13) + _
"La demanda de crédito establece por una parte las necesidades y " + _
"aspiraciones de endeudamiento de los asociados, por otra las condiciones " + _
"que establece la Cooperativa para otorgar créditos, así como la oferta " + _
"disponible en el entorno del asociados.  Además, la condición económica del " + _
"asociado y sus expectativas de futuro son condicionantes importantes de la demanda de " + _
"Crédito.  La capacidad de otorgar crédito en una Coopertiva está muy condicionado " + _
"por su disponibilidad de activos, y por el plazo de repago que pueda brindar; " + _
"éste a su vez está muy cliente con la forma como la Cooperativa se financia. " + _
"Muchas cooperativas generan captaciones vía depósitos de corto plazo, por lo " + _
"que no están en capacidad de colocar a largo plazo, limitando así su oferta de crédito."
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una medida, si el problema se genera por falta de recursos de " + _
  "crédito, es disponer de recursos que estaban destinados a otras cosas " + _
  "y colocarlos en crédito o solicitar recursos para colocarlos en crédito."
            Case 2
                meTexto.EditValue = "Analizar las condiciones de crédito, tales como tasa de interés, " + _
  "requisitos, tiempo de análisis, garantías y hacerlos más accesibles a  " + _
  "los asociados; esto no debe descuidar la calidad de los deudores de la " + _
  "Cooperativa."
            Case 3
                meTexto.EditValue = "Incorporar nuevos productos de crédito, acordes con las " + _
  "expectativas de los asociados (una investigación de mercado puede " + _
  "ser útil en este caso)."
        End Select
    End Sub
End Class