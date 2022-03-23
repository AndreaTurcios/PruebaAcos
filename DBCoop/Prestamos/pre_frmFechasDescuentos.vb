Imports DBCoopEL.TableEntities
Public Class pre_frmFechasDescuentos

    Private Sub pre_frmFechasDescuentos_Delete_Click() Handles Me.Eliminar

        If gv.GetFocusedRowCellValue(gv.Columns(2)) = False Then
            MsgBox("La fecha de descuento ya está cerrada", MsgBoxStyle.Exclamation, Me.Text)
            Return
        End If

        If MsgBox("Está seguro(a) de eliminar éste registro?", MsgBoxStyle.YesNo, gSystemName) = MsgBoxResult.No Then
            Return
        End If
        objTablas.coo_FechasDescuentosDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
        gc.DataSource = objTablas.coo_FechasDescuentosSelectAll()
    End Sub

    Private Sub pre_frmFechasDescuentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        gc.DataSource = objTablas.coo_FechasDescuentosSelectAll
    End Sub

    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim entFechas As New coo_FechasDescuentos
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
            gc.DataSource = objTablas.coo_FechasDescuentosSelectAll
            Exit Sub
        End If

        With (entFechas)
            .IdComprobante = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .FechaDescuento = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
            .Activo = gv.GetRowCellValue(iFila, gv.Columns(2).FieldName)

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .CerradoPor = ""
                .FechaCerrado = Nothing
                .ModificadoPor = ""
                .FechaHoraModificacion = Nothing
            Else
                .CreadoPor = SiEsNulo(gv.GetRowCellValue(iFila, gv.Columns(3).FieldName), objMenu.User)
                .FechaHoraCreacion = SiEsNulo(gv.GetRowCellValue(iFila, gv.Columns(4).FieldName), Now)
                .CerradoPor = ""
                .FechaCerrado = Nothing
            End If
        End With

        If DbMode = DbModeType.insert Then
            entFechas.IdComprobante = objFunciones.ObtenerUltimoId("coo_FechasDescuentos", "IdComprobante") + 1
            entFechas.CreadoPor = objMenu.User
            entFechas.FechaHoraCreacion = Now
            entFechas.CerradoPor = ""
            entFechas.FechaCerrado = Nothing
            entFechas.ModificadoPor = ""
            objTablas.coo_FechasDescuentosInsert(entFechas)
            gc.DataSource = objTablas.coo_FechasDescuentosSelectAll
        Else
            entFechas.FechaHoraModificacion = Now
            entFechas.ModificadoPor = objMenu.User
            entFechas.CerradoPor = ""
            entFechas.FechaCerrado = Nothing

            If gv.GetFocusedRowCellValue(gv.Columns(2)) = True Then
                objTablas.coo_FechasDescuentosUpdate(entFechas)
            End If
            gc.DataSource = objTablas.coo_FechasDescuentosSelectAll
        End If
    End Sub

    Private Sub pre_frmFechasDescuentosReport_Click() Handles Me.Reporte
        gc.ShowPrintPreview()
    End Sub

    Private Sub pre_frmFechasDescuentos_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(gc.DataSource, "")
    End Sub

    Private Sub gv_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.SetRowCellValue(gv.FocusedRowHandle, "IdComprobante", 0)
        gv.SetRowCellValue(gv.FocusedRowHandle, "FechaDescuento", Today)
        gv.SetRowCellValue(gv.FocusedRowHandle, "Activo", True)
    End Sub
End Class
