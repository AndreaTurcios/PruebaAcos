Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmActividades

    Private Sub pre_frmActividades_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar ésta Actividad Economica?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_ActividadesDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(1)))
        gc.DataSource = objTablas.coo_ActividadesSelectAll
    End Sub

    Private Sub pre_frmActividades_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarCombos()
        gc.DataSource = objTablas.coo_ActividadesSelectAll
    End Sub

    Private Sub CargarCombos()
        objCombos.coo_RubrosActividades(leRubro, "")
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entActividad As New coo_Actividades
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
            gc.DataSource = objTablas.coo_ActividadesSelectAll
            Exit Sub
        End If
        With (entActividad)
            .IdActividad = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .Nombre = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)
            .IdRubro = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
        End With
        If DbMode = DbModeType.insert Then
            objTablas.coo_ActividadesInsert(entActividad)
        Else
            objTablas.coo_ActividadesUpdate(entActividad)
        End If
    End Sub

    Private Sub pre_frmActividades_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub adm_frmActividades_RepoteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub
End Class
