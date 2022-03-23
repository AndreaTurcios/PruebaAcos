Public Class apo_rptRetiroAsociados

    Private Sub XrLabel27_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel27.BeforePrint
        If GetCurrentColumnValue("MontoCobrar") < 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel36_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel36.BeforePrint
        If GetCurrentColumnValue("LiquidoEntregar") < 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel26_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel26.BeforePrint
        If GetCurrentColumnValue("MontoCobrar") < 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLine15_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLine15.BeforePrint
        If GetCurrentColumnValue("MontoCobrar") < 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel35_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel35.BeforePrint
        If GetCurrentColumnValue("LiquidoEntregar") < 0 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLine19_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLine19.BeforePrint
        If GetCurrentColumnValue("LiquidoEntregar") < 0 Then
            e.Cancel = True
        End If
    End Sub
End Class