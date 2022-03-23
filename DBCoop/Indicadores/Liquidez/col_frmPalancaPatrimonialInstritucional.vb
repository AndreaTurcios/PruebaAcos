Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmPalancaPatrimonialInstritucional
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "El capital institucional representa la parte indivisible " + _
"del patrimonio de la Cooperativa, siendo lo que en caso de una " + _
"salida masiva de asociados quede para responder por los compromisos " + _
"adquiridos, ya que el capital social es propiedad de los asociados " + _
"y lo puede retirar en cualquier momento."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("PalancaPatrimonialInstritucional")
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
        Valor = blIndicador.rptIndicador(46, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La Cooperativa debe establecer procesos de planeación estratégica " + _
  "que le permitan visualizar la forma en la que crecerá la masa de activos " + _
  "y por ende las demandas de patrimonio.  Sabiendo los requerimientos de " + _
  "patrimonio, puede, en el período de tiempo del plan, establecer las acciones " + _
  "de capitalización necesaria, las que pueden depender de la generación de " + _
  "excedentes sólo de manera parcial.  Si la capitalización actual no es " + _
  "compatible con el crecimiento, la Cooperativa debe reconceptualizar su " + _
  "estrategia de crecimiento, unido a políticas más claras de capitalización."
            Case 2
                meTexto.EditValue = "La adecuada colocación de la cartera y su protección vía provisiones " + _
  "suficientes, facilita que el capital se mantenga estable y que la Coopertiva " + _
  "no enfrente problemas una vez que se les realice una auditoría o una evaluación " + _
  "de los reguladores o de los auditores externos.  Es importante además, que la " + _
  "Cooperativa acepte en buenos términos los bienes reposeídos, ya que existe la " + _
  "tendencia a sobre valorarlos para reflejar menos pérdidas y luego no se pueden vender."
            Case 3
                meTexto.EditValue = "La prudencia en la búsqueda de rendimiento y el conservador en el diseño " + _
  "de proceso de crecimiento y penetración de mercados, son dos condiciones necesarias " + _
  "para el éxito en la intermediación financiera.  Las crisis que se han analizado han " + _
  "reflejado como denominador común, falta de liquidez para enfrentar corridas de depósitos " + _
  "y ésta ha sido generada por la actitud temeraria con la que algunos ejecutivos enfrentaron " + _
  "el crecimiento y la rentabilidad."
        End Select
    End Sub

    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 46
        ind_frmFormulasFinancieras.cIndice = "PALANCA PATRIMONIAL INSTITUCIONAL"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class