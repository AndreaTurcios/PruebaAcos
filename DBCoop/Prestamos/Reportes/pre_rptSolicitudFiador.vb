Public Class pre_rptSolicitudFiador

    Private Sub XrLabel14_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrLabel14.BeforePrint
        XrLabel14.Text = DateDiff(DateInterval.Year, CType(GetCurrentColumnValue("FechaNacimiento"), Date), Today)
    End Sub
End Class