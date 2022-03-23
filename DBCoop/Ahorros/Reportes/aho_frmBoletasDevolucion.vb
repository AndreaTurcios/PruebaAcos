Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class aho_frmBoletasDevolucion
    Dim blAhorro As New DBCoopBL.AhorrosBLL()
    Dim blAdmon As New DBCoopBL.AdmonBLL()
    Dim entSucursal As adm_Sucursales, dtParam As DataTable = blAdmon.ObtieneParametros()

    Private Sub aho_frmListadoDescuentosAhorros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spAnio.EditValue = Year(Today)
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_TiposCuenta(leTipoCuenta, "")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub
    Private Sub aho_frmListadoDescuentosAhorros_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptBoletaDevolucion
        Dim dt As DataTable
        dt = blAhorro.rptBoletaDevolucionAhorro(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, spAnio.EditValue)

        If leSucursal.EditValue = -1 Then
            entSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Else
            entSucursal = objTablas.adm_SucursalesSelectByPK(leSucursal.EditValue)
        End If

        rpt.DataSource = dt
        rpt.DataMember = ""


        If dt.Rows.Count = 0 Then
            MsgBox("No existen datos para generar reporte", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        Dim HastaCapitalizacion As DateTime = dt.Rows(0).Item("FechaUltimoAhorro")
        rpt.xrlLugarFecha.Text = String.Format("{0}, {1}", entSucursal.Ciudad, FechaToString(HastaCapitalizacion, HastaCapitalizacion))
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlNombreLargo.Text = dtParam.Rows(0).Item("NombreLargo")

        rpt.xrlNota.Text = dtParam.Rows(0).Item("NotaDevolucionAhorro")

        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmListadoDescuentosAhorros_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptBoletaDevolucionAhorro(leSucursal.EditValue, leTipoCuenta.EditValue, leCentroCosto.EditValue, spAnio.EditValue), "")
    End Sub
End Class
