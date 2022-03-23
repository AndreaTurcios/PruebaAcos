Imports DBCoopDL
Public Class MenusBLL
    ReadOnly dl As New MenusDLL()
#Region "Acceso a Datos"
    Public Function IsMenuActivo(ByVal CodUsuario As String, ByVal NombreModulo As String) As Boolean
        Return dl.IsMenuActivo(CodUsuario, NombreModulo)
    End Function
    Public Function IsMenuActivo(ByVal CodUsuario As String, ByVal NombreModulo As String, ByVal IdOpcion As String) As Boolean
        Return dl.IsMenuActivo(CodUsuario, NombreModulo, IdOpcion)
    End Function
    Public Function GetPermisosForma(ByVal CodUsuario As String, ByVal ModuloName As String, ByVal OptionId As String) As DataTable
        Return dl.GetPermisosForma(CodUsuario, ModuloName, OptionId)
    End Function
#End Region

#Region "Propiedades publicas de la clase Menu"
    

    Private _FechaContable As String
    Public Property FechaContable() As String
        Get
            Return _FechaContable
        End Get
        Set(ByVal value As String)
            _FechaContable = value
        End Set
    End Property
    Private _User As String
    Public Property User() As String
        Get
            Return _User
        End Get
        Set(ByVal value As String)
            _User = value
        End Set
    End Property

    Private _Sucursal As String
    Public Property Sucursal() As String
        Get
            Return _Sucursal
        End Get
        Set(ByVal value As String)
            _Sucursal = value
        End Set
    End Property
    Private _QuickBarList As New List(Of qBar)
    Public Property QuickBarList() As List(Of qBar)
        Get
            Return _QuickBarList
        End Get
        Set(ByVal value As List(Of qBar))
            _QuickBarList = value
        End Set
    End Property


    Public Class qBar
        Private _FormName As String
        Public Property FormName() As String
            Get
                Return _FormName
            End Get
            Set(ByVal value As String)
                _FormName = value
            End Set
        End Property
        Private _QbNew As Integer
        Public Property QbNew() As Integer
            Get
                Return _QbNew
            End Get
            Set(ByVal value As Integer)
                _QbNew = value
            End Set
        End Property

        Private _QbSave As Integer
        Public Property QbSave() As Integer
            Get
                Return _QbSave
            End Get
            Set(ByVal value As Integer)
                _QbSave = value
            End Set
        End Property

        Private _QbEdit As Integer
        Public Property QbEdit() As Integer
            Get
                Return _QbEdit
            End Get
            Set(ByVal value As Integer)
                _QbEdit = value
            End Set
        End Property

        Private _QbDelete As Integer
        Public Property QbDelete() As Integer
            Get
                Return _QbDelete
            End Get
            Set(ByVal value As Integer)
                _QbDelete = value
            End Set
        End Property

        Private _QbUndo As Integer
        Public Property QbUndo() As Integer
            Get
                Return _QbUndo
            End Get
            Set(ByVal value As Integer)
                _QbUndo = value
            End Set
        End Property

        Private _QbFind As Integer
        Public Property QbFind() As Integer
            Get
                Return _QbFind
            End Get
            Set(ByVal value As Integer)
                _QbFind = value
            End Set
        End Property

        Private _QbReport As Integer
        Public Property QbReport() As Integer
            Get
                Return _QbReport
            End Get
            Set(ByVal value As Integer)
                _QbReport = value
            End Set
        End Property
        Private _QbBack As Integer
        Public Property QbBack() As Integer
            Get
                Return _QbBack
            End Get
            Set(ByVal value As Integer)
                _QbBack = value
            End Set
        End Property
        Private _QbNext As Integer
        Public Property QbNext() As Integer
            Get
                Return _QbNext
            End Get
            Set(ByVal value As Integer)
                _QbNext = value
            End Set
        End Property

        Private _QbExcel As Integer
        Public Property QbExcel() As Integer
            Get
                Return _QbExcel
            End Get
            Set(ByVal value As Integer)
                _QbExcel = value
            End Set
        End Property

    End Class
#End Region
End Class
