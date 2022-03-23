Imports DBCoopDL
Public Class FuncionesBLL
    Dim dl As New FuncionesDLL

    
    Public Function ObtenerUltimoId(ByVal Tabla As String, ByVal PrimaryKey As String) As Integer
        Return dl.ObtenerUltimoId(Tabla, PrimaryKey)
    End Function
    Public Function ObtenerPrimerId(ByVal Tabla As String, ByVal PrimaryKey As String) As Integer
        Return dl.ObtenerPrimerId(Tabla, PrimaryKey)
    End Function
    Public Function getDepartamento(ByVal IdMunicipio As String) As String
        Return dl.getDepartamento(IdMunicipio)
    End Function
    Public Function EsNulo(ByVal Value As Object, ByVal ValueNoNull As Object) As Object
        If Value Is Nothing Then Return Nothing
        If IsDBNull(Value) Then Return ValueNoNull
        Return value
    End Function
    Public Function ObtenerCorrelativo(ByVal sCorrelativo As String) As Integer
        Return dl.ObtenerCorrelativo(sCorrelativo)
    End Function

    Public Function ObtenerValorComision(ByVal IdAsociado As Integer) As Decimal
        Return dl.ObtenerValorComision(IdAsociado)
    End Function
    Public Function GetFechaContable(ByVal IdSucursal As Integer) As Date
        Return dl.GetFechaContable(IdSucursal)
    End Function
    Public Function ObtenerUltimoIdTelefono(ByVal Tabla As String, ByVal PrimaryKey As String, ByVal Condicion As Integer) As Integer
        Return dl.ObtenerUltimoIdTelefono(Tabla, PrimaryKey, Condicion)
    End Function
    Public Function GetUltCanton(ByVal IdMunicipio As String) As String
        Return dl.GetUltCanton(IdMunicipio)
    End Function
    Public Function GetConsulta(ByVal sSQL As String) As DataTable
        Return dl.GetConsulta(sSQL)
    End Function

End Class
