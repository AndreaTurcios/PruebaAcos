Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports vb = Microsoft.VisualBasic
Public Class FrmDepositos
    Dim blAdmon As New AdmonBLL
    Dim blCaja As New CajaBusiness, dtParam As DataTable = blAdmon.ObtieneParametros()
    Dim EntCuentaAhorro As coo_CuentasAhorro, EntUltMovAhorro As coo_UltMovAhorro
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub FrmDepositos_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        _NroCtaAhorro.Focus()
    End Sub
    Private Sub FrmDepositos_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        objCombos.cooPtmoFmaPago(leFormaPago)
        _FechaDeposito.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        teIdCuenta.EditValue = 0
        _Monto.EditValue = 0.0
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click

        If _NroCtaAhorro.Text = "" Then
            MsgBox("Numero de cuenta en blanco", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If
        If _FechaDeposito.Text = "" Then
            MsgBox("La fecha del depósito no puede quedar en blanco", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If
        If _Monto.EditValue <= 0 Then
            MsgBox("Monto del depósito es incorrecto", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If
        'If _Saldo.EditValue <> 0.0 And _FechaDeposito.EditValue < _FecUltMov.EditValue Then
        '    MsgBox("Fecha del depósito incorrecta", MsgBoxStyle.Critical, "Nota")
        '    Exit Sub
        'End If
        If teNumeroDoc.EditValue = "" And leFormaPago.EditValue > 5 Then
            MsgBox("Debe de especificar el número de documento", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        If _Saldo.EditValue = 0.0 Then
            If EntUltMovAhorro.IdMov = 0 Then
                'EntAperturaCuenta = blcaja.coo_GetMontoAperturaSelectBy(IdCuenta)
                If EntCuentaAhorro.MontoApertura <> _Monto.EditValue Then
                    MsgBox("Monto a Depositar Difiere con el valor especificado en la apertura", MsgBoxStyle.Critical, "Nota")
                    Exit Sub
                End If
                If EntCuentaAhorro.FechaApertura <> _FechaDeposito.EditValue Then
                    MsgBox("La fecha del depósito no coincide con la fecha de Apertura de la Cuenta ", MsgBoxStyle.Critical, "Verifique")
                    Exit Sub
                End If
            Else
                If EntCuentaAhorro.IdCuentaCte > 0 Then
                    MsgBox("La Cuenta es un depósito a Plazo. No puede efectuarle depósitos", MsgBoxStyle.Critical, "Verifique")
                    Exit Sub
                End If
            End If
        End If

        Dim entCuentaAhorroMov As New coo_CuentasAhorroMov
        With entCuentaAhorroMov
            .IdCuenta = teIdCuenta.EditValue
            .IdMov = EntUltMovAhorro.IdMov + 1
            .NumeroDoc = teNumeroDoc.EditValue
            .Fecha = _FechaDeposito.EditValue
            .IdTipo = 1
            .Valor = _Monto.EditValue
            .Saldo = _Saldo.EditValue + _Monto.EditValue
            .LineaLibreta = _LineaLibreta.EditValue
            .IdFormaPago = leFormaPago.EditValue
            .FechaContable = _FechaDeposito.EditValue ' objFunciones.GetFechaContable(gIdSucursal)
            .IdSucursal = gIdSucursal

            If leFormaPago.EditValue = 2 Then
                .Pignorado = True
            Else
                .Pignorado = False
            End If
            .Observaciones = _Observa.Text
            .Impreso = False
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With
        'If blCaja.ExisteComprobanteDeposito(entCuentaAhorroMov.NumeroDoc) <> "" Then
        '    MsgBox("Numero de Comprobante ya Existe", MsgBoxStyle.Critical, "Error de usuario")
        '    Exit Sub
        'End If

        'se hizo éste cambio para que genere el número de documento en la capa de datos
        Dim IdSuc = gIdSucursal
        If leFormaPago.EditValue = 6 Then
            IdSuc = -1
        End If
        Dim msj As String = blCaja.InsertaDeposito(entCuentaAhorroMov, IdSuc)
        teNumeroDoc.EditValue = entCuentaAhorroMov.NumeroDoc
        If msj <> "" Then
            MsgBox(String.Format("No fue posible guardar el Depósito{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Monto.EditValue >= 57142.85 And leFormaPago.EditValue = 1 Then
            If MsgBox("Desea Generar el Documento UIF1?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                'Dim entidad As coo_ContratoAhorro = blcaja.rptContratoAhorro(entCuentaAhorroMov.IdCuenta)
                Dim FileName As String = Environment.CurrentDirectory & "\Plantillas\Form_UIF1.xls"
                FileOpen(0, FileName, OpenMode.Binary)
                'Dim oExcel = CreateObject("Excel.Application")
                'oExcel.Visible = True
                'oExcel.workbooks.Open(FileName)
            End If
        Else
            Dim entTipoCuenta As coo_TiposCuentaAhorro
            entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(EntCuentaAhorro.IdTipoCuenta)
            If (_Monto.EditValue >= 3000 Or entTipoCuenta.TipoAhorro > 1) And leFormaPago.EditValue < 5 Then
                MsgBox("Se impimirá ahora la Declaración Jurada", MsgBoxStyle.Information, "Imprimir")
                'Declaracion Jurada
                Dim entidad As coo_DeclaracionJurada = blCaja.rptDeclaracionJurada(entCuentaAhorroMov.IdCuenta, entCuentaAhorroMov.IdMov)

                Dim entDocRtf As coo_Documentos = objTablas.coo_DocumentosSelectByPK("DeclaracionJuradaIngresosEgresos")
                Dim txt As String = entDocRtf.Contenido
                Dim rpt As New rpt_RichTextLogo
                rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl

                With entidad
                    txt = txt.Replace("[NombreEmp]", gsNombre_Empresa)
                    txt = txt.Replace("[Oficina]", .Sucursal)
                    txt = txt.Replace("[Nombre]", .NombreAsociado)
                    txt = txt.Replace("[Representacion]", "___________________________________")
                    txt = txt.Replace("[Origen]", .OrigenFondos)
                    txt = txt.Replace("[Profesion]", .Profesion)
                    txt = txt.Replace("[Monto]", Format(.MontoApertura, "###,##0.00"))
                    txt = txt.Replace("[Concepto]", "DEPOSITO DE AHORRO CTA. No. " & .NumeroCuenta)
                    txt = txt.Replace("[Domicilio]", .Municipio)
                    txt = txt.Replace("[Dui]", .Dui)
                    txt = txt.Replace("[Nit]", .Nit)
                    txt = txt.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreEmpresa"))
                    txt = txt.Replace("[Ciudad]", entSucursal.Ciudad)
                    txt = txt.Replace("[Fecha]", FechaToString(Today, Today))
                    rpt.xrContenido.Rtf = txt
                    'rpt.XrLogoSuc.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
                    rpt.PrintDialog()
                End With
            End If
        End If

        If _Monto.EditValue >= 3000 Then
            MsgBox("Se imprimirá ahora el Formulario de Control", MsgBoxStyle.Information, "Imprimir")
            'Formulario Control
            Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(EntCuentaAhorro.IdAsociado)
            Dim entActividadEconomica As coo_Actividades = objTablas.coo_ActividadesSelectByPK(entAsociados.IdActividad)
            Dim entCanton As adm_cantones = objTablas.adm_cantonesSelectByPK(entAsociados.IdCanton)
            Dim entEstadoCivil As pla_EstadoCivil = objTablas.pla_EstadoCivilSelectByPK(entAsociados.IdEstadoCivil)
            Dim entDespartamento As adm_Departamentos = objTablas.adm_DepartamentosSelectByPK(entAsociados.IdDepartamento)
            Dim entMunicipio As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
            Dim entProfesion As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)

            Dim rpt As New rptFormularioControl
            rpt.xrpbLogo.ImageUrl = entSucursal.LogoImageUrl

            rpt.xrlActividad.Text = entActividadEconomica.Nombre

            Dim PosicionCadena As Integer = vb.InStr(vb.Trim(entAsociados.Apellidos), " ")
            If PosicionCadena = 0 Then
                rpt.xrlApellidoPat.Text = entAsociados.Apellidos
                rpt.xrlApellidoMat.Text = ""
            Else
                rpt.xrlApellidoPat.Text = vb.Left(vb.Trim(entAsociados.Apellidos), vb.InStr(vb.Trim(entAsociados.Apellidos), " "))
                rpt.xrlApellidoMat.Text = vb.Mid(vb.Trim(entAsociados.Apellidos), vb.InStr(vb.Trim(entAsociados.Apellidos), " "))
            End If
            rpt.xrlNombres.Text = entAsociados.Nombres
            rpt.xrlFechaNac.Text = Format(entAsociados.FechaNacimiento, "dd/MM/yyyy")
            rpt.xrlNacion.Text = entAsociados.Nacionalidad
            rpt.xrlSexo.Text = IIf(entAsociados.IdSexo = 1, "Masculino", "Femenino")
            rpt.xrlDui.Text = entAsociados.NumeroDocumento
            rpt.xrlEstado.Text = entEstadoCivil.Nombre
            rpt.xrlProfesion.Text = entProfesion.Nombre

            rpt.xrlDireccion.Text = entAsociados.Direccion & ", " & entMunicipio.Nombre & "/" & entDespartamento.Nombre
            rpt.xrlCanton.Text = entCanton.Nombre
            rpt.xrlOtros.Text = entAsociados.Ubicacion
            rpt.xrlNoAsociado.Text = entAsociados.Numero
            rpt.xrlTelefono.Text = entAsociados.Telefonos
            rpt.PrintDialog()
        End If

        If MsgBox("¿Actualizar Libreta de Ahorros?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            If gsNombre_Empresa.StartsWith("ACAPRO") Then
                ActualizaLibretaAhorroPorCodigo(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            Else
                ImprimeLibretaAhorro(EntCuentaAhorro.IdCuenta, _LineaLibreta.EditValue, entSucursal.LineasLibreta)
            End If
        End If

        If MsgBox("Postear el Comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
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

        If MsgBox("Desea imprimir el comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New aho_rptDepositoAhorro

            Dim sDecimal = String.Format("{0:c}", Format(CDec(_Monto.EditValue), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            rpt.DataSource = blCaja.rptDepositoAhorroIdMov(entCuentaAhorroMov.IdMov, entCuentaAhorroMov.IdCuenta)
            rpt.xrlMensaje.Text = dtParam.Rows(0).Item("MensajeCooperativo")
            rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")

            rpt.xrlLugarFecha.Text = entSucursal.Ciudad + ", " + FechaToString(Today, Today)
            rpt.xrlCantidadLetras.Text = Num2Text(Int(_Monto.EditValue)) & " " & sDecimal & " DÓLARES"
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            While True
                rpt.PrintDialog()
                If MsgBox("¿Generar otra impresión del documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                    Exit While
                End If
            End While
        End If
        leFormaPago.EditValue = 1
        teIdCuenta.EditValue = 0
        _Nombre.EditValue = ""
        teNumeroDoc.EditValue = ""
        _Monto.EditValue = 0.0
        _FechaDeposito.EditValue = blCaja.GetFechaContable(gIdSucursal)
        _NroCtaAhorro.EditValue = ""
        _Observa.EditValue = ""
        _Saldo.EditValue = 0.0
        _SaldoDisponible.EditValue = 0.0
        _LineaLibreta.EditValue = 0
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
        teIdCuenta.EditValue = blCaja.GetIdCuentaAhorro(_NroCtaAhorro.EditValue)

        If teIdCuenta.EditValue = 0 Then
            MsgBox("No se encuentra registrada ningúna cuenta con éste número", MsgBoxStyle.Exclamation, "Nota")
            _NroCtaAhorro.EditValue = ""
            _NroCtaAhorro.Focus()
            Exit Sub
        End If


        entPignorado = blCaja.coo_PignoracionesSelectByCuenta(teIdCuenta.EditValue)
        EntCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        EntUltMovAhorro = blCaja.coo_UltMovAhorroSelectBy(EntCuentaAhorro.IdCuenta)
        If entPignorado.IdCuenta > 0 Then
            Pignorado = entPignorado.Valor
        End If
        With EntCuentaAhorro
            Dim elAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(.IdAsociado)
            _Nombre.EditValue = elAsociado.Nombres & " " & elAsociado.Apellidos
            _Saldo.EditValue = EntUltMovAhorro.SaldoActual
            If EntUltMovAhorro.SaldoActual = 0 Then
                _Monto.EditValue = EntCuentaAhorro.MontoApertura
            End If
            _SaldoDisponible.EditValue = EntUltMovAhorro.SaldoDisponible - Pignorado
            _FecUltMov.EditValue = Format(EntUltMovAhorro.Fecha, "dd/MM/yyyy")

            _LineaLibreta.EditValue = EntUltMovAhorro.Linea
        End With
    End Sub

    Private Sub FrmDepositos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub _FechaDeposito_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles _FechaDeposito.Validating
        If _FechaDeposito.EditValue < _FecUltMov.EditValue Then
            MsgBox("Fecha de depósito incorrecta", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
    End Sub

    Private Sub leFormaPago_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles leFormaPago.EditValueChanged
        teNumeroDoc.Properties.ReadOnly = leFormaPago.EditValue <> 6
    End Sub
End Class