Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aho_frmProvisionIntereses
    Dim blAhorro As New AhorrosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()

    Private Sub aho_frmProvisionIntereses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
        objCombos.coo_UbicacionesAsociados(leCentroCosto, "-- TODOS LOS CENTROS DE COSTO --")
        MonthEdit1.Month = piMesCerrado
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub aho_frmProvisionIntereses_Report_Click() Handles Me.Reporte
        Dim rpt As New aho_rptProvisionIntereses
        rpt.DataSource = blAhorro.rptProvisionInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, chkIncluirInt.EditValue, chkIncluirDep.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "Correspondiente al mes de " & MonthEdit1.Text & " de " & SpinEdit1.EditValue
        rpt.xrlSucursal.Text = "SUCURSAL : " & leSucursal.Text
        rpt.xrlCentroCosto.Text = "CENTRO DE COSTO: " & leCentroCosto.Text
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub aho_frmProvisionIntereses_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blAhorro.rptProvisionInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, chkIncluirInt.EditValue, chkIncluirDep.EditValue), "")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If MsgBox("Está seguro(a) de contabilizar la provisión de intereses?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim i As Integer = blAhorro.PartidaProvisionInteres(leSucursal.EditValue, SpinEdit1.EditValue, MonthEdit1.EditValue, leCentroCosto.EditValue, chkIncluirInt.EditValue, chkIncluirDep.EditValue, objMenu.User)
            MsgBox("La partida se realizo  con éxito", MsgBoxStyle.Information, "Nota")
        Catch ex As Exception

            MsgBox("No fue posible crear el documento" + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
End Class
