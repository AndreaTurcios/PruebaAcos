Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class pre_frmConsolidadoCarteraComunidad
    Dim blPrestamo As New PrestamosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()

    Private Sub pre_frmConsolidadoCarteraComunidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODOS LAS SUCURSALES")
        objCombos.coo_TiposCartera(leTipoCartera, "-- TODOS LOS TIPOS DE CARTERA --")
        rdoTipoCanton.EditValue = 1
    End Sub


    Private Sub pre_frmConsolidadoCarteraComunidad_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptConsolidadoCarteraCanton
        rpt.DataSource = blPrestamo.rptConsolidadoCarteraCanton(leSucursal.EditValue, rdoTipoCanton.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlTipoCartera.Text = leTipoCartera.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmConsolidadoCarteraComunidad_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptConsolidadoCarteraCanton(leSucursal.EditValue, rdoTipoCanton.EditValue, _
        leTipoCartera.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
    End Sub
End Class
