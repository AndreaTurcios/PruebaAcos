Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmParticipacionActivoFijo
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Es la relación que existe entre el activo fijo y el activo total " + _
"de la Cooperativa, donde el activo fijo es aquel activo que la cooperativa " + _
"tiene en uso (o sea excluye los bienes recibidos en pago)."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("ParticipacionDeActivoFijo")
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
        Valor = blIndicador.rptIndicador(35, meMes.EditValue, seAnio.EditValue, 1)
        teSituacionAct.EditValue = round(Valor * 1, 2)
        LinearScaleComponent1.Value = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una de las soluciones más efectivas para reducir el nivel de " + _
  "activos fijos es desprendiéndose de todos aquellos que no sean " + _
  "necesarios. En algunos casos la cooperativa debe incluso desprenderse " + _
  "de activos que fueron adquiridos pensando en el crecimiento, en nuevas " + _
  "oficinas, en programas sociales y otros, ya que siempre debe ser " + _
  "privilegiada la buena marcha del presente a los importantes planes del futuro."
            Case 2
                meTexto.EditValue = "Cuando se trata de sucursales y oficinas secundarias, una " + _
  "alternativa es la de arrendar instalaciones, esto reduce el nivel " + _
  "de activos y los recursos inmovilizados, a la vez que permite una " + _
  "mayor flexibilidad.  Una de las decisiones que no se recomienda es " + _
  "el arrendamiento financiero 'leasing' de equipos tecnológicos y " + _
  "equipos de transporte, ya que el mismo es atractivo cuando la empresa " + _
  "puede utilizarlo como escudo fiscal, y cuando no tiene opciones de " + _
  "financiación normales, pero en el caso de las Cooperativas no se " + _
  "gana nada con este tipo de arriendo y normalmente los costos son " + _
  "más elevados que una deuda normal."
            Case 3
                meTexto.EditValue = "La otra alternativa es establecer metas de crecimiento contándose " + _
  "con la misma cantidad de activos fijos.  En algunos casos la Cooperativa " + _
  "puede optar por suscribir convenios para compartir oficinas o ubicarse " + _
  "en sitios prestados."
            Case 4
                meTexto.EditValue = "Una alternativa a la ausencia de una sede adecuada es la de " + _
  "someter a los asociados a un régimen de capitalización que elimine " + _
  "la presión sobre los recursos para ser colocados en crédito.  En " + _
  "estos casos se debe diseñar un proyecto de edificio y éste debe ser " + _
  "adoptado por la Asamblea de asociados."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Toda Cooperativa requiere de una determinada dotación de activos para " + _
"operar.  En orden de necesidad están los equipos, el mobiliario, el equipo de " + _
"transporte y comunicaciones, las oficinas, los edificios y terrenos.  Aunque " + _
"las cooperativas al igual que otras empresas pueden obtenerlos vía 'leasing', " + _
"no se considera esta alternativa como aceptable." + Chr(13) + _
"Los activos de la cooperativa crecen en la medida en la que aumenta su volumen " + _
"de negocio, aunque no necesariamente lo hacen de manera proporcional al " + _
"crecimiento del total de activos."
    End Sub


    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 35
        ind_frmFormulasFinancieras.cIndice = "PARTICIPACION DE ACTIVO FIJO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class