Public Class aso_rptListadoIngresosAfiliaciones
    Private nNumero As Decimal = 1

    Private Sub XrLabel3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel3.BeforePrint
        XrLabel3.Text = nNumero
        nNumero = nNumero + 1
    End Sub
End Class