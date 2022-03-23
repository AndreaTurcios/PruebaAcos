Public Class pre_rptHistorialPrestamos
    Private nNumero As Integer = 1

    Private Sub XrLabel33_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel33.BeforePrint
        XrLabel33.Text = nNumero
        nNumero += 1
    End Sub
End Class