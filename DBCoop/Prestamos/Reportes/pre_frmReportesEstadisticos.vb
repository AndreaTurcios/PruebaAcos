Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmReportesEstadisticos
    Dim bl As New PrestamosBLL
    Private Sub pre_frmReportesEstadisticos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "-- TODAS LAS SUCURSALES --")
    End Sub

    Private Sub pre_frmReportesAuditoria_Reporte() Handles Me.Reporte
        Dim Tit As String = "AL " & FechaToString(deHasta.EditValue, deHasta.EditValue).ToUpper()
        Dim rpt As New pre_rptEstadisticos
        Select Case RadioGroup1.EditValue
            Case 0

                rpt.DataSource = bl.rptInformeEstadisticoFuente(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR FUENTE"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "FUENTE"
                rpt.ShowPreviewDialog()
            Case 1
                rpt.DataSource = bl.rptInformeEstadisticoLinea(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR LINEA"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "LINEA"
                rpt.ShowPreviewDialog()
            Case 2
                rpt.DataSource = bl.rptInformeEstadisticoMunicipio(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR MUNICIPIO"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "MUNICIPIO"
                rpt.ShowPreviewDialog()
            Case 3
                rpt.DataSource = bl.rptInformeEstadisticoTecnico(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR TECNICO"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "TECNICO"
                rpt.ShowPreviewDialog()
            Case 4
                rpt.DataSource = bl.rptInformeEstadisticoTipoPlazo(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR TIPO DE PLAZO"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "TIPO DE PLAZO"
                rpt.ShowPreviewDialog()
            Case 5
                rpt.DataSource = bl.rptInformeEstadisticoSexo(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR SEXO"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "SEXO"
                rpt.ShowPreviewDialog()

            Case 6
                rpt.DataSource = bl.rptInformeEstadisticoEdad(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR EDAD"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "EDAD"
                rpt.ShowPreviewDialog()
            Case 7
                rpt.DataSource = bl.rptInformeEstadisticoFormaPago(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue)
                rpt.DataMember = ""
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlTitulo.Text = "RESUMEN DE CARTERA POR FORMA DE PAGO"
                rpt.xrlFecha.Text = Tit
                rpt.XrlSucursal.Text = leSucursal.Text
                rpt.xrlNombre.Text = "FORMA DE PAGO"
                rpt.ShowPreviewDialog()
        End Select
    End Sub

    Private Sub pre_frmReportesAuditoria_ReporteExcel() Handles Me.ReporteExcel
        Select Case RadioGroup1.EditValue
            Case 0
                DataTableToExcel(bl.rptInformeEstadisticoFuente(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 1
                DataTableToExcel(bl.rptInformeEstadisticoLinea(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 2
                DataTableToExcel(bl.rptInformeEstadisticoMunicipio(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 3
                DataTableToExcel(bl.rptInformeEstadisticoTecnico(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 4
                DataTableToExcel(bl.rptInformeEstadisticoTipoPlazo(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 5
                DataTableToExcel(bl.rptInformeEstadisticoSexo(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 6
                DataTableToExcel(bl.rptInformeEstadisticoEdad(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
            Case 7
                DataTableToExcel(bl.rptInformeEstadisticoFormaPago(leSucursal.EditValue, deHasta.EditValue, chkIncluir.EditValue), "")
        End Select
    End Sub


End Class
