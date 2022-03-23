Public Class Cuota

    'Private _PagoFirstCalc As Decimal
    'Public Property PagoFirstCalc() As Decimal
    '    Get
    '        Return _PagoFirstCalc
    '    End Get
    '    Set(ByVal value As Decimal)
    '        _PagoFirstCalc = value
    '    End Set
    'End Property

    Private _NumeroCuota As Integer
    Public Property NumeroCuota() As Integer
        Get
            Return _NumeroCuota
        End Get
        Set(ByVal value As Integer)
            _NumeroCuota = value
        End Set
    End Property

    Private _FechaVencimiento As Date
    Public Property FechaPago() As Date
        Get
            Return _FechaVencimiento
        End Get
        Set(ByVal value As Date)
            _FechaVencimiento = value
        End Set
    End Property

    Private _DiasCalculados As Integer
    Public Property DiasCalculados() As Integer
        Get
            Return _DiasCalculados
        End Get
        Set(ByVal value As Integer)
            _DiasCalculados = value
        End Set
    End Property

    Private _TasaInteres As Decimal
    Public Property TasaInteres() As Decimal
        Get
            Return _TasaInteres
        End Get
        Set(ByVal value As Decimal)
            _TasaInteres = value
        End Set
    End Property

    Private _TasaMora As Decimal
    Public Property TasaMora() As Decimal
        Get
            Return _TasaMora
        End Get
        Set(ByVal value As Decimal)
            _TasaMora = value
        End Set
    End Property

    Private _ImporteCuota As Decimal
    Public Property ImporteCuota() As Decimal
        Get
            Return _ImporteCuota
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuota = value
        End Set
    End Property

    Private _ImporteInteres As Decimal
    Public Property ImporteInteres() As Decimal
        Get
            Return _ImporteInteres
        End Get
        Set(ByVal value As Decimal)
            _ImporteInteres = value
        End Set
    End Property

    Private _ImporteCapital As Decimal
    Public Property ImporteCapital() As Decimal
        Get
            Return _ImporteCapital
        End Get
        Set(ByVal value As Decimal)
            _ImporteCapital = value
        End Set
    End Property

    Private _ImporteSaldo As Decimal
    Public Property ImporteSaldo() As Decimal
        Get
            Return _ImporteSaldo
        End Get
        Set(ByVal value As Decimal)
            _ImporteSaldo = value
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

    Private _TasaSeguro As Decimal
    Public Property TasaSeguro() As Decimal
        Get
            Return _TasaSeguro
        End Get
        Set(ByVal value As Decimal)
            _TasaSeguro = value
        End Set
    End Property

    Private _ImporteCuotaSeguro As Decimal
    Public Property ImporteCuotaSeguro() As Decimal
        Get
            Return _ImporteCuotaSeguro
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaSeguro = value
        End Set
    End Property

End Class
