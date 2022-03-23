Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.Math
Public Class frmRetiros
    Dim blCaja As New CajaBusiness
    Dim blAdmon As New AdmonBLL
    Dim EntCuentaAhorro As coo_CuentasAhorro
    Dim EntUltMovAhorro As coo_UltMovAhorro
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub frmRetiros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _NroCtaAhorro.Focus()
    End Sub
    Private Sub frmRetiros_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        CargaCombos()
        _fecRetiro.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        teIdCuenta.EditValue = 0
        _Monto.EditValue = 0.0
        _Saldo.EditValue = 0.0
        _saldoDisponible.EditValue = 0.0
    End Sub
    Private Sub CargaCombos()
        objCombos.cooPtmoFmaPago(leFormaPago)
        objCombos.cooTipoDocumento(_TipoDocPtdo)
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click
        If EntCuentaAhorro.IdCuentaCte > 0 Then
            MsgBox("Esta cuenta no acepta retiros", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _NroCtaAhorro.Text = "" Then
            MsgBox("Numero de cuenta en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'If teNumeroDoc.Text = "" Then
        '    entSucursal = 
        '    teNumeroDoc.EditValue = glIdSucursal.ToString.PadLeft(2, "0") & "-" & (entSucursal.CorrelativoRetiro + 1).ToString.PadLeft(6, "0")
        'End If
        If _fecRetiro.Text = "" Then
            MsgBox("Fecha del retiro no puede quedar en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If _Monto.EditValue = 0 Then
            MsgBox("Monto no puede ser cero", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If _fecRetiro.EditValue < _FecUltMov.EditValue Then
            MsgBox("Fecha de retiro incorrecta", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Monto.EditValue > _saldoDisponible.EditValue Then
            MsgBox("No puede retirar mas de su disponible", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _PersonaAutorizada.EditValue > 0 And _DocIdentidad.Text = "" Then
            MsgBox("Documento de identidad en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim entCuentaAhorroMov As New coo_CuentasAhorroMov
        With entCuentaAhorroMov
            .IdCuenta = teIdCuenta.EditValue
            .IdMov = EntUltMovAhorro.IdMov + 1
            .NumeroDoc = teNumeroDoc.EditValue
            .Fecha = _fecRetiro.EditValue
            .IdTipo = 2
            .Valor = _Monto.EditValue
            .Saldo = CDec(_Saldo.EditValue) - CDec(_Monto.EditValue)
            .LineaLibreta = _LineaLibreta.EditValue + 1
            .IdFormaPago = leFormaPago.EditValue
            .FechaContable = _fecRetiro.EditValue 'objFunciones.GetFechaContable(gIdSucursal)
            .IdSucursal = gIdSucursal
            .Pignorado = False
            .Observaciones = ""
            .Impreso = False
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .IdAutorizado = _PersonaAutorizada.EditValue
            .DocAutorizado = _DocIdentidad.Text
        End With
        'If blcaja.ExisteComprobanteRetiro(entCuentaAhorroMov.NumeroDoc) <> "" Then
        '    MsgBox("Numero de Comprobante ya existe", MsgBoxStyle.Critical, "Error de usuario")
        '    Exit Sub
        'End If
        Dim IdSuc As Integer = gIdSucursal
        If leFormaPago.EditValue = 6 Then
            IdSuc = -1
        End If
        Dim msj As String = blCaja.InsertaRetiro(entCuentaAhorroMov, IdSuc)
        teNumeroDoc.EditValue = entCuentaAhorroMov.NumeroDoc
        If msj <> "" Then
            MsgBox(String.Format("No fue posible aplicar el retiro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("¿Actualizar Libreta de Ahorros?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If gsNombre_Empresa.StartsWith("ACAPRO") Then
                ActualizaLibretaAhorroPorCodigo(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            Else
                ImprimeLibretaAhorro(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            End If
        End If

        If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New rptPosteo
            rpt.xrlComprobante.Text = entCuentaAhorroMov.NumeroDoc.ToString()
            rpt.xrlCuenta.Text = EntCuentaAhorro.Numero.ToString
            rpt.xrlFecha.Text = entCuentaAhorroMov.Fecha
            rpt.xrlValor.Text = Format(CDec(entCuentaAhorroMov.Valor), "##,##0.00")
            rpt.xrlCajero.Text = objMenu.User
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If

        If MsgBox("Desea imprimir el Comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(EntCuentaAhorro.IdSucursal)
            Dim rpt As New aho_rptRetiroAhorro() With {.DataSource = blCaja.rptRetiroAhorro(teNumeroDoc.Text, entCuentaAhorroMov.IdCuenta), .DataMember = ""}
            Dim sDecimal = String.Format("{0:c}", Format(CDec(_Monto.EditValue), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

            rpt.xrlMensaje.Text = blCaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
            rpt.XrPictureBox1.ImageUrl = blCaja.ObtieneParametros.Rows(0).Item("RutaLogo")
            rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(Today, Today)
            rpt.xrlCantidadLetras.Text = Num2Text(Int(_Monto.EditValue)) & " " & sDecimal & " DÓLARES"
            rpt.xrlEmpresa.Text = gsNombre_Empresa

            While True
                rpt.PrintDialog()
                If MsgBox("¿Generar otra impresión del comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                    Exit While
                End If
            End While
        End If

        If leFormaPago.EditValue = 2 Then
            If MsgBox("Solicitar autorización para éste retiro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim Anombrede As String = InputBox("Emitir cheque a nombre de:", "Autorización de cheque", "escriba aquí a nombre de quien se emite el cheque")
                Dim entCuenta As coo_CuentasAhorro
                Dim entTipoCuenta As coo_TiposCuentaAhorro
                entCuenta = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
                entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(entCuenta.IdTipoCuenta)
                Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(EntCuentaAhorro.IdSucursal)
                Dim rpt As New aho_rptComprobAutorizaCheque() With {.DataMember = ""}
                Dim sDecimal = String.Format("{0:c}", Format(CDec(_Monto.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlEmpresa.Text = gsNombre_Empresa
                rpt.xrlCuenta.Text = _NroCtaAhorro.Text
                rpt.xrlTitulo.Text = "RETIRO DE " & entTipoCuenta.Nombre & "No. " & teNumeroDoc.EditValue
                rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(_fecRetiro.EditValue, _fecRetiro.EditValue)
                rpt.xrlAsociado.Text = _NombreCliente.EditValue
                rpt.xrlCantidadLetras.Text = Num2Text(Int(_Monto.EditValue)) & " " & sDecimal & " DÓLARES"
                rpt.xrlAnombrede.Text = Anombrede
                While True
                    rpt.PrintDialog()
                    If MsgBox("¿Generar otra impresión del comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                        Exit While
                    End If
                End While
            End If
        End If

        _NroCtaAhorro.Text = ""
        teIdCuenta.EditValue = 0
        _DocIdentidad.Text = ""
        _fecRetiro.EditValue = blCaja.GetFechaContable(gIdSucursal)
        _FecUltMov.Text = ""
        _LineaLibreta.Text = ""
        _Monto.EditValue = 0.0
        _NombreCliente.Text = ""
        teNumeroDoc.Text = ""
        _NroDocumento.Text = ""
        _PersonaAutorizada.ItemIndex = 0
        _Saldo.EditValue = 0.0
        _saldoDisponible.EditValue = 0.0
        _NroCtaAhorro.Focus()
    End Sub

    Private Sub _NroCtaAhorro_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _NroCtaAhorro.ButtonClick
        frmConsultaCuentasAhorro.ShowDialog()
        _NroCtaAhorro.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        _NroCtaAhorro_Validated(e, New EventArgs)
    End Sub
    Private Sub _NroCtaAhorro_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _NroCtaAhorro.Validated
        Dim entPignorado As New coo_Pignoraciones
        Dim Pignorado As Decimal = 0.0

        If SiEsNulo(_NroCtaAhorro.EditValue, "") = "" Then
            Exit Sub
        End If
        teIdCuenta.EditValue = blcaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)
        If teIdCuenta.EditValue = 0 Then
            MsgBox("No se encuentra registrada ningúna cuenta con éste número", MsgBoxStyle.Exclamation, "Nota")
            _NroCtaAhorro.EditValue = ""
            _NroCtaAhorro.Focus()
            Exit Sub
        End If

        entPignorado = blcaja.coo_PignoracionesSelectByCuenta(teIdCuenta.EditValue)

        'IdCuenta = blcaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        EntUltMovAhorro = blcaja.coo_UltMovAhorroSelectBy(EntCuentaAhorro.IdCuenta)
        If entPignorado.IdCuenta > 0 Then
            Pignorado = entPignorado.Valor
        End If
        With EntCuentaAhorro
            Dim elAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(.IdAsociado)
            _NombreCliente.EditValue = elAsociado.Nombres + " " + elAsociado.Apellidos
            _Saldo.EditValue = EntUltMovAhorro.SaldoActual
            _saldoDisponible.EditValue = EntUltMovAhorro.SaldoDisponible - Pignorado
            _FecUltMov.EditValue = Format(EntUltMovAhorro.Fecha, "dd/MM/yyyy")
            _LineaLibreta.EditValue = EntUltMovAhorro.Linea
            _NroDocumento.EditValue = elAsociado.NumeroDocumento
            _TipoDocPtdo.EditValue = elAsociado.IdTipoDocumento

            Dim entSaldoCredito As DataTable = blCaja.SolicitudRetiro(elAsociado.IdAsociado, blCaja.GetFechaContable(gIdSucursal))

            teSaldoAhorros.EditValue = 0.0
            teSaldoAportaciones.EditValue = 0.0
            teSaldoDeudas.EditValue = 0.0
            teSaldoDisponible.EditValue = 0.0
            teSaldoDeudasFiador.EditValue = 0.0

            teSaldoAhorros.EditValue = entSaldoCredito.Rows(0).Item("TotalAhorro")
            teSaldoAportaciones.EditValue = entSaldoCredito.Rows(0).Item("TotalAportaciones")
            teSaldoDeudas.EditValue = entSaldoCredito.Rows(0).Item("TotalDeducciones")
            teSaldoDeudasFiador.EditValue = entSaldoCredito.Rows(0).Item("SaldoComoFiador")
            teSaldoDisponible.EditValue = entSaldoCredito.Rows(0).Item("LiquidezSocio")

        End With
        objCombos.cooAutorizadoCuenta(_PersonaAutorizada, "IdCuenta=" & EntCuentaAhorro.IdCuenta)
    End Sub


    Private Sub _PersonaAutorizada_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _PersonaAutorizada.EditValueChanged
        _DocIdentidad.EditValue = blcaja.ObtenerDocAutorizado(_PersonaAutorizada.EditValue)
    End Sub

    Private Sub frmRetiros_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub _fecRetiro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _fecRetiro.Validating
        If _fecRetiro.EditValue < _FecUltMov.EditValue Then
            MsgBox("Fecha de retiro incorrecta", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
    End Sub

    Private Sub leFormaPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leFormaPago.EditValueChanged
        teNumeroDoc.Properties.ReadOnly = leFormaPago.EditValue <> 6
    End Sub

    Private Sub sbVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVer.Click
        Dim entCuenta As coo_CuentasAhorro
        entCuenta = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entCuenta.IdAsociado > 0 Then
            pre_frmVerDocumentosAsociado.IdAsociado = entCuenta.IdAsociado
            pre_frmVerDocumentosAsociado.ShowDialog()
        End If
    End Sub

    Private Sub sbVerFirma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFirma.Click
        Dim entCuenta As coo_CuentasAhorro
        entCuenta = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entCuenta.IdAsociado > 0 Then
            pre_frmVerFirmasAsociado.IdAsociado = entCuenta.IdAsociado
            pre_frmVerFirmasAsociado.ShowDialog()
        End If
    End Sub

    Private Sub sbVerFotografia_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVerFotografia.Click
        Dim entCuenta As coo_CuentasAhorro
        entCuenta = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entCuenta.IdAsociado > 0 Then
            pre_frmVerFotoAsociado.IdAsociado = entCuenta.IdAsociado
            pre_frmVerFotoAsociado.ShowDialog()
        End If
    End Sub
End Class