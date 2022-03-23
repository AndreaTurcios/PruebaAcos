Imports DBCoopEL.TableEntities

Public Class adm_frmTipoMovimientoCaja
    Dim entTipoMovimiento As coo_TiposMovimientoCaja
    Dim IdTipoMovimiento As Integer = 0
    Dim entCuentas As con_Cuentas
    Dim bl As New DBCoopBL.PrestamosBLL()
    
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdTipoMovimientoStart As Integer = 0
        Dim IdTipoMovimientoEnd As Integer = 0
        If TipoAvance = -1 Then
            IdTipoMovimientoStart = objFunciones.ObtenerPrimerId("Coo_TiposMovimientoCaja", "IdTipo")
            If IdTipoMovimiento = IdTipoMovimientoStart Then
                IdTipoMovimiento = IdTipoMovimiento + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdTipoMovimientoEnd = objFunciones.ObtenerUltimoId("Coo_TiposMovimientoCaja", "IdTipo")
            If IdTipoMovimiento = IdTipoMovimientoEnd Then
                IdTipoMovimiento = IdTipoMovimiento - 1
            End If
        End If
        If IdTipoMovimiento = 0 Then
            Exit Sub
        End If
        IdTipoMovimiento = bl.ObtenerIdTipoMovimiento(IdTipoMovimiento, TipoAvance)
        If IdTipoMovimiento = 0 Then
            Exit Sub
        End If
        entTipoMovimiento = objTablas.coo_TiposMovimientoCajaSelectByPK(IdTipoMovimiento)
        With entTipoMovimiento
            teIdTipo.EditValue = .IdTipo
            teNombre.EditValue = .Nombre
            cboTipoAplicacion.EditValue = .TipoAPlicacion
            chkIncluyeIsr.EditValue = .AplicaIsr
            chkIncluyeIva.EditValue = .IncluyeIva
            seLineaCorte.EditValue = .LineaCorte
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

    Private Sub pre_frmTipoMovimientoCaja_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de Eliminar el Tipo de Movimiento de Caja?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_TiposMovimientoCajaDeleteByPK(IdTipoMovimiento)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El Tipo de Movimiento de Caja ha sido eliminado con éxito", MsgBoxStyle.Information)
                IdTipoMovimiento = teIdTipo.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar el Tipo de Movimiento de Caja" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmTipoMovimientoCaja_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdTipo.Properties.ReadOnly = True
        teNombre.Focus()
    End Sub


    Private Sub pre_frmTipoMovimientoCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        IdTipoMovimiento = objFunciones.ObtenerUltimoId("Coo_TiposMovimientoCaja", "IdTipo")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Private Sub CargaCombos()
        objCombos.preTipoMovimientoCaja(cboTipoAplicacion)
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

    Private Sub pre_frmTipoMovimientoCaja_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entTipoMovimiento = New coo_TiposMovimientoCaja
        teIdTipo.EditValue = objFunciones.ObtenerUltimoId("Coo_TiposMovimientoCaja", "IdTipo") + 1
        teIdTipo.Properties.ReadOnly = True
        teNombre.EditValue = ""
        beCta01.EditValue = ""
        teCta01.EditValue = ""
        cboTipoAplicacion.EditValue = 1
        seLineaCorte.EditValue = 0
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox("Debe especificar el Nombre del Tipo de Movimiento de Caja" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        Return True

        If seLineaCorte.EditValue <= 0 Then
            MsgBox("Debe especificar el Número de la Línea en el Corte de Caja" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        Return True

    End Function

    Private Sub pre_frmTipoMovimientoCaja_Query_Click() Handles Me.Consulta
        IdTipoMovimiento = objConsultas.cnsTiposMovimientoCaja(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmTipoMovimientoCaja_Report_Click() Handles Me.Reporte
        'Dim myRpt As New pre_rptLineas
        'myRpt.DataSource = blCaja.coo_LineasSelectAll()
        'myRpt.xrlEmpresa.Text = gsNombre_Empresa
        'myRpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmTipoMovimientoCaja_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        If DbMode = DbModeType.insert Then
            objTablas.coo_TiposMovimientoCajaInsert(entTipoMovimiento)
            MsgBox("El tipo de movimiento de caja ha sido guardado con éxito", MsgBoxStyle.Information, "Nota")
        Else
            objTablas.coo_TiposMovimientoCajaUpdate(entTipoMovimiento)
            MsgBox("El tipo de movimiento de caja ha sido actualizada con éxito", MsgBoxStyle.Information, "Nota")
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entTipoMovimiento
            .IdTipo = teIdTipo.EditValue
            .Nombre = teNombre.EditValue
            .TipoAPlicacion = cboTipoAplicacion.EditValue
            .IdCuentaContable = beCta01.EditValue
            .LineaCorte = seLineaCorte.EditValue
            .AplicaIsr = chkIncluyeIsr.EditValue
            .IncluyeIva = chkIncluyeIva.EditValue
        End With
    End Sub

    Private Sub pre_frmTipoMovimientoCaja_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

    Private Sub adm_frmTipoMovimientoCaja_ReporteExcel() Handles Me.ReporteExcel
        Dim dt As DataTable = objTablas.coo_TiposMovimientoCajaSelectAll
        DataTableToExcel(dt, "")
    End Sub
End Class
