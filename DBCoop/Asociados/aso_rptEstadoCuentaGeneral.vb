Public Class aso_rptEstadoCuentaGeneral
    Private nTotalCargos As Decimal
    Private nTotalAbonos As Decimal
    Private Sub XrLabel28_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nTotalCargos += GetCurrentColumnValue("Cargo")
    End Sub

    Private Sub XrLabel28_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = nTotalCargos
        e.Handled = True
    End Sub

    Private Sub XrLabel27_SummaryRowChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nTotalAbonos += GetCurrentColumnValue("Abono")
    End Sub

    Private Sub XrLabel27_SummaryGetResult(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = nTotalAbonos
        e.Handled = True
    End Sub
End Class