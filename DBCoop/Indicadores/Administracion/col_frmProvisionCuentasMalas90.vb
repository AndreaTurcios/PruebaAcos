Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmProvisionCuentasMalas90
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Un indicador ajustado, es observar cuál es la " + _
"relación que existe entre la provisión para cuentas " + _
"malas y la morosidad a más de 90 días, más la morosidad " + _
"judicial, si la hay a menos de 90 días (como por ejemplo " + _
"cuando la entidad deudora ha sido declarada en quiebra."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaProvisionMalas"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If

        ent = bl.col_IndicadoresParametrosSelectByPK("ProvisionParaCuentasMalasMasDe90")
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
        Dim dt As New DataTable
        dt = blIndicador.ProvisionCuentasMalas90(seAnio.EditValue, meMes.EditValue)
        teDato1.EditValue = dt.Rows(0).Item("SaldoCuenta")
        teDato2.EditValue = dt.Rows(0).Item("CapitalMora")
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Existen en varios países de América Latina sistemas de referencia de " + _
  "crédito, que operan tanto como simple información o como seguro de crédito.  " + _
  "Al estar inscritos y ser del conocimiento del deudor, éste tendrá más cuidado " + _
  "en el manejo del crédito, porque sabe que dicha referencia es fundamental para " + _
  "nuevas operaciones."
            Case 2
                meTexto.EditValue = "El contar con una política conservadora de provisión para morosidad " + _
  "hace que los problemas se detecten desde un inicio y que las soluciones " + _
  "encontradas sean reales.  Si la Cooperativa tiene problemas de morosidad, y " + _
  "la provisiona, esto se reflejará en la rentabilidad y a su vez en la " + _
  "conciencia sobre el problema de toda la organización."
            Case 3
                meTexto.EditValue = "Una forma de atacar la cobranza de manera adecuada es tercerizándola, " + _
  "bien con la contratación de una compañía o bien con la constitución de una " + _
  "empresa de cobranzas con varias cooperativas.  Para la empresa que cobra su " + _
  "único objetivo es cobrar, mientras que para la cooperativa son muchos los " + _
  "objetivos que mantiene, debiendo en algunos casos marginar la cobranza por " + _
  "otros que considera más importantes."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Considerandose que cuando un deudor entró en " + _
"morosidad de más de 90 días es porque tiene la clara " + _
"intención o posibilidad de no pagar, este indicador " + _
"permite saber si la cooperativa está cubierta " + _
"adecuadamente, sobre todo ante una política de " + _
"distribución de excedentes, cuando pudiera ser " + _
"que los mismos no sean reales."
    End Sub
End Class