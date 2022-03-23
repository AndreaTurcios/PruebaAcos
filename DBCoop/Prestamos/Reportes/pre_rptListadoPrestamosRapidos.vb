Public Class pre_rptListadoPrestamosRapidos
    Private Corr As Integer = 1
    Private nTotalPres As Decimal = 0.0

    Private Sub xrlNumero_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlNumero.BeforePrint
        xrlNumero.Text = Corr
        Corr += 1
    End Sub


End Class