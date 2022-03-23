Public Class Solicitud2



    Private Sub xrlFecha_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrlFecha.BeforePrint
        xrlFecha.Text = Format(Today, "dd/MM/yyyy")
    End Sub
End Class