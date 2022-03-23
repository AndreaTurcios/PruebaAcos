Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmListadoAcuerdos
    Dim entAsociado As coo_Asociados
    Dim bl As New DBCoopBL.PrestamosBLL

    Private Sub pre_frmListadoResoluciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        rgTipoListado.EditValue = CInt(1)
    End Sub

    Private Sub btVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btVer.Click
        Dim rpt As New pre_rptListadoAcuerdos
        rpt.DataSource = bl.rptListadoAcuerdos(rgTipoListado.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        If rgTipoListado.EditValue = 1 Then
            rpt.xrlTitulo.Text = "LISTADO DE ACUERDOS POR FECHA DE RECIBIDO"
        Else
            rpt.xrlTitulo.Text = "LISTADO DE ACUERDOS POR FECHA DE VENCIMIENTO"
        End If
        rpt.xrlFecha.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub sbExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbExcel.Click
        DataTableToExcel(bl.rptListadoAcuerdos(rgTipoListado.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSalir.Click
        Close()
    End Sub
End Class
