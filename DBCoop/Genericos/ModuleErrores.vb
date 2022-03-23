Module ModuleErrores
    Public Sub TrapError(ByVal ex As Exception)
        If IsNothing(ex) Then
            MsgBox("Operación completada con éxito", MsgBoxStyle.Information)
            Exit Sub
        End If

        Select Case ex.GetType.Name
            Case "SqlException"
                TrapSqlError(ex)
            Case Else
                MsgBox(ex.Message, MsgBoxStyle.Critical, ex.GetType.Name)
        End Select
    End Sub

    Private Sub TrapSqlError(ByVal ex As Exception)
        Dim errText As String = ""
        Select Case CType(ex, SqlClient.SqlException).Number
            Case 547
                errText = "No es posible eliminar este registro " & _
                       Chr(13) & "mientras existan dependencias con otras tablas"
            Case 2627
                errText = "El registro que pretende agregar ya existe"
            Case Else
                errText = ex.Message
        End Select
        MsgBox(errText, MsgBoxStyle.Critical, "SQL ERROR")
    End Sub
End Module
