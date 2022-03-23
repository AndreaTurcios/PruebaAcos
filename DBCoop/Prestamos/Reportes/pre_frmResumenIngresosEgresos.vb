Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmResumenIngresosEgresos
    Dim blcaja As New DBCoopBL.PrestamosBLL()
    Dim funCaja As New DBCoopBL.FuncionesBLL()

    Private Sub pre_FrmResumenIngresosEgresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub pre_frmResumenIngresosEgresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        deDesde.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deHasta.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        leSucursal.EditValue = gIdSucursal
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "-- TODOS LOS CAJER@S --")
    End Sub

    Private Sub sbImprimir_Click() Handles Me.Reporte
        Dim myRpt As New pre_rptResumenIngresosEgresos
        myRpt.DataSource = blcaja.rptResumenIngresosEgresos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leCajero.EditValue)
        myRpt.DataMember = ""
        myRpt.xrlSucursal.Text = leSucursal.Text
        myRpt.xrlEmpresa.Text = gsNombre_Empresa
        myRpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        myRpt.ShowPreviewDialog()
    End Sub


    Private Sub pre_frmResumenIngresosEgresos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blcaja.rptResumenIngresosEgresos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leCajero.EditValue), "")
    End Sub
End Class
