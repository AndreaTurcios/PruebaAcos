Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL

Public Class adm_frmRecuperarArchivo
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()
    Dim blApor As New AportacionesBLL
    Dim blAho As New AhorrosBLL
    Dim dt As DataTable
    Dim fd As New FuncionesBLL
    Dim dtDescuentosEnviados As DataTable
    Dim dtDescuentosPrestamos As DataTable
    Dim dtParam As DataTable = bl.ObtieneParametros
    Dim dFecha As Date
    Dim IdAsociadoRecorrido As Integer, IdPresAnt As Integer = 0, IdMovUltAfi As Integer = 0
    Dim entAsociado As coo_Asociados
    Dim entAfiliacion As New List(Of coo_Afiliaciones)
    Dim entAportaciones As New List(Of coo_Aportaciones)
    Dim entMovFuneraria As New List(Of coo_MovFuneraria)
    Dim entReintegros As New List(Of coo_ReintegrosPlanilla)
    Dim entAhorros As New List(Of coo_CuentasAhorroMov)
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    Dim entDescuentosEnviados As New List(Of coo_DescuentosPendientesPlanilla)
    Dim blPrestamo As New Prestamo
    Dim elpagodetalle As New coo_PrestamosDetalle
    Dim blCaja As New CajaBusiness()
    'Dim IdMovUlt As Integer = 0, IdMovUltApo As Integer = 0
    'Dim IdMovAho As Integer = 0, IdMovFune As Integer = 0, IdAsociadoPago As Integer = 0

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.adm_TiposPlanilla(leTipoPlanilla, "")
        objCombos.adm_TipoArchivo(leTipoArchivo, "")
        leSucursal.EditValue = gIdSucursal
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        dt = bl.GetTablaDescuentos()
        Dim dtArchivo As New DataTable
        Dim dFechaContable As Date
        Dim TipoMov As Integer = 0
        Dim Numero As String

        dFechaContable = objFunciones.GetFechaContable(gIdSucursal)
        dtArchivo = ConstruirDatatable(btArchivoSucursal.EditValue, ",")

        For Each row As DataRow In dtArchivo.Rows

            Numero = bl.ExisteNumeroAsociado(row.Item(0))
            If Numero = "" Then
                MsgBox(String.Format("Codigo Asociado no existe {0} Imposible Continuar ", row.Item(0)), MsgBoxStyle.Critical, "Error Registro")
            End If

            IdAsociadoRecorrido = blApor.ExisteNumAsociado(Numero)

            If Numero <> "" And IdAsociadoRecorrido > 0 Then
                Dim entAsociadoRecorre As New coo_Asociados
                Dim entUbicaciones As New coo_UbicacionesAsociados
                entAsociadoRecorre = objTablas.coo_AsociadosSelectByPK(IdAsociadoRecorrido)
                entUbicaciones = objTablas.coo_UbicacionesAsociadosSelectByPK(entAsociadoRecorre.IdUbicacion)

                Dim dr As DataRow
                dr = dt.NewRow()
                dr("Numero") = row.Item(0)
                dr("Nombres") = entAsociadoRecorre.Nombres
                dr("Apellidos") = entAsociadoRecorre.Apellidos
                dr("Descuento") = row.Item(1)
                dr("IdAsociado") = IdAsociadoRecorrido
                dr("IdUbicacion") = entAsociadoRecorre.IdUbicacion
                dr("NombreUbicacion") = entUbicaciones.Nombre
                dt.Rows.Add(dr)
            End If
        Next

        gc.DataSource = dt
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

        'VERIFICO SI LA FECHA DEL PRIMER PAGO ESTA HABIL AUN
        Dim FechaDescuentosPla As Date = blPres.FechaDescuentoActiva()
        If FechaDescuentosPla = Nothing Then
            MsgBox(String.Format("No hay ninguna fecha disponible para descuentos {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Exit Sub
        End If

        'If deFecha.EditValue < FechaDescuentosPla Then
        '    MsgBox(String.Format("La fecha de recuperación es menor a la fecha del del próximo descuento {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Exit Sub
        'End If

        If gv.DataRowCount = 0 Then
            MsgBox(String.Format("Debe de cargar el archivo a aplicar"), MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de aplicar los descuentos, Ya no podra revertir los movimientos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then

            ''VERIFICO QUE LOS DESCUENTOS A APLICAR ESTEN GUARDADOS PARA APLICARLOS EN LA CARGA
            'If dtDescuentosEnviados.Rows.Count = 0 Then
            '    MsgBox(String.Format("No hay descuentos enviados con estos parametros "), MsgBoxStyle.Critical)
            '    Exit Sub
            'End If


            IdMovUltAfi = fd.ObtenerUltimoId("Coo_Afiliaciones", "IdMov")
            For i = 0 To gv.DataRowCount - 1 ' FOR DE LA LISTA DE LOS ASOCIADOS 
                Dim IdAsociadoRecorre As Integer = 0
                IdAsociadoRecorre = blApor.ExisteNumAsociado(gv.GetRowCellValue(i, "Numero"))
                dtDescuentosEnviados = bl.ExtraeDescuentosEnviados(leTipoPlanilla.EditValue, deFecha.EditValue, IdAsociadoRecorre, 0, leTipoArchivo.EditValue)

                Dim Residuo As Decimal = gv.GetRowCellValue(i, "Descuento")

                'FOR DONDE EXTRAIGO LOS DESCUENTOS DE AFILIACION, APORTACION, AHORROS Y AYUDA FUNERARIA
                For j = 0 To dtDescuentosEnviados.Rows.Count - 1
                    Dim TipoMov As Integer = dtDescuentosEnviados.Rows(j).Item("IdTipoDescuento")
                    Dim IdLineaRecorre As Integer = dtDescuentosEnviados.Rows(j).Item("IdLinea")
                    Dim IdAsociadoDesuento As Integer = dtDescuentosEnviados.Rows(j).Item("IdAsociado")
                    Dim ValorDescuento As Decimal = 0.0
                    Dim DescuentoEnviado As Decimal = dtDescuentosEnviados.Rows(j).Item("TotalDescontar")

                    If Residuo >= DescuentoEnviado Then
                        ValorDescuento = DescuentoEnviado
                        Residuo = Residuo - DescuentoEnviado
                    Else
                        ValorDescuento = Residuo
                        Residuo = 0.0
                    End If

                    Select Case TipoMov
                        Case 0 ' EXCLUIVO PARA LAS AFILIACIONES
                            Dim entDetalle As New coo_Afiliaciones
                            With entDetalle
                                .IdMov = IdMovUltAfi + 1
                                .IdAsociado = IdAsociadoDesuento
                                .FechaGeneracion = deFecha.EditValue
                                .FechaAplicacion = objFunciones.GetFechaContable(gIdSucursal)
                                .CuotaIngreso = ValorDescuento
                                .AporteInicial = 0.0
                                .Papeleria = 0.0
                                .TramitesIngreso = 0.0
                                .Otros = 0.0
                                .Concepto = "DESCUENTO DE AFILIACION POR PLANILLA "
                                .IdFormaPago = 6
                                .IdSucursal = leSucursal.EditValue
                                .Aplicado = True
                                .CreadoPor = objMenu.User
                                IdMovUltAfi = IdMovUltAfi + 1
                            End With
                            entAfiliacion.Add(entDetalle)

                            'RELLENO LA ENTIDAD DE LOS DESCUENTOS QUE SE ENVIARON PARA SABER SI CUBRE O NO
                            'EL VALOR QUE SE LE MANDO Y VER SI QUEDA PENDIENTE DE CUBRIR ESE DESCUENTO
                            Dim entDetEnvAfi As New coo_DescuentosPendientesPlanilla
                            With entDetEnvAfi
                                .IdAsociado = IdAsociadoDesuento
                                .FechaAplicacion = dtDescuentosEnviados.Rows(j).Item("FechaAplicacion")
                                .IdLinea = dtDescuentosEnviados.Rows(j).Item("IdLinea")
                                .IdTipoDescuento = dtDescuentosEnviados.Rows(j).Item("IdTipoDescuento")
                                .IdPrestamo = dtDescuentosEnviados.Rows(j).Item("IdPrestamo")
                                .TotalDescontar = dtDescuentosEnviados.Rows(j).Item("TotalDescontar")
                                .DescuentoReal = ValorDescuento
                                .DescuentoPendiente = dtDescuentosEnviados.Rows(j).Item("DescuentoPendiente")
                                .IdPlanillaDescuento = dtDescuentosEnviados.Rows(j).Item("IdPlanillaDescuento")
                                .CreadoPor = dtDescuentosEnviados.Rows(j).Item("CreadoPor")
                                .FechaHoraCreacion = dtDescuentosEnviados.Rows(j).Item("FechaHoraCreacion")
                                .IdDetalle = dtDescuentosEnviados.Rows(j).Item("IdDetalle")
                            End With
                            entDescuentosEnviados.Add(entDetEnvAfi)

                        Case 1
                            Dim entDetalle2 As New coo_Aportaciones
                            With entDetalle2
                                .IdAsociado = IdAsociadoDesuento
                                .IdMov = blApor.GetUltMovAporta(IdAsociadoDesuento) + 1
                                .IdTipo = 1
                                .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .IdFormaPago = 6
                                .Cargo = 0.0
                                .Abono = ValorDescuento
                                .Saldo = blApor.GetSaldoAporta(IdAsociadoDesuento) + ValorDescuento
                                .LineaLibreta = blApor.GetUltLineaAporta(IdAsociadoDesuento) + 1
                                .Impreso = False
                                .IdSucursal = gIdSucursal
                                .FechaContable = objFunciones.GetFechaContable(gIdSucursal)

                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now

                            End With
                            entAportaciones.Add(entDetalle2)

                            'RELLENO LA ENTIDAD DE LOS DESCUENTOS QUE SE ENVIARON PARA SABER SI CUBRE O NO
                            'EL VALOR QUE SE LE MANDO Y VER SI QUEDA PENDIENTE DE CUBRIR ESE DESCUENTO
                            Dim entDetEnvApo As New coo_DescuentosPendientesPlanilla
                            With entDetEnvApo
                                .IdAsociado = IdAsociadoDesuento
                                .FechaAplicacion = dtDescuentosEnviados.Rows(j).Item("FechaAplicacion")
                                .IdLinea = dtDescuentosEnviados.Rows(j).Item("IdLinea")
                                .IdTipoDescuento = dtDescuentosEnviados.Rows(j).Item("IdTipoDescuento")
                                .IdPrestamo = dtDescuentosEnviados.Rows(j).Item("IdPrestamo")
                                .TotalDescontar = dtDescuentosEnviados.Rows(j).Item("TotalDescontar")
                                .DescuentoReal = ValorDescuento
                                .DescuentoPendiente = dtDescuentosEnviados.Rows(j).Item("DescuentoPendiente")
                                .IdPlanillaDescuento = dtDescuentosEnviados.Rows(j).Item("IdPlanillaDescuento")
                                .CreadoPor = dtDescuentosEnviados.Rows(j).Item("CreadoPor")
                                .FechaHoraCreacion = dtDescuentosEnviados.Rows(j).Item("FechaHoraCreacion")
                                .IdDetalle = dtDescuentosEnviados.Rows(j).Item("IdDetalle")
                            End With
                            entDescuentosEnviados.Add(entDetEnvApo)

                        Case 3
                            Dim entDetalle3 As New coo_CuentasAhorroMov
                            With entDetalle3
                                .IdCuenta = blAho.GetCuentaAhorroCorriente(IdAsociadoDesuento)
                                .IdMov = blAho.GetUltMovAhorro(.IdCuenta) + 1
                                .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                                .Fecha = deFecha.EditValue
                                .IdTipo = 1
                                .Valor = ValorDescuento
                                .Saldo = blAho.GetSaldoAhorro(.IdCuenta) + ValorDescuento
                                .LineaLibreta = blAho.GetUltLineaAhorro(IdAsociadoDesuento) + 1
                                .IdFormaPago = 6
                                .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                                .IdSucursal = gIdSucursal
                                .Pignorado = False
                                .Observaciones = "APLICACION DE PLANILLA " + leTipoPlanilla.Text + " " + deFecha.ToString
                                .Impreso = False
                                .IdAutorizado = IdAsociadoDesuento
                                .DocAutorizado = ""
                                .CreadoPor = objMenu.User
                                .FechaHoraCreacion = Now
                            End With
                            entAhorros.Add(entDetalle3)

                            'RELLENO LA ENTIDAD DE LOS DESCUENTOS QUE SE ENVIARON PARA SABER SI CUBRE O NO
                            'EL VALOR QUE SE LE MANDO Y VER SI QUEDA PENDIENTE DE CUBRIR ESE DESCUENTO
                            Dim entDetEnvAho As New coo_DescuentosPendientesPlanilla
                            With entDetEnvAho
                                .IdAsociado = IdAsociadoDesuento
                                .FechaAplicacion = dtDescuentosEnviados.Rows(j).Item("FechaAplicacion")
                                .IdLinea = dtDescuentosEnviados.Rows(j).Item("IdLinea")
                                .IdTipoDescuento = dtDescuentosEnviados.Rows(j).Item("IdTipoDescuento")
                                .IdPrestamo = dtDescuentosEnviados.Rows(j).Item("IdPrestamo")
                                .TotalDescontar = dtDescuentosEnviados.Rows(j).Item("TotalDescontar")
                                .DescuentoReal = ValorDescuento
                                .DescuentoPendiente = dtDescuentosEnviados.Rows(j).Item("DescuentoPendiente")
                                .IdPlanillaDescuento = dtDescuentosEnviados.Rows(j).Item("IdPlanillaDescuento")
                                .CreadoPor = dtDescuentosEnviados.Rows(j).Item("CreadoPor")
                                .FechaHoraCreacion = dtDescuentosEnviados.Rows(j).Item("FechaHoraCreacion")
                                .IdDetalle = dtDescuentosEnviados.Rows(j).Item("IdDetalle")
                            End With
                            entDescuentosEnviados.Add(entDetEnvAho)
                    End Select
                Next

                'FOR DONDE EXTRAIGO LOS DESCUENTOS ENVIADOS DEL ASOCIADO DE PRESTAMOS Y CREDITOS

                dtDescuentosPrestamos = bl.ExtraeDescuentosEnviados(leTipoPlanilla.EditValue, deFecha.EditValue, IdAsociadoRecorre, 1, leTipoArchivo.EditValue)
                For k = 0 To dtDescuentosPrestamos.Rows.Count - 1

                    Dim IdPrestamo As Integer = dtDescuentosPrestamos.Rows(k).Item("IdPrestamo")
                    Dim IdAsoc As Integer = dtDescuentosPrestamos.Rows(k).Item("IdAsociado")
                    Dim Valor As Decimal = dtDescuentosPrestamos.Rows(k).Item("TotalDescontar")
                    Dim ValorDescuento As Decimal = 0.0
                    Dim entDetalle4 As New coo_PrestamosDetalle
                    Dim dtTasa As DataTable = blPres.ObtenerUltimasTasas(IdPrestamo)
                    Dim entPrestamo As New coo_Prestamos

                    If Residuo >= Valor Then
                        ValorDescuento = Valor
                        'Residuo = Residuo - Valor
                    Else
                        ValorDescuento = Residuo
                        'Residuo = 0.0
                    End If

                    entPrestamo = objTablas.coo_PrestamosSelectByPK(IdPrestamo)
                    ActualizaPrestamo(ValorDescuento, IdPrestamo)

                    If Residuo >= (elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion) Then
                        Residuo = Residuo - (elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion)
                    Else
                        Residuo = 0.0
                    End If


                    If elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion < ValorDescuento Then
                        With entDetalle4
                            .IdPrestamo = elpagodetalle.IdPrestamo
                            .IdMov = elpagodetalle.IdMov + 1
                            .Numero = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                            .Fecha = deFecha.EditValue
                            .TipoAplicacion = 1
                            .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                            .ImportePagado = elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion
                            .CapitalPagado = elpagodetalle.CapitalPagado
                            .SaldoCapital = blPres.GetSaldoCapitalPrestamo(IdPrestamo) - elpagodetalle.CapitalPagado
                            .DiasCalcInteres = elpagodetalle.DiasCalcInteres
                            .DiasCalcMora = elpagodetalle.DiasCalcMora
                            .InteresPagado = elpagodetalle.InteresPagado
                            .InteresPendiente = elpagodetalle.InteresPendiente
                            .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                            .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
                            .ValorSeguroPagado = 0.0
                            .ValorSeguroPendiente = 0.0
                            .ManejoPagado = 0.0
                            .ManejoPendiente = 0.0
                            .OtrosPagado = 0.0
                            .OtrosPendiente = 0.0
                            .CuotaAhorro = elpagodetalle.CuotaAhorro
                            .CuotaAportacion = elpagodetalle.CuotaAportacion
                            .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
                            .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
                            .IdFormaPago = 6
                            .IdSucursal = gIdSucursal
                            .CreadoPor = objMenu.User
                            .FechaHoraCreacion = Now
                        End With

                        'RELLENO LA ENTIDAD DE LOS DESCUENTOS QUE SE ENVIARON PARA SABER SI CUBRE O NO
                        'EL VALOR QUE SE LE MANDO Y VER SI QUEDA PENDIENTE DE CUBRIR ESE DESCUENTO
                        Dim entDetEnvPre As New coo_DescuentosPendientesPlanilla
                        With entDetEnvPre
                            .IdAsociado = IdAsoc
                            .FechaAplicacion = dtDescuentosPrestamos.Rows(k).Item("FechaAplicacion")
                            .IdLinea = dtDescuentosPrestamos.Rows(k).Item("IdLinea")
                            .IdTipoDescuento = dtDescuentosPrestamos.Rows(k).Item("IdTipoDescuento")
                            .IdPrestamo = dtDescuentosPrestamos.Rows(k).Item("IdPrestamo")
                            .TotalDescontar = dtDescuentosPrestamos.Rows(k).Item("TotalDescontar")
                            .DescuentoReal = elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion
                            .DescuentoPendiente = dtDescuentosPrestamos.Rows(k).Item("DescuentoPendiente")
                            .IdPlanillaDescuento = dtDescuentosPrestamos.Rows(k).Item("IdPlanillaDescuento")
                            .CreadoPor = dtDescuentosPrestamos.Rows(k).Item("CreadoPor")
                            .FechaHoraCreacion = dtDescuentosPrestamos.Rows(k).Item("FechaHoraCreacion")
                            .IdDetalle = dtDescuentosPrestamos.Rows(k).Item("IdDetalle")
                        End With
                        entDescuentosEnviados.Add(entDetEnvPre)

                    Else
                        With entDetalle4
                            .IdPrestamo = elpagodetalle.IdPrestamo
                            .IdMov = elpagodetalle.IdMov + 1
                            .Numero = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                            .Fecha = deFecha.EditValue
                            .TipoAplicacion = 1
                            .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                            .ImportePagado = elpagodetalle.CapitalPagado + elpagodetalle.InteresPagado + elpagodetalle.InteresMoraPagado + elpagodetalle.CuotaAhorro + elpagodetalle.CuotaAportacion  'ValorDescuento
                            .CapitalPagado = elpagodetalle.CapitalPagado
                            .SaldoCapital = blPres.GetSaldoCapitalPrestamo(IdPrestamo) - elpagodetalle.CapitalPagado
                            .DiasCalcInteres = elpagodetalle.DiasCalcInteres
                            .DiasCalcMora = elpagodetalle.DiasCalcMora
                            .InteresPagado = elpagodetalle.InteresPagado
                            .InteresPendiente = elpagodetalle.InteresPendiente
                            .InteresMoraPagado = elpagodetalle.InteresMoraPagado
                            .InteresMoraPendiente = elpagodetalle.InteresMoraPendiente
                            .ValorSeguroPagado = 0.0
                            .ValorSeguroPendiente = 0.0
                            .ManejoPagado = 0.0
                            .ManejoPendiente = 0.0
                            .OtrosPagado = 0.0
                            .OtrosPendiente = 0.0
                            .CuotaAhorro = elpagodetalle.CuotaAhorro
                            .CuotaAportacion = elpagodetalle.CuotaAportacion
                            .TasaInteres = dtTasa.Rows(0).Item("TasaInteres")
                            .TasaInteresMora = dtTasa.Rows(0).Item("TasaInteresMora")
                            .IdFormaPago = 6
                            .IdSucursal = gIdSucursal
                            .CreadoPor = objMenu.User
                            .FechaHoraCreacion = Now
                        End With

                        'RELLENO LA ENTIDAD DE LOS DESCUENTOS QUE SE ENVIARON PARA SABER SI CUBRE O NO
                        'EL VALOR QUE SE LE MANDO Y VER SI QUEDA PENDIENTE DE CUBRIR ESE DESCUENTO
                        Dim entDetEnvPre2 As New coo_DescuentosPendientesPlanilla
                        With entDetEnvPre2
                            .IdAsociado = IdAsoc
                            .FechaAplicacion = dtDescuentosPrestamos.Rows(k).Item("FechaAplicacion")
                            .IdLinea = dtDescuentosPrestamos.Rows(k).Item("IdLinea")
                            .IdTipoDescuento = dtDescuentosPrestamos.Rows(k).Item("IdTipoDescuento")
                            .IdPrestamo = dtDescuentosPrestamos.Rows(k).Item("IdPrestamo")
                            .TotalDescontar = dtDescuentosPrestamos.Rows(k).Item("TotalDescontar")
                            .DescuentoReal = ValorDescuento
                            .DescuentoPendiente = dtDescuentosPrestamos.Rows(k).Item("DescuentoPendiente")
                            .IdPlanillaDescuento = dtDescuentosPrestamos.Rows(k).Item("IdPlanillaDescuento")
                            .CreadoPor = dtDescuentosPrestamos.Rows(k).Item("CreadoPor")
                            .FechaHoraCreacion = dtDescuentosPrestamos.Rows(k).Item("FechaHoraCreacion")
                            .IdDetalle = dtDescuentosPrestamos.Rows(k).Item("IdDetalle")
                        End With
                        entDescuentosEnviados.Add(entDetEnvPre2)
                    End If
                    entPrestamos.Add(entDetalle4)

                    '' agrego las aportaciones descontadas en prestamo corriente
                    If entDetalle4.CuotaAportacion > 0.0 Then
                        Dim entDetalleApo As New coo_Aportaciones
                        With entDetalleApo
                            .IdAsociado = IdAsoc
                            .IdMov = blApor.GetUltMovAporta(IdAsoc) + 1
                            .IdTipo = 1
                            .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                            .Fecha = deFecha.EditValue
                            .IdFormaPago = 6
                            .Cargo = 0.0
                            .Abono = entDetalle4.CuotaAportacion
                            .Saldo = blApor.GetSaldoAporta(IdAsoc) + entDetalle4.CuotaAportacion
                            .LineaLibreta = blApor.GetUltLineaAporta(IdAsoc) + 1
                            .Impreso = False
                            .IdSucursal = gIdSucursal
                            .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                            .CreadoPor = objMenu.User
                            .FechaHoraCreacion = Now
                        End With
                        entAportaciones.Add(entDetalleApo)
                    End If

                    If entDetalle4.CuotaAhorro > 0.0 Then
                        Dim entDetalleAho As New coo_CuentasAhorroMov
                        With entDetalleAho
                            .IdCuenta = blAho.GetCuentaAhorroPrestamo(IdAsoc)
                            .IdMov = blAho.GetUltMovAhorro(.IdCuenta) + 1
                            .NumeroDoc = "PLA-" & Format(deFecha.EditValue, "ddMMyyyy")
                            .Fecha = deFecha.EditValue
                            .IdTipo = 1
                            .Valor = entDetalle4.CuotaAhorro
                            .Saldo = blAho.GetSaldoAhorro(.IdCuenta) + entDetalle4.CuotaAhorro
                            .LineaLibreta = blAho.GetUltLineaAhorro(IdAsoc) + 1
                            .IdFormaPago = 6
                            .FechaContable = objFunciones.GetFechaContable(gIdSucursal)
                            .IdSucursal = gIdSucursal
                            .Pignorado = False
                            .Observaciones = "APLICACION DE PLANILLA " + leTipoPlanilla.Text + " " + deFecha.ToString
                            .Impreso = False
                            .IdAutorizado = IdAsoc
                            .DocAutorizado = ""
                            .CreadoPor = objMenu.User
                            .FechaHoraCreacion = Now
                        End With
                        entAhorros.Add(entDetalleAho)
                    End If
                Next

                'CUANDO AL ASOCIADO LE DESCUENTAN DE MAS EN LA EMPRESA, GUARDO EL REGISTRO AQUI PARA LUEGO
                'QUE DESIDAN SI LO APLICAN A APORTACION, AHORRO O PRESTAMOS ETC.

                If Residuo > 0.0 Then
                    Dim entDetalleReintegro As New coo_ReintegrosPlanilla
                    With entDetalleReintegro
                        .IdMov = 0 ' se asignara en la capa de datos
                        .IdAsociado = IdAsociadoRecorre
                        .FechaAplicacion = deFecha.EditValue
                        .IdPlanillaDescuento = leTipoPlanilla.EditValue
                        .Monto = Residuo
                        .Aplicado = False
                        .CreadoPor = objMenu.User
                        .AplicadoPor = ""
                        .FechaHoraCreacion = Now
                    End With
                    entReintegros.Add(entDetalleReintegro)
                End If
            Next

            Dim msj As String = ""


            msj = blPres.InsertaDescuentos(entAfiliacion, entAportaciones, entMovFuneraria _
            , entAhorros, entPrestamos, entReintegros, entDescuentosEnviados, leTipoPlanilla.EditValue, 1, objFunciones.GetFechaContable(gIdSucursal), objMenu.User)


            If msj = "" Then
                MsgBox("Los Descuentos han sido guardados con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If

            Close()
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
                    .InteresPendiente = blPrestamo.PagoActual.ImporteDeudaInteres
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
        rpt.DataSource = gc.DataSource
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo.Text = "PLANILLA DE DESCUENTOS " + leTipoPlanilla.Text
        rpt.xrlFecha.Text = "FECHA A CARGAR PLANILLA" & FechaToString(deFecha.EditValue, deFecha.EditValue).ToUpper
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        If MsgBox("Está seguro(a) de generar la partida contable?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj2 As String = ""
            msj2 = blPres.PartidaCargaPlanilla(leTipoPlanilla.EditValue, deFecha.EditValue, objMenu.User)
            If msj2 = "Ok" Then
                MsgBox("La Partida  ha sido generada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj2), MsgBoxStyle.Critical)
                Return
            End If
        End If

    End Sub

    Private Sub btArchivoSucursal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btArchivoSucursal.EditValueChanged

    End Sub
End Class


