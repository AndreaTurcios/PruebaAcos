Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class apo_frmDividendosHistorico

    Dim blAporta As New AportacionesBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim entDivLineas As List(Of coo_DividendosLineas)
    Dim cn As New AdmonBLL()

    Private Sub apo_frmRepartoDividendos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES--")
        SpinEdit1.Value = piPeriodo
    End Sub

    Private Sub apo_frmRepartoDividendos_Report_Click() Handles Me.Reporte
        Dim dFecha As DateTime
        Dim dt As DataTable
        Dim msj As String = ""
        Dim Div As New List(Of coo_Dividendos)
        Dim AñoActual As Integer = Year(funCaja.GetFechaContable(1))


        dFecha = CDate("31/12/" & SpinEdit1.EditValue)


        dt = blAporta.rptHistorialDividendo(leSucursal.EditValue, dFecha)

        'If ceTodas.EditValue Then
        '    Dim rpt As New apo_rptRepartoDividendos2
        '    rpt.DataSource = dt
        '    rpt.DataMember = ""
        '    rpt.xrlEmpresa.Text = gsNombre_Empresa
        '    rpt.xrlTitulo.Text = "INFORME DE REPARTO DE DIVIDENDOS POR ASOCIADO PARA EL EJERCICIO " & SpinEdit1.Text
        '    rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text

        '    rpt.xrlPorAportacion.Text = sePorcentaje.EditValue.ToString + " %"
        '    rpt.xrlPorEfectivo.Text = sePorcentajeEfectivo.EditValue.ToString + " %"
        '    rpt.xrlPorLP.Text = sePorcentajeLP.EditValue.ToString + " %"

        '    rpt.xrlUtilidad.Text = Format(seUtilidad.EditValue, "###,##0.00")
        '    rpt.xrlFuneraria.Text = Format(seAyuda.EditValue, "###,##0.00")
        '    rpt.xrlAportaciones.Text = Format(RepartoAportacion, "###,##0.00")
        '    rpt.xrlLP.Text = Format(RepartoEfectivo, "###,##0.00")
        '    rpt.xrlEfectivo.Text = Format(RepartoLP, "###,##0.00")
        '    'rpt.xrlUtilidad.Text = seUtilidad.EditValue
        '    rpt.ShowPreviewDialog()
        'Else

        Dim rpt As New apo_rptRepartoDividendos
        rpt.DataSource = dt
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "INFORME DE REPARTO DE DIVIDENDOS POR ASOCIADO PARA EL EJERCICIO " & SpinEdit1.Text
        rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text

        rpt.xrlPorAportacion.Text = dt.Rows(0).Item("PorAportacion").ToString + " %"
        rpt.xrlPorEfectivo.Text = dt.Rows(0).Item("PorEfectivo").ToString + " %"
        rpt.xrlPorLP.Text = dt.Rows(0).Item("PorLP").ToString + " %"
        Dim Utilidad As Decimal = dt.Rows(0).Item("RepartirFuneraria") + dt.Rows(0).Item("RepartirAportacion") + dt.Rows(0).Item("RepartirLP") + dt.Rows(0).Item("RepartirEfectivo")
        rpt.xrlUtilidad.Text = Format(Utilidad, "###,##0.00")
        rpt.xrlFuneraria.Text = Format(dt.Rows(0).Item("RepartirFuneraria"), "###,##0.00")
        rpt.xrlAportaciones.Text = Format(dt.Rows(0).Item("RepartirAportacion"), "###,##0.00")
        rpt.xrlLP.Text = Format(dt.Rows(0).Item("RepartirLP"), "###,##0.00")
        rpt.xrlEfectivo.Text = Format(dt.Rows(0).Item("RepartirEfectivo"), "###,##0.00")
        rpt.ShowPreviewDialog()
        'End If
    End Sub


End Class
