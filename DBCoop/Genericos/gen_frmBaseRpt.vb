Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraPrinting.Localization
Imports DevExpress.XtraBars
Imports DBCoopBL.MenusBLL
Public Class gen_frmBaseRpt
    Private Sub gen_frmBaseRpt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MyBase.Name <> "gen_frmBaseRpt" Then
            rbMenu.HideQuickBar()
            Localizer.Active = New SpanishEditor
            PreviewLocalizer.Active = New SpanishPrint
            BarStaticItem1.Caption = "Fecha Contable: " & objMenu.FechaContable
            BarStaticItem2.Caption = "Usuario: " & objMenu.User
            BarStaticItem3.Caption = "Sucursal: " & objMenu.Sucursal
            AgregaBarra()
            rbMenu.qbReport.Visibility = BarItemVisibility.Always
            rbMenu.qbExcel.Visibility = BarItemVisibility.Always
            GuardaEstadoBarra()
        End If
    End Sub
    Private Sub gen_frmBaseRpt_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        RestauraEstadoBarra()
    End Sub
    Private Sub gen_frmBaseRpt_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pred As New PredicateClass(MyBase.Name)
        Dim qbar As qBar = objMenu.QuickBarList.Find(AddressOf pred.FindForm)
        objMenu.QuickBarList.Remove(qbar)
        rbMenu.HideQuickBar()
    End Sub
    Public Event Reporte()
    Public Event ExportarExcel()
    Public Event ReporteExcel()

    Public Sub ReporteBase()
        DevExpress.XtraPrinting.CsvExportOptions.FollowReportLayout = False
        RaiseEvent Reporte()
    End Sub
    Public Sub ExcelBase()
        RaiseEvent ReporteExcel()
    End Sub

    Private _Modulo As String = ""
    Public Property Modulo() As String
        Get
            Return _Modulo
        End Get
        Set(ByVal value As String)
            _Modulo = value
        End Set
    End Property
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
                .QbNew = rbMenu.qbNew.Visibility
                .QbSave = rbMenu.qbSave.Visibility
                .QbEdit = rbMenu.qbEdit.Visibility
                .QbDelete = rbMenu.qbDelete.Visibility
                .QbFind = rbMenu.qbFind.Visibility
                .QbReport = rbMenu.qbReport.Visibility
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

    Private Sub gen_frmBaseRpt_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class