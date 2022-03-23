Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class pre_frmListadoCruces
    Dim bl As New PrestamosBLL()
    Dim blAsoc As New AsociadosBLL()

    Private Sub pre_frmListadoCruces_Report_Click() Handles Me.Reporte

        Dim rpt As New pre_rptListadoCruces
        rpt.DataSource = bl.rptListadoCruces(leSucursal.EditValue, teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue, rgOpcion.SelectedIndex)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)

        If rgOpcion.SelectedIndex = 0 Then
            rpt.xrlTitulo.Text = "INCLUYE SOLO CRUCES APLICADOS"
        Else
            If rgOpcion.SelectedIndex = 1 Then
                rpt.xrlTitulo.Text = "INCLUYE SOLO CRUCES PENDIENTES DE APLICAR"
            Else
                rpt.xrlTitulo.Text = "INCLUYE CRUCES APLICADOS Y PENDIENTES"
            End If
        End If

        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmListadoCruces_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        deDesde.EditValue = Today
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES --")
        teIdAsociado.EditValue = 0
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

        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With
    End Sub

    Private Sub pre_frmListadoCruces_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptListadoCruces(leSucursal.EditValue, teIdAsociado.EditValue, deDesde.EditValue, deHasta.EditValue, rgOpcion.EditValue), "")
    End Sub
End Class
