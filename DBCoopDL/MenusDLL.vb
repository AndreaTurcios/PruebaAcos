Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class MenusDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()

    Public Function IsMenuActivo(ByVal CodUsuario As String, ByVal NombreModulo As String) As Boolean
        Dim sql As String = String.Format("select count(*) from adm_OpcionesUsuarios where NombreModulo='{0}'", NombreModulo)
        Dim res As Integer = db.ExecuteScalar(CommandType.Text, sql)
        If res = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Function IsMenuActivo(ByVal CodUsuario As String, ByVal NombreModulo As String, ByVal IdOpcion As String) As Boolean
        Dim sql As String

        sql = "select count(*) from adm_OpcionesUsuarios "
        sql &= " where NombreModulo='" & NombreModulo & "'"
        sql &= " and IdOpcion='" & IdOpcion & "'"
        sql &= " and IdUsuario='" & CodUsuario & "'"

        Dim result As Integer = db.ExecuteScalar(CommandType.Text, sql)
        If result = 0 Then
            Return False
        Else
            Return True
        End If

    End Function
    Public Function GetPermisosForma(ByVal CodUsuario As String, ByVal ModuloName As String, ByVal OptionId As String) As DataTable
        Dim sSQL As String
        sSQL = "adm_GetPermisosUsuario"
        Return db.ExecuteDataSet(sSQL, CodUsuario, ModuloName, OptionId).Tables(0)
    End Function
  
End Class
