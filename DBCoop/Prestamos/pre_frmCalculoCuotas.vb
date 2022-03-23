Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports System.Math
Imports System.Diagnostics
Public Class pre_frmCalculoCuotas
    ReadOnly cn As New AdmonBLL()
    Dim dtParam As DataTable = cn.ObtieneParametros()

    Private Sub pre_frmCalculoCuotas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        deFecha.EditValue = Today
        deFechaPrimerPago.EditValue = Today
        teMonto.EditValue = 0.0

        teCuotaAportacion.EditValue = dtParam.Rows(0).Item("CuotaAportacion")
        ceIncluirSeguro.Checked = dtParam.Rows(0).Item("TasaSeguro") > 0
        teCuotaAhorro.EditValue = 0.0
        teTasaManejo.EditValue = 0.0
        chkSinCentavos.Checked = False
        If gsNombre_Empresa.StartsWith("ACOCONCHA") Then
            rgTipoCuota.EditValue = 2
            ceIncluirSeguro.Checked = False
        End If
    End Sub

    Private Sub pre_frmCalculoCuotas_Report_Click() Handles Me.Reporte
        Dim Plan As New DataTable
        CreaTabla(Plan)
        Dim rpt As New pre_rptPlanPago
        rpt.DataSource = plan
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlMontoOtorgado.Text = Format(teMonto.EditValue, "###,##0.00")
        rpt.xrlNumeroCuotas.Text = seNumCuotas.EditValue
        rpt.xrlTasa.Text = Format(seTasa.EditValue, "##0.00")

        Dim FormaPago As String = seNumCuotas.Text + " CUOTAS MENSUALES"
        If rgFormaPago.EditValue = 1 And seNumCuotas.EditValue = 1 Then
            FormaPago = "AL VENCIMIENTO"
        End If
        If rgFormaPago.EditValue = 2 And seFrecuencia.EditValue = 1 Then
            FormaPago = "CUOTAS DIARIAS"
        End If
        If rgFormaPago.EditValue = 2 And seFrecuencia.EditValue = 7 Then
            FormaPago = "CUOTAS SEMANALES"
        End If
        If rgFormaPago.EditValue = 1 And seFrecuencia.EditValue = 6 Then
            FormaPago = "CUOTAS SEMESTRALES"
        End If
        If rgFormaPago.EditValue = 1 And seFrecuencia.EditValue = 12 Then
            FormaPago = "CUOTAS ANUALES"
        End If
        rpt.xrlFormaPago.Text = FormaPago
        rpt.xrlFechaOtorgado.Text = deFecha.EditValue
        rpt.xrlNombreAsociado.Text = teNombre.EditValue
        rpt.xrlUsuario.Text = objMenu.User
        rpt.ShowPreviewDialog()

        plan.Dispose()
        rpt.Dispose()

    End Sub

    Private Sub pre_frmCalculoCuotas_ReporteExcel() Handles Me.ReporteExcel
        Dim Plan As New DataTable
        CreaTabla(plan)
        DataTableToExcel(Plan, "")
    End Sub
    Private Sub CreaTabla(ByRef Plan As DataTable)
        If seNumCuotas.EditValue <= 0 Or seFrecuencia.EditValue <= 0 Or seTasa.EditValue <= 0 Or teMonto.EditValue <= 0 Then
            MsgBox("Falta información para poder generar el plan de cuotas", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        Dim pres As New Prestamo()

        With pres
            .CapitalInicial = teMonto.EditValue
            .NumeroCuotas = seNumCuotas.EditValue
            .DiasPorAnio = giDiasPorAnioPrestamo
            .TasaInteresAnual = seTasa.EditValue
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFecha.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .TipoCuota = rgTipoCuota.EditValue
            .ImporteCuotaAhorro = teCuotaAhorro.EditValue
            .ImporteCuotaManejo = teTasaManejo.EditValue
            .ImporteCuotaAportacion = teCuotaAportacion.EditValue
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = deFechaPrimerPago.EditValue
            .CuotaSinCentavos = chkSinCentavos.EditValue

            If ceIncluirSeguro.EditValue = True Then
                .TasaSeguroDeuda = dtParam.Rows(0).Item("TasaSeguro")
            End If
            .CalculaPlanPagos()
        End With
        Plan.Columns.Add("NumeroCuota", GetType(Integer))
        Plan.Columns.Add("FechaPago", GetType(DateTime))
        Plan.Columns.Add("ImporteCuota", GetType(Decimal))
        Plan.Columns.Add("ImporteCuotaSeguro", GetType(Decimal))
        Plan.Columns.Add("ImporteCuotaAportacion", GetType(Decimal))
        Plan.Columns.Add("ImporteCuotaAhorro", GetType(Decimal))
        Plan.Columns.Add("ImporteCuotaManejo", GetType(Decimal))
        Plan.Columns.Add("ImporteInteres", GetType(Decimal))
        Plan.Columns.Add("ImporteCapital", GetType(Decimal))
        Plan.Columns.Add("ImporteSaldo", GetType(Decimal))
        Dim dr As DataRow
        For Each detalle As Cuota In pres.PlanPago
            dr = Plan.NewRow()
            dr("NumeroCuota") = detalle.NumeroCuota
            dr("FechaPago") = detalle.FechaPago
            dr("ImporteCuota") = detalle.ImporteCuota
            dr("ImporteCuotaSeguro") = detalle.ImporteCuotaSeguro
            dr("ImporteCuotaAportacion") = detalle.ImporteCuotaAportacion
            dr("ImporteCuotaAhorro") = detalle.ImporteCuotaAhorro
            dr("ImporteCuotaManejo") = detalle.ImporteCuotaManejo
            dr("ImporteInteres") = detalle.ImporteInteres
            dr("ImporteCapital") = detalle.ImporteCapital
            dr("ImporteSaldo") = detalle.ImporteSaldo
            Plan.Rows.Add(dr)
        Next
    End Sub

    Private Sub CalculaCuotaAhorro()
        'If seNumCuotas.EditValue > 0.0 Then
        '    teCuotaAhorro.EditValue = Decimal.Round(teMonto.EditValue * (seTasa.EditValue / 100) / seNumCuotas.EditValue, 2)
        'End If
    End Sub

    Private Sub teMonto_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMonto.EditValueChanged
        CalculaCuotaAhorro()
    End Sub

    Private Sub seTasa_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seTasa.EditValueChanged
        CalculaCuotaAhorro()
    End Sub

    Private Sub seNumCuotas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seNumCuotas.EditValueChanged
        CalculaCuotaAhorro()
    End Sub

    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

 
End Class
