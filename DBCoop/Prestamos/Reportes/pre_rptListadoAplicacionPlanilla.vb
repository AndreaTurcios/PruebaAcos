Imports DBCoopBL

Public Class pre_rptListadoAplicacionPlanilla
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()
    Private Corr As Integer = 1
    Private nTotalPres As Decimal = 0.0

    'Private Sub xrlNumero_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlNumero.BeforePrint
    '    xrlNumero.Text = Corr
    '    Corr += 1
    'End Sub



    Private Sub xrlSaldoFavor_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoFavor.BeforePrint
        If GetCurrentColumnValue("SaldoFavor") = 0.0 Then
            xrlSaldoFavor.Text = ""
        End If
    End Sub

    Private Sub xrlSaldoDeudas_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoDeudas.BeforePrint
        If GetCurrentColumnValue("SaldoDeudas") = 0.0 Then
            xrlSaldoDeudas.Text = ""
        End If
    End Sub

    Private Sub xrlSaldoOtros_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlSaldoOtros.BeforePrint
        If GetCurrentColumnValue("SaldoOtros") = 0.0 Then
            xrlSaldoOtros.Text = ""
        End If
    End Sub

    Private Sub xrlComentario_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlComentario.BeforePrint
        Dim sDecimal = String.Format("{0:c}", Format(CDec(SiEsNulo(GetCurrentColumnValue("TotalDescuento"), 0)), "##,##0.00"))
        Dim Contenido As String
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        Contenido = "Señor (a) " & GetCurrentColumnValue("NombreAsociado") & "  Ref. " & GetCurrentColumnValue("NumeroAsociado")
        Contenido += "  -  " & GetCurrentColumnValue("CentroCosto") & ", su descuento de $ " & CType(GetCurrentColumnValue("TotalDescuento"), String) & "  "
        Contenido += " (" & Num2Text(Int(SiEsNulo(GetCurrentColumnValue("TotalDescuento"), 0))) & " " & sDecimal & " DÓLARES" & " )"
        Contenido += " efectuado en planilla del  " & CType(GetCurrentColumnValue("FechaAbono"), String)
        Contenido += " ha sido aplicado de la siguiente forma:"
        xrlComentario.Text = Contenido
    End Sub

    Private Sub GroupFooter1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupFooter1.BeforePrint
        XrSubreport1.ReportSource.DataSource = blPrestamo.rptListadoAplicacionPlanilla(GetCurrentColumnValue("IdSucursal"), GetCurrentColumnValue("IdCentro"), GetCurrentColumnValue("Fecha"), GetCurrentColumnValue("FechaAbono"), GetCurrentColumnValue("IdAsociado"))
        XrSubreport1.ReportSource.DataMember = ""
    End Sub
End Class