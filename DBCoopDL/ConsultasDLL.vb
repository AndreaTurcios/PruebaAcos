Imports Microsoft.Practices.EnterpriseLibrary.Data

Public Class ConsultasDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()


    Public Sub CargaCns(ByRef cns As Object, ByVal tabla As String, ByVal sCondic As String, ByVal ParamArray Parametros() As Object)

        Dim campos As String = Join(Parametros, ",")
        Dim sSQL As String

        Dim paramOrder As String = Parametros(0)
        Dim sWhere As String = "where 1=1"
        If sCondic <> "" Then sWhere &= " and " & sCondic

        sSQL = String.Format("select {0} from {1} {2} order by {3}", campos, tabla, sWhere, paramOrder)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)

        cns.cnsDatatable = dl

    End Sub
    Public Function ConsultaAlertas() As DataTable
        Dim sql As String
        sql = "SELECT de.IdAlerta,aso.Nombres,aso.Apellidos,de.IdPrestamo,NumeroPrestamo=isnull(pre.Numero,''),de.Descripcion from coo_Alertas de "
        sql &= " inner join coo_Asociados aso on de.IdAsociado=aso.IdAsociado left join coo_prestamos pre on de.IdPrestamo=pre.IdPrestamo Order By de.IdAlerta DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaFechasDescuentos() As DataTable
        Dim sql As String
        sql = "SELECT  IdComprobante,FechaDescuento, Activo, CreadoPor, FechaHoraCreacion from coo_FechasDescuentos  "
        sql &= " where Activo=1 order by FechaDescuento"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function


    Public Function ConsultaCuentaCorriente(ByVal IdAsociado As Integer) As DataTable

        Dim sSQL As String
        sSQL = "SELECT ca.Numero, aso.Nombres, aso.Apellidos, ca.IdCuenta from coo_CuentasAhorro ca "
        sSQL &= " inner join coo_asociados aso on ca.IdAsociado=aso.IdAsociado where ca.IdTipoCuenta=1"
        sSQL &= " and ca.IdAsociado = " & IdAsociado & "Order By IdCuenta DESC "

        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function ConsultaAyudaFuneraria() As DataTable

        Dim sSQL As String
        sSQL = "SELECT ay.IdMovimiento ,ay.IdAsociado, NumAsociado = aso.Numero, Nombre= aso.nombres +' '+aso.apellidos, ay.fechaservicio, ValorOtorgado=ay.cantidadotorgada "
        sSQL &= " from coo_ayudafuneraria ay inner join coo_asociados aso on ay.idasociado = aso.idasociado order by ay.idasociado"


        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function ConsultaCuentaAhorro(ByVal IdAsociado As Integer) As DataTable
        Dim sql As String
        sql = "SELECT ca.IdCuenta, ca.Numero, aso.Nombres, aso.Apellidos, ca.FechaHoraCreacion from coo_CuentasAhorro ca "
        sql &= " inner join coo_asociados aso on ca.IdAsociado=aso.IdAsociado where "
        sql &= " ca.IdAsociado = " & IdAsociado & "Order By IdCuenta DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function


    Public Function ConsultaFiadores() As DataTable

        Dim sql As String
        sql = "SELECT fia.NroDocumento, Fiador=fia.NombresApellidos,fia.Nit,fia.Telefonos from coo_GarantiasFiador fia "
        sql &= "Group by fia.NroDocumento, fia.NombresApellidos, fia.Nit, fia.Telefonos Order By fia.NroDocumento DESC "

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaSolicitudRetiro() As DataTable

        Dim sql As String
        sql = "SELECT sol.IdSolicitud, Sol.NumeroSolicitud, Sol.Fecha, Sol.FechaRetiro, Aso.Numero,Nombres=Aso.Nombres+' '+Aso.Apellidos from coo_SolicitudRetiro Sol inner join coo_Asociados aso on Sol.IdAsociado = aso.IdAsociado"

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function ConsultaPlanillasAplicadas() As DataTable
        Dim sql As String
        sql = "SELECT Mov.FechaContable, Mov.Fecha from coo_PrestamosDetalle Mov where mov.IdFormaPago=6 and Mov.CreadoPor <> 'ITO' group by Mov.FechaContable, Mov.Fecha order by Mov.FechaContable, Mov.Fecha"
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ConsultaSolicitudRetiroAprobadas(ByVal FechaContable As DateTime, ByVal RetiroTotal As Boolean) As DataTable
        Dim sql As String

        If RetiroTotal = True Then
            sql = "SELECT sol.IdSolicitud, Sol.NumeroSolicitud, Sol.Fecha, Sol.FechaRetiro, Aso.Numero,Nombres=Aso.Nombres+' '+Aso.Apellidos from coo_SolicitudRetiro Sol inner join coo_Asociados aso on Sol.IdAsociado = aso.IdAsociado where Sol.AprobadoPor <> '' and Sol.TipoRetiro=0 and CONVERT(char(10), Sol.FechaHoraAprobacion, 112) = '" & Format(FechaContable, "yyyyMMdd") & "'"
        Else
            sql = "SELECT sol.IdSolicitud, Sol.NumeroSolicitud, Sol.Fecha, Sol.FechaRetiro, Aso.Numero,Nombres=Aso.Nombres+' '+Aso.Apellidos from coo_SolicitudRetiro Sol inner join coo_Asociados aso on Sol.IdAsociado = aso.IdAsociado where Sol.AprobadoPor <> '' and Sol.TipoRetiro=1 and CONVERT(char(10), Sol.FechaHoraAprobacion, 112) = '" & Format(FechaContable, "yyyyMMdd") & "'"
        End If

        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function



    Public Function ConsultaSolicitudFondos() As DataTable
        Return db.ExecuteDataSet("coo_spConsultaSolicitudFondos").Tables(0)
    End Function

    Public Function ConsultaCantones() As DataTable
        Dim sql As String
        sql = "SELECT ca.Id,ca.IdCanton, ca.Nombre,Departamento=dp.Nombre, Municipio=mu.Nombre from adm_Cantones ca "
        sql &= " inner join adm_Departamentos dp on ca.IdDepartamento=dp.IdDepartamento inner join adm_Municipios mu on ca.IdMunicipio= mu.IdMunicipio "
        sql &= " Order By ca.IdCanton DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ConsultaCuentasGasto() As DataTable
        Dim sql As String
        sql = "SELECT ca.IdCuenta,ca.Idrubro,Rubro=ru.Nombre ,ca.Nombre,ca.CuentaContable from coo_cuentasGastos ca "
        sql &= " inner join coo_RubrosGastos ru on ca.IdRubro=ru.Id "
        sql &= " Order By ca.IdCuenta DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function ConsultaOperacionNumerario() As DataTable
        Dim sql As String
        sql = "SELECT o.IdOperacion,o.Numero,o.CreadoPor,Sucursal=su.Nombre "
        sql &= ",o.Fecha,Operacion=tp.Nombre,TipoOperacion=lis.Nombre,o.Valor from coo_OperacionesNumerario o "
        sql &= " inner join coo_TiposOperacionNumerario tp on o.IdTipoOperacion=tp.IdTipoOperacion inner join adm_listas lis on o.TipoOperacion=lis.Id and lis.Modulo='TIPO_NUMERARIO' "
        sql &= " inner join adm_sucursales su on o.IdSucursal=su.IdSucursal Order By IdOperacion DESC "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
