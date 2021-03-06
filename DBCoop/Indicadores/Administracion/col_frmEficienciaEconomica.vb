Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmEficienciaEconomica
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "El índice de eficiencia económica mide la productividad de la " + _
"organización con relación a la masa de ingresos que se logran generar cada año."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("EficienciaEconomica")
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
        Valor = blIndicador.rptIndicador(47, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Las cuentas morosas con más de 90 días deben ser causadas en " + _
  "provisión para cuentas malas y no generan ingresos por intereses, así, " + _
  "si es posible lograr alguna recuperación ésta irá directamente al ingreso."
            Case 2
                meTexto.EditValue = "Una forma de mejorar el índice es la de contener el gasto con " + _
  "los mismos niveles de ingreso, con lo que la relación ingreso gastos se " + _
  "mejorará.  Es importante en estos casos no afectar gastos que son estratégicos, " + _
  "tanto para la operación como para el crecimiento."
            Case 3
                meTexto.EditValue = "Algunas cooperativas tienen cánones de arrendamiento, de servicios " + _
  "externos y de rendimiento de inversiones, que como no son su actividad principal " + _
  "no la consideran estratégica, pero que pueden ser de gran utilidad si se requiere " + _
  "una mayor rentabilidad.  Además, está la posibilidad de elevar las comisiones que " + _
  "se cobran por los créditos, cuando lo permiten las circunstancias y el mercado."
            Case 4
                meTexto.EditValue = "Otra alternativa de utilidad es trasladar costos a los clientes, sobre " + _
  "todo cuando se trata d costos de apertura de cuentas corrientes, de manejo de " + _
  "cuentas de débito o de tramitación y legalización de créditos.  Si bien, en muchos " + _
  "casos, la Cooperativa los asume para darle mayor servicio al asociado, si la " + _
  "rentabilidad está cayendo, todos deben contribuir en su solución."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "La eficiencia económica, es la relación de los gastos totales " + _
"entre los ingresos totales.  Esta razón nos muestra que tan racional " + _
"es la administración de la Cooperativa para hacer que los gastos que " + _
"soportan los ingresos no excedan el parámetro de aceptación." + Chr(13) + "Este " + _
"indicador se ve afectado por la estacionalidad de los ingresos y los " + _
"gastos, lo que llama a tenerse una clara política de aplicación contable " + _
"que reduzca este fenómeno." + Chr(13) + "En la eficiencia económica, las variables que " + _
"mayor peso tiene son las asociadas con los intereses que la Cooperativa " + _
"paga y recibe por su operación.  Luego, están los gastos generales y de " + _
"administración y las provisiones y reservas operativas."
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 47
        ind_frmFormulasFinancieras.cIndice = "EFICIENCIA ECONOMICA"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class