Imports DevExpress.Skins
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class adm_frmSetup
    Dim entCuentas As con_Cuentas
    Dim myBL As New AdmonBLL()
    Dim BL As New TableBusiness()

    Private Sub frmSetup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        
        Dim dt As DataTable = myBL.ObtieneParametros
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.conTiposPartida(leTipoPartida, "")
        objCombos.conTiposPartida(leTipoPartidaAhorro, "")

        'objCombos.fac_PuntosVenta(lePuntoVenta, leSucursal.EditValue)
        'objCombos.invBodegas(leBodega)
        GetSkins()
        With dt.Rows(0)
            teEmpresa.EditValue = .Item("NombreEmpresa")
            teEmpresaLargo.EditValue = .Item("NombreLargo")
            teNRC.EditValue = .Item("NrcEmpresa")
            teNIT.EditValue = .Item("NitEmpresa")
            rgTipoContrib.SelectedIndex = .Item("TipoContribuyente") - 1

            ceAgente.EditValue = .Item("EsRetenedor")
            teDireccion.EditValue = .Item("Direccion")
            teDomicilio.EditValue = .Item("Domicilio")
            teDepartamento.EditValue = .Item("Departamento")
            teMunicipio.EditValue = .Item("Municipio")
            teNumeroPatronal.EditValue = .Item("NumeroPatronal")
            teActividad.EditValue = .Item("ActividadEconomica")
            teNombre1.EditValue = .Item("NombreFirmante1")
            teNombre2.EditValue = .Item("NombreFirmante2")
            teNombre3.EditValue = .Item("NombreFirmante3")
            teNombre4.EditValue = .Item("NombreFirmante4")
            teNombre5.EditValue = .Item("NombreFirmante5")
            teNombre6.EditValue = .Item("NombreFirmante6")
            teCargo1.EditValue = .Item("CargoFirmante1")
            teCargo2.EditValue = .Item("CargoFirmante2")
            teCargo3.EditValue = .Item("CargoFirmante3")
            teCargo4.EditValue = .Item("CargoFirmante4")
            teCargo5.EditValue = .Item("CargoFirmante5")
            teCargo6.EditValue = .Item("CargoFirmante6")
            teMoneda.EditValue = .Item("DescMoneda")
            teMensaje.EditValue = .Item("MensajeCooperativo")
            meNotaInformativa.EditValue = .Item("NotaInformativa")

            spAnio.EditValue = .Item("Ejercicio")
            deFechaMinima.EditValue = .Item("FechaCierre")
            deFechaMaxima.EditValue = .Item("FechaLimite")
            sePorcIVA.EditValue = .Item("PorcIVA")
            sePorcReten.EditValue = .Item("PorcRetencion")
            sePorcPercep.EditValue = .Item("PorcPercepcion")
            leSucursal.EditValue = .Item("IdSucursal")
            cboTipoPartida.SelectedIndex = .Item("TipoNumeracionPartidas") - 1
            ceGuardarDescuadre.EditValue = .Item("GuardarDesbalance")

            beCta01.EditValue = .Item("IdCuentaCaja")
            beCta02.EditValue = .Item("IdCuentaDebito1")
            beCta03.EditValue = .Item("IdCuentaDebito2")
            beCta04.EditValue = .Item("IdCuentaCredito1")
            beCta05.EditValue = .Item("IdCuentaCredito2")

            beCta06.EditValue = .Item("IdCuentaRetencion1")
            beCta07.EditValue = .Item("IdCuentaRetencion2")
            beCta08.EditValue = .Item("IdCuentaPercepcion")
            beCta09.EditValue = .Item("IdCuentaProvisionAhorro")
            beCta10.EditValue = .Item("IdCuentaAfiliacion")
            beCta11.EditValue = .Item("IdCuentaNumerario")
            beCta12.EditValue = .Item("IdCuentaAportacion")
            beCta13.EditValue = .Item("IdCuentaSeguro")
            beCta14.EditValue = .Item("IdCuentaDividendos")
            beCta15.EditValue = .Item("IdCuentaRetencionDividendos")
            beCta16.EditValue = .Item("IdCuentaAhorroFunerario")
            teAportacion.EditValue = .Item("CuotaAportacion")

            seDiasAhorro.EditValue = .Item("DiasAhorro")
            seDiasPrestamo.EditValue = .Item("DiasPrestamo")
            teMaximoAhorroISR.EditValue = .Item("AhorroMaxIsr")

            teSeguroDeuda.EditValue = .Item("TasaSeguro")
            btImagenLogo.EditValue = .Item("RutaLogo")

            teMaximoAsegurable.EditValue = .Item("MaximoAsegurablePrestamo")
            teMaximoAportaciones.EditValue = .Item("MaximoAsegurableAportacion")
            teMaximoAhorro.EditValue = .Item("MaximoAsegurableAhorro")

            teCuotaAfiliacion.EditValue = .Item("CuotaAfiliacion")

            teConceptoCaja.EditValue = .Item("ConceptoPartidaCaja")
            leTipoPartida.EditValue = .Item("IdTipoPartidaCaja")
            leTipoPartidaAhorro.EditValue = .Item("IdTipoPartidaAhorros")
            teTasaMora.EditValue = .Item("TasaMora")
            beRutaImagenes.EditValue = .Item("RutaImagenes")
            teAntiguedad.EditValue = .Item("Antiguedad")
            teCodigoAportacion.EditValue = .Item("CodigoAportacion")
            meNotaDevolucion.EditValue = .Item("NotaDevolucionAhorro")

            teCorreo.EditValue = .Item("Email")
            tePassword.EditValue = .Item("EmailPassword")
            teServidorCorreo.EditValue = .Item("ServerEmail")
            tePuerto.EditValue = .Item("PortEmail")
            chkSsl.EditValue = .Item("Ssl")
            TeAplicaTelefonia.EditValue = .Item("ValorAplicaTelefonia")
            TeNoAplicaTelefonia.EditValue = .Item("ValorNoAplicaTelefonia")
        End With
    End Sub
    Private Sub Button1_Click() Handles Me.Guardar
        Dim adm_Para As New adm_Parametros
        adm_Para.NombreEmpresa = teEmpresa.EditValue
        adm_Para.NombreLargo = teEmpresaLargo.EditValue
        adm_Para.NrcEmpresa = teNRC.EditValue
        adm_Para.NitEmpresa = teNIT.EditValue
        adm_Para.Direccion = teDireccion.EditValue
        adm_Para.Domicilio = teDomicilio.EditValue
        adm_Para.Departamento = teDepartamento.EditValue
        adm_Para.Municipio = teMunicipio.EditValue
        adm_Para.NumeroPatronal = teNumeroPatronal.EditValue
        adm_Para.ActividadEconomica = teActividad.EditValue
        adm_Para.TipoContribuyente = rgTipoContrib.EditValue
        adm_Para.EsRetenedor = ceAgente.EditValue
        adm_Para.NombreFirmante1 = teNombre1.EditValue
        adm_Para.NombreFirmante2 = teNombre2.EditValue
        adm_Para.NombreFirmante3 = teNombre3.EditValue
        adm_Para.NombreFirmante4 = teNombre4.EditValue
        adm_Para.NombreFirmante5 = teNombre5.EditValue
        adm_Para.NombreFirmante6 = teNombre6.EditValue
        adm_Para.CargoFirmante1 = teCargo1.EditValue
        adm_Para.CargoFirmante2 = teCargo2.EditValue
        adm_Para.CargoFirmante3 = teCargo3.EditValue
        adm_Para.CargoFirmante4 = teCargo4.EditValue
        adm_Para.CargoFirmante5 = teCargo5.EditValue
        adm_Para.CargoFirmante6 = teCargo6.EditValue
        adm_Para.MensajeCooperativo = teMensaje.EditValue
        adm_Para.NotaInformativa = meNotaInformativa.EditValue

        adm_Para.DescMoneda = teMoneda.EditValue
        adm_Para.Ejercicio = spAnio.EditValue
        adm_Para.FechaCierre = deFechaMinima.EditValue
        adm_Para.FechaLimite = deFechaMaxima.EditValue
        adm_Para.PorcIva = sePorcIVA.EditValue
        adm_Para.PorcRetencion = sePorcReten.EditValue
        adm_Para.PorcPercepcion = sePorcPercep.EditValue
        adm_Para.IdSucursal = leSucursal.EditValue

        adm_Para.TipoNumeracionPartidas = cboTipoPartida.SelectedIndex + 1
        adm_Para.GuardarDesbalance = ceGuardarDescuadre.Checked

        adm_Para.IdCuentaCaja = beCta01.EditValue
        adm_Para.IdCuentaCredito1 = beCta04.EditValue
        adm_Para.IdCuentaCredito2 = beCta05.EditValue
        adm_Para.IdCuentaDebito1 = beCta02.EditValue
        adm_Para.IdCuentaDebito2 = beCta03.EditValue
        adm_Para.IdCuentaRetencion1 = beCta06.EditValue
        adm_Para.IdCuentaRetencion2 = beCta07.EditValue
        adm_Para.IdCuentaPercepcion = beCta08.EditValue
        adm_Para.CuotaAportacion = teAportacion.EditValue
        adm_Para.DiasAhorro = seDiasAhorro.EditValue
        adm_Para.DiasPrestamo = seDiasPrestamo.EditValue
        adm_Para.AhorroMaxIsr = teMaximoAhorroISR.EditValue
        adm_Para.TasaSeguro = teSeguroDeuda.EditValue
        adm_Para.RutaLogo = btImagenLogo.EditValue
        adm_Para.IdCuentaProvisionAhorro = beCta09.EditValue
        adm_Para.MaximoAsegurablePrestamo = teMaximoAsegurable.EditValue
        adm_Para.MaximoAsegurableAportacion = teMaximoAportaciones.EditValue
        adm_Para.MaximoAsegurableAhorro = teMaximoAhorro.EditValue
        adm_Para.IdCuentaAfiliacion = beCta10.EditValue
        adm_Para.CuotaAfiliacion = teCuotaAfiliacion.EditValue
        adm_Para.IdCuentaNumerario = beCta11.EditValue
        adm_Para.IdCuentaAportacion = beCta12.EditValue
        adm_Para.IdCuentaSeguro = beCta13.EditValue
        adm_Para.IdCuentaDividendos = beCta14.EditValue
        adm_Para.IdCuentaRetencionDividendos = beCta15.EditValue
        adm_Para.IdCuentaahorroFunerario = beCta16.EditValue
        adm_Para.ConceptoPartidaCaja = teConceptoCaja.EditValue
        adm_Para.IdTipoPartidaCaja = leTipoPartida.EditValue
        adm_Para.IdTipoPartidaAhorros = leTipoPartidaAhorro.EditValue
        adm_Para.TasaMora = teTasaMora.EditValue
        adm_Para.RutaImagenes = beRutaImagenes.EditValue
        adm_Para.NotaInformativa = meNotaInformativa.EditValue
        adm_Para.Antiguedad = teAntiguedad.EditValue
        adm_Para.CodigoAportacion = teCodigoAportacion.EditValue
        adm_Para.NotaDevolucionAhorro = meNotaDevolucion.EditValue
        adm_Para.Email = teCorreo.EditValue
        adm_Para.EmailPassword = tePassword.EditValue
        adm_Para.PortEmail = tePuerto.EditValue
        adm_Para.Ssl = chkSsl.EditValue
        adm_Para.ValorAplicaTelefonia = TeAplicaTelefonia.EditValue
        adm_Para.ValorNoAplicaTelefonia = TeNoAplicaTelefonia.EditValue
        adm_Para.ServerEmail = teServidorCorreo.EditValue
        pnIVA = sePorcIVA.EditValue / 100
        gsDesc_Moneda = teMoneda.EditValue


        BL.adm_ParametrosUpdate(adm_Para)


        My.Settings.SkinName = cbeSkins.Text
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(cbeSkins.Text)
        My.Settings.Save()
        MsgBox("La configuración ha sido guardada con éxito", MsgBoxStyle.Information, "Nota")

    End Sub

    Private Sub GetSkins()
        cbeSkins.Text = My.Settings.SkinName
        For Each cnt As SkinContainer In SkinManager.Default.Skins
            cbeSkins.Properties.Items.Add(cnt.SkinName)
        Next cnt
    End Sub

    Private Sub btImagenLogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btImagenLogo.Click
        If btImagenLogo.Properties.ReadOnly = True Then
            Exit Sub
        End If
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "OpenFileDialog1" Then
            btImagenLogo.Text = OpenFile.FileName
        End If
    End Sub

    Private Sub beRutaImagenes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles beRutaImagenes.Click
        If beRutaImagenes.Properties.ReadOnly = True Then
            Exit Sub
        End If
        OpenFile.ShowDialog()
        If OpenFile.FileName <> "OpenFileDialog1" Then
            beRutaImagenes.Text = OpenFile.FileName
        End If
    End Sub


    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        beCta01.EditValue = ""
        beCta01_Validated(beCta01, New System.EventArgs)
    End Sub
    Private Sub beCta02_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta02.ButtonClick
        beCta02.EditValue = ""
        beCta02_Validated(beCta01, New System.EventArgs)
    End Sub
    Private Sub beCta03_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta03.ButtonClick
        beCta03.EditValue = ""
        beCta03_Validated(beCta03, New System.EventArgs)
    End Sub
    Private Sub beCta04_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta04.ButtonClick
        beCta04.EditValue = ""
        beCta04_Validated(beCta04, New System.EventArgs)
    End Sub
    Private Sub beCta05_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta05.ButtonClick
        beCta05.EditValue = ""
        beCta05_Validated(beCta05, New System.EventArgs)
    End Sub
    Private Sub beCta06_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta06.ButtonClick
        beCta06.EditValue = ""
        beCta06_Validated(beCta06, New System.EventArgs)
    End Sub
    Private Sub beCta07_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta07.ButtonClick
        beCta07.EditValue = ""
        beCta07_Validated(beCta07, New System.EventArgs)
    End Sub
    Private Sub beCta08_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta08.ButtonClick
        beCta08.EditValue = ""
        beCta08_Validated(beCta08, New System.EventArgs)
    End Sub
    Private Sub beCta09_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta09.ButtonClick
        beCta09.EditValue = ""
        beCta09_Validated(beCta09, New System.EventArgs)
    End Sub
    Private Sub beCta10_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta10.ButtonClick
        beCta10.EditValue = ""
        beCta10_Validated(beCta10, New System.EventArgs)
    End Sub
    Private Sub beCta11_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta11.ButtonClick
        beCta11.EditValue = ""
        beCta11_Validated(beCta11, New System.EventArgs)
    End Sub
    Private Sub beCta12_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta12.ButtonClick
        beCta12.EditValue = ""
        beCta12_Validated(beCta12, New System.EventArgs)
    End Sub
    Private Sub beCta13_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta13.ButtonClick
        beCta13.EditValue = ""
        beCta13_Validated(beCta13, New System.EventArgs)
    End Sub
    Private Sub beCta14_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta14.ButtonClick
        beCta14.EditValue = ""
        beCta14_Validated(beCta14, New System.EventArgs)
    End Sub
    Private Sub beCta15_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta15.ButtonClick
        beCta15.EditValue = ""
        beCta15_Validated(beCta15, New System.EventArgs)
    End Sub
    Private Sub beCta16_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta16.ButtonClick
        beCta16.EditValue = ""
        beCta16_Validated(beCta16, New System.EventArgs)
    End Sub
    Private Sub beCta01_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta01.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
        teCta01.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta02_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta02.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta02.EditValue)
        beCta02.EditValue = entCuentas.IdCuenta
        teCta02.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta03_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta03.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta03.EditValue)
        beCta03.EditValue = entCuentas.IdCuenta
        teCta03.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta04_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta04.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta04.EditValue)
        beCta04.EditValue = entCuentas.IdCuenta
        teCta04.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta05_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta05.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta05.EditValue)
        beCta05.EditValue = entCuentas.IdCuenta
        teCta05.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta06_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta06.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta06.EditValue)
        beCta06.EditValue = entCuentas.IdCuenta
        teCta06.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta07_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta07.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta07.EditValue)
        beCta07.EditValue = entCuentas.IdCuenta
        teCta07.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta08_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta08.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta08.EditValue)
        beCta08.EditValue = entCuentas.IdCuenta
        teCta08.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta09_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta09.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta09.EditValue)
        beCta09.EditValue = entCuentas.IdCuenta
        teCta09.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta10_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta10.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta10.EditValue)
        beCta10.EditValue = entCuentas.IdCuenta
        teCta10.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta11_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta11.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta11.EditValue)
        beCta11.EditValue = entCuentas.IdCuenta
        teCta11.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta12_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta12.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta12.EditValue)
        beCta12.EditValue = entCuentas.IdCuenta
        teCta12.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta13_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta13.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta13.EditValue)
        beCta13.EditValue = entCuentas.IdCuenta
        teCta13.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta14_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta14.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta14.EditValue)
        beCta14.EditValue = entCuentas.IdCuenta
        teCta14.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta15_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta15.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta15.EditValue)
        beCta15.EditValue = entCuentas.IdCuenta
        teCta15.EditValue = entCuentas.Nombre
    End Sub
    Private Sub beCta16_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles beCta16.Validated
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta16.EditValue)
        beCta16.EditValue = entCuentas.IdCuenta
        teCta16.EditValue = entCuentas.Nombre
    End Sub

    Private Sub sbCorrelativos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCorrelativos.Click
        adm_frmActualizarCorrelativos.ShowDialog()
    End Sub
End Class