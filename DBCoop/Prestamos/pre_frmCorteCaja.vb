Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmCorteCaja
    Dim blcaja As New PrestamosBLL()
    Dim EntCorteCaja As New coo_CorteCaja
    Dim EntArqueo As New List(Of coo_CorteCajaArqueo)
    Dim IdCorte As Integer
    Dim funCaja As New DBCoopBL.FuncionesBLL

    Private Sub frmCorteCaja_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCorteCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        deFechaCorte.EditValue = funCaja.GetFechaContable(gIdSucursal)
        leCajero.EditValue = objMenu.User
        leSucursal.EditValue = CInt(gIdSucursal)
        teFacturas.EditValue = 0
        teAnuladas.EditValue = 0
        CargaControles()
        CalcularTotales()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "")
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        Dim EntCaja As coo_CorteCaja
        IdCorte = EntCorteCaja.IdCorte
        EntCaja = blcaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, objMenu.User)
        IdCorte = EntCaja.IdCorte

        If EntCorteCaja.IdCorte > 0 Then
            objTablas.coo_CorteCajaDeleteByPK(EntCorteCaja.IdCorte)
        Else
            EntCorteCaja = blcaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, leCajero.EditValue)
            'IdCorte = EntCaja.IdCorte
            If EntCorteCaja.IdCorte > 0 Then
                objTablas.coo_CorteCajaDeleteByPK(EntCorteCaja.IdCorte)
            End If
        End If
        CargaEntidades()
        Dim entArqueo = New List(Of coo_CorteCajaArqueo)
        For i = 0 To gvArqueo.DataRowCount - 1
            Dim entDetalleA As New coo_CorteCajaArqueo
            With entDetalleA
                .IdCorte = 0  ' Se asigna en la capa de datos
                .IdDenominacion = gvArqueo.GetRowCellValue(i, "IdDenominacion")
                .Cantidad = gvArqueo.GetRowCellValue(i, "Cantidad")
                .Total = gvArqueo.GetRowCellValue(i, "Total")
            End With
            entArqueo.Add(entDetalleA)
        Next

        Dim entCheques = New List(Of coo_CorteCajaCheques)
        For i = 0 To gvCheques.DataRowCount - 1
            Dim entDetalleA As New coo_CorteCajaCheques
            With entDetalleA
                .IdCorte = 0  ' Se asigna en la capa de datos
                .NumeroCuenta = gvCheques.GetRowCellValue(i, "NumeroCuenta")
                .NumeroCheque = gvCheques.GetRowCellValue(i, "NumeroCheque")
                .NombreBanco = gvCheques.GetRowCellValue(i, "NombreBanco")
                .AnombreDe = gvCheques.GetRowCellValue(i, "AnombreDe")
                .Valor = gvCheques.GetRowCellValue(i, "Valor")
            End With
            entCheques.Add(entDetalleA)
        Next

        Dim msj As String = blcaja.InsertaCorteCaja(EntCorteCaja, entArqueo, entCheques)
        If msj = "" Then
            MsgBox("El corte de caja fue guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible guardar el corte de caja{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            Return
        End If
        Dim rpt As New rptCorteCaja
        Dim rpt2 As New rptDetalleCheques


        rpt.DataSource = blcaja.rptCorteCaja(leSucursal.EditValue, deFechaCorte.EditValue, leCajero.EditValue)
        rpt.DataMember = ""
        rpt.xrlCajero.Text = leCajero.Text
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFirma1.Text = leCajero.Text
        rpt.xrlFecha.Text = "AL " & FechaToString(deFechaCorte.EditValue, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataSource = blcaja.rptCorteCajaIngresos(leSucursal.EditValue, leCajero.EditValue, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport2.ReportSource.DataSource = blcaja.rptCorteCajaEgresos(leSucursal.EditValue, leCajero.EditValue, deFechaCorte.EditValue)
        rpt.XrSubreport2.ReportSource.DataMember = ""
        EntCorteCaja = blcaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, leCajero.EditValue)
        rpt.XrSubreport3.ReportSource.DataSource = blcaja.GetArqueoCaja(EntCorteCaja.IdCorte)
        rpt.XrSubreport3.ReportSource.DataMember = ""
        Dim dtCheque As DataTable = blcaja.GetChequesCaja(EntCorteCaja.IdCorte)
        rpt.ShowPreviewDialog()
        If dtCheque.Rows.Count > 0 Then
            rpt2.DataSource = dtCheque
            rpt2.DataMember = ""
            rpt2.xrlCajero.Text = leCajero.Text
            rpt2.xrlEmpresa.Text = gsNombre_Empresa
            rpt2.xrlFecha.Text = "AL " & FechaToString(deFechaCorte.EditValue, deFechaCorte.EditValue)
            rpt2.ShowPreviewDialog()
        End If
        Close()
    End Sub

    Private Sub CargaControles()
        EntCorteCaja = blcaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, leCajero.EditValue)
        If EntCorteCaja.IdUsuario <> "" Then
            teFacturas.EditValue = EntCorteCaja.CantidadFacturas
            teAnuladas.EditValue = EntCorteCaja.FacturasAnuladas
            gcArqueo.DataSource = blcaja.GetArqueoCaja(EntCorteCaja.IdCorte)
            gcCheques.DataSource = blcaja.GetChequesCorteCaja(EntCorteCaja.IdCorte)
        Else
            gcArqueo.DataSource = blcaja.GetDenominaciones()
            gcCheques.DataSource = blCaja.GetChequesCorteCaja(-1)
        End If
        CalcularTotales()
    End Sub

    Private Sub CalcularTotales()
        gvArqueo.SetRowCellValue(gvArqueo.FocusedRowHandle, "Total", gvArqueo.GetRowCellValue(gvArqueo.FocusedRowHandle, "Cantidad") * gvArqueo.GetRowCellValue(gvArqueo.FocusedRowHandle, "Valor"))
        gvArqueo.UpdateTotalSummary()
        teTotal.EditValue = Me.gcTotal.SummaryItem.SummaryValue
    End Sub

    Private Sub gvArqueo_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvArqueo.RowUpdated
        CalcularTotales()
    End Sub

    Private Sub CargaEntidades()
        'Dim entCorteCaja As New coo_CorteCaja
        With entCorteCaja
            .IdSucursal = leSucursal.EditValue
            .IdUsuario = leCajero.EditValue
            .Fecha = deFechaCorte.EditValue
            .CantidadFacturas = teFacturas.EditValue
            .FacturasAnuladas = teAnuladas.EditValue
        End With
    End Sub

    Private Sub deFechaCorte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles deFechaCorte.Validated, leCajero.Validated, leSucursal.Validated
        CargaControles()
    End Sub

End Class