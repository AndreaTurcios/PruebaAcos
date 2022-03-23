Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmInformeRemesas
    Dim blCaja As New PrestamosBLL()


    Private Sub pre_frmInformeRemesas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub pre_frmInformeRemesas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        deDesde.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deHasta.EditValue = deDesde.EditValue
        leSucursal.EditValue = gIdSucursal
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "-- TODOS LOS CAJER@S --")
    End Sub

    Private Sub pre_frmInformeRemesas_Reporte() Handles Me.Reporte
        Dim myRpt As New pre_rptInformeRemesas
        myRpt.DataSource = blcaja.rptInformeRemesas(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leCajero.EditValue)
        myRpt.DataMember = ""
        myRpt.xrlSucursal.Text = leSucursal.Text
        myRpt.xrlEmpresa.Text = gsNombre_Empresa
        myRpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        myRpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmIngresosEgresos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blcaja.rptInformeRemesas(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, leCajero.EditValue), "")
    End Sub
End Class
