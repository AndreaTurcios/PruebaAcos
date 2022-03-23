Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports vb = Microsoft.VisualBasic
Imports System.Diagnostics

Public Class frmIngresoDesembolsos
    Dim entPrestamo As New coo_Prestamos, entDesembolso As New coo_PrestamosDetalle
    Dim entCuentaAhorro As coo_CuentasAhorro, entDeposito As New coo_CuentasAhorroMov, entSimultaneo As New coo_CuentasAhorroMov
    Dim entAportacion As New coo_Aportaciones, entCapitalizacion As New coo_Aportaciones
    Dim entSolicitud As coo_Solicitudes
    Dim entPlanPago As New List(Of coo_PrestamosPlanPagos)
    Dim entCancelacion As New List(Of coo_PrestamosDetalle)
    Dim entPignora As New List(Of coo_Pignoraciones)
    Dim entRefinancia As New DataTable
    Dim entDescuentosSolicitud As New DataTable
    Dim entLiquidacion As New coo_PrestamosDesembolso
    Dim blCaja As New CajaBusiness(), dtParam As DataTable = blCaja.ObtieneParametros()
    Dim entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)

    Private Sub pre_frmIngresoDesembolsos_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub pre_frmIngresoDesembolsos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles()
        objCombos.cooTipoDesembolso(leTipoDesembolso)
        seNumeroDesembolso.Properties.ReadOnly = True
        teMontoDesembolso.Properties.ReadOnly = True
        teMontoLiquido.Properties.ReadOnly = True
        teNumeroPrestamo.Properties.ReadOnly = True
        teIdCuentaAhorro.Properties.ReadOnly = True
        teNombre.Properties.ReadOnly = True
        leTipoDesembolso.EditValue = 1
        teIdSolicitudFondo.Focus()
    End Sub

    Private Sub CargaControles()
        teNombre.EditValue = ""
        seNumeroDesembolso.EditValue = 1
        deFechaDesembolso.EditValue = blCaja.GetFechaContable(gIdSucursal)
        teMontoDesembolso.EditValue = 0.0
        teMontoLiquido.EditValue = 0.0
        teNumeroPrestamo.EditValue = ""
        beNoCuentaAhorro.EditValue = ""
        teIdCuentaAhorro.EditValue = 0
    End Sub

    Private Sub teIdSolicitudFondo_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles teIdSolicitudFondo.MouseClick
        frmConsultaSolicitudFondos.ShowDialog()
        teIdSolicitudFondo.EditValue = frmConsultaSolicitudFondos.IdsolicitudFondo
        teIdSolicitudFondo_Validated(e, New EventArgs)
    End Sub

    Private Sub teIdSolicitudFondo_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles teIdSolicitudFondo.Validated
        Dim entSolicitudFondo As New coo_SolicitudFondos, entSolicitudCredito As New coo_Solicitudes
        Dim entAsociados As New coo_Asociados, entMunicipios As New adm_Municipios
        Dim NumeroPrestamo As String, TotalChequesTerceros As Decimal = 0.0

        If teIdSolicitudFondo.EditValue = Nothing Then
            Exit Sub
        End If
        entSolicitudFondo = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)
        entSolicitudCredito = objTablas.coo_SolicitudesSelectByPK(entSolicitudFondo.IdSolicitud)
        entAsociados = objTablas.coo_AsociadosSelectByPK(entSolicitudCredito.IdAsociado)
        entMunicipios = objTablas.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        If entSolicitudFondo.IdSolicitudFondo <= 0 Then
            MsgBox("La solicitud de fondos no existe", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entAsociados.IdCanton = "" Then
            MsgBox("No se le ha asignado comunidad al Asociado", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entAsociados.IdMunicipio = "" Then
            MsgBox("No se le ha asignado municipio al Asociado", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entSolicitudFondo.Entregado = True Then
            MsgBox("No es posible realizar el desembolso. La solicitud de fondos ya fue aplicado", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        teIdSolicitudFondo.EditValue = entSolicitudFondo.IdSolicitudFondo
        teNombre.EditValue = String.Format("{0} - {1} {2}", entSolicitudCredito.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        seNumeroDesembolso.EditValue = entSolicitudFondo.IdDesembolso
        teMontoDesembolso.EditValue = entSolicitudFondo.MontoDesembolso
        TotalChequesTerceros = blCaja.ValorChequesDesembolso(entSolicitudFondo.IdSolicitud)
        teMontoLiquido.EditValue = entSolicitudFondo.MontoDesembolso - (entSolicitudFondo.TotalRefinanciamiento + entSolicitudFondo.Capitalizacion + entSolicitudFondo.Aportacion + entSolicitudFondo.Ahorro + entSolicitudFondo.TotalOtrasDeducciones + entSolicitudFondo.Iva + TotalChequesTerceros)
        NumeroPrestamo = blCaja.ExisteSolicitudPrestamo(entSolicitudFondo.IdSolicitud)
        If NumeroPrestamo = "" Then
            NumeroPrestamo = String.Format("{0}-{1}-{2}", gIdSucursal.ToString.PadLeft(2, "0"), entAsociados.IdMunicipio, (entMunicipios.Correlativo + 1).ToString.PadLeft(4, "0"))
        End If
        teNumeroPrestamo.EditValue = NumeroPrestamo
        teIdCuentaAhorro.EditValue = entSolicitudFondo.IdCuenta
    End Sub

    Private Sub beNoCuentaAhorro_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles beNoCuentaAhorro.MouseClick
        Dim entSolicitudFondo As coo_SolicitudFondos = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)
        frmConsultaCuentasCorriente.IdAsociado = entSolicitudFondo.IdAsociado
        frmConsultaCuentasCorriente.ShowDialog()
        beNoCuentaAhorro.EditValue = frmConsultaCuentasCorriente.Numero
        beNoCuentaAhorro_Validated(e, New EventArgs)
    End Sub

    Private Sub beNoCuentaAhorro_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles beNoCuentaAhorro.Validated
        If SiEsNulo(beNoCuentaAhorro.EditValue, "") = "" Then
            Exit Sub
        End If
        If teIdCuentaAhorro.EditValue = 0 Or teIdCuentaAhorro.EditValue = Nothing Then
            teIdCuentaAhorro.EditValue = blCaja.GetIdCuentaAhorro(beNoCuentaAhorro.EditValue)
        End If

        Dim entCuentaCorriente As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuentaAhorro.EditValue)
        Dim entSolicitudFondo As coo_SolicitudFondos = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)

        If entCuentaCorriente.Numero = "" Then
            MsgBox("No existe el número de Cuenta", MsgBoxStyle.Critical, "Error")
            teIdCuentaAhorro.EditValue = 0
            beNoCuentaAhorro.EditValue = ""
            beNoCuentaAhorro.Focus()
            Exit Sub
        End If
        If entSolicitudFondo.IdAsociado <> entCuentaCorriente.IdAsociado Then
            MsgBox("La cuenta no corresponde al asociado", MsgBoxStyle.Critical, "Error")
            teIdCuentaAhorro.EditValue = 0
            beNoCuentaAhorro.EditValue = ""
            beNoCuentaAhorro.Focus()
            Exit Sub
        End If
        beNoCuentaAhorro.EditValue = entCuentaCorriente.Numero
        teIdCuentaAhorro.EditValue = entCuentaCorriente.IdCuenta
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGuardar.Click

        If Not DatosValidos() Then
            Exit Sub
        End If
        Dim entSolicitudFondo As New coo_SolicitudFondos
        Dim entAsociados As New coo_Asociados

        Dim ValorPapeleria As Decimal = 0.0, TotalFactura As Decimal = 0.0
        Dim ValorFPP As Decimal = 0.0
        entSolicitudFondo = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)
        entAsociados = objTablas.coo_AsociadosSelectByPK(entSolicitudFondo.IdAsociado)

        CargaEntidades()
        If seNumeroDesembolso.EditValue = 1 Then
            Dim msj As String = blCaja.InsertaPrimerDesembolso(entPrestamo, entDesembolso, entDeposito, entPlanPago, _
            teIdSolicitudFondo.EditValue, entAsociados.IdMunicipio, entLiquidacion, entSimultaneo, _
            entAportacion, entCapitalizacion, entCancelacion, entPignora)
            If msj = "" Then
                MsgBox("El desembolso ha sido aplicado con éxito", MsgBoxStyle.Information, "Nota")
            Else
                MsgBox("No fue posible aplicar el desembolso" + Chr(13) + msj, MsgBoxStyle.Critical, "Nota")
                Return
            End If
        Else
            Dim msj As String = blCaja.InsertaDesembolso(entDesembolso, entDeposito, teIdSolicitudFondo.EditValue, entLiquidacion, entSimultaneo, entAportacion, entCapitalizacion, entCancelacion, entPignora, entSolicitud)
            If msj = "" Then
                MsgBox("El desembolso ha sido aplicado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible aplicar el desembolso" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If

        'PENDIENTE DE DEFINIR LA IMPRESION DE LA FACTURA Y COMPROBANTE DE DEPOSITO POR PARTE DE LA CAJERA
        For Each entDetalle As coo_PrestamosDetalle In entCancelacion
            Dim entPrestamo As New coo_Prestamos
            entPrestamo = objTablas.coo_PrestamosSelectByPK(entPrestamo.IdPrestamo)

            If MsgBox("Desea imprimir la factura de cancelación del préstamo #" & entPrestamo.Numero, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then

                Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
                Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)

                Dim entFuente As coo_Fuentes = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
                Dim IdMov As Integer
                Dim rpt1 As New pre_rptFacturaPago

                ' IdMov = blCaja.UltMovReferencia(leReferencia.EditValue, entPrestamo.IdPrestamo)
                entPrestamo = objTablas.coo_PrestamosSelectByPK(entPrestamo.IdPrestamo)
                entAsociado = objTablas.coo_AsociadosSelectByPK(entAsociado.IdAsociado)
                entLinea = objTablas.coo_LineasSelectByPK(entPrestamo.IdLinea)
                entFuente = objTablas.coo_FuentesSelectByPK(entPrestamo.IdFuente)
                ' entDetalle = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo), IdMov)


                Dim sDecimal = String.Format("{0:c}", Format(CDec(entDetalle.ImportePagado), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt1.xrlTotalPagado.Text = Format(CDec(entDetalle.ImportePagado), "##,##0.00")
                rpt1.xrlFechaContable.Text = entDetalle.FechaContable
                rpt1.xrlNombre.Text = entAsociado.Nombres & " " & entAsociado.Apellidos
                rpt1.xrlNumeroAsociado.Text = entAsociado.Numero
                rpt1.xrlDireccion.Text = entAsociado.Direccion
                rpt1.xrlIdMov.Text = (entDetalle.IdMov - 1)
                rpt1.xrlFechaOtorgado.Text = entPrestamo.FechaAprobado
                rpt1.xrlLinea.Text = entLinea.Nombre
                rpt1.xrlEmpresa.Text = gsNombre_Empresa
                rpt1.xrlFuente.Text = entFuente.Nombre
                rpt1.xrlNumeroPrestamo.Text = entPrestamo.Numero
                If entPrestamo.IdTipoCartera = 3 Then
                    rpt1.xrlTipoCartera.Text = "PRESTAMO SANEADO"
                Else
                    rpt1.xrlTipoCartera.Text = ""
                End If
                '  rpt1.xrlTasaInteres.Text = dt.Rows(i).Item("TasaInteres")
                rpt1.xrlNuevoSaldo.Text = Format(CDec(entDetalle.SaldoCapital), "##,##0.00")
                rpt1.xrlCapitalPagado.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
                rpt1.xrlSaldoCapital.Text = Format(CDec(entDetalle.SaldoCapital + entDetalle.CapitalPagado), "##,##0.00")
                rpt1.xrlInteresPendiente.Text = entDetalle.InteresPendiente
                rpt1.xrlFechaUltPago.Text = entDetalle.Fecha
                rpt1.xrlFechaVencimiento.Text = entPrestamo.FechaVencimiento
                rpt1.xrlMontoOtorgado.Text = Format(CDec(entPrestamo.MontoAprobado), "##,##0.00")
                rpt1.xrlComprobante.Text = entDetalle.Numero
                rpt1.xrlCapital.Text = Format(CDec(entDetalle.CapitalPagado), "##,##0.00")
                rpt1.xrlAportacion.Text = entDetalle.CuotaAportacion
                rpt1.xrlAhorro.Text = entDetalle.CuotaAhorro
                rpt1.xrlInteres.Text = entDetalle.InteresPagado
                rpt1.xrlInteresMora.Text = entDetalle.InteresMoraPagado
                rpt1.xrlSeguroDeuda.Text = entDetalle.ValorSeguroPagado
                rpt1.xrlManejo.Text = entDetalle.ManejoPagado
                rpt1.xrlTotalOtros.Text = entDetalle.CapitalPagado + entDetalle.CuotaAhorro
                rpt1.xrlTotalOtros2.Text = entDetalle.ValorSeguroPagado + entDetalle.ManejoPagado + entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt1.xrlTotalExento.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt1.xrlTotalExento2.Text = entDetalle.InteresPagado + entDetalle.InteresMoraPagado
                rpt1.xrlTotalGravado.Text = entDetalle.ManejoPagado
                rpt1.xrlValorCuota.Text = Format(CDec(entPrestamo.ValorCuota), "##,##0.00")
                rpt1.xrlNumCuotas.Text = entPrestamo.NumCuotas
                rpt1.ShowPrintMarginsWarning = False
                rpt1.xrlCantidadLetras.Text = Num2Text(Int(entDetalle.ImportePagado)) & " " & sDecimal & " DÓLARES"
                rpt1.ShowPreviewDialog()
            End If
        Next

        ValorPapeleria = blCaja.ValorPapeleriaDesembolso(entSolicitudFondo.IdSolicitudFondo)
        ValorFPP = blCaja.ValorFPP(entSolicitudFondo.IdSolicitudFondo)
        If ValorPapeleria > 0.0 Then
            If MsgBox("¿Imprimir la Factura por Tramitación?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim entAsociado As New coo_Asociados
                Dim rpt1 As New pre_rptFacturaIngresos

                entAsociado = objTablas.coo_AsociadosSelectByPK(entAsociados.IdAsociado)
                TotalFactura = ValorPapeleria + entSolicitudFondo.Iva + ValorFPP
                Dim sDecimal = String.Format("{0:c}", Format(CDec(TotalFactura), "##,##0.00"))

                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt1.xrlTotalPagado.Text = Format(CDec(TotalFactura), "##,##0.00")
                rpt1.xrlFechaContable.Text = deFechaDesembolso.EditValue
                rpt1.xrlNombre.Text = teNombre.EditValue
                rpt1.xrlNumeroAsociado.Text = entAsociado.Numero
                rpt1.xrlDireccion.Text = entAsociado.Direccion

                rpt1.xrlDui.Text = entAsociado.NumeroDocumento
                rpt1.xrlComprobante.Text = ""
                rpt1.xrlConceptoOtrosIngresos.Text = ""
                rpt1.xrlOtrosIngresos.Text = Format(CDec(0.0), "##,##0.00")
                rpt1.xrlConceptoNoSujeto.Text = "3% FPP"
                rpt1.xrlNoSujeto.Text = Format(CDec(ValorFPP), "##,##0.00")
                rpt1.xrlConceptoExento.Text = ""
                rpt1.xrlExento.Text = Format(CDec(0.0), "##,##0.00")
                rpt1.xrlconceptoGravado.Text = ""
                rpt1.xrlGravado.Text = Format(CDec(ValorPapeleria), "##,##0.00")
                rpt1.xrlIva.Text = Format(CDec(entSolicitudFondo.Iva), "##,##0.00")

                rpt1.xrlTotalOtros.Text = Format(0.0, "##,##0.00")
                rpt1.xrlTotalExento.Text = Format(0.0, "##,##0.00")
                rpt1.xrlTotalExento2.Text = Format(0.0, "##,##0.00")
                rpt1.xrlTotalGravado.Text = Format(CDec(TotalFactura), "##,##0.00")
                rpt1.xrlSaldo.Text = Format(CDec(entSolicitudFondo.MontoDesembolso), "##,##0.00")

                rpt1.xrlCantidadLetras.Text = Num2Text(Int(CDec(TotalFactura))) & " " & sDecimal & " DÓLARES"
                rpt1.PrinterName = gsImpresorDefault
                While True
                    rpt1.PrintDialog()
                    If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If

        'If MsgBox("Actualizar Libreta de Ahorros?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
        '    If gsNombre_Empresa.StartsWith("ACAPRO") Then
        '        ActualizaLibretaAhorroPorCodigo(entCuentaAhorro.IdCuenta, teLineaLibreta.EditValue, 24)
        '    Else
        '        ImprimeLibretaAhorro(entDeposito.IdCuenta, teLineaLibreta.EditValue, 24)
        '    End If
        'End If
        'entCuentaAhorro = blCaja.coo_CuentasAhorroSelectByPK(entDeposito.IdCuenta)

        'If MsgBox("Postear el Comprobante de depósito?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
        '    Dim rpt1 As New rptPosteo
        '    rpt1.xrlComprobante.Text = entDeposito.NumeroDoc.ToString()
        '    rpt1.xrlCuenta.Text = entCuentaAhorro.Numero.ToString
        '    rpt1.xrlFecha.Text = entDeposito.Fecha
        '    rpt1.xrlValor.Text = entDeposito.Valor
        '    rpt1.xrlCajero.Text = objmenu.user
        '    rpt1.PrinterName = gsImpresorDefault
        '    While True
        '        rpt1.PrintDialog()
        '        If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
        '            Exit While
        '        End If
        '    End While
        'End If


        'If MsgBox("Desea imprimir el comprobante de depósito en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
        '    Dim rpt1 As New aho_rptDepositoAhorro
        '    Dim sDecimal = String.Format("{0:c}", Format(CDec(entDeposito.Valor), "##,##0.00"))

        '    sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
        '    rpt1.DataSource = blCaja.rptDepositoAhorroIdMov(entDeposito.IdMov, entDeposito.IdCuenta)
        '    rpt1.xrlMensaje.Text = dtParam.Rows(0).Item("MensajeCooperativo")
        '    rpt1.xrlLugarFecha.Text = dtParam.Rows(0).Item("Municipio") + ", " + FechaToString(Today, Today)
        '    rpt1.xrlCantidadLetras.Text = Num2Text(Int(entDeposito.Valor)) & " " & sDecimal & " DÓLARES"
        '    rpt1.xrlEmpresa.Text = gsNombre_Empresa
        '    rpt1.PrinterName = gsImpresorDefault
        '    While True
        '        rpt1.PrintDialog()
        '        If MsgBox("¿Generar otra impresión del documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
        '            Exit While
        '        End If
        '    End While
        'End If

        If teMontoLiquido.EditValue < 3000 Then
            Close()
            Exit Sub
        End If

        'MsgBox("Se impimirá ahora la Declaración Jurada", MsgBoxStyle.Information, "Imprimir")
        ''Declaracion Jurada
        'Dim UltMovAhorro As Integer = blCaja.GetUltMovAhorro(entDeposito.IdCuenta)
        'Dim entidad As coo_DeclaracionJurada = blCaja.rptDeclaracionJurada(entDeposito.IdCuenta, UltMovAhorro)

        'Dim entDocRtf As coo_Documentos = blCaja.coo_DocumentosSelectByPK("DeclaracionJuradaPrestamo")
        'Dim txt As String = entDocRtf.Contenido
        'Dim rpt As New rpt_RichTextLogo
        'rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl

        'With entidad
        '    txt = txt.Replace("[NombreEmp]", gsNombre_Empresa)
        '    txt = txt.Replace("[Oficina]", .Sucursal)
        '    txt = txt.Replace("[Nombre]", .NombreAsociado)
        '    txt = txt.Replace("[Origen]", "OTORGAMIENTO DE PRESTAMO EN ESTA FECHA") 'PENDIENTE DE REVISAR Y VALIDA CON EL OFICIAL DE CUMPLIMIENTO
        '    txt = txt.Replace("[Profesion]", .Profesion)
        '    txt = txt.Replace("[Representacion]", "_______________________________")
        '    txt = txt.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
        '    '    txt = txt.Replace("[NombreEmp]", gsNombre_Empresa)
        '    txt = txt.Replace("[Monto]", Format(.MontoApertura, "###,##0.00"))
        '    txt = txt.Replace("[Concepto]", "DEPOSITO DE AHORRO POR DESEMBOLSO A CTA. No. " & .NumeroCuenta)
        '    txt = txt.Replace("[Domicilio]", .Municipio)
        '    txt = txt.Replace("[Dui]", .Dui)
        '    txt = txt.Replace("[Nit]", .Nit)
        '    txt = txt.Replace("[Fecha]", FechaToString(Today, Today))
        '    txt = txt.Replace("[Ciudad]", entSucursal.Ciudad)
        'End With
        'rpt.xrContenido.Rtf = txt
        'rpt.PrintDialog()

        'MsgBox("Se imprimirá ahora el formulario de control", MsgBoxStyle.Information, "Imprimir")
        ''Formulario de Control
        'entAsociados = blCaja.coo_AsociadosSelectByPK(entCuentaAhorro.IdAsociado)
        'Dim entActividadEconomica As coo_Actividades = blCaja.coo_ActividadesSelectByPK(entAsociados.IdActividad)
        'Dim entCanton As adm_Cantones = blCaja.adm_CantonesSelectByPK(entAsociados.IdCanton)
        'Dim entEstadoCivil As pla_EstadoCivil = blCaja.pla_EstadoCivilSelectByPK(entAsociados.IdEstadoCivil)
        'Dim entDespartamento As adm_Departamentos = blCaja.adm_DepartamentosSelectByPK(entAsociados.IdDepartamento)
        'Dim entMunicipio As adm_Municipios = blCaja.adm_MunicipiosSelectByPK(entAsociados.IdMunicipio)
        'Dim entProfesion As coo_Profesiones = blCaja.coo_ProfesionesSelectByPK(entAsociados.IdProfesion)

        'Dim rpt2 As New rptFormularioControl
        'rpt2.xrpbLogo.ImageUrl = entSucursal.LogoImageUrl

        'rpt2.xrlActividad.Text = entActividadEconomica.Nombre

        'Dim PosicionCadena As Integer = vb.InStr(vb.Trim(entAsociados.Apellidos), " ")
        'If PosicionCadena = 0 Then
        '    rpt2.xrlApellidoPat.Text = entAsociados.Apellidos
        '    rpt2.xrlApellidoMat.Text = ""
        'Else
        '    rpt2.xrlApellidoPat.Text = vb.Left(vb.Trim(entAsociados.Apellidos), vb.InStr(vb.Trim(entAsociados.Apellidos), " "))
        '    rpt2.xrlApellidoMat.Text = vb.Mid(vb.Trim(entAsociados.Apellidos), vb.InStr(vb.Trim(entAsociados.Apellidos), " "))
        'End If
        'rpt2.xrlNombres.Text = entAsociados.Nombres
        'rpt2.xrlFechaNac.Text = Format(entAsociados.FechaNacimiento, "dd/MM/yyyy")
        'rpt2.xrlNacion.Text = entAsociados.Nacionalidad
        'rpt2.xrlSexo.Text = IIf(entAsociados.IdSexo = 1, "Masculino", "Femenino")
        'rpt2.xrlDui.Text = entAsociados.NumeroDocumento
        'rpt2.xrlEstado.Text = entEstadoCivil.Nombre
        'rpt2.xrlProfesion.Text = entProfesion.Nombre

        'rpt2.xrlDireccion.Text = entAsociados.Direccion & ", " & entMunicipio.Nombre & "/" & entDespartamento.Nombre
        'rpt2.xrlCanton.Text = entCanton.Nombre
        'rpt2.xrlOtros.Text = entAsociados.Ubicacion
        'rpt2.xrlNoAsociado.Text = entAsociados.Numero
        'rpt2.xrlTelefono.Text = entAsociados.Telefonos
        'rpt2.ShowPrintMarginsWarning = False
        'rpt2.PrintDialog()

        'CargaControles()
        Close()
    End Sub

    Function DatosValidos() As Boolean

        If teIdSolicitudFondo.EditValue = 0 Then
            MsgBox("Es necesario especificar la Solicitud de Fondos", MsgBoxStyle.Critical, "Imposible continuar")
            teIdSolicitudFondo.Focus()
            Return False
        End If

        Dim entSolicitudFondo As coo_SolicitudFondos = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)

        If seNumeroDesembolso.EditValue = 0 Then
            MsgBox("El Número de desembolso debe ser Mayor a cero", MsgBoxStyle.Critical, "Imposible Continuar")
            teIdSolicitudFondo.Focus()
            Return False
        End If
        'If teComprobante.EditValue = "" Then
        '    MsgBox(String.Format("Debe especificar el Número de Comprobante de Desembolso{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    teComprobante.Focus()
        '    Return False
        'End If
        If SiEsNulo(deFechaDesembolso.EditValue, Nothing) = Nothing Then
            MsgBox(String.Format("Debe especificar la Fecha del Desembolso{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaDesembolso.Focus()
            Return False
        End If
        Dim FechaContable As Date = blCaja.GetFechaContable(gIdSucursal)
        'If FechaContable > deFechaDesembolso.EditValue Then
        '    MsgBox("Fecha de desembolso invalida porque corresponde a un período ya cerrado", MsgBoxStyle.Critical, "Error al guardar el registro")
        '    deFechaDesembolso.Focus()
        '    Return False
        'End If
        If entSolicitudFondo.TotalRefinanciamiento > 0.0 Then
            If deFechaDesembolso.EditValue <> entSolicitudFondo.FechaEntrega Then
                MsgBox("La Fecha de Desembolso debe ser la Misma que la Solicitud de Fondos", MsgBoxStyle.Critical, "Error al Guardar el registro")
                Return False
            End If
        End If
        'If teMontoLiquido.EditValue <= 0 Then
        '    MsgBox(String.Format("El Monto a desembolsar no es Valido{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    teMontoDesembolso.Focus()
        '    Return False
        'End If
        If teMontoLiquido.EditValue > 0.0 Then
            If teIdCuentaAhorro.EditValue = 0 And leTipoDesembolso.EditValue = 2 Then
                MsgBox(String.Format("Debe especificar la cuenta de Ahorro para Depositar el Desembolso{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                beNoCuentaAhorro.Focus()
                Return False
            End If
        End If
        'If blCaja.ExisteNumComprobanteDesembolso(teComprobante.EditValue) > 0 Then
        '    MsgBox("Ya existe un número de comprobante con este número", MsgBoxStyle.Critical)
        '    Return False
        'End If
        If blCaja.ExisteNumPrestamo(teNumeroPrestamo.EditValue) > 0 And seNumeroDesembolso.EditValue = 1 Then
            MsgBox("Ya existe el número de Préstamo", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        Dim entSolicitudFondo As coo_SolicitudFondos = objTablas.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)
        Dim entResolucion As coo_Resoluciones = objTablas.coo_ResolucionesSelectByPK(entSolicitudFondo.IdSolicitud)
        Dim entSolicitudCredito As coo_Solicitudes = objTablas.coo_SolicitudesSelectByPK(entSolicitudFondo.IdSolicitud)
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entSolicitudFondo.IdAsociado)

        Dim pres As New Prestamo()
        Dim IdPrestamo As Integer, SaldoCapital As Decimal
        Dim entPignoracion As New DataTable


        IdPrestamo = blCaja.ExistePrestamo(entSolicitudCredito.IdSolicitud)
        'DiasPrestamo = bl.ObtieneParametros

        entRefinancia = blCaja.coo_SolicitudFondosRefinanciaSelectByFondo(teIdSolicitudFondo.EditValue)
        entDescuentosSolicitud = blCaja.coo_SolicitudDescuentosSelectBySolicitud(entSolicitudFondo.IdSolicitud)

        With pres
            .CapitalInicial = entResolucion.MontoAprobado
            .NumeroCuotas = entResolucion.NumeroCuotasAprobada
            .DiasPorAnio = dtParam.Rows(0).Item("DiasPrestamo")
            .TasaInteresAnual = entResolucion.TasaInteresAprobada
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .FechaOtorgamiento = deFechaDesembolso.EditValue
            .IdFormaPago = entResolucion.IdFormaPagoAprobado
            .FrecuenciaPago = entResolucion.FrecuenciaPagoAprobado
            .TipoCuota = entSolicitudCredito.TipoCuota
            .ImporteCuotaAhorro = entSolicitudCredito.CuotaAhorro
            .ImporteCuotaManejo = entSolicitudCredito.CuotaManejo
            .ImporteCuotaAportacion = entSolicitudCredito.CuotaAportacion
            .TasaSeguroDeuda = 0.0
            .FechaPrimerPago = entSolicitudCredito.FechaPrimerPago
            .Efectivo = False

            Dim entLinea As coo_Lineas = objTablas.coo_LineasSelectByPK(entSolicitudCredito.IdLinea)
            If entLinea.CuotaSinCentavos Then
                .CuotaSinCentavos = True
            End If

            If entSolicitudCredito.IncluyeTasaSeguro = True Then
                .TasaSeguroDeuda = dtParam.Rows(0).Item("TasaSeguro")
            End If
            .CalculaPlanPagos()
        End With

        With entPrestamo
            .IdSolicitud = entSolicitudFondo.IdSolicitud
            .IdAsociado = entSolicitudFondo.IdAsociado
            .Numero = teNumeroPrestamo.EditValue
            .MontoAprobado = entResolucion.MontoAprobado
            .FechaAprobado = entResolucion.FechaAprobacion
            .FechaOtorgado = entSolicitudFondo.FechaEntrega
            .FechaPrimerPago = entSolicitudCredito.FechaPrimerPago
            .MontoDesembolsado = teMontoDesembolso.EditValue
            .MesesGracia = 0
            .DiasMoraGracia = 3
            .AplicaDescuento = entSolicitudCredito.AplicaDescuento
            .IdFormaPago = entResolucion.IdFormaPagoAprobado
            .FrecuenciaPago = entResolucion.FrecuenciaPagoAprobado
            .NumCuotas = entResolucion.NumeroCuotasAprobada
            .TasaInteres = entResolucion.TasaInteresAprobada
            .TasaMora = dtParam.Rows(0).Item("TasaMora")
            .CuotaGestion = 0.0
            .ValorCuota = pres.ValorCuota
            .CuotaAportacion = entSolicitudCredito.CuotaAportacion
            .CuotaAhorro = entSolicitudCredito.CuotaAhorro
            .CuotaManejo = entSolicitudCredito.CuotaManejo
            .CuotaOtros = entSolicitudCredito.CuotaOtros
            .TasaSeguro = pres.TasaSeguroDeuda
            .IdTipoAplicacion = entSolicitudCredito.IdTipoAplicacion
            If .IdFormaPago = 1 Then
                .FechaVencimiento = DateAdd(DateInterval.Month, (pres.FrecuenciaPago * pres.NumeroCuotas), pres.FechaOtorgamiento)
            Else
                .FechaVencimiento = DateAdd(DateInterval.Day, (pres.FrecuenciaPago * pres.NumeroCuotas), pres.FechaOtorgamiento)
            End If
            .IdDepartamento = entAso.IdDepartamento
            .IdMunicipio = entAso.IdMunicipio
            .IdCanton = entAso.IdCanton
            .IdTecnico = entSolicitudCredito.IdTecnico
            .IdLinea = entSolicitudCredito.IdLinea
            .IdFuente = entSolicitudCredito.IdFuente
            .IdTipoCartera = 1
            .IdSucursal = gIdSucursal
            .IdTipoPrestamo = entSolicitudCredito.IdTipoCredito
            .IdEstado = 1
            .TipoCuota = entSolicitudCredito.TipoCuota


            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .ModificadoPor = objMenu.User
            .FechaHoraModificacion = Now
        End With

        With entLiquidacion
            .IdSolicitudFondo = teIdSolicitudFondo.EditValue
            .IdSolicitud = entSolicitudFondo.IdSolicitud
            .IdDesembolso = seNumeroDesembolso.EditValue
            .MontoDesembolso = teMontoDesembolso.EditValue
            .LiquidoDesembolso = teMontoLiquido.EditValue
            .NumeroPrestamo = teNumeroPrestamo.EditValue
            .NumeroComprobante = "" 'se definirá en la DL
            .IdCuenta = teIdCuentaAhorro.EditValue
            .FechaMovimiento = deFechaDesembolso.EditValue
            .TipoDesembolso = CByte(leTipoDesembolso.EditValue)
        End With

        With entDesembolso
            .IdPrestamo = IdPrestamo
            .ReferenciaPago = ""
            .Numero = "" 'se definirá en la DL
            .Fecha = deFechaDesembolso.EditValue
            .TipoAplicacion = 0
            .FechaContable = blCaja.GetFechaContable(gIdSucursal)
            .ImportePagado = teMontoDesembolso.EditValue
            .CapitalPagado = 0.0
            SaldoCapital = blCaja.GetSaldoCapitalPrestamo(IdPrestamo)
            .SaldoCapital = SaldoCapital + teMontoDesembolso.EditValue
            .DiasCalcInteres = 0
            .DiasCalcMora = 0
            .InteresPagado = 0.0
            .InteresPendiente = 0.0
            .InteresMoraPagado = 0.0
            .InteresMoraPendiente = 0.0
            .ValorSeguroPagado = 0.0
            .ValorSeguroPendiente = 0.0
            .ManejoPagado = 0.0
            .ManejoPendiente = 0.0
            .OtrosPagado = 0.0
            .OtrosPendiente = 0.0
            .CuotaAhorro = 0.0
            .CuotaAportacion = 0.0
            .ComisionCobranza = 0.0
            .Gestion = 0.0
            .TasaInteres = entResolucion.TasaInteresAprobada
            .TasaInteresMora = dtParam.Rows(0).Item("TasaMora")
            .IdFormaPago = 1
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With

        For Each detalle As Cuota In pres.PlanPago
            Dim entDetalle As New coo_PrestamosPlanPagos
            entDetalle.NumCuota = detalle.NumeroCuota
            entDetalle.Fecha = detalle.FechaPago
            entDetalle.Valor = detalle.ImporteCuota
            entDetalle.TasaInteres = detalle.TasaInteres
            entDetalle.TasaMora = detalle.TasaMora
            entDetalle.Interes = detalle.ImporteInteres
            entDetalle.Capital = detalle.ImporteCapital
            entDetalle.Saldo = detalle.ImporteSaldo
            entDetalle.CuotaAportacion = detalle.ImporteCuotaAportacion
            entDetalle.CuotaAhorro = detalle.ImporteCuotaAhorro
            entDetalle.CuotaManejo = detalle.ImporteCuotaManejo
            entDetalle.CuotaOtros = detalle.ImporteCuotaOtros
            entDetalle.TasaSeguro = detalle.TasaSeguro
            entDetalle.CuotaSeguro = detalle.ImporteCuotaSeguro
            entPlanPago.Add(entDetalle)
        Next
        If leTipoDesembolso.EditValue = 2 Then
            With entDeposito
                .IdCuenta = teIdCuentaAhorro.EditValue
                .NumeroDoc = "D/" & teNumeroPrestamo.EditValue & "/" & seNumeroDesembolso.EditValue
                .Fecha = deFechaDesembolso.EditValue
                .FechaContable = deFechaDesembolso.EditValue
                .IdTipo = 1
                .Valor = teMontoLiquido.EditValue
                .IdFormaPago = 4
                .IdSucursal = gIdSucursal
                .Pignorado = False
                .Observaciones = "DEPOSITO POR DESEMBOLSO DE PRESTAMO"
                .Impreso = False
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .IdAutorizado = -1
                .DocAutorizado = "PRESTAMO"
            End With
        End If
        If entSolicitudFondo.Aportacion > 0 Then
            With entAportacion
                .IdAsociado = entSolicitudFondo.IdAsociado
                .IdTipo = 1
                .NumeroDoc = "P/" & teNumeroPrestamo.EditValue & "/" & seNumeroDesembolso.EditValue
                .Fecha = deFechaDesembolso.EditValue
                .FechaContable = blCaja.GetFechaContable(gIdSucursal)
                .IdFormaPago = 4
                .Cargo = 0
                .Abono = entSolicitudFondo.Aportacion
                .Impreso = False
                .IdSucursal = gIdSucursal
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
        End If

        If entSolicitudFondo.Capitalizacion > 0 Then
            With entCapitalizacion
                .IdAsociado = entSolicitudFondo.IdAsociado
                .IdTipo = 2
                .NumeroDoc = "C/" & teNumeroPrestamo.EditValue & "/" & seNumeroDesembolso.EditValue
                .Fecha = deFechaDesembolso.EditValue
                .FechaContable = blCaja.GetFechaContable(gIdSucursal)
                .IdFormaPago = 4
                .Cargo = 0
                .Abono = entSolicitudFondo.Capitalizacion
                .Impreso = False
                .IdSucursal = gIdSucursal
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
        End If
        If entSolicitudFondo.IdCuenta > 0 And entSolicitudFondo.Ahorro > 0 Then
            With entSimultaneo
                .IdCuenta = entSolicitudFondo.IdCuenta
                .NumeroDoc = "D/" & teNumeroPrestamo.EditValue & "/" & seNumeroDesembolso.EditValue
                .Fecha = deFechaDesembolso.EditValue
                .FechaContable = deFechaDesembolso.EditValue
                .IdTipo = 1
                .Valor = entSolicitudFondo.Ahorro
                .IdFormaPago = 4
                .IdSucursal = gIdSucursal
                .Pignorado = False
                .Observaciones = "DEPOSITO DE AHORRO SIMULTANEO POR DESEMBOLSO DE PRESTAMO"
                .Impreso = False
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .IdAutorizado = -1
                .DocAutorizado = "PRESTAMO"
            End With
        End If

        entCancelacion = New List(Of coo_PrestamosDetalle)
        For Each MiDataRow As DataRow In entRefinancia.Rows
            Dim entDetalle As New coo_PrestamosDetalle
            With entDetalle
                .IdPrestamo = MiDataRow("IdPrestamo")
                .IdMov = blCaja.GetUltMovPrestamo(.IdPrestamo) + 1
                .TipoAplicacion = 1
                .ReferenciaPago = ""
                .Numero = "R/" & teNumeroPrestamo.EditValue & "/" & seNumeroDesembolso.EditValue 'La R es por Refinanciamiento
                .Fecha = deFechaDesembolso.EditValue
                .FechaContable = deFechaDesembolso.EditValue
                .ImportePagado = MiDataRow("SaldoCapital") + MiDataRow("SaldoInteres") + MiDataRow("SaldoInteresMoratorio") + MiDataRow("SaldoSeguro") + MiDataRow("SaldoOtros")
                .CapitalPagado = MiDataRow("SaldoCapital")
                .SaldoCapital = 0.0
                .DiasCalcInteres = 0
                .DiasCalcMora = 0
                .InteresPagado = MiDataRow("SaldoInteres")
                .InteresPendiente = 0.0
                .InteresMoraPagado = MiDataRow("SaldoInteresMoratorio")
                .InteresMoraPendiente = 0.0
                .ValorSeguroPagado = MiDataRow("SaldoSeguro")
                .ValorSeguroPendiente = 0.0
                .ManejoPagado = 0.0
                .ManejoPendiente = 0.0
                .OtrosPagado = 0.0
                .OtrosPendiente = 0.0
                .CuotaAhorro = 0.0
                .CuotaAportacion = 0.0
                .TasaInteres = 0.0
                .TasaInteresMora = 0.0
                .IdFormaPago = 4
                .IdSucursal = gIdSucursal
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
            End With
            entCancelacion.Add(entDetalle)
        Next

        entPignoracion = blCaja.coo_GarantiasCuentaPignoradasSelectBySolicitud(entSolicitudCredito.IdSolicitud)

        For Each MiDataRow As DataRow In entPignoracion.Rows
            Dim entP As New coo_Pignoraciones
            entP.IdPignoracion = 0
            entP.IdSolicitud = MiDataRow("IdSolicitud")
            entP.IdCuenta = MiDataRow("IdCuenta")
            entP.IdPrestamo = IdPrestamo
            entP.IdAsociado = MiDataRow("IdASociado")
            entP.FechaPignoracion = deFechaDesembolso.EditValue
            entP.Valor = MiDataRow("Valor")
            entP.Activa = True
            entP.Manual = False
            entP.FechaReversion = Nothing
            entP.RevertidoPor = ""
            entP.CreadoPor = objMenu.User
            entP.FechaHoraCreacion = Now
            entPignora.Add(entP)
        Next

        ''
    End Sub

    Private Sub sbCalculadora_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalculadora.Click
        Dim Proceso As New Process()
        Proceso.StartInfo.FileName = "calc.exe"
        Proceso.StartInfo.Arguments = ""
        Proceso.Start()
    End Sub

End Class