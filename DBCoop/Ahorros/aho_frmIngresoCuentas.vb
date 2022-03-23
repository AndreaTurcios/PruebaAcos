Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraReports.UI
Public Class aho_frmIngresoCuentas
    Dim entCuentaAhorro As coo_CuentasAhorro, entTipoCuenta As coo_TiposCuentaAhorro
    Dim blAdmon As New AdmonBLL(), blAhorro As New AhorrosBLL(), blAsoc As New AsociadosBLL()
    Dim entBeneficiario As List(Of coo_CuentasAhorroBeneficiarios)
    Dim entAutorizado As List(Of coo_CuentasAhorroAutorizado)
    Dim entDocumentos As coo_Documentos, entSucursal As adm_Sucursales = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
    Dim dtParam As DataTable = blAdmon.ObtieneParametros()

    Private Sub aho_frmIngresoCuentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaCombos()
        teIdCuenta.EditValue = objFunciones.ObtenerUltimoId("COO_CuentasAhorro", "IdCuenta")
        CargaControles(0)
        gcBeneficiarios.DataSource = blAhorro.GetBeneficiariosCuenta(teIdCuenta.EditValue)
        gcAutorizados.DataSource = blAhorro.GetAutorizadosCuenta(teIdCuenta.EditValue)
        ActivarControles(False)
    End Sub
    Private Sub aho_frmIngresoCuentas_Nuevo() Handles Me.Nuevo
        gvBeneficiarios.CancelUpdateCurrentRow()
        gvBeneficiarios.AddNewRow()
        gvAutorizados.CancelUpdateCurrentRow()
        gvAutorizados.AddNewRow()

        ActivarControles(True)
        entCuentaAhorro = New coo_CuentasAhorro
        gcBeneficiarios.DataSource = blAhorro.GetBeneficiariosCuenta(-1)
        gcAutorizados.DataSource = blAhorro.GetAutorizadosCuenta(-1)
        ' el Id se agigna en la capa de datos
        teIdCuenta.EditValue = 0 'objFunciones.ObtenerUltimoId("Coo_CuentasAhorro", "IdCuenta") + 1
        teNoCuenta.EditValue = ""
        leTipoCuenta.EditValue = 1
        leTipoCuenta_Validated(leTipoCuenta, New EventArgs)
        teNumAsociado.EditValue = ""
        teIdAsociado.EditValue = 0
        TeRazonSocial.EditValue = ""
        teNombreAsociado.EditValue = ""
        teDireccion.EditValue = ""
        teCuotaAhorro.EditValue = 0.0
        deFechaApertura.EditValue = Today
        deFechaUltima.EditValue = deFechaApertura.EditValue
        teMontoApertura.EditValue = 0.0
        teNombreCuentaCorriente.EditValue = ""
        beNumeroCuentaCorriente.EditValue = ""
        teIdCuentaCorriente.EditValue = 0
        teCertificado.EditValue = ""
        teOrigenFondos.EditValue = ""
        leFormaPago.EditValue = 1
        teIdCuentaCorriente.Properties.ReadOnly = True
        teNoCuenta.Focus()
    End Sub
    Private Sub aho_frmIngresoCuentas_Guardar() Handles Me.Guardar
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""
        If DbMode = DbModeType.insert Then

            msj = blAhorro.InsertaCuentaAhorro(entCuentaAhorro, entBeneficiario, entAutorizado)
            If msj = "" Then
                MsgBox("La Cuenta de Ahorro ha sido guardado con éxito", MsgBoxStyle.Information)
                teIdCuenta.EditValue = entCuentaAhorro.IdCuenta
            Else
                MsgBox(String.Format("No fue posible actualizar la Cuenta de Ahorro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = blAhorro.UpdateCuentaAhorro(entCuentaAhorro, entBeneficiario, entAutorizado)
            If msj = "" Then
                MsgBox("La Cuenta de Ahorro ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la Cuenta de Ahorro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        End If
        teIdCuenta.EditValue = entCuentaAhorro.IdCuenta
        MostrarModoInicial()
        ActivarControles(False)
    End Sub
    Private Sub aho_frmIngresoCuentas_Editar() Handles Me.Editar
        If entCuentaAhorro.IdSucursal <> gIdSucursal Then
            MsgBox("No es permitido editar cuentas de otras sucursales", MsgBoxStyle.Critical)
            Close()
        End If
        ActivarControles(True)
        Dim entTipoCuenta As coo_TiposCuentaAhorro
        Dim entUltMov As New coo_UltMovAhorro

        entUltMov = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        If entUltMov.IdMov > 1 Then
            ''gvBeneficiarios.OptionsBehavior.Editable = False
            For Each ctrl In XtraTabPage1.Controls
                If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                    CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = True
                End If
                If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                    CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = True
                End If
            Next
            For Each ctrl In XtraTabPage4.Controls
                If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                    CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = True
                End If
                If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                    CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = True
                End If
            Next
            teNoCuenta.Properties.ReadOnly = True
        End If
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)
        If entTipoCuenta.IdTipo = 1 Then
            sePlazoDias.Properties.ReadOnly = True
            beNumeroCuentaCorriente.Properties.ReadOnly = True
            teCertificado.Properties.ReadOnly = True
            teOrigenFondos.Properties.ReadOnly = True
            beNumeroCuentaCorriente.Enabled = False
        Else
            sePlazoDias.Properties.ReadOnly = False
            beNumeroCuentaCorriente.Properties.ReadOnly = False
            teCertificado.Properties.ReadOnly = False
            teOrigenFondos.Properties.ReadOnly = False
            beNumeroCuentaCorriente.Enabled = True
        End If
        teCuotaAhorro.Properties.ReadOnly = False
        gvBeneficiarios.OptionsBehavior.Editable = True
        gvAutorizados.OptionsBehavior.Editable = True
        teIdCuentaCorriente.Properties.ReadOnly = True
        teNoCuenta.Focus()
    End Sub
    Private Sub aho_frmIngresoCuentas_Revertir() Handles Me.Revertir
        ActivarControles(False)
        CargaControles(0)
    End Sub
    Private Sub aho_frmIngresoCuentas_Consulta() Handles Me.Consulta

        frmConsultaCuentasAhorro.ShowDialog()
        teNoCuenta.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        'teNoCuenta_Validated(New EventArgs)
        CargaControles(0)
    End Sub
    Private Sub aho_frmIngresoCuentas_Reporte() Handles Me.Reporte
        Dim entTipoCuenta As coo_TiposCuentaAhorro = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)

        If teMontoApertura.EditValue >= 57142.85 Then
            If MsgBox("Desea Generar el Documento UIF1?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim sFileName As String = System.Environment.CurrentDirectory & "\Plantillas\Form_UIF1.xls"
                Dim oExcel = CreateObject("Excel.Application")
                oExcel.Visible = True
                oExcel.workbooks.Open(sFileName)
            End If
        Else
            seTasa.EditValue = entTipoCuenta.TasaInteres
        End If
        If MsgBox("Desea Generar el Registro de Firmas de la Cuenta de Ahorro?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New aho_rptRegistroFirmas
            Dim entSucursal As adm_Sucursales
            entSucursal = objTablas.adm_SucursalesSelectByPK(entCuentaAhorro.IdSucursal)
            rpt.DataSource = blAhorro.rptRegistroFirmas(teIdCuenta.EditValue)
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
            rpt.xrlCiudad.Text = entSucursal.Ciudad + ", " + FechaToString(Today, Today)
            rpt.XrSubreport1.ReportSource.DataSource = blAhorro.GetAutorizadosCuenta(teIdCuenta.EditValue)
            rpt.XrSubreport1.ReportSource.DataMember = ""
            rpt.XrSubreport2.ReportSource.DataSource = blAhorro.GetBeneficiariosCuenta(teIdCuenta.EditValue)
            rpt.XrSubreport2.ReportSource.DataMember = ""
            rpt.ShowPreviewDialog()
        End If

        If entTipoCuenta.TipoAhorro = 1 AndAlso MsgBox("Desea Generar el Contrato de Ahorro en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then


            'Dim entidad As coo_ContratoAhorro = blAhorro.rptContratoAhorro(teIdCuenta.EditValue)

            'entDocumentos = objTablas.coo_DocumentosSelectByPK("ContratoAhorro")
            'Dim texto As String = entDocumentos.Contenido
            'With entidad
            '    texto = texto.Replace("[num_cuenta]", Trim(.NumeroCuenta))
            '    texto = texto.Replace("[Num_Asociado]", .NumeroAsociado)
            '    texto = texto.Replace("[Nom_Asociado]", .NombreAsociado)
            '    texto = texto.Replace("[Profesion]", .Profesion)
            '    texto = texto.Replace("[Edad]", DateDiff(DateInterval.Year, CType(.FechaNacimiento, Date), Today))
            '    texto = texto.Replace("[Num_Doc]", .NumeroDocumento)
            '    texto = texto.Replace("[Domicilio]", .Municipio)
            '    texto = texto.Replace("[Tasa_Interes]", .TasaApertura)
            '    texto = texto.Replace("[Creado_Por]", .CreadoPor)
            '    texto = texto.Replace("[Lugar_Fecha]", dtParam.Rows(0).Item("Municipio") + ", " + FechaToString(Today, Today))
            '    texto = texto.Replace("[FechaActual]", "")
            '    texto = texto.Replace("[Ciudad]", entSucursal.Ciudad)
            '    texto = texto.Replace("[NombreLargo]", dtParam.Rows(0).Item("NombreLargo"))
            '    texto = texto.Replace("[Empresa]", gsNombre_Empresa)
            '    texto = texto.Replace("[MunicipioEmp]", dtParam.Rows(0).Item("Municipio"))
            '    texto = texto.Replace("[DeptoEmp]", dtParam.Rows(0).Item("Departamento"))
            'End With

            'Dim rpt As New pre_rptRichTextLogo
            'rpt.XrEscrito.Rtf = texto
            'rpt.XrLogoSuc.ImageUrl = entSucursal.LogoImageUrl
            'rpt.ShowPreviewDialog()

            Dim rpt As New aho_rptContratoAhorro
            rpt.DataSource = blAhorro.rptContratoAhorro2(teIdAsociado.EditValue)
            rpt.DataMember = ""

            rpt.xrlDia.Text = CDate(Today).Day.ToString()
            rpt.xrlMes.Text = ObtieneMesString(CDate(Today).Month)
            rpt.xrlAnio.Text = CDate(Today).Year.ToString

            rpt.ShowPreviewDialog()

        End If
        If entTipoCuenta.TipoAhorro > 1 Then  'se imprime solo para los certificados a plazo
            If MsgBox("Desea Generar el Certificado de Cuenta a Plazo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim FileName As String = Environment.CurrentDirectory & "\Plantillas\CertificadoDepositoPlazo.repx"
                If Not IO.File.Exists(FileName) Then
                    MsgBox("No existe la plantilla para generar la impresión del certificado", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                Dim Autorizado1 As String = "", Autorizado2 As String = "", Autorizado3 As String = "", Autorizado4 As String = ""
                Dim dtAutorizados As DataTable = blAhorro.GetAutorizadosCuenta(teIdCuenta.EditValue)
                
                For i As Integer = 0 To dtAutorizados.Rows.Count - 1
                    If i = 0 Then
                        Autorizado1 = SiEsNulo(dtAutorizados.Rows(0).Item("Nombre"), "")
                    End If
                    If i = 1 Then
                        Autorizado2 = SiEsNulo(dtAutorizados.Rows(1).Item("Nombre"), "")
                    End If
                    If i = 2 Then
                        Autorizado3 = SiEsNulo(dtAutorizados.Rows(2).Item("Nombre"), "")
                    End If
                    If i = 3 Then
                        Autorizado4 = SiEsNulo(dtAutorizados.Rows(3).Item("Nombre"), "")
                    End If
                Next
                'cambiar a plantilla
                Dim sDecimal = String.Format("{0:c}", Format(CDec(teMontoApertura.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                Dim rpt As New aho_rptCertificadoAhorro
                rpt.LoadLayout(FileName)

                rpt.xrlNumero.Text = teNoCuenta.EditValue
                rpt.xrlNombreAsociado.Text = teNombreAsociado.EditValue
                rpt.xrlNumeroAsociado.Text = teNumAsociado.EditValue
                rpt.xrlValor.Text = Format(teMontoApertura.EditValue, "###,##0.00")
                rpt.xrlCantidadLetras.Text = Num2Text(Int(teMontoApertura.EditValue)) & " " & sDecimal & " DÓLARES"
                rpt.xrlTasa.Text = Format(seTasa.EditValue, "##,##0.00") & "%"
                rpt.xrlPlazo.Text = sePlazoDias.EditValue
                rpt.xrlFechaVence.Text = DateAdd(DateInterval.Day, sePlazoDias.EditValue, deFechaApertura.EditValue)
                rpt.xrlNumCuentaCorriente.Text = beNumeroCuentaCorriente.EditValue
                If leFormaPago.EditValue = 1 Then
                    rpt.xrlForma1.Visible = True
                Else
                    rpt.xrlForma2.Visible = True
                End If
                rpt.xrlCiudad.Text = entSucursal.Ciudad + ", " + FechaToString(deFechaApertura.EditValue, deFechaApertura.EditValue)

                rpt.xrlAutorizado1.Text = teNombreAsociado.EditValue
                rpt.xrlAutorizado2.Text = Autorizado1
                'rpt.XrSubreport2.ReportSource.Report(New aho_rptBeneficiariosPlazo)
                rpt.XrSubreport2.ReportSource.DataSource = blAhorro.GetBeneficiariosCuenta(teIdCuenta.EditValue)
                rpt.XrSubreport2.ReportSource.DataMember = ""
                rpt.ShowPreview()
            End If
        End If

    End Sub
    Private Sub aho_frmIngresoCuentas_Eliminar() Handles Me.Eliminar
        Dim entUltMov As New coo_UltMovAhorro
        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        entUltMov = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)

        If entUltMov.IdMov > 1 Then
            MsgBox("No es posible eliminar la Cuenta de Ahorro, Ya posee Movimientos", MsgBoxStyle.Critical, "Error al elminar el registro")
            Exit Sub
        End If

        'SE COMENTARIO, PORQUE AVECES CREAN CUENTAS A CERO Y LAS TIENEN BORRAR, SIEMPRE Y CUANDO NO TENGAN
        'MOVIMIENTO LAS CUENTA

        'If deFechaApertura.EditValue < dFechaContable Then
        '    MsgBox("No es posible eliminar la Cuenta de Ahorro. El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error de usuario")
        '    Exit Sub
        'End If

        If MsgBox("¿Está seguro(a) de eliminar la Cuenta de Ahorro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_CuentasAhorroDeleteByPK(teIdCuenta.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La cuenta ha sido elminada con éxito", MsgBoxStyle.Information)
                CargaControles(-1)
            Else
                MsgBox(String.Format("No fue posible eliminar la Cuenta de Ahorro{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Public Sub CargaControles(ByVal TipoAvance As Integer)
        Dim IdCuentaStart As Integer = 0
        Dim IdCuentaEnd As Integer = 0
        If TipoAvance = -1 Then
            IdCuentaStart = objFunciones.ObtenerPrimerId("Coo_CuentasAhorro", "IdCuenta")
            If teIdCuenta.EditValue = IdCuentaStart Then
                teIdCuenta.EditValue = teIdCuenta.EditValue + 1
            End If
        End If
        If TipoAvance = 1 Then
            IdCuentaEnd = objFunciones.ObtenerUltimoId("Coo_CuentasAhorro", "IdCuenta")
            If teIdCuenta.EditValue = IdCuentaEnd Then
                teIdCuenta.EditValue = teIdCuenta.EditValue - 1
            End If
        End If
        If teIdCuenta.EditValue = 0 Then
            Exit Sub
        End If
        teIdCuenta.EditValue = blAhorro.ObtenerIdCuenta(teIdCuenta.EditValue, TipoAvance)
        If teIdCuenta.EditValue = 0 Then
            Exit Sub
        End If
        entCuentaAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        With entCuentaAhorro
            teIdCuenta.EditValue = .IdCuenta
            leTipoCuenta.EditValue = .IdTipoCuenta
            teNoCuenta.EditValue = .Numero
            teIdAsociado.EditValue = .IdAsociado
            teNumAsociado_Validated(teNumAsociado, New EventArgs)
            gcBeneficiarios.DataSource = blAhorro.GetBeneficiariosCuenta(.IdCuenta)
            gcAutorizados.DataSource = blAhorro.GetAutorizadosCuenta(.IdCuenta)

            teCuotaAhorro.EditValue = .CuotaAhorro
            TeRazonSocial.EditValue = .RazonSocial
            deFechaApertura.EditValue = .FechaApertura
            deFechaUltima.EditValue = .FechaUltCap
            seTasa.EditValue = .TasaApertura
            teMontoApertura.EditValue = .MontoApertura
            sePlazoDias.EditValue = .PlazoDias
            leFormaPago.EditValue = .IdFormaPago
            teIdCuentaCorriente.EditValue = .IdCuentaCte
            'se invoca el Id de la cuenta corriente
            beNumeroCuentaCorriente.EditValue = blAhorro.ObtenerNumeroCuentaByIdCuenta(.IdCuentaCte)
            beNumeroCuentaCorriente_Validated(beNumeroCuentaCorriente, New EventArgs)
            teCertificado.EditValue = .NumeroCertificado
            teOrigenFondos.EditValue = .OrigenFondos
        End With
    End Sub
    Private Sub ActivarControles(ByVal Tipo As Boolean)

        gvBeneficiarios.OptionsBehavior.Editable = Tipo
        gvAutorizados.OptionsBehavior.Editable = Tipo
        For Each ctrl In XtraTabPage1.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.RadioGroup Then
                CType(ctrl, DevExpress.XtraEditors.RadioGroup).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.PictureEdit Then
                CType(ctrl, DevExpress.XtraEditors.PictureEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        For Each ctrl In XtraTabPage4.Controls
            If TypeOf ctrl Is DevExpress.XtraEditors.TextEdit Then
                CType(ctrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.CheckEdit Then
                CType(ctrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = Not Tipo
            End If
            If TypeOf ctrl Is DevExpress.XtraEditors.ButtonEdit Then
                CType(ctrl, DevExpress.XtraEditors.ButtonEdit).Properties.ReadOnly = Not Tipo
            End If
        Next
        teIdCuenta.Properties.ReadOnly = True
        leTipoCuenta.Properties.ReadOnly = Not Tipo
        teNoCuenta.Properties.ReadOnly = Not Tipo

        seTasa.Properties.ReadOnly = True
        sePlazoDias.Properties.ReadOnly = True
        teNombreAsociado.Properties.ReadOnly = True
        teIdAsociado.Properties.ReadOnly = True
        teDireccion.Properties.ReadOnly = True
        teNombreCuentaCorriente.Properties.ReadOnly = True

    End Sub

    Private Sub CargaCombos()
        objCombos.coo_TiposCuenta(leTipoCuenta, "")
        objCombos.coo_TipoCuentaAhorro(leFormaPago, "")
    End Sub

    Function DatosValidos() As Boolean

        If teIdAsociado.EditValue = 0 Then
            MsgBox("Debe especificar el Número de Asociado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNumAsociado.Focus()
            Return False
        End If
        'If teNoCuenta.EditValue = "" Then
        '    MsgBox("Debe especificar el Número de Cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    teNoCuenta.Focus()
        '    Return False
        'End If
        If SiEsNulo(deFechaApertura.EditValue, Nothing) = Nothing Then
            MsgBox("Debe especificar la Fecha de Apertura de la cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFechaApertura.Focus()
            Return False
        End If

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        
        'If deFechaApertura.EditValue < dFechaContable Then
        '    MsgBox("No es posible crear la cuenta. Verifique la fecha", MsgBoxStyle.Critical, "Error de usuario")
        '    Return False
        'End If

        Dim entUltMov As coo_UltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        If entUltMov.IdMov > 1 Then
            'MsgBox("No es posible Modificar la Cuenta de Ahorro, Ya posee Movimientos", MsgBoxStyle.Critical, "Error al elminar el registro")
            'Return False
        Else
            'If entUltMov.IdMov = 1 Then
            '    If entUltMov.SaldoActual <> teMontoApertura.EditValue Then
            '        MsgBox("No es posible Modificar la Cuenta de Ahorro, el Monto de Apertura difiere del Desposito", MsgBoxStyle.Critical, "Error al elminar el registro")
            '        Return False
            '    End If
            'End If
        End If
        If seTasa.EditValue <= 0 Then
            MsgBox("La Tasa de Interes debe de ser positiva" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            seTasa.Focus()
            Return False
        End If
        'If teMontoApertura.EditValue <= 0 Then
        '    MsgBox("Debe especificar el Monto de Apertura de la cuenta" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    teMontoApertura.Focus()
        '    Return False
        'End If
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)
        If entTipoCuenta.TipoAhorro > 1 Then
            If beNumeroCuentaCorriente.EditValue = "" Or teIdCuentaCorriente.EditValue = 0 Then
                MsgBox(String.Format("Debe especificar la cuenta corriente a afectar{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                beNumeroCuentaCorriente.Focus()
                Return False
            End If

            Dim entCtaCte As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuentaCorriente.EditValue)
            If teIdAsociado.EditValue <> entCtaCte.IdAsociado Then
                MsgBox("La cuenta a depositar debe pertenecer al asociado que apertura el depósito", MsgBoxStyle.Critical, "Imposible Continuar")
                beNumeroCuentaCorriente.Focus()
                Return False
            End If
            If sePlazoDias.EditValue <= 0 Then
                MsgBox("El tipo de cuenta no tiene definido el plazo en días" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                beNumeroCuentaCorriente.Focus()
                Return False
            End If
            If teCertificado.EditValue = "" Then
                MsgBox("Es necesario especificar el número de certificado" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                beNumeroCuentaCorriente.Focus()
                Return False
            End If
            If teOrigenFondos.EditValue = "" Then
                MsgBox("Falta especificar el Origen de Fondos al Depósito a Plazo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
                teOrigenFondos.Focus()
                Return False
            End If
            If leFormaPago.EditValue = 1 Then
                MsgBox(String.Format("La cuenta a Plazo no puede tener este Tipo de Capitalización{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                leFormaPago.Focus()
                Return False
            End If
        Else
            If leFormaPago.EditValue > 1 Then
                MsgBox(String.Format("La cuenta Corriente no puede tener este Plazo de ahorro{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                leFormaPago.Focus()
                Return False
            End If
            'If bl.ExisteIdCuentaCorriente(teIdCuenta.EditValue, teNumAsociado.EditValue) > 0 And DbMode = DbModeType.insert Then
            '    MsgBox("Ya existe un Id Cuenta con este número", MsgBoxStyle.Critical, "Nota")
            '    Return False
            'End If
        End If
        'If blAhorro.ExisteIdCuentaAhorro(teIdCuenta.EditValue) > 0 And DbMode = DbModeType.insert Then
        '    MsgBox("Ya existe un Id Cuenta con este número", MsgBoxStyle.Critical)
        '    Return False
        'End If
        If blAhorro.ExisteNumCuentaAhorro(teNoCuenta.EditValue) > 0 And DbMode = DbModeType.insert Then
            MsgBox("Ya existe un numero de cuenta con este número", MsgBoxStyle.Critical, gSystemName)
            Return False
        End If

        Return True
    End Function

    Private Sub leTipoCuenta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leTipoCuenta.EditValueChanged
        If DbMode = DbModeType.insert Then
            leTipoCuenta_Validated(leTipoCuenta, New System.EventArgs)
        End If
    End Sub

    Private Sub leTipoCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles leTipoCuenta.Validated
        Dim entTipoCuenta As coo_TiposCuentaAhorro = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)
        Dim entAso As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

        seTasa.EditValue = entTipoCuenta.TasaInteres

        If entTipoCuenta.TipoAhorro = 1 Then  'es ahorro a la vista, escolar, programado, navideño...
            sePlazoDias.EditValue = 0
            beNumeroCuentaCorriente.Properties.ReadOnly = True
            beNumeroCuentaCorriente.Enabled = False
            teCertificado.Properties.ReadOnly = True
            teOrigenFondos.Properties.ReadOnly = True
            teOrigenFondos.EditValue = ""
            teNoCuenta.EditValue = ""
            If teNumAsociado.EditValue <> "" And DbMode = DbModeType.insert Then
                'teNoCuenta.EditValue = entTipoCuenta.IdTipo.ToString.PadLeft(1, "0") & "-" & gIdSucursal.ToString.PadLeft(1, "0") & "-" & teNumAsociado.EditValue
                teNoCuenta.EditValue = entAso.NumeroDocumento & "-" & entTipoCuenta.IdTipo.ToString.PadLeft(1, "0") & "-" & (entTipoCuenta.Correlativo + 1).ToString.PadLeft(5, "0")
            End If

        Else
            sePlazoDias.EditValue = entTipoCuenta.PlazoDias
            'sePlazoDias.Properties.ReadOnly = False
            beNumeroCuentaCorriente.Properties.ReadOnly = False
            beNumeroCuentaCorriente.Enabled = True
            teCertificado.Properties.ReadOnly = False
            teOrigenFondos.Properties.ReadOnly = False
            teNoCuenta.EditValue = entAso.NumeroDocumento & "-" & entTipoCuenta.IdTipo.ToString.PadLeft(1, "0") & "-" & (entTipoCuenta.Correlativo + 1).ToString.PadLeft(5, "0")
            '(entTipoCuenta.Correlativo + 1).ToString.PadLeft(5, "0")
        End If
    End Sub

    Private Sub CargaEntidades()
        With entCuentaAhorro
            .IdCuenta = teIdCuenta.EditValue
            .IdTipoCuenta = leTipoCuenta.EditValue
            .Numero = teNoCuenta.EditValue
            .IdAsociado = teIdAsociado.EditValue
            .RazonSocial = TeRazonSocial.EditValue
            .FechaApertura = deFechaApertura.EditValue
            .CuotaAhorro = teCuotaAhorro.EditValue
            .TasaApertura = seTasa.EditValue
            .TasaVigente = seTasa.EditValue
            .MontoApertura = teMontoApertura.EditValue
            .PlazoDias = sePlazoDias.EditValue
            .IdCuentaCte = teIdCuentaCorriente.EditValue
            .NumeroCertificado = teCertificado.EditValue
            .OrigenFondos = teOrigenFondos.EditValue
            .IdFormaPago = leFormaPago.EditValue
            .FechaUltCap = deFechaUltima.EditValue
            .FechaVigenciaTasa = Today
            .IdEstado = 1
            .IdSucursal = gIdSucursal
            If DbMode = DbModeType.insert Then
                .CreadoPor = objMenu.User
                .FechaHoraCreacion = Now
                .ModificadoPor = ""
            Else
                .FechaHoraModificacion = Now
                .ModificadoPor = objMenu.User
            End If
        End With

        entBeneficiario = New List(Of coo_CuentasAhorroBeneficiarios)
        For i = 0 To gvBeneficiarios.DataRowCount - 1
            Dim entDetalle As New coo_CuentasAhorroBeneficiarios
            With entDetalle
                .IdCuenta = 0  ' Se asigna en la capa de datos
                .IdBeneficiario = i
                .Nombre = SiEsNulo(gvBeneficiarios.GetRowCellValue(i, "Nombre"), "")
                .Direccion = SiEsNulo(gvBeneficiarios.GetRowCellValue(i, "Direcion"), "")
                .Edad = SiEsNulo(gvBeneficiarios.GetRowCellValue(i, "Edad"), 0)
                .Porcentaje = SiEsNulo(gvBeneficiarios.GetRowCellValue(i, "Porcentaje"), "")
                .Parentesco = SiEsNulo(gvBeneficiarios.GetRowCellValue(i, "Parentesco"), "")
            End With
            entBeneficiario.Add(entDetalle)
        Next

        entAutorizado = New List(Of coo_CuentasAhorroAutorizado)
        For i = 0 To gvAutorizados.DataRowCount - 1
            Dim entDetalleA As New coo_CuentasAhorroAutorizado
            With entDetalleA
                .IdCuenta = 0  ' Se asigna en la capa de datos
                .IdAutorizado = i
                .Nombre = SiEsNulo(gvAutorizados.GetRowCellValue(i, "Nombre"), "")
                .NroDocumento = SiEsNulo(gvAutorizados.GetRowCellValue(i, "NroDocumento"), "")
                .ArchivoFirma = ""
            End With
            entAutorizado.Add(entDetalleA)
        Next
    End Sub

    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        If teNoCuenta.Properties.ReadOnly = False Then
            frmConsultaAsociados.ShowDialog()
            teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
            teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
            teNombreAsociado.EditValue = frmConsultaAsociados.Nombre
            teNumAsociado_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated, teIdAsociado.Validated
        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            'Exit Sub
        Else
            If teIdAsociado.EditValue = 0 Then
                Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
                If dt.Rows.Count = 0 Then
                    MsgBox("No existe el número de asociado ingresado", MsgBoxStyle.Critical, "Nota")
                    Exit Sub
                End If
                teIdAsociado.EditValue = dt.Rows(0).Item("IdAsociado")
            End If
        End If
        Dim Asoc As coo_Asociados = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)
        Dim entTipoCuenta As coo_TiposCuentaAhorro
        entTipoCuenta = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)
        teNumAsociado.EditValue = Asoc.Numero
        teNombreAsociado.EditValue = Asoc.Nombres + " " + Asoc.Apellidos
        TeRazonSocial.EditValue = Asoc.Nombres + " " + Asoc.Apellidos
        teDireccion.EditValue = Asoc.Direccion

        If teNumAsociado.EditValue <> "" And DbMode = DbModeType.insert Then
            'teNoCuenta.EditValue = entTipoCuenta.IdTipo.ToString.PadLeft(1, "0") & "-" & gIdSucursal.ToString.PadLeft(1, "0") & "-" & teNumAsociado.EditValue
            teNoCuenta.EditValue = Asoc.NumeroDocumento & "-" & entTipoCuenta.IdTipo.ToString.PadLeft(1, "0") & "-" & (entTipoCuenta.Correlativo + 1).ToString.PadLeft(5, "0")
        End If
    End Sub

    Private Sub btCuentaCorriente_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuentaCorriente.EditValueChanged
        'nothing to do
    End Sub
    Private Sub btNumeroCuentaCorriente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beNumeroCuentaCorriente.ButtonClick
        Dim entTipoCuenta As coo_TiposCuentaAhorro = objTablas.coo_TiposCuentaAhorroSelectByPK(leTipoCuenta.EditValue)
        If entTipoCuenta.TipoAhorro = 2 Then
            beNumeroCuentaCorriente.EditValue = objConsultas.ConsultaCuentaCorriente(frmConsultas, teIdAsociado.EditValue)
            beNumeroCuentaCorriente_Validated(e, New EventArgs)
        End If
    End Sub
    Private Sub beNumeroCuentaCorriente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuentaCorriente.Validated
        If beNumeroCuentaCorriente.EditValue = "" Then
            Exit Sub
        End If
        teIdCuentaCorriente.EditValue = blAhorro.ObtenerIdCuentaByNumero(beNumeroCuentaCorriente.EditValue)

        Dim entCuentaCorriente As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuentaCorriente.EditValue)
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entCuentaCorriente.IdAsociado)
        teNombreCuentaCorriente.EditValue = entAsociados.Numero & ", " & entAsociados.Nombres & " " & entAsociados.Apellidos
    End Sub

    Private Sub deFechaApertura_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles deFechaApertura.EditValueChanged
        deFechaUltima.EditValue = deFechaApertura.EditValue
    End Sub
End Class
