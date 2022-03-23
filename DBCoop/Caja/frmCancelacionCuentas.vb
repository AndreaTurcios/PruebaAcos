Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmCancelacionCuentas
    Dim blCaja As New CajaBusiness()
    Dim EntCuentaAhorro As coo_CuentasAhorro
    Dim EntUltMovAhorro As coo_UltMovAhorro
    Dim entCapitalizacion As coo_CapitalizacionAhorro
    Dim entTipoCuenta As coo_TiposCuentaAhorro, IdCuenta As Integer
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub frmCancelacionCuentas_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        _NroCtaAhorro.Focus()
    End Sub

    Private Sub frmCancelacionCuentas_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmCancelacionCuentas_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        _fecRetiro.EditValue = blCaja.GetFechaContable(gIdSucursal)
        teMonto.EditValue = 0.0
        _Tasa.EditValue = 0.0
    End Sub

    Private Sub CargaCombos()
        objCombos.cooPtmoFmaPago(_FormaPago)
        objCombos.cooTipoDocumento(_TipoDocPtdo)
    End Sub

    Private Sub _NroCtaAhorro_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _NroCtaAhorro.ButtonClick
        frmConsultaCuentasAhorro.ShowDialog()
        _NroCtaAhorro.EditValue = frmConsultaCuentasAhorro.Numero
        _NroCtaAhorro_Validated(e, New EventArgs)
    End Sub

    Private Sub _NroCtaAhorro_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _NroCtaAhorro.Validated
        Dim entPignorado As New coo_Pignoraciones
        Dim Pignorado As Decimal = 0.0

        If SiEsNulo(_NroCtaAhorro.EditValue, "") = "" Then
            Exit Sub
        End If
        IdCuenta = blcaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)
        If IdCuenta = 0 Then
            MsgBox("No se encuentra registrada ningúna cuenta con éste número", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        IdCuenta = blcaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)

        entPignorado = blcaja.coo_PignoracionesSelectByCuenta(IdCuenta)

        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(IdCuenta)
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(EntCuentaAhorro.IdTipoCuenta)
        EntUltMovAhorro = blcaja.coo_UltMovAhorroSelectBy(EntCuentaAhorro.IdCuenta)
        If entPignorado.IdCuenta > 0 Then
            Pignorado = entPignorado.Valor
        End If

        If entTipoCuenta.TipoAhorro = 1 Then
            entCapitalizacion = blCaja.coo_CapitalizacionAhorroCancelacion(EntCuentaAhorro.IdCuenta, _fecRetiro.EditValue, _Tasa.EditValue)
        End If



        With EntCuentaAhorro
            Dim elAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(.IdAsociado)
            _NombreCliente.EditValue = elAsociado.Nombres + " " + elAsociado.Apellidos
            _Saldo.EditValue = EntUltMovAhorro.SaldoActual
            _saldoDisponible.EditValue = EntUltMovAhorro.SaldoDisponible - Pignorado
            deFechaUlt.EditValue = Format(EntUltMovAhorro.Fecha, "dd/MM/yyyy")
            _LineaLibreta.EditValue = EntUltMovAhorro.Linea
            teMonto.EditValue = EntUltMovAhorro.SaldoActual
            _NroDocumento.EditValue = elAsociado.NumeroDocumento
            _TipoDocPtdo.EditValue = elAsociado.IdTipoDocumento
            _Tasa.EditValue = entTipoCuenta.TasaInteres

            If entTipoCuenta.TipoAhorro = 1 Then
                teInteres.EditValue = entCapitalizacion.SaldoInteres
                teISR.EditValue = entCapitalizacion.SaldoIsr
            Else
                teInteres.EditValue = 0.0
                teISR.EditValue = 0.0
            End If
        End With
        objCombos.cooAutorizadoCuenta(_PersonaAutorizada, "IdCuenta=" & EntCuentaAhorro.IdCuenta)
    End Sub

    Private Sub _fecRetiro_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles _fecRetiro.Validated
        If _fecRetiro.EditValue < deFechaUlt.EditValue Then
            MsgBox("Fecha de pago incorrecta", MsgBoxStyle.Critical)
            Exit Sub
        End If
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(IdCuenta)
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(EntCuentaAhorro.IdTipoCuenta)
        If entTipoCuenta.TipoAhorro = 1 Then
            entCapitalizacion = blCaja.coo_CapitalizacionAhorroCancelacion(EntCuentaAhorro.IdCuenta, _fecRetiro.EditValue, _Tasa.EditValue)
            teInteres.EditValue = entCapitalizacion.SaldoInteres
            teISR.EditValue = entCapitalizacion.SaldoIsr
        Else
            teInteres.EditValue = 0.0
            teISR.EditValue = 0.0
        End If
    End Sub

    Private Sub _PersonaAutorizada_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _PersonaAutorizada.EditValueChanged
        _DocIdentidad.EditValue = blcaja.ObtenerDocAutorizado(_PersonaAutorizada.EditValue)
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim msj As String = ""

        If _Tasa.EditValue = 0 Then
            MsgBox("Debe de especificar la tasa de interes para cancelar la cuenta", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If _NroCtaAhorro.Text = "" Then
            MsgBox("Número de cuenta en blanco", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _NroComprobante.Text = "" Then
            _NroComprobante.EditValue = gIdSucursal.ToString.PadLeft(2, "0") & "-" & (entSucursal.CorrelativoRetiro + 1).ToString.PadLeft(6, "0")
        End If
        If _fecRetiro.Text = "" Then
            MsgBox("Fecha de cancelación no puede quedar en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If teMonto.EditValue <= 0 Then
            MsgBox("Monto en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _fecRetiro.EditValue < deFechaUlt.EditValue Then
            MsgBox("Fecha de cancelación incorrecta", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If teMonto.EditValue > _saldoDisponible.EditValue Then
            MsgBox("No puede retirar mas de su disponible", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _PersonaAutorizada.EditValue > 0 And _DocIdentidad.Text = "" Then
            MsgBox("Documento de identidad en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(IdCuenta)
        Dim entInteres As New coo_CuentasAhorroMov
        Dim entIsr As New coo_IsrInteres
        Dim entCuentaAhorroMov As New coo_CuentasAhorroMov

        If teInteres.EditValue > 0.0 Then
            With entInteres
                .IdCuenta = IdCuenta
                .IdMov = EntUltMovAhorro.IdMov + 1
                .NumeroDoc = "IN-" & _NroComprobante.EditValue
                .Fecha = _fecRetiro.EditValue
                .IdTipo = 4  'el 4 representa los inereses pagados a las cuentas de ahorro a la vista
                .Valor = teInteres.EditValue
                .Saldo = _Saldo.EditValue + teInteres.EditValue
                .LineaLibreta = _LineaLibreta.EditValue + 1
                .IdFormaPago = _FormaPago.EditValue
                .FechaContable = _fecRetiro.EditValue 'blCaja.GetFechaContable(gIdSucursal)
                .IdSucursal = gIdSucursal
                .Pignorado = False
                .Observaciones = "CAPITALIZACION DE INTERESES POR CANCELACION"
                .Impreso = False
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .IdAutorizado = _PersonaAutorizada.EditValue
                .DocAutorizado = _DocIdentidad.Text
            End With
        End If

        With entCuentaAhorroMov
            .IdCuenta = IdCuenta
            If teInteres.EditValue > 0.0 Then
                .IdMov = EntUltMovAhorro.IdMov + 2
                .LineaLibreta = _LineaLibreta.EditValue + 2
            Else
                .IdMov = EntUltMovAhorro.IdMov + 1
                .LineaLibreta = _LineaLibreta.EditValue + 1
            End If
            .NumeroDoc = _NroComprobante.EditValue
            .Fecha = _fecRetiro.EditValue
            .IdTipo = 2
            .Valor = teMonto.EditValue + teInteres.EditValue
            .Saldo = 0.0
            .IdFormaPago = _FormaPago.EditValue
            .FechaContable = _fecRetiro.EditValue 'blCaja.GetFechaContable(gIdSucursal)
            .IdSucursal = gIdSucursal
            .Pignorado = False
            .Observaciones = "CANCELACION DE CUENTA DE AHORRO"
            .Impreso = False
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .IdAutorizado = _PersonaAutorizada.EditValue
            .DocAutorizado = _DocIdentidad.Text
        End With

        With entIsr
            .IdCuenta = IdCuenta
            .Mes = Month(_fecRetiro.EditValue)
            .Ejercicio = Year(_fecRetiro.EditValue)
            .Fecha = _fecRetiro.EditValue
            .IdAsociado = EntCuentaAhorro.IdAsociado
            .Saldo = teMonto.EditValue
            .Interes = teInteres.EditValue
            .Isr = teISR.EditValue
            .Idtipo = 4
        End With

        If blCaja.ExisteComprobanteRetiro(entCuentaAhorroMov.NumeroDoc) <> "" Then
            MsgBox("Numero de Comprobante ya Existe", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If

        msj = blCaja.InsertaCancelacionAhorro(entCuentaAhorroMov, entInteres, entIsr, gIdSucursal)

        If msj = "" Then
            MsgBox("El Retiro de Ahorro ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("No fue posible guardar el Retiro de Ahorro" + Chr(13) + msj, MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("¿Actualizar Libreta de Ahorros ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If gsNombre_Empresa.StartsWith("ACAPRO") Then
                ActualizaLibretaAhorroPorCodigo(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            Else
                ImprimeLibretaAhorro(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            End If
        End If

        If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim myRpt3 As New rptPosteo
            myRpt3.xrlComprobante.Text = entCuentaAhorroMov.NumeroDoc.ToString()
            myRpt3.xrlCuenta.Text = EntCuentaAhorro.Numero.ToString
            myRpt3.xrlFecha.Text = entCuentaAhorroMov.Fecha
            myRpt3.xrlValor.Text = Format(CDec(entCuentaAhorroMov.Valor), "##,##0.00")
            myRpt3.xrlCajero.Text = objMenu.User
            myRpt3.PrinterName = gsImpresorDefault
            While True
                myRpt3.PrintDialog()
                If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If
        If MsgBox("Desea imprimir el Comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim myRpt As New aho_rptRetiroAhorro
            Dim sDecimal = String.Format("{0:c}", Format(CDec(teMonto.EditValue), "##,##0.00"))

            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

            myRpt.DataSource = blcaja.rptRetiroAhorro(_NroComprobante.Text, entCuentaAhorroMov.IdCuenta)
            myRpt.xrlMensaje.Text = blcaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
            myRpt.XrPictureBox1.ImageUrl = blcaja.ObtieneParametros.Rows(0).Item("RutaLogo")
            myRpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(Today, Today)
            myRpt.xrlCantidadLetras.Text = Num2Text(Int(teMonto.EditValue)) & " " & sDecimal & " DÓLARES"
            myRpt.xrlEmpresa.Text = gsNombre_Empresa
            myRpt.PrinterName = gsImpresorDefault

            While True
                myRpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End While
        End If

        _NroCtaAhorro.Text = ""
        _DocIdentidad.Text = ""
        _fecRetiro.EditValue = blCaja.GetFechaContable(gIdSucursal)
        deFechaUlt.Text = ""
        _LineaLibreta.Text = ""
        teMonto.Text = 0.0
        _NombreCliente.Text = ""
        _NroComprobante.Text = ""
        _NroDocumento.Text = ""
        _PersonaAutorizada.ItemIndex = 0
        _Saldo.Text = 0.0
        _saldoDisponible.Text = 0
        teInteres.EditValue = 0.0
        teISR.EditValue = 0.0
        Close()
    End Sub


    Private Sub _Tasa_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Tasa.EditValueChanged

        IdCuenta = blCaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(IdCuenta)
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(EntCuentaAhorro.IdTipoCuenta)

        If entTipoCuenta.TipoAhorro = 1 Then
            entCapitalizacion = blCaja.coo_CapitalizacionAhorroCancelacion(EntCuentaAhorro.IdCuenta, _fecRetiro.EditValue, _Tasa.EditValue)
        End If

        If entTipoCuenta.TipoAhorro = 1 Then
            teInteres.EditValue = entCapitalizacion.SaldoInteres
            teISR.EditValue = entCapitalizacion.SaldoIsr
        Else
            teInteres.EditValue = 0.0
            teISR.EditValue = 0.0
        End If

    End Sub
End Class