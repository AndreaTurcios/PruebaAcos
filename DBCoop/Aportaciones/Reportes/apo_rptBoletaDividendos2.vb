Public Class apo_rptBoletaDividendos2


    Private Sub xrlContenido_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        xrlContenido.Text = "Señor (a) " + SiEsNulo(GetCurrentColumnValue("Nombres"), "") + " Ref: " & SiEsNulo(GetCurrentColumnValue("NumeroAsociado"), "")
        xrlContenido.Text += ", Tenemos el agrado de comunicarle que La Cooperativa hará el reparto de excedentes, en la fecha fijada en la Asamblea General de Asociados celebrada el "
        xrlContenido.Text += String.Format(" {0}", FechaToString(GetCurrentColumnValue("FechaAsamblea"), GetCurrentColumnValue("FechaAsamblea")))
        xrlContenido.Text += ", de acuerdo con la información siguiente:"
    End Sub



    Private Sub xrlCantidadLetras_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        Dim sDecimal = String.Format("{0:c}", Format(CDec(GetCurrentColumnValue("Total")), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

        xrlCantidadLetras.Text = Num2Text(Int(GetCurrentColumnValue("Total"))) & " " & sDecimal & " DÓLARES"
    End Sub

    Private Sub xrlContenido_BeforePrint_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlContenido.BeforePrint
        xrlContenido.Text = "Señor (a) " + SiEsNulo(GetCurrentColumnValue("Nombres"), "") + " Ref: " & SiEsNulo(GetCurrentColumnValue("NumeroAsociado"), "")
        xrlContenido.Text += " " + SiEsNulo(GetCurrentColumnValue("CentroCosto"), "") + ", Tenemos el agrado de comunicarle que La Cooperativa hará el reparto de excedentes, en la fecha fijada en la Asamblea General de Asociados celebrada el "
        xrlContenido.Text += String.Format(" {0}", FechaToString(GetCurrentColumnValue("FechaAsamblea"), GetCurrentColumnValue("FechaAsamblea")))
        xrlContenido.Text += ", de acuerdo con la información siguiente:"
    End Sub

    Private Sub xrlCantidadLetras_BeforePrint_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCantidadLetras.BeforePrint
        Dim sDecimal = String.Format("{0:c}", Format(CDec(GetCurrentColumnValue("Total")), "##,##0.00"))
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

        xrlCantidadLetras.Text = Num2Text(Int(GetCurrentColumnValue("Total"))) & " " & sDecimal & " DÓLARES"
    End Sub
End Class