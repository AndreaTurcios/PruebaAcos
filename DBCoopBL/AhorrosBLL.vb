Imports DBCoopDL
Imports DBCoopEL.TableEntities
Public Class AhorrosBLL
    Dim dl As New AhorrosDLL
    Public Function ObtenerIdCuentaByNumero(ByVal Numero As String) As Integer
        Return dl.ObtenerIdCuentaByNumero(Numero)
    End Function
    Public Function ObtenerNumeroCuentaByIdCuenta(ByVal IdCuenta As Integer) As String
        Return dl.ObtenerNumeroCuentaByIdCuenta(IdCuenta)
    End Function
    Public Function ObtenerIdTipoCuentaAhorro(ByVal IdTipo As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdTipoCuentaAhorro(IdTipo, TipoAvance)
    End Function
    Public Function InsertaTipoCuentaAhorro(ByRef entTipoCuenta As coo_TiposCuentaAhorro) As String
        Return dl.InsertaTipoCuentaAhorro(entTipoCuenta)
    End Function

    Public Function CambioTasaAhorro(ByVal IdCuenta As Integer, ByVal Tasa As Decimal, ByVal FechaContable As Date, ByVal CreadoPor As String) As String
        Return dl.CambioTasaAhorro(IdCuenta, Tasa, FechaContable, CreadoPor)
    End Function

    Public Function UpdateTipoCuentaAhorro(ByRef entTipoCuenta As coo_TiposCuentaAhorro) As String
        Return dl.UpdateTipoCuentaAhorro(entTipoCuenta)
    End Function
    Public Function LiberarFondoDeposito(ByVal IdCuenta As Integer, ByVal IdMov As Integer) As String
        Return dl.LiberarFondoDeposito(IdCuenta, IdMov)
    End Function
    Public Function ObtenerIdCuenta(ByVal IdCuenta As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdCuenta(IdCuenta, TipoAvance)
    End Function
    Public Function GetBeneficiariosCuenta(ByVal IdCuenta As Integer) As DataTable
        Return dl.GetBeneficiariosCuenta(IdCuenta)
    End Function
    Public Function GetDepositosPignorados(ByVal IdSucursal As Integer) As DataTable
        Return dl.GetDepositosPignorados(IdSucursal)
    End Function
    Public Function GetAutorizadosCuenta(ByVal IdCuenta As Integer) As DataTable
        Return dl.GetAutorizadosCuenta(IdCuenta)
    End Function
    Public Function GetSaldosAhorros(ByVal IdSolicitud As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal Nuevo As Boolean, ByVal Modulo As String) As DataTable
        Return dl.GetSaldosAhorros(IdSolicitud, IdAsociado, HastaFecha, Nuevo, Modulo)
    End Function
    'Public Function ExisteIdCuentaAhorro(ByVal IdCuenta As Integer) As Integer
    '    Return dl.ExisteIdCuentaAhorro(IdCuenta)
    'End Function
    Public Function ExisteNumCuentaAhorro(ByVal Numero As String) As Integer
        Return dl.ExisteNumCuentaAhorro(Numero)
    End Function

    Public Function GetIdMovAhorro(ByVal Numero As String, ByVal IdCuenta As Integer) As Integer
        Return dl.GetIdMovAhorro(Numero, IdCuenta)
    End Function


    Public Function ExisteCapitalizacionAhorro(ByVal Fecha As String, ByVal Periodo As String) As Integer
        Return dl.ExisteCapitalizacionAhorro(Fecha, Periodo)
    End Function
    Public Function ExisteCapitalizacionPlazo(ByVal Fecha As Date, ByVal IdSucursal As Integer) As Integer
        Return dl.ExisteCapitalizacionPlazo(Fecha, IdSucursal)
    End Function
    Public Function ValidaCapitalizacion(ByVal Ejercicio As Integer, ByVal Mes As Integer) As Integer
        Return dl.ValidaCapitalizacion(Ejercicio, Mes)
    End Function
    Public Function ValidaDevolucionAhorro(ByVal Ejercicio As Integer) As Integer
        Return dl.ValidaDevolucionAhorro(Ejercicio)
    End Function
    Public Function InsertaCuentaAhorro(ByRef entCuentaAhorro As coo_CuentasAhorro _
    , ByRef entBeneficiario As List(Of coo_CuentasAhorroBeneficiarios) _
    , ByRef entAutorizado As List(Of coo_CuentasAhorroAutorizado)) As String
        Return dl.InsertaCuentaAhorro(entCuentaAhorro, entBeneficiario, entAutorizado)
    End Function
    Public Function InsertaPignoracion(ByRef entPignoracion As coo_Pignoraciones) As String
        Return dl.InsertaPignoracion(entPignoracion)
    End Function
    Public Function UpdateCuentaAhorro(ByRef entCuentaAhorro As coo_CuentasAhorro, ByRef entBeneficiario As List(Of coo_CuentasAhorroBeneficiarios), ByRef entAutorizado As List(Of coo_CuentasAhorroAutorizado)) As String
        Return dl.UpdateCuentaAhorro(entCuentaAhorro, entBeneficiario, entAutorizado)
    End Function
    Public Function coo_UltCierreAhorroSelectBy() As coo_CierresAhorro
        Return dl.coo_UltCierreAhorroSelectBy()
    End Function
    Public Function coo_UltMovAhorroSelectBy(ByVal IdCuenta As Integer) As coo_UltMovAhorro
        Return dl.coo_UltMovAhorroSelectBy(IdCuenta)
    End Function
    Public Function coo_spGarantiasCuentaPignoradaSelectByPK(ByVal IdCuenta As System.Int32) As coo_GarantiasCuentaPignorada
        Return dl.coo_spGarantiasCuentaPignoradaSelectByPK(IdCuenta)
    End Function
    Public Function rptContratoAhorro(ByVal IdCuenta As Integer) As coo_ContratoAhorro
        Return dl.rptContratoAhorro(IdCuenta)
    End Function
    Public Function rptContratoAhorro2(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptContratoAhorro2(IdAsociado)
    End Function
    Public Function coo_PignoracionesSelectByCuenta(ByVal IdCuenta As System.Int32) As coo_Pignoraciones
        Return dl.coo_PignoracionesSelectByCuenta(IdCuenta)
    End Function
    Public Function rptDeclaracionJurada(ByVal IdCuenta As Integer) As coo_DeclaracionJurada
        Return dl.rptDeclaracionJurada(IdCuenta)
    End Function
    Public Function rptRegistroFirmas(ByVal IdCuenta As Integer) As DataTable
        Return dl.rptRegistroFirmasAhorro(IdCuenta)
    End Function
    Public Function rptCertificadoAhorro(ByVal IdCuenta As Integer) As DataTable
        Return dl.rptCertificadoAhorro(IdCuenta)
    End Function
    Public Function coo_spCuentasAhorroMovSelectByPK(ByVal NumeroDoc As String) As coo_CuentasAhorroMov
        Return dl.coo_spCuentasAhorroMovSelectByPK(NumeroDoc)
    End Function
    Public Function CapitalizacionAhorro(ByVal DesdeFecha As Date, ByVal HastaFecha As Date, ByVal ejercicio As Integer, ByVal num_mes As Integer, ByVal CreadoPor As String) As String
        Return dl.CapitalizacionAhorro(DesdeFecha, HastaFecha, ejercicio, num_mes, CreadoPor)
    End Function
    Public Function DevolucionAhorro(ByVal Fecha As Date, ByVal TipoCuenta As Integer, ByVal IdSucursal As Integer, ByVal Papeleria As Decimal, ByVal DescuentoDesde As Decimal, ByVal CreadoPor As String) As String
        Return dl.DevolucionAhorro(Fecha, TipoCuenta, IdSucursal, Papeleria, DescuentoDesde, CreadoPor)
    End Function
    Public Function CapitalizacionPlazo(ByVal Fecha As DateTime, ByVal IdSucursal As Integer, ByVal CreadoPor As String) As String
        Return dl.CapitalizacionPlazo(Fecha, IdSucursal, CreadoPor)
    End Function
    Public Function RevierteCapitalizacion(ByVal ejercicio As Integer, ByVal num_mes As Integer) As Integer
        Return dl.RevierteCapitalizacion(ejercicio, num_mes)
    End Function
    Public Function RevierteDevolucion(ByVal ejercicio As Integer) As Integer
        Return dl.RevierteDevolucion(ejercicio)
    End Function
    Public Function rptMovimientoCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptMovimientoCuentaAhorro(IdCuenta, DesdeFecha, HastaFecha)
    End Function
    Public Function rptPignoracionCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptPignoracionCuentaAhorro(IdCuenta, DesdeFecha, HastaFecha)
    End Function
    Public Function rptListadoCuentaAhorro(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, _
    ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoCuentaAhorro(IdSucursal, HastaFecha, IdEstado, IdTipo, IdCentro, Incluir)
    End Function
    Public Function rptListadoCuentaInactivas(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, _
 ByVal IdTipo As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoCuentasInactivas(IdSucursal, HastaFecha, IdTipo, Incluir)
    End Function

    Public Function rptListadoCuentaAhorroAsociado(ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptListadoCuentaAhorroAsociado(HastaFecha, IdAsociado)
    End Function
    Public Function rptListadoDepositosPlazo(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, _
    ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoDepositosPlazo(IdSucursal, DesdeFecha, HastaFecha, IdEstado, IdTipo, IdCentro, Incluir)
    End Function
    Public Function rptAcumuladoMovimientos(ByVal IdSucursal As Integer, ByVal IdTipo As Integer, _
    ByVal IdCentro As Integer, ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptAcumuladoMovimientos(IdSucursal, IdTipo, IdCentro, DesdeFecha, HastaFecha)
    End Function


    Public Function rptDetalleMovimientos(ByVal IdSucursal As Integer, ByVal IdTipo As Integer, ByVal Idcentro As Integer, _
ByVal DesdeFecha As Date, ByVal HastaFecha As Date) As DataTable
        Return dl.rptDetalleMovimientos(IdSucursal, IdTipo, Idcentro, DesdeFecha, HastaFecha)
    End Function
    Public Function rptDepositoAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return dl.rptDepositoAhorro(NumeroComp, IdCuenta)
    End Function
    Public Function rptRetiroAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return dl.rptRetiroAhorro(NumeroComp, IdCuenta)
    End Function
    Public Function rptInteresCuentaCapitalizado(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, _
    ByVal HastaFecha As DateTime, ByVal IdTipo As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptInteresCuentaCapitalizado(IdSucursal, DesdeFecha, HastaFecha, IdTipo, IdCentro, Incluir)
    End Function
    Public Function rptListadoDepositosVencer(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, _
    ByVal HastaFecha As DateTime, ByVal IdTipo As Integer, ByVal IdCentro As Integer) As DataTable
        Return dl.rptListadoDepositosVencer(IdSucursal, DesdeFecha, HastaFecha, IdTipo, IdCentro)
    End Function
    Public Function rptProvisionInteres(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer, _
    ByVal Mes As Integer, ByVal IdCentro As Integer, ByVal IncluirInt As Boolean, ByVal IncluirDep As Boolean) As DataTable
        Return dl.rptProvisionInteres(IdSucursal, Ejercicio, Mes, IdCentro, IncluirInt, IncluirDep)
    End Function
    Public Function PartidaProvisionInteres(ByVal IdSucursal As Integer, ByVal Ejercicio As Integer, _
ByVal Mes As Integer, ByVal IdCentro As Integer, ByVal IncluirInt As Boolean, ByVal IncluirDep As Boolean, ByVal CreadoPor As String) As Integer
        Return dl.PartidaProvisionInteres(IdSucursal, Ejercicio, Mes, IdCentro, IncluirInt, IncluirDep, CreadoPor)
    End Function
    Public Function rptListadoCapitalizacionInteres(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, _
ByVal Mes As Integer, ByVal IdCentro As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoCapitalizacionInteres(IdSucursal, ejercicio, Mes, IdCentro, Incluir)
    End Function
    Public Function rptListadoCuentaMesTipo(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer, _
ByVal IdCentro As Integer, ByVal IdEstado As Integer, ByVal IdTipo As Integer, ByVal Incluir As Boolean) As DataTable
        Return dl.rptListadoCuentasMesTipo(IdSucursal, ejercicio, Mes, IdCentro, IdEstado, IdTipo, Incluir)
    End Function
    Public Function rptProvisionIsr(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.rptProvisionIsr(IdSucursal, ejercicio, Mes)
    End Function
    Public Function rptIsrAplicadoInteres(ByVal IdSucursal As Integer, ByVal ejercicio As Integer, ByVal Mes As Integer, ByVal IdCentro As Integer) As DataTable
        Return dl.rptIsrAplicadoInteres(IdSucursal, ejercicio, Mes, IdCentro)
    End Function
    Public Function ObtenerPignoraciones(ByVal IdSucursal As Integer) As DataTable
        Return dl.ObtenerPignoraciones(IdSucursal)
    End Function
    Public Function RevertirPignoracion(ByVal IdPignoracion As Integer, ByVal Usuario As String) As Integer
        Return dl.RevertirPignoracion(IdPignoracion, Usuario)
    End Function
    Public Function GetUltMovAhorro(ByVal IdCuenta As Integer) As Integer
        Return dl.GetUltMovAhorro(IdCuenta)
    End Function
    Public Function GetCuentaAhorroPrestamo(ByVal IdAsociado As Integer) As Integer
        Return dl.GetCuentaAhorroPrestamo(IdAsociado)
    End Function

    Public Function GetCuentaAhorroCorriente(ByVal IdAsociado As Integer) As Integer
        Return dl.GetCuentaAhorroCorriente(IdAsociado)
    End Function
    Public Function GetCuentaAhorroCorrientePla(ByVal IdAsociado As Integer) As Integer
        Return dl.GetCuentaAhorroCorrientePla(IdAsociado)
    End Function

    Public Function GetSaldoAhorro(ByVal IdCuenta As Integer) As Decimal
        Return dl.GetSaldoAhorro(IdCuenta)
    End Function

    Public Function GetUltLineaAhorro(ByVal IdCuenta As Integer) As Integer
        Return dl.GetUltLineaAhorro(IdCuenta)
    End Function

    Public Function rptBoletaDevolucionAhorro(ByVal IdSucursal As Integer, ByVal IdTipoCuenta As Integer, ByVal IdCentro As Integer, ByVal Ejercicio As Integer) As DataTable
        Return dl.rptBoletaDevolucionAhorro(IdSucursal, IdTipoCuenta, IdCentro, Ejercicio)
    End Function

    Public Function coo_getCuentaAhorroSimultaneo(ByVal IdAsociado As Integer) As DataTable
        Return dl.coo_GetCtaAhorroSimultaneo(IdAsociado)
    End Function

End Class
