Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmAportacionesPorAsociado
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este índice mide el nivel de aportación que en promedio han " + _
"realizado los asociados en la Cooperativa."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("AportacionesPorAsociado")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        TextEdit1.EditValue = 0
        TextEdit2.EditValue = 0
        teSituacionAct.EditValue = 0.0
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

            '''Agregando los comentarios según los rangos (RADIOGROUP)
            'Dim rgi As New DevExpress.XtraEditors.Controls.RadioGroupItem
            'rgi.Description = TextoRango
            'rgi.Value = contadorR
            'rgResultados.Properties.Items.Add(rgi)


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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As New DataTable
        dt = blIndicador.AportacionesPorAsociado(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = CInt(dt.Rows(0).Item("SaldoAportacion"))
        TextEdit2.EditValue = CInt(dt.Rows(0).Item("AsociadoActivo"))
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Las aportaciones sociales son el componente del patrimonio que " + _
"está conformado por cuentas individuales a favor de cada asociado y se " + _
"forma tanto por el aporte directo del asociado como por la capitalización " + _
"de los excedentes que le corresponden a cada asociado. En las cooperativas " + _
"cerradas e institucionales se forma por el descuento de un porcentaje del salario, " + _
"normalmente por acuerdo de asamblea (el 2%, 2.5% o 5% según sea el caso). En " + _
"las cooperativas abiertas es una contribución voluntaria.  Además, en muchas " + _
"cooperativas se acostumbra la capitalización de un porcentaje de cada crédito " + _
"que el asociado solicita.  Algunas cooperativas están optando por capitalizar " + _
"el mayor porcentaje posible de sus excedentes para que el capital social sea " + _
"principalmente institucional; sin embargo, esto no es una alternativa para las " + _
"cooperativas pequeñas o de creación más reciente, ya que las mismas generan " + _
"pocos excedentes anuales."
    End Sub

End Class