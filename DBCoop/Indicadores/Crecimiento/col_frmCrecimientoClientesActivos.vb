Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System
Public Class col_frmCrecimientoClientesActivos
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Es prudente que la Cooperativa tenga un crecimiento sostenido " + _
"de la membresía, puesto que a partir de ella se va a generar una serie " + _
"de operaciones que darán por resultado el desarrollo integral de la misma."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("CrecimientoDeClientesActivos")
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
        Dim valor As Decimal
        valor = blIndicador.CrecimientoClientesActivo(seAnio.EditValue, meMes.EditValue)
        teSituacionAct.EditValue = valor
        LinearScaleComponent1.Value = valor
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Concentrarse en aquel mercado que efectivamente se puede atender. " + _
  "Para ello, se pueden realizar investigaciones de mercado, que permitan " + _
  "conocer las necesidades y aspiraciones de los socios potenciales."
            Case 2
                meTexto.EditValue = "Uno de los elementos que mayor impacto produce en la membresía es " + _
  "la gargantía de que la Cooperativa es gestionada con los más altos estándares " + _
  "de transparencia y honestidad.  Lo anterior es un elemento cultural en la gran " + _
  "mayoría de las cooperativas que tiene que ver con personas comprometidas con " + _
  "la causa y con normas éticas y disciplinarias sólidas."
            Case 3
                meTexto.EditValue = "Buscar alianzas y fusiones con otras cooperatiavs de la comunidad.  " + _
  "Si bien esta alternativa no ha sido muy preferida por las cooperativas, es " + _
  "una opción para dar un servicio de alta calidad en determinadas comunidades."
            Case 4
                meTexto.EditValue = "Una alternativa es la de redefinir el asociado, tanto para ampliarlo " + _
  "en casos en los que se encuentra en una situación de tope del potencial del " + _
  "mercado (éste ha sido el caso de cooperativas de profesionales que han " + _
  "extendido el vínculo al núcleo familiar), como cuando la definición del " + _
  "asociado no está facilitando la penetración del mercado, o cuando la " + _
  "dispersión de los asociados potenciales no permite avanzar."
            Case 5
                meTexto.EditValue = ""

        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El crecimiento de la membresía conlleva a la captación " + _
"de más recursos de capital, a través de las aportaciones y " + _
"depósitos; de igual forma, implica la prestación de más servicios " + _
"crediticios, por lo cual la necesidad de capital de la Cooperativa " + _
"aumentará significativamente." + Chr(13) + "Se precisa determinar el tipo de " + _
"vínculo: abierta, cerrada o gremial, a fin de definir la población " + _
"de asociados potenciales que posee, a aquellos que están dentro del " + _
"vínculo, pero que no forman parte de la Cooperativa, y a partir de " + _
"allí, definir el crecimiento producto de las nuevas captaciones " + _
"de asociados por mes y por año." + Chr(13) + "No existe una fórmula que permita " + _
"saber qué  tamaño de organización es el más eficiente, pero sí hay " + _
"evidencias de que las cooperativas deben alcanzar un determinado " + _
"tamaño para operar con eficiencia y tener impacto en la comunidad; " + _
"de ahí la necesidad de que crezcan en asociados y negocios."
    End Sub
End Class