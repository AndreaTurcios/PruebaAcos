Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Public Class frmAportaciones
    Dim blCaja As New CajaBusiness()
    Dim entUsuario As New adm_Usuarios
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub frmAportaciones_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        teNumero.Focus()
    End Sub

    Private Sub frmAportaciones_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        entUsuario = objTablas.adm_UsuariosSelectByPK(objMenu.User)
        CargaCombos()
        If entUsuario.TipoUsuario = 6 Then
            _TipoAportacion.Properties.ReadOnly = True
        Else
            _TipoAportacion.Properties.ReadOnly = False
        End If
        _FechaMov.EditValue = blCaja.GetFechaContable(gIdSucursal)
    End Sub
    Private Sub CargaCombos()
        objCombos.cooPtmoFmaPago(_FormaPago)
        objCombos.cooTipoAportacion(_TipoAportacion)
    End Sub

    Private Sub teNumero_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumero.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumero.EditValue = frmConsultaAsociados.NumAsociado
        teNumero_Validated(e, New EventArgs)
    End Sub
    Private Sub teNumero_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles teNumero.Validated
        If SiEsNulo(teNumero.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim EntAsociado As coo_Asociados = blCaja.coo_AsociadosSelectNumero(teNumero.EditValue)
        If EntAsociado.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        With EntAsociado
            teIdAsociado.EditValue = EntAsociado.IdAsociado
            _NombreCliente.EditValue = .Nombres + " " + .Apellidos
            _FechaIngCliente.EditValue = .FechaHoraCreacion
            _saldo.EditValue = blCaja.GetSaldoAporta(teIdAsociado.EditValue)
            teLineaLibreta.EditValue = blCaja.GetUltLineaAporta(teIdAsociado.EditValue) + 1
            _Monto.EditValue = 0.0
            If blCaja.GetUltFechaAporta(teIdAsociado.EditValue) Is Nothing Then
                _FechaUltMov.EditValue = Nothing
            Else
                _FechaUltMov.EditValue = blCaja.GetUltFechaAporta(teIdAsociado.EditValue)
            End If
        End With
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click


        If teNumero.EditValue = "" Then
            MsgBox("Numero de asociado en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If _Monto.EditValue <= 0 Then
            MsgBox("Monto a aportar mal introducido", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If
        If _FechaUltMov.EditValue <> Nothing Then
            If _FechaMov.EditValue < _FechaUltMov.EditValue Then
                MsgBox("Fecha de pago incorrecta", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        'If teLineaLibreta.EditValue < 1 Or teLineaLibreta.EditValue > entSucursal.LineasLibreta Then
        '    MsgBox("Número de línea para libreta es incorrecto", MsgBoxStyle.Critical, "Nota")
        '    Exit Sub
        'End If
        If _NumeroComprobante.Text = "" Then
            entSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            _NumeroComprobante.EditValue = String.Format("{0}-{1}", gIdSucursal.ToString.PadLeft(2, "0"), (entSucursal.CorrelativoPago + 1).ToString.PadLeft(6, "0"))
        End If

        'se cambió la asignación del correlativo a la capa de datos y se verifica que si el usuario lo digita, no se esté repitiendo
        If _NumeroComprobante.EditValue <> "" Then
            If blCaja.ExisteComprobanteAportacion(_NumeroComprobante.EditValue) <> "" Then
                MsgBox("Numero de Comprobante ya existe", MsgBoxStyle.Critical, "Error de usuario")
                Exit Sub
            End If
        End If

        Dim entAportacion As New coo_Aportaciones
        With entAportacion
            .IdAsociado = teIdAsociado.EditValue
            .IdMov = blCaja.GetUltMovAporta(.IdAsociado) + 1
            .IdTipo = _TipoAportacion.EditValue
            .NumeroDoc = _NumeroComprobante.EditValue
            .Fecha = _FechaMov.EditValue
            .IdFormaPago = _FormaPago.EditValue
            .Cargo = 0.0
            .Abono = _Monto.EditValue
            .Saldo = blCaja.GetSaldoAporta(.IdAsociado) + _Monto.EditValue
            .LineaLibreta = teLineaLibreta.EditValue
            .Impreso = False
            .IdSucursal = gIdSucursal
            .FechaContable = _FechaMov.EditValue 'blCaja.GetFechaContable(gIdSucursal)
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With

        Dim msj As String = blCaja.InsertaAportacion(entAportacion)

        If msj <> "" Then
            MsgBox(String.Format("No fue posible aplicar la aportación{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If

        If MsgBox("Actualizar la Libreta de Aportaciones?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If gsNombre_Empresa.StartsWith("ACAPRO") Then
                ActualizaLibretaAportaPorCodigo(teIdAsociado.EditValue, teLineaLibreta.EditValue, entSucursal.LineasLibreta)
            Else
                ImprimeLibretaAportacion(teIdAsociado.EditValue, teLineaLibreta.EditValue, entSucursal.LineasLibreta)
            End If
        End If
        If MsgBox("Postear el Comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New rptPosteo
            rpt.xrlComprobante.Text = _NumeroComprobante.EditValue.ToString()
            rpt.xrlCuenta.Text = teNumero.EditValue.ToString()
            rpt.xrlFecha.Text = _FechaMov.DateTime.Day & "/" & _FechaMov.DateTime.Month & "/" & _FechaMov.DateTime.Year
            rpt.xrlValor.Text = Format(CDec(_Monto.EditValue), "##,##0.00")
            rpt.xrlCajero.Text = objMenu.User
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If
        Dim entAsociado As coo_Asociados
        If gsNombre_Empresa.StartsWith("ACAPRO") Then
            If MsgBox("Imprimir el comprobante de ingreso?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim rpt As New apo_rptIngresoAportacion
                entAsociado = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
                Dim sDecimal = String.Format("{0:c}", _Monto.EditValue)
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlAportacion.Text = _Monto.EditValue
                rpt.xrlFecha.Text = FechaToString(_FechaMov.EditValue, _FechaMov.EditValue)
                rpt.xrlNombre.Text = entAsociado.Nombres
                rpt.xrlApellido.Text = entAsociado.Apellidos
                rpt.xrlNumero.Text = teNumero.EditValue
                rpt.xrlCantidadLetras.Text = String.Format("{0} {1} DÓLARES", Num2Text(Int(_Monto.EditValue)), sDecimal)
                rpt.xrlSaldo.Text = _Monto.EditValue
                rpt.xrlComprobante.Text = _NumeroComprobante.EditValue
                While True
                    rpt.PrintDialog()
                    If MsgBox("Imprimir otra copia del comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                        Exit While
                    End If
                End While
            End If
        End If
        If MsgBox("¿Desea imprimir el recibo o comprobante de aportación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New apo_rptComprobAportacion
            Dim sDecimal = String.Format("{0:c}", _Monto.EditValue)
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            rpt.DataSource = blCaja.rptIngresoAportacion(_NumeroComprobante.EditValue, teIdAsociado.EditValue)
            rpt.DataMember = ""
            rpt.XrPictureBox1.ImageUrl = blCaja.ObtieneParametros.Rows(0).Item("RutaLogo")
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(_FechaMov.EditValue, _FechaMov.EditValue)
            rpt.xrlCantidadLetras.Text = String.Format("{0} {1} DÓLARES", Num2Text(Int(_Monto.EditValue)), sDecimal)
            rpt.xrlMensaje.Text = blCaja.ObtieneParametros.Rows(0).Item("MensajeCooperativo")
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("Imprimir otra copia del comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                    Exit While
                End If
            End While
        End If

        teNumero.Focus()
        teNumero.EditValue = ""
        _saldo.EditValue = 0.0
        _SaldoDebeSer.EditValue = 0.0
        _NumeroComprobante.EditValue = ""
        _FechaMov.EditValue = blCaja.GetFechaContable(gIdSucursal)
        _Monto.EditValue = 0.0
        teIdAsociado.EditValue = 0
        _NombreCliente.EditValue = ""
        _FechaIngCliente.EditValue = Nothing
        _FechaUltMov.EditValue = Nothing
    End Sub

    Private Sub _FechaMov_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _FechaMov.Validating
        Dim meses As Integer = DateDiff(DateInterval.Month, _FechaIngCliente.EditValue, _FechaMov.EditValue)
        If meses = 0 Then meses = 1
        _SaldoDebeSer.EditValue = meses * glCuotaAportacion
        If _FechaUltMov.EditValue <> Nothing Then
            If _FechaMov.EditValue < _FechaUltMov.EditValue Then
                MsgBox("Fecha de pago incorrecta", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub _Monto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _Monto.Validating
        _Diferencia.EditValue = _SaldoDebeSer.EditValue - (_saldo.EditValue + _Monto.EditValue)
    End Sub

    Private Sub frmAportaciones_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

End Class