Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmProvisionCuentasMalas
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Se considera que en una cooperativa lo mismo que " + _
"en cualquier intermediario financiero, una parte de sus " + _
"préstamos no podrá ser recuperada y deberá ser considerada " + _
"pérdidas.  Como el proceso legal de extinción de un crédito " + _
"es lento, se establece una cuenta llamada provisión para " + _
"cuentas malas, donde se acumulan los estimados de todos " + _
"aquellos créditos que están en mora."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()

        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaProvisionMalas"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If

        ent = bl.col_IndicadoresParametrosSelectByPK("ProvisionParaCuentasMalas")
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
        dt = blIndicador.ProvisionCuentasMalas(seAnio.EditValue, meMes.EditValue)
        teDato1.EditValue = dt.Rows(0).Item("SaldoCuenta")
        teDato2.EditValue = dt.Rows(0).Item("SaldoCapital")
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La primera tarea es la de colocar bien el crédito: esto es " + _
  "tener prudencia, hacer los estudios y las investigaciones " + _
  "correspondientes, no colocar por metas de presupuesto sino " + _
  "por certeza de recuperación, no seguir las modas."
            Case 2
                meTexto.EditValue = "Una Cooperativa que tiene capacidad para cobrar es una " + _
  "cooperativa que tendrá controlada la morosidad.  Lo mejor es " + _
  "anticiparse a la morosidad y cobrar antes de que la morosidad " + _
  "se torne antigua.  En momentos de escasez de dinero, se tiende " + _
  "a utilizarlo en lo que es más urgente y en lo que más problemas " + _
  "puede resolver y el que cobra primero y mejor, por lo general es " + _
  "el único que cobra."
            Case 3
                meTexto.EditValue = "La Cooperativa debe hacerse con las mejores garantías " + _
  "que tenga el deudor, para así contar con una palanca importante " + _
  "a la hora de cobrar.  No todas las garantías de calidad son la " + _
  "casa, el negocio o la finca del asociado; en cada caso la cooperativa " + _
  "puede identificar aquello que más estima el asociado, como su prestigio, " + _
  "la recomendación crediticia y demás."
        End Select
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "Cuando un crédito entra en morosidad se despliega una " + _
"serie de decisiones en torno a la provisión y la causación de " + _
"intereses, según la antiguedad del crédito moroso.  Por lo " + _
"general, no se toma decisión alguna en créditos con morosidad " + _
"menor a 30 días, por cuanto se considera que puede ser el " + _
"resultado de morosidad friccicional, o sea que el atraso no es " + _
"la imposibilidad de pago del deudor, sino porque la respectiva " + _
"remesa no ha llegado a la contabilidad de la Cooperativa.  Si " + _
"la morosidad supera los 30 días y hasta 90 días se provisiona " + _
"el 10% de la operación, si la morosidad se ubica entre los 91 " + _
"y 180 días se provisiona el 30% del crédito y si la morosidad " + _
"supera los 180 días se provisiona el 50%.  Cuando la morosidad " + _
"llega a los 360 días se debe provisionar el 100% de la operación."
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
            blIndicador.ActualizaCuentaIndicador(beCta01.EditValue, "IdCuentaProvisionMalas")
        End If
    End Sub

End Class