Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmActivosPorEmpleados
    Dim TextoArray(0) As String
    Dim TextoArray2(0) As String
    Dim TextoArray3(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "Los activos por empleado son una muestra de la " + _
"eficiencia con la que la organización está operando, de " + _
"las capacidades técnicas a lo interno de la cooperativa " + _
"y de la tecnología de proceso de información que está utilizando."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        Me.GaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl2.BackColor = Me.GroupControl2.BackColor
        Me.GaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl3.BackColor = Me.GroupControl2.BackColor
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

        ent = bl.col_IndicadoresParametrosSelectByPK("ActivosPorEmpleados")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
        ConfigurandoIndicador()
        ConfigurandoIndicador2()
        ConfigurandoIndicador3()
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
    Sub ConfigurandoIndicador2()
        LinearScaleComponent2.MinValue = ent.ValorInicial2
        LinearScaleComponent2.MaxValue = ent.ValorFinal2
        LinearScaleComponent2.MajorTickCount = ent.Escala2


        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos2.Split(";")
        Dim Rango As String
        Dim contadorR As Integer = 0
        icboResultado2.Properties.Items.Clear()
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
            Me.LinearScaleComponent2.Ranges.Add(LSR)


            ItemLista.Value = contadorR
            ItemLista.Description = TextoRango
            Me.icboResultado2.Properties.Items.Add(ItemLista)
            ''Agregando el texto al array según los rangos.
            TextoArray2(contadorR) = TextoResultadoRango
            contadorR += 1
            ReDim Preserve TextoArray2(contadorR)
        Next
        Me.LinearScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 7)
    End Sub
    Sub ConfigurandoIndicador3()
        LinearScaleComponent3.MinValue = ent.ValorInicial3
        LinearScaleComponent3.MaxValue = ent.ValorFinal3
        LinearScaleComponent3.MajorTickCount = ent.Escala3


        Dim LSR As DevExpress.XtraGauges.Core.Model.LinearScaleRange
        Dim Rangos() As String = ent.Rangos3.Split(";")
        Dim Rango As String
        Dim contadorR As Integer = 0
        icboResultado3.Properties.Items.Clear()
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
            Me.LinearScaleComponent3.Ranges.Add(LSR)


            ItemLista.Value = contadorR
            ItemLista.Description = TextoRango
            Me.icboResultado3.Properties.Items.Add(ItemLista)
            ''Agregando el texto al array según los rangos.
            TextoArray3(contadorR) = TextoResultadoRango
            contadorR += 1
            ReDim Preserve TextoArray3(contadorR)
        Next
        Me.LinearScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 7)
    End Sub

    Private Sub sbResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbResultado.Click
        Dim dt As New DataTable
        dt = blIndicador.ActivosPorEmpleado(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = dt.Rows(0).Item("SaldoCuenta")
        TextEdit2.EditValue = dt.Rows(0).Item("NumeroEmpleados")
        teSituacionAct.EditValue = dt.Rows(0).Item("Valor")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Valor")
        LinearScaleComponent2.Value = dt.Rows(0).Item("Valor")
        LinearScaleComponent3.Value = dt.Rows(0).Item("Valor")
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub
    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "La Cooperativa reflejará diversos niveles de activo " + _
"por empleado según esté en desarrollo o consolidada, y según " + _
"el grado de tecnificación que ostente." + Chr(13) + "Si bien, existen " + _
"cooperativas desarrolladas tecnológicamente donde la media de " + _
"activos por empleado supera el millón de dólares; en nuestro " + _
"entorno se debe establecer una razón que sea acorde con el " + _
"poder adquisitivo y con el tamaño de la organización." + Chr(13) + "Cuando " + _
"la cooperativa tiene muchos empleados que trabajan tiempo " + _
"parcial, debe procurar homologarlos a un tiempo completo para " + _
"reflejar una cifra bastante exacta."
    End Sub
    Private Sub icboResultado2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icboResultado2.SelectedIndexChanged
        If Me.icboResultado2.EditValue >= 0 Then
            Me.meTexto.EditValue = TextoArray2(Me.icboResultado2.EditValue)
        End If
    End Sub
    Private Sub icboResultado3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles icboResultado3.SelectedIndexChanged
        If Me.icboResultado3.EditValue >= 0 Then
            Me.meTexto.EditValue = TextoArray3(Me.icboResultado3.EditValue)
        End If
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