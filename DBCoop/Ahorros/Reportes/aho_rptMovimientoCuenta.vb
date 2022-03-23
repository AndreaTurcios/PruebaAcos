Public Class aho_rptMovimientoCuenta
    Private nTotalDepositos As Decimal
    Private nTotalRetiros As Decimal
    Private nTotalInteres As Decimal
    Private Sub XrLabel27_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles XrLabel27.SummaryRowChanged
        nTotalDepositos += GetCurrentColumnValue("Deposito")
    End Sub

    Private Sub XrLabel27_SummaryGetResult(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel27.SummaryGetResult
        e.Result = nTotalDepositos
        e.Handled = True
    End Sub

    Private Sub XrLabel22_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles XrLabel22.SummaryRowChanged
        nTotalRetiros += GetCurrentColumnValue("Retiro")
    End Sub

    Private Sub XrLabel22_SummaryGetResult(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel22.SummaryGetResult
        e.Result = nTotalRetiros
        e.Handled = True
    End Sub

    Private Sub XrLabel21_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles XrLabel21.SummaryRowChanged
        nTotalInteres += GetCurrentColumnValue("Interes")
    End Sub

    Private Sub XrLabel21_SummaryGetResult(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel21.SummaryGetResult
        e.Result = nTotalInteres
        e.Handled = True
    End Sub

    Private Sub xrlCT_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCT.BeforePrint
        If GetCurrentColumnValue("CambioTasa") <> 0 Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
End Class