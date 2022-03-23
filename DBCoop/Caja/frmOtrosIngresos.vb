Imports DevExpress.XtraReports.UI
Imports System.Math
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports vb = Microsoft.VisualBasic

Public Class frmOtrosIngresos
    Dim blCaja As New CajaBusiness()
    Dim funCaja As New FuncionesBLL
    Dim entSucursal As New adm_Sucursales, dtParam As DataTable = blCaja.ObtieneParametros()

    Private Sub frmOtrosIngresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmOtrosIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        _FechaIngreso.EditValue = blCaja.GetFechaContable(gIdSucursal)
        teConceptoOtrosIngresos.EditValue = ""
        _Prefijo.Text = ""
        _Prefijo.EditValue = ""
        _Direccion.EditValue = ""
        _Dui.EditValue = ""
    End Sub

    Private Sub CargaCombos()
        With objCombos
            .cooPtmoFmaPago(_formPago)
            .cooTipoComprobanteIngreso(leTipoComprobante)
            .coo_TiposMovimientoCaja(_TipoMovimiento, " TipoAplicacion = 1")
        End With
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        Dim msj As String = ""
        If _NroComprobante.EditValue = "" Then
            entSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            _NroComprobante.EditValue = String.Format("{0}-{1}", gIdSucursal.ToString.PadLeft(2, "0"), (entSucursal.CorrelativoPago + 1).ToString.PadLeft(6, "0"))
        End If
        If _FechaIngreso.Text = "" Then
            MsgBox("Fecha de ingreso en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If (_IngresoExcento.EditValue + _IngresoGravado.EditValue + _IngresoNoSujeto.EditValue + teOtrosIngresos.EditValue) = 0 Then
            MsgBox("No ha registrado ningún ingreso", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim entOtrosIngresos As New coo_OtrosIngresos
        With entOtrosIngresos
            .IdMov = blCaja.ObtenerUltimoID("coo_OtrosIngresos", "IdMov")
            .PrefijoNumero = _Prefijo.EditValue
            .TipoComprobante = leTipoComprobante.EditValue
            .Numero = _NroComprobante.EditValue
            .Fecha = _FechaIngreso.EditValue
            .IdFormaPago = _formPago.EditValue
            .IdTipoMovimiento = _TipoMovimiento.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .Nombre = _NombreAsociado.Text
            .Direccion = _Direccion.EditValue
            .Dui = _Dui.EditValue
            .ValorNoSujeto = Val(_IngresoNoSujeto.EditValue)
            .ConceptoNoSujeto = _ConceptoNoSujeto.Text
            .ValorExento = Val(_IngresoExcento.EditValue)
            .ConceptoExento = _ConceptoExento.Text
            .ValorAfecto = Val(_IngresoGravado.EditValue)
            .ConceptoAfecto = _ConceptoGravado.Text
            .ValorIva = Round(.ValorAfecto - (.ValorAfecto / (pnIVA + 1)), 2)
            .OtrosIngresos = teOtrosIngresos.EditValue
            .ConceptoOtrosIngresos = teConceptoOtrosIngresos.EditValue
            .Observaciones = _observa.Text
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaContable = _FechaIngreso.EditValue 'blCaja.GetFechaContable(gIdSucursal)
            .FechaHoraCreacion = Now
        End With
        If blCaja.IdMovComprobanteIngreso(entOtrosIngresos.Numero, entOtrosIngresos.PrefijoNumero) <> 0 Then
            MsgBox("Numero de Comprobante ya Existe", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If

        msj = blCaja.InsertaOtrosIngresos(entOtrosIngresos, gIdSucursal)

        If msj = "" Then
            MsgBox("La transacción ha sido aplicada con éxito", MsgBoxStyle.Information, "Nota")
        Else
            MsgBox("No fue posible aplicar la transacción" + Chr(13) + msj, MsgBoxStyle.Critical, "Nota")
            Return
        End If

        If leTipoComprobante.EditValue = 2 Then
            If MsgBox("Desea imprimir la Factura ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim entAsociado As New coo_Asociados
                Dim myRpt As New pre_rptFacturaIngresos

                entAsociado = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

                Dim sDecimal = String.Format("{0:c}", Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                myRpt.xrlTotalPagado.Text = Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00")
                myRpt.xrlFechaContable.Text = _FechaIngreso.EditValue
                myRpt.xrlNombre.Text = _NombreAsociado.EditValue
                myRpt.xrlNumeroAsociado.Text = _IdAsociado.EditValue
                myRpt.xrlDireccion.Text = _Direccion.EditValue

                myRpt.xrlDui.Text = _Dui.EditValue
                myRpt.xrlComprobante.Text = _NroComprobante.EditValue
                myRpt.xrlConceptoOtrosIngresos.Text = teConceptoOtrosIngresos.EditValue
                myRpt.xrlOtrosIngresos.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                myRpt.xrlConceptoNoSujeto.Text = _ConceptoNoSujeto.EditValue
                myRpt.xrlNoSujeto.Text = Format(CDec(_IngresoNoSujeto.EditValue), "##,##0.00")
                myRpt.xrlConceptoExento.Text = _ConceptoExento.EditValue
                myRpt.xrlExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                myRpt.xrlconceptoGravado.Text = _ConceptoGravado.EditValue
                myRpt.xrlGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")

                myRpt.xrlTotalOtros.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                myRpt.xrlTotalExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                myRpt.xrlTotalExento2.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                myRpt.xrlTotalGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")
                If _IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue >= 1 Then
                    myRpt.xrlCantidadLetras.Text = Num2Text(Int(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue))) & " " & sDecimal & " DÓLARES"
                Else
                    myRpt.xrlCantidadLetras.Text = sDecimal & " DÓLARES"
                End If
                myRpt.PrinterName = gsImpresorDefault
                While True
                    myRpt.PrintDialog()
                    If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If

        If leTipoComprobante.EditValue = 1 Then
            If MsgBox("Desea imprimir el Comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim myRpt2 As New pre_rptComprobIngreso
                Dim sDecimal = String.Format("{0:c}", Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                myRpt2.xrlConceptoIngreso.Text = teConceptoOtrosIngresos.EditValue
                myRpt2.xrlIngreso.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                myRpt2.xrlConceptoNoSujeto.Text = _ConceptoNoSujeto.EditValue
                myRpt2.xrlNoSujeto.Text = Format(CDec(_IngresoNoSujeto.EditValue), "##,##0.00")
                myRpt2.xrlConceptoExento.Text = _ConceptoExento.EditValue
                myRpt2.xrlExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                myRpt2.xrlConceptoGravado.Text = _ConceptoGravado.EditValue
                myRpt2.xrlGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")
                myRpt2.xrlTotal.Text = Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00")

                myRpt2.xrlFecha.Text = FechaToString(_FechaIngreso.EditValue, _FechaIngreso.EditValue)
                myRpt2.xrlNombre.Text = _NombreAsociado.EditValue
                myRpt2.xrlNumero.Text = _IdAsociado.EditValue
                If _IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue >= 1 Then
                    myRpt2.xrlCantidadLetras.Text = Num2Text(Int(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue))) & " " & sDecimal & " DÓLARES"
                Else
                    myRpt2.xrlCantidadLetras.Text = sDecimal & " DÓLARES"
                End If

                myRpt2.PrinterName = gsImpresorDefault
                While True
                    myRpt2.PrintDialog()
                    If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While

            End If
        End If
        If leTipoComprobante.EditValue > 2 Then
            If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim rpt3 As New rptPosteo
                rpt3.xrlComprobante.Text = _Prefijo.EditValue.ToString
                rpt3.xrlCuenta.Text = _IdAsociado.EditValue
                rpt3.xrlFecha.Text = _FechaIngreso.EditValue
                rpt3.xrlValor.Text = Format(CDec((_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue)), "##,##0.00")
                rpt3.xrlCajero.Text = objMenu.User
                rpt3.PrinterName = gsImpresorDefault
                While True
                    rpt3.PrintDialog()
                    If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If
        'ENVÍO DE REMSAS
        If _TipoMovimiento.EditValue = 113 And (_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue) >= 500 Then
            MsgBox("Se imprimirá ahora la declaracion Jurada", MsgBoxStyle.Information, "Imprimir")
            'Declaración Jurada
            Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
            Dim entProfesion As coo_Profesiones = objTablas.coo_ProfesionesSelectByPK(entAsociado.IdProfesion)
            Dim entMunicipio As adm_Municipios = objTablas.adm_MunicipiosSelectByPK(entAsociado.IdMunicipio)
            Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            Dim entDocRtf As coo_Documentos = blCaja.coo_DocumentosSelectByPK("DeclaracionJuradaIngresosEgresos")
            Dim txt As String = entDocRtf.Contenido
            Dim rpt As New rpt_RichTextLogo
            rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
            txt = txt.Replace("[NombreEmp]", gsNombre_Empresa)
            txt = txt.Replace("[Oficina]", entSucursal.Nombre)
            txt = txt.Replace("[Nombre]", _NombreAsociado.EditValue)
            txt = txt.Replace("[Representacion]", "___________________________________")
            txt = txt.Replace("[Origen]", "RECEPCIÓN DE REMESA")
            txt = txt.Replace("[Profesion]", entProfesion.Nombre)
            txt = txt.Replace("[Monto]", Format(CDec(teOtrosIngresos.EditValue), "###,##0.00"))
            txt = txt.Replace("[Concepto]", teConceptoOtrosIngresos.EditValue)
            txt = txt.Replace("[Domicilio]", entMunicipio.Nombre)
            txt = txt.Replace("[Dui]", entAsociado.NumeroDocumento)
            txt = txt.Replace("[Nit]", entAsociado.Nit)
            txt = txt.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
            txt = txt.Replace("[Ciudad]", entSucursal.Ciudad)
            txt = txt.Replace("[Fecha]", FechaToString(_FechaIngreso.EditValue, _FechaIngreso.EditValue))
            rpt.xrContenido.Rtf = txt
            rpt.PrintDialog()
        End If

        If (_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue) >= 3000 Or (_TipoMovimiento.EditValue = 113 And (_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue) >= 500) Then
            MsgBox("Se imprimirá ahora el Formulario de Control", MsgBoxStyle.Information, "Imprimir")
            'Formulario Control
            Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
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
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End If
        _ConceptoExento.Text = ""
        _ConceptoGravado.Text = ""
        _ConceptoNoSujeto.Text = ""
        _Direccion.Text = ""
        _Dui.Text = ""
        _FechaIngreso.EditValue = Today
        _formPago.ItemIndex = 0
        _IdAsociado.Text = ""
        _IngresoExcento.EditValue = 0.0
        _IngresoGravado.EditValue = 0.0
        _IngresoNoSujeto.EditValue = 0.0
        teOtrosIngresos.EditValue = 0.0
        _NombreAsociado.Text = ""
        _Prefijo.Text = ""
        _observa.Text = ""
        _NroComprobante.Text = ""
        teConceptoOtrosIngresos.EditValue = ""
        _TipoMovimiento.ItemIndex = 0
        _formPago.Focus()
    End Sub

    Private Sub _IdAsociado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles _IdAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        _IdAsociado.EditValue = frmConsultaAsociados.NumAsociado
        _IdAsociado_Validated(e, New EventArgs)
    End Sub

    Private Sub _IdAsociado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles _IdAsociado.Validated
        If SiEsNulo(_IdAsociado.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim EntAsociado As coo_Asociados = blCaja.coo_AsociadosSelectNumero(_IdAsociado.EditValue)
        If EntAsociado.IdAsociado = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        With EntAsociado
            teIdAsociado.EditValue = EntAsociado.IdAsociado
            _NombreAsociado.EditValue = .Nombres + " " + .Apellidos
            _Direccion.EditValue = .Direccion
            _Dui.EditValue = .NumeroDocumento
        End With
    End Sub

    Private Sub leTipoComprobante_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leTipoComprobante.EditValueChanged
        If leTipoComprobante.EditValue = 2 Or leTipoComprobante.EditValue = 3 Then
            _IngresoGravado.Properties.ReadOnly = False
            _IngresoExcento.Properties.ReadOnly = False
            _IngresoNoSujeto.Properties.ReadOnly = False
            _ConceptoExento.Properties.ReadOnly = False
            _ConceptoGravado.Properties.ReadOnly = False
            _ConceptoNoSujeto.Properties.ReadOnly = False
        Else
            _IngresoGravado.Properties.ReadOnly = True
            _IngresoExcento.Properties.ReadOnly = True
            _IngresoNoSujeto.Properties.ReadOnly = True
            _ConceptoExento.Properties.ReadOnly = True
            _ConceptoGravado.Properties.ReadOnly = True
            _ConceptoNoSujeto.Properties.ReadOnly = True
            _IngresoGravado.EditValue = 0.0
            _IngresoExcento.EditValue = 0.0
            _IngresoNoSujeto.EditValue = 0.0
            _ConceptoGravado.EditValue = ""
            _ConceptoExento.EditValue = ""
            _ConceptoNoSujeto.EditValue = ""
        End If
    End Sub
End Class