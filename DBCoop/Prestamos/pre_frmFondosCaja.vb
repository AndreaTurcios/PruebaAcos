Imports DBCoopEL.TableEntities
Public Class pre_frmFondosCaja

    Private Sub pre_frmFondosCaja_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar éste fondo de caja?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_FondosCajaDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
        gc.DataSource = objTablas.coo_FondosCajaSelectAll()
    End Sub

    Private Sub pre_frmFondosCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        gc.DataSource = objTablas.coo_FondosCajaSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entFondos As New coo_FondosCaja
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
            gc.DataSource = objTablas.coo_FondosCajaSelectAll
            Exit Sub
        End If

        With (entFondos)
            .IdComprobante = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .Referencia = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .Fecha = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)
            .Valor = gv.GetRowCellValue(iFila, gv.Columns(3).FieldName)

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .CreadoPor = gv.GetRowCellValue(iFila, gv.Columns(3).FieldName)
                .FechaHoraCreacion = gv.GetRowCellValue(iFila, gv.Columns(4).FieldName)
            End If
        End With

        If DbMode = DbModeType.insert Then
            entFondos.CreadoPor = objMenu.User
            entFondos.FechaHoraCreacion = Now
            entFondos.ModificadoPor = ""
            objTablas.coo_FondosCajaInsert(entFondos)
        Else
            entFondos.FechaHoraModificacion = Now
            entFondos.ModificadoPor = objMenu.User
            objTablas.coo_FondosCajaUpdate(entFondos)
        End If

    End Sub

    Private Sub pre_frmFondosCaja_Report_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub pre_frmFondosCaja_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub

    Private Sub gv_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.SetRowCellValue(gv.FocusedRowHandle, "Valor", 0.0)
        gv.SetRowCellValue(gv.FocusedRowHandle, "Fecha", Today)
    End Sub
End Class
