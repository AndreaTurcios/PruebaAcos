Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmAplicacionPlanilla
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()
    Dim blAsoc As New DBCoopBL.AsociadosBLL()

    Private Sub pre_frmListadoDescuentosPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFechaContable.EditValue = Today
        deHasta.EditValue = Today
        teIdAsociado.EditValue = 0
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptListadoAplicacionPlanilla
        rpt.DataSource = blPrestamo.rptListadoAplicacionPlanilla(leSucursal.EditValue, leCentroCosto.EditValue, deFechaContable.EditValue, deHasta.EditValue, teIdAsociado.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa

        rpt.ShowPreviewDialog()
    End Sub
    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            teIdAsociado.EditValue = 0
            Exit Sub
        End If

        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumeroBoleta(teNumAsociado.EditValue, teIdAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            teIdAsociado.EditValue = 0
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With
    End Sub
    Private Sub pre_frmListadoDescuentosPrestamos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blPrestamo.rptListadoAplicacionPlanilla(leSucursal.EditValue, leCentroCosto.EditValue, deFechaContable.EditValue, deHasta.EditValue, teIdAsociado.EditValue), "")
    End Sub

    Private Sub sbMuestra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbMuestra.Click
        deFechaContable.EditValue = objConsultas.ConsultaPlanillasAplicadas(frmConsultas)
        deHasta.EditValue = blPrestamo.FechaPlanilla(deFechaContable.EditValue)
    End Sub
End Class
