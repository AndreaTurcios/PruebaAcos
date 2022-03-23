Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class apo_frmRepartoDividendos
    Dim blAporta As New AportacionesBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim entDivLineas As List(Of coo_DividendosLineas)
    Dim cn As New AdmonBLL()
    Dim RepartoAportacion As Decimal, RepartoEfectivo As Decimal, RepartoLP As Decimal, RepartoOtras As Decimal

    Private Sub apo_frmRepartoDividendos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'deHasta.EditValue = Today
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES--")
        SpinEdit1.Value = piPeriodo
        Dim dt As DataTable = objTablas.coo_LineasSelectAll()
        dt.Columns.Add(New DataColumn("Porcentaje", GetType(Decimal)))
        For i = 0 To dt.Rows.Count - 1
            dt.Rows(i).Item("Porcentaje") = 0.0
        Next
        gcLineas.DataSource = dt
    End Sub

    Private Sub apo_frmRepartoDividendos_Report_Click() Handles Me.Reporte
        Dim dFecha As DateTime
        Dim dt As DataTable
        Dim msj As String = ""
        Dim Div As New List(Of coo_Dividendos)
        Dim AñoActual As Integer = Year(funCaja.GetFechaContable(1))
        Dim PorcOtraslienas As Decimal = 0


        gvLineas.UpdateTotalSummary()

        If (sePorcentaje.EditValue + Me.gcPorcenLineas.SummaryItem.SummaryValue) <> 100 Then
            MsgBox("Los porcentajes a distribuir no es igual al 100%", MsgBoxStyle.Information)
            Exit Sub
        End If

        If seUtilidad.EditValue <= 0.0 Then
            MsgBox("Debe de especificar la utilidad", MsgBoxStyle.Information)
            Exit Sub
        End If

        dFecha = CDate("31/12/" & SpinEdit1.EditValue)

        LlenarEntidad()
        dt = blAporta.rptRepartoDividendo(leSucursal.EditValue, dFecha, seUtilidad.EditValue _
        , sePorcentaje.EditValue, seAyuda.EditValue, ceIncluir.EditValue, entDivLineas _
        , SpinEdit1.EditValue, ceTodas.EditValue, seDescuento.EditValue, seDescuentoAPartir.EditValue)




        RepartoAportacion = Round((seUtilidad.EditValue * sePorcentaje.EditValue) / 100, 2)
        Dim PorcE As Decimal, PorcP As Decimal

        For i = 0 To gvLineas.DataRowCount - 1
            If gvLineas.GetRowCellValue(i, "TipoLinea") = 1 Then
                RepartoEfectivo = Round((seUtilidad.EditValue * gvLineas.GetRowCellValue(i, "Porcentaje")) / 100, 2)
                PorcE = gvLineas.GetRowCellValue(i, "Porcentaje")
            End If

            If gvLineas.GetRowCellValue(i, "TipoLinea") = 2 Then
                RepartoLP = Round((seUtilidad.EditValue * gvLineas.GetRowCellValue(i, "Porcentaje")) / 100, 2)
                PorcP = gvLineas.GetRowCellValue(i, "Porcentaje")
            End If

            If gvLineas.GetRowCellValue(i, "TipoLinea") = 3 Then
                PorcOtraslienas += gvLineas.GetRowCellValue(i, "Porcentaje")
            End If
        Next
        RepartoOtras = Round((seUtilidad.EditValue * PorcOtraslienas) / 100, 2)

        If ceTodas.EditValue Then
            Dim rpt As New apo_rptRepartoDividendos2
            rpt.DataSource = dt
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlTitulo.Text = "INFORME DE REPARTO DE DIVIDENDOS POR ASOCIADO PARA EL EJERCICIO " & SpinEdit1.Text
            rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text

            rpt.xrlPorAportacion.Text = sePorcentaje.EditValue.ToString + " %"
            rpt.xrlPorEfectivo.Text = PorcP.ToString + " %"
            rpt.xrlPorLP.Text = PorcE.ToString + " %"
            rpt.xrlPorOtr.Text = PorcOtraslienas.ToString + " %"
            rpt.xrlUtilidad.Text = Format(seUtilidad.EditValue, "$ ###,##0.00")
            rpt.xrlFuneraria.Text = Format(seAyuda.EditValue, "$ ###,##0.00")
            rpt.xrlAportaciones.Text = Format(RepartoAportacion, "$ ###,##0.00")
            rpt.xrlLP.Text = Format(RepartoEfectivo, "$ ###,##0.00")
            rpt.xrlEfectivo.Text = Format(RepartoLP, "$ ###,##0.00")
            rpt.xrlOtras.Text = Format(RepartoOtras, "$ ###,##0.00")
            'rpt.xrlUtilidad.Text = seUtilidad.EditValue
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New apo_rptRepartoDividendos
            rpt.DataSource = dt
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlTitulo.Text = "INFORME DE REPARTO DE DIVIDENDOS POR ASOCIADO PARA EL EJERCICIO " & SpinEdit1.Text
            rpt.xrlSucursal.Text = "SUCURSAL: " & leSucursal.Text

            rpt.xrlPorAportacion.Text = sePorcentaje.EditValue.ToString + " %"
            rpt.xrlPorEfectivo.Text = sePorcentajeEfectivo.EditValue.ToString + " %"
            rpt.xrlPorLP.Text = sePorcentajeLP.EditValue.ToString + " %"

            rpt.xrlUtilidad.Text = Format(seUtilidad.EditValue, "###,##0.00")
            rpt.xrlFuneraria.Text = Format(seAyuda.EditValue, "###,##0.00")
            rpt.xrlAportaciones.Text = Format(RepartoAportacion, "###,##0.00")
            rpt.xrlLP.Text = Format(RepartoLP, "###,##0.00")
            rpt.xrlEfectivo.Text = Format(RepartoEfectivo, "###,##0.00")
            'rpt.xrlUtilidad.Text = seUtilidad.EditValue
            rpt.ShowPreviewDialog()
        End If


            If MsgBox("Desea aplicar los Dividendos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                Dim cComprobante As String
                cComprobante = "RD" + (SpinEdit1.EditValue).ToString

                If blAporta.SiExisteRepDiv(SpinEdit1.EditValue) > 0 Then
                    MsgBox("Ya existe una aplicacion de Dividendos para el Periodo", MsgBoxStyle.Information)
                    Exit Sub
                End If

                If MsgBox("Favor Confirme nuevamente el Proceso?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

                    For Each MiDataRow As DataRow In dt.Rows
                        Dim entDividendos As New coo_Dividendos
                        entDividendos.IdAsociado = MiDataRow("IdAsociado")
                        entDividendos.Periodo = SpinEdit1.EditValue
                        entDividendos.SaldoActualAportacion = MiDataRow("SaldoActualAportacion")
                        entDividendos.PorcentajeAportacion = MiDataRow("PorcentajeAportacion")
                        entDividendos.TotalPagarAportacion = MiDataRow("TotalPagarAportacion")
                        entDividendos.SaldoInteresEfectivo = MiDataRow("SaldoInteresEfectivo")
                        entDividendos.PorcentajeEfectivo = MiDataRow("PorcentajeEfectivo")
                        entDividendos.TotalPagarEfectivo = MiDataRow("TotalPagarEfectivo")
                        entDividendos.SaldoInteresLP = MiDataRow("SaldoInteresLP")
                        entDividendos.PorcentajeLP = MiDataRow("PorcentajeLP")
                    entDividendos.TotalPagarLP = MiDataRow("TotalPagarLP")
                    entDividendos.SaldoOtrasLineas = MiDataRow("SaldoOtrasLineas")
                    entDividendos.TotalPagarOtrasLineas = MiDataRow("OtrasLineas")
                        entDividendos.SujetoRetencion = MiDataRow("SujetoRetencion")
                        entDividendos.Retencion = MiDataRow("Retencion")
                        entDividendos.SubTotal = MiDataRow("SubTotal")
                    entDividendos.AhorroFunerario = MiDataRow("AhorroFunerario")
                    entDividendos.Papeleria = MiDataRow("Papeleria")
                        entDividendos.Total = MiDataRow("Total")
                        entDividendos.RepartirAportacion = RepartoAportacion
                        entDividendos.PorAportacion = sePorcentaje.EditValue
                        entDividendos.RepartirEfectivo = RepartoEfectivo
                        entDividendos.PorEfectivo = sePorcentajeEfectivo.EditValue
                        entDividendos.RepartirLP = RepartoLP
                    entDividendos.PorLP = sePorcentajeLP.EditValue
                    entDividendos.PorOtrasLineas = PorcOtraslienas
                    entDividendos.RepartirFuneraria = seAyuda.EditValue
                    entDividendos.RepartirOtras = RepartoOtras
                        entDividendos.CreadoPor = objMenu.User
                        entDividendos.FechaHoraCreacion = Now
                        Div.Add(entDividendos)


                    Next

                    msj = blAporta.InsertaDividendos(Div)

                    If msj = "" Then
                        MsgBox("La Aplicacion de Dividendos fue realizada con éxito", MsgBoxStyle.Information)
                    Else
                        MsgBox("No fue posible aplicar los Dividendos" + Chr(13) + msj, MsgBoxStyle.Critical, "Error")
                    End If

                End If
            End If
    End Sub

    Private Sub LlenarEntidad()
        entDivLineas = New List(Of coo_DividendosLineas)
        For i = 0 To gvLineas.DataRowCount - 1
            Dim entDetalle As New coo_DividendosLineas
            With entDetalle
                .Periodo = SpinEdit1.EditValue
                .IdLinea = gvLineas.GetRowCellValue(i, "IdLinea")
                .Porcentaje = gvLineas.GetRowCellValue(i, "Porcentaje")

            End With
            entDivLineas.Add(entDetalle)
        Next



    End Sub
    'Private Sub apo_frmRepartoDividendos_ReporteExcel() Handles Me.ReporteExcel
    '    Dim dFecha As DateTime
    '    dFecha = CDate("31/12/" & SpinEdit1.EditValue)
    '    DataTableToExcel(blAporta.rptRepartoDividendo(leSucursal.EditValue, dFecha, seUtilidad.EditValue _
    '    , sePorcentaje.EditValue, sePorcentajeLP.EditValue, sePorcentajeEfectivo.EditValue, seAyuda.EditValue, ceIncluir.EditValue), "")
    'End Sub

End Class
