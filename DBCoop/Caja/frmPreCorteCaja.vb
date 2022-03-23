Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class frmPreCorteCaja
    Dim blCaja As New PrestamosBLL

    Private Sub frmPreCorteCaja_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmPreCorteCaja_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        deFechaCorte.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        leSucursal.EditValue = CInt(gIdSucursal)
        leSucursal.Properties.ReadOnly = True
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimir.Click
        Dim rpt As New rptCorteCajaPrevio
        rpt.DataSource = blCaja.rptCorteCaja(leSucursal.EditValue, deFechaCorte.EditValue, objMenu.User)
        rpt.DataMember = ""
        rpt.xrlCajero.Text = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFirma1.Text = ""
        rpt.xrlFecha.Text = "AL " & FechaToString(deFechaCorte.EditValue, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataSource = blCaja.rptCorteCajaIngresos(leSucursal.EditValue, objMenu.User, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport2.ReportSource.DataSource = blCaja.rptCorteCajaEgresos(leSucursal.EditValue, objMenu.User, deFechaCorte.EditValue)
        rpt.XrSubreport2.ReportSource.DataMember = ""
        rpt.ShowPreviewDialog()
    End Sub
End Class