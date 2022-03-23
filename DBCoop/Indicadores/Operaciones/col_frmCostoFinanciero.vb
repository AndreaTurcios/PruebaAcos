Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class col_frmCostoFinanciero
    Dim ent As New col_IndicadoresParametros
    Dim bl As New DBCoopBL.TableBusiness
    Dim blIndicador As New IndicadoresBLL()
    Dim Definicion As String = "El costo financiero es el complemento del rendimiento " + _
"financiero, en el sentido de que representa lo que cuestan los " + _
"pasivos financieros."
    Private Sub gen_frmIndicador_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        meTexto.EditValue = Definicion
        'ent = bl.col_IndicadoresParametrosSelectByPK("NombreIndicador")
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)

    End Sub

    Private Sub sbResultado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbResultado.Click
        Dim Valor As Decimal
        Valor = blIndicador.rptIndicador(38, meMes.EditValue, seAnio.EditValue, 2)
        teSituacionAct.EditValue = round(Valor * 1, 2)
    End Sub

    Private Sub sbDefinicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbDefinicion.Click
        meTexto.EditValue = Definicion
    End Sub


    Private Sub sbAfecta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAfecta.Click
        meTexto.EditValue = "El índice de costo financiero es de suma utilidad porque " + _
"permite establecer cuál es el costo de la captación que realiza la " + _
"Cooperativa, de la cual se amarra el rendimiento financiero y se " + _
"fijan las políticas con las cuales se negocian tasas de interés y " + _
"operaciones de crédito con los asociados y terceros.  El costo " + _
"financiero se ve afectado por las tendencias del mercado, donde las " + _
"cooperativas por lo general llevan desventaja con respecto a los " + _
"demás intermediarios financieros, por cuanto no tienen acceso a " + _
"recursos financieros vía instrumentos sofisticados como la titularización " + _
"de cartera, la emisión de obligaciones negociables y los mercados " + _
"internacionales."
    End Sub


    Private Sub sbVerFormula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFormula.Click
        ind_frmFormulasFinancieras.IdFormula = 38
        ind_frmFormulasFinancieras.cIndice = "COSTO FINANCIERO"
        ind_frmFormulasFinancieras.ShowDialog()
    End Sub
End Class