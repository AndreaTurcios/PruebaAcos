Public Class pre_rptEstadisticos

    Private nCantidad As Integer = 0
    Private nMonto As Decimal = 0.0
    Private nSaldo As Decimal = 0.0

    Private Sub XrLabel37_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel37.BeforePrint
        nCantidad += GetCurrentColumnValue("CantidadPrestamo")
    End Sub

    Private Sub XrLabel41_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel41.BeforePrint
        nMonto += GetCurrentColumnValue("MontoOtorgado")
    End Sub


    Private Sub XrLabel45_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel45.BeforePrint
        nSaldo += GetCurrentColumnValue("SaldoCapital")
    End Sub

    Private Sub XrLabel43_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel43.BeforePrint
        XrLabel43.Text = Decimal.Round(nMonto / nCantidad, 2)
    End Sub

    Private Sub XrLabel44_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel44.BeforePrint
        XrLabel44.Text = Decimal.Round(nSaldo / nCantidad, 2)
    End Sub
End Class