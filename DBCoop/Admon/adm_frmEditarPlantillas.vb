Imports DBCoopBL
Public Class adm_frmEditarPlantillas
    Dim bl As New AdmonBLL
    Private Sub adm_frmEditarPlantillas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As New DataTable
        dt = bl.ObtieneNombrePlantillas()
        For Each dr As DataRow In dt.Rows
            cboPlantilla.Properties.Items.Add(dr("Nombre"))
        Next
    End Sub

    Private Sub btEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEditar.Click
        Dim forma As New frm_EditorRichText
        forma.Icon = Me.Icon
        forma.NombreArchivoRTF = cboPlantilla.EditValue
        forma.Text += " - ( " + cboPlantilla.EditValue + " )"
        forma.Show()
    End Sub
End Class
