Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports DBCoopEL.TableEntities
Public Class AportacionesDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTabla As New TableData

    Public Function rptSolicitudAdmision(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudAdmision", IdAsociado).Tables(0)
    End Function

    Public Function rptAsociadosBeneficiarios(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spAsociadosBeneficiarios", IdAsociado).Tables(0)
    End Function

    Public Function rptFichaAsociado(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spFichaAsociado", IdAsociado).Tables(0)
    End Function
    Public Function RevierteDividendos(ByVal Ejercicio As Integer) As Integer
        Dim NumeroReg As Integer = 1
        If db.ExecuteScalar("coo_spRevierteDividendos", Ejercicio) = "" Then
            NumeroReg = 0
        End If
        Return NumeroReg
    End Function
    Public Function rptDatosDeclaracionJuradaAsociado(ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spDeclaracionJuradaAsociado", IdAsociado).Tables(0)
    End Function
    Public Function coo_spAportacionesSelectByPK(ByVal NumeroDoc As String) As coo_Aportaciones
        Dim dt As DataTable = db.ExecuteDataSet("coo_spAportacionesSelectByPK", NumeroDoc).Tables(0)

        Dim Entidad As New coo_Aportaciones
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.IdMov = dt.Rows(0).Item("IdMov")
            Entidad.IdTipo = dt.Rows(0).Item("IdTipo")
            Entidad.NumeroDoc = dt.Rows(0).Item("NumeroDoc")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.Cargo = dt.Rows(0).Item("Cargo")
            Entidad.Abono = dt.Rows(0).Item("Abono")
            Entidad.Saldo = dt.Rows(0).Item("Saldo")
            Entidad.LineaLibreta = dt.Rows(0).Item("LineaLibreta")
            Entidad.Impreso = dt.Rows(0).Item("Impreso")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.FechaContable = dt.Rows(0).Item("FechaContable")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function

    Public Function ExisteNumAsociado(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdAsociado from coo_Asociados where  Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function

    Public Function GetIdMovAportacion(ByVal Numero As String, ByVal IdAsociado As Integer) As Integer
        Dim sSql As String = "select IdMov from coo_Aportaciones where NumeroDoc= '" & Numero & "'" & " AND IdAsociado=" & IdAsociado
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function

    Public Function rptLiquidacionAportacion(ByVal NumeroDoc As String, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spLiquidacionAportacion", NumeroDoc, IdAsociado).Tables(0)
    End Function

    Public Function rptBoletasDividendos(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal Periodo As Integer, ByVal IdAsociado As Integer, ByVal FechaAsamblea As Date) As DataTable
        Return db.ExecuteDataSet("coo_spBoletasDividendos", IdSucursal, IdCentro, Periodo, IdAsociado, FechaAsamblea).Tables(0)
    End Function
    Public Function RecalculaSaldoAportacion(ByVal IdAsociado As Integer) As Integer
        Return db.ExecuteScalar("coo_spRecalculaSaldoAportacion", IdAsociado)
    End Function


    Public Function rptEstadoCuentaAportacion(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaAportacion", IdAsociado, Fecha).Tables(0)
    End Function
    Public Function rptPrestamosPagoDesgloze(ByVal Referencia As String, ByVal IdAsociado As String, ByVal Correo As Boolean) As DataTable
        'Dim Condicion As String = ""
        'If IdAsociado.ToString = "" Then
        '    IdAsociado = 0
        'End If
        'If Correo = True Then
        '    Condicion = " and a.CorreoElectronico<>'' "
        'End If
        'Dim sSQL As String = "declare @IdAsociado as int  set @IdAsociado=" & IdAsociado & " if @IdAsociado=0 set @IdAsociado=null Select p.IdAsociado,p.TasaInteres,dt.Idprestamo,a.CorreoElectronico FROM coo_PrestamosDetalle dt INNER JOIN coo_Prestamos p ON dt.IdPrestamo=p.IdPrestamo  "
        'sSQL += " INNER JOIN Coo_Asociados a on p.IdAsociado=a.IdAsociado "
        'sSQL += " WHERE dt.Numero='" & Referencia & "' and p.Idasociado=isnull(@IdAsociado,p.IdAsociado) " & Condicion
        'Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
        Return db.ExecuteDataSet("coo_spPrestamosPagoDesgloze", Referencia, IdAsociado, Correo).Tables(0)
    End Function
    Public Function rptEstadoCuentaGeneral(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal SoloSocios As Boolean, ByVal Enviar As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaGeneral", IdAsociado, Fecha, SoloSocios, Enviar).Tables(0)
    End Function

    Public Function rptProgramacionSocio(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spProgramacionSocios", IdAsociado, Fecha).Tables(0)
    End Function
    Public Function rptCambioDescuentosSocios(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCambioDescuentosSocios", IdAsociado, Fecha).Tables(0)
    End Function


    Public Function rptEstadoCuentaAyuda(ByVal IdAsociado As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaAyuda", IdAsociado, Desde, Hasta).Tables(0)
    End Function

    Public Function rptAportacionesFechaSexo(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spAportacionesFechaSexo", IdSucursal, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptSolicitudRetiro(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudRetiro", IdAsociado, Fecha).Tables(0)
    End Function



    Public Function rptSaldosAsociados(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal HastaFecha As DateTime, ByVal TipoReporte As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSaldosAsociados", IdSucursal, IdCentro, HastaFecha, TipoReporte).Tables(0)
    End Function
    Public Function rptPorcenAhorroSocio(ByVal IdCentro As Integer) As DataTable
        Dim sSQL As String = "Select aso.IdAsociado, aso.Numero, Nombres=aso.nombres+' '+aso.apellidos,Ubicacion= ubi.nombre, Porcen=aso.CuotaPresEfectivo from coo_asociados aso"
        sSQL += " inner join coo_UbicacionesAsociados ubi on aso.idubicacion = ubi.idubicacion where aso.CuotaPresEfectivo <> 0.0"
        If IdCentro <> -1 Then
            sSQL += " and aso.idubicacion = " & IdCentro
        End If
        sSQL += " order by aso.idubicacion, aso.nombres"

        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function rptSaldosAsociados(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spSaldosAsociadosAhorroAportacion", IdSucursal, IdCentro, IdAsociado, HastaFecha).Tables(0)
    End Function
    Public Function rptRepartoDividendo(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
    , ByVal Utilidad As Decimal, ByVal Porcentaje As Decimal, ByVal AyudaFuneraria As Decimal _
    , ByVal Incluir As Boolean, ByRef entDivLineas As List(Of coo_DividendosLineas), ByVal Periodo As Integer _
    , ByVal Todas As Boolean, ByVal DescPapeleria As Decimal, ByVal PapeleriaDesde As Decimal) As DataTable

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj As String = ""
        Try

            Dim sSQL As String = "delete coo_DividendosLineas  where Periodo= " & Periodo
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As coo_DividendosLineas In entDivLineas
                objTabla.coo_DividendosLineasInsert(detalle, tran)
            Next

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        If Todas Then
            Return db.ExecuteDataSet("coo_spReporteRepartoDividendoDet2", IdSucursal, HastaFecha, Utilidad, Porcentaje _
            , AyudaFuneraria, Incluir, DescPapeleria, PapeleriaDesde).Tables(0)
        Else
            Return db.ExecuteDataSet("coo_spReporteRepartoDividendo", IdSucursal, HastaFecha, Utilidad, Porcentaje _
            , AyudaFuneraria, Incluir, DescPapeleria, PapeleriaDesde).Tables(0)
        End If

    End Function

    Public Function rptHistorialDividendo(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Dim sql As String = "Select NumeroAsociado=aso.Numero, Nombre=aso.Nombres+' '+aso.apellidos, d.* from coo_Dividendos d inner join coo_asociados aso on d.idasociado = aso.idasociado"
        sql += " where d.periodo = " & HastaFecha.Year
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function rptArchivoF915(ByVal Año1 As Integer, ByVal Año2 As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spArchivoF915", Año1, Año2).Tables(0)
    End Function

    Public Function rptMovimientoFechaAportacion(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal TipoReporte As Integer, ByVal IdForma As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spMovimientoFechaAportacion", IdSucursal, IdCentro, DesdeFecha, HastaFecha, TipoReporte, IdForma).Tables(0)
    End Function
    Public Function rptAportacionesPorPagarRetiroTotal(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spAportacionesPorPagarRetiros", IdSucursal, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptMovimientoFechaAyuda(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spMovimientoFechaAyuda", IdSucursal, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function


    Function ObtenerIdAsociado(ByVal IdAsociado As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdAsociado
        End If
        Dim sSQL As String = String.Format("select top 1 IdAsociado from coo_Asociados where IdAsociado < {0} order by IdAsociado desc", IdAsociado)
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdAsociado from coo_Asociados where IdAsociado > " & IdAsociado
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

    Public Function GetBeneficiarios(ByVal IdAsociado As Integer) As DataTable
        Dim sql As String = "select * from coo_AsociadosBeneficiarios where IdAsociado=" & IdAsociado
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function InsertaAsociado(ByRef entAsociado As coo_Asociados, ByRef entBeneficiario As List(Of coo_AsociadosBeneficiarios), ByRef entDescuentos As List(Of coo_AsociadosDescuentos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entAsociado.IdAsociado = fd.ObtenerUltimoId("COO_ASOCIADOS", "IdAsociado") + 1

            objTabla.coo_AsociadosInsert(entAsociado, tran)

            For Each detalle As coo_AsociadosBeneficiarios In entBeneficiario
                detalle.IdAsociado = entAsociado.IdAsociado
                objTabla.coo_AsociadosBeneficiariosInsert(detalle, tran)
            Next

            For Each detalle As coo_AsociadosDescuentos In entDescuentos
                detalle.IdAsociado = entAsociado.IdAsociado
                objTabla.coo_AsociadosDescuentosInsert(detalle, tran)
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

    Public Function InsertaAyudaFuneraria(ByRef entAyuda As coo_AyudaFuneraria) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            entAyuda.IdMovimiento = fd.ObtenerUltimoId("COO_AYUDAFUNERARIA", "IdMovimiento") + 1
            objTabla.coo_AyudaFunerariaInsert(entAyuda, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function

    Public Function ActualizaFuneraria(ByRef entAyuda As coo_AyudaFuneraria) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            objTabla.coo_AyudaFunerariaUpdate(entAyuda, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function
    Public Function UpdateAsociado(ByRef entAsociado As coo_Asociados _
        , ByRef entBeneficiario As List(Of coo_AsociadosBeneficiarios) _
, ByRef entDescuentos As List(Of coo_AsociadosDescuentos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj As String = ""
        Try
            objTabla.coo_AsociadosUpdate(entAsociado, tran)
            Dim sSQL As String = "delete coo_AsociadosBeneficiarios where IdAsociado=" & entAsociado.IdAsociado
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As coo_AsociadosBeneficiarios In entBeneficiario
                detalle.IdAsociado = entAsociado.IdAsociado
                objTabla.coo_AsociadosBeneficiariosInsert(detalle, tran)
            Next

            Dim sSQL2 As String = "delete coo_AsociadosDescuentos where IdAsociado=" & entAsociado.IdAsociado
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL2)

            For Each detalle As coo_AsociadosDescuentos In entDescuentos
                detalle.IdAsociado = entAsociado.IdAsociado
                objTabla.coo_AsociadosDescuentosInsert(detalle, tran)
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

    Public Function InsertaLiquidacionAportacion _
        (ByRef entLiquidacion As coo_LiquidacionAportaciones, ByVal IdAsociado As Integer, ByVal FechaLiquidacion As DateTime) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Dim msj As String = ""
        Try
            If entLiquidacion.TotalRetiro = entLiquidacion.TotalAportaciones Then 'el asociado se retira totalmente de la cooperativa
                Dim sql As String = String.Format("Update coo_Asociados set IdEstado = 2, FechaRetiro = '{0}' Where IdAsociado ={1}", Format(FechaLiquidacion, "yyyyMMdd"), IdAsociado)
                db.ExecuteScalar(tran, CommandType.Text, sql)
            End If

            objTabla.coo_LiquidacionAportacionesInsert(entLiquidacion, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function GetSaldoAporta(ByVal IdAsociado As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoAporta", IdAsociado)
        Return Saldo
    End Function
    Public Function GetSaldoFune(ByVal IdAsociado As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoFune", IdAsociado)
        Return Saldo
    End Function

    Public Function GetUltLineaAporta(ByVal IdAsociado As Integer) As Integer
        Dim Linea As Decimal = db.ExecuteScalar("coo_spGetUltLineaAporta", IdAsociado)
        Return Linea
    End Function

    Public Function GetUltMovAporta(ByVal IdAsociado As Integer) As Integer
        Dim IdMov As Integer = db.ExecuteScalar("coo_spGetUlMovAporta", IdAsociado)
        Return IdMov
    End Function
    Public Function GetUltMovFune(ByVal IdAsociado As Integer) As Integer
        Dim IdMov As Integer = db.ExecuteScalar("coo_spGetUlMovFune", IdAsociado)
        Return IdMov
    End Function
    '

    Public Function GetUltFechaAporta(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Dim fecha As Nullable(Of Date) = fd.SiEsNulo(db.ExecuteScalar("coo_spGetUltFechaAporta", IdAsociado), Nothing)
        Return fecha
    End Function
    Public Function GetUltFechaFune(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Dim fecha As Nullable(Of Date) = fd.SiEsNulo(db.ExecuteScalar("coo_spGetUltFechaAyudaFuneraria", IdAsociado), Nothing)
        Return fecha
    End Function

    Public Function SiExisteRepDiv(ByVal Periodo As Integer) As Integer
        Dim sSql As String = "select * from coo_Dividendos where periodo=" & Periodo
        Dim Existe As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return Existe
    End Function


    Public Function rptListadoAspirantes(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAspirantes", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoGeneralAsociados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoGeneralAsociados", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoAsociadosActivos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime _
    , ByVal HastaFecha As DateTime, ByVal SinEnvios As Boolean, ByVal SinDividendo As Boolean, ByVal SinFunerarias As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosActivos", IdSucursal, DesdeFecha, HastaFecha, SinEnvios, SinDividendo, SinFunerarias).Tables(0)
    End Function
    Public Function rptListadoAsociadosSinActividad(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosSinActividad", IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptListadoAsociadosDescMenorEnviado(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal SoloMenor As Boolean, ByVal Detalle As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosDescuentoMenorEnviado", IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha, SoloMenor, Detalle).Tables(0)
    End Function
    Public Function rptListadoAsociadosSobregirados(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal SoloSobregirados As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosSobregirados", IdSucursal, HastaFecha, SoloSobregirados).Tables(0)
    End Function

    Public Function rptListadoReintegros(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal SoloPendiente As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoReintegros", IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha, SoloPendiente).Tables(0)
    End Function


    Public Function rptListadoAsociadosSinAhorrosPrestamos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosSinRubros", IdSucursal, HastaFecha).Tables(0)
    End Function


    Public Function rptListadoIngresosAsociados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoIngresosAsociados", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptListadoAyudaFuneraria(ByVal IdAsociado As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Dim sql As String = "Select a.IdAsociado, NumAsociado=aso.Numero, Nombres= aso.nombres+' '+aso.apellidos"
        sql += ", A.NombreFamiliar, a.FechaServicio, a.ParentescoFamiliar, a.CantidadOtorgada from coo_AyudaFuneraria  a "
        sql += "inner join coo_asociados aso on a.idasociado = aso.idasociado where a.IdAsociado = " & IdAsociado
        sql += " and a.FechaServicio > " & DesdeFecha
        sql += " and a.fechaServicio < dateadd(dd,1,a.FechaServicio) "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptListadoIngresosAfiliaciones(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoIngresosAfiliaciones", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoDescuentosAportaciones(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDescuentosAportaciones", IdSucursal, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoAsociadosInactivos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosInactivos", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptListadoAsociadosRetirados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal Estado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAsociadosRetirados", IdSucursal, DesdeFecha, HastaFecha, Estado).Tables(0)
    End Function

    Public Function InsertaDividendos(ByRef entDiv As List(Of coo_Dividendos)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj As String = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            For Each detalle As coo_Dividendos In entDiv
                objTabla.coo_DividendosInsert(detalle, tran)
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
    Function ObtenerParametrosGenerales() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from adm_parametros").Tables(0)
    End Function
End Class