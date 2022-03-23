Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmCrecimientoDeActivos
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Al considerar que los activos en toda organización son las posesiones " + _
"y derechos con valor monetario que esta posee; es imprescindible que crezcan " + _
"en una proporción razonable a su entorno y a las metas trazadas."
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

        ent = bl.col_IndicadoresParametrosSelectByPK("CrecimientoDeActivos")
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
        Dim dt As New DataTable
        dt = blIndicador.CrecimientoActivos(seAnio.EditValue, meMes.EditValue)
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "Ésta es una alternativa siempre adecuada para el desarrollo " + _
  "de la Cooperativa, la que se puede lograr vía otra organización " + _
  "cooperativa, o vía otro intermediario financiero."
            Case 2
                meTexto.EditValue = "Otra alternativa es desvincular territorios pasándolos " + _
  "a una nueva organización cooperativa o a cooperativas más " + _
  "pequeñas y posesionadas en el mismo entorno."
            Case 3
                meTexto.EditValue = "Otra alternativa es la de encarecer los créditos o bajar la tasa " + _
  "de los dépositos con el ánimo de que algunos clientes decidan operar con " + _
  "otros intermediarios." + Chr(13) + "Cuando se está ante crecimientos muy pobres y negativos."
            Case 4
                meTexto.EditValue = "La primera acción que se recomienda es corregir los errores que " + _
  "han llevado a una reducción de la actividad, como pueden ser carteras " + _
  "morosas que afectan la credibilidad de la organización."
            Case 5
                meTexto.EditValue = "Otra alternativa es mejorar la empatía de la organización " + _
  "con el asociado vía estudio y sondeos de mercado."
            Case 6
                meTexto.EditValue = "Una alternativa siempre disponible es entrar en negociación " + _
  "con otras cooperativas, para lograr un mayor volumen vía la fusión o " + _
  "adquisición de negocios y asociados."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Los activos como tal son el indicador más estudiado a la " + _
"hora de evaluar el crecimiento de la organización, por cuanto es " + _
"el que más se puede comparar con el de otras empresas." + Chr(13) + "El crecimiento " + _
"de activos debe ser comparado con el crecimiento que han tenido otras " + _
"instituciones en la misma industria y sobre ella considerar si el " + _
"desempeño ha sido bueno o no.  Las metas de crecimiento de activos " + _
"deben estar también asociadas con las capacidades internas de " + _
"atención de los clientes y de manejo de mayores volúmenes de activos."
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