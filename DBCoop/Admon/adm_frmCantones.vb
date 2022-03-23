Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmCantones
    Dim entidad As adm_cantones
    Dim Id As Integer = 0
    Dim bl As New PrestamosBLL()
    Dim fun As New FuncionesBLL()

    Private Sub pre_frmCantones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        Id = objFunciones.ObtenerUltimoId("adm_Cantones", "Id")
        CargaControles(0)
        ActivarControles(False)
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdCantonStart As Integer = 0
        Dim IdCantonEnd As Integer = 0
        If TipoAvance = -1 Then
            IdCantonStart = objFunciones.ObtenerPrimerId("adm_Cantones", "Id")
            If Id = IdCantonStart Then
                Id = Id + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdCantonEnd = objFunciones.ObtenerUltimoId("adm_cantones", "Id")
            If Id = IdCantonEnd Then
                Id = Id - 1
            End If
        End If

        If Id = 0 Then
            Exit Sub
        End If
        Id = bl.ObtenerIdCanton(Id, TipoAvance)
        If Id = 0 Then
            Exit Sub
        End If
        entidad = objTablas.adm_spCantonesSelectByPK(Id)
        With entidad
            teIdCanton.EditValue = .Id
            teNombre.EditValue = .Nombre
            cboDepartamento.EditValue = .IdDepartamento
            cboMunicipio.EditValue = .IdMunicipio
            teCodCanton.EditValue = .IdCanton
            chkComunidad.EditValue = .EsRural
        End With

    End Sub

    Private Sub pre_frmCantones_Delete_Click() Handles Me.Eliminar
        If MsgBox("Está seguro(a) de eliminar el Canton?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""

            Try
                objTablas.adm_cantonesDeleteByPK(teCodCanton.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El cantón ha sido eliminado con éxito", MsgBoxStyle.Information)
                Id = teIdCanton.EditValue - 1
                CargaControles(-1)
            Else
                MsgBox("No fue posible eliminar la comunidad o cantón" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub pre_frmCantones_Edit_Click() Handles Me.Editar
        ActivarControles(True)
        teCodCanton.Properties.ReadOnly = True
        cboDepartamento.Focus()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Departamentos(cboDepartamento)
        objCombos.adm_Municipios(cboMunicipio, "")
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
            teIdCanton.Properties.ReadOnly = True
            cboDepartamento.Properties.ReadOnly = True
            cboMunicipio.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub cboDepartamento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.EditValueChanged
        objCombos.adm_Municipios(cboMunicipio, cboDepartamento.EditValue)
        If DbMode = DbModeType.insert And teNombre.Properties.ReadOnly = False Then
            cboDepartamento_Validated(cboDepartamento, New System.EventArgs)
        End If
    End Sub

    Private Sub pre_frmCantones_New_Click() Handles Me.Nuevo
        ActivarControles(True)
        entidad = New adm_cantones
        teIdCanton.EditValue = objFunciones.ObtenerUltimoId("adm_cantones", "Id") + 1
        teIdCanton.Properties.ReadOnly = True
        teCodCanton.EditValue = ""
        teNombre.EditValue = ""
        chkComunidad.Checked = True
        cboDepartamento.EditValue = ""
        cboMunicipio.EditValue = ""
        teCodCanton.Properties.ReadOnly = True
        cboDepartamento.Focus()
    End Sub

    Function DatosValidos() As Boolean
        If teCodCanton.EditValue = "" Then
            MsgBox(String.Format("Debe especificar el código de cantón{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teCodCanton.Focus()
            Return False
        End If
        If teNombre.EditValue = "" Then
            MsgBox("Debe especificar el nombre de la comunidad o cantón" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teCodCanton.Focus()
            Return False
        End If
        If bl.ExisteCodCanton(teCodCanton.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe el código del cantón", MsgBoxStyle.Critical)
            Return False
        End If

        Return True
    End Function

    Private Sub pre_frmCantones_Query_Click() Handles Me.Consulta
        Id = objConsultas.ConsultaCantones(frmConsultas)
        CargaControles(0)
    End Sub

    Private Sub pre_frmCantones_Report_Click() Handles Me.Reporte
        Dim rpt As New pre_rptCantones
        rpt.DataSource = bl.rptCantones()
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub pre_frmCantones_Save_Click() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            objTablas.adm_cantonesInsert(entidad)
            MsgBox("El cantón ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            objTablas.adm_cantonesUpdate(entidad)
            MsgBox("El cantón ha sido actualizado con éxito", MsgBoxStyle.Information)
        End If
        MostrarModoInicial()
        ActivarControles(False)
    End Sub

    Private Sub CargaEntidades()
        With entidad
            .Id = teIdCanton.EditValue
            .IdCanton = teCodCanton.EditValue
            .Nombre = teNombre.EditValue
            .EsRural = chkComunidad.Checked
            .IdDepartamento = cboDepartamento.EditValue
            .IdMunicipio = cboMunicipio.EditValue
        End With
    End Sub

    Private Sub pre_frmCantones_Undo_Click() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub

    Private Sub cboDepartamento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboDepartamento.Validated
        If DbMode = DbModeType.insert Then
            If Not (cboDepartamento.Text = "" And cboMunicipio.Text = "") Then
                Dim cCanton As String
                Dim nCanton As Integer
                cCanton = fun.GetUltCanton(cboMunicipio.EditValue)
                If cCanton.Substring(0, 1) = " " Then
                    nCanton = 0
                Else
                    nCanton = CType(cCanton.Substring(4, 2), Integer)
                End If
                teCodCanton.EditValue = cboMunicipio.EditValue & (nCanton + 1).ToString.PadLeft(2, "0")
            End If
        End If
    End Sub

    Private Sub cboMunicipio_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboMunicipio.EditValueChanged
        If DbMode = DbModeType.insert And teNombre.Properties.ReadOnly = False Then
            cboDepartamento_Validated(cboDepartamento, New System.EventArgs)
        End If
    End Sub

    Private Sub adm_frmCantones_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptCantones(), "")
    End Sub
End Class

