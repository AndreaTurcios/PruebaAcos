Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL
Imports System.Diagnostics
Public Class apo_frmLiquidacionAsociados
    Dim blAsoc As New AsociadosBLL()
    Dim blPres As New PrestamosBLL()
    Dim blAhorro As New AhorrosBLL
    Dim blAporta As New AportacionesBLL()
    Dim blCaja As New CajaBusiness()
    Dim blPrestamo As New Prestamo
    Dim cn As New AdmonBLL()
    Dim elpagodetalle As New coo_PrestamosDetalle
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    Dim entPrestamos2 As New List(Of coo_PrestamosDetalle)
    Dim entAportaciones As New List(Of coo_Aportaciones)
    Dim entAhorrosMov As New List(Of coo_CuentasAhorroMov)
    Dim EntUltMovAhorro As coo_UltMovAhorro
    Dim TotalLiquidar As Decimal = 0.0
    Dim entCuentas As con_Cuentas


    Private Sub apo_frmLiquidacionAsociados_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaControles()
    End Sub

    Private Sub CargaControles()
        teIdAsociado.EditValue = 0
        teNumAsociado.EditValue = ""
        deFechaEntrega.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        teNombreAsociado.EditValue = ""
        beCta01.EditValue = ""
        teCta01.EditValue = ""
    End Sub

    Private Sub CalcularTotales()
        gvRefinancia.UpdateTotalSummary()
        gvAhorros.UpdateTotalSummary()
        teSaldoDeudas.EditValue = Me.gcCapital.SummaryItem.SummaryValue + Me.gcInteres.SummaryItem.SummaryValue _
        + Me.gcMoratorio.SummaryItem.SummaryValue + Me.gcSeguro.SummaryItem.SummaryValue _
        + Me.gcOtros.SummaryItem.SummaryValue
        teSaldoAhorros.EditValue = Me.gcValorCol.SummaryItem.SummaryValue
        teLiquido.EditValue = (teSaldoAhorros.EditValue + teSaldoAportaciones.EditValue) - teSaldoDeudas.EditValue

    End Sub

    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        beCta01.EditValue = ""
        beCta01_Validated(beCta01, New System.EventArgs)
    End Sub
    Private Sub beCta01_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub
    Private Sub teNumAsociado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            teIdAsociado.EditValue = 0
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim HaySolicitudCrucePendiente As Integer = blPres.ObtenerSolCrucePendiente(teIdAsociado.EditValue)

        If HaySolicitudCrucePendiente > 0 Then
            MsgBox("El asociado tiene solicitudes de cruce pendientes de autorizar", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With

        Dim EntAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        If EntAsociado.IdEstado <> 1 Then
            MsgBox("El asociado no se encuentra activo", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With EntAsociado
            _FechaIngCliente.EditValue = .FechaIngreso
        End With

        teSaldoAportaciones.EditValue = blAporta.GetSaldoAporta(teIdAsociado.EditValue)
        teAportacionesLiquida.EditValue = teSaldoAportaciones.EditValue
        gcAhorros.DataSource = blAhorro.GetSaldosAhorros(-999, teIdAsociado.EditValue, deFechaEntrega.EditValue, True, "")
        gvAhorros.UpdateTotalSummary()

        TotalLiquidar = teAportacionesLiquida.EditValue + Me.gcValorCol.SummaryItem.SummaryValue
        gcRefinancia.DataSource = blPres.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaEntrega.EditValue, -1, TotalLiquidar, 0)

        CalcularTotales()

        If teLiquido.EditValue > 0.0 Then
            beCta01.Enabled = False
            teCta01.Enabled = False
        Else
            beCta01.Enabled = True
            teCta01.Enabled = True
        End If
    End Sub
    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click

        If teIdAsociado.EditValue = 0 Then
            MsgBox("Debe seleccionar un asociado a retirar", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        Dim EntAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        If entAsociado.IdEstado <> 1 Then
            MsgBox("El asociado no se encuentra activo", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim SaldoFiador As Decimal = 0.0
        Dim entAso As coo_Asociados
        entAso = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        SaldoFiador = blPres.GetSaldoAsociadoFiador(entAso.NumeroDocumento, deFechaEntrega.EditValue)

        If SaldoFiador > 0.0 Then
            MsgBox("El Asociado posee Saldo Pendiente como Fiador", MsgBoxStyle.Exclamation, "Nota")

            Dim forma As New aso_frmAutoriza
            forma.tePass.EditValue = ""
            forma.ShowDialog()

            Dim ClaveAutoriza As String = forma.tePass.EditValue
            Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
            Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
            Dim inArray As Byte() = provider.ComputeHash(bytes)
            provider.Clear()

            Dim sPassWord As String = Convert.ToBase64String(inArray)
            Dim Respuesta As String = cn.ValidarUsuario("GERENTE", sPassWord)

            If Respuesta <> "Ok" Then
                MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If

        If MsgBox("Está seguro(a) de aplicar el retiro total?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If

        If teLiquido.EditValue < 0 Then
            If beCta01.EditValue = "" Then
                If MsgBox("Está seguro(a) de dejar la cuenta contable por cobrar en blanco?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            Else
                If MsgBox("Está seguro(a) de llevar a una cuenta por cobrar el saldo pte. del socio(a)?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If


        'LLENO ENTIDAD DE AHORROS QUE SE DESCONTARAN
        Dim EntregarSocio As Decimal = 0.0
        Dim TotalLiquidar As Decimal = teSaldoDeudas.EditValue
        Dim DescAhorro As Decimal = teSaldoDeudas.EditValue
        Dim Sobrante As Decimal = 0.0, nSaldo As Decimal = 0.0
        Dim entCuentaAhorroMov As New List(Of coo_CuentasAhorroMov)

        For i = 0 To gvAhorros.DataRowCount - 1
            If gvAhorros.GetRowCellValue(i, "SaldoActual") > 0.0 Then
                Dim entDetalleAh As New coo_CuentasAhorroMov

                If TotalLiquidar >= gvAhorros.GetRowCellValue(i, "SaldoActual") Then
                    DescAhorro = gvAhorros.GetRowCellValue(i, "SaldoActual")
                Else
                    DescAhorro = TotalLiquidar
                    Sobrante = gvAhorros.GetRowCellValue(i, "SaldoActual") - TotalLiquidar
                End If

                With entDetalleAh
                    .IdCuenta = gvAhorros.GetRowCellValue(i, "IdCuenta")

                    EntUltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(gvAhorros.GetRowCellValue(i, "IdCuenta"))

                    .IdMov = EntUltMovAhorro.IdMov + 1
                    .NumeroDoc = "RT-" & teIdSolicitud.EditValue.ToString '  Year(deFechaEntrega.EditValue).ToString & entAsociado.NumeroDocumento
                    .Fecha = deFechaEntrega.EditValue
                    .IdTipo = 2
                    .Valor = DescAhorro
                    .Saldo = CDec(EntUltMovAhorro.SaldoActual) - DescAhorro
                    .LineaLibreta = EntUltMovAhorro.Linea + 1
                    .IdFormaPago = 8 ' ESPECIAL ACELCA CRUCE DE CUENTAS
                    .FechaContable = deFechaEntrega.EditValue
                    .IdSucursal = gIdSucursal
                    .Pignorado = False
                    .Observaciones = "RETIRO DE ASOCIADOS"
                    .Impreso = False
                    .CreadoPor = objMenu.User
                    .FechaHoraCreacion = Now
                    .IdAutorizado = 0
                    .DocAutorizado = ""
                End With
                entCuentaAhorroMov.Add(entDetalleAh)
                TotalLiquidar = TotalLiquidar - DescAhorro
                nSaldo = entDetalleAh.Saldo

                If Sobrante > 0 Then
                    Dim entDetalleAh2 As New coo_CuentasAhorroMov
                    With entDetalleAh2
                        .IdCuenta = gvAhorros.GetRowCellValue(i, "IdCuenta")

                        EntUltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(gvAhorros.GetRowCellValue(i, "IdCuenta"))

                        .IdMov = EntUltMovAhorro.IdMov + 2
                        .NumeroDoc = "RS-" & teIdSolicitud.EditValue.ToString 'Year(deFechaEntrega.EditValue).ToString & entAsociado.NumeroDocumento
                        .Fecha = deFechaEntrega.EditValue
                        .IdTipo = 2
                        .Valor = Sobrante
                        .Saldo = nSaldo - Sobrante
                        .LineaLibreta = EntUltMovAhorro.Linea + 2
                        .IdFormaPago = 2
                        .FechaContable = deFechaEntrega.EditValue
                        .IdSucursal = gIdSucursal
                        .Pignorado = False
                        .Observaciones = "RETIRO DE ASOCIADOS, SALDO A FAVOR"
                        .Impreso = False
                        .CreadoPor = objMenu.User
                        .FechaHoraCreacion = Now
                        .IdAutorizado = 0
                        .DocAutorizado = ""
                    End With
                    entCuentaAhorroMov.Add(entDetalleAh2)
                    EntregarSocio = EntregarSocio + Sobrante
                End If
            End If
        Next

        'LLENO ENTIDAD DE APORTACIONES QUE SE DESCONTARAN
        Dim nDesAporPrestamos As Decimal = 0.0
        Sobrante = 0.0
        nSaldo = 0.0

        If TotalLiquidar >= teSaldoAportaciones.EditValue Then
            nDesAporPrestamos = teSaldoAportaciones.EditValue
        Else
            nDesAporPrestamos = TotalLiquidar
            Sobrante = teSaldoAportaciones.EditValue - nDesAporPrestamos
        End If

        entAportaciones = New List(Of coo_Aportaciones)
        If nDesAporPrestamos > 0.0 Then
            Dim entDetalle As New coo_Aportaciones
            With entDetalle
                .IdAsociado = teIdAsociado.EditValue
                .IdMov = blAporta.GetUltMovAporta(teIdAsociado.EditValue) + 1
                .IdTipo = 4 ' codigo especial para cruces
                .NumeroDoc = "RT-" & teIdSolicitud.EditValue.ToString 'Year(deFechaEntrega.EditValue).ToString & EntAsociado.NumeroDocumento
                .Fecha = deFechaEntrega.EditValue
                .IdFormaPago = 8
                .Cargo = nDesAporPrestamos
                .Abono = 0.0
                .Saldo = blAporta.GetSaldoAporta(teIdAsociado.EditValue) - nDesAporPrestamos
                .LineaLibreta = blAporta.GetUltLineaAporta(teIdAsociado.EditValue) + 1
                .Impreso = False
                .IdSucursal = gIdSucursal
                .FechaContable = deFechaEntrega.EditValue
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                nSaldo = blAporta.GetSaldoAporta(teIdAsociado.EditValue) - nDesAporPrestamos
            End With
            entAportaciones.Add(entDetalle)

        End If

        If Sobrante > 0.0 Then
            Dim entDetalle2 As New coo_Aportaciones
            With entDetalle2
                .IdAsociado = teIdAsociado.EditValue
                .IdMov = blAporta.GetUltMovAporta(teIdAsociado.EditValue) + 2
                .IdTipo = 4 ' codigo especial para cruces
                .NumeroDoc = "RS-" & teIdSolicitud.EditValue.ToString 'Year(deFechaEntrega.EditValue).ToString & EntAsociado.NumeroDocumento
                .Fecha = deFechaEntrega.EditValue
                .IdFormaPago = 2
                .Cargo = Sobrante
                .Abono = 0.0
                .Saldo = nSaldo - Sobrante
                .LineaLibreta = blAporta.GetUltLineaAporta(teIdAsociado.EditValue) + 2
                .Impreso = False
                .IdSucursal = gIdSucursal
                .FechaContable = deFechaEntrega.EditValue
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
            entAportaciones.Add(entDetalle2)
            EntregarSocio = EntregarSocio + Sobrante
        End If


        'LLENO ENTIDAD DE PRESTAMOS QUE SE ABONARAN
        For i = 0 To gvRefinancia.DataRowCount - 1
            If beCta01.EditValue <> "" Then
                gcRefinancia.DataSource = blPres.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaEntrega.EditValue, -1, teSaldoDeudas.EditValue, 0)
            End If
            If gvRefinancia.GetRowCellValue(i, "TotalAbonar") > 0.0 Then

                Dim entDetalle4 As New coo_PrestamosDetalle
                ActualizaPrestamo(gvRefinancia.GetRowCellValue(i, "TotalAbonar"), gvRefinancia.GetRowCellValue(i, "IdPrestamo"))
                Dim dtTasa As DataTable = blPres.ObtenerUltimasTasas(gvRefinancia.GetRowCellValue(i, "IdPrestamo"))

                With entDetalle4
                    .IdPrestamo = elpagodetalle.IdPrestamo
                    .IdMov = elpagodetalle.IdMov + 1
                    .Numero = "RS-" & teIdSolicitud.EditValue.ToString 'Year(deFechaEntrega.EditValue).ToString & EntAsociado.NumeroDocumento
                    .Fecha = deFechaEntrega.EditValue
                    .TipoAplicacion = 1

                    .FechaContable = deFechaEntrega.EditValue
                    .ImportePagado = gvRefinancia.GetRowCellValue(i, "TotalAbonar")
                    .CapitalPagado = elpagodetalle.CapitalPagado
                    .SaldoCapital = blPres.GetSaldoCapitalPrestamo(gvRefinancia.GetRowCellValue(i, "IdPrestamo")) - elpagodetalle.CapitalPagado
                    .DiasCalcInteres = elpagodetalle.DiasCalcInteres
                    .DiasCalcMora = elpagodetalle.DiasCalcMora
                    .InteresPagado = elpagodetalle.InteresPagado
                    .InteresPendiente = elpagodetalle.InteresPendiente
                    .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                    .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
                    .ValorSeguroPagado = elpagodetalle.ValorSeguroPagado
                    .ValorSeguroPendiente = 0.0
                    .ManejoPagado = 0.0
                    .ManejoPendiente = 0.0
                    .OtrosPagado = 0.0
                    .OtrosPendiente = 0.0
                    .CuotaAhorro = 0.0
                    .CuotaAportacion = 0.0
                    .TasaInteres = elpagodetalle.TasaInteres   'dtTasa.Rows(0).Item("TasaInteres")
                    .TasaInteresMora = elpagodetalle.TasaInteresMora  'dtTasa.Rows(0).Item("TasaInteresMora")
                    .IdFormaPago = 8
                    .IdSucursal = gIdSucursal
                    .CreadoPor = objMenu.User
                    .FechaHoraCreacion = Now
                End With
                entPrestamos.Add(entDetalle4)
            End If
        Next

        Dim msj As String = ""
        msj = blPres.AplicaRetiroSocios(entAportaciones, entCuentaAhorroMov, entPrestamos _
        , teLiquido.EditValue, teIdAsociado.EditValue, deFechaEntrega.EditValue, beCta01.EditValue, teIdSolicitud.EditValue)

        ''SI LE COLOCARON CUENTA POR COBRAR ESO LO LLEVO A UNA CUENTA POR COBRAR,
        ''PARA LA EMPRESA QUE PAGA PLANILLA
        'If beCta01.EditValue <> "" Then
        '    gcRefinancia.DataSource = blPres.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaEntrega.EditValue, -1, (teLiquido.EditValue * -1), 0)

        '    For i = 0 To gvRefinancia.DataRowCount - 1
        '        If gvRefinancia.GetRowCellValue(i, "TotalAbonar") > 0.0 Then

        '            Dim entDetalle4 As New coo_PrestamosDetalle
        '            ActualizaPrestamo(gvRefinancia.GetRowCellValue(i, "TotalAbonar"), gvRefinancia.GetRowCellValue(i, "IdPrestamo"))
        '            Dim dtTasa As DataTable = blPres.ObtenerUltimasTasas(gvRefinancia.GetRowCellValue(i, "IdPrestamo"))

        '            With entDetalle4
        '                .IdPrestamo = elpagodetalle.IdPrestamo
        '                .IdMov = elpagodetalle.IdMov + 1
        '                .Numero = "RTD" & teIdSolicitud.EditValue.ToString
        '                .Fecha = deFechaEntrega.EditValue
        '                .TipoAplicacion = 1

        '                .FechaContable = deFechaEntrega.EditValue
        '                .ImportePagado = gvRefinancia.GetRowCellValue(i, "TotalAbonar")
        '                .CapitalPagado = elpagodetalle.CapitalPagado
        '                .SaldoCapital = blPres.GetSaldoCapitalPrestamo(gvRefinancia.GetRowCellValue(i, "IdPrestamo")) - elpagodetalle.CapitalPagado
        '                .DiasCalcInteres = elpagodetalle.DiasCalcInteres
        '                .DiasCalcMora = elpagodetalle.DiasCalcMora
        '                .InteresPagado = elpagodetalle.InteresPagado
        '                .InteresPendiente = elpagodetalle.InteresPendiente
        '                .InteresMoraPagado = elpagodetalle.InteresMoraPagado
        '                .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
        '                .ValorSeguroPagado = 0.0
        '                .ValorSeguroPendiente = 0.0
        '                .ManejoPagado = 0.0
        '                .ManejoPendiente = 0.0
        '                .OtrosPagado = 0.0
        '                .OtrosPendiente = 0.0
        '                .CuotaAhorro = 0.0
        '                .CuotaAportacion = 0.0
        '                .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
        '                .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
        '                .IdFormaPago = 8
        '                .IdSucursal = gIdSucursal
        '                .CreadoPor = objMenu.User
        '                .FechaHoraCreacion = Now
        '            End With
        '            entPrestamos2.Add(entDetalle4)
        '        End If
        '    Next

        '    'INSERTO EL PAGO DEL PRESTAMO PARA LIQUIDARLO TOTALMENTE Y ACTIAR UNA CXC EN LA CONTA
        '    Dim msj2 As String = ""
        '    msj2 = blPres.AplicaRetiroSocios2(entPrestamos2, beCta01.EditValue, teIdSolicitud.EditValue)
        '    If msj2 <> "" Then
        '        MsgBox(String.Format("No fue posible realizar el retiro de socio {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
        '        Return
        '    End If
        'End If


        If msj = "" Then
            MsgBox("Retiro de Socio fue realizado con éxito", MsgBoxStyle.Information)
            blAporta.RecalculaSaldoAportacion(teIdAsociado.EditValue) ' recalculo el saldo de las aportaciones

            Dim myRpt As New apo_rptLiquidacionAsociado
            Dim sDecimal = String.Format("{0:c}", EntregarSocio)
            Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

            myRpt.DataSource = gcRefinancia.DataSource
            myRpt.DataMember = ""
            myRpt.xrlNumero.Text = entAsociados.Numero
            myRpt.xrlNombres.Text = entAsociados.Nombres + " " + entAsociados.Apellidos
            myRpt.xrlDireccion.Text = entAsociados.Direccion
            myRpt.xrlTelefonos.Text = entAsociados.Telefonos
            myRpt.xrlFecha.Text = Format(deFechaEntrega.EditValue, "dd/MM/yyyy")
            myRpt.xrlLugarFecha.Text = cn.ObtieneParametros.Rows(0).Item("Municipio") + ", " + FechaToString(Today, Today)
            myRpt.xrlSaldoAhorros.Text = teSaldoAhorros.EditValue
            myRpt.xrlSaldoAportaciones.Text = teSaldoAportaciones.EditValue
            myRpt.xrlSaldoDeudas.Text = teSaldoDeudas.EditValue
            myRpt.xrlLiquidez.Text = teLiquido.EditValue
            myRpt.xrlCuentaPorCobrar.Text = 0.0

            If beCta01.EditValue <> "" And teLiquido.EditValue < 0 Then
                myRpt.xrlCuentaPorCobrar.Text = Format(teLiquido.EditValue * -1, "##,##0.00")
            End If

            gvAhorros.UpdateTotalSummary()
            myRpt.XrSubreport1.ReportSource.DataSource = gcAhorros.DataSource
            myRpt.XrSubreport1.ReportSource.DataMember = ""

            myRpt.XrSubreport2.ReportSource.DataSource = gcRefinancia.DataSource 'blPres.GetSaldoPrestamoAsociado(teIdAsociado.EditValue, deFechaEntrega.EditValue, -1, TotalLiquidar)
            myRpt.XrSubreport2.ReportSource.DataMember = ""

            myRpt.xrlEntregar.Text = Format(EntregarSocio, "##,##0.00")
            myRpt.xrlCantidadLetras.Text = Num2Text(Int(EntregarSocio)) & " " & sDecimal & " DÓLARES"
            myRpt.xrlEmpresa.Text = gsNombre_Empresa
            myRpt.ShowPreviewDialog()

            Me.Close()
        Else
            MsgBox(String.Format("No fue posible realizar el retiro de socio {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If


        Close()
    End Sub

    Private Sub ActualizaPrestamo(ByVal Abono As Decimal, ByVal IdPrestamo As Integer)
        blPrestamo = New Prestamo
        Dim entPrestamoCuota As coo_Prestamos
        entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(IdPrestamo)
        blPrestamo.FechaAmortizacion = deFechaEntrega.EditValue
        blPrestamo.CargaPrestamo(IdPrestamo)
        If blPrestamo.IdAsociado <> 0 Then
            With blPrestamo
                .FechaContable = deFechaEntrega.EditValue
                .FechaAmortizacion = deFechaEntrega.EditValue
                .FechaPrimerPago = entPrestamoCuota.FechaPrimerPago
                Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entPrestamoCuota.IdLinea)
                If entLinea.CuotaSinCentavos Then
                    .CuotaSinCentavos = True
                End If

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

                elpagodetalle = New coo_PrestamosDetalle
                Dim elpagodetalle1 As New coo_PrestamosDetalle
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
                        Dim dtSaldos As DataTable = blCaja.CalculaSaldoPres(blPrestamo.IdPrestamo, blPrestamo.IdAsociado, deFechaEntrega.EditValue, True)
                        .InteresPagado = SiEsNulo(dtSaldos.Rows(0).Item("SaldoInteres"), 0.0)
                    End If

                    .InteresPendiente = blPrestamo.PagoActual.ImporteDeudaInteres
                    .ManejoPagado = blPrestamo.PagoActual.ImporteCuotaManejo
                    .ManejoPendiente = blPrestamo.PagoActual.ImporteDeudaManejo

                    'TODO asaber que es numero
                    .Numero = "P-" & Format(deFechaEntrega.EditValue, "ddMMyyyy")
                    .ReferenciaPago = blPrestamo.PagoActual.ReferenciaPago

                    .OtrosPagado = blPrestamo.PagoActual.ImporteCuotaOtros
                    .OtrosPendiente = blPrestamo.PagoActual.ImporteDeudaOtros

                    .SaldoCapital = blPrestamo.PagoActual.ImporteSaldo
                    .ValorSeguroPagado = blPrestamo.PagoActual.ImporteCuotaSeguro
                    .ValorSeguroPendiente = blPrestamo.PagoActual.ImporteDeudaSeguro
                End With
                ' elpagodetalle.Add(elpagodetalle1)
            End With
        End If
    End Sub
  


    Private Sub teNumSolicitud_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumSolicitud.ButtonClick
 
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        Dim Idsol As String = objConsultas.ConsultaSolicitudRetiroAprobadas(frmConsultas, dFechaContable, True)
        If Idsol = "" Then
            Exit Sub
        End If
        teIdSolicitud.EditValue = Idsol

        Dim entSol As coo_SolicitudRetiro = objTablas.coo_SolicitudRetiroSelectByPK(teIdSolicitud.EditValue)
        teNumSolicitud.EditValue = entSol.NumeroSolicitud
        teIdSolicitud.EditValue = entSol.IdSolicitud
        teIdAsociado.EditValue = entSol.IdAsociado
        deFechaEntrega.EditValue = entSol.FechaRetiro
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entSol.IdAsociado)
        teNumAsociado.EditValue = entAso.Numero
        teNumAsociado_Validated(e, New EventArgs)

    End Sub

    Private Sub teNumSolicitud_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumSolicitud.EditValueChanged

    End Sub
End Class