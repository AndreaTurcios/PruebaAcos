Imports DBCoopEL.TableEntities
Public Class pre_frmTiposCredito

    Private Sub pre_frmTiposCredito_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar éste tipo de Credito?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_TiposPrestamoDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
        gc.DataSource = objTablas.coo_TiposPrestamoSelectAll
    End Sub

    Private Sub pre_frmTiposCredito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        gc.DataSource = objTablas.coo_TiposPrestamoSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entTipoCredito As New coo_TiposPrestamo
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
            gc.DataSource = objTablas.coo_TiposPrestamoSelectAll
            Exit Sub
        End If
        With (entTipoCredito)
            .IdTipoPrestamo = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .Nombre = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .Desde = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)
            .Hasta = gv.GetRowCellValue(iFila, gv.Columns(3).FieldName)
        End With
        If DbMode = DbModeType.insert Then
            objTablas.coo_TiposPrestamoInsert(entTipoCredito)
        Else
            objTablas.coo_TiposPrestamoUpdate(entTipoCredito)
        End If
    End Sub

    Private Sub pre_frmTiposCredito_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub pre_frmTiposCredito_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub
End Class
