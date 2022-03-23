Public Class apo_rptEstadoCuentaAportacion
    Private nTotalCargos As Decimal
    Private nTotalAbonos As Decimal
    Private Sub XrLabel28_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XrLabel28.SummaryRowChanged
        nTotalCargos += GetCurrentColumnValue("Cargo")
    End Sub

    Private Sub XrLabel28_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel28.SummaryGetResult
        e.Result = nTotalCargos
        e.Handled = True
    End Sub

    Private Sub XrLabel27_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XrLabel27.SummaryRowChanged
        nTotalAbonos += GetCurrentColumnValue("Abono")
    End Sub

    Private Sub XrLabel27_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel27.SummaryGetResult
        e.Result = nTotalAbonos
        e.Handled = True
    End Sub
End Class