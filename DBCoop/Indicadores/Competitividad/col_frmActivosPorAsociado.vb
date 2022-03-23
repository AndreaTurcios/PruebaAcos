Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmActivosPorAsociado
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Este indicador mide el tamaño de la Cooperativa en función a la " + _
"economía de cada asociado, siendo una medida importante para establecer " + _
"qué tan desarrollada está la Cooperativa y qué tanta significancia" + _
"puede tener en la vida del asociado."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()

        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaActivo"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If

        ent = bl.col_IndicadoresParametrosSelectByPK("ActivosPorAsociado")
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
        dt = blIndicador.ActivosPorAsociado(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = CInt(dt.Rows(0).Item("SaldoCuenta"))
        TextEdit2.EditValue = CInt(dt.Rows(0).Item("AsociadoActivo"))
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El tamaño de la cooperativa adquiere sentido cuando se relaciona " + _
"con el tamaño económico de la comunidad que atiende.  Así, se ha considerado " + _
"que la Cooperativa contará con más capacidad de servicio entre más sea su " + _
"activo por asociado." + Chr(13) + "El crecimiento de activos mejora el indicador siempre " + _
"que este crecimiento sea superior al crecimiento de asociados.  Cuando la " + _
"Cooperativa atiende a microempresarios, o a cooperativas más pequeñas, deberá " + _
"considerar este elemento, para no distorcionar las cifras. Para muchas cooperativas, " + _
"la dificultad para hacer crecer este indicador radica en la limitada oferta de " + _
"servicios financieros, ya que el asociado al no contar con los servicios " + _
"financieros que requiere, recurre a otros intermediarios. Según la riqueza de " + _
"la comunidad así deberá ser la riqueza de la cooperativa."
    End Sub

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una de las principales formas de aumento del activo es la de brindar " + _
  "mayores servicios, especialmente de crédito y ahorro."
            Case 2
                meTexto.EditValue = "Según las normas regulatorias, las cooperativas pueden tener al menos " + _
  "5 veces en activo lo que tienen en patrimonio.  Esto se puede lograr vía más " + _
  "servicios de crédito financiados  con captación o credito externo."
            Case 3
                meTexto.EditValue = "Una alternativa es la de apoyar que los asociados realicen muchas " + _
  "más actividades de las que están realizando vía el mercadeo y la búsqueda " + _
  "de servicios competitivos."
            Case 4
                meTexto.EditValue = "En algunos casos se pueden desvincular asociados que no realizan " + _
  "operaciones y que representan costos para la institución."
        End Select
    End Sub

    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        Dim entCuentas As con_Cuentas
        beCta01.EditValue = ""
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub

    Private Sub beCta01_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        Dim entCuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
        If teCta01.EditValue <> "" Then
            blIndicador.ActualizaCuentaIndicador(beCta01.EditValue, "IdCuentaActivo")
        End If
    End Sub


End Class