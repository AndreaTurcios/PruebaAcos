Public Class apo_rptMovimientoFechaAportacion
    Private nTotalCargos As Decimal
    Private nTotalAbonos As Decimal
    Private Sub XrLabel28_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xrlTotCargos.SummaryRowChanged
        nTotalCargos += GetCurrentColumnValue("Cargo")
    End Sub

    Private Sub XrLabel28_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrlTotCargos.SummaryGetResult
        e.Result = nTotalCargos
        e.Handled = True
    End Sub

    Private Sub XrLabel27_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xrlTotAbonos.SummaryRowChanged
        nTotalAbonos += GetCurrentColumnValue("Abono")
    End Sub

    Private Sub XrLabel27_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs) Handles xrlTotAbonos.SummaryGetResult
        e.Result = nTotalAbonos
        e.Handled = True
    End Sub
End Class