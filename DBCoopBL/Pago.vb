Public Class Pago

    Private _RefenciaPago As String
    Public Property ReferenciaPago() As String
        Get
            Return _RefenciaPago
        End Get
        Set(ByVal value As String)
            _RefenciaPago = value
        End Set
    End Property

    Private _NumeroComprobante As String
    Public Property NumeroComprobante() As String
        Get
            Return _NumeroComprobante
        End Get
        Set(ByVal value As String)
            _NumeroComprobante = value
        End Set
    End Property

    Private _Fecha As Date
    Public Property Fecha() As Date
        Get
            Return _Fecha
        End Get
        Set(ByVal value As Date)
            _Fecha = value
        End Set
    End Property

    Private _FormaPago As Integer
    Public Property FormaPago() As Integer
        Get
            Return _FormaPago
        End Get
        Set(ByVal value As Integer)
            _FormaPago = value
        End Set
    End Property

    Private _DiasCalculoInteres As Integer
    Public Property DiasCalculoInteres() As Integer
        Get
            Return _DiasCalculoInteres
        End Get
        Set(ByVal value As Integer)
            _DiasCalculoInteres = value
        End Set
    End Property

    Private _DiasCalculoMora As Integer
    Public Property DiasCalculoMora() As Integer
        Get
            Return _DiasCalculoMora
        End Get
        Set(ByVal value As Integer)
            _DiasCalculoMora = value
        End Set
    End Property

    Private _ImporteSaldoCalculoMora As Decimal
    Public Property ImporteSaldoCalculoMora() As Decimal
        Get
            Return _ImporteSaldoCalculoMora
        End Get
        Set(ByVal value As Decimal)
            _ImporteSaldoCalculoMora = value
        End Set
    End Property

    Private _ImporteSaldoCalculoInteres As Decimal
    Public Property ImporteSaldoCalculoInteres() As Decimal
        Get
            Return _ImporteSaldoCalculoInteres
        End Get
        Set(ByVal value As Decimal)
            _ImporteSaldoCalculoInteres = value
        End Set
    End Property

    Private _ImportePago As Decimal
    Public Property ImportePago() As Decimal
        Get
            Return _ImportePago
        End Get
        Set(ByVal value As Decimal)
            _ImportePago = value
        End Set
    End Property

    Private _ImporteMora As Decimal
    Public Property ImporteMora() As Decimal
        Get
            Return _ImporteMora
        End Get
        Set(ByVal value As Decimal)
            _ImporteMora = value
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


    Private _ImporteGestion As Decimal
    Public Property ImporteGestion() As Decimal
        Get
            Return _ImporteGestion
        End Get
        Set(ByVal value As Decimal)
            _ImporteGestion = value
        End Set
    End Property

    Private _ImporteComisionCobranza As Decimal
    Public Property ImporteComisionCobranza() As Decimal
        Get
            Return _ImporteComisionCobranza
        End Get
        Set(ByVal value As Decimal)
            _ImporteComisionCobranza = value
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

    Private _ImporteCuotaSeguro As Decimal
    Public Property ImporteCuotaSeguro() As Decimal
        Get
            Return _ImporteCuotaSeguro
        End Get
        Set(ByVal value As Decimal)
            _ImporteCuotaSeguro = value
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

    Private _ImporteDeudaMora As Decimal
    Public Property ImporteDeudaMora() As Decimal
        Get
            Return _ImporteDeudaMora
        End Get
        Set(ByVal value As Decimal)
            _ImporteDeudaMora = value
        End Set
    End Property

    Private _ImporteDeudaInteres As Decimal
    Public Property ImporteDeudaInteres() As Decimal
        Get
            Return _ImporteDeudaInteres
        End Get
        Set(ByVal value As Decimal)
            _ImporteDeudaInteres = value
        End Set
    End Property

    Private _DiasDeudaMora As Integer
    Public Property DiasDeudaMora() As Integer
        Get
            Return _DiasDeudaMora
        End Get
        Set(ByVal value As Integer)
            _DiasDeudaMora = value
        End Set
    End Property

    Private _DiasDeudaInteres As Integer
    Public Property DiasDeudaInteres() As Integer
        Get
            Return _DiasDeudaInteres
        End Get
        Set(ByVal value As Integer)
            _DiasDeudaInteres = value
        End Set
    End Property

    Private _ImporteDeudaManejo As Decimal
    Public Property ImporteDeudaManejo() As Decimal
        Get
            Return _ImporteDeudaManejo
        End Get
        Set(ByVal value As Decimal)
            _ImporteDeudaManejo = value
        End Set
    End Property

    Private _ImporteDeudaOtros As Decimal
    Public Property ImporteDeudaOtros() As Decimal
        Get
            Return _ImporteDeudaOtros
        End Get
        Set(ByVal value As Decimal)
            _ImporteDeudaOtros = value
        End Set
    End Property

    Private _ImporteDeudaSeguro As Decimal
    Public Property ImporteDeudaSeguro() As Decimal
        Get
            Return _ImporteDeudaSeguro
        End Get
        Set(ByVal value As Decimal)
            _ImporteDeudaSeguro = value
        End Set
    End Property





End Class
