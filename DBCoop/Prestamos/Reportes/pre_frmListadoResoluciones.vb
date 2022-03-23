Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmListadoResoluciones
    Dim entAsociado As coo_Asociados
    Dim bl As New DBCoopBL.PrestamosBLL

    Private Sub pre_frmListadoResoluciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        teActa.EditValue = ""
        rgTipoListado.EditValue = CInt(1)
    End Sub

    Private Sub btVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btVer.Click
        Dim rpt As New pre_rptListadoResoluciones
        rpt.DataSource = bl.rptListadoResoluciones(rgTipoListado.EditValue, teActa.EditValue, _
        deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        If rgTipoListado.EditValue = 1 Then
            rpt.xrlTitulo.Text = "INFORME DE RESOLUCIONES DE CRÉDITO EN EL ACTA No. " & teActa.EditValue
        Else
            rpt.xrlTitulo.Text = "INFORME DE RESOLUCIONES DE CRÉDITO " & "AL " & FechaToString(deDesde.EditValue, deHasta.EditValue)
        End If
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub sbExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbExcel.Click
        DataTableToExcel(bl.rptListadoResoluciones(rgTipoListado.EditValue, teActa.EditValue, _
        deDesde.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSalir.Click
        Close()
    End Sub
End Class
