Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports DBCoopEL.TableEntities

Public Class AhorrosDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTabla As New TableData
    Public Function ObtenerIdCuentaByNumero(ByVal Numero As String) As Integer
        Dim sql As String = String.Format("select IdCuenta from coo_CuentasAhorro where Numero = '{0}'", Numero)
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function
    Public Function ObtenerNumeroCuentaByIdCuenta(ByVal IdCuenta As Integer) As String
        Dim sql As String = String.Format("select Numero from coo_CuentasAhorro where IdCuenta = {0}", IdCuenta)
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function
    Function ObtenerIdTipoCuentaAhorro(ByVal IdTipo As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdTipo
        End If
        Dim sSQL As String = String.Format("select top 1 IdTipo from coo_TiposCuentaAhorro where IdTipo < {0} order by IdTipo desc", IdTipo)
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdTipo from coo_TiposCuentaAhorro where IdTipo > " & IdTipo
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function InsertaTipoCuentaAhorro(ByRef entTipoCuenta As coo_TiposCuentaAhorro) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entTipoCuenta.IdTipo = fd.ObtenerUltimoId("Coo_TiposCuentaAhorro", "IdTipo") + 1
            objTabla.coo_TiposCuentaAhorroInsert(entTipoCuenta, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function
    Public Function UpdateTipoCuentaAhorro(ByRef entTipoCuenta As coo_TiposCuentaAhorro) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_TiposCuentaAhorroUpdate(entTipoCuenta, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj

    End Function
    Function ObtenerIdCuenta(ByVal IdCuenta As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdCuenta
        End If
        Dim sSQL As String = String.Format("select top 1 IdCuenta from coo_CuentasAhorro where IdCuenta < {0} order by IdCuenta desc", IdCuenta)
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdCuenta from coo_CuentasAhorro where IdCuenta > " & IdCuenta
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function GetBeneficiariosCuenta(ByVal IdCuenta As Integer) As DataTable
        Dim sSQL As String = "select * from coo_CuentasAhorroBeneficiarios "
        If IdCuenta = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdCuenta=" & IdCuenta
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetDepositosPignorados(ByVal IdSucursal As Integer) As DataTable
        Dim sSQL As String = "select cue.Numero,aso.Nombres,aso.Apellidos,mov.NumeroDoc,mov.Observaciones,mov.Fecha,mov.Valor,mov.Pignorado,cue.IdCuenta,mov.IdMov from coo_CuentasAhorro cue inner join  coo_CuentasAhorroMov mov on cue.IdCuenta=mov.IdCuenta inner join coo_Asociados aso on cue.IdAsociado=aso.IdAsociado "
        If IdSucursal = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where Mov.Pignorado=1 AND mov.IdSucursal=" & IdSucursal
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetAutorizadosCuenta(ByVal IdCuenta As Integer) As DataTable
        Dim sSQL As String = "select * from coo_CuentasAhorroAutorizado "
        If IdCuenta = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdCuenta=" & IdCuenta
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    '
    Public Function GetSaldosAhorros(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal Nuevo As Boolean, ByVal Modulo As String) As DataTable
        Dim sSQL As String = ""
        If Modulo = "Reintegro" Then
            sSQL = "select * from coo_AplicarReintegrosAhorros "
        Else
            sSQL = "select * from coo_SolicitudesCrucesAhorros "
        End If

        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If

        If Nuevo Then
            Return db.ExecuteDataSet("coo_spSaldosAhorro", IdAsociado, HastaFecha).Tables(0)
        Else
            Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
        End If

    End Function
    Public Function coo_UltMovAhorroSelectBy(ByVal IdCuenta As Integer) As coo_UltMovAhorro
        Dim dt As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", IdCuenta).Tables(0)
        Dim entAhorro As New coo_UltMovAhorro
        If dt.Rows.Count = 0 Then
            With entAhorro
                .IdMov = 0
                .Fecha = Today
                .Linea = 0
                .SaldoActual = 0
                .SaldoDisponible = 0
            End With

        Else
            With entAhorro
                .IdMov = dt.Rows(0).Item("IdMov")
                .Fecha = dt.Rows(0).Item("Fecha")
                .Linea = dt.Rows(0).Item("Linea")
                .SaldoActual = dt.Rows(0).Item("SaldoActual")
                .SaldoDisponible = dt.Rows(0).Item("SaldoDisponible")
            End With
        End If
        Return entAhorro
    End Function
    Public Function coo_UltCierreAhorroSelectBy() As coo_CierresAhorro
        Dim dt As DataTable = db.ExecuteDataSet(CommandType.Text, "SELECT TOP 1 Ejercicio, Mes, DesdeCierre, HastaCierre,CreadoPor, FechaHoraCreacion FROM coo_CierresAhorro order by ejercicio desc, mes desc").Tables(0)
        Dim entCierre As New coo_CierresAhorro

        If dt.Rows.Count = 0 Then
            With entCierre
                .mes = 12
                .ejercicio = Year(Today())
                .DesdeCierre = CDate("15" + "/" + "01" + "/" + (Now.Year - 1).ToString)
                .HastaCierre = CDate("31" + "/" + "12" + "/" + (Now.Year - 1).ToString)
                .CreadoPor = ""
                .FechaHoraCreacion = Today
            End With
        Else
            With entCierre
                .mes = dt.Rows(0).Item("Mes")
                .ejercicio = dt.Rows(0).Item("Ejercicio")
                .DesdeCierre = dt.Rows(0).Item("DesdeCierre")
                .HastaCierre = dt.Rows(0).Item("HastaCierre")
                .CreadoPor = dt.Rows(0).Item("CreadoPor")
                .FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            End With
        End If

        Return entCierre
    End Function
    'Public Function ExisteIdCuentaAhorro(ByVal IdCuenta As Integer) As Integer
    '    Dim sSql As String = "select IdCuenta from coo_CuentasAhorro where IdCuenta=" & IdCuenta
    '    IdCuenta = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
    '    Return IdCuenta
    'End Function
    Public Function ExisteNumCuentaAhorro(ByVal Numero As String) As Integer
        Dim sSql As String = String.Format("select IdCuenta,Numero from coo_CuentasAhorro where Numero= '{0}'", Numero)
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function ExisteCapitalizacionAhorro(ByVal Fecha As String, ByVal Periodo As String) As Integer
        Dim sSql As String = "select top 1 cue.IdCuenta from coo_CuentasAhorro cue "
        sSql = sSql & "inner join coo_CuentasAhorroMov Mov on cue.Idcuenta=Mov.IdCuenta "
        sSql = sSql & "inner join coo_TiposCuentaAhorro tp on cue.IdTipoCuenta=tp.IdTipo "
        sSql = String.Format("{0}where Mov.IdTipo=4 AND tp.TipoAhorro=1 and mov.IdFormaPago=4 and Fecha='{1}' and left(mov.NumeroDoc,10)= '{2}' order by cue.IdCuenta", sSql, Fecha, Periodo)
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function ExisteCapitalizacionPlazo(ByVal Fecha As Date, ByVal IdSucursal As Integer) As Integer
        Dim sSql As String = "select ca.IdCuenta from coo_CuentasAhorro ca "
        sSql = sSql & "inner join coo_CuentasAhorroMov mv on ca.IdCuenta = mv.IdCuenta "
        sSql = sSql & "inner join coo_TiposCuentaAhorro tp on ca.IdTipoCuenta=tp.IdTipo "
        sSql = sSql & "where mv.IdTipo=5 and mv.Fecha >= @Fecha and mv.IdSucursal = @IdSucursal"

        Dim cmd As DbCommand = db.GetSqlStringCommand(sSql)
        db.AddInParameter(cmd, "@Fecha", DbType.Date, Fecha)
        db.AddInParameter(cmd, "@IdSucursal", DbType.Int32, IdSucursal)
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(cmd), 0)
        ''Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function ValidaCapitalizacion(ByVal Ejercicio As Integer, ByVal Mes As Integer) As Integer
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar("coo_spGetValidaCapitalizacion", Ejercicio, Mes), 0)
        Return NumeroReg
    End Function
    Public Function ValidaDevolucionAhorro(ByVal Ejercicio As Integer) As Integer
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar("spGetValidaDevolucionAhorro", Ejercicio), 0)
        Return NumeroReg
    End Function
    Public Function coo_PignoracionesSelectByCuenta(ByVal IdCuenta As Int32) As coo_Pignoraciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PignoracionesSelectByCuenta", _
         IdCuenta _
         ).Tables(0)
        Dim Entidad As New coo_Pignoraciones
        If dt.Rows.Count > 0 Then
            Entidad.IdPignoracion = dt.Rows(0).Item("IdPignoracion")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.FechaPignoracion = dt.Rows(0).Item("FechaPignoracion")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.Activa = dt.Rows(0).Item("Activa")
            Entidad.Manual = dt.Rows(0).Item("Manual")
            Entidad.FechaReversion = fd.SiEsNulo(dt.Rows(0).Item("FechaReversion"), Nothing)
            Entidad.RevertidoPor = fd.SiEsNulo(dt.Rows(0).Item("RevertidoPor"), Nothing)
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function
    Public Function InsertaCuentaAhorro _
 (ByRef entCuentaAhorro As coo_CuentasAhorro, ByRef entBeneficiario As List(Of coo_CuentasAhorroBeneficiarios) _
  , ByRef entAutorizado As List(Of coo_CuentasAhorroAutorizado)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entCuentaAhorro.IdCuenta = fd.ObtenerUltimoId("Coo_CuentasAhorro", "IdCuenta") + 1

            Dim sql As String = "update coo_TiposCuentaAhorro set Correlativo = Correlativo + 1 WHERE IdTipo=" & entCuentaAhorro.IdTipoCuenta
            db.ExecuteNonQuery(CommandType.Text, sql)
            'sql &= ";select Correlativo from coo_TiposCuentaAhorro where IdTipo=" & entCuentaAhorro.IdTipoCuenta

            ''entCuentaAhorro.Numero = entCuentaAhorro.IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(7, "0") & "-" & entCuentaAhorro.IdTipoCuenta.ToString.PadLeft(2, "0")
            objTabla.coo_CuentasAhorroInsert(entCuentaAhorro, tran)

            For Each detalle As coo_CuentasAhorroBeneficiarios In entBeneficiario
                detalle.IdCuenta = entCuentaAhorro.IdCuenta
                objTabla.coo_CuentasAhorroBeneficiariosInsert(detalle, tran)
            Next

            For Each detalle As coo_CuentasAhorroAutorizado In entAutorizado
                detalle.IdCuenta = entCuentaAhorro.IdCuenta
                objTabla.coo_CuentasAhorroAutorizadoInsert(detalle, tran)
            Next
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function
    Public Function InsertaPignoracion(ByRef entPignoracion As coo_Pignoraciones) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entPignoracion.IdPignoracion = fd.ObtenerUltimoId("Coo_Pignoraciones", "IdPignoracion") + 1
            objTabla.coo_PignoracionesInsert(entPignoracion, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function
    Public Function LiberarFondoDeposito(ByVal IdCuenta As Integer, ByVal Idmov As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            Dim sSQL As String = "update coo_CuentasAhorroMov set Pignorado = 0 WHERE IdCuenta=" & IdCuenta & " AND IdMov= " & Idmov
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
    Public Function UpdateCuentaAhorro _
(ByRef entCuentaAhorro As coo_CuentasAhorro _
    , ByRef entBeneficiario As List(Of coo_CuentasAhorroBeneficiarios), ByRef entAutorizado As List(Of coo_CuentasAhorroAutorizado)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_CuentasAhorroUpdate(entCuentaAhorro, tran)

            Dim sSQL As String = "delete coo_CuentasAhorroBeneficiarios where IdCuenta=" & entCuentaAhorro.IdCuenta
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            Dim sSQL2 As String = "delete coo_CuentasAhorroAutorizado where IdCuenta=" & entCuentaAhorro.IdCuenta
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL2)

            For Each detalle As coo_CuentasAhorroBeneficiarios In entBeneficiario
                detalle.IdCuenta = entCuentaAhorro.IdCuenta
                objTabla.coo_CuentasAhorroBeneficiariosInsert(detalle, tran)
            Next

            For Each detalle As coo_CuentasAhorroAutorizado In entAutorizado
                detalle.IdCuenta = entCuentaAhorro.IdCuenta
                objTabla.coo_CuentasAhorroAutorizadoInsert(detalle, tran)
            Next
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj

    End Function
    Public Function rptContratoAhorro(ByVal IdCuenta As Integer) As coo_ContratoAhorro

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spContratoAhorro", IdCuenta).Tables(0)

        Dim Entidad As New coo_ContratoAhorro
        If dt.Rows.Count > 0 Then
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroAsociado = dt.Rows(0).Item("NumeroAsociado")
            Entidad.NombreAsociado = dt.Rows(0).Item("NombreAsociado")
            Entidad.Profesion = dt.Rows(0).Item("Profesion")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.NombreCuenta = dt.Rows(0).Item("NombreCuenta")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.Municipio = dt.Rows(0).Item("Municipio")
            Entidad.NumeroDocumento = dt.Rows(0).Item("NumeroDocumento")
            Entidad.TasaApertura = dt.Rows(0).Item("TasaApertura")
        End If
        Return Entidad
    End Function
    Public Function rptContratoAhorro2(ByVal IdAsociado As Integer) As DataTable

        Dim dt As DataTable
        Dim Sql = "select A.IdAsociado, Nombre=A.Nombres+' '+A.apellidos, A.IsssAfp Isss, d.Descuento CuotaAhorro, d.Idplanilla TipoDescuento "
        Sql += " from coo_Asociados A inner join coo_asociadosdescuentos d on a.idasociado = d.idasociado"
        Sql += " where d.idrubro = 3 and a.idasociado = " & IdAsociado
        dt = db.ExecuteDataSet(CommandType.Text, Sql).Tables(0)
        Return dt
    End Function
    Public Function rptDeclaracionJurada(ByVal IdCuenta As Integer) As coo_DeclaracionJurada

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spDeclaracionJurada", IdCuenta).Tables(0)

        Dim Entidad As New coo_DeclaracionJurada
        If dt.Rows.Count > 0 Then
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroAsociado = dt.Rows(0).Item("NumeroAsociado")
            Entidad.NombreAsociado = dt.Rows(0).Item("NombreAsociado")
            Entidad.Profesion = dt.Rows(0).Item("Profesion")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.NombreCuenta = dt.Rows(0).Item("NombreCuenta")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.Municipio = dt.Rows(0).Item("Municipio")
            Entidad.Dui = dt.Rows(0).Item("Dui")
            Entidad.TasaApertura = dt.Rows(0).Item("TasaApertura")
            Entidad.Nit = dt.Rows(0).Item("Nit")
            Entidad.FechaApertura = dt.Rows(0).Item("FechaApertura")
            Entidad.MontoApertura = dt.Rows(0).Item("MontoApertura")
            Entidad.Sucursal = dt.Rows(0).Item("Sucursal")
            Entidad.OrigenFondos = dt.Rows(0).Item("OrigenFondos")
        End If
        Return Entidad
    End Function
    Public Function rptRegistroFirmasAhorro(ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spRegistroFirmasAhorro", IdCuenta).Tables(0)
    End Function
    Public Function rptCertificadoAhorro(ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spCertificadoAhorro", IdCuenta).Tables(0)
    End Function

    Public Function CambioTasaAhorro(ByVal IdCuenta As Integer, ByVal Tasa As Decimal, ByVal FechaContable As Date, ByVal CreadoPor As String) As String
        Return db.ExecuteScalar("coo_spCambioTasaInteresAhorro", IdCuenta, Tasa, FechaContable, CreadoPor)
    End Function

    Public Function coo_spCuentasAhorroMovSelectByPK(ByVal NumeroDoc As String) As coo_CuentasAhorroMov
        Dim dt As DataTable = db.ExecuteDataSet("coo_spCuentasAhorroMovSelectByPK", NumeroDoc).Tables(0)

        Dim Entidad As New coo_CuentasAhorroMov
        If dt.Rows.Count > 0 Then
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.IdMov = dt.Rows(0).Item("IdMov")
            Entidad.NumeroDoc = dt.Rows(0).Item("NumeroDoc")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.IdTipo = dt.Rows(0).Item("IdTipo")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.Saldo = dt.Rows(0).Item("Saldo")
            Entidad.LineaLibreta = dt.Rows(0).Item("LineaLibreta")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.FechaContable = dt.Rows(0).Item("FechaContable")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.Pignorado = dt.Rows(0).Item("Pignorado")
            Entidad.Observaciones = dt.Rows(0).Item("Observaciones")
            Entidad.Impreso = dt.Rows(0).Item("Impreso")
            Entidad.IdAutorizado = dt.Rows(0).Item("IdAutorizado")
            Entidad.DocAutorizado = dt.Rows(0).Item("DocAutorizado")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function
    Public Function CapitalizacionAhorro(ByVal DesdeFecha As Date, ByVal HastaFecha As Date, ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal CreadoPor As String) As String
        Dim i As String = db.ExecuteScalar("coo_spCapitalizacionAhorro", DesdeFecha, HastaFecha, Ejercicio, Mes, CreadoPor)
        Dim sSQL As String
        If i <> "" Then
            Return i
        Else
            'elimino el mes que se está cerrando 
            sSQL = "delete coo_CierresAhorro where mes=@Mes and Ejercicio=@Ejercicio and HastaCierre =@HastaFecha"
            Dim cmd As DbCommand = db.GetSqlStringCommand(sSQL)
            db.AddInParameter(cmd, "@Mes", DbType.Int32, Mes)
            db.AddInParameter(cmd, "@Ejercicio", DbType.Int32, Ejercicio)
            db.AddInParameter(cmd, "@HastaFecha", DbType.Date, HastaFecha)
            db.ExecuteScalar(cmd)

            '-- inserto el mes cerrado
            sSQL = "insert coo_CierresAhorro (mes, ejercicio,DesdeCierre, HastaCierre, CreadoPor) values ('"
            sSQL &= Mes & "','" & Ejercicio & "','" & Format(DesdeFecha, "yyyyMMdd") & "','" & Format(HastaFecha, "yyyyMMdd") & "','" & CreadoPor & "')"
            'sSQL &= Mes & "','" & Ejercicio & "','" & CreadoPor & "')"

            db.ExecuteNonQuery(CommandType.Text, sSQL)
            Return i
        End If
    End Function
    Public Function DevolucionAhorro(ByVal Fecha As Date, ByVal TipoCuenta As Integer, ByVal IdSucursal As Integer, ByVal Papeleria As Decimal, ByVal DescuentoDesde As Decimal, ByVal CreadoPor As String) As String

        Dim i As String = db.ExecuteScalar("coo_spDevolucionAhorro", Fecha, TipoCuenta, IdSucursal, Papeleria, DescuentoDesde, CreadoPor)
        Return i

    End Function

    Public Function CapitalizacionPlazo(ByVal Fecha As Date, ByVal IdSucursal As Integer, ByVal CreadoPor As String) As String
        Dim i As String = db.ExecuteScalar("coo_spCapitalizacionPlazo", Fecha, IdSucursal, CreadoPor)
        If i <> "" Then
            Return i
        Else
            Return i
        End If
    End Function

    Public Function RevierteCapitalizacion(ByVal Ejercicio As Integer, ByVal Mes As Integer) As Integer
        Dim NumeroReg As Integer = 1
        If db.ExecuteScalar("coo_spRevierteCapitalizacion", Ejercicio, Mes) = "" Then
            NumeroReg = 0
        End If
        Dim sSQL As String
        'elimino el mes que se está cerrando 
        sSQL = "delete coo_CierresAhorro where mes=@Mes and Ejercicio=@Ejercicio"
        Dim cmd As DbCommand = db.GetSqlStringCommand(sSQL)
        db.AddInParameter(cmd, "@Mes", DbType.Int32, Mes)
        db.AddInParameter(cmd, "@Ejercicio", DbType.Int32, Ejercicio)
        db.ExecuteScalar(cmd)

        Return NumeroReg
    End Function
    Public Function RevierteDevolucion(ByVal Ejercicio As Integer) As Integer
        Dim NumeroReg As Integer = 1
        If db.ExecuteScalar("coo_spRevierteDevolucion", Ejercicio) = "" Then
            NumeroReg = 0
        End If
        Return NumeroReg
    End Function

    Public Function rptMovimientoCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spMovimientoCuentaAhorro", IdCuenta, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptPignoracionCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spPignoracionCuentaAhorro", IdCuenta, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoCuentaAhorro(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, _
    ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCuentasAhorro", IdSucursal, HastaFecha, IdEstado, IdTipo, IdCentro, Incluir).Tables(0)
    End Function

    Public Function rptListadoCuentasInactivas(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, _
 ByVal IdTipo As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCuentasInactivas", IdSucursal, HastaFecha, IdTipo, Incluir).Tables(0)
    End Function


    Public Function rptListadoCuentaAhorroAsociado(ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCuentasAhorroAsociado", HastaFecha, IdAsociado).Tables(0)
    End Function

    Public Function rptListadoDepositosPlazo(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, _
    ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal Idcentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDepositosPlazo", IdSucursal, DesdeFecha, HastaFecha, IdEstado, IdTipo, Idcentro, Incluir).Tables(0)
    End Function

    Public Function GetIdMovAhorro(ByVal Numero As String, ByVal IdCuenta As Integer) As Integer
        Dim sSql As String = "select IdMov from coo_CuentasAhorroMov where NumeroDoc= '" & Numero & "'" & " AND IdCuenta=" & IdCuenta
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function

    Public Function rptDepositoAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteDepositoAhorro", NumeroComp, IdCuenta).Tables(0)
    End Function

    Public Function rptRetiroAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteRetiroAhorro", NumeroComp, IdCuenta).Tables(0)
    End Function

    Public Function rptDetalleMovimientos(ByVal IdSucursal As Integer, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spDetalleMovimientoAhorro", IdSucursal, IdTipo, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptAcumuladoMovimientos(ByVal IdSucursal As Integer, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spAcumuladoMovimientoAhorro", IdSucursal, IdTipo, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptInteresCuentaCapitalizado(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, _
    ByVal HastaFecha As DateTime, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spInteresCuentasCapitalizado", IdSucursal, DesdeFecha, HastaFecha, IdTipo, IdCentro, Incluir).Tables(0)
    End Function

    Public Function rptListadoDepositosVencer(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, _
    ByVal HastaFecha As DateTime, ByVal IdTipo As Integer, ByVal IdCentro As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDepositosVencer", IdSucursal, DesdeFecha, HastaFecha, IdTipo, IdCentro).Tables(0)
    End Function

    Public Function rptProvisionInteres(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer, ByVal Mes As Integer, _
    ByVal IdCentro As Integer, ByVal IncluirInt As Boolean, ByVal IncluirDep As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spProvisionInteresAhorro", IdSucursal, Ejercicio, Mes, IdCentro, IncluirInt, IncluirDep, 0, "", "").Tables(0)
    End Function
    Public Function PartidaProvisionInteres(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer, ByVal Mes As Integer, _
ByVal IdCentro As Integer, ByVal IncluirInt As Boolean, ByVal IncluirDep As Boolean, ByVal CreadoPor As String) As Integer

        Dim ConceptoPartida As String = "PROVISION DE INTERESES DEL PERIODO " + UCase(MonthName(Mes)) + " " + Ejercicio.ToString
        Return db.ExecuteScalar("coo_spProvisionInteresAhorro", IdSucursal, Ejercicio, Mes, IdCentro, IncluirInt, IncluirDep, 1, CreadoPor, ConceptoPartida)
    End Function


    Public Function rptListadoCapitalizacionInteres(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, _
    ByVal Mes As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCapitalizacionInteres", IdSucursal, ejercicio, Mes, IdCentro, Incluir).Tables(0)
    End Function

    Public Function rptListadoCuentasMesTipo(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer, _
    ByVal IdCentro As Integer, ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCuentasMesTipo", IdSucursal, ejercicio, Mes, IdCentro, IdEstado, IdTipo, Incluir).Tables(0)
    End Function

    Public Function rptProvisionIsr(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spProvisionIsr", IdSucursal, ejercicio, Mes).Tables(0)
    End Function

    Public Function rptIsrAplicadoInteres(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer, ByVal IdCentro As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spIsrAplicadoInteres", IdSucursal, ejercicio, Mes, IdCentro).Tables(0)
    End Function

    Public Function coo_spGarantiasCuentaPignoradaSelectByPK _
  (ByVal IdCuenta As System.Int32 _
  ) As coo_GarantiasCuentaPignorada

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spGarantiasCuentaPignoradaSelectByPK", IdCuenta).Tables(0)

        Dim Entidad As New coo_GarantiasCuentaPignorada
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdGarantia = dt.Rows(0).Item("IdGarantia")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Nombres = dt.Rows(0).Item("Nombres")
            Entidad.ValorPignorado = dt.Rows(0).Item("ValorPignorado")
            Entidad.Aplicado = dt.Rows(0).Item("Aplicado")
            Entidad.Manual = dt.Rows(0).Item("Manual")
            Entidad.FechaReversion = fd.SiEsNulo(dt.Rows(0).Item("FechaReversion"), Nothing)
            Entidad.Usuario = fd.SiEsNulo(dt.Rows(0).Item("Usuario"), Nothing)
            Entidad.Fecha = fd.SiEsNulo(dt.Rows(0).Item("Fecha"), Nothing)
        End If
        Return Entidad
    End Function

    Public Function ObtenerPignoraciones(ByVal IdSucursal As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListaPignoraciones").Tables(0)
    End Function

    Public Function RevertirPignoracion(ByVal IdPignoracion As Integer, ByVal Usuario As String) As Integer
        Dim sql As String = String.Format("update coo_Pignoraciones set Activa= 0, RevertidoPor='{0}', FechaReversion=getdate() where IdPignoracion={1}", Usuario, IdPignoracion)
        Return db.ExecuteNonQuery(CommandType.Text, sql)
    End Function

    Public Function GetUltMovAhorro(ByVal IdCuenta As Integer) As Integer
        Dim IdMov As Decimal = db.ExecuteScalar("coo_spGetUlMovAhorro", IdCuenta)
        Return IdMov
    End Function
    Public Function GetCuentaAhorroPrestamo(ByVal IdAsociado As Integer) As Integer
        Dim sSQL = "Select top 1 IdCuenta from  coo_CuentasAhorro where IdTipoCuenta = 1 and IdAsociado = " & IdAsociado
        Dim IdCuenta As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return IdCuenta
    End Function

    Public Function GetCuentaAhorroCorriente(ByVal IdAsociado As Integer) As Integer
        Dim sSQL = "Select top 1 IdCuenta from  coo_CuentasAhorro where IdTipoCuenta = 2 and IdAsociado = " & IdAsociado
        Dim IdCuenta As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return IdCuenta
    End Function
    Public Function GetCuentaAhorroCorrientePla(ByVal IdAsociado As Integer) As Integer
        Dim sSQL = "Select top 1 IdCuenta from  coo_CuentasAhorro where IdTipoCuenta = 1 and IdAsociado = " & IdAsociado
        Dim IdCuenta As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return IdCuenta
    End Function

    Public Function GetSaldoAhorro(ByVal IdCuenta As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoAhorro", IdCuenta)
        Return Saldo
    End Function

    Public Function GetUltLineaAhorro(ByVal IdCuenta As Integer) As Integer
        Dim Linea As Decimal = db.ExecuteScalar("coo_spGetUltLineaAhorro", IdCuenta)
        Return Linea
    End Function

    Public Function rptBoletaDevolucionAhorro(ByVal IdSucursal As Integer, ByVal IdTipoCuenta As Integer, ByVal IdCentro As Integer, ByVal Ejercicio As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spBoletaDevolucionAhorro", IdSucursal, IdTipoCuenta, IdCentro, Ejercicio).Tables(0)
    End Function

    Public Function coo_GetCtaAhorroSimultaneo(ByVal IdAsociado As Integer) As DataTable
        Dim sSQL As String = "coo_spGetCuentaSimultaneo"
        Return db.ExecuteDataSet(sSQL, IdAsociado).Tables(0)
    End Function

End Class
