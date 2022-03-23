Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class col_frmPenetracionDeMercado
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim TextoArray(0) As String
    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        Me.meTexto.EditValue = "El índice de penetración de mercado, mide el nivel de participación que la Cooperativa tiene en el mercado potencial meta al cual tiene acceso, sea éste una empresa, una institución del estado, un determinado tipo de cliente o una comunidad."
    End Sub


    Private Sub col_frmPenetracionDeMercado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.GaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GaugeControl1.BackColor = Me.GroupControl1.BackColor
        Me.meTexto.EditValue = "El índice de penetración de mercado, mide el nivel de participación que la Cooperativa tiene en el mercado potencial meta al cual tiene acceso, sea éste una empresa, una institución del estado, un determinado tipo de cliente o una comunidad."
        LinearScaleComponent1.Value = 0
        Me.LinearScaleComponent1.Ranges.Clear()
        ent = bl.col_IndicadoresParametrosSelectByPK("PenetracionDeMercado")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)

        ConfigurandoIndicador()
        TextEdit1.EditValue = 0
        TextEdit2.EditValue = 0
        TextEdit3.EditValue = 0.0
    End Sub

    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        Me.meTexto.EditValue = "Si la Cooperativa opera en una institución pública, sería el número de clientes con relación al total de trabajadores.  Si la Cooperativa opera en una comunidad, sería la población económicamente activa de la comunidad con relación a los clientes activos.  Tal y como lo hemos indicado anteriormente, siendo la finalidad de la Cooperativa incidir en el nivel de vida del cliente y su comunidad, para lograrlo requiere contar con determinado peso específico dentro de esa comunidad, por lo cual se esperarían niveles elevados de penetración de mercado.  Cada Cooperativa, en función de su situación actual, sus recursos y la competencia está en capacidad de definir la penetración de mercado deseada para cada año y medirla cada mes o cada trimestre."
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

    Private Sub RadioGroup1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioGroup1.SelectedIndexChanged
        Select Case Me.RadioGroup1.EditValue
            Case 1
                Me.meTexto.EditValue = "Concentrarse en aquel mercado que efectivamente se puede atender. " + _
    "Para ello, se pueden realizar investigaciones de mercado, que permitan conocer " + _
    "las necesidades y aspiraciones de los socios potenciales e identificar dónde " + _
    "la Cooperativa puede sacar ventaja con relación a otros competidores."
            Case 2
                Me.meTexto.EditValue = "Uno de los elementos que mayor impacto produce en la membresía es la " + _
  "garantía de que la Cooperativa es gestionada con los más altos estándares de " + _
  "transparencia y honestidad.  Lo anterior es un elemento cultural en la gran " + _
  "mayoría de las cooperativas que tiene que ver con personas comprometidas con " + _
  "la causa cooperativa y con normas éticas y disciplinarias sólidas."
            Case 3
                Me.meTexto.EditValue = "Consiste en que la Cooperativa deje de atender comunidades donde no " + _
  "tiene una clara posición de mercado y privilegie aquellas donde su trabajo " + _
  "puede ser más efectivo.  La población que se deja de atender puede ser traspasada " + _
  "a otra Cooperativa para que tenga un mejor servicio o crear una nueva Cooperativa " + _
  "en esa comunidad."
            Case 4
                Me.meTexto.EditValue = "Buscar alianzas y fusiones con otras cooperativas de la comunidad, " + _
  "para fortalecer la posición de la Cooperativa resultante con relación al " + _
  "mercado que se espera atender.  Si bien esta alternativa no ha sido muy " + _
  "preferida por las cooperativas, es una opción para dar un servicio de alta " + _
  "calidad en determinadas comunidades."
            Case 5
                Me.meTexto.EditValue = "Una alternativa es la de redefinir el cliente, tanto para ampliarlo " + _
    "en casos en los que se encuentra en una situación de tope del potencial del " + _
    "mercado (éste ha sido el caso de cooperativas de profesionales que han extendido " + _
    "el vínculo al núcleo familiar), como cuando la definición del cliente no está " + _
    "facilitando la penetración del mercado, o cuando la dispersión de los clientes " + _
    "potenciales no permite avanzar."
            Case 6
                Me.meTexto.EditValue = "Hacer propios los proyectos y las aspiraciones de la comunidad, conocer " + _
  "de cerca los problemas de los diversos grupos que conforman dicha comunidad y " + _
  "volcar la capacidad de la organización al desarrollo de la misma.  Dicho vínculo " + _
  "y compromiso no necesariamente implica que la Cooperativa se involucrará " + _
  "financieramente en todos los proyectos de desarrollo que se identifiquen, sino " + _
  "que solamente los apoyará con sus capacidades"
        End Select
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As New DataTable
        dt = blIndicador.PenetracionMercado(seAnio.EditValue, meMes.EditValue)
        TextEdit1.EditValue = CInt(dt.Rows(0).Item("ClienteActivo"))
        TextEdit2.EditValue = CInt(dt.Rows(0).Item("ClienteMeta"))
        TextEdit3.EditValue = dt.Rows(0).Item("Porcentaje")
        LinearScaleComponent1.Value = dt.Rows(0).Item("Porcentaje")
    End Sub

End Class