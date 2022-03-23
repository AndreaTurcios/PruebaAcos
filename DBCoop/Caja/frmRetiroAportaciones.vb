Imports System
Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports System.Math
Public Class frmRetiroAportaciones
    Dim blCaja As New CajaBusiness()
    Dim funCaja As New CajaBL.FuncionesBusiness()
    Dim entUsuario As New adm_Usuarios, entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal), dtParamtros As DataTable = blCaja.ObtieneParametros()

    Private Sub frmRetiroAportaciones_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        _FormaPago.Focus()
    End Sub

    Private Sub frmRetiroAportaciones_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmRetiroAportaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        entUsuario = objtablas.adm_UsuariosSelectByPK(objMenu.User)
        CargaCombos()
        If entUsuario.TipoUsuario = 6 Then
            _TipoAportacion.Properties.ReadOnly = True
        Else
            _TipoAportacion.Properties.ReadOnly = False
        End If
        _FechaMov.EditValue = blCaja.GetFechaContable(gIdSucursal)
        _FormaPago.EditValue = CByte(2)
    End Sub

    Private Sub CargaCombos()
        objCombos.cooPtmoFmaPago(_FormaPago)
        objCombos.cooTipoAportacion(_TipoAportacion)
    End Sub

    Private Sub _IdAsociado_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles _IdAsociado.MouseClick
        If _IdAsociado.Text = "" Then
            Dim cns As New frmConsulta
            cns.sSQL = "select aso.Numero, aso.IdAsociado, aso.Nombres, aso.Apellidos,li.NumeroDoc,li.TotalRetiro from coo_Asociados aso inner join coo_LiquidacionAportaciones li on aso.IdAsociado=li.IdAsociado WHERE li.desembolsado='False'"
            cns.ShowDialog()
            _IdAsociado.EditValue = cns.Codigo
        End If
        _IdAsociado_Validating(e, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub _IdAsociado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _IdAsociado.Validating
        If _IdAsociado.Text = "" Then
            Exit Sub
        End If
        Dim EntAsociado As coo_Asociados = blCaja.coo_AsociadosSelectNumero(_IdAsociado.EditValue)
        If EntAsociado.IdAsociado = 0 Then
            Exit Sub
        End If
        teIdAsociado.EditValue = EntAsociado.IdAsociado
        Dim entLiquidacion As coo_LiquidacionAportaciones = blCaja.coo_LiquidacionSelectByAsociado(EntAsociado.IdAsociado)
        If entLiquidacion.IdAsociado = 0 Then
            Exit Sub
        End If
        With EntAsociado
            _NombreCliente.EditValue = .Nombres + " " + .Apellidos
            _FechaIngCliente.EditValue = .FechaHoraCreacion
            _saldo.EditValue = blCaja.GetSaldoAporta(teIdAsociado.EditValue)
            _LineaLibreta.EditValue = blCaja.GetUltLineaAporta(teIdAsociado.EditValue) + 1
            _Monto.EditValue = entLiquidacion.TotalRetiro
            _NumeroComprobante.EditValue = entLiquidacion.NumeroDoc
            If blCaja.GetUltFechaAporta(teIdAsociado.EditValue) Is Nothing Then
                _FechaUltMov.EditValue = blCaja.GetFechaContable(gIdSucursal)
            Else
                _FechaUltMov.EditValue = blCaja.GetUltFechaAporta(teIdAsociado.EditValue)
            End If

            Dim entSaldoCredito As DataTable = blCaja.SolicitudRetiro(.IdAsociado, _FechaMov.EditValue) 'blCaja.GetFechaContable(gIdSucursal)

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

        GroupBox1.Enabled = True
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim msj As String = ""

        If _IdAsociado.Text = "" Then
            MsgBox("Numero de asociado en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        'If _Monto.EditValue <> _saldo.EditValue Then
        '    MsgBox("El Saldo Actual de la cuenta difiere de la Liquidación de Aportaciones", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        If _Monto.EditValue < 0.0 Then
            MsgBox("El Saldo a Liquidar debe de ser Positivo", MsgBoxStyle.Critical)
            Exit Sub
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

                Dim forma As New frmAutoriza
                forma.tePass.EditValue = ""
                forma.ShowDialog()

                Dim ClaveAutoriza As String = forma.tePass.EditValue
                Dim provider As New Security.Cryptography.SHA1CryptoServiceProvider
                Dim bytes As Byte() = System.Text.Encoding.UTF8.GetBytes(ClaveAutoriza)
                Dim inArray As Byte() = provider.ComputeHash(bytes)
                provider.Clear()

                Dim sPassWord As String = Convert.ToBase64String(inArray)
                Dim Respuesta As String = blCaja.ValidarUsuario("GERENTE", sPassWord)

                If Respuesta <> "Ok" Then
                    MsgBox("Clave no Autorizada. Imposible continuar", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If

        End If

        If _NumeroComprobante.Text = "" Then
            _NumeroComprobante.EditValue = funCaja.ObtenerCorrelativo("APORTACIONES")
        End If
        Dim entAportacion As New coo_Aportaciones
        With entAportacion
            .IdAsociado = teIdAsociado.EditValue
            .IdMov = blCaja.GetUltMovAporta(.IdAsociado) + 1
            .IdTipo = _TipoAportacion.EditValue
            .NumeroDoc = _NumeroComprobante.EditValue
            .Fecha = _FechaMov.EditValue
            .IdFormaPago = _FormaPago.EditValue
            .Cargo = _Monto.EditValue
            .Abono = 0.0
            .Saldo = blCaja.GetSaldoAporta(.IdAsociado) - _Monto.EditValue
            .LineaLibreta = _LineaLibreta.EditValue
            .Impreso = False
            .IdSucursal = gIdSucursal
            .FechaContable = _FechaMov.EditValue 'blCaja.GetFechaContable(gIdSucursal)
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With
        Dim sSQL2 As String = "update coo_LiquidacionAportaciones set Desembolsado ='True' WHERE NumeroDoc='" & entAportacion.NumeroDoc & "' and IdAsociado=" & entAportacion.IdAsociado
        objTablas.coo_AportacionesInsert(entAportacion)
        blCaja.CancelacionLiquidacionAportacion(sSQL2)


        If MsgBox("¿Actualizar Libreta de Aportaciones?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If gsNombre_Empresa.StartsWith("ACAPRO") Then
                ActualizaLibretaAportaPorCodigo(teIdAsociado.EditValue, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            Else
                ImprimeLibretaAportacion(teIdAsociado.EditValue, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            End If
        End If

        If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim myRpt3 As New rptPosteo
            myRpt3.xrlComprobante.Text = _NumeroComprobante.EditValue.ToString()
            myRpt3.xrlCuenta.Text = _IdAsociado.EditValue.ToString()
            myRpt3.xrlFecha.Text = _FechaMov.DateTime.Day & "/" & _FechaMov.DateTime.Month & "/" & _FechaMov.DateTime.Year
            myRpt3.xrlValor.Text = _Monto.EditValue.ToString
            Format(CDec(_Monto.EditValue), "##,##0.00")
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
            Dim myRpt As New apo_rptIngresoAportacion
            Dim sDecimal = String.Format("{0:c}", Format(CDec(_Monto.EditValue), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            myRpt.xrlAportacion.Text = _Monto.EditValue
            myRpt.xrlFecha.Text = FechaToString(_FechaMov.EditValue, _FechaMov.EditValue)
            myRpt.xrlNombre.Text = _NombreCliente.EditValue
            myRpt.xrlNumero.Text = _IdAsociado.EditValue
            myRpt.xrlCantidadLetras.Text = Num2Text(Int(_Monto.EditValue)) & " " & sDecimal & " DÓLARES"
            myRpt.xrlSaldo.Text = _Monto.EditValue
            myRpt.xrlComprobante.Text = _NumeroComprobante.EditValue
            myRpt.PrinterName = gsImpresorDefault
            While True
                myRpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While

        End If


        GroupBox1.Enabled = False
        _IdAsociado.Focus()
        _IdAsociado.Text = ""
        _saldo.EditValue = 0.0
        _SaldoDebeSer.EditValue = 0.0
        _NumeroComprobante.Text = ""
        _FechaMov.EditValue = blCaja.GetFechaContable(gIdSucursal)
        teIdAsociado.EditValue = Nothing
    End Sub

    Private Sub _FechaMov_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _FechaMov.Validating
        Dim meses As Integer = DateDiff(DateInterval.Month, _FechaIngCliente.EditValue, _FechaMov.EditValue)
        If meses = 0 Then meses = 1
        _SaldoDebeSer.EditValue = meses * glCuotaAportacion
    End Sub

    Private Sub _Monto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _Monto.Validating
        _Diferencia.EditValue = _SaldoDebeSer.EditValue - (_saldo.EditValue + _Monto.EditValue)
    End Sub

    Private Sub cmdReimprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReimprimir.Click
        Dim myRpt As New apo_rptLiquidacionAportacion
        Dim sDecimal = String.Format("{0:c}", _Monto.EditValue)
        sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"

        myRpt.DataSource = blCaja.rptLiquidacionAportacion(_NumeroComprobante.Text, teIdAsociado.EditValue)
        myRpt.DataMember = ""
        myRpt.xrlLugarFecha.Text = dtParamtros.Rows(0).Item("Municipio") + ", " + FechaToString(Today, Today)
        myRpt.xrlCantidadLetras.Text = Num2Text(Int(_Monto.EditValue)) & " " & sDecimal & " DÓLARES"
        myRpt.xrlEmpresa.Text = gsNombre_Empresa
        myRpt.xrlTotalCreditos.Text = 0.0
        myRpt.PrintDialog()

    End Sub
End Class