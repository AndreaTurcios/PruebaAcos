Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math

Public Class pre_frmCambioTasaInteres
    Dim entCambioTasa As New List(Of coo_PrestamosDetalle)
    Dim bl As New PrestamosBLL()
    Dim blEntidad As New TableBusiness()
    Dim fun As New FuncionesBLL()
    ReadOnly blCaja As New CajaBusiness()
    Dim blPres As New Prestamo


    Private Sub pre_frmCambioTasaInteres_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFecha.EditValue = Today
        rdoTipoTasa.EditValue = 0
        rdoTipoCambio.EditValue = 0
        beNoPrestamo.Focus()
        objCombos.coo_LineasEfectivo(cboLinea, "", "--TODAS LAS LINEAS DE CREDITO--")
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
        Dim NumeroPrestamo As String
        If beNoPrestamo.EditValue = "" Then
            NumeroPrestamo = Nothing
        Else
            NumeroPrestamo = beNoPrestamo.EditValue
        End If
        entPrestamo = bl.coo_PrestamosSelectByNumero(NumeroPrestamo)
        entAsociados = blEntidad.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teAsociado.EditValue = entAsociados.Nombres & " " & entAsociados.Apellidos
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        Dim IdMovimiento As Integer
        Dim TipoTasa As Integer
        If Not DatosValidos() Then
            Exit Sub
        End If
        If rdoTipoTasa.EditValue = 0 Then
            TipoTasa = 3
        Else
            TipoTasa = 4
        End If

        Dim dtSaldos As DataTable = bl.rptDetalleGeneralCartera(-1, cboLinea.EditValue, -1, -1, -1 _
        , deFecha.EditValue, False)

        If rdoTipoCambio.EditValue = 0 Then
            For i = 0 To dtSaldos.Rows.Count - 1
                If beNoPrestamo.EditValue = "" Then
                    CargaEntidades(dtSaldos.Rows(i).Item("NumeroPrestamo"))
                Else
                    If dtSaldos.Rows(i).Item("NumeroPrestamo") = beNoPrestamo.EditValue Then
                        CargaEntidades(dtSaldos.Rows(i).Item("NumeroPrestamo"))
                    End If
                End If

            Next

            Dim msj As String = ""
            msj = bl.InsertaCambioTasa(entCambioTasa)

            If msj = "" Then
                MsgBox("El Cambio de Tasa ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible Guardar el Cambio de Tasa" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        Else

            For i = 0 To dtSaldos.Rows.Count - 1
                Dim entPrestamo As New coo_Prestamos
                entPrestamo = bl.coo_PrestamosSelectByNumero(dtSaldos.Rows(i).Item("NumeroPrestamo"))
                IdMovimiento = bl.ExisteCambioTasa(entPrestamo.IdPrestamo, deFecha.EditValue, TipoTasa)
                objTablas.coo_PrestamosDetalleDeleteByPK(entPrestamo.IdPrestamo, IdMovimiento)
            Next

            MsgBox("El Cambio de Tasa fue eliminado con Exito", MsgBoxStyle.Information)
        End If
    End Sub

    Function DatosValidos() As Boolean

        Dim dFechaContable As New Date
        Dim TipoTasa As Integer
        Dim UltMovPrestamo As Integer
        Dim IdMovimiento As Integer = 0
        Dim IdMov As Integer
        Dim entPrestamo As coo_Prestamos
        entPrestamo = bl.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
        UltMovPrestamo = bl.GetUltMovPrestamo(entPrestamo.IdPrestamo)

        Dim dtSaldos As DataTable = bl.rptDetalleGeneralCartera(-1, cboLinea.EditValue, -1, -1, -1 _
        , deFecha.EditValue, False)

        If rdoTipoTasa.EditValue = 0 Then
            TipoTasa = 3
        Else
            TipoTasa = 4
        End If

        'If beNoPrestamo.EditValue = "" Then
        '    MsgBox("Debes especificar El Número de Préstamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    beNoPrestamo.Focus()
        '    Return False
        'End If

        If SiEsNulo(deFecha.EditValue, Nothing) = Nothing Then
            MsgBox("Debe especificar la Fecha del Cambio de Tasa" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFecha.Focus()
            Return False
        End If

        dFechaContable = fun.GetFechaContable(gIdSucursal)
        If dFechaContable > deFecha.EditValue Then
            MsgBox("El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Return False
        End If

        If rdoTipoCambio.EditValue = 0 Then
            If seTasa.EditValue < 0 Then
                MsgBox("La nueva Tasa debe ser Positiva" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                seTasa.Focus()
                Return False
            End If

            IdMov = bl.ExisteCambioTasa(entPrestamo.IdPrestamo, deFecha.EditValue, TipoTasa)
            If IdMov > 0 Then
                MsgBox("Ya existe un Cambio de Tasa en esta Fecha" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                seTasa.Focus()
                Return False
            End If
        Else

            For i = 0 To dtSaldos.Rows.Count - 1
                If IdMovimiento = 0 Then
                    IdMovimiento = bl.ExisteCambioTasa(dtSaldos.Rows(i).Item("IdPrestamo"), deFecha.EditValue, TipoTasa)
                End If
            Next

            If IdMovimiento = 0 Then
                MsgBox("No Existe Cambio de Tasa en esta Fecha" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Eliminar")
                seTasa.Focus()
                Return False
            End If

            For i = 0 To dtSaldos.Rows.Count - 1
                IdMovimiento = bl.ExisteCambioTasa(dtSaldos.Rows(i).Item("IdPrestamo"), deFecha.EditValue, TipoTasa)
                bl.GetUltMovPrestamo(dtSaldos.Rows(i).Item("IdPrestamo"))
                If IdMovimiento < UltMovPrestamo Then
                    MsgBox("No Es Posible eliminar el Cambio de Tasa, Existen movimientos despues del Cambio de Tasa" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Eliminar")
                    seTasa.Focus()
                    Return False
                End If
            Next


        End If

        Return True
    End Function

    Private Sub CargaEntidades(ByVal NumeroPrestamo_ As String)

        Dim entPrestamo As New coo_Prestamos
        Dim entAsociado As New coo_Asociados
        Dim TipoTasa As Integer
        Dim PrefijoTasa As String

        If rdoTipoTasa.EditValue = 0 Then
            TipoTasa = 3
            PrefijoTasa = "CT-"
        Else
            TipoTasa = 4
            PrefijoTasa = "CM-"
        End If

        entPrestamo = bl.coo_PrestamosSelectByNumero(NumeroPrestamo_)
        entAsociado = blEntidad.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
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
            Dim TasaInteres As Decimal = .TasaInteresAnual / 100 * DiasCalculoInteres / giDiasPorAnioPrestamo
            Dim TasaMora As Decimal = .TasaInteresMora / 100 * DiasCalculoMora / giDiasPorAnioPrestamo

            SaldoCapital = ImporteSaldoCalculoInteres

            DebeSerInteres = .UltimoPago.ImporteDeudaInteres + Round(ImporteSaldoCalculoInteres * TasaInteres, 2)
            DebeSerMora = .UltimoPago.ImporteDeudaMora + Round(ImporteSaldoCalculoMora * TasaMora, 2)

        End With

        Dim detalle As New coo_PrestamosDetalle
        With detalle
            .IdPrestamo = entPrestamo.IdPrestamo
            .IdMov = -1
            .TipoAplicacion = TipoTasa
            .Numero = PrefijoTasa & entAsociado.Numero & (Year(deFecha.EditValue)).ToString.PadLeft(4, "0")
            .Fecha = deFecha.EditValue
            .FechaContable = deFecha.EditValue
            .ImportePagado = seTasa.EditValue
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

            If rdoTipoTasa.EditValue = 1 Then
                .TasaInteres = seTasa.EditValue
                .TasaInteresMora = 0.0
            Else
                .TasaInteres = 0.0
                .TasaInteresMora = seTasa.EditValue
            End If

            .IdFormaPago = 1
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With
        entCambioTasa.Add(detalle)
    End Sub

    Private Sub beNoPrestamo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beNoPrestamo.EditValueChanged

    End Sub

    Private Sub deFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deFecha.EditValueChanged

    End Sub
End Class
