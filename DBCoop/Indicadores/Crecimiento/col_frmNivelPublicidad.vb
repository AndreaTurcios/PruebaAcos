Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmNivelPublicidad
    Dim TextoArray(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "La publicidad bien llevada debe verse en una cooperativa " + _
"como una acción que permite el crecimiento.  En virtud de que " + _
"ayuda a mantener a los asociados vinculados e informados sobre " + _
"las diversas actividades de la organización, así como a la opinión " + _
"publica enterada del quehacer de la Cooperativa."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaPublicidad"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If
        ent = bl.col_IndicadoresParametrosSelectByPK("NivelDePublicidad")
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
        Dim valor As Decimal
        valor = blIndicador.CrecimientoNivelPublicidad(seAnio.EditValue, meMes.EditValue)
        teSituacionAct.EditValue = valor
        LinearScaleComponent1.Value = valor
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El gasto en publicidad incluye todas aquellas cuentas que tienen " + _
"que ver con comunicación e información y que se dirigen al público en " + _
"general." + Chr(13) + "La publicidad debe enfocarse en tres grandes ejes.  En primer " + _
"lugar, en la imagen institucional, reforzando las bondades de la " + _
"Cooperativa, sus logros históricos, su forma de gobierno, los valores " + _
"éticos que la rigen, la diferencia entre la filosofía cooperativa y la " + _
"filosofía de utilidades; debe lograr que la diferencia cooperativa sea " + _
"concebida como la principal arma competitiva." + Chr(13) + "En segundo lugar, debe " + _
"enfocarse en las particularidades como intermediario financiero, destacando " + _
"las característica de sus productos y servicios financieros." + Chr(13) + "Finalmente, " + _
"debe enfocarse en la comunicación con el asociado, el que en su triple " + _
"condición de dueño, cliente e inversionista, necesita estar adecuadamente " + _
"informado para mantener el respaldo en la organización." + Chr(13) + "La publicidad no " + _
"debe estar limitada a la membresía, sino que debe abarcar a todos los formadores " + _
"de opinión, tales como la comunidad, las estructuras de gobierno y los reguladores."
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
            blIndicador.ActualizaCuentaIndicador(beCta01.EditValue, "IdCuentaPublicidad")
        End If
    End Sub

End Class