Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports System.IO
Imports System.Math
'Imports CajaBL
Public Class pre_frmTrasladoPrestamos
    Dim entPres As New coo_Prestamos
    Dim entDesembolso As New coo_PrestamosDetalle
    Dim entCambioTasa As New coo_PrestamosDetalle
    Dim entCambioTasaMora As New coo_PrestamosDetalle
    Dim entTraslado As New coo_PrestamosTraslado
    Dim entNuevoTraslado As New coo_PrestamosTraslado
    Dim entPlanPago As New List(Of coo_PrestamosPlanPagos)
    Dim entPrestamo As New coo_Prestamos
    Dim bl As New DBCoopBL.PrestamosBLL()
    Dim blEntidad As New DBCoopBL.TableBusiness()
    Dim fun As New DBCoopBL.FuncionesBLL()
    Dim blCaja As New CajaBusiness()
    Dim blPres As Prestamo

    Private Sub pre_frmTrasladoPrestamos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFecha.EditValue = Today
        deFechaPrimer.EditValue = Today
        rdoTipoCambio.EditValue = 0
        beNoPrestamo.Focus()
        objCombos.coo_TiposCartera(leTipoCartera, "")
    End Sub


    Private Sub beNoPrestamo_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles beNoPrestamo.MouseClick
        frmConsultaPrestamos.ShowDialog()
        beNoPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        'teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado

        beNoPrestamo_Validated(e, New EventArgs)

    End Sub

    Private Sub beNoPrestamo_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNoPrestamo.Validated
        Dim entAsociados As New coo_Asociados
        Dim entPrestamo As New coo_Prestamos
        Dim entPrestamoSaldo As New coo_SaldoPrestamo
        Dim NumeroPrestamo As String
        If beNoPrestamo.EditValue = "" Then
            NumeroPrestamo = Nothing
        Else
            NumeroPrestamo = beNoPrestamo.EditValue
        End If
        entPrestamo = bl.coo_PrestamosSelectByNumero(NumeroPrestamo)
        entPrestamoSaldo = bl.coo_SaldosPrestamo(entPrestamo.IdPrestamo, deFecha.EditValue)
        entAsociados = blEntidad.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teAsociado.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)
        teSaldoCapital.EditValue = entPrestamoSaldo.SaldoCapital
        teSaldoInteres.EditValue = entPrestamoSaldo.SaldoInteres
        teMoratorio.EditValue = entPrestamoSaldo.SaldoInteresMora
        seTasaInteres.EditValue = entPrestamoSaldo.TasaInteres
        seTasaMora.EditValue = entPrestamoSaldo.TasaMora
    End Sub

    Private Sub deFecha_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles deFecha.Validated
        beNoPrestamo_Validated(e, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGuardar.Click
        Dim IdMovInteres As Integer, IdMovMora As Integer, IdTraslado As Integer
        Dim entAsociados As New coo_Asociados
        If Not DatosValidos() Then
            Exit Sub
        End If
        If rdoTipoCambio.EditValue = 0 Then
            CargaEntidades()
            entAsociados = blEntidad.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
            Dim msj As String = ""
            If leTipoCartera.EditValue = 1 Then
                msj = bl.InsertaTrasladoPrestamo(entTraslado)
            End If
            If leTipoCartera.EditValue = 2 Then
                msj = bl.InsertaTrasladoPrestamo(entTraslado, entCambioTasa, entCambioTasaMora, leTipoCartera.EditValue)
            End If
            If leTipoCartera.EditValue = 3 Then
                If chkNuevo.EditValue = False Then
                    msj = bl.InsertaTrasladoPrestamo(entTraslado, entCambioTasa, entCambioTasaMora, leTipoCartera.EditValue)
                Else
                    msj = bl.InsertaTrasladoPrestamo(entTraslado, entCambioTasa, entCambioTasaMora, entPres, entDesembolso, entPlanPago, entAsociados.IdMunicipio, entNuevoTraslado)
                End If
            End If

            If msj = "" Then
                MsgBox("El Traslado ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible Guardar el Traslado de Préstamo{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            Dim msj As String = ""
            Dim entPrestamo As coo_Prestamos
            entPrestamo = bl.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
            IdMovInteres = bl.ExisteCambioTasa(entPrestamo.IdPrestamo, deFecha.EditValue, 3)
            IdMovMora = bl.ExisteCambioTasa(entPrestamo.IdPrestamo, deFecha.EditValue, 4)
            IdTraslado = bl.ExisteTrasladoPrestamo(entPrestamo.IdPrestamo, deFecha.EditValue)
            msj = bl.EliminaTrasladoPrestamo(entPrestamo.IdPrestamo, IdMovInteres, IdMovMora, IdTraslado)
            If msj = "" Then
                MsgBox("La eliminacion fue realizada con exito. El Préstamo Saneado debe ser borrado manualmente", MsgBoxStyle.Information, "Nota")
            Else
                MsgBox(String.Format("No fue posible eliminar el traslado del préstamo{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If

        End If
    End Sub

    Function DatosValidos() As Boolean
        Dim dFechaContable As New Date
        Dim UltMovPrestamo As Integer
        Dim IdMovimiento As Integer
        Dim IdTraslado As Integer
        Dim entTraslado As coo_PrestamosTraslado
        Dim entPrestamo As coo_Prestamos = bl.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
        UltMovPrestamo = bl.GetUltMovPrestamo(entPrestamo.IdPrestamo)

        If beNoPrestamo.EditValue = "" Then
            MsgBox("Debes especificar El Número de Préstamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNoPrestamo.Focus()
            Return False
        End If
        If SiEsNulo(deFecha.EditValue, Nothing) = Nothing Then
            MsgBox("Debes especificar la Fecha del Traslado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If
        dFechaContable = fun.GetFechaContable(gIdSucursal)
        'If dFechaContable > deFecha.EditValue Then
        '    MsgBox("El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
        '    Return False
        'End If
        If rdoTipoCambio.EditValue = 0 Then
            If teSaldoCapital.EditValue <= 0 Then
                MsgBox("El saldo de Capital debe ser mayor a cero" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                teSaldoCapital.Focus()
                Return False
            End If
            IdTraslado = bl.ExisteTrasladoPrestamo(entPrestamo.IdPrestamo, deFecha.EditValue)
            If IdTraslado > 0 Then
                MsgBox("Ya existe un Traslado de Préstamo en esta Fecha" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                seTasaInteres.Focus()
                Return False
            End If
        Else
            IdTraslado = bl.ExisteTrasladoPrestamo(entPrestamo.IdPrestamo, deFecha.EditValue)
            If IdTraslado = 0 Then
                MsgBox("No Existe Traslado en esta Fecha" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Eliminar")
                seTasaInteres.Focus()
                Return False
            End If
            entTraslado = blEntidad.coo_PrestamosTrasladoSelectByPK(entPrestamo.IdPrestamo, IdTraslado)
            If entTraslado.TipoTraslado > 1 Then
                IdMovimiento = bl.ExisteCambioTasa(entPrestamo.IdPrestamo, deFecha.EditValue, 3)
                If IdMovimiento < UltMovPrestamo Then
                    MsgBox("No Es Posible eliminar el Traslado, Existen movimientos despues del Cambio de Traslado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Eliminar")
                    seTasaInteres.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        Dim entAsociado As New coo_Asociados
        Dim entMunicipios As New adm_Municipios
        Dim PrefijoTasaInteres As String
        Dim PrefijoTasaMora As String
        blPres = New Prestamo()

        PrefijoTasaInteres = "CT-"
        PrefijoTasaMora = "CM-"
        entPrestamo = bl.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
        entAsociado = blEntidad.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        entMunicipios = blEntidad.adm_MunicipiosSelectByPK(entAsociado.IdMunicipio)
        blPres.FechaAmortizacion = deFecha.EditValue
        blPres.CargaPrestamo(entPrestamo.IdPrestamo)

        Dim SaldoCapital As Decimal
        Dim SaldoDebeSer As Decimal
        Dim CapitalMora As Decimal
        Dim ValorCuota As Decimal
        Dim CuotaAhorro As Decimal
        Dim CuotaAportacion As Decimal
        Dim CuotaSeguro As Decimal
        Dim CuotaManejo As Decimal
        Dim CuotaOtros As Decimal
        Dim DiasCalculoInteres As Integer
        Dim DiasCalculoMora As Integer
        Dim DebeSerInteres As Decimal
        Dim DebeSerMora As Decimal

        With blPres
            .FechaContable = deFecha.EditValue
            .FechaAmortizacion = deFecha.EditValue
            'Cuota base para el calculo de la mora
            .CalculaUltimoPago()
            .CalculaCuotaBaseMora()
            .CalculaCuotaDeberSer()
            'TODO cambiar nombre
            SaldoDebeSer = .CuotaDeberSer.ImporteSaldo
            CapitalMora = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0.0)

            ValorCuota = .CuotaBaseMora.ImporteCuota
            .ImporteAbonoPago = Val(ValorCuota)
            'Cuota base para calculo de otros importes

            With .CuotaDeberSer
                CuotaAhorro = .ImporteCuotaAhorro
                CuotaAportacion = .ImporteCuotaAportacion
                CuotaSeguro = .ImporteCuotaSeguro
                CuotaManejo = .ImporteCuotaManejo
                CuotaOtros = .ImporteCuotaOtros
            End With

            '-- Estado de cuenta
            DiasCalculoInteres = DateDiff(DateInterval.Day, .UltimoPago.Fecha, .FechaAmortizacion)
            DiasCalculoMora = blCaja.GetDiasMora(entPrestamo.IdPrestamo, deFecha.EditValue)

            ''Cuando arrastro saldo de interes en mora pendiente, tomo los dias de calculo de mora desde el ultimo pago realizado
            If .UltimoPago.ImporteDeudaMora > 0.0 Then
                DiasCalculoMora = DiasCalculoInteres
            End If

            'Si va adelantado en el pago la mora el calculo de mora es 0
            Dim ImporteSaldoCalculoMora As Decimal = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0)
            Dim ImporteSaldoCalculoInteres As Decimal = .UltimoPago.ImporteSaldo

            'Calcula las tasas diarias
            Dim TasaInteres As Decimal = Decimal.Round(.TasaInteresAnual / 100 * DiasCalculoInteres / giDiasPorAnioPrestamo, 2)
            Dim TasaMora As Decimal = Decimal.Round(.TasaInteresMora / 100 * DiasCalculoMora / giDiasPorAnioPrestamo, 2)

            SaldoCapital = ImporteSaldoCalculoInteres

            DebeSerInteres = .UltimoPago.ImporteDeudaInteres + Round(ImporteSaldoCalculoInteres * TasaInteres, 2)
            DebeSerMora = .UltimoPago.ImporteDeudaMora + Round(ImporteSaldoCalculoMora * TasaMora, 2)

        End With

        With entCambioTasaMora
            .IdPrestamo = entPrestamo.IdPrestamo
            .IdMov = -1
            .TipoAplicacion = 4
            .Numero = PrefijoTasaMora & entAsociado.Numero & (Year(deFecha.EditValue)).ToString.PadLeft(4, "0")
            .Fecha = deFecha.EditValue
            .FechaContable = deFecha.EditValue
            .ImportePagado = seTasaMora.EditValue
            .CapitalPagado = 0.0
            .SaldoCapital = SaldoCapital
            .DiasCalcInteres = DiasCalculoInteres
            .DiasCalcMora = DiasCalculoMora
            .InteresPagado = 0.0
            .InteresPendiente = DebeSerInteres
            .InteresMoraPagado = 0.0
            .InteresMoraPendiente = DebeSerMora
            .ValorSeguroPagado = 0.0
            .ValorSeguroPendiente = CuotaSeguro
            .ManejoPagado = 0.0
            .ManejoPendiente = CuotaManejo
            .OtrosPagado = 0.0
            .OtrosPendiente = CuotaOtros
            .CuotaAhorro = 0.0
            .CuotaAportacion = 0.0
            .TasaInteres = 0.0
            .TasaInteresMora = 0.0
            .IdFormaPago = 1
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With

        With entCambioTasa
            .IdPrestamo = entPrestamo.IdPrestamo
            .IdMov = -1
            .TipoAplicacion = 3
            .Numero = PrefijoTasaInteres & entAsociado.Numero & (Year(deFecha.EditValue)).ToString.PadLeft(4, "0")
            .Fecha = deFecha.EditValue
            .FechaContable = deFecha.EditValue
            .ImportePagado = seTasaInteres.EditValue
            .CapitalPagado = 0.0
            .SaldoCapital = SaldoCapital
            .DiasCalcInteres = DiasCalculoInteres
            .DiasCalcMora = DiasCalculoMora
            .InteresPagado = 0.0
            .InteresPendiente = DebeSerInteres
            .InteresMoraPagado = 0.0
            .InteresMoraPendiente = DebeSerMora
            .ValorSeguroPagado = 0.0
            .ValorSeguroPendiente = CuotaSeguro
            .ManejoPagado = 0.0
            .ManejoPendiente = CuotaManejo
            .OtrosPagado = 0.0
            .OtrosPendiente = CuotaOtros
            .CuotaAhorro = 0.0
            .CuotaAportacion = 0.0
            .TasaInteres = 0.0
            .TasaInteresMora = 0.0
            .IdFormaPago = 1
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            If leTipoCartera.EditValue = 3 Then
                .CapitalPagado = SaldoCapital
                .SaldoCapital = 0.0
                .InteresPagado = DebeSerInteres
                .InteresPendiente = 0.0
                .InteresMoraPagado = DebeSerMora
                .InteresMoraPendiente = 0.0
                .ValorSeguroPagado = CuotaSeguro
                .ValorSeguroPendiente = 0.0
                .ManejoPagado = CuotaManejo
                .ManejoPendiente = 0.0
                .OtrosPagado = CuotaOtros
                .OtrosPendiente = 0.0
            End If
        End With

        With entTraslado
            .IdPrestamo = entPrestamo.IdPrestamo
            .TipoTraslado = leTipoCartera.EditValue
            .Fecha = deFecha.EditValue
            .SaldoPrestamo = teSaldoCapital.EditValue
            .SaldoInteres = teSaldoInteres.EditValue
            .SaldoInteresMoratorio = teMoratorio.EditValue
            .TasaInteresTraslado = seTasaInteres.EditValue
            .TasaMoraTraslado = seTasaMora.EditValue
            .CostasProcesales = teCostas.EditValue
        End With

        If chkNuevo.EditValue = True And leTipoCartera.EditValue = 3 Then
            With entNuevoTraslado
                .IdPrestamo = -1
                .TipoTraslado = leTipoCartera.EditValue
                .Fecha = deFecha.EditValue
                .SaldoPrestamo = teSaldoCapital.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros
                .SaldoInteres = teSaldoInteres.EditValue
                .SaldoInteresMoratorio = teMoratorio.EditValue
                .TasaInteresTraslado = seTasaInteres.EditValue
                .TasaMoraTraslado = seTasaMora.EditValue
                .CostasProcesales = teCostas.EditValue
            End With


            With entPres
                .IdSolicitud = entPrestamo.IdSolicitud
                .IdAsociado = entPrestamo.IdAsociado
                .Numero = gIdSucursal.ToString.PadLeft(2, "0") & "-" & entAsociado.IdMunicipio & "-" & (entMunicipios.Correlativo + 1).ToString.PadLeft(4, "0")
                .MontoAprobado = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
                .FechaAprobado = deFecha.EditValue
                .FechaOtorgado = deFecha.EditValue
                .FechaPrimerPago = deFechaPrimer.EditValue
                .MontoDesembolsado = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
                .MesesGracia = 0
                .DiasMoraGracia = 3
                .IdFormaPago = entPrestamo.IdFormaPago
                .FrecuenciaPago = entPrestamo.FrecuenciaPago
                .NumCuotas = 1
                .TasaInteres = seTasaInteres.EditValue
                .TasaMora = seTasaMora.EditValue
                .ValorCuota = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
                .CuotaAportacion = entPrestamo.CuotaAportacion
                .CuotaAhorro = entPrestamo.CuotaAhorro
                .CuotaManejo = entPrestamo.CuotaManejo
                .CuotaOtros = entPrestamo.CuotaOtros
                .TasaSeguro = entPrestamo.TasaSeguro
                .FechaVencimiento = deFecha.EditValue
                .IdTecnico = entPrestamo.IdTecnico
                .IdLinea = entPrestamo.IdLinea
                .IdFuente = entPrestamo.IdFuente
                .IdTipoCartera = 3
                .IdSucursal = gIdSucursal
                .IdTipoPrestamo = entPrestamo.IdTipoPrestamo
                .IdEstado = 1
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = objMenu.User
                .FechaHoraModificacion = Now
            End With

            ''Aqui lleno la entidad de Plan de pagos

            Dim entDetalle As New coo_PrestamosPlanPagos
            entDetalle.NumCuota = 1
            entDetalle.Fecha = deFecha.EditValue
            entDetalle.Valor = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
            entDetalle.TasaInteres = seTasaInteres.EditValue
            entDetalle.TasaMora = seTasaMora.EditValue
            entDetalle.Interes = 0.0
            entDetalle.Capital = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
            entDetalle.Saldo = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
            entDetalle.CuotaAportacion = 0.0
            entDetalle.CuotaAhorro = 0.0
            entDetalle.CuotaManejo = 0.0
            entDetalle.CuotaOtros = 0.0
            entDetalle.TasaSeguro = 0.0
            entDetalle.CuotaSeguro = 0.0
            entPlanPago.Add(entDetalle)

            With entDesembolso
                .IdPrestamo = 0
                .Numero = entPres.Numero
                .Fecha = deFecha.EditValue
                .TipoAplicacion = 0
                .FechaContable = Today
                .ImportePagado = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
                .CapitalPagado = 0.0
                .SaldoCapital = teSaldoCapital.EditValue + teSaldoInteres.EditValue + teMoratorio.EditValue + CuotaSeguro + CuotaManejo + CuotaOtros + teCostas.EditValue
                .DiasCalcInteres = 0
                .DiasCalcMora = 0
                .InteresPagado = 0.0
                .InteresPendiente = 0.0
                .InteresMoraPagado = 0.0
                .InteresMoraPendiente = 0.0
                .ValorSeguroPagado = 0.0
                .ValorSeguroPendiente = 0.0
                .ManejoPagado = 0.0
                .ManejoPendiente = 0.0
                .OtrosPagado = 0.0
                .OtrosPendiente = 0.0
                .CuotaAhorro = 0.0
                .CuotaAportacion = 0.0
                .TasaInteres = 0.0
                .TasaInteresMora = 0.0
                .IdFormaPago = 1
                .IdSucursal = gIdSucursal
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
        End If
    End Sub

End Class
