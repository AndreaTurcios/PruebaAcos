Public Class pre_rptTecnicoLinea
    Dim Correl As Integer = 1
    Private Sub xrlCorrel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCorrel.BeforePrint
        xrlCorrel.Text = Correl
        Correl += 1
    End Sub
End Class