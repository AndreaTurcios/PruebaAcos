Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmPruebaAcida
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Se calcula sustrayendo aquellos activos circulantes " + _
"que no son de rápida convertibilidad en efectivo, es decir, las " + _
"cifras empleadas para el cálculo son las cuentas de caja y " + _
"banco; tales como efectivo en caja y bancos (cuentas de ahorro, " + _
"cuentas corrientes), las inversiones temporales, dadas por " + _
"depósitos a plazo y cuenta centralizada.  Estos datos se dividen " + _
"entre el total de depósitos a corto plazo (cuenta de ahorros, " + _
"corrientes y a plazo, con vencimiento menor a un año)."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("PruebaDeAcida")
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
        Valor = blIndicador.rptIndicador(43, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una alternativa es incentivar las tasas de interés " + _
  "y los demás atributos de los productos de ahorro, para captar " + _
  "más y cubrir el faltante.  Es importante en este caso que se " + _
  "procure captar a plazos largos, ya que de lo contrario se " + _
  "estaría solo posponiendo el problema."
            Case 2
                meTexto.EditValue = "Una alternativa adicional es la contratación de préstamos " + _
  "que permitan cubrir los faltantes de liquidez.  Muchas veces es " + _
  "recomendable tener los créditos pre autorizados, de tal forma que " + _
  "sólo se utilicen en caso de necesidad."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "La Cooperativa debe mantener reservas de efectivo " + _
"en caja y bancos para atender los compromisos inmediatos " + _
"como son el retiro de depósitos y de las cuentas de ahorro.  " + _
"Para ello la cooperativa debe reservar una parte de todo lo " + _
"que capta.  La liquidez inmediata se afecta por la captación " + _
"de muy corto plazo, como por la estacionalidad de los retiros, " + _
"sobre todo cuando se presentan las ocasiones como la Navidad, " + _
"el inicio de las siembras, la feria del pueblo, las vacaciones " + _
"o la entrada a clases."
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case RadioGroup1.EditValue
            Case 1
                meTexto.EditValue = "Una excelente alternativa cuando la liquidez es " + _
  "elevada, es la cancelación de operaciones, especialmente " + _
  "aquellas que tienen costos elevados."
            Case 2
                meTexto.EditValue = "Según sea el nivel de exceso de la liquidez se pueden " + _
  "establecer programas especiales de crédito que eleven el nivel " + _
  "de aprovechamiento de los recursos.  Es importante conocer cuál " + _
  "es la posición de la cooperativa en otras variables como la " + _
  "rentabilidad y demás y estar seguros de si el exceso de liquidez " + _
  "se mantendrá por un tiempo o es pasajero; si es permanente, una " + _
  "política de activación de la demanda de crédito puede ser muy " + _
  "adecuada, porque ayuda a consolidar la Cooperativa, pero si es " + _
  "temporal puede ser muy peligrosa porque a la larga, los recursos " + _
  "en exceso serán solicitados y la Cooperativa enfrentará entonces " + _
  "defectos de liquidez."
        End Select
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 43
        ind_frmFormulasFinancieras.cIndice = "PRUEBA ACIDA"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class