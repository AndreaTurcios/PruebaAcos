Public Class pre_rptDetalleTecnicoClasificacion
    Private nTotalMora As Decimal = 0.0
    Private nTotalCapital As Decimal = 0.0, Corr As Integer = 1

    Private Sub XrLabel47_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel47.BeforePrint
        nTotalCapital = GetCurrentColumnValue("TotalSaldoCapital")
        If nTotalCapital > 0.0 Then
            XrLabel47.Text = Decimal.Round((nTotalMora / nTotalCapital) * 100, 2)
        Else
            XrLabel47.Text = 0.0
        End If
    End Sub

    Private Sub XrLabel37_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel37.BeforePrint
        nTotalMora += GetCurrentColumnValue("CapitalMora")
    End Sub

    Private Sub XrLabel2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        XrLabel2.Text = Corr
        Corr += 1
    End Sub

End Class