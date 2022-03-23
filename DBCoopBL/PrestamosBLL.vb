Imports DBCoopDL
Imports DBCoopEL.TableEntities
Public Class PrestamosBLL
    ReadOnly dl As New PrestamosDLL()
    
    Public Function ObtenerIdFuente(ByVal IdFuente As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdFuente(IdFuente, TipoAvance)
    End Function
    Public Function ObtenerIdLinea(ByVal IdLinea As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdLinea(IdLinea, TipoAvance)
    End Function
    Public Function ObtenerImpresorDefault(ByVal IdUsuario As String) As String
        Return dl.ObtenerImpresorDefault(IdUsuario)
    End Function
    Public Function ObtenerIdDeduccionPrestamo(ByVal IdDeduccion As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdDeduccionPrestamo(IdDeduccion, TipoAvance)
    End Function
    Public Function EnvioDescuentosPlanillaDespensa(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
    , ByVal TipoPlanilla As Integer, ByVal GuardarEnvio As Boolean, ByVal Detalle As Boolean _
    , ByVal EnvioAhorro As Boolean, ByVal CreadoPor As String) As DataTable
        Return dl.EnvioDescuentosPlanillaDespensa(IdSucursal, HastaFecha, TipoPlanilla, GuardarEnvio, Detalle, EnvioAhorro, CreadoPor)
    End Function

    Public Function EnvioDescuentosPlanillaFinanciero(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
, ByVal TipoPlanilla As Integer, ByVal GuardarEnvio As Boolean, ByVal Detalle As Boolean _
, ByVal IdCentro As Integer, ByVal CreadoPor As String, ByVal EnvioRRHH As Boolean, ByVal cheAplicaPlanilla As Boolean) As DataTable
        Return dl.EnvioDescuentosPlanillaFinanciero(IdSucursal, HastaFecha, TipoPlanilla, GuardarEnvio, Detalle, IdCentro, CreadoPor, EnvioRRHH, cheAplicaPlanilla)
    End Function

    Public Function EnvioDescuentosTelefono() As DataTable
        Return dl.EnvioDescuentosTelefono()
    End Function
    Public Function ObtenerFechaDescuento(ByVal Fecha As Date) As Integer
        Return dl.ObtenerFechaDescuento(Fecha)
    End Function

    Public Function SaldoLineaAsociado(ByVal IdLinea As Integer, ByVal IdAsociado As Integer, ByVal Fecha As Date) As Decimal
        Return dl.SaldoLineaAsociado(IdLinea, IdAsociado, Fecha)
    End Function

    Public Function ObtenerIdFormaPago(ByVal IdFormaPago As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdFormaPago(IdFormaPago, TipoAvance)
    End Function
    Public Function ObtenerSaldoCaja(ByVal HastaFecha As Date) As Decimal
        Return dl.ObtenerSaldoCaja(HastaFecha)
    End Function
    Public Function ObtenerSolCrucePendiente(ByVal IdAsociado As Integer) As Integer
        Return dl.ObtenerSolCrucePendiente(IdAsociado)
    End Function
    Public Function FechaDescuentoActiva() As Date
        Return dl.FechaDescuentoActiva()
    End Function

    Public Function FechaDescuentoActivaAntigua() As Date
        Return dl.FechaDescuentoActivaAntigua()
    End Function

    Public Function VerificaAplicoEnvio(ByVal Fecha As Date, ByVal TipoPlanilla As Integer) As Integer
        Return dl.VerificaAplicoEnvio(Fecha, TipoPlanilla)
    End Function
    Public Function CierreFechaDescuento(ByVal IdComprobante As Integer, ByVal UsrCierra As String, ByVal FechaActual As Date) As Integer
        Return dl.CierreFechaDescuento(IdComprobante, UsrCierra, FechaActual)
    End Function
    Public Function ObtenerIdTipoMovimiento(ByVal IdTipoMovimiento As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdTipoMovimiento(IdTipoMovimiento, TipoAvance)
    End Function
    Public Function ObtenerIdTecnico(ByVal IdTecnico As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdTecnico(IdTecnico, TipoAvance)
    End Function

    Public Function CobroPendienteOtrasLineas(ByVal IdAsociado As Integer, ByVal HastaFecha As Date) As Decimal
        Return dl.CobroPendienteOtrasLineas(IdAsociado, HastaFecha)
    End Function
    Public Function rptInformeAseguradora(ByVal HastaFecha As Date, ByVal IdSucursal As Integer) As DataTable
        Return dl.rptInformeAseguradora(HastaFecha, IdSucursal)
    End Function
    Public Function ObtenerFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return dl.ObtenerFiadores(IdSolicitud)
    End Function
    Public Function rptEnvioDescuentosTelefonico(ByVal FechaAplicacion As Date, ByVal IdCentro As Integer) As DataTable
        Return dl.rptEnvioDescuentosTelefonico(FechaAplicacion, IdCentro)
    End Function
    Public Function rptListadoCruces(ByVal IdSucursal As Integer, ByVal IdAsociado As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal Estado As Integer) As DataTable
        Return dl.rptListadoCruces(IdSucursal, IdAsociado, DesdeFecha, HastaFecha, Estado)
    End Function

    Public Function VerificaSolPendientesFacturar(ByVal IdAsociado As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.VerificaSolPendientesFacturar(IdAsociado, IdLinea, HastaFecha)

    End Function
    Public Function InsertaCorteCaja(ByRef entCorteCaja As coo_CorteCaja _
, ByRef entArqueo As List(Of coo_CorteCajaArqueo), ByRef entCheques As List(Of coo_CorteCajaCheques)) As String
        Return dl.InsertaCorteCaja(entCorteCaja, entArqueo, entCheques)
    End Function

    Public Function rptInformeAseguradoraAportacion(ByVal HastaFecha As Date, ByVal IdSucursal As Integer) As DataTable
        Return dl.rptInformeAseguradoraAportacion(HastaFecha, IdSucursal)
    End Function

    Public Function rptInformeAseguradoraAhorro(ByVal HastaFecha As Date, ByVal IdSucursal As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeAseguradoraAhorro(HastaFecha, IdSucursal, Incluir)
    End Function

    Public Function ObtenerUltimasTasas(ByVal IdPrestamo As Integer) As DataTable
        Return dl.ObtenerUltimasTasas(IdPrestamo)
    End Function

    Public Function ArchivoInfored(ByVal HastaFecha As Date) As DataTable
        Return dl.ArchivoInfored(HastaFecha)
    End Function
    Public Function rptInformeAuditoria1(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptInformeAuditoria1(IdSucursal, Desde, Hasta)
    End Function
    Public Function rptInformeAuditoria2(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptInformeAuditoria2(IdSucursal, Desde, Hasta)
    End Function
    Public Function rptInformeAuditoria3(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptInformeAuditoria3(IdSucursal, Desde, Hasta)
    End Function
    Public Function rptInformeAuditoria4(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptInformeAuditoria4(IdSucursal, Desde, Hasta)
    End Function
    Public Function rptInformeAuditoria5(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptInformeAuditoria5(IdSucursal, Desde, Hasta)
    End Function

    Public Function rptInformeAuditoria6(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date, ByVal Valor As Decimal) As DataTable
        Return dl.rptInformeAuditoria6(IdSucursal, Desde, Hasta, Valor)
    End Function

    Public Function rptDatosConsolidados(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptDatosConsolidados(IdSucursal, Desde, Hasta)
    End Function

    Public Function rptCobrosAportaciones(ByVal IdSolicitud As Integer, ByVal Hasta As Date) As DataTable
        Return dl.rptCobrosAportaciones(IdSolicitud, Hasta)
    End Function


    Public Function rptInformeEstadisticoFuente(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoFuente(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoLinea(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoLinea(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoMunicipio(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoMunicipio(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoTecnico(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoTecnico(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoTipoPlazo(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoTipoPlazo(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoSexo(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoSexo(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoEdad(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoEdad(IdSucursal, Hasta, Incluir)
    End Function

    Public Function rptInformeEstadisticoFormaPago(ByVal IdSucursal As Integer, ByVal Hasta As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInformeEstadisticoFormaPago(IdSucursal, Hasta, Incluir)
    End Function

    Public Function ActualizarSolicitudResolucion(ByVal IdSolicitud As Integer, ByVal CuotaManejo As Decimal, _
                                                  ByVal CuotaAhorro As Decimal, ByVal IncluyeSeguro As Decimal, _
                                                  ByVal CuotaAportacion As Decimal) As Integer
        Return dl.ActualizarSolicitudResolucion(IdSolicitud, CuotaManejo, CuotaAhorro, IncluyeSeguro, CuotaAportacion)
    End Function
    Public Function ActualizaActaResolucion(ByVal NumActa As Integer) As Integer
        Return dl.ActualizaActaResolucion(NumActa)
    End Function


    'Public Function ActualizarResolucionGerencia(ByVal entRes As coo_Resoluciones) As Integer
    '    Return dl.ActualizarResolucionGerencia(IdSolicitud, ComiteActa, Recomendaciones, Resolucion, OtrasGerente, _
    '                                           TipoResolucion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago, _
    '                                           MesGracia, TipoTramite, IdEstado, IdSucursal, Fecha)
    'End Function

    '    Public Function ActualizarResolucionComite(ByVal IdSolicitud As Integer, ByVal ComiteActa As String, _
    'ByVal Recomendaciones As String, ByVal Resolucion As String, ByVal OtrasComite As String, _
    'ByVal TipoResolucion As Integer, ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer, _
    'ByVal TipoTramite As String, ByVal IdEstado As Integer, ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As Integer
    '        Return dl.ActualizarResolucionComite(IdSolicitud, ComiteActa, Recomendaciones, Resolucion, OtrasComite, _
    '                                               TipoResolucion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago, _
    '                                               MesGracia, TipoTramite, IdEstado, IdSucursal, Fecha)
    '    End Function


    '    Public Function ActualizarResolucionConsejo(ByVal IdSolicitud As Integer, ByVal ComiteConsejo As String, _
    'ByVal Recomendaciones As String, ByVal Resolucion As String, ByVal OtrasConsejo As String, _
    'ByVal TipoResolucion As Integer, ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    'ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer, _
    'ByVal TipoTramite As String, ByVal IdEstado As Integer, ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As Integer
    '        Return dl.ActualizarResolucionConsejo(IdSolicitud, ComiteConsejo, Recomendaciones, Resolucion, OtrasConsejo, _
    '                                               TipoResolucion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago, _
    '                                               MesGracia, TipoTramite, IdEstado, IdSucursal, Fecha)
    '    End Function

    ' Public Function ResolucionAprobadaGerencia(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '     Return dl.ResolucionAprobadaGerencia(IdSolicitud, FechaAprobacion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago)
    ' End Function

    ' Public Function ResolucionAprobadaComite(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '     Return dl.ResolucionAprobadaComite(IdSolicitud, FechaAprobacion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago)
    ' End Function

    ' Public Function ResolucionAprobadaConsejo(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer) As Integer
    '     Return dl.ResolucionAprobadaConsejo(IdSolicitud, FechaAprobacion, Monto, Cuotas, Tasa, IdFormaPago, FrecuenciaPago)
    ' End Function


    'Public Function ResolucionReprobadaGerencia(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Return dl.ResolucionReprobadaGerencia(IdSolicitud, FechaAprobacion)
    'End Function

    'Public Function ResolucionReprobadaComite(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Return dl.ResolucionReprobadaComite(IdSolicitud, FechaAprobacion)
    'End Function

    'Public Function ResolucionReprobadaConsejo(ByVal IdSolicitud As Integer, ByVal FechaAprobacion As DateTime) As Integer
    '    Return dl.ResolucionReprobadaConsejo(IdSolicitud, FechaAprobacion)
    'End Function

    ' Public Function ResolucionRecomendadaGerencia(ByVal IdSolicitud As Integer, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer) As Integer
    '     Return dl.ResolucionRecomendadaGerencia(IdSolicitud, Monto, Cuotas, Tasa, IdFormaPago, _
    '                                             FrecuenciaPago, MesGracia)
    ' End Function

    ' Public Function ResolucionRecomendadaComite(ByVal IdSolicitud As Integer, _
    'ByVal Monto As Decimal, ByVal Cuotas As Decimal, ByVal Tasa As Decimal, _
    ' ByVal IdFormaPago As Integer, ByVal FrecuenciaPago As Integer, ByVal MesGracia As Integer) As Integer
    '     Return dl.ResolucionRecomendadaComite(IdSolicitud, Monto, Cuotas, Tasa, IdFormaPago, _
    '                                             FrecuenciaPago, MesGracia)
    ' End Function

    Public Function ObtenerIdCanton(ByVal Id As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdCanton(Id, TipoAvance)
    End Function
    Public Function rptCantones() As DataTable
        Return dl.rptCantones()
    End Function
    Public Function ExisteCodCanton(ByVal IdCanton As String) As Integer
        Return dl.ExisteCodCanton(IdCanton)
    End Function
    Public Function coo_CorteCajaSelectFecha(ByVal Fecha As Date, ByVal Usuario As String) As coo_CorteCaja
        Return dl.coo_CorteCajaSelectFecha(Fecha, Usuario)
    End Function
    Public Function GetArqueoCaja(ByVal idCorte As Integer) As DataTable
        Return dl.GetArqueoCaja(idCorte)
    End Function

    Public Function rptIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptIngresosEgresos(IdSucursal, DesdeFecha, HastaFecha, IdUsuario)
    End Function

    Public Function rptInformeRemesas(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptInformeRemesas(IdSucursal, DesdeFecha, HastaFecha, IdUsuario)
    End Function


    Public Function rptHistorialPrestamo(ByVal IdAsociado As Integer, ByVal Fecha As Date, ByVal IncluirCancelados As Boolean) As DataTable
        Return dl.rptHistorialPrestamo(IdAsociado, Fecha, IncluirCancelados)
    End Function
    Public Function rptDatosAsociado(ByVal IdAsociado As Integer, ByVal Fecha As Date) As DataTable
        Return dl.rptDatosAsociado(IdAsociado, Fecha)
    End Function
    Public Function ObtenerIdSolicitud(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdSolicitud(IdSolicitud, TipoAvance)
    End Function
    Public Function ObtenerIdSolicitudEfectivo(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdSolicitudEfectivo(IdSolicitud, TipoAvance)
    End Function
    Public Function ObtenerIdSolicitudRetiro(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdSolicitudRetiro(IdSolicitud, TipoAvance)
    End Function
    Public Function ObtenerIdSolicitudCruce(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdSolicitudCruce(IdSolicitud, TipoAvance)
    End Function
    Public Function ObtenerIdAplicarReintegro(ByVal IdSolicitud As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdAplicarReintegro(IdSolicitud, TipoAvance)
    End Function
    Public Function GetObligacionesSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetObligacionesSolicitud(IdSolicitud)
    End Function

    'Public Function GetDetalleIngresosSolicitud(ByVal IdSolicitud As Integer) As DataTable
    '    Return dl.GetDetalleIngresosSolicitud(IdSolicitud)
    'End Function

    'Public Function GetDetalleGastosSolicitud(ByVal IdSolicitud As Integer) As DataTable
    '    Return dl.GetDetalleGastosSolicitud(IdSolicitud)
    'End Function

    Public Function GetSeguimientoCobros(ByVal IdPrestamo As Integer) As DataTable
        Return dl.GetSeguimientoCobros(IdPrestamo)
    End Function

    Public Function GetSeguimientoPrestamos(ByVal IdPrestamo As Integer) As DataTable
        Return dl.GetSeguimientoPrestamos(IdPrestamo)
    End Function


    Public Function ActualizarSolicitudFondo(ByVal IdSolicitudFondo As Integer) As Integer
        Return dl.ActualizarSolicitudFondo(IdSolicitudFondo)
    End Function

    Public Function ActualizarAnulacionDesembolso(ByVal IdPrestamo As Integer, ByVal MontoDesembolsado As Decimal) As Integer
        Return dl.ActualizarAnulacionDesembolso(IdPrestamo, MontoDesembolsado)
    End Function


    Public Function GetDeducciones(ByVal Monto As Decimal) As DataTable
        Return dl.GetDeducciones(Monto)
    End Function
    Public Function GetSaldoPrestamoAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdLinea As Integer, ByVal TotalRetirar As Decimal, ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetSaldoPrestamoAsociado(IdAsociado, Fecha, IdLinea, TotalRetirar, IdSolicitud)
    End Function

    Public Function GetSaldoPrestamoRapidoAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdLinea As Integer, ByVal TotalRetirar As Decimal, ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetSaldoPrestamoRapidoAsociado(IdAsociado, Fecha, IdLinea, TotalRetirar, IdSolicitud)
    End Function

    Public Function GetPrestamosSolRetiro(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetPrestamosSolRetiro(IdSolicitud)
    End Function
    Public Function GetDenominaciones() As DataTable
        Return dl.GetDenominaciones()
    End Function
    Public Function GetObligacionesFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Return dl.GetObligacionesFiador(IdSolicitud, IdFiador)
    End Function
    Public Function GetBienesSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetBienesSolicitud(IdSolicitud)
    End Function
    Public Function GetBienesFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Return dl.GetBienesFiador(IdSolicitud, IdFiador)
    End Function
    Public Function GetReferenciasSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetReferenciasSolicitud(IdSolicitud)
    End Function
    Public Function GetFiadoresSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetFiadoresSolicitud(IdSolicitud)
    End Function
    Public Function rptCorteCaja(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptCorteCaja(IdSucursal, HastaFecha, IdUsuario)
    End Function
    Public Function rptCorteCajaIngresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteCajaIngresos(IdSucursal, IdUsuario, HastaFecha)
    End Function
    Public Function rptCorteCajaEgresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteCajaEgresos(IdSucursal, IdUsuario, HastaFecha)
    End Function
    Public Function GetReferenciasFiador(ByVal IdSolicitud As Integer, ByVal IdFiador As Integer) As DataTable
        Return dl.GetReferenciasFiador(IdSolicitud, IdFiador)
    End Function
    Public Function GetGarantiasSolicitud(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetGarantiasSolicitud(IdSolicitud)
    End Function
    Public Function GetEmisionDesembolso(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetEmisionDesembolso(IdSolicitud)
    End Function
    Public Function GetDescuentosCuota(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetDescuentosCuota(IdSolicitud)
    End Function
    Public Function GetProgramacionPrestamo(ByVal IdPrestamo As Integer) As DataTable
        Return dl.GetProgramacionPrestamo(IdPrestamo)
    End Function
    Public Function GetSaldosPrestamos(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal Nuevo As Boolean, ByVal Modulo As String) As DataTable
        Return dl.GetSaldosPrestamos(IdSolicitud, IdAsociado, HastaFecha, Nuevo, Modulo)
    End Function
    'Public Function GetDeudasSolRetiro(ByVal IdSolicitud As Integer) As DataTable
    '    Return dl.GetDeudasSolRetiro(IdSolicitud)
    'End Function
    Public Function ExisteIdSolicitud(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteIdSolicitud(IdSolicitud)
    End Function
    Public Function ExisteSolicitudFondos(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteSolicitudFondos(IdSolicitud)
    End Function
    Public Function ExisteSolicitudPresEfectivo(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteSolicitudPresEfectivo(IdSolicitud)
    End Function
    Public Function GetIdSolicitudFondos(ByVal IdSolicitud As Integer) As Integer
        Return dl.GetIdSolicitudFondos(IdSolicitud)
    End Function
    Public Function ExisteDesembolso(ByVal IdSolicitudFondo As Integer) As Integer
        Return dl.ExisteDesembolso(IdSolicitudFondo)
    End Function
    Public Function ExisteSolicitudPrestamo(ByVal IdSolicitud As Integer) As String
        Return dl.ExisteSolicitudPrestamo(IdSolicitud)
    End Function
    Public Function ExistePrestamo(ByVal IdSolicitud As Integer) As String
        Return dl.ExistePrestamo(IdSolicitud)
    End Function
    Public Function ExisteFiadorSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Return dl.ExisteFiadorSolicitud(IdSolicitud, IdGarantia)
    End Function
    Public Function ExisteCambioTasa(ByVal IdPrestamo As Integer, ByVal Fecha As DateTime, ByVal TipoTasa As Integer) As Integer
        Return dl.ExisteCambioTasa(IdPrestamo, Fecha, TipoTasa)
    End Function
    Public Function ExisteTrasladoPrestamo(ByVal IdPrestamo As Integer, ByVal Fecha As DateTime) As Integer
        Return dl.ExisteTrasladoPrestamo(IdPrestamo, Fecha)
    End Function

    Public Function ExisteHipotecaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Return dl.ExisteHipotecaSolicitud(IdSolicitud, IdGarantia)
    End Function

    Public Function ExisteDictamenTecnico(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteDictamenTecnico(IdSolicitud)
    End Function

    Public Function ExisteResolucionSolicitud(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteResolucionSolicitud(IdSolicitud)
    End Function

    Public Function ExisteDictamenGerencia(ByVal IdSolicitud As Integer) As Integer
        Return dl.ExisteDictamenGerencia(IdSolicitud)
    End Function

    Public Function ExistePrendaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Return dl.ExistePrendaSolicitud(IdSolicitud, IdGarantia)
    End Function

    Public Function ExisteCuentaPignoradaSolicitud(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As Integer
        Return dl.ExisteCuentaPignoradaSolicitud(IdSolicitud, IdGarantia)
    End Function

    Public Function ExisteNumeroSolicitud(ByVal Numero As String) As Integer
        Return dl.ExisteNumeroSolicitud(Numero)
    End Function
    Public Function ExisteNumeroSolicitudCruce(ByVal Numero As String) As Integer
        Return dl.ExisteNumeroSolicitudCruce(Numero)
    End Function
    Public Function ExisteNumeroSolicitudPresEfectivo(ByVal Numero As String) As Integer
        Return dl.ExisteNumeroSolicitudPresEfectivo(Numero)
    End Function
    Public Function AplicaEjecutivos(ByVal IdAsociado As Integer) As Integer
        Return dl.AplicaEjecutivos(IdAsociado)
    End Function
    Public Function ExisteNumeroSolicitudpres(ByVal Numero As Integer) As Integer
        Return dl.ExisteNumeroSolicitudpres(Numero)
    End Function

    Public Function ExisteNumComprobanteDesembolso(ByVal Numero As String) As Integer
        Return dl.ExisteNumComprobanteDesembolso(Numero)
    End Function
    Public Function CambiaEstadoReintegro(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal IdPlanilla As Integer, ByVal FechaPlanilla As DateTime) As String
        Return dl.CambiaEstadoReintegro(IdSolicitud, IdAsociado, IdPlanilla, FechaPlanilla)
    End Function


    Public Function InsertaSolicitudPrestamo(ByRef entSolicitud As coo_Solicitudes _
    , ByRef entObligaciones As List(Of coo_SolicitudesObligacion) _
    , ByRef entBienes As List(Of coo_SolicitudesBien) _
    , ByRef entReferencias As List(Of coo_SolicitudesReferencia) _
    , ByRef entGarantias As List(Of coo_SolicitudesGarantias) _
    , ByRef entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso)) As String
        Return dl.InsertaSolicitudPrestamo(entSolicitud, entObligaciones, entBienes _
                                           , entReferencias, entGarantias, entEmisionDesembolso)
    End Function
    Public Function InsertaSolicitudCruce(ByRef entSolicitud As coo_SolicitudesCruces _
, ByRef entCruceAhorros As List(Of coo_SolicitudesCrucesAhorros), ByRef entCrucePrestamos As List(Of coo_SolicitudesCrucesPrestamos)) As String
        Return dl.InsertaSolicitudCruce(entSolicitud, entCruceAhorros, entCrucePrestamos)
    End Function
    Public Function InsertaAplicacionReintegro(ByRef entSolicitud As coo_AplicarReintegros _
, ByRef entReintegroAhorros As List(Of coo_AplicarReintegrosAhorros) _
, ByRef entReintegroPrestamos As List(Of coo_AplicarReintegrosPrestamos), ByVal FechaPlanilla As DateTime, ByVal TipoPlanilla As Integer) As String
        Return dl.InsertaAplicacionReintegro(entSolicitud, entReintegroAhorros, entReintegroPrestamos, FechaPlanilla, TipoPlanilla)
    End Function
    'entCruceAhorros, entCrucePrestamos
    Public Function InsertaSolicitudPrestamoEfectivo(ByRef entPresEfectivo As coo_PrestamosEfectivo, ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
        , ByRef entPlan As List(Of coo_PrestamosPlanPagos), ByRef entLiquidacion As coo_PrestamosDesembolso, ByRef entPresRef As List(Of coo_PrestamoEfectivoRefinancia), ByRef entCancelacion As List(Of coo_PrestamosDetalle)) As String
        Return dl.InsertaSolicitudPrestamoEfectivo(entPresEfectivo, entPrestamo, entDesembolso, entPlan, entLiquidacion, entPresRef, entCancelacion)

    End Function
    Public Function InsertaSolicitudRetiro(ByRef entRetiro As coo_SolicitudRetiro, ByRef entSolRetiroPrestamos As List(Of coo_SolicitudRetiroPrestamos)) As String
        Return dl.InsertaSolicitudRetiro(entRetiro, entSolRetiroPrestamos)

    End Function

    Public Function InsertaFiadorSolicitud(ByRef entFiador As coo_GarantiasFiador _
, ByRef entObligacionFiador As List(Of coo_FiadoresObligacion) _
, ByRef entBienFiador As List(Of coo_FiadoresBien) _
, ByRef entReferenciaFiador As List(Of coo_FiadoresReferencia)) As String
        Return dl.InsertaFiadorSolicitud(entFiador, entObligacionFiador, entBienFiador, entReferenciaFiador)
    End Function

    Public Function InsertaHipotecaSolicitud(ByRef entHipoteca As coo_GarantiasHipoteca) As String
        Return dl.InsertaHipotecaSolicitud(entHipoteca)
    End Function

    Public Function InsertaSeguimientoCobro(ByRef entSeguimiento As coo_SeguimientoCobros) As String
        Return dl.InsertaSeguimientoCobro(entSeguimiento)
    End Function

    Public Function InsertaSeguimientoPrestamo(ByRef entSeguimiento As coo_SeguimientoPrestamos) As String
        Return dl.InsertaSeguimientoPrestamo(entSeguimiento)
    End Function


    Public Function InsertaDictamenTecnico(ByRef entDictamen As coo_DictamenTecnico) As String
        Return dl.InsertaDictamenTecnico(entDictamen)
    End Function

    Public Function InsertaDictamenGerencia(ByRef entDictamen As coo_DictamenGerencia) As String
        Return dl.InsertaDictamenGerencia(entDictamen)
    End Function

    Public Function InsertaPrendaSolicitud(ByRef entPrenda As coo_GarantiasPrendaria) As String
        Return dl.InsertaPrendaSolicitud(entPrenda)
    End Function
    'Public Function CambiaEstadoReintegro(ByRef entPrenda As coo_GarantiasPrendaria) As String
    '    Return dl.InsertaPrendaSolicitud(entPrenda)
    'End Function

    Public Function InsertaCuentaPignoradaSolicitud(ByRef entPignorada As coo_GarantiasCuentaPignorada) As String
        Return dl.InsertaCuentaPignoradaSolicitud(entPignorada)
    End Function

    Public Function UpdateSolicitudPrestamo(ByRef entSolicitud As coo_Solicitudes _
    , ByRef entObligacion As List(Of coo_SolicitudesObligacion) _
    , ByRef entBienes As List(Of coo_SolicitudesBien), ByRef entReferencias As List(Of coo_SolicitudesReferencia) _
    , ByRef entGarantias As List(Of coo_SolicitudesGarantias) _
    , ByRef entEmisionDesembolso As List(Of coo_SolicitudesEmisionDesembolso)) As String
        Return dl.UpdateSolicitudPrestamo(entSolicitud, entObligacion, entBienes, entReferencias _
                                          , entGarantias, entEmisionDesembolso)
    End Function

    Public Function UpdateSolicitudCruce(ByRef entSolicitud As coo_SolicitudesCruces _
, ByRef entCruceAhorros As List(Of coo_SolicitudesCrucesAhorros) _
, ByRef entCrucePrestamos As List(Of coo_SolicitudesCrucesPrestamos)) As String
        Return dl.UpdateSolicitudCruce(entSolicitud, entCruceAhorros, entCrucePrestamos)
    End Function
    Public Function UpdateAplicacionReintegro(ByRef entSolicitud As coo_AplicarReintegros _
, ByRef entReintegroAhorros As List(Of coo_AplicarReintegrosAhorros) _
, ByRef entReintegroPrestamos As List(Of coo_AplicarReintegrosPrestamos)) As String
        Return dl.UpdateAplicacionReintegro(entSolicitud, entReintegroAhorros, entReintegroPrestamos)
    End Function
    ', 
    Public Function UpdateSolicitudPrestamoEfectivo(ByRef entPresEfectivo As coo_PrestamosEfectivo, ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
        , ByRef entPlan As List(Of coo_PrestamosPlanPagos), ByRef entLiquidacion As coo_PrestamosDesembolso, ByRef IdPrestamo As Integer) As String
        Return dl.UpdateSolicitudPrestamoEfectivo(entPresEfectivo, entPrestamo, entDesembolso, entPlan, entLiquidacion, IdPrestamo)
    End Function
    Public Function UpdateSolicitudRetiro(ByRef entSolicitud As coo_SolicitudRetiro, ByRef entSolRetiroPrestamos As List(Of coo_SolicitudRetiroPrestamos)) As String
        Return dl.UpdateSolicitudRetiro(entSolicitud, entSolRetiroPrestamos)
    End Function

    Public Function UpdateFiadorSolicitud(ByRef entFiador As coo_GarantiasFiador _
, ByRef entObligacion As List(Of coo_FiadoresObligacion) _
, ByRef entBienes As List(Of coo_FiadoresBien), ByRef entReferencias As List(Of coo_FiadoresReferencia)) As String
        Return dl.UpdateFiadorSolicitud(entFiador, entObligacion, entBienes, entReferencias)
    End Function

    Public Function UpdateDictamenTecnico(ByRef entDictamen As coo_DictamenTecnico) As String
        Return dl.UpdateDictamenTecnico(entDictamen)
    End Function

    Public Function UpdateResolucionSolicitud(ByRef entResolucion As coo_Resoluciones) As String
        Return dl.UpdateResolucionSolicitud(entResolucion)
    End Function

    Public Function InsertaResolucionSolicitud(ByRef entResolucion As coo_Resoluciones) As String
        Return dl.InsertaResolucionSolicitud(entResolucion)
    End Function

    Public Function UpdateDictamenGerencia(ByRef entDictamen As coo_DictamenGerencia) As String
        Return dl.UpdateDictamenGerencia(entDictamen)
    End Function

    Public Function UpdateHipotecaSolicitud(ByRef entHipoteca As coo_GarantiasHipoteca) As String
        Return dl.UpdateHipotecaSolicitud(entHipoteca)
    End Function


    Public Function UpdatePrendaSolicitud(ByRef entPrenda As coo_GarantiasPrendaria) As String
        Return dl.UpdatePrendaSolicitud(entPrenda)
    End Function

    Public Function ActualizarCuentaPignoradaSolicitud(ByRef entPignorada As coo_GarantiasCuentaPignorada) As String
        Return dl.ActualizarCuentaPignoradaSolicitud(entPignorada)
    End Function
    Public Function ConsultaSolicitudesByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.ConsultaSolicitudesByLike(Nombre, Apellido)
    End Function
    Public Function ConsultaSolicitudesCrucesByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.ConsultaSolicitudesCrucesByLike(Nombre, Apellido)
    End Function
    Public Function ConsultaReintegrosByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.ConsultaReintegrosByLike(Nombre, Apellido)
    End Function
    Public Function ConsultaSolicitudesPresEfectivoByLike(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.ConsultaSolicitudesPresEfectivoByLike(Nombre, Apellido)
    End Function
    Public Function ConsultaPeriodosTelefonos() As DataTable
        Return dl.ConsultaPeriodosTelefonos()
    End Function
    Public Function ConsultaSolicitudesAprobadas(ByVal Nombre As String, ByVal Apellido As String, ByVal SoloPendientes As Boolean) As DataTable
        Return dl.ConsultaSolicitudesAprobadas(Nombre, Apellido, SoloPendientes)
    End Function
    Public Function DesembolsosParaConsulta(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.DesembolsosParaConsulta(Nombre, Apellido)
    End Function

    Public Function GetFiadoresSolicitudPrestamo(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetFiadoresSolicitudPrestamo(IdSolicitud)
    End Function

    Public Function rptSolicitudPrestamo(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudPrestamo(IdSolicitud)
    End Function
    Public Function rptSolicitudPrestamoFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudPrestamoFiadores(IdSolicitud)
    End Function

    Public Function rptSolicitudCruce1(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudCruce1(IdSolicitud)
    End Function
    Public Function rptSolicitudCruce2(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudCruce2(IdSolicitud)
    End Function
    Public Function rptAplicacionReintegro1(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptAplicacionReintegro1(IdSolicitud)
    End Function
    Public Function rptAplicacionReintegro2(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptAplicacionReintegro2(IdSolicitud)
    End Function

    Public Function rptSolicitudFiador(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As DataTable
        Return dl.rptSolicitudFiador(IdSolicitud, IdGarantia)
    End Function

    Public Function rptSolvenciaEconomica(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolvenciaEconomica(IdSolicitud)
    End Function

    Public Function rptSolvenciaEconomicaDetalle(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolvenciaEconomicaDetalle(IdSolicitud)
    End Function


    Public Function rptFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptFiadores(IdSolicitud)
    End Function

    Public Function rptRefinanciamiento(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptRefinanciamiento(IdSolicitudFondo)
    End Function

    Public Function rptDeducciones(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptDeducciones(IdSolicitudFondo)
    End Function
    Public Function rptPrestamosLiquidaFondos(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptPrestamosLiquidaFondos(IdSolicitudFondo)
    End Function


    Public Function rptSolicitudPrestamoGarantia(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudPrestamoGarantia(IdSolicitud)
    End Function

    Public Function rptDictamenTecnicoFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptDictamenTecnicoFiadores(IdSolicitud)
    End Function

    Public Function rptSolicitudPrestamoBien(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptSolicitudPrestamoBien(IdSolicitud)
    End Function

    Public Function rptFiadorBien(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As DataTable
        Return dl.rptFiadorBien(IdSolicitud, IdGarantia)
    End Function

    Public Function GetDictamenTecnico(ByVal IdSolicitud As Integer) As DataTable
        Return dl.GetDictamenTecnico(IdSolicitud)
    End Function

    'Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
    '    Return dl.GetUltMovPrestamo(IdPrestamo)
    'End Function

    Public Function GetIdMovAportacionPrestamo(ByVal Numero As String, ByVal IdAsociado As Integer) As Integer
        Return dl.GetIdMovAportacionPrestamo(Numero, IdAsociado)
    End Function


    Public Function rptDictamenTecnico2(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptDictamenTecnico2(IdSolicitud)
    End Function

    Public Function rptAutorizacionGerencia(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptAutorizacionGerencia(IdSolicitud)
    End Function

    Public Function rptSolicitudFondos(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptSolicitudFondos(IdSolicitudFondo)
    End Function

    Public Function rptLiquidacionPrestamo(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptLiquidacionPrestamo(IdSolicitudFondo)
    End Function

    Public Function rptResumenIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptResumenIngresosEgresos(IdSucursal, DesdeFecha, HastaFecha, IdUsuario)
    End Function

    Public Function rptResolucionConsejo(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptResolucionConsejo(IdSolicitud)
    End Function

    Public Function rptResolucionGerencia(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptResolucionGerencia(IdSolicitud)
    End Function

    Public Function rptResolucionComite(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptResolucionComite(IdSolicitud)
    End Function

    Public Function rptResolucionConsejoAdministracion(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptResolucionConsejoAdministracion(IdSolicitud)
    End Function

    Public Function coo_SaldoFondoSolicitud(ByVal IdSolicitud As Integer) As coo_SaldoFondoSolicitud
        Return dl.coo_SaldoFondoSolicitud(IdSolicitud)
    End Function

    Public Function InsertaSolicitudFondo(ByRef entSolicitudFondo As coo_SolicitudFondos _
, ByRef entRefinancia As List(Of coo_SolicitudFondosRefinancia) _
, ByRef entDeduccion As List(Of coo_SolicitudFondosDeducciones)) As String
        Return dl.InsertaSolicitudFondo(entSolicitudFondo, entRefinancia, entDeduccion)
    End Function

    Public Function InsertaDesembolso1(ByRef entPrestamo As coo_Prestamos _
, ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByRef entPlan As List(Of coo_PrestamosPlanPagos), _
ByRef IdFondo As Integer, ByRef IdMunicipio As String, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones) As String
        Return dl.InsertaDesembolso1(entPrestamo, entDesembolso, entDeposito, entPlan, IdFondo, _
        IdMunicipio, entLiquidacion, entSimultaneo, entAportacion, entCapitalizacion)
    End Function

    Public Function InsertaCambioTasa(ByRef entCambioTasa As List(Of coo_PrestamosDetalle)) As String
        Return dl.InsertaCambioTasa(entCambioTasa)
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado) As String
        Return dl.InsertaTrasladoPrestamo(entTraslado)
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado, _
    ByRef entCambioTasa As coo_PrestamosDetalle, ByRef entCambioTasamora As coo_PrestamosDetalle, _
    ByVal TipoCartera As Integer) As String
        Return dl.InsertaTrasladoPrestamo(entTraslado, entCambioTasa, entCambioTasamora, TipoCartera)
    End Function

    Public Function InsertaTrasladoPrestamo(ByRef entTraslado As coo_PrestamosTraslado, _
ByRef entCambioTasa As coo_PrestamosDetalle, ByRef entCambioTasamora As coo_PrestamosDetalle, _
ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle, _
ByRef entPlanPago As List(Of coo_PrestamosPlanPagos), ByVal IdMunicipio As String, _
ByRef entNuevoTraslado As coo_PrestamosTraslado) As String
        Return dl.InsertaTrasladoPrestamo(entTraslado, entCambioTasa, entCambioTasamora, _
        entPrestamo, entDesembolso, entPlanPago, IdMunicipio, entNuevoTraslado)
    End Function


    Public Function EliminaTrasladoPrestamo(ByVal IdPrestamo As Integer, ByVal IdMovInteres As Integer, ByVal IdMovMora As Integer, ByVal IdTraslado As Integer) As String
        Return dl.EliminaTrasladoPrestamo(IdPrestamo, IdMovInteres, IdMovMora, IdTraslado)
    End Function

    Public Function InsertaDesembolso(ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByVal IdFondo As Integer, ByRef entLiquidacion As coo_PrestamosDesembolso, _
 ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
 ByRef entCapitalizacion As coo_Aportaciones) As String
        Return dl.InsertaDesembolso(entDesembolso, entDeposito, IdFondo, entLiquidacion, entSimultaneo, entAportacion, entCapitalizacion)
    End Function

    Public Function GetSaldoCapitalPrestamo(ByVal IdPrestamo As Integer) As Decimal
        Return dl.GetSaldoCapitalPrestamo(IdPrestamo)
    End Function

    Public Function GetSaldoAsociadoFiador(ByVal Documento As String, ByVal Fecha As Date) As Decimal
        Return dl.GetSaldoAsociadoFiador(Documento, Fecha)
    End Function

    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Return dl.GetUltMovPrestamo(IdPrestamo)
    End Function

#Region "Reportes"
#Region "Reportes Generales"
    Public Function rptListadoSolicitudesEstado(ByVal IdEstado As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptListadoSolicitudesEstado(IdEstado, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoSolicitudesComparativo(ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptListadoSolicitudesComparativo(DesdeFecha, HastaFecha)
    End Function

    Public Function rptPrestamosRegistrados(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date, ByVal ExcluirAutomaticos As Boolean) As DataTable
        Return dl.rptPrestamosRegistrados(IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha, ExcluirAutomaticos)
    End Function
    Public Function rptPrestamosTipoCredito(ByVal IdTipoCredito As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptPrestamosTipoCredito(IdTipoCredito, IdLinea, IdFuente, HastaFecha)
    End Function
    Public Function rptPrestamosSaldosFacturas(ByVal IdLinea As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptPrestamosSaldosFacturas(IdLinea, HastaFecha)
    End Function
    Public Function rptPrestamosFacCobradosCancelados(ByVal IdLinea As Integer, ByVal TipoReporte As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptPrestamosFacCobradosCancelados(IdLinea, TipoReporte, DesdeFecha, HastaFecha)
    End Function
    Public Function rptPrestamosTipoGarantia(ByVal IdTipo As Integer, ByVal TipoPlazo As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As Date) As DataTable
        Return dl.rptPrestamosTipoGarantia(IdTipo, TipoPlazo, IdLinea, IdFuente, HastaFecha)
    End Function

    Public Function rptEstadoCuentaPrestamo(ByVal NumeroPrestamo As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptEstadoCuentaPrestamo(NumeroPrestamo, HastaFecha)
    End Function

    Public Function rptImprimeAcuerdo(ByVal IdSeguimiento As Integer) As DataTable
        Return dl.rptImprimeAcuerdo(IdSeguimiento)
    End Function


    Public Function rptListadoDesembolsos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date, ByVal IncluirAutomaticos As Boolean) As DataTable
        Return dl.rptListadoDesembolsos(IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha, IncluirAutomaticos)
    End Function

    Public Function rptListadoGeneralPagos(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, _
    ByVal IdFuente As Integer, ByVal IdFormaPago As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoGeneralpagos(IdSucursal, IdTecnico, IdFuente, IdFormaPago, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoResoluciones(ByVal TipoReporte As Integer, ByVal NumeroActa As String, _
    ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoResoluciones(TipoReporte, NumeroActa, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoAcuerdos(ByVal TipoFecha As Integer, ByVal DesdeFecha As DateTime, _
                    ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAcuerdos(TipoFecha, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoSeguimientos(ByVal TipoFecha As Integer, ByVal DesdeFecha As DateTime, _
                    ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoSeguimientos(TipoFecha, DesdeFecha, HastaFecha)
    End Function


    Public Function rptListadoPagosLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal IdFormaPago As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptListadoPagosLinea(IdSucursal, IdTecnico, IdLinea, IdFormaPago, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoGeneralPrestamos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, _
ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoGeneralPrestamos(IdSucursal, IdLinea, IdTecnico, IdFuente, HastaFecha, Incluir)
    End Function

    Public Function rptListadoPrestamosCancelados(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptListadoPrestamosCancelados(IdSucursal, IdLinea, IdTecnico, IdFuente, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoFiadores(ByVal NroDocumento As String, ByVal IdAsociado As Integer, _
ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoFiadores(NroDocumento, IdAsociado, HastaFecha, Incluir)
    End Function

#End Region
    
#Region "Reportes Financieros"
    Public Function rptConsolidadoGeneralCartera(ByVal IdSucursal As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptConsolidadoGeneralCartera(IdSucursal, TipoCartera, HastaFecha, Incluir)
    End Function
    Public Function rptConsolidadoCarteraFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptConsolidadoCarteraFuente(IdSucursal, IdFuente, TipoCartera, HastaFecha, incluir)
    End Function
    Public Function rptDetalleCarteraFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraFuente(IdSucursal, IdFuente, TipoCartera, HastaFecha, Incluir)
    End Function

    Public Function rptDetalleGeneralCarteraLinea(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataSet
        Return dl.rptDetalleGeneralCarteraPorLinea(IdSucursal, IdLinea, TipoCartera, HastaFecha, Incluir)
    End Function

    Public Function rptConsolidadoCarteraLinea(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptConsolidadoCarteraLinea(IdSucursal, IdLinea, TipoCartera, HastaFecha, incluir)
    End Function

    Public Function rptConsolidadoCreditosVencidos(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As Date) As DataTable
        Return dl.rptConsolidadoCreditosVencidos(IdSucursal, IdLinea, HastaFecha)
    End Function



    Public Function rptConsolidadoCarteraTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptConsolidadoCarteraTecnico(IdSucursal, IdTecnico, TipoCartera, HastaFecha, Incluir)
    End Function

    Public Function rptConsolidadoCarteraCanton(ByVal IdSucursal As Integer, ByVal TipoCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptConsolidadoCarteraCanton(IdSucursal, TipoCanton, TipoCartera, HastaFecha, incluir)
    End Function
    Public Function rptDetalleGeneralCartera(ByVal IdSucursal As Integer, ByVal IdLinea As Integer, ByVal IdFuente As Integer, ByVal IdCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleGeneralCartera(IdSucursal, IdLinea, IdFuente, IdCanton, TipoCartera, HastaFecha, incluir)
    End Function

    Public Function rptDetalleCarteraCanton(ByVal IdSucursal As Integer, ByVal IdCanton As Integer, ByVal TipoCartera As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraCanton(IdSucursal, IdCanton, TipoCartera, HastaFecha, Incluir)
    End Function

#End Region
#Region "Reportes de los técnicos"
    Public Function rptDetalleCarteraTecnicoGeneral(ByVal IdTecnico As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraTecnicoGeneral(IdTecnico, HastaFecha, Incluir)
    End Function
    Public Function rptDetalleCarteraTecnicoFuente(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdFuente As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraTecnicoFuente(IdSucursal, IdTecnico, IdFuente, HastaFecha, Incluir)
    End Function
    Public Function rptDetalleCarteraTecnicoLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraTecnicoLinea(IdSucursal, IdTecnico, IdLinea, HastaFecha, Incluir)
    End Function

    Public Function rptDetalleTecnicoClasificacion(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleTecnicoClasificacion(IdSucursal, IdTecnico, IdClasificacion, HastaFecha, Incluir)
    End Function

    Public Function rptPrestamosVencerTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal Ejercicio As Integer, ByVal Mes As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptPrestamosVencerTecnico(IdSucursal, IdTecnico, Ejercicio, Mes, Incluir)
    End Function

    Public Function rptProyeccionRecuperaciones(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer) As DataTable
        Return dl.rptProyeccionRecuperaciones(IdSucursal, Ejercicio)
    End Function

    Public Function rptPrestamosPorTecnico(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.rptPrestamosPorTecnico(IdSucursal, IdTecnico, HastaFecha, Incluir)
    End Function

    Public Function rptDetalleCarteraTecnicoCanton(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdCanton As Integer, ByVal HastaFecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.rptDetalleCarteraTecnicoCanton(IdSucursal, IdTecnico, IdCanton, HastaFecha, Incluir)
    End Function

    Public Function rptCarteraVencidaPorTécnico(ByVal IdSucursal As Integer, ByVal TipoPlazo As Integer, ByVal IdLinea As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptAntiguedadPlazoLinea(IdSucursal, TipoPlazo, IdLinea, IdClasificacion, HastaFecha, Incluir)
    End Function
    Public Function rptCuadroMora(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal HastaFecha As Date, ByVal Tipo As Integer) As DataSet
        Return dl.rptCuadroMora(IdSucursal, IdTecnico, HastaFecha, Tipo)
    End Function
#End Region
#Region "Reportes de Antiguedad"
    Public Function rptAntiguedadGeneral(ByVal IdSucursal As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptAntiguedadGeneral(IdSucursal, IdClasificacion, HastaFecha, Incluir)
    End Function
    Public Function rptAntiguedadPorFuente(ByVal IdSucursal As Integer, ByVal IdFuente As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptAntiguedadPorFuente(IdSucursal, IdFuente, IdClasificacion, HastaFecha, Incluir)
    End Function
    Public Function rptAntiguedadTecnicoLinea(ByVal IdSucursal As Integer, ByVal IdTecnico As Integer, ByVal IdLinea As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptAntiguedadTecnicoLinea(IdSucursal, IdTecnico, IdLinea, IdClasificacion, HastaFecha, Incluir)
    End Function
    Public Function rptAntiguedadPlazoLinea(ByVal IdSucursal As Integer, ByVal TipoPlazo As Integer, ByVal IdLinea As Integer, ByVal IdClasificacion As Integer, ByVal HastaFecha As Date, ByVal Incluir As Boolean) As DataTable
        Return dl.rptAntiguedadPlazoLinea(IdSucursal, TipoPlazo, IdLinea, IdClasificacion, HastaFecha, Incluir)
    End Function
#End Region
    Public Function rptProvisionIntereses(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptProvisionIntereses(IdSucursal, HastaFecha)
    End Function
#End Region

    Public Function coo_FiadoresSelectByDui(ByVal NroDocumento As String) As coo_GarantiasFiador
        Return dl.coo_FiadoresSelectByDui(NroDocumento)
    End Function

    Public Function coo_PrestamosSelectByNumero(ByVal NumeroPrestamo As String) As coo_Prestamos
        Return dl.coo_PrestamosSelectByNumero(NumeroPrestamo)
    End Function

    Public Function coo_SaldosPrestamo(ByVal IdPrestamo As Integer, ByVal Fecha As Date) As coo_SaldoPrestamo
        Return dl.coo_SaldosPrestamo(IdPrestamo, Fecha)
    End Function

    Public Function coo_PrestamoParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.coo_PrestamoParaConsulta(Nombre, Apellido, Fecha, Incluir)
    End Function

    Public Function ValorChequesDesembolso(ByVal IdSolicitud As Integer) As Decimal
        Return dl.ValorChequesDesembolso(IdSolicitud)
    End Function

    Public Function GetChequesCaja(ByVal idCorte As Integer) As DataTable
        Return dl.GetChequesCaja(idCorte)
    End Function
#Region "Otros Procesos"
    Public Function ObtenerIdTipoOperacion(ByVal IdTipoOperacion As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdTipoOperacion(IdTipoOperacion, TipoAvance)
    End Function

    Public Function GetArqueoNumerario(ByVal IdOperacion As Integer) As DataTable
        Return dl.GetArqueoNumerario(IdOperacion)
    End Function

    Public Function GetDenominacionesNumerario() As DataTable
        Return dl.GetDenominacionesNumerario()
    End Function

    Public Function GetChequesNumerario(ByVal IdOperacion As Integer) As DataTable
        Return dl.GetChequesNumerario(IdOperacion)
    End Function

    Public Function rptMovimientoFechaNumerario(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptMovimientoFechaNumerario(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function InsertaOperacionNumerario(ByRef entOperacion As coo_OperacionesNumerario _
, ByRef entArqueo As List(Of coo_OperacionesNumerarioArqueo) _
, ByRef entCheques As List(Of coo_OperacionesNumerarioCheques)) As String
        Return dl.InsertaOperacionNumerario(entOperacion, entArqueo, entCheques)
    End Function



    Public Function UpdateOperacionNumerario(ByRef entOperacion As coo_OperacionesNumerario _
    , ByRef entArqueo As List(Of coo_OperacionesNumerarioArqueo) _
    , ByRef entCheque As List(Of coo_OperacionesNumerarioCheques)) As String
        Return dl.UpdateOperacionNumerario(entOperacion, entArqueo, entCheque)
    End Function


    Public Function rptOperacionNumerario(ByVal IdOperacion As Integer) As DataTable
        Return dl.rptOperacionNumerario(IdOperacion)
    End Function


    Public Function ExisteIdOperacion(ByVal IdOperacion As Integer) As Integer
        Return dl.ExisteIdOperacion(IdOperacion)
    End Function

    Public Function ExisteNumOperacion(ByVal Numero As String, ByVal IdTipoOperacion As Integer) As Integer
        Return dl.ExisteNumOperacion(Numero, IdTipoOperacion)
    End Function

    Public Function ObtenerIdOperacion(ByVal IdOperacion As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdOperacion(IdOperacion, TipoAvance)
    End Function
#End Region
    Public Function rptReciboPagoPrestamo(ByVal IdPrestamo As Integer, ByVal IdMov As Integer) As DataTable
        Return dl.rptReciboPagoIdMov(IdPrestamo, IdMov)
    End Function
    Public Function rptCorteNumerarioIngresos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteNumerarioIngresos(IdSucursal, HastaFecha)
    End Function

    Public Function rptCorteNumerario(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteNumerario(IdSucursal, HastaFecha)
    End Function

    Public Function rptCorteNumerarioEgresos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteNumerarioEgresos(IdSucursal, HastaFecha)
    End Function

    Public Function rptCorteNumerarioArqueo(ByVal IdSucursal As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptCorteNumerarioArqueo(IdSucursal, Fecha)
    End Function

    Public Function ActualizarSeguimientoSolicitud(ByVal IdSolicitud As Integer, ByVal Seguimiento As Integer) As String
        Return dl.ActualizarSeguimientoSolicitud(IdSolicitud, Seguimiento)
    End Function

    Public Function rptPagareDeudor(ByVal Nombre As String, ByVal Edad As String, _
                                    ByVal Profesion As String, ByVal Municipio As String, _
                                    ByVal Depto As String, ByVal NumDocumento As String, _
                                    ByVal MontoLetras As String, ByVal NumCuotas As String, _
                                    ByVal ValorCuota As String, ByVal Plazo As String, _
                                    ByVal FechaVENCE As String, ByVal TasaInteres As String, _
                                    ByVal FechaActual As String, ByVal TasaMora As String) As DataTable
        
        Return dl.rptPagareDeudor(Nombre, Edad, Profesion, Municipio, _
                                 Depto, NumDocumento, MontoLetras, NumCuotas, _
                                 ValorCuota, Plazo, FechaVENCE, TasaInteres, _
                                 FechaActual, TasaMora)
    End Function

    Public Function ObtenerParametrosEstructuras() As DataTable
        Return dl.ObtenerParametrosEstructuras()
    End Function

    Public Function ActualizaPrestamo(ByVal IdPrestamo As Integer, ByVal IdLinea As Integer, ByVal IdTecnico As Integer, _
                                 ByVal IdFuente As Integer, ByVal IdCanton As Integer, ByVal ModificadoPor As String, _
                                 ByVal CuotaGestion As Decimal, ByVal FechaPrimer As DateTime, ByVal IdFormaPago As Integer, ByVal IdTipoAplicacion As Integer, ByVal ValorCuota As Decimal) As String
        Return dl.ActualizarPrestamo(IdPrestamo, IdLinea, IdTecnico, IdFuente, IdCanton, ModificadoPor, CuotaGestion, FechaPrimer, IdFormaPago, IdTipoAplicacion, ValorCuota)
    End Function

    Public Function getPrestamosPlanPago(ByVal IdPrestamo As System.Int32) As DataTable
        Return dl.GetPrestamosPlanPago(IdPrestamo)
    End Function
    Public Function getPrestamosPlanPagoCapital(ByVal IdPrestamo As System.Int32, ByVal fecha As DateTime) As Decimal
        Return dl.getPrestamosPlanPagoCapital(IdPrestamo, fecha)
    End Function

    Public Function GetChequesCorteCaja(ByVal IdCorte As Integer) As DataTable
        Return dl.GetChequesCorteCaja(IdCorte)
    End Function

    Public Function ExisteNumPrestamo(ByVal Numero As String) As Integer
        Return dl.ExisteNumPrestamo(Numero)
    End Function
    Public Function AnulaPresEfectivo(ByVal IdSol As Integer, ByVal IdPrestamo As Integer) As String
        Return dl.AnulaPresEfectivo(IdSol, IdPrestamo)
    End Function
    Public Function AprobarSolicitudRetiro(ByVal IdSol As Integer, ByVal Usuario As String) As String
        Return dl.AprobarSolicitudRetiro(IdSol, Usuario)
    End Function
    Public Function ObtenerIdSolFondosEfectivo(ByVal IdSolicitud As Integer) As Integer
        Return dl.ObtenerIdSolFondosEfectivo(IdSolicitud)
    End Function
    Public Function PartidaTelefonia(ByVal Fecha As DateTime, ByVal CreadoPor As String) As String
        Return dl.PartidaTelefonia(Fecha, CreadoPor)
    End Function
    Public Function PartidaCargaPlanilla(ByVal IdPlanilla As Integer, ByVal Fecha As DateTime, ByVal CreadoPor As String) As String
        Return dl.PartidaCargaPlanilla(IdPlanilla, Fecha, CreadoPor)
    End Function
    Public Function adm_GenerarPartidasDiarias(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As String
        Return dl.adm_GenerarPartidasDiarias(IdSucursal, Desde, IdUsuario, GeneraReporte)
    End Function

    Public Function InsertaDescuentos(ByRef entAportaciones As List(Of coo_Aportaciones) _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle) _
, ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal creado As String) As String
        Return dl.InsertaDescuentos(entAportaciones, entAhorros, entPrestamos, IdSucursal, Fecha, creado)
    End Function
    Public Function InsertaDescuentosTelefono(ByRef entTelefono As List(Of coo_DescuentoTelefoniaPendiente)) As String
        Return dl.InsertaDescuentosTelefonos(entTelefono)
    End Function
    Public Function InsertaAbonosTelefono(ByRef entTelefono As List(Of coo_abonoTelefonia)) As String
        Return dl.InsertaAbonosTelefono(entTelefono)
    End Function
    Public Function AplicaCrucesCuentas(ByRef IdSolicitud As Integer, ByRef entAportaciones As List(Of coo_Aportaciones) _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle)) As String
        Return dl.AplicaCrucesCuentas(IdSolicitud, entAportaciones, entAhorros, entPrestamos)
    End Function
    Public Function AplicaReintegroCuentas(ByRef IdSolicitud As Integer, ByRef entAportaciones As coo_Aportaciones _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle)) As String
        Return dl.AplicaReintegroCuentas(IdSolicitud, entAportaciones, entAhorros, entPrestamos)
    End Function
    Public Function AplicaRetiroSocios(ByRef entAportaciones As List(Of coo_Aportaciones) _
, ByRef entAhorros As List(Of coo_CuentasAhorroMov), ByRef entPrestamos As List(Of coo_PrestamosDetalle) _
, ByVal Liquido As Decimal, ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal IdCuentaCobrar As String, ByVal IdSolicitud As Integer) As String
        Return dl.AplicaRetiroSocios(entAportaciones, entAhorros, entPrestamos, Liquido, IdAsociado, Fecha, IdCuentaCobrar, IdSolicitud)
    End Function
    Public Function AplicaRetiroSocios2(ByRef entPrestamos As List(Of coo_PrestamosDetalle), ByVal IdCuentaCobrar As String, ByVal IdSolicitud As Integer) As String
        Return dl.AplicaRetiroSocios2(entPrestamos, IdCuentaCobrar, IdSolicitud)
    End Function

    Public Function rptListadoLiquidacionCaja(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoLiquidacionCaja(IdSucursal, IdCentro, DesdeFecha, HastaFecha)
    End Function
    Public Function rptListadoAplicacionPlanilla(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptListadoAplicacionPlanilla(IdSucursal, IdCentro, DesdeFecha, HastaFecha, IdAsociado)
    End Function
    Public Function rptListadoAplicacionPlanillaConsolidado(ByVal IdPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAplicacionPlanillaConsolidado(IdPlanilla, DesdeFecha, HastaFecha)
    End Function
    Public Function rptListadoSaldosSocios(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime _
    , ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer, ByVal IdLinea As Integer, ByVal IncluyeAporte As Boolean, ByVal IncluyeAhorro As Boolean) As DataTable
        Return dl.rptListadoSaldosSocios(IdSucursal, DesdeFecha, HastaFecha, IdAsociado, IdLinea, IncluyeAporte, IncluyeAhorro)
    End Function
    Public Function FechaPlanilla(ByVal Fecha As DateTime) As DateTime
        Return dl.FechaPlanilla(Fecha)
    End Function
    Public Function ValidaReversionPlanilla(ByVal FechaContable As Date, ByVal Fecha As Date, ByVal Idtipo As Integer) As Integer
        Return dl.ValidaReversionPlanilla(FechaContable, Fecha, Idtipo)
    End Function
    Public Function ValidaDescuentoTelefonico(ByVal Fecha As Date) As Integer
        Return dl.ValidaDescuentoTelefonico(Fecha)
    End Function
    Public Function ObtieneFechaCancelacion(ByVal IdPrestamo As Integer) As Date
        Return dl.ObtieneFechaCancelacion(IdPrestamo)
    End Function
End Class
