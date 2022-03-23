Public Class pre_rptListadoLiquidacionCaja
    Private Corr As Integer = 1
    Private nTotalPres As Decimal = 0.0

    Private Sub xrlNumero_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlNumero.BeforePrint
        xrlNumero.Text = Corr
        Corr += 1
    End Sub

    Private Sub xrlSaldoAnterior_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoAnterior.BeforePrint
        xrlSaldoAnterior.Text = GetCurrentColumnValue("SaldoAnterior")
    End Sub

    Private Sub xrlSaldoActual_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoActual.BeforePrint
        xrlSaldoActual.Text = GetCurrentColumnValue("SaldoAnterior") + GetCurrentColumnValue("FondosPeriodo") - nTotalPres
    End Sub

    Private Sub XrLabel9_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel9.BeforePrint
        nTotalPres = nTotalPres + GetCurrentColumnValue("Valor")
    End Sub

    Private Sub xrlFondosPeriodo_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlFondosPeriodo.BeforePrint
        xrlFondosPeriodo.Text = GetCurrentColumnValue("FondosPeriodo")
    End Sub
End Class