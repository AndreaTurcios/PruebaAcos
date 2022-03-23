Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports CajaBL
Imports System.Diagnostics
Imports System.Math
Public Class apo_frmRetirarSocio
    Dim entSolRetiro As coo_SolicitudRetiro
    Dim bl As New PrestamosBLL()
    Dim blAdmon As New AdmonBLL()
    ReadOnly blAporta As New AportacionesBLL(), blAhorro As New AhorrosBLL()
    Dim entSolRetiroPres As List(Of coo_SolicitudRetiroPrestamos)
    Dim blAsoc As New AsociadosBLL(), dtParam As DataTable = blAporta.ObtenerParametrosGenerales(), ds As DataSet
    Dim IdAsociado As Integer


    Private Sub pre_frmSolicitudPrestamo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        teIdSolicitud.EditValue = objFunciones.ObtenerUltimoId("coo_SolicitudRetiro", "IdSolicitud")
        CargaCombos()
        CargaControles(0)
        If Not SiEsNulo(teIdAsociado.EditValue, -1) = -1 Then
            gcPrestamos.DataSource = bl.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaRetiro.EditValue, -1, 0, teIdSolicitud.EditValue)
        End If
        ActivarControles(False)
    End Sub
    Private Sub CargaCombos()
        objCombos.coo_Lineas(leLinea, "")
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Nuevo() Handles Me.Nuevo
        IdAsociado = teIdAsociado.EditValue

        ActivarControles(True)
        entSolRetiro = New coo_SolicitudRetiro

        teIdSolicitud.EditValue = 0
        teNumAsociado.EditValue = ""
        teDui.EditValue = ""
        teIdAsociado.EditValue = 0
        teNombreAsociado.EditValue = ""
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deFechaRetiro.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        rgTipoRetiro.SelectedIndex = 0
        teSaldoCreditos.EditValue = 0.0
        teSaldosInteres.EditValue = 0.0
        teSaldosIntMora.EditValue = 0.0
        teSaldosSeguro.EditValue = 0.0

        teSaldosAhorro.EditValue = 0.0
        teSaldosAportacion.EditValue = 0.0
        teMontoPropiedad.EditValue = 0.0
        teMontoCobrar.EditValue = 0.0
        tePendiente.EditValue = 0.0
        teLiquidoEntregar.EditValue = 0.0
        meMotivo.EditValue = ""




        ds = blAdmon.ObtieneCorrelativos(gIdSucursal)
        teNumSol.EditValue = (ds.Tables(2).Rows(0).Item("UltimoValor") + 1).ToString.PadLeft(5, "0")
        gcPrestamos.DataSource = bl.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaRetiro.EditValue, -1, 0, 0)
        teNumAsociado.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Guardar() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = bl.InsertaSolicitudRetiro(entSolRetiro, entSolRetiroPres)

            If msj = "" Then
                MsgBox("La solicitud ha sido guardada con éxito", MsgBoxStyle.Information)
                teIdSolicitud.EditValue = entSolRetiro.IdSolicitud
            Else
                MsgBox(String.Format("No fue posible actualizar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else

            msj = bl.UpdateSolicitudRetiro(entSolRetiro, entSolRetiroPres)
            If msj = "" Then
                MsgBox("La solicitud de crédito ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la solicitud de crédito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If

        IdAsociado = teIdAsociado.EditValue
        LimpiarPantalla()
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Consulta() Handles Me.Consulta

        teIdSolicitud.EditValue = objConsultas.ConsultaSolicitudRetiro(frmConsultas)
        Dim entSol As coo_SolicitudRetiro = objTablas.coo_SolicitudRetiroSelectByPK(teIdSolicitud.EditValue)
        teNumSol.EditValue = entSol.NumeroSolicitud
        CargaControles(0)

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Editar() Handles Me.Editar

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If dFechaContable > deFecha.EditValue Then
        '    MsgBox("No es posible modificar la solicitud, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
        '    MostrarModoInicial()
        '    ActivarControles(False)
        '    Exit Sub
        'End If

        If entSolRetiro.AprobadoPor <> "" Then
            MsgBox(String.Format("La Solicitud ya fue aplicada", Chr(13)), MsgBoxStyle.Critical, "Error al Modificar")
            MostrarModoInicial()
            ActivarControles(False)
            Return
        End If

        ActivarControles(True)
        teNumSol.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Revertir() Handles Me.Revertir
        teIdAsociado.EditValue = IdAsociado
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Reporte() Handles Me.Reporte
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        Dim entSuc As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Dim Ubicaciones As coo_UbicacionesAsociados = objTablas.coo_UbicacionesAsociadosSelectByPK(entAso.IdUbicacion)
        Dim rpt As New apo_rptRetirarSocio
        Dim rpt1 As New apo_rptRetiroAsociados2

        'rpt1.DataSource = 
        'rpt1.DataMember = ""

        If rgTipoRetiro.SelectedIndex = 0 Then
            rpt.xrlTotal.Visible = True
            rpt.xrlParcial.Visible = False
        Else
            rpt.xrlTotal.Visible = False
            rpt.xrlParcial.Visible = True
        End If

        rpt.xrlNombreEmpresaLargo.Text = dtParam.Rows(0).Item("NombreLargo")
        rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
        rpt.xrlNumAsociado.Text = teNumAsociado.EditValue
        rpt.xrlCargo.Text = entAso.CargoTrabajo
        rpt.xrlDepartamento.Text = Ubicaciones.Nombre 'entAso.TelefonoTrabajoAnterior
        rpt.xrlLugarFecha.Text = entSuc.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.xrlObservaciones.Text = meMotivo.EditValue
        rpt.xrlDui.Text = entAso.NumeroDocumento
        rpt.xrlISSS.Text = entAso.IsssAfp

        rpt.ShowPreviewDialog()

        rpt1.xrlEmpresa.Text = dtParam.Rows(0).Item("NombreEmpresa")
        rpt1.xrlLugarFecha.Text = entSuc.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt1.xrlNumero.Text = teNumSol.EditValue
        rpt1.xrlNombre.Text = teNombreAsociado.EditValue
        rpt1.xrlNumAsociado.Text = teNumAsociado.EditValue
        rpt1.xrlDUI.Text = teDui.EditValue
        rpt1.xrlMotivo.Text = meMotivo.EditValue

        rpt1.xrlSaldo.Text = Format(teSaldoCreditos.EditValue, "##,###.00")
        rpt1.xrlSaldoInteres.Text = Format(teSaldosInteres.EditValue, "##,###.00")
        rpt1.xrlSaldoMora.Text = Format(teSaldosIntMora.EditValue, "##,###.00")
        rpt1.xrlSaldoSeguro.Text = Format(teSaldosSeguro.EditValue, "##,###.00")
        rpt1.xrlPendiente.Text = Format(tePendiente.EditValue, "##,###.00")
        rpt1.xrlMontoCobrar.Text = Format(teMontoCobrar.EditValue, "##,###.00")

        rpt1.xrlMontoAportado.Text = Format(teSaldosAportacion.EditValue, "##,###.00")
        rpt1.xrlSaldoAhorro.Text = Format(teSaldosAhorro.EditValue, "##,###.00")
        rpt1.xrlPropiedadSocio.Text = Format(teMontoPropiedad.EditValue, "##,###.00")
        rpt1.xrlLiquido.Text = Format(teLiquidoEntregar.EditValue, "##,###.00")

        If teLiquidoEntregar.EditValue < 0.0 Then
            rpt1.xrlLiquido.Visible = False
            rpt1.XrLabel35.Visible = False
            rpt1.XrLine19.Visible = False
        Else
            rpt1.xrlLiquido.Visible = True
            rpt1.XrLabel35.Visible = True
            rpt1.XrLine19.Visible = True
        End If

        If teMontoCobrar.EditValue < 0.0 Then
            rpt1.XrLabel26.Visible = False
            rpt1.xrlMontoCobrar.Visible = False
            rpt1.XrLine15.Visible = False
        Else
            rpt1.XrLabel26.Visible = True
            rpt1.xrlMontoCobrar.Visible = True
            rpt1.XrLine15.Visible = True
        End If

        Dim TotalLiquidar = teSaldosAportacion.EditValue + teSaldosAhorro.EditValue
        rpt1.XrSubreport1.ReportSource.DataSource = bl.GetPrestamosSolRetiro(teIdSolicitud.EditValue)
        rpt1.XrSubreport1.ReportSource.DataMember = ""
        rpt1.ShowPreviewDialog()

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Eliminar() Handles Me.Eliminar
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > deFecha.EditValue Then
            MsgBox("No es posible eliminar la solicitud, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End If

        If entSolRetiro.AprobadoPor <> "" Then
            MsgBox(String.Format("La Solicitud ya fue Aplicada", Chr(13)), MsgBoxStyle.Critical, "Error al Eliminar")
            Exit Sub
        End If


        If MsgBox("Está seguro(a) de eliminar la Solicitud de Retiro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try

                objTablas.coo_SolicitudRetiroDeleteByPK(teIdSolicitud.EditValue)

            Catch ex As Exception
                msj = ex.Message()
            End Try

            If msj = "" Then
                MsgBox("La Solicitud ha sido elminada con éxito", MsgBoxStyle.Information, "Nota")
                teIdSolicitud.EditValue -= 1
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Function DatosValidos() As Boolean
        If teNumAsociado.EditValue = "" Then
            MsgBox(String.Format("No se ha especificado el número de asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If
        If teNumSol.EditValue = "" Then
            MsgBox(String.Format("Es necesario especificar el número de Solicitud {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumSol.Focus()
            Return False
        End If

        If SiEsNulo(deFecha.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha de la solicitud{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If

        If SiEsNulo(deFechaRetiro.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha de Retiro{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaRetiro.Focus()
            Return False
        End If

        'If deFechaRetiro.EditValue < objFunciones.GetFechaContable(gIdSucursal) Then
        '    MsgBox(String.Format("La fecha de la solicitud no puede ser menor a la fecha contable{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    deFecha.Focus()
        '    Return False
        'End If

        If deFechaRetiro.EditValue < objFunciones.GetFechaContable(gIdSucursal) Then
            MsgBox(String.Format("La fecha de retiro no puede ser menor a la fecha contable{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaRetiro.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub LimpiarPantalla()
    End Sub

    Private Sub CargaEntidades()

        With entSolRetiro
            .IdSolicitud = teIdSolicitud.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .NumeroSolicitud = teNumSol.EditValue
            .Fecha = deFecha.EditValue
            .FechaRetiro = deFechaRetiro.EditValue
            .TipoRetiro = rgTipoRetiro.SelectedIndex
            .MotivoRetiro = meMotivo.EditValue
            .SaldoCreditos = teSaldoCreditos.EditValue
            .SaldoInteres = teSaldosInteres.EditValue
            .SaldoInteresMora = teSaldosIntMora.EditValue
            .SaldoSeguro = teSaldosSeguro.EditValue

            .MontoAhorrado = teSaldosAhorro.EditValue
            .MontoAportado = teSaldosAportacion.EditValue
            .MontoPropiedadSocio = teMontoPropiedad.EditValue
            .LiquidoEntregarSocio = teLiquidoEntregar.EditValue
            .PendienteCooperativa = tePendiente.EditValue
            .MontoCobrarSocio = teMontoCobrar.EditValue
            .IdCuentaCobrar = ""
            .Aplicado = 0

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
                .AprobadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With

        entSolRetiroPres = New List(Of coo_SolicitudRetiroPrestamos)
        For i = 0 To gvPrestamos.DataRowCount - 1
            Dim entDetalleA As New coo_SolicitudRetiroPrestamos
            With entDetalleA
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .Correlativo = i
                .IdPrestamo = gvPrestamos.GetRowCellValue(i, "IdPrestamo")
                .Numero = gvPrestamos.GetRowCellValue(i, "Numero")
                .IdLinea = gvPrestamos.GetRowCellValue(i, "IdLinea")
                .SaldoCapital = gvPrestamos.GetRowCellValue(i, "SaldoCapital")
                .SaldoInteres = gvPrestamos.GetRowCellValue(i, "SaldoInteres")
                .SaldoInteresMora = gvPrestamos.GetRowCellValue(i, "SaldoInteresMora")
                .SaldoOtros = gvPrestamos.GetRowCellValue(i, "SaldoOtros")
                .SaldoSeguro = gvPrestamos.GetRowCellValue(i, "SaldoSeguro")
            End With
            entSolRetiroPres.Add(entDetalleA)
        Next

    End Sub


    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        If teNumSol.Properties.ReadOnly = False Then
            frmConsultaAsociados.ShowDialog()
            teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
            teNumAsociado_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated, teIdAsociado.Validated

        If teIdAsociado.EditValue = 0 Then
            Dim dt1 As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
            If dt1.Rows.Count = 0 Then
                Exit Sub
            End If
            teIdAsociado.EditValue = dt1.Rows(0).Item("IdAsociado")
        End If

        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        teNumAsociado.EditValue = entAsociado.Numero
        teNombreAsociado.EditValue = entAsociado.Nombres + " " + entAsociado.Apellidos
        teDui.EditValue = entAsociado.NumeroDocumento

        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            ds = blAdmon.ObtieneCorrelativos(gIdSucursal)
            teNumSol.EditValue = (ds.Tables(2).Rows(0).Item("UltimoValor") + 1).ToString.PadLeft(5, "0")
        End If

        Dim dt As New DataTable()
        dt = blAporta.rptSolicitudRetiro(teIdAsociado.EditValue, deFechaRetiro.EditValue)

        teSaldoCreditos.EditValue = dt.Rows(0).Item("SaldoCapital")
        teSaldosInteres.EditValue = dt.Rows(0).Item("InteresesNormal")
        teSaldosIntMora.EditValue = dt.Rows(0).Item("InteresMoratorio")
        teSaldosSeguro.EditValue = dt.Rows(0).Item("Seguro")

        teSaldosAhorro.EditValue = dt.Rows(0).Item("TotalAhorro")
        teSaldosAportacion.EditValue = dt.Rows(0).Item("TotalAportaciones")
        teMontoPropiedad.EditValue = dt.Rows(0).Item("TotalAFavor")
        teMontoCobrar.EditValue = dt.Rows(0).Item("MontoCobrar")
        tePendiente.EditValue = dt.Rows(0).Item("TotalDeducciones")
        teLiquidoEntregar.EditValue = dt.Rows(0).Item("LiquidoEntregar")


        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            gcPrestamos.DataSource = bl.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaRetiro.EditValue, -1, 0, 0)
        End If
    End Sub

    Private Sub ActivarControles(ByVal Tipo As Boolean)
        teIdSolicitud.Properties.ReadOnly = True
        teNumAsociado.Properties.ReadOnly = Not Tipo
        teNumSol.Properties.ReadOnly = Not Tipo
        deFecha.Properties.ReadOnly = Not Tipo
        deFechaRetiro.Properties.ReadOnly = Not Tipo

        For Each ctrl In XtraTabPage7.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.RadioGroup Then
                CType(ctrl, DevExpress.XtraEditors.RadioGroup).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.PictureEdit Then
                CType(ctrl, DevExpress.XtraEditors.PictureEdit).Properties.ReadOnly = Not Tipo
            End If
        Next

        teNombreAsociado.Properties.ReadOnly = True
        If Not entSolRetiro Is Nothing Then
            sbAprobar.Enabled = Not entSolRetiro.AprobadoPor <> ""
        End If
    End Sub
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdSolicitudStart As Integer = 0
        Dim IdSolicitudEnd As Integer = 0
        If TipoAvance = -1 Then
            IdSolicitudStart = objFunciones.ObtenerPrimerId("coo_SolicitudRetiro ", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudStart Then
                teIdSolicitud.EditValue += 1
            End If
        End If
        If TipoAvance = 1 Then
            IdSolicitudEnd = objFunciones.ObtenerUltimoId("coo_SolicitudRetiro", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudEnd Then
                teIdSolicitud.EditValue -= 1
            End If
        End If
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        teIdSolicitud.EditValue = bl.ObtenerIdSolicitudRetiro(teIdSolicitud.EditValue, TipoAvance)
        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If
        entSolRetiro = objTablas.coo_SolicitudRetiroSelectByPK(teIdSolicitud.EditValue)
        With entSolRetiro
            teIdSolicitud.EditValue = .IdSolicitud
            teIdAsociado.EditValue = .IdAsociado
            deFechaRetiro.EditValue = .FechaRetiro
            teNumAsociado_Validated(teIdAsociado, New EventArgs)
            teNumSol.EditValue = .NumeroSolicitud
            deFecha.EditValue = .Fecha

            rgTipoRetiro.SelectedIndex = .TipoRetiro
            meMotivo.EditValue = .MotivoRetiro
            teSaldoCreditos.EditValue = .SaldoCreditos
            teSaldosInteres.EditValue = .SaldoInteres
            teSaldosIntMora.EditValue = .SaldoInteresMora
            teSaldosSeguro.EditValue = .SaldoSeguro

            teSaldosAhorro.EditValue = .MontoAhorrado
            teSaldosAportacion.EditValue = .MontoAportado
            teMontoPropiedad.EditValue = .MontoPropiedadSocio
            teLiquidoEntregar.EditValue = .LiquidoEntregarSocio
            tePendiente.EditValue = .PendienteCooperativa
            teMontoCobrar.EditValue = .MontoCobrarSocio

            If Not entSolRetiro Is Nothing Then
                sbAprobar.Enabled = Not entSolRetiro.AprobadoPor <> ""
            End If

        End With
        gcPrestamos.DataSource = bl.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaRetiro.EditValue, -1, 0, teIdSolicitud.EditValue)
    End Sub


    Private Sub sbAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAprobar.Click

        If Not rbMenu.qbSave.Visibility = DevExpress.XtraBars.BarItemVisibility.Never Then
            Exit Sub
        End If

        If Not teIdSolicitud.EditValue > 0 Then
            Exit Sub
        End If


        If entSolRetiro.AprobadoPor <> "" Then
            MsgBox(String.Format("La solicitud se encuentra aprobada", Chr(13)), MsgBoxStyle.Critical, "Error al Aprobar")
            Exit Sub
        End If


        If MsgBox("Está seguro(a) de aprobar esta solicitud?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            msj = bl.AprobarSolicitudRetiro(teIdSolicitud.EditValue, objMenu.User)

            If msj = "" Then
                MsgBox("La solicitud ha sido aprobada con éxito", MsgBoxStyle.Information, "Nota")
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible aprobar la solicitud {0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub deFechaRetiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deFechaRetiro.EditValueChanged
        If teIdAsociado.EditValue > 0 Then
            Dim dt As New DataTable()
            dt = blAporta.rptSolicitudRetiro(teIdAsociado.EditValue, deFechaRetiro.EditValue)

            teSaldoCreditos.EditValue = dt.Rows(0).Item("SaldoCapital")
            teSaldosInteres.EditValue = dt.Rows(0).Item("InteresesNormal")
            teSaldosIntMora.EditValue = dt.Rows(0).Item("InteresMoratorio")
            teSaldosSeguro.EditValue = dt.Rows(0).Item("Seguro")

            teSaldosAhorro.EditValue = dt.Rows(0).Item("TotalAhorro")
            teSaldosAportacion.EditValue = dt.Rows(0).Item("TotalAportaciones")
            teMontoPropiedad.EditValue = dt.Rows(0).Item("TotalAFavor")
            teMontoCobrar.EditValue = dt.Rows(0).Item("MontoCobrar")
            tePendiente.EditValue = dt.Rows(0).Item("TotalDeducciones")
            teLiquidoEntregar.EditValue = dt.Rows(0).Item("LiquidoEntregar")

            gcPrestamos.DataSource = bl.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaRetiro.EditValue, -1, 0, 0)
        End If
    End Sub

    Private Sub teNumAsociado_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.EditValueChanged

    End Sub
End Class
