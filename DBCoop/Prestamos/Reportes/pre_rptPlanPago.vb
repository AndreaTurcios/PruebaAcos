Public Class pre_rptPlanPago

    Private Sub xrlSeguro_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSeguro.BeforePrint
        e.Cancel = GetCurrentColumnValue("ImporteCuotaSeguro") = 0
    End Sub

    Private Sub xrlAporta_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlAporta.BeforePrint
        e.Cancel = GetCurrentColumnValue("ImporteCuotaAportacion") = 0
    End Sub

    Private Sub xrlAhorro_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlAhorro.BeforePrint
        e.Cancel = GetCurrentColumnValue("ImporteCuotaAhorro") = 0
    End Sub

    Private Sub xrlManejo_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlManejo.BeforePrint
        e.Cancel = GetCurrentColumnValue("ImporteCuotaManejo") = 0
    End Sub
End Class