Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class aso_frmSaldosAsociados
    ReadOnly blAporta As New AportacionesBLL()

    Private Sub apo_frmSaldosAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
        teIdAsociado.EditValue = 0
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub

    Private Sub apo_frmSaldosAsociados_Report_Click() Handles Me.Reporte
        Dim rpt As New aso_rptSaldosAsociados
        rpt.DataSource = blAporta.rptSaldosAsociados(leSucursal.EditValue, leCentroCosto.EditValue, teIdAsociado.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlcDelAl.Text = FechaToString(deHasta.EditValue, deHasta.EditValue)
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.xrlTitulo.Text = "SALDOS TOTALES DE APORTACIONES Y AHORROS POR ASOCIADO"

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
            teNombreAsociado.EditValue = ""
            Exit Sub
        End If

        If teIdAsociado.EditValue = 0 Then
            Exit Sub
        End If

        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        If entAsociados.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            teIdAsociado.EditValue = 0
            teNombreAsociado.EditValue = ""
            Exit Sub
        End If


        teIdAsociado.EditValue = entAsociados.IdAsociado
        teNombreAsociado.EditValue = entAsociados.Nombres + " " + entAsociados.Apellidos


    End Sub
    Private Sub apo_frmSaldosAsociados_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAporta.rptSaldosAsociados(leSucursal.EditValue, leCentroCosto.EditValue, teIdAsociado.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbSociosAhorros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbSociosAhorros.Click
        Dim rpt As New aso_rptPorcenAhorrosSocios
        rpt.DataSource = blAporta.rptPorcenAhorroSocio(leCentroCosto.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa

        rpt.ShowPreviewDialog()
    End Sub
End Class

