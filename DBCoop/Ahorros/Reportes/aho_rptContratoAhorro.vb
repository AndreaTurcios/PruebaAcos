Public Class aho_rptContratoAhorro


    Private Sub xrlQuin_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlQuin.BeforePrint
        If GetCurrentColumnValue("TipoDescuento") = 3 Then
            xrlQuin.Text = ""
        Else
            xrlQuin.Text = "X"
        End If
    End Sub

    Private Sub xrlMen_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlMen.BeforePrint
        If GetCurrentColumnValue("TipoDescuento") = 3 Then
            xrlMen.Text = "X"
        Else
            xrlMen.Text = ""
        End If
    End Sub
End Class