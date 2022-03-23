Imports DBCoopBL
Imports System.IO
Public Class ind_frmGenerador
    Dim bl As New IndicadoresBLL()
    Dim ShowColumns As Boolean = True

    Private Sub ind_frmGenerador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.col_Variables(leIndicador, "-- TODAS LOS INDICADORES --")
        seAnio.EditValue = Year(Now)
        gv.ColumnsCustomization()
    End Sub

    Private Sub ShowColumnSelector()
        If ShowColumns Then
            gv.ColumnsCustomization()
            sbMostrarOcultar.Text = "Ocultar &Selector de Columnas"
        Else
            gv.DestroyCustomization()
            sbMostrarOcultar.Text = "Mostrar &Selector de Columnas"
        End If
    End Sub

    Private Sub sbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbGenerar.Click
        gc.DataSource = bl.rptComparativoAnualColac(seAnio.EditValue, leIndicador.EditValue)
        gv.BestFitColumns()
    End Sub
    Private Sub sbMostrarOcultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbMostrarOcultar.Click
        ShowColumns = Not ShowColumns
        ShowColumnSelector()
    End Sub

    Private Sub sbToExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbToExcel.Click
        DataTableToExcel(gc.DataSource, "")
    End Sub
End Class
