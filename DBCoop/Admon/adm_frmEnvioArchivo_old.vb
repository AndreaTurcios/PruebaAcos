Imports DBCoopBL
Imports DBCoopEL.TableEntities
'Imports CajaBL
Public Class adm_frmEnvioArchivo
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()
    Dim blApor As New AportacionesBLL
    Dim blAho As New AhorrosBLL
    Dim dt As DataTable
    Dim dtParam As DataTable = bl.ObtieneParametros
    Dim dFecha As Date
    Dim IdDocumento As Integer
    Dim entAsociado As coo_Asociados
    Dim entAfiliacion As New List(Of coo_Afiliaciones)
    Dim entAportaciones As New List(Of coo_Aportaciones)
    Dim entAhorros As New List(Of coo_CuentasAhorroMov)
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    Dim blPrestamo As New Prestamo
    Dim elpagodetalle As New coo_PrestamosDetalle
    Dim blCaja As New CajaBusiness()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES")
        objCombos.adm_TiposPlanilla(leTipoPlanilla, "")
        objCombos.adm_TipoArchivo(leTipoArchivo, "")
        ' leSucursal.EditValue = gIdSucursal
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        ceDetalle.EditValue = False
    End Sub

    Private Sub btGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGenerar.Click
        'VERIFICO SI LA FECHA DEL PRIMER PAGO ESTA HABIL AUN
        Dim FechaDescuentosPla As Date = blPres.FechaDescuentoActiva()
        If FechaDescuentosPla = Nothing Then
            MsgBox(String.Format("No hay ninguna fecha disponible para descuentos {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Exit Sub
        End If


        'Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If deFecha.EditValue < dFechaContable Then
        '    MsgBox("La fecha de generación no debe ser menor a la fecha contable, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al Generar")
        '    Exit Sub
        'End If

        'If blPres.VerificaAplicoEnvio(deFecha.EditValue, leTipoPlanilla.EditValue) <> 0 Then
        '    MsgBox("Ya a aplicado un envio con estos parametros", MsgBoxStyle.Critical, "Error al Generar")
        '    Exit Sub
        'End If


        If ceDetalle.EditValue = False Then
            Dim rpt As New pre_rptListadoEnvioPlanilla
            If leTipoArchivo.EditValue = 1 Then
                rpt.DataSource = blPres.EnvioDescuentosPlanillaDespensa(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
                rpt.xrlTitulo.Text = "PLANILLA " + leTipoPlanilla.Text + " DESCUENTOS A EMPLEADOS DESPENSA Y ELECTRODOMESTICOS"
            Else
                rpt.DataSource = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
                rpt.xrlTitulo.Text = "PLANILLA " + leTipoPlanilla.Text + " DE DESCUENTOS A EMPLEADOS FINANCIERO"
            End If

            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            


            If CDate(deFecha.EditValue).Day <= 15 Then
                rpt.xrlcDelAl.Text = "PRIMERA QUINCENA DEL MES DE: " + ObtieneMesString(CDate(deFecha.EditValue).Month) + " " + CDate(deFecha.EditValue).Year.ToString
            Else
                rpt.xrlcDelAl.Text = "SEGUNDA QUINCENA DEL MES DE: " + ObtieneMesString(CDate(deFecha.EditValue).Month) + " " + CDate(deFecha.EditValue).Year.ToString
            End If

            rpt.xrlSucursal.Text = leSucursal.Text
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New pre_rptListadoEnvioPlanillaDetalle
            If leTipoArchivo.EditValue = 1 Then
                rpt.DataSource = blPres.EnvioDescuentosPlanillaDespensa(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
                rpt.xrlTitulo.Text = "PLANILLA " + leTipoPlanilla.Text + " DESCUENTOS A EMPLEADOS DESPENSA Y ELECTRODOMESTICOS"
            Else
                rpt.DataSource = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
                rpt.xrlTitulo.Text = "PLANILLA " + leTipoPlanilla.Text + " DE DESCUENTOS A EMPLEADOS FINANCIERO"
            End If

            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa


            If CDate(deFecha.EditValue).Day <= 15 Then
                rpt.xrlcDelAl.Text = "PRIMERA QUINCENA DEL MES DE: " + ObtieneMesString(CDate(deFecha.EditValue).Month) + " " + CDate(deFecha.EditValue).Year.ToString
            Else
                rpt.xrlcDelAl.Text = "SEGUNDA QUINCENA DEL MES DE: " + ObtieneMesString(CDate(deFecha.EditValue).Month) + " " + CDate(deFecha.EditValue).Year.ToString
            End If

            rpt.xrlSucursal.Text = leSucursal.Text
            rpt.ShowPreviewDialog()
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'VERIFICO SI LA FECHA DEL PRIMER PAGO ESTA HABIL AUN
        Dim FechaDescuentosPla As Date = blPres.FechaDescuentoActiva()
        If FechaDescuentosPla = Nothing Then
            MsgBox(String.Format("No hay ninguna fecha disponible para descuentos {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            Exit Sub
        End If

        'If deFecha.EditValue < FechaDescuentosPla Then
        '    MsgBox(String.Format("La fecha de envio es menor a la fecha del del próximo descuento {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Exit Sub
        'End If


        'Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If deFecha.EditValue < dFechaContable Then
        '    MsgBox("La fecha de generación no debe ser menor a la fecha contable, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
        '    Exit Sub
        'End If

        If blPres.VerificaAplicoEnvio(deFecha.EditValue, leTipoPlanilla.EditValue, leTipoArchivo.EditValue) <> 0 Then
            MsgBox("Ya a aplicado un envio con estos parametros", MsgBoxStyle.Critical, "Error al Generar")
            Exit Sub
        End If

        If MsgBox(String.Format("Los datos a aplicar quedaran como definitivos para la carga de datos, Está seguro(a) de continuar con el proceso?", Chr(13)), MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim dt As New DataTable

        If leTipoArchivo.EditValue = 1 Then
            dt = blPres.EnvioDescuentosPlanillaDespensa(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, True, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
        Else
            dt = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, True, ceDetalle.EditValue, ceEnvioAhorro.EditValue, objMenu.User)
        End If

        If dt.Rows(0).Item("Ok") = "Ok" Then
            MsgBox("La aplicación se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
            Close()
        Else
            MsgBox(String.Format("Se generó un error al momento de realizar el proceso{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13)), MsgBoxStyle.Critical, "Nota")
        End If
    End Sub
End Class


