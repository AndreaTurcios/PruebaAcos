Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmIngresosPorEmpleados
    Dim TextoArray(0) As String
    Dim TextoArray2(0) As String
    Dim TextoArray3(0) As String
    Dim ent As New col_IndicadoresParametros
    Dim blIndicador As New IndicadoresBLL()
    Dim bl As New DBCoopBL.TableBusiness
    Dim Definicion As String = "El ingreso por empleado es un indicador que ayuda a " + _
"establecer la eficiencia con la que opera la organización, " + _
"así como la capacidad generadora de ingresos de sus trabajadores."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        Me.GaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl2.BackColor = Me.GroupControl2.BackColor
        Me.GaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl3.BackColor = Me.GroupControl3.BackColor
        meTexto.EditValue = Definicion
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        Dim dtParametro As New DataTable
        dtParametro = blIndicador.Get_CuentasIndicadores()
        beCta01.EditValue = SiEsNulo(dtParametro.Rows(0).Item("IdCuentaIngreso"), "")
        Dim entCuentas As con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        If entCuentas.Nombre <> "" Then
            teCta01.EditValue = entCuentas.Nombre
        End If
        ent = bl.col_IndicadoresParametrosSelectByPK("IngresosPorEmpleados")
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
        dt = blIndicador.IngresosPorEmpleado(seAnio.EditValue, meMes.EditValue)
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
        meTexto.EditValue = "El ingreso por empleado es una medida rápida de la productividad " + _
"del trabajo, sobre todo cuando el indicador se puede comparar con el de " + _
"otras cooperativas similares.  Además, a mayor generación de ingresos, " + _
"mayor valor agregado por empleado y mayor posibilidad de progreso económico " + _
"para todos (asociados y trabajadores)." + Chr(13) + "Las cooperativas con baja tecnificación " + _
"y automatización o con sucursales poco rentables son propensas a tener " + _
"valores mucho más bajos que aquellos que gozan de tecnología de punta."
    End Sub

    Private Sub rgCorreciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgCorreciones.SelectedIndexChanged
        Select Case rgCorreciones.EditValue
            Case 1
                meTexto.EditValue = "La primera y la mejor decisión que puede tomar una cooperativa " + _
    "es la de contar en todo momento con personal adecuado, constituido por " + _
    "personas con formación, con profesionalismo, con mística y con entrega " + _
    "para su institución.  Personas que están en la Cooperativa porque van a " + _
    "ocupar un puesto necesario y no enviadas por un directivo y que están en " + _
    "capacidad de abrigar la filosofía cooperativa."
            Case 2
                meTexto.EditValue = "Un elemento que contribuye a elevados desempeños es la adopción " + _
  "de políticas que permitan una alta motivación en el trabajo.  Para muchas " + _
  "personas la Cooperativa comienza como una alternativa desconocida y a veces " + _
  "marginal de trabajo y termina siendo su segunda casa para el resto de su vida, " + _
  "por lo que la adopción de políticas que permitan que la Cooperativa sea una forma " + _
  "de vida son consistentes con elevados estándares de productividad del trabajo."
            Case 3
                meTexto.EditValue = "Muchas empresas del sector financiero han instaurado como " + _
  "norma que de los excedentes, los trabajadores deben percibir el 15%, " + _
  "ya que consideran que han contribuido a generarlos de una forma mayor " + _
  "y diferente a lo que se genera en otra actividad económica; esto por " + _
  "cuanto las decisiones en la intermediación financiera son altamente " + _
  "delicadas y si se toman sin considerar las posteriores consecuencias " + _
  "pueden terminar en pérdidas importantes."
            Case 4
                meTexto.EditValue = "La tecnología es el factor detonante de la productividad, y " + _
  "en la intermediación financiera está cambiando tan rápidamente que no se " + _
  "puede esperar, se debe integrar nueva tecnología todos los días.  " + _
  "Además, siendo tan dinámica la actividad en una cooperativa de ahorro " + _
  "y crédito es necesario que la tecnología se extienda a toda la organización."
            Case 5
                meTexto.EditValue = "Algunas actividades se desarrollan de manera más eficiente si las ejecuta " + _
  "una empresa especializada.  El hacerlo eleva la productividad de la Cooperativa y " + _
  "también de la empresa contratada, razón por la que es una buena decisión para mantener " + _
  "elevados índices de desempeño del recurso humano."

        End Select
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
            blIndicador.ActualizaCuentaIndicador(beCta01.EditValue, "IdCuentaIngreso")
        End If
    End Sub

End Class