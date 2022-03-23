Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmEquiposTecnologicos
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este indicador relaciona el monto del equipo de " + _
"tecnología con respecto al total de activo fijo neto."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("EquiposTecnologicos")
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
        Valor = blIndicador.rptIndicador(51, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una forma de corregir desviaciones en tecnología es " + _
  "la de compararse con otros intermediarios financieros, " + _
  "procurando que la inversión se mantenga a su mismo nivel."
            Case 2
                meTexto.EditValue = "La planificacion del desarrollo tecnológico a lo largo " + _
  "de un periodo de tiempo como de cinco años, permite visualizar " + _
  "más claramente la demanda futura de tecnología."
            Case 3
                meTexto.EditValue = "La tecnología no puede ser vista como un gasto más o una " + _
  "inversión más; sino que tiene que verse como una inversión " + _
  "estratégica, capaz de cambiar la posición de la Cooperativa en " + _
  "el mercado.  Sólo de esa forma se aceptará el reto que representa " + _
  "la constante inversión en tecnología."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Hay que considerar que el activo fijo representa un activo " + _
"productivo, el cual no debe representar más del 5% del activo total; " + _
"debemos tener presente que el equipo tecnológico sólo representa una " + _
"parte del activo fijo; y que existen otros que absorben gran parte " + _
"del porcentaje destinado.  Sin embargo, al estar las Cooperativas " + _
"insertas dentro del sector de intermediación financiera, éstas " + _
"requieren del equipo necesario para brindar un servicio eficiente, " + _
"rápido y confiable a sus asociados, es por ello que la necesidad de " + _
"poseer tecnología apropiada es de importancia."
    End Sub


    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 51
        ind_frmFormulasFinancieras.cIndice = "EQUIPOS TECNOLOGICOS"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class