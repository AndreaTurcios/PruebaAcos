Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmFormasPagoCaja
    Dim entidad As coo_FormasPagoCaja
    Dim IdTipoIngreso As Integer = 0
    Dim entCuentas As con_Cuentas
    Dim bl As New PrestamosBLL()
    
    Private Sub pre_frmTiposIngresoCaja_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de Eliminar el Tipo de Ingreso a Caja?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_FormasPagoCajaDeleteByPK(IdTipoIngreso)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El tipo de ingreso a caja ha sido eliminado con éxito", MsgBoxStyle.Information, "Nota")
                IdTipoIngreso = teIdTipo.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar el Tipo de Ingreso de Caja{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmTiposIngresoCaja_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdTipo.Properties.ReadOnly = True
        teNombre.Focus()
    End Sub

    Private Sub pre_frmTiposIngresoCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdTipoIngreso = objFunciones.ObtenerUltimoId("Coo_FormasPagoCaja", "IdFormaPago")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdTipoIngresoStart As Integer = 0
        Dim IdTipoIngresoEnd As Integer = 0
        'Evaluo si el registro es primero para que este conserve su estado'
        If TipoAvance = -1 Then
            IdTipoIngresoStart = objFunciones.ObtenerPrimerId("Coo_FormasPagoCaja", "IdFormaPago")
            If IdTipoIngreso = IdTipoIngresoStart Then
                IdTipoIngreso = IdTipoIngreso + 1
            End If
        End If
        'Evaluo si el registro es el ultimo para que este conserve su estado'
        If TipoAvance = 1 Then
            IdTipoIngresoEnd = objFunciones.ObtenerUltimoId("coo_FormasPagoCaja", "IdFormaPago")
            If IdTipoIngreso = IdTipoIngresoEnd Then
                IdTipoIngreso = IdTipoIngreso - 1
            End If
        End If

        If IdTipoIngreso = 0 Then
            Exit Sub
        End If
        IdTipoIngreso = bl.ObtenerIdFormaPago(IdTipoIngreso, TipoAvance)
        If IdTipoIngreso = 0 Then
            Exit Sub
        End If
        entidad = objTablas.coo_FormasPagoCajaSelectByPK(IdTipoIngreso)
        With entidad
            teIdTipo.EditValue = .IdFormaPago
            teNombre.EditValue = .Nombre
            tePrefijo.EditValue = .Prefijo
            rgAbonoCargo.EditValue = CInt(.AbonoCargo)
            'chkContabiliza.EditValue = .contabilizar
            beCta01.EditValue = .IdCuentaContable
            beCta01_Validated(beCta01, New System.EventArgs)
        End With
    End Sub

    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        If teNombre.Properties.ReadOnly = False Then
            beCta01.EditValue = ""
            entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
            beCta01.EditValue = entCuentas.IdCuenta
            teCta01.EditValue = entCuentas.Nombre
        End If
    End Sub

    Private Sub beCta01_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
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

    Private Sub pre_frmTiposIngresoCaja_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entidad = New coo_FormasPagoCaja
        teIdTipo.EditValue = objFunciones.ObtenerUltimoId("coo_FormasPagoCaja", "IdFormaPago") + 1
        teIdTipo.Properties.ReadOnly = True
        teNombre.EditValue = ""
        tePrefijo.EditValue = ""
        beCta01.EditValue = ""
        teCta01.EditValue = ""
        rgAbonoCargo.EditValue = 1
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox(String.Format("Debe especificar el nombre de la forma de pago{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        If tePrefijo.EditValue = "" Then
            MsgBox(String.Format("Debes especificar el Prefijo de la Forma de Pago{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            tePrefijo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub pre_frmTiposIngresoCaja_Query_Click() Handles Me.Consulta
        IdTipoIngreso = objConsultas.cnsFormasPagoCaja(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmTiposIngresoCaja_Report_Click() Handles Me.Reporte

    End Sub

    Private Sub pre_frmTiposIngresoCaja_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            objTablas.coo_FormasPagoCajaInsert(entidad)
            MsgBox("La forma de pago ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            objTablas.coo_FormasPagoCajaUpdate(entidad)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entidad
            .IdFormaPago = teIdTipo.EditValue
            .Nombre = teNombre.EditValue
            .Prefijo = tePrefijo.EditValue
            .AbonoCargo = rgAbonoCargo.EditValue
            .IdCuentaContable = beCta01.EditValue
            .FHCreacion = Now
            .CreadoPor = objMenu.User
            '.contabilizar = chkContabiliza.EditValue
        End With
    End Sub

    Private Sub pre_frmTiposIngresoCaja_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

End Class
