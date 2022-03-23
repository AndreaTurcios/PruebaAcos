Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmRentabilidadActivoROA
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "La rentabilidad del activo es un índice altamente utilizado " + _
"en la mayoría de las empresas, sobre todo cuando se están realizando " + _
"estudios de factibilidad.  Si bien su utilidad ha quedado un tanto " + _
"relegada, particularmente cuando se hacen análisis de coyuntura " + _
"financiera, se consideran útiles para la comparabilidad con otras " + _
"empresas del mismo ramo."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("RentabilidadDelActivo(ROA)")
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
        Valor = blIndicador.rptIndicador(40, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = round(Valor * 1, 2)
        LinearScaleComponent1.Value = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La fijación de metas le impone retos a los administradores, " + _
  "los que en el esfuerzo por lograrlos llegan a utilizar de manera " + _
  "eficiente los recursos, siempre que se trate de metas realistas (de " + _
  "lo contrario se puede tornar temerarios).  Una de esas metas es " + _
  "lograr una rentabilidad acorde con las demás cooperativas del sector, " + _
  "o con determinados intermediarios financieros, o bien fijar una meta " + _
  "con respecto a la devolución de rendimientos al capital."
            Case 2
                meTexto.EditValue = "Una alternativa es la de concentrar la Cooperativa en aquellas " + _
  "actividades que sean rentables, desprendiéndose de las que no lo son. " + _
  "Si la Cooperativa posee recursos para desarrollo de actividades sociales, " + _
  "deben concentrar en ellos todos los proyectos no rentables y si dichos " + _
  "productos están en desarrollo crear cuentas temporales, o negociar en " + _
  "la asamblea los costos de dicho desarrollo."
            Case 3
                meTexto.EditValue = "La otra alternativa es revisar la operación general de la " + _
  "organización y realizar los ajustes necesarios que eleven la rentabilidad, " + _
  "los que deben considerar situaciones como las de: reducir personal y cortar " + _
  "gastos, cerrar oficinas, cambiar de proveedores y de tecnología, ceder " + _
  "carteras poco rentables, y ceder asociados a otras cooperativas, cuando " + _
  "los costos de atención sean elevados."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Las cooperativas tradicionalmente no han tenido que " + _
"alcanzar una alta rentabilidad del patrimonio, por cuanto la " + _
"retribución de los aportes sociales ha sido inferior a los " + _
"que se esperan en la sociedades por acciones.   Sin embargo, " + _
"se está dando un cambio en la gestión de las organizaciones, " + _
"unido a un cambio en lo que el asociado considera una remuneración " + _
"justa de sus aportes.  Incluso algunas cooperativas están optando " + _
"por desestimular la formación de capital social, a cambio de " + _
"depósitos a plazo, con lo que aumenta la presión para una mayor " + _
"rentabilidad." + Chr(13) + "En el caso de las cooperativas, este indicador se " + _
"ve afectado por la naturaleza misma de la organización; sus costos " + _
"de gobernabilidad son substancialmente más elevados que los que " + _
"tienen las empresas privadas."
    End Sub


    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 40
        ind_frmFormulasFinancieras.cIndice = "RENTABILIDAD DEL ACTIVO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class