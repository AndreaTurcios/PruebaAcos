Public Class apo_rptListadoAsociadosRetirados
    Private nCorrelativo As Integer = 1
    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = nCorrelativo
        nCorrelativo += 1
    End Sub
End Class