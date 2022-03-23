Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.IO

Public Class adm_frmRecuperarArchivo
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()
    Dim blApor As New AportacionesBLL()
    Dim blAho As New AhorrosBLL()
    Dim blCaja As New CajaBusiness()
    Dim blPrestamo As New Prestamo
    Dim dt As DataTable
    Dim dtTele As DataTable
    Dim fd As New FuncionesBLL
    Dim dtDescuentosEnviados As DataTable
    Dim dtDescuentosPrestamos As DataTable
    Dim dtParam As DataTable = bl.ObtieneParametros
    Dim dFecha As Date
    Dim IdAsociadoRecorrido As Integer, IdPres As Integer = 0, IdMovUltAfi As Integer = 0
    Dim entAsociado As coo_Asociados
    Dim entAportaciones As New List(Of coo_Aportaciones)
    Dim entAhorros As New List(Of coo_CuentasAhorroMov)
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    Dim EntTelefonos As New List(Of coo_DescuentoTelefoniaPendiente)
    Dim EntListAbono As New List(Of coo_abonoTelefonia)
    Dim elpagodetalle As New coo_PrestamosDetalle
    'Dim IdMovUlt As Integer = 0, IdMovUltApo As Integer = 0
    'Dim IdMovAho As Integer = 0, IdMovFune As Integer = 0, IdAsociadoPago As Integer = 0
    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        deFecha.EditValue = Today
        objCombos.adm_TiposModulo(leTipoArchivo, "")
        leSucursal.EditValue = gIdSucursal
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        dtTele = bl.GetTablaDescuentosTelefonosAplicados(deFecha.EditValue)
        'dtTele = bl.GetTablaDescuentosTelefonosAplicados(deFecha.EditValue)
        TeNumeroFactura.EditValue = bl.GetNumeroFactura(deFecha.EditValue)
        ChecCargaExcel.Visible = False
        BtnGenerarExcel.Visible = False
        CheckAbono.Visible = False
        If dtTele.Rows.Count = 0 Then
            dtTele = bl.GetTablaDescuentosTelefonos()
        End If
        GCTelefonia.DataSource = dtTele
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        If leTipoArchivo.EditValue = 4 Then
            dtTele = bl.GetLimpiaTablaTelefonos()
            If CheckAbono.Checked = True Then
                Dim dtArchivoAbono As New DataTable
                Dim k As Integer = 1
                Dim ofd As New OpenFileDialog()
                ofd.ShowDialog()
                If ofd.FileName = "" Then
                    Return
                End If
                Dim Archivo As System.IO.StreamReader = File.OpenText(ofd.FileName)
                Dim separador As String = InputBox("Separador:", "Defina el delimitador del archivo", ",")
                If separador = "" Then
                    separador = ","
                End If
                Try
                    While Archivo.Peek() > 0
                        Dim sLine As String = Archivo.ReadLine()
                        Dim aData As Array = sLine.Split(separador)
                        IdAsociadoRecorrido = blApor.ExisteNumAsociado(aData(0))
                        If IdAsociadoRecorrido > 0 Then
                            Dim Total As Decimal = aData(4)
                            Dim subtotal As Decimal = Total
                            Dim dr As DataRow
                            dr = dtTele.NewRow()
                            dr("IdAsociado") = IdAsociadoRecorrido
                            dr("Numero") = aData(0)
                            dr("Nombres") = aData(1)
                            dr("Apellidos") = aData(2)
                            dr("Telefono") = aData(3)
                            dr("ValorTotalFactura") = Total
                            dr("ValorIva") = 0
                            dr("ValorSeguridad") = 0
                            dr("ValorComicion") = 0
                            dr("SubTotal") = subtotal
                            dr("Total") = Total
                            dtTele.Rows.Add(dr)
                            k += 1
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Return
                End Try
                Archivo.Close()
                GCTelefonia.DataSource = dtTele
            Else
                Dim dtArchivo2 As New DataTable
                Dim k As Integer = 1
                Dim ofd As New OpenFileDialog()
                ofd.ShowDialog()
                If ofd.FileName = "" Then
                    Return
                End If
                Dim Archivo As System.IO.StreamReader = File.OpenText(ofd.FileName)
                Dim separador As String = InputBox("Separador:", "Defina el delimitador del archivo", ",")
                If separador = "" Then
                    separador = ","
                End If
                Try
                    While Archivo.Peek() > 0
                        Dim sLine As String = Archivo.ReadLine()
                        Dim aData As Array = sLine.Split(separador)
                        IdAsociadoRecorrido = blApor.ExisteNumAsociado(aData(0))
                        If IdAsociadoRecorrido > 0 Then
                            Dim iva As Decimal = aData(4) * 0.13
                            Dim seguridad As Decimal = aData(4) * 0.05
                            Dim Total As Decimal = aData(4)
                            Dim ValComision As Decimal = objFunciones.ObtenerValorComision(IdAsociadoRecorrido)
                            Dim subtotal As Decimal = Total + iva + seguridad
                            Dim dr As DataRow
                            dr = dtTele.NewRow()
                            dr("IdAsociado") = IdAsociadoRecorrido
                            dr("Numero") = aData(0)
                            dr("Nombres") = aData(1)
                            dr("Apellidos") = aData(2)
                            dr("Telefono") = aData(3)
                            dr("ValorTotalFactura") = Total
                            dr("ValorIva") = iva
                            dr("ValorSeguridad") = seguridad
                            dr("ValorComicion") = ValComision
                            dr("SubTotal") = subtotal
                            dr("Total") = Total + ValComision
                            dtTele.Rows.Add(dr)
                            k += 1
                        End If
                    End While
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Return
                End Try
                Archivo.Close()
                GCTelefonia.DataSource = dtTele
            End If
        Else
                    dt = bl.GetTablaDescuentos()
                    Dim dtArchivo As New DataTable
                    Dim dFechaContable As Date
                    Dim TipoMov As Integer = 0
                    Dim i As Integer = 1

                    dFechaContable = objFunciones.GetFechaContable(gIdSucursal)
                    'dtArchivo = ConstruirDatatable(btArchivoSucursal.EditValue, ",")

                    Dim ofd As New OpenFileDialog()
                    ofd.ShowDialog()
                    If ofd.FileName = "" Then
                        Return
                    End If
                    Dim Archivo As System.IO.StreamReader = File.OpenText(ofd.FileName)
                    Dim separador As String = InputBox("Separador:", "Defina el delimitador del archivo", ",")
                    If separador = "" Then
                        separador = ","
                    End If
                    Try
                        While Archivo.Peek() > 0
                            Dim sLine As String = Archivo.ReadLine()
                            Dim aData As Array = sLine.Split(separador)

                            IdAsociadoRecorrido = blApor.ExisteNumAsociado(aData(0))
                            IdPres = blPres.ExisteNumPrestamo(aData(1))

                            If leTipoArchivo.EditValue = 1 Then
                                If IdAsociadoRecorrido > 0 And IdPres > 0 Then
                                    Dim entAsociadoRecorre As New coo_Asociados
                                    entAsociadoRecorre = objTablas.coo_AsociadosSelectByPK(IdAsociadoRecorrido)

                                    Dim dr As DataRow
                                    dr = dt.NewRow()
                                    dr("Num") = i
                                    dr("Numero") = aData(0)
                                    dr("Nombres") = entAsociadoRecorre.Nombres
                                    dr("Apellidos") = entAsociadoRecorre.Apellidos
                                    dr("NumeroPrestamo") = aData(1)
                                    dr("Aportaciones") = 0.0
                                    dr("Ahorros") = 0.0
                                    dr("Prestamos") = aData(2)
                                    dr("IdPrestamo") = IdPres
                                    dr("IdAsociado") = IdAsociadoRecorrido
                                    dt.Rows.Add(dr)
                                    i += 1
                                End If
                            Else
                                If IdAsociadoRecorrido > 0 Then
                                    Dim entAsociadoRecorre As New coo_Asociados
                                    entAsociadoRecorre = objTablas.coo_AsociadosSelectByPK(IdAsociadoRecorrido)

                                    Dim dr As DataRow
                                    dr = dt.NewRow()
                                    dr("Num") = i
                                    dr("Numero") = aData(0)
                                    dr("Nombres") = entAsociadoRecorre.Nombres
                                    dr("Apellidos") = entAsociadoRecorre.Apellidos
                                    dr("NumeroPrestamo") = ""
                                    dr("Aportaciones") = aData(1)
                                    dr("Ahorros") = aData(2)
                                    dr("Prestamos") = 0.0
                                    dr("IdPrestamo") = 0
                                    dr("IdAsociado") = IdAsociadoRecorrido
                                    dt.Rows.Add(dr)
                                    i += 1
                                Else
                                    MsgBox("Código de Socio no Existe :" + aData(0), MsgBoxStyle.Information, "Error")
                                End If
                            End If
                        End While
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        Return
                    End Try
                    Archivo.Close()
                    gc.DataSource = dt
        End If
    End Sub


    Private Sub btArchivoSucursal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btArchivoSucursal.Click
        If btArchivoSucursal.Properties.ReadOnly = True Then
            Exit Sub
        End If
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "OpenFileDialog1" Then
            btArchivoSucursal.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub sbAplicar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAplicar.Click
        If leTipoArchivo.EditValue = 4 Then
            If CheckAbono.Checked = True Then
                If TeNumeroFactura.EditValue = "" Then
                    MsgBox("No ha ingresado un Numero de Abono", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If MsgBox("Está seguro(a) de aplicar los Abonos Telefonicos, Ya no podra revertir los movimientos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    For i = 0 To GVTelefonia.DataRowCount - 1 ' FOR DE LA LISTA DE LOS ASOCIADOS
                        Dim entAbo As New coo_abonoTelefonia
                        With entAbo
                            .IdAsociado = GVTelefonia.GetRowCellValue(i, "IdAsociado")
                            .FechaAplicacion = deFecha.EditValue 'GVTelefonia.GetRowCellValue(i, "FechaAplicacion")
                            .Telefono = GVTelefonia.GetRowCellValue(i, "Telefono")
                            .NAbono = TeNumeroFactura.EditValue 'GVTelefonia.GetRowCellValue(i, "NumeroFactura")
                            .ValorTotalAbono = GVTelefonia.GetRowCellValue(i, "ValorTotalFactura")
                            .Total = GVTelefonia.GetRowCellValue(i, "ValorTotalFactura")
                        End With
                        EntListAbono.Add(entAbo)
                    Next
                    Dim msj As String = ""
                    objTablas.coo_AbonoTelefoniaDelete(deFecha.EditValue)
                    msj = blPres.InsertaAbonosTelefono(EntListAbono)
                    If msj = "" Then
                        MsgBox("Los Abonos Telefonicos han sido guardados con éxito", MsgBoxStyle.Information)
                    Else
                        MsgBox(String.Format("No fue posible actualizar los Abonos{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                        Return
                    End If
                    Close()
                End If
            Else
                If TeNumeroFactura.EditValue = "" Then
                    MsgBox("No ha ingresado un Numero de Factura", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                If MsgBox("Está seguro(a) de aplicar los descuentos Telefonicos, Ya no podra revertir los movimientos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    For i = 0 To GVTelefonia.DataRowCount - 1 ' FOR DE LA LISTA DE LOS ASOCIADOS
                        Dim entTelefono As New coo_DescuentoTelefoniaPendiente
                        With entTelefono
                            .IdAsociado = GVTelefonia.GetRowCellValue(i, "IdAsociado")
                            .FechaAplicacion = deFecha.EditValue 'GVTelefonia.GetRowCellValue(i, "FechaAplicacion")
                            .Telefono = GVTelefonia.GetRowCellValue(i, "Telefono")
                            .Nfactura = TeNumeroFactura.EditValue 'GVTelefonia.GetRowCellValue(i, "NumeroFactura")
                            .ValorTotalFactura = GVTelefonia.GetRowCellValue(i, "ValorTotalFactura")
                            .ValorIva = GVTelefonia.GetRowCellValue(i, "ValorIva")
                            .ValorSeguridad = GVTelefonia.GetRowCellValue(i, "ValorSeguridad")
                            .Valorcomicion = GVTelefonia.GetRowCellValue(i, "ValorComicion")
                            .Total = GVTelefonia.GetRowCellValue(i, "Total")
                        End With
                        EntTelefonos.Add(entTelefono)
                    Next
                    Dim msj As String = ""
                    If blPres.ValidaDescuentoTelefonico(deFecha.EditValue) > 0 Then
                        objTablas.coo_DescuentoTelefoniaPendienteDelete(deFecha.EditValue)
                        msj = blPres.InsertaDescuentosTelefono(EntTelefonos)
                    Else
                        msj = blPres.InsertaDescuentosTelefono(EntTelefonos)
                    End If
                    If msj = "" Then
                        MsgBox("Los Descuentos Telefonicos han sido guardados con éxito", MsgBoxStyle.Information)
                    Else
                        MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                        Return
                    End If

                    Close()
                End If
            End If
        Else
            If gv.DataRowCount = 0 Then
                MsgBox(String.Format("Debe de cargar el archivo a aplicar"), MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim IdAsociadoRecorre As Integer = 0
            Dim ValorDescuento As Decimal = 0.0
            Dim lNoexistenCuentasAhorros As Boolean = False

            If leTipoArchivo.EditValue <> 1 Then
                For x = 0 To gv.DataRowCount - 1
                    If gv.GetRowCellValue(x, "Ahorros") > 0.0 And SiEsNulo(blAho.GetCuentaAhorroCorrientePla(gv.GetRowCellValue(x, "IdAsociado")), 0) = 0 Then
                        lNoexistenCuentasAhorros = True
                    End If
                Next

                If lNoexistenCuentasAhorros Then
                    MsgBox(String.Format("Hay Descuentos de Ahorro, sin Cuentas Creadas"), MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

            If blPres.ValidaReversionPlanilla(deFecha.EditValue, deFecha.EditValue, leTipoArchivo.EditValue) > 0 Then
                MsgBox("No es Posible aplicar la Planilla, ya se ingresaron movimientos despues de la fecha a Aplicar", MsgBoxStyle.Critical)
                Exit Sub
            End If

            If MsgBox("Está seguro(a) de aplicar los descuentos, Ya no podra revertir los movimientos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                If leTipoArchivo.EditValue = 1 Then ' cargo los prestamos
                    For i = 0 To gv.DataRowCount - 1 ' FOR DE LA LISTA DE LOS ASOCIADOS 

                        IdAsociadoRecorre = gv.GetRowCellValue(i, "IdPrestamo")

                        Dim IdPrestamo As Integer = gv.GetRowCellValue(i, "IdPrestamo")
                        Dim Valor As Decimal = gv.GetRowCellValue(i, "Prestamos")
                        ValorDescuento = gv.GetRowCellValue(i, "Prestamos")
                        Dim entDetalle4 As New coo_PrestamosDetalle
                        Dim dtTasa As DataTable = blPres.ObtenerUltimasTasas(IdPrestamo)
                        Dim entPrestamo As New coo_Prestamos


                        entPrestamo = objTablas.coo_PrestamosSelectByPK(IdPrestamo)
                        ActualizaPrestamo(ValorDescuento, IdPrestamo)

                        If elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.ValorSeguroPagado < ValorDescuento Then
                            With entDetalle4
                                .IdPrestamo = elpagodetalle.IdPrestamo
                                .IdMov = elpagodetalle.IdMov + 1
                                .Numero = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .TipoAplicacion = 1
                                .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                                .ImportePagado = elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.ValorSeguroPagado
                                .CapitalPagado = elpagodetalle.CapitalPagado
                                .SaldoCapital = blPres.GetSaldoCapitalPrestamo(IdPrestamo) - elpagodetalle.CapitalPagado
                                .DiasCalcInteres = elpagodetalle.DiasCalcInteres
                                .DiasCalcMora = elpagodetalle.DiasCalcMora
                                .InteresPagado = elpagodetalle.InteresPagado
                                .InteresPendiente = elpagodetalle.InteresPendiente
                                .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                                .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
                                .ValorSeguroPagado = elpagodetalle.ValorSeguroPagado
                                .ValorSeguroPendiente = elpagodetalle.ValorSeguroPendiente
                                .ManejoPagado = 0.0
                                .ManejoPendiente = 0.0
                                .OtrosPagado = 0.0
                                .OtrosPendiente = 0.0
                                .CuotaAhorro = 0.0
                                .CuotaAportacion = 0.0
                                .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
                                .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
                                .IdFormaPago = 6
                                .IdSucursal = gIdSucursal
                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now
                            End With
                        Else
                            With entDetalle4
                                .IdPrestamo = elpagodetalle.IdPrestamo
                                .IdMov = elpagodetalle.IdMov + 1
                                .Numero = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .TipoAplicacion = 1
                                .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                                .ImportePagado = elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.ValorSeguroPagado
                                .CapitalPagado = elpagodetalle.CapitalPagado
                                .SaldoCapital = blPres.GetSaldoCapitalPrestamo(IdPrestamo) - elpagodetalle.CapitalPagado
                                .DiasCalcInteres = elpagodetalle.DiasCalcInteres
                                .DiasCalcMora = elpagodetalle.DiasCalcMora
                                .InteresPagado = elpagodetalle.InteresPagado
                                .InteresPendiente = elpagodetalle.InteresPendiente
                                .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                                .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
                                .ValorSeguroPagado = elpagodetalle.ValorSeguroPagado
                                .ValorSeguroPendiente = elpagodetalle.ValorSeguroPendiente
                                .ManejoPagado = 0.0
                                .ManejoPendiente = 0.0
                                .OtrosPagado = 0.0
                                .OtrosPendiente = 0.0
                                .CuotaAhorro = 0.0
                                .CuotaAportacion = 0.0
                                .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
                                .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
                                .IdFormaPago = 6
                                .IdSucursal = gIdSucursal
                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now
                            End With
                        End If
                        entPrestamos.Add(entDetalle4)

                    Next
                Else
                    For i = 0 To gv.DataRowCount - 1
                        ValorDescuento = gv.GetRowCellValue(i, "Aportaciones")
                        IdAsociadoRecorre = gv.GetRowCellValue(i, "IdAsociado")

                        If ValorDescuento > 0.0 And IdAsociadoRecorre > 0 Then
                            Dim entDetalleApo As New coo_Aportaciones
                            With entDetalleApo
                                .IdAsociado = IdAsociadoRecorre
                                .IdMov = blApor.GetUltMovAporta(IdAsociadoRecorre) + 1
                                .IdTipo = 1
                                .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .IdFormaPago = 6
                                .Cargo = 0.0
                                .Abono = ValorDescuento
                                .Saldo = blApor.GetSaldoAporta(IdAsociadoRecorre) + ValorDescuento
                                .LineaLibreta = blApor.GetUltLineaAporta(IdAsociadoRecorre) + 1
                                .Impreso = False
                                .IdSucursal = gIdSucursal
                                .FechaContable = deFecha.EditValue
                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now
                            End With
                            entAportaciones.Add(entDetalleApo)
                        End If

                        ValorDescuento = gv.GetRowCellValue(i, "Ahorros")
                        If ValorDescuento > 0.0 And IdAsociadoRecorre > 0 Then
                            Dim entDetalle3 As New coo_CuentasAhorroMov
                            With entDetalle3
                                .IdCuenta = SiEsNulo(blAho.GetCuentaAhorroCorrientePla(IdAsociadoRecorre), 0)
                                .IdMov = blAho.GetUltMovAhorro(.IdCuenta) + 1
                                .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .IdTipo = 1
                                .Valor = ValorDescuento
                                .Saldo = blAho.GetSaldoAhorro(.IdCuenta) + ValorDescuento
                                .LineaLibreta = blAho.GetUltLineaAhorro(IdAsociadoRecorre) + 1
                                .IdFormaPago = 6
                                .FechaContable = deFecha.EditValue
                                .IdSucursal = gIdSucursal
                                .Pignorado = False
                                .Observaciones = "APLICACION DE PLANILLA " + deFecha.EditValue.ToString
                                .Impreso = False
                                .IdAutorizado = 0
                                .DocAutorizado = ""
                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now
                            End With
                            entAhorros.Add(entDetalle3)
                        End If
                    Next

                End If

                Dim msj As String = ""


                msj = blPres.InsertaDescuentos(entAportaciones _
                , entAhorros, entPrestamos, 1, objFunciones.GetFechaContable(gIdSucursal), objMenu.User)

                If msj = "" Then
                    MsgBox("Los Descuentos han sido guardados con éxito", MsgBoxStyle.Information)
                Else
                    MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                    Return
                End If

                Close()

            End If
        End If
    End Sub

    Private Sub ActualizaPrestamo(ByVal Abono As Decimal, ByVal IdPrestamo As Integer)
        blPrestamo = New Prestamo
        Dim entPrestamoCuota As coo_Prestamos

        entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(IdPrestamo)
        blPrestamo.FechaAmortizacion = deFecha.EditValue
        blPrestamo.CargaPrestamo(IdPrestamo)
        Dim entLineas As coo_Lineas = objTablas.coo_LineasSelectByPK(entPrestamoCuota.IdLinea)

        If blPrestamo.IdAsociado <> 0 Then
            With blPrestamo
                .FechaContable = blCaja.GetFechaContable(leSucursal.EditValue)
                .FechaAmortizacion = deFecha.EditValue
                .DiasPorAnio = giDiasPorAnioPrestamo
                .CancelarEfectivo = False
                .Efectivo = entLineas.TipoLinea = 1
                entPrestamoCuota = objTablas.coo_PrestamosSelectByPK(blPrestamo.IdPrestamo)
                'Cuota base para el calculo de la mora
                .CalculaUltimoPago()
                .CalculaCuotaBaseMora()
                .CalculaCuotaDeberSer()
                'TODO cambiar nombre
                .ImporteAbonoPago = Abono


                .ComisionCobranza = 0.0
                .Gestion = 0.0
                .CuotaAportacion = entPrestamoCuota.CuotaAportacion
                .CuotaAhorro = entPrestamoCuota.CuotaAhorro
                .CuotaManejo = 0.0
                .NoInteres = False
                .TipoCuota = entPrestamoCuota.TipoCuota
                .CalculaAmortizacion()

                With elpagodetalle

                    If blPrestamo.PagoActual.FormaPago = 4 Then
                        .TipoAplicacion = 2
                    Else
                        .TipoAplicacion = 1
                    End If

                    .CapitalPagado = blPrestamo.PagoActual.ImporteCapital
                    .CreadoPor = blPrestamo.CodUsuario
                    .ComisionCobranza = blPrestamo.PagoActual.ImporteComisionCobranza
                    .Gestion = blPrestamo.PagoActual.ImporteGestion
                    .CuotaAhorro = blPrestamo.PagoActual.ImporteCuotaAhorro
                    .CuotaAportacion = blPrestamo.PagoActual.ImporteCuotaAportacion
                    .DiasCalcInteres = blPrestamo.PagoActual.DiasCalculoInteres
                    .DiasCalcMora = blPrestamo.PagoActual.DiasCalculoMora
                    .Fecha = blPrestamo.FechaAmortizacion
                    .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                    .FechaHoraCreacion = Now
                    .IdFormaPago = blPrestamo.PagoActual.FormaPago
                    .IdMov = blPrestamo.GetUltMovPrestamo(IdPrestamo)

                    .IdPrestamo = blPrestamo.IdPrestamo
                    .IdSucursal = blPrestamo.IdSucursal
                    .ImportePagado = blPrestamo.ImporteAbonoPago

                    'If blPrestamo.TipoCuota = 1 Then
                    '    .InteresPagado = blPrestamo.PagoActual.ImporteInteres
                    'Else
                    '    Dim dtSaldos As DataTable = blCaja.CalculaSaldoPres(blPrestamo.IdPrestamo, blPrestamo.IdAsociado, deFecha.EditValue)
                    '    .InteresPagado = SiEsNulo(dtSaldos.Rows(0).Item("SaldoInteres"), 0.0)
                    'End If

                    .InteresPagado = blPrestamo.PagoActual.ImporteInteres
                    .InteresMoraPagado = blPrestamo.PagoActual.ImporteMora

                    If .InteresMoraPagado >= Abono Then
                        .InteresPagado = 0
                    End If

                    .InteresMoraPendiente = blPrestamo.PagoActual.ImporteDeudaMora
                    .TasaInteres = blPrestamo.TasaInteresAnual
                    .TasaInteresMora = blPrestamo.TasaInteresMora
                    '.InteresPagado = blPrestamo.PagoActual.ImporteInteres
                    .InteresPendiente = IIf(entPrestamoCuota.IdLinea = 6, 0, blPrestamo.PagoActual.ImporteDeudaInteres)
                    .ManejoPagado = blPrestamo.PagoActual.ImporteCuotaManejo
                    .ManejoPendiente = blPrestamo.PagoActual.ImporteDeudaManejo

                    'TODO asaber que es numero
                    .Numero = "P-" & Format(deFecha.EditValue, "ddMMyyyy")
                    .ReferenciaPago = blPrestamo.PagoActual.ReferenciaPago

                    .OtrosPagado = blPrestamo.PagoActual.ImporteCuotaOtros
                    .OtrosPendiente = blPrestamo.PagoActual.ImporteDeudaOtros
                    .SaldoCapital = blPrestamo.PagoActual.ImporteSaldo
                    .ValorSeguroPagado = blPrestamo.PagoActual.ImporteCuotaSeguro
                    .ValorSeguroPendiente = blPrestamo.PagoActual.ImporteDeudaSeguro

                    'IdPresAnt = entPrestamoCuota.IdPrestamo
                    'IdMovUlt = .IdMov
                End With

            End With
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim rpt As New pre_rptListadoCargarPlanilla
        Dim dtReporte As New DataTable
        dtReporte = bl.GetTablaReporte()

        For i = 0 To gv.DataRowCount - 1
            If gv.GetRowCellValue(i, "Ahorros") > 0.0 And SiEsNulo(blAho.GetCuentaAhorroCorrientePla(gv.GetRowCellValue(i, "IdAsociado")), 0) = 0 Then
                Dim dr As DataRow
                dr = dtReporte.NewRow()
                dr("IdAsociado") = gv.GetRowCellValue(i, "IdAsociado")
                dr("Numero") = gv.GetRowCellValue(i, "Numero")
                dr("Nombres") = gv.GetRowCellValue(i, "Nombres")
                dr("Descuento") = gv.GetRowCellValue(i, "Ahorros")
                dtReporte.Rows.Add(dr)
            End If
        Next

        rpt.DataSource = dtReporte
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "ASOCIADOS SIN CUENTA DE AHORROS"
        rpt.xrlFecha.Text = "FECHA A CARGAR PLANILLA" & FechaToString(deFecha.EditValue, deFecha.EditValue).ToUpper
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub leTipoArchivo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leTipoArchivo.EditValueChanged
        If leTipoArchivo.EditValue = 4 Then
            GCTelefonia.Visible = True
            gc.Visible = False
            TeNumeroFactura.Visible = True
            LabelControl26.Visible = True
            'dtTele = bl.GetTablaDescuentosTelefonos()
            'GCTelefonia.DataSource = dtTele
            ChecCargaExcel.Checked = False
            btProceder.Enabled = False
            ChecCargaExcel.Visible = True
            BtnGenerarExcel.Visible = True
            SimpleButton1.Visible = False
        Else
            GCTelefonia.Visible = False
            gc.Visible = True
            TeNumeroFactura.Visible = False
            LabelControl26.Visible = False
            btProceder.Enabled = True
            ChecCargaExcel.Visible = False
            BtnGenerarExcel.Visible = False
            SimpleButton1.Visible = True
        End If
    End Sub

    Private Sub btTelefonia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Delimitador As String = InputBox("Deliminator del archivo:", "Especifique el delimitador", ",")
        If Delimitador = "" Then
            Return
        End If
        Dim fbd As New FolderBrowserDialog
        fbd.ShowDialog()
        If fbd.SelectedPath = "" Then
            Return
        End If
        Dim Archivo As String = String.Format("{0}\DESCUENTOTELEFONOS{1}.csv", fbd.SelectedPath, Format(deFecha.EditValue, "yyyyMMdd"))
        Try
            Using Arc As StreamWriter = New StreamWriter(Archivo)
                Dim linea As String = String.Empty
                Dim dt As New DataTable
                'dt = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, True, leCentro.EditValue, objMenu.User, False)
                dt = blPres.EnvioDescuentosTelefono()
                For fila As Integer = 0 To dt.Rows.Count - 1
                    linea = String.Empty
                    linea &= dt.Rows(fila).Item("Numero") & Delimitador
                    linea &= dt.Rows(fila).Item("Nombres") & Delimitador
                    linea &= dt.Rows(fila).Item("Apellidos") & Delimitador
                    linea &= dt.Rows(fila).Item("NumeroFactura") & Delimitador
                    linea &= dt.Rows(fila).Item("ValorTotalFactura") & Delimitador
                    With Arc
                        linea = linea.Remove(linea.Length - 1).ToString
                        .WriteLine(linea.ToString)
                    End With
                Next
            End Using
            Process.Start(Archivo)
            'si se genera un error
        Catch ex As Exception
            MsgBox("NO SE PUDO GUARDAR EL ARCHIVO" + Chr(13) + ex.Message.ToString, MsgBoxStyle.Critical, "Nota")
        End Try
    End Sub

    Private Sub gvTelefonia_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GVTelefonia.ValidatingEditor
       
    End Sub

    Private Sub deFecha_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deFecha.EditValueChanged
        If CheckAbono.Checked = True Then
            If deFecha.EditValue = Nothing Then
                deFecha.EditValue = Today
            End If
            dtTele = bl.GetTablaAbonosTelefonosAplicados(deFecha.EditValue)
            TeNumeroFactura.EditValue = bl.GetNumeroFactura(deFecha.EditValue)
            If dtTele.Rows.Count = 0 Then
                dtTele = bl.GetTablaDescuentosTelefonos()
            End If
            GCTelefonia.DataSource = dtTele
        Else
            If deFecha.EditValue = Nothing Then
                deFecha.EditValue = Today
            End If
            dtTele = bl.GetTablaDescuentosTelefonosAplicados(deFecha.EditValue)
            TeNumeroFactura.EditValue = bl.GetNumeroFactura(deFecha.EditValue)
            If dtTele.Rows.Count = 0 Then
                dtTele = bl.GetTablaDescuentosTelefonos()
            End If
            GCTelefonia.DataSource = dtTele
        End If   
    End Sub

    Private Sub ChecCargaExcel_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecCargaExcel.EditValueChanged
        If ChecCargaExcel.Checked = True Then
            btProceder.Enabled = True
            CheckAbono.Visible = True
            dtTele = bl.GetLimpiaTablaTelefonos()
            GCTelefonia.DataSource = dtTele
            SimpleButton1.Visible = False
        Else
            btProceder.Enabled = False
            CheckAbono.Visible = False
            dtTele = bl.GetTablaDescuentosTelefonosAplicados(deFecha.EditValue)
            If dtTele.Rows.Count = 0 Then
                dtTele = bl.GetTablaDescuentosTelefonos()
            End If
            GCTelefonia.DataSource = dtTele
            GCTelefonia.DataSource = dtTele
            SimpleButton1.Visible = True
        End If
    End Sub

    Private Sub BtnGenerarExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerarExcel.Click
        Dim Delimitador As String = InputBox("Deliminator del archivo:", "Especifique el delimitador", ",")
        If Delimitador = "" Then
            Return
        End If
        Dim fbd As New FolderBrowserDialog
        fbd.ShowDialog()
        If fbd.SelectedPath = "" Then
            Return
        End If
        Dim Archivo As String
        If CheckAbono.Checked = True Then
            Archivo = String.Format("{0}\ABONOSTELEFONOS{1}.csv", fbd.SelectedPath, Format(deFecha.EditValue, "yyyyMMdd"))
        Else
            Archivo = String.Format("{0}\DESCUENTOTELEFONOS{1}.csv", fbd.SelectedPath, Format(deFecha.EditValue, "yyyyMMdd"))
        End If
        Try
            Using Arc As StreamWriter = New StreamWriter(Archivo)
                Dim linea As String = String.Empty
                Dim dt As New DataTable
                dt = blPres.EnvioDescuentosTelefono()
                For fila As Integer = 0 To dt.Rows.Count - 1
                    linea = String.Empty
                    linea &= dt.Rows(fila).Item("Numero") & Delimitador
                    linea &= dt.Rows(fila).Item("Nombres") & Delimitador
                    linea &= dt.Rows(fila).Item("Apellidos") & Delimitador
                    linea &= dt.Rows(fila).Item("Telefono") & Delimitador
                    linea &= dt.Rows(fila).Item("ValorTotalFactura") & Delimitador
                    With Arc
                        linea = linea.Remove(linea.Length - 1).ToString
                        .WriteLine(linea.ToString)
                    End With
                Next
            End Using
            Process.Start(Archivo)
            'si se genera un error
        Catch ex As Exception
            MsgBox("NO SE PUDO GUARDAR EL ARCHIVO" + Chr(13) + ex.Message.ToString, MsgBoxStyle.Critical, "Nota")
        End Try
    End Sub

    Private Sub CheckAbono_CheckedChanged(sender As Object, e As EventArgs) Handles CheckAbono.CheckedChanged
        If CheckAbono.Checked = True Then
            LabelControl26.Text = "Numero Abono:"
            GridColumn12.Caption = "Valor Total Abono"
            GridColumn15.Visible = False
            GridColumn16.Visible = False
            sbAplicar.Text = "Aplicar Abonos"
        Else
            LabelControl26.Text = "Numero Factura:"
            GridColumn12.Caption = "Valor Total Factura"
            GridColumn16.Visible = True
            GridColumn15.Visible = True
            sbAplicar.Text = "Aplicar Descuentos"
        End If
    End Sub

    Private Sub GVTelefonia_KeyDown(sender As Object, e As KeyEventArgs) Handles GVTelefonia.KeyDown
        If e.KeyCode = Keys.Enter OrElse e.KeyCode = Keys.Space OrElse e.KeyCode = Keys.Tab OrElse e.KeyCode = Keys.Down OrElse e.KeyCode = Keys.Right OrElse e.KeyCode = Keys.Control OrElse e.KeyCode = Keys.ControlKey Then
            If GVTelefonia.FocusedColumn.FieldName = "ValorTotalFactura" Then
                If CheckAbono.Checked = True Then
                    Dim Total As Decimal = fd.EsNulo(GVTelefonia.EditingValue, 0)
                    Dim subtotal As Decimal = Total
                    GVTelefonia.SetFocusedRowCellValue("ValorIva", 0)
                    GVTelefonia.SetFocusedRowCellValue("ValorSeguridad", 0)
                    GVTelefonia.SetFocusedRowCellValue("ValorComicion", 0)
                    GVTelefonia.SetFocusedRowCellValue("Total", Total)
                    GVTelefonia.SetFocusedRowCellValue("SubTotal", Total)
                Else
                    Dim iva As Decimal = GVTelefonia.EditingValue * 0.13
                    Dim seguridad As Decimal = GVTelefonia.EditingValue * 0.05
                    Dim ValComision As Decimal = objFunciones.ObtenerValorComision(GVTelefonia.GetRowCellValue(GVTelefonia.FocusedRowHandle, "IdAsociado"))
                    Dim Total As Decimal = GVTelefonia.EditingValue + ValComision
                    Dim subtotal As Decimal = GVTelefonia.EditingValue + iva + seguridad
                    GVTelefonia.SetFocusedRowCellValue("ValorIva", iva)
                    GVTelefonia.SetFocusedRowCellValue("ValorSeguridad", seguridad)
                    GVTelefonia.SetFocusedRowCellValue("ValorComicion", ValComision)
                    GVTelefonia.SetFocusedRowCellValue("Total", Total)
                    GVTelefonia.SetFocusedRowCellValue("SubTotal", subtotal)
                End If
            End If
        End If
    End Sub
End Class


