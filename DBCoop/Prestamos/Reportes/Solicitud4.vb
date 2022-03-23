Public Class Solicitud4


    Private Sub XrLabel2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlFechaIngreso.BeforePrint
        If GetCurrentColumnValue("FechaIngresoTrabajo") = "01/01/1900" Then
            xrlFechaIngreso.Text = ""
        End If
    End Sub

 
    Private Sub xrlCuotaAporta_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlCuotaAporta.BeforePrint
        If GetCurrentColumnValue("CuotaAportacion") = 0.0 Then
            xrlCuotaAporta.Text = ""
        End If
    End Sub
End Class