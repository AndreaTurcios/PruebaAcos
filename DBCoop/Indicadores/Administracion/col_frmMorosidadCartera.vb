Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmMorosidadCartera
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "La morosidad es el indicador más estudiado para ver si " + _
"la Cooperativa está teniendo o no un buen desempeño.  " + _
"La Morosidad se mide según a norma " + _
"vigente (sea del sistema de contabilidad, o de la entidad que " + _
"supervisa la Cooperativa) y en ausencia de ésta, se considera " + _
"como morosas todas las operaciones cuyo pago tenga más de 1 día " + _
"de vencido."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("MorosidadDeCartera")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        teDato1.EditValue = 0.0
        teDato2.EditValue = 0.0
    End Sub

    Sub ConfigurandoIndicador()
        LinearScaleComponent1.MinValue = ent.ValorInicial
        LinearScaleComponent1.MaxValue = ent.ValorFinal
        LinearScaleComponent1.MajorTickCount = ent.Escala


        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos.Split(";")
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
        dt = blIndicador.MorosidadCartera(seAnio.EditValue, meMes.EditValue)
        teDato1.EditValue = CInt(dt.Rows(0).Item("CapitalMora"))
        teDato2.EditValue = CInt(dt.Rows(0).Item("SaldoCapital"))
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub


    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "La morosidad de cartera se ve muy afectada por las condiciones económicas " + _
"imperantes de las que la Cooperativa no puede ser ajena.  Así, es común que si la " + _
"morosidad se dispara para el mercado financiero, se dispare también para la " + _
"cooperativa, lo que la debe llevar a redimensionar el indicador, sin perder la " + _
"perspectiva de que el hecho de que todos estén mal no resuelve los problemas " + _
"operativos y de morosidad que la Cooperativa esté enfrentando." + Chr(13) + "La morosidad " + _
"debe ser calculada independiente de la política de provisión vigente, ya que existe " + _
"la errónea costumbre de estimar la morosidad según las cuotas vencidas, lo que da " + _
"como resultado, que préstamos que tienen más de un año de vencidos, reflejan sólo " + _
"una parte del saldo como saldo moroso, lo que tiende a desinflar la cifra de la mora, " + _
"reflejando a su vez una condición de morosidad a todas luces engañosa." + Chr(13) + "En el sistema " + _
"contable, o en sistema de estimación de la mora, es importante, considerar aquellos " + _
"días en que el pago pudo haber sido efectuado y no se ha registrado en la contabilidad " + _
"por no tenerse la información bancaria, sobre todo cuando la cooperativa tiene diversas " + _
"sucursales y diversas formas de cobro.  Por lo anterior, en algunos casos se recomienda " + _
"dejar los primeros tres o cinco días de mora fuera del cálculo." + Chr(13) + "Tan importante es " + _
"conocer cuál es el saldo de la mora como cuál es la antigüedad de los diversos créditos " + _
"morosos. Para lo anterior, es necesario preparar una tabla que divida la cartera por " + _
"categorías, oscilando de cartera 'A' que es cartera que no tiene ninguna mora, cartera " + _
"'B' con menos de 30 días de mora, cartera 'C' con 31 a 90 días de mora, cartera 'D' con " + _
"más de 91 días y menos de 180 y cartera 'E'.  La cartera con más de 360 días o que está " + _
"en proceso judicial, debe ser sacada del total de préstamos y descontar su importe de la " + _
"provisión de morosidad." + Chr(13) + "Según el tipo de cooperativa así será su morosidad, por cuanto " + _
"no es lo mismo una cooperativa que opera con descuento por nómina y que casi no tiene " + _
"morosidad a una que trabaja con el público, cuya morosidad es mucho más elevada, ya que " + _
"no controla la fuente de ingreso del deudor." + Chr(13) + "Como se puede deducir, la contabilidad no " + _
"refleja la cartera morosa, por lo que la misma debe ser obtenida de un subprograma " + _
"derivado de la misma contabilidad.  En sistemas contables eficientes, la morosidad y " + _
"la antigüedad de la misma, así como la provisión de morosidad se generan desde el " + _
"mismo sistema, sin que medie la opinión o el trabajo del departamento de crédito."
    End Sub
End Class