Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmParticipacionDeCartera
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "La cartera es el activo más importante en la Cooperativa, por lo que " + _
"este índice mide cuánto de los activos están dedicados al otorgamiento de " + _
"créditos asociados.  Se consideran todas las formas de crédito y todas las " + _
"operaciones que no hayan sido castigadas por problemas de morosidad."
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
        ent = bl.col_IndicadoresParametrosSelectByPK("ParticipacionDeCartera")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        teDato1.EditValue = 0.0
        teDato2.EditValue = 0.0
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
        Dim dt As New DataTable
        dt = blIndicador.ParticipacionCartera(seAnio.EditValue, meMes.EditValue)
        teDato1.EditValue = dt.Rows(0).Item("SaldoCapital")
        teDato2.EditValue = dt.Rows(0).Item("SaldoCuenta")
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Una de las alternativas más importantes es la de desmontar activos que " + _
  "normalmente están destinados a inversiones o activos fijos y colocarlos en " + _
  "cartera."
            Case 2
                meTexto.EditValue = "Otra alternativa es hacer los créditos más competitivos con el fin de " + _
  "mejorar la colocación.  El establecer líneas de crédito para el sector de la " + _
  "microempresa, hipotecarios o de tarjetas de crédito, son algunas de las " + _
  "alternativas."
            Case 3
                meTexto.EditValue = "Si la reducción de la participación de la cartera dentro del total de " + _
  "activos es el resultado de un crecimiento no esperado de la liquidez y si este " + _
  "crecimiento es estable, se puede comprar cartera de los asociados, manteniendo " + _
  "el mismo nivel de riesgo, pero con más operación.  Estas transacciones deben ser " + _
  "realizadas con cuidado porque, por lo general, elevan la morosidad.  Cuando el " + _
  "problema es que por razones diversas la cartera supera los niveles recomendables, " + _
  "la alternativa es vender aquella parte de la cartera que no se considera estratégica, " + _
  "o darla en garantía para una operación de crédito de corto plazo (redescuento de " + _
  "cartera."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El tamaño de la cartera de crédito depende en gran " + _
"medida de los recursos que la Cooperativa tenga para prestar, de la " + _
"capacidad de endeudamiento que posean los asociados y de las condiciones " + _
"de crédito que ofrezca la cooperativa." + Chr(13) + "Toda cooperativa tiene una demanda " + _
"natural de crédito, constituida por la demanda de crédito de sus asociados; esta " + _
"demanda la aprovechará dependiendo de la " + _
"competitividad que posea, ya que el asociado puede en muchos casos acudir a " + _
"otro intermediario financiero." + Chr(13) + "Además, la cooperativa tiene otros usos del " + _
"dinero diferentes al crédito, como las inversiones, los depósitos en otros " + _
"intermediarios financieros, y la adquisición de activos fijos." + Chr(13) + "En determinados " + _
"momentos, la Cooperativa bien puede tomar la decisión de elevar el nivel de " + _
"préstamos o bien de bajarlo para adaptarse a las circunstancias del momento, " + _
"pero debe mantener el cuidado de que sus niveles estén en torno a los niveles " + _
"antes indicados."
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