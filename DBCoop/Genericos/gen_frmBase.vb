Imports DevExpress.XtraGrid.Localization
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraBars
Imports DBCoopBL.MenusBLL

Public Class gen_frmBase
    Public Enum DbModeType
        insert = 0
        update = 1
        query = 2
    End Enum

    Dim dtPermisos As DataTable
    Public Event Nuevo()
    Public Event Guardar()
    Public Event Editar()
    Public Event Revertir()
    Public Event Eliminar()
    Public Event Consulta()
    Public Event Reporte()
    Public Event ReporteExcel()

    Private Sub gen_frmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MyBase.Name <> "gen_frmBase" Then
            rbMenu.HideQuickBar()
            GridLocalizer.Active = New SpanishGrid
            Localizer.Active = New SpanishEditor
            PreviewLocalizer.Active = New SpanishPrint
            If _Modulo <> "" Then   'cuando esta propiedad tenga valor es porque es un mantenimiento
                dtPermisos = objMenu.GetPermisosForma(objMenu.User, _Modulo, _OptionId)
                AllowInsert = dtPermisos.Rows(0).Item("snInsert")
                AllowDelete = dtPermisos.Rows(0).Item("snDelete")
                AllowEdit = dtPermisos.Rows(0).Item("snEdit")
                AgregaBarra()
                MostrarModoInicial()
            End If
            BarStaticItem1.Caption = "Fecha Contable: " & objMenu.FechaContable
            BarStaticItem2.Caption = "Usuario: " & objMenu.User
            BarStaticItem3.Caption = "Sucursal: " & objMenu.Sucursal
        End If
    End Sub

    Private Sub gen_frmBase_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        RestauraEstadoBarra()
    End Sub

    Private Sub gen_frmBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pred As New PredicateClass(MyBase.Name)
        Dim qbar As qBar = objMenu.QuickBarList.Find(AddressOf pred.FindForm)
        objMenu.QuickBarList.Remove(qbar)
        rbMenu.HideQuickBar()
    End Sub

    Private _OptionId As String
    Public Property OptionId() As String
        Get
            Return _OptionId
        End Get
        Set(ByVal value As String)
            _OptionId = value
        End Set
    End Property

    Private _Modulo As String = ""
    Public Property Modulo() As String
        Get
            Return _Modulo
        End Get
        Set(ByVal value As String)
            _Modulo = value
        End Set
    End Property

    Public Sub NuevoBase()
        If dtPermisos.Rows(0).Item("SnInsert") = False Then
            MsgBox("Según las politicas de seguridad no le está permitido agregar información" & Chr(13) _
                   & "Para mayor información sobre ésta política consulte con el administrador", MsgBoxStyle.Information)
        Else
            MostrarModoInsertar()
            RaiseEvent Nuevo()
        End If
    End Sub
    Public Sub GuardarBase()
        RaiseEvent Guardar()
    End Sub
    Public Sub EditarBase()
        If dtPermisos.Rows(0).Item("SnEdit") = False Then
            MsgBox("Según las politicas de seguridad no le está permitido editar información" & Chr(13) _
                   & "Para mayor información sobre ésta política consulte con el administrador", MsgBoxStyle.Information)
        Else
            MostrarModoEditar()
            RaiseEvent Editar()
        End If
    End Sub
    Public Sub EliminarBase()
        If dtPermisos.Rows(0).Item("SnDelete") = False Then
            MsgBox("Según las politicas de seguridad no le está permitido eliminar información" & Chr(13) _
                   & "Para mayor información sobre ésta política consulte con el administrador", MsgBoxStyle.Information)
        Else
            RaiseEvent Eliminar()
        End If
    End Sub
    Public Sub RevertirBase()
        MostrarModoInicial()
        RaiseEvent Revertir()
    End Sub
    Public Sub ConsultarBase()
        MostrarModoInicial()
        RaiseEvent Consulta()
    End Sub
    Public Sub ReporteBase()
        DevExpress.XtraPrinting.CsvExportOptions.FollowReportLayout = False
        RaiseEvent Reporte()
    End Sub
    Public Sub ExcelBase()
        RaiseEvent ReporteExcel()
    End Sub

    Private _DbMode As Integer
    Public Property DbMode() As Integer
        Get
            Return _DbMode
        End Get
        Set(ByVal value As Integer)
            _DbMode = value
        End Set
    End Property
    Private _TipoFormulario As Integer = 0
    Public Property TipoFormulario() As Integer
        Get
            Return _TipoFormulario
        End Get
        Set(ByVal value As Integer)
            _TipoFormulario = value
        End Set
    End Property
    Private _AllowInsert As Boolean
    Public Property AllowInsert() As Boolean
        Get
            Return _AllowInsert
        End Get
        Set(ByVal value As Boolean)
            _AllowInsert = value
        End Set
    End Property
    Private _AllowDelete As Boolean
    Public Property AllowDelete() As Boolean
        Get
            Return _AllowDelete
        End Get
        Set(ByVal value As Boolean)
            _AllowDelete = value
        End Set
    End Property
    Private _AllowEdit As Boolean
    Public Property AllowEdit() As Boolean
        Get
            Return _AllowEdit
        End Get
        Set(ByVal Value As Boolean)
            _AllowEdit = Value
        End Set
    End Property
    Public Sub MostrarModoInicial()
        With rbMenu
            If TipoFormulario < 2 Then  ' para formularios 0 y 1, son los mantenimientos principales
                .qbNew.Visibility = BarItemVisibility.Always
                .qbSave.Visibility = BarItemVisibility.Never
                .qbEdit.Visibility = BarItemVisibility.Always
                .qbUndo.Visibility = BarItemVisibility.Never
                .qbDelete.Visibility = BarItemVisibility.Always
                .qbFind.Visibility = BarItemVisibility.Always
                .qbReport.Visibility = BarItemVisibility.Always
                .qbExcel.Visibility = BarItemVisibility.Always
            End If

            If TipoFormulario = 2 Then 'formulario de tipo lista, se muestra solo el boton de eliminar y reporte
                .qbNew.Visibility = BarItemVisibility.Never
                .qbEdit.Visibility = BarItemVisibility.Never
                .qbSave.Visibility = BarItemVisibility.Never
                .qbDelete.Visibility = BarItemVisibility.Always
                .qbReport.Visibility = BarItemVisibility.Always
                .qbFind.Visibility = BarItemVisibility.Never
                .qbUndo.Visibility = BarItemVisibility.Never
                .qbExcel.Visibility = BarItemVisibility.Always
            End If
            If TipoFormulario = 3 Then 'formulario con botón solo para guardar
                .qbNew.Visibility = BarItemVisibility.Never
                .qbSave.Visibility = BarItemVisibility.Always
                .qbEdit.Visibility = BarItemVisibility.Never
                .qbUndo.Visibility = BarItemVisibility.Never
                .qbDelete.Visibility = BarItemVisibility.Never
                .qbFind.Visibility = BarItemVisibility.Never
                .qbReport.Visibility = BarItemVisibility.Never
                .qbExcel.Visibility = BarItemVisibility.Never
            End If
            If TipoFormulario = 0 Then 'solamente para el formulario 0 se deben mostrar los botones de navegación 
                .qbBack.Visibility = BarItemVisibility.Always
                .qbNext.Visibility = BarItemVisibility.Always
            Else
                .qbBack.Visibility = BarItemVisibility.Never
                .qbNext.Visibility = BarItemVisibility.Never
            End If
        End With
        DbMode = DbModeType.update
        GuardaEstadoBarra()
    End Sub
    Public Sub MostrarModoInsertar()
        DbMode = DbModeType.insert
        With rbMenu
            .qbNew.Visibility = BarItemVisibility.Never
            .qbSave.Visibility = BarItemVisibility.Always
            .qbEdit.Visibility = BarItemVisibility.Never
            .qbUndo.Visibility = BarItemVisibility.Always
            .qbDelete.Visibility = BarItemVisibility.Never
            .qbFind.Visibility = BarItemVisibility.Never
            .qbReport.Visibility = BarItemVisibility.Never
            .qbBack.Visibility = BarItemVisibility.Never
            .qbNext.Visibility = BarItemVisibility.Never
            .qbExcel.Visibility = BarItemVisibility.Never
        End With
        GuardaEstadoBarra()
    End Sub
    Public Sub MostrarModoEditar()
        DbMode = DbModeType.update
        With rbMenu
            .qbNew.Visibility = BarItemVisibility.Never
            .qbSave.Visibility = BarItemVisibility.Always
            .qbEdit.Visibility = BarItemVisibility.Never
            .qbUndo.Visibility = BarItemVisibility.Always
            .qbDelete.Visibility = BarItemVisibility.Never
            .qbFind.Visibility = BarItemVisibility.Never
            .qbReport.Visibility = BarItemVisibility.Never
            .qbBack.Visibility = BarItemVisibility.Always
            .qbNext.Visibility = BarItemVisibility.Always
            .qbExcel.Visibility = BarItemVisibility.Never
        End With
        GuardaEstadoBarra()
    End Sub
    Private _rbMenu As New BravioMain
    Public Property rbMenu() As BravioMain
        Get
            Return _rbMenu
        End Get
        Set(ByVal value As BravioMain)
            _rbMenu = value
        End Set
    End Property
    Private Class PredicateClass
        Private formName As String
        Public Sub New(ByVal formName As String)
            Me.formName = formName
        End Sub

        Public Function FindForm(ByVal qb As qBar) As Boolean
            Return qb.FormName = Me.formName
        End Function
    End Class
    Private Sub AgregaBarra()
        Dim qbar As New qBar
        With qbar
            .FormName = MyBase.Name
            .QbNew = 1
            .QbSave = 1
            .QbEdit = 1
            .QbDelete = 1
            .QbUndo = 1
            .QbFind = 1
            .QbReport = 1
            .QbBack = 1
            .QbNext = 1
            .QbExcel = 1
        End With
        objMenu.QuickBarList.Add(qbar)
    End Sub
    Private Sub GuardaEstadoBarra()
        Dim pred As New PredicateClass(MyBase.Name)
        Dim qbar As qBar = objMenu.QuickBarList.Find(AddressOf pred.FindForm)
        If Not qbar Is Nothing Then
            With qbar
                .QbDelete = rbMenu.qbDelete.Visibility
                .QbEdit = rbMenu.qbEdit.Visibility
                .QbFind = rbMenu.qbFind.Visibility
                .QbNew = rbMenu.qbNew.Visibility
                .QbReport = rbMenu.qbReport.Visibility
                .QbSave = rbMenu.qbSave.Visibility
                .QbUndo = rbMenu.qbUndo.Visibility
                .QbBack = rbMenu.qbBack.Visibility
                .QbNext = rbMenu.qbNext.Visibility
                .QbExcel = rbMenu.qbExcel.Visibility
            End With
        End If
    End Sub
    Private Sub RestauraEstadoBarra()
        Dim pred As New PredicateClass(MyBase.Name)
        Dim qbar As qBar = objMenu.QuickBarList.Find(AddressOf pred.FindForm)
        If Not qbar Is Nothing Then
            With qbar
                rbMenu.qbDelete.Visibility = .QbDelete
                rbMenu.qbEdit.Visibility = .QbEdit
                rbMenu.qbFind.Visibility = .QbFind
                rbMenu.qbNew.Visibility = .QbNew
                rbMenu.qbReport.Visibility = .QbReport
                rbMenu.qbSave.Visibility = .QbSave
                rbMenu.qbUndo.Visibility = .QbUndo
                rbMenu.qbBack.Visibility = .QbBack
                rbMenu.qbNext.Visibility = .QbNext
                rbMenu.qbExcel.Visibility = .QbExcel
            End With
        End If
    End Sub
    Private Sub gen_frmBase_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape And Not rbMenu.qbUndo.Visibility = BarItemVisibility.Always Then
            Close()
        End If
    End Sub

End Class