#Region "ConsultasMaestrosDetalle"

    Public Function ConsultaPedidos() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT fac_Pedidos.IdComprobante, fac_Pedidos.Numero, fac_Pedidos.Fecha, fac_Clientes.Nombre AS Cliente, Fac_Pedidos.CreadoPor, Fac_Pedidos.FechaHoraCreacion"
        sSQL &= " FROM fac_Pedidos INNER JOIN fac_Clientes on fac_Pedidos.IdCliente = fac_Clientes.IdCliente"
        sSQL &= " ; select * from fac_PedidosDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Pedidos_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaRemision() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT IdComprobante, Numero, Fecha, Nombre, CreadoPor, FechaHoraCreacion from fac_NotasRemision"
        sSQL &= " ; select * from fac_NotasRemisionDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Notas_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaCotizaciones() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT IdCotizacion, Numero, Fecha, Nombre, CreadoPor, FechaHoraCreacion"
        sSQL &= " FROM Fac_Cotizaciones; select * from fac_CotizacionesDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Cotiza_Detalle", ds.Tables(0).Columns("IdCotizacion"), ds.Tables(1).Columns("IdCotizacion"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaFactura() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT IdComprobante, Numero, Fecha, Nombre, TotalComprobante, CreadoPor, FechaHoraCreacion from fac_Ventas"
        sSQL &= " Order By IdComprobante DESC; SELECT * FROM fac_VentasDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Ventas_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function

    Public Function ConsultaCompras() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String

        sSQL = "SELECT com_Compras.IdComprobante, com_Compras.Serie, com_Compras.Numero, com_Compras.Fecha, com_Proveedores.Nombre AS Proveedor, "
        sSQL &= " com_Compras.CreadoPor, com_Compras.FechaHoraCreacion"
        sSQL &= " FROM com_Compras INNER JOIN"
        sSQL &= " com_Proveedores ON com_Compras.IdProveedor = com_Proveedores.IdProveedor"
        sSQL &= " ; select * from com_ComprasDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Compras_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaImportaciones() As DataSet
        Dim ds As New DataSet
        Dim sql As String
        sql = "select IdComprobante, NumeroFactura, NumeroPoliza, Fecha, FechaContable, IdProveedor, Nombre, TotalPoliza, TotalPorPagar "
        sql &= "from com_importaciones ; select * from com_ImportacionesDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sql)

        Dim dr As New DataRelation("Importaciones_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function

    Public Function ConsultaQuedan() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT Que.IdComprobante, Que.Numero, Que.IdProveedor, Pro.Nombre NombreProveedor, Que.Fecha, Que.FechaPago, Que.TotalPago "
        sSQL &= "FROM CPP_Quedan Que INNER JOIN Com_Proveedores Pro ON Que.IdProveedor = Pro.IdProveedor; SELECT * FROM CPP_QuedanDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Quedan_Detalle" _
                                   , ds.Tables(0).Columns("IdComprobante") _
                                   , ds.Tables(1).Columns("IdComprobante"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaCheques() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT Che.IdCheque, Che.IdTipoPartida, Che.NumeroPartida, Ban.NumeroCuenta, Numero, Fecha, AnombreDe, Left(Concepto,100) Concepto, Valor, Che.CreadoPor, "
        sSQL &= "Che.FechaHoraCreacion  from ban_Cheques Che inner join ban_cuentasbancarias ban on che.idcuentabancaria = ban.idcuentabancaria"
        sSQL &= " order by Ban.NumeroCuenta, Numero desc; select * from ban_ChequesDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Cheques_Detalle" _
                                   , ds.Tables(0).Columns("IdCheque") _
                                   , ds.Tables(1).Columns("IdCheque"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaTransacciones() As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT Tra.IdTransaccion, Tra.IdTipoPartida, Tra.NumeroPartida, Ban.NumeroCuenta, Tra.Fecha, Left(Concepto,100) Concepto, Tra.Valor, Tra.CreadoPor,"
        sSQL &= " Tra.FechaHoraCreacion, Tra.ModificadoPor from ban_Transacciones Tra"
        sSQL &= " inner join Ban_CuentasBancarias Ban ON Tra.IdCuentaBancaria = Ban.IdCuentaBancaria"
        sSQL &= " order by Ban.NumeroCuenta, Fecha desc; select * from ban_TransaccionesDetalle"

        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("TransDetalle" _
                                   , ds.Tables(0).Columns("IdTransaccion") _
                                   , ds.Tables(1).Columns("IdTransaccion"))
        ds.Relations.Add(dr)
        Return ds
    End Function
    Public Function ConsultaPartidas(ByVal sCondition As String) As DataSet
        Dim ds As New DataSet
        Dim sSQL As String
        sSQL = "SELECT IdPartida, IdTipo, Numero, Fecha, left(Concepto,100) Concepto, CreadoPor, FechaHoraCreacion FROM con_Partidas"
        If sCondition <> "" Then
            sSQL &= " Where " & sCondition & " Order By IdPartida DESC"
            sSQL &= " ; SELECT * FROM con_PartidasDetalle pd INNER JOIN con_Partidas cp ON pd.IdPartida = cp.IdPartida Where " & sCondition
        Else
            sSQL &= " Order By IdPartida DESC"
            sSQL &= " ; SELECT * FROM con_PartidasDetalle"
        End If


        ds = db.ExecuteDataSet(CommandType.Text, sSQL)

        Dim dr As New DataRelation("Partidas_Detalle" _
                                   , ds.Tables(0).Columns("IdPartida") _
                                   , ds.Tables(1).Columns("IdPartida"))
        ds.Relations.Add(dr)
        Return ds
    End Function

#End Region
End Class
