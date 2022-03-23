Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class ind_frmParametros
    Dim entParametros As New col_Parametros
    Dim bl As New IndicadoresBLL()
    Dim entDetalleParametros As New List(Of col_ParametrosDetalle)


    Private Sub ind_frmParametros_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaControles()
        leVariable.Focus()
    End Sub

    Private Sub CargaControles()
        objCombos.col_Parametros(leVariable, "")
        leVariable.EditValue = 1
        seAnio.EditValue = Year(Today)
    End Sub

    Private Sub CalcularTotales()
        gvDetalle.UpdateTotalSummary()
    End Sub

    Private Sub seAnio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seAnio.EditValueChanged, leVariable.EditValueChanged
        gcDetalle.DataSource = bl.GetParametrosIndicador(leVariable.EditValue, seAnio.EditValue)
        CalcularTotales()
    End Sub


    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        CargaEntidades()
        Dim msj As String = ""
        msj = bl.InsertaParametrosIndicadores(entDetalleParametros, seAnio.EditValue, leVariable.EditValue)
        If msj = "" Then
            MsgBox("Los Parametros han sido guardados con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible actualizar los Parametros{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If
        Close()
    End Sub

    Private Sub CargaEntidades()
        For i = 0 To gvDetalle.DataRowCount - 1
            Dim entDetalle As New col_ParametrosDetalle
            With entDetalle
                .Anio = seAnio.EditValue
                .IdParametro = leVariable.EditValue
                .Mes = gvDetalle.GetRowCellValue(i, "Mes")
                .Valor = gvDetalle.GetRowCellValue(i, "Valor")
            End With
            entDetalleParametros.Add(entDetalle)
        Next
    End Sub
End Class