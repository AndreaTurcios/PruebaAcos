Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmRendimientoFinanciero
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este constituye un indicador clave en el desarrollo " + _
"de toda empresa, y particularmente en el desarrollo de una " + _
"cooperativa de ahorro y crédito.  El rendimiento financiero " + _
"mide el nivel de ingresos con relación al activo productivo."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        meTexto.EditValue = Definicion
        ent = bl.col_IndicadoresParametrosSelectByPK("NombreIndicador")
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
        Valor = blIndicador.rptIndicador(37, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Este indicador es sumamente dinámico y tiende a perder " + _
"efectividad cuando la Cooperativa se encuentra en una etapa de " + _
"volatilidad, sea porque los activos están creciendo muy rápidamente " + _
"o porque se están reduciendo.  Es importante en todo momento excluir " + _
"el activo no productivo, para no afectar el índice que se está calculando." + Chr(13) + _
"El rendimiento financiero es un índice sumamente útil a la hora de " + _
"analizar las políticas de fijación de tasas de interés y a la hora de " + _
"aceptar tasas para los depósitos y otras inversiones.  Constituye a la " + _
"vez un punto de corte de las inversiones, según el rendimiento que " + _
"cada una de éstas tenga.  El índice permite la comparabilidad con otros " + _
"intermediarios financieros, sobre todo en momentos de volatibilidad de las " + _
"tasas de interés, donde la Cooperativa se ve presionada por la competencia."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 37
        ind_frmFormulasFinancieras.cIndice = "RENDIMIENTO FINANCIERO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class