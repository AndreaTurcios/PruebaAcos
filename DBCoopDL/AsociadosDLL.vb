Imports Microsoft.Practices.EnterpriseLibrary.Data
'Imports System.Data
Imports System.Data.Common
Imports DBCoopEL.TableEntities
Public Class AsociadosDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim objTabla As New TableData
    Public Function DatosGeneralesAsociadoPorNumero(ByVal NumAsociado As String) As DataTable
        Dim sql As String = "select Numero, Nombres, Apellidos, NumeroDocumento, Telefonos, Direccion, IdAsociado from coo_Asociados where IdEstado=1 and  Numero = '" + NumAsociado + "'"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function MaxCorrelativoSolEfectivo(ByVal IsssAfp As String) As Integer
        Dim sql As String = "select CorrelativoSolicitud=max(CorrelativoSolicitud) from coo_Asociados where  Numero = '" + IsssAfp + "'"
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function
    Public Function VerificaAsociado(ByVal IdAsociado As Integer) As String
        Dim sql As String = "SELECT idAsociado  FROM coo_Asociados WHERE IdAsociado= " & IdAsociado
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function

    Public Function DatosGeneralesAsociadoPorNumeroBoleta(ByVal NumAsociado As String, ByVal IdAsociado As Integer) As DataTable
        Dim sql As String = "select Numero, Nombres, Apellidos, NumeroDocumento, Telefonos, Direccion, IdAsociado from coo_Asociados where  Numero = '" + NumAsociado + "'"
        sql += " and IdAsociado= " & IdAsociado
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function aso_ListadoSaldosAsociados() As DataTable
        Return db.ExecuteDataSet("coo_spListadoTelefonicoSaldos").Tables(0)
    End Function
    Public Function aso_HistoricoSaldosTelefonia(ByVal IdAsociado As Integer, ByVal NTelefono As String, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaTelefonia", IdAsociado, NTelefono, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function DescuentosAsociados(ByVal IdAsociado As Integer) As DataTable
        Dim sql As String = "select IdPlanilla, IdRubro, Descuento from coo_AsociadosDescuentos where IdAsociado = " & IdAsociado
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ListadoTelefonia(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoTelefonico", IdAsociado).Tables(0)
    End Function
    Public Function DatosAsociadoParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spDatosAsociadoParaConsulta", Nombre, Apellido, Incluir).Tables(0)
    End Function
    Public Function DatosAsociadoParaConsultaReintegro(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return db.ExecuteDataSet("coo_spDatosAsociadoParaConsultaReintegro", Nombre, Apellido).Tables(0)
    End Function


    Public Function CambioPrestamosEfectivo(ByVal IdAsociado As Integer, ByVal Valor As Decimal _
    , ByVal RubroCanbiar As Integer, ByRef entCambioDescuentos As List(Of coo_AsociadosCambioDescuentos)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            Dim sSQL As String = ""

            ' RubroCanbiar 
            '0 prestamos en efectivo, 1-aportaciones, 2- ahorros, 3-ayuda funeraria
            If IdAsociado > 0 Then
                If RubroCanbiar = 0 Then
                    sSQL = "update coo_Asociados set CuotaPresEfectivo = " & Valor & " WHERE IdAsociado=" & IdAsociado
                End If
                If RubroCanbiar = 1 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE IdAsociado=" & IdAsociado
                    sSQL += " and IdRubro = 1"
                End If
                If RubroCanbiar = 2 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE IdAsociado=" & IdAsociado
                    sSQL += " and IdRubro = 3"
                End If
                If RubroCanbiar = 3 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE IdAsociado=" & IdAsociado
                    sSQL += " and IdRubro = 2"
                End If

            Else
                If RubroCanbiar = 0 Then
                    sSQL = " update coo_Asociados set CuotaPresEfectivo = " & Valor & " WHERE IdEstado = 1"
                End If
                If RubroCanbiar = 1 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE  IdRubro= 1 and (Select IdEstado from coo_asociados where IdAsociado =coo_AsociadosDescuentos.IdAsociado)=1"
                End If
                If RubroCanbiar = 2 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE IdRubro= 3 and (Select IdEstado from coo_asociados where IdAsociado =coo_AsociadosDescuentos.IdAsociado)=1"
                End If
                If RubroCanbiar = 3 Then
                    sSQL = "update coo_AsociadosDescuentos  set Descuento = " & Valor & " WHERE IdRubro= 2 and (Select IdEstado from coo_asociados where IdAsociado =coo_AsociadosDescuentos.IdAsociado)=1"
                End If
            End If


            For Each detalle As coo_AsociadosCambioDescuentos In entCambioDescuentos
                objTabla.coo_AsociadosCambioDescuentosInsert(detalle, tran)
            Next

            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)


            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function rptAsociadosGenero(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spAsociadosGenero", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptFolioAsociado(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spFolioAsociado", IdAsociado).Tables(0)
    End Function

    Public Function rptAyudaFuneraria(ByVal IdMovimiento As Integer) As DataTable
        Dim sql As String = "select * from coo_AyudaFuneraria where IdMovimiento = " & IdMovimiento
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function


End Class
