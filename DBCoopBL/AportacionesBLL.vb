Imports DBCoopDL
Imports DBCoopEL.TableEntities
Public Class AportacionesBLL
    Dim dl As New AportacionesDLL
    
    Public Function rptSolicitudAdmision(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptSolicitudAdmision(IdAsociado)
    End Function
    Public Function rptAsociadosBeneficiarios(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptAsociadosBeneficiarios(IdAsociado)
    End Function

    Public Function rptFichaAsociado(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptFichaAsociado(IdAsociado)
    End Function
    Public Function rptDatosDeclaracionJuradaAsociado(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptDatosDeclaracionJuradaAsociado(IdAsociado)
    End Function
    Public Function rptLiquidacionAportacion(ByVal NumeroDoc As String, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptLiquidacionAportacion(NumeroDoc, IdAsociado)
    End Function
    Public Function RevierteDividendos(ByVal ejercicio As Integer) As Integer
        Return dl.RevierteDividendos(ejercicio)
    End Function
    Public Function rptBoletasDividendos(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal Periodo As Integer, ByVal IdAsociado As Integer, ByVal FechaAsamblea As Date) As DataTable
        Return dl.rptBoletasDividendos(IdSucursal, IdCentro, Periodo, IdAsociado, FechaAsamblea)
    End Function
    Public Function RecalculaSaldoAportacion(ByVal IdAsociado As Integer) As Integer
        Return dl.RecalculaSaldoAportacion(IdAsociado)
    End Function

    Public Function rptSolicitudRetiro(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptSolicitudRetiro(IdAsociado, Fecha)
    End Function
    Public Function rptEstadoCuentaAportacion(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptEstadoCuentaAportacion(IdAsociado, Fecha)
    End Function
    Public Function rptEstadoCuentaGeneral(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal SoloSocios As Boolean, ByVal Enviar As Boolean) As DataTable
        Return dl.rptEstadoCuentaGeneral(IdAsociado, Fecha, SoloSocios, Enviar)
    End Function
    Public Function rptPrestamosPagoDesgloze(ByVal Referencia As String, ByVal IdAsociado As Integer, ByVal Correo As Boolean) As DataTable
        Return dl.rptPrestamosPagoDesgloze(Referencia, IdAsociado, Correo)
    End Function
    Public Function rptProgramacionSocio(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptProgramacionSocio(IdAsociado, Fecha)
    End Function
    Public Function rptCambioDescuentosSocios(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptCambioDescuentosSocios(IdAsociado, Fecha)
    End Function
    Public Function rptEstadoCuentaAyuda(ByVal IdAsociado As Integer, ByVal Desde As DateTime, ByVal Hasta As DateTime) As DataTable
        Return dl.rptEstadoCuentaAyuda(IdAsociado, Desde, Hasta)
    End Function

    Public Function rptSaldosAsociados(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal HastaFecha As DateTime, ByVal TipoReporte As Integer) As DataTable
        Return dl.rptSaldosAsociados(IdSucursal, IdCentro, HastaFecha, TipoReporte)
    End Function
    Public Function rptPorcenAhorroSocio(ByVal IdCentro As Integer) As DataTable
        Return dl.rptPorcenAhorroSocio(IdCentro)
    End Function
    Public Function rptSaldosAsociados(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptSaldosAsociados(IdSucursal, IdCentro, IdAsociado, HastaFecha)
    End Function
    Public Function rptRepartoDividendo(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime _
    , ByVal Utilidad As Decimal, ByVal Porcentaje As Decimal, ByVal AyudaFuneraria As Decimal _
    , ByVal Incluir As Boolean, ByRef entDivLineas As List(Of coo_DividendosLineas), ByVal Periodo As Integer _
    , ByVal Todas As Boolean, ByVal DescPapeleria As Decimal, ByVal PapeleriaDesde As Decimal) As DataTable
        Return dl.rptRepartoDividendo(IdSucursal, HastaFecha, Utilidad, Porcentaje, AyudaFuneraria, Incluir _
    , entDivLineas, Periodo, Todas, DescPapeleria, PapeleriaDesde)
    End Function
    Public Function rptHistorialDividendo(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptHistorialDividendo(IdSucursal, HastaFecha)
    End Function

    Public Function rptArchivoF915(ByVal Año1 As Integer, ByVal Año2 As Integer) As DataTable
        Return dl.rptArchivoF915(Año1, Año2)
    End Function

    Public Function rptMovimientoFechaAportacion(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal TipoReporte As Integer, ByVal IdForma As Integer) As DataTable
        Return dl.rptMovimientoFechaAportacion(IdSucursal, IdCentro, DesdeFecha, HastaFecha, TipoReporte, IdForma)
    End Function
    Public Function rptAportacionesPorPagarRetiroTotal(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptAportacionesPorPagarRetiroTotal(IdSucursal, IdCentro, DesdeFecha, HastaFecha)
    End Function
    Public Function rptMovimientoFechaAyuda(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptMovimientoFechaAyuda(IdSucursal, IdCentro, DesdeFecha, HastaFecha)
    End Function

    Public Function rptAportacionesFechaSexo(ByVal IdSucursal As Integer, ByVal IdCentro As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptAportacionesFechaSexo(IdSucursal, IdCentro, DesdeFecha, HastaFecha)
    End Function

    Public Function coo_spAportacionesSelectByPK(ByVal NumeroDoc As String) As coo_Aportaciones
        Return dl.coo_spAportacionesSelectByPK(NumeroDoc)
    End Function

    Public Function ObtenerIdAsociado(ByVal IdAsociado As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdAsociado(IdAsociado, TipoAvance)
    End Function
    Public Function GetBeneficiarios(ByVal IdAsociado As Integer) As DataTable
        Return dl.GetBeneficiarios(IdAsociado)
    End Function
    Public Function InsertaAsociado(ByRef entAsociado As coo_Asociados, ByRef entBeneficiario As List(Of coo_AsociadosBeneficiarios), ByRef entDescuentos As List(Of coo_AsociadosDescuentos)) As String
        Return dl.InsertaAsociado(entAsociado, entBeneficiario, entDescuentos)
    End Function
    Public Function InsertaAyudaFuneraria(ByRef entAyuda As coo_AyudaFuneraria) As String
        Return dl.InsertaAyudaFuneraria(entAyuda)
    End Function
    Public Function ActualizaFuneraria(ByRef entAyuda As coo_AyudaFuneraria) As String
        Return dl.ActualizaFuneraria(entAyuda)
    End Function
    Public Function InsertaLiquidacionAportacion(ByRef entLiquidacion As coo_LiquidacionAportaciones, ByVal IdAsociado As Integer, ByVal FechaLiquidacion As DateTime) As String
        Return dl.InsertaLiquidacionAportacion(entLiquidacion, IdAsociado, FechaLiquidacion)
    End Function

    Public Function UpdateAsociado(ByRef entAsociado As coo_Asociados, ByRef entBeneficiario As List(Of coo_AsociadosBeneficiarios), ByRef entDescuentos As List(Of coo_AsociadosDescuentos)) As String
        Return dl.UpdateAsociado(entAsociado, entBeneficiario, entDescuentos)
    End Function

    Public Function GetSaldoAporta(ByVal IdAsociado As Integer) As Decimal
        Return dl.GetSaldoAporta(IdAsociado)
    End Function
    Public Function GetSaldoFune(ByVal IdAsociado As Integer) As Decimal
        Return dl.GetSaldoFune(IdAsociado)
    End Function

    Public Function GetUltLineaAporta(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltLineaAporta(IdAsociado)
    End Function

    Public Function GetUltFechaAporta(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Return dl.GetUltFechaAporta(IdAsociado)
    End Function
    Public Function GetUltFechaFune(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Return dl.GetUltFechaFune(IdAsociado)
    End Function

    Public Function GetUltMovAporta(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltMovAporta(IdAsociado)
    End Function
    Public Function GetUltMovFune(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltMovFune(IdAsociado)
    End Function

    Public Function GetIdMovAportacion(ByVal Numero As String, ByVal IdAsociado As Integer) As Integer
        Return dl.GetIdMovAportacion(Numero, IdAsociado)
    End Function

    Public Function SiExisteRepDiv(ByVal Periodo As Integer) As Integer
        Return dl.SiExisteRepDiv(Periodo)
    End Function

    Public Function rptListadoAspirantes(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAspirantes(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoGeneralAsociados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoGeneralAsociados(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoAsociadosActivos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime _
    , ByVal HastaFecha As DateTime, ByVal SinEnvios As Boolean, ByVal SinDividendo As Boolean, ByVal SinFunerarias As Boolean) As DataTable
        Return dl.rptListadoAsociadosActivos(IdSucursal, DesdeFecha, HastaFecha, SinEnvios, SinDividendo, SinFunerarias)
    End Function
    Public Function rptListadoAsociadosSinActividad(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAsociadosSinActividad(IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha)
    End Function
    Public Function rptListadoAsociadosDescMenorEnviado(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal SoloMenor As Boolean, ByVal Detalle As Boolean) As DataTable
        Return dl.rptListadoAsociadosDescMenorEnviado(IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha, SoloMenor, Detalle)
    End Function
    Public Function rptListadoAsociadosSobregirados(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal SoloSobregirados As Boolean) As DataTable
        Return dl.rptListadoAsociadosSobregirados(IdSucursal, HastaFecha, SoloSobregirados)
    End Function
    Public Function rptListadoReintegros(ByVal IdSucursal As Integer, ByVal TipoPlanilla As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal SoloPendiente As Boolean) As DataTable
        Return dl.rptListadoReintegros(IdSucursal, TipoPlanilla, DesdeFecha, HastaFecha, SoloPendiente)
    End Function
    Public Function rptListadoAsociadosSinAhorrosPrestamos(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAsociadosSinAhorrosPrestamos(IdSucursal, HastaFecha)
    End Function

    Public Function rptListadoIngresosAsociados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoIngresosAsociados(IdSucursal, DesdeFecha, HastaFecha)
    End Function
    Public Function rptListadoAyudaFuneraria(ByVal IdAsociado As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAyudaFuneraria(IdAsociado, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoIngresosAfiliaciones(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoIngresosAfiliaciones(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoDescuentosAportaciones(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoDescuentosAportaciones(IdSucursal, HastaFecha)
    End Function


    Public Function rptListadoAsociadosInactivos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptListadoAsociadosInactivos(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function rptListadoAsociadosRetirados(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal Estado As Integer) As DataTable
        Return dl.rptListadoAsociadosRetirados(IdSucursal, DesdeFecha, HastaFecha, Estado)
    End Function

    Public Function ExisteNumAsociado(ByVal Numero As String) As Integer
        Return dl.ExisteNumAsociado(Numero)
    End Function

    Public Function InsertaDividendos(ByRef entDiv As List(Of coo_Dividendos)) As String
        Return dl.InsertaDividendos(entDiv)
    End Function
    Public Function ObtenerParametrosGenerales() As DataTable
        Return dl.ObtenerParametrosGenerales()
    End Function

End Class
