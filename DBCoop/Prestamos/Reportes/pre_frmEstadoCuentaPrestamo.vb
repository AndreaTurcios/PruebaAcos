Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
'Imports CajaBL
Public Class pre_frmEstadoCuentaPrestamo
    ReadOnly blPrestamo As New PrestamosBLL()
    Dim blCaja As New TableBusiness()
    Dim bl As New CajaBusiness()
    Dim blPres As New Prestamo

    Private Sub pre_frmEstadoCuentaPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deHasta.EditValue = Today
    End Sub

    Private Sub pre_frmEstadoCuentaPrestamo_Reporte() Handles Me.Reporte

        Dim entPrestamo As New coo_Prestamos
        blPres = New Prestamo()
        entPrestamo = blPrestamo.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
        blPres.FechaAmortizacion = deHasta.EditValue
        blPres.CargaPrestamo(entPrestamo.IdPrestamo)
        Dim SaldoDebeSer As Decimal, CapitalMora As Decimal, ValorCuota As Decimal, CuotaAhorro As Decimal, CuotaAportacion As Decimal
        Dim CuotaSeguro As Decimal, CuotaManejo As Decimal, CuotaOtros As Decimal, DiasCalculoInteres As Integer, DiasCalculoMora As Integer
        Dim DebeSerInteres As Decimal, DebeSerMora As Decimal
        Dim CuotaGestion As Decimal, CuotaCapitalPlan As Decimal = SiEsNulo(blPrestamo.getPrestamosPlanPagoCapital(entPrestamo.IdPrestamo, deHasta.EditValue), 0.0)

        With blPres
            .FechaContable = deHasta.EditValue
            .FechaAmortizacion = deHasta.EditValue
            .DiasPorAnio = giDiasPorAnioPrestamo
            .FechaPrimerPago = entPrestamo.FechaPrimerPago
            .CancelarEfectivo = False

            Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
            If entLinea.CuotaSinCentavos Then
                .CuotaSinCentavos = True
            End If

            .Efectivo = entLinea.TipoLinea = 1


            'Cuota base para el calculo de la mora
            .CalculaUltimoPago()
            .CalculaCuotaBaseMora()
            .CalculaCuotaDeberSer()
            'TODO cambiar nombre
            SaldoDebeSer = .CuotaDeberSer.ImporteSaldo
            CapitalMora = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0.0)

            ValorCuota = .CuotaBaseMora.ImporteCuota
            .ImporteAbonoPago = Val(entPrestamo.MontoDesembolsado)
            'Cuota base para calculo de otros importes

            With .CuotaDeberSer
                CuotaAhorro = .ImporteCuotaAhorro
                CuotaAportacion = .ImporteCuotaAportacion
                CuotaSeguro = .ImporteCuotaSeguro
                CuotaManejo = .ImporteCuotaManejo
                CuotaOtros = .ImporteCuotaOtros
            End With

            '-- Estado de cuenta
            If entPrestamo.TipoCuota = 1 Then
                DiasCalculoInteres = DateDiff(DateInterval.Day, .UltimoPago.Fecha, .FechaAmortizacion)
            Else
                DiasCalculoInteres = DateDiff(DateInterval.Day, .UltimoPago.Fecha, .FechaAmortizacion)
            End If

            DiasCalculoMora = bl.GetDiasMora(entPrestamo.IdPrestamo, deHasta.EditValue)

            ''Cuando arrastro saldo de interes en mora pendiente, tomo los dias de calculo de mora desde el ultimo pago realizado


            If .UltimoPago.ImporteDeudaMora > 0.0 Or .UltimoPago.ImporteMora > 0 Then
                DiasCalculoMora = DiasCalculoInteres
            End If

            DiasCalculoMora = Min(DiasCalculoMora, bl.GetDiasMora(entPrestamo.IdPrestamo, deHasta.EditValue))

            'Si va adelantado en el pago la mora el calculo de mora es 0

            Dim ImporteSaldoCalculoMora As Decimal = Max(.UltimoPago.ImporteSaldo - .CuotaDeberSer.ImporteSaldo, 0)
            Dim ImporteSaldoCalculoInteres As Decimal = .UltimoPago.ImporteSaldo

            'Calcula las tasas diarias
            Dim TasaInteres As Decimal

            If entPrestamo.IdLinea <> 7 Then
                TasaInteres = .TasaInteresAnual / 100 * DiasCalculoInteres / giDiasPorAnioPrestamo
                DebeSerInteres = .UltimoPago.ImporteDeudaInteres + Round(ImporteSaldoCalculoInteres * TasaInteres, 2)
            Else
                Dim dtSaldos As DataTable = bl.CalculaSaldoPres(teIdPrestamo.EditValue, entPrestamo.IdAsociado, deHasta.EditValue, False)
                DebeSerInteres = dtSaldos.Rows(0).Item("SaldoInteres")
            End If

            Dim TasaMora As Decimal = .TasaInteresMora / 100 * DiasCalculoMora / giDiasPorAnioPrestamo

            DebeSerMora = .UltimoPago.ImporteDeudaMora + Round(ImporteSaldoCalculoMora * TasaMora, 2)
            .NoInteres = False
            .CalculaAmortizacion()

            With .PagoActual
                CuotaSeguro = .ImporteCuotaSeguro
            End With
            CuotaGestion = entPrestamo.CuotaGestion
            If entPrestamo.IdTipoCartera = 3 Or blPres.UltimoPago.ImporteSaldo <= 0 Then
                CuotaAhorro = 0.0
                CuotaManejo = 0.0
                CuotaSeguro = 0.0
            End If

        End With
        Dim rpt As New pre_rptEstadoCuentaPrestamo
        rpt.DataSource = bl.rptEstadoCuentaPrestamo(beNoPrestamo.EditValue, deHasta.EditValue)
        rpt.DataMember = ""
        Dim dtFia As DataTable = bl.rptFiadores(entPrestamo.IdSolicitud)
        If dtFia.Rows.Count > 0 Then
            rpt.XrSubreport1.ReportSource.DataSource = dtFia
            rpt.XrSubreport1.ReportSource.DataMember = ""
        Else
            rpt.XrSubreport1.Visible = False
        End If
        rpt.xrlCapitalMora.Text = Format(CapitalMora, "###,##0.00")
        rpt.xrlIntereses.Text = Format(DebeSerInteres, "###,##0.00")
        rpt.xrlIntMora.Text = Format(DebeSerMora, "###,##0.00")
        rpt.xrlSeguro.Text = Format(CuotaSeguro, "###,##0.00")
        rpt.xrlManejo.Text = Format(CuotaManejo, "###,##0.00")
        rpt.xrlAhorro.Text = Format(CuotaAhorro, "###,##0.00")
        rpt.xrlGestion.Text = Format(CuotaGestion, "###,##0.00")
        rpt.xrlSaldoPagar.Text = Format(CapitalMora + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro + CuotaGestion, "###,##0.00")
        rpt.xrlTotalCancelar.Text = Format(blPres.UltimoPago.ImporteSaldo + DebeSerInteres + DebeSerMora + CuotaSeguro + CuotaManejo + CuotaAhorro + CuotaGestion, "###,##0.00")
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFecha.Text = teTitulo.EditValue + " AL " & (FechaToString(deHasta.EditValue, deHasta.EditValue)).ToUpper
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub beNoPrestamo_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles beNoPrestamo.MouseClick
        frmConsultaPrestamos.ShowDialog()
        beNoPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        'teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado

        beNoPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub beNoPrestamo_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNoPrestamo.Validated

        If beNoPrestamo.EditValue = "" Then
            Exit Sub
        End If
        Dim entAsociados As New coo_Asociados, entPrestamo As New coo_Prestamos
        entPrestamo = blPrestamo.coo_PrestamosSelectByNumero(beNoPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        entAsociados = blCaja.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teNombreAsociado.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)
    End Sub

    Private Sub pre_frmEstadoCuentaPrestamo_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptEstadoCuentaPrestamo(beNoPrestamo.EditValue, deHasta.EditValue), "")
    End Sub

    Private Sub sbAcuerdos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAcuerdos.Click
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If beNoPrestamo.EditValue = "" Then
            MsgBox("Debe seleccionar un préstamo", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        pre_frmAcuerdosAsociado.IdPrestamo = teIdPrestamo.EditValue
        pre_frmAcuerdosAsociado.ShowDialog()
    End Sub

    Private Sub sbGenerarPlan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGenerarPlan.Click
        If beNoPrestamo.EditValue = "" Then
            Exit Sub
        End If
        Dim rpt As New pre_rptPlanPago
        Dim plan As DataTable = blPrestamo.getPrestamosPlanPago(teIdPrestamo.EditValue)
        Dim entPrestamo As coo_Prestamos = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        rpt.DataSource = plan
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlMontoOtorgado.Text = entPrestamo.MontoAprobado
        rpt.xrlNumeroCuotas.Text = entPrestamo.NumCuotas
        rpt.xrlTasa.Text = entPrestamo.TasaInteres
        rpt.xrlFormaPago.Text = IIf(entPrestamo.IdFormaPago = 1, "Mensual", "Por días")
        rpt.xrlFechaOtorgado.Text = entPrestamo.FechaOtorgado
        rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
        rpt.xrlUsuario.Text = objMenu.User
        rpt.ShowPreviewDialog()
        rpt.Dispose()
    End Sub
End Class
