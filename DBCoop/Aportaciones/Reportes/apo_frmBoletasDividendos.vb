Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class apo_frmBoletasDividendos
    Dim bl As New DBCoopBL.AportacionesBLL()
    Dim blAsoc As New DBCoopBL.AsociadosBLL()
    Dim blAdmon As New DBCoopBL.AdmonBLL()
    Dim entSucursal As adm_Sucursales, dtParam As DataTable = blAdmon.ObtieneParametros()

    Private Sub aho_frmListadoDescuentosAhorros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        spAnio.EditValue = Year(Today)
        deFecha.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
    End Sub
    Private Sub aho_frmListadoDescuentosAhorros_Report_Click() Handles Me.Reporte

        If Not CheckEdit1.EditValue Then
            Dim rpt As New apo_rptBoletaDividendos
            Dim dt As DataTable
            dt = bl.rptBoletasDividendos(leSucursal.EditValue, leCentroCosto.EditValue, spAnio.EditValue, teIdAsociado.EditValue, deFecha.EditValue)
            entSucursal = objTablas.adm_SucursalesSelectByPK(leSucursal.EditValue)


            rpt.DataSource = dt
            rpt.DataMember = ""

            rpt.xrlEmpresa.Text = dtParam.Rows(0).Item("NombreEmpresa")
            rpt.xrlNombreLargo.Text = dtParam.Rows(0).Item("NombreLargo")

            If dt.Rows.Count = 0 Then
                MsgBox("No existen datos para generar reporte", MsgBoxStyle.Exclamation, "Nota")
                Exit Sub
            End If

            rpt.xrlPorcentajeAportacion.Text = "(" & dt.Rows(0).Item("PorAportacion").ToString & "%)"
            rpt.xrlPorcentajeLP.Text = "(" & dt.Rows(0).Item("PorLP") & "%)"
            rpt.xrlPorcentajeEfectivo.Text = "(" & dt.Rows(0).Item("PorEfectivo") & "%)"
            rpt.xrlSaldoAl.Text = "Su saldo al 31/12/" & spAnio.EditValue.ToString
            rpt.xrlDistribucion.Text = "Excedentes y Ayuda funeraria  a Distribuir del Ejercicio " & spAnio.EditValue.ToString
            rpt.xrlAportacion.Text = "Saldo de Aportaciones al 31 de diciembre de " & spAnio.EditValue.ToString
            rpt.xrlLugarFecha.Text = String.Format("{0}, {1}", dtParam.Rows(0).Item("Domicilio"), FechaToString(deFecha.EditValue, deFecha.EditValue))
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New apo_rptBoletaDividendos2
            Dim dt As DataTable
            dt = bl.rptBoletasDividendos(leSucursal.EditValue, leCentroCosto.EditValue, spAnio.EditValue, teIdAsociado.EditValue, deFecha.EditValue)
            entSucursal = objTablas.adm_SucursalesSelectByPK(leSucursal.EditValue)


            rpt.DataSource = dt
            rpt.DataMember = ""

            rpt.xrlEmpresa.Text = dtParam.Rows(0).Item("NombreEmpresa")
            rpt.xrlNombreLargo.Text = dtParam.Rows(0).Item("NombreLargo")

            If dt.Rows.Count = 0 Then
                MsgBox("No existen datos para generar reporte", MsgBoxStyle.Exclamation, "Nota")
                Exit Sub
            End If

            rpt.xrlPorcentajeAportacion.Text = "(" & dt.Rows(0).Item("PorAportacion").ToString & "%)"
            rpt.xrlPorcentajeLP.Text = "(" & dt.Rows(0).Item("PorLP") & "%)"
            rpt.xrlPorcentajeEfectivo.Text = "(" & dt.Rows(0).Item("PorEfectivo") & "%)"
            rpt.xrlPorcentajeOtras.Text = "(" & dt.Rows(0).Item("PorOtrasLineas") & "%)"
            rpt.xrlSaldoAl.Text = "Su saldo al 31/12/" & spAnio.EditValue.ToString
            rpt.xrlDistribucion.Text = "Excedentes y Ayuda funeraria  a Distribuir del Ejercicio " & spAnio.EditValue.ToString
            rpt.xrlAportacion.Text = "Saldo de Aportaciones al 31 de diciembre de " & spAnio.EditValue.ToString
            rpt.xrlLugarFecha.Text = String.Format("{0}, {1}", dtParam.Rows(0).Item("Domicilio"), FechaToString(deFecha.EditValue, deFecha.EditValue))
            rpt.ShowPreviewDialog()
        End If

    End Sub

    Private Sub aho_frmListadoDescuentosAhorros_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptBoletasDividendos(leSucursal.EditValue, leCentroCosto.EditValue, spAnio.EditValue, teIdAsociado.EditValue, deFecha.EditValue), "")
    End Sub


    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
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
End Class
