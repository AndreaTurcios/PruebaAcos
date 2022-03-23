Public Class pre_rptSolvenciaEconomicaDetalle
    Private nIngresos As Decimal = 0.0
    Private nGastos As Decimal = 0.0

    Private Sub xrResultado_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrResultado.SummaryGetResult
        e.Result = nIngresos - nGastos
        e.Handled = True
    End Sub

    Private Sub xrResultado_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xrResultado.SummaryRowChanged
        nIngresos += GetCurrentColumnValue("ValorIngreso")
        nGastos += GetCurrentColumnValue("ValorGasto")
    End Sub

    Private Sub xrResultado_SummaryReset(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xrResultado.SummaryReset
        nIngresos = 0
        nGastos = 0
    End Sub
End Class