Public Class apo_rptListadoAsociadosSinActividad
    Private nNumero As Integer = 1
    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = nNumero
        nNumero += 1
    End Sub
End Class