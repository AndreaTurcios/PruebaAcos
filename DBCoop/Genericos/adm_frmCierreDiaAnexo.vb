Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class adm_frmCierreDiaAnexo
    Dim bl As New AdmonBLL()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        leSucursal.EditValue = gIdSucursal
        leSucursal.Properties.ReadOnly = True
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)

    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        Dim dt As DataTable = bl.adm_CierreSucursalAnexo(leSucursal.EditValue, deFecha.EditValue, objMenu.User, True)
        Dim rpt As New adm_rptAnexoCierre
        rpt.DataSource = dt
        rpt.DataMember = ""

        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlTitulo.Text = "ANEXOS A LA PARTIDA DE CIERRE"
        rpt.ShowPreviewDialog()
    End Sub
End Class
