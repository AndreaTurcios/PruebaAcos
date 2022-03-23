Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmListadoPagosLinea
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmListadoPagosLinea_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES --")
        objCombos.coo_Tecnicos(leTecnico, "-- TODOS LOS TECNICOS --")
        objCombos.coo_Lineas(leLinea, "-- TODAS LAS LINEAS DE CRÉDITO --")
        objCombos.coo_FormasPagoCaja(cboForma, "-- TODOS LAS FORMAS DE PAGO --")
    End Sub

    Private Sub pre_frmListadoPagosLinea_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptListadoPagosLinea
        rpt.DataSource = blPrestamo.rptListadoPagosLinea(leSucursal.EditValue, leTecnico.EditValue, _
        leLinea.EditValue, cboForma.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlTecnico.Text = leTecnico.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoPagosLinea_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoPagosLinea(leSucursal.EditValue, leTecnico.EditValue, _
        leLinea.EditValue, cboForma.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub
End Class
