Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmCorteCaja
    ReadOnly blCaja As New CajaBusiness()
    Dim EntCorteCaja As New coo_CorteCaja
    Private Sub frmCorteCaja_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmCorteCaja_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        deFechaCorte.EditValue = blCaja.GetFechaContable(gIdSucursal)
        teFacturas.EditValue = 0
        teAnuladas.EditValue = 0
        'leCajero.EditValue = objMenu.User
        leSucursal.EditValue = CInt(gIdSucursal)
        'leCajero.Properties.ReadOnly = True
        leSucursal.Properties.ReadOnly = True
        CargaControles()
        CalcularTotales()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        'objCombos.adm_Usuarios(leCajero, " TipoUsuario=6", "")
    End Sub

    Private Sub gvArqueo_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvArqueo.RowUpdated
        CalcularTotales()
    End Sub

    Private Sub CalcularTotales()
        gvArqueo.SetRowCellValue(gvArqueo.FocusedRowHandle, "Total", gvArqueo.GetRowCellValue(gvArqueo.FocusedRowHandle, "Cantidad") * gvArqueo.GetRowCellValue(gvArqueo.FocusedRowHandle, "Valor"))
        gvArqueo.UpdateTotalSummary()
        teTotal.EditValue = Me.gcTotal.SummaryItem.SummaryValue
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGuardar.Click

        If Not DatosValidos() Then
            Exit Sub
        End If

        If EntCorteCaja.IdCorte > 0 Then
            objTablas.coo_CorteCajaDeleteByPK(EntCorteCaja.IdCorte)
        Else
            EntCorteCaja = blCaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, objMenu.User)
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

        Dim msj As String = blCaja.InsertaCorteCaja(EntCorteCaja, entArqueo, entCheques)
        If msj = "" Then
            MsgBox("El corte de caja fue guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible guardar el corte de caja{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            Return
        End If
        Dim rpt As New rptCorteCaja
        Dim rpt2 As New rptDetalleCheques
        Dim dtCheque As DataTable = blCaja.GetChequesCorteCaja(EntCorteCaja.IdCorte)

        rpt.DataSource = blCaja.rptCorteCaja(leSucursal.EditValue, deFechaCorte.EditValue, objMenu.User)
        rpt.DataMember = ""
        rpt.xrlCajero.Text = objMenu.User
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlFirma1.Text = objMenu.User
        rpt.xrlFecha.Text = "AL " & FechaToString(deFechaCorte.EditValue, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataSource = blCaja.rptCorteCajaIngresos(leSucursal.EditValue, objMenu.User, deFechaCorte.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""
        rpt.XrSubreport2.ReportSource.DataSource = blCaja.rptCorteCajaEgresos(leSucursal.EditValue, objMenu.User, deFechaCorte.EditValue)
        rpt.XrSubreport2.ReportSource.DataMember = ""
        EntCorteCaja = blCaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, objMenu.User)
        rpt.XrSubreport3.ReportSource.DataSource = blCaja.GetArqueoCaja(EntCorteCaja.IdCorte)
        rpt.XrSubreport3.ReportSource.DataMember = ""
        rpt.ShowPreviewDialog()
        If dtCheque.Rows.Count > 0 Then
            rpt2.DataSource = dtCheque
            rpt2.DataMember = ""
            rpt2.xrlCajero.Text = objMenu.User
            rpt2.xrlEmpresa.Text = gsNombre_Empresa
            rpt2.xrlFecha.Text = "AL " & FechaToString(deFechaCorte.EditValue, deFechaCorte.EditValue)
            rpt2.ShowPreviewDialog()
        End If
        Close()
    End Sub

    Private Sub CargaEntidades()
        'Dim entCorteCaja As New coo_CorteCaja
        With EntCorteCaja
            .IdSucursal = leSucursal.EditValue
            .IdUsuario = objMenu.User
            .Fecha = deFechaCorte.EditValue
            .CantidadFacturas = teFacturas.EditValue
            .FacturasAnuladas = teAnuladas.EditValue
        End With
    End Sub

    Function DatosValidos() As Boolean

        If blCaja.GetFechaContable(gIdSucursal) > Today Then
            MsgBox("El Corte ya esta cerrado", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        Return True
    End Function

    Private Sub CargaControles()
        EntCorteCaja = blCaja.coo_CorteCajaSelectFecha(deFechaCorte.EditValue, objMenu.User)
        If EntCorteCaja.IdUsuario <> "" Then
            teFacturas.EditValue = EntCorteCaja.CantidadFacturas
            teAnuladas.EditValue = EntCorteCaja.FacturasAnuladas
            gcArqueo.DataSource = blCaja.GetArqueoCaja(EntCorteCaja.IdCorte)
            gcCheques.DataSource = blCaja.GetChequesCorteCaja(EntCorteCaja.IdCorte)
        Else
            gcArqueo.DataSource = blCaja.GetDenominaciones()
            gcCheques.DataSource = blCaja.GetChequesCorteCaja(-1)
        End If
        CalcularTotales()
    End Sub

    Private Sub deFechaCorte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles deFechaCorte.Validated
        CargaControles()
    End Sub


    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEliminar.Click
        If MsgBox("Desea eliminar el cheque del corte de caja?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar") = MsgBoxResult.Yes Then
            gvCheques.DeleteRow(gvCheques.FocusedRowHandle)
        End If
    End Sub

    Private Sub deFechaCorte_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deFechaCorte.EditValueChanged

    End Sub
End Class