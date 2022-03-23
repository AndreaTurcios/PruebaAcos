Public Class aso_rptListadoAyudaFuneraria
    Private nNumero As Integer = 1


    Private Sub xrlCorrel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCorrel.BeforePrint
        xrlCorrel.Text = nNumero
        nNumero += 1
    End Sub
End Class