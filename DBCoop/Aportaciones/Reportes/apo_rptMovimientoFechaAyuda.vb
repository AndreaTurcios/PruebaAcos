Public Class apo_rptMovimientoFechaAyuda
    Private nTotalCargos As Decimal
    Private nTotalAbonos As Decimal




    Private Sub XrLabel27_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XrLabel27.SummaryRowChanged
        nTotalAbonos += GetCurrentColumnValue("Abono")
    End Sub

    Private Sub XrLabel27_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles XrLabel27.SummaryGetResult
        e.Result = nTotalAbonos
        e.Handled = True
    End Sub
End Class