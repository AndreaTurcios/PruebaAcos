Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmProfesiones

    Private Sub pre_frmProfesiones_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar ésta Profesión?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_ProfesionesDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
        gc.DataSource = objTablas.coo_ProfesionesSelectAll
    End Sub


    Private Sub pre_frmProfesiones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gc.DataSource = objTablas.coo_ProfesionesSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entProfesiones As New coo_Profesiones
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
            gc.DataSource = objTablas.coo_ProfesionesSelectAll
            Exit Sub
        End If
        With (entProfesiones)
            .IdProfesion = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .Nombre = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .Asegurado = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)
        End With
        If DbMode = DbModeType.insert Then
            objTablas.coo_ProfesionesInsert(entProfesiones)
        Else
            objTablas.coo_ProfesionesUpdate(entProfesiones)
        End If
    End Sub

    Private Sub pre_frmProfesiones_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub adm_frmProfesiones_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub
End Class
