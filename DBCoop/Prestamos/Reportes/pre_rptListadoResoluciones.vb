Public Class pre_rptListadoResoluciones
    Private nNumero As Integer = 1


    Private Sub XrLabel13_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel13.BeforePrint
        XrLabel13.Text = nNumero
        nNumero += 1
    End Sub
End Class