Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmPrestamosPorVencerTecnico
    Dim bl As New PrestamosBLL()


    Private Sub pre_frmPrestamosPorVencerTecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_Tecnicos(leTecnico, "-- TOD@S LOS TECNIC@S --")
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub pre_frmPrestamosPorVencerTecnico_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptPrestamosVencerTecnico
        rpt.DataSource = bl.rptPrestamosVencerTecnico(leSucursal.EditValue, leTecnico.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, ceIncluir.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = "Correspondiente al mes de " & MonthEdit1.Text & " de " & SpinEdit1.EditValue
        rpt.xrlNombreSucursal.Text = leSucursal.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmPrestamosPorVencerTecnico_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptPrestamosVencerTecnico(leSucursal.EditValue, leTecnico.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, ceIncluir.EditValue), "")
    End Sub
End Class
