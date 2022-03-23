Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmRptIngresosEgresos
    Dim blCaja As New CajaBusiness()


    Private Sub frmIngresosEgresos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmIngresosEgresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        deDesde.EditValue = blCaja.GetFechaContable(gIdSucursal)
        deHasta.EditValue = deDesde.EditValue
        'leCajero.EditValue = objMenu.User
        Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        leSucursal.EditValue = entSucursal.Nombre
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        'objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "")
    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimir.Click
        Dim rpt As New rptIngresosEgresos
        rpt.DataSource = blCaja.rptIngresosEgresos(leSucursal.EditValue, deDesde.EditValue, deHasta.EditValue, objMenu.User)
        rpt.DataMember = ""
        rpt.xrlSucursal.Text = leSucursal.Text
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub
End Class