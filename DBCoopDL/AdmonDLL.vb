Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports DBCoopEL.TableEntities
Imports System.Data.Common
Public Class AdmonDLL
    ReadOnly db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTablas As New TableData

    Public Sub adm_ParametrosUpdate(ByVal entidad As adm_Parametros)

        db.ExecuteNonQuery("adm_ParametrosUpdate", _
          entidad.NrcEmpresa _
         , entidad.NitEmpresa _
         , entidad.TipoContribuyente _
         , entidad.EsRetenedor _
         , entidad.Direccion _
         , entidad.Domicilio _
         , entidad.Municipio _
         , entidad.Departamento _
         , entidad.NumeroPatronal _
         , entidad.ActividadEconomica _
         , entidad.NombreFirmante1 _
         , entidad.CargoFirmante1 _
         , entidad.NombreFirmante2 _
         , entidad.CargoFirmante2 _
         , entidad.NombreFirmante3 _
         , entidad.CargoFirmante3 _
         , entidad.NombreFirmante4 _
         , entidad.CargoFirmante4 _
         , entidad.NombreFirmante5 _
         , entidad.CargoFirmante5 _
         , entidad.NombreFirmante6 _
         , entidad.CargoFirmante6 _
         , entidad.DescMoneda _
         , entidad.FechaCierre _
         , entidad.FechaLimite _
         , entidad.Ejercicio _
         , entidad.PorcIva _
         , entidad.PorcRetencion _
         , entidad.PorcPercepcion _
         , entidad.IdSucursal _
         , entidad.IdPunto _
         , entidad.IdBodega _
         , entidad.TipoNumeracionPartidas _
         , entidad.GuardarDesbalance _
         , entidad.IdCuentaCaja _
         , entidad.IdCuentaCredito1 _
         , entidad.IdCuentaCredito2 _
         , entidad.IdCuentaDebito1 _
         , entidad.IdCuentaDebito2 _
         , entidad.IdCuentaRetencion1 _
         , entidad.IdCuentaRetencion2 _
         , entidad.IdCuentaPercepcion _
         , entidad.MensajeCooperativo _
         , entidad.IdTipoPrecio _
         , entidad.UbicacionServer _
         , entidad.CuotaAportacion _
         )
    End Sub
    Public Function InsertaAlertas(ByRef entAlerta As coo_Alertas) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entAlerta.IdAlerta = ObtenerUltimoId("Coo_Alertas", "IdAlerta") + 1
            objTablas.coo_AlertasInsert(entAlerta, tran)
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            tran.Commit()
            cn.Close()
        End Try
        Return msj
    End Function
    Public Function UpdateAlerta(ByRef entAlerta As coo_Alertas) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTablas.coo_AlertasUpdate(entAlerta, tran)
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""

    End Function
    Public Function GetAlertaAsociadoSolicitud(ByVal IdAsociado As Integer, ByVal Fecha As Date) As DataTable
        Dim sSQL As String = "select * from coo_Alertas "
        If IdAsociado = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where ProcesoAplica=1 AND IdAsociado=" & IdAsociado & " AND FechaDefinicion <='" & Format(Fecha, "yyyyMMdd") & "' AND FechaVencimiento >='" & Format(Fecha, "yyyyMMdd") & "'"
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Function ObtenerIdAlerta(ByVal IdAlerta As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdAlerta
        End If
        Dim sSQL As String = "select top 1 IdAlerta from coo_Alertas where IdAlerta < " & IdAlerta & " order by IdAlerta desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdAlerta from coo_Alertas where IdAlerta > " & IdAlerta
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

    Public Function ValidarUsuario(ByVal UserId As String, ByVal Password As String) As String
        'Dim i As Integer = db.ExecuteScalar("adm_ValidarUsuario", UserId, txt_password)
        'If i = 0 Then
        '    Return False
        'Else
        '    Return True
        'End If
        Dim msj As String = "", EsCorrecto As Boolean
        Try
            EsCorrecto = db.ExecuteScalar("adm_ValidarUsuario", UserId, Password) = 1
            If EsCorrecto Then
                msj = "Ok"
            Else
                msj = "No"
            End If
        Catch ex As Exception
            msj = ex.Message
        End Try
        Return msj
    End Function
    Public Function ObtenerSucursalUsuario(ByVal IdUsuario As String) As DataTable
        Dim sql As String = "Select Us.IdSucursal, Su.Nombre from adm_Usuarios Us inner join adm_Sucursales su on us.IdSucursal = su.IdSucursal where IdUsuario = '" + IdUsuario + "'"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function coo_CuentasGastosSelectByPK(ByVal IdRubro As System.Int32, ByVal IdCuenta As System.Int32) As coo_CuentasGastos

        Dim dt As DataTable = db.ExecuteDataSet("coo_CuentasGastosSelectByPK", _
         IdRubro, IdCuenta).Tables(0)

        Dim Entidad As New coo_CuentasGastos
        If dt.Rows.Count > 0 Then
            Entidad.IdRubro = dt.Rows(0).Item("IdRubro")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.CuentaContable = dt.Rows(0).Item("CuentaContable")
            Entidad.IncluyeIva = dt.Rows(0).Item("IncluyeIva")
            Entidad.AplicaIsr = dt.Rows(0).Item("AplicaIsr")
        End If
        Return Entidad
    End Function

    Public Function coo_CuentasGastosSelectByPCuenta _
(ByVal IdCuenta As System.Int32 _
) As coo_CuentasGastos

        Dim sql As String = "Select * from coo_cuentasGastos where IdCuenta = " & IdCuenta

        Dim dt As DataTable
        dt = db.ExecuteDataSet(CommandType.Text, sql).Tables(0)

        Dim Entidad As New coo_CuentasGastos
        If dt.Rows.Count > 0 Then
            Entidad.IdRubro = dt.Rows(0).Item("IdRubro")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.CuentaContable = dt.Rows(0).Item("CuentaContable")

        End If
        Return Entidad
    End Function

    Public Sub BloqueaUsuario(ByVal cod_usuario As String)
        db.ExecuteScalar("adm_BloqueaUsuario", cod_usuario)
    End Sub
    Public Function GetPermisosUsuario(ByVal sIdUsuario As String, ByVal sModulo As String, ByVal sOptionId As String) As DataTable
        Return db.ExecuteDataSet("adm_GetPermisosUsuario", sIdUsuario, sModulo, sOptionId).Tables(0)
    End Function

    Public Function rptPermisosUsuarios(ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("adm_spPermisosUsuarios", IdUsuario).Tables(0)
    End Function

    Public Function getOpciones(ByVal sModulo As String, ByVal sIdUsuario As String) As DataTable
        Return db.ExecuteDataSet("adm_GetOpciones", sModulo, sIdUsuario).Tables(0)
    End Function
    Public Sub Elimina_Opciones_Usuario(ByVal sIdUsuario As String, ByVal sModulo As String)
        db.ExecuteNonQuery("adm_Opciones_UsuariosDelete", sIdUsuario, sModulo)
    End Sub
    Public Sub Inserta_Opcion_Usuario(ByVal sIdUsuario As String, ByVal sModulo As String, ByVal sOptionId As String, ByVal boolean1 As Boolean, ByVal boolean2 As Boolean, ByVal boolean3 As Boolean)
        db.ExecuteNonQuery("adm_Opciones_UsuariosInsert", sIdUsuario, sModulo, sOptionId, boolean1, boolean2, boolean3)
    End Sub
    Function GetModulos() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "Select * from adm_Modulos ").Tables(0)
    End Function
    Function GetUsuarios() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "Select * from adm_Usuarios").Tables(0)
    End Function

    Function ObtenerIdSucursal(ByVal IdSucursal As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdSucursal
        End If
        Dim sSQL As String = "select top 1 IdSucursal from adm_Sucursales where IdSucursal < " & IdSucursal & " order by IdSucursal desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdSucursal from adm_sucursales where IdSucursal > " & IdSucursal
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function


    Function ObtieneParametros() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from adm_parametros").Tables(0)
    End Function
    Public Function adm_CierreSucursal(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As String
        Return db.ExecuteScalar("coo_spCierreSucursal", IdSucursal, Fecha, IdUsuario, GeneraReporte)
    End Function
    Public Function adm_CierreSucursalAnexo(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal GeneraReporte As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spCierreSucursal", IdSucursal, Fecha, IdUsuario, GeneraReporte).Tables(0)
    End Function
    Public Function adm_ReviertePlanilla(ByVal FechaContable As Date, ByVal Fecha As Date) As String
        Return db.ExecuteScalar("coo_spReviertePlanilla", FechaContable, Fecha)
    End Function
    Public Function adm_RevierteDescuentoTelefonico(ByVal Fecha As Date) As String
        Return db.ExecuteScalar("coo_spRevierteDescuentoTelefonico", Fecha)
    End Function
    Function ObtenerIdCuentaGasto(ByVal IdCuenta As Integer, ByVal TipoAvance As Integer) As Integer
        If TipoAvance = 0 Then
            Return IdCuenta
        End If
        Dim sSQL As String = "select top 1 IdCuenta from coo_CuentasGastos where IdCuenta < " & IdCuenta & " order by IdCuenta desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdCuenta from coo_CuentasGastos where IdCuenta > " & IdCuenta
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function


    Public Function ConsultaCuentasProveedores() As DataTable
        Dim sql As String
        sql = "SELECT ca.IdCuenta, ca.Idrubro,Rubro=ru.Nombre ,ca.Nombre,ca.CuentaContable from coo_cuentasGastos ca "
        sql &= " inner join coo_RubrosGastos ru on ca.IdRubro=ru.Id "
        sql &= " Where ca.IdRubro=20 Order By ca.IdCuenta DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function com_InsertaCompra(ByRef CompraHeader As com_Compras, ByRef CompraDetalle As List(Of com_ComprasDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            CompraHeader.IdComprobante = ObtenerUltimoId("COM_COMPRAS", "IdComprobante") + 1

            objTablas.com_ComprasInsert(CompraHeader, tran)

            For Each detalle As com_ComprasDetalle In CompraDetalle
                detalle.IdComprobante = CompraHeader.IdComprobante
                detalle.IdProducto = "111"   'se ha dejado quemado éste dato por la forma de como se ingresa la compra
                objTablas.com_ComprasDetalleInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            cn.Close()
            Return ex.Message
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function
    Public Function com_ActualizaCompra(ByRef CompraHeader As com_Compras, ByRef CompraDetalle As List(Of com_ComprasDetalle)) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            objTablas.com_ComprasUpdate(CompraHeader, tran)

            Dim sSQL As String = "delete com_ComprasDetalle where IdComprobante=" & CompraHeader.IdComprobante
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As com_ComprasDetalle In CompraDetalle
                detalle.IdComprobante = CompraHeader.IdComprobante
                objTablas.com_ComprasDetalleInsert(detalle, tran)
            Next

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function com_ObtenerCompraDetalle(ByVal IdCompra As Integer) As DataTable
        Dim sql As String = "select IdRubro=0, IdGasto, Descripcion, ValorExento, ValorAfecto, IdCuenta from com_ComprasDetalle where IdComprobante=" & IdCompra
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function coo_InsertarLiquidacion(ByVal entLiquidacion As coo_Liquidaciones, ByVal Detalle As List(Of coo_LiquidacionesDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try

            'Guarda el quedan
            objTablas.coo_LiquidacionesInsert(entLiquidacion, tran)

            For Each entDetalle As coo_LiquidacionesDetalle In Detalle
                entDetalle.IdComprobante = entLiquidacion.IdComprobante
                objTablas.coo_LiquidacionesDetalleInsert(entDetalle, tran)
            Next
        Catch ex As Exception
            tran.Rollback()
            cn.Close()
            Return ex.Message
        End Try
        tran.Commit()
        cn.Close()
        Return ""

    End Function


    Public Function com_ObtenerIdCompra(ByVal IdCompra As Integer, ByVal TipoAvance As Integer) As Integer
        Dim sSQL As String = "select top 1 IdComprobante from com_Compras where IdComprobante < " & IdCompra & " order by IdComprobante desc"
        If TipoAvance = 1 Then
            sSQL = "select top 1 IdComprobante from com_Compras where IdComprobante > " & IdCompra
        End If
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function

    Function cpp_ObtenerUltAbono(ByVal IdProveedor As String) As Integer
        Dim sql As String = ""
        sql = "select isnull(max(IdComprobante),0) from cpp_Abonos where IdProveedor='" & IdProveedor & "'"
        Return db.ExecuteScalar(CommandType.Text, sql)
    End Function

    Public Function GetSaldoProveedor(ByVal IdProveedor As String, ByVal HastaFecha As DateTime) As Decimal
        Dim Saldo As Integer = db.ExecuteScalar("cpp_spSaldoProveedor", IdProveedor, HastaFecha)
        Return Saldo
    End Function

    Public Sub ConsultaProductos(ByRef Forma As Object, ByVal sCondic As String)
        Dim sSQL As String = "select IdProducto, Nombre from inv_productos where EstadoProducto = 1"
        Dim dtProd As DataTable = db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
        Forma.cnsDatatable = dtProd
    End Sub

    Public Function inv_GeneralesProducto(ByVal IdProducto) As DataTable
        Return db.ExecuteDataSet("inv_spGeneralesProducto", IdProducto).Tables(0)
    End Function

    Public Function inv_ObtienePrecios(ByVal IdProducto As String) As DataTable
        Dim sSQL As String = "select ip.IdPrecio, pp.Precio from inv_Precios ip left join inv_ProductosPrecios pp on ip.IdPrecio = pp.IdPrecio and pp.IdProducto = '"
        sSQL &= IdProducto & "'"
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function inv_VerificaCodigoProducto(ByVal IdProducto As String) As Boolean
        Return db.ExecuteScalar(CommandType.Text, "select 1 from inv_productos where IdProducto = '" & IdProducto & "'") = 1
    End Function
    Public Function ObtieneFechaCierre() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select FechaCierre,FechaLimite from adm_parametros").Tables(0)
    End Function

    Function ObtieneNombrePlantillas() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "SELECT ID=Documento, Nombre=Documento FROM coo_Documentos").Tables(0)
    End Function


    Public Function ObtenerUltimoId(ByVal Tabla As String, ByVal PrimaryKey As String) As Integer
        'METER A TRANSACCION
        Dim sql As String = "select IsNull(max(" & PrimaryKey & "),0) from " & Tabla
        Dim Id As Integer = db.ExecuteScalar(CommandType.Text, sql)
        Return Id
    End Function
    Public Function GetLimpiaTablaTelefonos() As DataTable
        Dim sSQL As String = "SELECT a.IdAsociado,Numero,Nombres,Apellidos,Telefono=isnull(t.Ntelefono,'S/N'),NumeroFactura=convert(VARCHAR(50),''),ValorTotalFactura=convert(decimal(18,2),0.00),ValorIva=convert(decimal(18,2),0.00)"
        sSQL += ", ValorSeguridad=convert(decimal(18,2),0.00),ValorComicion=convert(decimal(18,2),0.00),Total=convert(decimal(18,2),0.00),SubTotal=convert(decimal(18,2),0.00) FROM coo_Asociados  a "
        sSQL += "inner JOIN coo_AsociadosTelefonia t ON a.IdAsociado=t.IdAsociado where a.Idasociado= -1"
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetTablaDescuentosTelefonos() As DataTable
        Dim sSQL As String = "SELECT a.IdAsociado,Numero,Nombres,Apellidos,Telefono=isnull(t.Ntelefono,'S/N'),NumeroFactura=convert(VARCHAR(50),''),ValorTotalFactura=convert(decimal(18,2),0.00),ValorIva=convert(decimal(18,2),0.00)"
        sSQL += ", ValorSeguridad=convert(decimal(18,2),0.00),ValorComicion=convert(decimal(18,2),0.00),Total=convert(decimal(18,2),0.00),SubTotal=convert(decimal(18,2),0.00) FROM coo_Asociados  a "
        sSQL += "inner JOIN coo_AsociadosTelefonia t ON a.IdAsociado=t.IdAsociado"
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetTablaAbonosTelefonosAplicados(ByVal FechaAplicacion As DateTime) As DataTable
        Dim sSQL As String = "SELECT a.IdAsociado,a.Numero ,a.Nombres,a.Apellidos,Telefono=isnull(p.Telefono,'S/N'),NumeroFactura=isnull(p.NAbono,''),ValorTotalFactura=isnull(p.ValorTotalAbono,0),ValorIva=0"
        sSQL += ",ValorSeguridad=0,ValorComicion=0,Total=isnull(p.Total,0),SubTotal=isnull(p.ValorTotalAbono,0) FROM coo_Asociados a "
        sSQL += "inner JOIN coo_abonoTelefonia p ON p.IdAsociado=a.IdAsociado WHERE p.FechaAplicacion= '" & Format(FechaAplicacion, "yyyyMMdd") + "'"
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Function GetTablaDescuentosTelefonosAplicados(ByVal FechaAplicacion As DateTime) As DataTable
        Dim sSQL As String = "SELECT a.IdAsociado,a.Numero ,a.Nombres,a.Apellidos,Telefono=isnull(p.Telefono,'S/N'),NumeroFactura=isnull(p.Nfactura,''),ValorTotalFactura=isnull(p.ValorTotalFactura,0),ValorIva=isnull(p.ValorIva,0)"
        sSQL += ",ValorSeguridad=isnull(p.ValorSeguridad,0),ValorComicion=isnull(p.Valorcomicion,0),Total=isnull(p.Total,0),SubTotal=isnull(p.ValorTotalFactura+p.ValorIva+p.ValorSeguridad,0)FROM coo_Asociados a "
        sSQL += "inner JOIN coo_DescuentoTelefoniaPendiente p ON p.IdAsociado=a.IdAsociado WHERE p.FechaAplicacion= '" & Format(FechaAplicacion, "yyyyMMdd") + "'"
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetNumeroFactura(ByVal FechaAplicacion As DateTime) As String
        Dim sSQL As String = "SELECT TOP 1 nFactura FROM coo_DescuentoTelefoniaPendiente WHERE FechaAplicacion = '" & Format(FechaAplicacion, "yyyyMMdd") + "'"
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function GetNumeroAbono(ByVal FechaAplicacion As DateTime) As String
        Dim sSQL As String = "SELECT TOP 1 NAbono FROM coo_DescuentoTelefoniaPendiente WHERE FechaAplicacion = '" & Format(FechaAplicacion, "yyyyMMdd") + "'"
        Return db.ExecuteScalar(CommandType.Text, sSQL)
    End Function
    Public Function GetTablaDescuentos() As DataTable
        Dim sSQL As String = "select Num=convert(int,0),IdAsociado, Numero, Nombres, Apellidos,Aportaciones= convert(decimal(18,2),0.00),Ahorros= convert(decimal(18,2),0.00), Prestamos= convert(decimal(18,2),0.00), IdPrestamo=convert(int,0),NumeroPrestamo=convert(varchar(15),'') from coo_asociados where IdAsociado=-1 "
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetTablaReporte() As DataTable
        Dim sSQL As String = "select IdAsociado, Numero, Nombres=Nombres+' '+Apellidos, Descuento=convert(decimal(18,2),0.00) from coo_asociados where IdAsociado=-1 "
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function ExtraeDescuentosEnviados(ByVal TipoPlanilla As Integer, ByVal Fecha As DateTime, ByVal IdAsociado As Integer, ByVal ConPrestamos As Integer, ByVal Tipo As Integer) As DataTable
        Dim sSQL As String = ""

        If ConPrestamos = 0 Then
            sSQL = "select * from coo_DescuentosPendientesPlanilla  where IdPlanillaDescuento= " & TipoPlanilla
            sSQL += " and Tipo= " & Tipo
            sSQL += " and IdAsociado= " & IdAsociado
            sSQL += " and IdLinea =0 and FechaAplicacion= '" & Format(Fecha, "yyyyMMdd") + "'"
            sSQL += " ORDER BY IdAsociado,IdTipoDescuento"
        Else
            sSQL = "select D.* from coo_DescuentosPendientesPlanilla D inner join coo_Lineas li on D.IdLinea = li.IdLinea"
            sSQL += " where d.IdPlanillaDescuento = " & TipoPlanilla
            sSQL += " and d.Tipo= " & Tipo
            sSQL += " and d.IdAsociado= " & IdAsociado
            sSQL += " and d.IdLinea > 0 and d.FechaAplicacion= '" & Format(Fecha, "yyyyMMdd") + "'"
            sSQL += " ORDER BY li.Prioridad, D.IdPrestamo "
        End If

        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    '
    Public Function ExisteCodigoCuentaAhorro(ByVal Codigo As String) As Integer
        Dim sSql As String = "select IdTipo from coo_TiposCuentaAhorro where CodigoDescuento= '" & Codigo & "'"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function

    Public Function ExisteNumeroAsociado(ByVal Codigo As String) As String
        Dim sSql As String = "SELECT DISTINCT Numero FROM coo_Asociados WHERE Numero='" & Codigo & "'"
        Dim NumeroReg As String = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function

    Public Function ExisteCodigoLinea(ByVal Codigo As String) As Integer
        Dim sSql As String = "select IdLinea from coo_Lineas where CodigoDescuento= '" & Codigo & "'"
        Dim NumeroReg As Integer = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function

    Public Function ExisteNumeroCuentaAhorro(ByVal Codigo As String, ByVal Idtipo As Integer) As String
        Dim sSql As String = "SELECT Numero=max(aho.Numero) FROM coo_CuentasAhorro aho INNER JOIN coo_Asociados aso ON aho.IdAsociado=aso.IdAsociado WHERE substring(aso.Numero,9,6)='" & Codigo & "' AND aho.IdTipoCuenta=" & Idtipo
        Dim NumeroReg As String = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function

    Public Function ExisteNumeroPrestamo(ByVal Codigo As String, ByVal IdLinea As Integer) As String
        Dim sSql As String = "SELECT Numero=max(pre.Numero) FROM coo_Prestamos pre INNER JOIN coo_Asociados aso ON pre.IdAsociado=aso.IdAsociado WHERE substring(aso.Numero,9,6)='" & Codigo & "' AND pre.IdLinea= " & IdLinea
        Dim NumeroReg As String = fd.SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function

    Function ObtieneCorrelativos(ByVal IdSucursal As Integer) As DataSet
        Dim sql As String = "select ultimoValor from adm_correlativos where correlativo = 'NUMERO_ASOCIADO'"
        sql &= "; select CorrelativoPago, CorrelativoDeposito, CorrelativoIngresos from adm_sucursales where IdSucursal = " & IdSucursal
        sql &= "; select ultimoValor from adm_correlativos where correlativo = 'SOLICITUD_RETIRO'"
        sql &= "; select ultimoValor from adm_correlativos where correlativo = 'VALES_EFECTIVO'"
        sql &= "; select ultimoValor from adm_correlativos where correlativo = 'RESOLUCION_CREDITO'"
        Return db.ExecuteDataSet(CommandType.Text, sql)
    End Function

    Public Sub ActualizaCorrelativos(ByVal NumAsociado As Integer, ByVal Factura As Integer, ByVal Deposito As Integer, ByVal Recibo As Integer, ByVal SolRetiro As Integer _
    , ByVal NumVale As Integer, ByVal NumResolucion As Integer, ByVal IdSucursal As Integer)
        Dim sql As String = "update adm_correlativos set ultimoValor = " & NumAsociado & " where correlativo = 'NUMERO_ASOCIADO'"
        sql &= "; update adm_sucursales set CorrelativoPago = " & Factura
        sql &= ", CorrelativoDeposito = " & Deposito
        sql &= ", CorrelativoRetiro = " & Deposito
        sql &= ", CorrelativoIngresos = " & Recibo
        sql &= " where IdSucursal = " & IdSucursal
        sql &= "; update adm_correlativos set ultimoValor = " & SolRetiro & " where correlativo = 'SOLICITUD_RETIRO'"
        sql &= "; update adm_correlativos set ultimoValor = " & NumVale & " where correlativo = 'VALES_EFECTIVO'"
        sql &= "; update adm_correlativos set ultimoValor = " & NumResolucion & " where correlativo = 'RESOLUCION_CREDITO'"
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub
    Public Sub ActualizaSolRetiro(ByVal Correlativo As String, ByVal Valor As Integer)
        Dim sql As String = " update adm_correlativos set ultimoValor = " & Valor & " where correlativo = '" & Correlativo + "'"
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub

End Class
