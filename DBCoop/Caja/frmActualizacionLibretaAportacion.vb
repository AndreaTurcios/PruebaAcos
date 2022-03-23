Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmActualizacionLibretaAportacion
    Dim blCaja As New CajaBusiness(), entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub teNumeroAsociado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        beNumeroAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumeroAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub teNumeroAsociado_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNumeroAsociado.Validated
        If beNumeroAsociado.EditValue = "" Then
            Exit Sub
        End If

        Dim EntAsociado As coo_Asociados = blCaja.coo_AsociadosSelectNumero(beNumeroAsociado.EditValue)
        If EntAsociado.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With EntAsociado
            teIdAsociado.EditValue = EntAsociado.IdAsociado
            teNombreCliente.EditValue = .Nombres + " " + .Apellidos
            teLineaLibreta.EditValue = blCaja.GetUltLineaAporta(EntAsociado.IdAsociado) + 1
            gcMov.DataSource = blCaja.coo_AportacionesSelect(EntAsociado.IdAsociado)
            gvMov.MoveLast()
        End With
    End Sub
    Private Sub gvMov_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvMov.RowUpdated
        Dim msj As String = ""
        Dim IdAsociado As Integer, IdMov As Integer, Impreso As Boolean
        If gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov")) > -1 Then
            IdAsociado = gvMov.GetFocusedRowCellValue(gvMov.Columns("IdAsociado"))
            IdMov = gvMov.GetFocusedRowCellValue(gvMov.Columns("IdMov"))
            Impreso = gvMov.GetFocusedRowCellValue(gvMov.Columns("Impreso"))
            msj = blCaja.ActualizaImpresoAportacion(IdAsociado, IdMov, Impreso)
            If msj <> "" Then
                MsgBox(String.Format("Error al actualizar{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
    Private Sub sbAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbAceptar.Click
        If beNumeroAsociado.EditValue = "" Then
            MsgBox("Numero de asociado en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If teLineaLibreta.EditValue < 1 Or teLineaLibreta.EditValue > entSucursal.LineasLibreta Then
            MsgBox("Número de línea incorrecto", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If gsNombre_Empresa.StartsWith("ACAPRO") Then
            ActualizaLibretaAportaPorCodigo(teIdAsociado.EditValue, teLineaLibreta.EditValue, entSucursal.LineasLibreta)
            gcMov.DataSource = Nothing
            beNumeroAsociado.Focus()
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
                'se deben insertar 3 lineas
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
        Next
        Dim Pendiente As Boolean
        For j = 1 To 14
            Libreta.Rows.Add(Libreta.NewRow())
        Next
        'recorro las filas a imprimir
        For i = 0 To gvMov.DataRowCount - 1
            If Not gvMov.GetRowCellValue(i, "Impreso") Then
                'se actualiza el registro como impreso                
                blCaja.ActualizaImpresoAportacion(teIdAsociado.EditValue, gvMov.GetRowCellValue(i, "IdMov"), True)

                If NumLinea = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                    For j = 1 To 3
                        Libreta.Rows.Add(Libreta.NewRow())
                    Next
                End If

                Pendiente = True
                Row = Libreta.NewRow()
                Row("Linea") = NumLinea
                Row("Referencia") = String.Format("{0} {1}", Format(gvMov.GetRowCellValue(i, "Fecha"), "dd/MM/yy"), gvMov.GetRowCellValue(i, "NumeroDoc"))
                '
                If gvMov.GetRowCellValue(i, "Abono") > 0 Then
                    'Row("Retiro") = Nothing
                    Row("Deposito") = gvMov.GetRowCellValue(i, "Abono")
                Else
                    Row("Retiro") = gvMov.GetRowCellValue(i, "Cargo")
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

        gcMov.DataSource = blCaja.coo_AportacionesSelect(teIdAsociado.EditValue)
        gvMov.MoveLast()
    End Sub
   
    Private Sub sbCambio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCambio.Click
        If beNumeroAsociado.EditValue = "" Then
            MsgBox("Numero de asociado en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim entAsociado As coo_Asociados
        entAsociado = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        MsgBox("Coloque la nueva libreta en el impresor...", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Nota")
        Dim rpt As New rptCambioLibreta
        rpt.LoadLayout("Plantillas/NuevaLibretaAportacion.repx")
        rpt.xrlNumero.Text = beNumeroAsociado.EditValue
        rpt.xrlNombre.Text = teNombreCliente.EditValue
        rpt.xrlNumeroAsociado.Text = entAsociado.Numero
        rpt.xrlFecha.Text = entAsociado.FechaIngreso
        rpt.PrinterName = gsImpresorDefault
        rpt.PrintDialog()
    End Sub
    Private Sub GeneraImpresion(ByVal Libreta As DataTable)
        MsgBox("Coloque la libreta de aportaciones en el impresor", MsgBoxStyle.Information, "Nota")
        Using rpt As New rptLibretaAhorro()
            rpt.LoadLayout("Plantillas/LibretaAportacion.repx")
            rpt.DataSource = Libreta
            rpt.DataMember = ""
            rpt.PrinterName = gsImpresorDefault
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End Using
    End Sub

    
    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimir.Click
        Dim rpt As New apo_rptComprobAportacion
        Dim Monto As Decimal = gvMov.GetFocusedRowCellValue("Cargo") + gvMov.GetFocusedRowCellValue("Abono")
        Dim sDecimal = String.Format("{0:c}", Monto)
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        rpt.DataSource = blCaja.rptIngresoAportacion(gvMov.GetFocusedRowCellValue("NumeroDoc"), teIdAsociado.EditValue)
        rpt.DataMember = ""
        rpt.XrPictureBox1.ImageUrl = blCaja.ObtieneParametros.Rows(0).Item("RutaLogo")
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(gvMov.GetFocusedRowCellValue("Fecha"), gvMov.GetFocusedRowCellValue("Fecha"))
        rpt.xrlCantidadLetras.Text = String.Format("{0} {1} DÓLARES", Num2Text(Int(Monto)), sDecimal)
        rpt.xrlMensaje.Text = blCaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
        rpt.PrinterName = gsImpresorDefault
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub frmActualizacionLibretas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
End Class