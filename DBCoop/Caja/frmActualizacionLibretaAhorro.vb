Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmActualizacionLibretaAhorro
    Dim blCaja As New CajaBusiness()
    Dim EntCuentaAhorro As coo_CuentasAhorro, EntUltMovAhorro As coo_UltMovAhorro, entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    
    Private Sub teNumeroCuenta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroCuenta.ButtonClick
        frmConsultaCuentasAhorro.ShowDialog()
        beNumeroCuenta.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        beNumeroCuenta_Validated(e, New EventArgs)
    End Sub

    Private Sub beNumeroCuenta_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNumeroCuenta.Validated
        If beNumeroCuenta.EditValue = "" Then
            teIdCuenta.EditValue = 0
            Exit Sub
        End If

        teIdCuenta.EditValue = blCaja.GetIdCuentaAhorro(beNumeroCuenta.EditValue)
        
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If EntCuentaAhorro.Numero = "" Then
            MsgBox("No se encuentra el número de cuenta especificado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(EntCuentaAhorro.IdAsociado)
        teNombreCliente.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)

        EntUltMovAhorro = blCaja.coo_UltMovAhorroSelectBy(EntCuentaAhorro.IdCuenta)
        teLineaLibreta.EditValue = EntUltMovAhorro.Linea
        gcMov.DataSource = blCaja.coo_AhorrosSelect(teIdCuenta.EditValue)
        gvMov.MoveLast()
    End Sub

    Private Sub gvMov_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvMov.RowUpdated
        Dim IdCuenta As Integer, IdMov As Integer, Impreso As Boolean
        If gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov")) > -1 Then
            IdCuenta = gvMov.GetFocusedRowCellValue(gvMov.Columns("IdCuenta"))
            IdMov = gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov"))
            Impreso = gvMov.GetFocusedRowCellValue(gvMov.Columns("Impreso"))
            Dim msj As String = blCaja.ActualizaImpresoAhorro(IdCuenta, IdMov, Impreso)
            If msj <> "" Then
                MsgBox(String.Format("Error al actualizar{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            End If
        End If
    End Sub

    Private Sub sbAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAceptar.Click

        If beNumeroCuenta.EditValue = "" Then
            MsgBox("No se ha especificado el número de cuenta", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If teLineaLibreta.EditValue < 1 Or teLineaLibreta.EditValue > entSucursal.LineasLibreta Then
            MsgBox("Número de línea incorrecto", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If gsNombre_Empresa.StartsWith("ACAPRO") Then
            ActualizaLibretaAhorroPorCodigo(teIdCuenta.EditValue, teLineaLibreta.EditValue, entSucursal.LineasLibreta)
            gcMov.DataSource = Nothing
            beNumeroCuenta.Focus()
            Exit Sub
        End If

        Dim NumLinea As Integer = teLineaLibreta.EditValue
        Dim Libreta As New DataTable("Libreta1")
        Libreta.Columns.Add("Linea", GetType(Integer))
        Libreta.Columns.Add("Referencia", GetType(String))
        Libreta.Columns.Add("IdTipo", GetType(Integer))
        Libreta.Columns.Add("Retiro", GetType(Decimal))
        Libreta.Columns.Add("Deposito", GetType(Decimal))
        Libreta.Columns.Add("Saldo", GetType(Decimal))

        'inserto las líneas que hacen falta para llegar a la línea deseada
        Dim Row As DataRow = Nothing
        For i = 1 To NumLinea - 1
            Libreta.Rows.Add(Libreta.NewRow())
            If i = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
        Next
        Dim Pendiente As Boolean
        For j = 1 To 14
            Libreta.Rows.Add(Libreta.NewRow())
        Next
        'recorro las filas a imprimir, 9 de junio se hizo el cheque
        For i = 0 To gvMov.DataRowCount - 1
            If Not gvMov.GetRowCellValue(i, "Impreso") Then
                'se actualiza el registro como impreso
                blCaja.ActualizaImpresoAhorro(teIdCuenta.EditValue, gvMov.GetRowCellValue(i, "IdMov"), True)

                'se verifica que no sea el corte de página, es decir en la línea 12
                If NumLinea = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                    For j = 1 To 3
                        Libreta.Rows.Add(Libreta.NewRow())
                    Next
                End If

                Pendiente = True
                Row = Libreta.NewRow()
                Row("Linea") = NumLinea
                Row("Referencia") = String.Format("{0} {1}", Format(gvMov.GetRowCellValue(i, "Fecha"), "dd/MM/yy"), gvMov.GetRowCellValue(i, "NumeroDoc"))
                Row("IdTipo") = gvMov.GetRowCellValue(i, "IdTipo")
                '
                If "2".IndexOf(gvMov.GetRowCellValue(i, "IdTipo")) <> -1 Then
                    'Row("Retiro") = Nothing
                    Row("Retiro") = gvMov.GetRowCellValue(i, "Valor")
                Else
                    Row("Deposito") = gvMov.GetRowCellValue(i, "Valor")
                    'Row("Deposito") = Nothing
                End If
                Row("Saldo") = gvMov.GetRowCellValue(i, "Saldo")

                Libreta.Rows.Add(Row)
                NumLinea += 1
                'si ya se incluyeron las lineas que se imprimen por libreta, pedirla nuevamente
                If NumLinea = entSucursal.LineasLibreta + 1 Then
                    GeneraImpresion(Libreta)
                    Pendiente = False
                    Libreta.Rows.Clear()
                    NumLinea = 1
                End If
            End If
        Next
        If Pendiente Then
            GeneraImpresion(Libreta)
        End If
        
        gcMov.DataSource = blCaja.coo_AhorrosSelect(teIdCuenta.EditValue)
        gvMov.MoveLast()
    End Sub

    Private Sub sbCambio_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCambio.Click
        If beNumeroCuenta.EditValue = "" Then
            MsgBox("No ha especificado el número de cuenta", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Dim IdCuentaCte As Integer = blCaja.GetIdCuentaAhorro(teNumeroCuenta.EditValue)
        Dim entCuentaAhorro As coo_CuentasAhorro
        Dim entAsociado As coo_Asociados
        entCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        entAsociado = objTablas.coo_AsociadosSelectByPK(entCuentaAhorro.IdAsociado)

        MsgBox("Coloque la nueva libreta en el impresor...", MsgBoxStyle.Information, "Nota")
        Using rpt As New rptCambioLibreta()
            rpt.LoadLayout("Plantillas/NuevaLibretaAhorro.repx")
            rpt.xrlNumero.Text = beNumeroCuenta.EditValue
            rpt.xrlNombre.Text = teNombreCliente.EditValue
            rpt.xrlNumeroAsociado.Text = entAsociado.Numero
            rpt.xrlFecha.Text = entAsociado.FechaIngreso
            rpt.PrinterName = gsImpresorDefault
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End Using

    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimir.Click

        If gvMov.GetFocusedRowCellValue(gvMov.Columns("IdTipo")) <> 2 Then
            Dim rpt As New aho_rptDepositoAhorro
            Dim sDecimal = String.Format("{0:c}", Format(CDec(gvMov.GetFocusedRowCellValue(gvMov.Columns("Valor"))), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            rpt.DataSource = blCaja.rptDepositoAhorroIdMov(gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov")), gvMov.GetFocusedRowCellValue(gvMov.Columns("IdCuenta")))
            rpt.xrlMensaje.Text = blCaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
            rpt.XrPictureBox1.ImageUrl = blCaja.ObtieneParametros.Rows(0).Item("RutaLogo")
            rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(gvMov.GetFocusedRowCellValue(gvMov.Columns("Fecha")), gvMov.GetFocusedRowCellValue(gvMov.Columns("Fecha")))
            rpt.xrlCantidadLetras.Text = Num2Text(Int(gvMov.GetFocusedRowCellValue(gvMov.Columns("Valor")))) & " " & sDecimal & " DÓLARES"
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New aho_rptRetiroAhorro

            Dim sDecimal = String.Format("{0:c}", Format(CDec(gvMov.GetFocusedRowCellValue(gvMov.Columns("Valor"))), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

            rpt.DataSource = blCaja.rptRetiroAhorro(gvMov.GetFocusedRowCellValue(gvMov.Columns("NumeroDoc")), gvMov.GetFocusedRowCellValue(gvMov.Columns("IdCuenta")))
            rpt.xrlMensaje.Text = blCaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
            rpt.XrPictureBox1.ImageUrl = blCaja.ObtieneParametros.Rows(0).Item("RutaLogo")
            rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(gvMov.GetFocusedRowCellValue(gvMov.Columns("Fecha")), gvMov.GetFocusedRowCellValue(gvMov.Columns("Fecha")))
            rpt.xrlCantidadLetras.Text = Num2Text(Int(gvMov.GetFocusedRowCellValue(gvMov.Columns("Valor")))) & " " & sDecimal & " DÓLARES"
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub GeneraImpresion(ByVal Libreta As DataTable)
        MsgBox("Coloque la libreta de ahorros en el impresor", MsgBoxStyle.Information, "Nota")
        Using rpt As New rptLibretaAhorro()
            rpt.LoadLayout("Plantillas/LibretaAhorro.repx")
            rpt.DataSource = Libreta
            rpt.DataMember = ""
            rpt.PrinterName = gsImpresorDefault
            rpt.ShowPrintMarginsWarning = False
            ''rpt.ShowPreviewDialog()
            rpt.PrintDialog()
        End Using
    End Sub

    Private Sub frmActualizacionLibretasAhorro_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class