Imports DBCoopDL
Public Class CombosBLL

    Dim dl As New CombosDLL
    Public Sub adm_Sucursales(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Sucursales", "IdSucursal", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub adm_Departamentos(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Departamentos", "IdDepartamento", "Nombre", "")
    End Sub

    Public Sub adm_Municipios(ByVal combo As Object, ByVal IdDepartamento As String)
        Dim sCondic As String = String.Format("IdDepartamento='{0}'", IdDepartamento)
        dl.CargaCombo(combo, "adm_Municipios", "IdMunicipio", "Nombre", sCondic)
    End Sub

    Public Sub adm_Rubros(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_RubrosGastos", "Id", "Nombre", "")
    End Sub
    Public Sub pre_TiposAlerta(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'PROCESO_ALERTA'", sTipoSelect)
    End Sub
    'Public Sub adm_Cantones(ByVal combo As Object, ByVal sTipoSelect As String)
    '    dl.CargaCombo(combo, "Adm_Cantones", "IdCanton", "Nombre", "", sTipoSelect)
    'End Sub

    Public Sub adm_Cantones(ByVal combo As Object, ByVal IdMunicipio As String, ByVal sTipoSelect As String)
        Dim sCondic As String
        If IdMunicipio = "" Then
            sCondic = ""
        Else
            sCondic = String.Format("IdMunicipio='{0}'", IdMunicipio)
        End If

        dl.CargaCombo(combo, "adm_Cantones", "IdCanton", "Nombre", sCondic, sTipoSelect)
    End Sub

    Public Sub adm_Sexo(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'SEXO'")
    End Sub

    Public Sub adm_TipoImpuesto(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_IMPUESTO'")
    End Sub


    Public Sub adm_TipoUsuario(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_USUARIO'")
    End Sub

    Public Sub adm_CartaCobro(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'CARTA_COBRO'", sTipoSelect)
    End Sub

    Public Sub adm_TiposModulo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_MODULO'", sTipoSelect)
    End Sub


    Public Sub adm_TipoTrabajo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_TRABAJO'", sTipoSelect)
    End Sub

    Public Sub adm_AporteCapitalizacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'CAPITALIZACION'", sTipoSelect)
    End Sub

    Public Sub adm_EstadoSocio(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_ESTADO'", sTipoSelect)
    End Sub

    Public Sub adm_TiposContratacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_TIPO_CONTRATACION'", sTipoSelect)
    End Sub
    Public Sub adm_TipoVivienda(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_TIPO_VIVIENDA'", sTipoSelect)
    End Sub
    Public Sub adm_TiposPlanilla(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_TIPOS_PLANILLA'", sTipoSelect)
    End Sub

    Public Sub adm_TipoArchivo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_ARCHIVO'", sTipoSelect)
    End Sub

    Public Sub adm_TiposLinea(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPOS_LINEAS'", sTipoSelect)
    End Sub
    Public Sub adm_TiposDescuentos(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_DESCUENTOS_TIP'", sTipoSelect)
    End Sub
    Public Sub adm_TipoHipoteca(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_HIPOTECA'", sTipoSelect)
    End Sub

    Public Sub adm_TipoContratacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'CONTRATACION'", sTipoSelect)
    End Sub

    Public Sub adm_EstadoSolicitud(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'SOLICITUDES_ESTADO'", sTipoSelect)
    End Sub
    Public Sub adm_TipoPlazo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_PLAZO'", sTipoSelect)
    End Sub
    Public Sub adm_ReporteAseguradora(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_ASEGURADORA'", sTipoSelect)
    End Sub


    Public Sub adm_Usuarios(ByVal combo As Object, ByVal sCondicion As String, ByVal sTipoSelect As String)
        dl.CargaComboCaracter(combo, "adm_Usuarios", "IdUsuario", "Nombre", sCondicion, sTipoSelect)
    End Sub

    Public Sub aso_TiposRelacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_TIPO_RELACION'", sTipoSelect)
    End Sub
    Public Sub aso_TipoReporteTelefonia(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASO_RETELEFONIA'")
    End Sub

    Public Sub preTipoMovimientoCaja(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_MOVIMIENTO'")
    End Sub

    Public Sub coo_TipoCalculoDeduccion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_CALCULO'", sTipoSelect)
    End Sub
    Public Sub coo_TipoReporeAportacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'ASOCIADOS_DESCUENTOS_TIP' and Id in (1,2)", sTipoSelect)
    End Sub
    Public Sub coo_UbicacionesAsociados(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_UbicacionesAsociados", "IdUbicacion", "Nombre", "", sTipoSelect)
    End Sub


#Region "Aportacion"
    Public Sub coo_TiposDocumento(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_TipoDocumento", "IdTipo", "Nombre", "")
    End Sub
    Public Sub coo_Profesiones(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_Profesiones", "IdProfesion", "Nombre", "")
    End Sub
    Public Sub coo_RubroActividades(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_RubrosActividades", "IdRubro", "Nombre", "")
    End Sub
    Public Sub coo_Actividades(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_Actividades", "IdActividad", "Nombre", sTipoSelect)
    End Sub
    Public Sub coo_FormasPagoCaja(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_FormasPagoCaja", "IdFormaPago", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub coo_TipoRetiro(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "MODULO='ASOCIADOS_TIPO_RETIRO'", sTipoSelect)
    End Sub
    Public Sub coo_compania(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "MODULO='ASO_COMPANIATELEFONIA'")
    End Sub
    Public Sub coo_TipoAportacion(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_TiposAportacion", "IdTipo", "Nombre", "")
    End Sub
#End Region

#Region "Ahorros"
    Public Sub coo_TipoCuentaAhorro(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_AHORRO'", sTipoSelect)
    End Sub
    Public Sub coo_TiposCuenta(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposCuentaAhorro", "IdTipo", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub coo_TiposCuentaPlazo(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposCuentaAhorro", "IdTipo", "Nombre", "TipoAhorro=2 OR TipoAhorro=3 ", sTipoSelect)
    End Sub
#End Region

#Region "Prestamos"
    Public Sub coo_Lineas(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_Lineas", "IdLinea", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_LineasEfectivo(ByVal combo As Object, ByVal sCondicion As String, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_Lineas", "IdLinea", "Nombre", sCondicion, sTipoSelect)
    End Sub

    Public Sub coo_PrestamosClasificacion(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_PrestamosClasificacion", "IdClasificacion", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub coo_GarantiasFiador(ByVal combo As Object, ByVal sCondicion As String, ByVal sTipoSelect As String)
        dl.CargaComboFiador(combo, "coo_GarantiasFiador", "IdGarantia", "NombresApellidos", sCondicion, sTipoSelect)
    End Sub

    Public Sub coo_TiposCartera(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposCartera", "IdTipoCartera", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub coo_Tecnicos(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_Tecnicos", "IdTecnico", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_Fuentes(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_Fuentes", "IdFuente", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_RubrosActividades(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_RubrosActividades", "IdRubro", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_TipoCredito(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposPrestamo", "IdTipoPrestamo", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_TiposGarantia(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposGarantia", "IdTipo", "Nombre", "", sTipoSelect)
    End Sub
#End Region
#Region "Caja"
    Public Sub cooPtmoFmaPago(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_FormasPagoCaja", "IdFormaPago", "Nombre", "")
    End Sub
#End Region
    Public Sub cooTipoComprobanteIngreso(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'OTROS_INGRESOS'")
    End Sub
    Public Sub coo_TiposMovimientoCaja(ByVal Combo As Object, ByVal condicion As String)
        dl.CargaCombo(Combo, "coo_TiposMovimientoCaja", "IdTipo", "Nombre", condicion, "")
    End Sub
    Public Sub cooTipoOperacionCaja(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'OPERACION_CAJA'")
    End Sub
    Public Sub cooTipoDesembolso(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_DESEMBOLSO'")
    End Sub
    Public Sub coo_AgentesRemesa(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_AgentesRemesa", "IdAgente", "Nombre", "", "NINGUNO")
    End Sub
    Public Sub cooTipoDocumento(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_TipoDocumento", "IdTipo", "Nombre", "")
    End Sub
    Public Sub cooAutorizadoCuenta(ByVal combo As Object, ByVal condicion As String)
        dl.CargaCombo(combo, "coo_CuentasAhorroAutorizado", "IdAutorizado", "Nombre", condicion, "NINGUNO")
    End Sub
    Public Sub cooTipoAportacion(ByVal combo As Object)
        dl.CargaCombo(combo, "coo_TiposAportacion", "IdTipo", "Nombre", "")
    End Sub
#Region "Contabilidad"
    Public Sub conTiposPartida(ByVal combo As Object, Optional ByVal sTipoSelect As String = "")
        dl.CargaLookUpEdit(combo, "con_TiposPartida", "IdTipo", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub conTiposCuentaCierre(ByVal combo As Object)
        dl.CargaCombo(combo, "con_Cuentas", "IdCuenta", "Nombre", "Nivel=2 and CargarComo in (4,5)", "")
    End Sub
#End Region
#Region "Bancos"
    Public Sub banCuentasBancarias(ByVal combo As Object)
        dl.CargaCombo(combo, "ban_CuentasBancarias", "IdCuentaBancaria", "RTRIM(Nombre)+' - '+NumeroCuenta Nombre", "")
    End Sub
    Public Sub banTiposTransaccion(ByVal combo As Object, Optional ByVal sTipoSelect As String = "")
        dl.CargaCombo(combo, "ban_TiposTransaccion", "IdTipo", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub Ban_CargoAbono(ByVal Combo As Object)
        dl.CargaCombo(Combo, "adm_Listas", "Id", "Nombre", "Modulo = 'BAN'")
    End Sub

#End Region


#Region "Indicadores"
    Public Sub col_Variables(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "col_Variables", "IdVariable", "Nombre", "", sTipoSelect)
    End Sub

    Public Sub col_Indicadores(ByVal combo As Object, ByVal IdVariable As Integer)
        Dim sCondic As String = String.Format("IdVariable='{0}'", IdVariable)
        dl.CargaCombo(combo, "col_Indicadores", "IdIndicador", "Nombre", sCondic)
    End Sub

    Public Sub col_Parametros(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "col_parametros", "IdParametro", "Nombre", "", sTipoSelect)
    End Sub

#End Region

    Public Sub adm_EstadoCivil(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo='ADM_ESTADO_CIVIL'", "")
    End Sub

    Public Sub adm_TipoOperacion(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'TIPO_NUMERARIO'")
    End Sub


    Public Sub adm_TiposOperacionNumerario(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_TiposOperacionNumerario", "IdTipoOperacion", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub com_TiposComprobante(ByVal combo As Object, Optional ByVal sTipoSelect As String = "")
        'COMBO ESPECIAL PARA MOSTRAR LOS TIPOS DE COMPROBANTE QUE APLICAN PARA EL MODULO DE COMPRAS
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'COMPRAS_TIPO_DOCUMENTO'")
    End Sub
    Public Sub coo_TiposLiquidacion(ByVal combo As Object)
        dl.CargaCombo(combo, "adm_Listas", "Id", "Nombre", "Modulo = 'COMPRAS_TIPO_LIQUIDACION'")
    End Sub
    Public Sub coo_Rubros(ByVal combo As Object, ByVal sTipoSelect As String)
        dl.CargaCombo(combo, "coo_RubrosGastos", "Id", "Nombre", "", sTipoSelect)
    End Sub
    Public Sub coo_ReferenciaPago(ByVal combo As Object, ByVal Mes As Integer, ByVal Periodo As Integer)
        dl.ComboReferencia(combo, Mes, Periodo)
    End Sub
    Public Sub coo_CuentasGastos(ByVal combo As Object, ByVal IdRubro As Integer)
        Dim Condic As String = "IdRubro = " & IdRubro
        dl.CargaCombo(combo, "coo_CuentasGastos", "IdCuenta", "Nombre", Condic, "")
    End Sub
End Class
