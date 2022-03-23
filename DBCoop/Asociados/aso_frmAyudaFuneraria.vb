Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraReports.UI
Public Class aso_frmAyudaFuneraria
    Dim blAdmon As New AdmonBLL(), blAsoc As New AsociadosBLL(), blApor As New AportacionesBLL()
    Dim entAyuda As coo_AyudaFuneraria
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim dtParam As DataTable = blAdmon.ObtieneParametros()


    Private Sub aho_frmIngresoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        teIdMovimiento.EditValue = objFunciones.ObtenerUltimoId("COO_AyudaFuneraria", "IdMovimiento")
        CargaControles(0)
        ActivarControles(False)
    End Sub
    Private Sub aho_frmIngresoCuentas_Nuevo() Handles Me.Nuevo

        ActivarControles(True)
        entAyuda = New coo_AyudaFuneraria
        ' el Id se agigna en la capa de datos
        teIdMovimiento.EditValue = 0
        teIdAsociado.EditValue = 0
        teNombreAsociado.EditValue = ""
        teCantidadOtrogada.EditValue = 0.0
        teNumAsociado.EditValue = ""
        deFechaMov.EditValue = Today
        teNombreFamiliar.EditValue = ""
        teParentesco.EditValue = ""
        teEdad.EditValue = ""
        lbControl.EditValue = ""
        deFechaDesceso.EditValue = Today
        teIdMovimiento.Properties.ReadOnly = True
        teNumAsociado.Focus()
    End Sub
    Private Sub aho_frmIngresoCuentas_Guardar() Handles Me.Guardar

        If Not DatosValidos() Then
            Exit Sub
        End If

        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            msj = blApor.InsertaAyudaFuneraria(entAyuda)
            If msj = "" Then
                MsgBox("El registro ha sido guardado con éxito", MsgBoxStyle.Information)
                teIdMovimiento.EditValue = entAyuda.IdMovimiento
            Else
                MsgBox(String.Format("No fue posible Insertar el registro {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = blApor.ActualizaFuneraria(entAyuda)
            If msj = "" Then
                MsgBox("El registro ha sido actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar el registro {0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        teIdMovimiento.EditValue = entAyuda.IdMovimiento
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub aho_frmIngresoCuentas_Editar() Handles Me.Editar

        ActivarControles(True)
        teNumAsociado.Focus()
    End Sub
    Private Sub aho_frmIngresoCuentas_Revertir() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub aho_frmIngresoCuentas_Consulta() Handles Me.Consulta

        teIdMovimiento.EditValue = objConsultas.cnsAyudaFuneraria(frmConsultas)
        CargaControles(0)
    End Sub
    Private Sub aho_frmIngresoCuentas_Reporte() Handles Me.Reporte

        Dim rpt As New aso_rptAyudaFuneraria
        rpt.DataSource = blAsoc.rptAyudaFuneraria(teIdMovimiento.EditValue)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlEmpresa2.Text = gsNombre_Empresa
        rpt.xrlNumAsociado.Text = teNumAsociado.EditValue
        rpt.xrlNumAsociado2.Text = teNumAsociado.EditValue
        rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
        rpt.xrlNombreAsociado2.Text = teNombreAsociado.EditValue
        rpt.ShowPreviewDialog()


    End Sub
    Private Sub aho_frmIngresoCuentas_Eliminar() Handles Me.Eliminar

        If MsgBox("¿Está seguro(a) de eliminar el registro actual?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_AyudaFunerariaDeleteByPK(teIdMovimiento.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El registro ha sido elminado con éxito", MsgBoxStyle.Information)
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar el registro {0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdStart As Integer = 0
        Dim IdEnd As Integer = 0

        If TipoAvance = -1 Then
            IdStart = objFunciones.ObtenerPrimerId("Coo_AyudaFuneraria", "IdMovimiento")
            If teIdMovimiento.EditValue = IdStart Then
                teIdMovimiento.EditValue = teIdMovimiento.EditValue + 1
            End If
        End If

        If TipoAvance = 1 Then
            IdEnd = objFunciones.ObtenerUltimoId("Coo_AyudaFuneraria", "IdMovimiento")
            If teIdMovimiento.EditValue = IdEnd Then
                teIdMovimiento.EditValue = teIdMovimiento.EditValue - 1
            End If
        End If

        If teIdMovimiento.EditValue = 0 Then
            Exit Sub
        End If

        'teIdMovimiento.EditValue = blAhorro.ObtenerIdCuenta(teIdCuenta.EditValue, TipoAvance)
        If teIdMovimiento.EditValue = 0 Then
            Exit Sub
        End If
        entAyuda = objTablas.coo_AyudaFunerariaSelectByPK(teIdMovimiento.EditValue)
        With entAyuda
            teIdMovimiento.EditValue = .IdMovimiento
            teIdAsociado.EditValue = .IdAsociado
            teNombreAsociado.EditValue = 1
            teCantidadOtrogada.EditValue = .CantidadOtorgada
            teNumAsociado_Validated(teNumAsociado, New EventArgs)
            deFechaMov.EditValue = .FechaServicio
            teNombreFamiliar.EditValue = .NombreFamiliar
            teParentesco.EditValue = .ParentescoFamiliar
            teEdad.EditValue = .EdadFamiliar
            deFechaDesceso.EditValue = .FechaDescesoFamiliar
            lbControl.EditValue = .Observaciones
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
            If TypeOf ctrl Is DevExpress.XtraEditors.DateEdit Then
                CType(ctrl, DevExpress.XtraEditors.DateEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        For Each ctrl In PanelControl2.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.DateEdit Then
                CType(ctrl, DevExpress.XtraEditors.DateEdit).Properties.ReadOnly = Not Tipo
            End If

        Next

    End Sub



    Function DatosValidos() As Boolean

        If teIdAsociado.EditValue = 0 Then
            MsgBox("Debe especificar el Número de Asociado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If

        If teCantidadOtrogada.EditValue = 0 Then
            MsgBox("Debe especificar la cantidad a otorgar" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teCantidadOtrogada.Focus()
            Return False
        End If

        If SiEsNulo(deFechaMov.EditValue, Nothing) = Nothing Then
            MsgBox("Debe especificar la Fecha de Uso del servicio" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFechaMov.Focus()
            Return False
        End If


        Return True
    End Function




    Private Sub CargaEntidades()
        With entAyuda
            .IdMovimiento = teIdMovimiento.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .FechaServicio = deFechaMov.EditValue
            .CantidadOtorgada = teCantidadOtrogada.EditValue
            .NombreFamiliar = teNombreFamiliar.EditValue
            .ParentescoFamiliar = teParentesco.EditValue
            .EdadFamiliar = teEdad.EditValue
            .FechaDescesoFamiliar = deFechaDesceso.EditValue
            .Observaciones = lbControl.Text

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick

        frmConsultaAsociados.ShowDialog()
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teNombreAsociado.EditValue = frmConsultaAsociados.Nombre
        teNumAsociado_Validated(e, New EventArgs)

    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated, teIdAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            'Exit Sub
        Else
            If teIdAsociado.EditValue = 0 Then
                Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
                If dt.Rows.Count = 0 Then
                    MsgBox("No existe el número de asociado ingresado", MsgBoxStyle.Critical, "Nota")
                    Exit Sub
                End If
                teIdAsociado.EditValue = dt.Rows(0).Item("IdAsociado")
            End If
        End If
        Dim Asoc As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        teNumAsociado.EditValue = Asoc.Numero
        teNombreAsociado.EditValue = Asoc.Nombres + " " + Asoc.Apellidos

    End Sub
End Class
