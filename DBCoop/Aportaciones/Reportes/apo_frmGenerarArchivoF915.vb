Imports DBCoopBL
Imports System.IO
Public Class apo_frmGenerarArchivoF915
    Dim blAporta As New AportacionesBLL()

    Private Sub apo_frmGenerarArchivoF915_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sePeriodo.EditValue = piPeriodo - 1
        sePresenta.EditValue = piPeriodo
    End Sub


    Private Sub apo_frmGenerarArchivoF915_Reporte() Handles Me.Reporte
        Dim dt As DataTable = blAporta.rptArchivoF915(sePeriodo.EditValue, sePresenta.EditValue)
        Dim fbd As New FolderBrowserDialog
        fbd.ShowDialog()
        If fbd.SelectedPath = "" Then
            Return
        End If
        Dim NombreArchivo As String = InputBox("Nombre del archivo", "Caption", "")
        If NombreArchivo = "" Then
            Return
        End If
        Dim FileName As String = fbd.SelectedPath & "\" & NombreArchivo & ".txt"
        GeneraArchivoF915Txt(FileName, "", dt, "")

    End Sub

    Private Sub GeneraArchivoF915Txt(ByVal fileName As String, ByVal separator As String _
                            , ByVal dt As DataTable, ByVal delimiter As String)

        Dim sw As New StreamWriter(fileName)

        For Each fila As DataRow In dt.Rows
            Dim sepText As String = ""
            Dim linea As String = ""
            For i As Integer = 0 To dt.Columns.Count - 1
                If i = 0 Then
                    linea = linea & sepText & delimiter & fila.Item(i).ToString & Space(40 - Len(fila.Item(i).ToString)) & delimiter
                End If
                If i = 1 Then
                    linea = linea & sepText & delimiter & fila.Item(i).ToString & Space(14 - Len(fila.Item(i).ToString)) & delimiter
                End If
                If i > 1 Then
                    linea = linea & sepText & delimiter & fila.Item(i).ToString & delimiter
                End If
                sepText = separator
            Next
            sw.WriteLine(linea)
        Next
        sw.Close()
        MsgBox("El Archivo ha sido guardado con éxito", MsgBoxStyle.Information)
    End Sub

End Class
