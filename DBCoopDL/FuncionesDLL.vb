Imports System.Configuration
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports System.Data.Common
Imports System.Data

Public Class FuncionesDLL
    Private db As Database = DatabaseFactory.CreateDatabase()

    Public Function getDepartamento(ByVal IdMunicipio As String) As String
        Dim sSQL As String = "select IdDepartamento from adm_municipios where IdMunicipio = '"
        sSQL &= IdMunicipio & "'"
        Return SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), " ")
    End Function

    Public Function GetUltCanton(ByVal IdMunicipio As String) As String
        Dim sSQL As String = "select Max(IdCanton) from adm_cantones where IdMunicipio = '"
        sSQL &= IdMunicipio & "'"
        Return SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), " ")
    End Function

    Public Function GetNumPartida(ByVal TipoPartida As String, ByVal Fecha As Date, ByVal Transac As DbTransaction) As String

        Dim sSQL As String = "select TipoNumeracionPartidas from adm_parametros"
        Dim NumPartidaBy As Integer = db.ExecuteScalar(CommandType.Text, sSQL)

        Dim strCorrelativo = ""
        Select Case NumPartidaBy
            Case 1 'Mensual con Tipo de Partida
                strCorrelativo = TipoPartida & Month(Fecha).ToString.PadLeft(2, "0") & Year(Fecha).ToString
            Case 2 'Anual con Tipo de Partida
                strCorrelativo = TipoPartida & Year(Fecha).ToString
            Case 3 'Mensual sin tipo de partida
                strCorrelativo = Month(fecha).ToString.PadLeft(2, "0") & Year(fecha).ToString
            Case 4 'Anual sin tipo de partida
                strCorrelativo = Year(fecha).ToString
        End Select

        sSQL = "select UltimoValor from adm_correlativos where Correlativo='" & strCorrelativo & "'"
        Dim UltimoValor As Integer = SiEsNulo(db.ExecuteScalar(Transac, CommandType.Text, sSQL), -1)

        If UltimoValor < 1 Then 'Crea un nuevo registro
            sSQL = "insert adm_correlativos (correlativo, UltimoValor) values ('" & strCorrelativo & "',1)"
            UltimoValor = 1
        Else 'Actualiza el registro
            UltimoValor += 1
            sSQL = "update adm_correlativos set UltimoValor = UltimoValor + 1 where correlativo='" & strCorrelativo & "'"
        End If
        db.ExecuteNonQuery(transac, CommandType.Text, sSQL)

        Select Case NumPartidaBy
            Case 1 'Mensual por tipo de partida
                Return Month(fecha).ToString.PadLeft(2, "0") & UltimoValor.ToString.PadLeft(4, "0")
            Case 2 'Anual por tipo de partida
                Return UltimoValor.ToString.PadLeft(6, "0")
            Case 3 'Mensual sin tipo de partida
                Return UltimoValor.ToString.PadLeft(6, "0")
            Case 4 'Anual por Tipo de Partida
                Return UltimoValor.ToString.PadLeft(6, "0")
        End Select

        Return "000000"
    End Function

    Public Function GetNumeroCheque(ByVal IdBanco As Integer, ByVal IdCuentaBancaria As Integer) As Integer
        Dim sSQL As String = "select UltNumeroCheque from ban_CuentasBancarias"
        sSQL &= " where IdBanco= " & IdBanco & " and IdCuentaBancaria = " & IdCuentaBancaria
        Dim UltimoValor As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)

        UltimoValor += 1
        Return UltimoValor
    End Function
    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Dim IdMov As Integer = db.ExecuteScalar("coo_spGetUlMovPrestamo", IdPrestamo)
        Return IdMov
    End Function
    Public Function ObtenerUltimoId(ByVal Tabla As String, ByVal PrimaryKey As String) As Integer
        'METER A TRANSACCION
        Dim sSQL As String = "select max(" & PrimaryKey & ") from " & Tabla
        Dim iMax As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)
        Return iMax
    End Function
    Public Function ObtenerPrimerId(ByVal Tabla As String, ByVal PrimaryKey As String) As Integer
        'METER A TRANSACCION
        Dim sSQL As String = "select min(" & PrimaryKey & ") from " & Tabla
        Dim iMin As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)
        Return iMin
    End Function

    Public Function ObtenerCorrelativoManual(ByVal NombreCorrelativo As String, ByVal Transac As DbTransaction) As Integer
        Dim sSQL As String = "select UltimoValor from adm_correlativos where Correlativo='" & NombreCorrelativo & "'"
        Dim NuevoCorrelativo As Integer = SiEsNulo(db.ExecuteScalar(Transac, CommandType.Text, sSQL), 0) + 1

        If NuevoCorrelativo = 1 Then 'Crea un nuevo registro
            sSQL = "insert adm_correlativos (correlativo, UltimoValor) values ('" & NombreCorrelativo & "',1)"
        Else 'Actualiza el registro
            sSQL = "update adm_correlativos set UltimoValor = UltimoValor + 1 where correlativo='" & NombreCorrelativo & "'"
        End If
        db.ExecuteNonQuery(Transac, CommandType.Text, sSQL)

        Return NuevoCorrelativo

    End Function
    Public Function ObtenerCorrelativoManual(ByVal NombreCorrelativo As String) As Integer
        Dim sSQL As String = "select UltimoValor from adm_correlativos where Correlativo='" & NombreCorrelativo & "'"
        Dim NuevoCorrelativo As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0) + 1

        If NuevoCorrelativo = 1 Then 'Crea un nuevo registro
            sSQL = "insert adm_correlativos (correlativo, UltimoValor) values ('" & NombreCorrelativo & "',1)"
        Else 'Actualiza el registro
            sSQL = "update adm_correlativos set UltimoValor = UltimoValor + 1 where correlativo='" & NombreCorrelativo & "'"
        End If
        db.ExecuteNonQuery(CommandType.Text, sSQL)

        Return NuevoCorrelativo

    End Function

    Public Function ObtenerCorrelativo(ByVal correlativo As String) As Integer
        Return db.ExecuteScalar("coo_GetIdMov", correlativo, 0)
    End Function
    Public Function ObtenerValorComision(ByVal IdAsociado As Integer) As Decimal
        Dim NumeroReg As Decimal = db.ExecuteScalar("coo_spGetObtineComisionAsociado", IdAsociado)
        Return NumeroReg
    End Function
    Public Function ObtenerUltimoIdTelefono(ByVal Tabla As String, ByVal PrimaryKey As String, ByVal Condicion As Integer) As Integer
        Dim sSQL As String = "select IsNull(max(" & PrimaryKey & "),0) from " & Tabla & " WHERE IdAsociado=  " & Condicion
        Dim iMax As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return iMax
    End Function
    Public Function GetFechaContable(ByVal IdSucursal As Integer) As Date
        'Dim sSQL As String = "select max(fecha) from coo_Calendario where activo=1 and IdSucursal=" & IdSucursal
        Dim sSQL As String = "select Fecha=convert(date,getdate(),112) "
        Dim Fecha As Date = db.ExecuteScalar(CommandType.Text, sSQL)
        Return Fecha
    End Function
    Public Function SiEsNulo(ByVal value As Object, ByVal ValueNoNull As Object) As Object
        If value Is Nothing Then Return Nothing
        If IsDBNull(value) Then Return ValueNoNull
        Return value
    End Function
    Public Function GetConsulta(ByVal sSQL As String) As DataTable
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
End Class
