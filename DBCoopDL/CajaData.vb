Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports DBCoopEL.TableEntities
Imports System.Data.Common
Public Class CajaData
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTabla As New TableData

    Function ObtieneParametros() As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from adm_parametros").Tables(0)
    End Function
    Public Function ObtenerImpresorDefault(ByVal IdUsuario As String) As String
        Dim sql As String = String.Format("select ImpresorPredeterminado from adm_Usuarios where IdUsuario='{0}'", IdUsuario)
        Return db.ExecuteScalar(CommandType.Text, sql)

    End Function
    Public Function VerificaUsuarioCajeroVerCorte(ByVal IdUsuario As String) As Boolean
        Dim sql As String = String.Format("select 1 from adm_Usuarios where IdUsuario='{0}' and PuedeVerCorte=1", IdUsuario)
        Return db.ExecuteScalar(CommandType.Text, sql) = 1
    End Function
    Public Function VerificaUsuarioCajeroVerCorte(ByVal IdUsuario As String, ByVal Contrasenia As String) As Boolean
        Dim sql As String = String.Format("select 1 from adm_Usuarios where IdUsuario='{0}' and Clave = '{1}' and PuedeVerCorte=1", IdUsuario, Contrasenia)
        Return db.ExecuteScalar(CommandType.Text, sql) = 1
    End Function
    Public Function rptFacturaPopular(ByVal IdSucursal As String, ByVal IdFormaPago As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spFacturaPopular", IdSucursal, IdFormaPago, Fecha).Tables(0)
    End Function
    Public Function rptIngresoAportacion(ByVal NumeroComp As String, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteIngresoAportacion", NumeroComp, IdAsociado).Tables(0)
    End Function
    Public Function rptIngresoAyudaFuneraria(ByVal NumeroComp As String, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteIngresoAyudaFune", NumeroComp, IdAsociado).Tables(0)
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
    'Public Function rptDepositoAhorro(ByVal IdCuenta As Integer, ByVal IdMov As Integer) As DataTable
    '    Return db.ExecuteDataSet("coo_spComprobanteDepositoAhorro", IdCuenta, IdMov).Tables(0)
    'End Function
    Public Function rptDepositoAhorroIdMov(ByVal IdMov As Integer, ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteDepositoAhorroIdMov", IdMov, IdCuenta).Tables(0)
    End Function

    Public Function rptReciboPagoIdMov(ByVal IdPrestamo As Integer, ByVal IdMov As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spReciboPagoPrestamo", IdPrestamo, IdMov).Tables(0)
    End Function

    Public Function rptCorteCaja(ByVal IdSucursal As Integer, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCaja", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function
    Public Function rptIngresosEgresos(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime, ByVal IdUsuario As String) As DataTable
        Return db.ExecuteDataSet("coo_spIngresosEgresosCaja", IdSucursal, DesdeFecha, HastaFecha, IdUsuario).Tables(0)
    End Function
    Public Function ConsultaCuentaCorriente(ByVal IdAsociado As Integer) As DataTable
        Dim sSQL As String
        sSQL = "SELECT ca.IdCuenta, ca.Numero, aso.Nombres, aso.Apellidos, ca.FechaHoraCreacion from coo_CuentasAhorro ca "
        sSQL &= " inner join coo_asociados aso on ca.IdAsociado=aso.IdAsociado where ca.IdTipoCuenta=1"
        sSQL &= " and ca.IdAsociado = " & IdAsociado & "Order By IdCuenta DESC "
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function ConsultaCuentaAhorro() As DataTable
        Dim sSQL As String
        sSQL = "SELECT ca.IdCuenta, ca.Numero,TipoCuenta=tp.Nombre,ca.FechaApertura,aso.Nombres, aso.Apellidos,aso.RazonSocial,aso.NumeroDocumento,FechaHoraCreacion=ca.FHCreacion from coo_CuentasAhorro ca "
        sSQL &= " inner join coo_asociados aso on ca.IdAsociado=aso.IdAsociado inner join coo_TiposCuentaAhorro tp on ca.IdTipoCuenta=tp.IdTipo "
        sSQL &= " Order By IdCuenta DESC "

        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function GetSaldoCapitalPrestamo(ByVal IdPrestamo As Integer) As Decimal
        Dim SaldoCapital As Decimal = db.ExecuteScalar("coo_spGetSaldoCapitalPrestamo", IdPrestamo)
        Return SaldoCapital
    End Function
    Public Sub CargaCombo(ByRef Combo As Object _
                       , ByVal Tabla As String _
                      , ByVal ValueMember As String _
                      , ByVal DisplayMember As String _
                      , ByVal sCondic As String _
                      , Optional ByVal sTipoSelect As String = "")

        Dim sSQL As String = ""
        If sCondic <> "" Then
            sCondic = " where " & sCondic   'no incluir el and en la condicion en la primer condicion del where
        End If
        If sTipoSelect <> "" Then
            sSQL = "select top 1 -1 " & ValueMember & ", '" & sTipoSelect & "' " & DisplayMember & " from " & tabla & " union all "
        End If
        sSQL &= String.Format("select {0},{1} from {2} {3} order by {0}", ValueMember, DisplayMember, tabla, sCondic)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)

        With combo.Properties
            .DisplayMember = "Nombre"
            .ValueMember = ValueMember
            .datasource = dl
        End With
        Try
            combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub
    Public Function coo_SolicitudFondosRefinanciaSelectByFondo _
      (ByVal IdSolicitudFondo As System.Int32) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudFondosRefinanciaSelectByFondo", _
         IdSolicitudFondo).Tables(0)
    End Function
    '
    Public Function coo_SolicitudDescuentosSelectBySolicitud _
  (ByVal IdSolicitud As System.Int32) As DataTable
        Return db.ExecuteDataSet("coo_SolicitudDescuentosSelectBySolicitud", _
         IdSolicitud).Tables(0)
    End Function
    Public Function rptMovimientoCuentaAhorro(ByVal IdCuenta As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spMovimientoCuentaAhorro", IdCuenta, DesdeFecha, HastaFecha).Tables(0)
    End Function
    Public Function rptRetiroAhorro(ByVal NumeroComp As String, ByVal IdCuenta As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spComprobanteRetiroAhorro", NumeroComp, IdCuenta).Tables(0)
    End Function
    Public Function ExisteNumComprobanteDesembolso(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdPrestamo,Numero from coo_PrestamosDetalle where Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function ExisteNumComprobanteIngreso(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdPrestamo,Numero from coo_PrestamosDetalle where Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function ExisteNumPrestamo(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdPrestamo,Numero from coo_Prestamos where Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function VerificaSeguroCobrado(ByVal IdPrestamo As Integer, ByVal Mes As Integer, ByVal Periodo As Integer) As Integer
        Dim sSql As String = "SELECT TOP 1  Count(*) FROM coo_PrestamosDetalle WHERE IdPrestamo=" & IdPrestamo & " AND month(FEcha)=" & Mes & " AND year(FEcha)=" & Periodo & " AND ValorSeguroPagado>0"
        Dim Cobrado As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return Cobrado
    End Function
    Public Function coo_GarantiasCuentaPignoradaSelectBySolicitud _
(ByVal IdSolicitud As System.Int32 _
) As DataTable
        Return db.ExecuteDataSet("coo_GarantiasCuentaPignoradaBySolicitud", _
         IdSolicitud _
         ).Tables(0)
    End Function



    Public Function coo_PignoracionesSelectByCuenta _
   (ByVal IdCuenta As System.Int32 _
   ) As coo_Pignoraciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PignoracionesSelectByCuenta", _
         IdCuenta _
         ).Tables(0)
        Dim Entidad As New coo_Pignoraciones
        If dt.Rows.Count > 0 Then
            Entidad.IdPignoracion = dt.Rows(0).Item("IdPignoracion")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.FechaPignoracion = dt.Rows(0).Item("FechaPignoracion")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.Activa = dt.Rows(0).Item("Activa")
            Entidad.Manual = dt.Rows(0).Item("Manual")
            Entidad.FechaReversion = SiEsNulo(dt.Rows(0).Item("FechaReversion"), Nothing)
            Entidad.RevertidoPor = SiEsNulo(dt.Rows(0).Item("RevertidoPor"), Nothing)
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function
    Public Function ExistePrestamo(ByVal IdSolicitud As Integer) As Integer
        Dim Prestamo As Integer
        Dim sSql As String = "select IdPrestamo from coo_Prestamos where IdSolicitud=" & IdSolicitud
        Prestamo = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return Prestamo
    End Function
    Public Function CalculaSaldoPres(ByVal IdPrestamo As Integer, ByVal IdAsociado As Integer, ByVal HastaFecha As DateTime, ByVal CancelarEfectivo As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spCalculaSaldosPrestamo", IdPrestamo, IdAsociado, HastaFecha, CancelarEfectivo).Tables(0)
    End Function
    Public Function ConsultaPrestamos() As DataTable

        Dim sSQL As String
        sSQL = "SELECT NumeroPrestamo=pre.numero,pre.FechaOtorgado,aso.Nombres, aso.Apellidos,aso.RazonSocial,aso.NumeroDocumento,Linea=li.Nombre,FechaHoraCreacion=pre.FHCreacion from coo_Prestamos pre "
        sSQL &= " inner join coo_asociados aso on pre.IdAsociado=aso.IdAsociado inner join coo_Lineas li on pre.IdLinea=li.IdLinea "
        sSQL &= " Order By IdPrestamo DESC "

        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function
    Public Function ExisteSolicitudPrestamo(ByVal IdSolicitud As Integer) As String
        Dim Numero As String
        Dim sSql As String = "select Numero from coo_Prestamos where IdSolicitud=" & IdSolicitud
        Numero = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return Numero
    End Function
    Public Function ValorPapeleriaDesembolso(ByVal IdSolicitudFondo As Integer) As Decimal

        Dim sql As String = "select Papeleria=sum(sfd.Valor) from coo_SolicitudFondosDeducciones sfd inner join coo_deduccionesPrestamo dp on sfd.IdDeduccion=dp.IdDeduccion where dp.AplicaIva=1 and sfd.IdDeduccion=1 and sfd.IdSolicitudFondo=" & IdSolicitudFondo
        Return SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0.0)

    End Function
    Public Function ValorFPP(ByVal IdSolicitudFondo As Integer) As Decimal
        Dim sql As String = "select FPP=sum(sfd.Valor) from coo_SolicitudFondosDeducciones sfd inner join coo_deduccionesPrestamo dp on sfd.IdDeduccion=dp.IdDeduccion where dp.AplicaIva=0 and sfd.IdDeduccion=2 and sfd.IdSolicitudFondo=" & IdSolicitudFondo
        Return SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0.0)

    End Function

    Public Function ValorChequesDesembolso(ByVal IdSolicitud As Integer) As Decimal

        Dim sql As String = "select Cheque=sum(Valor) from coo_SolicitudesEmisionDesembolso where IdSolicitud=" & IdSolicitud
        Return SiEsNulo(db.ExecuteScalar(CommandType.Text, sql), 0.0)

    End Function
    Public Function ExisteComprobanteAportacion(ByVal Numero As String) As String
        Dim sSql As String = "select NumeroDoc from coo_Aportaciones where NumeroDoc= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function ExisteComprobanteAyudaFune(ByVal Numero As String) As String
        Dim sSql As String = "select NumeroDoc from coo_MovFuneraria where NumeroDoc= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function

    Public Function ExisteComprobanteRemision(ByVal Numero As String, ByVal IdSucursal As Integer) As String
        Dim sSql As String = "select Numero from coo_OperacionesCaja where Numero= '" & Numero & "' and Tipo=2 " & " and IdSucursal=" & IdSucursal
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function ExisteComprobanteRequisicion(ByVal Numero As String, ByVal IdSucursal As Integer) As String
        Dim sSql As String = "select Numero from coo_OperacionesCaja where Numero= '" & Numero & "' and Tipo=1 " & " and IdSucursal=" & IdSucursal
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function IdMovComprobanteIngreso(ByVal Numero As String, ByVal prefijo As String) As Integer
        Dim sSql As String = "select IdMov from coo_OtrosIngresos where Numero= '" & Numero & "' And PrefijoNumero='" & prefijo & "'"
        Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function IdMovComprobanteEgreso(ByVal Numero As String) As Integer
        Dim sSql As String = "select IdMov from coo_OtrosEgresos where Numero= '" & Numero & "'"
        Dim NumeroReg As Integer = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), 0)
        Return NumeroReg
    End Function
    Public Function IdMovComprobanteIngreso(ByVal Numero As String) As String
        Dim sSql As String = "select Numero from coo_OtrosIngresos where Numero= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function ExisteComprobanteEgreso(ByVal Numero As String) As String
        Dim sSql As String = "select Numero from coo_OtrosEgresos where Numero= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function ExisteComprobanteDeposito(ByVal Numero As String) As String
        Dim sSql As String = "select NumeroDoc from coo_CuentasAhorroMov where IdTipo= 1 and NumeroDoc= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function coo_AportacionesSelectNoImpresos(ByVal IdAsociado As Integer) As DataTable
        Dim sSql As String = "select * from coo_Aportaciones where Impreso= 'False' AND IdAsociado= " & IdAsociado & " ORDER BY Fecha "
        Return db.ExecuteDataSet(CommandType.Text, sSql).Tables(0)
    End Function
    Public Function coo_AportacionesSelect(ByVal IdAsociado As Integer) As DataTable
        Dim sSql As String = "select * from coo_Aportaciones where IdAsociado= " & IdAsociado & " ORDER BY Fecha "
        Return db.ExecuteDataSet(CommandType.Text, sSql).Tables(0)
    End Function

    Public Function coo_AhorrosSelect(ByVal IdCuenta As Integer) As DataTable
        Dim sSql As String = "select * from coo_CuentasAhorroMov where IdCuenta= " & IdCuenta & " ORDER BY Fecha "
        Return db.ExecuteDataSet(CommandType.Text, sSql).Tables(0)
    End Function

    Public Function coo_AhorrosSelectNoImpresos(ByVal IdCuenta As Integer) As DataTable
        Dim sSql As String = "select * from coo_CuentasAhorroMov where Impreso= 'False' AND IdCuenta= " & IdCuenta & " ORDER BY Fecha "
        Return db.ExecuteDataSet(CommandType.Text, sSql).Tables(0)
    End Function

    Public Function ExisteComprobanteRetiro(ByVal Numero As String) As String
        Dim sSql As String = "select NumeroDoc from coo_CuentasAhorroMov where IdTipo= 2 and NumeroDoc= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function UltMovReferencia(ByVal Numero As String, ByVal IDPrestamo As Integer) As Integer
        Dim sSql As String = "select max(IdMov) from coo_PrestamosDetalle where IdPrestamo=" & IDPrestamo & " and Numero= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function
    Public Function SolicitudRetiro(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spSolicitudRetiro", IdAsociado, Fecha).Tables(0)
    End Function

    Public Function ExisteComprobantePago(ByVal Numero As String) As String
        Dim sSql As String = "select Numero from coo_PrestamosDetalle where Numero= '" & Numero & "'"
        Dim NumeroReg As String = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSql), "")
        Return NumeroReg
    End Function

    Public Function coo_PagosPrestamoParalibreta(ByVal IdPrestamo As Integer) As DataTable
        Dim sSql As String = "select * from coo_PrestamosDetalle where IdPrestamo= " & IdPrestamo & " ORDER BY Fecha "
        Return db.ExecuteDataSet(CommandType.Text, sSql).Tables(0)
    End Function


    Public Function InsertaPrimerDesembolso _
(ByRef entPrestamo As coo_Prestamos, ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByRef entPlan As List(Of coo_PrestamosPlanPagos), _
ByRef IdFondo As Integer, ByRef IdMunicipio As String, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones, ByRef entCancelacion As List(Of coo_PrestamosDetalle), ByRef entPignora As List(Of coo_Pignoraciones)) As String
        Dim cn As DbConnection = db.CreateConnection
        Dim IdMovAporta As Integer = 0
        Dim SaldoAportacion As Decimal = 0.0
        Dim LinealibretaAportacion As Integer = 0
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            entPrestamo.IdPrestamo = ObtenerUltimoID("Coo_Prestamos", "IdPrestamo") + 1
            Dim IdPignoracion As Integer = ObtenerUltimoID("Coo_Pignoraciones", "IdPignoracion") + 1

            objTabla.coo_PrestamosInsert(entPrestamo, tran)

            entDesembolso.IdPrestamo = entPrestamo.IdPrestamo
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo) + 1

            'se inserta el desembolso
            'obtenemos el numero correlativo del desembolso
            Dim sql As String = "update adm_Sucursales set CorrelativoDesembolso = CorrelativoDesembolso + 1 where IdSucursal=" & entDesembolso.IdSucursal
            sql &= ";select CorrelativoDesembolso from adm_Sucursales where IdSucursal=" & entDesembolso.IdSucursal
            entDesembolso.Numero = entPrestamo.IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")

            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            'SE HA DESACTIVADO EL DESEMBOLSO A LA CUENTA DE AHORRO PARA CONCHAGUA
            'If entDeposito.Valor > 0.0 Then
            '    Dim dtDeposito As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entDeposito.IdCuenta).Tables(0)
            '    entDeposito.IdMov = (dtDeposito.Rows(0).Item("IdMov")) + 1
            '    entDeposito.Saldo = (dtDeposito.Rows(0).Item("SaldoActual")) + entDeposito.Valor
            '    entDeposito.LineaLibreta = (dtDeposito.Rows(0).Item("Linea")) + 1
            '    coo_CuentasAhorroMovInsert(entDeposito, tran)
            'End If

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

            'se le asigna el mismo correlativo de desembolso
            entLiquidacion.NumeroComprobante = entDesembolso.Numero
            entLiquidacion.IdPrestamo = entPrestamo.IdPrestamo
            objTabla.coo_PrestamosDesembolsoInsert(entLiquidacion, tran)

            For Each detalle As coo_PrestamosPlanPagos In entPlan
                detalle.IdPrestamo = entPrestamo.IdPrestamo
                objTabla.coo_PrestamosPlanPagosInsert(detalle, tran)
            Next

            For Each detalle As coo_PrestamosDetalle In entCancelacion
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            For Each detalle As coo_Pignoraciones In entPignora
                detalle.IdPignoracion = IdPignoracion
                detalle.IdPrestamo = entDesembolso.IdPrestamo
                objTabla.coo_PignoracionesInsert(detalle, tran)
                IdPignoracion = IdPignoracion + 1
            Next

            sql = "update coo_SolicitudFondos set entregado = 'True' WHERE IdSolicitudFondo=" & IdFondo
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


    Public Function InsertaDesembolso _
(ByRef entDesembolso As coo_PrestamosDetalle _
, ByRef entDeposito As coo_CuentasAhorroMov, ByVal IdFondo As Integer, ByRef entLiquidacion As coo_PrestamosDesembolso, _
ByRef entSimultaneo As coo_CuentasAhorroMov, ByRef entAportacion As coo_Aportaciones, _
ByRef entCapitalizacion As coo_Aportaciones, ByRef entCancelacion As List(Of coo_PrestamosDetalle), ByRef entPignora As List(Of coo_Pignoraciones), ByRef entSolicitud As coo_Solicitudes) As String
        Dim cn As DbConnection = db.CreateConnection
        Dim IdMovAporta As Integer = 0
        Dim SaldoAportacion As Decimal = 0.0
        Dim LinealibretaAportacion As Integer = 0

        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            'TODO Calcula correlativos y los actualiza en las entidades
            Dim IdPignoracion As Integer = ObtenerUltimoID("Coo_Pignoraciones", "IdPignoracion") + 1
            entDesembolso.IdMov = GetUltMovPrestamo(entDesembolso.IdPrestamo) + 1
            objTabla.coo_PrestamosDetalleInsert(entDesembolso, tran)

            Dim dtDeposito As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", entDeposito.IdCuenta).Tables(0)
            entDeposito.IdMov = (dtDeposito.Rows(0).Item("IdMov")) + 1
            entDeposito.Saldo = (dtDeposito.Rows(0).Item("SaldoActual")) + entDeposito.Valor
            entDeposito.LineaLibreta = (dtDeposito.Rows(0).Item("Linea")) + 1


            'se inserta el desembolso
            'obtenemos el numero correlativo del desembolso
            Dim sql As String = "update adm_Sucursales set CorrelativoDesembolso = CorrelativoDesembolso + 1 where IdSucursal=" & entDesembolso.IdSucursal
            sql &= ";select CorrelativoDesembolso from adm_Sucursales where IdSucursal=" & entDesembolso.IdSucursal
            entDesembolso.Numero = entDesembolso.IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")


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
                If entAportacion.IdAsociado = 0 Then
                    IdMovAporta = (db.ExecuteScalar("coo_spGetUlMovAporta", entCapitalizacion.IdAsociado))
                    SaldoAportacion = (db.ExecuteScalar("coo_spGetSaldoAporta", entCapitalizacion.IdAsociado))
                    LinealibretaAportacion = (db.ExecuteScalar("coo_spGetUltLineaAporta", entCapitalizacion.IdAsociado))
                Else
                    IdMovAporta = (db.ExecuteScalar("coo_spGetUlMovAporta", entAportacion.IdAsociado))
                    SaldoAportacion = (db.ExecuteScalar("coo_spGetSaldoAporta", entAportacion.IdAsociado))
                    LinealibretaAportacion = (db.ExecuteScalar("coo_spGetUltLineaAporta", entAportacion.IdAsociado))
                End If
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

            For Each detalle As coo_PrestamosDetalle In entCancelacion
                objTabla.coo_PrestamosDetalleInsert(detalle, tran)
            Next

            For Each detalle As coo_Pignoraciones In entPignora
                detalle.IdPignoracion = IdPignoracion
                detalle.IdPrestamo = entDesembolso.IdPrestamo
                objTabla.coo_PignoracionesInsert(detalle, tran)
                IdPignoracion = IdPignoracion + 1
            Next

            Dim sSQL As String = "update coo_SolicitudFondos set entregado = 'True' WHERE IdSolicitudFondo=" & IdFondo
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            Dim sSQL2 As String = "update coo_Prestamos set AplicaDescuento=" & entSolicitud.AplicaDescuento & ", MontoDesembolsado= MontoDesembolsado + " & entLiquidacion.MontoDesembolso & " WHERE IdPrestamo=" & entLiquidacion.IdPrestamo
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL2)

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try
        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function InsertaAportacion(ByRef entAportacion As coo_Aportaciones) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_AportacionesInsert(entAportacion, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoPago = CorrelativoPago + 1 WHERE IdSucursal=" & entAportacion.IdSucursal
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

    Public Function InsertaAyudaFuneraria(ByRef entAyuda As coo_MovFuneraria) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_MovFunerariaInsert(entAyuda, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoPago = CorrelativoPago + 1 WHERE IdSucursal=" & entAyuda.IdSucursal
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

    Public Function ActualizaImpresoAhorro _
(ByVal IdCuenta As Integer, ByVal IdMov As Integer, ByVal Impreso As Boolean) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            Dim sql As String = "update coo_CuentasAhorroMov set Impreso ='" & Impreso & "' WHERE IdCuenta=" & IdCuenta & " AND IdMov= " & IdMov
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

    Public Function ActualizaImpresoAportacion _
(ByVal IdAsociado As Integer, ByVal IdMov As Integer, ByVal Impreso As Boolean) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            Dim sql As String = "update coo_Aportaciones set Impreso ='" & Impreso & "' WHERE IdAsociado=" & IdAsociado & " AND IdMov= " & IdMov
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


    Public Function InsertaRemision _
(ByRef entRemision As coo_OperacionesCaja, ByVal IdSucursal As Integer) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_OperacionesCajaInsert(entRemision, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoRemision = CorrelativoRemision + 1 WHERE IdSucursal=" & IdSucursal
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

    Public Function InsertaRequisicion(ByRef entRemision As coo_OperacionesCaja, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_OperacionesCajaInsert(entRemision, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoRequisicion = CorrelativoRequisicion + 1 WHERE IdSucursal=" & IdSucursal
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
    Public Function InsertaDeposito(ByRef entidad As coo_CuentasAhorroMov, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            If IdSucursal > 0 Then  'se debe actualizar el correlativo de documento
                Dim sql As String = "update adm_Sucursales set CorrelativoDeposito = CorrelativoDeposito + 1, CorrelativoRetiro = CorrelativoRetiro + 1 where IdSucursal=" & IdSucursal
                sql &= ";select CorrelativoDeposito from adm_Sucursales where IdSucursal=" & IdSucursal
                entidad.NumeroDoc = IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")
            End If
            objTabla.coo_CuentasAhorroMovInsert(entidad, tran)

            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try


        Return msj
    End Function
    Public Function InsertaRetiro(ByRef entidad As coo_CuentasAhorroMov, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            If IdSucursal > 0 Then  'se debe actualizar el correlativo de documento
                Dim sql As String = "update adm_Sucursales set CorrelativoDeposito = CorrelativoDeposito + 1, CorrelativoRetiro = CorrelativoRetiro + 1 where IdSucursal=" & IdSucursal
                sql &= ";select CorrelativoRetiro from adm_Sucursales where IdSucursal=" & IdSucursal
                entidad.NumeroDoc = IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(tran, CommandType.Text, sql)).ToString.PadLeft(6, "0")
            End If
            objTabla.coo_CuentasAhorroMovInsert(entidad, tran)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj
    End Function

    Public Function InsertaCancelacionAhorro(ByRef entCuentaAhorroMov As coo_CuentasAhorroMov, ByRef entInteres As coo_CuentasAhorroMov, _
 ByRef entIsr As coo_IsrInteres, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            entIsr.IdIsr = ObtenerUltimoID("Coo_IsrInteres", "IdIsr") + 1
            If entInteres.Valor <> 0 Then
                If entInteres.IdTipo = 4 Then
                    objTabla.coo_CuentasAhorroMovInsert(entInteres, tran)
                End If
                If entIsr.Isr <> 0 Then
                    If entIsr.Idtipo = 4 Then
                        objTabla.coo_IsrInteresInsert(entIsr, tran)
                    End If
                End If
            End If
            objTabla.coo_CuentasAhorroMovInsert(entCuentaAhorroMov, tran)

            Dim sql As String = "update adm_Sucursales set CorrelativoDeposito = CorrelativoDeposito + 1, CorrelativoRetiro = CorrelativoRetiro + 1 WHERE IdSucursal=" & IdSucursal
            db.ExecuteNonQuery(tran, CommandType.Text, sql)

            sql = "update coo_CuentasAhorro set IdEstado = 4 WHERE IdCuenta=" & entCuentaAhorroMov.IdCuenta
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

    Public Function AplicarPago(ByRef entPago As coo_PrestamosDetalle, _
                       ByVal entAhorro As coo_CuentasAhorroMov, _
                       ByVal entAportacion As coo_Aportaciones, ByVal IdSucursal As String) As String

        Dim cn As DbConnection = db.CreateConnection()
        cn.Open()
        Dim trans As DbTransaction = cn.BeginTransaction
        Dim msj = ""
        Try

            entPago.IdMov = GetUltMovPrestamo(entPago.IdPrestamo) + 1

            If entPago.SaldoCapital = 0 Then 'este codigo hacerle un update de un solo, sin llamar la clase
                'Dim entPrestamo As coo_Prestamos = coo_PrestamosSelectByPK(entPago.IdPrestamo)
                'entPrestamo.IdEstado = 3 'Cancelado
                'coo_PrestamosUpdate(entPrestamo, trans)
                Dim sql As String = "update coo_Prestamos set IdEstado = 3 WHERE IdPrestamo = " & entPago.IdPrestamo
                db.ExecuteNonQuery(trans, CommandType.Text, sql)
            End If
            '
            If IdSucursal > 0 Then  'se debe actualizar el correlativo de documento
                Dim sql As String = "update adm_Sucursales set CorrelativoPago = CorrelativoPago + 1 where IdSucursal=" & IdSucursal
                sql &= ";select CorrelativoPago from adm_Sucursales where IdSucursal=" & IdSucursal
                entPago.Numero = IdSucursal.ToString.PadLeft(2, "0") & "-" & (db.ExecuteScalar(trans, CommandType.Text, sql)).ToString.PadLeft(6, "0")
            End If
            'teNumeroDoc.EditValue = String.Format("{0}-{1}", glIdSucursal.ToString.PadLeft(2, "0"), (entSucursal.CorrelativoPago + 1).ToString.PadLeft(6, "0"))
            objTabla.coo_PrestamosDetalleInsert(entPago, trans)

            If entAhorro.Valor <> 0 Then
                entAhorro.NumeroDoc = "P/" & entPago.Numero
                objTabla.coo_CuentasAhorroMovInsert(entAhorro, trans)
            End If
            If entAportacion.IdAsociado > 0 Then
                entAportacion.NumeroDoc = "P/" & entPago.Numero
                objTabla.coo_AportacionesInsert(entAportacion, trans)
            End If

            trans.Commit()
        Catch ex As Exception
            trans.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try
        Return msj
    End Function

    Public Function InsertaOtrosIngresos(ByRef entOtrosIngresos As coo_OtrosIngresos, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_OtrosIngresosInsert(entOtrosIngresos, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoPago = CorrelativoPago + 1 WHERE IdSucursal=" & IdSucursal
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

    Public Function InsertaOtrosEgresos(ByRef entOtrosEgresos As coo_OtrosEgresos, ByVal IdSucursal As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj = ""
        Try
            objTabla.coo_OtrosEgresosInsert(entOtrosEgresos, tran)
            Dim sql As String = "update adm_Sucursales set CorrelativoEgresos = CorrelativoEgresos + 1 WHERE IdSucursal=" & IdSucursal
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

    

    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Dim IdMov As Integer = db.ExecuteScalar("coo_spGetUlMovPrestamo", IdPrestamo)
        Return IdMov
    End Function

    Public Function GetUltMovIsr() As Integer
        Dim IdIsr As Decimal = db.ExecuteScalar("coo_spGetUlMovIsr")
        Return IdIsr
    End Function

    Public Function rptContratoAhorro(ByVal IdCuenta As Integer) As coo_ContratoAhorro

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spContratoAhorro", IdCuenta).Tables(0)

        Dim Entidad As New coo_ContratoAhorro
        If dt.Rows.Count > 0 Then
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroAsociado = dt.Rows(0).Item("NumeroAsociado")
            Entidad.NombreAsociado = dt.Rows(0).Item("NombreAsociado")
            Entidad.Profesion = dt.Rows(0).Item("Profesion")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.NombreCuenta = dt.Rows(0).Item("NombreCuenta")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.Municipio = dt.Rows(0).Item("Municipio")
            Entidad.NumeroDocumento = dt.Rows(0).Item("NumeroDocumento")
            Entidad.TasaApertura = dt.Rows(0).Item("TasaApertura")

        End If
        Return Entidad
    End Function

    Public Function rptDeclaracionJurada(ByVal IdCuenta As Integer, ByVal IdMov As Integer) As coo_DeclaracionJurada

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spDeclaracionJurada", IdCuenta, IdMov).Tables(0)

        Dim Entidad As New coo_DeclaracionJurada
        If dt.Rows.Count > 0 Then
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroAsociado = dt.Rows(0).Item("NumeroAsociado")
            Entidad.NombreAsociado = dt.Rows(0).Item("NombreAsociado")
            Entidad.Profesion = dt.Rows(0).Item("Profesion")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.NombreCuenta = dt.Rows(0).Item("NombreCuenta")
            Entidad.Municipio = dt.Rows(0).Item("Municipio")
            Entidad.Dui = dt.Rows(0).Item("Dui")
            Entidad.TasaApertura = dt.Rows(0).Item("TasaApertura")
            Entidad.Nit = dt.Rows(0).Item("Nit")
            Entidad.FechaApertura = dt.Rows(0).Item("FechaApertura")
            Entidad.MontoApertura = dt.Rows(0).Item("MontoApertura")
            Entidad.Sucursal = dt.Rows(0).Item("Sucursal")
            Entidad.OrigenFondos = dt.Rows(0).Item("OrigenFondos")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
        End If
        Return Entidad
    End Function

    Public Function coo_PrestamosSelectByNumero(ByVal Numero As String) As coo_Prestamos

        Dim dt As DataTable = db.ExecuteDataSet("coo_spPrestamosSelectByNumero", _
         Numero).Tables(0)

        Dim Entidad As New coo_Prestamos
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.MontoAprobado = dt.Rows(0).Item("MontoAprobado")
            Entidad.FechaAprobado = dt.Rows(0).Item("FechaAprobado")
            Entidad.FechaOtorgado = dt.Rows(0).Item("FechaOtorgado")
            Entidad.MontoDesembolsado = dt.Rows(0).Item("MontoDesembolsado")
            Entidad.MesesGracia = dt.Rows(0).Item("MesesGracia")
            Entidad.DiasMoraGracia = dt.Rows(0).Item("DiasMoraGracia")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
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
            Entidad.IdTecnico = dt.Rows(0).Item("IdTecnico")
            Entidad.IdLinea = dt.Rows(0).Item("IdLinea")
            Entidad.IdFuente = dt.Rows(0).Item("IdFuente")
            Entidad.IdTipoCartera = dt.Rows(0).Item("IdTipoCartera")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.IdTipoPrestamo = dt.Rows(0).Item("IdTipoPrestamo")
            Entidad.TipoCuota = dt.Rows(0).Item("TipoCuota")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
        End If
        Return Entidad
    End Function

    Public Function coo_OperacionesCajaSelectByNumero _
  (ByVal IdSucursal As Integer, ByVal Numero As String, ByVal Tipo As Integer _
  ) As coo_OperacionesCaja

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_OperacionesCajaSelectByNumero", _
         IdSucursal, Numero, Tipo _
         ).Tables(0)

        Dim Entidad As New coo_OperacionesCaja
        If dt.Rows.Count > 0 Then
            Entidad.IdOperacion = dt.Rows(0).Item("IdOperacion")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Tipo = dt.Rows(0).Item("Tipo")
            Entidad.Monto = dt.Rows(0).Item("Monto")
            Entidad.Concepto = dt.Rows(0).Item("Concepto")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.Excluir = dt.Rows(0).Item("Excluir")

        End If
        Return Entidad
    End Function

    Public Function coo_LiquidacionesSelectByNumero _
      (ByVal IdSucursal As System.Int32, ByVal Numero As String _
      ) As coo_Liquidaciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spLiquidacionesSelectByNumero", _
         IdSucursal, Numero _
         ).Tables(0)

        Dim Entidad As New coo_Liquidaciones
        If dt.Rows.Count > 0 Then
            Entidad.IdComprobante = dt.Rows(0).Item("IdComprobante")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.IdCuentaProveedor = dt.Rows(0).Item("IdCuentaProveedor")
            Entidad.NombreProveedor = dt.Rows(0).Item("NombreProveedor")
            Entidad.TotalGastos = dt.Rows(0).Item("TotalGastos")
            Entidad.TotalAnticipo = dt.Rows(0).Item("TotalAnticipo")
            Entidad.Reintegro = dt.Rows(0).Item("Reintegro")
            Entidad.Concepto = dt.Rows(0).Item("Concepto")
            Entidad.Cancelado = dt.Rows(0).Item("Cancelado")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = dt.Rows(0).Item("FechaHoraModificacion")

        End If
        Return Entidad
    End Function


    Public Function coo_DocumentosSelectByPK(ByVal Documento As String) As coo_Documentos
        Dim dt As DataTable = db.ExecuteDataSet("coo_DocumentosSelectByPK", Documento).Tables(0)
        Dim Entidad As New coo_Documentos
        If dt.Rows.Count > 0 Then
            Entidad.Documento = dt.Rows(0).Item("Documento")
            Entidad.Contenido = dt.Rows(0).Item("Contenido")
        End If
        Return Entidad
    End Function

#Region "Non Auto Generated"
    Public Function coo_spVerificaUsuarioCajero(ByVal Usuario As String, ByVal Contrasenia As String) As Integer
        Return db.ExecuteScalar("coo_spVerificaUsuarioCajero", Usuario, Contrasenia)
    End Function
    Public Sub coo_spLogUsuario(ByVal IdSucursal As Integer, ByVal Fecha As Date, ByVal Usuario As String)
        db.ExecuteNonQuery("coo_spLogUsuario", IdSucursal, Fecha, Usuario)
    End Sub
    Public Function ObtenerAfiliaciones(ByVal IdSucursal As Integer) As DataTable
        Dim sql As String = "select ca.IdAsociado, aso.Numero, aso.Nombres, aso.Apellidos, ca.FechaGeneracion Fecha, ca.CuotaIngreso"
        sql &= ", ca.TramitesIngreso, ca.Otros, aso.CreadoPor from coo_afiliaciones ca "
        sql &= "inner join coo_asociados aso on ca.IdAsociado = aso.idasociado where Aplicado=0 and ca.IdSucursal = " & IdSucursal
        Return db.ExecuteDataSet(CommandType.Text, Sql).Tables(0)
    End Function

    Public Function ObtenerLiquidacionesPendientes(ByVal IdSucursal As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spObtenerLiquidacionesPendientes", IdSucursal).Tables(0)
    End Function

    Public Function ObtenerDetalleLiquidacion(ByVal IdLiquidacion As Integer, ByVal CreadoPor As String) As DataTable
        Return db.ExecuteDataSet("coo_spObtenerDetalleLiquidacion", IdLiquidacion, CreadoPor).Tables(0)
    End Function

    Public Function ObtenerSaldoPendienteLiquidacion(ByVal IdCuentaGasto As Integer, ByVal Fecha As DateTime) As Decimal
        Return db.ExecuteScalar("coo_spObtenerSaldoPendienteLiquidacion", IdCuentaGasto, Fecha)
    End Function

    Public Function ObtenerAfiliacionesAplicadas(ByVal IdSucursal As Integer, ByVal FechaContable As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spObtenerAfiliacionesAplicadas", IdSucursal, FechaContable).Tables(0)
    End Function

    Public Sub ActualizarEstadoAfiliacion(ByVal IdAsociado As Integer, ByVal Fecha As Date, ByVal IdUsuario As String, ByVal IdFormaPago As Integer)
        Dim sql As String = ""
        sql = "update coo_afiliaciones Set Aplicado = 1, FechaAplicacion = '" & Format(Fecha, "yyyyMMdd")
        sql += "'" + ", CreadoPor='" + IdUsuario + "' , IdFormaPago=" & IdFormaPago & " where IdAsociado = " & IdAsociado
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub

    Public Sub ActualizarEstadoLiquidacion(ByVal IdComprobante As Integer)
        Dim sql As String = ""
        sql = "update coo_Liquidaciones Set Cancelado = 1 where IdComprobante = " & IdComprobante
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub


    Public Sub RevertirEstadoAfiliacion(ByVal IdAsociado As Integer)
        Dim sql As String = ""
        sql = "update coo_afiliaciones Set Aplicado = 0 where IdAsociado = " & IdAsociado
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub

    Public Function CierreCaja(ByVal IdSucursal As Integer, ByVal fecha As Date, ByVal CreadoPor As String) As DataTable
        Return db.ExecuteDataSet("coo_CierreCaja", IdSucursal, fecha, CreadoPor).Tables(0)
        'db.ExecuteNonQuery("coo_CierreCaja", IdSucursal, Format(fecha, "yyMMdd"), CreadoPor)
    End Function
    Public Function ObtenerUltimoID(ByVal tabla As String, ByVal columna As String) As Integer
        Dim cn As DbConnection = db.CreateConnection()
        Dim sSQL As String = String.Format("select isnull(max({0}),0) from {1}", columna, tabla)
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction
        Dim num As Integer = 0
        Try
            num = db.ExecuteScalar(tran, CommandType.Text, sSQL)
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
        Finally
            cn.Close()
        End Try
        Return num + 1
    End Function

    Public Sub AperturarCaja(ByVal IdSucursal As Integer, ByVal FechaContable As Date, ByVal Usuario As String)

        Dim sSQL As String = "update coo_LogUsuario set Activo=1"
        sSQL &= " where fecha='" & Format(FechaContable, "yyyyMMdd") & "'"
        sSQL &= " and IdSucursal=" & IdSucursal
        sSQL &= " and CodUsuario='" & Usuario & "'"
        db.ExecuteScalar(CommandType.Text, sSQL)
    End Sub
    Public Function IsCajaAbierta(ByVal IdSucursal As Integer, ByVal FechaContable As Date, ByVal Usuario As String) As Boolean
        Dim sSQL As String = "select Activo from coo_LogUsuario where fecha='" & Format(FechaContable, "yyyyMMdd") & "'"
        sSQL &= " and IdSucursal=" & IdSucursal & " and CodUsuario='" & Usuario & "' and Activo=1"
        Dim result As Boolean = db.ExecuteScalar(CommandType.Text, sSQL)
        Return result
    End Function

    Public Function ObtenerDocAutorizado(ByVal IdAutorizado As Integer) As String
        Dim sSQL As String = "select NroDocumento from coo_CuentasAhorroAutorizado where IdAutorizado=" & IdAutorizado
        Dim Documento As String = db.ExecuteScalar(CommandType.Text, sSQL)
        Return Documento
    End Function

    Public Function GetDenominaciones() As DataTable
        Dim sql As String = "select IdCorte=convert(Integer,0),IdDenominacion,Valor,Cantidad=convert(Integer,0),Total=convert(decimal,0.00),Nombre from coo_DenominacionesMoneda "
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function GetArqueoCaja(ByVal IdCorte As Integer) As DataTable
        Dim sql As String = "select a.IdCorte, a.IdDenominacion, d.Valor, a.Cantidad, a.Total, d.Nombre from coo_CorteCajaArqueo a inner join coo_DenominacionesMoneda d on a.IdDenominacion=d.IdDenominacion WHERE a.IdCorte=" & IdCorte
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function
    Public Function GetChequesCorteCaja(ByVal IdCorte As Integer) As DataTable
        Dim sql As String = "select IdCorte, NumeroCuenta, NumeroCheque, NombreBanco, AnombreDe,Valor from coo_CorteCajaCheques where IdCorte=" & IdCorte
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function GetFechaContable(ByVal IdSucursal As Integer) As Date
        'Dim sql As String = "select max(fecha) from coo_Calendario where activo=1 and IdSucursal=" & IdSucursal
        Dim sSQL As String = "select Fecha=convert(date,getdate(),112) "
        Dim Fecha As Date = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), Today)
        Return Fecha
    End Function

    Public Function GetSucursal(ByVal IdUsuario As String) As Integer
        Dim sSQL As String = String.Format("select IdSucursal from adm_Usuarios where estado=1 and IdUsuario='{0}'", IdUsuario)
        Dim IdSucursal As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return IdSucursal
    End Function
    Public Function rptLiquidacionAportacion(ByVal NumeroDoc As String, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spLiquidacionAportacion", NumeroDoc, IdAsociado).Tables(0)
    End Function

    Public Function GetNombreSucursal(ByVal IdSucursal As Integer) As String
        Dim sSQL As String = "select Nombre from adm_Sucursales where IdSucursal=" & IdSucursal
        Dim Nombre As String = db.ExecuteScalar(CommandType.Text, sSQL)
        Return Nombre
    End Function


    Public Function GetDiasMora(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Integer
        Dim DiasMora As Integer = db.ExecuteScalar("coo_spDiasMora", IdPrestamo, HastaFecha)
        Return DiasMora
    End Function


    Public Function IsPrestamoCancelado(ByVal IdPrestamo As Integer) As Boolean
        Dim sSQL As String = "select idestado from coo_Prestamos where idprestamo=" & IdPrestamo
        Dim IdEstado As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Dim result As Boolean
        If IdEstado = 3 Then
            result = True
        Else
            result = False
        End If
        Return result

    End Function

    Public Function GetIdCuentaAhorro(ByVal NroCta As String) As Integer
        Dim sSQL As String = "select IdCuenta from coo_CuentasAhorro where Numero='" & NroCta & "'"
        Dim IdCuenta As Integer
        IdCuenta = SiEsNulo(db.ExecuteScalar(CommandType.Text, sSQL), 0)
        Return IdCuenta
    End Function

    'Public Function coo_GetMontoAperturaSelectBy(ByVal IdCuenta As Integer) As coo_GetAperturaCuenta
    '    Dim dt As DataTable = db.ExecuteDataSet("coo_CuentasAhorroSelectByPk", IdCuenta).Tables(0)
    '    Dim entAhorro As New coo_GetAperturaCuenta
    '    If dt.Rows.Count = 0 Then
    '        With entAhorro
    '            .MontoApertura = 0
    '            .FechaApertura = Today
    '        End With
    '    Else
    '        With entAhorro
    '            .MontoApertura = dt.Rows(0).Item("MontoApertura")
    '            .FechaApertura = dt.Rows(0).Item("FechaApertura")
    '        End With
    '    End If
    '    Return entAhorro
    'End Function

    Public Function coo_UltMovAhorroSelectBy(ByVal IdCuenta As Integer) As coo_UltMovAhorro
        Dim dt As DataTable = db.ExecuteDataSet("coo_UltMovAhorroSelectBy", IdCuenta).Tables(0)
        Dim entAhorro As New coo_UltMovAhorro
        If dt.Rows.Count = 0 Then
            With entAhorro
                .IdMov = 0
                .Fecha = Today
                .Linea = 1
                .SaldoActual = 0
                .SaldoDisponible = 0
            End With
        Else
            With entAhorro
                .IdMov = dt.Rows(0).Item("IdMov")
                .Fecha = dt.Rows(0).Item("Fecha")
                .Linea = dt.Rows(0).Item("Linea")
                .SaldoActual = dt.Rows(0).Item("SaldoActual")
                .SaldoDisponible = dt.Rows(0).Item("SaldoDisponible")
            End With
        End If
        Return entAhorro
    End Function

    Public Function coo_CapitalizacionAhorroCancelacion(ByVal IdCuenta As Integer, ByVal Fecha As DateTime, ByVal Tasa As Decimal) As coo_CapitalizacionAhorro
        Dim dt As DataTable = db.ExecuteDataSet("coo_spCapitalizacionAhorroCancelacion", IdCuenta, Fecha, Tasa).Tables(0)
        Dim entCapitalizacion As New coo_CapitalizacionAhorro
        If dt.Rows.Count = 0 Then
            With entCapitalizacion
                .SaldoInteres = 0
                .SaldoIsr = 0
                .UltFechaCap = Today
            End With
        Else
            With entCapitalizacion
                .SaldoInteres = SiEsNulo(dt.Rows(0).Item("SaldoInteres"), 0.0)
                .SaldoIsr = SiEsNulo(dt.Rows(0).Item("SaldoIsr"), 0.0)
                .UltFechaCap = SiEsNulo(dt.Rows(0).Item("UltFechaCap"), Today)
            End With
        End If
        Return entCapitalizacion
    End Function

    Public Function coo_PrestamosDetalleSelectAllById(ByVal IdPrestamo As Integer) As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from coo_PrestamosDetalle where IdPrestamo=" & IdPrestamo).Tables(0)
    End Function
    Public Function coo_PrestamosPlanPagosSelectAllById(ByVal IdPrestamo As Integer) As DataTable
        Return db.ExecuteDataSet(CommandType.Text, "select * from coo_PrestamosPlanPagos where IdPrestamo=" & IdPrestamo).Tables(0)
    End Function
    Public Function coo_GetCtaAhorro(ByVal IdAsociado As Integer) As DataTable
        Dim sSQL As String = "coo_spGetLibretaAhorro"
        Return db.ExecuteDataSet(sSQL, IdAsociado).Tables(0)
    End Function

    Public Function coo_GetCtaAhorroSimultaneo(ByVal IdAsociado As Integer) As DataTable
        Dim sSQL As String = "coo_spGetCuentaSimultaneo"
        Return db.ExecuteDataSet(sSQL, IdAsociado).Tables(0)
    End Function



    Public Function DatosAsociadoParaConsulta(ByVal Nombres As String, ByVal Apellidos As String, ByVal Incluir As Boolean) As DataTable
        Dim sql As String = "coo_spDatosAsociadoParaConsulta"
        Return db.ExecuteDataSet(sql, Nombres, Apellidos, Incluir).Tables(0)
    End Function

    Public Function CuentaAhorroParaConsulta(ByVal Nombres As String, ByVal Apellidos As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Dim sSQL As String = "coo_spCuentaAhorroParaConsulta"
        Return db.ExecuteDataSet(sSQL, Nombres, Apellidos, "", Incluir).Tables(0)
    End Function

    Public Function PrestamoParaConsulta(ByVal Nombres As String, ByVal Apellidos As String, ByVal Fecha As DateTime, ByVal Incluir As Boolean) As DataTable
        Dim sSQL As String = "coo_spPrestamoParaConsulta"
        Return db.ExecuteDataSet(sSQL, Nombres, Apellidos, Fecha, Incluir).Tables(0)
    End Function

    Public Function SolicitudFondosParaConsulta() As DataTable
        Dim sSQL As String = "coo_spConsultaSolicitudFondos"
        Return db.ExecuteDataSet(sSQL).Tables(0)
    End Function

    Public Function coo_GetLineaAportacion(ByVal IdAsociado As Integer) As Integer
        Dim sSQL As String = "select isnull(max(LineaLibreta),0) from coo_Aportaciones where idasociado=" & IdAsociado
        Dim linea As Integer = db.ExecuteScalar(CommandType.Text, sSQL)
        Return linea
    End Function

    Public Function coo_GetCambioTasaInteres(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Decimal
        Dim sSQL As String = "coo_spCambioTasaInteres"
        Dim Tasa As Decimal = db.ExecuteScalar(sSQL, IdPrestamo, HastaFecha)
        Return Tasa
    End Function

    Public Function rptEstadoCuentaPrestamo(ByVal NumeroPrestamo As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaPrestamo", NumeroPrestamo, HastaFecha).Tables(0)
    End Function

    Public Function rptFiadores(ByVal IdSolicitud As Integer) As DataTable
        Dim sql As String = "select NombreFiador=NombresApellidos, Direccion, Telefonos from coo_GarantiasFiador "
        sql &= "where IdSolicitud=" & IdSolicitud
        Return db.ExecuteDataSet(CommandType.Text, sql).Tables(0)
    End Function

    Public Function coo_GetCambioTasaMora(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Decimal
        Dim sSQL As String = "coo_spCambioTasaMora"
        Dim Tasa As Decimal = db.ExecuteScalar(sSQL, IdPrestamo, HastaFecha)
        Return Tasa
    End Function

    Public Function GetSaldoAhorro(ByVal IdCuenta As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoAhorro", IdCuenta)
        Return Saldo
    End Function
    Public Function GetUltMovAhorro(ByVal IdCuenta As Integer) As Integer
        Dim IdMov As Decimal = db.ExecuteScalar("coo_spGetUlMovAhorro", IdCuenta)
        Return IdMov
    End Function
    Public Function GetSaldoAporta(ByVal IdAsociado As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoAporta", IdAsociado)
        Return Saldo
    End Function
    Public Function GetSaldoAyudaFuneraria(ByVal IdAsociado As Integer) As Decimal
        Dim Saldo As Decimal = db.ExecuteScalar("coo_spGetSaldoAyudaFuneraria", IdAsociado)
        Return Saldo
    End Function


    Public Function GetUltMovAporta(ByVal IdAsociado As Integer) As Integer
        Dim IdMov As Decimal = db.ExecuteScalar("coo_spGetUlMovAporta", IdAsociado)
        Return IdMov
    End Function
    Public Function GetUltMovFune(ByVal IdAsociado As Integer) As Integer
        Dim IdMov As Decimal = db.ExecuteScalar("coo_spGetUlMovFune", IdAsociado)
        Return IdMov
    End Function


    Public Function GetUltFechaAporta(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Dim fecha As Nullable(Of Date) = SiEsNulo(db.ExecuteScalar("coo_spGetUltFechaAporta", IdAsociado), Nothing)
        Return fecha
    End Function
    Public Function GetUltFechaAyudaFuneraria(ByVal IdAsociado As Integer) As Nullable(Of Date)
        Dim fecha As Nullable(Of Date) = SiEsNulo(db.ExecuteScalar("coo_spGetUltFechaAporta", IdAsociado), Nothing)
        Return fecha
    End Function

    Public Function GetUltLineaAporta(ByVal IdAsociado As Integer) As Integer
        Dim Linea As Decimal = db.ExecuteScalar("coo_spGetUltLineaAporta", IdAsociado)
        Return Linea
    End Function

    Public Function GetUltMovAfilia() As Integer
        Return db.ExecuteScalar("coo_spGetUlMovAfilia")
    End Function


    Public Function SiEsNulo(ByVal value As Object, ByVal ValueNoNull As Object) As Object
        If value Is Nothing Then Return Nothing
        If IsDBNull(value) Then Return ValueNoNull
        Return value
    End Function


    Public Function rptHistorialPrestamo(ByVal IdAsociado As Integer, ByVal Fecha As DateTime, ByVal InlcuirCancelados As Boolean) As DataTable
        Return db.ExecuteDataSet("coo_spHistorialPrestamo", IdAsociado, Fecha, InlcuirCancelados).Tables(0)
    End Function

    Public Function rptEstadoCuentaAportacion(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spEstadoCuentaAportacion", IdAsociado, Fecha).Tables(0)
    End Function

    Public Function rptDatosAsociado(ByVal IdAsociado As Integer, ByVal Fecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spDatosAsociado", IdAsociado, Fecha).Tables(0)
    End Function

    Public Function rptListadoCuentaAhorroAsociado(ByVal HastaFecha As DateTime, ByVal IdAsociado As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoCuentasAhorroAsociado", HastaFecha, IdAsociado).Tables(0)
    End Function

    Public Function rptCorteCajaIngresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCajaIngresos", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function

    Public Function rptCorteCajaEgresos(ByVal IdSucursal As Integer, ByVal IdUsuario As String, ByVal HastaFecha As DateTime) As DataTable
        Return db.ExecuteDataSet("coo_spCorteCajaEgresos", IdSucursal, HastaFecha, IdUsuario).Tables(0)
    End Function

    Public Function ConsultaSolicitudFondos() As DataTable
        Return db.ExecuteDataSet("coo_spConsultaSolicitudFondos").Tables(0)
    End Function

    Public Sub ActualizaCorrelativoSucursal(ByVal Sentencia As String)
        db.ExecuteNonQuery(CommandType.Text, Sentencia)
    End Sub

    Public Sub EjecutaInstruccionSql(ByVal sql As String)
        db.ExecuteNonQuery(CommandType.Text, sql)
    End Sub

    Public Sub CancelacionLiquidacionAportacion(ByVal Sentencia As String)
        db.ExecuteNonQuery(CommandType.Text, Sentencia)
    End Sub

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

    Public Function coo_CorteCajaSelectFecha(ByVal Fecha As DateTime, ByVal Usuario As String) As coo_CorteCaja

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

    Public Function coo_InsertarLiquidacion(ByVal entLiquidacion As coo_Liquidaciones, ByVal Detalle As List(Of coo_LiquidacionesDetalle)) As String

        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try

            'Guarda el quedan
            objTabla.coo_LiquidacionesInsert(entLiquidacion, tran)

            For Each entDetalle As coo_LiquidacionesDetalle In Detalle
                entDetalle.IdComprobante = entLiquidacion.IdComprobante
                objTabla.coo_LiquidacionesDetalleInsert(entDetalle, tran)
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


    Public Function coo_CorteCajaArqueoSelectFecha(ByVal IdCorte As System.Int32) As coo_CorteCajaArqueo

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spCorteCajaArqueoSelectFecha", _
         IdCorte _
         ).Tables(0)

        Dim Entidad As New coo_CorteCajaArqueo
        If dt.Rows.Count > 0 Then
            Entidad.IdCorte = dt.Rows(0).Item("IdCorte")
            Entidad.IdDenominacion = dt.Rows(0).Item("IdDenominacion")
            Entidad.Cantidad = dt.Rows(0).Item("Cantidad")
            Entidad.Total = dt.Rows(0).Item("Total")

        End If
        Return Entidad
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

    Public Function coo_AsociadosSelectNumero(ByVal Numero As System.String) As coo_Asociados

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_spAsociadosSelectNumero", Numero).Tables(0)

        Dim Entidad As New coo_Asociados
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Nombres = dt.Rows(0).Item("Nombres")
            Entidad.Apellidos = dt.Rows(0).Item("Apellidos")
            Entidad.FechaNacimiento = dt.Rows(0).Item("FechaNacimiento")
            Entidad.IdProfesion = dt.Rows(0).Item("IdProfesion")
            Entidad.IdActividad = dt.Rows(0).Item("IdActividad")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.IdTipoDocumento = dt.Rows(0).Item("IdTipoDocumento")
            Entidad.NumeroDocumento = dt.Rows(0).Item("NumeroDocumento")
            Entidad.Direccion = dt.Rows(0).Item("Direccion")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
        End If
        Return Entidad
    End Function

    Public Function coo_LiquidacionSelectByAsociado(ByVal IdAsociado As System.Int32) As coo_LiquidacionAportaciones

        Dim dt As DataTable = db.ExecuteDataSet("coo_spLiquidacionSelectByAsociado", _
         IdAsociado).Tables(0)

        Dim Entidad As New coo_LiquidacionAportaciones
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.NumeroDoc = dt.Rows(0).Item("NumeroDoc")
            Entidad.FechaIngreso = dt.Rows(0).Item("FechaIngreso")
            Entidad.FechaUltMovimiento = dt.Rows(0).Item("FechaUltMovimiento")
            Entidad.TotalAportaciones = dt.Rows(0).Item("TotalAportaciones")
            Entidad.NumActa = dt.Rows(0).Item("NumActa")
            Entidad.TotalRetiro = dt.Rows(0).Item("TotalRetiro")
            Entidad.FechaLiquidacion = dt.Rows(0).Item("FechaLiquidacion")
            Entidad.PrestamosPendientes = dt.Rows(0).Item("PrestamosPendientes")
            Entidad.InteresesPendientes = dt.Rows(0).Item("InteresesPendientes")
            Entidad.ProvisionIncobrable = dt.Rows(0).Item("ProvisionIncobrable")
            Entidad.ValorIva = dt.Rows(0).Item("ValorIva")
            Entidad.Honorarios = dt.Rows(0).Item("Honorarios")
            Entidad.LiquidoPagar = dt.Rows(0).Item("LiquidoPagar")
            Entidad.OtrosProductos = dt.Rows(0).Item("OtrosProductos")
            Entidad.IdTipo = dt.Rows(0).Item("IdTipo")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.IdTipoLiquidacion = dt.Rows(0).Item("IdTipoLiquidacion")
            Entidad.Desembolsado = dt.Rows(0).Item("Desembolsado")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function

    Public Function rptLiquidacionPrestamo(ByVal IdSolicitudFondo As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spLiquidacionPrestamo", IdSolicitudFondo).Tables(0)
    End Function
#End Region

End Class
