Public Class pre_rptPrestamosRegistrados
    Private Corr As Integer = 1
    Private Sub XrLabel13_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCorr.BeforePrint
        xrlCorr.Text = Corr
        Corr += 1
    End Sub
End Class