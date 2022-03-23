Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports DBCoopEL.TableEntities

Public Class PrestamosDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTabla As New TableData
    
    
    Function ObtenerIdFuente(ByVal IdFuente As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdFuente
        End If
        Dim sSQL As String = "select top 1 IdFuente from coo_Fuentes where IdFuente < " & IdFuente & " order by IdFuente desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdFuente from coo_Fuentes where IdFuente > " & IdFuente
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function ObtenerImpresorDefault(ByVal IdUsuario As String) As String
        Dim sql As String = String.Format("select ImpresorPredeterminado from adm_Usuarios where IdUsuario='{0}'", IdUsuario)
        Return db.ExecuteScalar(CommandType.Text, sql)

    End Function
    Function ObtenerIdLinea(ByVal IdLinea As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdLinea
        End If
        Dim sSQL As String = "select top 1 IdLinea from coo_Lineas where IdLinea < " & IdLinea & " order by IdLinea desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdLinea from coo_Lineas where IdLinea > " & IdLinea
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdDeduccionPrestamo(ByVal IdDeduccion As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdDeduccion
        End If
        Dim sSQL As String = "select top 1 IdDeduccion from coo_DeduccionesPrestamo where IdDeduccion < " & IdDeduccion & " order by IdDeduccion desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdDeduccion from coo_DeduccionesPrestamo where IdDeduccion > " & IdDeduccion
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function ValorChequesDesembolso(ByVal IdSolicitud As Integer) As Decimal
        Dim Valor As Decimal
        Dim sSql As String = "select Cheque=sum(Valor) from coo_SolicitudesEmisionDesembolso where IdSolicitud=" & IdSolicitud
        Valor = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0.0)
        Return Valor
    End Function

    Public Function SaldoLineaAsociado(ByVal IdLinea As Integer, ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As Decimal
        Return db.ExecuteScalar("coo_spSaldoLineaAsociado", IdLinea, IdAsociado, Fecha)
    End Function

    Public Function ActualizarSolicitudFondo(ByVal IdSolicitudFondo As Integer) As Integer
        Dim sSQL As String = "update coo_SolicitudFondos set entregado = 0 WHERE IdSolicitudFondo=" & IdSolicitudFondo
        db.ExecuteNonQuery(CommandType.Text, sSQL)
        Return 0
    End Function

    Public Function EnvioDescuentosPlanillaDespensa(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
    , ByVal TipoPlanilla As Integer, ByVal GuardarEnvio As Boolean, ByVal Detalle As Boolean _
    , ByVal EnvioAhorro As Boolean, ByVal CreadoPor As String) As DataTable
        Return db.ExecuteDataSet("coo_spEnvioDescuentosDespensa", IdSucursal, HastaFecha, TipoPlanilla, GuardarEnvio, Detalle, EnvioAhorro, CreadoPor).Tables(0)
    End Function

    Public Function EnvioDescuentosPlanillaFinanciero(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
, ByVal TipoPlanilla As Integer, ByVal GuardarEnvio As Boolean, ByVal Detalle As Boolean _
, ByVal IdCentro As Integer, ByVal CreadoPor As String, ByVal EnvioRRHH As Boolean, ByVal cheAplicaPlanilla As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spEnvioDescuentosFinanciero", IdSucursal, HastaFecha, TipoPlanilla, GuardarEnvio, Detalle, IdCentro, CreadoPor, EnvioRRHH, cheAplicaPlanilla).Tables(0)
    End Function
    Public Function EnvioDescuentosTelefono() As DataTable
        Return db.ExecuteDataSet("coo_spArchivoDescuentosTelefono").Tables(0)
    End Function
    Public Function ObtenerFechaDescuento(ByVal Fecha As Date) As Integer
        Dim sql As String = String.Format("select IdComprobante from coo_FechasDescuentos where FechaDescuento = '" & Format(Fecha, "yyyyMMdd") + "'")
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function
    Public Function ObtenerUltimasTasas(ByVal IdPrestamo As Integer) As DataTable
        Dim sql As String = "select TasaInteres, TasaInteresMora from coo_PrestamosDetalle where IdPrestamo= " & IdPrestamo
        sql &= " and IdMov = (select max(IdMov) from coo_PrestamosDetalle where IdPrestamo= " & IdPrestamo & ")"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ActualizarAnulacionDesembolso(ByVal IdPrestamo As Integer, ByVal MontoDesembolsado As Decimal) As Integer
        Dim sSQL As String = "update coo_Prestamos set MontoDesembolsado = MontoDesembolsado + " & MontoDesembolsado & " WHERE IdPrestamo=" & IdPrestamo
        db.ExecuteNonQuery(CommandType.Text, sSQL)
        Return 0
    End Function




    Public Function ActualizarSolicitudResolucion(ByVal IdSolicitud As Integer, ByVal CuotaManejo As Decimal, _
                                                  ByVal CuotaAhorro As Decimal, ByVal IncluyeSeguro As Decimal, _
                                                  ByVal CuotaAportacion As Decimal) As Integer
        Dim sSQL As String = "update coo_Solicitudes set CuotaManejo =" & CuotaManejo & ", CuotaAhorro="
        sSQL += CuotaAhorro & " , IncluyeTasaSeguro=" & IncluyeSeguro & " ,CuotaAportacion=" & CuotaAportacion
        sSQL += " WHERE IdSolicitud = " & IdSolicitud
        db.ExecuteNonQuery(CommandType.Text, sSQL)

        Return 0
    End Function

    Public Function ActualizaActaResolucion(ByVal NumActa As Integer) As Integer
        Dim sqlNum As String = " update adm_correlativos set ultimoValor = " & NumActa & " where correlativo = 'RESOLUCION_CREDITO'"
        db.ExecuteNonQuery(CommandType.Text, sqlNum)
        Return 0
    End Function
    'Public Sub ActualizarResolucionGerencia(ByVal entRes As coo_Resoluciones)
    '    'Dim sSQL As String = "update coo_Resoluciones set ComiteActa ='" & ComiteActa & "', RecomendacionGerente='"
    '    'sSQL += Recomendaciones & "' , ResolucionGerente='" & Resolucion & "' , OtrasGerente='" & OtrasGerente & "'"
    '    'sSQL += ", TipoResolucionGerente=" & TipoResolucion & " , MontoGerente=" & Monto & " , CuotasGerente=" & Cuotas
    '    'sSQL += " , TasaGerente=" & Tasa & ", IdFormaPagoGerente=" & IdFormaPago & " , FrecuenciaPagoGerente="
    '    'sSQL += FrecuenciaPago & ", MesGraciaGerente=" & MesGracia & ", TipoTramite='" & TipoTramite
    '    'sSQL += "', IdEstado=" & IdEstado & ", IdSucursal=" & IdSucursal & ",FechaResolucionGerente='" & Format(Fecha, "yyyyMMdd")
    '    'sSQL += "' WHERE IdSolicitud = " & IdSolicitud
    '    'db.ExecuteNonQuery(CommandType.Text, sSQL)
    '    objTabla.coo_ResolucionesUpdate(entRes)
    'End Sub

    'Public Function ActualizarResolucionComite(ByVal IdSolicitud As Integer, ByVal ComiteActa As String, _
    'ByVal Recomendaciones As String, ByVal Resolucion As String, ByVal OtrasComite As String, _
    'ByVal TipoResolucion As Integer, ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer, _
    'ByVal TipoTramite As String, ByVal IdEstado As Integer, ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As Integer
    '    Dim sSQL As String = "update coo_Resoluciones set ComiteActa ='" & ComiteActa & "', RecomendacionComite='"
    '    sSQL += Recomendaciones & "' , ComiteResolucion='" & Resolucion & "' , OtrasComite='" & OtrasComite & "'"
    '    sSQL += ", TipoResolucionComite=" & TipoResolucion & " , MontoComite=" & Monto & " , CuotasComite=" & Cuotas
    '    sSQL += " , TasaComite=" & Tasa & " , IdFormaPagoComite=" & IdFormaPago & " , FrecuenciaPagoComite="
    '    sSQL += FrecuenciaPago & " , MesGraciaComite=" & MesGracia & ", TipoTramite='" & TipoTramite
    '    sSQL += "', IdEstado=" & IdEstado & ", IdSucursal=" & IdSucursal & ", FechaResolucionComite='" & Format(Fecha, "yyyyMMdd")
    '    sSQL += "' WHERE IdSolicitud = " & IdSolicitud
    '    db.ExecuteNonQuery(CommandType.Text, sSQL)
    '    Return 0
    'End Function


    '    Public Function ActualizarResolucionConsejo(ByVal IdSolicitud As Integer, ByVal ConsejoActa As String, _
    'ByVal Recomendaciones As String, ByVal Resolucion As String, ByVal OtrasConsejo As String, _
    'ByVal TipoResolucion As Integer, ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer, _
    'ByVal TipoTramite As String, ByVal IdEstado As Integer, ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As Integer
    '        Dim sSQL As String = "update coo_Resoluciones set ConsejoActa ='" & ConsejoActa & "', RecomendacionConsejo='"
    '        sSQL += Recomendaciones & "' , ConsejoResolucion='" & Resolucion & "' , OtrasConsejo='" & OtrasConsejo & "'"
    '        sSQL += ", TipoResolucionConsejo=" & TipoResolucion & " , MontoConsejo=" & Monto & " , CuotasConsejo=" & Cuotas
    '        sSQL += " , TasaConsejo=" & Tasa & " , IdFormaPagoConsejo=" & IdFormaPago & " , FrecuenciaPagoConsejo="
    '        sSQL += FrecuenciaPago & " , MesGraciaConsejo=" & MesGracia & ", TipoTramite='" & TipoTramite
    '        sSQL += "', IdEstado=" & IdEstado & ", IdSucursal=" & IdSucursal & ", FechaResolucionConsejo='" & Format(Fecha, "yyyyMMdd")
    '        sSQL += "' WHERE IdSolicitud = " & IdSolicitud
    '        db.ExecuteNonQuery(CommandType.Text, sSQL)
    '        Return 0
    '    End Function

    ' Public Function ResolucionAprobadaGerencia(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '     Dim sSQL As String = "update coo_Resoluciones set AutorizaGerencia=1,AutorizaComite=0 ,Aprobada=1,FechaAprobacion='"
    '     sSQL += Format(FechaAprobacion, "yyyyMMdd") & "' , MontoAprobado=" & Monto
    '     sSQL += ", NumeroCuotasAprobada=" & Cuotas & " , TasaInteresAprobada=" & Tasa & ", IdFormaPagoAprobado=" & IdFormaPago
    '     sSQL += " , FrecuenciaPagoAprobado=" & FrecuenciaPago 
    '     sSQL += " WHERE IdSolicitud = " & IdSolicitud
    '     db.ExecuteNonQuery(CommandType.Text, sSQL)
    '     Return 0
    ' End Function


    '    Public Function ResolucionAprobadaComite(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '        Dim sSQL As String = "update coo_Resoluciones set AutorizaGerencia=1,AutorizaComite=1,Aprobada=1,FechaAprobacion='"
    '        sSQL += Format(FechaAprobacion, "yyyyMMdd") & "' , MontoAprobado=" & Monto
    '        sSQL += ", NumeroCuotasAprobada=" & Cuotas & " , TasaInteresAprobada=" & Tasa & ", IdFormaPagoAprobado=" & IdFormaPago
    '        sSQL += " , FrecuenciaPagoAprobado=" & FrecuenciaPago
    '        sSQL += " WHERE IdSolicitud = " & IdSolicitud
    '        db.ExecuteNonQuery(CommandType.Text, sSQL)
    '        Return 0
    '    End Function

    '    Public Function ResolucionAprobadaConsejo(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '        Dim sSQL As String = "update coo_Resoluciones set Aprobada=1,FechaAprobacion='"
    '        sSQL += Format(FechaAprobacion, "yyyyMMdd") & "' , MontoAprobado=" & Monto
    '        sSQL += ", NumeroCuotasAprobada=" & Cuotas & " , TasaInteresAprobada=" & Tasa & ", IdFormaPagoAprobado=" & IdFormaPago
    '        sSQL += " , FrecuenciaPagoAprobado=" & FrecuenciaPago
    '        sSQL += " WHERE IdSolicitud = " & IdSolicitud
    '        db.ExecuteNonQuery(CommandType.Text, sSQL)
    '        Return 0
    '    End Function


    'Public Function ResolucionReprobadaGerencia(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Dim sSQL As String = "update coo_Resoluciones set AutorizaGerencia=0,AutorizaComite=0 ,Aprobada=0,FechaAprobacion='"
    '    sSQL += Format(FechaAprobacion, "yyyyMMdd") & "', MontoAprobado=0, NumeroCuotasAprobada=0"
    '    sSQL += " , FrecuenciaPagoAprobado=0, TasaInteresAprobada=0, IdFormaPagoAprobado=0 WHERE IdSolicitud = " & IdSolicitud
    '    db.ExecuteNonQuery(CommandType.Text, sSQL)
    '    Return 0
    'End Function

    'Public Function ResolucionReprobadaComite(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Dim sSQL As String = "update coo_Resoluciones set AutorizaGerencia=1,AutorizaComite=0,Aprobada=0,FechaAprobacion='"
    '    sSQL += Format(FechaAprobacion, "yyyyMMdd") & "' , MontoAprobado=0 , NumeroCuotasAprobada=0"
    '    sSQL += " , FrecuenciaPagoAprobado=0, TasaInteresAprobada=0, IdFormaPagoAprobado=0 WHERE IdSolicitud = " & IdSolicitud
    '    db.ExecuteNonQuery(CommandType.Text, sSQL)
    '    Return 0
    'End Function

    'Public Function ResolucionReprobadaConsejo(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Dim sSQL As String = "update coo_Resoluciones set Aprobada=0,FechaAprobacion='"
    '    sSQL += Format(FechaAprobacion, "yyyyMMdd") & "' , MontoAprobado=0 , NumeroCuotasAprobada=0"
    '    sSQL += " , FrecuenciaPagoAprobado=0, TasaInteresAprobada=0, IdFormaPagoAprobado=0 WHERE IdSolicitud = " & IdSolicitud
    '    db.ExecuteNonQuery(CommandType.Text, sSQL)
    '    Return 0
    'End Function


    ' Public Function ResolucionRecomendadaGerencia(ByVal IdSolicitud As Integer, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer) As Integer
    '     Dim sSQL As String = "update coo_Resoluciones set AutorizaComite=1,AutorizaGerencia=0 "
    '     sSQL += ", MontoComite=" & Monto & ", CuotasComite=" & Cuotas & " , TasaComite="
    '     sSQL += Tasa & ", IdFormaPagoComite=" & IdFormaPago & " , FrecuenciaPagoComite=" & FrecuenciaPago
    '     sSQL += ",MesGraciaComite=" & MesGracia & " WHERE IdSolicitud = " & IdSolicitud
    '     db.ExecuteNonQuery(CommandType.Text, sSQL)
    '     Return 0
    ' End Function

    ' Public Function ResolucionRecomendadaComite(ByVal IdSolicitud As Integer, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer) As Integer
    '     Dim sSQL As String = "update coo_Resoluciones set AutorizaComite=0,AutorizaGerencia=1,AutorizaConsejo=1 "
    '     sSQL += ", MontoComite=" & Monto & ", CuotasComite=" & Cuotas & " , TasaComite="
    '     sSQL += Tasa & ", IdFormaPagoComite=" & IdFormaPago & " , FrecuenciaPagoComite=" & FrecuenciaPago
    '     sSQL += ",MesGraciaComite=" & MesGracia & " WHERE IdSolicitud = " & IdSolicitud
    '     db.ExecuteNonQuery(CommandType.Text, sSQL)
    '     Return 0
    ' End Function


    Function ObtenerIdFormaPago(ByVal IdFormaPago As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdFormaPago
        End If
        Dim sSQL As String = "select top 1 IdFormaPago from coo_FormasPagoCaja where IdFormaPago < " & IdFormaPago & " order by IdFormaPago desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdFormaPago from coo_FormasPagoCaja where IdFormaPago > " & IdFormaPago
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function FechaDescuentoActiva() As Date
        Dim SQL As String = "select top 1 FechaDescuento from coo_fechasdescuentos where Activo=1 order by fechadescuento desc"
        Return fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, SQL), Nothing)
    End Function
    Public Function FechaDescuentoActivaAntigua() As Date
        Dim SQL As String = "select top 1 FechaDescuento from coo_fechasdescuentos where Activo=1 order by fechadescuento ASC"
        Return fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, SQL), Nothing)
    End Function

    Public Function VerificaAplicoEnvio(ByVal Fecha As Date, ByVal TipoPlanilla As Integer) As Integer
        Dim SQL As String = "select top 1 Isnull(IdAsociado,0) from coo_DescuentosPendientesPlanilla  where IdPlanillaDescuento = " & TipoPlanilla
        SQL += " and FechaAplicacion = '" & Format(Fecha, "yyyyMMdd") + "'"
        Return fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, SQL), Nothing)
    End Function

    Function ObtenerSaldoCaja(ByVal HastaFecha As Date) As Decimal

        Dim sSQL As String = "select sum(Valor) Valor from coo_FondosCaja where Fecha<=' " & Format(HastaFecha, "yyyyMMdd") + "'"
        Dim TotalFondos = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)

        Dim sSQL2 As String = "select sum(MontoSolicitado) Valor from coo_PrestamosEfectivo where FechaSolicitud<=' " & Format(HastaFecha, "yyyyMMdd") + "'"
        Dim TotalPrestamos = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL2), 0)

        Return (TotalFondos - TotalPrestamos)
    End Function
    Function ObtenerSolCrucePendiente(ByVal IdAsociado As Integer) As Integer

        Dim sSQL As String = "select IdSolicitud from coo_SolicitudesCruces  where Autorizado =0 and IdAsociado= " & IdAsociado

        Return fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)
    End Function
    '
    Public Function CierreFechaDescuento(ByVal IdComprobante As Integer, ByVal UsrCierra As String, ByVal FechaActual As Date) As Integer
        Dim sSQL = "update coo_FechasDescuentos set Activo =0, CerradoPor= '" & UsrCierra + "'"
        sSQL += " , FechaCerrado= '" & Format(FechaActual, "yyyyMMdd") + "'"
        sSQL += " where IdComprobante = " & IdComprobante
        Return db.ExecuteNonQuery(CommandType.Text, sSQL)
    End Function

    Function ObtenerIdTipoMovimiento(ByVal IdTipoMovimiento As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdTipoMovimiento
        End If
        Dim sSQL As String = "select top 1 IdTipo from coo_TiposMovimientoCaja where IdTipo < " & IdTipoMovimiento & " order by IdTipo desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdTipo from coo_TiposMovimientoCaja where IdTipo > " & IdTipoMovimiento
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdTecnico(ByVal IdTecnico As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdTecnico
        End If
        Dim sSQL As String = "select top 1 IdTecnico from coo_Tecnicos where IdTecnico < " & IdTecnico & " order by IdTecnico desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdTecnico from coo_Tecnicos where IdTecnico > " & IdTecnico
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

  
    Function CobroPendienteOtrasLineas(ByVal IdAsociado As Integer, ByVal HastaFecha As Date) As Decimal

        Dim sSQL As String = "select sum(des.DescuentoPendiente) as DescuentoPendiente from coo_DescuentosPendientesPlanilla des"
        sSQL += " INNER JOIN coo_Lineas li on des.idlinea = li.idlinea"
        sSQL += " where  li.TipoLinea = 3 and des.IdAsociado = " & IdAsociado
        sSQL += " and des.FechaAplicacion <= '" & Format(HastaFecha, "yyyyMMdd") + "'"

        Return fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)
    End Function
    '
    Function VerificaSolPendientesFacturar(ByVal IdAsociado As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudesPendientesFacturacion", IdAsociado, IdLinea, HastaFecha).Tables(0)
    End Function
    '
    Public Function ExisteDesembolso(ByVal IdSolicitudFondo As Integer) As Integer
        Dim sSql As String = "select IdSolicitudFondo from coo_PrestamosDesembolso where IdSolicitudFondo= " & IdSolicitudFondo
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Function ObtenerIdCanton(ByVal Id As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return Id
        End If
        Dim sSQL As String = "select top 1 Id from adm_Cantones where Id < " & Id & " order by Id desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 Id from adm_Cantones where Id > " & Id
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

    Public Function DesembolsosParaConsulta(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return db.ExecuteDataSet("coo_spConsultaDesembolsos", Nombre, Apellido).Tables(0)
    End Function

    Public Function rptCantones() As DataTable
        Return db.ExecuteDataSet("coo_spCantones").Tables(0)
    End Function
    Public Function ExisteCodCanton(ByVal IdCanton As String) As Integer
        Dim sSql As String = "select IdCanton from adm_cantones where IdCanton= '" & IdCanton & "'"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function rptHistorialPrestamo(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IncluirCancelados As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spHistorialPrestamo", IdAsociado, Fecha, IncluirCancelados).Tables(0)
    End Function
    Public Function rptDatosAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spDatosAsociado", IdAsociado, Fecha).Tables(0)
    End Function
    Public Function coo_CorteCajaSelectFecha(ByVal Fecha As Date, ByVal Usuario As String) As coo_CorteCaja

        Dim dt As DataTable = db.ExecuteDataSet("coo_spCorteCajaSelectFecha", Fecha, Usuario).Tables(0)

        Dim Entidad As New coo_CorteCaja
        If dt.Rows.Count > 0 Then
            Entidad.IdCorte = dt.Rows(0).Item("IdCorte")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.IdUsuario = dt.Rows(0).Item("IdUsuario")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CantidadFacturas = dt.Rows(0).Item("CantidadFacturas")
            Entidad.FacturasAnuladas = dt.Rows(0).Item("FacturasAnuladas")

        End If
        Return Entidad
    End Function
    Public Function GetArqueoCaja(ByVal IdCorte As Integer) As DataTable
        Dim sql As String = "select a.IdCorte, a.IdDenominacion, d.Valor, a.Cantidad, a.Total, d.Nombre from coo_CorteCajaArqueo a inner join coo_DenominacionesMoneda d on a.IdDenominacion=d.IdDenominacion WHERE a.IdCorte=" & IdCorte
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function rptResumenIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spResumenIngresosEgresosCaja", IdSucursal, DesdeFecha, HastaFecha, IdUsuario).Tables(0)
    End Function
    Function ObtenerIdSolicitud(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdSolicitud
        End If
        Dim sSQL As String = "select top 1 IdSolicitud from coo_Solicitudes where IdSolicitud < " & IdSolicitud & " order by IdSolicitud desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSolicitud from coo_Solicitudes where IdSolicitud > " & IdSolicitud
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdSolicitudEfectivo(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdSolicitud
        End If
        Dim sSQL As String = "select top 1 IdSolicitud from coo_PrestamosEfectivo  where IdSolicitud < " & IdSolicitud & " order by IdSolicitud desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSolicitud from coo_PrestamosEfectivo  where IdSolicitud > " & IdSolicitud
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdSolicitudRetiro(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdSolicitud
        End If
        Dim sSQL As String = "select top 1 IdSolicitud from coo_SolicitudRetiro  where IdSolicitud < " & IdSolicitud & " order by IdSolicitud desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSolicitud from coo_SolicitudRetiro  where IdSolicitud > " & IdSolicitud
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdSolicitudCruce(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdSolicitud
        End If
        Dim sSQL As String = "select top 1 IdSolicitud from coo_SolicitudesCruces where IdSolicitud < " & IdSolicitud & " order by IdSolicitud desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSolicitud from coo_SolicitudesCruces where IdSolicitud > " & IdSolicitud
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Function ObtenerIdAplicarReintegro(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer

        If TipoAvance = 0 Then
            Return IdSolicitud
        End If

        Dim sSQL As String = "select top 1 IdSolicitud from coo_AplicarReintegros where IdSolicitud < " & IdSolicitud & " order by IdSolicitud desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSolicitud from coo_AplicarReintegros where IdSolicitud > " & IdSolicitud
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

    Public Function GetObligacionesSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesObligacion "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    'Public Function GetDetalleIngresosSolicitud(ByVal IdSolicitud As Integer) As DataTable
    '    Dim sSQL As String = "select * from coo_SolicitudesDetalleIngresos "
    '    If IdSolicitud = -999 Then
    '        sSQL &= "where 1=2"
    '    Else
    '        sSQL &= "where IdSolicitud=" & IdSolicitud
    '    End If
    '    Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    'End Function

    'Public Function GetDetalleGastosSolicitud(ByVal IdSolicitud As Integer) As DataTable
    '    Dim sSQL As String = "select * from coo_SolicitudesDetalleGastos "
    '    If IdSolicitud = -999 Then
    '        sSQL &= "where 1=2"
    '    Else
    '        sSQL &= "where IdSolicitud=" & IdSolicitud
    '    End If
    '    Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    'End Function


    Public Function GetSeguimientoCobros(ByVal IdPrestamo As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SeguimientoCobros "
        If IdPrestamo = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdPrestamo=" & IdPrestamo
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function GetSeguimientoPrestamos(ByVal IdPrestamo As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SeguimientoPrestamos "
        If IdPrestamo = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdPrestamo=" & IdPrestamo
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function GetDeducciones(ByVal Monto As Decimal) As DataTable
        Return db.ExecuteDataSet("coo_spDeduccionesPrestamo", Monto).Tables(0)
    End Function
    Public Function GetDenominaciones() As DataTable
        Dim sSQL As String = "select IdCorte=convert(Integer,0),IdDenominacion,Nombre,Cantidad=convert(Integer,0),Total=convert(decimal,0.00),Valor from coo_DenominacionesMoneda "
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Dim IdMov As Decimal = db.ExecuteScalar("coo_spGetUlMovPrestamo", IdPrestamo)
        Return IdMov
    End Function

    Public Function GetUltMovTraslado(ByVal IdPrestamo As Integer) As Integer
        Dim IdTraslado As Integer = db.ExecuteScalar("coo_spGetUlMovTraslado", IdPrestamo)
        Return IdTraslado
    End Function
    Public Function GetSaldoPrestamoAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdLinea As Integer, ByVal TotalRetirar As Decimal, ByVal IdSolicitud As Integer) As DataTable

        If IdSolicitud > 0 Then
            Dim sql As String = "Select * from coo_SolicitudRetiroPrestamos where IdSolicitud = " & IdSolicitud
            Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
        Else
            Return db.ExecuteDataSet("coo_spPrestamosAsociado", IdAsociado, Fecha, IdLinea, TotalRetirar).Tables(0)
        End If

    End Function


    Public Function GetSaldoPrestamoRapidoAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdLinea As Integer, ByVal TotalRetirar As Decimal, ByVal IdSolicitud As Integer) As DataTable

        If IdSolicitud > 0 Then
            Dim sql As String = "Select * from coo_PrestamoEfectivoRefinancia where IdSolicitud = " & IdSolicitud
            Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
        Else
            Return db.ExecuteDataSet("coo_spPrestamosAsociado", IdAsociado, Fecha, IdLinea, TotalRetirar).Tables(0)
        End If

    End Function


    Public Function GetPrestamosSolRetiro(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "Select d.IdPrestamo, Lin.Nombre as LineaCredito, d.SaldoCapital, d.SaldoInteres, d.SaldoInteresMOra, d. SaldoSeguro, d.SaldoOtros from coo_SolicitudRetiroPrestamos d inner join coo_lineas lin on d.idlinea = lin.idlinea where d.IdSolicitud= " & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function


    Public Function rptCobrosAportaciones(ByVal IdSolicitud As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCobroAportaciones", IdSolicitud, Fecha).Tables(0)
    End Function


    Public Function GetObligacionesFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Dim sSQL As String = "select * from coo_FiadoresObligacion "
        If IdFiador = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdFiador=" & IdFiador & " AND IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetBienesSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesBien "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetBienesFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Dim sSQL As String = "select * from coo_FiadoresBien "
        If IdFiador = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdFiador=" & IdFiador & " AND IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetReferenciasFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Dim sSQL As String = "select * from coo_FiadoresReferencia "
        If IdFiador = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdFiador=" & IdFiador & " AND IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptEnvioDescuentosTelefonico(ByVal FechaAplicacion As DateTime, ByVal IdCentro As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spEnvioDescuentosTelefonico", FechaAplicacion, IdCentro).Tables(0)
    End Function
    Public Function rptInformeAseguradora(ByVal HastaFecha As DateTime, ByVal IdSucursal As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spInformeAseguradora", IdSucursal, HastaFecha).Tables(0)
    End Function
    Public Function ObtenerFiadores(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String
        sSQL = "SELECT IdAsociado,Nombre=NombresApellidos,Valor=PorcentajeCubre FROM coo_GarantiasFiador WHERE IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptListadoCruces(ByVal IdSucursal As Integer, ByVal IdAsociado As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal Estado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCruces", IdSucursal, IdAsociado, DesdeFecha, HastaFecha, Estado).Tables(0)
    End Function

    Public Function rptInformeAseguradoraAportacion(ByVal HastaFecha As DateTime, ByVal IdSucursal As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spInformeAseguradoraAportaciones", IdSucursal, HastaFecha).Tables(0)
    End Function

    Public Function rptInformeAseguradoraAhorro(ByVal HastaFecha As DateTime, ByVal IdSucursal As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spInformeAseguradoraAhorros", IdSucursal, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptCorteCaja(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCaja", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function
    Public Function rptCorteCajaIngresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCajaIngresos", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function
    Public Function rptCorteCajaEgresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCajaEgresos", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function

    Public Function rptIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spIngresosEgresosCaja", IdSucursal, DesdeFecha, HastaFecha, IdUsuario).Tables(0)
    End Function

    Public Function rptInformeRemesas(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spInformeRemesas", IdSucursal, DesdeFecha, HastaFecha, IdUsuario).Tables(0)
    End Function

    Public Function ArchivoInfored(ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spArchivoInfored", -1, HastaFecha).Tables(0)
    End Function

    Public Function GetFiadoresSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_GarantiasFiador WHERE IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function GetReferenciasSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesReferencia "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function GetGarantiasSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesGarantias "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function GetEmisionDesembolso(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesEmisionDesembolso "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function


    Public Function GetDescuentosCuota(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_SolicitudesDescuentosCuota "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetProgramacionPrestamo(ByVal IdPrestamo As Integer) As DataTable
        Dim sSQL As String = "select * from coo_PrestamosDetalleDescuentos where IdPrestamo= " & IdPrestamo
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    'Public Function GetDeudasSolRetiro(ByVal IdSolicitud As Integer) As DataTable
    '    Dim sSQL As String = "select * from coo_PrestamosDetalleDescuentos where IdPrestamo= " & IdPrestamo
    '    Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    'End Function

    '
    Public Function GetSaldosPrestamos(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal Nuevo As Boolean, ByVal Modulo As String) As DataTable
        Dim sSQL As String = ""

        If Modulo = "Reintegro" Then
            sSQL = "select * from coo_AplicarReintegrosPrestamos "
        Else
            If Modulo = "SolRetiro" Then
                sSQL = "select * from coo_SolicitudRetiroPrestamos "
            Else
                sSQL = "select * from coo_SolicitudesCrucesPrestamos "
            End If
        End If

        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If

        If Nuevo Then
            Return db.ExecuteDataSet("coo_spSaldoPrestamos", IdAsociado, HastaFecha).Tables(0)
        Else
            Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
        End If

    End Function

    Public Function ExisteIdSolicitud(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_Solicitudes where IdSolicitud=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteSolicitudFondos(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_SolicitudFondos where IdSolicitud=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteSolicitudPresEfectivo(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdPresEfectivo from coo_Prestamos where IdPresEfectivo=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function
    Public Function GetIdMovAportacionPrestamo(ByVal Numero As String, ByVal IdAsociado As Integer) As Integer
        Dim IdMov As Integer
        Dim sSql As String = "select IdMov from coo_Aportaciones where IdAsociado=" & IdAsociado & " AND NumeroDoc='" & Numero & "'"
        IdMov = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdMov
    End Function



    Public Function GetIdSolicitudFondos(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitudFondo from coo_SolicitudFondos where IdSolicitud=" & IdSolicitud
        Dim IdSolicitudFondo As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitudFondo
    End Function

    Public Function ExisteSolicitudPrestamo(ByVal IdSolicitud As Integer) As String
        Dim Numero As String
        Dim sSql As String = "select Numero from coo_Prestamos where IdSolicitud=" & IdSolicitud
        Numero = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return Numero
    End Function

    Public Function ExistePrestamo(ByVal IdSolicitud As Integer) As Integer
        Dim Prestamo As Integer
        Dim sSql As String = "select IdPrestamo from coo_Prestamos where IdSolicitud=" & IdSolicitud
        Prestamo = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return Prestamo
    End Function

    Public Function ExisteFiadorSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_GarantiasFiador where IdSolicitud=" & IdSolicitud & " AND IdGarantia =" & IdGarantia
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteCambioTasa(ByVal IdPrestamo As Integer, ByVal Fecha As DateTime, ByVal TipoTasa As Integer) As Integer
        Dim sSql As String = "select IdMov from coo_PrestamosDetalle where IdPrestamo=" & IdPrestamo & " AND Fecha ='" & Format(Fecha, "yyyyMMdd") & "' AND TipoAplicacion =" & TipoTasa
        IdPrestamo = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdPrestamo
    End Function

    Public Function ExisteTrasladoPrestamo(ByVal IdPrestamo As Integer, ByVal Fecha As DateTime) As Integer
        Dim sSql As String = "select IdTraslado from coo_PrestamosTraslado where IdPrestamo=" & IdPrestamo & " AND Fecha ='" & Format(Fecha, "yyyyMMdd") & "'"
        IdPrestamo = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdPrestamo
    End Function

    Public Function ExisteHipotecaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_GarantiasHipoteca where IdSolicitud=" & IdSolicitud & " AND IdGarantia =" & IdGarantia
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteDictamenTecnico(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_DictamenTecnico where IdSolicitud=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function rptInformeAuditoria1(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria1", IdSucursal, Desde, Hasta).Tables(0)
    End Function
    Public Function rptInformeAuditoria2(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria2", IdSucursal, Desde, Hasta).Tables(0)
    End Function
    Public Function rptInformeAuditoria3(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria3", IdSucursal, Desde, Hasta).Tables(0)
    End Function
    Public Function rptInformeAuditoria4(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria4", IdSucursal, Desde, Hasta).Tables(0)
    End Function
    Public Function rptInformeAuditoria5(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria5", IdSucursal, Desde, Hasta).Tables(0)
    End Function

    Public Function rptInformeAuditoria6(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Valor As Decimal) As DataTable
        Return db.ExecuteDataSet("coo_spRptAuditoria6", IdSucursal, Desde, Hasta, Valor).Tables(0)
    End Function

    Public Function rptDatosConsolidados(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptDatosConsolidados", IdSucursal, Desde, Hasta).Tables(0)
    End Function


    Public Function ExisteResolucionSolicitud(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_Resoluciones where IdSolicitud=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function


    Public Function ExisteDictamenGerencia(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_DictamenGerencia where IdSolicitud=" & IdSolicitud
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExistePrendaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_GarantiasPrendaria where IdSolicitud=" & IdSolicitud & " AND IdGarantia =" & IdGarantia
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteCuentaPignoradaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Dim sSql As String = "select IdSolicitud from coo_GarantiasCuentaPignorada where IdSolicitud=" & IdSolicitud & " AND IdGarantia =" & IdGarantia
        IdSolicitud = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdSolicitud
    End Function

    Public Function ExisteNumeroSolicitud(ByVal Numero As String) As Integer
        Dim sql As String = String.Format("select IdSolicitud from coo_Solicitudes where Numero= '{0}'", Numero)
        Dim i As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0)
        Return i
    End Function
    '
    Public Function ExisteNumeroSolicitudCruce(ByVal Numero As String) As Integer
        Dim sql As String = String.Format("select IdSolicitud from coo_SolicitudesCruces where Numero= '{0}'", Numero)
        Dim i As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0)
        Return i
    End Function
    Public Function ExisteNumeroSolicitudPresEfectivo(ByVal Numero As String) As Integer
        Dim sql As String = String.Format("select IdSolicitud from coo_PrestamosEfectivo where Numero= '{0}'", Numero)
        Dim i As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0)
        Return i
    End Function

    Public Function AplicaEjecutivos(ByVal IdAsociado As Integer) As Integer
        Dim sql As String = String.Format("select TOP 1 IdPlanilla from coo_AsociadosDescuentos  where IdRubro = 1 and IdAsociado ='{0}'", IdAsociado)
        Dim i As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0)
        Return i
    End Function


    Public Function ExisteNumeroSolicitudpres(ByVal Numero As Integer) As Integer
        Dim sql As String = "select IdPrestamo from coo_Prestamos where IdSolicitud= '" & Numero & "'"     'String.Format("select idprestamo from coo_Prestamos where IdSolicitud= '" & Numero)
        Dim i As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0)
        Return i
    End Function

    Public Function ExisteNumComprobanteDesembolso(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdPrestamo,Numero from coo_PrestamosDetalle where Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function CambiaEstadoReintegro(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal IdPlanilla As Integer, ByVal FechaPlanilla As DateTime) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try

            Dim sSQL As String = "update coo_ReintegrosPlanilla set Aplicado = 0 "
            sSQL += " ,  AplicadoPor = '' "
            sSQL += " ,  FechaHoraAplicacion= null"
            sSQL += " WHERE IdAsociado=" & IdAsociado
            sSQL += " and FechaAplicacion='" & Format(FechaPlanilla, "yyyyMMdd") & "'"
            sSQL += " and IdPlanillaDescuento=" & IdPlanilla

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

    Public Function InsertaSolicitudPrestamo _
(ByRef entSolicitud As coo_Solicitudes, ByRef entObligaciones As List(Of coo_SolicitudesObligacion) _
 , ByRef entBienes As List(Of coo_SolicitudesBien), ByRef entReferencias As List(Of coo_SolicitudesReferencia) _
 , ByRef entGarantias As List(Of coo_SolicitudesGarantias) _
 , ByRef entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entSolicitud.IdSolicitud = fd.ObtenerUltimoId("Coo_Solicitudes", "IdSolicitud") + 1
            objTabla.coo_SolicitudesInsert(entSolicitud, tran)

            For Each detalle As coo_SolicitudesObligacion In entObligaciones
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesObligacionInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesBien In entBienes
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesBienInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesReferencia In entReferencias
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesReferenciaInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesGarantias In entGarantias
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                'MsgBox(detalle.Concepto)
                'MsgBox(detalle.Correlativo)
                'MsgBox(detalle.IdSolicitud)
                'MsgBox(detalle.IdTipo)

                objTabla.coo_SolicitudesGarantiasInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesEmisionDesembolso In entEmisionDesembolso
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesEmisionDesembolsoInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_Asociados set CorrelativoSolicitud = CorrelativoSolicitud + 1 WHERE IdAsociado=" & entSolicitud.IdAsociado
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

    Public Function InsertaSolicitudCruce _
(ByRef entSolicitud As coo_SolicitudesCruces _
    , ByRef entCruceAhorros As List(Of coo_SolicitudesCrucesAhorros) _
    , ByRef entCrucePrestamos As List(Of coo_SolicitudesCrucesPrestamos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entSolicitud.IdSolicitud = fd.ObtenerUltimoId("Coo_SolicitudesCruces", "IdSolicitud") + 1
            objTabla.coo_SolicitudesCrucesInsert(entSolicitud, tran)

            For Each detalle As coo_SolicitudesCrucesAhorros In entCruceAhorros
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesCrucesAhorrosInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesCrucesPrestamos In entCrucePrestamos
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesCrucesPrestamosInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_Asociados set CorrelativoSolicitudCruce = CorrelativoSolicitudCruce + 1 WHERE IdAsociado=" & entSolicitud.IdAsociado
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
    Public Function InsertaAplicacionReintegro _
(ByRef entSolicitud As coo_AplicarReintegros _
, ByRef entReintegroAhorros As List(Of coo_AplicarReintegrosAhorros) _
, ByRef entReintegroPrestamos As List(Of coo_AplicarReintegrosPrestamos), ByVal FechaPlanilla As DateTime, ByVal TipoPlanilla As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entSolicitud.IdSolicitud = fd.ObtenerUltimoId("coo_AplicarReintegros", "IdSolicitud") + 1
            objTabla.coo_AplicarReintegrosInsert(entSolicitud, tran)

            For Each detalle As coo_AplicarReintegrosAhorros In entReintegroAhorros
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_AplicarReintegrosAhorrosInsert(detalle, tran)
            Next

            For Each detalle As coo_AplicarReintegrosPrestamos In entReintegroPrestamos
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_AplicarReintegrosPrestamosInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_ReintegrosPlanilla set Aplicado = 1 "
            sSQL += " ,  AplicadoPor='" & entSolicitud.CreadoPor & "'"
            sSQL += " ,  FechaHoraAplicacion= getdate()"
            sSQL += " WHERE IdAsociado=" & entSolicitud.IdAsociado
            sSQL += " and FechaAplicacion='" & Format(FechaPlanilla, "yyyyMMdd") & "'"
            sSQL += " and IdPlanillaDescuento=" & TipoPlanilla

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
    '

    Public Function InsertaSolicitudPrestamoEfectivo(ByRef entPresEfectivo As coo_PrestamosEfectivo, ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
        , ByRef entPlan As List(Of coo_PrestamosPlanPagos), ByRef entLiquidacion As coo_PrestamosDesembolso, ByRef entPresRefinancia As List(Of coo_PrestamoEfectivoRefinancia), ByRef entCancelacion As List(Of coo_PrestamosDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            entPresEfectivo.IdSolicitud = fd.ObtenerUltimoId("coo_PrestamosEfectivo", "IdSolicitud") + 1
            objTabla.coo_PrestamosEfectivoInsert(entPresEfectivo, tran)

            Dim sSQL9 As String = "update coo_Asociados set CorrelativoSolicitud = CorrelativoSolicitud + 1 WHERE IdAsociado=" & entPresEfectivo.IdAsociado
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL9)

            '---INSERTO PRESTAMOS
            'TODO Calcula correlativos y los actualiza en las entidades
            entPrestamo.IdPrestamo = fd.ObtenerUltimoId("Coo_Prestamos", "IdPrestamo") + 1
            entPrestamo.IdPresEfectivo = entPresEfectivo.IdSolicitud

            objTabla.coo_PrestamosInsert(entPrestamo, tran)

            entDesembolso.IdPrestamo = entPrestamo.IdPrestamo
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo) + 1

            Dim sql As String = "update adm_Sucursales set CorrelativoDesembolso = CorrelativoDesembolso + 1 where IdSucursal=" & entDesembolso.IdSucursal
            sql &= ";select CorrelativoDesembolso from adm_Sucursales where IdSucursal=" & entDesembolso.IdSucursal
            entDesembolso.Numero = entPrestamo.IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")

            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            'se le asigna el mismo correlativo de desembolso
            entLiquidacion.NumeroComprobante = entDesembolso.Numero
            entLiquidacion.IdPrestamo = entPrestamo.IdPrestamo
            entLiquidacion.IdSolicitudFondo = 0 'entSolFondos.IdSolicitudFondo
            objTabla.coo_PrestamosDesembolsoInsert(entLiquidacion, tran)

            For Each detalle As coo_PrestamosPlanPagos In entPlan
                detalle.IdPrestamo = entPrestamo.IdPrestamo
                objTabla.coo_PrestamosPlanPagosInsert(detalle, tran)
            Next

            For Each detalle As coo_PrestamoEfectivoRefinancia In entPresRefinancia
                detalle.IdSolicitud = entPresEfectivo.IdSolicitud
                objTabla.coo_PrestamoEfectivoRefinanciaInsert(detalle, tran)
            Next


            'For Each detalle As coo_PrestamosDetalle In entCancelacion
            '    objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            'Next

            Dim sqlNum As String = " update adm_correlativos set ultimoValor = " & entPresEfectivo.NumVale & " where correlativo = 'VALES_EFECTIVO'"
            db.ExecuteNonQuery(CommandType.Text, sqlNum)

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function



    Public Function InsertaSolicitudRetiro(ByRef entRetiro As coo_SolicitudRetiro, ByRef entSolRetiroPrestamos As List(Of coo_SolicitudRetiroPrestamos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            entRetiro.IdSolicitud = fd.ObtenerUltimoId("coo_SolicitudRetiro", "IdSolicitud") + 1
            objTabla.coo_SolicitudRetiroInsert(entRetiro, tran)

            For Each detalle As coo_SolicitudRetiroPrestamos In entSolRetiroPrestamos
                detalle.IdSolicitud = entRetiro.IdSolicitud
                objTabla.coo_SolicitudRetiroPrestamosInsert(detalle, tran)
            Next

            Dim sqlNum As String = " update adm_correlativos set ultimoValor = " & CInt(entRetiro.NumeroSolicitud) & " where correlativo = 'SOLICITUD_RETIRO'"
            db.ExecuteNonQuery(CommandType.Text, sqlNum)

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function InsertaFiadorSolicitud _
(ByRef entFiador As coo_GarantiasFiador, ByRef entObligacionFiador As List(Of coo_FiadoresObligacion) _
, ByRef entBienesFiador As List(Of coo_FiadoresBien), ByRef entReferenciasFiador As List(Of coo_FiadoresReferencia)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_GarantiasFiadorInsert(entFiador, tran)

            For Each detalle As coo_FiadoresObligacion In entObligacionFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresObligacionInsert(detalle, tran)
            Next
            For Each detalle As coo_FiadoresBien In entBienesFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresBienInsert(detalle, tran)
            Next
            For Each detalle As coo_FiadoresReferencia In entReferenciasFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresReferenciaInsert(detalle, tran)
            Next
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaHipotecaSolicitud(ByRef entHipoteca As coo_GarantiasHipoteca) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_GarantiasHipotecaInsert(entHipoteca, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaSeguimientoCobro(ByRef entSeguimiento As coo_SeguimientoCobros) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entSeguimiento.IdSeguimiento = fd.ObtenerUltimoId("Coo_SeguimientoCobros", "IdSeguimiento") + 1
            objTabla.coo_SeguimientoCobrosInsert(entSeguimiento, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaSeguimientoPrestamo(ByRef entSeguimiento As coo_SeguimientoPrestamos) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entSeguimiento.IdSeguimiento = fd.ObtenerUltimoId("Coo_SeguimientoPrestamos", "IdSeguimiento") + 1
            objTabla.coo_SeguimientoPrestamosInsert(entSeguimiento, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function


    Public Function InsertaDictamenTecnico(ByRef entDictamen As coo_DictamenTecnico) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_DictamenTecnicoInsert(entDictamen, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaResolucionSolicitud(ByRef entResolucion As coo_Resoluciones) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            objTabla.coo_ResolucionesInsert(entResolucion, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaDictamenGerencia(ByRef entDictamen As coo_DictamenGerencia) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_DictamenGerenciaInsert(entDictamen, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaPrendaSolicitud(ByRef entPrenda As coo_GarantiasPrendaria) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_GarantiasPrendariaInsert(entPrenda, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaCuentaPignoradaSolicitud(ByRef entPignorada As coo_GarantiasCuentaPignorada) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            objTabla.coo_GarantiasCuentaPignoradaInsert(entPignorada, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function UpdateSolicitudPrestamo _
(ByRef entSolicitud As coo_Solicitudes _
, ByRef entObligaciones As List(Of coo_SolicitudesObligacion), ByRef entBienes As List(Of coo_SolicitudesBien) _
, ByRef entReferencias As List(Of coo_SolicitudesReferencia), ByRef entGarantias As List(Of coo_SolicitudesGarantias), _
ByRef entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_SolicitudesUpdate(entSolicitud, tran)

            Dim sql As String = "delete coo_SolicitudesObligacion where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_SolicitudesBien where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_SolicitudesReferencia where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_SolicitudesGarantias where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_SolicitudesEmisionDesembolso where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)


            'Dim sSQL6 As String = "delete coo_SolicitudesDetalleIngresos where IdSolicitud=" & entSolicitud.IdSolicitud
            'db.ExecuteNonQuery(tran, CommandType.Text, sSQL6)

            'Dim sSQL7 As String = "delete coo_SolicitudesDetalleGastos where IdSolicitud=" & entSolicitud.IdSolicitud
            'db.ExecuteNonQuery(tran, CommandType.Text, sSQL7)


            For Each detalle As coo_SolicitudesObligacion In entObligaciones
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesObligacionInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesBien In entBienes
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesBienInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesReferencia In entReferencias
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesReferenciaInsert(detalle, tran)
            Next
            For Each detalle As coo_SolicitudesGarantias In entGarantias
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesGarantiasInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesEmisionDesembolso In entEmisionDesembolso
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesEmisionDesembolsoInsert(detalle, tran)
            Next
            '

            'For Each detalle As coo_SolicitudesDetalleIngresos In entDetalleIngreso
            '    detalle.IdSolicitud = entSolicitud.IdSolicitud
            '    objTabla.coo_SolicitudesDetalleIngresosInsert(detalle, tran)
            'Next

            'For Each detalle As coo_SolicitudesDetalleGastos In entDetalleGasto
            '    detalle.IdSolicitud = entSolicitud.IdSolicitud
            '    objTabla.coo_SolicitudesDetalleGastosInsert(detalle, tran)
            'Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function

    Public Function UpdateSolicitudCruce _
(ByRef entSolicitud As coo_SolicitudesCruces _
    , ByRef entCruceAhorros As List(Of coo_SolicitudesCrucesAhorros) _
    , ByRef entCrucePrestamos As List(Of coo_SolicitudesCrucesPrestamos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_SolicitudesCrucesUpdate(entSolicitud, tran)

            Dim sql As String = "delete coo_SolicitudesCrucesAhorros where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_SolicitudesCrucesPrestamos where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            For Each detalle As coo_SolicitudesCrucesAhorros In entCruceAhorros
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesCrucesAhorrosInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudesCrucesPrestamos In entCrucePrestamos
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudesCrucesPrestamosInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function

    '
    Public Function UpdateAplicacionReintegro _
(ByRef entSolicitud As coo_AplicarReintegros _
    , ByRef entReintegroAhorros As List(Of coo_AplicarReintegrosAhorros) _
    , ByRef entReintegroPrestamos As List(Of coo_AplicarReintegrosPrestamos)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_AplicarReintegrosUpdate(entSolicitud, tran)

            Dim sql As String = "delete coo_AplicarReintegrosAhorros where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "delete coo_AplicarReintegrosPrestamos where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            For Each detalle As coo_AplicarReintegrosAhorros In entReintegroAhorros
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_AplicarReintegrosAhorrosInsert(detalle, tran)
            Next

            For Each detalle As coo_AplicarReintegrosPrestamos In entReintegroPrestamos
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_AplicarReintegrosPrestamosInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function
    Public Function UpdateSolicitudPrestamoEfectivo(ByRef entPresEfectivo As coo_PrestamosEfectivo, ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
        , ByRef entPlan As List(Of coo_PrestamosPlanPagos), ByRef entLiquidacion As coo_PrestamosDesembolso, ByRef IdPrestamo As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            ' BORROS LOS DATOS EXISTENTES
            objTabla.coo_PrestamosPlanPagosDeleteByPrestamo(IdPrestamo)
            objTabla.coo_PrestamosDetalleDeleteByPK(IdPrestamo, 1)
            objTabla.coo_PrestamosDesembolsoDeleteByPK(0, IdPrestamo)

            Dim sql1 As String = "delete from coo_PrestamosDesembolso where IdPrestamo = " & IdPrestamo
            db.ExecuteNonQuery(CommandType.Text, sql1)

            objTabla.coo_PrestamosDeleteByPK(IdPrestamo)

            objTabla.coo_PrestamosEfectivoUpdate(entPresEfectivo, tran)

            '---INSERTO PRESTAMOS
            entPrestamo.IdPrestamo = fd.ObtenerUltimoId("Coo_Prestamos", "IdPrestamo") + 1
            objTabla.coo_PrestamosInsert(entPrestamo, tran)

            entDesembolso.IdPrestamo = entPrestamo.IdPrestamo
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo) + 1

            Dim sql As String = "update adm_Sucursales set CorrelativoDesembolso = CorrelativoDesembolso + 1 where IdSucursal=" & entDesembolso.IdSucursal
            sql &= ";select CorrelativoDesembolso from adm_Sucursales where IdSucursal=" & entDesembolso.IdSucursal
            entDesembolso.Numero = entPrestamo.IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")

            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            'se le asigna el mismo correlativo de desembolso
            entLiquidacion.NumeroComprobante = entDesembolso.Numero
            entLiquidacion.IdPrestamo = entPrestamo.IdPrestamo
            entLiquidacion.IdSolicitudFondo = 0
            objTabla.coo_PrestamosDesembolsoInsert(entLiquidacion, tran)

            For Each detalle As coo_PrestamosPlanPagos In entPlan
                detalle.IdPrestamo = entPrestamo.IdPrestamo
                objTabla.coo_PrestamosPlanPagosInsert(detalle, tran)
            Next


        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function


    Public Function UpdateSolicitudRetiro(ByRef entSolicitud As coo_SolicitudRetiro, ByRef entSolRetiroPrestamos As List(Of coo_SolicitudRetiroPrestamos)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_SolicitudRetiroUpdate(entSolicitud, tran)

            Dim Sql As String = ""
            Sql = "delete coo_SolicitudRetiroPrestamos where IdSolicitud=" & entSolicitud.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, Sql)


            For Each detalle As coo_SolicitudRetiroPrestamos In entSolRetiroPrestamos
                detalle.IdSolicitud = entSolicitud.IdSolicitud
                objTabla.coo_SolicitudRetiroPrestamosInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function

    Public Function UpdateFiadorSolicitud _
(ByRef entFiador As coo_GarantiasFiador _
, ByRef entObligacionFiador As List(Of coo_FiadoresObligacion), ByRef entBienesFiador As List(Of coo_FiadoresBien) _
, ByRef entReferenciasFiador As List(Of coo_FiadoresReferencia)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_GarantiasFiadorUpdate(entFiador, tran)

            Dim sSQL As String = "delete coo_FiadoresObligacion where IdFiador=" & entFiador.IdGarantia & " AND IdSolicitud=" & entFiador.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            Dim sSQL2 As String = "delete coo_FiadoresBien where IdFiador=" & entFiador.IdGarantia & " AND IdSolicitud=" & entFiador.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL2)

            Dim sSQL3 As String = "delete coo_FiadoresReferencia where IdFiador=" & entFiador.IdGarantia & " AND IdSolicitud=" & entFiador.IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL3)

            For Each detalle As coo_FiadoresObligacion In entObligacionFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresObligacionInsert(detalle, tran)
            Next

            For Each detalle As coo_FiadoresBien In entBienesFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresBienInsert(detalle, tran)
            Next
            For Each detalle As coo_FiadoresReferencia In entReferenciasFiador
                detalle.IdFiador = entFiador.IdGarantia
                detalle.IdSolicitud = entFiador.IdSolicitud
                objTabla.coo_FiadoresReferenciaInsert(detalle, tran)
            Next
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function UpdateHipotecaSolicitud(ByRef entHipoteca As coo_GarantiasHipoteca) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            objTabla.coo_GarantiasHipotecaUpdate(entHipoteca, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function UpdateDictamenTecnico(ByRef entDictamen As coo_DictamenTecnico) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_DictamenTecnicoUpdate(entDictamen, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function UpdateResolucionSolicitud(ByRef entResolucion As coo_Resoluciones) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_ResolucionesUpdate(entResolucion, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function


    Public Function UpdateDictamenGerencia(ByRef entDictamen As coo_DictamenGerencia) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_DictamenGerenciaUpdate(entDictamen, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function UpdatePrendaSolicitud(ByRef entPrenda As coo_GarantiasPrendaria) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_GarantiasPrendariaUpdate(entPrenda, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function
    Public Function ConsultaSolicitudesByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Dim sql As String
        sql = "SELECT sol.IdSolicitud, sol.Numero, aso.Nombres, aso.Apellidos, sol.FechaSolicitud, LineaCredito=lin.Nombre, Tecnico=tec.Nombre, sol.FechaHoraCreacion "
        sql += "from coo_solicitudes sol "
        sql += "inner join coo_asociados aso on sol.IdAsociado = aso.IdAsociado "
        sql += "inner join coo_Lineas    lin on sol.IdLinea= lin.IdLinea "
        sql += "inner join coo_Tecnicos  tec on sol.IdFuente= tec.IdTecnico "
        sql += "inner join coo_TiposPrestamo tp on sol.IdTipoCredito=tp.IdTipoPrestamo "
        sql += "where aso.Nombres LIKE '%" + Nombre + "%' "
        sql += "AND Aso.Apellidos LIKE '%" + Apellido + "%' Order By IdSolicitud DESC"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaSolicitudesCrucesByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Dim sql As String
        sql = "SELECT sol.IdSolicitud, sol.Numero, aso.Nombres, aso.Apellidos, sol.FechaSolicitud, sol.FechaHoraCreacion "
        sql += "from coo_solicitudesCruces sol "
        sql += "inner join coo_asociados aso on sol.IdAsociado = aso.IdAsociado "
        sql += "where aso.Nombres LIKE '%" + Nombre + "%' "
        sql += "AND Aso.Apellidos LIKE '%" + Apellido + "%' Order By IdSolicitud DESC"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function


    Public Function ConsultaReintegrosByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Dim sql As String
        sql = "SELECT sol.IdSolicitud, aso.Nombres, aso.Apellidos, sol.FechaSolicitud, sol.ValorReintegro, sol.FechaHoraCreacion "
        sql += "from coo_AplicarReintegros sol "
        sql += "inner join coo_asociados aso on sol.IdAsociado = aso.IdAsociado "
        sql += "where aso.Nombres LIKE '%" + Nombre + "%' "
        sql += "AND Aso.Apellidos LIKE '%" + Apellido + "%' Order By IdSolicitud DESC"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaSolicitudesPresEfectivoByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Dim sql As String
        sql = "SELECT sol.IdSolicitud, sol.Numero, aso.Nombres, aso.Apellidos, sol.FechaSolicitud, LineaCredito=lin.Nombre, sol.FechaHoraCreacion "
        sql += "from coo_PrestamosEfectivo  sol "
        sql += "inner join coo_asociados aso on sol.IdAsociado = aso.IdAsociado "
        sql += "inner join coo_Lineas    lin on sol.IdLinea= lin.IdLinea "
        sql += "inner join coo_TiposPrestamo tp on sol.IdTipoCredito=tp.IdTipoPrestamo "
        sql += "where aso.Nombres LIKE '%" + Nombre + "%' "
        sql += "AND Aso.Apellidos LIKE '%" + Apellido + "%' Order By IdSolicitud DESC"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaPeriodosTelefonos() As DataTable
        Dim sql As String
        sql = "SELECT Fecha_Aplicacion= FechaAplicacion FROM coo_DescuentoTelefoniaPendiente GROUP BY FechaAplicacion"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ActualizarSeguimientoSolicitud _
(ByVal IdSolicitud As Integer, ByVal Seguimiento As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            Dim sSQL As String = "update coo_Solicitudes set RequiereSeguimiento=" & Seguimiento & " where Idsolicitud=" & IdSolicitud
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function ConsultaSolicitudesAprobadas(ByVal Nombre As String, ByVal Apellido As String, ByVal SoloPendientes As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spConsultaSolicitudAprobada", Nombre, Apellido, SoloPendientes).Tables(0)
    End Function
    Public Function ActualizarCuentaPignoradaSolicitud(ByRef entPignorada As coo_GarantiasCuentaPignorada) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_GarantiasCuentaPignoradaUpdate(entPignorada, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function GetFiadoresSolicitudPrestamo(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select NombreFiador=NombresApellidos, TiempoConocer, Familiar=case when EsFamiliar=1 then 'SI' else 'NO' end, Parentesco, PorcentajeCubre from coo_GarantiasFiador WHERE IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
        'Return db.ExecuteDataSet("coo_spSolicitudFiador", IdSolicitud).Tables(0)
    End Function
    Public Function rptSolicitudPrestamo(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudPrestamo", IdSolicitud).Tables(0)
    End Function
    Public Function rptSolicitudPrestamoFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudPrestamoFiadores", IdSolicitud).Tables(0)
    End Function

    Public Function rptSolicitudCruce1(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL = "Select * from coo_SolicitudesCrucesAhorros where valor > 0.00 and IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptSolicitudCruce2(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL = "Select p.*, LineaCredito=li.nombre from coo_SolicitudesCrucesPrestamos p inner join coo_lineas li on p.idlinea=li.idlinea where p.ValorAbono > 0.00 and p.IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptAplicacionReintegro1(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL = "Select * from coo_AplicarReintegrosAhorros where valor > 0.00 and IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptAplicacionReintegro2(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL = "Select p.*, LineaCredito=li.nombre from coo_AplicarReintegrosPrestamos p inner join coo_lineas li on p.idlinea=li.idlinea where p.ValorAbono > 0.00 and p.IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    '

    Public Function rptSolicitudFiador(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudFiador", IdSolicitud, IdGarantia).Tables(0)
    End Function

    Public Function rptSolvenciaEconomica(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spRptSolvenciaEconomica", IdSolicitud).Tables(0)
    End Function

    Public Function rptSolvenciaEconomicaDetalle(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spRptSolvenciaEconomicaDetalle", IdSolicitud).Tables(0)
    End Function

    Public Function rptSolicitudPrestamoGarantia(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select TipoGarantia=tg.Nombre,sg.Concepto from coo_SolicitudesGarantias sg inner join coo_TiposGarantia tg on sg.IdTipo=tg.IdTipo  "
        sql &= "where sg.IdSolicitud=" & IdSolicitud

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptDictamenTecnicoFiadores(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select NombreFiador=NombresApellidos, Direccion, Telefonos from coo_GarantiasFiador "
        sql &= "where IdSolicitud=" & IdSolicitud

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptSolicitudPrestamoBien(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select DescripcionPropiedad, Direccion, ValorAproximado, EsHipotecado=case when Hipotecado=0 then 'NO' else 'SI' end from coo_SolicitudesBien "
        sql &= "where IdSolicitud=" & IdSolicitud

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptFiadorBien(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As DataTable
        Dim sql As String = "select DescripcionPropiedad, Direccion, ValorAproximado, EsHipotecado=case when Hipotecado=0 then 'NO' else 'SI' end from coo_FiadoresBien "
        sql &= "where IdSolicitud=" & IdSolicitud & " AND IdFiador=" & IdGarantia
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptFiadores(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select NombreFiador=NombresApellidos, Direccion, Telefonos from coo_GarantiasFiador "
        sql &= "where IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptRefinanciamiento(ByVal IdSolicitudFondo As Integer) As DataTable
        Dim sSQL As String = "select NumeroPrestamo=pre.Numero,re.SaldoCapital,re.SaldoInteres,re.SaldoInteresMoratorio,re.SaldoSeguro,re.SaldoOtros from coo_SolicitudFondosRefinancia re inner join coo_Prestamos pre on re.Idprestamo=pre.IdPrestamo  "
        If IdSolicitudFondo = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where re.IdSolicitudFondo=" & IdSolicitudFondo
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function rptDeducciones(ByVal IdSolicitudFondo As Integer) As DataTable
        Dim sSQL As String = "select Concepto=dp.Nombre,sf.Valor from coo_SolicitudFondosDeducciones sf inner join coo_DeduccionesPrestamo dp on  sf.IdDeduccion=dp.IdDeduccion "
        If IdSolicitudFondo = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where sf.IdSolicitudFondo=" & IdSolicitudFondo
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function rptPrestamosLiquidaFondos(ByVal IdSolicitudFondo As Integer) As DataTable
        Dim sSQL As String = "select l.Nombre as Linea, S.SaldoCapital, S.SaldoInteres, S.SaldoInteresMoratorio, S.SaldoSeguro, S.SaldoOtros from coo_SolicitudFondosRefinancia  S inner join coo_Prestamos P on  S.IdPrestamo=P.IdPrestamo inner join coo_lineas l on p.idlinea=l.idlinea where S.IdSolicitudFondo =" & IdSolicitudFondo
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function


    Public Function GetDictamenTecnico(ByVal IdSolicitud As Integer) As DataTable
        Dim sSQL As String = "select * from coo_DictamenTecnico "
        If IdSolicitud = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdSolicitud=" & IdSolicitud
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function rptDictamenTecnico2(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spDictamenTecnico2", IdSolicitud).Tables(0)
    End Function
    Public Function rptAutorizacionGerencia(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spAutorizacionGerencia", IdSolicitud).Tables(0)
    End Function

    Public Function rptSolicitudFondos(ByVal IdSolicitudFondo As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudFondos", IdSolicitudFondo).Tables(0)
    End Function

    Public Function rptLiquidacionPrestamo(ByVal IdSolicitudFondo As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spLiquidacionPrestamo", IdSolicitudFondo).Tables(0)
    End Function

    Public Function rptResolucionConsejo(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spResolucionConsejo", IdSolicitud).Tables(0)
    End Function

    Public Function rptResolucionGerencia(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spResolucionGerencia", IdSolicitud).Tables(0)
    End Function

    Public Function rptResolucionComite(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spResolucionComite", IdSolicitud).Tables(0)
    End Function

    Public Function rptResolucionConsejoAdministracion(ByVal IdSolicitud As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spResolucionConsejoAdministracion", IdSolicitud).Tables(0)
    End Function

    Public Function coo_SaldoFondoSolicitud(ByVal IdSolicitud As Integer) As coo_SaldoFondoSolicitud
        Dim dt As DataTable = db.ExecuteDataSet("coo_spGetSaldoFondoSolicitud", IdSolicitud).Tables(0)
        Dim entSaldoFondo As New coo_SaldoFondoSolicitud
        If dt.Rows.Count = 0 Then
            With entSaldoFondo
                .IdDesembolso = 0
                .Desembolsado = 0.0
            End With

        Else
            With entSaldoFondo
                .IdDesembolso = dt.Rows(0).Item("IdDesembolso")
                .Desembolsado = dt.Rows(0).Item("Desembolso")
            End With
        End If
        Return entSaldoFondo
    End Function


    Public Function InsertaCorteCaja _
(ByRef entCorteCaja As coo_CorteCaja, ByRef entArqueo As List(Of coo_CorteCajaArqueo), ByRef entCheques As List(Of coo_CorteCajaCheques)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj As String = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entCorteCaja.IdCorte = fd.ObtenerUltimoId("Coo_CorteCaja", "IdCorte") + 1
            objTabla.coo_CorteCajaInsert(entCorteCaja, tran)

            For Each detalle As coo_CorteCajaArqueo In entArqueo
                detalle.IdCorte = entCorteCaja.IdCorte
                objTabla.coo_CorteCajaArqueoInsert(detalle, tran)
            Next

            For Each detalle As coo_CorteCajaCheques In entCheques
                detalle.IdCorte = entCorteCaja.IdCorte
                objTabla.coo_CorteCajaChequesInsert(detalle, tran)
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



    Public Function InsertaSolicitudFondo _
(ByRef entSolicitudFondo As coo_SolicitudFondos, ByRef entRefinancia As List(Of coo_SolicitudFondosRefinancia) _
, ByRef entDeduccion As List(Of coo_SolicitudFondosDeducciones)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entSolicitudFondo.IdSolicitudFondo = fd.ObtenerUltimoId("Coo_SolicitudFondos", "IdSolicitudFondo") + 1
            objTabla.coo_SolicitudFondosInsert(entSolicitudFondo, tran)

            For Each detalle As coo_SolicitudFondosRefinancia In entRefinancia
                detalle.IdSolicitudFondo = entSolicitudFondo.IdSolicitudFondo
                objTabla.coo_SolicitudFondosRefinanciaInsert(detalle, tran)
            Next

            For Each detalle As coo_SolicitudFondosDeducciones In entDeduccion
                detalle.IdSolicitudFondo = entSolicitudFondo.IdSolicitudFondo
                objTabla.coo_SolicitudFondosDeduccionesInsert(detalle, tran)
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

    Public Function InsertaDesembolso1 _
(ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByRef entPlan As List(Of coo_PrestamosPlanPagos), _
ByRef IdFondo As Integer, ByRef IdMunicipio As String, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones) As String
        Dim cn As DbConnection = db.CreateConnection
        Dim IdMovAporta As Integer = 0
        Dim SaldoAportacion As Decimal = 0.0
        Dim LinealibretaAportacion As Integer = 0
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entPrestamo.IdPrestamo = fd.ObtenerUltimoId("Coo_Prestamos", "IdPrestamo") + 1
            objTabla.coo_PrestamosInsert(entPrestamo, tran)

            entDesembolso.IdPrestamo = entPrestamo.IdPrestamo
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo)
            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            Dim dtDeposito As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entDeposito.IdCuenta).Tables(0)
            entDeposito.IdMov = (dtDeposito.Rows(0).Item("IdMov")) + 1
            entDeposito.Saldo = (dtDeposito.Rows(0).Item("SaldoActual")) + entDeposito.Valor
            entDeposito.LineaLibreta = (dtDeposito.Rows(0).Item("Linea")) + 1

            If entSimultaneo.IdCuenta > 0 Then
                If entDeposito.IdCuenta <> entSimultaneo.IdCuenta Then
                    Dim dtSimultaneo As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entSimultaneo.IdCuenta).Tables(0)
                    entSimultaneo.IdMov = (dtSimultaneo.Rows(0).Item("IdMov")) + 1
                    entSimultaneo.Saldo = (dtSimultaneo.Rows(0).Item("SaldoActual")) + entSimultaneo.Valor
                    entSimultaneo.LineaLibreta = (dtSimultaneo.Rows(0).Item("Linea")) + 1
                Else
                    entSimultaneo.IdMov = entDeposito.IdMov + 1
                    entSimultaneo.Saldo = entDeposito.Saldo + entSimultaneo.Valor
                    entSimultaneo.LineaLibreta = entDeposito.LineaLibreta + 1
                End If
                objTabla.coo_CuentasAhorroMovInsert(entSimultaneo, tran)
            End If
            objTabla.coo_CuentasAhorroMovInsert(entDeposito, tran)

            If (entAportacion.Abono + entCapitalizacion.Abono) > 0 Then
                IdMovAporta = (db.ExecuteScalar("coo_spGetUlMovAporta", entPrestamo.IdAsociado))
                SaldoAportacion = (db.ExecuteScalar("coo_spGetSaldoAporta", entPrestamo.IdAsociado))
                LinealibretaAportacion = (db.ExecuteScalar("coo_spGetUltLineaAporta", entPrestamo.IdAsociado))
            End If

            If entAportacion.Abono > 0 Then
                entAportacion.IdMov = IdMovAporta + 1
                entAportacion.Saldo = SaldoAportacion + entAportacion.Abono
                entAportacion.LineaLibreta = LinealibretaAportacion + 1
                objTabla.coo_AportacionesInsert(entAportacion, tran)
                IdMovAporta = IdMovAporta + 1
                SaldoAportacion = SaldoAportacion + entAportacion.Abono
                LinealibretaAportacion = LinealibretaAportacion + 1
            End If

            If entCapitalizacion.Abono > 0 Then
                entCapitalizacion.IdMov = IdMovAporta + 1
                entCapitalizacion.Saldo = SaldoAportacion + entCapitalizacion.Abono
                entCapitalizacion.LineaLibreta = LinealibretaAportacion + 1
                objTabla.coo_AportacionesInsert(entCapitalizacion, tran)
            End If

            entLiquidacion.IdPrestamo = entPrestamo.IdPrestamo
            objTabla.coo_PrestamosDesembolsoInsert(entLiquidacion, tran)

            For Each detalle As coo_PrestamosPlanPagos In entPlan
                detalle.IdPrestamo = entPrestamo.IdPrestamo
                objTabla.coo_PrestamosPlanPagosInsert(detalle, tran)
            Next

            Dim sql As String = "update coo_SolicitudFondos set entregado = 1 WHERE IdSolicitudFondo=" & IdFondo
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "update adm_Municipios set correlativo = Correlativo + 1 WHERE IdMunicipio=" & IdMunicipio
            db.ExecuteNonQuery(tran, CommandType.Text, sql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function InsertaCambioTasa(ByRef entCambioTasa As List(Of coo_PrestamosDetalle)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            For Each detalle As coo_PrestamosDetalle In entCambioTasa
                detalle.IdMov = GetUltMovPrestamo(detalle.IdPrestamo) + 1
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            'objTabla.coo_PrestamosDetalleInsert(entCambioTasa, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades

            entTraslado.IdTraslado = GetUltMovTraslado(entTraslado.IdPrestamo) + 1
            objTabla.coo_PrestamosTrasladoInsert(entTraslado, tran)

            Dim sql As String = "update coo_Prestamos set IdTipoCartera = 1 WHERE IdPrestamo=" & entTraslado.IdPrestamo
            db.ExecuteNonQuery(tran, CommandType.Text, sql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado, _
    ByRef entCambioTasa As coo_PrestamosDetalle, ByRef entCambioTasaMora As coo_PrestamosDetalle, _
    ByVal TipoCartera As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entTraslado.IdTraslado = GetUltMovTraslado(entTraslado.IdPrestamo) + 1
            objTabla.coo_PrestamosTrasladoInsert(entTraslado, tran)

            entCambioTasaMora.IdMov = GetUltMovPrestamo(entCambioTasaMora.IdPrestamo) + 1
            objTabla.coo_PrestamosDetalleInsert(entCambioTasaMora, tran)

            entCambioTasa.IdMov = entCambioTasaMora.IdMov + 1
            objTabla.coo_PrestamosDetalleInsert(entCambioTasa, tran)

            Dim sql As String = "update coo_Prestamos set IdTipoCartera = " & TipoCartera & " WHERE IdPrestamo=" & entTraslado.IdPrestamo
            db.ExecuteNonQuery(tran, CommandType.Text, sql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado, _
ByRef entCambioTasa As coo_PrestamosDetalle, ByRef entCambioTasaMora As coo_PrestamosDetalle, _
ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle, _
ByRef entPlanPago As List(Of coo_PrestamosPlanPagos), ByVal IdMunicipio As String, _
ByRef entNuevoTraslado As coo_PrestamosTraslado) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades

            entTraslado.IdTraslado = GetUltMovTraslado(entTraslado.IdPrestamo) + 1
            objTabla.coo_PrestamosTrasladoInsert(entTraslado, tran)

            entCambioTasaMora.IdMov = GetUltMovPrestamo(entCambioTasaMora.IdPrestamo) + 1
            objTabla.coo_PrestamosDetalleInsert(entCambioTasaMora, tran)

            entCambioTasa.IdMov = entCambioTasaMora.IdMov + 1
            objTabla.coo_PrestamosDetalleInsert(entCambioTasa, tran)

            entPrestamo.IdPrestamo = fd.ObtenerUltimoId("Coo_Prestamos", "IdPrestamo") + 1
            objTabla.coo_PrestamosInsert(entPrestamo, tran)

            entNuevoTraslado.IdTraslado = 1
            entNuevoTraslado.IdPrestamo = entPrestamo.IdPrestamo
            objTabla.coo_PrestamosTrasladoInsert(entNuevoTraslado, tran)

            entDesembolso.IdPrestamo = entPrestamo.IdPrestamo
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo)
            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            For Each detalle As coo_PrestamosPlanPagos In entPlanPago
                detalle.IdPrestamo = entPrestamo.IdPrestamo
                objTabla.coo_PrestamosPlanPagosInsert(detalle, tran)
            Next

            Dim sql As String = "update coo_Prestamos set IdTipoCartera = 3 WHERE IdPrestamo= " & entTraslado.IdPrestamo
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "update adm_Municipios set correlativo = Correlativo + 1 WHERE IdMunicipio = " & IdMunicipio
            db.ExecuteNonQuery(tran, CommandType.Text, sql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function


    Public Function EliminaTrasladoPrestamo(ByVal IdPrestamo As Integer, ByVal IdMovInteres As Integer, ByVal IdMovMora As Integer, ByVal IdTraslado As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            If IdMovInteres > 0 Then
                objTabla.coo_PrestamosDetalleDeleteByPK(IdPrestamo, IdMovInteres)
            End If
            If IdMovMora > 0 Then
                objTabla.coo_PrestamosDetalleDeleteByPK(IdPrestamo, IdMovMora)
            End If
            If IdTraslado > 0 Then
                objTabla.coo_PrestamosTrasladoDeleteByPK(IdPrestamo, IdTraslado)
            End If

            Dim sSQL As String = "update coo_Prestamos set IdTipoCartera = 1 WHERE IdPrestamo=" & IdPrestamo
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

    Public Function InsertaDesembolso(ByRef entDesembolso As coo_PrestamosDetalle, ByRef entDeposito As coo_CuentasAhorroMov, ByVal IdFondo As Integer, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, ByRef entCapitalizacion As coo_Aportaciones) As String
        Dim cn As DbConnection = db.CreateConnection
        Dim IdMovAporta As Integer = 0
        Dim SaldoAportacion As Decimal = 0.0
        Dim LinealibretaAportacion As Integer = 0

        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades

            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo) + 1
            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            Dim dtDeposito As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entDeposito.IdCuenta).Tables(0)
            entDeposito.IdMov = (dtDeposito.Rows(0).Item("IdMov")) + 1
            entDeposito.Saldo = (dtDeposito.Rows(0).Item("SaldoActual")) + entDeposito.Valor
            entDeposito.LineaLibreta = (dtDeposito.Rows(0).Item("Linea")) + 1


            If entSimultaneo.IdCuenta > 0 Then
                If entDeposito.IdCuenta <> entSimultaneo.IdCuenta Then
                    Dim dtSimultaneo As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entSimultaneo.IdCuenta).Tables(0)
                    entSimultaneo.IdMov = (dtSimultaneo.Rows(0).Item("IdMov")) + 1
                    entSimultaneo.Saldo = (dtSimultaneo.Rows(0).Item("SaldoActual")) + entSimultaneo.Valor
                    entSimultaneo.LineaLibreta = (dtSimultaneo.Rows(0).Item("Linea")) + 1
                Else
                    entSimultaneo.IdMov = entDeposito.IdMov + 1
                    entSimultaneo.Saldo = entDeposito.Saldo + entSimultaneo.Valor
                    entSimultaneo.LineaLibreta = entDeposito.LineaLibreta + 1
                End If
                objTabla.coo_CuentasAhorroMovInsert(entSimultaneo, tran)
            End If
            objTabla.coo_CuentasAhorroMovInsert(entDeposito, tran)


            If (entAportacion.Abono + entCapitalizacion.Abono) > 0 Then
                IdMovAporta = (db.ExecuteScalar("coo_spGetUlMovAporta", entAportacion.IdAsociado))
                SaldoAportacion = (db.ExecuteScalar("coo_spGetSaldoAporta", entAportacion.IdAsociado))
                LinealibretaAportacion = (db.ExecuteScalar("coo_spGetUltLineaAporta", entAportacion.IdAsociado))
            End If

            If entAportacion.Abono > 0 Then
                entAportacion.IdMov = IdMovAporta + 1
                entAportacion.Saldo = SaldoAportacion + entAportacion.Abono
                entAportacion.LineaLibreta = LinealibretaAportacion + 1
                objTabla.coo_AportacionesInsert(entAportacion, tran)
                IdMovAporta = IdMovAporta + 1
                SaldoAportacion = SaldoAportacion + entAportacion.Abono
                LinealibretaAportacion = LinealibretaAportacion + 1
            End If

            If entCapitalizacion.Abono > 0 Then
                entCapitalizacion.IdMov = IdMovAporta + 1
                entCapitalizacion.Saldo = SaldoAportacion + entCapitalizacion.Abono
                entCapitalizacion.LineaLibreta = LinealibretaAportacion + 1
                objTabla.coo_AportacionesInsert(entCapitalizacion, tran)
            End If

            entLiquidacion.IdPrestamo = entDesembolso.IdPrestamo
            objTabla.coo_PrestamosDesembolsoInsert(entLiquidacion, tran)

            Dim sSQL As String = "update coo_SolicitudFondos set entregado = 'True' WHERE IdSolicitudFondo=" & IdFondo
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

    Public Function GetSaldoCapitalPrestamo(ByVal IdPrestamo As Integer) As Decimal
        Dim SaldoCapital As Decimal = db.ExecuteScalar("coo_spGetSaldoCapitalPrestamo", IdPrestamo)
        Return SaldoCapital
    End Function

    Public Function GetSaldoAsociadoFiador(ByVal Documento As String, ByVal Fecha As Date) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spAsociadoFiador", Documento, Fecha)
        Return Saldo
    End Function


#Region "Reportes"
    Public Function rptProvisionIntereses(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spRptProvisionIntereses", IdSucursal, HastaFecha).Tables(0)
    End Function

#Region "Reportes Generales"
    Public Function rptListadoSolicitudesEstado(ByVal IdEstado As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoSolicitudesEstado", IdEstado, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoSolicitudesComparativo(ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoSolicitudesComparativo", DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoDesembolsos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date, ByVal IncluirAutomaticos As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDesembolsos", IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha, IncluirAutomaticos).Tables(0)
    End Function

    Public Function rptListadoGeneralpagos(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal IdFormaPago As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoGeneralPagos", IdSucursal, IdTecnico, IdFuente, IdFormaPago, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoResoluciones(ByVal TipoReporte As Integer, ByVal NumeroActa As String, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoResoluciones", TipoReporte, NumeroActa, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoAcuerdos(ByVal TipoFecha As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoAcuerdos", TipoFecha, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoSeguimientos(ByVal TipoFecha As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoSeguimientos", TipoFecha, DesdeFecha, HastaFecha).Tables(0)
    End Function


    Public Function rptListadoPagosLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal IdFormaPago As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoPagosLinea", IdSucursal, IdTecnico, IdLinea, IdFormaPago, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptPrestamosRegistrados(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal ExcluirAutomaticos As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spPrestamosRegistrados", IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha, ExcluirAutomaticos).Tables(0)
    End Function

    Public Function rptPrestamosTipoGarantia(ByVal IdTipo As Integer, ByVal TipoPlazo As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spPrestamosTipoGarantia", IdTipo, TipoPlazo, IdLinea, IdFuente, HastaFecha).Tables(0)
    End Function
    Public Function rptPrestamosTipoCredito(ByVal IdTipoCredito As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spRptPrestamosTipoCredito", IdTipoCredito, IdLinea, IdFuente, HastaFecha).Tables(0)
    End Function
    Public Function rptPrestamosSaldosFacturas(ByVal IdLinea As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spPrestamosPorFacturacionPtes", IdLinea, HastaFecha).Tables(0)
    End Function
    Public Function rptPrestamosFacCobradosCancelados(ByVal IdLinea As Integer, ByVal TipoReporte As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spPrestamosFacCobradosCancelados", IdLinea, TipoReporte, DesdeFecha, HastaFecha).Tables(0)
    End Function


    Public Function rptEstadoCuentaPrestamo(ByVal NumeroPrestamo As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaPrestamo", NumeroPrestamo, HastaFecha).Tables(0)
    End Function

    Public Function rptImprimeAcuerdo(ByVal IdSeguimiento As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spImprimeAcuerdo", IdSeguimiento).Tables(0)
    End Function

    Public Function rptListadoGeneralPrestamos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoGeneralPrestamos", IdSucursal, IdLinea, IdTecnico, IdFuente, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptListadoPrestamosCancelados(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spListadoPrestamosCancelados", IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha).Tables(0)
    End Function

    Public Function rptListadoFiadores(ByVal NroDocumento As String, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoFiadores", NroDocumento, IdAsociado, HastaFecha, Incluir).Tables(0)
    End Function
#End Region
#Region "Reportes Financieros"
    Public Function rptConsolidadoGeneralCartera(ByVal IdSucursal As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptConsolidadoGeneralCartera", IdSucursal, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptConsolidadoCarteraFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptConsolidadoCarteraFuente", IdSucursal, IdFuente, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptDetalleCarteraFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleCarteraFuente", IdSucursal, IdFuente, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptConsolidadoCarteraTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptConsolidadoCarteraTecnico", IdSucursal, IdTecnico, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptConsolidadoCarteraLinea(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptConsolidadoCarteraLinea", IdSucursal, IdLinea, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptConsolidadoCreditosVencidos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_sprptConsolidadoCreditosVencidos", IdSucursal, IdLinea, HastaFecha).Tables(0)
    End Function


    Public Function rptConsolidadoCarteraCanton(ByVal IdSucursal As Integer, ByVal TipoCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptConsolidadoCarteraCanton", IdSucursal, TipoCanton, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptDetalleGeneralCartera(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal IdCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleGeneralCartera", IdSucursal, IdLinea, IdFuente, IdCanton, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptDetalleCarteraCanton(ByVal IdSucursal As Integer, ByVal IdCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleCarteraCanton", IdSucursal, IdCanton, TipoCartera, HastaFecha, Incluir).Tables(0)
    End Function


    Public Function rptDetalleGeneralCarteraPorLinea(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataSet
        Return db.ExecuteDataSet("coo_spRptDetalleGeneralCarteraPorLinea", IdSucursal, IdLinea, TipoCartera, HastaFecha, Incluir)
    End Function
#End Region
#Region "Reportes de los Técnicos"
    Public Function rptDetalleCarteraTecnicoGeneral(ByVal IdTecnico As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleCarteraTecnicoGeneral", IdTecnico, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptDetalleCarteraTecnicoFuente(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleCarteraTecnicoFuente", IdSucursal, IdTecnico, IdFuente, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptDetalleCarteraTecnicoLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_sprptDetalleCarteraTecnicoLinea", IdSucursal, IdTecnico, IdLinea, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptDetalleTecnicoClasificacion(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleTecnicoClasificacion", IdSucursal, IdTecnico, IdClasificacion, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptPrestamosVencerTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptPrestamosVencerTecnico", IdSucursal, IdTecnico, Ejercicio, Mes, Incluir).Tables(0)
    End Function

    Public Function rptProyeccionRecuperaciones(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spRptProyeccionRecuperaciones", IdSucursal, Ejercicio).Tables(0)
    End Function


    Public Function rptPrestamosPorTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptPrestamosPorTecnico", IdSucursal, IdTecnico, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptDetalleCarteraTecnicoCanton(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdCanton As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_sprptDetalleCarteraTecnicoCanton", IdSucursal, IdTecnico, IdCanton, HastaFecha, Incluir).Tables(0)
    End Function

    Public Function rptDetalleCarteraVencidaPorTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptDetalleCarteraVencidaPorTecnico", IdSucursal, IdTecnico, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptCuadroMora(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal HastaFecha As Date, ByVal Tipo As Integer) As DataSet
        Return db.ExecuteDataSet("coo_spRptCuadroMora", IdSucursal, IdTecnico, HastaFecha, Tipo)
    End Function
#End Region
#Region "Reportes de Antiguedad"
    Public Function rptAntiguedadGeneral(ByVal IdSucursal As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptAntiguedadGeneral", IdSucursal, IdClasificacion, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptAntiguedadPorFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptAntiguedadPorFuente", IdSucursal, IdFuente, IdClasificacion, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptAntiguedadTecnicoLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptAntiguedadTecnicoLinea", IdSucursal, IdTecnico, IdLinea, IdClasificacion, HastaFecha, Incluir).Tables(0)
    End Function
    Public Function rptAntiguedadPlazoLinea(ByVal IdSucursal As Integer, ByVal TipoPlazo As Integer, ByVal IdLinea As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptAntiguedadPlazoLinea", IdSucursal, TipoPlazo, IdLinea, IdClasificacion, HastaFecha, Incluir).Tables(0)
    End Function
#End Region

#End Region
    Public Function coo_FiadoresSelectByDui(ByVal NroDocumento As System.String) As coo_GarantiasFiador
        Dim dt As DataTable = db.ExecuteDataSet("coo_spFiadoresSelectByDui", NroDocumento).Tables(0)

        Dim Entidad As New coo_GarantiasFiador
        If dt.Rows.Count > 0 Then
            Entidad.IdGarantia = dt.Rows(0).Item("IdGarantia")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.NombresApellidos = dt.Rows(0).Item("NombresApellidos")
            Entidad.NroDocumento = dt.Rows(0).Item("NroDocumento")
            Entidad.LugarExpedicion = dt.Rows(0).Item("LugarExpedicion")
            Entidad.FechaExpedicion = dt.Rows(0).Item("FechaExpedicion")
            Entidad.IdProfesion = dt.Rows(0).Item("IdProfesion")
            Entidad.Nit = dt.Rows(0).Item("Nit")
            Entidad.Direccion = dt.Rows(0).Item("Direccion")
            Entidad.IdMunicipio = dt.Rows(0).Item("IdMunicipio")
            Entidad.IdDepartamento = dt.Rows(0).Item("IdDepartamento")
            Entidad.IdCanton = dt.Rows(0).Item("IdCanton")
            Entidad.Telefonos = dt.Rows(0).Item("Telefonos")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.IdSexo = dt.Rows(0).Item("IdSexo")
            Entidad.IdEstadoCivil = dt.Rows(0).Item("IdEstadoCivil")
            Entidad.PersonasSostiene = dt.Rows(0).Item("PersonasSostiene")
            Entidad.ViveCasaPropia = dt.Rows(0).Item("ViveCasaPropia")
            Entidad.TipoTrabajo = dt.Rows(0).Item("TipoTrabajo")
            Entidad.NombreTrabajo = dt.Rows(0).Item("NombreTrabajo")
            Entidad.DireccionTrabajo = dt.Rows(0).Item("DireccionTrabajo")
            Entidad.TelefonoTrabajo = dt.Rows(0).Item("TelefonoTrabajo")
            Entidad.TipoContratacion = dt.Rows(0).Item("TipoContratacion")
            Entidad.TiempoTrabajo = dt.Rows(0).Item("TiempoTrabajo")
            Entidad.SalarioMensual = dt.Rows(0).Item("SalarioMensual")
            Entidad.Comisiones = dt.Rows(0).Item("Comisiones")
            Entidad.IngresosNegocio = dt.Rows(0).Item("IngresosNegocio")
            Entidad.OtrosIngresos = dt.Rows(0).Item("OtrosIngresos")
            Entidad.GastosVida = dt.Rows(0).Item("GastosVida")
            Entidad.PagoObligaciones = dt.Rows(0).Item("PagoObligaciones")
            Entidad.GastosNegocio = dt.Rows(0).Item("GastosNegocio")
            Entidad.OtrosGastos = dt.Rows(0).Item("OtrosGastos")
        End If
        Return Entidad
    End Function

    Public Function coo_PrestamosSelectByNumero _
  (ByVal Numero As String) As coo_Prestamos

        Dim dt As DataTable = db.ExecuteDataSet("coo_spPrestamosSelectByNumero", Numero).Tables(0)

        Dim Entidad As New coo_Prestamos
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.MontoAprobado = dt.Rows(0).Item("MontoAprobado")
            Entidad.FechaAprobado = dt.Rows(0).Item("FechaAprobado")
            Entidad.FechaOtorgado = dt.Rows(0).Item("FechaOtorgado")
            Entidad.FechaPrimerPago = dt.Rows(0).Item("FechaPrimerPago")
            Entidad.MontoDesembolsado = dt.Rows(0).Item("MontoDesembolsado")
            Entidad.MesesGracia = dt.Rows(0).Item("MesesGracia")
            Entidad.DiasMoraGracia = dt.Rows(0).Item("DiasMoraGracia")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.TipoCuota = dt.Rows(0).Item("TipoCuota")
            Entidad.IdTipoAplicacion = fd.SiEsNulo(dt.Rows(0).Item("IdTipoAplicacion"), Nothing)
            Entidad.FrecuenciaPago = dt.Rows(0).Item("FrecuenciaPago")
            Entidad.NumCuotas = dt.Rows(0).Item("NumCuotas")
            Entidad.TasaInteres = dt.Rows(0).Item("TasaInteres")
            Entidad.TasaMora = dt.Rows(0).Item("TasaMora")
            Entidad.ValorCuota = dt.Rows(0).Item("ValorCuota")
            Entidad.CuotaAportacion = dt.Rows(0).Item("CuotaAportacion")
            Entidad.CuotaAhorro = dt.Rows(0).Item("CuotaAhorro")
            Entidad.CuotaManejo = dt.Rows(0).Item("CuotaManejo")
            Entidad.CuotaOtros = dt.Rows(0).Item("CuotaOtros")
            Entidad.TasaSeguro = dt.Rows(0).Item("TasaSeguro")
            Entidad.FechaVencimiento = dt.Rows(0).Item("FechaVencimiento")
            Entidad.IdDepartamento = dt.Rows(0).Item("IdDepartamento")
            Entidad.IdMunicipio = dt.Rows(0).Item("IdMunicipio")
            Entidad.IdCanton = dt.Rows(0).Item("IdCanton")
            Entidad.IdTecnico = dt.Rows(0).Item("IdTecnico")
            Entidad.IdLinea = dt.Rows(0).Item("IdLinea")
            Entidad.IdFuente = dt.Rows(0).Item("IdFuente")
            Entidad.IdTipoCartera = dt.Rows(0).Item("IdTipoCartera")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.IdTipoPrestamo = dt.Rows(0).Item("IdTipoPrestamo")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Function coo_SaldosPrestamo(ByVal IdPrestamo As System.Int32, ByVal Fecha As System.DateTime) As coo_SaldoPrestamo
        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spSaldosPrestamo", IdPrestamo, Fecha).Tables(0)

        Dim Entidad As New coo_SaldoPrestamo
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.SaldoCapital = dt.Rows(0).Item("SaldoCapital")
            Entidad.SaldoInteres = dt.Rows(0).Item("SaldoInteres")
            Entidad.SaldoInteresMora = dt.Rows(0).Item("SaldoInteresMora")
            Entidad.TasaInteres = dt.Rows(0).Item("TasaInteres")
            Entidad.TasaMora = dt.Rows(0).Item("TasaMora")
        End If
        Return Entidad
    End Function

    Public Function coo_PrestamoParaConsulta(ByVal Nombres As String, ByVal Apellidos As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spPrestamoParaConsulta", Nombres, Apellidos, Fecha, Incluir).Tables(0)
    End Function

    Public Function GetChequesCaja(ByVal IdCorte As Integer) As DataTable
        Dim sql As String = "select a.IdCorte, a.NumeroCuenta, a.NumeroCheque, a.NombreBanco, a.AnombreDe, a.Valor from coo_CorteCajaCheques a WHERE a.IdCorte=" & IdCorte
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

#Region "Otros Procesos"
    Function ObtenerIdTipoOperacion(ByVal IdTipoOperacion As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdTipoOperacion
        End If
        Dim sSQL As String = "select top 1 IdTipoOperacion from coo_TiposOperacionNumerario where IdTipoOperacion < " & IdTipoOperacion & " order by IdTipoOperacion desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdTipoOperacion from coo_TiposOperacionNumerario where IdTipoOperacion > " & IdTipoOperacion
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function


    Public Function GetArqueoNumerario(ByVal IdOperacion As Integer) As DataTable
        Dim sql As String = "select a.IdOperacion, a.IdDenominacion, d.Valor, a.Cantidad, a.Total, d.Nombre from coo_OperacionesNumerarioArqueo a inner join coo_DenominacionesMoneda d on a.IdDenominacion=d.IdDenominacion WHERE a.IdOperacion=" & IdOperacion
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function GetDenominacionesNumerario() As DataTable
        Dim sql As String = "select IdOperacion=convert(Integer,0),IdDenominacion,Valor,Cantidad=convert(Integer,0),Total=convert(decimal,0.00),Nombre from coo_DenominacionesMoneda "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function GetChequesNumerario(ByVal IdOperacion As Integer) As DataTable
        Dim sql As String = "select IdOperacion, NumeroCuenta, NumeroCheque, NombreBanco, AnombreDe,Valor from coo_OperacionesNumerarioCheques where IdOperacion=" & IdOperacion
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function rptMovimientoFechaNumerario(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spMovimientoFechaNumerario", IdSucursal, DesdeFecha, HastaFecha).Tables(0)
    End Function


    Public Function InsertaOperacionNumerario _
(ByRef entOperacion As coo_OperacionesNumerario, ByRef entArqueo As List(Of coo_OperacionesNumerarioArqueo) _
, ByRef entCheques As List(Of coo_OperacionesNumerarioCheques)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entOperacion.IdOperacion = fd.ObtenerUltimoId("Coo_OperacionesNumerario", "IdOperacion") + 1
            objTabla.coo_OperacionesNumerarioInsert(entOperacion, tran)

            For Each detalle As coo_OperacionesNumerarioArqueo In entArqueo
                detalle.IdOperacion = entOperacion.IdOperacion
                objTabla.coo_OperacionesNumerarioArqueoInsert(detalle, tran)
            Next

            For Each detalle As coo_OperacionesNumerarioCheques In entCheques
                detalle.IdOperacion = entOperacion.IdOperacion
                objTabla.coo_OperacionesNumerarioChequesInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            tran.Commit()
            cn.Close()
        End Try

        Return msj
    End Function


    Public Function UpdateOperacionNumerario _
(ByRef entOperacion As coo_OperacionesNumerario _
, ByRef entArqueo As List(Of coo_OperacionesNumerarioArqueo), ByRef entCheques As List(Of coo_OperacionesNumerarioCheques)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTabla.coo_OperacionesNumerarioUpdate(entOperacion, tran)

            Dim sSQL As String = "delete coo_OperacionesNumerarioArqueo where IdOperacion=" & entOperacion.IdOperacion
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            Dim sSQL2 As String = "delete coo_OperacionesNumerarioCheques where IdOperacion=" & entOperacion.IdOperacion
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL2)

            For Each detalle As coo_OperacionesNumerarioArqueo In entArqueo
                detalle.IdOperacion = entOperacion.IdOperacion
                objTabla.coo_OperacionesNumerarioArqueoInsert(detalle, tran)
            Next

            For Each detalle As coo_OperacionesNumerarioCheques In entCheques
                detalle.IdOperacion = entOperacion.IdOperacion
                objTabla.coo_OperacionesNumerarioChequesInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function


    Public Function rptOperacionNumerario(ByVal IdOperacion As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spOperacionNumerario", IdOperacion).Tables(0)
    End Function

    Public Function ExisteIdOperacion(ByVal IdOperacion As Integer) As Integer
        Dim sSql As String = "select IdOperacion from coo_OperacionesNumerario where IdOperacion=" & IdOperacion
        IdOperacion = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return IdOperacion
    End Function


    Public Function ExisteNumOperacion(ByVal Numero As String, ByVal IdTipoOperacion As Integer) As Integer
        Dim sSql As String = "select IdOperacion from coo_OperacionesNumerario where Numero= '" & Numero & "' and IdTipoOperacion=" & IdTipoOperacion
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function


    Function ObtenerIdOperacion(ByVal IdOperacion As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdOperacion
        End If
        Dim sSQL As String = "select top 1 IdOperacion from coo_OperacionesNumerario where IdOperacion < " & IdOperacion & " order by IdOperacion desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdOperacion from coo_OperacionesNumerario where IdOperacion > " & IdOperacion
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function


#End Region
    Public Function rptReciboPagoIdMov(ByVal IdPrestamo As Integer, ByVal IdMov As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spReciboPagoPrestamo", IdPrestamo, IdMov).Tables(0)
    End Function

    Public Function rptCorteNumerarioIngresos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteNumerarioIngresos", IdSucursal, HastaFecha).Tables(0)
    End Function

    Public Function rptCorteNumerario(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteNumerario", IdSucursal, HastaFecha).Tables(0)
    End Function

    Public Function rptCorteNumerarioEgresos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteNumerarioEgresos", IdSucursal, HastaFecha).Tables(0)
    End Function

    Public Function rptCorteNumerarioArqueo(ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteNumerarioArqueo", IdSucursal, Fecha).Tables(0)
    End Function

    Public Function rptPagareDeudor(ByVal Nombre As String, ByVal Edad As String, _
                                    ByVal Profesion As String, ByVal Municipio As String, _
                                    ByVal Depto As String, ByVal NumDocumento As String, _
                                    ByVal MontoLetras As String, ByVal NumCuotas As String, _
                                    ByVal ValorCuota As String, ByVal Plazo As String, _
                                    ByVal FechaVENCE As String, ByVal TasaInteres As String, _
                                    ByVal FechaActual As String, ByVal TasaMora As String) As DataTable

        Return db.ExecuteDataSet("coo_spTemplatePagareDeudor", Nombre, Edad, Profesion, Municipio, _
                                 Depto, NumDocumento, MontoLetras, NumCuotas, _
                                 ValorCuota, Plazo, FechaVENCE, TasaInteres, _
                                 FechaActual, TasaMora).Tables(0)
    End Function


    Function ObtenerParametrosEstructuras() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from coo_EstructurasAdministracion").Tables(0)
    End Function



    Public Function ActualizarPrestamo(ByVal IdPrestamo As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, _
        ByVal IdFuente As Integer, ByVal IdCanton As String, ByVal IdUsuario As String, ByVal CuotaGestion As Decimal _
        , ByVal FechaPrimer As DateTime, ByVal IdFormaPago As Integer, ByVal IdTipoAplicacion As Integer, ByVal ValorCuota As Decimal) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            Dim sql As String = ""
            sql = "update coo_Prestamos Set IdLinea=" & IdLinea & ", IdTecnico="
            sql += IdTecnico & ",IdFuente=" & IdFuente & ", IdCanton='" & IdCanton
            sql += "'" + ",ModificadoPor='" & IdUsuario & "' ,CuotaGestion=" & CuotaGestion
            sql += ",IdTipoAplicacion=" & IdTipoAplicacion & ", ValorCuota=" & ValorCuota
            sql += ", FechaPrimerPago= '" & Format(FechaPrimer, "yyyyMMdd") & "'"
            sql += ", IdFormaPago = " & IdFormaPago
            sql += " where IdPrestamo = " & IdPrestamo

            db.ExecuteNonQuery(CommandType.Text, sql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj


    End Function


    Public Function GetPrestamosPlanPago(ByVal IdPrestamo As Integer) As DataTable
        Dim sSQL As String = "select NumeroCuota=NumCuota,FechaPago=Fecha,ImporteCuota=Valor "
        sSQL += ",ImporteCuotaSeguro=CuotaSeguro,ImporteCuotaAportacion=CuotaAportacion,ImporteCuotaAhorro=CuotaAhorro "
        sSQL += ",ImporteCuotaManejo=CuotaManejo,ImporteInteres=Interes,ImporteCapital=Capital,ImporteSaldo=Saldo from coo_PrestamosPlanPagos "
        If IdPrestamo = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdPrestamo=" & IdPrestamo
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function getPrestamosPlanPagoCapital(ByVal IdPrestamo As Integer, ByVal fecha As DateTime) As Decimal
        Dim sSQL As String = "select isnull(sum(Capital),0.0) capital from coo_PrestamosPlanPagos "
        sSQL &= "where IdPrestamo=" & IdPrestamo
        sSQL &= " and fecha<='" & Format(fecha, "yyyyMMdd") + "'"

        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function


    Public Function rptInformeEstadisticoFuente(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoFuente", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoLinea(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoLinea", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoMunicipio(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoMunicipio", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoTecnico(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoTecnico", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoTipoPlazo(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoTipoPlazo", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoSexo(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoSexo", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoEdad(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoEdad", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function rptInformeEstadisticoFormaPago(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spRptEstadisticoFormaPago", IdSucursal, Hasta, Incluir).Tables(0)
    End Function

    Public Function GetChequesCorteCaja(ByVal IdCorte As Integer) As DataTable
        Dim sql As String = "select IdCorte, NumeroCuenta, NumeroCheque, NombreBanco, AnombreDe,Valor from coo_CorteCajaCheques where IdCorte=" & IdCorte
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ExisteNumPrestamo(ByVal Numero As String) As Integer
        Dim sSql As String = String.Format("select IdPrestamo from coo_Prestamos where Numero= '{0}'", Numero)
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function AnulaPresEfectivo(ByVal IdSol As Integer, ByVal IdPrestamo As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""


        Try
            objTabla.coo_PrestamosPlanPagosDeleteByPrestamo(IdPrestamo)
            objTabla.coo_PrestamosDetalleDeleteByPK(IdPrestamo, 1)
            objTabla.coo_PrestamosDesembolsoDeleteByPK(0, IdPrestamo)
            objTabla.coo_PrestamosDetalleDescuentosDeleteByIdPrestamo(IdPrestamo)
            objTabla.coo_PrestamosDeleteByPK(IdPrestamo)

            Dim sSql As String = "update coo_PrestamosEfectivo  set anulado = 1 , MontoSolicitado =0, TasaInteres=0, ValorCuota=0 where idsolicitud= " & IdSol
            db.ExecuteNonQuery(CommandType.Text, sSql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function



    Public Function AprobarSolicitudRetiro(ByVal IdSol As Integer, ByVal Usuario As String) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try

            Dim sSql As String = "update coo_SolicitudRetiro  set AprobadoPor = '" & Usuario & "'"
            sSql += " , FechaHoraAprobacion= getdate() "
            sSql += " where IdSolicitud =  " & IdSol
            db.ExecuteNonQuery(CommandType.Text, sSql)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function ObtenerIdSolFondosEfectivo(ByVal IdSolicitud As Integer) As Integer
        Dim sSql As String = String.Format("select IdSolicitudFondo from coo_SolicitudFondos where IdSolicitud= '{0}'", IdSolicitud)
        sSql += " and IdDesembolso=99"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function adm_GenerarPartidasDiarias(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As String
        Return db.ExecuteScalar("coo_spPartidaCierreSucursal", IdSucursal, Desde, IdUsuario, GeneraReporte)
    End Function
    Public Function PartidaTelefonia(ByVal Fecha As Date, ByVal CreadoPor As String) As String
        Return db.ExecuteScalar("coo_spContabilizarTelefonia", Fecha, CreadoPor)
    End Function
    Public Function PartidaCargaPlanilla(ByVal IdPlanilla As Integer, ByVal Fecha As Date, ByVal CreadoPor As String) As String
        Return db.ExecuteScalar("coo_spContabilizaCargaPlanilla", IdPlanilla, Fecha, CreadoPor)
    End Function

    Public Function InsertaDescuentos _
(ByRef entAportaciones As List(Of coo_Aportaciones) _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle) _
, ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal creado As String) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades

            For Each detalle As coo_Aportaciones In entAportaciones
                If detalle.Abono > 0.0 Then
                    objTabla.coo_AportacionesInsert(detalle, tran)
                End If
            Next

            For Each detalle As coo_CuentasAhorroMov In entAhorros
                If detalle.Valor > 0.0 Then
                    If detalle.IdCuenta > 0 Then
                        objTabla.coo_CuentasAhorroMovInsert(detalle, tran)
                    Else
                        objTabla.coo_CuentasAhorroMovInsert(detalle, tran)
                    End If
                End If
            Next

            Dim IdMovPre As Integer = 0
            For Each detalle As coo_PrestamosDetalle In entPrestamos

                If (detalle.CapitalPagado + detalle.InteresPagado + detalle.InteresMoraPagado + detalle.ValorSeguroPagado) > 0.0 Then
                    objTabla.coo_PrestamosDetalleInsert(detalle, tran)
                End If
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
    Public Function InsertaAbonosTelefono(ByRef entTelefono As List(Of coo_abonoTelefonia)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            For Each detalle As coo_abonoTelefonia In entTelefono
                objTabla.coo_abonoTelefoniaInsert(detalle, tran)
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
    Public Function InsertaDescuentosTelefonos(ByRef entTelefono As List(Of coo_DescuentoTelefoniaPendiente)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            For Each detalle As coo_DescuentoTelefoniaPendiente In entTelefono
                objTabla.coo_DescuentoTelefoniaPendienteInsert(detalle, tran)
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
    Public Function AplicaCrucesCuentas _
(ByRef IdSolicitud As Integer, ByRef entAportaciones As List(Of coo_Aportaciones) _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            For Each detalle As coo_Aportaciones In entAportaciones
                objTabla.coo_AportacionesInsert(detalle, tran)
            Next

            For Each detalle As coo_CuentasAhorroMov In entAhorros
                objTabla.coo_CuentasAhorroMovInsert(detalle, tran)
            Next

            For Each detalle As coo_PrestamosDetalle In entPrestamos
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_SolicitudesCruces  set Autorizado = 1, AutorizadoPor = 'GERENTE' , FechaHoraAutorizacion = getdate() where IdSolicitud= " & IdSolicitud
            db.ExecuteNonQuery(CommandType.Text, sSQL)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function



    Public Function AplicaReintegroCuentas _
(ByRef IdSolicitud As Integer, ByRef entAportaciones As coo_Aportaciones _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            If entAportaciones.Abono > 0.0 Then
                objTabla.coo_AportacionesInsert(entAportaciones, tran)
            End If


            For Each detalle As coo_CuentasAhorroMov In entAhorros
                objTabla.coo_CuentasAhorroMovInsert(detalle, tran)
            Next

            For Each detalle As coo_PrestamosDetalle In entPrestamos
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_AplicarReintegros  set Autorizado = 1, AutorizadoPor = 'GERENTE' , FechaHoraAutorizacion = getdate() where IdSolicitud= " & IdSolicitud
            db.ExecuteNonQuery(CommandType.Text, sSQL)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function
    Public Function AplicaRetiroSocios _
(ByRef entAportaciones As List(Of coo_Aportaciones), ByRef entAhorros As List(Of coo_CuentasAhorroMov) _
 , ByRef entPrestamos As List(Of coo_PrestamosDetalle), ByVal Liquido As Decimal _
 , ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdCuentaCobrar As String, ByVal IdSolicitud As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try
            'TODO Calcula correlativos y los actualiza en las entidades

            For Each detalle As coo_Aportaciones In entAportaciones
                objTabla.coo_AportacionesInsert(detalle, tran)
            Next

            For Each detalle As coo_CuentasAhorroMov In entAhorros
                objTabla.coo_CuentasAhorroMovInsert(detalle, tran)
            Next

            For Each detalle As coo_PrestamosDetalle In entPrestamos
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            Dim sql As String = ""
            If Liquido < 0 Then ' le queda debiendo a la cooperativa
                sql = "UPDATE COO_ASOCIADOS SET IDESTADO = 4,FechaRetiro='" & Format(Fecha, "yyyyMMdd") & "'"
                sql += " WHERE IdAsociado = " & IdAsociado
            Else
                sql = "UPDATE COO_ASOCIADOS SET IDESTADO = 3,FechaRetiro='" & Format(Fecha, "yyyyMMdd") & "'"
                sql += " WHERE IdAsociado = " & IdAsociado
            End If
            db.ExecuteNonQuery(CommandType.Text, sql)

            If IdCuentaCobrar <> "" Then
                Dim sSQL As String = "update coo_SolicitudRetiro set IdCuentaCobrar = '" & IdCuentaCobrar & "'"
                sSQL += " , Aplicado = 1  where IdSolicitud = " & IdSolicitud
                db.ExecuteNonQuery(CommandType.Text, sSQL)
            End If

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function AplicaRetiroSocios2(ByRef entPrestamos As List(Of coo_PrestamosDetalle) _
        , ByVal IdCuentaCobrar As String, ByVal IdSolicitud As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""

        Try

            For Each detalle As coo_PrestamosDetalle In entPrestamos
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            Dim sSQL As String = "update coo_SolicitudRetiro set IdCuentaCobrar = '" & IdCuentaCobrar & "'"
            sSQL += " where IdSolicitud = " & IdSolicitud
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function rptListadoLiquidacionCaja(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoLiquidacionCaja", IdSucursal, IdCentro, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptListadoAplicacionPlanilla(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDesceuntosPlanilla", IdSucursal, IdCentro, DesdeFecha, HastaFecha, IdAsociado).Tables(0)
    End Function

    Public Function rptListadoAplicacionPlanillaConsolidado(ByVal IdPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spListadoDescuentosPlanillaConsolidada", IdPlanilla, DesdeFecha, HastaFecha).Tables(0)
    End Function


    Public Function rptListadoSaldosSocios(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime _
        , ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer, ByVal IdLinea As Integer, ByVal IncluyeAporte As Boolean, ByVal IncluyeAhorro As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spListadoSaldoFechas", IdSucursal, IdAsociado, DesdeFecha, HastaFecha, IdLinea, IncluyeAporte, IncluyeAhorro).Tables(0)
    End Function

    Public Function FechaPlanilla(ByVal Fecha As DateTime) As DateTime
        Dim sSQL As String = "Select Fecha from coo_prestamosdetalle where idformapago=6 and creadopor <> 'ITO' and fechacontable ='" & Format(Fecha, "yyyyMMdd") & "'"
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function ValidaReversionPlanilla(ByVal FechaContable As Date, ByVal Fecha As Date, ByVal IdTipo As Integer) As Integer
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar("coo_spGetValidaPlanilla", FechaContable, Fecha, IdTipo), 0)
        Return NumeroReg
    End Function
    Public Function ValidaDescuentoTelefonico(ByVal Fecha As Date) As Integer
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar("coo_spGetValidaDescuentoTelefonico", Fecha), 0)
        Return NumeroReg
    End Function

    Public Function ObtieneFechaCancelacion(ByVal IdPrestamo As Integer) As Date
        Dim sSql As String = "select max(fecha) fecha from coo_prestamosdetalle where IdPrestamo=  " & IdPrestamo
        Dim FechaC As Date = db.ExecuteScalar(CommandType.Text, sSql)
        Return FechaC
    End Function


End Class
