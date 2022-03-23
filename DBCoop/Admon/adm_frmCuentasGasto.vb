Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmCuentasGasto
    Dim entidad As coo_CuentasGastos
    Dim entCuentas As New con_Cuentas
    Dim Id As Integer = 0
    Dim bl As New AdmonBLL()
    Dim fun As New FuncionesBLL()

    Private Sub pre_frmCuentasGasto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        Id = objFunciones.ObtenerUltimoId("coo_CuentasGastos", "IdCuenta")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdCuentaGastoStart As Integer = 0
        Dim IdCuentaGastoEnd As Integer = 0
        If TipoAvance = -1 Then
            IdCuentaGastoStart = objFunciones.ObtenerPrimerId("coo_cuentasGastos", "IdCuenta")
            If Id = IdCuentaGastoStart Then
                Id = Id + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdCuentaGastoEnd = objFunciones.ObtenerUltimoId("coo_cuentasgastos", "Idcuenta")
            If Id = IdCuentaGastoEnd Then
                Id = Id - 1
            End If
        End If

        If Id = 0 Then
            Exit Sub
        End If
        Id = bl.ObtenerIdCuentaGasto(Id, TipoAvance)
        If Id = 0 Then
            Exit Sub
        End If
        entidad = bl.coo_CuentasGastosSelectByCuenta(Id)
        With entidad
            teIdCuenta.EditValue = .IdCuenta
            teNombre.EditValue = .Nombre
            cboRubro.EditValue = .IdRubro
            beCta01.EditValue = .CuentaContable
            beCta01_Validated(beCta01, New System.EventArgs)
        End With

    End Sub

    Private Sub pre_frmCuentasGasto_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar la Cuenta Gasto?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""

            Try
                objTablas.coo_CuentasGastosDeleteByPK(cboRubro.EditValue, teIdCuenta.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Cuenta ha sido eliminada con éxito", MsgBoxStyle.Information)
                Id = teIdCuenta.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar la Cuenta de Gasto" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmCuentasGasto_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdCuenta.Properties.ReadOnly = True
        cboRubro.Focus()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Rubros(cboRubro)
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
        If Not (DbModeType.insert = DbMode) Then
            teIdCuenta.Properties.ReadOnly = True
            cboRubro.Properties.ReadOnly = True
            cboRubro.Properties.ReadOnly = True
        End If
    End Sub


    Private Sub pre_frmCuentasGasto_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entidad = New coo_CuentasGastos
        teIdCuenta.EditValue = objFunciones.ObtenerUltimoId("coo_cuentasGastos", "IdCuenta") + 1
        teIdCuenta.Properties.ReadOnly = True
        teNombre.EditValue = ""
        cboRubro.EditValue = ""
        beCta01.EditValue = ""
        cboRubro.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox("Debe especificar el nombre de la cuenta de gastos" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            Return False
        End If

        Return True
    End Function

    Private Sub pre_frmCuentasGasto_Query_Click() Handles Me.Consulta
        Id = objConsultas.ConsultacuentasGastos(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmCuentasGasto_Report_Click() Handles Me.Reporte
        'Dim rpt As New pre_rptCantones
        'rpt.DataSource = bl.rptCantones()
        'rpt.DataMember = ""
        'rpt.xrlEmpresa.Text = gsNombre_Empresa
        'rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmCuentasGastos_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            objTablas.coo_CuentasGastosInsert(entidad)
            MsgBox("La Cuenta ha sido guardada con éxito", MsgBoxStyle.Information)
        Else
            objTablas.coo_CuentasGastosUpdate(entidad)
            MsgBox("La Cuenta ha sido actualizado con éxito", MsgBoxStyle.Information)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entidad
            .IdCuenta = teIdCuenta.EditValue
            .Nombre = teNombre.EditValue
            .IdRubro = cboRubro.EditValue
            .CuentaContable = beCta01.EditValue
        End With
    End Sub

    Private Sub pre_frmCuentasGastos_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub


    Private Sub adm_frmCuentasGastos_ReporteExcel() Handles Me.ReporteExcel
        ''DataTableToExcel(bl.rptCantones(), "")
    End Sub

    Private Sub beCta01_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub

    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        If teNombre.Properties.ReadOnly = False Then
            beCta01.EditValue = ""
            entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
            beCta01.EditValue = entCuentas.IdCuenta
            teCta01.EditValue = entCuentas.Nombre
        End If
    End Sub

End Class

