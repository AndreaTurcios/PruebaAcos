Imports DBCoopEL.TableEntities
Imports DBCoopBL
Imports DevExpress.XtraReports.UI
Imports vb = Microsoft.VisualBasic
Public Class frmEliminarOtrosIngresos
    Dim blCaja As New CajaBusiness()
    Dim entSucursal As New adm_Sucursales
    Dim entTipoMovimiento As coo_TiposMovimientoCaja

    Private Sub frmEliminarOtrosIngresos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmEliminarOtrosIngresos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
    End Sub

    Private Sub CargaCombos()
        With objCombos
            .cooPtmoFmaPago(_formPago)
            .cooTipoComprobanteIngreso(leTipoComprobante)
        End With
    End Sub

    Private Sub sbObtener_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbObtener.Click

        Dim entOtrosIngresos As coo_OtrosIngresos
        Dim entAsociado As coo_Asociados
        Dim IdMov As Integer = blCaja.IdMovComprobanteIngreso(_NroComprobante.EditValue, _Prefijo.EditValue)
        entOtrosIngresos = objTablas.coo_OtrosIngresosSelectByPK(IdMov)
        entAsociado = objTablas.coo_AsociadosSelectByPK(entOtrosIngresos.IdAsociado)
        entSucursal = objTablas.adm_SucursalesSelectByPK(entOtrosIngresos.IdSucursal)
        If Idmov > 0 Then
            teIdMov.EditValue = entOtrosIngresos.IdMov
            _formPago.EditValue = entOtrosIngresos.IdFormaPago
            leTipoComprobante.EditValue = entOtrosIngresos.TipoComprobante
            entTipoMovimiento = objTablas.coo_TiposMovimientoCajaSelectByPK(entOtrosIngresos.IdTipoMovimiento)
            teTipoMovimiento.EditValue = entTipoMovimiento.Nombre
            teSucursal.EditValue = entSucursal.Nombre
            teIdAsociado.EditValue = entOtrosIngresos.IdAsociado
            If entAsociado.Numero <> "" Then
                _IdAsociado.EditValue = entAsociado.Numero
            Else
                _IdAsociado.EditValue = ""
            End If
            _NombreAsociado.EditValue = entOtrosIngresos.Nombre
            _Dui.EditValue = entOtrosIngresos.Dui
            _Direccion.EditValue = entOtrosIngresos.Direccion
            _FechaIngreso.EditValue = entOtrosIngresos.Fecha
            _IngresoNoSujeto.EditValue = entOtrosIngresos.ValorNoSujeto
            _ConceptoNoSujeto.EditValue = entOtrosIngresos.ConceptoNoSujeto
            _IngresoExcento.EditValue = entOtrosIngresos.ValorExento
            _ConceptoExento.EditValue = entOtrosIngresos.ConceptoExento
            _IngresoGravado.EditValue = entOtrosIngresos.ValorAfecto
            _ConceptoGravado.EditValue = entOtrosIngresos.ConceptoAfecto
            teOtrosIngresos.EditValue = entOtrosIngresos.OtrosIngresos
            teConceptoOtrosIngresos.EditValue = entOtrosIngresos.ConceptoOtrosIngresos
            _observa.EditValue = entOtrosIngresos.Observaciones
        Else
            MsgBox("El comprobante no existe", MsgBoxStyle.Critical, "Nota")
            Close()
        End If

    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnEliminar.Click
        Dim msj As String = ""
        If _FechaIngreso.EditValue <> blCaja.GetFechaContable(gIdSucursal) Then
            MsgBox("No puede eliminar el documento. La fecha corresponde a un período ya cerrado", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If teIdMov.EditValue <= 0 Then
            MsgBox("Debe seleccionar un comprobante de ingreso", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de eliminar el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_OtrosIngresosDeleteByPK(teIdMov.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El documento fue eliminado con Exito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar el documento" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al eliminar el registro")
            End If
        End If
        Close()
    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbImprimir.Click
        If leTipoComprobante.EditValue = 2 Then
            If MsgBox("¿Desea imprimir la Factura?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim entAsociado As New coo_Asociados
                Dim rpt As New pre_rptFacturaIngresos

                entAsociado = objTablas.coo_AsociadosSelectByPK(teIdAsociado.EditValue)

                Dim sDecimal = String.Format("{0:c}", Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlTotalPagado.Text = Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00")
                rpt.xrlFechaContable.Text = _FechaIngreso.EditValue
                rpt.xrlNombre.Text = _NombreAsociado.EditValue
                rpt.xrlNumeroAsociado.Text = _IdAsociado.EditValue
                rpt.xrlDireccion.Text = _Direccion.EditValue

                rpt.xrlDui.Text = _Dui.EditValue
                rpt.xrlComprobante.Text = _NroComprobante.EditValue
                rpt.xrlConceptoOtrosIngresos.Text = teConceptoOtrosIngresos.EditValue
                rpt.xrlOtrosIngresos.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                rpt.xrlConceptoNoSujeto.Text = _ConceptoNoSujeto.EditValue
                rpt.xrlNoSujeto.Text = Format(CDec(_IngresoNoSujeto.EditValue), "##,##0.00")
                rpt.xrlConceptoExento.Text = _ConceptoExento.EditValue
                rpt.xrlExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                rpt.xrlconceptoGravado.Text = _ConceptoGravado.EditValue
                rpt.xrlGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")

                rpt.xrlTotalOtros.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                rpt.xrlTotalExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                rpt.xrlTotalExento2.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                rpt.xrlTotalGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")
                If _IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue >= 1 Then
                    rpt.xrlCantidadLetras.Text = Num2Text(Int(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue))) & " " & sDecimal & " DÓLARES"
                Else
                    rpt.xrlCantidadLetras.Text = sDecimal & " DÓLARES"
                End If
                rpt.PrinterName = gsImpresorDefault
                While True
                    rpt.PrintDialog()
                    If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If

        If leTipoComprobante.EditValue = 1 Then
            If MsgBox("Desea imprimir el Comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim rpt As New pre_rptComprobIngreso
                Dim sDecimal = String.Format("{0:c}", Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00"))
                sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
                rpt.xrlConceptoIngreso.Text = teConceptoOtrosIngresos.EditValue
                rpt.xrlIngreso.Text = Format(CDec(teOtrosIngresos.EditValue), "##,##0.00")
                rpt.xrlConceptoNoSujeto.Text = _ConceptoNoSujeto.EditValue
                rpt.xrlNoSujeto.Text = Format(CDec(_IngresoNoSujeto.EditValue), "##,##0.00")
                rpt.xrlConceptoExento.Text = _ConceptoExento.EditValue
                rpt.xrlExento.Text = Format(CDec(_IngresoExcento.EditValue), "##,##0.00")
                rpt.xrlConceptoGravado.Text = _ConceptoGravado.EditValue
                rpt.xrlGravado.Text = Format(CDec(_IngresoGravado.EditValue), "##,##0.00")
                rpt.xrlTotal.Text = Format(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue), "##,##0.00")

                rpt.xrlFecha.Text = FechaToString(_FechaIngreso.EditValue, _FechaIngreso.EditValue)
                rpt.xrlNombre.Text = _NombreAsociado.EditValue
                rpt.xrlNumero.Text = _IdAsociado.EditValue
                If _IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue >= 1 Then
                    rpt.xrlCantidadLetras.Text = Num2Text(Int(CDec(_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue))) & " " & sDecimal & " DÓLARES"
                Else
                    rpt.xrlCantidadLetras.Text = sDecimal & " DÓLARES"
                End If

                rpt.PrinterName = gsImpresorDefault
                While True
                    Rpt.PrintDialog()
                    If MsgBox("Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While

            End If
        End If
        If leTipoComprobante.EditValue > 2 Then
            If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                Dim rpt As New rptPosteo
                rpt.xrlComprobante.Text = _NroComprobante.EditValue
                rpt.xrlCuenta.Text = _IdAsociado.EditValue
                rpt.xrlFecha.Text = _FechaIngreso.EditValue
                rpt.xrlValor.Text = Format(CDec((_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue)), "##,##0.00")
                rpt.xrlCajero.Text = objMenu.User
                rpt.PrinterName = gsImpresorDefault
                While True
                    rpt.PrintDialog()
                    If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                        Exit While
                    End If
                End While
            End If
        End If

        If (_IngresoNoSujeto.EditValue + _IngresoExcento.EditValue + _IngresoGravado.EditValue + teOtrosIngresos.EditValue) > 3000 Then
            MsgBox("Se va imprimir el Formulario de Control en éste momento", MsgBoxStyle.Information, "Imprimir")
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
            rpt.PrintDialog()
        End If
    End Sub
End Class