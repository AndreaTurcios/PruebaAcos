Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports System.Math
Imports vb = Microsoft.VisualBasic
Public Class frmOtrosEgresos
    Dim blCaja As New CajaBusiness(), dtParam As DataTable = blcaja.ObtieneParametros()
    Dim EntSucursal As New adm_Sucursales, CuentaGasto As coo_CuentasGastos

    Private Sub frmOtrosEgresos_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        _FormaPago.Focus()
    End Sub

    Private Sub frmOtrosEgresos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub frmOtrosEgresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        _Fecha.EditValue = blcaja.GetFechaContable(gIdSucursal)
        _Monto.EditValue = 0.0
        _TipoMovimiento_EditValueChanged(e, New EventArgs)
    End Sub
    Private Sub CargaCombos()
        With objCombos
            .cooPtmoFmaPago(_FormaPago)
            .coo_TiposMovimientoCaja(leTipoMovimiento, " TipoAplicacion=2")
            .coo_AgentesRemesa(leAgente)
            .coo_Rubros(leRubro, "")
            .coo_CuentasGastos(leCuentaGasto, -1)
        End With
    End Sub

    Private Sub _IdAsociado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _IdAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        _IdAsociado.EditValue = frmConsultaAsociados.NumAsociado
        _IdAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub _Monto_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles _Monto.Validated

        If CuentaGasto.IncluyeIva = True Then
            _Iva.EditValue = Round(Val(_Monto.EditValue) * pnIVA, 2)
        Else
            _Iva.EditValue = 0.0
        End If
        If CuentaGasto.AplicaIsr = True Then
            'tener cuidado con éste dato, ya que se debe de digitar el valor neto que se pagará en caja
            Dim FactorRenta As Decimal = (100 - (glPjeRenta * 100)) / 100
            teValorRenta.EditValue = Round((_Monto.EditValue / FactorRenta) - _Monto.EditValue, 2)
        Else
            teValorRenta.EditValue = 0.0
        End If
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim msj As String = ""
        Dim entOtrosEgresos As New coo_OtrosEgresos
        Dim blFunciones As New CajaBL.FuncionesBusiness()

        If _NroComprobante.Text = "" Then
            EntSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            _NroComprobante.EditValue = gIdSucursal.ToString.PadLeft(2, "0") & "-" & (EntSucursal.CorrelativoEgresos + 1).ToString.PadLeft(6, "0")
        End If

        If _NroComprobante.Text = "" Then
            MsgBox("Número de comprobante no puede quedar en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Fecha.Text = "" Then
            MsgBox("Debe de especificar la Fecha de la transacción", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Monto.EditValue = 0.0 Then
            MsgBox("Debe de especificar el monto de la transacción", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If leTipoMovimiento.EditValue = 201 Then  '201 es el codigo para pago de remesas
            If Not (leAgente.EditValue > 0) Then
                MsgBox("Es necesario especificar el agente", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
            If _Remitente.EditValue = "" Then
                MsgBox("Es necesario especificar el Nombre del Remitente", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
            If _Nombre.EditValue = "" Or teDUI.EditValue = "" Then
                MsgBox("Es necesario especificar el Nombre y DUI del Beneficiario", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
        End If
        If leTipoMovimiento.EditValue = 205 Then
            If Not (leRubro.EditValue > 0) Then
                MsgBox("Es necesario especificar el rubro del gasto", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
            If Not (leCuentaGasto.EditValue > 0) Then
                MsgBox("Es necesario especificar la cuenta de gasto", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
            If _Concepto.EditValue = "" Then
                MsgBox("Es necesario especificar un Concepto al Gasto", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
            If _Nombre.EditValue = "" Then
                MsgBox("Es necesario especificar el Nombre", MsgBoxStyle.Critical, "Nota")
                Exit Sub
            End If
        End If
        With entOtrosEgresos
            .IdMov = blFunciones.ObtenerCorrelativo("COO_OTROS_EGRESOS")
            .Numero = _NroComprobante.Text
            .IdAsociado = teIdAsociado.EditValue
            .Nombre = _Nombre.Text
            .Fecha = _Fecha.EditValue
            .IdFormaPago = _FormaPago.EditValue
            .IdTipoMovimiento = leTipoMovimiento.EditValue
            .IdAgenteRemesa = leAgente.EditValue
            .IdCuentaGasto = leCuentaGasto.EditValue
            .RemitenteRemesa = _Remitente.Text
            .Concepto = _Concepto.Text
            .Valor = _Monto.EditValue
            .Iva = _Iva.EditValue
            .Isr = teValorRenta.EditValue
            .IdSucursal = gIdSucursal
            .FechaContable = _Fecha.EditValue 'blcaja.GetFechaContable(gIdSucursal)
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With
        If blCaja.ExisteComprobanteEgreso(entOtrosEgresos.Numero) <> "" Then
            MsgBox("Numero de Comprobante ya existe", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If

        msj = blCaja.InsertaOtrosEgresos(entOtrosEgresos, gIdSucursal)

        If msj = "" Then
            MsgBox("El documento ha sido guardado con éxito", MsgBoxStyle.Information, "Nota")
        Else
            MsgBox("No fue posible guardar el documento" + Chr(13) + msj, MsgBoxStyle.Critical, "Nota")
            Return
        End If

        If MsgBox("¿Postear el Comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New rptPosteo
            rpt.xrlComprobante.Text = _NroComprobante.EditValue
            rpt.xrlCuenta.Text = _IdAsociado.EditValue
            rpt.xrlFecha.Text = _Fecha.EditValue
            rpt.xrlValor.Text = Format(_Monto.EditValue + _Iva.EditValue, "###,##0.00")
            rpt.xrlCajero.Text = objMenu.User
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("¿Postear nuevamente?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                    Exit While
                End If
            End While
        End If

        If leTipoMovimiento.EditValue = 201 And _Monto.EditValue >= 2500 Then
            MsgBox("Se imprimirá ahora la Declaración Jurada", MsgBoxStyle.Information, "Imprimir")
            'Declaracion Jurada
            Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
            Dim entProfesion As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociado.IdProfesion)
            Dim entMunicipio As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociado.IdMunicipio)
            Dim entSucursales As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            Dim entDocRtf As coo_Documentos = blcaja.coo_DocumentosSelectByPK("DeclaracionJuradaIngresosEgresos")
            Dim txt As String = entDocRtf.Contenido
            Dim rpt As New rpt_RichTextLogo
            rpt.XrLogoSuc.ImageUrl = EntSucursal.LogoImageUrl
            txt = txt.Replace("[NombreEmp]", gsNombre_Empresa)
            txt = txt.Replace("[Oficina]", entSucursales.Nombre)
            txt = txt.Replace("[Nombre]", _Nombre.EditValue)
            txt = txt.Replace("[Origen]", "ENTREGA DE REMESA")
            txt = txt.Replace("[Representacion]", "___________________________________")
            txt = txt.Replace("[Profesion]", entProfesion.Nombre)
            txt = txt.Replace("[Monto]", Format(_Monto.EditValue, "###,##0.00"))
            txt = txt.Replace("[Concepto]", _Concepto.EditValue)
            txt = txt.Replace("[Domicilio]", entMunicipio.Nombre)
            txt = txt.Replace("[Dui]", entAsociado.NumeroDocumento)
            txt = txt.Replace("[Nit]", entAsociado.Nit)
            txt = txt.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
            txt = txt.Replace("[Ciudad]", EntSucursal.Ciudad)
            txt = txt.Replace("[Fecha]", FechaToString(_Fecha.EditValue, _Fecha.EditValue))
            rpt.xrContenido.Rtf = txt
            rpt.PrintDialog()
        End If
        If _Monto.EditValue >= 3000 Then
            MsgBox("Se imprimirá ahora el Formulario de Control", MsgBoxStyle.Information, "Imprimir")
            'formulario Control
            Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
            Dim entActividadEconomica As coo_Actividades = objTablas.coo_ActividadesSelectByPK(entAsociados.IdActividad)
            Dim entCanton As adm_cantones = objTablas.adm_cantonesSelectByPK(entAsociados.IdCanton)
            Dim entEstadoCivil As pla_EstadoCivil = objTablas.pla_EstadoCivilSelectByPK(entAsociados.IdEstadoCivil)
            Dim entDespartamento As adm_Departamentos = objTablas.adm_DepartamentosSelectByPK(entAsociados.IdDepartamento)
            Dim entMunicipio As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
            Dim entProfesion As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)

            Dim rpt As New rptFormularioControl
            rpt.xrpbLogo.ImageUrl = EntSucursal.LogoImageUrl
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
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End If

        leAgente.ItemIndex = 0
        _Concepto.Text = ""
        _Direccion.Text = ""
        teDUI.Text = ""
        _Fecha.EditValue = blcaja.GetFechaContable(gIdSucursal)
        _FormaPago.ItemIndex = 0
        _IdAsociado.Text = ""
        _Iva.Text = 0.0
        _Monto.Text = 0.0
        _Nombre.Text = ""
        _NroComprobante.Text = ""
        _Remitente.Text = ""
        teValorRenta.EditValue = 0.0
        leTipoMovimiento.ItemIndex = 0
        teIdAsociado.EditValue = Nothing

        _FormaPago.Focus()
    End Sub

    Private Sub _IdAsociado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IdAsociado.Validated
        If SiEsNulo(_IdAsociado.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim EntAsociado As coo_Asociados = blcaja.coo_AsociadosSelectNumero(_IdAsociado.EditValue)
        If EntAsociado.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        With EntAsociado
            teIdAsociado.EditValue = EntAsociado.IdAsociado
            _Nombre.EditValue = .Nombres + " " + .Apellidos
            _Direccion.EditValue = .Direccion
            teDUI.EditValue = .NumeroDocumento
        End With
    End Sub

    Private Sub leRubro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leRubro.EditValueChanged
        objCombos.coo_CuentasGastos(leCuentaGasto, leRubro.EditValue)
    End Sub

    Private Sub _TipoMovimiento_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leTipoMovimiento.EditValueChanged
        If leTipoMovimiento.EditValue = 205 Then
            leRubro.Properties.ReadOnly = False
            leCuentaGasto.Properties.ReadOnly = False
            leAgente.EditValue = -1
            leAgente.Properties.ReadOnly = True
            _Remitente.EditValue = ""
            _Remitente.Properties.ReadOnly = True
            _Iva.Properties.ReadOnly = False
        Else
            leRubro.EditValue = -1
            leCuentaGasto.EditValue = -1
            leRubro.Properties.ReadOnly = True
            leCuentaGasto.Properties.ReadOnly = True
            _Iva.Properties.ReadOnly = True
            _Iva.EditValue = 0.0
            If leTipoMovimiento.EditValue <> 201 Then
                leAgente.EditValue = -1
                leAgente.Properties.ReadOnly = True
                _Remitente.EditValue = ""
                _Remitente.Properties.ReadOnly = True
            Else
                leAgente.Properties.ReadOnly = False
                _Remitente.Properties.ReadOnly = False
            End If
        End If
    End Sub

    Private Sub leCuentaGasto_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles leCuentaGasto.EditValueChanged
        CuentaGasto = objTablas.coo_CuentasGastosSelectByPK(leRubro.EditValue, leCuentaGasto.EditValue)
    End Sub
End Class