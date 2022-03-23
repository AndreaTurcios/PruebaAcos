Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports DevExpress.XtraGrid.Columns
Public Class com_frmCompras
    Dim Header As com_Compras
    Dim Detalle As List(Of com_ComprasDetalle)
    Dim blCaja As New CajaBusiness()
    Dim entProducto As inv_Productos
    Dim _IdLiquidacion As Integer = 0
    Dim _CreadoPor As String = ""
    Dim bl As New AdmonBLL()

    Public Property IdLiquidacion() As Integer
        Get
            Return _IdLiquidacion
        End Get
        Set(ByVal value As Integer)
            _IdLiquidacion = value
        End Set
    End Property
    Public Property CreadoPor() As String
        Get
            Return _CreadoPor
        End Get
        Set(ByVal value As String)
            _CreadoPor = value
        End Set
    End Property


    Private Sub com_frmCompras_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        objCombos.com_TiposComprobante(leTipoDocto)
        objCombos.coo_TiposLiquidacion(leTipoLiquidacion)
        objCombos.coo_Rubros(leRubro, "")
        objCombos.coo_CuentasGastos(leGasto, leRubro.EditValue)
        com_frmCompras_Nuevo()
        teCorrelativo.Properties.ReadOnly = True
    End Sub
    Private Sub com_frmCompras_Nuevo()
        ActivarControles(True)
        Header = New com_Compras
        gc.DataSource = bl.com_ObtenerCompraDetalle(-1)

        beProveedor.EditValue = ""
        teSerie.EditValue = ""
        teNumero.EditValue = ""
        deFechaCompra.EditValue = Today
        deFechaContable.EditValue = Today
        teIva.EditValue = 0.0
        tePercepcion.EditValue = 0.0
        teTotal.EditValue = 0.0
        teNombre.EditValue = ""
        teGiro.EditValue = ""
        teNIT.EditValue = ""
        teNRC.EditValue = ""
        teSerie.Focus()
    End Sub
    Private Sub com_frmCompras_Guardar() Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()

        Dim msj As String = bl.com_InsertaCompra(Header, Detalle)
        If msj = "" Then
            MsgBox("El documento ha sido guardado con éxito", MsgBoxStyle.Information, "Nota")
        Else
            MsgBox(String.Format("NO FUE POSIBLE GUARDAR EL DOCUMENTO{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If
        Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim msj As String = ""
        Dim SaldoProveedor As Decimal = 0.0
        Dim IdComprobante As Integer = 0

        If teNumero.EditValue = "" OrElse teSerie.EditValue = "" Then
            msj = "Debe de especificar la serie y número de documento"
        End If
        If beProveedor.EditValue = "" Then
            msj = "Debe de especificar el código del proveedor"
        End If
        If teNRC.EditValue = "" Or teNIT.EditValue = "" Then
            msj = "Debe de especificar el NIT y NRC del proveedor"
        End If
        Dim EsOk As Boolean = ValidarFechaCierre(deFechaCompra.EditValue)
        If Not EsOk Then
            msj = "La fecha de la compra no corresponde al período activo"
        End If
        If msj <> "" Then
            MsgBox(msj, MsgBoxStyle.Critical, "Error de usuario")
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With Header
            .Serie = teSerie.Text
            .FechaVencimiento = deFechaCompra.EditValue
            .Direccion = "SUCHITOTO"
            .ExcluirLibro = ceExcluirLibroCompras.Checked
            .AplicadaInventario = chkAplicaPercepcion.Checked
            .Fecha = deFechaCompra.EditValue
            .FechaContable = deFechaContable.DateTime
            .Giro = teGiro.Text
            .IdBodega = 1
            .IdFormaPago = 1
            .IdProveedor = beProveedor.EditValue
            .Nit = teNIT.Text
            .Nombre = teNombre.Text
            .Nrc = teNRC.EditValue
            .Numero = teNumero.EditValue
            .NumOrdenCompra = ""
            .IdOrigenCompra = leTipoLiquidacion.EditValue
            .SaldoActual = teTotal.EditValue
            .DiasCredito = DateDiff(DateInterval.Day, deFechaCompra.EditValue, deFechaCompra.EditValue)
            .IdTipoCompra = 1
            .IdTipoComprobante = leTipoDocto.EditValue
            .TotalComprobante = teTotal.EditValue
            .TotalAfecto = Me.gcValorAfecto.SummaryItem.SummaryValue
            .TotalExento = Me.gcValorExento.SummaryItem.SummaryValue
            .TotalImpuesto1 = tePercepcion.EditValue
            .TotalImpuesto2 = 0.0
            .TotalIva = teIva.EditValue
            .IdSucursal = 1
            .CreadoPor = CreadoPor
            .FechaHoraCreacion = Now
            .ModificadoPor = ""
            .IdLiquidacion = IdLiquidacion
        End With

        Detalle = New List(Of com_ComprasDetalle)
        For i = 0 To gv.DataRowCount - 1
            Dim entDetalle As New com_ComprasDetalle
            With entDetalle
                .IdComprobante = 0  ' Se asigna en la capa de datos
                .IdProducto = gv.GetRowCellValue(i, "IdProducto")
                .IdGasto = gv.GetRowCellValue(i, "IdGasto")
                .Cantidad = gv.GetRowCellValue(i, "Cantidad")
                .Descripcion = gv.GetRowCellValue(i, "Descripcion")
                .PrecioUnitario = gv.GetRowCellValue(i, "PrecioUnitario")
                .ValorExento = gv.GetRowCellValue(i, "ValorExento")
                .ValorAfecto = gv.GetRowCellValue(i, "ValorAfecto")
                .IdCuenta = "PENDIENTE"
                .IdDetalle = i + 1
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
            Detalle.Add(entDetalle)
        Next
    End Sub
    
    Private Sub ActivarControles(ByVal Tipo As Boolean)
        For Each ctrl In pcHeader.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        gv.OptionsBehavior.Editable = Tipo
        teCorrelativo.Properties.ReadOnly = True
    End Sub
#Region "Grid"
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDown.Click
        Dim rh As Integer = gv.FocusedRowHandle
        If rh > 0 Then
            Dim numCol As Integer = gv.Columns.Count
            Dim columna(numCol) As Object
            'Guarda los datos de la fila actual en el temporal columna
            Dim i As Integer = 0
            For Each col As GridColumn In gv.Columns
                columna(i) = gv.GetRowCellValue(rh, col)
                i += 1
            Next
            'actualiza la fila con los registros de la fila anterior
            For Each col As GridColumn In gv.Columns
                gv.SetRowCellValue(rh, col, gv.GetRowCellValue(rh - 1, col))
            Next
            'actualiza la fila anterior con los registros de el temporal
            i = 0
            For Each col As GridColumn In gv.Columns
                gv.SetRowCellValue(rh - 1, col, columna(i))
                i += 1
            Next
            gv.FocusedRowHandle = rh - 1
            gv.SelectRow(rh - 1)
        End If
    End Sub
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.Click
        Dim rh As Integer = gv.FocusedRowHandle
        If rh < gv.RowCount - 1 Then
            Dim numCol As Integer = gv.Columns.Count
            Dim columna(numCol) As Object
            'Guarda los datos de la fila actual en el temporal columna
            Dim i As Integer = 0
            For Each col As GridColumn In gv.Columns
                columna(i) = gv.GetRowCellValue(rh, col)
                i += 1
            Next
            'actualiza la fila con los registros de la siguiente fila
            For Each col As GridColumn In gv.Columns
                gv.SetRowCellValue(rh, col, gv.GetRowCellValue(rh + 1, col))
            Next
            'actualiza la fila siguiente con los registros de el temporal
            i = 0
            For Each col As GridColumn In gv.Columns
                gv.SetRowCellValue(rh + 1, col, columna(i))
                i += 1
            Next
            gv.FocusedRowHandle = rh + 1
            gv.SelectRow(rh + 1)
        End If
    End Sub
    Private Sub cmdBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBorrar.Click
        gv.DeleteRow(gv.FocusedRowHandle)
        CalcularTotales()
    End Sub
    Private Sub gv_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.SetRowCellValue(gv.FocusedRowHandle, "Descripcion", "")
        gv.SetRowCellValue(gv.FocusedRowHandle, "PrecioUnitario", 0.0)
        gv.SetRowCellValue(gv.FocusedRowHandle, "ValorExento", 0.0)
        gv.SetRowCellValue(gv.FocusedRowHandle, "ValorAfecto", 0.0)
    End Sub
    Private Sub gv_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv.KeyDown

    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gv.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv.RowUpdated
        CalcularTotales()
    End Sub
   
    Private Sub CalcularTotales()
        gv.UpdateTotalSummary()
        teIva.EditValue = Decimal.Round(Me.gcValorAfecto.SummaryItem.SummaryValue * pnIVA, 2)
        tePercepcion.EditValue = 0.0
        If chkAplicaPercepcion.EditValue And Me.gcValorAfecto.SummaryItem.SummaryValue > 100 Then
            tePercepcion.EditValue = Decimal.Round(Me.gcValorAfecto.SummaryItem.SummaryValue * 1 / 100, 2)
        End If

        teTotal.EditValue = teIva.EditValue + tePercepcion.EditValue + Me.gcValorAfecto.SummaryItem.SummaryValue _
                        + Me.gcValorExento.SummaryItem.SummaryValue
    End Sub
#End Region

    Private Sub beProveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beProveedor.ButtonClick
        beProveedor.EditValue = ""
        beProveedor_Validated(sender, New System.EventArgs)
    End Sub
    Private Sub beProveedor_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beProveedor.Validated
        Dim entProveedor As com_Proveedores = objConsultas.cnsProveedores(frmConsultas, beProveedor.EditValue)
        beProveedor.EditValue = entProveedor.IdProveedor
        teNombre.EditValue = entProveedor.Nombre
        teGiro.EditValue = entProveedor.Giro
        teNRC.EditValue = entProveedor.Nrc
        teNIT.EditValue = entProveedor.Nit
        chkAplicaPercepcion.EditValue = entProveedor.AplicaRetencion
    End Sub
    Private Sub teDocExcluido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        If gv.FocusedRowHandle = DevExpress.XtraGrid.GridControl.InvalidRowHandle Then
            gv.FocusedRowHandle = DevExpress.XtraGrid.GridControl.NewItemRowHandle
        End If
        gv.FocusedColumn = gv.Columns(0)
    End Sub

    Private Sub com_frmCompras_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        sbGuardar.Visible = False
        Me.Dispose()
    End Sub

    Private Sub leRubro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leRubro.EditValueChanged
        objCombos.coo_CuentasGastos(leGasto, leRubro.EditValue)
    End Sub

    Private Sub leGasto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leGasto.EditValueChanged
        If gv.DataRowCount = 0 Then
            Exit Sub
        End If
    End Sub

    Private Sub seValorAfecto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles seValorAfecto.KeyDown
        If e.KeyCode = Keys.Enter Then
            gv.AddNewRow()
            gv.SetRowCellValue(gv.FocusedRowHandle, "IdRubro", leRubro.EditValue)
            gv.SetRowCellValue(gv.FocusedRowHandle, "IdGasto", leGasto.EditValue)
            gv.SetRowCellValue(gv.FocusedRowHandle, "Descripcion", teConcepto.EditValue)
            gv.SetRowCellValue(gv.FocusedRowHandle, "PrecioUnitario", 0.0)
            gv.SetRowCellValue(gv.FocusedRowHandle, "ValorExento", seValorExento.EditValue)
            gv.SetRowCellValue(gv.FocusedRowHandle, "ValorAfecto", seValorAfecto.EditValue)
            gv.UpdateCurrentRow()
            teConcepto.EditValue = ""
            seValorExento.EditValue = 0.0
            seValorAfecto.EditValue = 0.0
            leRubro.Focus()
        End If
    End Sub

    Private Sub seValorAfecto_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seValorAfecto.EditValueChanged

    End Sub
End Class
