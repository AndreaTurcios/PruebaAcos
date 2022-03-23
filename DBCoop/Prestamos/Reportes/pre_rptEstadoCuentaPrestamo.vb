Public Class pre_rptEstadoCuentaPrestamo

    Private Sub XrLabel31_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel31.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel80_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel80.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 0 Or GetCurrentColumnValue("TipoAplicacion") = 1 Or GetCurrentColumnValue("TipoAplicacion") = 2 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel9_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel9.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel67_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel67.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel66_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel66.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel65_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel65.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel64_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel64.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel63_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel63.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel62_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel61_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel61.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel22_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel22.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel21_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel21.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel4_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel4.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 3 Or GetCurrentColumnValue("TipoAplicacion") = 4 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel82_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel82.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 0 Or GetCurrentColumnValue("TipoAplicacion") = 1 Or GetCurrentColumnValue("TipoAplicacion") = 2 Then
            e.Cancel = True
        End If
    End Sub

    Private Sub XrLabel83_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel83.BeforePrint
        If GetCurrentColumnValue("TipoAplicacion") = 0 Or GetCurrentColumnValue("TipoAplicacion") = 1 Or GetCurrentColumnValue("TipoAplicacion") = 2 Then
            e.Cancel = True
        End If
    End Sub
End Class