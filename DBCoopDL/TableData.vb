Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports Microsoft.Practices.EnterpriseLibrary.Common
Imports System.Data.Common
Imports System.Data
Imports DBCoopEL.TableEntities
'Imports System.Windows.Forms

Public Class TableData
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    
#Region "adm_Usuarios"
    Public Function adm_UsuariosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_UsuariosSelectAll").Tables(0)
    End Function

    Public Function adm_UsuariosSelectByPK _
      (ByVal IdUsuario As System.String _
      ) As adm_Usuarios

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_UsuariosSelectByPK", _
         IdUsuario _
         ).tables(0)

        Dim Entidad As New adm_Usuarios
        If dt.Rows.Count > 0 Then
            entidad.IdUsuario = dt.rows(0).item("IdUsuario")
            entidad.Clave = dt.rows(0).item("Clave")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Apellidos = dt.rows(0).item("Apellidos")
            entidad.FechaCreacion = dt.rows(0).item("FechaCreacion")
            entidad.FechaVencimiento = dt.rows(0).item("FechaVencimiento")
            entidad.Estado = dt.rows(0).item("Estado")
            entidad.TipoUsuario = dt.rows(0).item("TipoUsuario")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            Entidad.PuedeVerCorte = dt.Rows(0).Item("PuedeVerCorte")
        End If
        Return Entidad
    End Function

    Public Sub adm_UsuariosDeleteByPK _
      (ByVal IdUsuario As System.String _
      )

        db.ExecuteNonQuery("adm_UsuariosDeleteByPK", _
         IdUsuario _
         )
    End Sub

    Public Sub adm_UsuariosDeleteByPK _
      (ByVal IdUsuario As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_UsuariosDeleteByPK", _
         IdUsuario _
         )
    End Sub

    Public Sub adm_UsuariosInsert _
    (ByVal entidad As adm_Usuarios)

        db.ExecuteNonQuery("adm_UsuariosInsert", _
         entidad.IdUsuario _
         , entidad.Clave _
         , entidad.Nombre _
         , entidad.Apellidos _
         , entidad.FechaCreacion _
         , entidad.FechaVencimiento _
         , entidad.Estado _
         , entidad.TipoUsuario _
         , entidad.IdSucursal _
         , entidad.PuedeVerCorte _
         )
    End Sub

    Public Sub adm_UsuariosInsert _
    (ByVal entidad As adm_Usuarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_UsuariosInsert", _
         entidad.IdUsuario _
         , entidad.Clave _
         , entidad.Nombre _
         , entidad.Apellidos _
         , entidad.FechaCreacion _
         , entidad.FechaVencimiento _
         , entidad.Estado _
         , entidad.TipoUsuario _
         , entidad.IdSucursal _
         )
    End Sub

    Public Sub adm_UsuariosUpdate _
    (ByVal entidad As adm_Usuarios)

        db.ExecuteNonQuery("adm_UsuariosUpdate", _
         entidad.IdUsuario _
         , entidad.Clave _
         , entidad.Nombre _
         , entidad.Apellidos _
         , entidad.FechaCreacion _
         , entidad.FechaVencimiento _
         , entidad.Estado _
         , entidad.TipoUsuario _
         , entidad.IdSucursal _
         , entidad.PuedeVerCorte _
         )
    End Sub

    Public Sub adm_UsuariosUpdate _
    (ByVal entidad As adm_Usuarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_UsuariosUpdate", _
         entidad.IdUsuario _
         , entidad.Clave _
         , entidad.Nombre _
         , entidad.Apellidos _
         , entidad.FechaCreacion _
         , entidad.FechaVencimiento _
         , entidad.Estado _
         , entidad.TipoUsuario _
         , entidad.IdSucursal _
         )
    End Sub

#End Region

#Region "adm_Libros"
    Public Function adm_LibrosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_LibrosSelectAll").Tables(0)
    End Function

    Public Function adm_LibrosSelectByPK _
      (ByVal IdLibro As System.Int32 _
      ) As adm_Libros

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_LibrosSelectByPK", _
         IdLibro _
         ).tables(0)

        Dim Entidad As New adm_Libros
        If dt.Rows.Count > 0 Then
            entidad.IdLibro = dt.rows(0).item("IdLibro")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub adm_LibrosDeleteByPK _
      (ByVal IdLibro As System.Int32 _
      )

        db.ExecuteNonQuery("adm_LibrosDeleteByPK", _
         IdLibro _
         )
    End Sub

    Public Sub adm_LibrosDeleteByPK _
      (ByVal IdLibro As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_LibrosDeleteByPK", _
         IdLibro _
         )
    End Sub

    Public Sub adm_LibrosInsert _
    (ByVal entidad As adm_Libros)

        db.ExecuteNonQuery("adm_LibrosInsert", _
         entidad.IdLibro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_LibrosInsert _
    (ByVal entidad As adm_Libros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_LibrosInsert", _
         entidad.IdLibro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_LibrosUpdate _
    (ByVal entidad As adm_Libros)

        db.ExecuteNonQuery("adm_LibrosUpdate", _
         entidad.IdLibro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_LibrosUpdate _
    (ByVal entidad As adm_Libros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_LibrosUpdate", _
         entidad.IdLibro _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "adm_Sucursales"
    Public Function adm_SucursalesSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_SucursalesSelectAll").Tables(0)
    End Function

    Public Function adm_SucursalesSelectByPK _
      (ByVal IdSucursal As System.Int32 _
      ) As adm_Sucursales

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_SucursalesSelectByPK", _
         IdSucursal _
         ).tables(0)

        Dim Entidad As New adm_Sucursales
        If dt.Rows.Count > 0 Then
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Responsable = dt.rows(0).item("Responsable")
            Entidad.Telefonos = dt.Rows(0).Item("Telefonos")
            Entidad.Email = dt.Rows(0).Item("Email")
            entidad.CorrelativoPago = dt.rows(0).item("CorrelativoPago")
            entidad.CorrelativoDeposito = dt.rows(0).item("CorrelativoDeposito")
            entidad.CorrelativoAportacion = dt.rows(0).item("CorrelativoAportacion")
            entidad.CorrelativoRetiro = dt.rows(0).item("CorrelativoRetiro")
            entidad.CorrelativoIngresos = dt.rows(0).item("CorrelativoIngresos")
            entidad.CorrelativoEgresos = dt.rows(0).item("CorrelativoEgresos")
            entidad.CorrelativoRequisicion = dt.rows(0).item("CorrelativoRequisicion")
            entidad.CorrelativoRemision = dt.rows(0).item("CorrelativoRemision")
            entidad.Ciudad = dt.rows(0).item("Ciudad")
            entidad.LineasLibreta = dt.rows(0).item("LineasLibreta")
            Entidad.LogoImageUrl = dt.Rows(0).Item("LogoImageUrl")
        End If
        Return Entidad
    End Function

    Public Sub adm_SucursalesDeleteByPK _
      (ByVal IdSucursal As System.Int32 _
      )

        db.ExecuteNonQuery("adm_SucursalesDeleteByPK", _
         IdSucursal _
         )
    End Sub

    Public Sub adm_SucursalesDeleteByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SucursalesDeleteByPK", _
         IdSucursal _
         )
    End Sub

    Public Sub adm_SucursalesInsert _
    (ByVal entidad As adm_Sucursales)

        db.ExecuteNonQuery("adm_SucursalesInsert", _
         entidad.IdSucursal _
         , entidad.Nombre _
         , entidad.Responsable _
         , entidad.Telefonos _
         , entidad.CorrelativoPago _
         , entidad.CorrelativoDeposito _
         , entidad.CorrelativoAportacion _
         , entidad.CorrelativoRetiro _
         , entidad.CorrelativoIngresos _
         , entidad.CorrelativoEgresos _
         , entidad.CorrelativoRequisicion _
         , entidad.CorrelativoRemision _
         , entidad.Ciudad _
         , entidad.LineasLibreta _
         , entidad.Email _
         , entidad.LogoImageUrl)
    End Sub

    Public Sub adm_SucursalesInsert _
    (ByVal entidad As adm_Sucursales, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SucursalesInsert", _
         entidad.IdSucursal _
         , entidad.Nombre _
         , entidad.Responsable _
         , entidad.Telefonos _
         , entidad.CorrelativoPago _
         , entidad.CorrelativoDeposito _
         , entidad.CorrelativoAportacion _
         , entidad.CorrelativoRetiro _
         , entidad.CorrelativoIngresos _
         , entidad.CorrelativoEgresos _
         , entidad.CorrelativoRequisicion _
         , entidad.CorrelativoRemision _
         , entidad.Ciudad _
         , entidad.LineasLibreta _
         , entidad.Email _
         , entidad.LogoImageUrl _
         )
    End Sub

    Public Sub adm_SucursalesUpdate _
    (ByVal entidad As adm_Sucursales)

        db.ExecuteNonQuery("adm_SucursalesUpdate", _
         entidad.IdSucursal _
         , entidad.Nombre _
         , entidad.Responsable _
         , entidad.Telefonos _
         , entidad.CorrelativoPago _
         , entidad.CorrelativoDeposito _
         , entidad.CorrelativoAportacion _
         , entidad.CorrelativoRetiro _
         , entidad.CorrelativoIngresos _
         , entidad.CorrelativoEgresos _
         , entidad.CorrelativoRequisicion _
         , entidad.CorrelativoRemision _
         , entidad.Ciudad _
         , entidad.LineasLibreta _
         , entidad.Email _
         , entidad.LogoImageUrl _
         )
    End Sub

    Public Sub adm_SucursalesUpdate _
    (ByVal entidad As adm_Sucursales, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SucursalesUpdate", _
         entidad.IdSucursal _
         , entidad.Nombre _
         , entidad.Responsable _
         , entidad.Telefonos _
         , entidad.CorrelativoPago _
         , entidad.CorrelativoDeposito _
         , entidad.CorrelativoAportacion _
         , entidad.CorrelativoRetiro _
         , entidad.CorrelativoIngresos _
         , entidad.CorrelativoEgresos _
         , entidad.CorrelativoRequisicion _
         , entidad.CorrelativoRemision _
         , entidad.Ciudad _
         , entidad.LineasLibreta _
         , entidad.Email _
         , entidad.LogoImageUrl _
         )
    End Sub

#End Region


#Region "adm_TiposComprobante"
    Public Function adm_TiposComprobanteSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_TiposComprobanteSelectAll").Tables(0)
    End Function

    Public Function adm_TiposComprobanteSelectByPK _
      (ByVal IdTipoComprobante As System.Int16 _
      ) As adm_TiposComprobante

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_TiposComprobanteSelectByPK", _
         IdTipoComprobante _
         ).tables(0)

        Dim Entidad As New adm_TiposComprobante
        If dt.Rows.Count > 0 Then
            entidad.IdTipoComprobante = dt.rows(0).item("IdTipoComprobante")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Abreviatura = dt.rows(0).item("Abreviatura")
            entidad.TipoAplicacion = dt.rows(0).item("TipoAplicacion")
            entidad.IdLibro = dt.rows(0).item("IdLibro")
            Entidad.DetallaIVA = dt.Rows(0).Item("DetallaIVA")
            entidad.IdModuloAplica = dt.rows(0).item("IdModuloAplica")

        End If
        Return Entidad
    End Function

    Public Sub adm_TiposComprobanteDeleteByPK _
      (ByVal IdTipoComprobante As System.Int16 _
      )

        db.ExecuteNonQuery("adm_TiposComprobanteDeleteByPK", _
         IdTipoComprobante _
         )
    End Sub

    Public Sub adm_TiposComprobanteDeleteByPK _
      (ByVal IdTipoComprobante As System.Int16 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_TiposComprobanteDeleteByPK", _
         IdTipoComprobante _
         )
    End Sub

    Public Sub adm_TiposComprobanteInsert _
    (ByVal entidad As adm_TiposComprobante)

        db.ExecuteNonQuery("adm_TiposComprobanteInsert", _
         entidad.IdTipoComprobante _
         , entidad.Nombre _
         , entidad.Abreviatura _
         , entidad.TipoAplicacion _
         , entidad.IdLibro _
         , entidad.DetallaIVA _
         , entidad.IdModuloAplica _
         )
    End Sub

    Public Sub adm_TiposComprobanteInsert _
    (ByVal entidad As adm_TiposComprobante, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_TiposComprobanteInsert", _
         entidad.IdTipoComprobante _
         , entidad.Nombre _
         , entidad.Abreviatura _
         , entidad.TipoAplicacion _
         , entidad.IdLibro _
         , entidad.DetallaIVA _
         , entidad.IdModuloAplica _
         )
    End Sub

    Public Sub adm_TiposComprobanteUpdate _
    (ByVal entidad As adm_TiposComprobante)

        db.ExecuteNonQuery("adm_TiposComprobanteUpdate", _
         entidad.IdTipoComprobante _
         , entidad.Nombre _
         , entidad.Abreviatura _
         , entidad.TipoAplicacion _
         , entidad.IdLibro _
         , entidad.DetallaIVA _
         , entidad.IdModuloAplica _
         )
    End Sub

    Public Sub adm_TiposComprobanteUpdate _
    (ByVal entidad As adm_TiposComprobante, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_TiposComprobanteUpdate", _
         entidad.IdTipoComprobante _
         , entidad.Nombre _
         , entidad.Abreviatura _
         , entidad.TipoAplicacion _
         , entidad.IdLibro _
         , entidad.DetallaIVA _
         , entidad.IdModuloAplica _
         )
    End Sub

#End Region
#Region "adm_SeriesDocumentos"
    Public Function adm_SeriesDocumentosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_SeriesDocumentosSelectAll").Tables(0)
    End Function

    Public Function adm_SeriesDocumentosSelectByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal IdPunto As System.Int32 _
      , ByVal IdTipoComprobante As System.Int32 _
      , ByVal Serie As System.String _
      ) As adm_SeriesDocumentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_SeriesDocumentosSelectByPK", _
         IdSucursal _
         , IdPunto _
         , IdTipoComprobante _
         , Serie _
         ).tables(0)

        Dim Entidad As New adm_SeriesDocumentos
        If dt.Rows.Count > 0 Then
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.IdPunto = dt.rows(0).item("IdPunto")
            entidad.IdTipoComprobante = dt.rows(0).item("IdTipoComprobante")
            entidad.Serie = dt.rows(0).item("Serie")
            entidad.FechaAsignacion = dt.rows(0).item("FechaAsignacion")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.UltimoNumero = dt.rows(0).item("UltimoNumero")
            entidad.DesdeNumero = dt.rows(0).item("DesdeNumero")
            entidad.HastaNumero = dt.rows(0).item("HastaNumero")
            entidad.EsActivo = dt.rows(0).item("EsActivo")

        End If
        Return Entidad
    End Function

    Public Sub adm_SeriesDocumentosDeleteByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal IdPunto As System.Int32 _
      , ByVal IdTipoComprobante As System.Int32 _
      , ByVal Serie As System.String _
      )

        db.ExecuteNonQuery("adm_SeriesDocumentosDeleteByPK", _
         IdSucursal _
         , IdPunto _
         , IdTipoComprobante _
         , Serie _
         )
    End Sub

    Public Sub adm_SeriesDocumentosDeleteByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal IdPunto As System.Int32 _
      , ByVal IdTipoComprobante As System.Int32 _
      , ByVal Serie As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SeriesDocumentosDeleteByPK", _
         IdSucursal _
         , IdPunto _
         , IdTipoComprobante _
         , Serie _
         )
    End Sub

    Public Sub adm_SeriesDocumentosInsert _
    (ByVal entidad As adm_SeriesDocumentos)

        db.ExecuteNonQuery("adm_SeriesDocumentosInsert", _
         entidad.IdSucursal _
         , entidad.IdPunto _
         , entidad.IdTipoComprobante _
         , entidad.Serie _
         , entidad.FechaAsignacion _
         , entidad.CreadoPor _
         , entidad.UltimoNumero _
         , entidad.DesdeNumero _
         , entidad.HastaNumero _
         , entidad.EsActivo _
         )
    End Sub

    Public Sub adm_SeriesDocumentosInsert _
    (ByVal entidad As adm_SeriesDocumentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SeriesDocumentosInsert", _
         entidad.IdSucursal _
         , entidad.IdPunto _
         , entidad.IdTipoComprobante _
         , entidad.Serie _
         , entidad.FechaAsignacion _
         , entidad.CreadoPor _
         , entidad.UltimoNumero _
         , entidad.DesdeNumero _
         , entidad.HastaNumero _
         , entidad.EsActivo _
         )
    End Sub

    Public Sub adm_SeriesDocumentosUpdate _
    (ByVal entidad As adm_SeriesDocumentos)

        db.ExecuteNonQuery("adm_SeriesDocumentosUpdate", _
         entidad.IdSucursal _
         , entidad.IdPunto _
         , entidad.IdTipoComprobante _
         , entidad.Serie _
         , entidad.FechaAsignacion _
         , entidad.CreadoPor _
         , entidad.UltimoNumero _
         , entidad.DesdeNumero _
         , entidad.HastaNumero _
         , entidad.EsActivo _
         )
    End Sub

    Public Sub adm_SeriesDocumentosUpdate _
    (ByVal entidad As adm_SeriesDocumentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_SeriesDocumentosUpdate", _
         entidad.IdSucursal _
         , entidad.IdPunto _
         , entidad.IdTipoComprobante _
         , entidad.Serie _
         , entidad.FechaAsignacion _
         , entidad.CreadoPor _
         , entidad.UltimoNumero _
         , entidad.DesdeNumero _
         , entidad.HastaNumero _
         , entidad.EsActivo _
         )
    End Sub

#End Region
#Region "adm_cantones"
    Public Function adm_cantonesSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_cantonesSelectAll").Tables(0)
    End Function

    Public Function adm_cantonesSelectByPK _
      (ByVal IdCanton As System.String _
      ) As adm_cantones

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_cantonesSelectByPK", _
         IdCanton _
         ).tables(0)

        Dim Entidad As New adm_cantones
        If dt.Rows.Count > 0 Then
            entidad.IdCanton = dt.rows(0).item("IdCanton")
            entidad.IdMunicipio = dt.rows(0).item("IdMunicipio")
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.EsRural = dt.rows(0).item("EsRural")
            entidad.Id = dt.rows(0).item("Id")

        End If
        Return Entidad
    End Function

    Public Function adm_spCantonesSelectByPK _
  (ByVal Id As System.Int32 _
  ) As adm_cantones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("adm_spCantonesSelectByPK", _
         Id _
         ).Tables(0)

        Dim Entidad As New adm_cantones
        If dt.Rows.Count > 0 Then
            Entidad.IdCanton = dt.Rows(0).Item("IdCanton")
            Entidad.IdMunicipio = dt.Rows(0).Item("IdMunicipio")
            Entidad.IdDepartamento = dt.Rows(0).Item("IdDepartamento")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.EsRural = dt.Rows(0).Item("EsRural")
            Entidad.Id = dt.Rows(0).Item("Id")
        End If
        Return Entidad
    End Function


    Public Sub adm_cantonesDeleteByPK _
      (ByVal IdCanton As System.String _
      )

        db.ExecuteNonQuery("adm_cantonesDeleteByPK", _
         IdCanton _
         )
    End Sub

    Public Sub adm_cantonesDeleteByPK _
      (ByVal IdCanton As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_cantonesDeleteByPK", _
         IdCanton _
         )
    End Sub

    Public Sub adm_cantonesInsert _
    (ByVal entidad As adm_cantones)

        db.ExecuteNonQuery("adm_cantonesInsert", _
         entidad.IdCanton _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.EsRural _
         , entidad.Id _
         )
    End Sub

    Public Sub adm_cantonesInsert _
    (ByVal entidad As adm_cantones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_cantonesInsert", _
         entidad.IdCanton _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.EsRural _
         , entidad.Id _
         )
    End Sub

    Public Sub adm_cantonesUpdate _
    (ByVal entidad As adm_cantones)

        db.ExecuteNonQuery("adm_cantonesUpdate", _
         entidad.IdCanton _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.EsRural _
         , entidad.Id _
         )
    End Sub

    Public Sub adm_cantonesUpdate _
    (ByVal entidad As adm_cantones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_cantonesUpdate", _
         entidad.IdCanton _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.EsRural _
         , entidad.Id _
         )
    End Sub

#End Region
#Region "adm_Municipios"
    Public Function adm_MunicipiosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_MunicipiosSelectAll").Tables(0)
    End Function

    Public Function adm_MunicipiosSelectByPK _
      (ByVal IdMunicipio As System.String _
      ) As adm_Municipios

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_MunicipiosSelectByPK", _
         IdMunicipio _
         ).tables(0)

        Dim Entidad As New adm_Municipios
        If dt.Rows.Count > 0 Then
            entidad.IdMunicipio = dt.rows(0).item("IdMunicipio")
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Correlativo = dt.rows(0).item("Correlativo")

        End If
        Return Entidad
    End Function

    Public Sub adm_MunicipiosDeleteByPK _
      (ByVal IdMunicipio As System.String _
      )

        db.ExecuteNonQuery("adm_MunicipiosDeleteByPK", _
         IdMunicipio _
         )
    End Sub

    Public Sub adm_MunicipiosDeleteByPK _
      (ByVal IdMunicipio As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_MunicipiosDeleteByPK", _
         IdMunicipio _
         )
    End Sub

    Public Sub adm_MunicipiosInsert _
    (ByVal entidad As adm_Municipios)

        db.ExecuteNonQuery("adm_MunicipiosInsert", _
         entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.Correlativo _
         )
    End Sub

    Public Sub adm_MunicipiosInsert _
    (ByVal entidad As adm_Municipios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_MunicipiosInsert", _
         entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.Correlativo _
         )
    End Sub

    Public Sub adm_MunicipiosUpdate _
    (ByVal entidad As adm_Municipios)

        db.ExecuteNonQuery("adm_MunicipiosUpdate", _
         entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.Correlativo _
         )
    End Sub

    Public Sub adm_MunicipiosUpdate _
    (ByVal entidad As adm_Municipios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_MunicipiosUpdate", _
         entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.Nombre _
         , entidad.Correlativo _
         )
    End Sub

#End Region

#Region "adm_Parametros"
    Public Function adm_ParametrosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_ParametrosSelectAll").Tables(0)
    End Function


    Public Sub adm_ParametrosInsert _
    (ByVal entidad As adm_Parametros)

        db.ExecuteNonQuery("adm_ParametrosInsert", _
         entidad.NombreEmpresa _
         , entidad.DatoEncriptado1 _
         , entidad.DatoEncriptado2 _
         , entidad.DatoEncriptado3 _
         , entidad.NrcEmpresa _
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
         , entidad.PorcRenta _
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
         , entidad.DiasAhorro _
         , entidad.AhorroMaxIsr _
         , entidad.DiasPrestamo _
         , entidad.TasaSeguro _
         , entidad.TasaMora _
         , entidad.IdTipoPartidaCaja _
         , entidad.ConceptoPartidaCaja _
         , entidad.IdCuentaSeguro _
         , entidad.IdCuentaAportacion _
         , entidad.IdCuentaNumerario _
         , entidad.CuotaAfiliacion _
         , entidad.IdCuentaAfiliacion _
         , entidad.MaximoAsegurablePrestamo _
          , entidad.MaximoAsegurableAportacion _
         , entidad.MaximoAsegurableAhorro _
         , entidad.IdCuentaProvisionAhorro _
         , entidad.RutaLogo _
         , entidad.NombreLargo _
         , entidad.NotaInformativa _
         , entidad.RutaImagenes _
         , entidad.NotaDevolucionAhorro _
         , entidad.IdCuentaDividendos _
         )
    End Sub

    Public Sub adm_ParametrosInsert _
    (ByVal entidad As adm_Parametros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_ParametrosInsert", _
         entidad.NombreEmpresa _
         , entidad.DatoEncriptado1 _
         , entidad.DatoEncriptado2 _
         , entidad.DatoEncriptado3 _
         , entidad.NrcEmpresa _
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
         , entidad.PorcRenta _
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
         , entidad.DiasAhorro _
         , entidad.AhorroMaxIsr _
         , entidad.DiasPrestamo _
         , entidad.TasaSeguro _
         , entidad.TasaMora _
         , entidad.IdTipoPartidaCaja _
         , entidad.ConceptoPartidaCaja _
         , entidad.IdCuentaSeguro _
         , entidad.IdCuentaAportacion _
         , entidad.IdCuentaNumerario _
         , entidad.CuotaAfiliacion _
         , entidad.IdCuentaAfiliacion _
         , entidad.MaximoAsegurablePrestamo _
           , entidad.MaximoAsegurableAportacion _
  , entidad.MaximoAsegurableAhorro _
         , entidad.IdCuentaProvisionAhorro _
         , entidad.RutaLogo _
         , entidad.NombreLargo _
         , entidad.NotaInformativa _
         , entidad.RutaImagenes _
         , entidad.NotaDevolucionAhorro _
         , entidad.IdCuentaDividendos _
         )
    End Sub

    Public Sub adm_ParametrosUpdate _
    (ByVal entidad As adm_Parametros)

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
         , entidad.PorcRenta _
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
         , entidad.NotaInformativa _
         , entidad.IdTipoPrecio _
         , entidad.CuotaAportacion _
         , entidad.DiasAhorro _
         , entidad.AhorroMaxIsr _
         , entidad.DiasPrestamo _
         , entidad.TasaSeguro _
         , entidad.TasaMora _
         , entidad.IdTipoPartidaCaja _
         , entidad.ConceptoPartidaCaja _
         , entidad.IdCuentaSeguro _
         , entidad.IdCuentaAportacion _
         , entidad.IdCuentaNumerario _
         , entidad.CuotaAfiliacion _
         , entidad.IdCuentaAfiliacion _
         , entidad.MaximoAsegurablePrestamo _
           , entidad.MaximoAsegurableAportacion _
           , entidad.MaximoAsegurableAhorro _
         , entidad.IdCuentaProvisionAhorro _
         , entidad.RutaLogo _
         , entidad.NombreLargo _
         , entidad.RutaImagenes _
         , entidad.UbicacionServer _
         , entidad.Antiguedad _
         , entidad.CodigoAportacion _
         , entidad.IdCuentaDividendos _
         , entidad.IdCuentaRetencionDividendos _
         , entidad.IdCuentaAhorroFunerario _
         , entidad.NotaDevolucionAhorro _
         , entidad.IdTipoPartidaAhorros _
         , entidad.Email _
        , entidad.EmailPassword _
        , entidad.PortEmail _
        , entidad.Ssl _
         , entidad.ServerEmail _
        , entidad.ValorAplicaTelefonia _
        , entidad.ValorNoAplicaTelefonia _
         )
    End Sub

#End Region

#Region "adm_Departamentos"
    Public Function adm_DepartamentosSelectAll() As DataTable
        Return db.ExecuteDataSet("adm_DepartamentosSelectAll").Tables(0)
    End Function

    Public Function adm_DepartamentosSelectByPK _
      (ByVal IdDepartamento As System.String _
      ) As adm_Departamentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("adm_DepartamentosSelectByPK", _
         IdDepartamento _
         ).tables(0)

        Dim Entidad As New adm_Departamentos
        If dt.Rows.Count > 0 Then
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub adm_DepartamentosDeleteByPK _
      (ByVal IdDepartamento As System.String _
      )

        db.ExecuteNonQuery("adm_DepartamentosDeleteByPK", _
         IdDepartamento _
         )
    End Sub

    Public Sub adm_DepartamentosDeleteByPK _
      (ByVal IdDepartamento As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_DepartamentosDeleteByPK", _
         IdDepartamento _
         )
    End Sub

    Public Sub adm_DepartamentosInsert _
    (ByVal entidad As adm_Departamentos)

        db.ExecuteNonQuery("adm_DepartamentosInsert", _
         entidad.IdDepartamento _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_DepartamentosInsert _
    (ByVal entidad As adm_Departamentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_DepartamentosInsert", _
         entidad.IdDepartamento _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_DepartamentosUpdate _
    (ByVal entidad As adm_Departamentos)

        db.ExecuteNonQuery("adm_DepartamentosUpdate", _
         entidad.IdDepartamento _
         , entidad.Nombre _
         )
    End Sub

    Public Sub adm_DepartamentosUpdate _
    (ByVal entidad As adm_Departamentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "adm_DepartamentosUpdate", _
         entidad.IdDepartamento _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_EstructurasAdministracion"
    Public Function coo_EstructurasAdministracionSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_EstructurasAdministracionSelectAll").Tables(0)
    End Function

    Public Function coo_EstructurasAdministracionSelectByPK _
      (ByVal Id As System.Int32 _
      ) As coo_EstructurasAdministracion

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_EstructurasAdministracionSelectByPK", _
         Id _
         ).tables(0)

        Dim Entidad As New coo_EstructurasAdministracion
        If dt.Rows.Count > 0 Then
            entidad.Id = dt.rows(0).item("Id")
            entidad.NombreComite1 = dt.rows(0).item("NombreComite1")
            entidad.NombreComite2 = dt.rows(0).item("NombreComite2")
            entidad.NombreComite3 = dt.rows(0).item("NombreComite3")
            entidad.NombreComite4 = dt.rows(0).item("NombreComite4")

        End If
        Return Entidad
    End Function

    Public Sub coo_EstructurasAdministracionDeleteByPK _
      (ByVal Id As System.Int32 _
      )

        db.ExecuteNonQuery("coo_EstructurasAdministracionDeleteByPK", _
         Id _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionDeleteByPK _
      (ByVal Id As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_EstructurasAdministracionDeleteByPK", _
         Id _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionInsert _
    (ByVal entidad As coo_EstructurasAdministracion)

        db.ExecuteNonQuery("coo_EstructurasAdministracionInsert", _
         entidad.Id _
         , entidad.NombreComite1 _
         , entidad.NombreComite2 _
         , entidad.NombreComite3 _
         , entidad.NombreComite4 _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionInsert _
    (ByVal entidad As coo_EstructurasAdministracion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_EstructurasAdministracionInsert", _
         entidad.Id _
         , entidad.NombreComite1 _
         , entidad.NombreComite2 _
         , entidad.NombreComite3 _
         , entidad.NombreComite4 _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionUpdate _
    (ByVal entidad As coo_EstructurasAdministracion)

        db.ExecuteNonQuery("coo_EstructurasAdministracionUpdate", _
         entidad.Id _
         , entidad.NombreComite1 _
         , entidad.NombreComite2 _
         , entidad.NombreComite3 _
         , entidad.NombreComite4 _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionUpdate _
    (ByVal entidad As coo_EstructurasAdministracion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_EstructurasAdministracionUpdate", _
         entidad.Id _
         , entidad.NombreComite1 _
         , entidad.NombreComite2 _
         , entidad.NombreComite3 _
         , entidad.NombreComite4 _
         )
    End Sub

#End Region

#Region "coo_CuentasGastos"
    Public Function coo_CuentasGastosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CuentasGastosSelectAll").Tables(0)
    End Function

    Public Function coo_CuentasGastosSelectByPK _
      (ByVal IdRubro As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasGastos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_CuentasGastosSelectByPK", _
         IdRubro _
         , IdCuenta _
         ).tables(0)

        Dim Entidad As New coo_CuentasGastos
        If dt.Rows.Count > 0 Then
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.CuentaContable = dt.rows(0).item("CuentaContable")

        End If
        Return Entidad
    End Function

    Public Sub coo_CuentasGastosDeleteByPK _
      (ByVal IdRubro As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CuentasGastosDeleteByPK", _
         IdRubro _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasGastosDeleteByPK _
      (ByVal IdRubro As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasGastosDeleteByPK", _
         IdRubro _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasGastosInsert _
    (ByVal entidad As coo_CuentasGastos)

        db.ExecuteNonQuery("coo_CuentasGastosInsert", _
         entidad.IdRubro _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.CuentaContable _
         )
    End Sub

    Public Sub coo_CuentasGastosInsert _
    (ByVal entidad As coo_CuentasGastos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasGastosInsert", _
         entidad.IdRubro _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.CuentaContable _
         )
    End Sub

    Public Sub coo_CuentasGastosUpdate _
    (ByVal entidad As coo_CuentasGastos)

        db.ExecuteNonQuery("coo_CuentasGastosUpdate", _
         entidad.IdRubro _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.CuentaContable _
         )
    End Sub

    Public Sub coo_CuentasGastosUpdate _
    (ByVal entidad As coo_CuentasGastos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasGastosUpdate", _
         entidad.IdRubro _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.CuentaContable _
         )
    End Sub

#End Region

#Region "con_Cuentas"
    Public Function con_CuentasSelectAll() As DataTable
        Return db.ExecuteDataSet("con_CuentasSelectAll").Tables(0)
    End Function

    Public Function con_CuentasSelectByPK _
      (ByVal IdCuenta As System.String) As con_Cuentas

        Dim dt As DataTable
        dt = db.ExecuteDataSet("con_CuentasSelectByPK", _
         IdCuenta).Tables(0)

        Dim Entidad As New con_Cuentas
        If dt.Rows.Count > 0 Then
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.IdCuentaMayor = dt.Rows(0).Item("IdCuentaMayor")
            Entidad.Tipo = dt.Rows(0).Item("Tipo")
            Entidad.Nivel = dt.Rows(0).Item("Nivel")
            Entidad.CargarComo = dt.Rows(0).Item("CargarComo")
            Entidad.EsTransaccional = dt.Rows(0).Item("EsTransaccional")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
        End If
        Return Entidad
    End Function

    Public Sub con_CuentasDeleteByPK _
      (ByVal IdCuenta As System.String)

        db.ExecuteNonQuery("con_CuentasDeleteByPK", IdCuenta)
    End Sub

    Public Sub con_CuentasDeleteByPK _
      (ByVal IdCuenta As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "con_CuentasDeleteByPK", _
         IdCuenta _
         )
    End Sub

    Public Sub con_CuentasInsert _
    (ByVal entidad As con_Cuentas)

        db.ExecuteNonQuery("con_CuentasInsert", _
         entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.IdCuentaMayor _
         , entidad.Tipo _
         , entidad.Nivel _
         , entidad.CargarComo _
         , entidad.EsTransaccional _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub con_CuentasInsert _
    (ByVal entidad As con_Cuentas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "con_CuentasInsert", _
         entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.IdCuentaMayor _
         , entidad.Tipo _
         , entidad.Nivel _
         , entidad.CargarComo _
         , entidad.EsTransaccional _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub con_CuentasUpdate _
    (ByVal entidad As con_Cuentas)

        db.ExecuteNonQuery("con_CuentasUpdate", _
         entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.IdCuentaMayor _
         , entidad.Tipo _
         , entidad.Nivel _
         , entidad.CargarComo _
         , entidad.EsTransaccional _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub con_CuentasUpdate _
    (ByVal entidad As con_Cuentas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "con_CuentasUpdate", _
         entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.IdCuentaMayor _
         , entidad.Tipo _
         , entidad.Nivel _
         , entidad.CargarComo _
         , entidad.EsTransaccional _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region

#Region "coo_Actividades"
    Public Function coo_ActividadesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_ActividadesSelectAll").Tables(0)
    End Function

    Public Function coo_ActividadesSelectByPK _
      (ByVal IdActividad As System.Int32 _
      ) As coo_Actividades

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_ActividadesSelectByPK", _
         IdActividad _
         ).tables(0)

        Dim Entidad As New coo_Actividades
        If dt.Rows.Count > 0 Then
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.IdActividad = dt.rows(0).item("IdActividad")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_ActividadesDeleteByPK _
      (ByVal IdActividad As System.Int32 _
      )

        db.ExecuteNonQuery("coo_ActividadesDeleteByPK", _
         IdActividad _
         )
    End Sub

    Public Sub coo_ActividadesDeleteByPK _
      (ByVal IdActividad As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ActividadesDeleteByPK", _
         IdActividad _
         )
    End Sub

    Public Sub coo_ActividadesInsert _
    (ByVal entidad As coo_Actividades)

        db.ExecuteNonQuery("coo_ActividadesInsert", _
         entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_ActividadesInsert _
    (ByVal entidad As coo_Actividades, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ActividadesInsert", _
         entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_ActividadesUpdate _
    (ByVal entidad As coo_Actividades)

        db.ExecuteNonQuery("coo_ActividadesUpdate", _
         entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_ActividadesUpdate _
    (ByVal entidad As coo_Actividades, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ActividadesUpdate", _
         entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.Nombre _
         )
    End Sub

#End Region

#Region "coo_FormasPagoCaja"
    Public Function coo_FormasPagoCajaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FormasPagoCajaSelectAll").Tables(0)
    End Function

    Public Function coo_FormasPagoCajaSelectByPK _
      (ByVal IdFormaPago As System.Byte _
      ) As coo_FormasPagoCaja

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FormasPagoCajaSelectByPK", _
         IdFormaPago _
         ).tables(0)

        Dim Entidad As New coo_FormasPagoCaja
        If dt.Rows.Count > 0 Then
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.IdCuentaContable = dt.rows(0).item("IdCuentaContable")
            entidad.AbonoCargo = dt.rows(0).item("AbonoCargo")
            entidad.Prefijo = dt.rows(0).item("Prefijo")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FHCreacion = dt.rows(0).item("FHCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_FormasPagoCajaDeleteByPK _
      (ByVal IdFormaPago As System.Byte _
      )

        db.ExecuteNonQuery("coo_FormasPagoCajaDeleteByPK", _
         IdFormaPago _
         )
    End Sub

    Public Sub coo_FormasPagoCajaDeleteByPK _
      (ByVal IdFormaPago As System.Byte _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FormasPagoCajaDeleteByPK", _
         IdFormaPago _
         )
    End Sub

    Public Sub coo_FormasPagoCajaInsert _
    (ByVal entidad As coo_FormasPagoCaja)

        db.ExecuteNonQuery("coo_FormasPagoCajaInsert", _
         entidad.IdFormaPago _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.AbonoCargo _
         , entidad.Prefijo _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_FormasPagoCajaInsert _
    (ByVal entidad As coo_FormasPagoCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FormasPagoCajaInsert", _
         entidad.IdFormaPago _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.AbonoCargo _
         , entidad.Prefijo _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_FormasPagoCajaUpdate _
    (ByVal entidad As coo_FormasPagoCaja)

        db.ExecuteNonQuery("coo_FormasPagoCajaUpdate", _
         entidad.IdFormaPago _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.AbonoCargo _
         , entidad.Prefijo _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_FormasPagoCajaUpdate _
    (ByVal entidad As coo_FormasPagoCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FormasPagoCajaUpdate", _
         entidad.IdFormaPago _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.AbonoCargo _
         , entidad.Prefijo _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

#End Region


#Region "coo_Fuentes"
    Public Function coo_FuentesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FuentesSelectAll").Tables(0)
    End Function

    Public Function coo_FuentesSelectByPK _
      (ByVal IdFuente As System.Int16 _
      ) As coo_Fuentes

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FuentesSelectByPK", _
         IdFuente _
         ).tables(0)

        Dim Entidad As New coo_Fuentes
        If dt.Rows.Count > 0 Then
            entidad.IdFuente = dt.rows(0).item("IdFuente")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_FuentesDeleteByPK _
      (ByVal IdFuente As System.Int16 _
      )

        db.ExecuteNonQuery("coo_FuentesDeleteByPK", _
         IdFuente _
         )
    End Sub

    Public Sub coo_FuentesDeleteByPK _
      (ByVal IdFuente As System.Int16 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FuentesDeleteByPK", _
         IdFuente _
         )
    End Sub

    Public Sub coo_FuentesInsert _
    (ByVal entidad As coo_Fuentes)

        db.ExecuteNonQuery("coo_FuentesInsert", _
         entidad.IdFuente _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_FuentesInsert _
    (ByVal entidad As coo_Fuentes, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FuentesInsert", _
         entidad.IdFuente _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_FuentesUpdate _
    (ByVal entidad As coo_Fuentes)

        db.ExecuteNonQuery("coo_FuentesUpdate", _
         entidad.IdFuente _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_FuentesUpdate _
    (ByVal entidad As coo_Fuentes, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FuentesUpdate", _
         entidad.IdFuente _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_UbicacionesAsociados"
    Public Function coo_UbicacionesAsociadosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_UbicacionesAsociadosSelectAll").Tables(0)
    End Function

    Public Function coo_UbicacionesAsociadosSelectByPK _
      (ByVal IdUbicacion As System.Int32 _
      ) As coo_UbicacionesAsociados

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_UbicacionesAsociadosSelectByPK", _
         IdUbicacion _
         ).tables(0)

        Dim Entidad As New coo_UbicacionesAsociados
        If dt.Rows.Count > 0 Then
            entidad.IdUbicacion = dt.rows(0).item("IdUbicacion")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_UbicacionesAsociadosDeleteByPK _
      (ByVal IdUbicacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_UbicacionesAsociadosDeleteByPK", _
         IdUbicacion _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosDeleteByPK _
      (ByVal IdUbicacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_UbicacionesAsociadosDeleteByPK", _
         IdUbicacion _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosInsert _
    (ByVal entidad As coo_UbicacionesAsociados)

        db.ExecuteNonQuery("coo_UbicacionesAsociadosInsert", _
         entidad.IdUbicacion _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosInsert _
    (ByVal entidad As coo_UbicacionesAsociados, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_UbicacionesAsociadosInsert", _
         entidad.IdUbicacion _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosUpdate _
    (ByVal entidad As coo_UbicacionesAsociados)

        db.ExecuteNonQuery("coo_UbicacionesAsociadosUpdate", _
         entidad.IdUbicacion _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosUpdate _
    (ByVal entidad As coo_UbicacionesAsociados, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_UbicacionesAsociadosUpdate", _
         entidad.IdUbicacion _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_Dividendos"
    Public Function coo_DividendosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DividendosSelectAll").Tables(0)
    End Function

    Public Function coo_DividendosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Periodo As System.Int32 _
      ) As coo_Dividendos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_DividendosSelectByPK", _
         IdAsociado _
         , Periodo _
         ).tables(0)

        Dim Entidad As New coo_Dividendos
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Periodo = dt.rows(0).item("Periodo")
            entidad.SaldoActualAportacion = dt.rows(0).item("SaldoActualAportacion")
            entidad.PorcentajeAportacion = dt.rows(0).item("PorcentajeAportacion")
            entidad.TotalPagarAportacion = dt.rows(0).item("TotalPagarAportacion")
            entidad.SaldoInteresEfectivo = dt.rows(0).item("SaldoInteresEfectivo")
            entidad.PorcentajeEfectivo = dt.rows(0).item("PorcentajeEfectivo")
            entidad.TotalPagarEfectivo = dt.rows(0).item("TotalPagarEfectivo")
            entidad.SaldoInteresLP = dt.rows(0).item("SaldoInteresLP")
            entidad.PorcentajeLP = dt.rows(0).item("PorcentajeLP")
            Entidad.TotalPagarLP = dt.Rows(0).Item("TotalPagarLP")
            Entidad.SaldoOtrasLineas = dt.Rows(0).Item("SaldoOtrasLineas")
            Entidad.TotalPagarOtrasLineas = dt.Rows(0).Item("TotalPagarOtrasLineas")
            entidad.SujetoRetencion = dt.rows(0).item("SujetoRetencion")
            entidad.Retencion = dt.rows(0).item("Retencion")
            entidad.SubTotal = dt.rows(0).item("SubTotal")
            Entidad.AhorroFunerario = dt.Rows(0).Item("AhorroFunerario")
            Entidad.Papeleria = dt.Rows(0).Item("Papeleria")
            entidad.Total = dt.rows(0).item("Total")
            entidad.RepartirAportacion = dt.rows(0).item("RepartirAportacion")
            entidad.PorAportacion = dt.rows(0).item("PorAportacion")
            entidad.RepartirEfectivo = dt.rows(0).item("RepartirEfectivo")
            entidad.PorEfectivo = dt.rows(0).item("PorEfectivo")
            entidad.RepartirLP = dt.rows(0).item("RepartirLP")
            Entidad.PorLP = dt.Rows(0).Item("PorLP")
            Entidad.PorOtrasLineas = dt.Rows(0).Item("PorOtrasLineas")
            Entidad.RepartirFuneraria = dt.Rows(0).Item("RepartirFuneraria")
            Entidad.RepartirOtras = dt.Rows(0).Item("RepartirOtras")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_DividendosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Periodo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_DividendosDeleteByPK", _
         IdAsociado _
         , Periodo _
         )
    End Sub

    Public Sub coo_DividendosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Periodo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosDeleteByPK", _
         IdAsociado _
         , Periodo _
         )
    End Sub

    Public Sub coo_DividendosInsert _
    (ByVal entidad As coo_Dividendos)

        db.ExecuteNonQuery("coo_DividendosInsert", _
         entidad.IdAsociado _
         , entidad.Periodo _
         , entidad.SaldoActualAportacion _
         , entidad.PorcentajeAportacion _
         , entidad.TotalPagarAportacion _
         , entidad.SaldoInteresEfectivo _
         , entidad.PorcentajeEfectivo _
         , entidad.TotalPagarEfectivo _
         , entidad.SaldoInteresLP _
         , entidad.PorcentajeLP _
         , entidad.TotalPagarLP _
         , entidad.SaldoOtrasLineas _
         , entidad.TotalPagarOtrasLineas _
         , entidad.SujetoRetencion _
         , entidad.Retencion _
         , entidad.SubTotal _
         , entidad.AhorroFunerario _
         , entidad.Papeleria _
         , entidad.Total _
         , entidad.RepartirAportacion _
         , entidad.PorAportacion _
         , entidad.RepartirEfectivo _
         , entidad.PorEfectivo _
         , entidad.RepartirLP _
         , entidad.PorLP _
         , entidad.PorOtrasLineas _
         , entidad.RepartirFuneraria _
         , entidad.RepartirOtras _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_DividendosInsert _
    (ByVal entidad As coo_Dividendos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosInsert", _
         entidad.IdAsociado _
         , entidad.Periodo _
         , entidad.SaldoActualAportacion _
         , entidad.PorcentajeAportacion _
         , entidad.TotalPagarAportacion _
         , entidad.SaldoInteresEfectivo _
         , entidad.PorcentajeEfectivo _
         , entidad.TotalPagarEfectivo _
         , entidad.SaldoInteresLP _
         , entidad.PorcentajeLP _
         , entidad.TotalPagarLP _
         , entidad.SaldoOtrasLineas _
         , entidad.TotalPagarOtrasLineas _
         , entidad.SujetoRetencion _
         , entidad.Retencion _
         , entidad.SubTotal _
         , entidad.AhorroFunerario _
         , entidad.Papeleria _
         , entidad.Total _
         , entidad.RepartirAportacion _
         , entidad.PorAportacion _
         , entidad.RepartirEfectivo _
         , entidad.PorEfectivo _
         , entidad.RepartirLP _
         , entidad.PorLP _
         , entidad.PorOtrasLineas _
         , entidad.RepartirFuneraria _
         , entidad.RepartirOtras _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_DividendosUpdate _
    (ByVal entidad As coo_Dividendos)

        db.ExecuteNonQuery("coo_DividendosUpdate", _
         entidad.IdAsociado _
         , entidad.Periodo _
         , entidad.SaldoActualAportacion _
         , entidad.PorcentajeAportacion _
         , entidad.TotalPagarAportacion _
         , entidad.SaldoInteresEfectivo _
         , entidad.PorcentajeEfectivo _
         , entidad.TotalPagarEfectivo _
         , entidad.SaldoInteresLP _
         , entidad.PorcentajeLP _
         , entidad.TotalPagarLP _
         , entidad.SaldoOtrasLineas _
         , entidad.TotalPagarOtrasLineas _
         , entidad.SujetoRetencion _
         , entidad.Retencion _
         , entidad.SubTotal _
         , entidad.AhorroFunerario _
         , entidad.Papeleria _
         , entidad.Total _
         , entidad.RepartirAportacion _
         , entidad.PorAportacion _
         , entidad.RepartirEfectivo _
         , entidad.PorEfectivo _
         , entidad.RepartirLP _
         , entidad.PorLP _
         , entidad.PorOtrasLineas _
         , entidad.RepartirFuneraria _
         , entidad.RepartirOtras _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_DividendosUpdate _
    (ByVal entidad As coo_Dividendos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosUpdate", _
         entidad.IdAsociado _
         , entidad.Periodo _
         , entidad.SaldoActualAportacion _
         , entidad.PorcentajeAportacion _
         , entidad.TotalPagarAportacion _
         , entidad.SaldoInteresEfectivo _
         , entidad.PorcentajeEfectivo _
         , entidad.TotalPagarEfectivo _
         , entidad.SaldoInteresLP _
         , entidad.PorcentajeLP _
         , entidad.TotalPagarLP _
         , entidad.SaldoOtrasLineas _
         , entidad.TotalPagarOtrasLineas _
         , entidad.SujetoRetencion _
         , entidad.Retencion _
         , entidad.SubTotal _
         , entidad.AhorroFunerario _
         , entidad.Papeleria _
         , entidad.Total _
         , entidad.RepartirAportacion _
         , entidad.PorAportacion _
         , entidad.RepartirEfectivo _
         , entidad.PorEfectivo _
         , entidad.RepartirLP _
         , entidad.PorLP _
         , entidad.PorOtrasLineas _
         , entidad.RepartirFuneraria _
         , entidad.RepartirOtras _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_DividendosLineas"
    Public Function coo_DividendosLineasSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DividendosLineasSelectAll").Tables(0)
    End Function

    Public Function coo_DividendosLineasSelectByPK _
      (ByVal Periodo As System.Int32 _
      , ByVal IdLinea As System.Int32 _
      ) As coo_DividendosLineas

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_DividendosLineasSelectByPK", _
         Periodo _
         , IdLinea _
         ).tables(0)

        Dim Entidad As New coo_DividendosLineas
        If dt.Rows.Count > 0 Then
            entidad.Periodo = dt.rows(0).item("Periodo")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Porcentaje = dt.rows(0).item("Porcentaje")

        End If
        Return Entidad
    End Function

    Public Sub coo_DividendosLineasDeleteByPK _
      (ByVal Periodo As System.Int32 _
      , ByVal IdLinea As System.Int32 _
      )

        db.ExecuteNonQuery("coo_DividendosLineasDeleteByPK", _
         Periodo _
         , IdLinea _
         )
    End Sub

    Public Sub coo_DividendosLineasDeleteByPK _
      (ByVal Periodo As System.Int32 _
      , ByVal IdLinea As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosLineasDeleteByPK", _
         Periodo _
         , IdLinea _
         )
    End Sub

    Public Sub coo_DividendosLineasInsert _
    (ByVal entidad As coo_DividendosLineas)

        db.ExecuteNonQuery("coo_DividendosLineasInsert", _
         entidad.Periodo _
         , entidad.IdLinea _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_DividendosLineasInsert _
    (ByVal entidad As coo_DividendosLineas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosLineasInsert", _
         entidad.Periodo _
         , entidad.IdLinea _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_DividendosLineasUpdate _
    (ByVal entidad As coo_DividendosLineas)

        db.ExecuteNonQuery("coo_DividendosLineasUpdate", _
         entidad.Periodo _
         , entidad.IdLinea _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_DividendosLineasUpdate _
    (ByVal entidad As coo_DividendosLineas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DividendosLineasUpdate", _
         entidad.Periodo _
         , entidad.IdLinea _
         , entidad.Porcentaje _
         )
    End Sub

#End Region

#Region "coo_Alertas"
    Public Function coo_AlertasSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AlertasSelectAll").Tables(0)
    End Function

    Public Function coo_AlertasSelectByPK _
      (ByVal IdAlerta As System.Int32 _
      ) As coo_Alertas

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AlertasSelectByPK", _
         IdAlerta _
         ).tables(0)

        Dim Entidad As New coo_Alertas
        If dt.Rows.Count > 0 Then
            entidad.IdAlerta = dt.rows(0).item("IdAlerta")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.FechaDefinicion = dt.rows(0).item("FechaDefinicion")
            entidad.FechaVencimiento = dt.rows(0).item("FechaVencimiento")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ProcesoAplica = dt.rows(0).item("ProcesoAplica")
            entidad.Descripcion = dt.rows(0).item("Descripcion")
            entidad.Contrasenia = dt.rows(0).item("Contrasenia")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_AlertasDeleteByPK _
      (ByVal IdAlerta As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AlertasDeleteByPK", _
         IdAlerta _
         )
    End Sub

    Public Sub coo_AlertasDeleteByPK _
      (ByVal IdAlerta As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AlertasDeleteByPK", _
         IdAlerta _
         )
    End Sub

    Public Sub coo_AlertasInsert _
    (ByVal entidad As coo_Alertas)

        db.ExecuteNonQuery("coo_AlertasInsert", _
         entidad.IdAlerta _
         , entidad.IdAsociado _
         , entidad.IdPrestamo _
         , entidad.FechaDefinicion _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ProcesoAplica _
         , entidad.Descripcion _
         , entidad.Contrasenia _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AlertasInsert _
    (ByVal entidad As coo_Alertas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AlertasInsert", _
         entidad.IdAlerta _
         , entidad.IdAsociado _
         , entidad.IdPrestamo _
         , entidad.FechaDefinicion _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ProcesoAplica _
         , entidad.Descripcion _
         , entidad.Contrasenia _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AlertasUpdate _
    (ByVal entidad As coo_Alertas)

        db.ExecuteNonQuery("coo_AlertasUpdate", _
         entidad.IdAlerta _
         , entidad.IdAsociado _
         , entidad.IdPrestamo _
         , entidad.FechaDefinicion _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ProcesoAplica _
         , entidad.Descripcion _
         , entidad.Contrasenia _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AlertasUpdate _
    (ByVal entidad As coo_Alertas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AlertasUpdate", _
         entidad.IdAlerta _
         , entidad.IdAsociado _
         , entidad.IdPrestamo _
         , entidad.FechaDefinicion _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ProcesoAplica _
         , entidad.Descripcion _
         , entidad.Contrasenia _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_FechasDescuentos"
    Public Function coo_FechasDescuentosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FechasDescuentosSelectAll").Tables(0)
    End Function

    Public Function coo_FechasDescuentosSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As coo_FechasDescuentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FechasDescuentosSelectByPK", _
         IdComprobante _
         ).tables(0)

        Dim Entidad As New coo_FechasDescuentos
        If dt.Rows.Count > 0 Then
            entidad.IdComprobante = dt.rows(0).item("IdComprobante")
            entidad.FechaDescuento = dt.rows(0).item("FechaDescuento")
            entidad.Activo = dt.rows(0).item("Activo")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            entidad.CerradoPor = dt.rows(0).item("CerradoPor")
            Entidad.FechaCerrado = fd.SiEsNulo(dt.Rows(0).Item("FechaCerrado"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_FechasDescuentosDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        db.ExecuteNonQuery("coo_FechasDescuentosDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FechasDescuentosDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FechasDescuentosDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FechasDescuentosInsert _
    (ByVal entidad As coo_FechasDescuentos)

        db.ExecuteNonQuery("coo_FechasDescuentosInsert", _
         entidad.IdComprobante _
         , entidad.FechaDescuento _
         , entidad.Activo _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.CerradoPor _
         , entidad.FechaCerrado _
         )
    End Sub

    Public Sub coo_FechasDescuentosInsert _
    (ByVal entidad As coo_FechasDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FechasDescuentosInsert", _
         entidad.IdComprobante _
         , entidad.FechaDescuento _
         , entidad.Activo _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.CerradoPor _
         , entidad.FechaCerrado _
         )
    End Sub

    Public Sub coo_FechasDescuentosUpdate _
    (ByVal entidad As coo_FechasDescuentos)

        db.ExecuteNonQuery("coo_FechasDescuentosUpdate", _
         entidad.IdComprobante _
         , entidad.FechaDescuento _
         , entidad.Activo _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.CerradoPor _
         , entidad.FechaCerrado _
         )
    End Sub

    Public Sub coo_FechasDescuentosUpdate _
    (ByVal entidad As coo_FechasDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FechasDescuentosUpdate", _
         entidad.IdComprobante _
         , entidad.FechaDescuento _
         , entidad.Activo _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.CerradoPor _
         , entidad.FechaCerrado _
         )
    End Sub

#End Region

#Region "coo_Tecnicos"
    Public Function coo_TecnicosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TecnicosSelectAll").Tables(0)
    End Function

    Public Function coo_TecnicosSelectByPK _
      (ByVal IdTecnico As System.Int16 _
      ) As coo_Tecnicos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TecnicosSelectByPK", _
         IdTecnico _
         ).tables(0)

        Dim Entidad As New coo_Tecnicos
        If dt.Rows.Count > 0 Then
            entidad.IdTecnico = dt.rows(0).item("IdTecnico")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_TecnicosDeleteByPK _
      (ByVal IdTecnico As System.Int16 _
      )

        db.ExecuteNonQuery("coo_TecnicosDeleteByPK", _
         IdTecnico _
         )
    End Sub

    Public Sub coo_TecnicosDeleteByPK _
      (ByVal IdTecnico As System.Int16 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TecnicosDeleteByPK", _
         IdTecnico _
         )
    End Sub

    Public Sub coo_TecnicosInsert _
    (ByVal entidad As coo_Tecnicos)

        db.ExecuteNonQuery("coo_TecnicosInsert", _
         entidad.IdTecnico _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TecnicosInsert _
    (ByVal entidad As coo_Tecnicos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TecnicosInsert", _
         entidad.IdTecnico _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TecnicosUpdate _
    (ByVal entidad As coo_Tecnicos)

        db.ExecuteNonQuery("coo_TecnicosUpdate", _
         entidad.IdTecnico _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TecnicosUpdate _
    (ByVal entidad As coo_Tecnicos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TecnicosUpdate", _
         entidad.IdTecnico _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_TiposMovimientoCaja"
    Public Function coo_TiposMovimientoCajaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TiposMovimientoCajaSelectAll").Tables(0)
    End Function

    Public Function coo_TiposMovimientoCajaSelectByPK _
      (ByVal IdTipo As System.Int32 _
      ) As coo_TiposMovimientoCaja

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TiposMovimientoCajaSelectByPK", _
         IdTipo _
         ).tables(0)

        Dim Entidad As New coo_TiposMovimientoCaja
        If dt.Rows.Count > 0 Then
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.IdCuentaContable = dt.rows(0).item("IdCuentaContable")
            entidad.TipoAPlicacion = dt.rows(0).item("TipoAPlicacion")
            entidad.LineaCorte = dt.rows(0).item("LineaCorte")
            entidad.IncluyeIva = dt.rows(0).item("IncluyeIva")
            entidad.AplicaIsr = dt.rows(0).item("AplicaIsr")

        End If
        Return Entidad
    End Function

    Public Sub coo_TiposMovimientoCajaDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_TiposMovimientoCajaDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposMovimientoCajaDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaInsert _
    (ByVal entidad As coo_TiposMovimientoCaja)

        db.ExecuteNonQuery("coo_TiposMovimientoCajaInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.TipoAPlicacion _
         , entidad.LineaCorte _
         , entidad.IncluyeIva _
         , entidad.AplicaIsr _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaInsert _
    (ByVal entidad As coo_TiposMovimientoCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposMovimientoCajaInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.TipoAPlicacion _
         , entidad.LineaCorte _
         , entidad.IncluyeIva _
         , entidad.AplicaIsr _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaUpdate _
    (ByVal entidad As coo_TiposMovimientoCaja)

        db.ExecuteNonQuery("coo_TiposMovimientoCajaUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.TipoAPlicacion _
         , entidad.LineaCorte _
         , entidad.IncluyeIva _
         , entidad.AplicaIsr _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaUpdate _
    (ByVal entidad As coo_TiposMovimientoCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposMovimientoCajaUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.TipoAPlicacion _
         , entidad.LineaCorte _
         , entidad.IncluyeIva _
         , entidad.AplicaIsr _
         )
    End Sub

#End Region

#Region "coo_RubrosActividades"
    Public Function coo_RubrosActividadesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_RubrosActividadesSelectAll").Tables(0)
    End Function

    Public Function coo_RubrosActividadesSelectByPK _
      (ByVal IdRubro As System.Int16 _
      ) As coo_RubrosActividades

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_RubrosActividadesSelectByPK", _
         IdRubro _
         ).tables(0)

        Dim Entidad As New coo_RubrosActividades
        If dt.Rows.Count > 0 Then
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_RubrosActividadesDeleteByPK _
      (ByVal IdRubro As System.Int16 _
      )

        db.ExecuteNonQuery("coo_RubrosActividadesDeleteByPK", _
         IdRubro _
         )
    End Sub

    Public Sub coo_RubrosActividadesDeleteByPK _
      (ByVal IdRubro As System.Int16 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_RubrosActividadesDeleteByPK", _
         IdRubro _
         )
    End Sub

    Public Sub coo_RubrosActividadesInsert _
    (ByVal entidad As coo_RubrosActividades)

        db.ExecuteNonQuery("coo_RubrosActividadesInsert", _
         entidad.IdRubro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_RubrosActividadesInsert _
    (ByVal entidad As coo_RubrosActividades, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_RubrosActividadesInsert", _
         entidad.IdRubro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_RubrosActividadesUpdate _
    (ByVal entidad As coo_RubrosActividades)

        db.ExecuteNonQuery("coo_RubrosActividadesUpdate", _
         entidad.IdRubro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_RubrosActividadesUpdate _
    (ByVal entidad As coo_RubrosActividades, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_RubrosActividadesUpdate", _
         entidad.IdRubro _
         , entidad.Nombre _
         )
    End Sub

#End Region

#Region "coo_FondosCaja"
    Public Function coo_FondosCajaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FondosCajaSelectAll").Tables(0)
    End Function

    Public Function coo_FondosCajaSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As coo_FondosCaja

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FondosCajaSelectByPK", _
         IdComprobante _
         ).tables(0)

        Dim Entidad As New coo_FondosCaja
        If dt.Rows.Count > 0 Then
            entidad.IdComprobante = dt.rows(0).item("IdComprobante")
            entidad.Referencia = dt.rows(0).item("Referencia")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.Valor = dt.rows(0).item("Valor")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            entidad.FechaHoraModificacion = dt.rows(0).item("FechaHoraModificacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_FondosCajaDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        db.ExecuteNonQuery("coo_FondosCajaDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FondosCajaDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FondosCajaDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FondosCajaInsert _
    (ByVal entidad As coo_FondosCaja)

        db.ExecuteNonQuery("coo_FondosCajaInsert", _
         entidad.IdComprobante _
         , entidad.Referencia _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_FondosCajaInsert _
    (ByVal entidad As coo_FondosCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FondosCajaInsert", _
         entidad.IdComprobante _
         , entidad.Referencia _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_FondosCajaUpdate _
    (ByVal entidad As coo_FondosCaja)

        db.ExecuteNonQuery("coo_FondosCajaUpdate", _
         entidad.IdComprobante _
         , entidad.Referencia _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_FondosCajaUpdate _
    (ByVal entidad As coo_FondosCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FondosCajaUpdate", _
         entidad.IdComprobante _
         , entidad.Referencia _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region

#Region "coo_Asociados"
    Public Function coo_AsociadosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AsociadosSelectAll").Tables(0)
    End Function

    Public Function coo_AsociadosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      ) As coo_Asociados

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AsociadosSelectByPK", _
         IdAsociado _
         ).tables(0)

        Dim Entidad As New coo_Asociados
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.Nombres = dt.rows(0).item("Nombres")
            entidad.Apellidos = dt.rows(0).item("Apellidos")
            entidad.RazonSocial = dt.rows(0).item("RazonSocial")
            entidad.NombreRepLegal = dt.rows(0).item("NombreRepLegal")
            entidad.ConocidoPor = dt.rows(0).item("ConocidoPor")
            entidad.PresentaCredencial = dt.rows(0).item("PresentaCredencial")
            entidad.IdUbicacion = dt.rows(0).item("IdUbicacion")
            entidad.IdTipoPersona = dt.rows(0).item("IdTipoPersona")
            entidad.IdTipoDocumento = dt.rows(0).item("IdTipoDocumento")
            entidad.NumeroDocumento = dt.rows(0).item("NumeroDocumento")
            entidad.Nit = dt.rows(0).item("Nit")
            entidad.IsssAfp = dt.rows(0).item("IsssAfp")
            entidad.OtroDocumento = dt.rows(0).item("OtroDocumento")
            entidad.TipoImpuesto = dt.rows(0).item("TipoImpuesto")
            entidad.FechaNacimiento = dt.rows(0).item("FechaNacimiento")
            entidad.LugarNacimiento = dt.rows(0).item("LugarNacimiento")
            entidad.Nacionalidad = dt.rows(0).item("Nacionalidad")
            entidad.IdSexo = dt.rows(0).item("IdSexo")
            entidad.IdEstadoCivil = dt.rows(0).item("IdEstadoCivil")
            entidad.IdProfesion = dt.rows(0).item("IdProfesion")
            entidad.LugarExpedicion = dt.rows(0).item("LugarExpedicion")
            entidad.FechaExpedicion = dt.rows(0).item("FechaExpedicion")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.Ubicacion = dt.rows(0).item("Ubicacion")
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.IdMunicipio = dt.rows(0).item("IdMunicipio")
            entidad.IdCanton = dt.rows(0).item("IdCanton")
            entidad.Telefonos = dt.rows(0).item("Telefonos")
            entidad.CorreoElectronico = dt.rows(0).item("CorreoElectronico")
            entidad.NombreConyuge = dt.rows(0).item("NombreConyuge")
            Entidad.FechaNacConyuge = fd.SiEsNulo(dt.Rows(0).Item("FechaNacConyuge"), Nothing)
            entidad.NumDocConyuge = dt.rows(0).item("NumDocConyuge")
            entidad.LugarTrabajoConyuge = dt.rows(0).item("LugarTrabajoConyuge")
            entidad.DirTrabajoConyuge = dt.rows(0).item("DirTrabajoConyuge")
            entidad.SalarioConyuge = dt.rows(0).item("SalarioConyuge")
            entidad.TelTrabajoConyuge = dt.rows(0).item("TelTrabajoConyuge")
            entidad.IdProfesionConyuge = dt.rows(0).item("IdProfesionConyuge")
            entidad.CargoConyuge = dt.rows(0).item("CargoConyuge")
            entidad.LugarTrabajo = dt.rows(0).item("LugarTrabajo")
            entidad.DireccionTrabajo = dt.rows(0).item("DireccionTrabajo")
            entidad.CargoTrabajo = dt.rows(0).item("CargoTrabajo")
            Entidad.FechaIngresoTrabajo = fd.SiEsNulo(dt.Rows(0).Item("FechaIngresoTrabajo"), Nothing)
            entidad.TelefonoTrabajo = dt.rows(0).item("TelefonoTrabajo")
            entidad.SalarioMensual = dt.rows(0).item("SalarioMensual")
            entidad.OtrosIngresos = dt.rows(0).item("OtrosIngresos")
            entidad.IngresosReportados = dt.rows(0).item("IngresosReportados")
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.IdActividad = dt.rows(0).item("IdActividad")
            Entidad.CuotaPresEfectivo = dt.Rows(0).Item("CuotaPresEfectivo")
            entidad.PrestamosEfectivo = dt.rows(0).item("PrestamosEfectivo")
            entidad.GiroNegocio = dt.rows(0).item("GiroNegocio")
            entidad.Monto1 = dt.rows(0).item("Monto1")
            entidad.Monto2 = dt.rows(0).item("Monto2")
            entidad.Monto3 = dt.rows(0).item("Monto3")
            entidad.Monto4 = dt.rows(0).item("Monto4")
            entidad.Monto5 = dt.rows(0).item("Monto5")
            entidad.NumeroHijos = dt.rows(0).item("NumeroHijos")
            entidad.TipoVivienda = dt.rows(0).item("TipoVivienda")
            entidad.PropietarioVivienda = dt.rows(0).item("PropietarioVivienda")
            entidad.NomReferencia1 = dt.rows(0).item("NomReferencia1")
            entidad.NomReferencia2 = dt.rows(0).item("NomReferencia2")
            Entidad.TrabajoReferencia1 = fd.SiEsNulo(dt.Rows(0).Item("TrabajoReferencia1"), Nothing)
            Entidad.TrabajoReferencia2 = fd.SiEsNulo(dt.Rows(0).Item("TrabajoReferencia2"), Nothing)
            entidad.DirReferencia1 = dt.rows(0).item("DirReferencia1")
            entidad.DirReferencia2 = dt.rows(0).item("DirReferencia2")
            entidad.TelReferencia1 = dt.rows(0).item("TelReferencia1")
            entidad.TelReferencia2 = dt.rows(0).item("TelReferencia2")
            entidad.EsSocio1 = dt.rows(0).item("EsSocio1")
            entidad.EsSocio2 = dt.rows(0).item("EsSocio2")
            entidad.FechaIngreso = dt.rows(0).item("FechaIngreso")
            entidad.FechaReIngreso = dt.rows(0).item("FechaReIngreso")
            Entidad.FechaRetiro = fd.SiEsNulo(dt.Rows(0).Item("FechaRetiro"), Nothing)
            Entidad.CorrelativoSolicitud = dt.Rows(0).Item("CorrelativoSolicitud")
            Entidad.CorrelativoSolicitudCruce = dt.Rows(0).Item("CorrelativoSolicitudCruce")
            Entidad.AplicaComision = dt.Rows(0).Item("AplicaComision")
            Entidad.EnviarDescuentos = dt.Rows(0).Item("EnviarDescuentos")
            Entidad.EnviarEstadoCuenta = dt.Rows(0).Item("EnviarEstadoCuenta")
            entidad.IdTipoRelacion = dt.rows(0).item("IdTipoRelacion")
            entidad.IdEstado = dt.rows(0).item("IdEstado")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            Entidad.Celular = fd.SiEsNulo(dt.Rows(0).Item("Celular"), Nothing)
            Entidad.NombreTrabajoAnterior = fd.SiEsNulo(dt.Rows(0).Item("NombreTrabajoAnterior"), Nothing)
            Entidad.TelefonoTrabajoAnterior = fd.SiEsNulo(dt.Rows(0).Item("TelefonoTrabajoAnterior"), Nothing)
            Entidad.ExcluirDividendos = dt.Rows(0).Item("ExcluirDividendos")
            Entidad.ExcluirDividendosFuneraria = dt.Rows(0).Item("ExcluirDividendosFuneraria")
            Entidad.AplicaTelefonia = dt.Rows(0).Item("AplicaTelefonia")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_AsociadosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AsociadosDeleteByPK", _
         IdAsociado _
         )
    End Sub

    Public Sub coo_AsociadosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosDeleteByPK", _
         IdAsociado _
         )
    End Sub

    Public Sub coo_AsociadosInsert _
    (ByVal entidad As coo_Asociados)

        db.ExecuteNonQuery("coo_AsociadosInsert", _
         entidad.IdAsociado _
         , entidad.Numero _
         , entidad.Nombres _
         , entidad.Apellidos _
         , entidad.RazonSocial _
         , entidad.NombreRepLegal _
         , entidad.ConocidoPor _
         , entidad.PresentaCredencial _
         , entidad.IdUbicacion _
         , entidad.IdTipoPersona _
         , entidad.IdTipoDocumento _
         , entidad.NumeroDocumento _
         , entidad.Nit _
         , entidad.IsssAfp _
         , entidad.OtroDocumento _
         , entidad.TipoImpuesto _
         , entidad.FechaNacimiento _
         , entidad.LugarNacimiento _
         , entidad.Nacionalidad _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.IdProfesion _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.Direccion _
         , entidad.Ubicacion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.CorreoElectronico _
         , entidad.NombreConyuge _
         , entidad.FechaNacConyuge _
         , entidad.NumDocConyuge _
         , entidad.LugarTrabajoConyuge _
         , entidad.DirTrabajoConyuge _
         , entidad.SalarioConyuge _
         , entidad.TelTrabajoConyuge _
         , entidad.IdProfesionConyuge _
         , entidad.CargoConyuge _
         , entidad.LugarTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.CargoTrabajo _
         , entidad.FechaIngresoTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.SalarioMensual _
         , entidad.OtrosIngresos _
         , entidad.IngresosReportados _
         , entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.CuotaPresEfectivo _
         , entidad.PrestamosEfectivo _
         , entidad.GiroNegocio _
         , entidad.Monto1 _
         , entidad.Monto2 _
         , entidad.Monto3 _
         , entidad.Monto4 _
         , entidad.Monto5 _
         , entidad.NumeroHijos _
         , entidad.TipoVivienda _
         , entidad.PropietarioVivienda _
         , entidad.NomReferencia1 _
         , entidad.NomReferencia2 _
         , entidad.TrabajoReferencia1 _
         , entidad.TrabajoReferencia2 _
         , entidad.DirReferencia1 _
         , entidad.DirReferencia2 _
         , entidad.TelReferencia1 _
         , entidad.TelReferencia2 _
         , entidad.EsSocio1 _
         , entidad.EsSocio2 _
         , entidad.FechaIngreso _
         , entidad.FechaReIngreso _
         , entidad.FechaRetiro _
         , entidad.CorrelativoSolicitud _
         , entidad.CorrelativoSolicitudCruce _
         , entidad.AplicaComision _
         , entidad.EnviarDescuentos _
         , entidad.EnviarEstadoCuenta _
         , entidad.IdTipoRelacion _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.Celular _
         , entidad.NombreTrabajoAnterior _
         , entidad.TelefonoTrabajoAnterior _
         , entidad.ExcluirDividendos _
         , entidad.ExcluirDividendosFuneraria _
         , entidad.AplicaTelefonia _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosInsert _
    (ByVal entidad As coo_Asociados, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosInsert", _
         entidad.IdAsociado _
         , entidad.Numero _
         , entidad.Nombres _
         , entidad.Apellidos _
         , entidad.RazonSocial _
         , entidad.NombreRepLegal _
         , entidad.ConocidoPor _
         , entidad.PresentaCredencial _
         , entidad.IdUbicacion _
         , entidad.IdTipoPersona _
         , entidad.IdTipoDocumento _
         , entidad.NumeroDocumento _
         , entidad.Nit _
         , entidad.IsssAfp _
         , entidad.OtroDocumento _
         , entidad.TipoImpuesto _
         , entidad.FechaNacimiento _
         , entidad.LugarNacimiento _
         , entidad.Nacionalidad _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.IdProfesion _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.Direccion _
         , entidad.Ubicacion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.CorreoElectronico _
         , entidad.NombreConyuge _
         , entidad.FechaNacConyuge _
         , entidad.NumDocConyuge _
         , entidad.LugarTrabajoConyuge _
         , entidad.DirTrabajoConyuge _
         , entidad.SalarioConyuge _
         , entidad.TelTrabajoConyuge _
         , entidad.IdProfesionConyuge _
         , entidad.CargoConyuge _
         , entidad.LugarTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.CargoTrabajo _
         , entidad.FechaIngresoTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.SalarioMensual _
         , entidad.OtrosIngresos _
         , entidad.IngresosReportados _
         , entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.CuotaPresEfectivo _
         , entidad.PrestamosEfectivo _
         , entidad.GiroNegocio _
         , entidad.Monto1 _
         , entidad.Monto2 _
         , entidad.Monto3 _
         , entidad.Monto4 _
         , entidad.Monto5 _
         , entidad.NumeroHijos _
         , entidad.TipoVivienda _
         , entidad.PropietarioVivienda _
         , entidad.NomReferencia1 _
         , entidad.NomReferencia2 _
         , entidad.TrabajoReferencia1 _
         , entidad.TrabajoReferencia2 _
         , entidad.DirReferencia1 _
         , entidad.DirReferencia2 _
         , entidad.TelReferencia1 _
         , entidad.TelReferencia2 _
         , entidad.EsSocio1 _
         , entidad.EsSocio2 _
         , entidad.FechaIngreso _
         , entidad.FechaReIngreso _
         , entidad.FechaRetiro _
         , entidad.CorrelativoSolicitud _
         , entidad.CorrelativoSolicitudCruce _
          , entidad.AplicaComision _
          , entidad.EnviarDescuentos _
          , entidad.EnviarEstadoCuenta _
         , entidad.IdTipoRelacion _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.Celular _
         , entidad.NombreTrabajoAnterior _
         , entidad.TelefonoTrabajoAnterior _
                  , entidad.ExcluirDividendos _
         , entidad.ExcluirDividendosFuneraria _
         , entidad.AplicaTelefonia _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosUpdate _
    (ByVal entidad As coo_Asociados)

        db.ExecuteNonQuery("coo_AsociadosUpdate", _
         entidad.IdAsociado _
         , entidad.Numero _
         , entidad.Nombres _
         , entidad.Apellidos _
         , entidad.RazonSocial _
         , entidad.NombreRepLegal _
         , entidad.ConocidoPor _
         , entidad.PresentaCredencial _
         , entidad.IdUbicacion _
         , entidad.IdTipoPersona _
         , entidad.IdTipoDocumento _
         , entidad.NumeroDocumento _
         , entidad.Nit _
         , entidad.IsssAfp _
         , entidad.OtroDocumento _
         , entidad.TipoImpuesto _
         , entidad.FechaNacimiento _
         , entidad.LugarNacimiento _
         , entidad.Nacionalidad _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.IdProfesion _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.Direccion _
         , entidad.Ubicacion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.CorreoElectronico _
         , entidad.NombreConyuge _
         , entidad.FechaNacConyuge _
         , entidad.NumDocConyuge _
         , entidad.LugarTrabajoConyuge _
         , entidad.DirTrabajoConyuge _
         , entidad.SalarioConyuge _
         , entidad.TelTrabajoConyuge _
         , entidad.IdProfesionConyuge _
         , entidad.CargoConyuge _
         , entidad.LugarTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.CargoTrabajo _
         , entidad.FechaIngresoTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.SalarioMensual _
         , entidad.OtrosIngresos _
         , entidad.IngresosReportados _
         , entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.CuotaPresEfectivo _
         , entidad.PrestamosEfectivo _
         , entidad.GiroNegocio _
         , entidad.Monto1 _
         , entidad.Monto2 _
         , entidad.Monto3 _
         , entidad.Monto4 _
         , entidad.Monto5 _
         , entidad.NumeroHijos _
         , entidad.TipoVivienda _
         , entidad.PropietarioVivienda _
         , entidad.NomReferencia1 _
         , entidad.NomReferencia2 _
         , entidad.TrabajoReferencia1 _
         , entidad.TrabajoReferencia2 _
         , entidad.DirReferencia1 _
         , entidad.DirReferencia2 _
         , entidad.TelReferencia1 _
         , entidad.TelReferencia2 _
         , entidad.EsSocio1 _
         , entidad.EsSocio2 _
         , entidad.FechaIngreso _
         , entidad.FechaReIngreso _
         , entidad.FechaRetiro _
         , entidad.CorrelativoSolicitud _
         , entidad.CorrelativoSolicitudCruce _
          , entidad.AplicaComision _
          , entidad.EnviarDescuentos _
          , entidad.EnviarEstadoCuenta _
         , entidad.IdTipoRelacion _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.Celular _
         , entidad.NombreTrabajoAnterior _
         , entidad.TelefonoTrabajoAnterior _
                  , entidad.ExcluirDividendos _
         , entidad.ExcluirDividendosFuneraria _
, entidad.AplicaTelefonia _
, entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosUpdate _
    (ByVal entidad As coo_Asociados, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosUpdate", _
         entidad.IdAsociado _
         , entidad.Numero _
         , entidad.Nombres _
         , entidad.Apellidos _
         , entidad.RazonSocial _
         , entidad.NombreRepLegal _
         , entidad.ConocidoPor _
         , entidad.PresentaCredencial _
         , entidad.IdUbicacion _
         , entidad.IdTipoPersona _
         , entidad.IdTipoDocumento _
         , entidad.NumeroDocumento _
         , entidad.Nit _
         , entidad.IsssAfp _
         , entidad.OtroDocumento _
         , entidad.TipoImpuesto _
         , entidad.FechaNacimiento _
         , entidad.LugarNacimiento _
         , entidad.Nacionalidad _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.IdProfesion _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.Direccion _
         , entidad.Ubicacion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.CorreoElectronico _
         , entidad.NombreConyuge _
         , entidad.FechaNacConyuge _
         , entidad.NumDocConyuge _
         , entidad.LugarTrabajoConyuge _
         , entidad.DirTrabajoConyuge _
         , entidad.SalarioConyuge _
         , entidad.TelTrabajoConyuge _
         , entidad.IdProfesionConyuge _
         , entidad.CargoConyuge _
         , entidad.LugarTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.CargoTrabajo _
         , entidad.FechaIngresoTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.SalarioMensual _
         , entidad.OtrosIngresos _
         , entidad.IngresosReportados _
         , entidad.IdRubro _
         , entidad.IdActividad _
         , entidad.CuotaPresEfectivo _
         , entidad.PrestamosEfectivo _
         , entidad.GiroNegocio _
         , entidad.Monto1 _
         , entidad.Monto2 _
         , entidad.Monto3 _
         , entidad.Monto4 _
         , entidad.Monto5 _
         , entidad.NumeroHijos _
         , entidad.TipoVivienda _
         , entidad.PropietarioVivienda _
         , entidad.NomReferencia1 _
         , entidad.NomReferencia2 _
         , entidad.TrabajoReferencia1 _
         , entidad.TrabajoReferencia2 _
         , entidad.DirReferencia1 _
         , entidad.DirReferencia2 _
         , entidad.TelReferencia1 _
         , entidad.TelReferencia2 _
         , entidad.EsSocio1 _
         , entidad.EsSocio2 _
         , entidad.FechaIngreso _
         , entidad.FechaReIngreso _
         , entidad.FechaRetiro _
         , entidad.CorrelativoSolicitud _
         , entidad.CorrelativoSolicitudCruce _
          , entidad.AplicaComision _
          , entidad.EnviarDescuentos _
          , entidad.EnviarEstadoCuenta _
         , entidad.IdTipoRelacion _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.Celular _
         , entidad.NombreTrabajoAnterior _
         , entidad.TelefonoTrabajoAnterior _
         , entidad.ExcluirDividendos _
         , entidad.ExcluirDividendosFuneraria _
         , entidad.AplicaTelefonia _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "Coo_AsociadosTelefonia"
    Public Function coo_AsociadosTelefoniaSelectAll(ByVal IdAsociado As System.Int32) As DataTable
        Dim sSQL As String = "SELECT * FROM Coo_AsociadosTelefonia where IdAsociado = " & IdAsociado
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function coo_AsociadosTelefoniaSelectByPK _
      (ByVal IdAsociado As System.Int32 _
       , ByVal IdTelefono As System.Int32 _
      ) As coo_AsociadosTelefonia

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_AsociadosTelefoniaSelectByPK", _
         IdAsociado _
         , IdTelefono _
         ).Tables(0)

        Dim Entidad As New coo_AsociadosTelefonia
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.IdTelefono = dt.Rows(0).Item("IdTelefono")
            Entidad.Compania = dt.Rows(0).Item("Compania")
            Entidad.Ntelefono = fd.SiEsNulo(dt.Rows(0).Item("Ntelefono"), "")
            Entidad.NContrato = fd.SiEsNulo(dt.Rows(0).Item("NContrato"), "")
            Entidad.Marca = fd.SiEsNulo(dt.Rows(0).Item("Marca"), "")
            Entidad.Modelo = fd.SiEsNulo(dt.Rows(0).Item("Modelo"), "")
            Entidad.Serie = fd.SiEsNulo(dt.Rows(0).Item("Serie"), "")
            Entidad.Activo = dt.Rows(0).Item("Activo")
            Entidad.PlanDatos = dt.Rows(0).Item("PlanDatos")
            Entidad.PlanVoz = dt.Rows(0).Item("PlanVoz")
            Entidad.CapacidadDatos = fd.SiEsNulo(dt.Rows(0).Item("CapacidadDatos"), "")
            Entidad.CapacidadVoz = fd.SiEsNulo(dt.Rows(0).Item("CapacidadVoz"), "")
            Entidad.FechaActivacion = fd.SiEsNulo(dt.Rows(0).Item("FechaActivacion"), Nothing)
            Entidad.FechaVencimiento = fd.SiEsNulo(dt.Rows(0).Item("FechaVencimiento"), Nothing)
            Entidad.FechaAsiganacionMovil = fd.SiEsNulo(dt.Rows(0).Item("FechaAsiganacionMovil"), Nothing)
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = fd.SiEsNulo(dt.Rows(0).Item("ModificadoPor"), "")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
        End If
        Return Entidad
    End Function

    Public Sub coo_AsociadosTelefoniaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
       , ByVal IdTelefono As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AsociadosTelefoniaDeleteByPK", _
         IdAsociado _
         , IdTelefono _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
       , ByVal IdTelefono As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosTelefoniaDeleteByPK", _
         IdAsociado _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaInsert _
    (ByVal entidad As coo_AsociadosTelefonia)

        db.ExecuteNonQuery("coo_AsociadosTelefoniaInsert", _
         entidad.IdAsociado _
         , entidad.IdTelefono _
         , entidad.Compania _
         , entidad.Ntelefono _
         , entidad.NContrato _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Activo _
         , entidad.PlanDatos _
         , entidad.PlanVoz _
         , entidad.CapacidadDatos _
         , entidad.CapacidadVoz _
         , entidad.FechaActivacion _
         , entidad.FechaVencimiento _
         , entidad.FechaAsiganacionMovil _
        , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaInsert _
    (ByVal entidad As coo_AsociadosTelefonia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosTelefoniaInsert", _
         entidad.IdAsociado _
         , entidad.IdTelefono _
         , entidad.Compania _
         , entidad.Ntelefono _
         , entidad.NContrato _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Activo _
         , entidad.PlanDatos _
         , entidad.PlanVoz _
         , entidad.CapacidadDatos _
         , entidad.CapacidadVoz _
         , entidad.FechaActivacion _
         , entidad.FechaVencimiento _
         , entidad.FechaAsiganacionMovil _
        , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaUpdate _
    (ByVal entidad As coo_AsociadosTelefonia)

        db.ExecuteNonQuery("coo_AsociadosTelefoniaUpdate", _
          entidad.IdAsociado _
          , entidad.IdTelefono _
         , entidad.Compania _
         , entidad.Ntelefono _
         , entidad.NContrato _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Activo _
         , entidad.PlanDatos _
         , entidad.PlanVoz _
         , entidad.CapacidadDatos _
         , entidad.CapacidadVoz _
         , entidad.FechaActivacion _
         , entidad.FechaVencimiento _
         , entidad.FechaAsiganacionMovil _
        , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaUpdate _
    (ByVal entidad As coo_AsociadosTelefonia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosTelefoniaUpdate", _
          entidad.IdAsociado _
          , entidad.IdTelefono _
         , entidad.Compania _
         , entidad.Ntelefono _
         , entidad.NContrato _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Activo _
         , entidad.PlanDatos _
         , entidad.PlanVoz _
         , entidad.CapacidadDatos _
         , entidad.CapacidadVoz _
         , entidad.FechaActivacion _
         , entidad.FechaVencimiento _
         , entidad.FechaAsiganacionMovil _
        , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_AsociadosDescuentos"
    Public Function coo_AsociadosDescuentosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AsociadosDescuentosSelectAll").Tables(0)
    End Function

    Public Function coo_AsociadosDescuentosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As coo_AsociadosDescuentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AsociadosDescuentosSelectByPK", _
         IdAsociado _
         , IdDetalle _
         ).tables(0)

        Dim Entidad As New coo_AsociadosDescuentos
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdDetalle = dt.rows(0).item("IdDetalle")
            entidad.IdPlanilla = dt.rows(0).item("IdPlanilla")
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.Descuento = dt.rows(0).item("Descuento")

        End If
        Return Entidad
    End Function

    Public Sub coo_AsociadosDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AsociadosDescuentosDeleteByPK", _
         IdAsociado _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosDescuentosDeleteByPK", _
         IdAsociado _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosInsert _
    (ByVal entidad As coo_AsociadosDescuentos)

        db.ExecuteNonQuery("coo_AsociadosDescuentosInsert", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.IdRubro _
         , entidad.Descuento _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosInsert _
    (ByVal entidad As coo_AsociadosDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosDescuentosInsert", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.IdRubro _
         , entidad.Descuento _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosUpdate _
    (ByVal entidad As coo_AsociadosDescuentos)

        db.ExecuteNonQuery("coo_AsociadosDescuentosUpdate", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.IdRubro _
         , entidad.Descuento _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosUpdate _
    (ByVal entidad As coo_AsociadosDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosDescuentosUpdate", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.IdRubro _
         , entidad.Descuento _
         )
    End Sub

#End Region
#Region "coo_AsociadosCambioDescuentos"
    Public Function coo_AsociadosCambioDescuentosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AsociadosCambioDescuentosSelectAll").Tables(0)
    End Function

    Public Function coo_AsociadosCambioDescuentosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Fecha As System.DateTime _
      ) As coo_AsociadosCambioDescuentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AsociadosCambioDescuentosSelectByPK", _
         IdAsociado _
         , IdDetalle _
         , Fecha _
         ).tables(0)

        Dim Entidad As New coo_AsociadosCambioDescuentos
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdDetalle = dt.rows(0).item("IdDetalle")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.Valor = dt.rows(0).item("Valor")
            entidad.IdRubro = dt.rows(0).item("IdRubro")
            entidad.MotivoCambio = dt.rows(0).item("MotivoCambio")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_AsociadosCambioDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Fecha As System.DateTime _
      )

        db.ExecuteNonQuery("coo_AsociadosCambioDescuentosDeleteByPK", _
         IdAsociado _
         , IdDetalle _
         , Fecha _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Fecha As System.DateTime _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosCambioDescuentosDeleteByPK", _
         IdAsociado _
         , IdDetalle _
         , Fecha _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosInsert _
    (ByVal entidad As coo_AsociadosCambioDescuentos)

        db.ExecuteNonQuery("coo_AsociadosCambioDescuentosInsert", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.IdRubro _
         , entidad.MotivoCambio _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosInsert _
    (ByVal entidad As coo_AsociadosCambioDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosCambioDescuentosInsert", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.IdRubro _
         , entidad.MotivoCambio _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosUpdate _
    (ByVal entidad As coo_AsociadosCambioDescuentos)

        db.ExecuteNonQuery("coo_AsociadosCambioDescuentosUpdate", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.IdRubro _
         , entidad.MotivoCambio _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosUpdate _
    (ByVal entidad As coo_AsociadosCambioDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosCambioDescuentosUpdate", _
         entidad.IdAsociado _
         , entidad.IdDetalle _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.IdRubro _
         , entidad.MotivoCambio _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_AsociadosBeneficiarios"
    Public Function coo_AsociadosBeneficiariosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AsociadosBeneficiariosSelectAll").Tables(0)
    End Function

    Public Function coo_AsociadosBeneficiariosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdBeneficiario As System.Byte _
      ) As coo_AsociadosBeneficiarios

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AsociadosBeneficiariosSelectByPK", _
         IdAsociado _
         , IdBeneficiario _
         ).tables(0)

        Dim Entidad As New coo_AsociadosBeneficiarios
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdBeneficiario = dt.rows(0).item("IdBeneficiario")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Domicilio = dt.rows(0).item("Domicilio")
            entidad.Parentesco = dt.rows(0).item("Parentesco")
            entidad.Porcentaje = dt.rows(0).item("Porcentaje")

        End If
        Return Entidad
    End Function

    Public Sub coo_AsociadosBeneficiariosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdBeneficiario As System.Byte _
      )

        db.ExecuteNonQuery("coo_AsociadosBeneficiariosDeleteByPK", _
         IdAsociado _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdBeneficiario As System.Byte _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosBeneficiariosDeleteByPK", _
         IdAsociado _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosInsert _
    (ByVal entidad As coo_AsociadosBeneficiarios)

        db.ExecuteNonQuery("coo_AsociadosBeneficiariosInsert", _
         entidad.IdAsociado _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Domicilio _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosInsert _
    (ByVal entidad As coo_AsociadosBeneficiarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosBeneficiariosInsert", _
         entidad.IdAsociado _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Domicilio _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosUpdate _
    (ByVal entidad As coo_AsociadosBeneficiarios)

        db.ExecuteNonQuery("coo_AsociadosBeneficiariosUpdate", _
         entidad.IdAsociado _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Domicilio _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosUpdate _
    (ByVal entidad As coo_AsociadosBeneficiarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AsociadosBeneficiariosUpdate", _
         entidad.IdAsociado _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Domicilio _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         )
    End Sub

#End Region
#Region "coo_Profesiones"
    Public Function coo_ProfesionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_ProfesionesSelectAll").Tables(0)
    End Function

    Public Function coo_ProfesionesSelectByPK _
      (ByVal IdProfesion As System.Int16 _
      ) As coo_Profesiones

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_ProfesionesSelectByPK", _
         IdProfesion _
         ).tables(0)

        Dim Entidad As New coo_Profesiones
        If dt.Rows.Count > 0 Then
            entidad.IdProfesion = dt.rows(0).item("IdProfesion")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Asegurado = dt.rows(0).item("Asegurado")

        End If
        Return Entidad
    End Function

    Public Sub coo_ProfesionesDeleteByPK _
      (ByVal IdProfesion As System.Int16 _
      )

        db.ExecuteNonQuery("coo_ProfesionesDeleteByPK", _
         IdProfesion _
         )
    End Sub

    Public Sub coo_ProfesionesDeleteByPK _
      (ByVal IdProfesion As System.Int16 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ProfesionesDeleteByPK", _
         IdProfesion _
         )
    End Sub

    Public Sub coo_ProfesionesInsert _
    (ByVal entidad As coo_Profesiones)

        db.ExecuteNonQuery("coo_ProfesionesInsert", _
         entidad.IdProfesion _
         , entidad.Nombre _
         , entidad.Asegurado _
         )
    End Sub

    Public Sub coo_ProfesionesInsert _
    (ByVal entidad As coo_Profesiones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ProfesionesInsert", _
         entidad.IdProfesion _
         , entidad.Nombre _
         , entidad.Asegurado _
         )
    End Sub

    Public Sub coo_ProfesionesUpdate _
    (ByVal entidad As coo_Profesiones)

        db.ExecuteNonQuery("coo_ProfesionesUpdate", _
         entidad.IdProfesion _
         , entidad.Nombre _
         , entidad.Asegurado _
         )
    End Sub

    Public Sub coo_ProfesionesUpdate _
    (ByVal entidad As coo_Profesiones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ProfesionesUpdate", _
         entidad.IdProfesion _
         , entidad.Nombre _
         , entidad.Asegurado _
         )
    End Sub

#End Region

#Region "coo_TipoDocumento"
    Public Function coo_TipoDocumentoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TipoDocumentoSelectAll").Tables(0)
    End Function

    Public Function coo_TipoDocumentoSelectByPK _
      (ByVal IdTipo As System.Int32 _
      ) As coo_TipoDocumento

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TipoDocumentoSelectByPK", _
         IdTipo _
         ).tables(0)

        Dim Entidad As New coo_TipoDocumento
        If dt.Rows.Count > 0 Then
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub coo_TipoDocumentoDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_TipoDocumentoDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TipoDocumentoDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TipoDocumentoDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TipoDocumentoInsert _
    (ByVal entidad As coo_TipoDocumento)

        db.ExecuteNonQuery("coo_TipoDocumentoInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TipoDocumentoInsert _
    (ByVal entidad As coo_TipoDocumento, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TipoDocumentoInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TipoDocumentoUpdate _
    (ByVal entidad As coo_TipoDocumento)

        db.ExecuteNonQuery("coo_TipoDocumentoUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         )
    End Sub

    Public Sub coo_TipoDocumentoUpdate _
    (ByVal entidad As coo_TipoDocumento, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TipoDocumentoUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_LiquidacionAportaciones"
    Public Function coo_LiquidacionAportacionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_LiquidacionAportacionesSelectAll").Tables(0)
    End Function

    Public Function coo_LiquidacionAportacionesSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal NumeroDoc As System.String _
      ) As coo_LiquidacionAportaciones

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_LiquidacionAportacionesSelectByPK", _
         IdAsociado _
         , NumeroDoc _
         ).tables(0)

        Dim Entidad As New coo_LiquidacionAportaciones
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.NumeroDoc = dt.rows(0).item("NumeroDoc")
            entidad.FechaIngreso = dt.rows(0).item("FechaIngreso")
            entidad.FechaUltMovimiento = dt.rows(0).item("FechaUltMovimiento")
            entidad.TotalAportaciones = dt.rows(0).item("TotalAportaciones")
            entidad.NumActa = dt.rows(0).item("NumActa")
            entidad.TotalRetiro = dt.rows(0).item("TotalRetiro")
            entidad.FechaLiquidacion = dt.rows(0).item("FechaLiquidacion")
            entidad.PrestamosPendientes = dt.rows(0).item("PrestamosPendientes")
            entidad.InteresesPendientes = dt.rows(0).item("InteresesPendientes")
            entidad.ProvisionIncobrable = dt.rows(0).item("ProvisionIncobrable")
            entidad.ValorIva = dt.rows(0).item("ValorIva")
            entidad.Honorarios = dt.rows(0).item("Honorarios")
            entidad.LiquidoPagar = dt.rows(0).item("LiquidoPagar")
            entidad.OtrosProductos = dt.rows(0).item("OtrosProductos")
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_LiquidacionAportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal NumeroDoc As System.String _
      )

        db.ExecuteNonQuery("coo_LiquidacionAportacionesDeleteByPK", _
         IdAsociado _
         , NumeroDoc _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal NumeroDoc As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionAportacionesDeleteByPK", _
         IdAsociado _
         , NumeroDoc _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesInsert _
    (ByVal entidad As coo_LiquidacionAportaciones)

        db.ExecuteNonQuery("coo_LiquidacionAportacionesInsert", _
         entidad.IdAsociado _
         , entidad.NumeroDoc _
         , entidad.FechaIngreso _
         , entidad.FechaUltMovimiento _
         , entidad.TotalAportaciones _
         , entidad.NumActa _
         , entidad.TotalRetiro _
         , entidad.FechaLiquidacion _
         , entidad.PrestamosPendientes _
         , entidad.InteresesPendientes _
         , entidad.ProvisionIncobrable _
         , entidad.ValorIva _
         , entidad.Honorarios _
         , entidad.LiquidoPagar _
         , entidad.OtrosProductos _
         , entidad.IdTipo _
         , entidad.IdFormaPago _
         , entidad.IdTipoLiquidacion _
         , entidad.Desembolsado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesInsert _
    (ByVal entidad As coo_LiquidacionAportaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionAportacionesInsert", _
         entidad.IdAsociado _
         , entidad.NumeroDoc _
         , entidad.FechaIngreso _
         , entidad.FechaUltMovimiento _
         , entidad.TotalAportaciones _
         , entidad.NumActa _
         , entidad.TotalRetiro _
         , entidad.FechaLiquidacion _
         , entidad.PrestamosPendientes _
         , entidad.InteresesPendientes _
         , entidad.ProvisionIncobrable _
         , entidad.ValorIva _
         , entidad.Honorarios _
         , entidad.LiquidoPagar _
         , entidad.OtrosProductos _
         , entidad.IdTipo _
         , entidad.IdFormaPago _
         , entidad.IdTipoLiquidacion _
         , entidad.Desembolsado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesUpdate _
    (ByVal entidad As coo_LiquidacionAportaciones)

        db.ExecuteNonQuery("coo_LiquidacionAportacionesUpdate", _
         entidad.IdAsociado _
         , entidad.NumeroDoc _
         , entidad.FechaIngreso _
         , entidad.FechaUltMovimiento _
         , entidad.TotalAportaciones _
         , entidad.NumActa _
         , entidad.TotalRetiro _
         , entidad.FechaLiquidacion _
         , entidad.PrestamosPendientes _
         , entidad.InteresesPendientes _
         , entidad.ProvisionIncobrable _
         , entidad.ValorIva _
         , entidad.Honorarios _
         , entidad.LiquidoPagar _
         , entidad.OtrosProductos _
         , entidad.IdTipo _
         , entidad.IdFormaPago _
         , entidad.IdTipoLiquidacion _
         , entidad.Desembolsado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesUpdate _
    (ByVal entidad As coo_LiquidacionAportaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionAportacionesUpdate", _
         entidad.IdAsociado _
         , entidad.NumeroDoc _
         , entidad.FechaIngreso _
         , entidad.FechaUltMovimiento _
         , entidad.TotalAportaciones _
         , entidad.NumActa _
         , entidad.TotalRetiro _
         , entidad.FechaLiquidacion _
         , entidad.PrestamosPendientes _
         , entidad.InteresesPendientes _
         , entidad.ProvisionIncobrable _
         , entidad.ValorIva _
         , entidad.Honorarios _
         , entidad.LiquidoPagar _
         , entidad.OtrosProductos _
         , entidad.IdTipo _
         , entidad.IdFormaPago _
         , entidad.IdTipoLiquidacion _
         , entidad.Desembolsado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_Aportaciones"
    Public Function coo_AportacionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AportacionesSelectAll").Tables(0)
    End Function

    Public Function coo_AportacionesSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_Aportaciones

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AportacionesSelectByPK", _
         IdAsociado _
         , IdMov _
         ).tables(0)

        Dim Entidad As New coo_Aportaciones
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.NumeroDoc = dt.rows(0).item("NumeroDoc")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.Cargo = dt.rows(0).item("Cargo")
            entidad.Abono = dt.rows(0).item("Abono")
            entidad.Saldo = dt.rows(0).item("Saldo")
            entidad.LineaLibreta = dt.rows(0).item("LineaLibreta")
            entidad.Impreso = dt.rows(0).item("Impreso")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.FechaContable = dt.rows(0).item("FechaContable")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_AportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AportacionesDeleteByPK", _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_AportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AportacionesDeleteByPK", _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_AportacionesInsert _
    (ByVal entidad As coo_Aportaciones)

        db.ExecuteNonQuery("coo_AportacionesInsert", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.Impreso _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AportacionesInsert _
    (ByVal entidad As coo_Aportaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AportacionesInsert", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.Impreso _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AportacionesUpdate _
    (ByVal entidad As coo_Aportaciones)

        db.ExecuteNonQuery("coo_AportacionesUpdate", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.Impreso _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_AportacionesUpdate _
    (ByVal entidad As coo_Aportaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AportacionesUpdate", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.Impreso _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_AyudaFuneraria"
    Public Function coo_AyudaFunerariaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AyudaFunerariaSelectAll").Tables(0)
    End Function

    Public Function coo_AyudaFunerariaSelectByPK _
      (ByVal IdMovimiento As System.Int32 _
      ) As coo_AyudaFuneraria

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AyudaFunerariaSelectByPK", _
         IdMovimiento _
         ).tables(0)

        Dim Entidad As New coo_AyudaFuneraria
        If dt.Rows.Count > 0 Then
            entidad.IdMovimiento = dt.rows(0).item("IdMovimiento")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.FechaServicio = dt.rows(0).item("FechaServicio")
            entidad.CantidadOtorgada = dt.rows(0).item("CantidadOtorgada")
            entidad.NombreFamiliar = dt.rows(0).item("NombreFamiliar")
            entidad.ParentescoFamiliar = dt.rows(0).item("ParentescoFamiliar")
            entidad.EdadFamiliar = dt.rows(0).item("EdadFamiliar")
            entidad.FechaDescesoFamiliar = dt.rows(0).item("FechaDescesoFamiliar")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_AyudaFunerariaDeleteByPK _
      (ByVal IdMovimiento As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AyudaFunerariaDeleteByPK", _
         IdMovimiento _
         )
    End Sub

    Public Sub coo_AyudaFunerariaDeleteByPK _
      (ByVal IdMovimiento As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AyudaFunerariaDeleteByPK", _
         IdMovimiento _
         )
    End Sub

    Public Sub coo_AyudaFunerariaInsert _
    (ByVal entidad As coo_AyudaFuneraria)

        db.ExecuteNonQuery("coo_AyudaFunerariaInsert", _
         entidad.IdMovimiento _
         , entidad.IdAsociado _
         , entidad.FechaServicio _
         , entidad.CantidadOtorgada _
         , entidad.NombreFamiliar _
         , entidad.ParentescoFamiliar _
         , entidad.EdadFamiliar _
         , entidad.FechaDescesoFamiliar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AyudaFunerariaInsert _
    (ByVal entidad As coo_AyudaFuneraria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AyudaFunerariaInsert", _
         entidad.IdMovimiento _
         , entidad.IdAsociado _
         , entidad.FechaServicio _
         , entidad.CantidadOtorgada _
         , entidad.NombreFamiliar _
         , entidad.ParentescoFamiliar _
         , entidad.EdadFamiliar _
         , entidad.FechaDescesoFamiliar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AyudaFunerariaUpdate _
    (ByVal entidad As coo_AyudaFuneraria)

        db.ExecuteNonQuery("coo_AyudaFunerariaUpdate", _
         entidad.IdMovimiento _
         , entidad.IdAsociado _
         , entidad.FechaServicio _
         , entidad.CantidadOtorgada _
         , entidad.NombreFamiliar _
         , entidad.ParentescoFamiliar _
         , entidad.EdadFamiliar _
         , entidad.FechaDescesoFamiliar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_AyudaFunerariaUpdate _
    (ByVal entidad As coo_AyudaFuneraria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AyudaFunerariaUpdate", _
         entidad.IdMovimiento _
         , entidad.IdAsociado _
         , entidad.FechaServicio _
         , entidad.CantidadOtorgada _
         , entidad.NombreFamiliar _
         , entidad.ParentescoFamiliar _
         , entidad.EdadFamiliar _
         , entidad.FechaDescesoFamiliar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region

#Region "coo_MovFuneraria"
    Public Function coo_MovFunerariaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_MovFunerariaSelectAll").Tables(0)
    End Function

    Public Function coo_MovFunerariaSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_MovFuneraria

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_MovFunerariaSelectByPK", _
         IdAsociado _
         , IdMov _
         ).tables(0)

        Dim Entidad As New coo_MovFuneraria
        If dt.Rows.Count > 0 Then
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.NumeroDoc = dt.rows(0).item("NumeroDoc")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.Cargo = dt.rows(0).item("Cargo")
            entidad.Abono = dt.rows(0).item("Abono")
            entidad.Saldo = dt.rows(0).item("Saldo")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.FechaContable = dt.rows(0).item("FechaContable")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_MovFunerariaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_MovFunerariaDeleteByPK", _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_MovFunerariaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_MovFunerariaDeleteByPK", _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_MovFunerariaInsert _
    (ByVal entidad As coo_MovFuneraria)

        db.ExecuteNonQuery("coo_MovFunerariaInsert", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_MovFunerariaInsert _
    (ByVal entidad As coo_MovFuneraria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_MovFunerariaInsert", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_MovFunerariaUpdate _
    (ByVal entidad As coo_MovFuneraria)

        db.ExecuteNonQuery("coo_MovFunerariaUpdate", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_MovFunerariaUpdate _
    (ByVal entidad As coo_MovFuneraria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_MovFunerariaUpdate", _
         entidad.IdAsociado _
         , entidad.IdMov _
         , entidad.IdTipo _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.Cargo _
         , entidad.Abono _
         , entidad.Saldo _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_CuentasAhorro"
    Public Function coo_CuentasAhorroSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CuentasAhorroSelectAll").Tables(0)
    End Function

    Public Function coo_CuentasAhorroSelectByPK(ByVal IdCuenta As System.Int32) As coo_CuentasAhorro

        Dim dt As DataTable = db.ExecuteDataSet("coo_CuentasAhorroSelectByPK", IdCuenta).Tables(0)

        Dim Entidad As New coo_CuentasAhorro
        If dt.Rows.Count > 0 Then
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.RazonSocial = dt.Rows(0).Item("RazonSocial")
            Entidad.FechaApertura = fd.SiEsNulo(dt.Rows(0).Item("FechaApertura"), Nothing)
            Entidad.IdTipoCuenta = dt.Rows(0).Item("IdTipoCuenta")
            Entidad.CuotaAhorro = dt.Rows(0).Item("CuotaAhorro")
            Entidad.TasaApertura = dt.Rows(0).Item("TasaApertura")
            Entidad.MontoApertura = dt.Rows(0).Item("MontoApertura")
            Entidad.TasaVigente = dt.Rows(0).Item("TasaVigente")
            Entidad.PlazoDias = dt.Rows(0).Item("PlazoDias")
            Entidad.FechaVigenciaTasa = fd.SiEsNulo(dt.Rows(0).Item("FechaVigenciaTasa"), Nothing)
            Entidad.IdCuentaCte = dt.Rows(0).Item("IdCuentaCte")
            Entidad.NumeroCertificado = dt.Rows(0).Item("NumeroCertificado")
            Entidad.IdFormaPago = fd.SiEsNulo(dt.Rows(0).Item("IdFormaPago"), 1)
            Entidad.FechaUltCap = dt.Rows(0).Item("FechaUltCap")
            Entidad.OrigenFondos = dt.Rows(0).Item("OrigenFondos")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraCreacion"), Nothing)
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
        End If
        Return Entidad
    End Function

    Public Sub coo_CuentasAhorroDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CuentasAhorroDeleteByPK", _
         IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasAhorroDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroDeleteByPK", _
         IdCuenta)
    End Sub

    Public Sub coo_CuentasAhorroInsert _
    (ByVal entidad As coo_CuentasAhorro)

        db.ExecuteNonQuery("coo_CuentasAhorroInsert", _
         entidad.IdCuenta _
         , entidad.IdAsociado _
         , entidad.Numero _
           , entidad.RazonSocial _
         , entidad.FechaApertura _
         , entidad.IdTipoCuenta _
         , entidad.CuotaAhorro _
         , entidad.TasaApertura _
         , entidad.MontoApertura _
         , entidad.TasaVigente _
         , entidad.PlazoDias _
         , entidad.FechaVigenciaTasa _
         , entidad.IdCuentaCte _
         , entidad.NumeroCertificado _
          , entidad.IdFormaPago _
        , entidad.FechaUltCap _
         , entidad.OrigenFondos _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion)
    End Sub

    Public Sub coo_CuentasAhorroInsert _
    (ByVal entidad As coo_CuentasAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroInsert", _
         entidad.IdCuenta _
         , entidad.IdAsociado _
         , entidad.Numero _
           , entidad.RazonSocial _
         , entidad.FechaApertura _
         , entidad.IdTipoCuenta _
         , entidad.CuotaAhorro _
         , entidad.TasaApertura _
         , entidad.MontoApertura _
         , entidad.TasaVigente _
         , entidad.PlazoDias _
         , entidad.FechaVigenciaTasa _
         , entidad.IdCuentaCte _
         , entidad.NumeroCertificado _
         , entidad.IdFormaPago _
        , entidad.FechaUltCap _
         , entidad.OrigenFondos _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_CuentasAhorroUpdate _
    (ByVal entidad As coo_CuentasAhorro)

        db.ExecuteNonQuery("coo_CuentasAhorroUpdate", _
         entidad.IdCuenta _
         , entidad.IdAsociado _
         , entidad.Numero _
           , entidad.RazonSocial _
         , entidad.FechaApertura _
         , entidad.IdTipoCuenta _
         , entidad.CuotaAhorro _
         , entidad.TasaApertura _
         , entidad.MontoApertura _
         , entidad.TasaVigente _
         , entidad.PlazoDias _
         , entidad.FechaVigenciaTasa _
         , entidad.IdCuentaCte _
         , entidad.NumeroCertificado _
         , entidad.IdFormaPago _
        , entidad.FechaUltCap _
         , entidad.OrigenFondos _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_CuentasAhorroUpdate _
    (ByVal entidad As coo_CuentasAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroUpdate", _
         entidad.IdCuenta _
         , entidad.IdAsociado _
         , entidad.Numero _
           , entidad.RazonSocial _
         , entidad.FechaApertura _
         , entidad.IdTipoCuenta _
         , entidad.CuotaAhorro _
         , entidad.TasaApertura _
         , entidad.MontoApertura _
         , entidad.TasaVigente _
         , entidad.PlazoDias _
         , entidad.FechaVigenciaTasa _
         , entidad.IdCuentaCte _
         , entidad.NumeroCertificado _
         , entidad.IdFormaPago _
         , entidad.FechaUltCap _
         , entidad.OrigenFondos _
         , entidad.IdEstado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_CuentasAhorroAutorizado"
    Public Function coo_CuentasAhorroAutorizadoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CuentasAhorroAutorizadoSelectAll").Tables(0)
    End Function

    Public Function coo_CuentasAhorroAutorizadoSelectByPK _
      (ByVal IdAutorizado As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasAhorroAutorizado

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_CuentasAhorroAutorizadoSelectByPK", _
         IdAutorizado _
         , IdCuenta _
         ).tables(0)

        Dim Entidad As New coo_CuentasAhorroAutorizado
        If dt.Rows.Count > 0 Then
            entidad.IdAutorizado = dt.rows(0).item("IdAutorizado")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.NroDocumento = dt.rows(0).item("NroDocumento")
            entidad.ArchivoFirma = dt.rows(0).item("ArchivoFirma")

        End If
        Return Entidad
    End Function

    Public Sub coo_CuentasAhorroAutorizadoDeleteByPK _
      (ByVal IdAutorizado As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CuentasAhorroAutorizadoDeleteByPK", _
         IdAutorizado _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoDeleteByPK _
      (ByVal IdAutorizado As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroAutorizadoDeleteByPK", _
         IdAutorizado _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoInsert _
    (ByVal entidad As coo_CuentasAhorroAutorizado)

        db.ExecuteNonQuery("coo_CuentasAhorroAutorizadoInsert", _
         entidad.IdAutorizado _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.NroDocumento _
         , entidad.ArchivoFirma _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoInsert _
    (ByVal entidad As coo_CuentasAhorroAutorizado, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroAutorizadoInsert", _
         entidad.IdAutorizado _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.NroDocumento _
         , entidad.ArchivoFirma _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoUpdate _
    (ByVal entidad As coo_CuentasAhorroAutorizado)

        db.ExecuteNonQuery("coo_CuentasAhorroAutorizadoUpdate", _
         entidad.IdAutorizado _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.NroDocumento _
         , entidad.ArchivoFirma _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoUpdate _
    (ByVal entidad As coo_CuentasAhorroAutorizado, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroAutorizadoUpdate", _
         entidad.IdAutorizado _
         , entidad.IdCuenta _
         , entidad.Nombre _
         , entidad.NroDocumento _
         , entidad.ArchivoFirma _
         )
    End Sub

#End Region
#Region "coo_CuentasAhorroBeneficiarios"
    Public Function coo_CuentasAhorroBeneficiariosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CuentasAhorroBeneficiariosSelectAll").Tables(0)
    End Function

    Public Function coo_CuentasAhorroBeneficiariosSelectByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdBeneficiario As System.Int32 _
      ) As coo_CuentasAhorroBeneficiarios

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_CuentasAhorroBeneficiariosSelectByPK", _
         IdCuenta _
         , IdBeneficiario _
         ).tables(0)

        Dim Entidad As New coo_CuentasAhorroBeneficiarios
        If dt.Rows.Count > 0 Then
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.IdBeneficiario = dt.rows(0).item("IdBeneficiario")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Edad = dt.rows(0).item("Edad")
            entidad.Parentesco = dt.rows(0).item("Parentesco")
            entidad.Porcentaje = dt.rows(0).item("Porcentaje")
            entidad.Direccion = dt.rows(0).item("Direccion")

        End If
        Return Entidad
    End Function

    Public Sub coo_CuentasAhorroBeneficiariosDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdBeneficiario As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CuentasAhorroBeneficiariosDeleteByPK", _
         IdCuenta _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdBeneficiario As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroBeneficiariosDeleteByPK", _
         IdCuenta _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosInsert _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios)

        db.ExecuteNonQuery("coo_CuentasAhorroBeneficiariosInsert", _
         entidad.IdCuenta _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Edad _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         , entidad.Direccion _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosInsert _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroBeneficiariosInsert", _
         entidad.IdCuenta _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Edad _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         , entidad.Direccion _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosUpdate _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios)

        db.ExecuteNonQuery("coo_CuentasAhorroBeneficiariosUpdate", _
         entidad.IdCuenta _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Edad _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         , entidad.Direccion _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosUpdate _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroBeneficiariosUpdate", _
         entidad.IdCuenta _
         , entidad.IdBeneficiario _
         , entidad.Nombre _
         , entidad.Edad _
         , entidad.Parentesco _
         , entidad.Porcentaje _
         , entidad.Direccion _
         )
    End Sub

#End Region
#Region "coo_CuentasAhorroMov"
    Public Function coo_CuentasAhorroMovSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CuentasAhorroMovSelectAll").Tables(0)
    End Function

    Public Function coo_CuentasAhorroMovSelectByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_CuentasAhorroMov

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_CuentasAhorroMovSelectByPK", _
         IdCuenta _
         , IdMov _
         ).tables(0)

        Dim Entidad As New coo_CuentasAhorroMov
        If dt.Rows.Count > 0 Then
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.NumeroDoc = dt.rows(0).item("NumeroDoc")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.Valor = dt.rows(0).item("Valor")
            entidad.Saldo = dt.rows(0).item("Saldo")
            entidad.LineaLibreta = dt.rows(0).item("LineaLibreta")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.FechaContable = dt.rows(0).item("FechaContable")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.Pignorado = dt.rows(0).item("Pignorado")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.Impreso = dt.rows(0).item("Impreso")
            Entidad.IdAutorizado = dt.Rows(0).Item("IdAutorizado")
            entidad.DocAutorizado = dt.rows(0).item("DocAutorizado")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function

    Public Sub coo_CuentasAhorroMovDeleteByPK(ByVal IdCuenta As Integer, ByVal IdMov As Integer)

        db.ExecuteNonQuery("coo_CuentasAhorroMovDeleteByPK", IdCuenta, IdMov)
    End Sub

    Public Sub coo_CuentasAhorroMovDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroMovDeleteByPK", _
         IdCuenta _
         , IdMov _
         )
    End Sub

    Public Sub coo_CuentasAhorroMovInsert _
    (ByVal entidad As coo_CuentasAhorroMov)

        db.ExecuteNonQuery("coo_CuentasAhorroMovInsert", _
         entidad.IdCuenta _
         , entidad.IdMov _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdTipo _
         , entidad.Valor _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.IdFormaPago _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.Pignorado _
         , entidad.Observaciones _
         , entidad.Impreso _
         , entidad.IdAutorizado _
         , entidad.DocAutorizado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CuentasAhorroMovInsert _
    (ByVal entidad As coo_CuentasAhorroMov, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroMovInsert", _
         entidad.IdCuenta _
         , entidad.IdMov _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdTipo _
         , entidad.Valor _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.IdFormaPago _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.Pignorado _
         , entidad.Observaciones _
         , entidad.Impreso _
         , entidad.IdAutorizado _
         , entidad.DocAutorizado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CuentasAhorroMovUpdate(ByVal entidad As coo_CuentasAhorroMov)

        db.ExecuteNonQuery("coo_CuentasAhorroMovUpdate", _
         entidad.IdCuenta _
         , entidad.IdMov _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdTipo _
         , entidad.Valor _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.IdFormaPago _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.Pignorado _
         , entidad.Observaciones _
         , entidad.Impreso _
         , entidad.IdAutorizado _
         , entidad.DocAutorizado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CuentasAhorroMovUpdate _
    (ByVal entidad As coo_CuentasAhorroMov, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CuentasAhorroMovUpdate", _
         entidad.IdCuenta _
         , entidad.IdMov _
         , entidad.NumeroDoc _
         , entidad.Fecha _
         , entidad.IdTipo _
         , entidad.Valor _
         , entidad.Saldo _
         , entidad.LineaLibreta _
         , entidad.IdFormaPago _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.Pignorado _
         , entidad.Observaciones _
         , entidad.Impreso _
         , entidad.IdAutorizado _
         , entidad.DocAutorizado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_CierresAhorro"
    Public Function coo_CierresAhorroSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CierresAhorroSelectAll").Tables(0)
    End Function

    Public Function coo_CierresAhorroSelectByPK _
      (ByVal ejercicio As System.Int32 _
      , ByVal mes As System.Int32 _
      ) As coo_CierresAhorro

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_CierresAhorroSelectByPK", _
         ejercicio _
         , mes _
         ).tables(0)

        Dim Entidad As New coo_CierresAhorro
        If dt.Rows.Count > 0 Then
            entidad.ejercicio = dt.rows(0).item("ejercicio")
            entidad.mes = dt.rows(0).item("mes")
            entidad.DesdeCierre = dt.rows(0).item("DesdeCierre")
            entidad.HastaCierre = dt.rows(0).item("HastaCierre")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_CierresAhorroDeleteByPK _
      (ByVal ejercicio As System.Int32 _
      , ByVal mes As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CierresAhorroDeleteByPK", _
         ejercicio _
         , mes _
         )
    End Sub

    Public Sub coo_CierresAhorroDeleteByPK _
      (ByVal ejercicio As System.Int32 _
      , ByVal mes As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CierresAhorroDeleteByPK", _
         ejercicio _
         , mes _
         )
    End Sub

    Public Sub coo_CierresAhorroInsert _
    (ByVal entidad As coo_CierresAhorro)

        db.ExecuteNonQuery("coo_CierresAhorroInsert", _
         entidad.ejercicio _
         , entidad.mes _
         , entidad.DesdeCierre _
         , entidad.HastaCierre _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CierresAhorroInsert _
    (ByVal entidad As coo_CierresAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CierresAhorroInsert", _
         entidad.ejercicio _
         , entidad.mes _
         , entidad.DesdeCierre _
         , entidad.HastaCierre _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CierresAhorroUpdate _
    (ByVal entidad As coo_CierresAhorro)

        db.ExecuteNonQuery("coo_CierresAhorroUpdate", _
         entidad.ejercicio _
         , entidad.mes _
         , entidad.DesdeCierre _
         , entidad.HastaCierre _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_CierresAhorroUpdate _
    (ByVal entidad As coo_CierresAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CierresAhorroUpdate", _
         entidad.ejercicio _
         , entidad.mes _
         , entidad.DesdeCierre _
         , entidad.HastaCierre _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_Lineas"
    Public Function coo_LineasSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_LineasSelectAll").Tables(0)
    End Function

    Public Function coo_LineasSelectByPK _
      (ByVal IdLinea As System.Int32 _
      ) As coo_Lineas

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_LineasSelectByPK", _
         IdLinea _
         ).tables(0)

        Dim Entidad As New coo_Lineas
        If dt.Rows.Count > 0 Then
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.TasaInteres = dt.rows(0).item("TasaInteres")
            entidad.IdCuentaCapitalCortoPlazo = dt.rows(0).item("IdCuentaCapitalCortoPlazo")
            Entidad.IdCuentaCapitalLargoPlazo = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaCapitalLargoPlazo"), Nothing)
            Entidad.IdCuentaRecuperacionJudicial = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaRecuperacionJudicial"), Nothing)
            Entidad.IdCuentaIrrecuperable = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaIrrecuperable"), Nothing)
            Entidad.IdCuentaContableInt = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaContableInt"), Nothing)
            Entidad.IdCuentaContableMora = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaContableMora"), Nothing)
            Entidad.Prioridad = dt.Rows(0).Item("Prioridad")
            Entidad.PrioridadRetiroSocios = dt.Rows(0).Item("PrioridadRetiroSocios")
            Entidad.TipoLinea = dt.Rows(0).Item("TipoLinea")
            Entidad.CuotaSinCentavos = dt.Rows(0).Item("CuotaSinCentavos")

        End If
        Return Entidad
    End Function

    Public Sub coo_LineasDeleteByPK _
      (ByVal IdLinea As System.Int32 _
      )

        db.ExecuteNonQuery("coo_LineasDeleteByPK", _
         IdLinea _
         )
    End Sub

    Public Sub coo_LineasDeleteByPK _
      (ByVal IdLinea As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LineasDeleteByPK", _
         IdLinea _
         )
    End Sub

    Public Sub coo_LineasInsert _
    (ByVal entidad As coo_Lineas)

        db.ExecuteNonQuery("coo_LineasInsert", _
         entidad.IdLinea _
         , entidad.Nombre _
         , entidad.TasaInteres _
         , entidad.IdCuentaCapitalCortoPlazo _
         , entidad.IdCuentaCapitalLargoPlazo _
         , entidad.IdCuentaRecuperacionJudicial _
         , entidad.IdCuentaIrrecuperable _
         , entidad.IdCuentaContableInt _
         , entidad.IdCuentaContableMora _
         , entidad.Prioridad _
         , entidad.PrioridadRetiroSocios _
         , entidad.TipoLinea _
         , entidad.CuotaSinCentavos _
         )
    End Sub

    Public Sub coo_LineasInsert _
    (ByVal entidad As coo_Lineas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LineasInsert", _
         entidad.IdLinea _
         , entidad.Nombre _
         , entidad.TasaInteres _
         , entidad.IdCuentaCapitalCortoPlazo _
         , entidad.IdCuentaCapitalLargoPlazo _
         , entidad.IdCuentaRecuperacionJudicial _
         , entidad.IdCuentaIrrecuperable _
         , entidad.IdCuentaContableInt _
         , entidad.IdCuentaContableMora _
         , entidad.Prioridad _
         , entidad.PrioridadRetiroSocios _
         , entidad.TipoLinea _
         , entidad.CuotaSinCentavos _
         )
    End Sub

    Public Sub coo_LineasUpdate _
    (ByVal entidad As coo_Lineas)

        db.ExecuteNonQuery("coo_LineasUpdate", _
         entidad.IdLinea _
         , entidad.Nombre _
         , entidad.TasaInteres _
         , entidad.IdCuentaCapitalCortoPlazo _
         , entidad.IdCuentaCapitalLargoPlazo _
         , entidad.IdCuentaRecuperacionJudicial _
         , entidad.IdCuentaIrrecuperable _
         , entidad.IdCuentaContableInt _
         , entidad.IdCuentaContableMora _
         , entidad.Prioridad _
         , entidad.PrioridadRetiroSocios _
         , entidad.TipoLinea _
         , entidad.CuotaSinCentavos _
         )
    End Sub

    Public Sub coo_LineasUpdate _
    (ByVal entidad As coo_Lineas, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LineasUpdate", _
         entidad.IdLinea _
         , entidad.Nombre _
         , entidad.TasaInteres _
         , entidad.IdCuentaCapitalCortoPlazo _
         , entidad.IdCuentaCapitalLargoPlazo _
         , entidad.IdCuentaRecuperacionJudicial _
         , entidad.IdCuentaIrrecuperable _
         , entidad.IdCuentaContableInt _
         , entidad.IdCuentaContableMora _
         , entidad.Prioridad _
         , entidad.PrioridadRetiroSocios _
         , entidad.TipoLinea _
         , entidad.CuotaSinCentavos _
         )
    End Sub

#End Region

#Region "coo_TiposCuentaAhorro"
    Public Function coo_TiposCuentaAhorroSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TiposCuentaAhorroSelectAll").Tables(0)
    End Function

    Public Function coo_TiposCuentaAhorroSelectByPK _
      (ByVal IdTipo As System.Byte _
      ) As coo_TiposCuentaAhorro

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TiposCuentaAhorroSelectByPK", _
         IdTipo _
         ).tables(0)

        Dim Entidad As New coo_TiposCuentaAhorro
        If dt.Rows.Count > 0 Then
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.IdCuentaContable = dt.rows(0).item("IdCuentaContable")
            entidad.PlazoDias = dt.rows(0).item("PlazoDias")
            entidad.TipoAhorro = dt.rows(0).item("TipoAhorro")
            entidad.TasaInteres = dt.rows(0).item("TasaInteres")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            Entidad.IdCuentaCosto = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaCosto"), Nothing)
            Entidad.IdCuentaGasto = fd.SiEsNulo(dt.Rows(0).Item("IdCuentaGasto"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_TiposCuentaAhorroDeleteByPK _
      (ByVal IdTipo As System.Byte _
      )

        db.ExecuteNonQuery("coo_TiposCuentaAhorroDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroDeleteByPK _
      (ByVal IdTipo As System.Byte _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposCuentaAhorroDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroInsert _
    (ByVal entidad As coo_TiposCuentaAhorro)

        db.ExecuteNonQuery("coo_TiposCuentaAhorroInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.PlazoDias _
         , entidad.TipoAhorro _
         , entidad.TasaInteres _
         , entidad.Correlativo _
         , entidad.IdCuentaCosto _
         , entidad.IdCuentaGasto _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroInsert _
    (ByVal entidad As coo_TiposCuentaAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposCuentaAhorroInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.PlazoDias _
         , entidad.TipoAhorro _
         , entidad.TasaInteres _
         , entidad.Correlativo _
         , entidad.IdCuentaCosto _
         , entidad.IdCuentaGasto _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroUpdate _
    (ByVal entidad As coo_TiposCuentaAhorro)

        db.ExecuteNonQuery("coo_TiposCuentaAhorroUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.PlazoDias _
         , entidad.TipoAhorro _
         , entidad.TasaInteres _
         , entidad.Correlativo _
         , entidad.IdCuentaCosto _
         , entidad.IdCuentaGasto _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroUpdate _
    (ByVal entidad As coo_TiposCuentaAhorro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposCuentaAhorroUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.IdCuentaContable _
         , entidad.PlazoDias _
         , entidad.TipoAhorro _
         , entidad.TasaInteres _
         , entidad.Correlativo _
         , entidad.IdCuentaCosto _
         , entidad.IdCuentaGasto _
         )
    End Sub

#End Region


#Region "coo_Afiliaciones"
    Public Function coo_AfiliacionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AfiliacionesSelectAll").Tables(0)
    End Function

    Public Function coo_AfiliacionesSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_Afiliaciones

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AfiliacionesSelectByPK", _
         IdMov _
         ).tables(0)

        Dim Entidad As New coo_Afiliaciones
        If dt.Rows.Count > 0 Then
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.FechaGeneracion = dt.rows(0).item("FechaGeneracion")
            entidad.FechaAplicacion = dt.rows(0).item("FechaAplicacion")
            entidad.CuotaIngreso = dt.rows(0).item("CuotaIngreso")
            entidad.AporteInicial = dt.rows(0).item("AporteInicial")
            entidad.AhorroInicial = dt.rows(0).item("AhorroInicial")
            entidad.Papeleria = dt.rows(0).item("Papeleria")
            entidad.TramitesIngreso = dt.rows(0).item("TramitesIngreso")
            entidad.Otros = dt.rows(0).item("Otros")
            entidad.Concepto = dt.rows(0).item("Concepto")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.Aplicado = dt.rows(0).item("Aplicado")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")

        End If
        Return Entidad
    End Function

    Public Sub coo_AfiliacionesDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AfiliacionesDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_AfiliacionesDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AfiliacionesDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_AfiliacionesInsert _
    (ByVal entidad As coo_Afiliaciones)

        db.ExecuteNonQuery("coo_AfiliacionesInsert", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaGeneracion _
         , entidad.FechaAplicacion _
         , entidad.CuotaIngreso _
         , entidad.AporteInicial _
         , entidad.AhorroInicial _
         , entidad.Papeleria _
         , entidad.TramitesIngreso _
         , entidad.Otros _
         , entidad.Concepto _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         )
    End Sub

    Public Sub coo_AfiliacionesInsert _
    (ByVal entidad As coo_Afiliaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AfiliacionesInsert", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaGeneracion _
         , entidad.FechaAplicacion _
         , entidad.CuotaIngreso _
         , entidad.AporteInicial _
         , entidad.AhorroInicial _
         , entidad.Papeleria _
         , entidad.TramitesIngreso _
         , entidad.Otros _
         , entidad.Concepto _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         )
    End Sub

    Public Sub coo_AfiliacionesUpdate _
    (ByVal entidad As coo_Afiliaciones)

        db.ExecuteNonQuery("coo_AfiliacionesUpdate", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaGeneracion _
         , entidad.FechaAplicacion _
         , entidad.CuotaIngreso _
         , entidad.AporteInicial _
         , entidad.AhorroInicial _
         , entidad.Papeleria _
         , entidad.TramitesIngreso _
         , entidad.Otros _
         , entidad.Concepto _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         )
    End Sub

    Public Sub coo_AfiliacionesUpdate _
    (ByVal entidad As coo_Afiliaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AfiliacionesUpdate", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaGeneracion _
         , entidad.FechaAplicacion _
         , entidad.CuotaIngreso _
         , entidad.AporteInicial _
         , entidad.AhorroInicial _
         , entidad.Papeleria _
         , entidad.TramitesIngreso _
         , entidad.Otros _
         , entidad.Concepto _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         )
    End Sub

#End Region
#Region "coo_ReintegrosPlanilla"
    Public Function coo_ReintegrosPlanillaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_ReintegrosPlanillaSelectAll").Tables(0)
    End Function

    Public Function coo_ReintegrosPlanillaSelectByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal IdAsociado As System.Int32 _
      ) As coo_ReintegrosPlanilla

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_ReintegrosPlanillaSelectByPK", _
         IdMov _
         , IdAsociado _
         ).tables(0)

        Dim Entidad As New coo_ReintegrosPlanilla
        If dt.Rows.Count > 0 Then
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.FechaAplicacion = dt.rows(0).item("FechaAplicacion")
            entidad.IdPlanillaDescuento = dt.rows(0).item("IdPlanillaDescuento")
            entidad.Monto = dt.rows(0).item("Monto")
            entidad.Aplicado = dt.rows(0).item("Aplicado")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.AplicadoPor = dt.rows(0).item("AplicadoPor")
            Entidad.FechaHoraAplicacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraAplicacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_ReintegrosPlanillaDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal IdAsociado As System.Int32 _
      )

        db.ExecuteNonQuery("coo_ReintegrosPlanillaDeleteByPK", _
         IdMov _
         , IdAsociado _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal IdAsociado As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ReintegrosPlanillaDeleteByPK", _
         IdMov _
         , IdAsociado _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaInsert _
    (ByVal entidad As coo_ReintegrosPlanilla)

        db.ExecuteNonQuery("coo_ReintegrosPlanillaInsert", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.IdPlanillaDescuento _
         , entidad.Monto _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.AplicadoPor _
         , entidad.FechaHoraAplicacion _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaInsert _
    (ByVal entidad As coo_ReintegrosPlanilla, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ReintegrosPlanillaInsert", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.IdPlanillaDescuento _
         , entidad.Monto _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.AplicadoPor _
         , entidad.FechaHoraAplicacion _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaUpdate _
    (ByVal entidad As coo_ReintegrosPlanilla)

        db.ExecuteNonQuery("coo_ReintegrosPlanillaUpdate", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.IdPlanillaDescuento _
         , entidad.Monto _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.AplicadoPor _
         , entidad.FechaHoraAplicacion _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaUpdate _
    (ByVal entidad As coo_ReintegrosPlanilla, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ReintegrosPlanillaUpdate", _
         entidad.IdMov _
         , entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.IdPlanillaDescuento _
         , entidad.Monto _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.AplicadoPor _
         , entidad.FechaHoraAplicacion _
         )
    End Sub

#End Region
#Region "coo_SolicitudRetiroPrestamos"
    Public Function coo_SolicitudRetiroPrestamosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudRetiroPrestamosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudRetiroPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudRetiroPrestamos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudRetiroPrestamosSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudRetiroPrestamos
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoCapital = dt.rows(0).item("SaldoCapital")
            entidad.SaldoInteres = dt.rows(0).item("SaldoInteres")
            entidad.SaldoInteresMora = dt.rows(0).item("SaldoInteresMora")
            entidad.SaldoSeguro = dt.rows(0).item("SaldoSeguro")
            entidad.SaldoOtros = dt.rows(0).item("SaldoOtros")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudRetiroPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudRetiroPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosInsert _
    (ByVal entidad As coo_SolicitudRetiroPrestamos)

        db.ExecuteNonQuery("coo_SolicitudRetiroPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosInsert _
    (ByVal entidad As coo_SolicitudRetiroPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosUpdate _
    (ByVal entidad As coo_SolicitudRetiroPrestamos)

        db.ExecuteNonQuery("coo_SolicitudRetiroPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosUpdate _
    (ByVal entidad As coo_SolicitudRetiroPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

#End Region


#Region "coo_TiposPrestamo"
    Public Function coo_TiposPrestamoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TiposPrestamoSelectAll").Tables(0)
    End Function

    Public Function coo_TiposPrestamoSelectByPK _
      (ByVal IdTipoPrestamo As System.Byte _
      ) As coo_TiposPrestamo

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TiposPrestamoSelectByPK", _
         IdTipoPrestamo _
         ).tables(0)

        Dim Entidad As New coo_TiposPrestamo
        If dt.Rows.Count > 0 Then
            entidad.IdTipoPrestamo = dt.rows(0).item("IdTipoPrestamo")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.Desde = dt.Rows(0).Item("Desde")
            Entidad.Hasta = dt.Rows(0).Item("Hasta")

        End If
        Return Entidad
    End Function

    Public Sub coo_TiposPrestamoDeleteByPK _
      (ByVal IdTipoPrestamo As System.Byte _
      )

        db.ExecuteNonQuery("coo_TiposPrestamoDeleteByPK", _
         IdTipoPrestamo _
         )
    End Sub

    Public Sub coo_TiposPrestamoDeleteByPK _
      (ByVal IdTipoPrestamo As System.Byte _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposPrestamoDeleteByPK", _
         IdTipoPrestamo _
         )
    End Sub

    Public Sub coo_TiposPrestamoInsert _
    (ByVal entidad As coo_TiposPrestamo)

        db.ExecuteNonQuery("coo_TiposPrestamoInsert", _
         entidad.IdTipoPrestamo _
         , entidad.Nombre _
          , entidad.Desde _
           , entidad.Hasta _
         )
    End Sub

    Public Sub coo_TiposPrestamoInsert _
    (ByVal entidad As coo_TiposPrestamo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposPrestamoInsert", _
         entidad.IdTipoPrestamo _
         , entidad.Nombre _
                   , entidad.Desde _
           , entidad.Hasta _
         )
    End Sub

    Public Sub coo_TiposPrestamoUpdate _
    (ByVal entidad As coo_TiposPrestamo)

        db.ExecuteNonQuery("coo_TiposPrestamoUpdate", _
         entidad.IdTipoPrestamo _
         , entidad.Nombre _
                   , entidad.Desde _
           , entidad.Hasta _
         )
    End Sub

    Public Sub coo_TiposPrestamoUpdate _
    (ByVal entidad As coo_TiposPrestamo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposPrestamoUpdate", _
         entidad.IdTipoPrestamo _
         , entidad.Nombre _
                   , entidad.Desde _
           , entidad.Hasta _
         )
    End Sub

#End Region


#Region "coo_SolicitudesReferencia"
    Public Function coo_SolicitudesReferenciaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesReferenciaSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesReferenciaSelectByPK _
      (ByVal IdReferencia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesReferencia

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesReferenciaSelectByPK", _
         IdReferencia _
         , IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesReferencia
        If dt.Rows.Count > 0 Then
            entidad.IdReferencia = dt.rows(0).item("IdReferencia")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.Parentesco = dt.rows(0).item("Parentesco")
            Entidad.Telefono = dt.Rows(0).Item("Telefono")
            Entidad.LugarTrabajo = dt.Rows(0).Item("LugarTrabajo")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesReferenciaDeleteByPK _
      (ByVal IdReferencia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesReferenciaDeleteByPK", _
         IdReferencia _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaDeleteByPK _
      (ByVal IdReferencia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesReferenciaDeleteByPK", _
         IdReferencia _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaInsert _
    (ByVal entidad As coo_SolicitudesReferencia)

        db.ExecuteNonQuery("coo_SolicitudesReferenciaInsert", _
         entidad.IdReferencia _
         , entidad.IdSolicitud _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         , entidad.Telefono _
           , entidad.LugarTrabajo _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaInsert _
    (ByVal entidad As coo_SolicitudesReferencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesReferenciaInsert", _
         entidad.IdReferencia _
         , entidad.IdSolicitud _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         , entidad.Telefono _
           , entidad.LugarTrabajo _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaUpdate _
    (ByVal entidad As coo_SolicitudesReferencia)

        db.ExecuteNonQuery("coo_SolicitudesReferenciaUpdate", _
         entidad.IdReferencia _
         , entidad.IdSolicitud _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         , entidad.Telefono _
           , entidad.LugarTrabajo _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaUpdate _
    (ByVal entidad As coo_SolicitudesReferencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesReferenciaUpdate", _
         entidad.IdReferencia _
         , entidad.IdSolicitud _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         , entidad.Telefono _
           , entidad.LugarTrabajo _
         )
    End Sub

#End Region

#Region "coo_SolicitudesGarantias"
    Public Function coo_SolicitudesGarantiasSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesGarantiasSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesGarantiasSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesGarantias

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesGarantiasSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesGarantias
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.Concepto = dt.rows(0).item("Concepto")
            entidad.IdTipo = dt.rows(0).item("IdTipo")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesGarantiasDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesGarantiasDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesGarantiasDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasInsert _
    (ByVal entidad As coo_SolicitudesGarantias)

        db.ExecuteNonQuery("coo_SolicitudesGarantiasInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.Concepto _
         , entidad.IdTipo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasInsert _
    (ByVal entidad As coo_SolicitudesGarantias, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesGarantiasInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.Concepto _
         , entidad.IdTipo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasUpdate _
    (ByVal entidad As coo_SolicitudesGarantias)

        db.ExecuteNonQuery("coo_SolicitudesGarantiasUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.Concepto _
         , entidad.IdTipo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasUpdate _
    (ByVal entidad As coo_SolicitudesGarantias, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesGarantiasUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.Concepto _
         , entidad.IdTipo _
         )
    End Sub

#End Region
#Region "coo_TiposGarantia"
    Public Function coo_TiposGarantiaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TiposGarantiaSelectAll").Tables(0)
    End Function

    Public Function coo_TiposGarantiaSelectByPK _
      (ByVal IdTipo As System.Int32 _
      ) As coo_TiposGarantia

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_TiposGarantiaSelectByPK", _
         IdTipo _
         ).tables(0)

        Dim Entidad As New coo_TiposGarantia
        If dt.Rows.Count > 0 Then
            entidad.IdTipo = dt.rows(0).item("IdTipo")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Prefijo = dt.rows(0).item("Prefijo")

        End If
        Return Entidad
    End Function

    Public Sub coo_TiposGarantiaDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_TiposGarantiaDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposGarantiaDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposGarantiaDeleteByPK", _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposGarantiaInsert _
    (ByVal entidad As coo_TiposGarantia)

        db.ExecuteNonQuery("coo_TiposGarantiaInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.Prefijo _
         )
    End Sub

    Public Sub coo_TiposGarantiaInsert _
    (ByVal entidad As coo_TiposGarantia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposGarantiaInsert", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.Prefijo _
         )
    End Sub

    Public Sub coo_TiposGarantiaUpdate _
    (ByVal entidad As coo_TiposGarantia)

        db.ExecuteNonQuery("coo_TiposGarantiaUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.Prefijo _
         )
    End Sub

    Public Sub coo_TiposGarantiaUpdate _
    (ByVal entidad As coo_TiposGarantia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposGarantiaUpdate", _
         entidad.IdTipo _
         , entidad.Nombre _
         , entidad.Prefijo _
         )
    End Sub

#End Region

#Region "coo_GarantiasPrendaria"
    Public Function coo_GarantiasPrendariaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_GarantiasPrendariaSelectAll").Tables(0)
    End Function

    Public Function coo_GarantiasPrendariaSelectByPK _
      (ByVal IdGarantia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_GarantiasPrendaria

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_GarantiasPrendariaSelectByPK", _
         IdGarantia _
         , IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_GarantiasPrendaria
        If dt.Rows.Count > 0 Then
            entidad.IdGarantia = dt.rows(0).item("IdGarantia")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.TipoPrenda = dt.rows(0).item("TipoPrenda")
            entidad.Marca = dt.rows(0).item("Marca")
            entidad.Modelo = dt.rows(0).item("Modelo")
            entidad.Serie = dt.rows(0).item("Serie")
            entidad.Color = dt.rows(0).item("Color")
            entidad.Motor = dt.rows(0).item("Motor")
            entidad.Chasis = dt.rows(0).item("Chasis")
            entidad.ValorAproximado = dt.rows(0).item("ValorAproximado")
            entidad.Descripcion = dt.rows(0).item("Descripcion")

        End If
        Return Entidad
    End Function

    Public Sub coo_GarantiasPrendariaDeleteByPK _
      (ByVal IdGarantia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_GarantiasPrendariaDeleteByPK", _
         IdGarantia _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_GarantiasPrendariaDeleteByPK _
      (ByVal IdGarantia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasPrendariaDeleteByPK", _
         IdGarantia _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_GarantiasPrendariaInsert _
    (ByVal entidad As coo_GarantiasPrendaria)

        db.ExecuteNonQuery("coo_GarantiasPrendariaInsert", _
         entidad.IdGarantia _
         , entidad.IdSolicitud _
         , entidad.TipoPrenda _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Color _
         , entidad.Motor _
         , entidad.Chasis _
         , entidad.ValorAproximado _
         , entidad.Descripcion _
         )
    End Sub

    Public Sub coo_GarantiasPrendariaInsert _
    (ByVal entidad As coo_GarantiasPrendaria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasPrendariaInsert", _
         entidad.IdGarantia _
         , entidad.IdSolicitud _
         , entidad.TipoPrenda _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Color _
         , entidad.Motor _
         , entidad.Chasis _
         , entidad.ValorAproximado _
         , entidad.Descripcion _
         )
    End Sub

    Public Sub coo_GarantiasPrendariaUpdate _
    (ByVal entidad As coo_GarantiasPrendaria)

        db.ExecuteNonQuery("coo_GarantiasPrendariaUpdate", _
         entidad.IdGarantia _
         , entidad.IdSolicitud _
         , entidad.TipoPrenda _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Color _
         , entidad.Motor _
         , entidad.Chasis _
         , entidad.ValorAproximado _
         , entidad.Descripcion _
         )
    End Sub

    Public Sub coo_GarantiasPrendariaUpdate _
    (ByVal entidad As coo_GarantiasPrendaria, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasPrendariaUpdate", _
         entidad.IdGarantia _
         , entidad.IdSolicitud _
         , entidad.TipoPrenda _
         , entidad.Marca _
         , entidad.Modelo _
         , entidad.Serie _
         , entidad.Color _
         , entidad.Motor _
         , entidad.Chasis _
         , entidad.ValorAproximado _
         , entidad.Descripcion _
         )
    End Sub

#End Region
#Region "coo_FiadoresBien"
    Public Function coo_FiadoresBienSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FiadoresBienSelectAll").Tables(0)
    End Function

    Public Function coo_FiadoresBienSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdBien As System.Int32 _
      ) As coo_FiadoresBien

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FiadoresBienSelectByPK", _
         IdSolicitud _
         , IdFiador _
         , IdBien _
         ).tables(0)

        Dim Entidad As New coo_FiadoresBien
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdFiador = dt.rows(0).item("IdFiador")
            entidad.IdBien = dt.rows(0).item("IdBien")
            entidad.DescripcionPropiedad = dt.rows(0).item("DescripcionPropiedad")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.ValorAproximado = dt.rows(0).item("ValorAproximado")
            entidad.hipotecado = dt.rows(0).item("hipotecado")

        End If
        Return Entidad
    End Function

    Public Sub coo_FiadoresBienDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdBien As System.Int32 _
      )

        db.ExecuteNonQuery("coo_FiadoresBienDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdBien _
         )
    End Sub

    Public Sub coo_FiadoresBienDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdBien As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresBienDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdBien _
         )
    End Sub

    Public Sub coo_FiadoresBienInsert _
    (ByVal entidad As coo_FiadoresBien)

        db.ExecuteNonQuery("coo_FiadoresBienInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdBien _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.hipotecado _
         )
    End Sub

    Public Sub coo_FiadoresBienInsert _
    (ByVal entidad As coo_FiadoresBien, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresBienInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdBien _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.hipotecado _
         )
    End Sub

    Public Sub coo_FiadoresBienUpdate _
    (ByVal entidad As coo_FiadoresBien)

        db.ExecuteNonQuery("coo_FiadoresBienUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdBien _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.hipotecado _
         )
    End Sub

    Public Sub coo_FiadoresBienUpdate _
    (ByVal entidad As coo_FiadoresBien, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresBienUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdBien _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.hipotecado _
         )
    End Sub

#End Region
#Region "coo_FiadoresObligacion"
    Public Function coo_FiadoresObligacionSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FiadoresObligacionSelectAll").Tables(0)
    End Function

    Public Function coo_FiadoresObligacionSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdObligacion As System.Int32 _
      ) As coo_FiadoresObligacion

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FiadoresObligacionSelectByPK", _
         IdSolicitud _
         , IdFiador _
         , IdObligacion _
         ).tables(0)

        Dim Entidad As New coo_FiadoresObligacion
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdFiador = dt.rows(0).item("IdFiador")
            entidad.IdObligacion = dt.rows(0).item("IdObligacion")
            entidad.Acreedor = dt.rows(0).item("Acreedor")
            entidad.MontoDeuda = dt.rows(0).item("MontoDeuda")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.AbonoMensual = dt.rows(0).item("AbonoMensual")

        End If
        Return Entidad
    End Function

    Public Sub coo_FiadoresObligacionDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdObligacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_FiadoresObligacionDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdObligacion _
         )
    End Sub

    Public Sub coo_FiadoresObligacionDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdObligacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresObligacionDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdObligacion _
         )
    End Sub

    Public Sub coo_FiadoresObligacionInsert _
    (ByVal entidad As coo_FiadoresObligacion)

        db.ExecuteNonQuery("coo_FiadoresObligacionInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdObligacion _
         , entidad.Acreedor _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_FiadoresObligacionInsert _
    (ByVal entidad As coo_FiadoresObligacion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresObligacionInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdObligacion _
         , entidad.Acreedor _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_FiadoresObligacionUpdate _
    (ByVal entidad As coo_FiadoresObligacion)

        db.ExecuteNonQuery("coo_FiadoresObligacionUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdObligacion _
         , entidad.Acreedor _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_FiadoresObligacionUpdate _
    (ByVal entidad As coo_FiadoresObligacion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresObligacionUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdObligacion _
         , entidad.Acreedor _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

#End Region
#Region "coo_FiadoresReferencia"
    Public Function coo_FiadoresReferenciaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_FiadoresReferenciaSelectAll").Tables(0)
    End Function

    Public Function coo_FiadoresReferenciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdReferencia As System.Int32 _
      ) As coo_FiadoresReferencia

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_FiadoresReferenciaSelectByPK", _
         IdSolicitud _
         , IdFiador _
         , IdReferencia _
         ).tables(0)

        Dim Entidad As New coo_FiadoresReferencia
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdFiador = dt.rows(0).item("IdFiador")
            entidad.IdReferencia = dt.rows(0).item("IdReferencia")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.Parentesco = dt.rows(0).item("Parentesco")

        End If
        Return Entidad
    End Function

    Public Sub coo_FiadoresReferenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdReferencia As System.Int32 _
      )

        db.ExecuteNonQuery("coo_FiadoresReferenciaDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdReferencia _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdReferencia As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresReferenciaDeleteByPK", _
         IdSolicitud _
         , IdFiador _
         , IdReferencia _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaInsert _
    (ByVal entidad As coo_FiadoresReferencia)

        db.ExecuteNonQuery("coo_FiadoresReferenciaInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdReferencia _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaInsert _
    (ByVal entidad As coo_FiadoresReferencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresReferenciaInsert", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdReferencia _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaUpdate _
    (ByVal entidad As coo_FiadoresReferencia)

        db.ExecuteNonQuery("coo_FiadoresReferenciaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdReferencia _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaUpdate _
    (ByVal entidad As coo_FiadoresReferencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_FiadoresReferenciaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdFiador _
         , entidad.IdReferencia _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Parentesco _
         )
    End Sub

#End Region
#Region "coo_GarantiasHipoteca"
    Public Function coo_GarantiasHipotecaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_GarantiasHipotecaSelectAll").Tables(0)
    End Function

    Public Function coo_GarantiasHipotecaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      ) As coo_GarantiasHipoteca

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_GarantiasHipotecaSelectByPK", _
         IdSolicitud _
         , IdGarantia _
         ).Tables(0)

        Dim Entidad As New coo_GarantiasHipoteca
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdGarantia = dt.Rows(0).Item("IdGarantia")
            Entidad.Propietario = dt.Rows(0).Item("Propietario")
            Entidad.DireccionPropiedad = dt.Rows(0).Item("DireccionPropiedad")
            Entidad.AreaPropiedad = dt.Rows(0).Item("AreaPropiedad")
            Entidad.DescripcionPropiedad = dt.Rows(0).Item("DescripcionPropiedad")
            Entidad.ValorPropiedad = dt.Rows(0).Item("ValorPropiedad")
            Entidad.Registro = dt.Rows(0).Item("Registro")
            Entidad.NumeroFolio = dt.Rows(0).Item("NumeroFolio")
            Entidad.NumeroLibro = dt.Rows(0).Item("NumeroLibro")
            Entidad.Gravada = dt.Rows(0).Item("Gravada")
            Entidad.IdSituacion = dt.Rows(0).Item("IdSituacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_GarantiasHipotecaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      )

        db.ExecuteNonQuery("coo_GarantiasHipotecaDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasHipotecaDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaInsert _
    (ByVal entidad As coo_GarantiasHipoteca)

        db.ExecuteNonQuery("coo_GarantiasHipotecaInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.Propietario _
         , entidad.DireccionPropiedad _
         , entidad.AreaPropiedad _
         , entidad.DescripcionPropiedad _
         , entidad.ValorPropiedad _
         , entidad.Registro _
         , entidad.NumeroFolio _
         , entidad.NumeroLibro _
         , entidad.Gravada _
         , entidad.IdSituacion _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaInsert _
    (ByVal entidad As coo_GarantiasHipoteca, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasHipotecaInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.Propietario _
         , entidad.DireccionPropiedad _
         , entidad.AreaPropiedad _
         , entidad.DescripcionPropiedad _
         , entidad.ValorPropiedad _
         , entidad.Registro _
         , entidad.NumeroFolio _
         , entidad.NumeroLibro _
         , entidad.Gravada _
         , entidad.IdSituacion _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaUpdate _
    (ByVal entidad As coo_GarantiasHipoteca)

        db.ExecuteNonQuery("coo_GarantiasHipotecaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.Propietario _
         , entidad.DireccionPropiedad _
         , entidad.AreaPropiedad _
         , entidad.DescripcionPropiedad _
         , entidad.ValorPropiedad _
         , entidad.Registro _
         , entidad.NumeroFolio _
         , entidad.NumeroLibro _
         , entidad.Gravada _
         , entidad.IdSituacion _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaUpdate _
    (ByVal entidad As coo_GarantiasHipoteca, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasHipotecaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.Propietario _
         , entidad.DireccionPropiedad _
         , entidad.AreaPropiedad _
         , entidad.DescripcionPropiedad _
         , entidad.ValorPropiedad _
         , entidad.Registro _
         , entidad.NumeroFolio _
         , entidad.NumeroLibro _
         , entidad.Gravada _
         , entidad.IdSituacion _
         )
    End Sub

#End Region
#Region "coo_GarantiasCuentaPignorada"
    Public Function coo_GarantiasCuentaPignoradaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_GarantiasCuentaPignoradaSelectAll").Tables(0)
    End Function

    Public Function coo_GarantiasCuentaPignoradaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      ) As coo_GarantiasCuentaPignorada

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_GarantiasCuentaPignoradaSelectByPK", _
         IdSolicitud _
         , IdGarantia _
         ).Tables(0)

        Dim Entidad As New coo_GarantiasCuentaPignorada
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdGarantia = dt.Rows(0).Item("IdGarantia")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.Nombres = dt.Rows(0).Item("Nombres")
            Entidad.ValorPignorado = dt.Rows(0).Item("ValorPignorado")
            Entidad.Aplicado = dt.Rows(0).Item("Aplicado")
            Entidad.Manual = dt.Rows(0).Item("Manual")
            Entidad.FechaReversion = fd.SiEsNulo(dt.Rows(0).Item("FechaReversion"), Nothing)
            Entidad.Usuario = fd.SiEsNulo(dt.Rows(0).Item("Usuario"), Nothing)
            Entidad.Fecha = fd.SiEsNulo(dt.Rows(0).Item("Fecha"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_GarantiasCuentaPignoradaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      )

        db.ExecuteNonQuery("coo_GarantiasCuentaPignoradaDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasCuentaPignoradaDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaInsert _
    (ByVal entidad As coo_GarantiasCuentaPignorada)

        db.ExecuteNonQuery("coo_GarantiasCuentaPignoradaInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdCuenta _
         , entidad.NumeroCuenta _
         , entidad.IdAsociado _
         , entidad.Nombres _
         , entidad.ValorPignorado _
         , entidad.Aplicado _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.Usuario _
         , entidad.Fecha _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaInsert _
    (ByVal entidad As coo_GarantiasCuentaPignorada, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasCuentaPignoradaInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdCuenta _
         , entidad.NumeroCuenta _
         , entidad.IdAsociado _
         , entidad.Nombres _
         , entidad.ValorPignorado _
         , entidad.Aplicado _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.Usuario _
         , entidad.Fecha _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaUpdate _
    (ByVal entidad As coo_GarantiasCuentaPignorada)

        db.ExecuteNonQuery("coo_GarantiasCuentaPignoradaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdCuenta _
         , entidad.NumeroCuenta _
         , entidad.IdAsociado _
         , entidad.Nombres _
         , entidad.ValorPignorado _
         , entidad.Aplicado _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.Usuario _
         , entidad.Fecha _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaUpdate _
    (ByVal entidad As coo_GarantiasCuentaPignorada, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasCuentaPignoradaUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdCuenta _
         , entidad.NumeroCuenta _
         , entidad.IdAsociado _
         , entidad.Nombres _
         , entidad.ValorPignorado _
         , entidad.Aplicado _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.Usuario _
         , entidad.Fecha _
         )
    End Sub

#End Region
#Region "coo_GarantiasFiador"
    Public Function coo_GarantiasFiadorSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_GarantiasFiadorSelectAll").Tables(0)
    End Function

    Public Function coo_GarantiasFiadorSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      ) As coo_GarantiasFiador

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_GarantiasFiadorSelectByPK", _
         IdSolicitud _
         , IdGarantia _
         ).tables(0)

        Dim Entidad As New coo_GarantiasFiador
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdGarantia = dt.rows(0).item("IdGarantia")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.NombresApellidos = dt.rows(0).item("NombresApellidos")
            entidad.NroDocumento = dt.rows(0).item("NroDocumento")
            entidad.LugarExpedicion = dt.rows(0).item("LugarExpedicion")
            entidad.FechaExpedicion = dt.rows(0).item("FechaExpedicion")
            entidad.IdProfesion = dt.rows(0).item("IdProfesion")
            entidad.Nit = dt.rows(0).item("Nit")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.IdMunicipio = dt.rows(0).item("IdMunicipio")
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.IdCanton = dt.rows(0).item("IdCanton")
            entidad.Telefonos = dt.rows(0).item("Telefonos")
            entidad.FechaNacimiento = dt.rows(0).item("FechaNacimiento")
            entidad.IdSexo = dt.rows(0).item("IdSexo")
            entidad.IdEstadoCivil = dt.rows(0).item("IdEstadoCivil")
            entidad.PersonasSostiene = dt.rows(0).item("PersonasSostiene")
            entidad.ViveCasaPropia = dt.rows(0).item("ViveCasaPropia")
            entidad.TipoTrabajo = dt.rows(0).item("TipoTrabajo")
            entidad.NombreTrabajo = dt.rows(0).item("NombreTrabajo")
            entidad.DireccionTrabajo = dt.rows(0).item("DireccionTrabajo")
            entidad.TelefonoTrabajo = dt.rows(0).item("TelefonoTrabajo")
            entidad.TipoContratacion = dt.rows(0).item("TipoContratacion")
            entidad.TiempoTrabajo = dt.rows(0).item("TiempoTrabajo")
            entidad.SalarioMensual = dt.rows(0).item("SalarioMensual")
            entidad.Comisiones = dt.rows(0).item("Comisiones")
            entidad.IngresosNegocio = dt.rows(0).item("IngresosNegocio")
            entidad.OtrosIngresos = dt.rows(0).item("OtrosIngresos")
            entidad.GastosVida = dt.rows(0).item("GastosVida")
            entidad.PagoObligaciones = dt.rows(0).item("PagoObligaciones")
            entidad.GastosNegocio = dt.rows(0).item("GastosNegocio")
            entidad.OtrosGastos = dt.rows(0).item("OtrosGastos")
            entidad.TiempoConocer = dt.rows(0).item("TiempoConocer")
            entidad.EsFamiliar = dt.rows(0).item("EsFamiliar")
            entidad.Parentesco = dt.rows(0).item("Parentesco")
            Entidad.PorcentajeCubre = dt.Rows(0).Item("PorcentajeCubre")
        End If
        Return Entidad
    End Function

    Public Sub coo_GarantiasFiadorDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      )

        db.ExecuteNonQuery("coo_GarantiasFiadorDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasFiadorDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasFiadorDeleteByPK", _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasFiadorInsert _
    (ByVal entidad As coo_GarantiasFiador)

        db.ExecuteNonQuery("coo_GarantiasFiadorInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdAsociado _
         , entidad.NombresApellidos _
         , entidad.NroDocumento _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.IdProfesion _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.FechaNacimiento _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.PersonasSostiene _
         , entidad.ViveCasaPropia _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.TipoContratacion _
         , entidad.TiempoTrabajo _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
         , entidad.GastosVida _
         , entidad.PagoObligaciones _
         , entidad.GastosNegocio _
         , entidad.OtrosGastos _
         , entidad.TiempoConocer _
         , entidad.EsFamiliar _
         , entidad.Parentesco _
         , entidad.PorcentajeCubre _
         )
    End Sub

    Public Sub coo_GarantiasFiadorInsert _
    (ByVal entidad As coo_GarantiasFiador, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasFiadorInsert", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdAsociado _
         , entidad.NombresApellidos _
         , entidad.NroDocumento _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.IdProfesion _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.FechaNacimiento _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.PersonasSostiene _
         , entidad.ViveCasaPropia _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.TipoContratacion _
         , entidad.TiempoTrabajo _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
         , entidad.GastosVida _
         , entidad.PagoObligaciones _
         , entidad.GastosNegocio _
         , entidad.OtrosGastos _
         , entidad.TiempoConocer _
         , entidad.EsFamiliar _
         , entidad.Parentesco _
         , entidad.PorcentajeCubre _
         )
    End Sub

    Public Sub coo_GarantiasFiadorUpdate _
    (ByVal entidad As coo_GarantiasFiador)

        db.ExecuteNonQuery("coo_GarantiasFiadorUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdAsociado _
         , entidad.NombresApellidos _
         , entidad.NroDocumento _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.IdProfesion _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.FechaNacimiento _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.PersonasSostiene _
         , entidad.ViveCasaPropia _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.TipoContratacion _
         , entidad.TiempoTrabajo _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
         , entidad.GastosVida _
         , entidad.PagoObligaciones _
         , entidad.GastosNegocio _
         , entidad.OtrosGastos _
         , entidad.TiempoConocer _
         , entidad.EsFamiliar _
         , entidad.Parentesco _
         , entidad.PorcentajeCubre _
         )
    End Sub

    Public Sub coo_GarantiasFiadorUpdate _
    (ByVal entidad As coo_GarantiasFiador, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_GarantiasFiadorUpdate", _
         entidad.IdSolicitud _
         , entidad.IdGarantia _
         , entidad.IdAsociado _
         , entidad.NombresApellidos _
         , entidad.NroDocumento _
         , entidad.LugarExpedicion _
         , entidad.FechaExpedicion _
         , entidad.IdProfesion _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.IdMunicipio _
         , entidad.IdDepartamento _
         , entidad.IdCanton _
         , entidad.Telefonos _
         , entidad.FechaNacimiento _
         , entidad.IdSexo _
         , entidad.IdEstadoCivil _
         , entidad.PersonasSostiene _
         , entidad.ViveCasaPropia _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.TipoContratacion _
         , entidad.TiempoTrabajo _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
         , entidad.GastosVida _
         , entidad.PagoObligaciones _
         , entidad.GastosNegocio _
         , entidad.OtrosGastos _
         , entidad.TiempoConocer _
         , entidad.EsFamiliar _
         , entidad.Parentesco _
         , entidad.PorcentajeCubre _
         )
    End Sub

#End Region

#Region "coo_Solicitudes"
    Public Function coo_SolicitudesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_Solicitudes

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_Solicitudes
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            Entidad.FechaSolicitud = dt.Rows(0).Item("FechaSolicitud")
            Entidad.FechaRecepcion = fd.SiEsNulo(dt.Rows(0).Item("FechaRecepcion"), Nothing)
            Entidad.FechaAprobacion = fd.SiEsNulo(dt.Rows(0).Item("FechaAprobacion"), Nothing)
            Entidad.FechaPrimerPago = fd.SiEsNulo(dt.Rows(0).Item("FechaPrimerPago"), Nothing)
            entidad.IdTecnico = dt.rows(0).item("IdTecnico")
            entidad.TipoTrabajo = dt.rows(0).item("TipoTrabajo")
            entidad.NombreTrabajo = dt.rows(0).item("NombreTrabajo")
            entidad.DireccionTrabajo = dt.rows(0).item("DireccionTrabajo")
            entidad.TelefonoTrabajo = dt.rows(0).item("TelefonoTrabajo")
            entidad.CargoTrabajo = dt.rows(0).item("CargoTrabajo")
            entidad.TiempoTrabajo = dt.rows(0).item("TiempoTrabajo")
            entidad.TipoContratacion = dt.rows(0).item("TipoContratacion")
            entidad.JefeInmediato = dt.rows(0).item("JefeInmediato")
            entidad.CapitalInvertido = dt.rows(0).item("CapitalInvertido")
            entidad.DireccionNegocio = dt.rows(0).item("DireccionNegocio")
            entidad.TelefonoNegocio = dt.rows(0).item("TelefonoNegocio")
            entidad.CasasComerciales = dt.rows(0).item("CasasComerciales")
            entidad.SalarioMensual = dt.rows(0).item("SalarioMensual")
            entidad.Comisiones = dt.rows(0).item("Comisiones")
            entidad.IngresosNegocio = dt.rows(0).item("IngresosNegocio")
            entidad.OtrosIngresos = dt.rows(0).item("OtrosIngresos")
            Entidad.Casa = fd.SiEsNulo(dt.Rows(0).Item("Casa"), Nothing)
            Entidad.Servicios = fd.SiEsNulo(dt.Rows(0).Item("Servicios"), Nothing)
            Entidad.Alimentacion = fd.SiEsNulo(dt.Rows(0).Item("Alimentacion"), Nothing)
            Entidad.OtrosPrestamos = fd.SiEsNulo(dt.Rows(0).Item("OtrosPrestamos"), Nothing)
            Entidad.Colegiatura = fd.SiEsNulo(dt.Rows(0).Item("Colegiatura"), Nothing)
            Entidad.Transporte = fd.SiEsNulo(dt.Rows(0).Item("Transporte"), Nothing)
            Entidad.TarjetaCredito = fd.SiEsNulo(dt.Rows(0).Item("TarjetaCredito"), Nothing)
            entidad.Efectivo = dt.rows(0).item("Efectivo")
            entidad.Bancos = dt.rows(0).item("Bancos")
            entidad.CuentasCobrar = dt.rows(0).item("CuentasCobrar")
            entidad.Mercaderias = dt.rows(0).item("Mercaderias")
            entidad.BienesInmuebles = dt.rows(0).item("BienesInmuebles")
            entidad.OtrosBienes = dt.rows(0).item("OtrosBienes")
            entidad.PrestamosPagar = dt.rows(0).item("PrestamosPagar")
            entidad.CuentasPagar = dt.rows(0).item("CuentasPagar")
            entidad.Proveedores = dt.rows(0).item("Proveedores")
            Entidad.Capital = dt.Rows(0).Item("Capital")
            entidad.MontoSolicitado = dt.rows(0).item("MontoSolicitado")
            entidad.TasaInteres = dt.rows(0).item("TasaInteres")
            entidad.NumeroCuotas = dt.rows(0).item("NumeroCuotas")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            Entidad.FrecuenciaPago = dt.Rows(0).Item("FrecuenciaPago")
            Entidad.TipoCuota = dt.Rows(0).Item("TipoCuota")
            Entidad.IdTipoAplicacion = fd.SiEsNulo(dt.Rows(0).Item("IdTipoAplicacion"), Nothing)
            entidad.DetalleFormaPago = dt.rows(0).item("DetalleFormaPago")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Destino = dt.rows(0).item("Destino")
            entidad.IdFuente = dt.rows(0).item("IdFuente")
            entidad.IdTipoCredito = dt.rows(0).item("IdTipoCredito")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.Aprobada = dt.rows(0).item("Aprobada")
            entidad.Procesada = dt.rows(0).item("Procesada")
            entidad.IncluyeTasaSeguro = dt.rows(0).item("IncluyeTasaSeguro")
            entidad.CuotaAportacion = dt.rows(0).item("CuotaAportacion")
            entidad.CuotaAhorro = dt.rows(0).item("CuotaAhorro")
            entidad.CuotaManejo = dt.rows(0).item("CuotaManejo")
            entidad.CuotaOtros = dt.rows(0).item("CuotaOtros")
            entidad.ValorCuota = dt.rows(0).item("ValorCuota")
            entidad.FechaPosibleDesembolso = dt.rows(0).item("FechaPosibleDesembolso")
            entidad.ProyeccionVenta = dt.rows(0).item("ProyeccionVenta")
            entidad.ConceptoProyeccionVenta = dt.rows(0).item("ConceptoProyeccionVenta")
            entidad.ProyeccionGastos = dt.rows(0).item("ProyeccionGastos")
            entidad.ConceptoProyeccionGastos = dt.rows(0).item("ConceptoProyeccionGastos")
            entidad.RequiereSeguimiento = dt.rows(0).item("RequiereSeguimiento")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            Entidad.AplicaDescuento = dt.Rows(0).Item("AplicaDescuento")
        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesInsert _
    (ByVal entidad As coo_Solicitudes)

        db.ExecuteNonQuery("coo_SolicitudesInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
           , entidad.FechaRecepcion _
         , entidad.FechaAprobacion _
         , entidad.FechaPrimerPago _
         , entidad.IdTecnico _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.CargoTrabajo _
         , entidad.TiempoTrabajo _
         , entidad.TipoContratacion _
         , entidad.JefeInmediato _
         , entidad.CapitalInvertido _
         , entidad.DireccionNegocio _
         , entidad.TelefonoNegocio _
         , entidad.CasasComerciales _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
        , entidad.Casa _
  , entidad.Servicios _
  , entidad.Alimentacion _
  , entidad.OtrosPrestamos _
  , entidad.Colegiatura _
  , entidad.Transporte _
  , entidad.TarjetaCredito _
         , entidad.Efectivo _
         , entidad.Bancos _
         , entidad.CuentasCobrar _
         , entidad.Mercaderias _
         , entidad.BienesInmuebles _
         , entidad.OtrosBienes _
         , entidad.PrestamosPagar _
         , entidad.CuentasPagar _
         , entidad.Proveedores _
         , entidad.Capital _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
          , entidad.TipoCuota _
            , entidad.IdTipoAplicacion _
         , entidad.DetalleFormaPago _
         , entidad.IdLinea _
         , entidad.Destino _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.Procesada _
         , entidad.IncluyeTasaSeguro _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.ValorCuota _
         , entidad.FechaPosibleDesembolso _
         , entidad.ProyeccionVenta _
         , entidad.ConceptoProyeccionVenta _
         , entidad.ProyeccionGastos _
         , entidad.ConceptoProyeccionGastos _
         , entidad.RequiereSeguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_SolicitudesInsert _
    (ByVal entidad As coo_Solicitudes, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
           , entidad.FechaRecepcion _
         , entidad.FechaAprobacion _
         , entidad.FechaPrimerPago _
         , entidad.IdTecnico _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.CargoTrabajo _
         , entidad.TiempoTrabajo _
         , entidad.TipoContratacion _
         , entidad.JefeInmediato _
         , entidad.CapitalInvertido _
         , entidad.DireccionNegocio _
         , entidad.TelefonoNegocio _
         , entidad.CasasComerciales _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
        , entidad.Casa _
  , entidad.Servicios _
  , entidad.Alimentacion _
  , entidad.OtrosPrestamos _
  , entidad.Colegiatura _
  , entidad.Transporte _
  , entidad.TarjetaCredito _
         , entidad.Efectivo _
         , entidad.Bancos _
         , entidad.CuentasCobrar _
         , entidad.Mercaderias _
         , entidad.BienesInmuebles _
         , entidad.OtrosBienes _
         , entidad.PrestamosPagar _
         , entidad.CuentasPagar _
         , entidad.Proveedores _
         , entidad.Capital _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.TipoCuota _
           , entidad.IdTipoAplicacion _
         , entidad.DetalleFormaPago _
         , entidad.IdLinea _
         , entidad.Destino _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.Procesada _
         , entidad.IncluyeTasaSeguro _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.ValorCuota _
         , entidad.FechaPosibleDesembolso _
         , entidad.ProyeccionVenta _
         , entidad.ConceptoProyeccionVenta _
         , entidad.ProyeccionGastos _
         , entidad.ConceptoProyeccionGastos _
         , entidad.RequiereSeguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AplicaDescuento _
         )
    End Sub

    Public Sub coo_SolicitudesUpdate _
    (ByVal entidad As coo_Solicitudes)

        db.ExecuteNonQuery("coo_SolicitudesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
           , entidad.FechaRecepcion _
         , entidad.FechaAprobacion _
         , entidad.FechaPrimerPago _
         , entidad.IdTecnico _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.CargoTrabajo _
         , entidad.TiempoTrabajo _
         , entidad.TipoContratacion _
         , entidad.JefeInmediato _
         , entidad.CapitalInvertido _
         , entidad.DireccionNegocio _
         , entidad.TelefonoNegocio _
         , entidad.CasasComerciales _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
        , entidad.Casa _
  , entidad.Servicios _
  , entidad.Alimentacion _
  , entidad.OtrosPrestamos _
  , entidad.Colegiatura _
  , entidad.Transporte _
  , entidad.TarjetaCredito _
         , entidad.Efectivo _
         , entidad.Bancos _
         , entidad.CuentasCobrar _
         , entidad.Mercaderias _
         , entidad.BienesInmuebles _
         , entidad.OtrosBienes _
         , entidad.PrestamosPagar _
         , entidad.CuentasPagar _
         , entidad.Proveedores _
         , entidad.Capital _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
          , entidad.TipoCuota _
         , entidad.IdTipoAplicacion _
         , entidad.DetalleFormaPago _
         , entidad.IdLinea _
         , entidad.Destino _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.Procesada _
         , entidad.IncluyeTasaSeguro _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.ValorCuota _
         , entidad.FechaPosibleDesembolso _
         , entidad.ProyeccionVenta _
         , entidad.ConceptoProyeccionVenta _
         , entidad.ProyeccionGastos _
         , entidad.ConceptoProyeccionGastos _
         , entidad.RequiereSeguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_SolicitudesUpdate _
    (ByVal entidad As coo_Solicitudes, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
           , entidad.FechaRecepcion _
         , entidad.FechaAprobacion _
          , entidad.FechaPrimerPago _
         , entidad.IdTecnico _
         , entidad.TipoTrabajo _
         , entidad.NombreTrabajo _
         , entidad.DireccionTrabajo _
         , entidad.TelefonoTrabajo _
         , entidad.CargoTrabajo _
         , entidad.TiempoTrabajo _
         , entidad.TipoContratacion _
         , entidad.JefeInmediato _
         , entidad.CapitalInvertido _
         , entidad.DireccionNegocio _
         , entidad.TelefonoNegocio _
         , entidad.CasasComerciales _
         , entidad.SalarioMensual _
         , entidad.Comisiones _
         , entidad.IngresosNegocio _
         , entidad.OtrosIngresos _
        , entidad.Casa _
  , entidad.Servicios _
  , entidad.Alimentacion _
  , entidad.OtrosPrestamos _
  , entidad.Colegiatura _
  , entidad.Transporte _
  , entidad.TarjetaCredito _
         , entidad.Efectivo _
         , entidad.Bancos _
         , entidad.CuentasCobrar _
         , entidad.Mercaderias _
         , entidad.BienesInmuebles _
         , entidad.OtrosBienes _
         , entidad.PrestamosPagar _
         , entidad.CuentasPagar _
         , entidad.Proveedores _
         , entidad.Capital _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.TipoCuota _
         , entidad.IdTipoAplicacion _
         , entidad.DetalleFormaPago _
         , entidad.IdLinea _
         , entidad.Destino _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.Procesada _
         , entidad.IncluyeTasaSeguro _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.ValorCuota _
         , entidad.FechaPosibleDesembolso _
         , entidad.ProyeccionVenta _
         , entidad.ConceptoProyeccionVenta _
         , entidad.ProyeccionGastos _
         , entidad.ConceptoProyeccionGastos _
         , entidad.RequiereSeguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AplicaDescuento _
         )
    End Sub

#End Region
#Region "coo_SolicitudesCruces"
    Public Function coo_SolicitudesCrucesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesCrucesSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesCrucesSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesCruces

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesCrucesSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesCruces
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.FechaSolicitud = dt.rows(0).item("FechaSolicitud")
            entidad.FechaRecepcion = dt.rows(0).item("FechaRecepcion")
            entidad.SaldoAportacion = dt.rows(0).item("SaldoAportacion")
            Entidad.LiquidarAportacion = dt.Rows(0).Item("LiquidarAportacion")
            Entidad.AumentarAportacion = dt.Rows(0).Item("AumentarAportacion")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            Entidad.Autorizado = dt.Rows(0).Item("Autorizado")
            entidad.AutorizadoPor = dt.rows(0).item("AutorizadoPor")
            Entidad.FechaHoraAutorizacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraAutorizacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesCrucesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesCrucesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesInsert _
    (ByVal entidad As coo_SolicitudesCruces)

        db.ExecuteNonQuery("coo_SolicitudesCrucesInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
         , entidad.FechaRecepcion _
         , entidad.SaldoAportacion _
         , entidad.LiquidarAportacion _
         , entidad.AumentarAportacion _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesInsert _
    (ByVal entidad As coo_SolicitudesCruces, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
         , entidad.FechaRecepcion _
         , entidad.SaldoAportacion _
         , entidad.LiquidarAportacion _
         , entidad.AumentarAportacion _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesUpdate _
    (ByVal entidad As coo_SolicitudesCruces)

        db.ExecuteNonQuery("coo_SolicitudesCrucesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
         , entidad.FechaRecepcion _
         , entidad.SaldoAportacion _
         , entidad.LiquidarAportacion _
         , entidad.AumentarAportacion _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
          , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesUpdate _
    (ByVal entidad As coo_SolicitudesCruces, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.FechaSolicitud _
         , entidad.FechaRecepcion _
         , entidad.SaldoAportacion _
         , entidad.LiquidarAportacion _
         , entidad.AumentarAportacion _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
          , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

#End Region
#Region "coo_SolicitudesCrucesAhorros"
    Public Function coo_SolicitudesCrucesAhorrosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesCrucesAhorrosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesCrucesAhorrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesCrucesAhorros

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesCrucesAhorrosSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesCrucesAhorros
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.Valor = dt.rows(0).item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesCrucesAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesCrucesAhorrosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesAhorrosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosInsert _
    (ByVal entidad As coo_SolicitudesCrucesAhorros)

        db.ExecuteNonQuery("coo_SolicitudesCrucesAhorrosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosInsert _
    (ByVal entidad As coo_SolicitudesCrucesAhorros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesAhorrosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesAhorros)

        db.ExecuteNonQuery("coo_SolicitudesCrucesAhorrosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesAhorros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesAhorrosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_SolicitudesCrucesPrestamos"
    Public Function coo_SolicitudesCrucesPrestamosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesCrucesPrestamosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesCrucesPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesCrucesPrestamos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesCrucesPrestamosSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesCrucesPrestamos
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdLinea = dt.Rows(0).Item("IdLinea")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.ValorAbono = dt.rows(0).item("ValorAbono")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesCrucesPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesCrucesPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosInsert _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos)

        db.ExecuteNonQuery("coo_SolicitudesCrucesPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosInsert _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos)

        db.ExecuteNonQuery("coo_SolicitudesCrucesPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesCrucesPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

#End Region

#Region "coo_SolicitudesBien"
    Public Function coo_SolicitudesBienSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesBienSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesBienSelectByPK _
      (ByVal IdBien As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesBien

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesBienSelectByPK", _
         IdBien _
         , IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesBien
        If dt.Rows.Count > 0 Then
            entidad.IdBien = dt.rows(0).item("IdBien")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.DescripcionPropiedad = dt.rows(0).item("DescripcionPropiedad")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.ValorAproximado = dt.rows(0).item("ValorAproximado")
            entidad.Hipotecado = dt.rows(0).item("Hipotecado")
            entidad.PagoMensual = dt.rows(0).item("PagoMensual")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesBienDeleteByPK _
      (ByVal IdBien As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesBienDeleteByPK", _
         IdBien _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesBienDeleteByPK _
      (ByVal IdBien As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesBienDeleteByPK", _
         IdBien _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesBienInsert _
    (ByVal entidad As coo_SolicitudesBien)

        db.ExecuteNonQuery("coo_SolicitudesBienInsert", _
         entidad.IdBien _
         , entidad.IdSolicitud _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.Hipotecado _
         , entidad.PagoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesBienInsert _
    (ByVal entidad As coo_SolicitudesBien, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesBienInsert", _
         entidad.IdBien _
         , entidad.IdSolicitud _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.Hipotecado _
         , entidad.PagoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesBienUpdate _
    (ByVal entidad As coo_SolicitudesBien)

        db.ExecuteNonQuery("coo_SolicitudesBienUpdate", _
         entidad.IdBien _
         , entidad.IdSolicitud _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.Hipotecado _
         , entidad.PagoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesBienUpdate _
    (ByVal entidad As coo_SolicitudesBien, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesBienUpdate", _
         entidad.IdBien _
         , entidad.IdSolicitud _
         , entidad.DescripcionPropiedad _
         , entidad.Direccion _
         , entidad.ValorAproximado _
         , entidad.Hipotecado _
         , entidad.PagoMensual _
         )
    End Sub

#End Region
#Region "coo_SolicitudesObligacion"
    Public Function coo_SolicitudesObligacionSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesObligacionSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesObligacionSelectByPK _
      (ByVal IdObligacion As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesObligacion

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesObligacionSelectByPK", _
         IdObligacion _
         , IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesObligacion
        If dt.Rows.Count > 0 Then
            entidad.IdObligacion = dt.rows(0).item("IdObligacion")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Acreedor = dt.rows(0).item("Acreedor")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.MontoDeuda = dt.rows(0).item("MontoDeuda")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.AbonoMensual = dt.rows(0).item("AbonoMensual")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesObligacionDeleteByPK _
      (ByVal IdObligacion As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesObligacionDeleteByPK", _
         IdObligacion _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionDeleteByPK _
      (ByVal IdObligacion As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesObligacionDeleteByPK", _
         IdObligacion _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionInsert _
    (ByVal entidad As coo_SolicitudesObligacion)

        db.ExecuteNonQuery("coo_SolicitudesObligacionInsert", _
         entidad.IdObligacion _
         , entidad.IdSolicitud _
         , entidad.Acreedor _
         , entidad.Direccion _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionInsert _
    (ByVal entidad As coo_SolicitudesObligacion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesObligacionInsert", _
         entidad.IdObligacion _
         , entidad.IdSolicitud _
         , entidad.Acreedor _
         , entidad.Direccion _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionUpdate _
    (ByVal entidad As coo_SolicitudesObligacion)

        db.ExecuteNonQuery("coo_SolicitudesObligacionUpdate", _
         entidad.IdObligacion _
         , entidad.IdSolicitud _
         , entidad.Acreedor _
         , entidad.Direccion _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionUpdate _
    (ByVal entidad As coo_SolicitudesObligacion, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesObligacionUpdate", _
         entidad.IdObligacion _
         , entidad.IdSolicitud _
         , entidad.Acreedor _
         , entidad.Direccion _
         , entidad.MontoDeuda _
         , entidad.SaldoActual _
         , entidad.AbonoMensual _
         )
    End Sub

#End Region
#Region "coo_SolicitudRetiro"
    Public Function coo_SolicitudRetiroSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudRetiroSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudRetiroSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudRetiro

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudRetiroSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_SolicitudRetiro
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.NumeroSolicitud = dt.Rows(0).Item("NumeroSolicitud")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.FechaRetiro = dt.rows(0).item("FechaRetiro")
            entidad.TipoRetiro = dt.rows(0).item("TipoRetiro")
            entidad.MotivoRetiro = dt.rows(0).item("MotivoRetiro")
            entidad.SaldoCreditos = dt.rows(0).item("SaldoCreditos")
            entidad.SaldoInteres = dt.rows(0).item("SaldoInteres")
            entidad.SaldoInteresMora = dt.rows(0).item("SaldoInteresMora")
            entidad.SaldoSeguro = dt.rows(0).item("SaldoSeguro")
            entidad.MontoAhorrado = dt.rows(0).item("MontoAhorrado")
            entidad.MontoAportado = dt.rows(0).item("MontoAportado")
            entidad.MontoPropiedadSocio = dt.rows(0).item("MontoPropiedadSocio")
            entidad.LiquidoEntregarSocio = dt.rows(0).item("LiquidoEntregarSocio")
            entidad.PendienteCooperativa = dt.rows(0).item("PendienteCooperativa")
            Entidad.MontoCobrarSocio = dt.Rows(0).Item("MontoCobrarSocio")
            Entidad.IdCuentaCobrar = dt.Rows(0).Item("IdCuentaCobrar")
            Entidad.Aplicado = dt.Rows(0).Item("Aplicado")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            entidad.AprobadoPor = dt.rows(0).item("AprobadoPor")
            Entidad.FechaHoraAprobacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraAprobacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudRetiroDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudRetiroDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudRetiroDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudRetiroInsert _
    (ByVal entidad As coo_SolicitudRetiro)

        db.ExecuteNonQuery("coo_SolicitudRetiroInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.NumeroSolicitud _
         , entidad.Fecha _
         , entidad.FechaRetiro _
         , entidad.TipoRetiro _
         , entidad.MotivoRetiro _
         , entidad.SaldoCreditos _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.MontoAhorrado _
         , entidad.MontoAportado _
         , entidad.MontoPropiedadSocio _
         , entidad.LiquidoEntregarSocio _
         , entidad.PendienteCooperativa _
         , entidad.MontoCobrarSocio _
         , entidad.IdCuentaCobrar _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AprobadoPor _
         , entidad.FechaHoraAprobacion _
         )
    End Sub

    Public Sub coo_SolicitudRetiroInsert _
    (ByVal entidad As coo_SolicitudRetiro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.NumeroSolicitud _
         , entidad.Fecha _
         , entidad.FechaRetiro _
         , entidad.TipoRetiro _
         , entidad.MotivoRetiro _
         , entidad.SaldoCreditos _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.MontoAhorrado _
         , entidad.MontoAportado _
         , entidad.MontoPropiedadSocio _
         , entidad.LiquidoEntregarSocio _
         , entidad.PendienteCooperativa _
         , entidad.MontoCobrarSocio _
         , entidad.IdCuentaCobrar _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AprobadoPor _
         , entidad.FechaHoraAprobacion _
         )
    End Sub

    Public Sub coo_SolicitudRetiroUpdate _
    (ByVal entidad As coo_SolicitudRetiro)

        db.ExecuteNonQuery("coo_SolicitudRetiroUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.NumeroSolicitud _
         , entidad.Fecha _
         , entidad.FechaRetiro _
         , entidad.TipoRetiro _
         , entidad.MotivoRetiro _
         , entidad.SaldoCreditos _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.MontoAhorrado _
         , entidad.MontoAportado _
         , entidad.MontoPropiedadSocio _
         , entidad.LiquidoEntregarSocio _
         , entidad.PendienteCooperativa _
         , entidad.MontoCobrarSocio _
         , entidad.IdCuentaCobrar _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AprobadoPor _
         , entidad.FechaHoraAprobacion _
         )
    End Sub

    Public Sub coo_SolicitudRetiroUpdate _
    (ByVal entidad As coo_SolicitudRetiro, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudRetiroUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.NumeroSolicitud _
         , entidad.Fecha _
         , entidad.FechaRetiro _
         , entidad.TipoRetiro _
         , entidad.MotivoRetiro _
         , entidad.SaldoCreditos _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.MontoAhorrado _
         , entidad.MontoAportado _
         , entidad.MontoPropiedadSocio _
         , entidad.LiquidoEntregarSocio _
         , entidad.PendienteCooperativa _
         , entidad.MontoCobrarSocio _
         , entidad.IdCuentaCobrar _
         , entidad.Aplicado _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AprobadoPor _
         , entidad.FechaHoraAprobacion _
         )
    End Sub

#End Region

#Region "coo_DictamenTecnico"
    Public Function coo_DictamenTecnicoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DictamenTecnicoSelectAll").Tables(0)
    End Function

    Public Function coo_DictamenTecnicoSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_DictamenTecnico

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_DictamenTecnicoSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_DictamenTecnico
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.ComentarioProyecto = dt.rows(0).item("ComentarioProyecto")
            entidad.CalidadAsociado = dt.rows(0).item("CalidadAsociado")
            entidad.ValoracionProyecto = dt.rows(0).item("ValoracionProyecto")
            entidad.OtrasCondiciones = dt.rows(0).item("OtrasCondiciones")
            entidad.OrganizacionProduccion = dt.rows(0).item("OrganizacionProduccion")
            entidad.CalidadGarantia = dt.rows(0).item("CalidadGarantia")
            entidad.PropuestaFinanciamiento = dt.rows(0).item("PropuestaFinanciamiento")
            entidad.MontoPropuesto = dt.rows(0).item("MontoPropuesto")
            entidad.CuotasPropuestas = dt.rows(0).item("CuotasPropuestas")
            entidad.MesesGracia = dt.rows(0).item("MesesGracia")
            entidad.FechaAnalisis = dt.rows(0).item("FechaAnalisis")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.FrecuenciaPago = dt.rows(0).item("FrecuenciaPago")
            entidad.ClasificacionDeudor = dt.rows(0).item("ClasificacionDeudor")
            entidad.ClasificacionFiador = dt.rows(0).item("ClasificacionFiador")

        End If
        Return Entidad
    End Function

    Public Sub coo_DictamenTecnicoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_DictamenTecnicoDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenTecnicoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenTecnicoDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenTecnicoInsert _
    (ByVal entidad As coo_DictamenTecnico)

        db.ExecuteNonQuery("coo_DictamenTecnicoInsert", _
         entidad.IdSolicitud _
         , entidad.ComentarioProyecto _
         , entidad.CalidadAsociado _
         , entidad.ValoracionProyecto _
         , entidad.OtrasCondiciones _
         , entidad.OrganizacionProduccion _
         , entidad.CalidadGarantia _
         , entidad.PropuestaFinanciamiento _
         , entidad.MontoPropuesto _
         , entidad.CuotasPropuestas _
         , entidad.MesesGracia _
         , entidad.FechaAnalisis _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.ClasificacionDeudor _
         , entidad.ClasificacionFiador _
         )
    End Sub

    Public Sub coo_DictamenTecnicoInsert _
    (ByVal entidad As coo_DictamenTecnico, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenTecnicoInsert", _
         entidad.IdSolicitud _
         , entidad.ComentarioProyecto _
         , entidad.CalidadAsociado _
         , entidad.ValoracionProyecto _
         , entidad.OtrasCondiciones _
         , entidad.OrganizacionProduccion _
         , entidad.CalidadGarantia _
         , entidad.PropuestaFinanciamiento _
         , entidad.MontoPropuesto _
         , entidad.CuotasPropuestas _
         , entidad.MesesGracia _
         , entidad.FechaAnalisis _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.ClasificacionDeudor _
         , entidad.ClasificacionFiador _
         )
    End Sub

    Public Sub coo_DictamenTecnicoUpdate _
    (ByVal entidad As coo_DictamenTecnico)

        db.ExecuteNonQuery("coo_DictamenTecnicoUpdate", _
         entidad.IdSolicitud _
         , entidad.ComentarioProyecto _
         , entidad.CalidadAsociado _
         , entidad.ValoracionProyecto _
         , entidad.OtrasCondiciones _
         , entidad.OrganizacionProduccion _
         , entidad.CalidadGarantia _
         , entidad.PropuestaFinanciamiento _
         , entidad.MontoPropuesto _
         , entidad.CuotasPropuestas _
         , entidad.MesesGracia _
         , entidad.FechaAnalisis _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.ClasificacionDeudor _
         , entidad.ClasificacionFiador _
         )
    End Sub

    Public Sub coo_DictamenTecnicoUpdate _
    (ByVal entidad As coo_DictamenTecnico, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenTecnicoUpdate", _
         entidad.IdSolicitud _
         , entidad.ComentarioProyecto _
         , entidad.CalidadAsociado _
         , entidad.ValoracionProyecto _
         , entidad.OtrasCondiciones _
         , entidad.OrganizacionProduccion _
         , entidad.CalidadGarantia _
         , entidad.PropuestaFinanciamiento _
         , entidad.MontoPropuesto _
         , entidad.CuotasPropuestas _
         , entidad.MesesGracia _
         , entidad.FechaAnalisis _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.ClasificacionDeudor _
         , entidad.ClasificacionFiador _
         )
    End Sub

#End Region
#Region "coo_DictamenGerencia"
    Public Function coo_DictamenGerenciaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DictamenGerenciaSelectAll").Tables(0)
    End Function

    Public Function coo_DictamenGerenciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_DictamenGerencia

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_DictamenGerenciaSelectByPK", _
         IdSolicitud _
         ).Tables(0)

        Dim Entidad As New coo_DictamenGerencia
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.RecomendacionGerencia = dt.Rows(0).Item("RecomendacionGerencia")
            Entidad.TipoTramite = dt.Rows(0).Item("TipoTramite")
            Entidad.OtrasCondiciones = dt.Rows(0).Item("OtrasCondiciones")

        End If
        Return Entidad
    End Function

    Public Sub coo_DictamenGerenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_DictamenGerenciaDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenGerenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenGerenciaDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenGerenciaInsert _
    (ByVal entidad As coo_DictamenGerencia)

        db.ExecuteNonQuery("coo_DictamenGerenciaInsert", _
         entidad.IdSolicitud _
         , entidad.RecomendacionGerencia _
         , entidad.TipoTramite _
         , entidad.OtrasCondiciones _
         )
    End Sub

    Public Sub coo_DictamenGerenciaInsert _
    (ByVal entidad As coo_DictamenGerencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenGerenciaInsert", _
         entidad.IdSolicitud _
         , entidad.RecomendacionGerencia _
         , entidad.TipoTramite _
         , entidad.OtrasCondiciones _
         )
    End Sub

    Public Sub coo_DictamenGerenciaUpdate _
    (ByVal entidad As coo_DictamenGerencia)

        db.ExecuteNonQuery("coo_DictamenGerenciaUpdate", _
         entidad.IdSolicitud _
         , entidad.RecomendacionGerencia _
         , entidad.TipoTramite _
         , entidad.OtrasCondiciones _
         )
    End Sub

    Public Sub coo_DictamenGerenciaUpdate _
    (ByVal entidad As coo_DictamenGerencia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DictamenGerenciaUpdate", _
         entidad.IdSolicitud _
         , entidad.RecomendacionGerencia _
         , entidad.TipoTramite _
         , entidad.OtrasCondiciones _
         )
    End Sub

#End Region

#Region "coo_Resoluciones"
    Public Function coo_ResolucionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_ResolucionesSelectAll").Tables(0)
    End Function

    Public Function coo_ResolucionesSelectByPK _
      (ByVal IdSolicitud As System.Int32) As coo_Resoluciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_ResolucionesSelectByPK", _
         IdSolicitud _
         ).Tables(0)

        Dim Entidad As New coo_Resoluciones
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.FechaAprobacion = fd.SiEsNulo(dt.Rows(0).Item("FechaAprobacion"), Nothing)
            Entidad.TipoTramite = dt.Rows(0).Item("TipoTramite")
            Entidad.RecomendacionGerente = dt.Rows(0).Item("RecomendacionGerente")
            Entidad.ResolucionGerente = dt.Rows(0).Item("ResolucionGerente")
            Entidad.OtrasGerente = dt.Rows(0).Item("OtrasGerente")
            Entidad.FechaResolucionGerente = dt.Rows(0).Item("FechaResolucionGerente")
            Entidad.TipoResolucionGerente = dt.Rows(0).Item("TipoResolucionGerente")
            Entidad.RecomendacionComite = dt.Rows(0).Item("RecomendacionComite")
            Entidad.ComiteSesion = dt.Rows(0).Item("ComiteSesion")
            Entidad.ComiteActa = dt.Rows(0).Item("ComiteActa")
            Entidad.ComiteResolucion = dt.Rows(0).Item("ComiteResolucion")
            Entidad.OtrasComite = dt.Rows(0).Item("OtrasComite")
            Entidad.FechaResolucionComite = dt.Rows(0).Item("FechaResolucionComite")
            Entidad.TipoResolucionComite = dt.Rows(0).Item("TipoResolucionComite")
            Entidad.RecomendacionConsejo = dt.Rows(0).Item("RecomendacionConsejo")
            Entidad.ConsejoSesion = dt.Rows(0).Item("ConsejoSesion")
            Entidad.ConsejoActa = dt.Rows(0).Item("ConsejoActa")
            Entidad.ConsejoResolucion = dt.Rows(0).Item("ConsejoResolucion")
            Entidad.OtrasConsejo = dt.Rows(0).Item("OtrasConsejo")
            Entidad.FechaResolucionConsejo = dt.Rows(0).Item("FechaResolucionConsejo")
            Entidad.TipoResolucionConsejo = dt.Rows(0).Item("TipoResolucionConsejo")
            Entidad.MontoGerente = dt.Rows(0).Item("MontoGerente")
            Entidad.CuotasGerente = dt.Rows(0).Item("CuotasGerente")
            Entidad.TasaGerente = dt.Rows(0).Item("TasaGerente")
            Entidad.IdFormaPagoGerente = dt.Rows(0).Item("IdFormaPagoGerente")
            Entidad.FrecuenciaPagoGerente = dt.Rows(0).Item("FrecuenciaPagoGerente")
            Entidad.MesGraciaGerente = dt.Rows(0).Item("MesGraciaGerente")
            Entidad.MontoComite = dt.Rows(0).Item("MontoComite")
            Entidad.CuotasComite = dt.Rows(0).Item("CuotasComite")
            Entidad.TasaComite = dt.Rows(0).Item("TasaComite")
            Entidad.IdFormaPagoComite = dt.Rows(0).Item("IdFormaPagoComite")
            Entidad.FrecuenciaPagoComite = dt.Rows(0).Item("FrecuenciaPagoComite")
            Entidad.MesGraciaComite = dt.Rows(0).Item("MesGraciaComite")
            Entidad.MontoConsejo = dt.Rows(0).Item("MontoConsejo")
            Entidad.CuotasConsejo = dt.Rows(0).Item("CuotasConsejo")
            Entidad.TasaConsejo = dt.Rows(0).Item("TasaConsejo")
            Entidad.IdFormaPagoConsejo = dt.Rows(0).Item("IdFormaPagoConsejo")
            Entidad.FrecuenciaPagoConsejo = dt.Rows(0).Item("FrecuenciaPagoConsejo")
            Entidad.MesGraciaConsejo = dt.Rows(0).Item("MesGraciaConsejo")
            Entidad.AutorizaGerencia = dt.Rows(0).Item("AutorizaGerencia")
            Entidad.AutorizaComite = dt.Rows(0).Item("AutorizaComite")
            Entidad.AutorizaConsejo = dt.Rows(0).Item("AutorizaConsejo")
            Entidad.Aprobada = dt.Rows(0).Item("Aprobada")
            Entidad.MontoAprobado = dt.Rows(0).Item("MontoAprobado")
            Entidad.TasaInteresAprobada = dt.Rows(0).Item("TasaInteresAprobada")
            Entidad.NumeroCuotasAprobada = dt.Rows(0).Item("NumeroCuotasAprobada")
            Entidad.IdFormaPagoAprobado = dt.Rows(0).Item("IdFormaPagoAprobado")
            Entidad.FrecuenciaPagoAprobado = dt.Rows(0).Item("FrecuenciaPagoAprobado")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = dt.Rows(0).Item("FechaHoraModificacion")
        End If
        Return Entidad
    End Function

    Public Sub coo_ResolucionesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_ResolucionesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_ResolucionesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ResolucionesDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_ResolucionesInsert(ByVal entidad As coo_Resoluciones)

        db.ExecuteNonQuery("coo_ResolucionesInsert", _
         entidad.IdSolicitud _
         , entidad.IdEstado _
         , entidad.FechaAprobacion _
         , entidad.TipoTramite _
         , entidad.RecomendacionGerente _
         , entidad.ResolucionGerente _
         , entidad.OtrasGerente _
         , entidad.FechaResolucionGerente _
         , entidad.TipoResolucionGerente _
         , entidad.RecomendacionComite _
         , entidad.ComiteSesion _
         , entidad.ComiteActa _
         , entidad.ComiteResolucion _
         , entidad.OtrasComite _
         , entidad.FechaResolucionComite _
         , entidad.TipoResolucionComite _
         , entidad.RecomendacionConsejo _
         , entidad.ConsejoSesion _
         , entidad.ConsejoActa _
         , entidad.ConsejoResolucion _
         , entidad.OtrasConsejo _
         , entidad.FechaResolucionConsejo _
         , entidad.TipoResolucionConsejo _
         , entidad.MontoGerente _
         , entidad.CuotasGerente _
         , entidad.TasaGerente _
         , entidad.IdFormaPagoGerente _
         , entidad.FrecuenciaPagoGerente _
         , entidad.MesGraciaGerente _
         , entidad.MontoComite _
         , entidad.CuotasComite _
         , entidad.TasaComite _
         , entidad.IdFormaPagoComite _
         , entidad.FrecuenciaPagoComite _
         , entidad.MesGraciaComite _
         , entidad.MontoConsejo _
         , entidad.CuotasConsejo _
         , entidad.TasaConsejo _
         , entidad.IdFormaPagoConsejo _
         , entidad.FrecuenciaPagoConsejo _
         , entidad.MesGraciaConsejo _
         , entidad.AutorizaGerencia _
         , entidad.AutorizaComite _
         , entidad.AutorizaConsejo _
         , entidad.Aprobada _
         , entidad.MontoAprobado _
         , entidad.TasaInteresAprobada _
         , entidad.NumeroCuotasAprobada _
         , entidad.IdFormaPagoAprobado _
         , entidad.FrecuenciaPagoAprobado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion)
    End Sub

    Public Sub coo_ResolucionesInsert _
    (ByVal entidad As coo_Resoluciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ResolucionesInsert", _
         entidad.IdSolicitud _
         , entidad.IdEstado _
         , entidad.FechaAprobacion _
         , entidad.TipoTramite _
         , entidad.RecomendacionGerente _
         , entidad.ResolucionGerente _
         , entidad.OtrasGerente _
         , entidad.FechaResolucionGerente _
         , entidad.TipoResolucionGerente _
         , entidad.RecomendacionComite _
         , entidad.ComiteSesion _
         , entidad.ComiteActa _
         , entidad.ComiteResolucion _
         , entidad.OtrasComite _
         , entidad.FechaResolucionComite _
         , entidad.TipoResolucionComite _
         , entidad.RecomendacionConsejo _
         , entidad.ConsejoSesion _
         , entidad.ConsejoActa _
         , entidad.ConsejoResolucion _
         , entidad.OtrasConsejo _
         , entidad.FechaResolucionConsejo _
         , entidad.TipoResolucionConsejo _
         , entidad.MontoGerente _
         , entidad.CuotasGerente _
         , entidad.TasaGerente _
         , entidad.IdFormaPagoGerente _
         , entidad.FrecuenciaPagoGerente _
         , entidad.MesGraciaGerente _
         , entidad.MontoComite _
         , entidad.CuotasComite _
         , entidad.TasaComite _
         , entidad.IdFormaPagoComite _
         , entidad.FrecuenciaPagoComite _
         , entidad.MesGraciaComite _
         , entidad.MontoConsejo _
         , entidad.CuotasConsejo _
         , entidad.TasaConsejo _
         , entidad.IdFormaPagoConsejo _
         , entidad.FrecuenciaPagoConsejo _
         , entidad.MesGraciaConsejo _
         , entidad.AutorizaGerencia _
         , entidad.AutorizaComite _
         , entidad.AutorizaConsejo _
         , entidad.Aprobada _
         , entidad.MontoAprobado _
         , entidad.TasaInteresAprobada _
         , entidad.NumeroCuotasAprobada _
         , entidad.IdFormaPagoAprobado _
         , entidad.FrecuenciaPagoAprobado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion)
    End Sub

    Public Sub coo_ResolucionesUpdate(ByVal entidad As coo_Resoluciones)

        db.ExecuteNonQuery("coo_ResolucionesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdEstado _
         , entidad.FechaAprobacion _
         , entidad.TipoTramite _
         , entidad.RecomendacionGerente _
         , entidad.ResolucionGerente _
         , entidad.OtrasGerente _
         , entidad.FechaResolucionGerente _
         , entidad.TipoResolucionGerente _
         , entidad.RecomendacionComite _
         , entidad.ComiteSesion _
         , entidad.ComiteActa _
         , entidad.ComiteResolucion _
         , entidad.OtrasComite _
         , entidad.FechaResolucionComite _
         , entidad.TipoResolucionComite _
         , entidad.RecomendacionConsejo _
         , entidad.ConsejoSesion _
         , entidad.ConsejoActa _
         , entidad.ConsejoResolucion _
         , entidad.OtrasConsejo _
         , entidad.FechaResolucionConsejo _
         , entidad.TipoResolucionConsejo _
         , entidad.MontoGerente _
         , entidad.CuotasGerente _
         , entidad.TasaGerente _
         , entidad.IdFormaPagoGerente _
         , entidad.FrecuenciaPagoGerente _
         , entidad.MesGraciaGerente _
         , entidad.MontoComite _
         , entidad.CuotasComite _
         , entidad.TasaComite _
         , entidad.IdFormaPagoComite _
         , entidad.FrecuenciaPagoComite _
         , entidad.MesGraciaComite _
         , entidad.MontoConsejo _
         , entidad.CuotasConsejo _
         , entidad.TasaConsejo _
         , entidad.IdFormaPagoConsejo _
         , entidad.FrecuenciaPagoConsejo _
         , entidad.MesGraciaConsejo _
         , entidad.AutorizaGerencia _
         , entidad.AutorizaComite _
         , entidad.AutorizaConsejo _
         , entidad.Aprobada _
         , entidad.MontoAprobado _
         , entidad.TasaInteresAprobada _
         , entidad.NumeroCuotasAprobada _
         , entidad.IdFormaPagoAprobado _
         , entidad.FrecuenciaPagoAprobado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_ResolucionesUpdate(ByVal entidad As coo_Resoluciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_ResolucionesUpdate", _
         entidad.IdSolicitud _
         , entidad.IdEstado _
         , entidad.FechaAprobacion _
         , entidad.TipoTramite _
         , entidad.RecomendacionGerente _
         , entidad.ResolucionGerente _
         , entidad.OtrasGerente _
         , entidad.FechaResolucionGerente _
         , entidad.TipoResolucionGerente _
         , entidad.RecomendacionComite _
         , entidad.ComiteSesion _
         , entidad.ComiteActa _
         , entidad.ComiteResolucion _
         , entidad.OtrasComite _
         , entidad.FechaResolucionComite _
         , entidad.TipoResolucionComite _
         , entidad.RecomendacionConsejo _
         , entidad.ConsejoSesion _
         , entidad.ConsejoActa _
         , entidad.ConsejoResolucion _
         , entidad.OtrasConsejo _
         , entidad.FechaResolucionConsejo _
         , entidad.TipoResolucionConsejo _
         , entidad.MontoGerente _
         , entidad.CuotasGerente _
         , entidad.TasaGerente _
         , entidad.IdFormaPagoGerente _
         , entidad.FrecuenciaPagoGerente _
         , entidad.MesGraciaGerente _
         , entidad.MontoComite _
         , entidad.CuotasComite _
         , entidad.TasaComite _
         , entidad.IdFormaPagoComite _
         , entidad.FrecuenciaPagoComite _
         , entidad.MesGraciaComite _
         , entidad.MontoConsejo _
         , entidad.CuotasConsejo _
         , entidad.TasaConsejo _
         , entidad.IdFormaPagoConsejo _
         , entidad.FrecuenciaPagoConsejo _
         , entidad.MesGraciaConsejo _
         , entidad.AutorizaGerencia _
         , entidad.AutorizaComite _
         , entidad.AutorizaConsejo _
         , entidad.Aprobada _
         , entidad.MontoAprobado _
         , entidad.TasaInteresAprobada _
         , entidad.NumeroCuotasAprobada _
         , entidad.IdFormaPagoAprobado _
         , entidad.FrecuenciaPagoAprobado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion)
    End Sub

#End Region
#Region "coo_SolicitudesDescuentosCuota"
    Public Function coo_SolicitudesDescuentosCuotaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesDescuentosCuotaSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesDescuentosCuotaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesDescuentosCuota

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudesDescuentosCuotaSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudesDescuentosCuota
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdPlanilla = dt.rows(0).item("IdPlanilla")
            entidad.Valor = dt.rows(0).item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesDescuentosCuotaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesDescuentosCuotaDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDescuentosCuotaDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaInsert _
    (ByVal entidad As coo_SolicitudesDescuentosCuota)

        db.ExecuteNonQuery("coo_SolicitudesDescuentosCuotaInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaInsert _
    (ByVal entidad As coo_SolicitudesDescuentosCuota, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDescuentosCuotaInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaUpdate _
    (ByVal entidad As coo_SolicitudesDescuentosCuota)

        db.ExecuteNonQuery("coo_SolicitudesDescuentosCuotaUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaUpdate _
    (ByVal entidad As coo_SolicitudesDescuentosCuota, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDescuentosCuotaUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

#End Region


#Region "coo_DeduccionesPrestamo"
    Public Function coo_DeduccionesPrestamoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DeduccionesPrestamoSelectAll").Tables(0)
    End Function

    Public Function coo_DeduccionesPrestamoSelectByPK(ByVal IdDeduccion As System.Int32) As coo_DeduccionesPrestamo

        Dim dt As DataTable = db.ExecuteDataSet("coo_DeduccionesPrestamoSelectByPK", IdDeduccion).Tables(0)

        Dim Entidad As New coo_DeduccionesPrestamo
        If dt.Rows.Count > 0 Then
            Entidad.IdDeduccion = dt.Rows(0).Item("IdDeduccion")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.AplicaIva = dt.Rows(0).Item("AplicaIva")
            Entidad.TipoCalculo = dt.Rows(0).Item("TipoCalculo")
            Entidad.Valor = dt.Rows(0).Item("Valor")
        End If
        Return Entidad
    End Function

    Public Sub coo_DeduccionesPrestamoDeleteByPK(ByVal IdDeduccion As System.Int32)
        db.ExecuteNonQuery("coo_DeduccionesPrestamoDeleteByPK", IdDeduccion)
    End Sub

    Public Sub coo_DeduccionesPrestamoDeleteByPK _
      (ByVal IdDeduccion As System.Int32, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DeduccionesPrestamoDeleteByPK", _
         IdDeduccion _
         )
    End Sub

    Public Sub coo_DeduccionesPrestamoInsert _
    (ByVal entidad As coo_DeduccionesPrestamo)

        db.ExecuteNonQuery("coo_DeduccionesPrestamoInsert", _
         entidad.IdDeduccion _
         , entidad.Nombre _
         , entidad.IdCuenta _
         , entidad.AplicaIva _
         , entidad.TipoCalculo _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_DeduccionesPrestamoInsert _
    (ByVal entidad As coo_DeduccionesPrestamo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DeduccionesPrestamoInsert", _
         entidad.IdDeduccion _
         , entidad.Nombre _
         , entidad.IdCuenta _
         , entidad.AplicaIva _
         , entidad.TipoCalculo _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_DeduccionesPrestamoUpdate _
    (ByVal entidad As coo_DeduccionesPrestamo)

        db.ExecuteNonQuery("coo_DeduccionesPrestamoUpdate", _
         entidad.IdDeduccion _
         , entidad.Nombre _
         , entidad.IdCuenta _
         , entidad.AplicaIva _
         , entidad.TipoCalculo _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_DeduccionesPrestamoUpdate _
    (ByVal entidad As coo_DeduccionesPrestamo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DeduccionesPrestamoUpdate", _
         entidad.IdDeduccion _
         , entidad.Nombre _
         , entidad.IdCuenta _
         , entidad.AplicaIva _
         , entidad.TipoCalculo _
         , entidad.Valor _
         )
    End Sub

#End Region

#Region "coo_SolicitudFondos"
    Public Function coo_SolicitudFondosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudFondosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudFondosSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      ) As coo_SolicitudFondos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_SolicitudFondosSelectByPK", _
         IdSolicitudFondo _
         ).tables(0)

        Dim Entidad As New coo_SolicitudFondos
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitudFondo = dt.rows(0).item("IdSolicitudFondo")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdDesembolso = dt.rows(0).item("IdDesembolso")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.FechaEntrega = dt.rows(0).item("FechaEntrega")
            entidad.MontoDesembolso = dt.rows(0).item("MontoDesembolso")
            entidad.Capitalizacion = dt.rows(0).item("Capitalizacion")
            entidad.TotalRefinanciamiento = dt.rows(0).item("TotalRefinanciamiento")
            entidad.Aportacion = dt.rows(0).item("Aportacion")
            entidad.TotalOtrasDeducciones = dt.rows(0).item("TotalOtrasDeducciones")
            entidad.Iva = dt.rows(0).item("Iva")
            entidad.Ahorro = dt.rows(0).item("Ahorro")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Entregado = dt.rows(0).item("Entregado")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudFondosDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudFondosDeleteByPK", _
         IdSolicitudFondo _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosDeleteByPK", _
         IdSolicitudFondo _
         )
    End Sub

    Public Sub coo_SolicitudFondosInsert _
    (ByVal entidad As coo_SolicitudFondos)

        db.ExecuteNonQuery("coo_SolicitudFondosInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDesembolso _
         , entidad.IdAsociado _
         , entidad.FechaEntrega _
         , entidad.MontoDesembolso _
         , entidad.Capitalizacion _
         , entidad.TotalRefinanciamiento _
         , entidad.Aportacion _
         , entidad.TotalOtrasDeducciones _
         , entidad.Iva _
         , entidad.Ahorro _
         , entidad.IdCuenta _
         , entidad.Entregado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SolicitudFondosInsert _
    (ByVal entidad As coo_SolicitudFondos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDesembolso _
         , entidad.IdAsociado _
         , entidad.FechaEntrega _
         , entidad.MontoDesembolso _
         , entidad.Capitalizacion _
         , entidad.TotalRefinanciamiento _
         , entidad.Aportacion _
         , entidad.TotalOtrasDeducciones _
         , entidad.Iva _
         , entidad.Ahorro _
         , entidad.IdCuenta _
         , entidad.Entregado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SolicitudFondosUpdate _
    (ByVal entidad As coo_SolicitudFondos)

        db.ExecuteNonQuery("coo_SolicitudFondosUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDesembolso _
         , entidad.IdAsociado _
         , entidad.FechaEntrega _
         , entidad.MontoDesembolso _
         , entidad.Capitalizacion _
         , entidad.TotalRefinanciamiento _
         , entidad.Aportacion _
         , entidad.TotalOtrasDeducciones _
         , entidad.Iva _
         , entidad.Ahorro _
         , entidad.IdCuenta _
         , entidad.Entregado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SolicitudFondosUpdate _
    (ByVal entidad As coo_SolicitudFondos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDesembolso _
         , entidad.IdAsociado _
         , entidad.FechaEntrega _
         , entidad.MontoDesembolso _
         , entidad.Capitalizacion _
         , entidad.TotalRefinanciamiento _
         , entidad.Aportacion _
         , entidad.TotalOtrasDeducciones _
         , entidad.Iva _
         , entidad.Ahorro _
         , entidad.IdCuenta _
         , entidad.Entregado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_SolicitudFondosDeducciones"
    Public Function coo_SolicitudFondosDeduccionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudFondosDeduccionesSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudFondosDeduccionesSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal IdDeduccion As System.Int32 _
      ) As coo_SolicitudFondosDeducciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SolicitudFondosDeduccionesSelectByPK", _
         IdSolicitudFondo _
         , IdSolicitud _
         , IdDeduccion _
         ).Tables(0)

        Dim Entidad As New coo_SolicitudFondosDeducciones
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitudFondo = dt.Rows(0).Item("IdSolicitudFondo")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdDeduccion = dt.Rows(0).Item("IdDeduccion")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudFondosDeduccionesDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal IdDeduccion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudFondosDeduccionesDeleteByPK", _
         IdSolicitudFondo _
         , IdSolicitud _
         , IdDeduccion _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal IdDeduccion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosDeduccionesDeleteByPK", _
         IdSolicitudFondo _
         , IdSolicitud _
         , IdDeduccion _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesInsert _
    (ByVal entidad As coo_SolicitudFondosDeducciones)

        db.ExecuteNonQuery("coo_SolicitudFondosDeduccionesInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDeduccion _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesInsert _
    (ByVal entidad As coo_SolicitudFondosDeducciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosDeduccionesInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDeduccion _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesUpdate _
    (ByVal entidad As coo_SolicitudFondosDeducciones)

        db.ExecuteNonQuery("coo_SolicitudFondosDeduccionesUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDeduccion _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesUpdate _
    (ByVal entidad As coo_SolicitudFondosDeducciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosDeduccionesUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdSolicitud _
         , entidad.IdDeduccion _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_SolicitudFondosRefinancia"
    Public Function coo_SolicitudFondosRefinanciaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudFondosRefinanciaSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudFondosRefinanciaSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Idsolicitud As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      ) As coo_SolicitudFondosRefinancia

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SolicitudFondosRefinanciaSelectByPK", _
         IdSolicitudFondo _
         , Idsolicitud _
         , IdPrestamo _
         ).Tables(0)

        Dim Entidad As New coo_SolicitudFondosRefinancia
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitudFondo = dt.Rows(0).Item("IdSolicitudFondo")
            Entidad.Idsolicitud = dt.Rows(0).Item("Idsolicitud")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.SaldoCapital = dt.Rows(0).Item("SaldoCapital")
            Entidad.SaldoInteres = dt.Rows(0).Item("SaldoInteres")
            Entidad.SaldoInteresMoratorio = dt.Rows(0).Item("SaldoInteresMoratorio")
            Entidad.SaldoSeguro = dt.Rows(0).Item("SaldoSeguro")
            Entidad.SaldoOtros = dt.Rows(0).Item("SaldoOtros")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudFondosRefinanciaDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Idsolicitud As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudFondosRefinanciaDeleteByPK", _
         IdSolicitudFondo _
         , Idsolicitud _
         , IdPrestamo _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Idsolicitud As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosRefinanciaDeleteByPK", _
         IdSolicitudFondo _
         , Idsolicitud _
         , IdPrestamo _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaInsert _
    (ByVal entidad As coo_SolicitudFondosRefinancia)

        db.ExecuteNonQuery("coo_SolicitudFondosRefinanciaInsert", _
         entidad.IdSolicitudFondo _
         , entidad.Idsolicitud _
         , entidad.IdPrestamo _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaInsert _
    (ByVal entidad As coo_SolicitudFondosRefinancia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosRefinanciaInsert", _
         entidad.IdSolicitudFondo _
         , entidad.Idsolicitud _
         , entidad.IdPrestamo _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaUpdate _
    (ByVal entidad As coo_SolicitudFondosRefinancia)

        db.ExecuteNonQuery("coo_SolicitudFondosRefinanciaUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.Idsolicitud _
         , entidad.IdPrestamo _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaUpdate _
    (ByVal entidad As coo_SolicitudFondosRefinancia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudFondosRefinanciaUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.Idsolicitud _
         , entidad.IdPrestamo _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

#End Region
#Region "coo_Prestamos"
    Public Function coo_PrestamosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      ) As coo_Prestamos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_PrestamosSelectByPK", _
         IdPrestamo _
         ).tables(0)

        Dim Entidad As New coo_Prestamos
        If dt.Rows.Count > 0 Then
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdPresEfectivo = dt.rows(0).item("IdPresEfectivo")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.MontoAprobado = dt.rows(0).item("MontoAprobado")
            entidad.FechaAprobado = dt.rows(0).item("FechaAprobado")
            entidad.FechaOtorgado = dt.rows(0).item("FechaOtorgado")
            entidad.FechaPrimerPago = dt.rows(0).item("FechaPrimerPago")
            entidad.MontoDesembolsado = dt.rows(0).item("MontoDesembolsado")
            entidad.MesesGracia = dt.rows(0).item("MesesGracia")
            Entidad.DiasMoraGracia = dt.Rows(0).Item("DiasMoraGracia")
            Entidad.IdTipoAplicacion = fd.SiEsNulo(dt.Rows(0).Item("IdTipoAplicacion"), Nothing)
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.FrecuenciaPago = dt.rows(0).item("FrecuenciaPago")
            entidad.NumCuotas = dt.rows(0).item("NumCuotas")
            entidad.TasaInteres = dt.rows(0).item("TasaInteres")
            entidad.TasaMora = dt.rows(0).item("TasaMora")
            entidad.ValorCuota = dt.rows(0).item("ValorCuota")
            entidad.CuotaAportacion = dt.rows(0).item("CuotaAportacion")
            entidad.CuotaAhorro = dt.rows(0).item("CuotaAhorro")
            entidad.CuotaManejo = dt.rows(0).item("CuotaManejo")
            entidad.CuotaOtros = dt.rows(0).item("CuotaOtros")
            entidad.CuotaGestion = dt.rows(0).item("CuotaGestion")
            entidad.TasaSeguro = dt.rows(0).item("TasaSeguro")
            entidad.FechaVencimiento = dt.rows(0).item("FechaVencimiento")
            entidad.IdDepartamento = dt.rows(0).item("IdDepartamento")
            entidad.IdMunicipio = dt.rows(0).item("IdMunicipio")
            entidad.IdCanton = dt.rows(0).item("IdCanton")
            entidad.IdTecnico = dt.rows(0).item("IdTecnico")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.IdFuente = dt.rows(0).item("IdFuente")
            entidad.IdTipoCartera = dt.rows(0).item("IdTipoCartera")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.IdTipoPrestamo = dt.rows(0).item("IdTipoPrestamo")
            Entidad.IdEstado = dt.Rows(0).Item("IdEstado")
            Entidad.TipoCuota = dt.Rows(0).Item("TipoCuota")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosDeleteByPK", _
         IdPrestamo _
         )
    End Sub

    Public Sub coo_PrestamosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDeleteByPK", _
         IdPrestamo _
         )
    End Sub

    Public Sub coo_PrestamosInsert _
    (ByVal entidad As coo_Prestamos)

        db.ExecuteNonQuery("coo_PrestamosInsert", _
         entidad.IdPrestamo _
         , entidad.IdSolicitud _
         , entidad.IdPresEfectivo _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.MontoAprobado _
         , entidad.FechaAprobado _
         , entidad.FechaOtorgado _
         , entidad.FechaPrimerPago _
         , entidad.MontoDesembolsado _
         , entidad.MesesGracia _
         , entidad.DiasMoraGracia _
           , entidad.IdTipoAplicacion _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.NumCuotas _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.ValorCuota _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.CuotaGestion _
         , entidad.TasaSeguro _
         , entidad.FechaVencimiento _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.IdTecnico _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCartera _
         , entidad.IdSucursal _
         , entidad.IdTipoPrestamo _
         , entidad.IdEstado _
         , entidad.TipoCuota _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_PrestamosInsert _
    (ByVal entidad As coo_Prestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosInsert", _
         entidad.IdPrestamo _
         , entidad.IdSolicitud _
         , entidad.IdPresEfectivo _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.MontoAprobado _
         , entidad.FechaAprobado _
         , entidad.FechaOtorgado _
         , entidad.FechaPrimerPago _
         , entidad.MontoDesembolsado _
         , entidad.MesesGracia _
         , entidad.DiasMoraGracia _
           , entidad.IdTipoAplicacion _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.NumCuotas _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.ValorCuota _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.CuotaGestion _
         , entidad.TasaSeguro _
         , entidad.FechaVencimiento _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.IdTecnico _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCartera _
         , entidad.IdSucursal _
         , entidad.IdTipoPrestamo _
         , entidad.IdEstado _
         , entidad.TipoCuota _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.AplicaDescuento _
         )
    End Sub

    Public Sub coo_PrestamosUpdate _
    (ByVal entidad As coo_Prestamos)

        db.ExecuteNonQuery("coo_PrestamosUpdate", _
         entidad.IdPrestamo _
         , entidad.IdSolicitud _
         , entidad.IdPresEfectivo _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.MontoAprobado _
         , entidad.FechaAprobado _
         , entidad.FechaOtorgado _
         , entidad.FechaPrimerPago _
         , entidad.MontoDesembolsado _
         , entidad.MesesGracia _
         , entidad.DiasMoraGracia _
           , entidad.IdTipoAplicacion _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.NumCuotas _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.ValorCuota _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.CuotaGestion _
         , entidad.TasaSeguro _
         , entidad.FechaVencimiento _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.IdTecnico _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCartera _
         , entidad.IdSucursal _
         , entidad.IdTipoPrestamo _
         , entidad.IdEstado _
         , entidad.TipoCuota _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_PrestamosUpdate _
    (ByVal entidad As coo_Prestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosUpdate", _
         entidad.IdPrestamo _
         , entidad.IdSolicitud _
         , entidad.IdPresEfectivo _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.MontoAprobado _
         , entidad.FechaAprobado _
         , entidad.FechaOtorgado _
         , entidad.FechaPrimerPago _
         , entidad.MontoDesembolsado _
         , entidad.MesesGracia _
         , entidad.DiasMoraGracia _
           , entidad.IdTipoAplicacion _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.NumCuotas _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.ValorCuota _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.CuotaGestion _
         , entidad.TasaSeguro _
         , entidad.FechaVencimiento _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.IdCanton _
         , entidad.IdTecnico _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCartera _
         , entidad.IdSucursal _
         , entidad.IdTipoPrestamo _
         , entidad.IdEstado _
         , entidad.TipoCuota _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_PrestamosDetalleDescuentos"
    Public Function coo_PrestamosDetalleDescuentosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosDetalleDescuentosSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosDetalleDescuentosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As coo_PrestamosDetalleDescuentos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_PrestamosDetalleDescuentosSelectByPK", _
         IdPrestamo _
         , IdDetalle _
         ).tables(0)

        Dim Entidad As New coo_PrestamosDetalleDescuentos
        If dt.Rows.Count > 0 Then
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdDetalle = dt.rows(0).item("IdDetalle")
            entidad.IdPlanilla = dt.rows(0).item("IdPlanilla")
            entidad.Valor = dt.rows(0).item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosDetalleDescuentosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosDetalleDescuentosDeleteByPK", _
         IdPrestamo _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleDescuentosDeleteByPK", _
         IdPrestamo _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosInsert _
    (ByVal entidad As coo_PrestamosDetalleDescuentos)

        db.ExecuteNonQuery("coo_PrestamosDetalleDescuentosInsert", _
         entidad.IdPrestamo _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosInsert _
    (ByVal entidad As coo_PrestamosDetalleDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleDescuentosInsert", _
         entidad.IdPrestamo _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosUpdate _
    (ByVal entidad As coo_PrestamosDetalleDescuentos)

        db.ExecuteNonQuery("coo_PrestamosDetalleDescuentosUpdate", _
         entidad.IdPrestamo _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosUpdate _
    (ByVal entidad As coo_PrestamosDetalleDescuentos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleDescuentosUpdate", _
         entidad.IdPrestamo _
         , entidad.IdDetalle _
         , entidad.IdPlanilla _
         , entidad.Valor _
         )
    End Sub

#End Region

#Region "coo_PrestamosDetalle"
    Public Function coo_PrestamosDetalleSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosDetalleSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosDetalleSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_PrestamosDetalle

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PrestamosDetalleSelectByPK", _
         IdPrestamo _
         , IdMov _
         ).Tables(0)

        Dim Entidad As New coo_PrestamosDetalle
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdMov = dt.Rows(0).Item("IdMov")
            Entidad.TipoAplicacion = dt.Rows(0).Item("TipoAplicacion")
            Entidad.ReferenciaPago = dt.Rows(0).Item("ReferenciaPago")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.FechaContable = dt.Rows(0).Item("FechaContable")
            Entidad.ImportePagado = dt.Rows(0).Item("ImportePagado")
            Entidad.CapitalPagado = dt.Rows(0).Item("CapitalPagado")
            Entidad.SaldoCapital = dt.Rows(0).Item("SaldoCapital")
            Entidad.DiasCalcInteres = dt.Rows(0).Item("DiasCalcInteres")
            Entidad.DiasCalcMora = dt.Rows(0).Item("DiasCalcMora")
            Entidad.InteresPagado = dt.Rows(0).Item("InteresPagado")
            Entidad.InteresPendiente = dt.Rows(0).Item("InteresPendiente")
            Entidad.InteresMoraPagado = dt.Rows(0).Item("InteresMoraPagado")
            Entidad.InteresMoraPendiente = dt.Rows(0).Item("InteresMoraPendiente")
            Entidad.ValorSeguroPagado = dt.Rows(0).Item("ValorSeguroPagado")
            Entidad.ValorSeguroPendiente = dt.Rows(0).Item("ValorSeguroPendiente")
            Entidad.ManejoPagado = dt.Rows(0).Item("ManejoPagado")
            Entidad.ManejoPendiente = dt.Rows(0).Item("ManejoPendiente")
            Entidad.OtrosPagado = dt.Rows(0).Item("OtrosPagado")
            Entidad.OtrosPendiente = dt.Rows(0).Item("OtrosPendiente")
            Entidad.CuotaAhorro = dt.Rows(0).Item("CuotaAhorro")
            Entidad.CuotaAportacion = dt.Rows(0).Item("CuotaAportacion")
            Entidad.ComisionCobranza = dt.Rows(0).Item("ComisionCobranza")
            Entidad.Gestion = dt.Rows(0).Item("Gestion")
            Entidad.TasaInteres = dt.Rows(0).Item("TasaInteres")
            Entidad.TasaInteresMora = dt.Rows(0).Item("TasaInteresMora")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosDetalleDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosDetalleDeleteByPK", _
         IdPrestamo _
         , IdMov _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleDeleteByPK", _
         IdPrestamo _
         , IdMov _
         )
    End Sub

    Public Sub coo_PrestamosDetalleInsert _
    (ByVal entidad As coo_PrestamosDetalle)

        db.ExecuteNonQuery("coo_PrestamosDetalleInsert", _
         entidad.IdPrestamo _
         , entidad.IdMov _
         , entidad.TipoAplicacion _
         , entidad.ReferenciaPago _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.ImportePagado _
         , entidad.CapitalPagado _
         , entidad.SaldoCapital _
         , entidad.DiasCalcInteres _
         , entidad.DiasCalcMora _
         , entidad.InteresPagado _
         , entidad.InteresPendiente _
         , entidad.InteresMoraPagado _
         , entidad.InteresMoraPendiente _
         , entidad.ValorSeguroPagado _
         , entidad.ValorSeguroPendiente _
         , entidad.ManejoPagado _
         , entidad.ManejoPendiente _
         , entidad.OtrosPagado _
         , entidad.OtrosPendiente _
         , entidad.CuotaAhorro _
         , entidad.CuotaAportacion _
         , entidad.ComisionCobranza _
         , entidad.Gestion _
         , entidad.TasaInteres _
         , entidad.TasaInteresMora _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PrestamosDetalleInsert _
    (ByVal entidad As coo_PrestamosDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleInsert", _
         entidad.IdPrestamo _
         , entidad.IdMov _
         , entidad.TipoAplicacion _
         , entidad.ReferenciaPago _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.ImportePagado _
         , entidad.CapitalPagado _
         , entidad.SaldoCapital _
         , entidad.DiasCalcInteres _
         , entidad.DiasCalcMora _
         , entidad.InteresPagado _
         , entidad.InteresPendiente _
         , entidad.InteresMoraPagado _
         , entidad.InteresMoraPendiente _
         , entidad.ValorSeguroPagado _
         , entidad.ValorSeguroPendiente _
         , entidad.ManejoPagado _
         , entidad.ManejoPendiente _
         , entidad.OtrosPagado _
         , entidad.OtrosPendiente _
         , entidad.CuotaAhorro _
         , entidad.CuotaAportacion _
         , entidad.ComisionCobranza _
         , entidad.Gestion _
         , entidad.TasaInteres _
         , entidad.TasaInteresMora _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PrestamosDetalleUpdate _
    (ByVal entidad As coo_PrestamosDetalle)

        db.ExecuteNonQuery("coo_PrestamosDetalleUpdate", _
         entidad.IdPrestamo _
         , entidad.IdMov _
         , entidad.TipoAplicacion _
         , entidad.ReferenciaPago _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.ImportePagado _
         , entidad.CapitalPagado _
         , entidad.SaldoCapital _
         , entidad.DiasCalcInteres _
         , entidad.DiasCalcMora _
         , entidad.InteresPagado _
         , entidad.InteresPendiente _
         , entidad.InteresMoraPagado _
         , entidad.InteresMoraPendiente _
         , entidad.ValorSeguroPagado _
         , entidad.ValorSeguroPendiente _
         , entidad.ManejoPagado _
         , entidad.ManejoPendiente _
         , entidad.OtrosPagado _
         , entidad.OtrosPendiente _
         , entidad.CuotaAhorro _
         , entidad.CuotaAportacion _
         , entidad.ComisionCobranza _
         , entidad.Gestion _
         , entidad.TasaInteres _
         , entidad.TasaInteresMora _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PrestamosDetalleUpdate _
    (ByVal entidad As coo_PrestamosDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDetalleUpdate", _
         entidad.IdPrestamo _
         , entidad.IdMov _
         , entidad.TipoAplicacion _
         , entidad.ReferenciaPago _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.ImportePagado _
         , entidad.CapitalPagado _
         , entidad.SaldoCapital _
         , entidad.DiasCalcInteres _
         , entidad.DiasCalcMora _
         , entidad.InteresPagado _
         , entidad.InteresPendiente _
         , entidad.InteresMoraPagado _
         , entidad.InteresMoraPendiente _
         , entidad.ValorSeguroPagado _
         , entidad.ValorSeguroPendiente _
         , entidad.ManejoPagado _
         , entidad.ManejoPendiente _
         , entidad.OtrosPagado _
         , entidad.OtrosPendiente _
         , entidad.CuotaAhorro _
         , entidad.CuotaAportacion _
         , entidad.ComisionCobranza _
         , entidad.Gestion _
         , entidad.TasaInteres _
         , entidad.TasaInteresMora _
         , entidad.IdFormaPago _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_PrestamosEfectivo"
    Public Function coo_PrestamosEfectivoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosEfectivoSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosEfectivoSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_PrestamosEfectivo

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_PrestamosEfectivoSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_PrestamosEfectivo
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.NumVale = dt.rows(0).item("NumVale")
            entidad.FechaSolicitud = dt.rows(0).item("FechaSolicitud")
            entidad.FechaPosibleDesembolso = dt.rows(0).item("FechaPosibleDesembolso")
            entidad.MontoSolicitado = dt.rows(0).item("MontoSolicitado")
            entidad.TasaInteres = dt.rows(0).item("TasaInteres")
            entidad.NumeroCuotas = dt.rows(0).item("NumeroCuotas")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.FrecuenciaPago = dt.rows(0).item("FrecuenciaPago")
            entidad.FechaPrimerPago = dt.rows(0).item("FechaPrimerPago")
            entidad.IdPlanilla = dt.rows(0).item("IdPlanilla")
            entidad.TipoCuota = dt.rows(0).item("TipoCuota")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.IdFuente = dt.rows(0).item("IdFuente")
            entidad.IdTipoCredito = dt.rows(0).item("IdTipoCredito")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.Aprobada = dt.rows(0).item("Aprobada")
            entidad.ValorCuota = dt.rows(0).item("ValorCuota")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            Entidad.Anulado = dt.Rows(0).Item("Anulado")
            Entidad.AplicaDescuento = dt.Rows(0).Item("AplicaDescuento")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosEfectivoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosEfectivoDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosEfectivoDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoInsert _
    (ByVal entidad As coo_PrestamosEfectivo)

        db.ExecuteNonQuery("coo_PrestamosEfectivoInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.NumVale _
         , entidad.FechaSolicitud _
         , entidad.FechaPosibleDesembolso _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.FechaPrimerPago _
         , entidad.IdPlanilla _
         , entidad.TipoCuota _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.ValorCuota _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Anulado _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoInsert _
    (ByVal entidad As coo_PrestamosEfectivo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosEfectivoInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.NumVale _
         , entidad.FechaSolicitud _
         , entidad.FechaPosibleDesembolso _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.FechaPrimerPago _
         , entidad.IdPlanilla _
         , entidad.TipoCuota _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.ValorCuota _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Anulado _
         , entidad.AplicaDescuento _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoUpdate _
    (ByVal entidad As coo_PrestamosEfectivo)

        db.ExecuteNonQuery("coo_PrestamosEfectivoUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.NumVale _
         , entidad.FechaSolicitud _
         , entidad.FechaPosibleDesembolso _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.FechaPrimerPago _
         , entidad.IdPlanilla _
         , entidad.TipoCuota _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.ValorCuota _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Anulado _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoUpdate _
    (ByVal entidad As coo_PrestamosEfectivo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosEfectivoUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.NumVale _
         , entidad.FechaSolicitud _
         , entidad.FechaPosibleDesembolso _
         , entidad.MontoSolicitado _
         , entidad.TasaInteres _
         , entidad.NumeroCuotas _
         , entidad.IdFormaPago _
         , entidad.FrecuenciaPago _
         , entidad.FechaPrimerPago _
         , entidad.IdPlanilla _
         , entidad.TipoCuota _
         , entidad.IdLinea _
         , entidad.IdFuente _
         , entidad.IdTipoCredito _
         , entidad.IdSucursal _
         , entidad.Aprobada _
         , entidad.ValorCuota _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Anulado _
         , entidad.AplicaDescuento _
         )
    End Sub

#End Region

#Region "coo_PrestamosTraslado"
    Public Function coo_PrestamosTrasladoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosTrasladoSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosTrasladoSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdTraslado As System.Int32 _
      ) As coo_PrestamosTraslado

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PrestamosTrasladoSelectByPK", _
         IdPrestamo _
         , IdTraslado _
         ).Tables(0)

        Dim Entidad As New coo_PrestamosTraslado
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdTraslado = dt.Rows(0).Item("IdTraslado")
            Entidad.TipoTraslado = dt.Rows(0).Item("TipoTraslado")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.SaldoPrestamo = dt.Rows(0).Item("SaldoPrestamo")
            Entidad.SaldoInteres = dt.Rows(0).Item("SaldoInteres")
            Entidad.SaldoInteresMoratorio = dt.Rows(0).Item("SaldoInteresMoratorio")
            Entidad.TasaInteresTraslado = dt.Rows(0).Item("TasaInteresTraslado")
            Entidad.TasaMoraTraslado = dt.Rows(0).Item("TasaMoraTraslado")
            Entidad.CostasProcesales = dt.Rows(0).Item("CostasProcesales")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosTrasladoDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdTraslado As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosTrasladoDeleteByPK", _
         IdPrestamo _
         , IdTraslado _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdTraslado As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosTrasladoDeleteByPK", _
         IdPrestamo _
         , IdTraslado _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoInsert _
    (ByVal entidad As coo_PrestamosTraslado)

        db.ExecuteNonQuery("coo_PrestamosTrasladoInsert", _
         entidad.IdPrestamo _
         , entidad.IdTraslado _
         , entidad.TipoTraslado _
         , entidad.Fecha _
         , entidad.SaldoPrestamo _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.TasaInteresTraslado _
         , entidad.TasaMoraTraslado _
         , entidad.CostasProcesales _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoInsert _
    (ByVal entidad As coo_PrestamosTraslado, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosTrasladoInsert", _
         entidad.IdPrestamo _
         , entidad.IdTraslado _
         , entidad.TipoTraslado _
         , entidad.Fecha _
         , entidad.SaldoPrestamo _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.TasaInteresTraslado _
         , entidad.TasaMoraTraslado _
         , entidad.CostasProcesales _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoUpdate _
    (ByVal entidad As coo_PrestamosTraslado)

        db.ExecuteNonQuery("coo_PrestamosTrasladoUpdate", _
         entidad.IdPrestamo _
         , entidad.IdTraslado _
         , entidad.TipoTraslado _
         , entidad.Fecha _
         , entidad.SaldoPrestamo _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.TasaInteresTraslado _
         , entidad.TasaMoraTraslado _
         , entidad.CostasProcesales _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoUpdate _
    (ByVal entidad As coo_PrestamosTraslado, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosTrasladoUpdate", _
         entidad.IdPrestamo _
         , entidad.IdTraslado _
         , entidad.TipoTraslado _
         , entidad.Fecha _
         , entidad.SaldoPrestamo _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMoratorio _
         , entidad.TasaInteresTraslado _
         , entidad.TasaMoraTraslado _
         , entidad.CostasProcesales _
         )
    End Sub

#End Region

#Region "coo_PrestamosPlanPagos"
    Public Function coo_PrestamosPlanPagosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosPlanPagosSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosPlanPagosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal NumCuota As System.Int32 _
      ) As coo_PrestamosPlanPagos

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PrestamosPlanPagosSelectByPK", _
         IdPrestamo _
         , NumCuota _
         ).Tables(0)

        Dim Entidad As New coo_PrestamosPlanPagos
        If dt.Rows.Count > 0 Then
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.NumCuota = dt.Rows(0).Item("NumCuota")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.TasaInteres = dt.Rows(0).Item("TasaInteres")
            Entidad.TasaMora = dt.Rows(0).Item("TasaMora")
            Entidad.Interes = dt.Rows(0).Item("Interes")
            Entidad.Capital = dt.Rows(0).Item("Capital")
            Entidad.Saldo = dt.Rows(0).Item("Saldo")
            Entidad.CuotaAportacion = dt.Rows(0).Item("CuotaAportacion")
            Entidad.CuotaAhorro = dt.Rows(0).Item("CuotaAhorro")
            Entidad.CuotaManejo = dt.Rows(0).Item("CuotaManejo")
            Entidad.CuotaOtros = dt.Rows(0).Item("CuotaOtros")
            Entidad.TasaSeguro = dt.Rows(0).Item("TasaSeguro")
            Entidad.CuotaSeguro = dt.Rows(0).Item("CuotaSeguro")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosPlanPagosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal NumCuota As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosPlanPagosDeleteByPK", _
         IdPrestamo _
         , NumCuota _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal NumCuota As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosPlanPagosDeleteByPK", _
         IdPrestamo _
         , NumCuota _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosInsert _
    (ByVal entidad As coo_PrestamosPlanPagos)

        db.ExecuteNonQuery("coo_PrestamosPlanPagosInsert", _
         entidad.IdPrestamo _
         , entidad.NumCuota _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.Interes _
         , entidad.Capital _
         , entidad.Saldo _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.TasaSeguro _
         , entidad.CuotaSeguro _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosInsert _
    (ByVal entidad As coo_PrestamosPlanPagos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosPlanPagosInsert", _
         entidad.IdPrestamo _
         , entidad.NumCuota _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.Interes _
         , entidad.Capital _
         , entidad.Saldo _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.TasaSeguro _
         , entidad.CuotaSeguro _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosUpdate _
    (ByVal entidad As coo_PrestamosPlanPagos)

        db.ExecuteNonQuery("coo_PrestamosPlanPagosUpdate", _
         entidad.IdPrestamo _
         , entidad.NumCuota _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.Interes _
         , entidad.Capital _
         , entidad.Saldo _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.TasaSeguro _
         , entidad.CuotaSeguro _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosUpdate _
    (ByVal entidad As coo_PrestamosPlanPagos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosPlanPagosUpdate", _
         entidad.IdPrestamo _
         , entidad.NumCuota _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.TasaInteres _
         , entidad.TasaMora _
         , entidad.Interes _
         , entidad.Capital _
         , entidad.Saldo _
         , entidad.CuotaAportacion _
         , entidad.CuotaAhorro _
         , entidad.CuotaManejo _
         , entidad.CuotaOtros _
         , entidad.TasaSeguro _
         , entidad.CuotaSeguro _
         )
    End Sub

    Public Sub coo_PrestamosPlanPagosDeleteByPrestamo _
  (ByVal IdPrestamo As System.Int32)
        db.ExecuteNonQuery("coo_PrestamosPlanPagosDeleteByPrestamo", IdPrestamo)
    End Sub
#End Region

#Region "coo_PrestamosDesembolso"
    Public Function coo_PrestamosDesembolsoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamosDesembolsoSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamosDesembolsoSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      ) As coo_PrestamosDesembolso

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_PrestamosDesembolsoSelectByPK", _
         IdSolicitudFondo _
         , IdPrestamo _
         ).tables(0)

        Dim Entidad As New coo_PrestamosDesembolso
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitudFondo = dt.rows(0).item("IdSolicitudFondo")
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdDesembolso = dt.rows(0).item("IdDesembolso")
            entidad.MontoDesembolso = dt.rows(0).item("MontoDesembolso")
            entidad.LiquidoDesembolso = dt.rows(0).item("LiquidoDesembolso")
            entidad.NumeroPrestamo = dt.rows(0).item("NumeroPrestamo")
            entidad.NumeroComprobante = dt.rows(0).item("NumeroComprobante")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.TipoDesembolso = dt.rows(0).item("TipoDesembolso")
            entidad.FechaMovimiento = dt.rows(0).item("FechaMovimiento")
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")

        End If
        Return Entidad
    End Function
    Public Function coo_PrestamosDesembolsoSelectByPK2 _
  (ByVal IdSolicitudFondo As System.Int32 _
  ) As coo_PrestamosDesembolso

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PrestamosDesembolsoSelectByPK2", _
         IdSolicitudFondo _
         ).Tables(0)

        Dim Entidad As New coo_PrestamosDesembolso
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitudFondo = dt.Rows(0).Item("IdSolicitudFondo")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.IdDesembolso = dt.Rows(0).Item("IdDesembolso")
            Entidad.MontoDesembolso = dt.Rows(0).Item("MontoDesembolso")
            Entidad.LiquidoDesembolso = dt.Rows(0).Item("LiquidoDesembolso")
            Entidad.NumeroPrestamo = dt.Rows(0).Item("NumeroPrestamo")
            Entidad.NumeroComprobante = dt.Rows(0).Item("NumeroComprobante")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.TipoDesembolso = dt.Rows(0).Item("TipoDesembolso")
            Entidad.FechaMovimiento = dt.Rows(0).Item("FechaMovimiento")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamosDesembolsoDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamosDesembolsoDeleteByPK", _
         IdSolicitudFondo _
         , IdPrestamo _
         )
    End Sub
    Public Sub coo_PrestamosDetalleDescuentosDeleteByIdPrestamo _
  (ByVal IdPrestamo As System.Int32)
        Dim sSQL As String = "delete from coo_PrestamosDetalleDescuentos  where IdPrestamo= " & IdPrestamo
        db.ExecuteNonQuery(CommandType.Text, sSQL)
    End Sub
    '

    Public Sub coo_PrestamosDesembolsoDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDesembolsoDeleteByPK", _
         IdSolicitudFondo _
         , IdPrestamo _
         )
    End Sub

    Public Sub coo_PrestamosDesembolsoInsert _
    (ByVal entidad As coo_PrestamosDesembolso)

        db.ExecuteNonQuery("coo_PrestamosDesembolsoInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdPrestamo _
         , entidad.IdDesembolso _
         , entidad.MontoDesembolso _
         , entidad.LiquidoDesembolso _
         , entidad.NumeroPrestamo _
         , entidad.NumeroComprobante _
         , entidad.IdCuenta _
         , entidad.TipoDesembolso _
         , entidad.FechaMovimiento _
         , entidad.IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosDesembolsoInsert _
    (ByVal entidad As coo_PrestamosDesembolso, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDesembolsoInsert", _
         entidad.IdSolicitudFondo _
         , entidad.IdPrestamo _
         , entidad.IdDesembolso _
         , entidad.MontoDesembolso _
         , entidad.LiquidoDesembolso _
         , entidad.NumeroPrestamo _
         , entidad.NumeroComprobante _
         , entidad.IdCuenta _
         , entidad.TipoDesembolso _
         , entidad.FechaMovimiento _
         , entidad.IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosDesembolsoUpdate _
    (ByVal entidad As coo_PrestamosDesembolso)

        db.ExecuteNonQuery("coo_PrestamosDesembolsoUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdPrestamo _
         , entidad.IdDesembolso _
         , entidad.MontoDesembolso _
         , entidad.LiquidoDesembolso _
         , entidad.NumeroPrestamo _
         , entidad.NumeroComprobante _
         , entidad.IdCuenta _
         , entidad.TipoDesembolso _
         , entidad.FechaMovimiento _
         , entidad.IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosDesembolsoUpdate _
    (ByVal entidad As coo_PrestamosDesembolso, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamosDesembolsoUpdate", _
         entidad.IdSolicitudFondo _
         , entidad.IdPrestamo _
         , entidad.IdDesembolso _
         , entidad.MontoDesembolso _
         , entidad.LiquidoDesembolso _
         , entidad.NumeroPrestamo _
         , entidad.NumeroComprobante _
         , entidad.IdCuenta _
         , entidad.TipoDesembolso _
         , entidad.FechaMovimiento _
         , entidad.IdSolicitud _
         )
    End Sub

#End Region
#Region "coo_abonoTelefonia"
    Public Function coo_abonoTelefoniaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_abonoTelefoniaSelectAll").Tables(0)
    End Function

    Public Function coo_abonoTelefoniaSelectByPK(ByVal IdAsociado As Integer) As coo_abonoTelefonia

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_abonoTelefoniaSelectByPK", IdAsociado _
            ).Tables(0)

        Dim Entidad As New coo_abonoTelefonia
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.FechaAplicacion = dt.Rows(0).Item("FechaAplicacion")
            Entidad.Telefono = dt.Rows(0).Item("Telefono")
            Entidad.NAbono = dt.Rows(0).Item("NAbono")
            Entidad.ValorTotalAbono = dt.Rows(0).Item("ValorTotalAbono")
            Entidad.Total = dt.Rows(0).Item("Total")

        End If
        Return Entidad
    End Function

    Public Sub coo_abonoTelefoniaDelete _
  (ByVal FechaAplicacion As System.DateTime _
  )

        db.ExecuteNonQuery("coo_abonoTelefoniaDelete", _
         FechaAplicacion _
         )
    End Sub
    Public Sub coo_abonoTelefoniaInsert _
    (ByVal entidad As coo_abonoTelefonia)

        db.ExecuteNonQuery("coo_abonoTelefoniaInsert", _
            entidad.IdAsociado _
            , entidad.FechaAplicacion _
            , entidad.Telefono _
            , entidad.NAbono _
            , entidad.ValorTotalAbono _
            , entidad.Total _
            )
    End Sub

    Public Sub coo_abonoTelefoniaInsert _
    (ByVal entidad As coo_abonoTelefonia, Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_abonoTelefoniaInsert", _
            entidad.IdAsociado _
            , entidad.FechaAplicacion _
            , entidad.Telefono _
            , entidad.NAbono _
            , entidad.ValorTotalAbono _
            , entidad.Total _
            )
    End Sub

    Public Sub coo_abonoTelefoniaUpdate _
    (ByVal entidad As coo_abonoTelefonia)

        db.ExecuteNonQuery("coo_abonoTelefoniaUpdate", _
            entidad.IdAsociado _
            , entidad.FechaAplicacion _
            , entidad.Telefono _
            , entidad.NAbono _
            , entidad.ValorTotalAbono _
            , entidad.Total _
            )
    End Sub

    Public Sub coo_abonoTelefoniaUpdate _
    (ByVal entidad As coo_abonoTelefonia, Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_abonoTelefoniaUpdate", _
            entidad.IdAsociado _
            , entidad.FechaAplicacion _
            , entidad.Telefono _
            , entidad.NAbono _
            , entidad.ValorTotalAbono _
            , entidad.Total _
            )
    End Sub

#End Region

#Region "coo_DescuentoTelefoniaPendiente"
    Public Function coo_DescuentoTelefoniaPendienteSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DescuentoTelefoniaPendienteSelectAll").Tables(0)
    End Function

    Public Function coo_DescuentoTelefoniaPendienteSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      ) As coo_DescuentoTelefoniaPendiente

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_DescuentoTelefoniaPendienteSelectByPK", _
         IdAsociado _
         ).Tables(0)

        Dim Entidad As New coo_DescuentoTelefoniaPendiente
        If dt.Rows.Count > 0 Then
            Entidad.IdAsociado = dt.Rows(0).Item("IdAsociado")
            Entidad.FechaAplicacion = dt.Rows(0).Item("FechaAplicacion")
            Entidad.Telefono = dt.Rows(0).Item("Telefono")
            Entidad.Nfactura = dt.Rows(0).Item("Nfactura")
            Entidad.ValorTotalFactura = dt.Rows(0).Item("ValorTotalFactura")
            Entidad.ValorIva = dt.Rows(0).Item("ValorIva")
            Entidad.ValorSeguridad = dt.Rows(0).Item("ValorSeguridad")
            Entidad.Valorcomicion = dt.Rows(0).Item("Valorcomicion")
            Entidad.Total = dt.Rows(0).Item("Total")
        End If
        Return Entidad
    End Function

    Public Sub coo_DescuentoTelefoniaPendienteDelete _
      (ByVal FechaAplicacion As System.DateTime _
      )

        db.ExecuteNonQuery("coo_DescuentoTelefoniaPendienteDelete", _
         FechaAplicacion _
         )
    End Sub
    Public Sub coo_DescuentoTelefoniaPendienteDelete _
      (ByVal FechaAplicacion As System.DateTime _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DescuentoTelefoniaPendienteDelete", _
         FechaAplicacion _
         )
    End Sub

    Public Sub coo_DescuentoTelefoniaPendienteInsert _
    (ByVal entidad As coo_DescuentoTelefoniaPendiente)

        db.ExecuteNonQuery("coo_DescuentoTelefoniaPendienteInsert", _
         entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.Telefono _
         , entidad.Nfactura _
         , entidad.ValorTotalFactura _
         , entidad.ValorIva _
         , entidad.ValorSeguridad _
         , entidad.Valorcomicion _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_DescuentoTelefoniaPendienteInsert _
    (ByVal entidad As coo_DescuentoTelefoniaPendiente, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DescuentoTelefoniaPendienteInsert", _
         entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.Telefono _
         , entidad.Nfactura _
         , entidad.ValorTotalFactura _
         , entidad.ValorIva _
         , entidad.ValorSeguridad _
         , entidad.Valorcomicion _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_DescuentoTelefoniaPendienteUpdate _
    (ByVal entidad As coo_DescuentoTelefoniaPendiente)

        db.ExecuteNonQuery("coo_DescuentoTelefoniaPendienteUpdate", _
         entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.Telefono _
         , entidad.Nfactura _
         , entidad.ValorTotalFactura _
         , entidad.ValorIva _
         , entidad.ValorSeguridad _
         , entidad.Valorcomicion _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_DescuentoTelefoniaPendienteUpdate _
    (ByVal entidad As coo_DescuentoTelefoniaPendiente, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_DescuentoTelefoniaPendienteUpdate", _
         entidad.IdAsociado _
         , entidad.FechaAplicacion _
         , entidad.Telefono _
         , entidad.Nfactura _
         , entidad.ValorTotalFactura _
         , entidad.ValorIva _
         , entidad.ValorSeguridad _
         , entidad.Valorcomicion _
         , entidad.Total _
         )
    End Sub

#End Region
#Region "coo_SolicitudesEmisionDesembolso"
    Public Function coo_SolicitudesEmisionDesembolsoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesEmisionDesembolsoSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesEmisionDesembolsoSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdEmision As System.Int32 _
      ) As coo_SolicitudesEmisionDesembolso

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SolicitudesEmisionDesembolsoSelectByPK", _
         IdSolicitud _
         , IdEmision _
         ).Tables(0)

        Dim Entidad As New coo_SolicitudesEmisionDesembolso
        If dt.Rows.Count > 0 Then
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.IdEmision = dt.Rows(0).Item("IdEmision")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesEmisionDesembolsoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdEmision As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesEmisionDesembolsoDeleteByPK", _
         IdSolicitud _
         , IdEmision _
         )
    End Sub

    Public Sub coo_SolicitudesEmisionDesembolsoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdEmision As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesEmisionDesembolsoDeleteByPK", _
         IdSolicitud _
         , IdEmision _
         )
    End Sub

    Public Sub coo_SolicitudesEmisionDesembolsoInsert _
    (ByVal entidad As coo_SolicitudesEmisionDesembolso)

        db.ExecuteNonQuery("coo_SolicitudesEmisionDesembolsoInsert", _
         entidad.IdSolicitud _
         , entidad.IdEmision _
         , entidad.Nombre _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesEmisionDesembolsoInsert _
    (ByVal entidad As coo_SolicitudesEmisionDesembolso, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesEmisionDesembolsoInsert", _
         entidad.IdSolicitud _
         , entidad.IdEmision _
         , entidad.Nombre _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesEmisionDesembolsoUpdate _
    (ByVal entidad As coo_SolicitudesEmisionDesembolso)

        db.ExecuteNonQuery("coo_SolicitudesEmisionDesembolsoUpdate", _
         entidad.IdSolicitud _
         , entidad.IdEmision _
         , entidad.Nombre _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesEmisionDesembolsoUpdate _
    (ByVal entidad As coo_SolicitudesEmisionDesembolso, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesEmisionDesembolsoUpdate", _
         entidad.IdSolicitud _
         , entidad.IdEmision _
         , entidad.Nombre _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_Pignoraciones"
    Public Function coo_PignoracionesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PignoracionesSelectAll").Tables(0)
    End Function

    Public Function coo_PignoracionesSelectByPK _
      (ByVal IdPignoracion As System.Int32 _
      ) As coo_Pignoraciones

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_PignoracionesSelectByPK", _
         IdPignoracion _
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
            Entidad.FechaReversion = dt.Rows(0).Item("FechaReversion")
            Entidad.RevertidoPor = dt.Rows(0).Item("RevertidoPor")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_PignoracionesDeleteByPK _
      (ByVal IdPignoracion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PignoracionesDeleteByPK", _
         IdPignoracion _
         )
    End Sub

    Public Sub coo_PignoracionesDeleteByPK _
      (ByVal IdPignoracion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PignoracionesDeleteByPK", _
         IdPignoracion _
         )
    End Sub

    Public Sub coo_PignoracionesInsert _
    (ByVal entidad As coo_Pignoraciones)

        db.ExecuteNonQuery("coo_PignoracionesInsert", _
         entidad.IdPignoracion _
         , entidad.IdSolicitud _
         , entidad.IdCuenta _
         , entidad.IdPrestamo _
         , entidad.IdAsociado _
         , entidad.FechaPignoracion _
         , entidad.Valor _
         , entidad.Activa _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.RevertidoPor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PignoracionesInsert _
    (ByVal entidad As coo_Pignoraciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PignoracionesInsert", _
         entidad.IdPignoracion _
         , entidad.IdSolicitud _
         , entidad.IdCuenta _
         , entidad.IdPrestamo _
         , entidad.IdAsociado _
         , entidad.FechaPignoracion _
         , entidad.Valor _
         , entidad.Activa _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.RevertidoPor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PignoracionesUpdate _
    (ByVal entidad As coo_Pignoraciones)

        db.ExecuteNonQuery("coo_PignoracionesUpdate", _
         entidad.IdPignoracion _
         , entidad.IdSolicitud _
         , entidad.IdCuenta _
         , entidad.IdPrestamo _
         , entidad.IdAsociado _
         , entidad.FechaPignoracion _
         , entidad.Valor _
         , entidad.Activa _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.RevertidoPor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_PignoracionesUpdate _
    (ByVal entidad As coo_Pignoraciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PignoracionesUpdate", _
         entidad.IdPignoracion _
         , entidad.IdSolicitud _
         , entidad.IdCuenta _
         , entidad.IdPrestamo _
         , entidad.IdAsociado _
         , entidad.FechaPignoracion _
         , entidad.Valor _
         , entidad.Activa _
         , entidad.Manual _
         , entidad.FechaReversion _
         , entidad.RevertidoPor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_CorteCaja"
    Public Function coo_CorteCajaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CorteCajaSelectAll").Tables(0)
    End Function

    Public Function coo_CorteCajaSelectByPK _
      (ByVal IdCorte As System.Int32 _
      ) As coo_CorteCaja

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_CorteCajaSelectByPK", _
         IdCorte _
         ).Tables(0)

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

    Public Sub coo_CorteCajaDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CorteCajaDeleteByPK", _
         IdCorte _
         )
    End Sub

    Public Sub coo_CorteCajaDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaDeleteByPK", _
         IdCorte _
         )
    End Sub

    Public Sub coo_CorteCajaInsert _
    (ByVal entidad As coo_CorteCaja)

        db.ExecuteNonQuery("coo_CorteCajaInsert", _
         entidad.IdCorte _
         , entidad.Fecha _
         , entidad.IdUsuario _
         , entidad.IdSucursal _
         , entidad.CantidadFacturas _
         , entidad.FacturasAnuladas _
         )
    End Sub

    Public Sub coo_CorteCajaInsert _
    (ByVal entidad As coo_CorteCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaInsert", _
         entidad.IdCorte _
         , entidad.Fecha _
         , entidad.IdUsuario _
         , entidad.IdSucursal _
         , entidad.CantidadFacturas _
         , entidad.FacturasAnuladas _
         )
    End Sub

    Public Sub coo_CorteCajaUpdate _
    (ByVal entidad As coo_CorteCaja)

        db.ExecuteNonQuery("coo_CorteCajaUpdate", _
         entidad.IdCorte _
         , entidad.Fecha _
         , entidad.IdUsuario _
         , entidad.IdSucursal _
         , entidad.CantidadFacturas _
         , entidad.FacturasAnuladas _
         )
    End Sub

    Public Sub coo_CorteCajaUpdate _
    (ByVal entidad As coo_CorteCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaUpdate", _
         entidad.IdCorte _
         , entidad.Fecha _
         , entidad.IdUsuario _
         , entidad.IdSucursal _
         , entidad.CantidadFacturas _
         , entidad.FacturasAnuladas _
         )
    End Sub

#End Region
#Region "coo_CorteCajaArqueo"
    Public Function coo_CorteCajaArqueoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CorteCajaArqueoSelectAll").Tables(0)
    End Function

    Public Function coo_CorteCajaArqueoSelectByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      ) As coo_CorteCajaArqueo

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_CorteCajaArqueoSelectByPK", _
         IdCorte _
         , IdDenominacion _
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

    Public Sub coo_CorteCajaArqueoDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_CorteCajaArqueoDeleteByPK", _
         IdCorte _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaArqueoDeleteByPK", _
         IdCorte _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoInsert _
    (ByVal entidad As coo_CorteCajaArqueo)

        db.ExecuteNonQuery("coo_CorteCajaArqueoInsert", _
         entidad.IdCorte _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoInsert _
    (ByVal entidad As coo_CorteCajaArqueo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaArqueoInsert", _
         entidad.IdCorte _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoUpdate _
    (ByVal entidad As coo_CorteCajaArqueo)

        db.ExecuteNonQuery("coo_CorteCajaArqueoUpdate", _
         entidad.IdCorte _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoUpdate _
    (ByVal entidad As coo_CorteCajaArqueo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaArqueoUpdate", _
         entidad.IdCorte _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

#End Region
#Region "coo_SeguimientoCobros"
    Public Function coo_SeguimientoCobrosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SeguimientoCobrosSelectAll").Tables(0)
    End Function

    Public Function coo_SeguimientoCobrosSelectByPK _
      (ByVal IdSeguimiento As System.Int32 _
      ) As coo_SeguimientoCobros

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SeguimientoCobrosSelectByPK", _
         IdSeguimiento _
         ).Tables(0)

        Dim Entidad As New coo_SeguimientoCobros
        If dt.Rows.Count > 0 Then
            Entidad.IdSeguimiento = dt.Rows(0).Item("IdSeguimiento")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.TipoCarta = dt.Rows(0).Item("TipoCarta")
            Entidad.Saldo = dt.Rows(0).Item("Saldo")
            Entidad.Acuerdos = dt.Rows(0).Item("Acuerdos")
            Entidad.FechaVencimiento = dt.Rows(0).Item("FechaVencimiento")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FHCreacion = dt.Rows(0).Item("FHCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_SeguimientoCobrosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SeguimientoCobrosDeleteByPK", _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoCobrosDeleteByPK", _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosInsert _
    (ByVal entidad As coo_SeguimientoCobros)

        db.ExecuteNonQuery("coo_SeguimientoCobrosInsert", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.TipoCarta _
         , entidad.Saldo _
         , entidad.Acuerdos _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosInsert _
    (ByVal entidad As coo_SeguimientoCobros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoCobrosInsert", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.TipoCarta _
         , entidad.Saldo _
         , entidad.Acuerdos _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosUpdate _
    (ByVal entidad As coo_SeguimientoCobros)

        db.ExecuteNonQuery("coo_SeguimientoCobrosUpdate", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.TipoCarta _
         , entidad.Saldo _
         , entidad.Acuerdos _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosUpdate _
    (ByVal entidad As coo_SeguimientoCobros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoCobrosUpdate", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.TipoCarta _
         , entidad.Saldo _
         , entidad.Acuerdos _
         , entidad.FechaVencimiento _
         , entidad.CreadoPor _
         , entidad.FHCreacion _
         )
    End Sub

#End Region
#Region "coo_SeguimientoPrestamos"
    Public Function coo_SeguimientoPrestamosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SeguimientoPrestamosSelectAll").Tables(0)
    End Function

    Public Function coo_SeguimientoPrestamosSelectByPK _
      (ByVal IdSeguimiento As System.Int32 _
      ) As coo_SeguimientoPrestamos

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SeguimientoPrestamosSelectByPK", _
         IdSeguimiento _
         ).Tables(0)

        Dim Entidad As New coo_SeguimientoPrestamos
        If dt.Rows.Count > 0 Then
            Entidad.IdSeguimiento = dt.Rows(0).Item("IdSeguimiento")
            Entidad.IdPrestamo = dt.Rows(0).Item("IdPrestamo")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.Saldo = dt.Rows(0).Item("Saldo")
            Entidad.Seguimiento = dt.Rows(0).Item("Seguimiento")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_SeguimientoPrestamosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SeguimientoPrestamosDeleteByPK", _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoPrestamosDeleteByPK", _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosInsert _
    (ByVal entidad As coo_SeguimientoPrestamos)

        db.ExecuteNonQuery("coo_SeguimientoPrestamosInsert", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.Saldo _
         , entidad.Seguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosInsert _
    (ByVal entidad As coo_SeguimientoPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoPrestamosInsert", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.Saldo _
         , entidad.Seguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosUpdate _
    (ByVal entidad As coo_SeguimientoPrestamos)

        db.ExecuteNonQuery("coo_SeguimientoPrestamosUpdate", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.Saldo _
         , entidad.Seguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosUpdate _
    (ByVal entidad As coo_SeguimientoPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SeguimientoPrestamosUpdate", _
         entidad.IdSeguimiento _
         , entidad.IdPrestamo _
         , entidad.Fecha _
         , entidad.Saldo _
         , entidad.Seguimiento _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_AplicarReintegros"
    Public Function coo_AplicarReintegrosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AplicarReintegrosSelectAll").Tables(0)
    End Function

    Public Function coo_AplicarReintegrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_AplicarReintegros

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AplicarReintegrosSelectByPK", _
         IdSolicitud _
         ).tables(0)

        Dim Entidad As New coo_AplicarReintegros
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.TipoAplicacion = dt.rows(0).item("TipoAplicacion")
            entidad.FechaSolicitud = dt.rows(0).item("FechaSolicitud")
            entidad.ValorReintegro = dt.rows(0).item("ValorReintegro")
            entidad.IdPlanillaReintegro = dt.rows(0).item("IdPlanillaReintegro")
            entidad.FechaPlanilla = dt.rows(0).item("FechaPlanilla")
            entidad.SaldoAportacion = dt.rows(0).item("SaldoAportacion")
            entidad.AportacionAumentar = dt.rows(0).item("AportacionAumentar")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            entidad.ModificadoPor = dt.rows(0).item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            entidad.Autorizado = dt.rows(0).item("Autorizado")
            entidad.AutorizadoPor = dt.rows(0).item("AutorizadoPor")
            Entidad.FechaHoraAutorizacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraAutorizacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_AplicarReintegrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AplicarReintegrosDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_AplicarReintegrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosDeleteByPK", _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_AplicarReintegrosInsert _
    (ByVal entidad As coo_AplicarReintegros)

        db.ExecuteNonQuery("coo_AplicarReintegrosInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.TipoAplicacion _
         , entidad.FechaSolicitud _
         , entidad.ValorReintegro _
         , entidad.IdPlanillaReintegro _
         , entidad.FechaPlanilla _
         , entidad.SaldoAportacion _
         , entidad.AportacionAumentar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_AplicarReintegrosInsert _
    (ByVal entidad As coo_AplicarReintegros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosInsert", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.TipoAplicacion _
         , entidad.FechaSolicitud _
         , entidad.ValorReintegro _
         , entidad.IdPlanillaReintegro _
         , entidad.FechaPlanilla _
         , entidad.SaldoAportacion _
         , entidad.AportacionAumentar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_AplicarReintegrosUpdate _
    (ByVal entidad As coo_AplicarReintegros)

        db.ExecuteNonQuery("coo_AplicarReintegrosUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.TipoAplicacion _
         , entidad.FechaSolicitud _
         , entidad.ValorReintegro _
         , entidad.IdPlanillaReintegro _
         , entidad.FechaPlanilla _
         , entidad.SaldoAportacion _
         , entidad.AportacionAumentar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

    Public Sub coo_AplicarReintegrosUpdate _
    (ByVal entidad As coo_AplicarReintegros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosUpdate", _
         entidad.IdSolicitud _
         , entidad.IdAsociado _
         , entidad.Numero _
         , entidad.TipoAplicacion _
         , entidad.FechaSolicitud _
         , entidad.ValorReintegro _
         , entidad.IdPlanillaReintegro _
         , entidad.FechaPlanilla _
         , entidad.SaldoAportacion _
         , entidad.AportacionAumentar _
         , entidad.Observaciones _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         , entidad.Autorizado _
         , entidad.AutorizadoPor _
         , entidad.FechaHoraAutorizacion _
         )
    End Sub

#End Region

#Region "coo_AplicarReintegrosAhorros"
    Public Function coo_AplicarReintegrosAhorrosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AplicarReintegrosAhorrosSelectAll").Tables(0)
    End Function

    Public Function coo_AplicarReintegrosAhorrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_AplicarReintegrosAhorros

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AplicarReintegrosAhorrosSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_AplicarReintegrosAhorros
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.Valor = dt.rows(0).item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_AplicarReintegrosAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AplicarReintegrosAhorrosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosAhorrosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosInsert _
    (ByVal entidad As coo_AplicarReintegrosAhorros)

        db.ExecuteNonQuery("coo_AplicarReintegrosAhorrosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosInsert _
    (ByVal entidad As coo_AplicarReintegrosAhorros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosAhorrosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosUpdate _
    (ByVal entidad As coo_AplicarReintegrosAhorros)

        db.ExecuteNonQuery("coo_AplicarReintegrosAhorrosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosUpdate _
    (ByVal entidad As coo_AplicarReintegrosAhorros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosAhorrosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdCuenta _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_AplicarReintegrosPrestamos"
    Public Function coo_AplicarReintegrosPrestamosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_AplicarReintegrosPrestamosSelectAll").Tables(0)
    End Function

    Public Function coo_AplicarReintegrosPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_AplicarReintegrosPrestamos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_AplicarReintegrosPrestamosSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_AplicarReintegrosPrestamos
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoActual = dt.rows(0).item("SaldoActual")
            entidad.ValorAbono = dt.rows(0).item("ValorAbono")

        End If
        Return Entidad
    End Function

    Public Sub coo_AplicarReintegrosPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_AplicarReintegrosPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosPrestamosDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosInsert _
    (ByVal entidad As coo_AplicarReintegrosPrestamos)

        db.ExecuteNonQuery("coo_AplicarReintegrosPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosInsert _
    (ByVal entidad As coo_AplicarReintegrosPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosPrestamosInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosUpdate _
    (ByVal entidad As coo_AplicarReintegrosPrestamos)

        db.ExecuteNonQuery("coo_AplicarReintegrosPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosUpdate _
    (ByVal entidad As coo_AplicarReintegrosPrestamos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_AplicarReintegrosPrestamosUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoActual _
         , entidad.ValorAbono _
         )
    End Sub

#End Region

#Region "coo_OperacionesNumerario"
    Public Function coo_OperacionesNumerarioSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OperacionesNumerarioSelectAll").Tables(0)
    End Function

    Public Function coo_OperacionesNumerarioSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      ) As coo_OperacionesNumerario

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_OperacionesNumerarioSelectByPK", _
         IdOperacion _
         ).Tables(0)

        Dim Entidad As New coo_OperacionesNumerario
        If dt.Rows.Count > 0 Then
            Entidad.IdOperacion = dt.Rows(0).Item("IdOperacion")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.FechaContable = dt.Rows(0).Item("FechaContable")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.IdTipoOperacion = dt.Rows(0).Item("IdTipoOperacion")
            Entidad.TipoOperacion = dt.Rows(0).Item("TipoOperacion")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.Observaciones = dt.Rows(0).Item("Observaciones")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_OperacionesNumerarioDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_OperacionesNumerarioDeleteByPK", _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioDeleteByPK", _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioInsert _
    (ByVal entidad As coo_OperacionesNumerario)

        db.ExecuteNonQuery("coo_OperacionesNumerarioInsert", _
         entidad.IdOperacion _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.IdTipoOperacion _
         , entidad.TipoOperacion _
         , entidad.Valor _
         , entidad.Observaciones _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioInsert _
    (ByVal entidad As coo_OperacionesNumerario, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioInsert", _
         entidad.IdOperacion _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.IdTipoOperacion _
         , entidad.TipoOperacion _
         , entidad.Valor _
         , entidad.Observaciones _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioUpdate _
    (ByVal entidad As coo_OperacionesNumerario)

        db.ExecuteNonQuery("coo_OperacionesNumerarioUpdate", _
         entidad.IdOperacion _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.IdTipoOperacion _
         , entidad.TipoOperacion _
         , entidad.Valor _
         , entidad.Observaciones _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioUpdate _
    (ByVal entidad As coo_OperacionesNumerario, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioUpdate", _
         entidad.IdOperacion _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.IdTipoOperacion _
         , entidad.TipoOperacion _
         , entidad.Valor _
         , entidad.Observaciones _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_OperacionesNumerarioArqueo"
    Public Function coo_OperacionesNumerarioArqueoSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OperacionesNumerarioArqueoSelectAll").Tables(0)
    End Function

    Public Function coo_OperacionesNumerarioArqueoSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      ) As coo_OperacionesNumerarioArqueo

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_OperacionesNumerarioArqueoSelectByPK", _
         IdOperacion _
         , IdDenominacion _
         ).Tables(0)

        Dim Entidad As New coo_OperacionesNumerarioArqueo
        If dt.Rows.Count > 0 Then
            Entidad.IdOperacion = dt.Rows(0).Item("IdOperacion")
            Entidad.IdDenominacion = dt.Rows(0).Item("IdDenominacion")
            Entidad.Cantidad = dt.Rows(0).Item("Cantidad")
            Entidad.Total = dt.Rows(0).Item("Total")

        End If
        Return Entidad
    End Function

    Public Sub coo_OperacionesNumerarioArqueoDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_OperacionesNumerarioArqueoDeleteByPK", _
         IdOperacion _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioArqueoDeleteByPK", _
         IdOperacion _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoInsert _
    (ByVal entidad As coo_OperacionesNumerarioArqueo)

        db.ExecuteNonQuery("coo_OperacionesNumerarioArqueoInsert", _
         entidad.IdOperacion _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoInsert _
    (ByVal entidad As coo_OperacionesNumerarioArqueo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioArqueoInsert", _
         entidad.IdOperacion _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoUpdate _
    (ByVal entidad As coo_OperacionesNumerarioArqueo)

        db.ExecuteNonQuery("coo_OperacionesNumerarioArqueoUpdate", _
         entidad.IdOperacion _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoUpdate _
    (ByVal entidad As coo_OperacionesNumerarioArqueo, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioArqueoUpdate", _
         entidad.IdOperacion _
         , entidad.IdDenominacion _
         , entidad.Cantidad _
         , entidad.Total _
         )
    End Sub

#End Region
#Region "coo_OperacionesNumerarioCheques"
    Public Function coo_OperacionesNumerarioChequesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OperacionesNumerarioChequesSelectAll").Tables(0)
    End Function

    Public Function coo_OperacionesNumerarioChequesSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      ) As coo_OperacionesNumerarioCheques

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_OperacionesNumerarioChequesSelectByPK", _
         IdOperacion _
         , NumeroCuenta _
         , NumeroCheque _
         ).Tables(0)

        Dim Entidad As New coo_OperacionesNumerarioCheques
        If dt.Rows.Count > 0 Then
            Entidad.IdOperacion = dt.Rows(0).Item("IdOperacion")
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroCheque = dt.Rows(0).Item("NumeroCheque")
            Entidad.NombreBanco = dt.Rows(0).Item("NombreBanco")
            Entidad.AnombreDe = dt.Rows(0).Item("AnombreDe")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_OperacionesNumerarioChequesDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      )

        db.ExecuteNonQuery("coo_OperacionesNumerarioChequesDeleteByPK", _
         IdOperacion _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioChequesDeleteByPK", _
         IdOperacion _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesInsert _
    (ByVal entidad As coo_OperacionesNumerarioCheques)

        db.ExecuteNonQuery("coo_OperacionesNumerarioChequesInsert", _
         entidad.IdOperacion _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesInsert _
    (ByVal entidad As coo_OperacionesNumerarioCheques, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioChequesInsert", _
         entidad.IdOperacion _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesUpdate _
    (ByVal entidad As coo_OperacionesNumerarioCheques)

        db.ExecuteNonQuery("coo_OperacionesNumerarioChequesUpdate", _
         entidad.IdOperacion _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesUpdate _
    (ByVal entidad As coo_OperacionesNumerarioCheques, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesNumerarioChequesUpdate", _
         entidad.IdOperacion _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_TiposOperacionNumerario"
    Public Function coo_TiposOperacionNumerarioSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_TiposOperacionNumerarioSelectAll").Tables(0)
    End Function

    Public Function coo_TiposOperacionNumerarioSelectByPK _
      (ByVal IdTipoOperacion As System.Int32 _
      ) As coo_TiposOperacionNumerario

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_TiposOperacionNumerarioSelectByPK", _
         IdTipoOperacion _
         ).Tables(0)

        Dim Entidad As New coo_TiposOperacionNumerario
        If dt.Rows.Count > 0 Then
            Entidad.IdTipoOperacion = dt.Rows(0).Item("IdTipoOperacion")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.TipoOperacion = dt.Rows(0).Item("TipoOperacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_TiposOperacionNumerarioDeleteByPK _
      (ByVal IdTipoOperacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_TiposOperacionNumerarioDeleteByPK", _
         IdTipoOperacion _
         )
    End Sub

    Public Sub coo_TiposOperacionNumerarioDeleteByPK _
      (ByVal IdTipoOperacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposOperacionNumerarioDeleteByPK", _
         IdTipoOperacion _
         )
    End Sub

    Public Sub coo_TiposOperacionNumerarioInsert _
    (ByVal entidad As coo_TiposOperacionNumerario)

        db.ExecuteNonQuery("coo_TiposOperacionNumerarioInsert", _
         entidad.IdTipoOperacion _
         , entidad.Nombre _
         , entidad.TipoOperacion _
         )
    End Sub

    Public Sub coo_TiposOperacionNumerarioInsert _
    (ByVal entidad As coo_TiposOperacionNumerario, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposOperacionNumerarioInsert", _
         entidad.IdTipoOperacion _
         , entidad.Nombre _
         , entidad.TipoOperacion _
         )
    End Sub

    Public Sub coo_TiposOperacionNumerarioUpdate _
    (ByVal entidad As coo_TiposOperacionNumerario)

        db.ExecuteNonQuery("coo_TiposOperacionNumerarioUpdate", _
         entidad.IdTipoOperacion _
         , entidad.Nombre _
         , entidad.TipoOperacion _
         )
    End Sub

    Public Sub coo_TiposOperacionNumerarioUpdate _
    (ByVal entidad As coo_TiposOperacionNumerario, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_TiposOperacionNumerarioUpdate", _
         entidad.IdTipoOperacion _
         , entidad.Nombre _
         , entidad.TipoOperacion _
         )
    End Sub

#End Region
#Region "coo_Documentos"
    Public Function coo_DocumentosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_DocumentosSelectAll").Tables(0)
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

    Public Sub coo_DocumentosDeleteByPK(ByVal Documento As String)
        db.ExecuteNonQuery("coo_DocumentosDeleteByPK", Documento)
    End Sub

    Public Sub coo_DocumentosDeleteByPK(ByVal Documento As String, ByVal Transaccion As DbTransaction)
        db.ExecuteNonQuery(Transaccion, "coo_DocumentosDeleteByPK", Documento)
    End Sub

    Public Sub coo_DocumentosInsert(ByVal entidad As coo_Documentos)
        db.ExecuteNonQuery("coo_DocumentosInsert", entidad.Documento, entidad.Contenido)
    End Sub

    Public Sub coo_DocumentosInsert(ByVal entidad As coo_Documentos, ByVal Transaccion As DbTransaction)
        db.ExecuteNonQuery(Transaccion, "coo_DocumentosInsert", entidad.Documento, entidad.Contenido)
    End Sub

    Public Sub coo_DocumentosUpdate(ByVal entidad As coo_Documentos)
        db.ExecuteNonQuery("coo_DocumentosUpdate", entidad.Documento, entidad.Contenido)
    End Sub

    Public Sub coo_DocumentosUpdate(ByVal entidad As coo_Documentos, ByVal Transaccion As DbTransaction)
        db.ExecuteNonQuery(Transaccion, "coo_DocumentosUpdate", entidad.Documento, entidad.Contenido)
    End Sub

#End Region

#Region "com_Compras"
    Public Function com_ComprasSelectAll() As DataTable
        Return db.ExecuteDataSet("com_ComprasSelectAll").Tables(0)
    End Function

    Public Function com_ComprasSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As com_Compras

        Dim dt As DataTable
        dt = db.ExecuteDataSet("com_ComprasSelectByPK", _
         IdComprobante _
         ).Tables(0)

        Dim Entidad As New com_Compras
        If dt.Rows.Count > 0 Then
            Entidad.IdComprobante = dt.Rows(0).Item("IdComprobante")
            Entidad.IdTipoComprobante = dt.Rows(0).Item("IdTipoComprobante")
            Entidad.Correlativo = dt.Rows(0).Item("Correlativo")
            Entidad.Serie = dt.Rows(0).Item("Serie")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.FechaContable = dt.Rows(0).Item("FechaContable")
            Entidad.IdProveedor = dt.Rows(0).Item("IdProveedor")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.Nrc = dt.Rows(0).Item("Nrc")
            Entidad.Nit = dt.Rows(0).Item("Nit")
            Entidad.Direccion = dt.Rows(0).Item("Direccion")
            Entidad.Giro = dt.Rows(0).Item("Giro")
            Entidad.IdFormaPago = dt.Rows(0).Item("IdFormaPago")
            Entidad.NumOrdenCompra = dt.Rows(0).Item("NumOrdenCompra")
            Entidad.DiasCredito = dt.Rows(0).Item("DiasCredito")
            Entidad.FechaVencimiento = dt.Rows(0).Item("FechaVencimiento")
            Entidad.IdTipoCompra = dt.Rows(0).Item("IdTipoCompra")
            Entidad.TotalExento = dt.Rows(0).Item("TotalExento")
            Entidad.TotalAfecto = dt.Rows(0).Item("TotalAfecto")
            Entidad.TotalIva = dt.Rows(0).Item("TotalIva")
            Entidad.TotalImpuesto1 = dt.Rows(0).Item("TotalImpuesto1")
            Entidad.TotalImpuesto2 = dt.Rows(0).Item("TotalImpuesto2")
            Entidad.TotalComprobante = dt.Rows(0).Item("TotalComprobante")
            Entidad.SaldoActual = dt.Rows(0).Item("SaldoActual")
            Entidad.IdSucursal = dt.Rows(0).Item("IdSucursal")
            Entidad.IdBodega = dt.Rows(0).Item("IdBodega")
            Entidad.IdOrigenCompra = dt.Rows(0).Item("IdOrigenCompra")
            Entidad.AplicadaInventario = dt.Rows(0).Item("AplicadaInventario")
            Entidad.ExcluirLibro = dt.Rows(0).Item("ExcluirLibro")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)
            Entidad.IdLiquidacion = dt.Rows(0).Item("IdLiquidacion")

        End If
        Return Entidad
    End Function

    Public Sub com_ComprasDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        db.ExecuteNonQuery("com_ComprasDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub com_ComprasDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub com_ComprasInsert _
    (ByVal entidad As com_Compras)

        db.ExecuteNonQuery("com_ComprasInsert", _
         entidad.IdComprobante _
         , entidad.IdTipoComprobante _
         , entidad.Correlativo _
         , entidad.Serie _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.Giro _
         , entidad.IdFormaPago _
         , entidad.NumOrdenCompra _
         , entidad.DiasCredito _
         , entidad.FechaVencimiento _
         , entidad.IdTipoCompra _
         , entidad.TotalExento _
         , entidad.TotalAfecto _
         , entidad.TotalIva _
         , entidad.TotalImpuesto1 _
         , entidad.TotalImpuesto2 _
         , entidad.TotalComprobante _
         , entidad.SaldoActual _
         , entidad.IdSucursal _
         , entidad.IdBodega _
         , entidad.IdOrigenCompra _
         , entidad.AplicadaInventario _
         , entidad.ExcluirLibro _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
           , entidad.IdLiquidacion _
         )
    End Sub

    Public Sub com_ComprasInsert _
    (ByVal entidad As com_Compras, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasInsert", _
         entidad.IdComprobante _
         , entidad.IdTipoComprobante _
         , entidad.Correlativo _
         , entidad.Serie _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.Giro _
         , entidad.IdFormaPago _
         , entidad.NumOrdenCompra _
         , entidad.DiasCredito _
         , entidad.FechaVencimiento _
         , entidad.IdTipoCompra _
         , entidad.TotalExento _
         , entidad.TotalAfecto _
         , entidad.TotalIva _
         , entidad.TotalImpuesto1 _
         , entidad.TotalImpuesto2 _
         , entidad.TotalComprobante _
         , entidad.SaldoActual _
         , entidad.IdSucursal _
         , entidad.IdBodega _
         , entidad.IdOrigenCompra _
         , entidad.AplicadaInventario _
         , entidad.ExcluirLibro _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
           , entidad.IdLiquidacion _
         )
    End Sub

    Public Sub com_ComprasUpdate _
    (ByVal entidad As com_Compras)

        db.ExecuteNonQuery("com_ComprasUpdate", _
         entidad.IdComprobante _
         , entidad.IdTipoComprobante _
         , entidad.Correlativo _
         , entidad.Serie _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.Giro _
         , entidad.IdFormaPago _
         , entidad.NumOrdenCompra _
         , entidad.DiasCredito _
         , entidad.FechaVencimiento _
         , entidad.IdTipoCompra _
         , entidad.TotalExento _
         , entidad.TotalAfecto _
         , entidad.TotalIva _
         , entidad.TotalImpuesto1 _
         , entidad.TotalImpuesto2 _
         , entidad.TotalComprobante _
         , entidad.SaldoActual _
         , entidad.IdSucursal _
         , entidad.IdBodega _
         , entidad.IdOrigenCompra _
         , entidad.AplicadaInventario _
         , entidad.ExcluirLibro _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
           , entidad.IdLiquidacion _
         )
    End Sub

    Public Sub com_ComprasUpdate(ByVal entidad As com_Compras, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasUpdate", _
         entidad.IdComprobante _
         , entidad.IdTipoComprobante _
         , entidad.Correlativo _
         , entidad.Serie _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.FechaContable _
         , entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Direccion _
         , entidad.Giro _
         , entidad.IdFormaPago _
         , entidad.NumOrdenCompra _
         , entidad.DiasCredito _
         , entidad.FechaVencimiento _
         , entidad.IdTipoCompra _
         , entidad.TotalExento _
         , entidad.TotalAfecto _
         , entidad.TotalIva _
         , entidad.TotalImpuesto1 _
         , entidad.TotalImpuesto2 _
         , entidad.TotalComprobante _
         , entidad.SaldoActual _
         , entidad.IdSucursal _
         , entidad.IdBodega _
         , entidad.IdOrigenCompra _
         , entidad.AplicadaInventario _
         , entidad.ExcluirLibro _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
           , entidad.IdLiquidacion _
         )
    End Sub
#End Region
#Region "com_ComprasDetalle"
    Public Function com_ComprasDetalleSelectAll() As DataTable
        Return db.ExecuteDataSet("com_ComprasDetalleSelectAll").Tables(0)
    End Function

    Public Function com_ComprasDetalleSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As com_ComprasDetalle

        Dim dt As DataTable
        dt = db.ExecuteDataSet("com_ComprasDetalleSelectByPK", _
         IdComprobante _
         , IdDetalle _
         ).Tables(0)

        Dim Entidad As New com_ComprasDetalle
        If dt.Rows.Count > 0 Then
            Entidad.IdComprobante = dt.Rows(0).Item("IdComprobante")
            Entidad.IdDetalle = dt.Rows(0).Item("IdDetalle")
            Entidad.IdProducto = dt.Rows(0).Item("IdProducto")
            Entidad.IdGasto = dt.Rows(0).Item("IdGasto")
            Entidad.Cantidad = dt.Rows(0).Item("Cantidad")
            Entidad.Descripcion = dt.Rows(0).Item("Descripcion")
            Entidad.PrecioUnitario = dt.Rows(0).Item("PrecioUnitario")
            Entidad.ValorExento = dt.Rows(0).Item("ValorExento")
            Entidad.ValorAfecto = dt.Rows(0).Item("ValorAfecto")
            Entidad.IdCuenta = dt.Rows(0).Item("IdCuenta")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
        End If
        Return Entidad
    End Function

    Public Sub com_ComprasDetalleDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        db.ExecuteNonQuery("com_ComprasDetalleDeleteByPK", _
         IdComprobante _
         , IdDetalle _
         )
    End Sub

    Public Sub com_ComprasDetalleDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasDetalleDeleteByPK", _
         IdComprobante _
         , IdDetalle _
         )
    End Sub

    Public Sub com_ComprasDetalleInsert _
    (ByVal entidad As com_ComprasDetalle)

        db.ExecuteNonQuery("com_ComprasDetalleInsert", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdProducto _
         , entidad.IdGasto _
         , entidad.Cantidad _
         , entidad.Descripcion _
         , entidad.PrecioUnitario _
         , entidad.ValorExento _
         , entidad.ValorAfecto _
         , entidad.IdCuenta _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub com_ComprasDetalleInsert _
    (ByVal entidad As com_ComprasDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasDetalleInsert", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdProducto _
         , entidad.IdGasto _
         , entidad.Cantidad _
         , entidad.Descripcion _
         , entidad.PrecioUnitario _
         , entidad.ValorExento _
         , entidad.ValorAfecto _
        , entidad.IdCuenta _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub com_ComprasDetalleUpdate _
    (ByVal entidad As com_ComprasDetalle)

        db.ExecuteNonQuery("com_ComprasDetalleUpdate", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdProducto _
         , entidad.IdGasto _
         , entidad.Cantidad _
         , entidad.Descripcion _
         , entidad.PrecioUnitario _
         , entidad.ValorExento _
         , entidad.ValorAfecto _
         , entidad.IdCuenta _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion)
    End Sub

    Public Sub com_ComprasDetalleUpdate(ByVal entidad As com_ComprasDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ComprasDetalleUpdate", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdProducto _
         , entidad.IdGasto _
         , entidad.Cantidad _
         , entidad.Descripcion _
         , entidad.PrecioUnitario _
         , entidad.ValorExento _
         , entidad.ValorAfecto _
         , entidad.IdCuenta _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion)
    End Sub

#End Region
#Region "inv_Productos"
    Public Function inv_ProductosSelectAll() As DataTable
        Return db.ExecuteDataSet("inv_ProductosSelectAll").Tables(0)
    End Function

    Public Function inv_ProductosSelectByPK _
      (ByVal IdProducto As System.String _
      ) As inv_Productos

        Dim dt As DataTable
        dt = db.ExecuteDataSet("inv_ProductosSelectByPK", _
         IdProducto _
         ).Tables(0)

        Dim Entidad As New inv_Productos
        If dt.Rows.Count > 0 Then
            Entidad.IdProducto = dt.Rows(0).Item("IdProducto")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.IdGrupo = dt.Rows(0).Item("IdGrupo")
            Entidad.IdSubGrupo = dt.Rows(0).Item("IdSubGrupo")
            Entidad.IdUnidad = dt.Rows(0).Item("IdUnidad")
            Entidad.IdMarca = dt.Rows(0).Item("IdMarca")
            Entidad.IdProveedor = dt.Rows(0).Item("IdProveedor")
            Entidad.IdUbicacion = dt.Rows(0).Item("IdUbicacion")
            Entidad.Talla = dt.Rows(0).Item("Talla")
            Entidad.Color = dt.Rows(0).Item("Color")
            Entidad.Estilo = dt.Rows(0).Item("Estilo")
            Entidad.UnidadesPresentacion = dt.Rows(0).Item("UnidadesPresentacion")
            Entidad.ExistenciaMaxima = dt.Rows(0).Item("ExistenciaMaxima")
            Entidad.ExistenciaMinima = dt.Rows(0).Item("ExistenciaMinima")
            Entidad.TipoProducto = dt.Rows(0).Item("TipoProducto")
            Entidad.EsExento = dt.Rows(0).Item("EsExento")
            Entidad.FechaIngreso = dt.Rows(0).Item("FechaIngreso")
            Entidad.PrecioUltCosto = dt.Rows(0).Item("PrecioUltCosto")
            Entidad.PrecioCosto = dt.Rows(0).Item("PrecioCosto")
            Entidad.InformacionAdicional = dt.Rows(0).Item("InformacionAdicional")
            Entidad.IdCuentaIng = dt.Rows(0).Item("IdCuentaIng")
            Entidad.IdCuentaInv = dt.Rows(0).Item("IdCuentaInv")
            Entidad.IdCuentaCos = dt.Rows(0).Item("IdCuentaCos")
            Entidad.ArchivoImagen = dt.Rows(0).Item("ArchivoImagen")
            Entidad.EstadoProducto = dt.Rows(0).Item("EstadoProducto")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub inv_ProductosDeleteByPK _
      (ByVal IdProducto As System.String _
      )

        db.ExecuteNonQuery("inv_ProductosDeleteByPK", _
         IdProducto _
         )
    End Sub

    Public Sub inv_ProductosDeleteByPK _
      (ByVal IdProducto As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "inv_ProductosDeleteByPK", _
         IdProducto _
         )
    End Sub

    Public Sub inv_ProductosInsert _
    (ByVal entidad As inv_Productos)

        db.ExecuteNonQuery("inv_ProductosInsert", _
         entidad.IdProducto _
         , entidad.Nombre _
         , entidad.IdGrupo _
         , entidad.IdSubGrupo _
         , entidad.IdUnidad _
         , entidad.IdMarca _
         , entidad.IdProveedor _
         , entidad.IdUbicacion _
         , entidad.Talla _
         , entidad.Color _
         , entidad.Estilo _
         , entidad.UnidadesPresentacion _
         , entidad.ExistenciaMaxima _
         , entidad.ExistenciaMinima _
         , entidad.TipoProducto _
         , entidad.EsExento _
         , entidad.FechaIngreso _
         , entidad.PrecioUltCosto _
         , entidad.PrecioCosto _
         , entidad.InformacionAdicional _
         , entidad.IdCuentaIng _
         , entidad.IdCuentaInv _
         , entidad.IdCuentaCos _
         , entidad.ArchivoImagen _
         , entidad.EstadoProducto _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub inv_ProductosInsert _
    (ByVal entidad As inv_Productos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "inv_ProductosInsert", _
         entidad.IdProducto _
         , entidad.Nombre _
         , entidad.IdGrupo _
         , entidad.IdSubGrupo _
         , entidad.IdUnidad _
         , entidad.IdMarca _
         , entidad.IdProveedor _
         , entidad.IdUbicacion _
         , entidad.Talla _
         , entidad.Color _
         , entidad.Estilo _
         , entidad.UnidadesPresentacion _
         , entidad.ExistenciaMaxima _
         , entidad.ExistenciaMinima _
         , entidad.TipoProducto _
         , entidad.EsExento _
         , entidad.FechaIngreso _
         , entidad.PrecioUltCosto _
         , entidad.PrecioCosto _
         , entidad.InformacionAdicional _
         , entidad.IdCuentaIng _
         , entidad.IdCuentaInv _
         , entidad.IdCuentaCos _
         , entidad.ArchivoImagen _
         , entidad.EstadoProducto _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub inv_ProductosUpdate _
    (ByVal entidad As inv_Productos)

        db.ExecuteNonQuery("inv_ProductosUpdate", _
         entidad.IdProducto _
         , entidad.Nombre _
         , entidad.IdGrupo _
         , entidad.IdSubGrupo _
         , entidad.IdUnidad _
         , entidad.IdMarca _
         , entidad.IdProveedor _
         , entidad.IdUbicacion _
         , entidad.Talla _
         , entidad.Color _
         , entidad.Estilo _
         , entidad.UnidadesPresentacion _
         , entidad.ExistenciaMaxima _
         , entidad.ExistenciaMinima _
         , entidad.TipoProducto _
         , entidad.EsExento _
         , entidad.FechaIngreso _
         , entidad.PrecioUltCosto _
         , entidad.PrecioCosto _
         , entidad.InformacionAdicional _
         , entidad.IdCuentaIng _
         , entidad.IdCuentaInv _
         , entidad.IdCuentaCos _
         , entidad.ArchivoImagen _
         , entidad.EstadoProducto _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub inv_ProductosUpdate _
    (ByVal entidad As inv_Productos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "inv_ProductosUpdate", _
         entidad.IdProducto _
         , entidad.Nombre _
         , entidad.IdGrupo _
         , entidad.IdSubGrupo _
         , entidad.IdUnidad _
         , entidad.IdMarca _
         , entidad.IdProveedor _
         , entidad.IdUbicacion _
         , entidad.Talla _
         , entidad.Color _
         , entidad.Estilo _
         , entidad.UnidadesPresentacion _
         , entidad.ExistenciaMaxima _
         , entidad.ExistenciaMinima _
         , entidad.TipoProducto _
         , entidad.EsExento _
         , entidad.FechaIngreso _
         , entidad.PrecioUltCosto _
         , entidad.PrecioCosto _
         , entidad.InformacionAdicional _
         , entidad.IdCuentaIng _
         , entidad.IdCuentaInv _
         , entidad.IdCuentaCos _
         , entidad.ArchivoImagen _
         , entidad.EstadoProducto _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "com_Proveedores"
    Public Function com_ProveedoresSelectAll() As DataTable
        Return db.ExecuteDataSet("com_ProveedoresSelectAll").Tables(0)
    End Function

    Public Function com_ProveedoresSelectByPK _
      (ByVal IdProveedor As System.String _
      ) As com_Proveedores

        Dim dt As DataTable
        dt = db.ExecuteDataSet("com_ProveedoresSelectByPK", _
         IdProveedor _
         ).Tables(0)

        Dim Entidad As New com_Proveedores
        If dt.Rows.Count > 0 Then
            Entidad.IdProveedor = dt.Rows(0).Item("IdProveedor")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")
            Entidad.Nrc = dt.Rows(0).Item("Nrc")
            Entidad.Nit = dt.Rows(0).Item("Nit")
            Entidad.Giro = dt.Rows(0).Item("Giro")
            Entidad.Direccion = dt.Rows(0).Item("Direccion")
            Entidad.IdDepartamento = dt.Rows(0).Item("IdDepartamento")
            Entidad.IdMunicipio = dt.Rows(0).Item("IdMunicipio")
            Entidad.Telefonos = dt.Rows(0).Item("Telefonos")
            Entidad.NumeroFax = dt.Rows(0).Item("NumeroFax")
            Entidad.CorreoElectronico = dt.Rows(0).Item("CorreoElectronico")
            Entidad.Contacto1 = dt.Rows(0).Item("Contacto1")
            Entidad.Contacto2 = dt.Rows(0).Item("Contacto2")
            Entidad.Contacto3 = dt.Rows(0).Item("Contacto3")
            Entidad.IdCuentaContable = dt.Rows(0).Item("IdCuentaContable")
            Entidad.LimiteCredito = dt.Rows(0).Item("LimiteCredito")
            Entidad.DiasCredito = dt.Rows(0).Item("DiasCredito")
            Entidad.Tipo = dt.Rows(0).Item("Tipo")
            Entidad.AplicaRetencion = dt.Rows(0).Item("AplicaRetencion")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")
            Entidad.ModificadoPor = dt.Rows(0).Item("ModificadoPor")
            Entidad.FechaHoraModificacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraModificacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub com_ProveedoresDeleteByPK _
      (ByVal IdProveedor As System.String _
      )

        db.ExecuteNonQuery("com_ProveedoresDeleteByPK", _
         IdProveedor _
         )
    End Sub

    Public Sub com_ProveedoresDeleteByPK _
      (ByVal IdProveedor As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ProveedoresDeleteByPK", _
         IdProveedor _
         )
    End Sub

    Public Sub com_ProveedoresInsert _
    (ByVal entidad As com_Proveedores)

        db.ExecuteNonQuery("com_ProveedoresInsert", _
         entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Giro _
         , entidad.Direccion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.Telefonos _
         , entidad.NumeroFax _
         , entidad.CorreoElectronico _
         , entidad.Contacto1 _
         , entidad.Contacto2 _
         , entidad.Contacto3 _
         , entidad.IdCuentaContable _
         , entidad.LimiteCredito _
         , entidad.DiasCredito _
         , entidad.Tipo _
         , entidad.AplicaRetencion _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub com_ProveedoresInsert _
    (ByVal entidad As com_Proveedores, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ProveedoresInsert", _
         entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Giro _
         , entidad.Direccion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.Telefonos _
         , entidad.NumeroFax _
         , entidad.CorreoElectronico _
         , entidad.Contacto1 _
         , entidad.Contacto2 _
         , entidad.Contacto3 _
         , entidad.IdCuentaContable _
         , entidad.LimiteCredito _
         , entidad.DiasCredito _
         , entidad.Tipo _
         , entidad.AplicaRetencion _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub com_ProveedoresUpdate _
    (ByVal entidad As com_Proveedores)

        db.ExecuteNonQuery("com_ProveedoresUpdate", _
         entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Giro _
         , entidad.Direccion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.Telefonos _
         , entidad.NumeroFax _
         , entidad.CorreoElectronico _
         , entidad.Contacto1 _
         , entidad.Contacto2 _
         , entidad.Contacto3 _
         , entidad.IdCuentaContable _
         , entidad.LimiteCredito _
         , entidad.DiasCredito _
         , entidad.Tipo _
         , entidad.AplicaRetencion _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

    Public Sub com_ProveedoresUpdate _
    (ByVal entidad As com_Proveedores, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "com_ProveedoresUpdate", _
         entidad.IdProveedor _
         , entidad.Nombre _
         , entidad.Nrc _
         , entidad.Nit _
         , entidad.Giro _
         , entidad.Direccion _
         , entidad.IdDepartamento _
         , entidad.IdMunicipio _
         , entidad.Telefonos _
         , entidad.NumeroFax _
         , entidad.CorreoElectronico _
         , entidad.Contacto1 _
         , entidad.Contacto2 _
         , entidad.Contacto3 _
         , entidad.IdCuentaContable _
         , entidad.LimiteCredito _
         , entidad.DiasCredito _
         , entidad.Tipo _
         , entidad.AplicaRetencion _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub

#End Region
#Region "coo_Liquidaciones"
    Public Sub coo_LiquidacionesInsert _
        (ByVal entidad As coo_Liquidaciones, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionesInsert", _
         entidad.IdComprobante _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.IdCuentaProveedor _
         , entidad.NombreProveedor _
         , entidad.TotalGastos _
         , entidad.TotalAnticipo _
         , entidad.Reintegro _
         , entidad.Concepto _
         , entidad.Cancelado _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.ModificadoPor _
         , entidad.FechaHoraModificacion _
         )
    End Sub
#End Region

#Region "coo_LiquidacionesDetalle"
    Public Function coo_LiquidacionesDetalleSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_LiquidacionesDetalleSelectAll").Tables(0)
    End Function

    Public Function coo_LiquidacionesDetalleSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As coo_LiquidacionesDetalle

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_LiquidacionesDetalleSelectByPK", _
         IdComprobante _
         , IdDetalle _
         ).Tables(0)

        Dim Entidad As New coo_LiquidacionesDetalle
        If dt.Rows.Count > 0 Then
            Entidad.IdComprobante = dt.Rows(0).Item("IdComprobante")
            Entidad.IdDetalle = dt.Rows(0).Item("IdDetalle")
            Entidad.IdCompra = dt.Rows(0).Item("IdCompra")
            Entidad.Numero = dt.Rows(0).Item("Numero")
            Entidad.IdTipo = dt.Rows(0).Item("IdTipo")
            Entidad.Fecha = dt.Rows(0).Item("Fecha")
            Entidad.Valor = dt.Rows(0).Item("Valor")
            Entidad.CreadoPor = dt.Rows(0).Item("CreadoPor")
            Entidad.FechaHoraCreacion = dt.Rows(0).Item("FechaHoraCreacion")

        End If
        Return Entidad
    End Function

    Public Sub coo_LiquidacionesDetalleDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        db.ExecuteNonQuery("coo_LiquidacionesDetalleDeleteByPK", _
         IdComprobante _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_LiquidacionesDetalleDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionesDetalleDeleteByPK", _
         IdComprobante _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_LiquidacionesDetalleInsert _
    (ByVal entidad As coo_LiquidacionesDetalle)

        db.ExecuteNonQuery("coo_LiquidacionesDetalleInsert", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdCompra _
         , entidad.Numero _
         , entidad.IdTipo _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionesDetalleInsert _
    (ByVal entidad As coo_LiquidacionesDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionesDetalleInsert", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdCompra _
         , entidad.Numero _
         , entidad.IdTipo _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionesDetalleUpdate _
    (ByVal entidad As coo_LiquidacionesDetalle)

        db.ExecuteNonQuery("coo_LiquidacionesDetalleUpdate", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdCompra _
         , entidad.Numero _
         , entidad.IdTipo _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_LiquidacionesDetalleUpdate _
    (ByVal entidad As coo_LiquidacionesDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionesDetalleUpdate", _
         entidad.IdComprobante _
         , entidad.IdDetalle _
         , entidad.IdCompra _
         , entidad.Numero _
         , entidad.IdTipo _
         , entidad.Fecha _
         , entidad.Valor _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region

#Region "coo_SolicitudesDetalleGastos"
    Public Function coo_SolicitudesDetalleGastosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesDetalleGastosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesDetalleGastosSelectByPK _
      (ByVal IdEgreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesDetalleGastos

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SolicitudesDetalleGastosSelectByPK", _
         IdEgreso _
         , IdSolicitud _
         ).Tables(0)

        Dim Entidad As New coo_SolicitudesDetalleGastos
        If dt.Rows.Count > 0 Then
            Entidad.IdEgreso = dt.Rows(0).Item("IdEgreso")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.Concepto = dt.Rows(0).Item("Concepto")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesDetalleGastosDeleteByPK _
      (ByVal IdEgreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesDetalleGastosDeleteByPK", _
         IdEgreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosDeleteByPK _
      (ByVal IdEgreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleGastosDeleteByPK", _
         IdEgreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosInsert _
    (ByVal entidad As coo_SolicitudesDetalleGastos)

        db.ExecuteNonQuery("coo_SolicitudesDetalleGastosInsert", _
         entidad.IdEgreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosInsert _
    (ByVal entidad As coo_SolicitudesDetalleGastos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleGastosInsert", _
         entidad.IdEgreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleGastos)

        db.ExecuteNonQuery("coo_SolicitudesDetalleGastosUpdate", _
         entidad.IdEgreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleGastos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleGastosUpdate", _
         entidad.IdEgreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "coo_SolicitudesDetalleIngresos"
    Public Function coo_SolicitudesDetalleIngresosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_SolicitudesDetalleIngresosSelectAll").Tables(0)
    End Function

    Public Function coo_SolicitudesDetalleIngresosSelectByPK _
      (ByVal IdIngreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesDetalleIngresos

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_SolicitudesDetalleIngresosSelectByPK", _
         IdIngreso _
         , IdSolicitud _
         ).Tables(0)

        Dim Entidad As New coo_SolicitudesDetalleIngresos
        If dt.Rows.Count > 0 Then
            Entidad.IdIngreso = dt.Rows(0).Item("IdIngreso")
            Entidad.IdSolicitud = dt.Rows(0).Item("IdSolicitud")
            Entidad.Concepto = dt.Rows(0).Item("Concepto")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_SolicitudesDetalleIngresosDeleteByPK _
      (ByVal IdIngreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        db.ExecuteNonQuery("coo_SolicitudesDetalleIngresosDeleteByPK", _
         IdIngreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosDeleteByPK _
      (ByVal IdIngreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleIngresosDeleteByPK", _
         IdIngreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosInsert _
    (ByVal entidad As coo_SolicitudesDetalleIngresos)

        db.ExecuteNonQuery("coo_SolicitudesDetalleIngresosInsert", _
         entidad.IdIngreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosInsert _
    (ByVal entidad As coo_SolicitudesDetalleIngresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleIngresosInsert", _
         entidad.IdIngreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleIngresos)

        db.ExecuteNonQuery("coo_SolicitudesDetalleIngresosUpdate", _
         entidad.IdIngreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleIngresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_SolicitudesDetalleIngresosUpdate", _
         entidad.IdIngreso _
         , entidad.IdSolicitud _
         , entidad.Concepto _
         , entidad.Valor _
         )
    End Sub

#End Region

#Region "coo_CorteCajaCheques"
    Public Function coo_CorteCajaChequesSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_CorteCajaChequesSelectAll").Tables(0)
    End Function

    Public Function coo_CorteCajaChequesSelectByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      ) As coo_CorteCajaCheques

        Dim dt As DataTable
        dt = db.ExecuteDataSet("coo_CorteCajaChequesSelectByPK", _
         IdCorte _
         , NumeroCuenta _
         , NumeroCheque _
         ).Tables(0)

        Dim Entidad As New coo_CorteCajaCheques
        If dt.Rows.Count > 0 Then
            Entidad.IdCorte = dt.Rows(0).Item("IdCorte")
            Entidad.NumeroCuenta = dt.Rows(0).Item("NumeroCuenta")
            Entidad.NumeroCheque = dt.Rows(0).Item("NumeroCheque")
            Entidad.NombreBanco = dt.Rows(0).Item("NombreBanco")
            Entidad.AnombreDe = dt.Rows(0).Item("AnombreDe")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub coo_CorteCajaChequesDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      )

        db.ExecuteNonQuery("coo_CorteCajaChequesDeleteByPK", _
         IdCorte _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_CorteCajaChequesDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaChequesDeleteByPK", _
         IdCorte _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_CorteCajaChequesInsert _
    (ByVal entidad As coo_CorteCajaCheques)

        db.ExecuteNonQuery("coo_CorteCajaChequesInsert", _
         entidad.IdCorte _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_CorteCajaChequesInsert _
    (ByVal entidad As coo_CorteCajaCheques, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaChequesInsert", _
         entidad.IdCorte _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_CorteCajaChequesUpdate _
    (ByVal entidad As coo_CorteCajaCheques)

        db.ExecuteNonQuery("coo_CorteCajaChequesUpdate", _
         entidad.IdCorte _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

    Public Sub coo_CorteCajaChequesUpdate _
    (ByVal entidad As coo_CorteCajaCheques, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_CorteCajaChequesUpdate", _
         entidad.IdCorte _
         , entidad.NumeroCuenta _
         , entidad.NumeroCheque _
         , entidad.NombreBanco _
         , entidad.AnombreDe _
         , entidad.Valor _
         )
    End Sub

#End Region

#Region "coo_PrestamoEfectivoRefinancia"
    Public Function coo_PrestamoEfectivoRefinanciaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_PrestamoEfectivoRefinanciaSelectAll").Tables(0)
    End Function

    Public Function coo_PrestamoEfectivoRefinanciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_PrestamoEfectivoRefinancia

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_PrestamoEfectivoRefinanciaSelectByPK", _
         IdSolicitud _
         , Correlativo _
         ).tables(0)

        Dim Entidad As New coo_PrestamoEfectivoRefinancia
        If dt.Rows.Count > 0 Then
            entidad.IdSolicitud = dt.rows(0).item("IdSolicitud")
            entidad.Correlativo = dt.rows(0).item("Correlativo")
            entidad.IdPrestamo = dt.rows(0).item("IdPrestamo")
            entidad.IdLinea = dt.rows(0).item("IdLinea")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.SaldoCapital = dt.rows(0).item("SaldoCapital")
            entidad.SaldoInteres = dt.rows(0).item("SaldoInteres")
            entidad.SaldoInteresMora = dt.rows(0).item("SaldoInteresMora")
            entidad.SaldoSeguro = dt.rows(0).item("SaldoSeguro")
            entidad.SaldoOtros = dt.rows(0).item("SaldoOtros")

        End If
        Return Entidad
    End Function

    Public Sub coo_PrestamoEfectivoRefinanciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        db.ExecuteNonQuery("coo_PrestamoEfectivoRefinanciaDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamoEfectivoRefinanciaDeleteByPK", _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaInsert _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia)

        db.ExecuteNonQuery("coo_PrestamoEfectivoRefinanciaInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaInsert _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamoEfectivoRefinanciaInsert", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaUpdate _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia)

        db.ExecuteNonQuery("coo_PrestamoEfectivoRefinanciaUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaUpdate _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_PrestamoEfectivoRefinanciaUpdate", _
         entidad.IdSolicitud _
         , entidad.Correlativo _
         , entidad.IdPrestamo _
         , entidad.IdLinea _
         , entidad.Numero _
         , entidad.SaldoCapital _
         , entidad.SaldoInteres _
         , entidad.SaldoInteresMora _
         , entidad.SaldoSeguro _
         , entidad.SaldoOtros _
         )
    End Sub

#End Region




#Region "col_Colac"
    Public Function col_ColacSelectAll() As DataTable
        Return db.ExecuteDataSet("col_ColacSelectAll").Tables(0)
    End Function

    Public Function col_ColacSelectByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Mes As System.Int32 _
      ) As col_Colac

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_ColacSelectByPK", _
         IdIndicador _
         , Anio _
         , Mes _
         ).Tables(0)

        Dim Entidad As New col_Colac
        If dt.Rows.Count > 0 Then
            Entidad.IdIndicador = dt.Rows(0).Item("IdIndicador")
            Entidad.Anio = dt.Rows(0).Item("Anio")
            Entidad.Mes = dt.Rows(0).Item("Mes")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub col_ColacDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Mes As System.Int32 _
      )

        db.ExecuteNonQuery("col_ColacDeleteByPK", _
         IdIndicador _
         , Anio _
         , Mes _
         )
    End Sub

    Public Sub col_ColacDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Mes As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ColacDeleteByPK", _
         IdIndicador _
         , Anio _
         , Mes _
         )
    End Sub

    Public Sub col_ColacInsert _
    (ByVal entidad As col_Colac)

        db.ExecuteNonQuery("col_ColacInsert", _
         entidad.IdIndicador _
         , entidad.Anio _
         , entidad.Mes _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ColacInsert _
    (ByVal entidad As col_Colac, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ColacInsert", _
         entidad.IdIndicador _
         , entidad.Anio _
         , entidad.Mes _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ColacUpdate _
    (ByVal entidad As col_Colac)

        db.ExecuteNonQuery("col_ColacUpdate", _
         entidad.IdIndicador _
         , entidad.Anio _
         , entidad.Mes _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ColacUpdate _
    (ByVal entidad As col_Colac, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ColacUpdate", _
         entidad.IdIndicador _
         , entidad.Anio _
         , entidad.Mes _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "col_FormulasFinancieras"
    Public Function col_FormulasFinancierasSelectAll() As DataTable
        Return db.ExecuteDataSet("col_FormulasFinancierasSelectAll").Tables(0)
    End Function

    Public Function col_FormulasFinancierasSelectByPK _
      (ByVal Id As System.Int32 _
      ) As col_FormulasFinancieras

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_FormulasFinancierasSelectByPK", _
         Id _
         ).Tables(0)

        Dim Entidad As New col_FormulasFinancieras
        If dt.Rows.Count > 0 Then
            Entidad.Id = dt.Rows(0).Item("Id")
            Entidad.IdFormula = dt.Rows(0).Item("IdFormula")
            Entidad.ValorFormula = dt.Rows(0).Item("ValorFormula")
            Entidad.Descripcion = dt.Rows(0).Item("Descripcion")
            Entidad.TipoValor = dt.Rows(0).Item("TipoValor")

        End If
        Return Entidad
    End Function

    Public Sub col_FormulasFinancierasDeleteByPK _
      (ByVal Id As System.Int32 _
      )

        db.ExecuteNonQuery("col_FormulasFinancierasDeleteByPK", _
         Id _
         )
    End Sub

    Public Sub col_FormulasFinancierasDeleteByPK _
      (ByVal Id As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_FormulasFinancierasDeleteByPK", _
         Id _
         )
    End Sub

    Public Sub col_FormulasFinancierasInsert _
    (ByVal entidad As col_FormulasFinancieras)

        db.ExecuteNonQuery("col_FormulasFinancierasInsert", _
         entidad.Id _
         , entidad.IdFormula _
         , entidad.ValorFormula _
         , entidad.Descripcion _
         , entidad.TipoValor _
         )
    End Sub

    Public Sub col_FormulasFinancierasInsert _
    (ByVal entidad As col_FormulasFinancieras, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_FormulasFinancierasInsert", _
         entidad.Id _
         , entidad.IdFormula _
         , entidad.ValorFormula _
         , entidad.Descripcion _
         , entidad.TipoValor _
         )
    End Sub

    Public Sub col_FormulasFinancierasUpdate _
    (ByVal entidad As col_FormulasFinancieras)

        db.ExecuteNonQuery("col_FormulasFinancierasUpdate", _
         entidad.Id _
         , entidad.IdFormula _
         , entidad.ValorFormula _
         , entidad.Descripcion _
         , entidad.TipoValor _
         )
    End Sub

    Public Sub col_FormulasFinancierasUpdate _
    (ByVal entidad As col_FormulasFinancieras, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_FormulasFinancierasUpdate", _
         entidad.Id _
         , entidad.IdFormula _
         , entidad.ValorFormula _
         , entidad.Descripcion _
         , entidad.TipoValor _
         )
    End Sub

#End Region
#Region "col_indicadores"
    Public Function col_indicadoresSelectAll() As DataTable
        Return db.ExecuteDataSet("col_indicadoresSelectAll").Tables(0)
    End Function

    Public Function col_indicadoresSelectByPK _
      (ByVal IdIndicador As System.Int32 _
      ) As col_indicadores

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_indicadoresSelectByPK", _
         IdIndicador _
         ).Tables(0)

        Dim Entidad As New col_indicadores
        If dt.Rows.Count > 0 Then
            Entidad.IdIndicador = dt.Rows(0).Item("IdIndicador")
            Entidad.IdVariable = dt.Rows(0).Item("IdVariable")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub col_indicadoresDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      )

        db.ExecuteNonQuery("col_indicadoresDeleteByPK", _
         IdIndicador _
         )
    End Sub

    Public Sub col_indicadoresDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_indicadoresDeleteByPK", _
         IdIndicador _
         )
    End Sub

    Public Sub col_indicadoresInsert _
    (ByVal entidad As col_indicadores)

        db.ExecuteNonQuery("col_indicadoresInsert", _
         entidad.IdIndicador _
         , entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_indicadoresInsert _
    (ByVal entidad As col_indicadores, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_indicadoresInsert", _
         entidad.IdIndicador _
         , entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_indicadoresUpdate _
    (ByVal entidad As col_indicadores)

        db.ExecuteNonQuery("col_indicadoresUpdate", _
         entidad.IdIndicador _
         , entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_indicadoresUpdate _
    (ByVal entidad As col_indicadores, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_indicadoresUpdate", _
         entidad.IdIndicador _
         , entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "col_IndicadoresParametros"
    Public Function col_IndicadoresParametrosSelectAll() As DataTable
        Return db.ExecuteDataSet("col_IndicadoresParametrosSelectAll").Tables(0)
    End Function

    Public Function col_IndicadoresParametrosSelectByPK _
      (ByVal NombreIndicador As System.String _
      ) As col_IndicadoresParametros

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_IndicadoresParametrosSelectByPK", _
         NombreIndicador _
         ).Tables(0)

        Dim Entidad As New col_IndicadoresParametros
        If dt.Rows.Count > 0 Then
            Entidad.NombreIndicador = dt.Rows(0).Item("NombreIndicador")
            Entidad.ValorInicial = dt.Rows(0).Item("ValorInicial")
            Entidad.ValorFinal = dt.Rows(0).Item("ValorFinal")
            Entidad.Rangos = dt.Rows(0).Item("Rangos")
            Entidad.Escala = dt.Rows(0).Item("Escala")
            Entidad.ValorInicial2 = dt.Rows(0).Item("ValorInicial2")
            Entidad.ValorFinal2 = dt.Rows(0).Item("ValorFinal2")
            Entidad.Rangos2 = dt.Rows(0).Item("Rangos2")
            Entidad.Escala2 = dt.Rows(0).Item("Escala2")
            Entidad.ValorInicial3 = dt.Rows(0).Item("ValorInicial3")
            Entidad.ValorFinal3 = dt.Rows(0).Item("ValorFinal3")
            Entidad.Rangos3 = dt.Rows(0).Item("Rangos3")
            Entidad.Escala3 = dt.Rows(0).Item("Escala3")

        End If
        Return Entidad
    End Function

    Public Sub col_IndicadoresParametrosDeleteByPK _
      (ByVal NombreIndicador As System.String _
      )

        db.ExecuteNonQuery("col_IndicadoresParametrosDeleteByPK", _
         NombreIndicador _
         )
    End Sub

    Public Sub col_IndicadoresParametrosDeleteByPK _
      (ByVal NombreIndicador As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_IndicadoresParametrosDeleteByPK", _
         NombreIndicador _
         )
    End Sub

    Public Sub col_IndicadoresParametrosInsert _
    (ByVal entidad As col_IndicadoresParametros)

        db.ExecuteNonQuery("col_IndicadoresParametrosInsert", _
         entidad.NombreIndicador _
         , entidad.ValorInicial _
         , entidad.ValorFinal _
         , entidad.Rangos _
         , entidad.Escala _
         , entidad.ValorInicial2 _
         , entidad.ValorFinal2 _
         , entidad.Rangos2 _
         , entidad.Escala2 _
         , entidad.ValorInicial3 _
         , entidad.ValorFinal3 _
         , entidad.Rangos3 _
         , entidad.Escala3 _
         )
    End Sub

    Public Sub col_IndicadoresParametrosInsert _
    (ByVal entidad As col_IndicadoresParametros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_IndicadoresParametrosInsert", _
         entidad.NombreIndicador _
         , entidad.ValorInicial _
         , entidad.ValorFinal _
         , entidad.Rangos _
         , entidad.Escala _
         , entidad.ValorInicial2 _
         , entidad.ValorFinal2 _
         , entidad.Rangos2 _
         , entidad.Escala2 _
         , entidad.ValorInicial3 _
         , entidad.ValorFinal3 _
         , entidad.Rangos3 _
         , entidad.Escala3 _
         )
    End Sub

    Public Sub col_IndicadoresParametrosUpdate _
    (ByVal entidad As col_IndicadoresParametros)

        db.ExecuteNonQuery("col_IndicadoresParametrosUpdate", _
         entidad.NombreIndicador _
         , entidad.ValorInicial _
         , entidad.ValorFinal _
         , entidad.Rangos _
         , entidad.Escala _
         , entidad.ValorInicial2 _
         , entidad.ValorFinal2 _
         , entidad.Rangos2 _
         , entidad.Escala2 _
         , entidad.ValorInicial3 _
         , entidad.ValorFinal3 _
         , entidad.Rangos3 _
         , entidad.Escala3 _
         )
    End Sub

    Public Sub col_IndicadoresParametrosUpdate _
    (ByVal entidad As col_IndicadoresParametros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_IndicadoresParametrosUpdate", _
         entidad.NombreIndicador _
         , entidad.ValorInicial _
         , entidad.ValorFinal _
         , entidad.Rangos _
         , entidad.Escala _
         , entidad.ValorInicial2 _
         , entidad.ValorFinal2 _
         , entidad.Rangos2 _
         , entidad.Escala2 _
         , entidad.ValorInicial3 _
         , entidad.ValorFinal3 _
         , entidad.Rangos3 _
         , entidad.Escala3 _
         )
    End Sub

#End Region
#Region "col_Parametros"
    Public Function col_ParametrosSelectAll() As DataTable
        Return db.ExecuteDataSet("col_ParametrosSelectAll").Tables(0)
    End Function

    Public Function col_ParametrosSelectByPK _
      (ByVal IdParametro As System.String _
      ) As col_Parametros

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_ParametrosSelectByPK", _
         IdParametro _
         ).Tables(0)

        Dim Entidad As New col_Parametros
        If dt.Rows.Count > 0 Then
            Entidad.IdParametro = dt.Rows(0).Item("IdParametro")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub col_ParametrosDeleteByPK _
      (ByVal IdParametro As System.String _
      )

        db.ExecuteNonQuery("col_ParametrosDeleteByPK", _
         IdParametro _
         )
    End Sub

    Public Sub col_ParametrosDeleteByPK _
      (ByVal IdParametro As System.String _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosDeleteByPK", _
         IdParametro _
         )
    End Sub

    Public Sub col_ParametrosInsert _
    (ByVal entidad As col_Parametros)

        db.ExecuteNonQuery("col_ParametrosInsert", _
         entidad.IdParametro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_ParametrosInsert _
    (ByVal entidad As col_Parametros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosInsert", _
         entidad.IdParametro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_ParametrosUpdate _
    (ByVal entidad As col_Parametros)

        db.ExecuteNonQuery("col_ParametrosUpdate", _
         entidad.IdParametro _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_ParametrosUpdate _
    (ByVal entidad As col_Parametros, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosUpdate", _
         entidad.IdParametro _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "col_ParametrosDetalle"
    Public Function col_ParametrosDetalleSelectAll() As DataTable
        Return db.ExecuteDataSet("col_ParametrosDetalleSelectAll").Tables(0)
    End Function

    Public Function col_ParametrosDetalleSelectByPK _
      (ByVal IdParametro As System.String _
      , ByVal Mes As System.Int32 _
      , ByVal Anio As System.Int32 _
      ) As col_ParametrosDetalle

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_ParametrosDetalleSelectByPK", _
         IdParametro _
         , Mes _
         , Anio _
         ).Tables(0)

        Dim Entidad As New col_ParametrosDetalle
        If dt.Rows.Count > 0 Then
            Entidad.IdParametro = dt.Rows(0).Item("IdParametro")
            Entidad.Mes = dt.Rows(0).Item("Mes")
            Entidad.Anio = dt.Rows(0).Item("Anio")
            Entidad.Valor = dt.Rows(0).Item("Valor")

        End If
        Return Entidad
    End Function

    Public Sub col_ParametrosDetalleDeleteByPK _
      (ByVal IdParametro As System.String _
      , ByVal Mes As System.Int32 _
      , ByVal Anio As System.Int32 _
      )

        db.ExecuteNonQuery("col_ParametrosDetalleDeleteByPK", _
         IdParametro _
         , Mes _
         , Anio _
         )
    End Sub

    Public Sub col_ParametrosDetalleDeleteByPK _
      (ByVal IdParametro As System.String _
      , ByVal Mes As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosDetalleDeleteByPK", _
         IdParametro _
         , Mes _
         , Anio _
         )
    End Sub

    Public Sub col_ParametrosDetalleInsert _
    (ByVal entidad As col_ParametrosDetalle)

        db.ExecuteNonQuery("col_ParametrosDetalleInsert", _
         entidad.IdParametro _
         , entidad.Mes _
         , entidad.Anio _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ParametrosDetalleInsert _
    (ByVal entidad As col_ParametrosDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosDetalleInsert", _
         entidad.IdParametro _
         , entidad.Mes _
         , entidad.Anio _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ParametrosDetalleUpdate _
    (ByVal entidad As col_ParametrosDetalle)

        db.ExecuteNonQuery("col_ParametrosDetalleUpdate", _
         entidad.IdParametro _
         , entidad.Mes _
         , entidad.Anio _
         , entidad.Valor _
         )
    End Sub

    Public Sub col_ParametrosDetalleUpdate _
    (ByVal entidad As col_ParametrosDetalle, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_ParametrosDetalleUpdate", _
         entidad.IdParametro _
         , entidad.Mes _
         , entidad.Anio _
         , entidad.Valor _
         )
    End Sub

#End Region
#Region "col_Variables"
    Public Function col_VariablesSelectAll() As DataTable
        Return db.ExecuteDataSet("col_VariablesSelectAll").Tables(0)
    End Function

    Public Function col_VariablesSelectByPK _
      (ByVal IdVariable As System.Int32 _
      ) As col_Variables

        Dim dt As DataTable
        dt = db.ExecuteDataSet("col_VariablesSelectByPK", _
         IdVariable _
         ).Tables(0)

        Dim Entidad As New col_Variables
        If dt.Rows.Count > 0 Then
            Entidad.IdVariable = dt.Rows(0).Item("IdVariable")
            Entidad.Nombre = dt.Rows(0).Item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub col_VariablesDeleteByPK _
      (ByVal IdVariable As System.Int32 _
      )

        db.ExecuteNonQuery("col_VariablesDeleteByPK", _
         IdVariable _
         )
    End Sub

    Public Sub col_VariablesDeleteByPK _
      (ByVal IdVariable As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_VariablesDeleteByPK", _
         IdVariable _
         )
    End Sub

    Public Sub col_VariablesInsert _
    (ByVal entidad As col_Variables)

        db.ExecuteNonQuery("col_VariablesInsert", _
         entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_VariablesInsert _
    (ByVal entidad As col_Variables, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_VariablesInsert", _
         entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_VariablesUpdate _
    (ByVal entidad As col_Variables)

        db.ExecuteNonQuery("col_VariablesUpdate", _
         entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

    Public Sub col_VariablesUpdate _
    (ByVal entidad As col_Variables, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "col_VariablesUpdate", _
         entidad.IdVariable _
         , entidad.Nombre _
         )
    End Sub

#End Region
#Region "coo_IsrInteres"
    Public Function coo_IsrInteresSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_IsrInteresSelectAll").Tables(0)
    End Function

    Public Function coo_IsrInteresSelectByPK _
      (ByVal IdIsr As System.Int32 _
      ) As coo_IsrInteres

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_IsrInteresSelectByPK", _
         IdIsr _
         ).tables(0)

        Dim Entidad As New coo_IsrInteres
        If dt.Rows.Count > 0 Then
            entidad.IdIsr = dt.rows(0).item("IdIsr")
            entidad.IdCuenta = dt.rows(0).item("IdCuenta")
            entidad.Mes = dt.rows(0).item("Mes")
            entidad.Ejercicio = dt.rows(0).item("Ejercicio")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Saldo = dt.rows(0).item("Saldo")
            entidad.Interes = dt.rows(0).item("Interes")
            entidad.Isr = dt.rows(0).item("Isr")
            entidad.Idtipo = dt.rows(0).item("Idtipo")

        End If
        Return Entidad
    End Function

    Public Sub coo_IsrInteresDeleteByPK _
      (ByVal IdIsr As System.Int32 _
      )

        db.ExecuteNonQuery("coo_IsrInteresDeleteByPK", _
         IdIsr _
         )
    End Sub

    Public Sub coo_IsrInteresDeleteByPK _
      (ByVal IdIsr As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_IsrInteresDeleteByPK", _
         IdIsr _
         )
    End Sub

    Public Sub coo_IsrInteresInsert _
    (ByVal entidad As coo_IsrInteres)

        db.ExecuteNonQuery("coo_IsrInteresInsert", _
         entidad.IdIsr _
         , entidad.IdCuenta _
         , entidad.Mes _
         , entidad.Ejercicio _
         , entidad.Fecha _
         , entidad.IdAsociado _
         , entidad.Saldo _
         , entidad.Interes _
         , entidad.Isr _
         , entidad.Idtipo _
         )
    End Sub

    Public Sub coo_IsrInteresInsert _
    (ByVal entidad As coo_IsrInteres, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_IsrInteresInsert", _
         entidad.IdIsr _
         , entidad.IdCuenta _
         , entidad.Mes _
         , entidad.Ejercicio _
         , entidad.Fecha _
         , entidad.IdAsociado _
         , entidad.Saldo _
         , entidad.Interes _
         , entidad.Isr _
         , entidad.Idtipo _
         )
    End Sub

    Public Sub coo_IsrInteresUpdate _
    (ByVal entidad As coo_IsrInteres)

        db.ExecuteNonQuery("coo_IsrInteresUpdate", _
         entidad.IdIsr _
         , entidad.IdCuenta _
         , entidad.Mes _
         , entidad.Ejercicio _
         , entidad.Fecha _
         , entidad.IdAsociado _
         , entidad.Saldo _
         , entidad.Interes _
         , entidad.Isr _
         , entidad.Idtipo _
         )
    End Sub

    Public Sub coo_IsrInteresUpdate _
    (ByVal entidad As coo_IsrInteres, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_IsrInteresUpdate", _
         entidad.IdIsr _
         , entidad.IdCuenta _
         , entidad.Mes _
         , entidad.Ejercicio _
         , entidad.Fecha _
         , entidad.IdAsociado _
         , entidad.Saldo _
         , entidad.Interes _
         , entidad.Isr _
         , entidad.Idtipo _
         )
    End Sub

#End Region
#Region "coo_OperacionesCaja"
    Public Function coo_OperacionesCajaSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OperacionesCajaSelectAll").Tables(0)
    End Function

    Public Function coo_OperacionesCajaSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      ) As coo_OperacionesCaja

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_OperacionesCajaSelectByPK", _
         IdOperacion _
         ).tables(0)

        Dim Entidad As New coo_OperacionesCaja
        If dt.Rows.Count > 0 Then
            entidad.IdOperacion = dt.rows(0).item("IdOperacion")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.Tipo = dt.rows(0).item("Tipo")
            entidad.Monto = dt.rows(0).item("Monto")
            entidad.Concepto = dt.rows(0).item("Concepto")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            entidad.FechaHoraCreacion = dt.rows(0).item("FechaHoraCreacion")
            entidad.Excluir = dt.rows(0).item("Excluir")
            entidad.FondoInicial = dt.rows(0).item("FondoInicial")

        End If
        Return Entidad
    End Function

    Public Sub coo_OperacionesCajaDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      )

        db.ExecuteNonQuery("coo_OperacionesCajaDeleteByPK", _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesCajaDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesCajaDeleteByPK", _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesCajaInsert _
    (ByVal entidad As coo_OperacionesCaja)

        db.ExecuteNonQuery("coo_OperacionesCajaInsert", _
         entidad.IdOperacion _
         , entidad.Fecha _
         , entidad.Numero _
         , entidad.Tipo _
         , entidad.Monto _
         , entidad.Concepto _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.Excluir _
         , entidad.FondoInicial _
         )
    End Sub

    Public Sub coo_OperacionesCajaInsert _
    (ByVal entidad As coo_OperacionesCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesCajaInsert", _
         entidad.IdOperacion _
         , entidad.Fecha _
         , entidad.Numero _
         , entidad.Tipo _
         , entidad.Monto _
         , entidad.Concepto _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.Excluir _
         , entidad.FondoInicial _
         )
    End Sub

    Public Sub coo_OperacionesCajaUpdate _
    (ByVal entidad As coo_OperacionesCaja)

        db.ExecuteNonQuery("coo_OperacionesCajaUpdate", _
         entidad.IdOperacion _
         , entidad.Fecha _
         , entidad.Numero _
         , entidad.Tipo _
         , entidad.Monto _
         , entidad.Concepto _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.Excluir _
         , entidad.FondoInicial _
         )
    End Sub

    Public Sub coo_OperacionesCajaUpdate _
    (ByVal entidad As coo_OperacionesCaja, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OperacionesCajaUpdate", _
         entidad.IdOperacion _
         , entidad.Fecha _
         , entidad.Numero _
         , entidad.Tipo _
         , entidad.Monto _
         , entidad.Concepto _
         , entidad.IdSucursal _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         , entidad.Excluir _
         , entidad.FondoInicial _
         )
    End Sub

#End Region

#Region "coo_OtrosEgresos"
    Public Function coo_OtrosEgresosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OtrosEgresosSelectAll").Tables(0)
    End Function

    Public Function coo_OtrosEgresosSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_OtrosEgresos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_OtrosEgresosSelectByPK", _
         IdMov _
         ).tables(0)

        Dim Entidad As New coo_OtrosEgresos
        If dt.Rows.Count > 0 Then
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.IdTipoMovimiento = dt.rows(0).item("IdTipoMovimiento")
            entidad.IdAgenteRemesa = dt.rows(0).item("IdAgenteRemesa")
            entidad.IdCuentaGasto = dt.rows(0).item("IdCuentaGasto")
            entidad.RemitenteRemesa = dt.rows(0).item("RemitenteRemesa")
            entidad.Concepto = dt.rows(0).item("Concepto")
            entidad.Valor = dt.rows(0).item("Valor")
            entidad.Iva = dt.rows(0).item("Iva")
            entidad.Isr = dt.rows(0).item("Isr")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.FechaContable = dt.rows(0).item("FechaContable")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            Entidad.FechaHoraCreacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraCreacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_OtrosEgresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_OtrosEgresosDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosEgresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosEgresosDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosEgresosInsert _
    (ByVal entidad As coo_OtrosEgresos)

        db.ExecuteNonQuery("coo_OtrosEgresosInsert", _
         entidad.IdMov _
         , entidad.Numero _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAgenteRemesa _
         , entidad.IdCuentaGasto _
         , entidad.RemitenteRemesa _
         , entidad.Concepto _
         , entidad.Valor _
         , entidad.Iva _
         , entidad.Isr _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosEgresosInsert _
    (ByVal entidad As coo_OtrosEgresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosEgresosInsert", _
         entidad.IdMov _
         , entidad.Numero _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAgenteRemesa _
         , entidad.IdCuentaGasto _
         , entidad.RemitenteRemesa _
         , entidad.Concepto _
         , entidad.Valor _
         , entidad.Iva _
         , entidad.Isr _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosEgresosUpdate _
    (ByVal entidad As coo_OtrosEgresos)

        db.ExecuteNonQuery("coo_OtrosEgresosUpdate", _
         entidad.IdMov _
         , entidad.Numero _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAgenteRemesa _
         , entidad.IdCuentaGasto _
         , entidad.RemitenteRemesa _
         , entidad.Concepto _
         , entidad.Valor _
         , entidad.Iva _
         , entidad.Isr _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosEgresosUpdate _
    (ByVal entidad As coo_OtrosEgresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosEgresosUpdate", _
         entidad.IdMov _
         , entidad.Numero _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAgenteRemesa _
         , entidad.IdCuentaGasto _
         , entidad.RemitenteRemesa _
         , entidad.Concepto _
         , entidad.Valor _
         , entidad.Iva _
         , entidad.Isr _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "coo_OtrosIngresos"
    Public Function coo_OtrosIngresosSelectAll() As DataTable
        Return db.ExecuteDataSet("coo_OtrosIngresosSelectAll").Tables(0)
    End Function

    Public Function coo_OtrosIngresosSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_OtrosIngresos

        Dim dt As datatable
        dt = db.ExecuteDataSet("coo_OtrosIngresosSelectByPK", _
         IdMov _
         ).tables(0)

        Dim Entidad As New coo_OtrosIngresos
        If dt.Rows.Count > 0 Then
            entidad.IdMov = dt.rows(0).item("IdMov")
            entidad.PrefijoNumero = dt.rows(0).item("PrefijoNumero")
            entidad.TipoComprobante = dt.rows(0).item("TipoComprobante")
            entidad.Numero = dt.rows(0).item("Numero")
            entidad.Fecha = dt.rows(0).item("Fecha")
            entidad.IdFormaPago = dt.rows(0).item("IdFormaPago")
            entidad.IdTipoMovimiento = dt.rows(0).item("IdTipoMovimiento")
            entidad.IdAsociado = dt.rows(0).item("IdAsociado")
            entidad.Nombre = dt.rows(0).item("Nombre")
            entidad.Direccion = dt.rows(0).item("Direccion")
            entidad.Dui = dt.rows(0).item("Dui")
            entidad.ValorNoSujeto = dt.rows(0).item("ValorNoSujeto")
            entidad.ConceptoNoSujeto = dt.rows(0).item("ConceptoNoSujeto")
            entidad.ValorExento = dt.rows(0).item("ValorExento")
            entidad.ConceptoExento = dt.rows(0).item("ConceptoExento")
            entidad.ValorAfecto = dt.rows(0).item("ValorAfecto")
            entidad.ValorIva = dt.rows(0).item("ValorIva")
            entidad.ConceptoAfecto = dt.rows(0).item("ConceptoAfecto")
            entidad.OtrosIngresos = dt.rows(0).item("OtrosIngresos")
            entidad.ConceptoOtrosIngresos = dt.rows(0).item("ConceptoOtrosIngresos")
            entidad.Observaciones = dt.rows(0).item("Observaciones")
            entidad.IdSucursal = dt.rows(0).item("IdSucursal")
            entidad.FechaContable = dt.rows(0).item("FechaContable")
            entidad.CreadoPor = dt.rows(0).item("CreadoPor")
            Entidad.FechaHoraCreacion = fd.SiEsNulo(dt.Rows(0).Item("FechaHoraCreacion"), Nothing)

        End If
        Return Entidad
    End Function

    Public Sub coo_OtrosIngresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        db.ExecuteNonQuery("coo_OtrosIngresosDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosIngresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosIngresosDeleteByPK", _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosIngresosInsert _
    (ByVal entidad As coo_OtrosIngresos)

        db.ExecuteNonQuery("coo_OtrosIngresosInsert", _
         entidad.IdMov _
         , entidad.PrefijoNumero _
         , entidad.TipoComprobante _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Dui _
         , entidad.ValorNoSujeto _
         , entidad.ConceptoNoSujeto _
         , entidad.ValorExento _
         , entidad.ConceptoExento _
         , entidad.ValorAfecto _
         , entidad.ValorIva _
         , entidad.ConceptoAfecto _
         , entidad.OtrosIngresos _
         , entidad.ConceptoOtrosIngresos _
         , entidad.Observaciones _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosIngresosInsert _
    (ByVal entidad As coo_OtrosIngresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosIngresosInsert", _
         entidad.IdMov _
         , entidad.PrefijoNumero _
         , entidad.TipoComprobante _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Dui _
         , entidad.ValorNoSujeto _
         , entidad.ConceptoNoSujeto _
         , entidad.ValorExento _
         , entidad.ConceptoExento _
         , entidad.ValorAfecto _
         , entidad.ValorIva _
         , entidad.ConceptoAfecto _
         , entidad.OtrosIngresos _
         , entidad.ConceptoOtrosIngresos _
         , entidad.Observaciones _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosIngresosUpdate _
    (ByVal entidad As coo_OtrosIngresos)

        db.ExecuteNonQuery("coo_OtrosIngresosUpdate", _
         entidad.IdMov _
         , entidad.PrefijoNumero _
         , entidad.TipoComprobante _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Dui _
         , entidad.ValorNoSujeto _
         , entidad.ConceptoNoSujeto _
         , entidad.ValorExento _
         , entidad.ConceptoExento _
         , entidad.ValorAfecto _
         , entidad.ValorIva _
         , entidad.ConceptoAfecto _
         , entidad.OtrosIngresos _
         , entidad.ConceptoOtrosIngresos _
         , entidad.Observaciones _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

    Public Sub coo_OtrosIngresosUpdate _
    (ByVal entidad As coo_OtrosIngresos, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_OtrosIngresosUpdate", _
         entidad.IdMov _
         , entidad.PrefijoNumero _
         , entidad.TipoComprobante _
         , entidad.Numero _
         , entidad.Fecha _
         , entidad.IdFormaPago _
         , entidad.IdTipoMovimiento _
         , entidad.IdAsociado _
         , entidad.Nombre _
         , entidad.Direccion _
         , entidad.Dui _
         , entidad.ValorNoSujeto _
         , entidad.ConceptoNoSujeto _
         , entidad.ValorExento _
         , entidad.ConceptoExento _
         , entidad.ValorAfecto _
         , entidad.ValorIva _
         , entidad.ConceptoAfecto _
         , entidad.OtrosIngresos _
         , entidad.ConceptoOtrosIngresos _
         , entidad.Observaciones _
         , entidad.IdSucursal _
         , entidad.FechaContable _
         , entidad.CreadoPor _
         , entidad.FechaHoraCreacion _
         )
    End Sub

#End Region
#Region "pla_EstadoCivil"
    Public Function pla_EstadoCivilSelectAll() As DataTable
        Return db.ExecuteDataSet("pla_EstadoCivilSelectAll").Tables(0)
    End Function

    Public Function pla_EstadoCivilSelectByPK _
      (ByVal IdEstadoCivil As System.Int32 _
      ) As pla_EstadoCivil

        Dim dt As datatable
        dt = db.ExecuteDataSet("pla_EstadoCivilSelectByPK", _
         IdEstadoCivil _
         ).tables(0)

        Dim Entidad As New pla_EstadoCivil
        If dt.Rows.Count > 0 Then
            entidad.IdEstadoCivil = dt.rows(0).item("IdEstadoCivil")
            entidad.Nombre = dt.rows(0).item("Nombre")

        End If
        Return Entidad
    End Function

    Public Sub pla_EstadoCivilDeleteByPK _
      (ByVal IdEstadoCivil As System.Int32 _
      )

        db.ExecuteNonQuery("pla_EstadoCivilDeleteByPK", _
         IdEstadoCivil _
         )
    End Sub

    Public Sub pla_EstadoCivilDeleteByPK _
      (ByVal IdEstadoCivil As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "pla_EstadoCivilDeleteByPK", _
         IdEstadoCivil _
         )
    End Sub

    Public Sub pla_EstadoCivilInsert _
    (ByVal entidad As pla_EstadoCivil)

        db.ExecuteNonQuery("pla_EstadoCivilInsert", _
         entidad.IdEstadoCivil _
         , entidad.Nombre _
         )
    End Sub

    Public Sub pla_EstadoCivilInsert _
    (ByVal entidad As pla_EstadoCivil, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "pla_EstadoCivilInsert", _
         entidad.IdEstadoCivil _
         , entidad.Nombre _
         )
    End Sub

    Public Sub pla_EstadoCivilUpdate _
    (ByVal entidad As pla_EstadoCivil)

        db.ExecuteNonQuery("pla_EstadoCivilUpdate", _
         entidad.IdEstadoCivil _
         , entidad.Nombre _
         )
    End Sub

    Public Sub pla_EstadoCivilUpdate _
    (ByVal entidad As pla_EstadoCivil, ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "pla_EstadoCivilUpdate", _
         entidad.IdEstadoCivil _
         , entidad.Nombre _
         )
    End Sub

#End Region
    Public Sub coo_LiquidacionesDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        db.ExecuteNonQuery("coo_LiquidacionesDeleteByPK", _
         IdComprobante _
         )
    End Sub

    Public Sub coo_LiquidacionesDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal Transaccion As DbTransaction)

        db.ExecuteNonQuery(Transaccion, "coo_LiquidacionesDeleteByPK", _
         IdComprobante _
         )
    End Sub

End Class
