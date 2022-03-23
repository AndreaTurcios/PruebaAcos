Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosFacCobradasCanceladas
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmPrestamosTipoCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = Today
        deHasta.EditValue = Today
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CREDITO --")
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_Reporte() Handles Me.Reporte
        If rgOpcion.SelectedIndex = 0 Then

            Dim rpt As New pre_rptListadoPagosFacturas
            rpt.DataSource = blPrestamo.rptPrestamosFacCobradosCancelados(leLinea.EditValue, rgOpcion.SelectedIndex, deDesde.EditValue, deHasta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New pre_rptListadoPrestamosCanceladosFac
            rpt.DataSource = blPrestamo.rptPrestamosFacCobradosCancelados(leLinea.EditValue, rgOpcion.SelectedIndex, deDesde.EditValue, deHasta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub pre_frmPrestamosTipoCredito_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptPrestamosFacCobradosCancelados(leLinea.EditValue, rgOpcion.SelectedIndex, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
