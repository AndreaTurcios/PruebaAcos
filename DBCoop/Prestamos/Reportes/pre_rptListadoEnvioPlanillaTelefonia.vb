Public Class pre_rptListadoEnvioPlanillaTelefonia
    Private nNumero As Integer = 1

    Private Sub xrlCorre_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCorre.BeforePrint
        xrlCorre.Text = nNumero
        nNumero += 1
    End Sub
End Class