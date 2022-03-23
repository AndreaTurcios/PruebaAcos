Imports System.Math
Imports DBCoopEL.TableEntities
Imports DBCoopDL
Public Class Prestamo
    Dim dl As New CajaData
    Dim dlAdmon As New AdmonBLL
    Dim objTablas As New TableData
    Dim fd As New FuncionesBLL()
    Dim blCaja As New CajaBusiness
    ReadOnly dlPrestamo As New PrestamoDL()

    
#Region "Propiedades"

    Private _IdCuentaAhorro As Integer
    Public Property IdCuentaAhorro() As Integer
        Get
            Return _IdCuentaAhorro
        End Get
        Set(ByVal value As Integer)
            _IdCuentaAhorro = value
        End Set
    End Property

    Private _LineaLibretaAporta As String
    Public Property LineaLibretaAporta() As String
        Get
            Return _LineaLibretaAporta
        End Get
        Set(ByVal value As String)
            _LineaLibretaAporta = value
        End Set
    End Property

    Private _LineaLibretaAhoro As String
    Public Property LineaLibretaAhorro() As String
        Get
            Return _LineaLibretaAhoro
        End Get
        Set(ByVal value As String)
            _LineaLibretaAhoro = value
        End Set
    End Property


    Private _CodUsuario As String
    Public Property CodUsuario() As String
        Get
            Return _CodUsuario
        End Get
        Set(ByVal value As String)
            _CodUsuario = value
        End Set
    End Property

    Private _CapitalInicial As Decimal
    Public Property CapitalInicial() As Decimal
        Get
            Return _CapitalInicial
        End Get
        Set(ByVal value As Decimal)
            _CapitalInicial = value
        End Set
    End Property

    Private _TasaInteresAnual As Decimal
    Public Property TasaInteresAnual() As Decimal
        Get
            Return _TasaInteresAnual
        End Get
        Set(ByVal value As Decimal)
            _TasaInteresAnual = value
        End Set
    End Property

    Private _NumeroCuotas As Integer
    Public Property NumeroCuotas() As Integer
        Get
            Return _NumeroCuotas
        End Get
        Set(ByVal value As Integer)
            _NumeroCuotas = value
        End Set
    End Property

    Private _IdFormaPago As Integer
    Public Property IdFormaPago() As Integer
        Get
            Return _IdFormaPago
        End Get
        Set(ByVal value As Integer)
            _IdFormaPago = value
        End Set
    End Property

    Private _FrecuenciaPago As Integer
    Public Property FrecuenciaPago() As Integer
        Get
            Return _FrecuenciaPago
        End Get
        Set(ByVal value As Integer)
            _FrecuenciaPago = value
        End Set
    End Property

    Private _TipoCuota As Integer
    Public Property TipoCuota() As Integer
        Get
            Return _TipoCuota
        End Get
        Set(ByVal value As Integer)
            _TipoCuota = value
        End Set
    End Property

    Private _DiasPorAnio As Integer
    Public Property DiasPorAnio() As Integer
        Get
            Return _DiasPorAnio
        End Get
        Set(ByVal value As Integer)
            _DiasPorAnio = value
        End Set
    End Property

    Private _PagoCalculado As Decimal
    Public Property PagoCalculado() As Decimal
        Get
            Return _PagoCalculado
        End Get
        Set(ByVal value As Decimal)
            _PagoCalculado = value
        End Set
    End Property

    Private _FechaOtorgamiento As Date
    Public Property FechaOtorgamiento() As Date
        Get
            Return _FechaOtorgamiento
        End Get
        Set(ByVal value As Date)
            _FechaOtorgamiento = value
        End Set
    End Property
    Private _FechaPrimerPago As Date
    Public Property FechaPrimerPago() As Date
        Get
            Return _FechaPrimerPago
        End Get
        Set(ByVal value As Date)
            _FechaPrimerPago = value
        End Set
    End Property

    Private _PlanPago As New List(Of Cuota)
    Public Property PlanPago() As List(Of Cuota)
        Get
            Return _PlanPago
        End Get
        Set(ByVal value As List(Of Cuota))
            _PlanPago = value
        End Set
    End Property

    Private _FechaAmortizacion As Date
    Public Property FechaAmortizacion() As Date
        Get
            Return _FechaAmortizacion
        End Get
        Set(ByVal value As Date)
            _FechaAmortizacion = value
        End Set
    End Property


    Private _CuotaAportacion As Decimal
    Public Property CuotaAportacion() As Decimal
        Get
            Return _CuotaAportacion
        End Get
        Set(ByVal value As Decimal)
            _CuotaAportacion = value
        End Set
    End Property

    Private _CuotaManejo As Decimal
    Public Property CuotaManejo() As Decimal
        Get
            Return _CuotaManejo
        End Get
        Set(ByVal value As Decimal)
            _CuotaManejo = value
        End Set
    End Property

    Private _CuotaAhorro As Decimal
    Public Property CuotaAhorro() As Decimal
        Get
            Return _CuotaAhorro
        End Get
        Set(ByVal value As Decimal)
            _CuotaAhorro = value
        End Set
    End Property

    Private _ComisionCobranza As Decimal
    Public Property ComisionCobranza() As Decimal
        Get
            Return _ComisionCobranza
        End Get
        Set(ByVal value As Decimal)
            _ComisionCobranza = value
        End Set
    End Property

    Private _Gestion As Decimal
    Public Property Gestion() As Decimal
        Get
            Return _Gestion
        End Get
        Set(ByVal value As Decimal)
            _Gestion = value
        End Set
    End Property

    Private _CuotaBaseMora As New Cuota
    Public Property CuotaBaseMora() As Cuota
        Get
            Return _CuotaBaseMora
        End Get
        Set(ByVal value As Cuota)
            _CuotaBaseMora = value
        End Set
    End Property

    Private _UltimoPago As New Pago
    Public Property UltimoPago() As Pago
        Get
            Return _UltimoPago
        End Get
        Set(ByVal value As Pago)
            _UltimoPago = value
        End Set
    End Property

    Private _Pagos As New List(Of Pago)
    Public Property Pagos() As List(Of Pago)
        Get
            Return _Pagos
        End Get
        Set(ByVal value As List(Of Pago))
            _Pagos = value
        End Set
    End Property

    Private _ImporteAbonoPago As Decimal
    Public Property ImporteAbonoPago() As Decimal
        Get
            Return _ImporteAbonoPago
        End Get
        Set(ByVal value As Decimal)
            _ImporteAbonoPago = value
        End Set
    End Property

    Private _TasaInteresMora As Decimal
    Public Property TasaInteresMora() As Decimal
        Get
            Return _TasaInteresMora
        End Get
        Set(ByVal value As Decimal)
            _TasaInteresMora = value
        End Set
    End Property


    Private _ImporteCuotaAportacion As Decimal
    Public Property ImporteCuotaAportacion() As Decimal
        Get
            Return _ImporteCuotaAportacion
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaAportacion = value
        End Set
    End Property

    Private _ImporteCuotaAhorro As Decimal
    Public Property ImporteCuotaAhorro() As Decimal
        Get
            Return _ImporteCuotaAhorro
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaAhorro = value
        End Set
    End Property

    Private _ImporteCuotaManejo As Decimal
    Public Property ImporteCuotaManejo() As Decimal
        Get
            Return _ImporteCuotaManejo
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaManejo = value
        End Set
    End Property

    Private _ImporteCuotaOtros As Decimal
    Public Property ImporteCuotaOtros() As Decimal
        Get
            Return _ImporteCuotaOtros
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaOtros = value
        End Set
    End Property
    Private _ImporteCuotaCapital As Decimal
    Public Property ImporteCuotaCapital() As Decimal
        Get
            Return _ImporteCuotaCapital
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaCapital = value
        End Set
    End Property
    Private _CuotaSinCentavos As Boolean
    Public Property CuotaSinCentavos() As Boolean
        Get
            Return _CuotaSinCentavos
        End Get
        Set(ByVal value As Boolean)
            _CuotaSinCentavos = value
        End Set
    End Property
    Private _CancelarEfectivo As Boolean
    Public Property CancelarEfectivo() As Boolean
        Get
            Return _CancelarEfectivo
        End Get
        Set(ByVal value As Boolean)
            _CancelarEfectivo = value
        End Set
    End Property

    Private _Efectivo As Boolean
    Public Property Efectivo() As Boolean
        Get
            Return _Efectivo
        End Get
        Set(ByVal value As Boolean)
            _Efectivo = value
        End Set
    End Property

    Private _TasaSeguroDeuda As Decimal
    Public Property TasaSeguroDeuda() As Decimal
        Get
            Return _TasaSeguroDeuda
        End Get
        Set(ByVal value As Decimal)
            _TasaSeguroDeuda = value
        End Set
    End Property

    Private _ValorCuota As Decimal
    Public Property ValorCuota() As Decimal
        Get
            Return _ValorCuota
        End Get
        Set(ByVal value As Decimal)
            _ValorCuota = value
        End Set
    End Property

    Private _IdAsociado As Integer
    Public Property IdAsociado() As Integer
        Get
            Return _IdAsociado
        End Get
        Set(ByVal value As Integer)
            _IdAsociado = value
        End Set
    End Property

    Private _NombreAsociado As String
    Public ReadOnly Property Asociado() As String
        Get
            Return _NombreAsociado
        End Get
    End Property

    'Private _CnString As String
    'Public Property CnString() As String
    '    Get
    '        Return _CnString
    '    End Get
    '    Set(ByVal value As String)
    '        _CnString = value
    '    End Set
    'End Property


    Private _PagoActual As New Pago
    Public Property PagoActual() As Pago
        Get
            Return _PagoActual
        End Get
        Set(ByVal value As Pago)
            _PagoActual = value
        End Set
    End Property


    Private _FechaContable As Nullable(Of Date)
    Public Property FechaContable() As Nullable(Of Date)
        Get
            Return _FechaContable
        End Get
        Set(ByVal value As Nullable(Of Date))
            _FechaContable = value
        End Set
    End Property


    Private _IdPrestamo As Integer
    Public Property IdPrestamo() As Integer
        Get
            Return _IdPrestamo
        End Get
        Set(ByVal value As Integer)
            _IdPrestamo = value
        End Set
    End Property

    Private _IdSucursal As Integer
    Public Property IdSucursal() As Integer
        Get
            Return _IdSucursal
        End Get
        Set(ByVal value As Integer)
            _IdSucursal = value
        End Set
    End Property

    Private _NumeroCtaAhorro As String
    Public Property NumeroCtaAhorro() As String
        Get
            Return _NumeroCtaAhorro
        End Get
        Set(ByVal value As String)
            _NumeroCtaAhorro = value
        End Set
    End Property

    Private _CuotaDeberSer As New Cuota
    Public Property CuotaDeberSer() As Cuota
        Get
            Return _CuotaDeberSer
        End Get
        Set(ByVal value As Cuota)
            _CuotaDeberSer = value
        End Set
    End Property

    Private _MoraModificada As Boolean
    Public Property MoraModificada() As Boolean
        Get
            Return _MoraModificada
        End Get
        Set(ByVal value As Boolean)
            _MoraModificada = value
        End Set
    End Property

    Private _SeguroModificado As Boolean
    Public Property SeguroModificado() As Boolean
        Get
            Return _SeguroModificado
        End Get
        Set(ByVal value As Boolean)
            _SeguroModificado = value
        End Set
    End Property


    Private _MoraManual As Decimal
    Public Property MoraManual() As Decimal
        Get
            Return _MoraManual
        End Get
        Set(ByVal value As Decimal)
            _MoraManual = value
        End Set
    End Property

    Private _NoInteres As Boolean
    Public Property NoInteres() As Boolean
        Get
            Return _NoInteres
        End Get
        Set(ByVal value As Boolean)
            _NoInteres = value
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Sub CalculaPlanPagos()
        Dim FechaAnterior As Date = FechaOtorgamiento
        Dim SaldoAnterior As Decimal = CapitalInicial
        Dim dtParam As DataTable = dlAdmon.ObtieneParametros
        Dim DiasPrestamo As Integer = dtParam.Rows(0).Item("DiasPrestamo")
        Dim MaxSeguro As Decimal = dtParam.Rows(0).Item("MaximoAsegurablePrestamo")
        'Determina el numero de periodos a pagar en un año
        Dim NumPeriodosAnio As Integer

        CuotaSinCentavos = False 'fd.EsNulo(CuotaSinCentavos, False)
        CancelarEfectivo = fd.EsNulo(CancelarEfectivo, False)
        Efectivo = fd.EsNulo(Efectivo, False)

        If IdFormaPago = 1 Then 'la forma de pago es por meses
            If FrecuenciaPago > 12 Then
                NumPeriodosAnio = 1
            Else
                NumPeriodosAnio = 12 / FrecuenciaPago
            End If
        Else
            If Efectivo Then
                FrecuenciaPago = DateDiff(DateInterval.Day, FechaOtorgamiento, FechaPrimerPago)
                NumPeriodosAnio = FrecuenciaPago / (FrecuenciaPago / 2) 'DiasPrestamo / FrecuenciaPago
            Else
                'FrecuenciaPago = 12 'DateDiff(DateInterval.Day, FechaOtorgamiento, FechaPrimerPago)
                NumPeriodosAnio = 12 '/ (FrecuenciaPago / 2) 'DiasPrestamo / FrecuenciaPago
            End If
        End If


        Dim TasaPago As Decimal = TasaInteresAnual / 100 / NumPeriodosAnio

        ' CuotaSinCentavos = False
        Dim NumCuota As Integer = 0

        If IdFormaPago = 1 Then
            NumCuota = NumeroCuotas
        Else
            If Efectivo Then
                NumCuota = NumeroCuotas
            Else
                NumCuota = (NumeroCuotas / 2)
            End If
        End If

        If TipoCuota = 2 Then
            PagoCalculado = Round(CapitalInicial / NumeroCuotas, 2)
        Else
            If TipoCuota = 3 Then ' capaga solo interes y el capital de ultimo
                PagoCalculado = 0
            Else
                If TasaPago = 0 Then
                    PagoCalculado = Round(CapitalInicial / NumeroCuotas, 2)
                Else
                    If Efectivo Then
                        PagoCalculado = CapitalInicial
                    Else
                        If CuotaSinCentavos Then
                            PagoCalculado = Round(CapitalInicial * (TasaPago * Pow(1 + TasaPago, NumCuota) / (Pow(1 + TasaPago, NumCuota) - 1)), 0)
                        Else
                            PagoCalculado = Round(CapitalInicial * (TasaPago * Pow(1 + TasaPago, NumCuota) / (Pow(1 + TasaPago, NumCuota) - 1)), 2)
                        End If
                    End If
                End If
            End If
        End If

        'no aplica para acosiemens
        'If IdFormaPago = 2 And TasaPago > 0 And TipoCuota = 1 Then
        '    PagoCalculado = PagoCalculado / 2
        'End If

        If CapitalInicial < MaxSeguro Then
            MaxSeguro = CapitalInicial
        End If

        Dim Seguro As Decimal = Round(MaxSeguro * (TasaSeguroDeuda / 1000), 2)
        PagoCalculado += Seguro

        If Me.IdFormaPago = 1 Then
            'calcular el seguro diario cuando el primer mes tenga 31 días para efectos que el asociado no caiga en mora
            Dim FechaProxima As Date = DateAdd(DateInterval.Month, FrecuenciaPago, FechaAnterior)
            If DateDiff(DateInterval.Day, FechaAnterior, FechaProxima) > 30 Then
                'Seguro = Round(Seguro / 30 * 31, 2)
            End If
            'Seguro = Round(Seguro * Me.FrecuenciaPago, 2)
        Else
            'Seguro = Round(Round(Round(MaxSeguro * TasaSeguroDeuda / 1000, 2) / 30, 8) * Me.FrecuenciaPago, 2)
        End If

        For i As Integer = 1 To NumeroCuotas
            Dim CuotaCalculada As New Cuota

            With CuotaCalculada

                .NumeroCuota = i

                If IdFormaPago = 1 Then
                    ' .FechaPago = DateAdd(DateInterval.Month, FrecuenciaPago, FechaAnterior)
                    If i = 1 Then
                        .FechaPago = FechaPrimerPago
                    Else

                        If FechaAnterior.Day = 15 Then
                            .FechaPago = DateAdd(DateInterval.Month, FrecuenciaPago, FechaAnterior)
                        Else
                            Dim FechaInicioMes_ As String = "01/" + DateAdd(DateInterval.Month, 1, FechaAnterior).Month.ToString.PadLeft(2, "0") + "/" + DateAdd(DateInterval.Month, 1, FechaAnterior).Year.ToString.PadLeft(4, "0")
                            Dim FecIniMes As Date = CDate(FechaInicioMes_)
                            FecIniMes = DateAdd(DateInterval.Month, FrecuenciaPago, FecIniMes)
                            FecIniMes = DateAdd(DateInterval.Day, -1, FecIniMes)
                            .FechaPago = FecIniMes
                        End If

                    End If

                Else 'QUINCENAL
                    If i = 1 Then
                        .FechaPago = FechaPrimerPago
                    Else
                        If FechaAnterior.Day = 15 Then ' SI EL PAGO ANTERIOR FUE DIA 15

                            Dim FechaInicioMes As String = "01/" + FechaAnterior.Month.ToString.PadLeft(2, "0") + "/" + FechaAnterior.Year.ToString.PadLeft(4, "0")
                            Dim Fec As Date = CDate(FechaInicioMes)
                            Fec = DateAdd(DateInterval.Month, 1, Fec)
                            Fec = DateAdd(DateInterval.Day, -1, Fec)

                            .FechaPago = Fec
                        Else
                            Dim FechaInicioMes_ As String = "15/" + DateAdd(DateInterval.Month, 1, FechaAnterior).Month.ToString.PadLeft(2, "0") + "/" + DateAdd(DateInterval.Month, 1, FechaAnterior).Year.ToString.PadLeft(4, "0")
                            Dim FecIniMes As Date = CDate(FechaInicioMes_)
                            .FechaPago = FecIniMes
                        End If
                        '  .FechaPago = DateAdd(DateInterval.Day, FrecuenciaPago, FechaAnterior)
                    End If
                End If

                .ImporteCuotaSeguro = SaldoAnterior * (TasaSeguroDeuda / 1000)
                .DiasCalculados = DateDiff(DateInterval.Day, FechaAnterior, .FechaPago)
                .TasaInteres = TasaInteresAnual
                .TasaMora = TasaInteresMora

                'para los prestamos que solo pagan interes, los dias seran fijos de 30
                If TipoCuota = 3 And i <> 1 Then
                    .DiasCalculados = 30
                End If

                If TipoCuota <> 2 Then 'cuando es cuota de capital fijo el interés se calcula en base a 31 días, según los señores de CONCHAGUA
                    .ImporteInteres = Round(SaldoAnterior * (TasaInteresAnual / 100) * .DiasCalculados / DiasPorAnio, 2)
                End If

                'especial de prestamos en efectivo de siemens
                If Efectivo Then
                    .ImporteInteres = Round(SaldoAnterior * (TasaInteresAnual / 100), 2)
                End If

                'Otras cuotas
                .ImporteCuotaAportacion = ImporteCuotaAportacion
                .ImporteCuotaAhorro = ImporteCuotaAhorro
                .ImporteCuotaManejo = ImporteCuotaManejo
                .ImporteCuotaOtros = ImporteCuotaOtros
                '.ImporteCuotaSeguro = Seguro

                .ImporteCuota = PagoCalculado + .ImporteCuotaAportacion + .ImporteCuotaAhorro + .ImporteCuotaManejo + .ImporteCuotaOtros
                '+ .ImporteCuotaSeguro

                If Efectivo Then 'cuando es cuota de capital fijo, se aumenta el interés
                    .ImporteCuota = .ImporteCuota + .ImporteInteres
                End If

                If i = 1 Then  'para efectos de obtener la primer cuota y que sería el valor de la cuota
                    Me.ValorCuota = .ImporteCuota
                End If

                If TipoCuota = 3 Then ' para prestamos capitalizable so que solo pagan int, solo sera interes mas seguro
                    .ImporteCuota = .ImporteInteres + .ImporteCuotaSeguro
                    Me.ValorCuota = .ImporteInteres + .ImporteCuotaSeguro
                End If

                'Ajusta el Importe de la ultima cuota igual al saldo
                If i = NumeroCuotas Then
                    .ImporteCuota = SaldoAnterior + .ImporteInteres + .ImporteCuotaSeguro + .ImporteCuotaAportacion + .ImporteCuotaAhorro + .ImporteCuotaManejo + .ImporteCuotaOtros
                    .ImporteCapital = .ImporteCuota - (.ImporteInteres + .ImporteCuotaSeguro + .ImporteCuotaAportacion + .ImporteCuotaAhorro + .ImporteCuotaManejo + .ImporteCuotaOtros)
                Else
                    If TipoCuota <> 3 Then
                        .ImporteCapital = .ImporteCuota - (.ImporteInteres + .ImporteCuotaSeguro + .ImporteCuotaAportacion + .ImporteCuotaAhorro + .ImporteCuotaManejo + .ImporteCuotaOtros)
                    Else
                        .ImporteCapital = 0.0
                    End If
                End If


                .ImporteSaldo = SaldoAnterior - .ImporteCapital

                '-- Actualiza contadores
                FechaAnterior = .FechaPago
                SaldoAnterior = .ImporteSaldo
            End With

            'Agrega la cuota calculada al plan de pagos
            PlanPago.Add(CuotaCalculada)
        Next
    End Sub

    Private Function GetIndiceCuotaDeberSer() As Integer
        'Encuentra la cuota para el calculo de recargos
        Dim i As Integer
        For i = Me.NumeroCuotas - 1 To -1 Step -1
            If i > -1 Then
                If PlanPago(i).FechaPago <= Me.FechaAmortizacion Then
                    Exit For
                End If
            End If
        Next
        i = Max(i, -1)

        If i = -1 Then
            Return 0
        Else
            Return PlanPago(i).NumeroCuota
        End If


    End Function

    Private Function GetDiasMora(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Integer
        'Calculo los dias en Mora
        Return dlPrestamo.GetDiasMora(IdPrestamo, HastaFecha)
    End Function

    Public Sub CalculaCuotaBaseMora()
        Dim i As Integer
        For i = 0 To Me.NumeroCuotas - 1
            If PlanPago(i).FechaPago > UltimoPago.Fecha Then
                Exit For
            End If
        Next
        i = Min(i, PlanPago.Count - 1)
        CuotaBaseMora = PlanPago(i)
    End Sub

    Public Sub CalculaUltimoPago()
        _UltimoPago = New Pago
        If Pagos.Count = 0 Then
            With PlanPago(0)
                UltimoPago.Fecha = Me.FechaOtorgamiento
                UltimoPago.ImporteDeudaMora = 0
                UltimoPago.ImporteDeudaMora = 0
                UltimoPago.ImporteSaldo = Me.CapitalInicial
            End With
        Else
            With Pagos(Pagos.Count - 1)
                UltimoPago.Fecha = .Fecha
                UltimoPago.ImporteMora = .ImporteMora
                UltimoPago.ImporteDeudaMora = .ImporteDeudaMora
                UltimoPago.ImporteDeudaInteres = .ImporteDeudaInteres
                UltimoPago.ImporteDeudaManejo = .ImporteDeudaManejo
                UltimoPago.ImporteDeudaOtros = .ImporteDeudaOtros
                UltimoPago.ImporteDeudaSeguro = .ImporteDeudaSeguro
                UltimoPago.ImporteSaldo = .ImporteSaldo
            End With
        End If
    End Sub

    Public Sub CalculaCuotaDeberSer()
        Dim NroCuotaBaseCalculo As Integer = GetIndiceCuotaDeberSer()
        Dim nIndicePlan As Integer = NroCuotaBaseCalculo - 1
        '' Creo esta variable para llevar el indice del arreglo Plan Pago y le resto 1 para llevar el control del Indice

        If (nIndicePlan = -1) Then
            _CuotaDeberSer = New Cuota
            With CuotaDeberSer
                .NumeroCuota = 0
                .ImporteSaldo = Me._CapitalInicial
                .FechaPago = Me.FechaOtorgamiento
                .ImporteCuotaAhorro = Me.ImporteCuotaAhorro
                .ImporteCuotaAportacion = Me.ImporteCuotaAportacion
                .ImporteCuotaManejo = Me.ImporteCuotaManejo
                .ImporteCuotaSeguro = 0
                .ImporteCuotaOtros = Me.ImporteCuotaOtros
                .TasaInteres = Me.TasaInteresAnual
                .TasaMora = Me.TasaInteresMora
                .TasaSeguro = Me.TasaSeguroDeuda
            End With
        Else
            Dim dt As DataTable = dlPrestamo.GetCuotasAportes(Me.IdPrestamo, NroCuotaBaseCalculo, Me.FechaAmortizacion)
            _CuotaDeberSer = New Cuota
            With CuotaDeberSer


                If Me.FechaAmortizacion = Me.PlanPago(nIndicePlan).FechaPago And (nIndicePlan - 1) > -1 Then
                    .NumeroCuota = NroCuotaBaseCalculo - 1
                    .ImporteSaldo = Me.PlanPago(nIndicePlan - 1).ImporteSaldo
                    .FechaPago = Me.PlanPago(nIndicePlan - 1).FechaPago
                Else
                    .NumeroCuota = NroCuotaBaseCalculo
                    .ImporteSaldo = Me.PlanPago(nIndicePlan).ImporteSaldo
                    .FechaPago = Me.PlanPago(nIndicePlan).FechaPago
                End If

                If Not IsDBNull(dt.Rows(0).Item("CuotaAhorro")) Then
                    .ImporteCuotaAhorro = Max(dt.Rows(0).Item("CuotaAhorro"), 0)
                    .ImporteCuotaAportacion = Max(dt.Rows(0).Item("CuotaAporta"), 0)
                    .ImporteCuotaManejo = Max(dt.Rows(0).Item("CuotaManejo"), 0)
                    .ImporteCuotaSeguro = Max(dt.Rows(0).Item("CuotaSeguro"), 0)
                    .ImporteCuotaOtros = Max(dt.Rows(0).Item("CuotaOtros"), 0)
                Else
                    .ImporteCuotaAhorro = 0
                    .ImporteCuotaAportacion = 0
                    .ImporteCuotaManejo = 0
                    .ImporteCuotaSeguro = 0
                    .ImporteCuotaOtros = 0
                End If
                .TasaInteres = PlanPago(nIndicePlan).TasaInteres
                .TasaMora = PlanPago(nIndicePlan).TasaMora
                .TasaSeguro = PlanPago(nIndicePlan).TasaSeguro
                ImporteCuotaCapital = PlanPago(nIndicePlan).ImporteCapital


            End With
        End If
    End Sub

    Public Sub CalculaAmortizacion()
        Dim dtParametros As DataTable = dlAdmon.ObtieneParametros
        Dim MaxSeguro As Decimal = dlAdmon.ObtieneParametros.Rows(0).Item("MaximoAsegurablePrestamo")
        Dim CuotaSeguro As Decimal = Me.TasaSeguroDeuda
        Dim SaldoAbonoPagos As Decimal = Me.ImporteAbonoPago
        _PagoActual = New Pago

        With PagoActual
            .Fecha = Me.FechaAmortizacion
            .DiasCalculoInteres = DateDiff(DateInterval.Day, UltimoPago.Fecha, Me.FechaAmortizacion)
            .DiasCalculoMora = GetDiasMora(Me.IdPrestamo, Me.FechaAmortizacion)

            If UltimoPago.ImporteDeudaMora > 0.0 Or UltimoPago.ImporteMora > 0 Then
                .DiasCalculoMora = .DiasCalculoInteres ' esto se abia comentariado antes , seactivo
            End If                                      'se activo de nuevo para que calcule la mora bien

            .DiasCalculoMora = Min(.DiasCalculoMora, GetDiasMora(Me.IdPrestamo, Me.FechaAmortizacion))


            ''Max(DateDiff(DateInterval.Day, CuotaBaseMora.FechaPago, Me.FechaAmortizacion), 0)
            'Si va adelantado en el pago la mora el calculo de mora es 0

            .ImporteSaldoCalculoMora = Max(UltimoPago.ImporteSaldo - CuotaDeberSer.ImporteSaldo, 0)
            .ImporteSaldoCalculoInteres = UltimoPago.ImporteSaldo

            'If Me.IdPrestamo = 256 Then
            '    MsgBox(UltimoPago.ImporteSaldo)
            '    MsgBox(CuotaDeberSer.ImporteSaldo)
            'End If

            'Calcula las tasas diarias
            Dim TasaInteres As Decimal = Me.TasaInteresAnual / 100 * .DiasCalculoInteres / Me.DiasPorAnio
            Dim TasaMora As Decimal = Me.TasaInteresMora / 100 * .DiasCalculoMora / Me.DiasPorAnio

            If Me.TasaInteresAnual > 0.0 Then
                'TasaSeguro = TasaSeguro / 1000 / 30 * .DiasCalculoInteres
                'éste codigo está solo para conchagua
                Dim Meses As Integer = DateDiff(DateInterval.Month, UltimoPago.Fecha, Me.FechaAmortizacion)
                'cambio para acosiemens, el seguro en base al saldo del prestamo
                CuotaSeguro = UltimoPago.ImporteSaldo * (CuotaSeguro / 1000)  'Decimal.Round(Meses * CuotaSeguro, 2)
            Else
                CuotaSeguro = 0.0
            End If
            .ImportePago = Me.ImporteAbonoPago

            'Calcula Gestion Extra Judicial
            If Me.Gestion > 0 Then
                .ImporteGestion = Me.Gestion
            Else
                .ImporteGestion = 0.0
            End If
            If .ImporteGestion > SaldoAbonoPagos Then
                .ImporteGestion = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteGestion
            End If

            'Calcula Comisión Cobranza
            If Me.ComisionCobranza > 0 Then
                .ImporteComisionCobranza = Me.ComisionCobranza
            Else
                .ImporteComisionCobranza = 0.0
            End If
            If .ImporteComisionCobranza > SaldoAbonoPagos Then
                .ImporteComisionCobranza = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteComisionCobranza
            End If

            'Calculo de la mora
            'Si no alcanza para pagar la mora solo abona una parte 
            'y se queda con deuda para el siguiente pago

            If Not MoraModificada Then 'si la mora no fue modificada en el ingreso de pagos
                .ImporteMora = UltimoPago.ImporteDeudaMora + Round(.ImporteSaldoCalculoMora * TasaMora, 2)
            Else
                .ImporteMora = Me.MoraManual
            End If

            If .ImporteMora > SaldoAbonoPagos Then
                If .ImporteMora > 0.0 Then
                    .ImporteDeudaMora = Round(.ImporteMora - SaldoAbonoPagos, 2)
                    .DiasDeudaMora = Int(.DiasCalculoMora * Me.ImporteAbonoPago / .ImporteMora)
                    .ImporteMora = Max(SaldoAbonoPagos, 0)
                    SaldoAbonoPagos = 0
                End If
            Else
                SaldoAbonoPagos -= .ImporteMora
            End If

            Dim SC As Integer = 0, dato As Date
            dato = Me.FechaAmortizacion
            SC = blCaja.VerificaSeguroCobrado(Me.IdPrestamo, dato.Month, dato.Year)

            'Verifica si en el mes se la cobro ya el seguro ya los demas pagos es sin Seguro
            If SC = 1 Then
                .ImporteCuotaSeguro = 0
            Else
                .ImporteCuotaSeguro = UltimoPago.ImporteDeudaSeguro + Round(CuotaSeguro, 2)
            End If

            If .ImporteCuotaSeguro > SaldoAbonoPagos Then
                .ImporteDeudaSeguro = Round(.ImporteCuotaSeguro - SaldoAbonoPagos, 2)
                .ImporteCuotaSeguro = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteCuotaSeguro
            End If

            'Calcula cuota manejo
            ''.ImporteCuotaManejo = Me.CuotaDeberSer.ImporteCuotaManejo
            If Me.CuotaManejo > 0 Then
                .ImporteCuotaManejo = Me.CuotaManejo
            Else
                .ImporteCuotaManejo = 0.0
            End If

            If .ImporteCuotaManejo > SaldoAbonoPagos Then

                .ImporteDeudaManejo = Round(.ImporteCuotaManejo - SaldoAbonoPagos, 2)
                .ImporteCuotaManejo = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteCuotaManejo
            End If

            If TipoCuota = 1 Then
                .ImporteInteres = UltimoPago.ImporteDeudaInteres + Round(.ImporteSaldoCalculoInteres * TasaInteres, 2)
            Else
                Dim dtSaldos As DataTable

                If CancelarEfectivo = True Then
                    dtSaldos = blCaja.CalculaSaldoPres(Me.IdPrestamo, Me.IdAsociado, Me.FechaAmortizacion, True)
                Else
                    dtSaldos = blCaja.CalculaSaldoPres(Me.IdPrestamo, Me.IdAsociado, Me.FechaAmortizacion, False)
                End If
                If NoInteres = True Then
                    .ImporteInteres = 0.0
                Else
                    .ImporteInteres = fd.EsNulo(dtSaldos.Rows(0).Item("SaldoInteres"), 0.0)
                End If

            End If

            If .ImporteInteres > SaldoAbonoPagos Then
                .ImporteDeudaInteres = Round(.ImporteInteres - SaldoAbonoPagos, 2)
                .DiasDeudaInteres = Int(.DiasDeudaInteres * SaldoAbonoPagos / .ImporteInteres)
                .ImporteInteres = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteInteres
            End If

            'Calcula otras cuotas
            .ImporteCuotaOtros = Me.CuotaDeberSer.ImporteCuotaOtros
            If .ImporteCuotaOtros > SaldoAbonoPagos Then
                .ImporteDeudaOtros = Round(.ImporteCuotaOtros - SaldoAbonoPagos, 2)
                .ImporteCuotaOtros = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteCuotaOtros
            End If

            'Calculo Aportacion
            If Me.CuotaAportacion > 0 Then
                .ImporteCuotaAportacion = Me.CuotaAportacion
            Else
                .ImporteCuotaAportacion = 0.0
            End If
            If .ImporteCuotaAportacion > SaldoAbonoPagos Then
                .ImporteCuotaAportacion = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteCuotaAportacion
            End If

            'Calculo Ahorro
            If Me.CuotaAhorro > 0 Then
                .ImporteCuotaAhorro = Me.CuotaAhorro
            Else
                .ImporteCuotaAhorro = 0.0
            End If
            If .ImporteCuotaAhorro > SaldoAbonoPagos Then
                .ImporteCuotaAhorro = Max(SaldoAbonoPagos, 0)
                SaldoAbonoPagos = 0
            Else
                SaldoAbonoPagos -= .ImporteCuotaAhorro
            End If

            If UltimoPago.ImporteSaldo < SaldoAbonoPagos Then
                .ImporteCapital = UltimoPago.ImporteSaldo
                .ImporteSaldo = 0.0
            Else
                .ImporteCapital = SaldoAbonoPagos
                .ImporteSaldo = UltimoPago.ImporteSaldo - .ImporteCapital
            End If

        End With

    End Sub

    Public Function CargaPrestamo(ByVal IdPrestamo As Integer) As Prestamo
        Dim enPrestamo As New coo_Prestamos
        Dim CambioTasaInteres As Decimal
        Dim CambioTasaInteresMora As Decimal
        enPrestamo = objtablas.coo_PrestamosSelectByPK(IdPrestamo)
        CambioTasaInteres = dl.coo_GetCambioTasaInteres(IdPrestamo, FechaAmortizacion)
        CambioTasaInteresMora = dl.coo_GetCambioTasaMora(IdPrestamo, FechaAmortizacion)

        Dim elAsociado As coo_Asociados = objtablas.coo_AsociadosSelectByPK(enPrestamo.IdAsociado)
        Dim dtCtaAhorro As DataTable = dl.coo_GetCtaAhorroSimultaneo(elAsociado.IdAsociado)
        Dim lineaAporta As Integer = dl.coo_GetLineaAportacion(elAsociado.IdAsociado)
        With enPrestamo
            Me.IdPrestamo = .IdPrestamo
            CapitalInicial = .MontoAprobado
            If CambioTasaInteres >= 0 Then
                TasaInteresAnual = CambioTasaInteres
            Else
                TasaInteresAnual = .TasaInteres
            End If

            If CambioTasaInteresMora >= 0 Then
                TasaInteresMora = CambioTasaInteresMora
            Else
                TasaInteresMora = .TasaMora
            End If
            TasaSeguroDeuda = .TasaSeguro
            If CambioTasaInteres = 0 Then
                TasaSeguroDeuda = 0.0
            End If
            FechaOtorgamiento = .FechaOtorgado
            IdAsociado = .IdAsociado
            _NombreAsociado = String.Format("{0} {1}", elAsociado.Nombres, elAsociado.Apellidos)
            'Me.DiasPorAnio = 365
            IdFormaPago = .IdFormaPago
            NumeroCuotas = .NumCuotas

            If dtCtaAhorro.Rows.Count > 0 Then  'verifica si tiene asociada una cuenta de ahorro
                IdCuentaAhorro = dtCtaAhorro.Rows(0).Item("IdCuenta")
                NumeroCtaAhorro = dtCtaAhorro.Rows(0).Item("Numero")
                LineaLibretaAhorro = dtCtaAhorro.Rows(0).Item("LineaLibreta")
            End If

            LineaLibretaAporta = lineaAporta
            ImporteCuotaAhorro = .CuotaAhorro
            ImporteCuotaAportacion = .CuotaAportacion
            CuotaAportacion = .CuotaAportacion
            ImporteCuotaManejo = .CuotaManejo
            ImporteCuotaOtros = .CuotaOtros
        End With
        Dim ListEntPagos As List(Of coo_PrestamosDetalle) = GetMovimientosDB(IdPrestamo)

        For Each EntPago As coo_PrestamosDetalle In ListEntPagos
            Dim ClsPago As New Pago
            With ClsPago
                .Fecha = EntPago.Fecha
                .ImporteMora = EntPago.InteresMoraPagado
                .ImporteSaldo = EntPago.SaldoCapital
                .ImporteDeudaInteres = EntPago.InteresPendiente
                .ImporteDeudaManejo = EntPago.ManejoPendiente
                .ImporteDeudaMora = EntPago.InteresMoraPendiente
                .ImporteDeudaOtros = EntPago.OtrosPendiente
                .ImporteDeudaSeguro = EntPago.ValorSeguroPendiente
            End With
            Me.Pagos.Add(ClsPago)
        Next

        Dim ListEntCuotas As List(Of coo_PrestamosPlanPagos) = GetCuotasDB(IdPrestamo)
        For Each entCuota As coo_PrestamosPlanPagos In ListEntCuotas
            Dim clsCuota As New Cuota
            With clsCuota
                .ImporteSaldo = entCuota.Saldo
                .ImporteCuota = entCuota.Valor
                .ImporteCuotaAhorro = entCuota.CuotaAhorro
                .ImporteCuotaAportacion = entCuota.CuotaAportacion
                .ImporteCuotaManejo = entCuota.CuotaManejo
                .ImporteCuotaOtros = entCuota.CuotaOtros
                .NumeroCuota = entCuota.NumCuota
                .FechaPago = entCuota.Fecha
                .TasaSeguro = 0.0
                If entCuota.TasaInteres > 0 Then
                    .TasaSeguro = entCuota.TasaSeguro
                End If
                .ImporteCuotaSeguro = Decimal.Round(CapitalInicial * .TasaSeguro / 1000, 2)
                .TasaInteres = entCuota.TasaInteres
                .TasaMora = entCuota.TasaMora
            End With
            PlanPago.Add(clsCuota)
        Next

        Return Me
    End Function
    Private Function GetCuotasDB(ByVal IdPrestamo As Integer) As List(Of coo_PrestamosPlanPagos)
        Dim ListEntCuotas As New List(Of coo_PrestamosPlanPagos)
        Dim dt As DataTable = dl.coo_PrestamosPlanPagosSelectAllById(IdPrestamo)
        For Each registro As DataRow In dt.Rows
            Dim EntCuota As New coo_PrestamosPlanPagos
            With EntCuota
                .Capital = registro("Capital")
                .CuotaAhorro = registro("CuotaAhorro")
                .CuotaAportacion = registro("CuotaAportacion")
                .CuotaManejo = registro("CuotaManejo")
                .CuotaOtros = registro("CuotaOtros")
                .Fecha = registro("Fecha")
                .IdPrestamo = registro("IdPrestamo")
                .Interes = registro("Interes")
                .NumCuota = registro("NumCuota")
                .Saldo = registro("Saldo")
                .TasaInteres = registro("TasaInteres")
                .TasaMora = registro("TasaMora")
                .TasaSeguro = registro("TasaSeguro")
                .Valor = registro("Valor")
            End With
            ListEntCuotas.Add(EntCuota)
        Next
        Return ListEntCuotas
    End Function
    Private Function GetMovimientosDB(ByVal IdPrestamo As Integer) As List(Of coo_PrestamosDetalle)
        Dim ListEntPagos As New List(Of coo_PrestamosDetalle)
        Dim dt As DataTable = dl.coo_PrestamosDetalleSelectAllById(IdPrestamo)
        For Each registro As DataRow In dt.Rows
            Dim EntPago As New coo_PrestamosDetalle

            With EntPago
                .CapitalPagado = registro("CapitalPagado")
                .CreadoPor = registro("CreadoPor")
                .CuotaAhorro = registro("CuotaAhorro")
                .CuotaAportacion = registro("CuotaAportacion")
                .DiasCalcInteres = registro("DiasCalcInteres")
                .DiasCalcMora = registro("DiasCalcMora")
                .Fecha = registro("Fecha")
                .FechaContable = registro("FechaContable")
                .FechaHoraCreacion = registro("FechaHoraCreacion")
                .IdFormaPago = registro("IdFormaPago")
                .IdMov = registro("IdMov")
                .IdPrestamo = registro("IdPrestamo")
                .IdSucursal = registro("IdSucursal")
                .ImportePagado = registro("ImportePagado")
                .InteresMoraPagado = registro("InteresMoraPagado")
                .TasaInteresMora = registro("TasaInteresMora")
                .InteresMoraPendiente = registro("InteresMoraPendiente")
                .InteresPagado = registro("InteresPagado")
                .TasaInteres = registro("TasaInteres")
                .InteresPendiente = registro("InteresPendiente")
                .ManejoPagado = registro("ManejoPagado")
                .ManejoPendiente = registro("ManejoPendiente")
                .Numero = registro("Numero")
                .OtrosPagado = registro("OtrosPagado")
                .OtrosPendiente = registro("OtrosPendiente")
                .SaldoCapital = registro("SaldoCapital")
                .ValorSeguroPagado = registro("ValorSeguroPagado")
                .ValorSeguroPendiente = registro("ValorSeguroPendiente")
            End With
            If EntPago.Fecha <= Me.FechaAmortizacion Then
                ListEntPagos.Add(EntPago)
            End If
        Next
        Return ListEntPagos
    End Function

    Public Sub CalculaAmortizacionNotaCargo()
        Dim SaldoAbonoPagos As Decimal = Me.ImporteAbonoPago
        Dim UltIdMov As Integer
        Dim entMovPago As New coo_PrestamosDetalle
        UltIdMov = GetUltMovPrestamo(Me.IdPrestamo)
        If UltIdMov > 0 Then
            entMovPago = objTablas.coo_PrestamosDetalleSelectByPK(Me.IdPrestamo, UltIdMov)
        End If
        _PagoActual = New Pago
        With PagoActual
            .Fecha = Me.FechaAmortizacion
            .DiasCalculoInteres = DateDiff(DateInterval.Day, UltimoPago.Fecha, Me.FechaAmortizacion)
            .DiasCalculoMora = GetDiasMora(Me.IdPrestamo, Me.FechaAmortizacion)

            If UltimoPago.ImporteDeudaMora > 0.0 Or UltimoPago.ImporteMora > 0 Then
                .DiasCalculoMora = .DiasCalculoInteres
            End If
            .DiasCalculoMora = Min(.DiasCalculoMora, GetDiasMora(Me.IdPrestamo, Me.FechaAmortizacion))

            ''Max(DateDiff(DateInterval.Day, CuotaBaseMora.FechaPago, Me.FechaAmortizacion), 0)
            'Si va adelantado en el pago la mora el calculo de mora es 0
            .ImporteSaldoCalculoMora = Max(UltimoPago.ImporteSaldo - CuotaDeberSer.ImporteSaldo, 0)
            .ImporteSaldoCalculoInteres = UltimoPago.ImporteSaldo


            'Calcula las tasas diarias
            ''CuotaDeberSer.TasaMora
            Dim TasaInteres As Decimal = Me.TasaInteresAnual / 100 * .DiasCalculoInteres / Me.DiasPorAnio
            Dim TasaMora As Decimal = Me.TasaInteresMora / 100 * .DiasCalculoMora / Me.DiasPorAnio
            Dim TasaSeguro As Decimal = 0.0
            If Me.TasaInteresAnual > 0.0 Then
                TasaSeguro = CuotaDeberSer.TasaSeguro / 1000 / 30 * .DiasCalculoInteres
            End If
            .ImportePago = 0 - Me.ImporteAbonoPago
            Me.ImporteAbonoPago = 0 - Me.ImporteAbonoPago
            'Calcula cuotas de ahorro y aportacion
            .ImporteCuotaAportacion = 0.0
            .ImporteCuotaAhorro = 0.0

            'Recalculo de la mora
            .ImporteMora = 0 - entMovPago.InteresMoraPagado
            .ImporteDeudaMora = UltimoPago.ImporteDeudaMora + Round(.ImporteSaldoCalculoMora * TasaMora, 2)
            .DiasDeudaMora = 0

            'Recalcula seguro de deuda
            .ImporteCuotaSeguro = 0 - entMovPago.ValorSeguroPagado
            .ImporteDeudaSeguro = UltimoPago.ImporteDeudaSeguro + Round(.ImporteSaldoCalculoInteres * TasaSeguro, 2)

            'Calcula cuota manejo
            .ImporteCuotaManejo = 0 - entMovPago.ManejoPagado
            .ImporteCuotaManejo = Me.CuotaDeberSer.ImporteCuotaManejo

            'Recalculo del interes
            .ImporteInteres = 0 - entMovPago.InteresPagado
            .ImporteDeudaInteres = UltimoPago.ImporteDeudaInteres + Round(.ImporteSaldoCalculoInteres * TasaInteres, 2)
            .DiasDeudaInteres = 0
            
            'Recalcula otras cuotas
            .ImporteCuotaOtros = 0 - entMovPago.OtrosPagado
            .ImporteDeudaOtros = Me.CuotaDeberSer.ImporteCuotaOtros

            .ImporteCapital = 0 - entMovPago.CapitalPagado
            .ImporteSaldo = UltimoPago.ImporteSaldo
        End With

    End Sub

    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Return dl.GetUltMovPrestamo(IdPrestamo)
    End Function

#End Region

End Class
