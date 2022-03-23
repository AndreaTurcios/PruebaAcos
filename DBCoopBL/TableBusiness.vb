Imports DBCoopDL
Imports DBCoopEL.TableEntities

Public Class TableBusiness
    Dim dl As New TableData
    
#Region "Admon"

    Public Function adm_UsuariosSelectAll() As DataTable
        Return dl.adm_UsuariosSelectAll()
    End Function

    Public Function adm_UsuariosSelectByPK _
      (ByVal IdUsuario As System.String _
      ) As adm_Usuarios

        Return dl.adm_UsuariosSelectByPK( _
         IdUsuario _
         )
    End Function

    Public Sub adm_UsuariosDeleteByPK _
      (ByVal IdUsuario As System.String _
      )

        dl.adm_UsuariosDeleteByPK( _
         IdUsuario _
         )
    End Sub

    Public Sub adm_UsuariosInsert _
    (ByVal entidad As adm_Usuarios)

        dl.adm_UsuariosInsert(entidad)
    End Sub

    Public Sub adm_UsuariosUpdate _
    (ByVal entidad As adm_Usuarios)

        dl.adm_UsuariosUpdate(entidad)
    End Sub

    Public Function adm_LibrosSelectAll() As DataTable
        Return dl.adm_LibrosSelectAll()
    End Function

    Public Function adm_LibrosSelectByPK _
      (ByVal IdLibro As System.Int32 _
      ) As adm_Libros

        Return dl.adm_LibrosSelectByPK( _
         IdLibro _
         )
    End Function

    Public Sub adm_LibrosDeleteByPK _
      (ByVal IdLibro As System.Int32 _
      )

        dl.adm_LibrosDeleteByPK( _
         IdLibro _
         )
    End Sub

    Public Sub adm_LibrosInsert _
    (ByVal entidad As adm_Libros)

        dl.adm_LibrosInsert(entidad)
    End Sub

    Public Sub adm_LibrosUpdate _
    (ByVal entidad As adm_Libros)

        dl.adm_LibrosUpdate(entidad)
    End Sub

    Public Function adm_SucursalesSelectAll() As DataTable
        Return dl.adm_SucursalesSelectAll()
    End Function

    Public Function adm_SucursalesSelectByPK(ByVal IdSucursal As System.Int32) As adm_Sucursales

        Return dl.adm_SucursalesSelectByPK(IdSucursal)
    End Function

    Public Sub adm_SucursalesDeleteByPK(ByVal IdSucursal As System.Int32)

        dl.adm_SucursalesDeleteByPK(IdSucursal)
    End Sub

    Public Sub adm_SucursalesInsert(ByVal entidad As adm_Sucursales)
        dl.adm_SucursalesInsert(entidad)
    End Sub

    Public Sub adm_SucursalesUpdate(ByVal entidad As adm_Sucursales)
        dl.adm_SucursalesUpdate(entidad)
    End Sub

    Public Function adm_TiposComprobanteSelectAll() As DataTable
        Return dl.adm_TiposComprobanteSelectAll()
    End Function

    Public Function adm_TiposComprobanteSelectByPK(ByVal IdTipoComprobante As System.Int32) As adm_TiposComprobante
        Return dl.adm_TiposComprobanteSelectByPK(IdTipoComprobante)
    End Function

    Public Sub adm_TiposComprobanteDeleteByPK(ByVal IdTipoComprobante As System.Int32)
        dl.adm_TiposComprobanteDeleteByPK(IdTipoComprobante)
    End Sub

    Public Sub adm_TiposComprobanteInsert(ByVal entidad As adm_TiposComprobante)
        dl.adm_TiposComprobanteInsert(entidad)
    End Sub

    Public Sub adm_TiposComprobanteUpdate(ByVal entidad As adm_TiposComprobante)
        dl.adm_TiposComprobanteUpdate(entidad)
    End Sub

    Public Function adm_SeriesDocumentosSelectAll() As DataTable
        Return dl.adm_SeriesDocumentosSelectAll()
    End Function

    Public Function adm_SeriesDocumentosSelectByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal IdPunto As System.Int32 _
      , ByVal IdTipoComprobante As System.Int32 _
      , ByVal Serie As System.String _
      ) As adm_SeriesDocumentos

        Return dl.adm_SeriesDocumentosSelectByPK( _
         IdSucursal _
         , IdPunto _
         , IdTipoComprobante _
         , Serie _
         )
    End Function

    Public Sub adm_SeriesDocumentosDeleteByPK _
      (ByVal IdSucursal As System.Int32 _
      , ByVal IdPunto As System.Int32 _
      , ByVal IdTipoComprobante As System.Int32 _
      , ByVal Serie As System.String _
      )

        dl.adm_SeriesDocumentosDeleteByPK( _
         IdSucursal _
         , IdPunto _
         , IdTipoComprobante _
         , Serie _
         )
    End Sub

    Public Sub adm_SeriesDocumentosInsert _
    (ByVal entidad As adm_SeriesDocumentos)

        dl.adm_SeriesDocumentosInsert(entidad)
    End Sub

    Public Sub adm_SeriesDocumentosUpdate _
    (ByVal entidad As adm_SeriesDocumentos)

        dl.adm_SeriesDocumentosUpdate(entidad)
    End Sub

    Public Function adm_cantonesSelectAll() As DataTable
        Return dl.adm_cantonesSelectAll()
    End Function

    Public Function adm_cantonesSelectByPK _
      (ByVal IdCanton As System.String _
      ) As adm_cantones

        Return dl.adm_cantonesSelectByPK( _
         IdCanton _
         )
    End Function

    Public Function adm_spCantonesSelectByPK _
  (ByVal Id As System.Int32 _
  ) As adm_cantones

        Return dl.adm_spcantonesSelectByPK( _
         Id _
         )
    End Function


    Public Sub adm_cantonesDeleteByPK _
      (ByVal IdCanton As System.String _
      )

        dl.adm_cantonesDeleteByPK( _
         IdCanton _
         )
    End Sub

    Public Sub adm_cantonesInsert _
    (ByVal entidad As adm_cantones)

        dl.adm_cantonesInsert(entidad)
    End Sub

    Public Sub adm_cantonesUpdate _
    (ByVal entidad As adm_cantones)

        dl.adm_cantonesUpdate(entidad)
    End Sub

    Public Function adm_MunicipiosSelectAll() As DataTable
        Return dl.adm_MunicipiosSelectAll()
    End Function

    Public Function adm_MunicipiosSelectByPK _
      (ByVal IdMunicipio As System.String _
      ) As adm_Municipios

        Return dl.adm_MunicipiosSelectByPK( _
         IdMunicipio _
         )
    End Function

    Public Sub adm_MunicipiosDeleteByPK _
      (ByVal IdMunicipio As System.String _
      )

        dl.adm_MunicipiosDeleteByPK( _
         IdMunicipio _
         )
    End Sub

    Public Sub adm_MunicipiosInsert _
    (ByVal entidad As adm_Municipios)

        dl.adm_MunicipiosInsert(entidad)
    End Sub

    Public Sub adm_MunicipiosUpdate _
    (ByVal entidad As adm_Municipios)

        dl.adm_MunicipiosUpdate(entidad)
    End Sub


    Public Sub adm_ParametrosUpdate _
    (ByVal entidad As adm_Parametros)

        dl.adm_ParametrosUpdate(entidad)
    End Sub

    Public Function adm_DepartamentosSelectAll() As DataTable
        Return dl.adm_DepartamentosSelectAll()
    End Function

    Public Function adm_DepartamentosSelectByPK _
      (ByVal IdDepartamento As System.String _
      ) As adm_Departamentos

        Return dl.adm_DepartamentosSelectByPK( _
         IdDepartamento _
         )
    End Function

    Public Sub adm_DepartamentosDeleteByPK _
      (ByVal IdDepartamento As System.String _
      )

        dl.adm_DepartamentosDeleteByPK( _
         IdDepartamento _
         )
    End Sub

    Public Sub adm_DepartamentosInsert _
    (ByVal entidad As adm_Departamentos)

        dl.adm_DepartamentosInsert(entidad)
    End Sub

    Public Sub adm_DepartamentosUpdate _
    (ByVal entidad As adm_Departamentos)

        dl.adm_DepartamentosUpdate(entidad)
    End Sub

    Public Function coo_CuentasGastosSelectAll() As DataTable
        Return dl.coo_CuentasGastosSelectAll()
    End Function

    Public Function coo_CuentasGastosSelectByPK _
      (ByVal IdRubro As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasGastos

        Return dl.coo_CuentasGastosSelectByPK( _
         IdRubro _
         , IdCuenta _
         )
    End Function

    Public Sub coo_CuentasGastosDeleteByPK _
      (ByVal IdRubro As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      )

        dl.coo_CuentasGastosDeleteByPK( _
         IdRubro _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasGastosInsert _
    (ByVal entidad As coo_CuentasGastos)

        dl.coo_CuentasGastosInsert(entidad)
    End Sub

    Public Sub coo_CuentasGastosUpdate _
    (ByVal entidad As coo_CuentasGastos)

        dl.coo_CuentasGastosUpdate(entidad)
    End Sub



#End Region

#Region "Aportaciones"
#Region "coo_AyudaFuneraria"
    Public Function coo_AyudaFunerariaSelectAll() As DataTable
        Return dl.coo_AyudaFunerariaSelectAll()
    End Function

    Public Function coo_AyudaFunerariaSelectByPK _
      (ByVal IdMovimiento As System.Int32 _
      ) As coo_AyudaFuneraria

        Return dl.coo_AyudaFunerariaSelectByPK( _
         IdMovimiento _
         )
    End Function

    Public Sub coo_AyudaFunerariaDeleteByPK _
      (ByVal IdMovimiento As System.Int32 _
      )

        dl.coo_AyudaFunerariaDeleteByPK( _
         IdMovimiento _
         )
    End Sub

    Public Sub coo_AyudaFunerariaInsert _
    (ByVal entidad As coo_AyudaFuneraria)

        dl.coo_AyudaFunerariaInsert(entidad)
    End Sub

    Public Sub coo_AyudaFunerariaUpdate _
    (ByVal entidad As coo_AyudaFuneraria)

        dl.coo_AyudaFunerariaUpdate(entidad)
    End Sub



#End Region


    Public Function coo_MovFunerariaSelectAll() As DataTable
        Return dl.coo_MovFunerariaSelectAll()
    End Function

    Public Function coo_MovFunerariaSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_MovFuneraria

        Return dl.coo_MovFunerariaSelectByPK( _
         IdAsociado _
         , IdMov _
         )
    End Function

    Public Sub coo_MovFunerariaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        dl.coo_MovFunerariaDeleteByPK( _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_MovFunerariaInsert _
    (ByVal entidad As coo_MovFuneraria)

        dl.coo_MovFunerariaInsert(entidad)
    End Sub

    Public Sub coo_MovFunerariaUpdate _
    (ByVal entidad As coo_MovFuneraria)

        dl.coo_MovFunerariaUpdate(entidad)
    End Sub




    Public Function coo_ActividadesSelectAll() As DataTable
        Return dl.coo_ActividadesSelectAll()
    End Function

    Public Function coo_ActividadesSelectByPK _
      (ByVal IdActividad As System.Int32 _
      ) As coo_Actividades

        Return dl.coo_ActividadesSelectByPK( _
         IdActividad _
         )
    End Function

    Public Sub coo_ActividadesDeleteByPK _
      (ByVal IdActividad As System.Int32 _
      )

        dl.coo_ActividadesDeleteByPK( _
         IdActividad _
         )
    End Sub

    Public Sub coo_ActividadesInsert _
    (ByVal entidad As coo_Actividades)

        dl.coo_ActividadesInsert(entidad)
    End Sub

    Public Sub coo_ActividadesUpdate _
    (ByVal entidad As coo_Actividades)

        dl.coo_ActividadesUpdate(entidad)
    End Sub

    Public Function coo_RubrosActividadesSelectAll() As DataTable
        Return dl.coo_RubrosActividadesSelectAll()
    End Function

    Public Function coo_RubrosActividadesSelectByPK _
      (ByVal IdRubro As System.Int16 _
      ) As coo_RubrosActividades

        Return dl.coo_RubrosActividadesSelectByPK( _
         IdRubro _
         )
    End Function

    Public Sub coo_RubrosActividadesDeleteByPK _
      (ByVal IdRubro As System.Int16 _
      )

        dl.coo_RubrosActividadesDeleteByPK( _
         IdRubro _
         )
    End Sub

    Public Sub coo_RubrosActividadesInsert _
    (ByVal entidad As coo_RubrosActividades)

        dl.coo_RubrosActividadesInsert(entidad)
    End Sub

    Public Sub coo_RubrosActividadesUpdate _
    (ByVal entidad As coo_RubrosActividades)

        dl.coo_RubrosActividadesUpdate(entidad)
    End Sub
    Public Function coo_AsociadosSelectAll() As DataTable
        Return dl.coo_AsociadosSelectAll()
    End Function

    Public Function coo_AsociadosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      ) As coo_Asociados

        Return dl.coo_AsociadosSelectByPK( _
         IdAsociado _
         )
    End Function

    Public Sub coo_AsociadosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      )

        dl.coo_AsociadosDeleteByPK( _
         IdAsociado _
         )
    End Sub

    Public Sub coo_AsociadosInsert _
    (ByVal entidad As coo_Asociados)

        dl.coo_AsociadosInsert(entidad)
    End Sub

    Public Sub coo_AsociadosUpdate _
    (ByVal entidad As coo_Asociados)

        dl.coo_AsociadosUpdate(entidad)
    End Sub

    Public Function coo_AsociadosCambioDescuentosSelectAll() As DataTable
        Return dl.coo_AsociadosCambioDescuentosSelectAll()
    End Function

    Public Function coo_AsociadosCambioDescuentosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Fecha As System.DateTime _
      ) As coo_AsociadosCambioDescuentos

        Return dl.coo_AsociadosCambioDescuentosSelectByPK( _
         IdAsociado _
         , IdDetalle _
         , Fecha _
         )
    End Function

    Public Sub coo_AsociadosCambioDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      , ByVal Fecha As System.DateTime _
      )

        dl.coo_AsociadosCambioDescuentosDeleteByPK( _
         IdAsociado _
         , IdDetalle _
         , Fecha _
         )
    End Sub

    Public Sub coo_AsociadosCambioDescuentosInsert _
    (ByVal entidad As coo_AsociadosCambioDescuentos)

        dl.coo_AsociadosCambioDescuentosInsert(entidad)
    End Sub

    Public Sub coo_AsociadosCambioDescuentosUpdate _
    (ByVal entidad As coo_AsociadosCambioDescuentos)

        dl.coo_AsociadosCambioDescuentosUpdate(entidad)
    End Sub

    Public Function coo_SolicitudRetiroPrestamosSelectAll() As DataTable
        Return dl.coo_SolicitudRetiroPrestamosSelectAll()
    End Function

    Public Function coo_SolicitudRetiroPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudRetiroPrestamos

        Return dl.coo_SolicitudRetiroPrestamosSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_SolicitudRetiroPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_SolicitudRetiroPrestamosDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosInsert _
    (ByVal entidad As coo_SolicitudRetiroPrestamos)

        dl.coo_SolicitudRetiroPrestamosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudRetiroPrestamosUpdate _
    (ByVal entidad As coo_SolicitudRetiroPrestamos)

        dl.coo_SolicitudRetiroPrestamosUpdate(entidad)
    End Sub



    Public Function coo_AsociadosBeneficiariosSelectAll() As DataTable
        Return dl.coo_AsociadosBeneficiariosSelectAll()
    End Function

    Public Function coo_AsociadosBeneficiariosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdBeneficiario As System.Byte _
      ) As coo_AsociadosBeneficiarios

        Return dl.coo_AsociadosBeneficiariosSelectByPK( _
         IdAsociado _
         , IdBeneficiario _
         )
    End Function

    Public Sub coo_AsociadosBeneficiariosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdBeneficiario As System.Byte _
      )

        dl.coo_AsociadosBeneficiariosDeleteByPK( _
         IdAsociado _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_AsociadosBeneficiariosInsert _
    (ByVal entidad As coo_AsociadosBeneficiarios)

        dl.coo_AsociadosBeneficiariosInsert(entidad)
    End Sub

    Public Sub coo_AsociadosBeneficiariosUpdate _
    (ByVal entidad As coo_AsociadosBeneficiarios)

        dl.coo_AsociadosBeneficiariosUpdate(entidad)
    End Sub
    Public Function coo_AsociadosDescuentosSelectAll() As DataTable
        Return dl.coo_AsociadosDescuentosSelectAll()
    End Function

    Public Function coo_AsociadosDescuentosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As coo_AsociadosDescuentos

        Return dl.coo_AsociadosDescuentosSelectByPK( _
         IdAsociado _
         , IdDetalle _
         )
    End Function

    Public Sub coo_AsociadosDescuentosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        dl.coo_AsociadosDescuentosDeleteByPK( _
         IdAsociado _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_AsociadosDescuentosInsert _
    (ByVal entidad As coo_AsociadosDescuentos)

        dl.coo_AsociadosDescuentosInsert(entidad)
    End Sub

    Public Sub coo_AsociadosDescuentosUpdate _
    (ByVal entidad As coo_AsociadosDescuentos)

        dl.coo_AsociadosDescuentosUpdate(entidad)
    End Sub


    Public Function coo_ProfesionesSelectAll() As DataTable
        Return dl.coo_ProfesionesSelectAll()
    End Function

    Public Function coo_ProfesionesSelectByPK _
      (ByVal IdProfesion As System.Int16 _
      ) As coo_Profesiones

        Return dl.coo_ProfesionesSelectByPK( _
         IdProfesion _
         )
    End Function

    Public Sub coo_ProfesionesDeleteByPK _
      (ByVal IdProfesion As System.Int16 _
      )

        dl.coo_ProfesionesDeleteByPK( _
         IdProfesion _
         )
    End Sub

    Public Sub coo_ProfesionesInsert _
    (ByVal entidad As coo_Profesiones)

        dl.coo_ProfesionesInsert(entidad)
    End Sub

    Public Sub coo_ProfesionesUpdate _
    (ByVal entidad As coo_Profesiones)

        dl.coo_ProfesionesUpdate(entidad)
    End Sub

    Public Function coo_TipoDocumentoSelectAll() As DataTable
        Return dl.coo_TipoDocumentoSelectAll()
    End Function

    Public Function coo_TipoDocumentoSelectByPK _
      (ByVal IdTipo As System.Int32 _
      ) As coo_TipoDocumento

        Return dl.coo_TipoDocumentoSelectByPK( _
         IdTipo _
         )
    End Function

    Public Sub coo_TipoDocumentoDeleteByPK _
      (ByVal IdTipo As System.Int32 _
      )

        dl.coo_TipoDocumentoDeleteByPK( _
         IdTipo _
         )
    End Sub

    Public Sub coo_TipoDocumentoInsert _
    (ByVal entidad As coo_TipoDocumento)

        dl.coo_TipoDocumentoInsert(entidad)
    End Sub

    Public Sub coo_TipoDocumentoUpdate _
    (ByVal entidad As coo_TipoDocumento)

        dl.coo_TipoDocumentoUpdate(entidad)
    End Sub


    Public Function coo_LiquidacionAportacionesSelectAll() As DataTable
        Return dl.coo_LiquidacionAportacionesSelectAll()
    End Function

    Public Function coo_LiquidacionAportacionesSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal NumeroDoc As System.String _
      ) As coo_LiquidacionAportaciones

        Return dl.coo_LiquidacionAportacionesSelectByPK( _
         IdAsociado _
         , NumeroDoc _
         )
    End Function

    Public Sub coo_LiquidacionAportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal NumeroDoc As System.String _
      )

        dl.coo_LiquidacionAportacionesDeleteByPK( _
         IdAsociado _
         , NumeroDoc _
         )
    End Sub

    Public Sub coo_LiquidacionAportacionesInsert _
    (ByVal entidad As coo_LiquidacionAportaciones)

        dl.coo_LiquidacionAportacionesInsert(entidad)
    End Sub

    Public Sub coo_LiquidacionAportacionesUpdate _
    (ByVal entidad As coo_LiquidacionAportaciones)

        dl.coo_LiquidacionAportacionesUpdate(entidad)
    End Sub

    Public Function coo_AportacionesSelectAll() As DataTable
        Return dl.coo_AportacionesSelectAll()
    End Function

    Public Function coo_AportacionesSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_Aportaciones

        Return dl.coo_AportacionesSelectByPK( _
         IdAsociado _
         , IdMov _
         )
    End Function

    Public Sub coo_AportacionesDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        dl.coo_AportacionesDeleteByPK( _
         IdAsociado _
         , IdMov _
         )
    End Sub

    Public Sub coo_AportacionesInsert _
    (ByVal entidad As coo_Aportaciones)

        dl.coo_AportacionesInsert(entidad)
    End Sub

    Public Sub coo_AportacionesUpdate _
    (ByVal entidad As coo_Aportaciones)

        dl.coo_AportacionesUpdate(entidad)
    End Sub
