Public Class pre_rptListadoAplicacionPlanilla2


    Private Sub xrlSaldoFavor2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoFavor2.BeforePrint
        If GetCurrentColumnValue("SaldoFavorFin") = 0.0 Then
            xrlSaldoFavor2.Text = ""
        End If
    End Sub

    Private Sub xrlSaldoDeudas2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoDeudas2.BeforePrint
        If GetCurrentColumnValue("SaldoDeudasFin") = 0.0 Then
            xrlSaldoDeudas2.Text = ""
        End If
    End Sub

    Private Sub xrlSaldoOtros_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        If GetCurrentColumnValue("SaldoOtros") = 0.0 Then
            ' xrlSaldoOtros.Text = ""
        End If
    End Sub


    Private Sub xrlFecha_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlFecha.BeforePrint
        xrlFecha.Text = String.Format(" {0}", FechaToString(Today, Today))
    End Sub
End Class