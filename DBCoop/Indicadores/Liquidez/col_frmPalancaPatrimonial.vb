Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmPalancaPatrimonial
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "La relación de capital social con el total del activo, " + _
"es conocida en muchas partes como la suficiencia de capital, " + _
"básica en la operación de todo intermediario financiero.  Se " + _
"llama palanca porque el capital social se utiliza como palanca " + _
"para levantar volúmenes superiores de pasivo. A mayor capital " + _
"social se supone que mayor es el pasivo que la organización puede " + _
"formar.  Pero igual que la imagen de una palanca, mucho pasivo " + _
"levantado con poco capital puede llevar a que la palanca se " + _
"quiebre y todo se pierda."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        meTexto.EditValue = Definicion
        ent = bl.col_IndicadoresParametrosSelectByPK("PalancaPatrimonialInstritucional")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
    End Sub
    Sub ConfigurandoIndicador()
        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos.Split(";")
        Dim Rango As String
        Dim contadorR As Integer = 0
        For Each Rango In Rangos
            LSR = New DevExpress.XtraGauges.Core.Model.LinearScaleRange
            Dim VariablesRango() As String = Rango.Split(",")
            Dim variable As String
            Dim contadorV As Integer = 0
            LSR.Name = "Range" + contadorR.ToString.Trim
            contadorR += 1
            For Each variable In VariablesRango
                Select Case contadorV
                    Case 0
                        LSR.StartValue = Val(variable)
                    Case 1
                        LSR.EndValue = Val(variable)
                    Case 2
                        Dim Color As String = ""
                        Select Case variable
                            Case "A"
                                Color = "Color:Yellow"
                            Case "R"
                                Color = "Color:Red"
                            Case "B"
                                Color = "Color:Blue"
                            Case "V"
                                Color = "Color:Green"
                        End Select
                        LSR.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject(Color)
                End Select
                contadorV += 1
            Next
        Next
    End Sub

    Private Sub sbResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbResultado.Click
        Dim Valor As Decimal
        Valor = blIndicador.rptIndicador(45, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub
    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El capital en las cooperativa se forma lentamente, " + _
"y se puede perder rápidamente, de ahí que se recomienda que " + _
"las cooperativas posean una mayor proporción de capital por " + _
"activo que otros intermediarios financieros." + Chr(13) + "El capital se " + _
"forma con las aportaciones de los asociados, y con la " + _
"capitalización de los excedentes, sea en la cuenta de los " + _
"asociados o en las reservas patrimoniales.  Se pierde bien " + _
"por el retiro masivo de asociados, o por pérdidas del ejercicio, " + _
"siendo el castigo de cuentas malas la forma más rápida como que " + _
"se pierde capital en las cooperativas." + Chr(13) + "Por lo anterior y como " + _
"el indicador está asociado a los activos totales, las cooperativas " + _
"deben controlar muy bien el crecimiento para no entrar en problemas " + _
"de insuficiencia patrimonial.  Aunque las normas de regulación " + _
"financieras prevén la adecuación de los activos a la hora de " + _
"establecer la suficiencia patrimonial, se considera que las " + _
"cooperativas no deben adecuar sus activos, sino que deben considerar " + _
"la relación simple y directa entre patrimonio y activos totales.  Lo " + _
"anterior, por cuanto la adecuación privilegia unos activos con respecto " + _
"a otros y esto puede alejar la cooperativa de su misión, ya que en muchas " + _
"comunidades son precisamente los asociados de las coopertivas los que no " + _
"están en capacidad de suscribir créditos con garantía reales, como " + _
"establece la norma." + Chr(13) + "Cuando en una cooperativa se desarrollan negocios " + _
"no financieros, la masa de activos destinados a estas actividades deben " + _
"ser descontadas del patrimonio y posteriormente realizar el cálculo del " + _
"indicador, para de esta forma reflejar un indicador homologable al de los " + _
"demás intermediarios financieros."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 45
        ind_frmFormulasFinancieras.cIndice = "PALANCA PATRIMONIAL"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class