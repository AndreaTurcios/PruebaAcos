Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmCrecimientoPatrimonio
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Como política de salud financiera, el patrimonio " + _
"de la Cooperativa debe crecer siempre, tanto por aportes " + _
"de asociados como por capitalización de resultados."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaPatrimonio"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If
        ent = bl.col_IndicadoresParametrosSelectByPK("CrecimientoDePatrimonio")
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

    Private Sub sbResultado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbResultado.Click
        Dim Valor As New Decimal
        Valor = blIndicador.CrecimientoPratrimonio(seAnio.EditValue, meMes.EditValue)
        teSituacionAct.EditValue = Round(Valor * 1, 2)
        LinearScaleComponent1.Value = Round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "El contar con un instrumental para la captación de " + _
  "aportes siempre es un buen elemento para que el capital " + _
  "efectivamente crezca.  Las políticas claras ayudan en tal " + _
  "dirección, como son la de fijar montos en función del ingreso " + _
  "del asociado, o de los créditos otorgados, o cuotas mensuales."
            Case 2
                meTexto.EditValue = "Un factor fundamental para lograr capitalizaciones rápidas " + _
  "si ese fuera el caso, es la de contarse con legitimidad en las " + _
  "decisiones, sobre todo de Asamblea, ya que en algunos casos, al no " + _
  "asistir una cantidad significativa de asociados a la Asamblea, los " + _
  "acuerdos de la misma no terminan siendo vinculantes para con el asociado."
            Case 3
                meTexto.EditValue = "Un factor fundamental para lograr capitalizaciones rápidas " + _
  "si ese fuera el caso, es la de contarse con legitimidad en las " + _
  "decisiones, sobre todo de Asamblea, ya que en algunos casos, al no " + _
  "asistir una cantidad significativa de asociados a la Asamblea, los " + _
  "acuerdos de la misma no terminan siendo vinculantes para con el asociado."
            Case 4
                meTexto.EditValue = "Algunas legislaciones están permitiendo la suscripción de créditos " + _
  "subordinados, donde una parte del crédito es colocada dentro del capital " + _
  "social con el fin de aumentarlo de cara a fuertes procesos de captación de " + _
  "depósitos y de crecimiento de la organización."
            Case 5
                meTexto.EditValue = "Mantener una sana política de capitalización de una parte de los " + _
  "excedentes siempre es sano, ya que consolida el crecimiento del patrimonio, " + _
  "acostumbra al asociado a capitalizar y fortalecer las reservas patrimoniales."

        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Las Cooperativas tienen problemas para lograr un rápido " + _
"crecimiento del patrimonio, sobre todo en momentos de urgencia, " + _
"por la dispersión de aportes que poseen y la imposibilidad material " + _
"de que unos cuantos asociados o terceros hagan aportes por valores " + _
"significativos; razón por la que deben mantener una alta disciplina de " + _
"formación patrimonial.  El crecimiento del patrimonio se ve afectado " + _
"por el retiro masivo de asociados, por la presencia de pérdidas y por " + _
"el crecimiento desmedido de los activos totales."
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
            blIndicador.ActualizaCuentaIndicador(beCta01.EditValue, "IdCuentaPatrimonio")
        End If
    End Sub

End Class