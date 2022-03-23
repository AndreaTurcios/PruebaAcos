Imports DBCoopEL.TableEntities
Imports DBCoopDL
Public Class AdmonBLL
    ReadOnly dl As New AdmonDLL()

    Public Function ValidarUsuario(ByVal IdUsuario As String, ByVal Password As String) As String
        Return dl.ValidarUsuario(IdUsuario, Password)
    End Function
    Public Function ObtenerSucursalUsuario(ByVal IdUsuario As String) As DataTable
        Return dl.ObtenerSucursalUsuario(IdUsuario)
    End Function
    Public Function GetAlertasAsociadoSolicitud(ByVal IdAsociado As Integer, ByVal Fecha As Date) As DataTable
        Return dl.GetAlertaAsociadoSolicitud(IdAsociado, Fecha)
    End Function
    Public Function rptPermisosUsuarios(ByVal IdUsuario As String) As DataTable
        Return dl.rptPermisosUsuarios(IdUsuario)
    End Function
    Public Function InsertaAlertas(ByRef entAlerta As coo_Alertas) As String
        Return dl.InsertaAlertas(entAlerta)
    End Function
    Public Function UpdateAlerta(ByRef entAlerta As coo_Alertas) As String
        Return dl.UpdateAlerta(entAlerta)
    End Function
    Public Function ObtenerIdAlerta(ByVal IdAlerta As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdAlerta(IdAlerta, TipoAvance)
    End Function

    Public Function GetPermisosUsuario(ByVal sIdUsuario As String, ByVal sModulo As String, ByVal sOptionId As String) As DataTable
        Return dl.GetPermisosUsuario(sIdUsuario, sModulo, sOptionId)
    End Function
    Public Function getOpciones(ByVal sModulo As String, ByVal sIdUsuario As String) As DataTable
        Return dl.getOpciones(sModulo, sIdUsuario)
    End Function
    Public Sub Elimina_Opciones_Usuario(ByVal sIdUsuario As String, ByVal sModulo As String)
        dl.Elimina_Opciones_Usuario(sIdUsuario, sModulo)
    End Sub
    Public Function ObtenerIdSucursal(ByVal IdSucursal As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdSucursal(IdSucursal, TipoAvance)
    End Function

    Public Sub Inserta_Opcion_Usuario(ByVal sIdUsuario As String, ByVal sModulo As String, ByVal sOptionId As String, ByVal boolean1 As Boolean, ByVal boolean2 As Boolean, ByVal boolean3 As Boolean)
        dl.Inserta_Opcion_Usuario(sIdUsuario, sModulo, sOptionId, boolean1, boolean2, boolean3)
    End Sub
    Function GetModulos() As DataTable
        Return dl.GetModulos()
    End Function
    Function GetUsuarios() As DataTable
        Return dl.GetUsuarios()
    End Function
    Function ObtieneParametros() As DataTable
        Return dl.ObtieneParametros
    End Function
    Sub adm_ParametrosUpdate(ByVal entidad As adm_Parametros)
        dl.adm_ParametrosUpdate(entidad)
    End Sub
    Public Function adm_CierreSucursal(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As String
        Return dl.adm_CierreSucursal(IdSucursal, Fecha, IdUsuario, GeneraReporte)
    End Function
    Public Function adm_CierreSucursalAnexo(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As DataTable
        Return dl.adm_CierreSucursalAnexo(IdSucursal, Fecha, IdUsuario, GeneraReporte)
    End Function
    Public Function adm_ReviertePlanilla(ByVal FechaContable As Date, ByVal Fecha As Date) As String
        Return dl.adm_ReviertePlanilla(FechaContable, Fecha)
    End Function
    Public Function adm_RevierteDescuentoTelefonico(ByVal Fecha As Date) As String
        Return dl.adm_RevierteDescuentoTelefonico(Fecha)
    End Function
    Public Function ObtenerIdCuentaGasto(ByVal IdCuenta As Integer, ByVal TipoAvance As Integer) As Integer
        Return dl.ObtenerIdCuentaGasto(IdCuenta, TipoAvance)
    End Function

    Public Function coo_CuentasGastosSelectByPK(ByVal IdRubro As Integer, ByVal IdCuenta As Integer) As coo_CuentasGastos
        Return dl.coo_CuentasGastosSelectByPK(IdRubro, IdCuenta)
    End Function
    Public Function coo_CuentasGastosSelectByCuenta _
      (ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasGastos

        Return dl.coo_CuentasGastosSelectByPCuenta(IdCuenta _
         )
    End Function


    Function cpp_ObtenerUltAbono(ByVal IdProveedor As String) As Integer
        Return dl.cpp_ObtenerUltAbono(IdProveedor)
    End Function


    Public Function GetSaldoProveedor(ByVal IdProveedor As String, ByVal HastaFecha As DateTime) As Decimal
        Return dl.GetSaldoProveedor(IdProveedor, HastaFecha)
    End Function

    Public Function ConsultacuentasProveedores(ByVal forma As Object) As Integer
        forma.cnsDataTable = dl.ConsultaCuentasProveedores()
        'forma.PrimaryKey = "Id"
        forma.text = "Consulta de Cuentas Proveedores"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function


    Public Function inv_GeneralesProducto(ByVal IdProducto As String) As DataTable
        Return dl.inv_GeneralesProducto(IdProducto)
    End Function

    Public Function inv_ObtienePrecios(ByVal IdProducto As String) As DataTable
        Return dl.inv_ObtienePrecios(IdProducto)
    End Function


    Public Function ConsultaProductos(ByRef Forma As Object, ByVal sCondic As String, ByVal IdProducto As String) As String
        dl.ConsultaProductos(Forma, "")
        Forma.ShowDialog()
        Return Forma.IdProducto
    End Function

    Public Function inv_VerificaCodigoProducto(ByVal IdProducto As String) As Boolean
        Return dl.inv_VerificaCodigoProducto(IdProducto)
    End Function
    Public Function com_ActualizaCompra(ByRef CompraHeader As com_Compras, ByRef CompraDetalle As List(Of com_ComprasDetalle)) As String
        Return dl.com_ActualizaCompra(CompraHeader, CompraDetalle)
    End Function
    Public Function com_InsertaCompra(ByRef CompraHeader As com_Compras, ByRef CompraDetalle As List(Of com_ComprasDetalle)) As String
        Return dl.com_InsertaCompra(CompraHeader, CompraDetalle)
    End Function
    Public Function com_ObtenerCompraDetalle(ByVal IdCompra As Integer) As DataTable
        Return dl.com_ObtenerCompraDetalle(IdCompra)
    End Function
    Public Function coo_InsertarLiquidaciones(ByVal entLiquidacion As coo_Liquidaciones, ByVal Detalle As List(Of coo_LiquidacionesDetalle)) As String
        Return dl.coo_InsertarLiquidacion(entLiquidacion, Detalle)
    End Function

    Function ObtieneNombrePlantillas() As DataTable
        Return dl.ObtieneNombrePlantillas
    End Function
    Function GetTablaDescuentosTelefonos() As DataTable
        Return dl.GetTablaDescuentosTelefonos
    End Function
    Function GetLimpiaTablaTelefonos() As DataTable
        Return dl.GetLimpiaTablaTelefonos
    End Function
    Function GetTablaDescuentosTelefonosAplicados(ByVal FechaAplicacion As DateTime) As DataTable
        Return dl.GetTablaDescuentosTelefonosAplicados(FechaAplicacion)
    End Function
    Function GetTablaAbonosTelefonosAplicados(ByVal FechaAplicacion As DateTime) As DataTable
        Return dl.GetTablaAbonosTelefonosAplicados(FechaAplicacion)
    End Function
    Function GetNumeroFactura(ByVal FechaAplicacion As DateTime) As String
        Return dl.GetNumeroFactura(FechaAplicacion)
    End Function
    Function GetTablaDescuentos() As DataTable
        Return dl.GetTablaDescuentos
    End Function
    Function GetTablaReporte() As DataTable
        Return dl.GetTablaReporte
    End Function
    Function ExtraeDescuentosEnviados(ByVal TipoPlanilla As Integer, ByVal Fecha As DateTime, ByVal IdAsociado As Integer, ByVal ConPrestamos As Integer, ByVal Tipo As Integer) As DataTable
        Return dl.ExtraeDescuentosEnviados(TipoPlanilla, Fecha, IdAsociado, ConPrestamos, Tipo)
    End Function

    Function ExisteCodigoCuentaAhorro(ByVal Codigo As String) As Integer
        Return dl.ExisteCodigoCuentaAhorro(Codigo)
    End Function

    Function ExisteCodigoLinea(ByVal Codigo As String) As Integer
        Return dl.ExisteCodigoLinea(Codigo)
    End Function

    Function ExisteNumeroAsociado(ByVal Codigo As String) As String
        Return dl.ExisteNumeroAsociado(Codigo)
    End Function

    Function ExisteNumeroCuentaAhorro(ByVal Codigo As String, ByVal IdTipo As Integer) As String
        Return dl.ExisteNumeroCuentaAhorro(Codigo,IdTipo)
    End Function

    Function ExisteNumeroPrestamo(ByVal Codigo As String, ByVal IdLinea As Integer) As String
        Return dl.ExisteNumeroPrestamo(Codigo, IdLinea)
    End Function

    Function ObtieneCorrelativos(ByVal IdSucursal As Integer) As DataSet
        Return dl.ObtieneCorrelativos(IdSucursal)
    End Function

    Public Sub ActualizaCorrelativos(ByVal Asociado As Integer, ByVal Factura As Integer, ByVal Deposito As Integer, ByVal Recibo As Integer, ByVal SolRetiro As Integer, ByVal NumVale As Integer, ByVal NumResoloucion As Integer, ByVal IdSucursal As Integer)
        dl.ActualizaCorrelativos(Asociado, Factura, Deposito, Recibo, SolRetiro, NumVale, NumResoloucion, IdSucursal)
    End Sub
    Public Sub ActualizaCorrel(ByVal Correlativo As String, ByVal Valor As Integer)
        dl.ActualizaSolRetiro(Correlativo, Valor)
    End Sub
End Class
