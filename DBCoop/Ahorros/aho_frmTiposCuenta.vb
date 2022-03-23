Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports System.IO
Public Class aho_frmTiposCuenta
    Dim entTipoCuenta As coo_TiposCuentaAhorro
    Dim IdTipo As Integer = 0
    Dim FileName As String
    Dim cn As New AdmonBLL()
    Dim bl As New AhorrosBLL()

    Private Sub aho_frmTiposCuenta_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar el Tipo de Cuenta?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""

            Try
                objTablas.coo_TiposCuentaAhorroDeleteByPK(IdTipo)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El Tipo de Cuenta ha sido eliminado con éxito", MsgBoxStyle.Information)
                IdTipo = teIdTipo.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar el tipo de cuenta" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub aho_frmTiposCuenta_Edit_Click() Handles MyBase.Editar
        ActivarControles(True)
        teIdTipo.Properties.ReadOnly = True
        teCuenta.Properties.ReadOnly = True
        teNombre.Focus()
    End Sub

    Private Sub aho_frmTiposCuenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        IdTipo = objFunciones.ObtenerUltimoId("Coo_TiposCuentaAhorro", "IdTipo")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdTipoStart As Integer = 0
        Dim IdTipoEnd As Integer = 0
        If TipoAvance = -1 Then
            IdTipoStart = objFunciones.ObtenerPrimerId("COO_TiposCuentaAhorro", "IdTipo")
            If IdTipo = IdTipoStart Then
                IdTipo = IdTipo + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdTipoEnd = objFunciones.ObtenerUltimoId("Coo_TiposCuentaAhorro", "IdTipo")
            If IdTipo = IdTipoEnd Then
                IdTipo = IdTipo - 1
            End If
        End If
        If IdTipo = 0 Then
            Exit Sub
        End If
        IdTipo = bl.ObtenerIdTipoCuentaAhorro(IdTipo, TipoAvance)
        If IdTipo = 0 Then
            Exit Sub
        End If
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(IdTipo)
        With entTipoCuenta
            teIdTipo.EditValue = .IdTipo
            teNombre.EditValue = .Nombre
            beIdCuenta.EditValue = .IdCuentaContable
            sePlazoDias.EditValue = .PlazoDias
            cboTipoCuenta.EditValue = CInt(.TipoAhorro)
            seTasa.EditValue = .TasaInteres
            seCorrelativo.EditValue = .Correlativo
            beIdCuenta02.EditValue = .IdCuentaCosto
            beIdCuenta03.EditValue = .IdCuentaGasto
        End With

        Dim entCuentas As New con_Cuentas
        entCuentas = objTablas.con_CuentasSelectByPK(beIdCuenta.EditValue)
        beIdCuenta.EditValue = entCuentas.IdCuenta
        teCuenta.EditValue = entCuentas.Nombre

        Dim entCuentas1 As New con_Cuentas
        entCuentas1 = objTablas.con_CuentasSelectByPK(beIdCuenta02.EditValue)
        beIdCuenta02.EditValue = entCuentas1.IdCuenta
        teCuenta02.EditValue = entCuentas1.Nombre

        Dim entCuentas2 As New con_Cuentas
        entCuentas2 = objTablas.con_CuentasSelectByPK(beIdCuenta03.EditValue)
        beIdCuenta03.EditValue = entCuentas2.IdCuenta
        teCuenta03.EditValue = entCuentas2.Nombre

    End Sub

    Private Sub beIdCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim entCuentas As New con_Cuentas
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beIdCuenta.EditValue)
        beIdCuenta.EditValue = entCuentas.IdCuenta
        teCuenta.EditValue = entCuentas.Nombre
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
        Next
    End Sub

    Private Sub CargaCombos()
        objCombos.coo_TipoCuentaAhorro(cboTipoCuenta, "")
    End Sub

    Private Sub aho_frmTiposCuenta_New_Click() Handles MyBase.Nuevo
        ActivarControles(True)
        entTipoCuenta = New coo_TiposCuentaAhorro
        teIdTipo.EditValue = objFunciones.ObtenerUltimoId("Coo_TiposCuentaAhorro", "IdTipo") + 1
        teIdTipo.Properties.ReadOnly = True
        teCuenta.Properties.ReadOnly = True
        teNombre.EditValue = ""
        beIdCuenta.EditValue = ""
        teCuenta.EditValue = ""
        sePlazoDias.EditValue = 0.0
        cboTipoCuenta.EditValue = 1
        seTasa.EditValue = 0.0
        seCorrelativo.EditValue = 0.0
        beIdCuenta02.EditValue = ""
        beIdCuenta03.EditValue = ""
        teCuenta02.EditValue = ""
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox("Debes especificar el Nombre del Tipo de Cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub aho_frmTiposCuenta_Query_Click() Handles Me.Consulta
        IdTipo = objConsultas.cnsTiposCuentaAhorro(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub aho_frmTiposCuenta_Save_Click() Handles MyBase.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            msj = bl.InsertaTipoCuentaAhorro(entTipoCuenta)
            If msj = "" Then
                MsgBox("El Tipo de Cuenta ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el Tipo de Cuenta" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = bl.UpdateTipoCuentaAhorro(entTipoCuenta)
            If msj = "" Then
                MsgBox("El Tipo de Cuenta ha sido actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el Tipo de Cuenta" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entTipoCuenta
            .IdTipo = teIdTipo.EditValue
            .Nombre = teNombre.EditValue
            .IdCuentaContable = beIdCuenta.EditValue
            .PlazoDias = sePlazoDias.EditValue
            .TipoAhorro = cboTipoCuenta.EditValue
            .TasaInteres = seTasa.EditValue
            .Correlativo = seCorrelativo.EditValue
            .IdCuentaCosto = beIdCuenta02.EditValue
            .IdCuentaGasto = beIdCuenta03.EditValue
        End With
    End Sub

    Private Sub beIdCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles beIdCuenta.Click
        beIdCuenta.EditValue = ""
        beIdCuenta_Validated(beIdCuenta, New System.EventArgs)
    End Sub


    Private Sub beIdCuenta02_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles beIdCuenta02.Click
        beIdCuenta02.EditValue = ""
        beIdCuenta02_Validated(beIdCuenta02, New System.EventArgs)
    End Sub
    Private Sub beIdCuenta03_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles beIdCuenta03.Click
        beIdCuenta03.EditValue = ""
        beIdCuenta03_Validated(beIdCuenta03, New System.EventArgs)
    End Sub

    Private Sub aho_frmTiposCuenta_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

    Private Sub beIdCuenta02_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim entCuentas As New con_Cuentas
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beIdCuenta02.EditValue)
        beIdCuenta02.EditValue = entCuentas.IdCuenta
        teCuenta02.EditValue = entCuentas.Nombre
    End Sub

    Private Sub beIdCuenta03_Validated(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim entCuentas As New con_Cuentas
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beIdCuenta03.EditValue)
        beIdCuenta03.EditValue = entCuentas.IdCuenta
        teCuenta03.EditValue = entCuentas.Nombre
    End Sub

End Class
