Public Class pre_rptInformeAseguradora
    Private nNumero As Integer = 1
    Private Sub XrLabel2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) 
        XrLabel2.Text = nNumero
        nNumero = nNumero + 1
    End Sub
End Class