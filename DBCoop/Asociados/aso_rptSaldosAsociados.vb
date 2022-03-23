Public Class aso_rptSaldosAsociados
    Private nNumero As Integer = 1
    Private nTotal As Decimal
    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = nNumero
        nNumero += 1
    End Sub

    Private Sub XrLabel28_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nTotal += GetCurrentColumnValue("SaldoActual")
    End Sub

    Private Sub XrLabel28_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = nTotal
        e.Handled = True
    End Sub
End Class