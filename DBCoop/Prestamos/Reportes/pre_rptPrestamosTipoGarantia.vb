Public Class pre_rptPrestamosTipoGarantia
    Private nTotalMora As Decimal = 0.0
    Private nTotalMoraLinea As Decimal = 0.0
    Private nTotalCapital As Decimal = 0.0

    Private Sub XrLabel43_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel43.BeforePrint
        nTotalCapital = GetCurrentColumnValue("TotalSaldoCapital")
        XrLabel43.Text = Decimal.Round((nTotalMoraLinea / nTotalCapital) * 100, 2)
    End Sub

    Private Sub XrLabel47_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel47.BeforePrint
        nTotalCapital = GetCurrentColumnValue("TotalSaldoCapital")
        XrLabel47.Text = Decimal.Round((nTotalMora / nTotalCapital) * 100, 2)
    End Sub

    Private Sub XrLabel41_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel41.BeforePrint
        nTotalMora = nTotalMora + GetCurrentColumnValue("CapitalMora")
        If GetCurrentColumnValue("IdLinea") <> GetPreviousColumnValue("IdLinea") Then
            nTotalMoraLinea = GetCurrentColumnValue("CapitalMora")
        Else
            nTotalMoraLinea = nTotalMoraLinea + GetCurrentColumnValue("CapitalMora")
        End If
    End Sub
End Class