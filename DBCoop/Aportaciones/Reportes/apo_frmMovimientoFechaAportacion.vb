Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class apo_frmMovimientoFechaAportacion
    Dim blAporta As New AportacionesBLL()


    Private Sub apo_frmMovimientoFechaAportacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = Today
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        objCombos.coo_FormasPagoCaja(cboForma, "-- TODAS LAS FORMAS DE PAGO --")
    End Sub

    Private Sub apo_frmMovimientoFechaAportacion_Report_Click() Handles Me.Reporte

        Dim rpt As New apo_rptMovimientoFechaAportacion
        rpt.DataSource = blAporta.rptMovimientoFechaAportacion(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue, rgOpcion.SelectedIndex, cboForma.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text

        If rgOpcion.SelectedIndex = 0 Then
            rpt.xrlCargos.Visible = False
            rpt.xrlTotCargos.Visible = False
        End If
        If rgOpcion.SelectedIndex = 1 Then
            rpt.xrlAbonos.Visible = False
            rpt.xrlTotAbonos.Visible = False
        End If
        If rgOpcion.SelectedIndex = 2 Then
            rpt.xrlCargos.Visible = True
            rpt.xrlTotCargos.Visible = True
            rpt.xrlAbonos.Visible = True
            rpt.xrlTotAbonos.Visible = True
        End If

        rpt.ShowPreviewDialog()
    End Sub


    Private Sub apo_frmMovimientoFechaAportacion_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptMovimientoFechaAportacion(leSucursal.EditValue, leCentroCosto.EditValue, deDesde.EditValue, deHasta.EditValue, rgOpcion.SelectedIndex, leCentroCosto.EditValue), "")
    End Sub
End Class
