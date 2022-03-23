Imports DBCoopEL.TableEntities
Imports DBCoopDL
Public Class CajaBusiness
    Dim dl As New CajaData()

    Public Function ObtenerImpresorDefault(ByVal IdUsuario As String) As String
        Return dl.ObtenerImpresorDefault(IdUsuario)
    End Function
    Public Function VerificaUsuarioCajeroVerCorte(ByVal IdUsuario As String) As Boolean
        Return dl.VerificaUsuarioCajeroVerCorte(IdUsuario)
    End Function
    Public Function VerificaUsuarioCajeroVerCorte(ByVal IdUsuario As String, ByVal Contrasenia As String) As Boolean
        Return dl.VerificaUsuarioCajeroVerCorte(IdUsuario, Contrasenia)
    End Function
    Public Function rptIngresoAportacion(ByVal NumeroComp As String, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptIngresoAportacion(NumeroComp, IdAsociado)
    End Function
    Public Function rptIngresoAyudaFuneraria(ByVal NumeroComp As String, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptIngresoAyudaFuneraria(NumeroComp, IdAsociado)
    End Function
    Public Function ValidarUsuario(ByVal IdUsuario As String, ByVal Password As String) As String
        Return dl.ValidarUsuario(IdUsuario, Password)
    End Function
    'Public Function rptDepositoAhorro(ByVal IdCuenta As Integer, ByVal IdMov As Integer) As DataTable
    '    Return dl.rptDepositoAhorro(IdCuenta, IdMov)
    'End Function
    Public Function rptDepositoAhorroIdMov(ByVal IdMov As Integer, ByVal IdCuenta As Integer) As DataTable
        Return dl.rptDepositoAhorroIdMov(IdMov, IdCuenta)
    End Function

    Public Function rptReciboPagoPrestamo(ByVal IdPrestamo As Integer, ByVal IdMov As Integer) As DataTable
        Return dl.rptReciboPagoIdMov(IdPrestamo, IdMov)
    End Function

    Public Function rptRetiroAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return dl.rptRetiroAhorro(NumeroComp, IdCuenta)
    End Function
    Public Function GetDenominaciones() As DataTable
        Return dl.GetDenominaciones()
    End Function
    Public Function GetArqueoCaja(ByVal IdCorte As Integer) As DataTable
        Return dl.GetArqueoCaja(IdCorte)
    End Function
    Public Function GetChequesCorteCaja(ByVal IdCorte As Integer) As DataTable
        Return dl.GetChequesCorteCaja(IdCorte)
    End Function

    Public Function DatosAsociadoParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Incluir As Boolean) As DataTable
        Return dl.DatosAsociadoParaConsulta(Nombre, Apellido, Incluir)
    End Function
    Public Function CuentaAhorroParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.CuentaAhorroParaConsulta(Nombre, Apellido, Fecha, Incluir)
    End Function
    Public Function PrestamoParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Return dl.PrestamoParaConsulta(Nombre, Apellido, Fecha, Incluir)
    End Function
    Public Function SolicitudFondosParaConsulta() As DataTable
        Return dl.SolicitudFondosParaConsulta()
    End Function
    Public Function rptLiquidacionPrestamo(ByVal IdSolicitudFondo As Integer) As DataTable
        Return dl.rptLiquidacionPrestamo(IdSolicitudFondo)
    End Function
    Public Function GetSaldoCapitalPrestamo(ByVal IdPrestamo As Integer) As Decimal
        Return dl.GetSaldoCapitalPrestamo(IdPrestamo)
    End Function
    Public Function InsertaPrimerDesembolso(ByRef entPrestamo As coo_Prestamos _
, ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByRef entPlan As List(Of coo_PrestamosPlanPagos), _
ByRef IdFondo As Integer, ByRef IdMunicipio As String, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones, ByRef entCancelacion As List(Of coo_PrestamosDetalle), ByRef entPignora As List(Of coo_Pignoraciones)) As String
        Return dl.InsertaPrimerDesembolso(entPrestamo, entDesembolso, entDeposito, entPlan, IdFondo, _
        IdMunicipio, entLiquidacion, entSimultaneo, entAportacion, entCapitalizacion, entCancelacion, entPignora)
    End Function
    Public Function InsertaDesembolso(ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByVal IdFondo As Integer, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones, ByRef entCancelacion As List(Of coo_PrestamosDetalle), ByRef entPignora As List(Of coo_Pignoraciones), ByRef entSolicitud As coo_Solicitudes) As String
        Return dl.InsertaDesembolso(entDesembolso, entDeposito, IdFondo, entLiquidacion, entSimultaneo, entAportacion, entCapitalizacion, entCancelacion, entPignora, entSolicitud)
    End Function
    Public Function ExisteNumComprobanteDesembolso(ByVal Numero As String) As Integer
        Return dl.ExisteNumComprobanteDesembolso(Numero)
    End Function
    Public Function ExisteNumPrestamo(ByVal Numero As String) As Integer
        Return dl.ExisteNumPrestamo(Numero)
    End Function
    Public Function VerificaSeguroCobrado(ByVal IdPrestamo As Integer, ByVal Mes As Integer, ByVal Periodo As Integer) As Integer
        Return dl.VerificaSeguroCobrado(IdPrestamo, Mes, Periodo)
    End Function
    Public Function ExistePrestamo(ByVal IdSolicitud As Integer) As String
        Return dl.ExistePrestamo(IdSolicitud)
    End Function
    Public Function CalculaSaldoPres(ByVal IdPrestamo As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal CancelarEfectivo As Boolean) As DataTable
        Return dl.CalculaSaldoPres(IdPrestamo, IdAsociado, HastaFecha, CancelarEfectivo)
    End Function

    Public Function coo_AsociadosSelectNumero(ByVal Numero As String) As coo_Asociados

        Return dl.coo_AsociadosSelectNumero(Numero)
    End Function
    Public Function coo_PignoracionesSelectByCuenta(ByVal IdCuenta As System.Int32) As coo_Pignoraciones
        Return dl.coo_PignoracionesSelectByCuenta(IdCuenta)
    End Function
    Public Function coo_GarantiasCuentaPignoradasSelectBySolicitud(ByVal IdSolicitud As System.Int32) As DataTable
        Return dl.coo_GarantiasCuentaPignoradaSelectBySolicitud(IdSolicitud)
    End Function
    Public Function coo_OperacionesCajaSelectByNumero _
  (ByVal IdSucursal As Integer, ByVal Numero As String, ByVal Tipo As Integer _
  ) As coo_OperacionesCaja

        Return dl.coo_OperacionesCajaSelectByNumero( _
         IdSucursal, Numero, Tipo _
         )
    End Function


    Public Function coo_LiquidacionesSelectByNumero _
  (ByVal IdSucursal As Integer, ByVal Numero As String _
  ) As coo_Liquidaciones

        Return dl.coo_LiquidacionesSelectByNumero( _
         IdSucursal, Numero _
         )
    End Function


    Public Function coo_AportacionesSelectNoImpresos(ByVal IdAsociado As System.Int32) As DataTable
        Return dl.coo_AportacionesSelectNoImpresos(IdAsociado)
    End Function
    Public Function coo_SolicitudFondosRefinanciaSelectByFondo _
  (ByVal IdSolicitudFondo As System.Int32) As DataTable
        Return dl.coo_SolicitudFondosRefinanciaSelectByFondo( _
         IdSolicitudFondo)
    End Function

    Public Function coo_SolicitudDescuentosSelectBySolicitud _
(ByVal IdSolicitud As System.Int32) As DataTable
        Return dl.coo_SolicitudDescuentosSelectBySolicitud( _
         IdSolicitud)
    End Function
    Public Function coo_AportacionesSelect(ByVal IdAsociado As System.Int32) As DataTable
        Return dl.coo_AportacionesSelect(IdAsociado)
    End Function
    Public Function coo_AhorrosSelect(ByVal IdCuenta As System.Int32) As DataTable
        Return dl.coo_AhorrosSelect(IdCuenta)
    End Function
    Public Function ActualizaImpresoAportacion(ByVal IdAsociado As System.Int32, ByVal IdMov As Integer, ByVal Impreso As Boolean) As String
        Return dl.ActualizaImpresoAportacion(IdAsociado, IdMov, Impreso)
    End Function
    Public Function ActualizaImpresoAhorro(ByVal IdCuenta As System.Int32, ByVal IdMov As Integer, ByVal Impreso As Boolean) As String
        Return dl.ActualizaImpresoAhorro(IdCuenta, IdMov, Impreso)
    End Function
    Public Function ConsultaCuentaCorriente(ByVal IdAsociado As Integer) As DataTable
        Return dl.ConsultaCuentaCorriente(IdAsociado)
    End Function
    Public Function coo_AhorroSelectNoImpresos(ByVal IdCuenta As System.Int32) As DataTable
        Return dl.coo_AhorrosSelectNoImpresos(IdCuenta)
    End Function
    Public Function coo_LiquidacionSelectByAsociado _
(ByVal IdAsociado As System.Int32 _
) As coo_LiquidacionAportaciones
        Return dl.coo_LiquidacionSelectByAsociado( _
         IdAsociado _
         )
    End Function
    Public Sub ActualizaCorrelativoSucursal(ByVal sentencia As String)
        dl.ActualizaCorrelativoSucursal(sentencia)
    End Sub
    Public Sub EjecutaInstruccionSql(ByVal sql As String)
        dl.EjecutaInstruccionSql(sql)
    End Sub

    Public Sub CancelacionLiquidacionAportacion(ByVal sentencia As String)
        dl.CancelacionLiquidacionAportacion(sentencia)
    End Sub

    Public Function InsertaAportacion(ByRef entAportacion As coo_Aportaciones) As String
        Return dl.InsertaAportacion(entAportacion)
    End Function
    Public Function InsertaAyudaFuneraria(ByRef entAyuda As coo_MovFuneraria) As String
        Return dl.InsertaAyudaFuneraria(entAyuda)
    End Function

    Public Function InsertaRemision(ByRef entRemision As coo_OperacionesCaja, ByVal IdSucursal As Integer) As String
        Return dl.InsertaRemision(entRemision, IdSucursal)
    End Function

    Public Function InsertaRequisicion(ByRef entRemision As coo_OperacionesCaja, ByVal IdSucursal As Integer) As String
        Return dl.InsertaRequisicion(entRemision, IdSucursal)
    End Function

    Public Function InsertaRetiro(ByRef entCuentaAhorroMov As coo_CuentasAhorroMov, ByVal IdSucursal As Integer) As String
        Return dl.InsertaRetiro(entCuentaAhorroMov, IdSucursal)
    End Function

    Public Function InsertaCancelacionAhorro(ByRef entCuentaAhorroMov As coo_CuentasAhorroMov, _
    ByRef entInteres As coo_CuentasAhorroMov, ByRef entIsr As coo_IsrInteres, ByVal IdSucursal As Integer) As String
        Return dl.InsertaCancelacionAhorro(entCuentaAhorroMov, entInteres, entIsr, IdSucursal)
    End Function


    Public Function InsertaDeposito(ByRef entCuentaAhorroMov As coo_CuentasAhorroMov, ByVal IdSucursal As Integer) As String
        Return dl.InsertaDeposito(entCuentaAhorroMov, IdSucursal)
    End Function

    Public Function InsertaOtrosIngresos(ByRef entOtrosIngresos As coo_OtrosIngresos, ByVal IdSucursal As Integer) As String
        Return dl.InsertaOtrosIngresos(entOtrosIngresos, IdSucursal)
    End Function

    Public Function InsertaOtrosEgresos(ByRef entOtrosEgresos As coo_OtrosEgresos, ByVal IdSucursal As Integer) As String
        Return dl.InsertaOtrosEgresos(entOtrosEgresos, IdSucursal)
    End Function

    Public Function rptContratoAhorro(ByVal IdCuenta As Integer) As coo_ContratoAhorro
        Return dl.rptContratoAhorro(IdCuenta)
    End Function

    Public Function rptDeclaracionJurada(ByVal IdCuenta As Integer, ByVal IdMov As Integer) As coo_DeclaracionJurada
        Return dl.rptDeclaracionJurada(IdCuenta, IdMov)
    End Function


    Public Function coo_DocumentosSelectByPK(ByVal Documento As String) As coo_Documentos
        Return dl.coo_DocumentosSelectByPK(Documento)
    End Function

    Public Function getPrestamosPlanPago(ByVal IdPrestamo As System.Int32) As DataTable
        Return dl.GetPrestamosPlanPago(IdPrestamo)
    End Function

    Public Function coo_PagosPrestamoParalibreta(ByVal IdPrestamo As System.Int32) As DataTable
        Return dl.coo_PagosPrestamoParalibreta(IdPrestamo)
    End Function



    '#Region "AUTOGeneratedCode"
    '    Public Function coo_MovFunerariaSelectAll() As DataTable
    '        Return dl.coo_MovFunerariaSelectAll()
    '    End Function

    '    Public Function coo_MovFunerariaSelectByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      ) As coo_MovFuneraria

    '        Return dl.coo_MovFunerariaSelectByPK( _
    '         IdAsociado _
    '         , IdMov _
    '         )
    '    End Function

    '    Public Sub coo_MovFunerariaDeleteByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_MovFunerariaDeleteByPK( _
    '         IdAsociado _
    '         , IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_MovFunerariaInsert _
    '    (ByVal entidad As coo_MovFuneraria)

    '        dl.coo_MovFunerariaInsert(entidad)
    '    End Sub

    '    Public Sub coo_MovFunerariaUpdate _
    '    (ByVal entidad As coo_MovFuneraria)

    '        dl.coo_MovFunerariaUpdate(entidad)
    '    End Sub


    '    Public Function coo_AfiliacionesSelectAll() As DataTable
    '        Return dl.coo_AfiliacionesSelectAll()
    '    End Function

    '    Public Function coo_AfiliacionesSelectByPK _
    '      (ByVal IdMov As System.Int32 _
    '      ) As coo_Afiliaciones

    '        Return dl.coo_AfiliacionesSelectByPK( _
    '         IdMov _
    '         )
    '    End Function

    '    Public Sub coo_AfiliacionesDeleteByPK _
    '      (ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_AfiliacionesDeleteByPK( _
    '         IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_AfiliacionesInsert _
    '    (ByVal entidad As coo_Afiliaciones)

    '        dl.coo_AfiliacionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_AfiliacionesUpdate _
    '    (ByVal entidad As coo_Afiliaciones)

    '        dl.coo_AfiliacionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_AgentesRemesaSelectAll() As DataTable
    '        Return dl.coo_AgentesRemesaSelectAll()
    '    End Function

    '    Public Function coo_AgentesRemesaSelectByPK _
    '      (ByVal IdAgente As System.Byte _
    '      ) As coo_AgentesRemesa

    '        Return dl.coo_AgentesRemesaSelectByPK( _
    '         IdAgente _
    '         )
    '    End Function

    '    Public Sub coo_AgentesRemesaDeleteByPK _
    '      (ByVal IdAgente As System.Byte _
    '      )

    '        dl.coo_AgentesRemesaDeleteByPK( _
    '         IdAgente _
    '         )
    '    End Sub

    '    Public Sub coo_AgentesRemesaInsert _
    '    (ByVal entidad As coo_AgentesRemesa)

    '        dl.coo_AgentesRemesaInsert(entidad)
    '    End Sub

    '    Public Sub coo_AgentesRemesaUpdate _
    '    (ByVal entidad As coo_AgentesRemesa)

    '        dl.coo_AgentesRemesaUpdate(entidad)
    '    End Sub

    '    Public Function coo_AportacionesSelectAll() As DataTable
    '        Return dl.coo_AportacionesSelectAll()
    '    End Function

    '    Public Function coo_AportacionesSelectByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      ) As coo_Aportaciones

    '        Return dl.coo_AportacionesSelectByPK( _
    '         IdAsociado _
    '         , IdMov _
    '         )
    '    End Function

    '    Public Sub coo_AportacionesDeleteByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_AportacionesDeleteByPK( _
    '         IdAsociado _
    '         , IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_AportacionesInsert _
    '    (ByVal entidad As coo_Aportaciones)

    '        dl.coo_AportacionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_AportacionesUpdate _
    '    (ByVal entidad As coo_Aportaciones)

    '        dl.coo_AportacionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_AsociadosSelectAll() As DataTable
    '        Return dl.coo_AsociadosSelectAll()
    '    End Function

    '    Public Function coo_AsociadosSelectByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      ) As coo_Asociados

    '        Return dl.coo_AsociadosSelectByPK( _
    '         IdAsociado _
    '         )
    '    End Function

    '    Public Sub coo_AsociadosDeleteByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      )

    '        dl.coo_AsociadosDeleteByPK( _
    '         IdAsociado _
    '         )
    '    End Sub

    '    Public Sub coo_AsociadosInsert _
    '    (ByVal entidad As coo_Asociados)

    '        dl.coo_AsociadosInsert(entidad)
    '    End Sub

    '    Public Sub coo_AsociadosUpdate _
    '    (ByVal entidad As coo_Asociados)

    '        dl.coo_AsociadosUpdate(entidad)
    '    End Sub

    '    Public Function coo_AsociadosBeneficiariosSelectAll() As DataTable
    '        Return dl.coo_AsociadosBeneficiariosSelectAll()
    '    End Function

    '    Public Function coo_AsociadosBeneficiariosSelectByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdBeneficiario As System.Byte _
    '      ) As coo_AsociadosBeneficiarios

    '        Return dl.coo_AsociadosBeneficiariosSelectByPK( _
    '         IdAsociado _
    '         , IdBeneficiario _
    '         )
    '    End Function

    '    Public Sub coo_AsociadosBeneficiariosDeleteByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal IdBeneficiario As System.Byte _
    '      )

    '        dl.coo_AsociadosBeneficiariosDeleteByPK( _
    '         IdAsociado _
    '         , IdBeneficiario _
    '         )
    '    End Sub

    '    Public Sub coo_AsociadosBeneficiariosInsert _
    '    (ByVal entidad As coo_AsociadosBeneficiarios)

    '        dl.coo_AsociadosBeneficiariosInsert(entidad)
    '    End Sub

    '    Public Sub coo_AsociadosBeneficiariosUpdate _
    '    (ByVal entidad As coo_AsociadosBeneficiarios)

    '        dl.coo_AsociadosBeneficiariosUpdate(entidad)
    '    End Sub

    '    Public Function coo_CalendarioSelectAll() As DataTable
    '        Return dl.coo_CalendarioSelectAll()
    '    End Function

    '    Public Function coo_CalendarioSelectByPK _
    '      (ByVal Fecha As System.DateTime _
    '      ) As coo_Calendario

    '        Return dl.coo_CalendarioSelectByPK( _
    '         Fecha _
    '         )
    '    End Function

    '    Public Sub coo_CalendarioDeleteByPK _
    '      (ByVal Fecha As System.DateTime _
    '      )

    '        dl.coo_CalendarioDeleteByPK( _
    '         Fecha _
    '         )
    '    End Sub

    '    Public Sub coo_CalendarioInsert _
    '    (ByVal entidad As coo_Calendario)

    '        dl.coo_CalendarioInsert(entidad)
    '    End Sub

    '    Public Sub coo_CalendarioUpdate _
    '    (ByVal entidad As coo_Calendario)

    '        dl.coo_CalendarioUpdate(entidad)
    '    End Sub

    '    Public Function coo_CuentasAhorroSelectAll() As DataTable
    '        Return dl.coo_CuentasAhorroSelectAll()
    '    End Function

    '    Public Function coo_CuentasAhorroSelectByPK _
    '      (ByVal IdCuenta As System.Int32 _
    '      ) As coo_CuentasAhorro

    '        Return dl.coo_CuentasAhorroSelectByPK( _
    '         IdCuenta _
    '         )
    '    End Function

    '    Public Sub coo_CuentasAhorroDeleteByPK _
    '      (ByVal IdCuenta As System.Int32 _
    '      )

    '        dl.coo_CuentasAhorroDeleteByPK( _
    '         IdCuenta _
    '         )
    '    End Sub

    '    Public Sub coo_CuentasAhorroInsert _
    '    (ByVal entidad As coo_CuentasAhorro)

    '        dl.coo_CuentasAhorroInsert(entidad)
    '    End Sub

    '    Public Sub coo_CuentasAhorroUpdate _
    '    (ByVal entidad As coo_CuentasAhorro)

    '        dl.coo_CuentasAhorroUpdate(entidad)
    '    End Sub

    '    Public Function coo_CuentasAhorroMovSelectAll() As DataTable
    '        Return dl.coo_CuentasAhorroMovSelectAll()
    '    End Function

    '    Public Function coo_CuentasAhorroMovSelectByPK _
    '      (ByVal IdCuenta As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      ) As coo_CuentasAhorroMov

    '        Return dl.coo_CuentasAhorroMovSelectByPK( _
    '         IdCuenta _
    '         , IdMov _
    '         )
    '    End Function

    '    Public Sub coo_CuentasAhorroMovDeleteByPK _
    '      (ByVal IdCuenta As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_CuentasAhorroMovDeleteByPK( _
    '         IdCuenta _
    '         , IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_CuentasAhorroMovInsert _
    '    (ByVal entidad As coo_CuentasAhorroMov)

    '        dl.coo_CuentasAhorroMovInsert(entidad)
    '    End Sub

    '    Public Sub coo_CuentasAhorroMovUpdate _
    '    (ByVal entidad As coo_CuentasAhorroMov)

    '        dl.coo_CuentasAhorroMovUpdate(entidad)
    '    End Sub

    '    Public Function coo_EstadosAsociadoSelectAll() As DataTable
    '        Return dl.coo_EstadosAsociadoSelectAll()
    '    End Function

    '    Public Function coo_EstadosAsociadoSelectByPK _
    '      (ByVal IdEstado As System.Byte _
    '      ) As coo_EstadosAsociado

    '        Return dl.coo_EstadosAsociadoSelectByPK( _
    '         IdEstado _
    '         )
    '    End Function

    '    Public Sub coo_EstadosAsociadoDeleteByPK _
    '      (ByVal IdEstado As System.Byte _
    '      )

    '        dl.coo_EstadosAsociadoDeleteByPK( _
    '         IdEstado _
    '         )
    '    End Sub

    '    Public Sub coo_EstadosAsociadoInsert _
    '    (ByVal entidad As coo_EstadosAsociado)

    '        dl.coo_EstadosAsociadoInsert(entidad)
    '    End Sub

    '    Public Sub coo_EstadosAsociadoUpdate _
    '    (ByVal entidad As coo_EstadosAsociado)

    '        dl.coo_EstadosAsociadoUpdate(entidad)
    '    End Sub

    '    Public Function coo_EstadosPrestamoSelectAll() As DataTable
    '        Return dl.coo_EstadosPrestamoSelectAll()
    '    End Function

    '    Public Function coo_EstadosPrestamoSelectByPK _
    '      (ByVal IdEstado As System.Byte _
    '      ) As coo_EstadosPrestamo

    '        Return dl.coo_EstadosPrestamoSelectByPK( _
    '         IdEstado _
    '         )
    '    End Function

    '    Public Sub coo_EstadosPrestamoDeleteByPK _
    '      (ByVal IdEstado As System.Byte _
    '      )

    '        dl.coo_EstadosPrestamoDeleteByPK( _
    '         IdEstado _
    '         )
    '    End Sub

    '    Public Sub coo_EstadosPrestamoInsert _
    '    (ByVal entidad As coo_EstadosPrestamo)

    '        dl.coo_EstadosPrestamoInsert(entidad)
    '    End Sub

    '    Public Sub coo_EstadosPrestamoUpdate _
    '    (ByVal entidad As coo_EstadosPrestamo)

    '        dl.coo_EstadosPrestamoUpdate(entidad)
    '    End Sub

    '    Public Function coo_FormasPagoCajaSelectAll() As DataTable
    '        Return dl.coo_FormasPagoCajaSelectAll()
    '    End Function

    '    Public Function coo_FormasPagoCajaSelectByPK _
    '      (ByVal IdFormaPago As System.Byte _
    '      ) As coo_FormasPagoCaja

    '        Return dl.coo_FormasPagoCajaSelectByPK( _
    '         IdFormaPago _
    '         )
    '    End Function

    '    Public Sub coo_FormasPagoCajaDeleteByPK _
    '      (ByVal IdFormaPago As System.Byte _
    '      )

    '        dl.coo_FormasPagoCajaDeleteByPK( _
    '         IdFormaPago _
    '         )
    '    End Sub

    '    Public Sub coo_FormasPagoCajaInsert _
    '    (ByVal entidad As coo_FormasPagoCaja)

    '        dl.coo_FormasPagoCajaInsert(entidad)
    '    End Sub

    '    Public Sub coo_FormasPagoCajaUpdate _
    '    (ByVal entidad As coo_FormasPagoCaja)

    '        dl.coo_FormasPagoCajaUpdate(entidad)
    '    End Sub

    '    Public Function coo_OperacionesCajaSelectAll() As DataTable
    '        Return dl.coo_OperacionesCajaSelectAll()
    '    End Function

    '    Public Function coo_OperacionesCajaSelectByPK _
    '      (ByVal IdOperacion As System.Int32 _
    '      ) As coo_OperacionesCaja

    '        Return dl.coo_OperacionesCajaSelectByPK( _
    '         IdOperacion _
    '         )
    '    End Function

    '    Public Sub coo_OperacionesCajaDeleteByPK _
    '      (ByVal IdOperacion As System.Int32 _
    '      )

    '        dl.coo_OperacionesCajaDeleteByPK( _
    '         IdOperacion _
    '         )
    '    End Sub

    '    Public Sub coo_OperacionesCajaInsert _
    '    (ByVal entidad As coo_OperacionesCaja)

    '        dl.coo_OperacionesCajaInsert(entidad)
    '    End Sub

    '    Public Sub coo_OperacionesCajaUpdate _
    '    (ByVal entidad As coo_OperacionesCaja)

    '        dl.coo_OperacionesCajaUpdate(entidad)
    '    End Sub

    '    Public Function coo_OtrosEgresosSelectAll() As DataTable
    '        Return dl.coo_OtrosEgresosSelectAll()
    '    End Function

    '    Public Function coo_OtrosEgresosSelectByPK _
    '      (ByVal IdMov As System.Int32 _
    '      ) As coo_OtrosEgresos

    '        Return dl.coo_OtrosEgresosSelectByPK( _
    '         IdMov _
    '         )
    '    End Function

    '    Public Sub coo_OtrosEgresosDeleteByPK _
    '      (ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_OtrosEgresosDeleteByPK( _
    '         IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_OtrosEgresosInsert _
    '    (ByVal entidad As coo_OtrosEgresos)

    '        dl.coo_OtrosEgresosInsert(entidad)
    '    End Sub

    '    Public Sub coo_OtrosEgresosUpdate _
    '    (ByVal entidad As coo_OtrosEgresos)

    '        dl.coo_OtrosEgresosUpdate(entidad)
    '    End Sub

    '    Public Function coo_OtrosIngresosSelectAll() As DataTable
    '        Return dl.coo_OtrosIngresosSelectAll()
    '    End Function

    '    Public Function coo_OtrosIngresosSelectByPK _
    '      (ByVal IdMov As System.Int32 _
    '      ) As coo_OtrosIngresos

    '        Return dl.coo_OtrosIngresosSelectByPK( _
    '         IdMov _
    '         )
    '    End Function

    '    Public Sub coo_OtrosIngresosDeleteByPK _
    '      (ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_OtrosIngresosDeleteByPK( _
    '         IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_OtrosIngresosInsert _
    '    (ByVal entidad As coo_OtrosIngresos)

    '        dl.coo_OtrosIngresosInsert(entidad)
    '    End Sub

    '    Public Sub coo_OtrosIngresosUpdate _
    '    (ByVal entidad As coo_OtrosIngresos)

    '        dl.coo_OtrosIngresosUpdate(entidad)
    '    End Sub


    '    Public Function coo_PrestamosSelectAll() As DataTable
    '        Return dl.coo_PrestamosSelectAll()
    '    End Function

    '    Public Function coo_PrestamosSelectByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      ) As coo_Prestamos

    '        Return dl.coo_PrestamosSelectByPK( _
    '         IdPrestamo _
    '         )
    '    End Function

    '    Public Sub coo_PrestamosDeleteByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      )

    '        dl.coo_PrestamosDeleteByPK( _
    '         IdPrestamo _
    '         )
    '    End Sub

    '    Public Sub coo_PrestamosInsert _
    '    (ByVal entidad As coo_Prestamos)

    '        dl.coo_PrestamosInsert(entidad)
    '    End Sub

    '    Public Sub coo_PrestamosUpdate _
    '    (ByVal entidad As coo_Prestamos)

    '        dl.coo_PrestamosUpdate(entidad)
    '    End Sub

    '    Public Function coo_PrestamosDetalleSelectAll() As DataTable
    '        Return dl.coo_PrestamosDetalleSelectAll()
    '    End Function

    '    Public Function coo_PrestamosDetalleSelectByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      ) As coo_PrestamosDetalle

    '        Return dl.coo_PrestamosDetalleSelectByPK( _
    '         IdPrestamo _
    '         , IdMov _
    '         )
    '    End Function

    '    Public Sub coo_PrestamosDetalleDeleteByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal IdMov As System.Int32 _
    '      )

    '        dl.coo_PrestamosDetalleDeleteByPK( _
    '         IdPrestamo _
    '         , IdMov _
    '         )
    '    End Sub

    '    Public Sub coo_PrestamosDetalleInsert _
    '    (ByVal entidad As coo_PrestamosDetalle)

    '        dl.coo_PrestamosDetalleInsert(entidad)
    '    End Sub

    '    Public Sub coo_PrestamosDetalleUpdate _
    '    (ByVal entidad As coo_PrestamosDetalle)

    '        dl.coo_PrestamosDetalleUpdate(entidad)
    '    End Sub
    '    Public Function coo_PrestamosDetalleDescuentosSelectAll() As DataTable
    '        Return dl.coo_PrestamosDetalleDescuentosSelectAll()
    '    End Function

    '    Public Function coo_PrestamosDetalleDescuentosSelectByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal IdDetalle As System.Int32 _
    '      ) As coo_PrestamosDetalleDescuentos

    '        Return dl.coo_PrestamosDetalleDescuentosSelectByPK( _
    '         IdPrestamo _
    '         , IdDetalle _
    '         )
    '    End Function

    '    Public Sub coo_PrestamosDetalleDescuentosDeleteByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal IdDetalle As System.Int32 _
    '      )

    '        dl.coo_PrestamosDetalleDescuentosDeleteByPK( _
    '         IdPrestamo _
    '         , IdDetalle _
    '         )
    '    End Sub

    '    Public Sub coo_PrestamosDetalleDescuentosInsert _
    '    (ByVal entidad As coo_PrestamosDetalleDescuentos)

    '        dl.coo_PrestamosDetalleDescuentosInsert(entidad)
    '    End Sub

    '    Public Sub coo_PrestamosDetalleDescuentosUpdate _
    '    (ByVal entidad As coo_PrestamosDetalleDescuentos)

    '        dl.coo_PrestamosDetalleDescuentosUpdate(entidad)
    '    End Sub


    '    Public Function coo_PrestamosPlanPagosSelectAll() As DataTable
    '        Return dl.coo_PrestamosPlanPagosSelectAll()
    '    End Function

    '    Public Function coo_PrestamosPlanPagosSelectByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal NumCuota As System.Int32 _
    '      ) As coo_PrestamosPlanPagos

    '        Return dl.coo_PrestamosPlanPagosSelectByPK( _
    '         IdPrestamo _
    '         , NumCuota _
    '         )
    '    End Function

    '    Public Sub coo_PrestamosPlanPagosDeleteByPK _
    '      (ByVal IdPrestamo As System.Int32 _
    '      , ByVal NumCuota As System.Int32 _
    '      )

    '        dl.coo_PrestamosPlanPagosDeleteByPK( _
    '         IdPrestamo _
    '         , NumCuota _
    '         )
    '    End Sub

    '    Public Sub coo_PrestamosPlanPagosInsert _
    '    (ByVal entidad As coo_PrestamosPlanPagos)

    '        dl.coo_PrestamosPlanPagosInsert(entidad)
    '    End Sub

    '    Public Sub coo_PrestamosPlanPagosUpdate _
    '    (ByVal entidad As coo_PrestamosPlanPagos)

    '        dl.coo_PrestamosPlanPagosUpdate(entidad)
    '    End Sub

    '    Public Function coo_TipoDocumentoSelectAll() As DataTable
    '        Return dl.coo_TipoDocumentoSelectAll()
    '    End Function

    '    Public Function coo_TipoDocumentoSelectByPK _
    '      (ByVal IdTipo As System.Int32 _
    '      ) As coo_TipoDocumento

    '        Return dl.coo_TipoDocumentoSelectByPK( _
    '         IdTipo _
    '         )
    '    End Function

    '    Public Sub coo_TipoDocumentoDeleteByPK _
    '      (ByVal IdTipo As System.Int32 _
    '      )

    '        dl.coo_TipoDocumentoDeleteByPK( _
    '         IdTipo _
    '         )
    '    End Sub

    '    Public Sub coo_TipoDocumentoInsert _
    '    (ByVal entidad As coo_TipoDocumento)

    '        dl.coo_TipoDocumentoInsert(entidad)
    '    End Sub

    '    Public Sub coo_TipoDocumentoUpdate _
    '    (ByVal entidad As coo_TipoDocumento)

    '        dl.coo_TipoDocumentoUpdate(entidad)
    '    End Sub

    '    Public Function coo_TipoMovimientoAhorroSelectAll() As DataTable
    '        Return dl.coo_TipoMovimientoAhorroSelectAll()
    '    End Function

    '    Public Function coo_TipoMovimientoAhorroSelectByPK _
    '      (ByVal IdTipo As System.Byte _
    '      ) As coo_TipoMovimientoAhorro

    '        Return dl.coo_TipoMovimientoAhorroSelectByPK( _
    '         IdTipo _
    '         )
    '    End Function

    '    Public Sub coo_TipoMovimientoAhorroDeleteByPK _
    '      (ByVal IdTipo As System.Byte _
    '      )

    '        dl.coo_TipoMovimientoAhorroDeleteByPK( _
    '         IdTipo _
    '         )
    '    End Sub

    '    Public Sub coo_TipoMovimientoAhorroInsert _
    '    (ByVal entidad As coo_TipoMovimientoAhorro)

    '        dl.coo_TipoMovimientoAhorroInsert(entidad)
    '    End Sub

    '    Public Sub coo_TipoMovimientoAhorroUpdate _
    '    (ByVal entidad As coo_TipoMovimientoAhorro)

    '        dl.coo_TipoMovimientoAhorroUpdate(entidad)
    '    End Sub

    '    Public Function coo_TiposAportacionSelectAll() As DataTable
    '        Return dl.coo_TiposAportacionSelectAll()
    '    End Function

    '    Public Function coo_TiposAportacionSelectByPK _
    '      (ByVal IdTipo As System.Byte _
    '      ) As coo_TiposAportacion

    '        Return dl.coo_TiposAportacionSelectByPK( _
    '         IdTipo _
    '         )
    '    End Function

    '    Public Sub coo_TiposAportacionDeleteByPK _
    '      (ByVal IdTipo As System.Byte _
    '      )

    '        dl.coo_TiposAportacionDeleteByPK( _
    '         IdTipo _
    '         )
    '    End Sub

    '    Public Sub coo_TiposAportacionInsert _
    '    (ByVal entidad As coo_TiposAportacion)

    '        dl.coo_TiposAportacionInsert(entidad)
    '    End Sub

    '    Public Sub coo_TiposAportacionUpdate _
    '    (ByVal entidad As coo_TiposAportacion)

    '        dl.coo_TiposAportacionUpdate(entidad)
    '    End Sub

    '    Public Function coo_TiposCarteraSelectAll() As DataTable
    '        Return dl.coo_TiposCarteraSelectAll()
    '    End Function

    '    Public Function coo_TiposCarteraSelectByPK _
    '      (ByVal IdTipoCartera As System.Byte _
    '      ) As coo_TiposCartera

    '        Return dl.coo_TiposCarteraSelectByPK( _
    '         IdTipoCartera _
    '         )
    '    End Function

    '    Public Sub coo_TiposCarteraDeleteByPK _
    '      (ByVal IdTipoCartera As System.Byte _
    '      )

    '        dl.coo_TiposCarteraDeleteByPK( _
    '         IdTipoCartera _
    '         )
    '    End Sub

    '    Public Sub coo_TiposCarteraInsert _
    '    (ByVal entidad As coo_TiposCartera)

    '        dl.coo_TiposCarteraInsert(entidad)
    '    End Sub

    '    Public Sub coo_TiposCarteraUpdate _
    '    (ByVal entidad As coo_TiposCartera)

    '        dl.coo_TiposCarteraUpdate(entidad)
    '    End Sub

    '    Public Function coo_TiposCuentaAhorroSelectAll() As DataTable
    '        Return dl.coo_TiposCuentaAhorroSelectAll()
    '    End Function

    '    Public Function coo_TiposCuentaAhorroSelectByPK _
    '      (ByVal IdTipo As System.Byte _
    '      ) As coo_TiposCuentaAhorro

    '        Return dl.coo_TiposCuentaAhorroSelectByPK( _
    '         IdTipo _
    '         )
    '    End Function

    '    Public Sub coo_TiposCuentaAhorroDeleteByPK _
    '      (ByVal IdTipo As System.Byte _
    '      )

    '        dl.coo_TiposCuentaAhorroDeleteByPK( _
    '         IdTipo _
    '         )
    '    End Sub

    '    Public Sub coo_TiposCuentaAhorroInsert _
    '    (ByVal entidad As coo_TiposCuentaAhorro)

    '        dl.coo_TiposCuentaAhorroInsert(entidad)
    '    End Sub

    '    Public Sub coo_TiposCuentaAhorroUpdate _
    '    (ByVal entidad As coo_TiposCuentaAhorro)

    '        dl.coo_TiposCuentaAhorroUpdate(entidad)
    '    End Sub

    '    Public Function coo_TiposMovimientoCajaSelectAll() As DataTable
    '        Return dl.coo_TiposMovimientoCajaSelectAll()
    '    End Function

    '    Public Function coo_TiposMovimientoCajaSelectByPK _
    '      (ByVal IdTipo As System.Byte _
    '      ) As coo_TiposMovimientoCaja

    '        Return dl.coo_TiposMovimientoCajaSelectByPK( _
    '         IdTipo _
    '         )
    '    End Function

    '    Public Sub coo_TiposMovimientoCajaDeleteByPK _
    '      (ByVal IdTipo As System.Byte _
    '      )

    '        dl.coo_TiposMovimientoCajaDeleteByPK( _
    '         IdTipo _
    '         )
    '    End Sub

    '    Public Sub coo_TiposMovimientoCajaInsert _
    '    (ByVal entidad As coo_TiposMovimientoCaja)

    '        dl.coo_TiposMovimientoCajaInsert(entidad)
    '    End Sub

    '    Public Sub coo_TiposMovimientoCajaUpdate _
    '    (ByVal entidad As coo_TiposMovimientoCaja)

    '        dl.coo_TiposMovimientoCajaUpdate(entidad)
    '    End Sub

    '    Public Function coo_TiposPrestamoSelectAll() As DataTable
    '        Return dl.coo_TiposPrestamoSelectAll()
    '    End Function

    '    Public Function coo_TiposPrestamoSelectByPK _
    '      (ByVal IdTipoPrestamo As System.Byte _
    '      ) As coo_TiposPrestamo

    '        Return dl.coo_TiposPrestamoSelectByPK( _
    '         IdTipoPrestamo _
    '         )
    '    End Function

    '    Public Sub coo_TiposPrestamoDeleteByPK _
    '      (ByVal IdTipoPrestamo As System.Byte _
    '      )

    '        dl.coo_TiposPrestamoDeleteByPK( _
    '         IdTipoPrestamo _
    '         )
    '    End Sub

    '    Public Sub coo_TiposPrestamoInsert _
    '    (ByVal entidad As coo_TiposPrestamo)

    '        dl.coo_TiposPrestamoInsert(entidad)
    '    End Sub

    '    Public Sub coo_TiposPrestamoUpdate _
    '    (ByVal entidad As coo_TiposPrestamo)

    '        dl.coo_TiposPrestamoUpdate(entidad)
    '    End Sub

    '    Public Function coo_CorteCajaSelectAll() As DataTable
    '        Return dl.coo_CorteCajaSelectAll()
    '    End Function

    '    Public Function coo_CorteCajaSelectByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      ) As coo_CorteCaja

    '        Return dl.coo_CorteCajaSelectByPK( _
    '         IdCorte _
    '         )
    '    End Function

    '    Public Sub coo_CorteCajaDeleteByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      )

    '        dl.coo_CorteCajaDeleteByPK( _
    '         IdCorte _
    '         )
    '    End Sub

    '    Public Sub coo_CorteCajaInsert _
    '    (ByVal entidad As coo_CorteCaja)

    '        dl.coo_CorteCajaInsert(entidad)
    '    End Sub

    '    Public Sub coo_CorteCajaUpdate _
    '    (ByVal entidad As coo_CorteCaja)

    '        dl.coo_CorteCajaUpdate(entidad)
    '    End Sub

    '    Public Function coo_CorteCajaArqueoSelectAll() As DataTable
    '        Return dl.coo_CorteCajaArqueoSelectAll()
    '    End Function

    '    Public Function coo_CorteCajaArqueoSelectByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      , ByVal IdDenominacion As System.Int32 _
    '      ) As coo_CorteCajaArqueo

    '        Return dl.coo_CorteCajaArqueoSelectByPK( _
    '         IdCorte _
    '         , IdDenominacion _
    '         )
    '    End Function

    '    Public Sub coo_CorteCajaArqueoDeleteByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      , ByVal IdDenominacion As System.Int32 _
    '      )

    '        dl.coo_CorteCajaArqueoDeleteByPK( _
    '         IdCorte _
    '         , IdDenominacion _
    '         )
    '    End Sub

    '    Public Sub coo_CorteCajaArqueoInsert _
    '    (ByVal entidad As coo_CorteCajaArqueo)

    '        dl.coo_CorteCajaArqueoInsert(entidad)
    '    End Sub

    '    Public Sub coo_CorteCajaArqueoUpdate _
    '    (ByVal entidad As coo_CorteCajaArqueo)

    '        dl.coo_CorteCajaArqueoUpdate(entidad)
    '    End Sub

    '    Public Function coo_DenominacionesMonedaSelectAll() As DataTable
    '        Return dl.coo_DenominacionesMonedaSelectAll()
    '    End Function

    '    Public Function coo_DenominacionesMonedaSelectByPK _
    '      (ByVal IdDenominacion As System.Int32 _
    '      ) As coo_DenominacionesMoneda

    '        Return dl.coo_DenominacionesMonedaSelectByPK( _
    '         IdDenominacion _
    '         )
    '    End Function

    '    Public Sub coo_DenominacionesMonedaDeleteByPK _
    '      (ByVal IdDenominacion As System.Int32 _
    '      )

    '        dl.coo_DenominacionesMonedaDeleteByPK( _
    '         IdDenominacion _
    '         )
    '    End Sub

    '    Public Sub coo_DenominacionesMonedaInsert _
    '    (ByVal entidad As coo_DenominacionesMoneda)

    '        dl.coo_DenominacionesMonedaInsert(entidad)
    '    End Sub

    '    Public Sub coo_DenominacionesMonedaUpdate _
    '    (ByVal entidad As coo_DenominacionesMoneda)

    '        dl.coo_DenominacionesMonedaUpdate(entidad)
    '    End Sub

    '    Public Function adm_UsuariosSelectAll() As DataTable
    '        Return dl.adm_UsuariosSelectAll()
    '    End Function

    '    Public Function adm_UsuariosSelectByPK _
    '      (ByVal IdUsuario As System.String _
    '      ) As adm_Usuarios

    '        Return dl.adm_UsuariosSelectByPK( _
    '         IdUsuario _
    '         )
    '    End Function

    '    Public Sub adm_UsuariosDeleteByPK _
    '      (ByVal IdUsuario As System.String _
    '      )

    '        dl.adm_UsuariosDeleteByPK( _
    '         IdUsuario _
    '         )
    '    End Sub

    '    Public Sub adm_UsuariosInsert _
    '    (ByVal entidad As adm_Usuarios)

    '        dl.adm_UsuariosInsert(entidad)
    '    End Sub

    '    Public Sub adm_UsuariosUpdate _
    '    (ByVal entidad As adm_Usuarios)

    '        dl.adm_UsuariosUpdate(entidad)
    '    End Sub

    '    Public Function adm_SucursalesSelectByPK _
    '      (ByVal IdSucursal As System.Int16 _
    '      ) As adm_Sucursales

    '        Return dl.adm_SucursalesSelectByPK( _
    '         IdSucursal _
    '         )
    '    End Function

    '    Public Sub adm_SucursalesDeleteByPK _
    '      (ByVal IdSucursal As System.Int16 _
    '      )

    '        dl.adm_SucursalesDeleteByPK( _
    '         IdSucursal _
    '         )
    '    End Sub




    '    Public Function coo_IsrInteresSelectAll() As DataTable
    '        Return dl.coo_IsrInteresSelectAll()
    '    End Function

    '    Public Function coo_IsrInteresSelectByPK _
    '      (ByVal IdIsr As System.Int32 _
    '      ) As coo_IsrInteres

    '        Return dl.coo_IsrInteresSelectByPK( _
    '         IdIsr _
    '         )
    '    End Function

    '    Public Sub coo_IsrInteresDeleteByPK _
    '      (ByVal IdIsr As System.Int32 _
    '      )

    '        dl.coo_IsrInteresDeleteByPK( _
    '         IdIsr _
    '         )
    '    End Sub

    '    Public Sub coo_IsrInteresInsert _
    '    (ByVal entidad As coo_IsrInteres)

    '        dl.coo_IsrInteresInsert(entidad)
    '    End Sub

    '    Public Sub coo_IsrInteresUpdate _
    '    (ByVal entidad As coo_IsrInteres)

    '        dl.coo_IsrInteresUpdate(entidad)
    '    End Sub

    '    Public Function coo_LiquidacionAportacionesSelectAll() As DataTable
    '        Return dl.coo_LiquidacionAportacionesSelectAll()
    '    End Function

    '    Public Function coo_LiquidacionAportacionesSelectByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal NumeroDoc As System.String _
    '      ) As coo_LiquidacionAportaciones

    '        Return dl.coo_LiquidacionAportacionesSelectByPK( _
    '         IdAsociado _
    '         , NumeroDoc _
    '         )
    '    End Function

    '    Public Sub coo_LiquidacionAportacionesDeleteByPK _
    '      (ByVal IdAsociado As System.Int32 _
    '      , ByVal NumeroDoc As System.String _
    '      )

    '        dl.coo_LiquidacionAportacionesDeleteByPK( _
    '         IdAsociado _
    '         , NumeroDoc _
    '         )
    '    End Sub

    '    Public Sub coo_LiquidacionAportacionesInsert _
    '    (ByVal entidad As coo_LiquidacionAportaciones)

    '        dl.coo_LiquidacionAportacionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_LiquidacionAportacionesUpdate _
    '    (ByVal entidad As coo_LiquidacionAportaciones)

    '        dl.coo_LiquidacionAportacionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_LineasSelectAll() As DataTable
    '        Return dl.coo_LineasSelectAll()
    '    End Function

    '    Public Function coo_LineasSelectByPK _
    '      (ByVal IdLinea As System.Int16 _
    '      ) As coo_Lineas

    '        Return dl.coo_LineasSelectByPK( _
    '         IdLinea _
    '         )
    '    End Function

    '    Public Sub coo_LineasDeleteByPK _
    '      (ByVal IdLinea As System.Int16 _
    '      )

    '        dl.coo_LineasDeleteByPK( _
    '         IdLinea _
    '         )
    '    End Sub

    '    Public Sub coo_LineasInsert _
    '    (ByVal entidad As coo_Lineas)

    '        dl.coo_LineasInsert(entidad)
    '    End Sub

    '    Public Sub coo_LineasUpdate _
    '    (ByVal entidad As coo_Lineas)

    '        dl.coo_LineasUpdate(entidad)
    '    End Sub

    '    Public Function coo_FuentesSelectAll() As DataTable
    '        Return dl.coo_FuentesSelectAll()
    '    End Function

    '    Public Function coo_FuentesSelectByPK _
    '      (ByVal IdFuente As System.Int16 _
    '      ) As coo_Fuentes

    '        Return dl.coo_FuentesSelectByPK( _
    '         IdFuente _
    '         )
    '    End Function

    '    Public Sub coo_FuentesDeleteByPK _
    '      (ByVal IdFuente As System.Int16 _
    '      )

    '        dl.coo_FuentesDeleteByPK( _
    '         IdFuente _
    '         )
    '    End Sub

    '    Public Sub coo_FuentesInsert _
    '    (ByVal entidad As coo_Fuentes)

    '        dl.coo_FuentesInsert(entidad)
    '    End Sub

    '    Public Sub coo_FuentesUpdate _
    '    (ByVal entidad As coo_Fuentes)

    '        dl.coo_FuentesUpdate(entidad)
    '    End Sub

    '    Public Function adm_MunicipiosSelectAll() As DataTable
    '        Return dl.adm_MunicipiosSelectAll()
    '    End Function

    '    Public Function adm_MunicipiosSelectByPK _
    '      (ByVal IdMunicipio As System.String _
    '      ) As adm_Municipios

    '        Return dl.adm_MunicipiosSelectByPK( _
    '         IdMunicipio _
    '         )
    '    End Function

    '    Public Sub adm_MunicipiosDeleteByPK _
    '      (ByVal IdMunicipio As System.String _
    '      )

    '        dl.adm_MunicipiosDeleteByPK( _
    '         IdMunicipio _
    '         )
    '    End Sub

    '    Public Sub adm_MunicipiosInsert _
    '    (ByVal entidad As adm_Municipios)

    '        dl.adm_MunicipiosInsert(entidad)
    '    End Sub

    '    Public Sub adm_MunicipiosUpdate _
    '    (ByVal entidad As adm_Municipios)

    '        dl.adm_MunicipiosUpdate(entidad)
    '    End Sub

    '    Public Function coo_SolicitudesSelectByPK(ByVal IdSolicitud As System.Int32) As coo_Solicitudes
    '        Return dl.coo_SolicitudesSelectByPK(IdSolicitud)
    '    End Function



    '    Public Function coo_SolicitudFondosSelectAll() As DataTable
    '        Return dl.coo_SolicitudFondosSelectAll()
    '    End Function

    '    Public Function coo_SolicitudFondosSelectByPK _
    '      (ByVal IdSolicitudFondo As System.Int32 _
    '      ) As coo_SolicitudFondos

    '        Return dl.coo_SolicitudFondosSelectByPK( _
    '         IdSolicitudFondo _
    '         )
    '    End Function

    '    Public Sub coo_SolicitudFondosDeleteByPK _
    '      (ByVal IdSolicitudFondo As System.Int32 _
    '      )

    '        dl.coo_SolicitudFondosDeleteByPK( _
    '         IdSolicitudFondo _
    '         )
    '    End Sub

    '    Public Sub coo_SolicitudFondosInsert _
    '    (ByVal entidad As coo_SolicitudFondos)

    '        dl.coo_SolicitudFondosInsert(entidad)
    '    End Sub

    '    Public Sub coo_SolicitudFondosUpdate _
    '    (ByVal entidad As coo_SolicitudFondos)

    '        dl.coo_SolicitudFondosUpdate(entidad)
    '    End Sub
    '    Public Function coo_SolicitudesDescuentosCuotaSelectAll() As DataTable
    '        Return dl.coo_SolicitudesDescuentosCuotaSelectAll()
    '    End Function

    '    Public Function coo_SolicitudesDescuentosCuotaSelectByPK _
    '      (ByVal IdSolicitud As System.Int32 _
    '      , ByVal Correlativo As System.Int32 _
    '      ) As coo_SolicitudesDescuentosCuota

    '        Return dl.coo_SolicitudesDescuentosCuotaSelectByPK( _
    '         IdSolicitud _
    '         , Correlativo _
    '         )
    '    End Function

    '    Public Sub coo_SolicitudesDescuentosCuotaDeleteByPK _
    '      (ByVal IdSolicitud As System.Int32 _
    '      , ByVal Correlativo As System.Int32 _
    '      )

    '        dl.coo_SolicitudesDescuentosCuotaDeleteByPK( _
    '         IdSolicitud _
    '         , Correlativo _
    '         )
    '    End Sub

    '    Public Sub coo_SolicitudesDescuentosCuotaInsert _
    '    (ByVal entidad As coo_SolicitudesDescuentosCuota)

    '        dl.coo_SolicitudesDescuentosCuotaInsert(entidad)
    '    End Sub

    '    Public Sub coo_SolicitudesDescuentosCuotaUpdate _
    '    (ByVal entidad As coo_SolicitudesDescuentosCuota)

    '        dl.coo_SolicitudesDescuentosCuotaUpdate(entidad)
    '    End Sub



    '    Public Function coo_ResolucionesSelectAll() As DataTable
    '        Return dl.coo_ResolucionesSelectAll()
    '    End Function

    '    Public Function coo_ResolucionesSelectByPK(ByVal IdSolicitud As System.Int32) As coo_Resoluciones

    '        Return dl.coo_ResolucionesSelectByPK( _
    '         IdSolicitud _
    '         )
    '    End Function

    '    Public Sub coo_ResolucionesDeleteByPK _
    '      (ByVal IdSolicitud As System.Int32 _
    '      )

    '        dl.coo_ResolucionesDeleteByPK( _
    '         IdSolicitud _
    '         )
    '    End Sub

    '    Public Sub coo_ResolucionesInsert _
    '    (ByVal entidad As coo_Resoluciones)

    '        dl.coo_ResolucionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_ResolucionesUpdate _
    '    (ByVal entidad As coo_Resoluciones)

    '        dl.coo_ResolucionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_CuentasGastosSelectAll() As DataTable
    '        Return dl.coo_CuentasGastosSelectAll()
    '    End Function

    '    Public Function coo_CuentasGastosSelectByPK(ByVal IdRubro As Integer, ByVal IdCuenta As Integer) As coo_CuentasGastos
    '        Return dl.coo_CuentasGastosSelectByPK(IdRubro, IdCuenta)
    '    End Function

    '    Public Sub coo_CuentasGastosDeleteByPK(ByVal IdRubro As Integer, ByVal IdCuenta As Integer)

    '        dl.coo_CuentasGastosDeleteByPK( _
    '         IdRubro _
    '         , IdCuenta _
    '         )
    '    End Sub

    '    Public Sub coo_CuentasGastosInsert _
    '    (ByVal entidad As coo_CuentasGastos)

    '        dl.coo_CuentasGastosInsert(entidad)
    '    End Sub

    '    Public Sub coo_CuentasGastosUpdate _
    '    (ByVal entidad As coo_CuentasGastos)

    '        dl.coo_CuentasGastosUpdate(entidad)
    '    End Sub

    '    Public Function coo_RubrosGastosSelectAll() As DataTable
    '        Return dl.coo_RubrosGastosSelectAll()
    '    End Function

    '    Public Function coo_RubrosGastosSelectByPK _
    '      (ByVal Id As System.Int32 _
    '      ) As coo_RubrosGastos

    '        Return dl.coo_RubrosGastosSelectByPK( _
    '         Id _
    '         )
    '    End Function

    '    Public Sub coo_RubrosGastosDeleteByPK _
    '      (ByVal Id As System.Int32 _
    '      )

    '        dl.coo_RubrosGastosDeleteByPK( _
    '         Id _
    '         )
    '    End Sub

    '    Public Sub coo_RubrosGastosInsert _
    '    (ByVal entidad As coo_RubrosGastos)

    '        dl.coo_RubrosGastosInsert(entidad)
    '    End Sub

    '    Public Sub coo_RubrosGastosUpdate _
    '    (ByVal entidad As coo_RubrosGastos)

    '        dl.coo_RubrosGastosUpdate(entidad)
    '    End Sub

    '    Public Function coo_SolicitudFondosRefinanciaSelectAll() As DataTable
    '        Return dl.coo_SolicitudFondosRefinanciaSelectAll()
    '    End Function

    '    Public Function coo_SolicitudFondosRefinanciaSelectByPK _
    '      (ByVal IdSolicitudFondo As System.Int32 _
    '      , ByVal Idsolicitud As System.Int32 _
    '      , ByVal IdPrestamo As System.Int32 _
    '      ) As coo_SolicitudFondosRefinancia

    '        Return dl.coo_SolicitudFondosRefinanciaSelectByPK( _
    '         IdSolicitudFondo _
    '         , Idsolicitud _
    '         , IdPrestamo _
    '         )
    '    End Function

    '    Public Sub coo_SolicitudFondosRefinanciaDeleteByPK _
    '      (ByVal IdSolicitudFondo As System.Int32 _
    '      , ByVal Idsolicitud As System.Int32 _
    '      , ByVal IdPrestamo As System.Int32 _
    '      )

    '        dl.coo_SolicitudFondosRefinanciaDeleteByPK( _
    '         IdSolicitudFondo _
    '         , Idsolicitud _
    '         , IdPrestamo _
    '         )
    '    End Sub

    '    Public Sub coo_SolicitudFondosRefinanciaInsert _
    '    (ByVal entidad As coo_SolicitudFondosRefinancia)

    '        dl.coo_SolicitudFondosRefinanciaInsert(entidad)
    '    End Sub

    '    Public Sub coo_SolicitudFondosRefinanciaUpdate _
    '    (ByVal entidad As coo_SolicitudFondosRefinancia)

    '        dl.coo_SolicitudFondosRefinanciaUpdate(entidad)
    '    End Sub

    '    Public Function coo_ActividadesSelectAll() As DataTable
    '        Return dl.coo_ActividadesSelectAll()
    '    End Function

    '    Public Function coo_ActividadesSelectByPK _
    '      (ByVal IdActividad As System.Int32 _
    '      ) As coo_Actividades

    '        Return dl.coo_ActividadesSelectByPK( _
    '         IdActividad _
    '         )
    '    End Function

    '    Public Sub coo_ActividadesDeleteByPK _
    '      (ByVal IdActividad As System.Int32 _
    '      )

    '        dl.coo_ActividadesDeleteByPK( _
    '         IdActividad _
    '         )
    '    End Sub

    '    Public Sub coo_ActividadesInsert _
    '    (ByVal entidad As coo_Actividades)

    '        dl.coo_ActividadesInsert(entidad)
    '    End Sub

    '    Public Sub coo_ActividadesUpdate _
    '    (ByVal entidad As coo_Actividades)

    '        dl.coo_ActividadesUpdate(entidad)
    '    End Sub

    '    Public Function adm_CantonesSelectAll() As DataTable
    '        Return dl.adm_CantonesSelectAll()
    '    End Function

    '    Public Function adm_CantonesSelectByPK _
    '      (ByVal IdCanton As System.String _
    '      ) As adm_Cantones

    '        Return dl.adm_CantonesSelectByPK( _
    '         IdCanton _
    '         )
    '    End Function

    '    Public Sub adm_CantonesDeleteByPK _
    '      (ByVal IdCanton As System.String _
    '      )

    '        dl.adm_CantonesDeleteByPK( _
    '         IdCanton _
    '         )
    '    End Sub

    '    Public Sub adm_CantonesInsert _
    '    (ByVal entidad As adm_Cantones)

    '        dl.adm_CantonesInsert(entidad)
    '    End Sub

    '    Public Sub adm_CantonesUpdate _
    '    (ByVal entidad As adm_Cantones)

    '        dl.adm_CantonesUpdate(entidad)
    '    End Sub
    '    Public Function pla_EstadoCivilSelectAll() As DataTable
    '        Return dl.pla_EstadoCivilSelectAll()
    '    End Function

    '    Public Function pla_EstadoCivilSelectByPK _
    '      (ByVal IdEstadoCivil As System.Int32 _
    '      ) As pla_EstadoCivil

    '        Return dl.pla_EstadoCivilSelectByPK( _
    '         IdEstadoCivil _
    '         )
    '    End Function

    '    Public Sub pla_EstadoCivilDeleteByPK _
    '      (ByVal IdEstadoCivil As System.Int32 _
    '      )

    '        dl.pla_EstadoCivilDeleteByPK( _
    '         IdEstadoCivil _
    '         )
    '    End Sub

    '    Public Sub pla_EstadoCivilInsert _
    '    (ByVal entidad As pla_EstadoCivil)

    '        dl.pla_EstadoCivilInsert(entidad)
    '    End Sub

    '    Public Sub pla_EstadoCivilUpdate _
    '    (ByVal entidad As pla_EstadoCivil)

    '        dl.pla_EstadoCivilUpdate(entidad)
    '    End Sub

    '    Public Function adm_DepartamentosSelectAll() As DataTable
    '        Return dl.adm_DepartamentosSelectAll()
    '    End Function

    '    Public Function adm_DepartamentosSelectByPK _
    '      (ByVal IdDepartamento As System.String _
    '      ) As adm_Departamentos

    '        Return dl.adm_DepartamentosSelectByPK( _
    '         IdDepartamento _
    '         )
    '    End Function

    '    Public Sub adm_DepartamentosDeleteByPK _
    '      (ByVal IdDepartamento As System.String _
    '      )

    '        dl.adm_DepartamentosDeleteByPK( _
    '         IdDepartamento _
    '         )
    '    End Sub

    '    Public Sub adm_DepartamentosInsert _
    '    (ByVal entidad As adm_Departamentos)

    '        dl.adm_DepartamentosInsert(entidad)
    '    End Sub

    '    Public Sub adm_DepartamentosUpdate _
    '    (ByVal entidad As adm_Departamentos)

    '        dl.adm_DepartamentosUpdate(entidad)
    '    End Sub
    '    Public Function coo_ProfesionesSelectAll() As DataTable
    '        Return dl.coo_ProfesionesSelectAll()
    '    End Function

    '    Public Function coo_ProfesionesSelectByPK _
    '      (ByVal IdProfesion As System.Int16 _
    '      ) As coo_Profesiones

    '        Return dl.coo_ProfesionesSelectByPK( _
    '         IdProfesion _
    '         )
    '    End Function

    '    Public Sub coo_ProfesionesDeleteByPK _
    '      (ByVal IdProfesion As System.Int16 _
    '      )

    '        dl.coo_ProfesionesDeleteByPK( _
    '         IdProfesion _
    '         )
    '    End Sub

    '    Public Sub coo_ProfesionesInsert _
    '    (ByVal entidad As coo_Profesiones)

    '        dl.coo_ProfesionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_ProfesionesUpdate _
    '    (ByVal entidad As coo_Profesiones)

    '        dl.coo_ProfesionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_PignoracionesSelectAll() As DataTable
    '        Return dl.coo_PignoracionesSelectAll()
    '    End Function

    '    Public Function coo_PignoracionesSelectByPK _
    '      (ByVal IdPignoracion As System.Int32 _
    '      ) As coo_Pignoraciones

    '        Return dl.coo_PignoracionesSelectByPK( _
    '         IdPignoracion _
    '         )
    '    End Function

    '    Public Sub coo_PignoracionesDeleteByPK _
    '      (ByVal IdPignoracion As System.Int32 _
    '      )

    '        dl.coo_PignoracionesDeleteByPK( _
    '         IdPignoracion _
    '         )
    '    End Sub

    '    Public Sub coo_PignoracionesInsert _
    '    (ByVal entidad As coo_Pignoraciones)

    '        dl.coo_PignoracionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_PignoracionesUpdate _
    '    (ByVal entidad As coo_Pignoraciones)

    '        dl.coo_PignoracionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_GarantiasCuentaPignoradaSelectAll() As DataTable
    '        Return dl.coo_GarantiasCuentaPignoradaSelectAll()
    '    End Function

    '    Public Function coo_GarantiasCuentaPignoradaSelectByPK _
    '      (ByVal IdSolicitud As System.Int32 _
    '      , ByVal IdGarantia As System.Int32 _
    '      ) As coo_GarantiasCuentaPignorada

    '        Return dl.coo_GarantiasCuentaPignoradaSelectByPK( _
    '         IdSolicitud _
    '         , IdGarantia _
    '         )
    '    End Function

    '    Public Sub coo_GarantiasCuentaPignoradaDeleteByPK _
    '      (ByVal IdSolicitud As System.Int32 _
    '      , ByVal IdGarantia As System.Int32 _
    '      )

    '        dl.coo_GarantiasCuentaPignoradaDeleteByPK( _
    '         IdSolicitud _
    '         , IdGarantia _
    '         )
    '    End Sub

    '    Public Sub coo_GarantiasCuentaPignoradaInsert _
    '    (ByVal entidad As coo_GarantiasCuentaPignorada)

    '        dl.coo_GarantiasCuentaPignoradaInsert(entidad)
    '    End Sub

    '    Public Sub coo_GarantiasCuentaPignoradaUpdate _
    '    (ByVal entidad As coo_GarantiasCuentaPignorada)

    '        dl.coo_GarantiasCuentaPignoradaUpdate(entidad)
    '    End Sub

    '    Public Function coo_CorteCajaChequesSelectAll() As DataTable
    '        Return dl.coo_CorteCajaChequesSelectAll()
    '    End Function

    '    Public Function coo_CorteCajaChequesSelectByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      , ByVal NumeroCuenta As System.String _
    '      , ByVal NumeroCheque As System.String _
    '      ) As coo_CorteCajaCheques

    '        Return dl.coo_CorteCajaChequesSelectByPK( _
    '         IdCorte _
    '         , NumeroCuenta _
    '         , NumeroCheque _
    '         )
    '    End Function

    '    Public Sub coo_CorteCajaChequesDeleteByPK _
    '      (ByVal IdCorte As System.Int32 _
    '      , ByVal NumeroCuenta As System.String _
    '      , ByVal NumeroCheque As System.String _
    '      )

    '        dl.coo_CorteCajaChequesDeleteByPK( _
    '         IdCorte _
    '         , NumeroCuenta _
    '         , NumeroCheque _
    '         )
    '    End Sub

    '    Public Sub coo_CorteCajaChequesInsert _
    '    (ByVal entidad As coo_CorteCajaCheques)

    '        dl.coo_CorteCajaChequesInsert(entidad)
    '    End Sub

    '    Public Sub coo_CorteCajaChequesUpdate _
    '    (ByVal entidad As coo_CorteCajaCheques)

    '        dl.coo_CorteCajaChequesUpdate(entidad)
    '    End Sub

    '    Public Function adm_SucursalesSelectAll() As DataTable
    '        Return dl.adm_SucursalesSelectAll()
    '    End Function

    '    Public Function adm_SucursalesSelectByPK _
    '      (ByVal IdSucursal As System.Int32 _
    '      ) As adm_Sucursales

    '        Return dl.adm_SucursalesSelectByPK( _
    '         IdSucursal _
    '         )
    '    End Function

    '    Public Sub adm_SucursalesDeleteByPK _
    '      (ByVal IdSucursal As System.Int32 _
    '      )

    '        dl.adm_SucursalesDeleteByPK( _
    '         IdSucursal _
    '         )
    '    End Sub

    '    Public Sub adm_SucursalesInsert _
    '    (ByVal entidad As adm_Sucursales)

    '        dl.adm_SucursalesInsert(entidad)
    '    End Sub

    '    Public Sub adm_SucursalesUpdate _
    '    (ByVal entidad As adm_Sucursales)

    '        dl.adm_SucursalesUpdate(entidad)
    '    End Sub

    '    Public Function coo_LiquidacionesSelectAll() As DataTable
    '        Return dl.coo_LiquidacionesSelectAll()
    '    End Function

    '    Public Function coo_LiquidacionesSelectByPK _
    '      (ByVal IdComprobante As System.Int32 _
    '      ) As coo_Liquidaciones

    '        Return dl.coo_LiquidacionesSelectByPK( _
    '         IdComprobante _
    '         )
    '    End Function

    '    Public Sub coo_LiquidacionesDeleteByPK _
    '      (ByVal IdComprobante As System.Int32 _
    '      )

    '        dl.coo_LiquidacionesDeleteByPK( _
    '         IdComprobante _
    '         )
    '    End Sub

    '    Public Sub coo_LiquidacionesInsert _
    '    (ByVal entidad As coo_Liquidaciones)

    '        dl.coo_LiquidacionesInsert(entidad)
    '    End Sub

    '    Public Sub coo_LiquidacionesUpdate _
    '    (ByVal entidad As coo_Liquidaciones)

    '        dl.coo_LiquidacionesUpdate(entidad)
    '    End Sub

    '    Public Function coo_LiquidacionesDetalleSelectAll() As DataTable
    '        Return dl.coo_LiquidacionesDetalleSelectAll()
    '    End Function

    '    Public Function coo_LiquidacionesDetalleSelectByPK _
    '      (ByVal IdComprobante As System.Int32 _
    '      , ByVal IdDetalle As System.Int32 _
    '      ) As coo_LiquidacionesDetalle

    '        Return dl.coo_LiquidacionesDetalleSelectByPK( _
    '         IdComprobante _
    '         , IdDetalle _
    '         )
    '    End Function

    '    Public Sub coo_LiquidacionesDetalleDeleteByPK _
    '      (ByVal IdComprobante As System.Int32 _
    '      , ByVal IdDetalle As System.Int32 _
    '      )

    '        dl.coo_LiquidacionesDetalleDeleteByPK( _
    '         IdComprobante _
    '         , IdDetalle _
    '         )
    '    End Sub

    '    Public Sub coo_LiquidacionesDetalleInsert _
    '    (ByVal entidad As coo_LiquidacionesDetalle)

    '        dl.coo_LiquidacionesDetalleInsert(entidad)
    '    End Sub

    '    Public Sub coo_LiquidacionesDetalleUpdate _
    '    (ByVal entidad As coo_LiquidacionesDetalle)

    '        dl.coo_LiquidacionesDetalleUpdate(entidad)
    '    End Sub


    '#End Region

#Region "NonGeneratedCode"
    Public Function coo_spVerificaUsuarioCajero(ByVal Usuario As String, ByVal Contrasenia As String) As Integer
        Return dl.coo_spVerificaUsuarioCajero(Usuario, Contrasenia)
    End Function
    Public Sub coo_spLogUsuario(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal Usuario As String)
        dl.coo_spLogUsuario(IdSucursal, Fecha, Usuario)
    End Sub

    Public Sub AperturarCaja(ByVal IdSucursal As Integer, ByVal FechaContable As Date, ByVal Usuario As String)
        dl.AperturarCaja(IdSucursal, FechaContable, Usuario)
    End Sub
    Public Function CierreCaja(ByVal IdSucursal As Integer, ByVal fecha As Date, ByVal CreadoPor As String) As DataTable
        Return dl.CierreCaja(IdSucursal, fecha, CreadoPor)
    End Function
    Public Function ObtenerUltimoID(ByVal tabla As String, ByVal columna As String) As Integer
        Return dl.ObtenerUltimoID(tabla, columna)
    End Function


    Public Function IsCajaAbierta(ByVal IdSucursal As Integer, ByVal FechaContable As Date, ByVal usuario As String) As Boolean
        Return dl.IsCajaAbierta(IdSucursal, FechaContable, usuario)
    End Function
    Public Function GetFechaContable(ByVal IdSucursal As Integer) As Date
        Return dl.GetFechaContable(IdSucursal)
    End Function
    Public Function rptLiquidacionAportacion(ByVal NumeroDoc As String, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptLiquidacionAportacion(NumeroDoc, IdAsociado)
    End Function
    Public Function GetSucursal(ByVal IdUsuario As String) As Integer
        Return dl.GetSucursal(IdUsuario)
    End Function

    Public Function GetNombreSucursal(ByVal IdSucursal As Integer) As String
        Return dl.GetNombreSucursal(IdSucursal)
    End Function

    Public Function GetDiasMora(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Integer
        Return dl.GetDiasMora(IdPrestamo, HastaFecha)
    End Function

    Public Function ObtenerAfiliaciones(ByVal IdSucursal As Integer) As DataTable
        Return dl.ObtenerAfiliaciones(IdSucursal)
    End Function

    Public Function ObtenerLiquidacionesPendientes(ByVal IdSucursal As Integer) As DataTable
        Return dl.ObtenerLiquidacionesPendientes(IdSucursal)
    End Function

    Public Function ObtenerDetalleLiquidacion(ByVal IdLiquidacion As Integer, ByVal CreadoPor As String) As DataTable
        Return dl.ObtenerDetalleLiquidacion(IdLiquidacion, CreadoPor)
    End Function

    Public Function ObtenerSaldoPendienteLiquidacion(ByVal IdCuentaGasto As Integer, ByVal Fecha As DateTime) As Decimal
        Return dl.ObtenerSaldoPendienteLiquidacion(IdCuentaGasto, Fecha)
    End Function


    Public Function ObtenerAfiliacionesAplicadas(ByVal IdSucursal As Integer, ByVal FechaContable As DateTime) As DataTable
        Return dl.ObtenerAfiliacionesAplicadas(IdSucursal, FechaContable)
    End Function

    Public Sub ActualizarEstadoAfiliacion(ByVal IdAsociado As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal IdFormaPago As Integer)
        dl.ActualizarEstadoAfiliacion(IdAsociado, Fecha, IdUsuario, IdFormaPago)
    End Sub

    Public Sub ActualizarEstadoLiquidacion(ByVal IdComprobante As Integer)
        dl.ActualizarEstadoLiquidacion(IdComprobante)
    End Sub

    Public Sub RevertirEstadoAfiliacion(ByVal IdAsociado As Integer)
        dl.RevertirEstadoAfiliacion(IdAsociado)
    End Sub

    Public Function ObtenerDocAutorizado(ByVal IdAutorizado As String) As String
        Return dl.ObtenerDocAutorizado(IdAutorizado)
    End Function

    Public Function IsPrestamoCancelado(ByVal IdPrestamo As Integer) As Boolean
        Return dl.IsPrestamoCancelado(IdPrestamo)
    End Function

    Public Function GetIdCuentaAhorro(ByVal NroCta As String) As Integer
        Return dl.GetIdCuentaAhorro(NroCta)
    End Function
    Public Function coo_UltMovAhorroSelectBy(ByVal IdCuenta As Integer) As coo_UltMovAhorro
        Return dl.coo_UltMovAhorroSelectBy(IdCuenta)
    End Function

    Public Function coo_CapitalizacionAhorroCancelacion(ByVal IdCuenta As Integer, ByVal Fecha As DateTime, ByVal Tasa As Decimal) As coo_CapitalizacionAhorro
        Return dl.coo_CapitalizacionAhorroCancelacion(IdCuenta, Fecha, Tasa)
    End Function


    'Public Function coo_GetMontoAperturaSelectBy(ByVal IdCuenta As Integer) As coo_GetAperturaCuenta
    '    Return dl.coo_GetMontoAperturaSelectBy(IdCuenta)
    'End Function

    Public Function GetUltMovAfilia() As Integer
        Return dl.GetUltMovAfilia
    End Function
    Public Function GetUltFechaAporta(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Return dl.GetUltFechaAporta(IdAsociado)
    End Function
    Public Function GetUltFechaAyudaFuneraria(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Return dl.GetUltFechaAyudaFuneraria(IdAsociado)
    End Function

    Public Function GetUltLineaAporta(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltLineaAporta(IdAsociado)
    End Function
    Public Function GetSaldoAhorro(ByVal IdCuenta As Integer) As Decimal
        Return dl.GetSaldoAhorro(IdCuenta)
    End Function

    Public Function GetUltMovAhorro(ByVal IdCuenta As Integer) As Integer
        Return dl.GetUltMovAhorro(IdCuenta)
    End Function

    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Return dl.GetUltMovPrestamo(IdPrestamo)
    End Function
    Public Function UltMovReferencia(ByVal Numero As String, ByVal IDPrestamo As Integer) As Integer
        Return dl.UltMovReferencia(Numero, IDPrestamo)
    End Function
    Public Function GetSaldoAporta(ByVal IdAsociado As Integer) As Decimal
        Return dl.GetSaldoAporta(IdAsociado)
    End Function
    Public Function GetSaldoAyudaFuneraria(ByVal IdAsociado As Integer) As Decimal
        Return dl.GetSaldoAyudaFuneraria(IdAsociado)
    End Function
    Public Function GetUltMovAporta(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltMovAporta(IdAsociado)
    End Function
    Public Function GetUltMovFune(ByVal IdAsociado As Integer) As Integer
        Return dl.GetUltMovFune(IdAsociado)
    End Function
    Public Function AplicarPago(ByVal clsPrestamo As Prestamo, ByVal entAhorro As coo_CuentasAhorroMov, _
        ByVal entAportacion As coo_Aportaciones, ByVal IdSucursal As String) As String

        Dim elPagoDetalle As New coo_PrestamosDetalle

        CargaEntidadDetallePago(clsPrestamo, elPagoDetalle)

        Return dl.AplicarPago(elPagoDetalle, entAhorro, entAportacion, IdSucursal)
    End Function

    Private Sub CargaEntidadDetallePago(ByRef clsPrestamo As Prestamo, ByRef elpagodetalle As coo_PrestamosDetalle)
        With elpagodetalle
            If clsPrestamo.PagoActual.FormaPago = 4 Then
                .TipoAplicacion = 2
            Else
                .TipoAplicacion = 1
            End If
            .CapitalPagado = clsPrestamo.PagoActual.ImporteCapital
            .CreadoPor = clsPrestamo.CodUsuario
            .ComisionCobranza = clsPrestamo.PagoActual.ImporteComisionCobranza
            .Gestion = clsPrestamo.PagoActual.ImporteGestion
            .CuotaAhorro = clsPrestamo.PagoActual.ImporteCuotaAhorro
            .CuotaAportacion = clsPrestamo.PagoActual.ImporteCuotaAportacion
            .DiasCalcInteres = clsPrestamo.PagoActual.DiasCalculoInteres
            .DiasCalcMora = clsPrestamo.PagoActual.DiasCalculoMora
            .Fecha = clsPrestamo.FechaAmortizacion
            .FechaContable = clsPrestamo.FechaContable
            .FechaHoraCreacion = Now
            .IdFormaPago = clsPrestamo.PagoActual.FormaPago
            .IdMov = clsPrestamo.Pagos.Count
            .IdPrestamo = clsPrestamo.IdPrestamo
            .IdSucursal = clsPrestamo.IdSucursal
            .ImportePagado = clsPrestamo.ImporteAbonoPago
            .InteresMoraPagado = clsPrestamo.PagoActual.ImporteMora
            .InteresMoraPendiente = clsPrestamo.PagoActual.ImporteDeudaMora
            .TasaInteres = clsPrestamo.TasaInteresAnual
            .TasaInteresMora = clsPrestamo.TasaInteresMora
            'If .InteresMoraPendiente > 0 Then
            '    .InteresMoraPagadoHasta = DateAdd(DateInterval.Day, clsPrestamo.PagoActual.DiasDeudaMora, clsPrestamo.CuotaBaseMora.FechaPago)
            'Else
            '    .InteresMoraPagadoHasta = clsPrestamo.FechaAmortizacion
            'End If

            .InteresPagado = clsPrestamo.PagoActual.ImporteInteres
            .InteresPendiente = clsPrestamo.PagoActual.ImporteDeudaInteres
            'If .InteresPendiente > 0 Then
            '    .InteresPagadoHasta = DateAdd(DateInterval.Day, clsPrestamo.PagoActual.DiasDeudaInteres, clsPrestamo.UltimoPago.Fecha)
            'Else
            '    .InteresPagadoHasta = clsPrestamo.FechaAmortizacion
            'End If

            .ManejoPagado = clsPrestamo.PagoActual.ImporteCuotaManejo
            .ManejoPendiente = clsPrestamo.PagoActual.ImporteDeudaManejo

            'TODO asaber que es numero
            .Numero = clsPrestamo.PagoActual.NumeroComprobante
            .ReferenciaPago = clsPrestamo.PagoActual.ReferenciaPago

            .OtrosPagado = clsPrestamo.PagoActual.ImporteCuotaOtros
            .OtrosPendiente = clsPrestamo.PagoActual.ImporteDeudaOtros

            .SaldoCapital = clsPrestamo.PagoActual.ImporteSaldo
            .ValorSeguroPagado = clsPrestamo.PagoActual.ImporteCuotaSeguro
            .ValorSeguroPendiente = clsPrestamo.PagoActual.ImporteDeudaSeguro
        End With

    End Sub

    Public Function rptHistorialPrestamo(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal InlcuirCancelados As Boolean) As DataTable
        Return dl.rptHistorialPrestamo(IdAsociado, Fecha, InlcuirCancelados)
    End Function

    Public Function rptEstadoCuentaAportacion(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptEstadoCuentaAportacion(IdAsociado, Fecha)
    End Function

    Public Function rptDatosAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptDatosAsociado(IdAsociado, Fecha)
    End Function

    Public Function rptListadoCuentaAhorroAsociado(ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return dl.rptListadoCuentaAhorroAsociado(HastaFecha, IdAsociado)
    End Function

    Public Function cnsAsociados(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_Asociados", "", "IdAsociado", "Numero", "Nombres", "Apellidos", "Telefonos", "TelefonoTrabajo")
        forma.text = "Consulta de Asociados"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function coo_PrestamosSelectByNumero _
(ByVal NumeroPrestamo As System.String _
) As coo_Prestamos

        Return dl.coo_PrestamosSelectByNumero( _
         NumeroPrestamo _
         )
    End Function

    Public Function rptEstadoCuentaPrestamo(ByVal NumeroPrestamo As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptEstadoCuentaPrestamo(NumeroPrestamo, HastaFecha)
    End Function

    Public Function rptFiadores(ByVal IdSolicitud As Integer) As DataTable
        Return dl.rptFiadores(IdSolicitud)
    End Function

    Public Function rptCorteCajaIngresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteCajaIngresos(IdSucursal, IdUsuario, HastaFecha)
    End Function

    Public Function rptCorteCajaEgresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptCorteCajaEgresos(IdSucursal, IdUsuario, HastaFecha)
    End Function


    Public Function ConsultaPrestamos(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaPrestamos()
        'forma.PrimaryKey = "IdCuenta"
        forma.text = "Consulta de Prestamos"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function rptMovimientoCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptMovimientoCuentaAhorro(IdCuenta, DesdeFecha, HastaFecha)
    End Function

    Public Function rptCorteCaja(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptCorteCaja(IdSucursal, HastaFecha, IdUsuario)
    End Function

    Public Function rptIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return dl.rptIngresosEgresos(IdSucursal, DesdeFecha, HastaFecha, IdUsuario)
    End Function

    Public Function ExisteSolicitudPrestamo(ByVal IdSolicitud As Integer) As String
        Return dl.ExisteSolicitudPrestamo(IdSolicitud)
    End Function

    Public Function ValorChequesDesembolso(ByVal IdSolicitud As Integer) As Decimal
        Return dl.ValorChequesDesembolso(IdSolicitud)
    End Function

    Public Function ValorPapeleriaDesembolso(ByVal IdSolicitudFondo As Integer) As Decimal
        Return dl.ValorPapeleriaDesembolso(IdSolicitudFondo)
    End Function

    Public Function ValorFPP(ByVal IdSolicitudFondo As Integer) As Decimal
        Return dl.ValorFPP(IdSolicitudFondo)
    End Function


    Public Function ConsultaCuentaAhorro(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaCuentaAhorro()
        'forma.PrimaryKey = "IdCuenta"
        forma.text = "Consulta de Cuentas de Ahorro"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Sub coo_FormasPagoPrestamo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_PrestamoFormaPago", "IdFormaPago", "Nombre", "", sTipoSelect)
    End Sub

    Public Function InsertaCorteCaja(ByRef entCorteCaja As coo_CorteCaja _
, ByRef entArqueo As List(Of coo_CorteCajaArqueo), ByRef entCheques As List(Of coo_CorteCajaCheques)) As String
        Return dl.InsertaCorteCaja(entCorteCaja, entArqueo, entCheques)
    End Function

    Public Function coo_CorteCajaSelectFecha _
      (ByVal Fecha As System.DateTime, ByVal Usuario As System.String _
      ) As coo_CorteCaja
        Return dl.coo_CorteCajaSelectFecha( _
         Fecha, Usuario _
         )
    End Function


    Public Function coo_CorteCajaArqueoSelectFecha _
      (ByVal IdCorte As System.Int32 _
      ) As coo_CorteCajaArqueo

        Return dl.coo_CorteCajaArqueoSelectFecha( _
         IdCorte _
         )
    End Function

    Public Function ExisteComprobanteAportacion(ByVal Numero As String) As String
        Return dl.ExisteComprobanteAportacion(Numero)
    End Function
    Public Function ExisteComprobanteAyudaFune(ByVal Numero As String) As String
        Return dl.ExisteComprobanteAyudaFune(Numero)
    End Function

    Public Function ExisteComprobanteRemision(ByVal Numero As String, ByVal IdSucursal As Integer) As String
        Return dl.ExisteComprobanteRemision(Numero, IdSucursal)
    End Function

    Public Function ExisteComprobanteRequisicion(ByVal Numero As String, ByVal IdSucursal As Integer) As String
        Return dl.ExisteComprobanteRequisicion(Numero, IdSucursal)
    End Function

    Public Function IdMovComprobanteIngreso(ByVal Numero As String, ByVal Prefijo As String) As Integer
        Return dl.IdMovComprobanteIngreso(Numero, Prefijo)
    End Function

    Public Function IdMovComprobanteEgreso(ByVal Numero As String) As Integer
        Return dl.IdMovComprobanteEgreso(Numero)
    End Function

    'Public Function ExisteComprobanteIngreso(ByVal Numero As String, ByVal Prefijo As String) As Integer
    '    Return dl.ExisteComprobanteIngreso(Numero, Prefijo)
    'End Function

    Public Function ExisteComprobanteEgreso(ByVal Numero As String) As String
        Return dl.ExisteComprobanteEgreso(Numero)
    End Function

    Public Function ExisteComprobantePago(ByVal Numero As String) As String
        Return dl.ExisteComprobantePago(Numero)
    End Function

    Public Function ExisteComprobanteDeposito(ByVal Numero As String) As String
        Return dl.ExisteComprobanteDeposito(Numero)
    End Function

    Public Function ExisteComprobanteRetiro(ByVal Numero As String) As String
        Return dl.ExisteComprobanteRetiro(Numero)
    End Function
    Public Function SolicitudRetiro(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.SolicitudRetiro(IdAsociado, Fecha)
    End Function
    Function ObtieneParametros() As DataTable
        Return dl.ObtieneParametros
    End Function

    Function rptFacturaPopular(ByVal IdSucursal As Integer, ByVal idformaPago As Integer, ByVal Fecha As DateTime) As DataTable
        Return dl.rptFacturaPopular(IdSucursal, idformaPago, Fecha)
    End Function

    Public Function ConsultaSolicitudFondos(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaSolicitudFondos()
        'forma.PrimaryKey = "IdSolicitudFondo"
        forma.text = "Consulta de Solicitud de Fondos"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function coo_InsertarLiquidaciones(ByVal entLiquidacion As coo_Liquidaciones, ByVal Detalle As List(Of coo_LiquidacionesDetalle)) As String
        Return dl.coo_InsertarLiquidacion(entLiquidacion, Detalle)
    End Function

#End Region
End Class
