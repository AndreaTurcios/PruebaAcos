Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmNivelActivoImproductivo
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este indicador mide el volumen de activos improductivos con " + _
"relación al activo total, siendo una forma de observar el aprovechamiento " + _
"que posee la Cooperativa con respecto a los activos.  Cuando el volumen " + _
"de activos improductivos es muy alto se presenta un problema de eficiencia " + _
"que algunas veces incide en la fijación de las tasas de interés."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("NivelDeActivoImproductivo")
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
        Valor = blIndicador.rptIndicador(36, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = round(Valor * 1, 2)
        LinearScaleComponent1.Value = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La primera acción es fijar límites para los activos " + _
  "improductivos de tal forma que las personas involucradas en " + _
  "su gestión se vean en la necesidad de mantenerse dentro de " + _
  "dichos márgenes."
            Case 2
                meTexto.EditValue = "Si la Cooperativa tiene una alta cartera morosa o " + _
  "muchos bienes reposeídos, lo ideal es llevarlos al gasto vía " + _
  "reservas para no afectar la rentabilidad de los demás activos, " + _
  "sobre todo cuando existen excedentes de operación."
            Case 3
                meTexto.EditValue = "Una opción de gran utilidad cuando hay problemas en " + _
  "determinados activos improductivos, es reducir los demás, tales " + _
  "como los activos productivos no necesarios."
            Case 4
                meTexto.EditValue = "El crecimiento del activo sirve como controlador del " + _
  "indicador, porque si el activo crece y no se forma nuevo activo, " + _
  "improductivo bajará el indicador."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Si bien, la Cooperativa requiere contar con activos que no generan " + _
"ingresos tales como el dinero en efectivo, las cuentas por cobrar y los " + _
"activos fijos, su nivel debe mantenerse dentro de ciertos parámetros para no " + _
"afectar la productividad de la organización." + Chr(13) + "Cuando la cooperativa tiene manejos " + _
"poco rigurosos del efectivo de que dispone o cuando acumula muchos activos fijos " + _
"o bienes reposeídos, o tiene alta morosidad no provisionada, su productividad se " + _
"verá disminuida y esto se reflejará automáticamente en este indicador."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 36
        ind_frmFormulasFinancieras.cIndice = "NIVEL DE ACTIVO FIJO IMPRODUCTIVO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class