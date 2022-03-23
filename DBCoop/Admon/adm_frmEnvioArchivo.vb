Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports System.IO

Public Class adm_frmEnvioArchivo
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()
    Dim blApor As New AportacionesBLL()
    Dim blAho As New AhorrosBLL
    Dim dt As DataTable
    Dim dtParam As DataTable = bl.ObtieneParametros
    Dim dFecha As Date
    Dim IdDocumento As Integer
    Dim entAsociado As coo_Asociados
    Dim entAportaciones As New List(Of coo_Aportaciones)
    Dim entAhorros As New List(Of coo_CuentasAhorroMov)
    Dim entPrestamos As New List(Of coo_PrestamosDetalle)
    Dim elpagodetalle As New coo_PrestamosDetalle
    Dim blCaja As New CajaBusiness()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "--TODAS LAS SUCURSALES")
        objCombos.adm_TiposPlanilla(leTipoPlanilla, "")
        objCombos.coo_UbicacionesAsociados(leCentro, "-- TODOS LOS CENTROS DE COSTOS --")
        deFecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        ceIncluirSaldo.EditValue = False
        leTipoPlanilla.EditValue = 3
    End Sub

    Private Sub btGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGenerar.Click
        DevExpress.XtraPrinting.CsvExportOptions.FollowReportLayout = False
        If ChecTelefonia.Checked = True Then
            Dim rpt As New pre_rptListadoEnvioPlanillaTelefonia
            rpt.DataSource = blPres.rptEnvioDescuentosTelefonico(deFecha.EditValue, leCentro.EditValue)
            rpt.xrlTitulo.Text = "DESCUENTOS DE TELEFONIA"
            rpt.DataMember = ""
            rpt.xrlEmpresa.Text = gsNombre_Empresa
            rpt.ShowPreviewDialog()
        Else
            Dim rpt As New pre_rptListadoEnvioPlanillaDetalle
            rpt.DataSource = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, True, leCentro.EditValue, objMenu.User, ceDetalle.EditValue, cheAplicaPlanilla.EditValue)
            rpt.xrlTitulo.Text = "PLANILLA " + leTipoPlanilla.Text + " DESCUENTOS A EMPLEADOS DE PRESTAMOS"


            rpt.xrlSaldo.Visible = ceIncluirSaldo.EditValue
            rpt.XrLabel12.Visible = ceIncluirSaldo.EditValue
            rpt.XrLabel14.Visible = ceIncluirSaldo.EditValue
            rpt.XrLabel15.Visible = ceIncluirSaldo.EditValue


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


        'If deFecha.EditValue < FechaDescuentosPla Then
        '    MsgBox(String.Format("La fecha de envio es menor a la fecha del del próximo descuento {0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Exit Sub
        'End If


        'Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        'If deFecha.EditValue < dFechaContable Then
        '    MsgBox("La fecha de generación no debe ser menor a la fecha contable, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
        '    Exit Sub
        'End If

        If blPres.VerificaAplicoEnvio(deFecha.EditValue, leTipoPlanilla.EditValue) <> 0 Then
            MsgBox("Ya a aplicado un envio con estos parametros", MsgBoxStyle.Critical, "Error al Generar")
            Exit Sub
        End If

        If MsgBox(String.Format("Los datos a aplicar quedaran como definitivos para la carga de datos, Está seguro(a) de continuar con el proceso?", Chr(13)), MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim dt As New DataTable
        dt = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, True, True, leCentro.EditValue, objMenu.User, False, cheAplicaPlanilla.EditValue)


        If dt.Rows(0).Item("Ok") = "Ok" Then
            MsgBox("La aplicación se ha realizado con éxito", MsgBoxStyle.Information, "Nota")
            Close()
        Else
            MsgBox(String.Format("Se generó un error al momento de realizar el proceso{0}Reporte el siguiente mensaje al departamento de IT{0}{1}", Chr(13)), MsgBoxStyle.Critical, "Nota")
        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim Delimitador As String = InputBox("Deliminator del archivo:", "Especifique el delimitador", ",")
        If Delimitador = "" Then
            Return
        End If

        Dim fbd As New FolderBrowserDialog

        fbd.ShowDialog()
        If fbd.SelectedPath = "" Then
            Return
        End If

        Dim Archivo As String = String.Format("{0}\SALDOPRESTAMOS{1}.txt", fbd.SelectedPath, Format(deFecha.EditValue, "yyyyMMdd"))

        Try
            Using Arc As StreamWriter = New StreamWriter(Archivo)
                Dim linea As String = String.Empty
                Dim dt As New DataTable
                dt = blPres.EnvioDescuentosPlanillaFinanciero(leSucursal.EditValue, deFecha.EditValue, leTipoPlanilla.EditValue, False, True, leCentro.EditValue, objMenu.User, False, cheAplicaPlanilla.EditValue)

                For fila As Integer = 0 To dt.Rows.Count - 1
                    linea = String.Empty

                    linea &= dt.Rows(fila).Item("Referencia") & Delimitador
                    linea &= dt.Rows(fila).Item("NumeroPrestamo") & Delimitador
                    linea &= dt.Rows(fila).Item("Descuento") & Delimitador

                    With Arc
                        linea = linea.Remove(linea.Length - 1).ToString
                        .WriteLine(linea.ToString)
                    End With
                Next
            End Using

            Process.Start(Archivo)

            'si se genera un error
        Catch ex As Exception
            MsgBox("NO SE PUDO GUARDAR EL ARCHIVO" + Chr(13) + ex.Message.ToString, MsgBoxStyle.Critical, "Nota")
        End Try
    End Sub

    Private Sub ChecTelefonia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChecTelefonia.CheckedChanged
        If ChecTelefonia.Checked = True Then
            ceIncluirSaldo.Enabled = False
            ceDetalle.Enabled = False
            leTipoPlanilla.Enabled = False
        Else
            ceIncluirSaldo.Enabled = True
            ceDetalle.Enabled = True
            leTipoPlanilla.Enabled = True
        End If
    End Sub

    
End Class


