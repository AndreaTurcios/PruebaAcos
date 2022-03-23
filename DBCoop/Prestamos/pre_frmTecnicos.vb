Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities

Public Class pre_frmTecnicos
    
    Private Sub pre_frmTecnicos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        gc.DataSource = objTablas.coo_TecnicosSelectAll
    End Sub

    Private Sub pre_frmTecnicos_Reporte() Handles Me.Reporte
        Dim rpt As New pre_rptTecnicos
        rpt.DataSource = objTablas.coo_TecnicosSelectAll()
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub


    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        Dim ent As New coo_Tecnicos
        Dim iFila As Integer
        If e.RowHandle < 0 Then
            DbMode = DbModeType.insert
            iFila = gv.RowCount - 1
        Else
            DbMode = DbModeType.update
            iFila = e.RowHandle
        End If
        If Not AllowInsert Or Not AllowEdit Then
            MsgBox("No le está permitido ingresar o editar información", MsgBoxStyle.Exclamation, "Nota")
            gc.DataSource = objTablas.coo_TecnicosSelectAll
            Exit Sub
        End If
        With ent
            .IdTecnico = gv.GetRowCellValue(iFila, gv.Columns(0).FieldName)
            .Nombre = gv.GetRowCellValue(iFila, gv.Columns(1).FieldName)
        End With
        If DbMode = DbModeType.insert Then
            objTablas.coo_TecnicosInsert(ent)
        Else
            objTablas.coo_TecnicosUpdate(ent)
        End If
    End Sub
    Private Sub pre_frmTecnicos_Eliminar() Handles Me.Eliminar
        If MsgBox("¿Está seguro(a) de eliminar al técnico seleccionado?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Confirme") = MsgBoxResult.Yes Then
            Dim msj As String = ""

            Try
                objTablas.coo_TecnicosDeleteByPK(gv.GetFocusedRowCellValue(gv.Columns(0)))
                gv.DeleteSelectedRows()
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj <> "" Then
                MsgBox(String.Format("No fue posible eliminar al técnico{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al eliminar")
            End If
        End If
    End Sub
End Class
