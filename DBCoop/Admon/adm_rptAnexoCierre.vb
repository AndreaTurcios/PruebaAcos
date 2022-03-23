Public Class adm_rptAnexoCierre
    Private nNumero As Integer = 1
    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        XrLabel3.Text = nNumero
        nNumero += 1
    End Sub
End Class