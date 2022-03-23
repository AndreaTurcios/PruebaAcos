Imports DBCoopEL.TableEntities
Public Class adm_frmFirmantes


    Private Sub adm_frmFirmantes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gc.DataSource = objTablas.coo_EstructurasAdministracionSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entEstructura As New coo_EstructurasAdministracion
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
            gc.DataSource = objTablas.coo_EstructurasAdministracionSelectAll
            Exit Sub
        End If

        With (entEstructura)
            .Id = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .NombreComite1 = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .NombreComite2 = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)
            .NombreComite3 = gv.GetRowCellValue(iFila, gv.Columns(3).FieldName)
            .NombreComite4 = gv.GetRowCellValue(iFila, gv.Columns(4).FieldName)
        End With

        If DbMode = DbModeType.insert Then

            objTablas.coo_EstructurasAdministracionInsert(entEstructura)
        Else

            objTablas.coo_EstructurasAdministracionUpdate(entEstructura)
        End If

    End Sub

    Private Sub adm_frmFirmantes_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub pre_frmFondosCaja_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub

End Class
