Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoReintegros
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub aso_frmListadoReintegros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.adm_TiposPlanilla(lePlanilla, "--TODOS LOS TIPOS DE PLANILLAS--")
    End Sub
    Private Sub aso_frmListadoReintegros_Report_Click() Handles Me.Reporte
        Dim rpt As New apo_rptListadoReintegros
        rpt.DataSource = blAporta.rptListadoReintegros(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue, ceMenor.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlTitulo.Text = "LISTADO DE REINTEGROS POR PLANILLAS DE DESCUENTO"
        If ceMenor.EditValue Then
            rpt.xrlTitulo.Text = "LISTADO DE REINTEGROS POR PLANILLAS DE DESCUENTO PENDIENTES DE APLICAR"
        End If
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text & "   TIPO DE PLANILLA:   " & lePlanilla.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aso_frmListadoReintegros_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoReintegros(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue, ceMenor.EditValue), "")
    End Sub
End Class
