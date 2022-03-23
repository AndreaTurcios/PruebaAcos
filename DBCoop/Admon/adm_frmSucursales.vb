Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmSucursales
    Dim entidad As adm_Sucursales
    Dim IdSucursal As Integer = 0
    Dim bl As New AdmonBLL()

    Private Sub adm_frmSucursales_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de Eliminar la Sucursal?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.adm_SucursalesDeleteByPK(IdSucursal)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Sucursal ha sido eliminada con éxito", MsgBoxStyle.Information, "Nota")
                IdSucursal = teIdSucursal.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar la Sucursal{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub adm_frmSucursales_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdSucursal.Properties.ReadOnly = True
        teNombre.Focus()
    End Sub

    Private Sub adm_frmSucursales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdSucursal = objFunciones.ObtenerUltimoId("adm_Sucursales", "IdSucursal")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdSucursalStart As Integer = 0
        Dim IdSucursalEnd As Integer = 0
        'Evaluo si el registro es primero para que este conserve su estado'
        If TipoAvance = -1 Then
            IdSucursalStart = objFunciones.ObtenerPrimerId("adm_Sucursales", "IdSucursal")
            If IdSucursal = IdSucursalStart Then
                IdSucursal = IdSucursal + 1
            End If
        End If
        'Evaluo si el registro es el ultimo para que este conserve su estado'
        If TipoAvance = 1 Then
            IdSucursalEnd = objFunciones.ObtenerUltimoId("adm_Sucursales", "IdSucursal")
            If IdSucursal = IdSucursalEnd Then
                IdSucursal = IdSucursal - 1
            End If
        End If

        If IdSucursal = 0 Then
            Exit Sub
        End If
        IdSucursal = bl.ObtenerIdSucursal(IdSucursal, TipoAvance)
        If IdSucursal = 0 Then
            Exit Sub
        End If
        entidad = objTablas.adm_SucursalesSelectByPK(IdSucursal)
        With entidad
            teIdSucursal.EditValue = .IdSucursal
            teNombre.EditValue = .Nombre
            teResponsable.EditValue = .Responsable
            teTelefono.EditValue = .Telefonos
            seCorrelativo.EditValue = .CorrelativoPago
            teCiudad.EditValue = .Ciudad
        End With
    End Sub

    Private Sub ActivarControles(ByVal Tipo As Boolean)
        For Each ctrl In PanelControl1.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.RadioGroup Then
                CType(ctrl, DevExpress.XtraEditors.RadioGroup).Properties.ReadOnly = Not Tipo
            End If
        Next
    End Sub

    Private Sub adm_frmSucursales_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entidad = New adm_Sucursales
        teIdSucursal.EditValue = objFunciones.ObtenerUltimoId("adm_Sucursales", "IdSucursal") + 1
        teIdSucursal.Properties.ReadOnly = True
        teNombre.EditValue = ""
        teResponsable.EditValue = ""
        teTelefono.EditValue = ""
        teSerie.EditValue = ""
        seCorrelativo.EditValue = 0
        teCiudad.EditValue = ""
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox(String.Format("Debe especificar el nombre de la Sucursal{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub adm_frmSucursales_Query_Click() Handles Me.Consulta
        'IdSucursal = objConsultas.cnsSucursales(frmConsultas)
        'CargaControles(0)
    End Sub


    Private Sub adm_frmSucursales_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            objTablas.adm_SucursalesInsert(entidad)
            MsgBox("La Sucursal ha sido guardada con éxito", MsgBoxStyle.Information)
        Else
            objTablas.adm_SucursalesUpdate(entidad)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entidad
            .IdSucursal = teIdSucursal.EditValue
            .Nombre = teNombre.EditValue
            .Responsable = teResponsable.EditValue
            .Telefonos = teTelefono.EditValue
            .CorrelativoPago = seCorrelativo.EditValue
            .Ciudad = teCiudad.EditValue
        End With
    End Sub

    Private Sub adm_frmSucursales_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

End Class
