Public Class aho_rptBoletaDevolucion


    Private Sub xrlContenido_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlContenido.BeforePrint
        Dim sDecimal = String.Format("{0:c}", Format(CDec(GetCurrentColumnValue("TotalRetirado")), "##,##0.00"))

        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        xrlContenido.Text = "Recibí de ACELCA DE R.L. la cantidad de "
        xrlContenido.Text += Num2Text(Int(GetCurrentColumnValue("TotalRetirado"))) & " " & sDecimal & " DÓLARES" & "  ($" & CType(GetCurrentColumnValue("TotalRetirado"), String) & ")"
        xrlContenido.Text += ", en concepto de reintegro de ahorros navideños del período que corresponde del "
        xrlContenido.Text += String.Format(" {0}", FechaToString(GetCurrentColumnValue("FechaPrimerAhorro"), GetCurrentColumnValue("FechaPrimerAhorro")))
        xrlContenido.Text += " al " & String.Format(" {0}", FechaToString(GetCurrentColumnValue("FechaUltimoAhorro"), GetCurrentColumnValue("FechaUltimoAhorro")))
        xrlContenido.Text += ", más el " & CType(GetCurrentColumnValue("TasaVigente"), String) & " % de intereses"
        xrlContenido.Text += " sobre saldos diarios según las fechas de los depósitos efectuados ya sea por descuentos"
        xrlContenido.Text += " en planilla o por abonos efectuados en efectivo, según el siguiente detalle"

        'xrlContenido2.Text = xrlContenido.Text
        ' xrlContenido3.Text = xrlContenido.Text
    End Sub

    Private Sub xrlHastaSaldos_BeforePrint_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlHastaSaldos.BeforePrint
        xrlHastaSaldos.Text = "Saldos al " + CType(GetCurrentColumnValue("Fecha"), Date)
        ' xrlHastaSaldos2.Text = "Saldos al " + CType(GetCurrentColumnValue("Fecha"), Date)
        ' xrlHastaSaldos3.Text = "Saldos al " + CType(GetCurrentColumnValue("Fecha"), Date)
    End Sub

    Private Sub xrlHastaInteres_BeforePrint_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlHastaInteres.BeforePrint
        xrlHastaInteres.Text = "(+) Intereses ( " + CType(GetCurrentColumnValue("TasaVigente"), String) + " % Sobre saldos Diarios)"
        '  xrlHastaInteres2.Text = "Intereses ( " + CType(GetCurrentColumnValue("TasaVigente"), String) + " % Sobre saldos Diarios)"
        ' xrlHastaInteres3.Text = "Intereses ( " + CType(GetCurrentColumnValue("TasaVigente"), String) + " Sobre saldos Diarios)"
    End Sub
End Class