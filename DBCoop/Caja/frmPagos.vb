Imports DevExpress.XtraReports.UI
Imports System.Math
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports System.Diagnostics
Public Class frmPagos
    Dim blCaja As New CajaBusiness
    Dim myBL As New AdmonBLL
    Dim blPrestamo As Prestamo
    Dim elAportacion As coo_Aportaciones, elAhorro As coo_CuentasAhorroMov
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim dtParam As DataTable = myBL.ObtieneParametros()
    Dim MoraModificada As Boolean, SeguroModificado As Boolean

    Private Sub frmPagos_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        btIdPrestamo.Focus()
    End Sub

    Private Sub frmPagos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmPagos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.cooPtmoFmaPago(leFormaPago)
        deFechaContable.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deFechaPago.EditValue = deFechaPago.EditValue
        ReseteaControles()

    End Sub


    Private Sub btIdPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btIdPrestamo.ButtonClick

        frmConsultaPrestamos.ShowDialog()
        btIdPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        btIdPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub CargaPantalla()
        Dim entPrestamoCuota As coo_Prestamos = objTablas.coo_PrestamosSelectByPK(blPrestamo.IdPrestamo)
        With blPrestamo
            teNombre.EditValue = .Asociado
            teNumCtaAhorro.EditValue = .NumeroCtaAhorro
            _LineaLibretaAhorro.EditValue = .LineaLibretaAhorro + 1
            _LineaLibretaAporta.EditValue = .LineaLibretaAporta + 1
            _CapitalInicial.EditValue = .CapitalInicial
            _FechaOtorgamiento.EditValue = .FechaOtorgamiento
            .DiasPorAnio = giDiasPorAnioPrestamo
            .CalculaUltimoPago()
            _FechaUp.EditValue = .UltimoPago.Fecha
            teSaldoActual.EditValue = .UltimoPago.ImporteSaldo
            teValorCuota.EditValue = entPrestamoCuota.ValorCuota
        End With
    End Sub

    Private Sub teMontoAplicar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoAplicar.LostFocus
        ActualizaPrestamo()
    End Sub

    Private Sub cmdAplicarPago_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdAplicarPago.Click
        deFechaContable.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        If btIdPrestamo.EditValue = "" Or teIdPrestamo.EditValue = 0 Then
            MsgBox("Número de préstamo incorrecto o no especificado", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If teMontoAplicar.EditValue < teCuotaAportacion.EditValue Then
            MsgBox("Monto aplicar es incorrecto. Es menor a la aportación", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        Dim msj As String = "", IdMovCargo As Integer
        Dim entNotaCargo As New coo_PrestamosDetalle

        blPrestamo.FechaContable = deFechaPago.EditValue 'deFechaContable.EditValue

        If teNumeroDoc.Text = "" And leFormaPago.EditValue > 4 Then
            MsgBox("Debe de especificar el número de comprobante", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If deFechaPago.Text = "" Then
            MsgBox("Fecha de pago no puede quedar en blanco", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If deFechaPago.EditValue < _FechaUp.EditValue Then
            MsgBox("Fecha de pago incorrecta. Es menor a la fecha del último calculo", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If teMontoAplicar.EditValue = 0.0 Then
            MsgBox("Debe de especificar el monto a abonar", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        'cobro de seguro de prestámo
        If _ImporteCapital.EditValue > teSaldoActual.EditValue And leFormaPago.EditValue <> 5 Then
            MsgBox("El Monto a Abonar excede el Saldo de Capital", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If leFormaPago.EditValue = 5 Then 'es una nota de cargo
            IdMovCargo = blCaja.GetUltMovPrestamo(teIdPrestamo.EditValue)
            entNotaCargo = objTablas.coo_PrestamosDetalleSelectByPK(teIdPrestamo.EditValue, IdMovCargo)
            If entNotaCargo.Fecha <> deFechaPago.EditValue Then
                MsgBox("Fecha de la nota de cargo debe ser la misma fecha del Ultimo Pago", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        blPrestamo.CodUsuario = objMenu.User
        blPrestamo.IdSucursal = gIdSucursal
        Dim IdSuc As Integer = gIdSucursal
        If leFormaPago.EditValue > 4 Then  'la correlatividad se excluye cuando es NC y Red Activa
            IdSuc = -1
            'teNumeroDoc.EditValue = String.Format("{0}-{1}", glIdSucursal.ToString.PadLeft(2, "0"), (entSucursal.CorrelativoPago + 1).ToString.PadLeft(6, "0"))
        End If

        blPrestamo.PagoActual.NumeroComprobante = teNumeroDoc.EditValue
        blPrestamo.PagoActual.FormaPago = leFormaPago.EditValue
        blPrestamo.PagoActual.ReferenciaPago = teSerie.EditValue

        If teCuotaAhorro.EditValue <> 0 Then
            With elAhorro
                .IdCuenta = blPrestamo.IdCuentaAhorro
                .IdMov = blCaja.GetUltMovAhorro(.IdCuenta) + 1
                .NumeroDoc = "P/" & blPrestamo.PagoActual.NumeroComprobante
                .Fecha = deFechaPago.EditValue
                .IdTipo = 1
                .Valor = teCuotaAhorro.EditValue
                .Saldo = blCaja.GetSaldoAhorro(.IdCuenta) + teCuotaAhorro.EditValue
                .LineaLibreta = _LineaLibretaAhorro.EditValue
                .IdFormaPago = blPrestamo.PagoActual.FormaPago
                .FechaContable = deFechaPago.EditValue 'deFechaContable.EditValue
                .IdSucursal = gIdSucursal
                .Pignorado = False
                .Observaciones = "CUOTA DE AHORRO EN PAGO DE PRESTAMO " & blPrestamo.IdPrestamo
                .Impreso = False
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
        End If

        If teCuotaAportacion.EditValue <> 0 Then
            With elAportacion
                .IdAsociado = blPrestamo.IdAsociado
                .IdMov = blCaja.GetUltMovAporta(.IdAsociado) + 1
                .IdTipo = 2
                .NumeroDoc = "P/" & teNumeroDoc.EditValue
                .Fecha = deFechaPago.EditValue
                .IdFormaPago = blPrestamo.PagoActual.FormaPago
                .Cargo = 0
                .Abono = teCuotaAportacion.EditValue
                .Saldo = blCaja.GetSaldoAporta(.IdAsociado) + teCuotaAportacion.EditValue
                .LineaLibreta = _LineaLibretaAporta.EditValue
                .Impreso = False
                .IdSucursal = gIdSucursal
                .FechaContable = deFechaPago.EditValue 'deFechaContable.EditValue
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
        End If
        'If blCaja.ExisteComprobantePago(blPrestamo.PagoActual.NumeroComprobante) <> "" Then
        '    MsgBox("Numero de Comprobante ya existe", MsgBoxStyle.Critical, "Error de usuario")
        '    Exit Sub
        'End If

        If leFormaPago.EditValue = 5 Then 'NOTA DE CARGO
            blPrestamo.ImporteAbonoPago = 0 - teMontoAplicar.EditValue
            blPrestamo.PagoActual.ImporteMora = 0 - teSaldoInteresMora.EditValue
            blPrestamo.PagoActual.ImporteDeudaMora = blPrestamo.PagoActual.ImporteDeudaMora + teSaldoInteresMora.EditValue
            blPrestamo.PagoActual.ImporteCuotaSeguro = 0 - teImporteSeguro.EditValue
            blPrestamo.PagoActual.ImporteDeudaSeguro = blPrestamo.PagoActual.ImporteDeudaSeguro + teImporteSeguro.EditValue
            blPrestamo.PagoActual.ImporteCuotaManejo = 0 - _ImporteManejo.EditValue
            blPrestamo.PagoActual.ImporteDeudaManejo = blPrestamo.PagoActual.ImporteDeudaManejo + _ImporteManejo.EditValue
            blPrestamo.PagoActual.ImporteInteres = 0 - teSaldoInteres.EditValue
            blPrestamo.PagoActual.ImporteDeudaInteres = blPrestamo.PagoActual.ImporteDeudaInteres + teSaldoInteres.EditValue
            blPrestamo.PagoActual.ImporteCuotaOtros = 0 - _ImporteOtros.EditValue
            blPrestamo.PagoActual.ImporteDeudaOtros = blPrestamo.PagoActual.ImporteDeudaOtros + _ImporteOtros.EditValue
            blPrestamo.PagoActual.ImporteCapital = 0 - _ImporteCapital.EditValue
            blPrestamo.PagoActual.ImporteSaldo = blPrestamo.PagoActual.ImporteSaldo + _ImporteCapital.EditValue
        End If

        msj = blCaja.AplicarPago(blPrestamo, elAhorro, elAportacion, IdSuc)

        If msj = "" Then
            MsgBox("El pago ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible guardar el pago{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Exit Sub
        End If
        'MEJORAR ESTE CODIGO, MUCHAS LLAMADAS A LA BASE
        If leFormaPago.EditValue <> 5 Then 'para las notas de cargo no se emite ningún documento
            If MsgBox("¿Imprimir la factura de pago?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim entAsociado As New coo_Asociados
                Dim entLinea As New coo_Lineas, entFuente As New coo_Fuentes
                Dim entPrestamo As New coo_Prestamos, entDetalle As New coo_PrestamosDetalle
                Dim rpt As New pre_rptFacturaPago
                Dim IdMov As Integer

                IdMov = blCaja.GetUltMovPrestamo(blPrestamo.IdPrestamo)
                entPrestamo = objTablas.coo_PrestamosSelectByPK(blPrestamo.IdPrestamo)
                entAsociado = objTablas.coo_AsociadosSelectByPK(blPrestamo.IdAsociado)
                entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
                entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
                entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(blPrestamo.IdPrestamo, IdMov)

                Dim sDecimal = String.Format("{0:c}", Format(CDec(teMontoAplicar.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlTotalPagado.Text = Format(CDec(teMontoAplicar.EditValue), "##,##0.00")
                rpt.xrlFechaContable.Text = deFechaContable.EditValue
                rpt.xrlNombre.Text = teNombre.EditValue
                rpt.xrlNumeroAsociado.Text = entAsociado.Numero
                rpt.xrlDireccion.Text = entAsociado.Direccion
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlIdMov.Text = (entDetalle.IdMov - 1)
                rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
                rpt.xrlFechaOtorgado.Text = _FechaOtorgamiento.EditValue
                rpt.xrlLinea.Text = entLinea.Nombre
                rpt.xrlFuente.Text = entFuente.Nombre
                rpt.xrlNumeroPrestamo.Text = btIdPrestamo.EditValue
                If entPrestamo.IdTipoCartera = 3 Then
                    rpt.xrlTipoCartera.Text = "PRESTAMO SANEADO"
                Else
                    rpt.xrlTipoCartera.Text = ""
                End If
                rpt.xrlTasaInteres.Text = blPrestamo.TasaInteresAnual
                rpt.xrlNuevoSaldo.Text = Format(CDec(entDetalle.SaldoCapital), "##,##0.00")
                rpt.xrlCapitalPagado.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
                rpt.xrlSaldoCapital.Text = Format(CDec(entDetalle.SaldoCapital + entDetalle.CapitalPagado), "##,##0.00")
                rpt.xrlInteresPendiente.Text = entDetalle.InteresPendiente
                rpt.xrlFechaUltPago.Text = _FechaUp.EditValue
                rpt.xrlFechaVencimiento.Text = entPrestamo.FechaVencimiento
                rpt.xrlMontoOtorgado.Text = Format(CDec(entPrestamo.MontoAprobado), "##,##0.00")
                rpt.xrlComprobante.Text = entDetalle.Numero
                rpt.xrlCapital.Text = entDetalle.CapitalPagado
                rpt.xrlAportacion.Text = entDetalle.CuotaAportacion
                rpt.xrlAhorro.Text = entDetalle.CuotaAhorro
                rpt.xrlInteres.Text = entDetalle.InteresPagado
                rpt.xrlInteresMora.Text = entDetalle.InteresMoraPagado
                rpt.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
                rpt.xrlManejo.Text = entDetalle.ManejoPagado
                '  rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAportacion + entDetalle.CuotaAhorro + entDetalle.ValorSeguroPagado
                rpt.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
                rpt.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt.xrlTotalGravado.Text = entDetalle.ManejoPagado
                rpt.xrlValorCuota.Text = Format(CDec(entPrestamo.ValorCuota), "##,##0.00")
                rpt.xrlNumCuotas.Text = entPrestamo.NumCuotas
                rpt.PrinterName = gsImpresorDefault
                rpt.ShowPrintMarginsWarning = False
                rpt.xrlCantidadLetras.Text = Num2Text(Int(teMontoAplicar.EditValue)) & " " & sDecimal & " DÓLARES"
                While True
                    rpt.PrintDialog()
                    If MsgBox("¿Se imprimió correctamente la factura?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If
        If teCuotaAportacion.EditValue <> 0 Then
            If MsgBox("Actualizar Libreta de Aportaciones?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                ActualizaLibretaAportaPorCodigo(blPrestamo.IdAsociado, _LineaLibretaAporta.EditValue, entSucursal.LineasLibreta)
            End If
        End If
        If teCuotaAhorro.EditValue <> 0 Then
            If MsgBox("¿Actualizar Libreta de Ahorro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                ActualizaLibretaAhorroPorCodigo(blPrestamo.IdCuentaAhorro, _LineaLibretaAhorro.EditValue, entSucursal.LineasLibreta)
            End If
        End If
        ReseteaControles()
    End Sub

    Private Sub btIdPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btIdPrestamo.Validated

        If SiEsNulo(btIdPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim entPrestamo = blCaja.coo_PrestamosSelectByNumero(btIdPrestamo.EditValue)
        If entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If

        'MEJORAR ÉSTE CODIGO, DEMASIADAS LLAMADAS A LA BASE
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        Dim UltimoMovimiento As Integer = blCaja.GetUltMovPrestamo(entPrestamo.IdPrestamo)
        Dim MovSaldo As coo_PrestamosDetalle = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, UltimoMovimiento)
        If MovSaldo.SaldoCapital <= 0.0 Then
            MsgBox("El préstamo ya está cancelado. No es posible aplicar más pagos", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If
        'GroupBox1.Enabled = True
        btIdPrestamo.Enabled = False
        elAportacion = New coo_Aportaciones
        elAhorro = New coo_CuentasAhorroMov
        blPrestamo = New Prestamo()
        blPrestamo.FechaAmortizacion = deFechaPago.EditValue
        blPrestamo.CargaPrestamo(teIdPrestamo.EditValue)
        teSerie.EditValue = ""
        CargaPantalla()
        ActualizaPrestamo()
    End Sub

    Private Sub _FechaPago_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles deFechaPago.Validating
        If deFechaPago.EditValue < _FechaUp.EditValue Then
            MsgBox("Fecha de pago incorrecta", MsgBoxStyle.Critical)
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        ReseteaControles()

    End Sub

    Private Sub _ImporteCuotaAportacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teCuotaAportacion.LostFocus
        ActualizaPrestamo()
    End Sub

    Private Sub _ImporteCuotaAhorro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teCuotaAhorro.LostFocus
        ActualizaPrestamo()
    End Sub

    Private Sub _ImporteCuotaManejo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teCuotaManejo.LostFocus
        ActualizaPrestamo()
    End Sub



    Private Sub leFormaPago_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles leFormaPago.EditValueChanged
        Dim UltIdMov As Integer
        Dim entMovPago As New coo_PrestamosDetalle
        If leFormaPago.EditValue = 5 Then 'ES UNA NOTA DE CARGO
            UltIdMov = blCaja.GetUltMovPrestamo(teIdPrestamo.EditValue)
            If UltIdMov > 0 Then
                entMovPago = objTablas.coo_PrestamosDetalleSelectByPK(teIdPrestamo.EditValue, UltIdMov)
                _ImporteCapital.EditValue = entMovPago.CapitalPagado
                teSaldoInteres.EditValue = entMovPago.InteresPagado
                teSaldoInteresMora.EditValue = entMovPago.InteresMoraPagado
                teImporteSeguro.EditValue = entMovPago.ValorSeguroPagado
                _ImporteManejo.EditValue = entMovPago.ManejoPagado
                _ImporteOtros.EditValue = entMovPago.OtrosPagado
                teMontoAplicar.EditValue = entMovPago.CapitalPagado + entMovPago.InteresPagado + entMovPago.InteresMoraPagado + entMovPago.ValorSeguroPagado + entMovPago.ManejoPagado + entMovPago.OtrosPagado
                _ImporteCapital.Properties.ReadOnly = False
                teSaldoInteres.Properties.ReadOnly = False
                '_DeberSerMora.Properties.ReadOnly = False
                '_ImporteSeguro.Properties.ReadOnly = False
                _ImporteManejo.Properties.ReadOnly = False
                _ImporteOtros.Properties.ReadOnly = False
                _ImporteCapital.Enabled = True
                teSaldoInteres.Enabled = True
                '_DeberSerMora.Enabled = True
                '_ImporteSeguro.Enabled = True
                _ImporteManejo.Enabled = True
                _ImporteOtros.Enabled = True
            Else
                MsgBox("No es posible aplicarle notas de cargo. No ha tenido ningún pago", MsgBoxStyle.Information, "Nota")
            End If
        Else
            _ImporteCapital.EditValue = 0.0
            teSaldoInteres.EditValue = 0.0
            teSaldoInteresMora.EditValue = 0.0
            teImporteSeguro.EditValue = 0.0
            _ImporteManejo.EditValue = 0.0
            _ImporteOtros.EditValue = 0.0
            teMontoAplicar.EditValue = 0.0
            _ImporteCapital.Properties.ReadOnly = True
            teSaldoInteres.Properties.ReadOnly = True
            '_DeberSerMora.Properties.ReadOnly = True
            '_ImporteSeguro.Properties.ReadOnly = True
            _ImporteManejo.Properties.ReadOnly = True
            _ImporteOtros.Properties.ReadOnly = True
            _ImporteCapital.Enabled = False
            teSaldoInteres.Enabled = False
            '_DeberSerMora.Enabled = False
            '_ImporteSeguro.Enabled = False
            _ImporteManejo.Enabled = False
            _ImporteOtros.Enabled = False
        End If
        teNumeroDoc.Properties.ReadOnly = leFormaPago.EditValue < 5
    End Sub

    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub teDeberSerMora_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teSaldoInteresMora.LostFocus
        MoraModificada = True
        ActualizaPrestamo()
    End Sub

    Private Sub ActualizaPrestamo()
        Dim entPrestamoCuota As coo_Prestamos
        If blPrestamo.IdAsociado <> 0 Then
            With blPrestamo
                .FechaContable = blCaja.GetFechaContable(gIdSucursal)
                .FechaAmortizacion = deFechaPago.EditValue
                entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(blPrestamo.IdPrestamo)
                .FechaPrimerPago = entPrestamoCuota.FechaPrimerPago
                .CancelarEfectivo = True ' variable solo se ocupa para saber si el abono es de pres. efecitvo, que muestre el intres sobre el saldo de capital, sino solo sobre la cutoa

                Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entPrestamoCuota.IdLinea)
                If entLinea.CuotaSinCentavos Then
                    .CuotaSinCentavos = True
                End If

                'Cuota base para el calculo de la mora
                .CalculaCuotaBaseMora()
                .CalculaCuotaDeberSer()
                'TODO cambiar nombre
                teSaldoDeberSer.EditValue = .CuotaDeberSer.ImporteSaldo
                _CapitalMora.EditValue = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0.0)
                teValorCuota.EditValue = entPrestamoCuota.ValorCuota
                .ImporteAbonoPago = teMontoAplicar.EditValue
                'Cuota base para calculo de otros importes
                If leFormaPago.EditValue <> 5 Then
                    With .CuotaDeberSer
                        If teMontoAplicar.EditValue = 0.0 Then
                            If blPrestamo.CuotaAhorro > 0.0 Then
                                teCuotaAhorro.EditValue = blPrestamo.CuotaAhorro
                            End If
                            'If blPrestamo.CuotaAportacion > 0.0 Then
                            '    teCuotaAportacion.EditValue = blPrestamo.CuotaAportacion
                            'End If
                            teCuotaManejo.EditValue = .ImporteCuotaManejo
                        End If
                        teImporteSeguro.EditValue = .ImporteCuotaSeguro
                        _ImporteManejo.EditValue = .ImporteCuotaManejo
                        _ImporteOtros.EditValue = .ImporteCuotaOtros
                    End With
                End If

                '-- Estado de cuenta
                teDiasInteres.EditValue = DateDiff(DateInterval.Day, .UltimoPago.Fecha, .FechaAmortizacion)
                teDiasMora.EditValue = blCaja.GetDiasMora(blPrestamo.IdPrestamo, deFechaPago.EditValue)

                Dim DiasCalculoInteres As Integer = teDiasInteres.EditValue
                Dim DiasCalculoMora As Integer = teDiasMora.EditValue
                'Cuando arrastro el saldo de interes en mora pendiente, tomo los dias de calculo de mora desde el ultimo pago realizado

                If .UltimoPago.ImporteDeudaMora > 0.0 Or .UltimoPago.ImporteMora > 0 Then
                    DiasCalculoMora = DiasCalculoInteres
                End If
                DiasCalculoMora = Min(DiasCalculoMora, blCaja.GetDiasMora(blPrestamo.IdPrestamo, deFechaPago.EditValue))

                'Si va adelantado en el pago la mora el calculo de mora es 0
                Dim ImporteSaldoCalculoMora As Decimal = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0)
                Dim ImporteSaldoCalculoInteres As Decimal = .UltimoPago.ImporteSaldo

                'Calcula las tasas diarias
                Dim TasaInteres As Decimal = .TasaInteresAnual / 100 * DiasCalculoInteres / giDiasPorAnioPrestamo
                Dim TasaMora As Decimal = .TasaInteresMora / 100 * DiasCalculoMora / giDiasPorAnioPrestamo

                If leFormaPago.EditValue <> 5 Then  'diferente de Nota de cargo

                    If entPrestamoCuota.TipoCuota = 1 Then
                        teSaldoInteres.EditValue = .UltimoPago.ImporteDeudaInteres + Round(ImporteSaldoCalculoInteres * TasaInteres, 2)
                    Else
                        Dim dtSaldos As DataTable = blCaja.CalculaSaldoPres(teIdPrestamo.EditValue, blPrestamo.IdAsociado, deFechaPago.EditValue, True)
                        teSaldoInteres.EditValue = dtSaldos.Rows(0).Item("SaldoInteres")
                    End If


                    If Not MoraModificada Then
                        teSaldoInteresMora.EditValue = .UltimoPago.ImporteDeudaMora + Round(ImporteSaldoCalculoMora * TasaMora, 2)
                    End If

                    .ComisionCobranza = teComision.EditValue
                    .Gestion = teGestion.EditValue
                    .CuotaAportacion = teCuotaAportacion.EditValue
                    .CuotaAhorro = teCuotaAhorro.EditValue
                    .CuotaManejo = teCuotaManejo.EditValue
                    '.SeguroManual = 
                    .MoraManual = teSaldoInteresMora.EditValue
                    .MoraModificada = MoraModificada
                    .SeguroModificado = SeguroModificado
                    .NoInteres = chkInteres.EditValue
                    .CalculaAmortizacion()
                    With .PagoActual
                        'If entPrestamoCuota.TipoCuota = 2 Then
                        '    If chkInteres.EditValue = 1 Then
                        '        teSaldoInteres.EditValue = .ImporteInteres
                        '    Else
                        '        teSaldoInteres.EditValue = 0.0
                        '    End If
                        'End If
                        teImporteSeguro.EditValue = .ImporteCuotaSeguro
                        _ImporteCapital.EditValue = .ImporteCapital
                        _ImporteInteres.EditValue = .ImporteInteres
                        _ImporteMora.EditValue = .ImporteMora
                        _TotalCancelar.EditValue = teSaldoActual.EditValue + teImporteSeguro.EditValue + teSaldoInteres.EditValue + teSaldoInteresMora.EditValue + blPrestamo.CuotaAportacion + blPrestamo.CuotaManejo + blPrestamo.CuotaAhorro
                        teTotalPagar.EditValue = _CapitalMora.EditValue + teImporteSeguro.EditValue + teSaldoInteres.EditValue + teSaldoInteresMora.EditValue + blPrestamo.CuotaManejo + blPrestamo.CuotaAhorro + blPrestamo.CuotaAportacion
                        teDiasInteres.EditValue = .DiasCalculoInteres

                    End With
                Else
                    .CalculaAmortizacionNotaCargo()
                End If
            End With
        End If
    End Sub

    Private Sub teImporteSeguro_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles teImporteSeguro.LostFocus
        SeguroModificado = True
        ActualizaPrestamo()
    End Sub
    Private Sub ReseteaControles()
        teMontoAplicar.EditValue = 0.0
        teCuotaAportacion.EditValue = 0.0
        teCuotaAhorro.EditValue = 0.0
        teCuotaManejo.EditValue = 0.0
        leFormaPago.ItemIndex = 0
        deFechaPago.EditValue = deFechaContable.EditValue
        teSerie.EditValue = ""
        teNombre.EditValue = ""
        teNumCtaAhorro.EditValue = ""
        teSaldoDeberSer.EditValue = 0.0
        _CapitalMora.EditValue = 0.0
        teValorCuota.EditValue = 0.0
        teDiasInteres.EditValue = 0.0
        teDiasMora.EditValue = 0.0
        teTotalPagar.EditValue = 0.0
        teSaldoActual.EditValue = 0.0
        _ImporteCapital.EditValue = 0.0
        teSaldoInteresMora.EditValue = 0.0
        _TotalCancelar.EditValue = 0.0
        btIdPrestamo.Enabled = True
        btIdPrestamo.Text = ""
        MoraModificada = False
        chkInteres.EditValue = False
        btIdPrestamo.Focus()
    End Sub

    'Private Sub chkInteres_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInteres.LostFocus
    '    ActualizaPrestamo()
    'End Sub
End Class