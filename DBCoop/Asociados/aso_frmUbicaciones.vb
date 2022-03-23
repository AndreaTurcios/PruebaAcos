Imports DBCoopEL.TableEntities
Public Class aso_frmUbicaciones

    Private Sub aso_frmUbicaciones_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar éste centro de costo?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_UbicacionesAsociadosDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
        gc.DataSource = objTablas.coo_UbicacionesAsociadosSelectAll
    End Sub

    Private Sub aso_frmUbicaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        gc.DataSource = objTablas.coo_UbicacionesAsociadosSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entUbicacion As New coo_UbicacionesAsociados
        Dim iFila As Integer
        If e.RowHandle < 0 Then
            DbMode = DbModeType.insert
            iFila = gv.RowCount - 1
        Else
            DbMode = DbModeType.update
            iFila = e.RowHandle
        End If
        If Not AllowInsert Or Not AllowEdit Then
            MsgBox("No le está permitido ingresar o editar información", MsgBoxStyle.Exclamation, Me.Text)
            gc.DataSource = objTablas.coo_UbicacionesAsociadosSelectAll
            Exit Sub
        End If
        With (entUbicacion)
            .IdUbicacion = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .Nombre = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
        End With
        If DbMode = DbModeType.insert Then
            objTablas.coo_UbicacionesAsociadosInsert(entUbicacion)
        Else
            objTablas.coo_UbicacionesAsociadosUpdate(entUbicacion)
        End If
    End Sub

    Private Sub aso_frmUbicacioneso_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub aso_frmUbicaciones_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub
End Class
