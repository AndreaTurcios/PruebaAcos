Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class aso_frmListadoAsociadosconDescMenor
    Dim blAporta As New DBCoopBL.AportacionesBLL()

    Private Sub apo_frmListadoAsociadosActivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("1/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.adm_TiposPlanilla(lePlanilla, "--TODOS LOS TIPOS DE PLANILLAS--")
    End Sub
    Private Sub apo_frmListadoAsociadosActivos_Report_Click() Handles Me.Reporte

        If Not ceDetalle.EditValue Then
            Dim rpt As New apo_rptListadoAsociadosDesMenorEnviado
            rpt.DataSource = blAporta.rptListadoAsociadosDescMenorEnviado(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue, ceMenor.EditValue, ceDetalle.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
            rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS CON DESCUENTO MENOR AL ENVIADO A PLANILLA"
            rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text & "   TIPO DE PLANILLA:   " & lePlanilla.Text
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New pre_rptDescuentosMenoresDetalle
            rpt.DataSource = blAporta.rptListadoAsociadosDescMenorEnviado(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue, ceMenor.EditValue, ceDetalle.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
            rpt.xrlTitulo.Text = "LISTADO DE ASOCIADOS CON DESCUENTO MENOR AL ENVIADO A PLANILLA"
            rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text & "   TIPO DE PLANILLA:   " & lePlanilla.Text
            rpt.ShowPreviewDialog()
        End If

    End Sub

    Private Sub aso_frmListadoAsociadosActivos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptListadoAsociadosDescMenorEnviado(leSucursal.EditValue, lePlanilla.EditValue, deDesde.EditValue, deHasta.EditValue, ceMenor.EditValue, ceDetalle.EditValue), "")
    End Sub
End Class
