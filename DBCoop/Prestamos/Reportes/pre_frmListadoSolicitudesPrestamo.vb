Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmListadoSolicitudesPrestamo
    Dim blPrestamo As New PrestamosBLL()


    Private Sub pre_frmListadoSolicitudesPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_EstadoSolicitud(leTipoListado, "-- TODOS LOS TIPOS DE ESTADO --")
    End Sub

    Private Sub pre_frmListadoSolicitudesPrestamo_Report_Click() Handles Me.Reporte
        If chkComparativo.EditValue = False Then
            Dim rpt As New pre_rptListadoSolicitudesPrestamo
            rpt.DataSource = blPrestamo.rptListadoSolicitudesEstado(leTipoListado.EditValue, deDesde.EditValue, deHasta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
            rpt.xrlTitulo.Text = "TIPO LISTADO : " & leTipoListado.Text
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New pre_rptSolicitudesPrestamoComparativo
            rpt.DataSource = blPrestamo.rptListadoSolicitudesComparativo(deDesde.EditValue, deHasta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub pre_frmListadoSolicitudesPrestamo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoSolicitudesComparativo(deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