#End Region

#Region "Ahorros"
    Public Function coo_TiposCuentaAhorroSelectAll() As DataTable
        Return dl.coo_TiposCuentaAhorroSelectAll()
    End Function

    Public Function coo_TiposCuentaAhorroSelectByPK _
      (ByVal IdTipo As System.Byte _
      ) As coo_TiposCuentaAhorro

        Return dl.coo_TiposCuentaAhorroSelectByPK( _
         IdTipo _
         )
    End Function

    Public Sub coo_TiposCuentaAhorroDeleteByPK _
      (ByVal IdTipo As System.Byte _
      )

        dl.coo_TiposCuentaAhorroDeleteByPK( _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposCuentaAhorroInsert _
    (ByVal entidad As coo_TiposCuentaAhorro)

        dl.coo_TiposCuentaAhorroInsert(entidad)
    End Sub

    Public Sub coo_TiposCuentaAhorroUpdate _
    (ByVal entidad As coo_TiposCuentaAhorro)

        dl.coo_TiposCuentaAhorroUpdate(entidad)
    End Sub



    Public Function coo_CuentasAhorroSelectAll() As DataTable
        Return dl.coo_CuentasAhorroSelectAll()
    End Function

    Public Function coo_CuentasAhorroSelectByPK _
      (ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasAhorro

        Return dl.coo_CuentasAhorroSelectByPK( _
         IdCuenta _
         )
    End Function

    Public Sub coo_CuentasAhorroDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      )

        dl.coo_CuentasAhorroDeleteByPK( _
         IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasAhorroInsert _
    (ByVal entidad As coo_CuentasAhorro)

        dl.coo_CuentasAhorroInsert(entidad)
    End Sub

    Public Sub coo_CuentasAhorroUpdate _
    (ByVal entidad As coo_CuentasAhorro)

        dl.coo_CuentasAhorroUpdate(entidad)
    End Sub

    Public Function coo_CuentasAhorroAutorizadoSelectAll() As DataTable
        Return dl.coo_CuentasAhorroAutorizadoSelectAll()
    End Function

    Public Function coo_CuentasAhorroAutorizadoSelectByPK _
      (ByVal IdAutorizado As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      ) As coo_CuentasAhorroAutorizado

        Return dl.coo_CuentasAhorroAutorizadoSelectByPK( _
         IdAutorizado _
         , IdCuenta _
         )
    End Function

    Public Sub coo_CuentasAhorroAutorizadoDeleteByPK _
      (ByVal IdAutorizado As System.Int32 _
      , ByVal IdCuenta As System.Int32 _
      )

        dl.coo_CuentasAhorroAutorizadoDeleteByPK( _
         IdAutorizado _
         , IdCuenta _
         )
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoInsert _
    (ByVal entidad As coo_CuentasAhorroAutorizado)

        dl.coo_CuentasAhorroAutorizadoInsert(entidad)
    End Sub

    Public Sub coo_CuentasAhorroAutorizadoUpdate _
    (ByVal entidad As coo_CuentasAhorroAutorizado)

        dl.coo_CuentasAhorroAutorizadoUpdate(entidad)
    End Sub

    Public Function coo_CuentasAhorroMovSelectAll() As DataTable
        Return dl.coo_CuentasAhorroMovSelectAll()
    End Function

    Public Function coo_CuentasAhorroMovSelectByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_CuentasAhorroMov

        Return dl.coo_CuentasAhorroMovSelectByPK( _
         IdCuenta _
         , IdMov _
         )
    End Function

    Public Sub coo_CuentasAhorroMovDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        dl.coo_CuentasAhorroMovDeleteByPK( _
         IdCuenta _
         , IdMov _
         )
    End Sub

    Public Sub coo_CuentasAhorroMovInsert _
    (ByVal entidad As coo_CuentasAhorroMov)

        dl.coo_CuentasAhorroMovInsert(entidad)
    End Sub

    Public Sub coo_CuentasAhorroMovUpdate _
    (ByVal entidad As coo_CuentasAhorroMov)

        dl.coo_CuentasAhorroMovUpdate(entidad)
    End Sub

    Public Function coo_CuentasAhorroBeneficiariosSelectAll() As DataTable
        Return dl.coo_CuentasAhorroBeneficiariosSelectAll()
    End Function

    Public Function coo_CuentasAhorroBeneficiariosSelectByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdBeneficiario As System.Int32 _
      ) As coo_CuentasAhorroBeneficiarios

        Return dl.coo_CuentasAhorroBeneficiariosSelectByPK( _
         IdCuenta _
         , IdBeneficiario _
         )
    End Function

    Public Sub coo_CuentasAhorroBeneficiariosDeleteByPK _
      (ByVal IdCuenta As System.Int32 _
      , ByVal IdBeneficiario As System.Int32 _
      )

        dl.coo_CuentasAhorroBeneficiariosDeleteByPK( _
         IdCuenta _
         , IdBeneficiario _
         )
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosInsert _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios)

        dl.coo_CuentasAhorroBeneficiariosInsert(entidad)
    End Sub

    Public Sub coo_CuentasAhorroBeneficiariosUpdate _
    (ByVal entidad As coo_CuentasAhorroBeneficiarios)

        dl.coo_CuentasAhorroBeneficiariosUpdate(entidad)
    End Sub

    Public Function coo_CierresAhorroSelectAll() As DataTable
        Return dl.coo_CierresAhorroSelectAll()
    End Function

    Public Function coo_CierresAhorroSelectByPK _
      (ByVal ejercicio As System.Int32 _
      , ByVal mes As System.Int32 _
      ) As coo_CierresAhorro

        Return dl.coo_CierresAhorroSelectByPK( _
         ejercicio _
         , mes _
         )
    End Function

    Public Sub coo_CierresAhorroDeleteByPK _
      (ByVal ejercicio As System.Int32 _
      , ByVal mes As System.Int32 _
      )

        dl.coo_CierresAhorroDeleteByPK( _
         ejercicio _
         , mes _
         )
    End Sub

    Public Sub coo_CierresAhorroInsert _
    (ByVal entidad As coo_CierresAhorro)

        dl.coo_CierresAhorroInsert(entidad)
    End Sub

    Public Sub coo_CierresAhorroUpdate _
    (ByVal entidad As coo_CierresAhorro)

        dl.coo_CierresAhorroUpdate(entidad)
    End Sub


