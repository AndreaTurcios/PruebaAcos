Public Class pre_rptCantones
    Private nNumero As Integer = 1

    Private Sub XrLabel8_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel8.BeforePrint
        If GetCurrentColumnValue("IdMunicipio") = GetPreviousColumnValue("IdMunicipio") Then
            XrLabel8.Text = nNumero
            nNumero += 1
        Else
            XrLabel8.Text = 1
            nNumero = 1
        End If

    End Sub
End Class