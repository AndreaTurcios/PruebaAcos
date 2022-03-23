Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmListadoSeguimientos
    Dim entAsociado As coo_Asociados
    Dim bl As New DBCoopBL.PrestamosBLL

    Private Sub pre_frmListadoSeguimientos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deDesde.EditValue = CDate("01/" & Month(Today) & "/" & Year(Today))
        deHasta.EditValue = Today
        rgTipoListado.EditValue = CInt(1)
    End Sub

    Private Sub btVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btVer.Click
        Dim rpt As New pre_rptListadoSeguimientos
        rpt.DataSource = bl.rptListadoSeguimientos(rgTipoListado.EditValue, deDesde.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        If rgTipoListado.EditValue = 1 Then
            rpt.xrlTitulo.Text = "LISTADO DE PRESTAMOS QUE REQUIEREN SEGUIMIENTO"
        Else
            rpt.xrlTitulo.Text = "LISTADO DE PRESTAMOS QUE NO REQUIEREN SEGUIMIENTO"
        End If
        rpt.xrlFecha.Text = FechaToString(deDesde.EditValue, deHasta.EditValue)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub sbExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbExcel.Click
        DataTableToExcel(bl.rptListadoSeguimientos(rgTipoListado.EditValue, deDesde.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSalir.Click
        Close()
    End Sub
End Class
