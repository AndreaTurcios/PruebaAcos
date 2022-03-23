Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmDeduccionesPrestamo
    Dim entDeduccion As coo_DeduccionesPrestamo
    Dim IdDeduccion As Integer = 0
    Dim entCuentas As con_Cuentas
    Dim bl As New PrestamosBLL()
    Dim blCaja As New TableBusiness()


    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdDeduccionStart As Integer = 0
        Dim IdDeduccionEnd As Integer = 0
        If TipoAvance = -1 Then
            IdDeduccionStart = objFunciones.ObtenerPrimerId("Coo_DeduccionesPrestamo", "IdDeduccion")
            If IdDeduccion = IdDeduccionStart Then
                IdDeduccion = IdDeduccion + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdDeduccionEnd = objFunciones.ObtenerUltimoId("Coo_DeduccionesPrestamo", "IdDeduccion")
            If IdDeduccion = IdDeduccionEnd Then
                IdDeduccion = IdDeduccion - 1
            End If
        End If
        If IdDeduccion = 0 Then
            Exit Sub
        End If
        IdDeduccion = bl.ObtenerIdDeduccionPrestamo(IdDeduccion, TipoAvance)
        If IdDeduccion = 0 Then
            Exit Sub
        End If
        entDeduccion = objTablas.coo_DeduccionesPrestamoSelectByPK(IdDeduccion)
        With entDeduccion
            teIdDeduccion.EditValue = .IdDeduccion
            teNombre.EditValue = .Nombre
            beCta01.EditValue = .IdCuenta
            beCta01_Validated(beCta01, New System.EventArgs)
            chkAplicaIva.EditValue = .AplicaIva
            cboTipoCalculo.EditValue = .TipoCalculo
            teValor.EditValue = .Valor
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
        entCuentas = blCaja.con_CuentasSelectByPK(beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de Eliminar el Tipo de Deducción?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_DeduccionesPrestamoDeleteByPK(IdDeduccion)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El tipo de Deducción ha sido eliminado con éxito", MsgBoxStyle.Information)
                IdDeduccion = teIdDeduccion.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar el tipo de deducción" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdDeduccion.Properties.ReadOnly = True
        teNombre.Focus()
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

    Private Sub pre_frmDeduccionesPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdDeduccion = objFunciones.ObtenerUltimoId("Coo_DeduccionesPrestamo", "IdDeduccion")
        objCombos.coo_TipoCalculoDeduccion(cboTipoCalculo, "")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entDeduccion = New coo_DeduccionesPrestamo
        teIdDeduccion.EditValue = objFunciones.ObtenerUltimoId("coo_DeduccionesPrestamo", "IdDeduccion") + 1
        teIdDeduccion.Properties.ReadOnly = True
        teNombre.EditValue = ""
        beCta01.EditValue = ""
        teCta01.EditValue = ""
        chkAplicaIva.EditValue = False
        cboTipoCalculo.EditValue = 1
        teValor.EditValue = 0.0
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox(String.Format("Debe especificar el nombre del tipo de deducción{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub pre_frmDeduccionesPrestamo_Query_Click() Handles Me.Consulta
        IdDeduccion = objConsultas.cnsDeduccionesPrestamo(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptDeduccionesPrestamo
        rpt.DataSource = blCaja.coo_DeduccionesPrestamoSelectAll()
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            objTablas.coo_DeduccionesPrestamoInsert(entDeduccion)
            MsgBox("El Tipo de deducción ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            objTablas.coo_DeduccionesPrestamoUpdate(entDeduccion)
            MsgBox("El tipo de deducción ha sido actualizada con éxito", MsgBoxStyle.Information)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entDeduccion
            .IdDeduccion = teIdDeduccion.EditValue
            .Nombre = teNombre.EditValue
            .IdCuenta = beCta01.EditValue
            .AplicaIva = chkAplicaIva.EditValue
            .TipoCalculo = cboTipoCalculo.EditValue
            .Valor = teValor.EditValue
        End With
    End Sub

    Private Sub pre_frmDeduccionesPrestamo_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub


    Private Sub pre_frmDeduccionesPrestamo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(blCaja.coo_DeduccionesPrestamoSelectAll(), "")
    End Sub
End Class
