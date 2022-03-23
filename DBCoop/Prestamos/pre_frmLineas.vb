Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmLineas
    Dim entLinea As coo_Lineas
    Dim IdLinea As Integer = 0
    Dim bl As New PrestamosBLL()
    Dim entCuentas As con_Cuentas


    Private Sub pre_frmLineas_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar la línea de crédito?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_LineasDeleteByPK(IdLinea)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La línea de crédito ha sido eliminada con éxito", MsgBoxStyle.Information)
                IdLinea = teIdLinea.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar la Linea de Crédito" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmLineas_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teIdLinea.Properties.ReadOnly = True
        teNombre.Focus()
    End Sub


    Private Sub pre_frmLineas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdLinea = objFunciones.ObtenerUltimoId("Coo_Lineas", "IdLinea")
        CargarCombos()
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Private Sub CargarCombos()
        objCombos.adm_TiposLinea(leTipoLinea, "")
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

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdLineaStart As Integer = 0
        Dim IdLineaEnd As Integer = 0
        If TipoAvance = -1 Then
            IdLineaStart = objFunciones.ObtenerPrimerId("Coo_Lineas", "IdLinea")
            If IdLinea = IdLineaStart Then
                IdLinea = IdLinea + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdLineaEnd = objFunciones.ObtenerUltimoId("Coo_Lineas", "IdLinea")
            If IdLinea = IdLineaEnd Then
                IdLinea = IdLinea - 1
            End If
        End If
        If IdLinea = 0 Then
            Exit Sub
        End If
        IdLinea = bl.ObtenerIdLinea(IdLinea, TipoAvance)
        If IdLinea = 0 Then
            Exit Sub
        End If
        entLinea = objTablas.coo_LineasSelectByPK(IdLinea)
        With entLinea
            teIdLinea.EditValue = .IdLinea
            teNombre.EditValue = .Nombre
            seTasa.EditValue = .TasaInteres
            beCta01.EditValue = .IdCuentaContableInt
            'beCta01_Validated(beCta01, New System.EventArgs)
            beCta02.EditValue = .IdCuentaContableMora
            'beCta02_Validated(beCta02, New System.EventArgs)
            beCta03.EditValue = .IdCuentaCapitalCortoPlazo
            beCta05.EditValue = .IdCuentaCapitalLargoPlazo
            beCta06.EditValue = .IdCuentaRecuperacionJudicial
            beCta07.EditValue = .IdCuentaIrrecuperable
            tePrioridad.EditValue = .Prioridad
            tePrioridadRetiro.EditValue = .PrioridadRetiroSocios
            leTipoLinea.EditValue = .TipoLinea
            chkSinCentavos.EditValue = .CuotaSinCentavos
            'beCta03_Validated(beCta03, New System.EventArgs)
        End With
    End Sub

    
    Private Sub pre_frmLineas_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entLinea = New coo_Lineas
        teIdLinea.EditValue = objFunciones.ObtenerUltimoId("Coo_Lineas", "IdLinea") + 1
        teIdLinea.Properties.ReadOnly = True
        teNombre.EditValue = ""
        seTasa.EditValue = 0.0
        beCta01.EditValue = ""
        teCta01.EditValue = ""
        beCta02.EditValue = ""
        teCta02.EditValue = ""
        beCta03.EditValue = ""
        teCta03.EditValue = ""
        tePrioridad.EditValue = ""
        leTipoLinea.EditValue = 1
        tePrioridad.EditValue = 0
        tePrioridadRetiro.EditValue = 0
        chkSinCentavos.Checked = False
        teNombre.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teNombre.EditValue = "" Then
            MsgBox("Debe especificar el Nombre de la línea de Credito" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNombre.Focus()
            Return False
        End If
        'If seTasa.EditValue <= 0 Then
        '    MsgBox("La Tasa de Interés de la Linea de Crédito no puede ser 0" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    teNombre.Focus()
        '    Return False
        'End If
        Return True
    End Function


    Private Sub pre_frmLineas_Query_Click() Handles Me.Consulta
        IdLinea = objConsultas.cnsLineas(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmLineas_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptLineas
        rpt.DataSource = objTablas.coo_LineasSelectAll()
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmLineas_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            objTablas.coo_LineasInsert(entLinea)
            MsgBox("La línea de crédito ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            objTablas.coo_LineasUpdate(entLinea)
            MsgBox("La Linea de Credito ha sido actualizada con éxito", MsgBoxStyle.Information)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entLinea
            .IdLinea = teIdLinea.EditValue
            .Nombre = teNombre.EditValue
            .TasaInteres = seTasa.EditValue
            .IdCuentaCapitalCortoPlazo = beCta03.EditValue
            .IdCuentaCapitalLargoPlazo = beCta05.EditValue
            .IdCuentaRecuperacionJudicial = beCta06.EditValue
            .IdCuentaIrrecuperable = beCta07.EditValue
            .IdCuentaContableInt = beCta01.EditValue
            .IdCuentaContableMora = beCta02.EditValue
            .Prioridad = tePrioridad.EditValue
            .PrioridadRetiroSocios = tePrioridadRetiro.EditValue
            .TipoLinea = leTipoLinea.EditValue
            .CuotaSinCentavos = chkSinCentavos.EditValue
        End With
    End Sub

    Private Sub pre_frmLineas_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

    Private Sub pre_frmLineas_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(objTablas.coo_LineasSelectAll(), "")
    End Sub
    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        beCta01.EditValue = ""
        beCta01_Validated(beCta01, New System.EventArgs)
    End Sub
    Private Sub beCta02_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta02.ButtonClick
        beCta02.EditValue = ""
        beCta02_Validated(beCta02, New System.EventArgs)
    End Sub
    Private Sub beCta03_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta03.ButtonClick
        beCta03.EditValue = ""
        beCta03_Validated(beCta03, New System.EventArgs)
    End Sub
    Private Sub beCta05_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta05.ButtonClick
        beCta05.EditValue = ""
        beCta05_Validated(beCta05, New System.EventArgs)
    End Sub
    Private Sub beCta06_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta06.ButtonClick
        beCta06.EditValue = ""
        beCta06_Validated(beCta06, New System.EventArgs)
    End Sub
    Private Sub beCta07_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta07.ButtonClick
        beCta07.EditValue = ""
        beCta07_Validated(beCta07, New System.EventArgs)
    End Sub




    Private Sub beCta01_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta02_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta02.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta02.EditValue)
        beCta02.EditValue = entCuentas.IdCuenta
        teCta02.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta03_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta03.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta03.EditValue)
        beCta03.EditValue = entCuentas.IdCuenta
        teCta03.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta05_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta05.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta05.EditValue)
        beCta05.EditValue = entCuentas.IdCuenta
        teCta05.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta06_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta06.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta06.EditValue)
        beCta06.EditValue = entCuentas.IdCuenta
        teCta06.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta07_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta07.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta07.EditValue)
        beCta07.EditValue = entCuentas.IdCuenta
        teCta07.EditValue = entCuentas.Nombre
    End Sub
End Class
