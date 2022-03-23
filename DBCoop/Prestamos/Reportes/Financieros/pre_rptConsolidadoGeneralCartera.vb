Public Class pre_rptConsolidadoGeneralCartera
    Private nTotalMora As Decimal = 0.0
    Private nMora As Decimal = 0.0
    Private nTotalCapital As Decimal = 0.0

    Private Sub XrLabel18_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel18.BeforePrint
        nTotalCapital = GetCurrentColumnValue("TotalSaldoCapital")
        nMora = GetCurrentColumnValue("CapitalMora")
        nTotalMora = nTotalMora + nMora
        If nTotalCapital > 0.0 Then
            XrLabel18.Text = Decimal.Round((nMora / nTotalCapital) * 100, 2)
        Else
            XrLabel18.Text = 0.0
        End If

    End Sub

    Private Sub XrLabel47_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel47.BeforePrint
        If nTotalCapital > 0.0 Then
            XrLabel47.Text = Decimal.Round((nTotalMora / nTotalCapital) * 100, 2)
        Else
            XrLabel47.Text = 0.0
        End If
    End Sub
End Class