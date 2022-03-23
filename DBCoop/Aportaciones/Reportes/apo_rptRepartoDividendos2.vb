Public Class apo_rptRepartoDividendos2
    Private nNumero As Integer = 1
    Private nTotalAportacion As Decimal
    Private nTotalPagar As Decimal

    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = nNumero
        nNumero += 1
    End Sub

    Private Sub XrLabel28_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nTotalAportacion += GetCurrentColumnValue("SaldoActual")
    End Sub

    Private Sub XrLabel28_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = nTotalAportacion
        e.Handled = True
    End Sub

    Private Sub XrLabel1_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nTotalPagar += GetCurrentColumnValue("TotalPagar")
    End Sub

    Private Sub XrLabel1_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = nTotalPagar
        e.Handled = True
    End Sub
End Class