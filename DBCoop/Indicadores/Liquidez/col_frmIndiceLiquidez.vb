Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmIndiceLiquidez
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Por activo circulante debemos comprender los activos " + _
"que se espera se conviertan en efectivo en un periodo menor o " + _
"igual a un año, y los pasivos circulantes son aquellos que se " + _
"deben pagar dentro del ejercicio en que nos encontremos."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("IndiceDeLiquidez")
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
        Valor = blIndicador.rptIndicador(42, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub
    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Por norma general, se supone que una Cooperativa está en buena " + _
"posición para pagar sus pasivos corrientes, si su activo circulante " + _
"excede por buen margen sus pasivos circulantes." + Chr(13) + "+Dentro de las cuentas " + _
"del activo circulante las más importatnes son caja y bancos, y depositos a corto plazo, " + _
"dado que esas son las que proveen liquidez.  Dentro de las cuentas del pasivo circulante, las " + _
"cuentas más importanes son los ahorros y depósitos de corto plazo, dado " + _
"que son las que más rápidamente demandan los asociados.  Hay que considerar " + _
"que en algunas cooperativas existe la política de otorgar créditos " + _
"automáticos en función de determinados tipos de ahorro y eso debe ser " + _
"considerado a la hora de hacer un análisis porque en cierta medida, dichos " + _
"créditos constituyen un compromiso exigible."
    End Sub
    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La Cooperativa debe participar en sistemas de liquidez, ya " + _
  "que éstos permiten que ante un defecto de liquidez la organización " + _
  "tenga acceso a recursos en condiciones favorables."
            Case 2
                meTexto.EditValue = "Una de las primeras alternativas es la realización de " + _
  "activos no líquidos, los que realizados de manera ordenada " + _
  "permiten inyectarle liquidez a la organización."
            Case 3
                meTexto.EditValue = "Unido al punto anterior está la negociación de acuerdos " + _
  "de sobregiro con bancos y entidades similares.  Para ello es " + _
  "necesario concentrar los depósitos, para lograr un volumen que " + _
  "aliente la firma de dichos acuerdos."
        End Select
    End Sub
    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case RadioGroup1.EditValue
            Case 1
                meTexto.EditValue = "Otra forma de reducir los excesos de liquidez es " + _
  "disminuyendo las ventajas de los ahorros y depósitos, tales " + _
  "como bajar las tasas para que se reduzca el interés de los " + _
  "asociados en ahorrar. Es importante tener cuidado de no " + _
  "crear demasiado desestímulo y terminar después con una " + _
  "reducción excesiva."
            Case 2
                meTexto.EditValue = "Otra medida es la de realizar inversiones financieras " + _
  "sólidas, con instrumentos de buena rentabilidad y alta " + _
  "liquidez que permitan aprovechar de manera eficiente los " + _
  "recursos existentes."
        End Select

    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 42
        ind_frmFormulasFinancieras.cIndice = "INDICE DE LIQUIDEZ"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class