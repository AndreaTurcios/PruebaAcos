Public Class pre_rptListadoDesembolsos
    Private nNumero As Integer = 1
    Private Sub XrLabel13_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel13.BeforePrint
        If GetCurrentColumnValue("IdLinea") = GetPreviousColumnValue("IdLinea") Then
            XrLabel13.Text = nNumero
            nNumero += 1
        Else
            XrLabel13.Text = 1
            nNumero = 1
        End If
    End Sub
End Class