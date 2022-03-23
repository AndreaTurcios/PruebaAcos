Imports DBCoopBL
Imports System.Data.OleDb
Public Class pre_frmGenerarArchivoInfored
    Dim blPrestamo As New PrestamosBLL()

    Private Sub pre_frmGenerarArchivoInfored_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        Dim Infored As DataTable
        Infored = blPrestamo.ArchivoInfored(deHasta.EditValue)
        DataTableToExcel(Infored, "P" & Month(deHasta.EditValue).ToString.PadLeft(2, "0") & Year(deHasta.EditValue).ToString.PadLeft(4, "000"))
    End Sub


End Class
