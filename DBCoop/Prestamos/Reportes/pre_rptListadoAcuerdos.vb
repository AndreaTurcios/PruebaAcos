Public Class pre_rptListadoAcuerdos
    Private nNumero As Integer = 1
    Private Sub XrLabel8_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel8.BeforePrint
        If GetCurrentColumnValue("Valor") > 0.0 Then
            XrLabel8.ForeColor = Color.Blue
        Else
            XrLabel8.ForeColor = Color.Red
        End If
    End Sub

    Private Sub XrLabel13_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel13.BeforePrint
        XrLabel13.Text = nNumero
        nNumero += 1
    End Sub
End Class