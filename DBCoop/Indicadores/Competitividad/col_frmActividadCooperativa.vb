Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmActividadCooperativa
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este índice muestra cuánto de los pasivos y el patrimonio es " + _
"propiedad de los asociados y la organización y cuánto está en manos " + _
"de terceros."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("ActividadCooperativa")
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
                        TextoRango = "(" + variable.Trim + " al "
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
        Valor = blIndicador.rptIndicador(52, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = round(Valor * 1, 2)
        LinearScaleComponent1.Value = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Los activos de la Cooperativa deben estar primordialmente al " + _
  "servicio del asociado.  Algunas veces las cooperativas  por comodidad " + _
  "o rentabilidad prefieren colocar sus activos en depósitos a plazo o " + _
  "inversiones financieras, y no en cartera, con lo que el asociado poco " + _
  "a poco deja de interesarse en la organización, dejando de hacer depósitos " + _
  "y de formar capital. Ante el argumento de que los asociados no solicitan " + _
  "crédito, se debe evaluar el porqué, ya que muchas veces las políticas de " + _
  "colocación de crédito no responden a las necesidades de los asociados."
            Case 2
                meTexto.EditValue = "La captación de terceros puede ser la causa de la poca actividad " + _
  "cooperativa, y ésta puede ser el resultado de criterios administrativos " + _
  "que lo facilitan.  Aunque para las cooperativas sea más cómodo captar " + _
  "grandes cantidades de dinero de personas, empresas e instituciones de " + _
  "la comunidad, esos dineros lejos de fortalecer el desarrollo de la " + _
  "organización lo debilitan, ya que introducen en la toma de decisiones " + _
  "diarias variables ajenas a la organización."
            Case 3
                meTexto.EditValue = "La Cooperativa debe considerar la reforma de estatutos que le " + _
  "permita integrar a empresas y personas que gravitan en la comunidad y " + _
  "aunque son clientes de la misma, todavía no son asociados."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "La Cooperativa nace para brindar servicios a sus asociados, así es de " + _
"esperarse que la mayoría de sus actividades las desarrolle con los asociados y " + _
"no con terceros.  Del lado del activo, el análisis se concentra en el nivel de " + _
"activos destinados a créditos con asociados (al menos el 75% del total de activos), " + _
"ya que se reconoce que la Cooperativa debe contar con depósitos en bancos para " + _
"atender sus necesidades de liquidez, de que debe contar con inversiones, " + _
"especialmente para los proyectos de integraión y que además requiere una " + _
"determinada cantidad de activos fijos.  Del lado del pasivo se considera que la " + _
"Cooperativa debe tener la menor cantidad de actividades con terceros, sean " + _
"depositantes o instituciones financieras." + Chr(13) + "Se considera que la Cooperativa requiere " + _
"endeudamiento externo para tres depósitos:  a)Liquidez, la misma se recomienda que " + _
"sea desarrollada principalmente con un sistema de liquidez cooperativo; b)Calce de " + _
"plazos, orientado a otorgar crédito a plazos más largos en el periodo medio en el " + _
"que capta; c)Nuevos servicios, orientado a ampliar la relación con asociados."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 52
        ind_frmFormulasFinancieras.cIndice = "ACTIVIDAD COOPERATIVA"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class