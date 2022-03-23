Public Class pre_rptInformeAseguradoraAportacion
    Private nNumero As Integer = 1
    Private Sub XrLabel2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        XrLabel2.Text = nNumero
        nNumero += 1
    End Sub
End Class