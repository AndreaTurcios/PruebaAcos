Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports CajaBL
Imports System.Math

Public Class apo_frmLiquidacionAportacion
    Dim blAdmon As New AdmonBLL()
    Dim blAporta As New AportacionesBLL()
    Dim blAsoc As New AsociadosBLL()
    Dim blPres As New PrestamosBLL()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()
    'Dim blcaja As New CajaBusiness()


    Private Sub frmRetiroAportaciones_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _FormaPago.Focus()
        _OtrosProductos.EditValue = 0.0
        _OtrosProductos.EditValue = 0.0
        _ProvisionIncobrable.EditValue = 0.0
    End Sub

    Private Sub frmRetiroAportaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        _FechaMov.EditValue = Today
    End Sub

    Private Sub CargaCombos()
        objCombos.coo_FormasPagoCaja(_FormaPago, "")
        objCombos.coo_TipoAportacion(_TipoAportacion)
        objCombos.coo_TipoRetiro(leTipoRetiro, "")
        _OtrosProductos.EditValue = 0.0
        _OtrosProductos.EditValue = 0.0
        _ProvisionIncobrable.EditValue = 0.0
    End Sub


    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim SaldoFiador As Decimal = 0.0
        Dim entAso As coo_Asociados
        entAso = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        SaldoFiador = blPres.GetSaldoAsociadoFiador(entAso.NumeroDocumento, _FechaMov.EditValue)
        'If SaldoFiador > 0.0 Then
        '    MsgBox("El Asociado posee Saldo Pendiente como Fiador", MsgBoxStyle.Exclamation, "Nota")
        '    Exit Sub
        'End If

        Dim msj As String = ""
        If teNumAsociado.EditValue = "" Then
            MsgBox("Número de asociado en blanco", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _Acta.EditValue = "" Then
            MsgBox("No se ha especificado el Número de Acta", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Monto.EditValue <= 0 Then
            MsgBox("El Monto a retirar de las aportaciones debe ser mayor que cero", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _LiquidoPagar.EditValue <= 0 Then
            MsgBox("Liquido a pagar debe ser mayor que cero", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If _Monto.EditValue > _saldo.EditValue Then
            MsgBox("El valor a retirar es mayor al saldo de aportaciones disponible", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _saldo.EditValue = _Monto.EditValue Then
            If MsgBox(String.Format("Está tratando de liquidar totalmente al asociado{0}Es esto correcto?{0}Favor confirme nuevamente el proceso...", Chr(13)), MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        ' el asociado no tiene liquidez para hacer retiro de aportaciones
        If teSaldoDisponible.EditValue < 0.0 Then
            Dim PorLiquidez As Decimal = 0.0
            Dim Disponible As Decimal = teSaldoDisponible.EditValue * -1
            PorLiquidez = Round(Disponible / teSaldoAportaciones.EditValue, 2) * 100

            If PorLiquidez > 20 Then
                If MsgBox("El Asociado tiene un porcentaje liquidez de " + PorLiquidez.ToString + "% de sobregiro, Desea Autorizar para Continuar ?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
                    Exit Sub
                End If

                Dim forma As New aso_frmAutoriza
                forma.tePass.EditValue = ""
                forma.ShowDialog()

                Dim ClaveAutoriza As String = forma.tePass.EditValue
                Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
                Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
                Dim inArray As Byte() = provider.ComputeHash(bytes)
                provider.Clear()

                Dim sPassWord As String = Convert.ToBase64String(inArray)
                Dim Respuesta As String = blAdmon.ValidarUsuario("GERENTE", sPassWord)

                If Respuesta <> "Ok" Then
                    MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        End If

        If _NumeroComprobante.Text = "" Then
            _NumeroComprobante.EditValue = funCaja.ObtenerCorrelativo("APORTACIONES")
        End If
        Dim entLiquidacion As New coo_LiquidacionAportaciones
        With entLiquidacion
            .IdAsociado = teIdAsociado.EditValue
            .FechaIngreso = _FechaIngCliente.EditValue
            .FechaUltMovimiento = _FechaUltMov.EditValue
            .TotalAportaciones = _saldo.EditValue
            .IdTipo = _TipoAportacion.EditValue
            .NumeroDoc = _NumeroComprobante.EditValue
            .FechaLiquidacion = _FechaMov.EditValue
            .IdFormaPago = _FormaPago.EditValue
            .TotalRetiro = _Monto.EditValue
            .NumActa = _Acta.EditValue
            .PrestamosPendientes = _PrestamosPendientes.EditValue
            .InteresesPendientes = _InteresesPendientes.EditValue
            .ProvisionIncobrable = _ProvisionIncobrable.EditValue
            .IdSucursal = gIdSucursal
            .ValorIva = _Iva.EditValue
            .Honorarios = _Honorarios.EditValue
            .OtrosProductos = _OtrosProductos.EditValue
            .LiquidoPagar = _LiquidoPagar.EditValue
            .IdTipoLiquidacion = leTipoRetiro.EditValue
            .Desembolsado = False
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now

        End With

        msj = blAporta.InsertaLiquidacionAportacion(entLiquidacion, entLiquidacion.IdAsociado, entLiquidacion.FechaLiquidacion)

        If msj = "" Then
            MsgBox("La liquidación ha sido aplicada con éxito" + Chr(13) + "Puede aplicar en caja el retiro del efectivo", MsgBoxStyle.Information, "Nota")
        Else
            MsgBox("No fue posible guardar la liquidación de Aportaciones" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If


        If MsgBox("Desea imprimir el Comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim myRpt As New apo_rptLiquidacionAportacion
            Dim sDecimal = String.Format("{0:c}", _LiquidoPagar.EditValue)
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

            myRpt.DataSource = blAporta.rptLiquidacionAportacion(_NumeroComprobante.Text, teIdAsociado.EditValue)
            myRpt.DataMember = ""
            myRpt.xrlLugarFecha.Text = cn.ObtieneParametros.Rows(0).Item("Municipio") + ", " + FechaToString(Today, Today)
            myRpt.xrlCantidadLetras.Text = Num2Text(Int(_LiquidoPagar.EditValue)) & " " & sDecimal & " DÓLARES"
            myRpt.xrlEmpresa.Text = gsNombre_Empresa
            myRpt.xrlTotalCreditos.Text = _SaldoCreditos.EditValue

            While True
                myRpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If

        GroupBox1.Enabled = False
        teNumAsociado.Focus()
        teNumAsociado.Text = ""
        _saldo.EditValue = 0
        _SaldoDebeSer.EditValue = 0
        _NumeroComprobante.Text = ""
        _FechaMov.EditValue = Today
        _Honorarios.EditValue = 0.0
        _OtrosProductos.EditValue = 0.0
        _ProvisionIncobrable.EditValue = 0.0
        _Iva.EditValue = 0.0
        _PrestamosPendientes.EditValue = 0.0
        _InteresesPendientes.EditValue = 0.0
        _Acta.EditValue = ""
        _SaldoCreditos.EditValue = 0.0
        teNumSolicitud.EditValue = ""
        teIdSolicitud.EditValue = 0
    End Sub

    Private Sub _FechaMov_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _FechaMov.Validating
        Dim meses As Integer = DateDiff(DateInterval.Month, _FechaIngCliente.EditValue, _FechaMov.EditValue)
        If meses = 0 Then meses = 1
        _SaldoDebeSer.EditValue = meses * 2.86  'cambiarlo por el parámetro
    End Sub

    Private Sub _Monto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _Monto.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _PrestamosPendientes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _PrestamosPendientes.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
      - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
    - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _InteresesPendientes_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _InteresesPendientes.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _Iva_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _Iva.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _ProvisionIncobrable_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _ProvisionIncobrable.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _Honorarios_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _Honorarios.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub _OtrosProductos_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _OtrosProductos.Validating
        _LiquidoPagar.EditValue = _Monto.EditValue - _PrestamosPendientes.EditValue _
        - _InteresesPendientes.EditValue - _Iva.EditValue - _ProvisionIncobrable.EditValue _
        - _Honorarios.EditValue - _OtrosProductos.EditValue
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim HaySolicitudCrucePendiente As Integer = blPres.ObtenerSolCrucePendiente(teIdAsociado.EditValue)

        If HaySolicitudCrucePendiente > 0 Then
            MsgBox("El asociado tiene solicitudes de cruce pendientes de autorizar.", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
            '    teDui.EditValue = .Item("NumeroDocumento")
        End With

        Dim EntAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        With EntAsociado
            _FechaIngCliente.EditValue = .FechaIngreso
            _saldo.EditValue = blAporta.GetSaldoAporta(teIdAsociado.EditValue)
            _Monto.EditValue = 0.0
            If blAporta.GetUltFechaAporta(teIdAsociado.EditValue) Is Nothing Then
                _FechaUltMov.EditValue = Today
            Else
                _FechaUltMov.EditValue = blAporta.GetUltFechaAporta(teIdAsociado.EditValue)
            End If
        End With

        Dim entSaldoCredito As DataTable = blAporta.rptSolicitudRetiro(teIdAsociado.EditValue, _FechaMov.EditValue)


        _PrestamosPendientes.EditValue = 0.0
        _SaldoCreditos.EditValue = 0.0
        teSaldoAhorros.EditValue = 0.0
        teSaldoAportaciones.EditValue = 0.0
        teSaldoDeudas.EditValue = 0.0
        teSaldoDisponible.EditValue = 0.0
        teSaldoDeudasFiador.EditValue = 0.0

        _PrestamosPendientes.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")
        _SaldoCreditos.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")

        teSaldoAhorros.EditValue = entSaldoCredito.Rows(0).Item("TotalAhorro")
        teSaldoAportaciones.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones")
        teSaldoDeudas.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")
        teSaldoDeudasFiador.EditValue = entSaldoCredito.Rows(0).Item("SaldoComoFiador")
        teSaldoDisponible.EditValue = entSaldoCredito.Rows(0).Item("LiquidezSocio")

        GroupBox1.Enabled = True

        _Honorarios.EditValue = 0.0
        _OtrosProductos.EditValue = 0.0
        _ProvisionIncobrable.EditValue = 0.0
        _Iva.EditValue = 0.0

        _InteresesPendientes.EditValue = 0.0
    End Sub

    Private Sub teNumSolicitud_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumSolicitud.ButtonClick

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        Dim IdSol As String = objConsultas.ConsultaSolicitudRetiroAprobadas(frmConsultas, dFechaContable, False)
        If IdSol = "" Then
            Exit Sub
        End If
        teIdSolicitud.EditValue = IdSol

        If Not teIdSolicitud.EditValue > 0 Then
            Exit Sub
        End If

        Dim entSol As coo_SolicitudRetiro = objTablas.coo_SolicitudRetiroSelectByPK(teIdSolicitud.EditValue)
        teNumSolicitud.EditValue = entSol.NumeroSolicitud
        teIdSolicitud.EditValue = entSol.IdSolicitud
        teIdAsociado.EditValue = entSol.IdAsociado
        _FechaMov.EditValue = entSol.FechaRetiro
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entSol.IdAsociado)
        teNumAsociado.EditValue = entAso.Numero
        teNumAsociado_Validated(e, New EventArgs)

    End Sub

    Private Sub teNumSolicitud_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumSolicitud.EditValueChanged

    End Sub
End Class




