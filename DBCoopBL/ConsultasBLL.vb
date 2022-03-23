Imports DBCoopDL
Imports DBCoopEL.TableEntities

Public Class ConsultasBLL
    Dim dl As New ConsultasDLL
    Dim td As New TableData
    
#Region "ConsultasCatalogos"
    Public Function cnsCuentas(ByRef forma As Object, ByVal IdCuenta As String) As con_Cuentas
        Dim entCuenta As New con_Cuentas

        If IdCuenta Is Nothing Then
            Return entCuenta
        End If

        If Not IdCuenta = "" Then
            entCuenta = td.con_CuentasSelectByPK(IdCuenta)
        End If

        If entCuenta.IdCuenta = "" Then
            dl.CargaCns(forma, "con_cuentas", "", "IdCuenta", "Nombre", "IdCuentaMayor")
            forma.Text = "Consulta de cuentas"
            forma.showdialog()
            If Not forma.ValCodigo = "" Then
                entCuenta = td.con_CuentasSelectByPK(forma.ValCodigo)
            End If

        End If
        Return entCuenta
    End Function
    

    Public Function cnsTiposCuentaAhorro(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_TiposCuentaAhorro", "", "IdTipo", "Nombre")
        forma.text = "Consulta de Tipos de Cuenta Ahorro"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function
    Public Function cnsAyudaFuneraria(ByVal forma As Object) As Integer
 

        forma.cnsDataTable = dl.ConsultaAyudaFuneraria()
        forma.showdialog()
        Return forma.ValCodigo

    End Function

    Public Function cnsFuentesFinanciamiento(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_Fuentes", "", "IdFuente", "Nombre")
        forma.text = "Consulta de Fuentes de Financiamiento"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function ConsultaAlertas(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaAlertas()
        'forma.PrimaryKey = "Id"
        forma.text = "Consulta de Alertas"
        forma.showdialog()
        Return forma.ValCodigo
    End Function
    Public Function ConsultaFechasDescuentos(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaFechasDescuentos()
        forma.text = "Consulta de Fechas de Descuento"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function cnsTecnicos(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_Tecnicos", "", "IdTecnico", "Nombre")
        forma.text = "Consulta de Tecnicos"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function cnsLineas(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_Lineas", "", "IdLinea", "Nombre")
        forma.text = "Consulta de las Lineas de Credito"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function cnsDeduccionesPrestamo(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_DeduccionesPrestamo", "", "IdDeduccion", "Nombre")
        forma.text = "Consulta los Tipos de Deducciones"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function cnsFormasPagoCaja(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_FormasPagoCaja", "", "IdFormaPago", "Nombre")
        forma.text = "Consulta de Formas de Pago "
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function cnsTiposMovimientoCaja(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_TiposMovimientoCaja", "", "IdTipo", "Nombre")
        forma.text = "Consulta de Tipos de Movimiento de Caja"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function ConsultaCuentaCorriente(ByVal forma As Object, ByVal IdAsociado As Integer) As String
        forma.cnsDataTable = dl.ConsultaCuentaCorriente(IdAsociado)
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultaCuentaAhorro(ByVal forma As Object, ByVal IdAsociado As Integer) As String
        forma.cnsDataTable = dl.ConsultaCuentaAhorro(IdAsociado)
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultaFiadores(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaFiadores()
        forma.showdialog()
        Return forma.ValCodigo
    End Function
    Public Function ConsultaSolicitudRetiro(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaSolicitudRetiro()
        forma.showdialog()
        Return forma.ValCodigo
    End Function
    Public Function ConsultaSolicitudRetiroAprobadas(ByVal forma As Object, ByVal FechaContable As DateTime, ByVal RetiroTotal As Boolean) As String
        forma.cnsDataTable = dl.ConsultaSolicitudRetiroAprobadas(FechaContable, RetiroTotal)
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultaPlanillasAplicadas(ByVal forma As Object) As String
        forma.cnsDataTable = dl.ConsultaPlanillasAplicadas()
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultaSolicitudFondos(ByVal forma As Object) As String

        forma.cnsDataTable = dl.ConsultaSolicitudFondos()
        'forma.PrimaryKey = "IdSolicitudFondo"
        forma.text = "Consulta de Solicitud de Fondos"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultaCantones(ByVal forma As Object) As String

        forma.cnsDataTable = dl.ConsultaCantones()
        'forma.PrimaryKey = "Id"
        forma.text = "Consulta de Cantones"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function ConsultacuentasGastos(ByVal forma As Object) As Integer

        forma.cnsDataTable = dl.ConsultaCuentasGasto()
        'forma.PrimaryKey = "Id"
        forma.text = "Consulta de Cuentas Gasto"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function
#End Region

    Public Function cnsTiposOperacionNumerario(ByVal forma As Object) As Integer
        dl.CargaCns(forma, "coo_TiposOperacionNumerario", "", "IdTipoOperacion", "Nombre")
        forma.text = "Consulta de Tipos de Operación de Numerario"
        forma.showdialog()
        If forma.ValCodigo = "" Then
            Return 0
        End If
        Return forma.ValCodigo
    End Function

    Public Function ConsultaOperacionNumerario(ByVal forma As Object) As String

        forma.cnsDataTable = dl.ConsultaOperacionNumerario()
        'forma.PrimaryKey = "IdSolicitud"
        forma.text = "Consulta de Operaciones Numerario"
        forma.showdialog()
        Return forma.ValCodigo
    End Function

    Public Function cnsProveedores(ByRef forma As Object, ByVal IdProveedor As String) As com_Proveedores
        Dim entProveedor As New com_Proveedores

        'Al llenar la entidad ya no se llama la consulta
        If Not IdProveedor = "" And Not IdProveedor Is Nothing Then
            entProveedor = td.com_ProveedoresSelectByPK(IdProveedor)
        End If

        If entProveedor.IdProveedor = "" Then
            dl.CargaCns(forma, "com_Proveedores", "", "IdProveedor", "Nombre", "Nrc", "Telefonos")
            forma.Text = "Consulta de proveedores"
            forma.showdialog()
            If Not forma.ValCodigo = "" Then
                entProveedor = td.com_ProveedoresSelectByPK(forma.ValCodigo)
            End If

        End If
        Return entProveedor
    End Function
    Public Function cnsProveedoresEmpleados(ByRef forma As Object, ByVal Id As Integer) As Integer
        Dim ent As New coo_CuentasGastos

        'Al llenar la entidad ya no se llama la consulta, favor revisar ese codigo quemado de 20
        If Id > 0 Then
            ent = td.coo_CuentasGastosSelectByPK(20, Id)
        End If

        If ent.IdCuenta = 0 Then
            dl.CargaCns(forma, "coo_CuentasGastos", "IdRubro=20", "IdCuenta", "Nombre")
            forma.Text = "Consulta de proveedores y empleados"
            forma.showdialog()
        End If
        Return forma.ValCodigo
    End Function
End Class
