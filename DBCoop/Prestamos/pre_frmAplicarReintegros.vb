Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Diagnostics
Public Class pre_frmAplicarReintegros
    Dim entSolicitud As coo_AplicarReintegros
    Dim bl As New PrestamosBLL()
    Dim blAdmon As New AdmonBLL()
    Dim blCaja As New CajaBusiness()
    Dim blPrestamo As New Prestamo
    Dim elpagodetalle As New coo_PrestamosDetalle
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    ReadOnly blAporta As New AportacionesBLL(), blAhorro As New AhorrosBLL()
    Dim blAsoc As New AsociadosBLL(), dtParam As DataTable = blAporta.ObtenerParametrosGenerales()
    Dim entReintegroAhorros As List(Of coo_AplicarReintegrosAhorros)
    Dim entReintegroPrestamos As List(Of coo_AplicarReintegrosPrestamos), IdAsociado As Integer = 0
    Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
    Dim EntUltMovAhorro As coo_UltMovAhorro


    Private Sub pre_frmSolicitudPrestamo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        teIdSolicitud.EditValue = objFunciones.ObtenerUltimoId("coo_AplicarReintegros", "IdSolicitud")
        CargaControles(0)

        gcAhorros.DataSource = blAhorro.GetSaldosAhorros(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")
        gcPrestamos.DataSource = bl.GetSaldosPrestamos(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")

        ActivarControles(False)
    End Sub

    Private Sub pre_frmSolicitudPrestamo_Nuevo() Handles Me.Nuevo
        IdAsociado = teIdAsociado.EditValue

        gvPrestamos.AddNewRow()
        gvAhorros.AddNewRow()


        ActivarControles(True)
        entSolicitud = New coo_AplicarReintegros

        gcAhorros.DataSource = blAhorro.GetSaldosAhorros(-999, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")
        gcPrestamos.DataSource = bl.GetSaldosPrestamos(-999, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")

        teIdSolicitud.EditValue = 0 'objFunciones.ObtenerUltimoId("Coo_Solicitudes", "IdSolicitud") + 1
        teNumAsociado.EditValue = ""
        teIdAsociado.EditValue = 0
        teNombreAsociado.EditValue = ""
        deFecha.EditValue = Today
        deFechaPlanilla.EditValue = Today
        teSaldoAportaciones.EditValue = 0.0
        teAportacionAumenta.EditValue = 0.0
        teValorReintegro.EditValue = 0.0
        rgOpcion.SelectedIndex = 0
        leTipoPlanilla.EditValue = 1
        meConcepto.EditValue = ""

        teNumAsociado.Focus()
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Guardar() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then
            msj = bl.InsertaAplicacionReintegro(entSolicitud, entReintegroAhorros, entReintegroPrestamos, deFechaPlanilla.EditValue, leTipoPlanilla.EditValue)
            If msj = "" Then
                MsgBox("El reintegro ha sido guardado con éxito", MsgBoxStyle.Information)
                teIdSolicitud.EditValue = entSolicitud.IdSolicitud
            Else
                MsgBox(String.Format("No fue posible actualizar la Solicitud{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = bl.UpdateAplicacionReintegro(entSolicitud, entReintegroAhorros, entReintegroPrestamos)
            If msj = "" Then
                MsgBox("La Aplicación de Reintegro ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la solicitud de crédito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        IdAsociado = teIdAsociado.EditValue
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Consulta() Handles Me.Consulta
        frmConsultaAplicacionReintegros.ShowDialog()
        teIdSolicitud.EditValue = frmConsultaAplicacionReintegros.IdSolicitud
        CargaControles(0)

    End Sub
    Private Sub pre_frmSolicitudPrestamo_Editar() Handles Me.Editar
        If entSolicitud.Autorizado <> 0 Then
            MsgBox("El reintegro ya fue Aplicado a saldos del asociado, No es Posible Modicarla", MsgBoxStyle.Critical)
            Return
        End If
        ActivarControles(True)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Revertir() Handles Me.Revertir
        teIdAsociado.EditValue = IdAsociado
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub pre_frmSolicitudPrestamo_Reporte() Handles Me.Reporte
        Dim entSuc As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        Dim rpt As New AplicacionReintegro() With {.DataSource = bl.rptSolicitudCruce1(teIdSolicitud.EditValue), .DataMember = ""}
        rpt.xrlNombreEmpresaLargo.Text = dtParam.Rows(0).Item("NombreLargo")
        rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
        rpt.xrlDui.Text = entAso.NumeroDocumento
        rpt.xrlISSS.Text = entAso.IsssAfp
        rpt.xrlNumAsociado.Text = teNumAsociado.EditValue
        rpt.xrlPlanilla.Text = leTipoPlanilla.Text + " de Fecha " & Format(deFechaPlanilla.EditValue, "dd/MM/yyyy")
        rpt.xrlPlanilla.Text = rpt.xrlPlanilla.Text + ", por un valor de $ " & teValorReintegro.EditValue.ToString
        rpt.xrlPlanilla.Text = rpt.xrlPlanilla.Text + " de la Siguiente manera:"
        rpt.xrlAportacionDescontar.Text = Format(teAportacionAumenta.EditValue, "###,##0.00")
        rpt.xrlSaldoAportacion.Text = Format(teSaldoAportaciones.EditValue, "###,##0.00")
        rpt.xrlObservaciones.Text = meConcepto.EditValue
        rpt.xrlLugarFecha.Text = entSuc.Ciudad & "  " & FechaToString(deFecha.EditValue, deFecha.EditValue)
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")

        If rgOpcion.SelectedIndex = 0 Then
            rpt.xrlFormaReintegro.Text = "Abonar Deudas y Cuentas a Favor"
        Else
            rpt.xrlFormaReintegro.Text = "Generar Cheque por: $ " & Format(teValorReintegro.EditValue, "###,##0.00")
        End If

        rpt.XrSubreport1.ReportSource.DataSource = bl.rptAplicacionReintegro1(teIdSolicitud.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""

        rpt.XrSubreport2.ReportSource.DataSource = bl.rptAplicacionReintegro2(teIdSolicitud.EditValue)
        rpt.XrSubreport2.ReportSource.DataMember = ""

        rpt.ShowPreviewDialog()


    End Sub
    Private Sub pre_frmSolicitudPrestamo_Eliminar() Handles Me.Eliminar
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > deFecha.EditValue Then
            MsgBox("No es posible eliminar el Reintegro, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End If

        If entSolicitud.Autorizado <> 0 Then
            MsgBox("El reintegro ya fue Aplicado a saldos del asociado. No es posible Eliminarla", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de eliminar el reintegro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""


            Try
                objTablas.coo_AplicarReintegrosDeleteByPK(teIdSolicitud.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try

           
            If msj = "" Then
                MsgBox("El reintegro ha sido elminado con éxito", MsgBoxStyle.Information, "Nota")
                teIdSolicitud.EditValue -= 1
                ActualizaEstadoReintegro()
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar el reintegro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub
    Private Sub ActualizaEstadoReintegro()
        Dim msj As String = ""
        msj = bl.CambiaEstadoReintegro(teIdSolicitud.EditValue, teIdAsociado.EditValue, leTipoPlanilla.EditValue, deFechaPlanilla.EditValue)
    End Sub
    Function DatosValidos() As Boolean

        If teNumAsociado.EditValue = "" Then
            MsgBox(String.Format("No se ha especificado el número de asociado{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If

        If teValorReintegro.EditValue = 0.0 Then
            MsgBox(String.Format("No se ha especificado el valor del reintegro{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If

        gvAhorros.UpdateSummary()
        gvPrestamos.UpdateSummary()

        If rgOpcion.SelectedIndex = 0 Then
            If (Me.gcValorAhorro.SummaryItem.SummaryValue + teAportacionAumenta.EditValue + Me.gcValorAbona.SummaryItem.SummaryValue) <> teValorReintegro.EditValue Then
                MsgBox(String.Format("Los valores  no concuerdan con el valor del Reintegro {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                gcAhorros.Focus()
                Return False
            End If
        Else
            If (Me.gcValorAhorro.SummaryItem.SummaryValue + teAportacionAumenta.EditValue + Me.gcValorAbona.SummaryItem.SummaryValue) > 0 Then
                MsgBox(String.Format("El reintegro es en cheque, no puede abonar ninguna deuda o cuenta a favor {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                gcAhorros.Focus()
                Return False
            End If
        End If


        If SiEsNulo(deFecha.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("No se ha especificado la Fecha de Aplicación del Reintegro{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub CargaEntidades()
        With entSolicitud
            .IdSolicitud = teIdSolicitud.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .FechaSolicitud = deFecha.EditValue
            .SaldoAportacion = teSaldoAportaciones.EditValue
            .AportacionAumentar = teAportacionAumenta.EditValue
            .ValorReintegro = teValorReintegro.EditValue
            .TipoAplicacion = rgOpcion.SelectedIndex
            .IdPlanillaReintegro = leTipoPlanilla.EditValue
            .FechaPlanilla = deFechaPlanilla.EditValue
            .Observaciones = meConcepto.EditValue

            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
                .AutorizadoPor = ""
                .Autorizado = 0
                .FechaHoraAutorizacion = Nothing
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If

        End With

        entReintegroAhorros = New List(Of coo_AplicarReintegrosAhorros)
        For i = 0 To gvAhorros.DataRowCount - 1
            Dim entDetalle As New coo_AplicarReintegrosAhorros
            With entDetalle
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .Correlativo = i
                .IdCuenta = gvAhorros.GetRowCellValue(i, "IdCuenta")
                .Numero = gvAhorros.GetRowCellValue(i, "Numero")
                .SaldoActual = gvAhorros.GetRowCellValue(i, "SaldoActual")
                .Valor = gvAhorros.GetRowCellValue(i, "Valor")
            End With
            entReintegroAhorros.Add(entDetalle)
        Next

        entReintegroPrestamos = New List(Of coo_AplicarReintegrosPrestamos)
        For i = 0 To gvPrestamos.DataRowCount - 1
            Dim entDetalleA As New coo_AplicarReintegrosPrestamos
            With entDetalleA
                .IdSolicitud = 0  ' Se asigna en la capa de datos
                .Correlativo = i
                .IdPrestamo = gvPrestamos.GetRowCellValue(i, "IdPrestamo")
                .Numero = gvPrestamos.GetRowCellValue(i, "Numero")
                .IdLinea = gvPrestamos.GetRowCellValue(i, "IdLinea")
                .SaldoActual = gvPrestamos.GetRowCellValue(i, "SaldoActual")
                .ValorAbono = gvPrestamos.GetRowCellValue(i, "ValorAbono")
            End With
            entReintegroPrestamos.Add(entDetalleA)
        Next
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        If deFecha.Properties.ReadOnly = False Then
            frmConsultaAsociadosReintegros.ShowDialog()
            teIdAsociado.EditValue = frmConsultaAsociadosReintegros.IdAsociado
            teValorReintegro.EditValue = frmConsultaAsociadosReintegros.ValorReintegro
            leTipoPlanilla.EditValue = frmConsultaAsociadosReintegros.IdPlanillaDescuento
            deFechaPlanilla.EditValue = frmConsultaAsociadosReintegros.FechaPlanilla
            teNumAsociado_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated, teIdAsociado.Validated
        If teIdAsociado.EditValue = 0 Then
            Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
            If dt.Rows.Count = 0 Then
                Exit Sub
            End If
            teIdAsociado.EditValue = dt.Rows(0).Item("IdAsociado")
        End If

        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        teNumAsociado.EditValue = entAsociado.Numero
        teNombreAsociado.EditValue = entAsociado.Nombres + " " + entAsociado.Apellidos

        If DbMode = DbModeType.insert And teIdAsociado.EditValue > 0 Then
            gcAhorros.DataSource = blAhorro.GetSaldosAhorros(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, True, "Reintegro")
            gcPrestamos.DataSource = bl.GetSaldosPrestamos(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, True, "Reintegro")
            teSaldoAportaciones.EditValue = blAporta.GetSaldoAporta(teIdAsociado.EditValue)
        End If

    End Sub
    Private Sub CargaCombos()
        objCombos.coo_Lineas(leLinea, "")
        objCombos.adm_TiposPlanilla(leTipoPlanilla, "")
    End Sub
    Private Sub ActivarControles(ByVal Tipo As Boolean)
        teIdSolicitud.Properties.ReadOnly = True
        gvAhorros.OptionsBehavior.Editable = Tipo
        gvPrestamos.OptionsBehavior.Editable = Tipo


        teNumAsociado.Properties.ReadOnly = Not Tipo
        teValorReintegro.Properties.ReadOnly = Not Tipo
        deFechaPlanilla.Properties.ReadOnly = Not Tipo
        leTipoPlanilla.Properties.ReadOnly = Not Tipo

        deFecha.Properties.ReadOnly = Not Tipo
        sbAprobacion.Enabled = Not Tipo

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

    End Sub
    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdSolicitudStart As Integer = 0
        Dim IdSolicitudEnd As Integer = 0

        If TipoAvance = -1 Then
            IdSolicitudStart = objFunciones.ObtenerPrimerId("coo_AplicarReintegros", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudStart Then
                teIdSolicitud.EditValue += 1
            End If
        End If

        If TipoAvance = 1 Then
            IdSolicitudEnd = objFunciones.ObtenerUltimoId("coo_AplicarReintegros", "IdSolicitud")
            If teIdSolicitud.EditValue = IdSolicitudEnd Then
                teIdSolicitud.EditValue -= 1
            End If
        End If

        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If

        teIdSolicitud.EditValue = bl.ObtenerIdAplicarReintegro(teIdSolicitud.EditValue, TipoAvance)

        If teIdSolicitud.EditValue = 0 Then
            Exit Sub
        End If

        entSolicitud = objTablas.coo_AplicarReintegrosSelectByPK(teIdSolicitud.EditValue)
        With entSolicitud
            teIdSolicitud.EditValue = .IdSolicitud
            teIdAsociado.EditValue = .IdAsociado
            teNumAsociado_Validated(teIdAsociado, New EventArgs)
            deFecha.EditValue = .FechaSolicitud
            teSaldoAportaciones.EditValue = .SaldoAportacion
            teAportacionAumenta.EditValue = .AportacionAumentar
            teValorReintegro.EditValue = .ValorReintegro
            deFechaPlanilla.EditValue = .FechaPlanilla
            leTipoPlanilla.EditValue = .IdPlanillaReintegro
            rgOpcion.SelectedIndex = .TipoAplicacion
            meConcepto.EditValue = .Observaciones

            gcAhorros.DataSource = blAhorro.GetSaldosAhorros(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")
            gcPrestamos.DataSource = bl.GetSaldosPrestamos(teIdSolicitud.EditValue, teIdAsociado.EditValue, dFechaContable, False, "Reintegro")

        End With
    End Sub

    Private Sub sbAprobacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbAprobacion.Click

        If entSolicitud.Autorizado = 1 Then
            MsgBox("El reintegro ya fue aplicado. Imposible continuar", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim forma As New aso_frmAutoriza
        forma.tePass.EditValue = ""
        forma.ShowDialog()

        Dim ClaveAutoriza As String = forma.tePass.EditValue
        Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
        Dim inArray As Byte() = provider.ComputeHash(bytes)
        provider.Clear()

        Dim sPassWord As String = Convert.ToBase64String(inArray)
        Dim Respuesta As String = blAdmon.ValidarUsuario("GERENTE", sPassWord)

        If Respuesta <> "Ok" Then
            MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
            Exit Sub
        End If

        AplicaDescuentos()

    End Sub

    Private Sub AplicaDescuentos()
        Dim SaldoCorrectoAportacion As Boolean = True
        Dim SaldoCorrectoAhorro As Boolean = True
        Dim SaldoCorrectoPrestamos As Boolean = True

        'LLENO ENTIDAD DE APORTACIONES QUE SE DESCONTARAN
        Dim entAportacion As New coo_Aportaciones
        With entAportacion
            .IdAsociado = teIdAsociado.EditValue
            .IdMov = blAporta.GetUltMovAporta(teIdAsociado.EditValue) + 1
            .IdTipo = 1
            .NumeroDoc = "Rein-" & Format(dFechaContable, "ddMMyyyy")
            .Fecha = dFechaContable
            .IdFormaPago = 4
            .Cargo = 0.0
            .Abono = teAportacionAumenta.EditValue
            .Saldo = blAporta.GetSaldoAporta(teIdAsociado.EditValue) + teAportacionAumenta.EditValue
            .LineaLibreta = blAporta.GetUltLineaAporta(teIdAsociado.EditValue) + 1
            .Impreso = False
            .IdSucursal = gIdSucursal
            .FechaContable = dFechaContable
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now

            If .Saldo < 0.0 Then
                SaldoCorrectoAportacion = False
            End If

        End With

        'LLENO ENTIDAD DE AHORROS QUE SE DESCONTARAN
        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        Dim entCuentaAhorroMov As New List(Of coo_CuentasAhorroMov)
        For i = 0 To gvAhorros.DataRowCount - 1
            If gvAhorros.GetRowCellValue(i, "Valor") > 0.0 Then
                Dim entDetalle As New coo_CuentasAhorroMov
                With entDetalle
                    .IdCuenta = gvAhorros.GetRowCellValue(i, "IdCuenta")

                    EntUltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(gvAhorros.GetRowCellValue(i, "IdCuenta"))

                    .IdMov = EntUltMovAhorro.IdMov + 1
                    .NumeroDoc = "Rein-" & entAsociado.NumeroDocumento
                    .Fecha = dFechaContable
                    .IdTipo = 1
                    .Valor = gvAhorros.GetRowCellValue(i, "Valor")
                    .Saldo = CDec(EntUltMovAhorro.SaldoActual) + CDec(gvAhorros.GetRowCellValue(i, "Valor"))
                    .LineaLibreta = EntUltMovAhorro.Linea + 1
                    .IdFormaPago = 4
                    .FechaContable = dFechaContable
                    .IdSucursal = gIdSucursal
                    .Pignorado = False
                    .Observaciones = "APLICACION DE REINTEGRO"
                    .Impreso = False
                    .CreadoPor = objMenu.User
                    .FechaHoraCreacion = Now
                    .IdAutorizado = 0
                    .DocAutorizado = ""
                    If .Saldo < 0.0 Then
                        SaldoCorrectoAhorro = False
                    End If
                End With
                entCuentaAhorroMov.Add(entDetalle)
            End If
        Next

        'LLENO ENTIDAD DE PRESTAMOS QUE SE ABONARAN
        For i = 0 To gvPrestamos.DataRowCount - 1
            If gvPrestamos.GetRowCellValue(i, "ValorAbono") > 0.0 Then

                Dim entDetalle4 As New coo_PrestamosDetalle
                ActualizaPrestamo(gvPrestamos.GetRowCellValue(i, "ValorAbono"), gvPrestamos.GetRowCellValue(i, "IdPrestamo"))
                Dim dtTasa As DataTable = bl.ObtenerUltimasTasas(gvPrestamos.GetRowCellValue(i, "IdPrestamo"))

                With entDetalle4
                    .IdPrestamo = elpagodetalle.IdPrestamo
                    .IdMov = elpagodetalle.IdMov + 1
                    .Numero = "Rein-" & Format(dFechaContable, "ddMMyyyy")
                    .Fecha = dFechaContable
                    .TipoAplicacion = 1

                    .FechaContable = dFechaContable
                    .ImportePagado = gvPrestamos.GetRowCellValue(i, "ValorAbono")
                    .CapitalPagado = elpagodetalle.CapitalPagado
                    .SaldoCapital = bl.GetSaldoCapitalPrestamo(gvPrestamos.GetRowCellValue(i, "IdPrestamo")) - elpagodetalle.CapitalPagado
                    .DiasCalcInteres = 0
                    .DiasCalcMora = 0
                    .InteresPagado = elpagodetalle.InteresPagado
                    .InteresPendiente = 0.0
                    .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                    .InteresMoraPendiente = 0.0
                    .ValorSeguroPagado = 0.0
                    .ValorSeguroPendiente = 0.0
                    .ManejoPagado = 0.0
                    .ManejoPendiente = 0.0
                    .OtrosPagado = 0.0
                    .OtrosPendiente = 0.0
                    .CuotaAhorro = 0.0
                    .CuotaAportacion = 0.0
                    .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
                    .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
                    .IdFormaPago = 4
                    .IdSucursal = gIdSucursal
                    .CreadoPor = objMenu.User
                    .FechaHoraCreacion = Now
                    If .SaldoCapital < 0.0 Then
                        SaldoCorrectoPrestamos = False
                    End If
                End With
                entPrestamos.Add(entDetalle4)
            End If
        Next

        If SaldoCorrectoPrestamos = False Or SaldoCorrectoAhorro = False Or SaldoCorrectoAportacion = False Then
            MsgBox(String.Format("Los saldos de Aportacion, Ahorro ó Prestamos quedaran en negativo, Imposible Continuar"), MsgBoxStyle.Critical)
            Return
        End If

        Dim msj As String = ""
        msj = bl.AplicaReintegroCuentas(teIdSolicitud.EditValue, entAportacion, entCuentaAhorroMov, entPrestamos)
        If msj = "" Then
            MsgBox("La Aplicacion del Reintegro fue realizada con éxito", MsgBoxStyle.Information)
            Me.Close()
        Else
            MsgBox(String.Format("No fue posible realizar la aplicacion del reintegro {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If
    End Sub
    Private Sub ActualizaPrestamo(ByVal Abono As Decimal, ByVal IdPrestamo As Integer)
        blPrestamo = New Prestamo
        Dim entPrestamoCuota As coo_Prestamos
        entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(IdPrestamo)
        blPrestamo.FechaAmortizacion = deFecha.EditValue
        blPrestamo.CargaPrestamo(IdPrestamo)
        If blPrestamo.IdAsociado <> 0 Then
            With blPrestamo
                .FechaContable = dFechaContable
                .FechaAmortizacion = dFechaContable
                .DiasPorAnio = giDiasPorAnioPrestamo
                entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(blPrestamo.IdPrestamo)
                'Cuota base para el calculo de la mora
                .CalculaUltimoPago()
                .CalculaCuotaBaseMora()
                .CalculaCuotaDeberSer()
                'TODO cambiar nombre
                .ImporteAbonoPago = Abono


                .ComisionCobranza = 0.0
                .Gestion = 0.0
                .CuotaAportacion = 0.0
                .CuotaAhorro = 0.0
                .CuotaManejo = 0.0
                .NoInteres = False
                .CalculaAmortizacion()

                With elpagodetalle

                    If blPrestamo.PagoActual.FormaPago = 4 Then
                        .TipoAplicacion = 2
                    Else
                        .TipoAplicacion = 1
                    End If

                    .CapitalPagado = blPrestamo.PagoActual.ImporteCapital
                    .CreadoPor = blPrestamo.CodUsuario
                    .ComisionCobranza = blPrestamo.PagoActual.ImporteComisionCobranza
                    .Gestion = blPrestamo.PagoActual.ImporteGestion
                    .CuotaAhorro = blPrestamo.PagoActual.ImporteCuotaAhorro
                    .CuotaAportacion = blPrestamo.PagoActual.ImporteCuotaAportacion
                    .DiasCalcInteres = blPrestamo.PagoActual.DiasCalculoInteres
                    .DiasCalcMora = blPrestamo.PagoActual.DiasCalculoMora
                    .Fecha = blPrestamo.FechaAmortizacion
                    .FechaContable = blPrestamo.FechaContable
                    .FechaHoraCreacion = Now
                    .IdFormaPago = blPrestamo.PagoActual.FormaPago
                    .IdMov = blPrestamo.GetUltMovPrestamo(IdPrestamo) 'blPrestamo.Pagos.Count
                    .IdPrestamo = blPrestamo.IdPrestamo
                    .IdSucursal = blPrestamo.IdSucursal
                    .ImportePagado = blPrestamo.ImporteAbonoPago
                    .InteresMoraPagado = blPrestamo.PagoActual.ImporteMora
                    .InteresMoraPendiente = blPrestamo.PagoActual.ImporteDeudaMora
                    .TasaInteres = blPrestamo.TasaInteresAnual
                    .TasaInteresMora = blPrestamo.TasaInteresMora

                    If blPrestamo.TipoCuota = 1 Then
                        .InteresPagado = blPrestamo.PagoActual.ImporteInteres
                    Else
                        Dim dtSaldos As DataTable = blCaja.CalculaSaldoPres(blPrestamo.IdPrestamo, blPrestamo.IdAsociado, dFechaContable, True)
                        .InteresPagado = SiEsNulo(dtSaldos.Rows(0).Item("SaldoInteres"), 0.0)
                    End If

                    .InteresPendiente = blPrestamo.PagoActual.ImporteDeudaInteres
                    .ManejoPagado = blPrestamo.PagoActual.ImporteCuotaManejo
                    .ManejoPendiente = blPrestamo.PagoActual.ImporteDeudaManejo

                    'TODO asaber que es numero
                    .Numero = "P-" & Format(dFechaContable, "ddMMyyyy")
                    .ReferenciaPago = blPrestamo.PagoActual.ReferenciaPago

                    .OtrosPagado = blPrestamo.PagoActual.ImporteCuotaOtros
                    .OtrosPendiente = blPrestamo.PagoActual.ImporteDeudaOtros

                    .SaldoCapital = blPrestamo.PagoActual.ImporteSaldo
                    .ValorSeguroPagado = blPrestamo.PagoActual.ImporteCuotaSeguro
                    .ValorSeguroPendiente = blPrestamo.PagoActual.ImporteDeudaSeguro
                End With

            End With
        End If
    End Sub

End Class

