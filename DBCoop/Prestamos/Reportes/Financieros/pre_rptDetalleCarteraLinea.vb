Public Class pre_rptDetalleCarteraLinea
    Private Corr As Integer = 1

    Private Sub XrLabel2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        XrLabel2.Text = Corr
        Corr += 1
    End Sub
End Class