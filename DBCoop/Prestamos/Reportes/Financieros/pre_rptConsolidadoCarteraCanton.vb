Public Class pre_rptConsolidadoCarteraCanton
    Private nTotalMora As Decimal = 0.0
    Private nTotalMoraRural As Decimal = 0.0
    Private nMora As Decimal = 0.0
    Private nTotalCapital As Decimal = 0.0

    Private Sub XrLabel18_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel18.BeforePrint
        nTotalCapital = GetCurrentColumnValue("TotalSaldoCapital")
        nMora = GetCurrentColumnValue("CapitalMora")
        nTotalMoraRural = nTotalMoraRural + nMora
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

    Private Sub XrLabel50_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel50.BeforePrint
        If nTotalCapital > 0.0 Then
            XrLabel50.Text = Decimal.Round((nTotalMoraRural / nTotalCapital) * 100, 2)
        Else
            XrLabel50.Text = 0.0
        End If
        nTotalMoraRural = 0
    End Sub

    Private Sub XrLabel56_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel56.BeforePrint
        If GetCurrentColumnValue("EsRural") = False Then
            XrLabel56.Text = "URBANAS"
        Else
            XrLabel56.Text = "RURALES"
        End If
    End Sub
End Class