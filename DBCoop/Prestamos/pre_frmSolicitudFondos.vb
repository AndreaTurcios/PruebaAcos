Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Diagnostics
Public Class pre_frmSolicitudFondos
    Dim entSolicitudFondo As New coo_SolicitudFondos, entSolicitudCredito As New coo_Solicitudes, entResolucion As New coo_Resoluciones
    Dim entSaldoFondoSolicitud As New coo_SaldoFondoSolicitud

    Dim blPres As New PrestamosBLL()
    Dim blAhorro As New AhorrosBLL

    Dim entRefinancia As List(Of coo_SolicitudFondosRefinancia)
    Dim entDeduccion As List(Of coo_SolicitudFondosDeducciones)


    Private Sub pre_frmSolicitudFondos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_AporteCapitalizacion(cboCapitalizacion, "")
        CargaControles()
        teIva.Properties.ReadOnly = True
        teTotalDeducciones.Properties.ReadOnly = True
        teIdCuenta.Properties.ReadOnly = True
        teIdSolicitud.Properties.ReadOnly = True
        seNumeroDesembolso.Properties.ReadOnly = True
        teRefinancia.Properties.ReadOnly = True
        beNoSolicitud.Focus()
    End Sub

    Private Sub CargaControles()
        teIdSolicitud.EditValue = 0
        beNoSolicitud.EditValue = ""
        seNumeroDesembolso.EditValue = 1
        deFechaEntrega.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        teMontoDesembolso.EditValue = 0.0
        seTasaCapitalizacion.EditValue = 0.0
        cboCapitalizacion.EditValue = 1
        teAportacion.EditValue = 0.0
        sePorcentajeAhorro.EditValue = 0.0
        teAhorro.EditValue = 0.0
        beNumeroCuenta.EditValue = ""
        teIdCuenta.EditValue = 0
        teIva.EditValue = 0.0
        teTotalDeducciones.EditValue = 0.0
    End Sub

    Private Sub beNoSolicitud_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNoSolicitud.ButtonClick
        frmConsultaSolicitudesAprobadas.SoloPendientes = True
        frmConsultaSolicitudesAprobadas.Text = "Consulta de solicitudes aprobadas y pendientes de desembolsar"
        frmConsultaSolicitudesAprobadas.ShowDialog()

        beNoSolicitud.EditValue = frmConsultaSolicitudesAprobadas.NoSolicitud
        teIdSolicitud.EditValue = frmConsultaSolicitudesAprobadas.IdSolicitud
        beNoSolicitud_Validated(e, New EventArgs)
    End Sub

    Private Sub beNoSolicitud_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNoSolicitud.Validated
        'obtienendo el id de la solicitud
        If beNoSolicitud.EditValue = "" Then
            Exit Sub
        End If

        If teIdSolicitud.EditValue = 0 Then 'es porque se ha ingresado manualmente el número
            teIdSolicitud.EditValue = blPres.ExisteNumeroSolicitud(beNoSolicitud.EditValue)
            If teIdSolicitud.EditValue = 0 Then
                MsgBox("El número de solicitud ingresado no existe", MsgBoxStyle.Critical, "Error")
                beNoSolicitud.Focus()
                Exit Sub
            End If
        End If
        'se llenan todas las entidades
        entSolicitudCredito = objTablas.coo_SolicitudesSelectByPK(teIdSolicitud.EditValue)
        entResolucion = objTablas.coo_ResolucionesSelectByPK(teIdSolicitud.EditValue)
        entSaldoFondoSolicitud = blPres.coo_SaldoFondoSolicitud(teIdSolicitud.EditValue)

        If entResolucion.IdEstado <> 2 Then
            MsgBox("La solicitud no ha sido aprobada", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entSaldoFondoSolicitud.Desembolsado >= entResolucion.MontoAprobado Then
            MsgBox("No es posible realizar mas desembolsos, la solicitud ya fue desembolsada totalmente", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entSolicitudCredito.IdAsociado)
        teNombre.EditValue = String.Format("{0} - {1} {2}", entAsociados.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        seNumeroDesembolso.EditValue = entSaldoFondoSolicitud.IdDesembolso + 1
        teMontoDesembolso.EditValue = entResolucion.MontoAprobado - entSaldoFondoSolicitud.Desembolsado
        gcDeducciones.DataSource = blPres.GetDeducciones(teMontoDesembolso.EditValue)
        CalcularTotales()
    End Sub

    Private Sub teMontoDesembolso_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teMontoDesembolso.Validated
        'entSaldoFondoSolicitud = objTablas.coo_SaldoFondoSolicitud(IdSolicitud)
        'Dim entResolucion As coo_Resoluciones = objTablas.coo_ResolucionesSelectByPK(IdSolicitud)

        If teMontoDesembolso.EditValue > (entResolucion.MontoAprobado - entSaldoFondoSolicitud.Desembolsado) Then
            MsgBox("El Monto a Entregar es mayor al pendiente de Desembolsar", MsgBoxStyle.Critical, "Error")
            teMontoDesembolso.EditValue = (entResolucion.MontoAprobado - entSaldoFondoSolicitud.Desembolsado)
            Exit Sub
        End If
        teAhorro.EditValue = Decimal.Round(teMontoDesembolso.EditValue * (sePorcentajeAhorro.EditValue / 100), 2)
        gcDeducciones.DataSource = blPres.GetDeducciones(teMontoDesembolso.EditValue)
        CalcularTotales()
    End Sub

    Private Sub sePorcentajeAhorro_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles sePorcentajeAhorro.EditValueChanged
        teMontoDesembolso_Validated(teMontoDesembolso, New System.EventArgs)
    End Sub

    Private Sub CalcularTotales()
        gvDeducciones.UpdateTotalSummary()
        teTotalDeducciones.EditValue = Me.gcValor.SummaryItem.SummaryValue
        teIva.EditValue = Decimal.Round(Me.gcGravado.SummaryItem.SummaryValue * pnIVA, 2)
        gvRefinancia.UpdateTotalSummary()
        teRefinancia.EditValue = Me.gcCapital.SummaryItem.SummaryValue + Me.gcInteres.SummaryItem.SummaryValue + Me.gcMoratorio.SummaryItem.SummaryValue + Me.gcSeguro.SummaryItem.SummaryValue + Me.gcOtros.SummaryItem.SummaryValue
    End Sub

    Private Sub gvDeducciones_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvDeducciones.RowUpdated
        CalcularTotales()
    End Sub

    Private Sub gvDeducciones_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvDeducciones.ValidateRow
        If gvDeducciones.GetFocusedRowCellValue(gvDeducciones.Columns("AplicaIva")) = True Then
            gvDeducciones.SetFocusedRowCellValue("Gravado", gvDeducciones.GetFocusedRowCellValue(gvDeducciones.Columns("Valor")))
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click

        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        msj = blPres.InsertaSolicitudFondo(entSolicitudFondo, entRefinancia, entDeduccion)
        If msj = "" Then
            MsgBox("La solicitud de fondo ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible actualizar la solciitud de fondos{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If
        Dim rpt As New pre_rptSolicitudFondos
        rpt.DataSource = blPres.rptSolicitudFondos(entSolicitudFondo.IdSolicitudFondo)
        rpt.DataMember = ""
        rpt.XrSubreport1.ReportSource.DataSource = blPres.rptFiadores(teIdSolicitud.EditValue)
        rpt.XrSubreport1.ReportSource.DataMember = ""

        rpt.XrSubreport2.ReportSource.DataSource = blPres.rptSolicitudPrestamoGarantia(teIdSolicitud.EditValue)
        rpt.XrSubreport2.ReportSource.DataMember = ""

        rpt.XrSubreport3.ReportSource.DataSource = blPres.rptRefinanciamiento(entSolicitudFondo.IdSolicitudFondo)
        rpt.XrSubreport3.ReportSource.DataMember = ""

        rpt.XrSubreport4.ReportSource.DataSource = blPres.rptDeducciones(entSolicitudFondo.IdSolicitudFondo)
        rpt.XrSubreport4.ReportSource.DataMember = ""

        rpt.XrSubreport5.ReportSource.DataSource = blPres.GetEmisionDesembolso(entSolicitudFondo.IdSolicitud)
        rpt.XrSubreport5.ReportSource.DataMember = ""
        rpt.ShowPreviewDialog()

        MsgBox("Se imprimirá ahora la hoja de liquidación", MsgBoxStyle.Information, "Nota")
        Dim rptLP As New pre_rptLiquidacionPrestamo
        rptLP.DataSource = blPres.rptLiquidacionPrestamo(entSolicitudFondo.IdSolicitudFondo)
        rptLP.DataMember = ""
        rptLP.XrSubreport4.ReportSource.DataSource = blPres.rptDeducciones(entSolicitudFondo.IdSolicitudFondo)
        rptLP.XrSubreport4.ReportSource.DataMember = ""
        rptLP.XrSubreport1.ReportSource.DataSource = blPres.rptPrestamosLiquidaFondos(entSolicitudFondo.IdSolicitudFondo)
        rptLP.XrSubreport1.ReportSource.DataMember = ""
        rptLP.xrlEmpresa.Text = gsNombre_Empresa
        rptLP.ShowPreviewDialog()
        beNoSolicitud.Focus()
        CargaControles()
        Close()
    End Sub

    Function DatosValidos() As Boolean

        If beNoSolicitud.EditValue = "" Then
            MsgBox(String.Format("No se ha especificado el número de solicitud{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            beNoSolicitud.Focus()
            Return False
        End If
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal), TotalRefinancia As Decimal = 0.0, Capitalizacion As Decimal = 0.0, Liquido As Decimal = 0.0

        entSaldoFondoSolicitud = blPres.coo_SaldoFondoSolicitud(teIdSolicitud.EditValue)
        gvRefinancia.UpdateTotalSummary()
        TotalRefinancia = Me.gcCapital.SummaryItem.SummaryValue + Me.gcInteres.SummaryItem.SummaryValue + Me.gcMoratorio.SummaryItem.SummaryValue + Me.gcSeguro.SummaryItem.SummaryValue + Me.gcOtros.SummaryItem.SummaryValue
        If cboCapitalizacion.EditValue = 1 Then
            Capitalizacion = Decimal.Round(entResolucion.MontoAprobado * (seTasaCapitalizacion.EditValue / 100), 2)
        Else
            Capitalizacion = Decimal.Round(teMontoDesembolso.EditValue * (seTasaCapitalizacion.EditValue / 100), 2)
        End If
        Liquido = teMontoDesembolso.EditValue - (Capitalizacion + teAportacion.EditValue + teAhorro.EditValue + teTotalDeducciones.EditValue + teIva.EditValue)

        entSolicitudCredito = objTablas.coo_SolicitudesSelectByPK(teIdSolicitud.EditValue)
        Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entSolicitudCredito.IdLinea)
        'Dim dt As DataTable = blPres.GetSaldoPrestamoAsociado(entSolicitudCredito.IdAsociado, deFechaEntrega.EditValue, entLinea.IdLinea, 0, 0)

        ''VALIDO QUE NO TENGA OTRO CREDITO A LARGO PLAZO, TIENE QUE REFINANCIAR PARA CONTINUAR
        'If dt.Rows.Count > 0 Then
        '    If entLinea.TipoLinea = 2 And teRefinancia.EditValue = 0.0 Then
        '        MsgBox("El asociado ya tiene un prestamo a largo plazo" + Chr(13) + "debe refinanciar para Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '        Return False
        '    End If
        'End If

        If seNumeroDesembolso.EditValue = 0 Then
            MsgBox("El número de desembolso debe ser mayor a cero" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNoSolicitud.Focus()
            Return False
        End If

        If SiEsNulo(deFechaEntrega.EditValue, Nothing) = Nothing Then
            MsgBox("Debe especificar la fecha de entrega del desembolso" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFechaEntrega.Focus()
            Return False
        End If

        If teAportacion.EditValue < 0.0 Then
            MsgBox("El Valor de la Aportación debe ser mayor que 0" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teAportacion.Focus()
            Return False
        End If

        'If deFechaEntrega.EditValue < dFechaContable Then
        '    MsgBox("La fecha de entrega no puede ser menor al cierre contable" + Chr(13) + "Fecha contable: " + Format(dFechaContable, "dd/MM/yyyy"), MsgBoxStyle.Critical, "Error de usuario")
        '    Return False
        'End If

        'If deFechaEntrega.EditValue < entResolucion.FechaAprobacion Then
        '    MsgBox("La Fecha de Entrega no puede ser Inferior a la fecha de Aprobación", MsgBoxStyle.Critical, "Error de usuario")
        '    Return False
        'End If
        If teMontoDesembolso.EditValue <= 0 Then
            MsgBox("El Monto a desembolsar no es Válido" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teMontoDesembolso.Focus()
            Return False
        End If
        If teAhorro.EditValue > 0 And teIdCuenta.EditValue = 0 Then
            MsgBox("No se ha especificado el número de cuenta de Ahorro" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNumeroCuenta.Focus()
            Return False
        End If
        If Liquido < 0.0 Then
            MsgBox("El Total de Deducciones exceden al Monto a Desembolsar" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            beNumeroCuenta.Focus()
            Return False
        End If
        If entSolicitudCredito.Numero = "" Then
            MsgBox("La Solicitud de Crédito No Existe", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If entResolucion.IdEstado <> 2 Then
            MsgBox("La Solicitud no ha sido Aprobada", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If teMontoDesembolso.EditValue > (entResolucion.MontoAprobado - entSaldoFondoSolicitud.Desembolsado) Then
            MsgBox("El Monto a Entregar es mayor al pendiente de Desembolsar", MsgBoxStyle.Critical, "Error")
            teMontoDesembolso.EditValue = (entResolucion.MontoAprobado - entSaldoFondoSolicitud.Desembolsado)
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entSolicitudFondo
            .IdSolicitud = entSolicitudCredito.IdSolicitud
            .IdDesembolso = seNumeroDesembolso.EditValue
            .IdAsociado = entSolicitudCredito.IdAsociado
            .MontoDesembolso = teMontoDesembolso.EditValue
            .FechaEntrega = deFechaEntrega.EditValue
            If cboCapitalizacion.EditValue = 1 Then
                .Capitalizacion = Decimal.Round(entResolucion.MontoAprobado * (seTasaCapitalizacion.EditValue / 100), 2)
            Else
                .Capitalizacion = Decimal.Round(teMontoDesembolso.EditValue * (seTasaCapitalizacion.EditValue / 100), 2)
            End If
            .Aportacion = teAportacion.EditValue
            .TotalOtrasDeducciones = teTotalDeducciones.EditValue
            .Iva = teIva.EditValue
            .Ahorro = teAhorro.EditValue
            .IdCuenta = teIdCuenta.EditValue
            .Entregado = False
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            gvRefinancia.UpdateTotalSummary()
            .TotalRefinanciamiento = teRefinancia.EditValue
        End With
        entRefinancia = New List(Of coo_SolicitudFondosRefinancia)
        For i = 0 To gvRefinancia.DataRowCount - 1
            Dim entDetalle As New coo_SolicitudFondosRefinancia
            With entDetalle
                .IdSolicitudFondo = 0  ' Se asigna en la capa de datos
                .IdPrestamo = gvRefinancia.GetRowCellValue(i, "IdPrestamo")
                .Idsolicitud = entSolicitudCredito.IdSolicitud
                .SaldoCapital = gvRefinancia.GetRowCellValue(i, "SaldoCapital")
                .SaldoInteres = gvRefinancia.GetRowCellValue(i, "SaldoInteres")
                .SaldoInteresMoratorio = gvRefinancia.GetRowCellValue(i, "SaldoInteresMora")
                .SaldoSeguro = gvRefinancia.GetRowCellValue(i, "SaldoSeguro")
                .SaldoOtros = gvRefinancia.GetRowCellValue(i, "SaldoOtros")
            End With
            entRefinancia.Add(entDetalle)
        Next

        entDeduccion = New List(Of coo_SolicitudFondosDeducciones)
        For i = 0 To gvDeducciones.DataRowCount - 1
            Dim entDetalleA As New coo_SolicitudFondosDeducciones
            With entDetalleA
                .IdSolicitudFondo = 0  'Se asigna en la capa de datos
                .IdSolicitud = teIdSolicitud.EditValue
                .IdDeduccion = gvDeducciones.GetRowCellValue(i, "IdDeduccion")
                .Valor = gvDeducciones.GetRowCellValue(i, "Valor")
            End With
            entDeduccion.Add(entDetalleA)
        Next
    End Sub
    Private Sub btNumeroCuenta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroCuenta.ButtonClick
        beNumeroCuenta.EditValue = objConsultas.ConsultaCuentaCorriente(frmConsultas, entSolicitudCredito.IdAsociado)
        beNumeroCuenta_Validated(e, New EventArgs)
    End Sub
    Private Sub beNumeroCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuenta.Validated
        If beNumeroCuenta.EditValue = "" Then
            Exit Sub
        End If
        teIdCuenta.EditValue = blAhorro.ObtenerIdCuentaByNumero(beNumeroCuenta.EditValue)

        Dim entCuentaCorriente As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entCuentaCorriente.Numero = "" Then
            MsgBox("No existe el número de Cuenta", MsgBoxStyle.Critical, "Error")
            teIdCuenta.EditValue = 0
            beNumeroCuenta.EditValue = ""
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        If entSolicitudCredito.IdAsociado <> entCuentaCorriente.IdAsociado Then
            MsgBox("La cuenta no corresponde al asociado", MsgBoxStyle.Critical, "Error")
            teIdCuenta.EditValue = 0
            beNumeroCuenta.EditValue = ""
            beNumeroCuenta.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub sbCalcular_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbCalcular.Click
        gcRefinancia.DataSource = blPres.GetSaldoPrestamoAsociado(entSolicitudCredito.IdAsociado, deFechaEntrega.EditValue, -1, 0, 0)
        CalcularTotales()
    End Sub

    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbEliminar.Click
        If MsgBox("Desea eliminar el préstamo de la Solicitud de Fondos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar") = MsgBoxResult.Yes Then
            gvRefinancia.DeleteRow(gvRefinancia.FocusedRowHandle)
            CalcularTotales()
        End If
    End Sub

    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

    Private Sub gvRefinancia_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvRefinancia.ValidatingEditor
        Select Case gvRefinancia.FocusedColumn.FieldName
            Case "SaldoSeguro"
                gvRefinancia.SetRowCellValue(gvRefinancia.FocusedRowHandle, "SaldoSeguro", e.Value)
                gvDeducciones.UpdateTotalSummary()
                CalcularTotales()
        End Select
    End Sub
End Class