#End Region

#Region "Prestamos"
    Public Function coo_FechasDescuentosSelectAll() As DataTable
        Return dl.coo_FechasDescuentosSelectAll()
    End Function

    Public Function coo_FechasDescuentosSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As coo_FechasDescuentos

        Return dl.coo_FechasDescuentosSelectByPK( _
         IdComprobante _
         )
    End Function

    Public Sub coo_FechasDescuentosDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        dl.coo_FechasDescuentosDeleteByPK( _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FechasDescuentosInsert _
    (ByVal entidad As coo_FechasDescuentos)

        dl.coo_FechasDescuentosInsert(entidad)
    End Sub

    Public Sub coo_FechasDescuentosUpdate _
    (ByVal entidad As coo_FechasDescuentos)

        dl.coo_FechasDescuentosUpdate(entidad)
    End Sub
    Public Function coo_DividendosSelectAll() As DataTable
        Return dl.coo_DividendosSelectAll()
    End Function

    Public Function coo_DividendosSelectByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Periodo As System.Int32 _
      ) As coo_Dividendos

        Return dl.coo_DividendosSelectByPK( _
         IdAsociado _
         , Periodo _
         )
    End Function

    Public Sub coo_DividendosDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
      , ByVal Periodo As System.Int32 _
      )

        dl.coo_DividendosDeleteByPK( _
         IdAsociado _
         , Periodo _
         )
    End Sub

    Public Sub coo_DividendosInsert _
    (ByVal entidad As coo_Dividendos)

        dl.coo_DividendosInsert(entidad)
    End Sub

    Public Sub coo_DividendosUpdate _
    (ByVal entidad As coo_Dividendos)

        dl.coo_DividendosUpdate(entidad)
    End Sub
    Public Function coo_DividendosLineasSelectAll() As DataTable
        Return dl.coo_DividendosLineasSelectAll()
    End Function

    Public Function coo_DividendosLineasSelectByPK _
      (ByVal Periodo As System.Int32 _
      , ByVal IdLinea As System.Int32 _
      ) As coo_DividendosLineas

        Return dl.coo_DividendosLineasSelectByPK( _
         Periodo _
         , IdLinea _
         )
    End Function

    Public Sub coo_DividendosLineasDeleteByPK _
      (ByVal Periodo As System.Int32 _
      , ByVal IdLinea As System.Int32 _
      )

        dl.coo_DividendosLineasDeleteByPK( _
         Periodo _
         , IdLinea _
         )
    End Sub

    Public Sub coo_DividendosLineasInsert _
    (ByVal entidad As coo_DividendosLineas)

        dl.coo_DividendosLineasInsert(entidad)
    End Sub

    Public Sub coo_DividendosLineasUpdate _
    (ByVal entidad As coo_DividendosLineas)

        dl.coo_DividendosLineasUpdate(entidad)
    End Sub











    Public Function coo_AlertasSelectAll() As DataTable
        Return dl.coo_AlertasSelectAll()
    End Function

    Public Function coo_AlertasSelectByPK _
      (ByVal IdAlerta As System.Int32 _
      ) As coo_Alertas

        Return dl.coo_AlertasSelectByPK( _
         IdAlerta _
         )
    End Function

    Public Sub coo_AlertasDeleteByPK _
      (ByVal IdAlerta As System.Int32 _
      )

        dl.coo_AlertasDeleteByPK( _
         IdAlerta _
         )
    End Sub

    Public Sub coo_AlertasInsert _
    (ByVal entidad As coo_Alertas)

        dl.coo_AlertasInsert(entidad)
    End Sub

    Public Sub coo_AlertasUpdate _
    (ByVal entidad As coo_Alertas)

        dl.coo_AlertasUpdate(entidad)
    End Sub




    Public Function coo_CorteCajaChequesSelectAll() As DataTable
        Return dl.coo_CorteCajaChequesSelectAll()
    End Function

    Public Function coo_CorteCajaChequesSelectByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      ) As coo_CorteCajaCheques

        Return dl.coo_CorteCajaChequesSelectByPK( _
         IdCorte _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Function

    Public Sub coo_CorteCajaChequesDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      )

        dl.coo_CorteCajaChequesDeleteByPK( _
         IdCorte _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_CorteCajaChequesInsert _
    (ByVal entidad As coo_CorteCajaCheques)

        dl.coo_CorteCajaChequesInsert(entidad)
    End Sub

    Public Sub coo_CorteCajaChequesUpdate _
    (ByVal entidad As coo_CorteCajaCheques)

        dl.coo_CorteCajaChequesUpdate(entidad)
    End Sub




    Public Function coo_FormasPagoCajaSelectAll() As DataTable
        Return dl.coo_FormasPagoCajaSelectAll()
    End Function

    Public Function coo_FormasPagoCajaSelectByPK _
      (ByVal IdFormaPago As System.Byte _
      ) As coo_FormasPagoCaja

        Return dl.coo_FormasPagoCajaSelectByPK( _
         IdFormaPago _
         )
    End Function

    Public Sub coo_FormasPagoCajaDeleteByPK _
      (ByVal IdFormaPago As System.Byte _
      )

        dl.coo_FormasPagoCajaDeleteByPK( _
         IdFormaPago _
         )
    End Sub

    Public Sub coo_FormasPagoCajaInsert _
    (ByVal entidad As coo_FormasPagoCaja)

        dl.coo_FormasPagoCajaInsert(entidad)
    End Sub

    Public Sub coo_FormasPagoCajaUpdate _
    (ByVal entidad As coo_FormasPagoCaja)

        dl.coo_FormasPagoCajaUpdate(entidad)
    End Sub

    Public Function coo_FuentesSelectAll() As DataTable
        Return dl.coo_FuentesSelectAll()
    End Function

    Public Function coo_FuentesSelectByPK _
      (ByVal IdFuente As System.Int16 _
      ) As coo_Fuentes

        Return dl.coo_FuentesSelectByPK( _
         IdFuente _
         )
    End Function

    Public Sub coo_FuentesDeleteByPK _
      (ByVal IdFuente As System.Int16 _
      )

        dl.coo_FuentesDeleteByPK( _
         IdFuente _
         )
    End Sub

    Public Sub coo_FuentesInsert _
    (ByVal entidad As coo_Fuentes)

        dl.coo_FuentesInsert(entidad)
    End Sub

    Public Sub coo_FuentesUpdate _
    (ByVal entidad As coo_Fuentes)

        dl.coo_FuentesUpdate(entidad)
    End Sub
    Public Function coo_SolicitudesCrucesSelectAll() As DataTable
        Return dl.coo_SolicitudesCrucesSelectAll()
    End Function

    Public Function coo_SolicitudesCrucesSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesCruces

        Return dl.coo_SolicitudesCrucesSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesCrucesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesCrucesDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesInsert _
    (ByVal entidad As coo_SolicitudesCruces)

        dl.coo_SolicitudesCrucesInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesCrucesUpdate _
    (ByVal entidad As coo_SolicitudesCruces)

        dl.coo_SolicitudesCrucesUpdate(entidad)
    End Sub
    Public Function coo_SolicitudesCrucesAhorrosSelectAll() As DataTable
        Return dl.coo_SolicitudesCrucesAhorrosSelectAll()
    End Function

    Public Function coo_SolicitudesCrucesAhorrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesCrucesAhorros

        Return dl.coo_SolicitudesCrucesAhorrosSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_SolicitudesCrucesAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_SolicitudesCrucesAhorrosDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosInsert _
    (ByVal entidad As coo_SolicitudesCrucesAhorros)

        dl.coo_SolicitudesCrucesAhorrosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesCrucesAhorrosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesAhorros)

        dl.coo_SolicitudesCrucesAhorrosUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesCrucesPrestamosSelectAll() As DataTable
        Return dl.coo_SolicitudesCrucesPrestamosSelectAll()
    End Function

    Public Function coo_SolicitudesCrucesPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesCrucesPrestamos

        Return dl.coo_SolicitudesCrucesPrestamosSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_SolicitudesCrucesPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_SolicitudesCrucesPrestamosDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosInsert _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos)

        dl.coo_SolicitudesCrucesPrestamosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesCrucesPrestamosUpdate _
    (ByVal entidad As coo_SolicitudesCrucesPrestamos)

        dl.coo_SolicitudesCrucesPrestamosUpdate(entidad)
    End Sub




    Public Function coo_SolicitudesDescuentosCuotaSelectAll() As DataTable
        Return dl.coo_SolicitudesDescuentosCuotaSelectAll()
    End Function

    Public Function coo_SolicitudesDescuentosCuotaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesDescuentosCuota

        Return dl.coo_SolicitudesDescuentosCuotaSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_SolicitudesDescuentosCuotaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_SolicitudesDescuentosCuotaDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaInsert _
    (ByVal entidad As coo_SolicitudesDescuentosCuota)

        dl.coo_SolicitudesDescuentosCuotaInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesDescuentosCuotaUpdate _
    (ByVal entidad As coo_SolicitudesDescuentosCuota)

        dl.coo_SolicitudesDescuentosCuotaUpdate(entidad)
    End Sub




    Public Function coo_LineasSelectAll() As DataTable
        Return dl.coo_LineasSelectAll()
    End Function

    Public Function coo_LineasSelectByPK _
      (ByVal IdLinea As System.Int16 _
      ) As coo_Lineas

        Return dl.coo_LineasSelectByPK( _
         IdLinea _
         )
    End Function

    Public Sub coo_LineasDeleteByPK _
      (ByVal IdLinea As System.Int16 _
      )

        dl.coo_LineasDeleteByPK( _
         IdLinea _
         )
    End Sub

    Public Sub coo_LineasInsert _
    (ByVal entidad As coo_Lineas)

        dl.coo_LineasInsert(entidad)
    End Sub

    Public Sub coo_LineasUpdate _
    (ByVal entidad As coo_Lineas)

        dl.coo_LineasUpdate(entidad)
    End Sub

    Public Function coo_TecnicosSelectAll() As DataTable
        Return dl.coo_TecnicosSelectAll()
    End Function

    Public Function coo_TecnicosSelectByPK _
      (ByVal IdTecnico As System.Int16 _
      ) As coo_Tecnicos

        Return dl.coo_TecnicosSelectByPK( _
         IdTecnico _
         )
    End Function

    Public Sub coo_TecnicosDeleteByPK _
      (ByVal IdTecnico As System.Int16 _
      )

        dl.coo_TecnicosDeleteByPK( _
         IdTecnico _
         )
    End Sub

    Public Sub coo_TecnicosInsert _
    (ByVal entidad As coo_Tecnicos)

        dl.coo_TecnicosInsert(entidad)
    End Sub

    Public Sub coo_TecnicosUpdate _
    (ByVal entidad As coo_Tecnicos)

        dl.coo_TecnicosUpdate(entidad)
    End Sub

    Public Function coo_TiposMovimientoCajaSelectAll() As DataTable
        Return dl.coo_TiposMovimientoCajaSelectAll()
    End Function

    Public Function coo_TiposMovimientoCajaSelectByPK _
      (ByVal IdTipo As System.Byte _
      ) As coo_TiposMovimientoCaja

        Return dl.coo_TiposMovimientoCajaSelectByPK( _
         IdTipo _
         )
    End Function

    Public Sub coo_TiposMovimientoCajaDeleteByPK _
      (ByVal IdTipo As System.Byte _
      )

        dl.coo_TiposMovimientoCajaDeleteByPK( _
         IdTipo _
         )
    End Sub

    Public Sub coo_TiposMovimientoCajaInsert _
    (ByVal entidad As coo_TiposMovimientoCaja)

        dl.coo_TiposMovimientoCajaInsert(entidad)
    End Sub

    Public Sub coo_TiposMovimientoCajaUpdate _
    (ByVal entidad As coo_TiposMovimientoCaja)

        dl.coo_TiposMovimientoCajaUpdate(entidad)
    End Sub

    Public Function coo_TiposPrestamoSelectAll() As DataTable
        Return dl.coo_TiposPrestamoSelectAll()
    End Function

    Public Function coo_TiposPrestamoSelectByPK _
      (ByVal IdTipoPrestamo As System.Byte _
      ) As coo_TiposPrestamo

        Return dl.coo_TiposPrestamoSelectByPK( _
         IdTipoPrestamo _
         )
    End Function

    Public Sub coo_TiposPrestamoDeleteByPK _
      (ByVal IdTipoPrestamo As System.Byte _
      )

        dl.coo_TiposPrestamoDeleteByPK( _
         IdTipoPrestamo _
         )
    End Sub

    Public Sub coo_TiposPrestamoInsert _
    (ByVal entidad As coo_TiposPrestamo)

        dl.coo_TiposPrestamoInsert(entidad)
    End Sub

    Public Sub coo_TiposPrestamoUpdate _
    (ByVal entidad As coo_TiposPrestamo)

        dl.coo_TiposPrestamoUpdate(entidad)
    End Sub


    Public Function coo_SolicitudesSelectAll() As DataTable
        Return dl.coo_SolicitudesSelectAll()
    End Function

    Public Function coo_SolicitudesSelectByPK(ByVal IdSolicitud As Int32) As coo_Solicitudes
        Return dl.coo_SolicitudesSelectByPK(IdSolicitud)
    End Function

    Public Sub coo_SolicitudesDeleteByPK(ByVal IdSolicitud As System.Int32)

        dl.coo_SolicitudesDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesInsert _
    (ByVal entidad As coo_Solicitudes)

        dl.coo_SolicitudesInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesUpdate _
    (ByVal entidad As coo_Solicitudes)

        dl.coo_SolicitudesUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesBienSelectAll() As DataTable
        Return dl.coo_SolicitudesBienSelectAll()
    End Function

    Public Function coo_SolicitudesBienSelectByPK _
      (ByVal IdBien As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesBien

        Return dl.coo_SolicitudesBienSelectByPK( _
         IdBien _
         , IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesBienDeleteByPK _
      (ByVal IdBien As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesBienDeleteByPK( _
         IdBien _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesBienInsert _
    (ByVal entidad As coo_SolicitudesBien)

        dl.coo_SolicitudesBienInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesBienUpdate _
    (ByVal entidad As coo_SolicitudesBien)

        dl.coo_SolicitudesBienUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesObligacionSelectAll() As DataTable
        Return dl.coo_SolicitudesObligacionSelectAll()
    End Function

    Public Function coo_SolicitudesObligacionSelectByPK _
      (ByVal IdObligacion As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesObligacion

        Return dl.coo_SolicitudesObligacionSelectByPK( _
         IdObligacion _
         , IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesObligacionDeleteByPK _
      (ByVal IdObligacion As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesObligacionDeleteByPK( _
         IdObligacion _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesObligacionInsert _
    (ByVal entidad As coo_SolicitudesObligacion)

        dl.coo_SolicitudesObligacionInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesObligacionUpdate _
    (ByVal entidad As coo_SolicitudesObligacion)

        dl.coo_SolicitudesObligacionUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesReferenciaSelectAll() As DataTable
        Return dl.coo_SolicitudesReferenciaSelectAll()
    End Function

    Public Function coo_SolicitudesReferenciaSelectByPK _
      (ByVal IdReferencia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesReferencia

        Return dl.coo_SolicitudesReferenciaSelectByPK( _
         IdReferencia _
         , IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesReferenciaDeleteByPK _
      (ByVal IdReferencia As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesReferenciaDeleteByPK( _
         IdReferencia _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesReferenciaInsert _
    (ByVal entidad As coo_SolicitudesReferencia)

        dl.coo_SolicitudesReferenciaInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesReferenciaUpdate _
    (ByVal entidad As coo_SolicitudesReferencia)

        dl.coo_SolicitudesReferenciaUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesGarantiasSelectAll() As DataTable
        Return dl.coo_SolicitudesGarantiasSelectAll()
    End Function

    Public Function coo_SolicitudesGarantiasSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_SolicitudesGarantias

        Return dl.coo_SolicitudesGarantiasSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_SolicitudesGarantiasDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_SolicitudesGarantiasDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_SolicitudesGarantiasInsert _
    (ByVal entidad As coo_SolicitudesGarantias)

        dl.coo_SolicitudesGarantiasInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesGarantiasUpdate _
    (ByVal entidad As coo_SolicitudesGarantias)

        dl.coo_SolicitudesGarantiasUpdate(entidad)
    End Sub

    Public Function coo_TiposGarantiaSelectAll() As DataTable
        Return dl.coo_TiposGarantiaSelectAll()
    End Function

    Public Function coo_TiposGarantiaSelectByPK _
      (ByVal IdTipo As System.Int32) As coo_TiposGarantia

        Return dl.coo_TiposGarantiaSelectByPK(IdTipo)
    End Function

    Public Sub coo_TiposGarantiaDeleteByPK(ByVal IdTipo As System.Int32)

        dl.coo_TiposGarantiaDeleteByPK(IdTipo)
    End Sub

    Public Sub coo_TiposGarantiaInsert(ByVal entidad As coo_TiposGarantia)

        dl.coo_TiposGarantiaInsert(entidad)
    End Sub

    Public Sub coo_TiposGarantiaUpdate(ByVal entidad As coo_TiposGarantia)

        dl.coo_TiposGarantiaUpdate(entidad)
    End Sub


    Public Function coo_GarantiasPrendariaSelectAll() As DataTable
        Return dl.coo_GarantiasPrendariaSelectAll()
    End Function

    Public Function coo_GarantiasPrendariaSelectByPK _
      (ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As coo_GarantiasPrendaria

        Return dl.coo_GarantiasPrendariaSelectByPK(IdSolicitud, IdGarantia)
    End Function

    Public Sub coo_GarantiasPrendariaDeleteByPK _
      (ByVal IdSolicitud As System.Int32, ByVal IdGarantia As System.Int32)

        dl.coo_GarantiasPrendariaDeleteByPK(IdSolicitud, IdGarantia)
    End Sub

    Public Sub coo_GarantiasPrendariaInsert(ByVal entidad As coo_GarantiasPrendaria)

        dl.coo_GarantiasPrendariaInsert(entidad)
    End Sub

    Public Sub coo_GarantiasPrendariaUpdate(ByVal entidad As coo_GarantiasPrendaria)
        dl.coo_GarantiasPrendariaUpdate(entidad)
    End Sub


    Public Function coo_GarantiasFiadorSelectAll() As DataTable
        Return dl.coo_GarantiasFiadorSelectAll()
    End Function

    Public Function coo_GarantiasFiadorSelectByPK(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer) As coo_GarantiasFiador

        Return dl.coo_GarantiasFiadorSelectByPK(IdSolicitud, IdGarantia)
    End Function

    Public Sub coo_GarantiasFiadorDeleteByPK(ByVal IdSolicitud As Integer, ByVal IdGarantia As Integer)
        dl.coo_GarantiasFiadorDeleteByPK(IdSolicitud, IdGarantia)
    End Sub

    Public Sub coo_GarantiasFiadorInsert(ByVal entidad As coo_GarantiasFiador)

        dl.coo_GarantiasFiadorInsert(entidad)
    End Sub

    Public Sub coo_GarantiasFiadorUpdate(ByVal entidad As coo_GarantiasFiador)

        dl.coo_GarantiasFiadorUpdate(entidad)
    End Sub

    Public Function coo_FiadoresBienSelectAll() As DataTable
        Return dl.coo_FiadoresBienSelectAll()
    End Function

    Public Function coo_FiadoresBienSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdBien As System.Int32 _
      ) As coo_FiadoresBien

        Return dl.coo_FiadoresBienSelectByPK( _
         IdSolicitud _
         , IdFiador _
         , IdBien _
         )
    End Function

    Public Sub coo_FiadoresBienDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdBien As System.Int32 _
      )

        dl.coo_FiadoresBienDeleteByPK( _
         IdSolicitud _
         , IdFiador _
         , IdBien _
         )
    End Sub

    Public Sub coo_FiadoresBienInsert _
    (ByVal entidad As coo_FiadoresBien)

        dl.coo_FiadoresBienInsert(entidad)
    End Sub

    Public Sub coo_FiadoresBienUpdate _
    (ByVal entidad As coo_FiadoresBien)

        dl.coo_FiadoresBienUpdate(entidad)
    End Sub

    Public Function coo_FiadoresObligacionSelectAll() As DataTable
        Return dl.coo_FiadoresObligacionSelectAll()
    End Function

    Public Function coo_FiadoresObligacionSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdObligacion As System.Int32 _
      ) As coo_FiadoresObligacion

        Return dl.coo_FiadoresObligacionSelectByPK( _
         IdSolicitud _
         , IdFiador _
         , IdObligacion _
         )
    End Function

    Public Sub coo_FiadoresObligacionDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdObligacion As System.Int32 _
      )

        dl.coo_FiadoresObligacionDeleteByPK( _
         IdSolicitud _
         , IdFiador _
         , IdObligacion _
         )
    End Sub

    Public Sub coo_FiadoresObligacionInsert _
    (ByVal entidad As coo_FiadoresObligacion)

        dl.coo_FiadoresObligacionInsert(entidad)
    End Sub

    Public Sub coo_FiadoresObligacionUpdate _
    (ByVal entidad As coo_FiadoresObligacion)

        dl.coo_FiadoresObligacionUpdate(entidad)
    End Sub

    Public Function coo_FiadoresReferenciaSelectAll() As DataTable
        Return dl.coo_FiadoresReferenciaSelectAll()
    End Function

    Public Function coo_FiadoresReferenciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdReferencia As System.Int32 _
      ) As coo_FiadoresReferencia

        Return dl.coo_FiadoresReferenciaSelectByPK( _
         IdSolicitud _
         , IdFiador _
         , IdReferencia _
         )
    End Function

    Public Sub coo_FiadoresReferenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdFiador As System.Int32 _
      , ByVal IdReferencia As System.Int32 _
      )

        dl.coo_FiadoresReferenciaDeleteByPK( _
         IdSolicitud _
         , IdFiador _
         , IdReferencia _
         )
    End Sub

    Public Sub coo_FiadoresReferenciaInsert _
    (ByVal entidad As coo_FiadoresReferencia)

        dl.coo_FiadoresReferenciaInsert(entidad)
    End Sub

    Public Sub coo_FiadoresReferenciaUpdate _
    (ByVal entidad As coo_FiadoresReferencia)

        dl.coo_FiadoresReferenciaUpdate(entidad)
    End Sub

    Public Function coo_GarantiasHipotecaSelectAll() As DataTable
        Return dl.coo_GarantiasHipotecaSelectAll()
    End Function

    Public Function coo_GarantiasHipotecaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      ) As coo_GarantiasHipoteca

        Return dl.coo_GarantiasHipotecaSelectByPK( _
         IdSolicitud _
         , IdGarantia _
         )
    End Function

    Public Sub coo_GarantiasHipotecaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      )

        dl.coo_GarantiasHipotecaDeleteByPK( _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasHipotecaInsert _
    (ByVal entidad As coo_GarantiasHipoteca)

        dl.coo_GarantiasHipotecaInsert(entidad)
    End Sub

    Public Sub coo_GarantiasHipotecaUpdate _
    (ByVal entidad As coo_GarantiasHipoteca)

        dl.coo_GarantiasHipotecaUpdate(entidad)
    End Sub

    Public Function coo_GarantiasCuentaPignoradaSelectAll() As DataTable
        Return dl.coo_GarantiasCuentaPignoradaSelectAll()
    End Function

    Public Function coo_GarantiasCuentaPignoradaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      ) As coo_GarantiasCuentaPignorada

        Return dl.coo_GarantiasCuentaPignoradaSelectByPK( _
         IdSolicitud _
         , IdGarantia _
         )
    End Function

    Public Sub coo_GarantiasCuentaPignoradaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal IdGarantia As System.Int32 _
      )

        dl.coo_GarantiasCuentaPignoradaDeleteByPK( _
         IdSolicitud _
         , IdGarantia _
         )
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaInsert _
    (ByVal entidad As coo_GarantiasCuentaPignorada)

        dl.coo_GarantiasCuentaPignoradaInsert(entidad)
    End Sub

    Public Sub coo_GarantiasCuentaPignoradaUpdate _
    (ByVal entidad As coo_GarantiasCuentaPignorada)

        dl.coo_GarantiasCuentaPignoradaUpdate(entidad)
    End Sub

    Public Function coo_DictamenTecnicoSelectAll() As DataTable
        Return dl.coo_DictamenTecnicoSelectAll()
    End Function

    Public Function coo_DictamenTecnicoSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_DictamenTecnico

        Return dl.coo_DictamenTecnicoSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_DictamenTecnicoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_DictamenTecnicoDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenTecnicoInsert _
    (ByVal entidad As coo_DictamenTecnico)

        dl.coo_DictamenTecnicoInsert(entidad)
    End Sub

    Public Sub coo_DictamenTecnicoUpdate _
    (ByVal entidad As coo_DictamenTecnico)

        dl.coo_DictamenTecnicoUpdate(entidad)
    End Sub

    Public Function coo_DictamenGerenciaSelectAll() As DataTable
        Return dl.coo_DictamenGerenciaSelectAll()
    End Function

    Public Function coo_DictamenGerenciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_DictamenGerencia

        Return dl.coo_DictamenGerenciaSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_DictamenGerenciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_DictamenGerenciaDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_DictamenGerenciaInsert _
    (ByVal entidad As coo_DictamenGerencia)

        dl.coo_DictamenGerenciaInsert(entidad)
    End Sub

    Public Sub coo_DictamenGerenciaUpdate _
    (ByVal entidad As coo_DictamenGerencia)

        dl.coo_DictamenGerenciaUpdate(entidad)
    End Sub

    Public Function coo_ResolucionesSelectAll() As DataTable
        Return dl.coo_ResolucionesSelectAll()
    End Function

    Public Function coo_ResolucionesSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_Resoluciones

        Return dl.coo_ResolucionesSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_ResolucionesDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_ResolucionesDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_ResolucionesInsert _
    (ByVal entidad As coo_Resoluciones)

        dl.coo_ResolucionesInsert(entidad)
    End Sub

    Public Sub coo_ResolucionesUpdate _
    (ByVal entidad As coo_Resoluciones)

        dl.coo_ResolucionesUpdate(entidad)
    End Sub

    Public Function coo_DeduccionesPrestamoSelectAll() As DataTable
        Return dl.coo_DeduccionesPrestamoSelectAll()
    End Function

    Public Function coo_DeduccionesPrestamoSelectByPK _
      (ByVal IdDeduccion As System.Int32 _
      ) As coo_DeduccionesPrestamo

        Return dl.coo_DeduccionesPrestamoSelectByPK( _
         IdDeduccion _
         )
    End Function

    Public Sub coo_DeduccionesPrestamoDeleteByPK _
      (ByVal IdDeduccion As System.Int32 _
      )

        dl.coo_DeduccionesPrestamoDeleteByPK( _
         IdDeduccion _
         )
    End Sub

    Public Sub coo_DeduccionesPrestamoInsert _
    (ByVal entidad As coo_DeduccionesPrestamo)

        dl.coo_DeduccionesPrestamoInsert(entidad)
    End Sub

    Public Sub coo_DeduccionesPrestamoUpdate _
    (ByVal entidad As coo_DeduccionesPrestamo)

        dl.coo_DeduccionesPrestamoUpdate(entidad)
    End Sub

    Public Function coo_SolicitudFondosSelectAll() As DataTable
        Return dl.coo_SolicitudFondosSelectAll()
    End Function

    Public Function coo_SolicitudFondosSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      ) As coo_SolicitudFondos

        Return dl.coo_SolicitudFondosSelectByPK( _
         IdSolicitudFondo _
         )
    End Function

    Public Sub coo_SolicitudFondosDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      )

        dl.coo_SolicitudFondosDeleteByPK( _
         IdSolicitudFondo _
         )
    End Sub

    Public Sub coo_SolicitudFondosInsert _
    (ByVal entidad As coo_SolicitudFondos)

        dl.coo_SolicitudFondosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudFondosUpdate _
    (ByVal entidad As coo_SolicitudFondos)

        dl.coo_SolicitudFondosUpdate(entidad)
    End Sub



    Public Function coo_SolicitudFondosDeduccionesSelectAll() As DataTable
        Return dl.coo_SolicitudFondosDeduccionesSelectAll()
    End Function

    Public Function coo_SolicitudFondosDeduccionesSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal IdConcepto As System.Int32 _
      ) As coo_SolicitudFondosDeducciones

        Return dl.coo_SolicitudFondosDeduccionesSelectByPK( _
         IdSolicitudFondo _
         , IdSolicitud _
         , IdConcepto _
         )
    End Function

    Public Sub coo_SolicitudFondosDeduccionesDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      , ByVal IdConcepto As System.Int32 _
      )

        dl.coo_SolicitudFondosDeduccionesDeleteByPK( _
         IdSolicitudFondo _
         , IdSolicitud _
         , IdConcepto _
         )
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesInsert _
    (ByVal entidad As coo_SolicitudFondosDeducciones)

        dl.coo_SolicitudFondosDeduccionesInsert(entidad)
    End Sub

    Public Sub coo_SolicitudFondosDeduccionesUpdate _
    (ByVal entidad As coo_SolicitudFondosDeducciones)

        dl.coo_SolicitudFondosDeduccionesUpdate(entidad)
    End Sub

    Public Function coo_SolicitudFondosRefinanciaSelectAll() As DataTable
        Return dl.coo_SolicitudFondosRefinanciaSelectAll()
    End Function

    Public Function coo_SolicitudFondosRefinanciaSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Idsolicitud As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      ) As coo_SolicitudFondosRefinancia

        Return dl.coo_SolicitudFondosRefinanciaSelectByPK( _
         IdSolicitudFondo _
         , Idsolicitud _
         , IdPrestamo _
         )
    End Function

    Public Sub coo_SolicitudFondosRefinanciaDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal Idsolicitud As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      )

        dl.coo_SolicitudFondosRefinanciaDeleteByPK( _
         IdSolicitudFondo _
         , Idsolicitud _
         , IdPrestamo _
         )
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaInsert _
    (ByVal entidad As coo_SolicitudFondosRefinancia)

        dl.coo_SolicitudFondosRefinanciaInsert(entidad)
    End Sub

    Public Sub coo_SolicitudFondosRefinanciaUpdate _
    (ByVal entidad As coo_SolicitudFondosRefinancia)

        dl.coo_SolicitudFondosRefinanciaUpdate(entidad)
    End Sub

    Public Function coo_PrestamosSelectAll() As DataTable
        Return dl.coo_PrestamosSelectAll()
    End Function

    Public Function coo_PrestamosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      ) As coo_Prestamos

        Return dl.coo_PrestamosSelectByPK( _
         IdPrestamo _
         )
    End Function

    Public Sub coo_PrestamosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      )

        dl.coo_PrestamosDeleteByPK( _
         IdPrestamo _
         )
    End Sub

    Public Sub coo_PrestamosInsert _
    (ByVal entidad As coo_Prestamos)

        dl.coo_PrestamosInsert(entidad)
    End Sub

    Public Sub coo_PrestamosUpdate _
    (ByVal entidad As coo_Prestamos)

        dl.coo_PrestamosUpdate(entidad)
    End Sub

    Public Function coo_PrestamosDetalleSelectAll() As DataTable
        Return dl.coo_PrestamosDetalleSelectAll()
    End Function

    Public Function coo_PrestamosDetalleSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdMov As System.Int32 _
      ) As coo_PrestamosDetalle

        Return dl.coo_PrestamosDetalleSelectByPK( _
         IdPrestamo _
         , IdMov _
         )
    End Function

    Public Sub coo_PrestamosDetalleDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdMov As System.Int32 _
      )

        dl.coo_PrestamosDetalleDeleteByPK( _
         IdPrestamo _
         , IdMov _
         )
    End Sub

    Public Sub coo_PrestamosDetalleInsert _
    (ByVal entidad As coo_PrestamosDetalle)

        dl.coo_PrestamosDetalleInsert(entidad)
    End Sub

    Public Sub coo_PrestamosDetalleUpdate _
    (ByVal entidad As coo_PrestamosDetalle)

        dl.coo_PrestamosDetalleUpdate(entidad)
    End Sub
    Public Function coo_PrestamosDetalleDescuentosSelectAll() As DataTable
        Return dl.coo_PrestamosDetalleDescuentosSelectAll()
    End Function

    Public Function coo_PrestamosDetalleDescuentosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As coo_PrestamosDetalleDescuentos

        Return dl.coo_PrestamosDetalleDescuentosSelectByPK( _
         IdPrestamo _
         , IdDetalle _
         )
    End Function

    Public Sub coo_PrestamosDetalleDescuentosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        dl.coo_PrestamosDetalleDescuentosDeleteByPK( _
         IdPrestamo _
         , IdDetalle _
         )
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosInsert _
    (ByVal entidad As coo_PrestamosDetalleDescuentos)

        dl.coo_PrestamosDetalleDescuentosInsert(entidad)
    End Sub

    Public Sub coo_PrestamosDetalleDescuentosUpdate _
    (ByVal entidad As coo_PrestamosDetalleDescuentos)

        dl.coo_PrestamosDetalleDescuentosUpdate(entidad)
    End Sub


    Public Function coo_PrestamosPlanPagosSelectAll() As DataTable
        Return dl.coo_PrestamosPlanPagosSelectAll()
    End Function

    Public Function coo_PrestamosPlanPagosSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal NumCuota As System.Int32 _
      ) As coo_PrestamosPlanPagos

        Return dl.coo_PrestamosPlanPagosSelectByPK( _
         IdPrestamo _
         , NumCuota _
         )
    End Function

    Public Sub coo_PrestamosPlanPagosDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal NumCuota As System.Int32 _
      )

        dl.coo_PrestamosPlanPagosDeleteByPK( _
         IdPrestamo _
         , NumCuota _
         )
    End Sub






    Public Sub coo_PrestamosPlanPagosInsert _
    (ByVal entidad As coo_PrestamosPlanPagos)

        dl.coo_PrestamosPlanPagosInsert(entidad)
    End Sub

    Public Sub coo_PrestamosPlanPagosUpdate _
    (ByVal entidad As coo_PrestamosPlanPagos)

        dl.coo_PrestamosPlanPagosUpdate(entidad)
    End Sub

    Public Function coo_PrestamosTrasladoSelectAll() As DataTable
        Return dl.coo_PrestamosTrasladoSelectAll()
    End Function

    Public Function coo_PrestamosTrasladoSelectByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdTraslado As System.Int32 _
      ) As coo_PrestamosTraslado

        Return dl.coo_PrestamosTrasladoSelectByPK( _
         IdPrestamo _
         , IdTraslado _
         )
    End Function

    Public Sub coo_PrestamosTrasladoDeleteByPK _
      (ByVal IdPrestamo As System.Int32 _
      , ByVal IdTraslado As System.Int32 _
      )

        dl.coo_PrestamosTrasladoDeleteByPK( _
         IdPrestamo _
         , IdTraslado _
         )
    End Sub

    Public Sub coo_PrestamosTrasladoInsert _
    (ByVal entidad As coo_PrestamosTraslado)

        dl.coo_PrestamosTrasladoInsert(entidad)
    End Sub

    Public Sub coo_PrestamosTrasladoUpdate _
    (ByVal entidad As coo_PrestamosTraslado)

        dl.coo_PrestamosTrasladoUpdate(entidad)
    End Sub

    Public Function coo_PignoracionesSelectAll() As DataTable
        Return dl.coo_PignoracionesSelectAll()
    End Function

    Public Function coo_PignoracionesSelectByPK _
      (ByVal IdPignoracion As System.Int32 _
      ) As coo_Pignoraciones

        Return dl.coo_PignoracionesSelectByPK( _
         IdPignoracion _
         )
    End Function

    Public Sub coo_PignoracionesDeleteByPK _
      (ByVal IdPignoracion As System.Int32 _
      )

        dl.coo_PignoracionesDeleteByPK( _
         IdPignoracion _
         )
    End Sub

    Public Sub coo_PignoracionesInsert _
    (ByVal entidad As coo_Pignoraciones)

        dl.coo_PignoracionesInsert(entidad)
    End Sub

    Public Sub coo_PignoracionesUpdate _
    (ByVal entidad As coo_Pignoraciones)

        dl.coo_PignoracionesUpdate(entidad)
    End Sub

    Public Function coo_CorteCajaSelectAll() As DataTable
        Return dl.coo_CorteCajaSelectAll()
    End Function

    Public Function coo_CorteCajaSelectByPK _
      (ByVal IdCorte As System.Int32 _
      ) As coo_CorteCaja

        Return dl.coo_CorteCajaSelectByPK( _
         IdCorte _
         )
    End Function

    Public Sub coo_CorteCajaDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      )

        dl.coo_CorteCajaDeleteByPK( _
         IdCorte _
         )
    End Sub

    Public Sub coo_CorteCajaInsert _
    (ByVal entidad As coo_CorteCaja)

        dl.coo_CorteCajaInsert(entidad)
    End Sub

    Public Sub coo_CorteCajaUpdate _
    (ByVal entidad As coo_CorteCaja)

        dl.coo_CorteCajaUpdate(entidad)
    End Sub

    Public Function coo_CorteCajaArqueoSelectAll() As DataTable
        Return dl.coo_CorteCajaArqueoSelectAll()
    End Function

    Public Function coo_CorteCajaArqueoSelectByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      ) As coo_CorteCajaArqueo

        Return dl.coo_CorteCajaArqueoSelectByPK( _
         IdCorte _
         , IdDenominacion _
         )
    End Function

    Public Sub coo_CorteCajaArqueoDeleteByPK _
      (ByVal IdCorte As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      )

        dl.coo_CorteCajaArqueoDeleteByPK( _
         IdCorte _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_CorteCajaArqueoInsert _
    (ByVal entidad As coo_CorteCajaArqueo)

        dl.coo_CorteCajaArqueoInsert(entidad)
    End Sub

    Public Sub coo_CorteCajaArqueoUpdate _
    (ByVal entidad As coo_CorteCajaArqueo)

        dl.coo_CorteCajaArqueoUpdate(entidad)
    End Sub

    Public Function coo_SeguimientoCobrosSelectAll() As DataTable
        Return dl.coo_SeguimientoCobrosSelectAll()
    End Function

    Public Function coo_SeguimientoCobrosSelectByPK _
      (ByVal IdSeguimiento As System.Int32 _
      ) As coo_SeguimientoCobros

        Return dl.coo_SeguimientoCobrosSelectByPK( _
         IdSeguimiento _
         )
    End Function

    Public Sub coo_SeguimientoCobrosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      )

        dl.coo_SeguimientoCobrosDeleteByPK( _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoCobrosInsert _
    (ByVal entidad As coo_SeguimientoCobros)

        dl.coo_SeguimientoCobrosInsert(entidad)
    End Sub

    Public Sub coo_SeguimientoCobrosUpdate _
    (ByVal entidad As coo_SeguimientoCobros)

        dl.coo_SeguimientoCobrosUpdate(entidad)
    End Sub

    Public Function coo_PrestamosDesembolsoSelectAll() As DataTable
        Return dl.coo_PrestamosDesembolsoSelectAll()
    End Function

    Public Function coo_PrestamosDesembolsoSelectByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      ) As coo_PrestamosDesembolso

        Return dl.coo_PrestamosDesembolsoSelectByPK( _
         IdSolicitudFondo _
         , IdPrestamo _
         )
    End Function
    Public Function coo_PrestamosDesembolsoSelectByPK2 _
  (ByVal IdSolicitudFondo As System.Int32 _
  ) As coo_PrestamosDesembolso

        Return dl.coo_PrestamosDesembolsoSelectByPK2( _
         IdSolicitudFondo _
         )
    End Function

    Public Sub coo_PrestamosDesembolsoDeleteByPK _
      (ByVal IdSolicitudFondo As System.Int32 _
      , ByVal IdPrestamo As System.Int32 _
      )

        dl.coo_PrestamosDesembolsoDeleteByPK( _
         IdSolicitudFondo _
         , IdPrestamo _
         )
    End Sub
    Public Sub coo_PrestamosDetalleDescuentosDeleteByIdPrestamo _
  (ByVal IdPrestamo As System.Int32 _
  )

        dl.coo_PrestamosDetalleDescuentosDeleteByIdPrestamo(IdPrestamo)
    End Sub
    '

    Public Sub coo_PrestamosDesembolsoInsert _
    (ByVal entidad As coo_PrestamosDesembolso)

        dl.coo_PrestamosDesembolsoInsert(entidad)
    End Sub

    Public Sub coo_PrestamosDesembolsoUpdate _
    (ByVal entidad As coo_PrestamosDesembolso)

        dl.coo_PrestamosDesembolsoUpdate(entidad)
    End Sub



    Public Sub coo_PrestamosPlanPagosDeleteByPrestamo _
      (ByVal IdPrestamo As System.Int32)
        dl.coo_PrestamosPlanPagosDeleteByPrestamo(IdPrestamo)
    End Sub

    Public Function coo_SolicitudesDetalleGastosSelectAll() As DataTable
        Return dl.coo_SolicitudesDetalleGastosSelectAll()
    End Function

    Public Function coo_SolicitudesDetalleGastosSelectByPK _
      (ByVal IdEgreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesDetalleGastos

        Return dl.coo_SolicitudesDetalleGastosSelectByPK( _
         IdEgreso _
         , IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesDetalleGastosDeleteByPK _
      (ByVal IdEgreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesDetalleGastosDeleteByPK( _
         IdEgreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleGastosInsert _
    (ByVal entidad As coo_SolicitudesDetalleGastos)

        dl.coo_SolicitudesDetalleGastosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesDetalleGastosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleGastos)

        dl.coo_SolicitudesDetalleGastosUpdate(entidad)
    End Sub

    Public Function coo_SolicitudesDetalleIngresosSelectAll() As DataTable
        Return dl.coo_SolicitudesDetalleIngresosSelectAll()
    End Function

    Public Function coo_SolicitudesDetalleIngresosSelectByPK _
      (ByVal IdIngreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudesDetalleIngresos

        Return dl.coo_SolicitudesDetalleIngresosSelectByPK( _
         IdIngreso _
         , IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudesDetalleIngresosDeleteByPK _
      (ByVal IdIngreso As System.Int32 _
      , ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudesDetalleIngresosDeleteByPK( _
         IdIngreso _
         , IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosInsert _
    (ByVal entidad As coo_SolicitudesDetalleIngresos)

        dl.coo_SolicitudesDetalleIngresosInsert(entidad)
    End Sub

    Public Sub coo_SolicitudesDetalleIngresosUpdate _
    (ByVal entidad As coo_SolicitudesDetalleIngresos)

        dl.coo_SolicitudesDetalleIngresosUpdate(entidad)
    End Sub

    Public Function coo_SeguimientoPrestamosSelectAll() As DataTable
        Return dl.coo_SeguimientoPrestamosSelectAll()
    End Function

    Public Function coo_SeguimientoPrestamosSelectByPK _
      (ByVal IdSeguimiento As System.Int32 _
      ) As coo_SeguimientoPrestamos

        Return dl.coo_SeguimientoPrestamosSelectByPK( _
         IdSeguimiento _
         )
    End Function

    Public Sub coo_SeguimientoPrestamosDeleteByPK _
      (ByVal IdSeguimiento As System.Int32 _
      )

        dl.coo_SeguimientoPrestamosDeleteByPK( _
         IdSeguimiento _
         )
    End Sub

    Public Sub coo_SeguimientoPrestamosInsert _
    (ByVal entidad As coo_SeguimientoPrestamos)

        dl.coo_SeguimientoPrestamosInsert(entidad)
    End Sub

    Public Sub coo_SeguimientoPrestamosUpdate _
    (ByVal entidad As coo_SeguimientoPrestamos)

        dl.coo_SeguimientoPrestamosUpdate(entidad)
    End Sub

    Public Function coo_PrestamosEfectivoSelectAll() As DataTable
        Return dl.coo_PrestamosEfectivoSelectAll()
    End Function

    Public Function coo_PrestamosEfectivoSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_PrestamosEfectivo

        Return dl.coo_PrestamosEfectivoSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_PrestamosEfectivoDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_PrestamosEfectivoDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_PrestamosEfectivoInsert _
    (ByVal entidad As coo_PrestamosEfectivo)

        dl.coo_PrestamosEfectivoInsert(entidad)
    End Sub

    Public Sub coo_PrestamosEfectivoUpdate _
    (ByVal entidad As coo_PrestamosEfectivo)

        dl.coo_PrestamosEfectivoUpdate(entidad)
    End Sub

    Public Function coo_FondosCajaSelectAll() As DataTable
        Return dl.coo_FondosCajaSelectAll()
    End Function

    Public Function coo_FondosCajaSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As coo_FondosCaja

        Return dl.coo_FondosCajaSelectByPK( _
         IdComprobante _
         )
    End Function

    Public Sub coo_FondosCajaDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        dl.coo_FondosCajaDeleteByPK( _
         IdComprobante _
         )
    End Sub

    Public Sub coo_FondosCajaInsert _
    (ByVal entidad As coo_FondosCaja)

        dl.coo_FondosCajaInsert(entidad)
    End Sub

    Public Sub coo_FondosCajaUpdate _
    (ByVal entidad As coo_FondosCaja)

        dl.coo_FondosCajaUpdate(entidad)
    End Sub


    Public Function coo_ReintegrosPlanillaSelectAll() As DataTable
        Return dl.coo_ReintegrosPlanillaSelectAll()
    End Function

    Public Function coo_ReintegrosPlanillaSelectByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal IdAsociado As System.Int32 _
      ) As coo_ReintegrosPlanilla

        Return dl.coo_ReintegrosPlanillaSelectByPK( _
         IdMov _
         , IdAsociado _
         )
    End Function

    Public Sub coo_ReintegrosPlanillaDeleteByPK _
      (ByVal IdMov As System.Int32 _
      , ByVal IdAsociado As System.Int32 _
      )

        dl.coo_ReintegrosPlanillaDeleteByPK( _
         IdMov _
         , IdAsociado _
         )
    End Sub

    Public Sub coo_ReintegrosPlanillaInsert _
    (ByVal entidad As coo_ReintegrosPlanilla)

        dl.coo_ReintegrosPlanillaInsert(entidad)
    End Sub

    Public Sub coo_ReintegrosPlanillaUpdate _
    (ByVal entidad As coo_ReintegrosPlanilla)

        dl.coo_ReintegrosPlanillaUpdate(entidad)
    End Sub

    Public Function coo_AplicarReintegrosSelectAll() As DataTable
        Return dl.coo_AplicarReintegrosSelectAll()
    End Function

    Public Function coo_AplicarReintegrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_AplicarReintegros

        Return dl.coo_AplicarReintegrosSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_AplicarReintegrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_AplicarReintegrosDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_AplicarReintegrosInsert _
    (ByVal entidad As coo_AplicarReintegros)

        dl.coo_AplicarReintegrosInsert(entidad)
    End Sub

    Public Sub coo_AplicarReintegrosUpdate _
    (ByVal entidad As coo_AplicarReintegros)

        dl.coo_AplicarReintegrosUpdate(entidad)
    End Sub

    Public Function coo_AplicarReintegrosAhorrosSelectAll() As DataTable
        Return dl.coo_AplicarReintegrosAhorrosSelectAll()
    End Function

    Public Function coo_AplicarReintegrosAhorrosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_AplicarReintegrosAhorros

        Return dl.coo_AplicarReintegrosAhorrosSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_AplicarReintegrosAhorrosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_AplicarReintegrosAhorrosDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosInsert _
    (ByVal entidad As coo_AplicarReintegrosAhorros)

        dl.coo_AplicarReintegrosAhorrosInsert(entidad)
    End Sub

    Public Sub coo_AplicarReintegrosAhorrosUpdate _
    (ByVal entidad As coo_AplicarReintegrosAhorros)

        dl.coo_AplicarReintegrosAhorrosUpdate(entidad)
    End Sub

    Public Function coo_AplicarReintegrosPrestamosSelectAll() As DataTable
        Return dl.coo_AplicarReintegrosPrestamosSelectAll()
    End Function

    Public Function coo_AplicarReintegrosPrestamosSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_AplicarReintegrosPrestamos

        Return dl.coo_AplicarReintegrosPrestamosSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_AplicarReintegrosPrestamosDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_AplicarReintegrosPrestamosDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosInsert _
    (ByVal entidad As coo_AplicarReintegrosPrestamos)

        dl.coo_AplicarReintegrosPrestamosInsert(entidad)
    End Sub

    Public Sub coo_AplicarReintegrosPrestamosUpdate _
    (ByVal entidad As coo_AplicarReintegrosPrestamos)

        dl.coo_AplicarReintegrosPrestamosUpdate(entidad)
    End Sub

    Public Function coo_SolicitudRetiroSelectAll() As DataTable
        Return dl.coo_SolicitudRetiroSelectAll()
    End Function

    Public Function coo_SolicitudRetiroSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      ) As coo_SolicitudRetiro

        Return dl.coo_SolicitudRetiroSelectByPK( _
         IdSolicitud _
         )
    End Function

    Public Sub coo_SolicitudRetiroDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      )

        dl.coo_SolicitudRetiroDeleteByPK( _
         IdSolicitud _
         )
    End Sub

    Public Sub coo_SolicitudRetiroInsert _
    (ByVal entidad As coo_SolicitudRetiro)

        dl.coo_SolicitudRetiroInsert(entidad)
    End Sub

    Public Sub coo_SolicitudRetiroUpdate _
    (ByVal entidad As coo_SolicitudRetiro)

        dl.coo_SolicitudRetiroUpdate(entidad)
    End Sub



#End Region





#Region "Contabilidad"

    Public Function con_CuentasSelectByPK(ByVal IdCuenta As String) As con_Cuentas
        Return dl.con_CuentasSelectByPK(IdCuenta)
    End Function
#End Region

#Region "Indicadores"
    Public Function col_ColacSelectAll() As DataTable
        Return dl.col_ColacSelectAll()
    End Function

    Public Function col_ColacSelectByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Mes As System.Int32 _
      ) As col_Colac

        Return dl.col_ColacSelectByPK( _
         IdIndicador _
         , Anio _
         , Mes _
         )
    End Function

    Public Sub col_ColacDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      , ByVal Anio As System.Int32 _
      , ByVal Mes As System.Int32 _
      )

        dl.col_ColacDeleteByPK( _
         IdIndicador _
         , Anio _
         , Mes _
         )
    End Sub

    Public Sub col_ColacInsert _
    (ByVal entidad As col_Colac)

        dl.col_ColacInsert(entidad)
    End Sub

    Public Sub col_ColacUpdate _
    (ByVal entidad As col_Colac)

        dl.col_ColacUpdate(entidad)
    End Sub

    Public Function col_FormulasFinancierasSelectAll() As DataTable
        Return dl.col_FormulasFinancierasSelectAll()
    End Function

    Public Function col_FormulasFinancierasSelectByPK _
      (ByVal Id As System.Int32 _
      ) As col_FormulasFinancieras

        Return dl.col_FormulasFinancierasSelectByPK( _
         Id _
         )
    End Function

    Public Sub col_FormulasFinancierasDeleteByPK _
      (ByVal Id As System.Int32 _
      )

        dl.col_FormulasFinancierasDeleteByPK( _
         Id _
         )
    End Sub

    Public Sub col_FormulasFinancierasInsert _
    (ByVal entidad As col_FormulasFinancieras)

        dl.col_FormulasFinancierasInsert(entidad)
    End Sub

    Public Sub col_FormulasFinancierasUpdate _
    (ByVal entidad As col_FormulasFinancieras)

        dl.col_FormulasFinancierasUpdate(entidad)
    End Sub

    Public Function col_indicadoresSelectAll() As DataTable
        Return dl.col_indicadoresSelectAll()
    End Function

    Public Function col_indicadoresSelectByPK _
      (ByVal IdIndicador As System.Int32 _
      ) As col_indicadores

        Return dl.col_indicadoresSelectByPK( _
         IdIndicador _
         )
    End Function

    Public Sub col_indicadoresDeleteByPK _
      (ByVal IdIndicador As System.Int32 _
      )

        dl.col_indicadoresDeleteByPK( _
         IdIndicador _
         )
    End Sub

    Public Sub col_indicadoresInsert _
    (ByVal entidad As col_indicadores)

        dl.col_indicadoresInsert(entidad)
    End Sub

    Public Sub col_indicadoresUpdate _
    (ByVal entidad As col_indicadores)

        dl.col_indicadoresUpdate(entidad)
    End Sub

    Public Function col_IndicadoresParametrosSelectAll() As DataTable
        Return dl.col_IndicadoresParametrosSelectAll()
    End Function

    Public Function col_IndicadoresParametrosSelectByPK _
      (ByVal NombreIndicador As System.String _
      ) As col_IndicadoresParametros

        Return dl.col_IndicadoresParametrosSelectByPK( _
         NombreIndicador _
         )
    End Function

    Public Sub col_IndicadoresParametrosDeleteByPK _
      (ByVal NombreIndicador As System.String _
      )

        dl.col_IndicadoresParametrosDeleteByPK( _
         NombreIndicador _
         )
    End Sub

    Public Sub col_IndicadoresParametrosInsert _
    (ByVal entidad As col_IndicadoresParametros)

        dl.col_IndicadoresParametrosInsert(entidad)
    End Sub

    Public Sub col_IndicadoresParametrosUpdate _
    (ByVal entidad As col_IndicadoresParametros)

        dl.col_IndicadoresParametrosUpdate(entidad)
    End Sub

    Public Function col_ParametrosSelectAll() As DataTable
        Return dl.col_ParametrosSelectAll()
    End Function

    Public Function col_ParametrosSelectByPK _
      (ByVal IdParametro As System.String _
      ) As col_Parametros

        Return dl.col_ParametrosSelectByPK( _
         IdParametro _
         )
    End Function

    Public Sub col_ParametrosDeleteByPK _
      (ByVal IdParametro As System.String _
      )

        dl.col_ParametrosDeleteByPK( _
         IdParametro _
         )
    End Sub

    Public Sub col_ParametrosInsert _
    (ByVal entidad As col_Parametros)

        dl.col_ParametrosInsert(entidad)
    End Sub

    Public Sub col_ParametrosUpdate _
    (ByVal entidad As col_Parametros)

        dl.col_ParametrosUpdate(entidad)
    End Sub

    Public Function col_ParametrosDetalleSelectAll() As DataTable
        Return dl.col_ParametrosDetalleSelectAll()
    End Function

    Public Function col_ParametrosDetalleSelectByPK _
      (ByVal IdParametro As System.String _
      , ByVal Mes As System.Int32 _
      , ByVal Anio As System.Int32 _
      ) As col_ParametrosDetalle

        Return dl.col_ParametrosDetalleSelectByPK( _
         IdParametro _
         , Mes _
         , Anio _
         )
    End Function

    Public Sub col_ParametrosDetalleDeleteByPK _
      (ByVal IdParametro As System.String _
      , ByVal Mes As System.Int32 _
      , ByVal Anio As System.Int32 _
      )

        dl.col_ParametrosDetalleDeleteByPK( _
         IdParametro _
         , Mes _
         , Anio _
         )
    End Sub

    Public Sub col_ParametrosDetalleInsert _
    (ByVal entidad As col_ParametrosDetalle)

        dl.col_ParametrosDetalleInsert(entidad)
    End Sub

    Public Sub col_ParametrosDetalleUpdate _
    (ByVal entidad As col_ParametrosDetalle)

        dl.col_ParametrosDetalleUpdate(entidad)
    End Sub

    Public Function col_VariablesSelectAll() As DataTable
        Return dl.col_VariablesSelectAll()
    End Function

    Public Function col_VariablesSelectByPK _
      (ByVal IdVariable As System.Int32 _
      ) As col_Variables

        Return dl.col_VariablesSelectByPK( _
         IdVariable _
         )
    End Function

    Public Sub col_VariablesDeleteByPK _
      (ByVal IdVariable As System.Int32 _
      )

        dl.col_VariablesDeleteByPK( _
         IdVariable _
         )
    End Sub

    Public Sub col_VariablesInsert _
    (ByVal entidad As col_Variables)

        dl.col_VariablesInsert(entidad)
    End Sub

    Public Sub col_VariablesUpdate _
    (ByVal entidad As col_Variables)

        dl.col_VariablesUpdate(entidad)
    End Sub


#End Region
    Public Function coo_EstructurasAdministracionSelectAll() As DataTable
        Return dl.coo_EstructurasAdministracionSelectAll()
    End Function

    Public Function coo_EstructurasAdministracionSelectByPK _
      (ByVal Id As System.Int32 _
      ) As coo_EstructurasAdministracion

        Return dl.coo_EstructurasAdministracionSelectByPK( _
         Id _
         )
    End Function

    Public Sub coo_EstructurasAdministracionDeleteByPK _
      (ByVal Id As System.Int32 _
      )

        dl.coo_EstructurasAdministracionDeleteByPK( _
         Id _
         )
    End Sub

    Public Sub coo_EstructurasAdministracionInsert _
    (ByVal entidad As coo_EstructurasAdministracion)

        dl.coo_EstructurasAdministracionInsert(entidad)
    End Sub

    Public Sub coo_EstructurasAdministracionUpdate _
    (ByVal entidad As coo_EstructurasAdministracion)

        dl.coo_EstructurasAdministracionUpdate(entidad)
    End Sub



    Public Function coo_OperacionesNumerarioSelectAll() As DataTable
        Return dl.coo_OperacionesNumerarioSelectAll()
    End Function

    Public Function coo_OperacionesNumerarioSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      ) As coo_OperacionesNumerario

        Return dl.coo_OperacionesNumerarioSelectByPK( _
         IdOperacion _
         )
    End Function

    Public Sub coo_OperacionesNumerarioDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      )

        dl.coo_OperacionesNumerarioDeleteByPK( _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioInsert _
    (ByVal entidad As coo_OperacionesNumerario)

        dl.coo_OperacionesNumerarioInsert(entidad)
    End Sub

    Public Sub coo_OperacionesNumerarioUpdate _
    (ByVal entidad As coo_OperacionesNumerario)

        dl.coo_OperacionesNumerarioUpdate(entidad)
    End Sub

    Public Function coo_OperacionesNumerarioArqueoSelectAll() As DataTable
        Return dl.coo_OperacionesNumerarioArqueoSelectAll()
    End Function

    Public Function coo_OperacionesNumerarioArqueoSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      ) As coo_OperacionesNumerarioArqueo

        Return dl.coo_OperacionesNumerarioArqueoSelectByPK( _
         IdOperacion _
         , IdDenominacion _
         )
    End Function

    Public Sub coo_OperacionesNumerarioArqueoDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal IdDenominacion As System.Int32 _
      )

        dl.coo_OperacionesNumerarioArqueoDeleteByPK( _
         IdOperacion _
         , IdDenominacion _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoInsert _
    (ByVal entidad As coo_OperacionesNumerarioArqueo)

        dl.coo_OperacionesNumerarioArqueoInsert(entidad)
    End Sub

    Public Sub coo_OperacionesNumerarioArqueoUpdate _
    (ByVal entidad As coo_OperacionesNumerarioArqueo)

        dl.coo_OperacionesNumerarioArqueoUpdate(entidad)
    End Sub

    Public Function coo_OperacionesNumerarioChequesSelectAll() As DataTable
        Return dl.coo_OperacionesNumerarioChequesSelectAll()
    End Function

    Public Function coo_OperacionesNumerarioChequesSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      ) As coo_OperacionesNumerarioCheques

        Return dl.coo_OperacionesNumerarioChequesSelectByPK( _
         IdOperacion _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Function

    Public Sub coo_OperacionesNumerarioChequesDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      , ByVal NumeroCuenta As System.String _
      , ByVal NumeroCheque As System.String _
      )

        dl.coo_OperacionesNumerarioChequesDeleteByPK( _
         IdOperacion _
         , NumeroCuenta _
         , NumeroCheque _
         )
    End Sub

    Public Sub coo_OperacionesNumerarioChequesInsert _
    (ByVal entidad As coo_OperacionesNumerarioCheques)

        dl.coo_OperacionesNumerarioChequesInsert(entidad)
    End Sub

    Public Sub coo_OperacionesNumerarioChequesUpdate _
    (ByVal entidad As coo_OperacionesNumerarioCheques)

        dl.coo_OperacionesNumerarioChequesUpdate(entidad)
    End Sub

    Public Function coo_TiposOperacionNumerarioSelectAll() As DataTable
        Return dl.coo_TiposOperacionNumerarioSelectAll()
    End Function

    Public Function coo_TiposOperacionNumerarioSelectByPK _
      (ByVal IdTipoOperacion As Integer) As coo_TiposOperacionNumerario

        Return dl.coo_TiposOperacionNumerarioSelectByPK(IdTipoOperacion)
    End Function

    Public Sub coo_TiposOperacionNumerarioDeleteByPK(ByVal IdTipoOperacion As System.Int32)
        dl.coo_TiposOperacionNumerarioDeleteByPK(IdTipoOperacion)
    End Sub

    Public Sub coo_TiposOperacionNumerarioInsert(ByVal entidad As coo_TiposOperacionNumerario)
        dl.coo_TiposOperacionNumerarioInsert(entidad)
    End Sub

    Public Sub coo_TiposOperacionNumerarioUpdate(ByVal entidad As coo_TiposOperacionNumerario)

        dl.coo_TiposOperacionNumerarioUpdate(entidad)
    End Sub

    Public Function coo_DocumentosSelectByPK(ByVal Documento As String) As coo_Documentos
        Return dl.coo_DocumentosSelectByPK(Documento)
    End Function

    Public Sub coo_DocumentosDeleteByPK(ByVal Documento As String)
        dl.coo_DocumentosDeleteByPK(Documento)
    End Sub

    Public Sub coo_DocumentosInsert(ByVal entidad As coo_Documentos)
        dl.coo_DocumentosInsert(entidad)
    End Sub

    Public Sub coo_DocumentosUpdate(ByVal entidad As coo_Documentos)
        dl.coo_DocumentosUpdate(entidad)
    End Sub


    Public Function com_ComprasSelectAll() As DataTable
        Return dl.com_ComprasSelectAll()
    End Function

    Public Function com_ComprasSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      ) As com_Compras

        Return dl.com_ComprasSelectByPK( _
         IdComprobante _
         )
    End Function

    Public Sub com_ComprasDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      )

        dl.com_ComprasDeleteByPK( _
         IdComprobante _
         )
    End Sub

    Public Sub com_ComprasInsert _
    (ByVal entidad As com_Compras)

        dl.com_ComprasInsert(entidad)
    End Sub

    Public Sub com_ComprasUpdate _
    (ByVal entidad As com_Compras)

        dl.com_ComprasUpdate(entidad)
    End Sub

    Public Function com_ComprasDetalleSelectAll() As DataTable
        Return dl.com_ComprasDetalleSelectAll()
    End Function

    Public Function com_ComprasDetalleSelectByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      ) As com_ComprasDetalle

        Return dl.com_ComprasDetalleSelectByPK( _
         IdComprobante _
         , IdDetalle _
         )
    End Function

    Public Sub com_ComprasDetalleDeleteByPK _
      (ByVal IdComprobante As System.Int32 _
      , ByVal IdDetalle As System.Int32 _
      )

        dl.com_ComprasDetalleDeleteByPK( _
         IdComprobante _
         , IdDetalle _
         )
    End Sub

    Public Sub com_ComprasDetalleInsert _
    (ByVal entidad As com_ComprasDetalle)

        dl.com_ComprasDetalleInsert(entidad)
    End Sub

    Public Sub com_ComprasDetalleUpdate _
    (ByVal entidad As com_ComprasDetalle)

        dl.com_ComprasDetalleUpdate(entidad)
    End Sub

    Public Function inv_ProductosSelectAll() As DataTable
        Return dl.inv_ProductosSelectAll()
    End Function

    Public Function inv_ProductosSelectByPK _
      (ByVal IdProducto As System.String _
      ) As inv_Productos

        Return dl.inv_ProductosSelectByPK( _
         IdProducto _
         )
    End Function

    Public Sub inv_ProductosDeleteByPK _
      (ByVal IdProducto As System.String _
      )

        dl.inv_ProductosDeleteByPK( _
         IdProducto _
         )
    End Sub

    Public Sub inv_ProductosInsert _
    (ByVal entidad As inv_Productos)

        dl.inv_ProductosInsert(entidad)
    End Sub

    Public Sub inv_ProductosUpdate _
    (ByVal entidad As inv_Productos)

        dl.inv_ProductosUpdate(entidad)
    End Sub


    Public Function com_ProveedoresSelectAll() As DataTable
        Return dl.com_ProveedoresSelectAll()
    End Function

    Public Function com_ProveedoresSelectByPK _
      (ByVal IdProveedor As System.String _
      ) As com_Proveedores

        Return dl.com_ProveedoresSelectByPK( _
         IdProveedor _
         )
    End Function

    Public Sub com_ProveedoresDeleteByPK _
      (ByVal IdProveedor As System.String _
      )

        dl.com_ProveedoresDeleteByPK( _
         IdProveedor _
         )
    End Sub

    Public Sub com_ProveedoresInsert _
    (ByVal entidad As com_Proveedores)

        dl.com_ProveedoresInsert(entidad)
    End Sub

    Public Sub com_ProveedoresUpdate _
    (ByVal entidad As com_Proveedores)

        dl.com_ProveedoresUpdate(entidad)
    End Sub

    Public Function coo_AfiliacionesSelectAll() As DataTable
        Return dl.coo_AfiliacionesSelectAll()
    End Function

    Public Function coo_AfiliacionesSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_Afiliaciones

        Return dl.coo_AfiliacionesSelectByPK( _
         IdMov _
         )
    End Function

    Public Sub coo_AfiliacionesDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        dl.coo_AfiliacionesDeleteByPK( _
         IdMov _
         )
    End Sub

    Public Sub coo_AfiliacionesInsert _
    (ByVal entidad As coo_Afiliaciones)

        dl.coo_AfiliacionesInsert(entidad)
    End Sub

    Public Sub coo_AfiliacionesUpdate _
    (ByVal entidad As coo_Afiliaciones)

        dl.coo_AfiliacionesUpdate(entidad)
    End Sub

    Public Function coo_UbicacionesAsociadosSelectAll() As DataTable
        Return dl.coo_UbicacionesAsociadosSelectAll()
    End Function

    Public Function coo_UbicacionesAsociadosSelectByPK _
      (ByVal IdUbicacion As System.Int32 _
      ) As coo_UbicacionesAsociados

        Return dl.coo_UbicacionesAsociadosSelectByPK( _
         IdUbicacion _
         )
    End Function

    Public Sub coo_UbicacionesAsociadosDeleteByPK _
      (ByVal IdUbicacion As System.Int32 _
      )

        dl.coo_UbicacionesAsociadosDeleteByPK( _
         IdUbicacion _
         )
    End Sub

    Public Sub coo_UbicacionesAsociadosInsert _
    (ByVal entidad As coo_UbicacionesAsociados)

        dl.coo_UbicacionesAsociadosInsert(entidad)
    End Sub

    Public Sub coo_UbicacionesAsociadosUpdate _
    (ByVal entidad As coo_UbicacionesAsociados)

        dl.coo_UbicacionesAsociadosUpdate(entidad)
    End Sub

    Public Function coo_PrestamoEfectivoRefinanciaSelectAll() As DataTable
        Return dl.coo_PrestamoEfectivoRefinanciaSelectAll()
    End Function

    Public Function coo_PrestamoEfectivoRefinanciaSelectByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      ) As coo_PrestamoEfectivoRefinancia

        Return dl.coo_PrestamoEfectivoRefinanciaSelectByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Function

    Public Sub coo_PrestamoEfectivoRefinanciaDeleteByPK _
      (ByVal IdSolicitud As System.Int32 _
      , ByVal Correlativo As System.Int32 _
      )

        dl.coo_PrestamoEfectivoRefinanciaDeleteByPK( _
         IdSolicitud _
         , Correlativo _
         )
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaInsert _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia)

        dl.coo_PrestamoEfectivoRefinanciaInsert(entidad)
    End Sub

    Public Sub coo_PrestamoEfectivoRefinanciaUpdate _
    (ByVal entidad As coo_PrestamoEfectivoRefinancia)

        dl.coo_PrestamoEfectivoRefinanciaUpdate(entidad)
    End Sub


    Public Function coo_IsrInteresSelectAll() As DataTable
        Return dl.coo_IsrInteresSelectAll()
    End Function

    Public Function coo_IsrInteresSelectByPK _
      (ByVal IdIsr As System.Int32 _
      ) As coo_IsrInteres

        Return dl.coo_IsrInteresSelectByPK( _
         IdIsr _
         )
    End Function

    Public Sub coo_IsrInteresDeleteByPK _
      (ByVal IdIsr As System.Int32 _
      )

        dl.coo_IsrInteresDeleteByPK( _
         IdIsr _
         )
    End Sub

    Public Sub coo_IsrInteresInsert _
    (ByVal entidad As coo_IsrInteres)

        dl.coo_IsrInteresInsert(entidad)
    End Sub

    Public Sub coo_IsrInteresUpdate _
    (ByVal entidad As coo_IsrInteres)

        dl.coo_IsrInteresUpdate(entidad)
    End Sub

    Public Function coo_OperacionesCajaSelectAll() As DataTable
        Return dl.coo_OperacionesCajaSelectAll()
    End Function

    Public Function coo_OperacionesCajaSelectByPK _
      (ByVal IdOperacion As System.Int32 _
      ) As coo_OperacionesCaja

        Return dl.coo_OperacionesCajaSelectByPK( _
         IdOperacion _
         )
    End Function

    Public Sub coo_OperacionesCajaDeleteByPK _
      (ByVal IdOperacion As System.Int32 _
      )

        dl.coo_OperacionesCajaDeleteByPK( _
         IdOperacion _
         )
    End Sub

    Public Sub coo_OperacionesCajaInsert _
    (ByVal entidad As coo_OperacionesCaja)

        dl.coo_OperacionesCajaInsert(entidad)
    End Sub

    Public Sub coo_OperacionesCajaUpdate _
    (ByVal entidad As coo_OperacionesCaja)

        dl.coo_OperacionesCajaUpdate(entidad)
    End Sub

    Public Function pla_EstadoCivilSelectAll() As DataTable
        Return dl.pla_EstadoCivilSelectAll()
    End Function

    Public Function pla_EstadoCivilSelectByPK _
      (ByVal IdEstadoCivil As System.Int32 _
      ) As pla_EstadoCivil

        Return dl.pla_EstadoCivilSelectByPK( _
         IdEstadoCivil _
         )
    End Function

    Public Sub pla_EstadoCivilDeleteByPK _
      (ByVal IdEstadoCivil As System.Int32 _
      )

        dl.pla_EstadoCivilDeleteByPK( _
         IdEstadoCivil _
         )
    End Sub

    Public Sub pla_EstadoCivilInsert _
    (ByVal entidad As pla_EstadoCivil)

        dl.pla_EstadoCivilInsert(entidad)
    End Sub

    Public Sub pla_EstadoCivilUpdate _
    (ByVal entidad As pla_EstadoCivil)

        dl.pla_EstadoCivilUpdate(entidad)
    End Sub

    Public Function coo_OtrosIngresosSelectAll() As DataTable
        Return dl.coo_OtrosIngresosSelectAll()
    End Function

    Public Function coo_OtrosIngresosSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_OtrosIngresos

        Return dl.coo_OtrosIngresosSelectByPK( _
         IdMov _
         )
    End Function

    Public Sub coo_OtrosIngresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        dl.coo_OtrosIngresosDeleteByPK( _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosIngresosInsert _
    (ByVal entidad As coo_OtrosIngresos)

        dl.coo_OtrosIngresosInsert(entidad)
    End Sub

    Public Sub coo_OtrosIngresosUpdate _
    (ByVal entidad As coo_OtrosIngresos)

        dl.coo_OtrosIngresosUpdate(entidad)
    End Sub
    Public Function coo_OtrosEgresosSelectAll() As DataTable
        Return dl.coo_OtrosEgresosSelectAll()
    End Function

    Public Function coo_OtrosEgresosSelectByPK _
      (ByVal IdMov As System.Int32 _
      ) As coo_OtrosEgresos

        Return dl.coo_OtrosEgresosSelectByPK( _
         IdMov _
         )
    End Function

    Public Sub coo_OtrosEgresosDeleteByPK _
      (ByVal IdMov As System.Int32 _
      )

        dl.coo_OtrosEgresosDeleteByPK( _
         IdMov _
         )
    End Sub

    Public Sub coo_OtrosEgresosInsert _
    (ByVal entidad As coo_OtrosEgresos)

        dl.coo_OtrosEgresosInsert(entidad)
    End Sub

    Public Sub coo_OtrosEgresosUpdate _
    (ByVal entidad As coo_OtrosEgresos)

        dl.coo_OtrosEgresosUpdate(entidad)
    End Sub

    Public Sub coo_LiquidacionesDeleteByPK _
  (ByVal IdComprobante As System.Int32 _
  )

        dl.coo_LiquidacionesDeleteByPK( _
         IdComprobante _
         )
    End Sub
    Public Function coo_AsociadosTelefoniaSelectAll(ByVal IdAsociado As System.Int32) As DataTable
        Return dl.coo_AsociadosTelefoniaSelectAll(IdAsociado)
    End Function

    Public Function coo_AsociadosTelefoniaSelectByPK _
      (ByVal IdAsociado As System.Int32 _
       , ByVal IdTelefono As System.Int32 _
      ) As coo_AsociadosTelefonia

        Return dl.coo_AsociadosTelefoniaSelectByPK( _
         IdAsociado _
         , IdTelefono _
         )
    End Function

    Public Sub coo_AsociadosTelefoniaDeleteByPK _
      (ByVal IdAsociado As System.Int32 _
       , ByVal IdTelefono As System.Int32 _
      )
        dl.coo_AsociadosTelefoniaDeleteByPK( _
         IdAsociado _
        , IdTelefono _
         )
    End Sub

    Public Sub coo_AsociadosTelefoniaInsert _
    (ByVal entidad As coo_AsociadosTelefonia)

        dl.coo_AsociadosTelefoniaInsert(entidad)
    End Sub

    Public Sub coo_AsociadosTelefoniaUpdate _
    (ByVal entidad As coo_AsociadosTelefonia)

        dl.coo_AsociadosTelefoniaUpdate(entidad)
    End Sub
    Public Sub coo_DescuentoTelefoniaPendienteDelete _
  (ByVal FechaAplicacion As System.DateTime _
  )
        dl.coo_DescuentoTelefoniaPendienteDelete( _
         FechaAplicacion _
         )
    End Sub
    Public Sub coo_AbonoTelefoniaDelete _
(ByVal FechaAplicacion As System.DateTime _
)
        dl.coo_AbonoTelefoniaDelete( _
         FechaAplicacion _
         )
    End Sub
End Class
