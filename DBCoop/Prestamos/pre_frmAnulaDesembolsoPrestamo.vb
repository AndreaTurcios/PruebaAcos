Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmAnulaDesembolsoPrestamo
    Dim entRefinancia As New DataTable
    Dim entLiquidacion As New coo_PrestamosDesembolso
    Dim bl As New DBCoopBL.TableBusiness()
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()
    Dim blAportacion As New AportacionesBLL()
    Dim blAhorro As New AhorrosBLL()
    Dim blFun As FuncionesBLL()
    Dim FechaContable As DateTime
    Dim DiasPrestamo As Integer
    Dim TasaSeguro As Decimal


    Private Sub pre_frmAnulaDesembolsoPrestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub pre_frmAnulaDesembolsoPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles()
        seNumeroDesembolso.Properties.ReadOnly = True
        deFecha.Properties.ReadOnly = True
        deFechaDesembolso.Properties.ReadOnly = True
        teNumeroPrestamo.Properties.ReadOnly = True
        teIdPrestamo.Properties.ReadOnly = True
        teNumCuenta.Properties.ReadOnly = True
        teIdCuenta.Properties.ReadOnly = True
        teMontoDesembolsado.Properties.ReadOnly = True
        teNumeroComprobante.Properties.ReadOnly = True
        teNumSolicitud.Properties.ReadOnly = True
        teNombre.Properties.ReadOnly = True
        teMontoLiquido.Properties.ReadOnly = True
        teIdSolicitudFondo.Focus()
    End Sub

    Private Sub CargaControles()
        teIdSolicitudFondo.EditValue = Nothing
        deFechaDesembolso.EditValue = Today
        teNumeroPrestamo.EditValue = ""
        teMontoDesembolsado.EditValue = 0.0
        teNombre.EditValue = ""
        seNumeroDesembolso.EditValue = 1
        teNumSolicitud.EditValue = ""
        deFecha.EditValue = Today
        teMontoLiquido.EditValue = 0.0
    End Sub

    Private Sub teIdSolicitudFondo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teIdSolicitudFondo.ButtonClick
        frmConsultaDesembolsos.ShowDialog()
        teIdSolicitudFondo.EditValue = frmConsultaDesembolsos.IdsolicitudFondo
        teIdSolicitudFondo_Validated(e, New EventArgs)
    End Sub

    Private Sub teIdSolicitudFondo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teIdSolicitudFondo.Validated
        Dim entPrestamoDesembolso As New coo_PrestamosDesembolso
        Dim entSolicitudFondo As New coo_SolicitudFondos
        Dim entSolicitudCredito As New coo_Solicitudes
        Dim entAsociados As New coo_Asociados
        Dim entCuenta As New coo_CuentasAhorro
        Dim IdSolicitudFondo As Integer
        If teIdSolicitudFondo.EditValue = Nothing Then
            IdSolicitudFondo = Nothing
        Else
            IdSolicitudFondo = teIdSolicitudFondo.EditValue
        End If
        If teIdSolicitudFondo.EditValue = Nothing Then
            Exit Sub
        End If


        entPrestamoDesembolso = bl.coo_PrestamosDesembolsoSelectByPK2(IdSolicitudFondo)
        entSolicitudFondo = bl.coo_SolicitudFondosSelectByPK(IdSolicitudFondo)
        entSolicitudCredito = bl.coo_SolicitudesSelectByPK(entSolicitudFondo.IdSolicitud)
        entAsociados = bl.coo_AsociadosSelectByPK(entSolicitudCredito.IdAsociado)
        entCuenta = bl.coo_CuentasAhorroSelectByPK(entPrestamoDesembolso.IdCuenta)

        If entPrestamoDesembolso.IdSolicitudFondo <= 0 Then
            MsgBox("El Desembolso no Existe", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entSolicitudFondo.IdSolicitudFondo <= 0 Then
            MsgBox("La solicitud de fondos no existe", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        If entPrestamoDesembolso.IdDesembolso = 99 Then
            MsgBox("El Desembolso corresponde a prestamo en efectivo", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        teIdSolicitudFondo.EditValue = entPrestamoDesembolso.IdSolicitudFondo
        deFechaDesembolso.EditValue = entPrestamoDesembolso.FechaMovimiento
        teNumeroPrestamo.EditValue = entPrestamoDesembolso.NumeroPrestamo
        teIdPrestamo.EditValue = entPrestamoDesembolso.IdPrestamo
        teNumeroComprobante.EditValue = entPrestamoDesembolso.NumeroComprobante
        teIdCuenta.EditValue = entPrestamoDesembolso.IdCuenta
        teNumCuenta.EditValue = entCuenta.Numero
        teMontoLiquido.EditValue = entPrestamoDesembolso.LiquidoDesembolso
        teMontoDesembolsado.EditValue = entPrestamoDesembolso.MontoDesembolso
        teNombre.EditValue = String.Format("{0} - {1} {2}", entSolicitudCredito.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        seNumeroDesembolso.EditValue = entSolicitudFondo.IdDesembolso
        teNumSolicitud.EditValue = entSolicitudCredito.Numero
        deFecha.EditValue = entSolicitudCredito.FechaSolicitud
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        Dim msj As String = ""
        Dim entSolicitudFondo As coo_SolicitudFondos
        Dim entPrestamoDesembolso As coo_PrestamosDesembolso
        Dim IdMovDeposito As Integer
        Dim IdMovAportacion As Integer
        Dim IdMovCapitalizacion As Integer
        Dim ComprobanteAportacion As String
        Dim ComprobanteCapitalizacion As String
        Dim IdSol As Integer = 0
        entPrestamoDesembolso = bl.coo_PrestamosDesembolsoSelectByPK(teIdSolicitudFondo.EditValue, teIdPrestamo.EditValue)
        ComprobanteAportacion = "P/" & entPrestamoDesembolso.NumeroComprobante
        ComprobanteCapitalizacion = "C/" & entPrestamoDesembolso.NumeroComprobante

        entSolicitudFondo = bl.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)
        IdMovAportacion = blAportacion.GetIdMovAportacion(ComprobanteAportacion, entSolicitudFondo.IdAsociado)
        IdMovCapitalizacion = blAportacion.GetIdMovAportacion(ComprobanteCapitalizacion, entSolicitudFondo.IdAsociado)

        IdMovDeposito = blAhorro.GetIdMovAhorro(entPrestamoDesembolso.NumeroComprobante, entPrestamoDesembolso.IdCuenta)
        If MsgBox("Está seguro(a) de eliminar el Desembolso?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_PrestamosPlanPagosDeleteByPrestamo(teIdPrestamo.EditValue)
                objTablas.coo_PrestamosDetalleDeleteByPK(teIdPrestamo.EditValue, 1)
                objTablas.coo_PrestamosDeleteByPK(teIdPrestamo.EditValue)
                objTablas.coo_PrestamosDesembolsoDeleteByPK(teIdSolicitudFondo.EditValue, teIdPrestamo.EditValue)
                objTablas.coo_PrestamosDetalleDescuentosDeleteByIdPrestamo(teIdPrestamo.EditValue)

                If seNumeroDesembolso.EditValue > 1 Then
                    IdSol = blPrestamo.ActualizarAnulacionDesembolso(teIdPrestamo.EditValue, teMontoDesembolsado.EditValue)
                End If
                If IdMovDeposito > 0 Then
                    objTablas.coo_CuentasAhorroMovDeleteByPK(teIdCuenta.EditValue, IdMovDeposito)
                End If
                If IdMovAportacion > 0 Then
                    objTablas.coo_AportacionesDeleteByPK(entSolicitudFondo.IdAsociado, IdMovAportacion)
                End If
                If IdMovCapitalizacion > 0 Then
                    objTablas.coo_AportacionesDeleteByPK(entSolicitudFondo.IdAsociado, IdMovCapitalizacion)
                End If
                IdSol = blPrestamo.ActualizarSolicitudFondo(entSolicitudFondo.IdSolicitudFondo)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El Desembolso ha sido Eliminado Con Exito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar el Desembolso" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
        CargaControles()
        Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim entSolicitudFondo As coo_SolicitudFondos
        Dim entPrestamoDesembolso As coo_PrestamosDesembolso
        Dim UltMovPrestamo As Integer
        Dim UltMovAportacion As Integer
        Dim UltMovAhorro As Integer
        Dim ComprobanteAportacion As String
        Dim ComprobanteCapitalizacion As String
        Dim IdMovAportacion As Integer
        Dim IdMovCapitalizacion As Integer
        Dim IdMovDeposito As Integer

        If IsNumeric(teIdSolicitudFondo.EditValue) Then
            If teIdSolicitudFondo.EditValue = 0 Then
                MsgBox(String.Format("Debes especificar La Solicitud de Fondos{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
                teIdSolicitudFondo.Focus()
                Return False
            End If
        Else
            MsgBox(String.Format("Debes especificar la Solicitud de Fondo{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teIdSolicitudFondo.Focus()
            Return False
        End If

        entPrestamoDesembolso = bl.coo_PrestamosDesembolsoSelectByPK(teIdSolicitudFondo.EditValue, teIdPrestamo.EditValue)
        entSolicitudFondo = bl.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)

        If seNumeroDesembolso.EditValue = 0 Then
            MsgBox(String.Format("El Número de desembolso debe ser Mayor a cero{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teIdSolicitudFondo.Focus()
            Return False
        End If
        If blPrestamo.ExisteDesembolso(teIdSolicitudFondo.EditValue) = 0 Then
            MsgBox("No es posible elminarlo la Solicitud de Fondos no ha sido Desembolsado", MsgBoxStyle.Critical)
            Return False
        End If
        FechaContable = objFunciones.GetFechaContable(gIdSucursal)

        If deFechaDesembolso.EditValue < FechaContable Then
            MsgBox("El Desembolso corresponde a un período ya cerrado", MsgBoxStyle.Critical, "Imposible continuar")
            Return False
        End If

        UltMovPrestamo = blPrestamo.GetUltMovPrestamo(entPrestamoDesembolso.IdPrestamo)
        If UltMovPrestamo > 1 Then
            MsgBox("El Prestamo ya posee Pagos , No es posible revertir el Desembolso", MsgBoxStyle.Critical, "Imposible continuar")
            Return False
        End If
        ComprobanteAportacion = "P/" & entPrestamoDesembolso.NumeroComprobante
        ComprobanteCapitalizacion = "C/" & entPrestamoDesembolso.NumeroComprobante
        IdMovAportacion = blAportacion.GetIdMovAportacion(ComprobanteAportacion, entSolicitudFondo.IdAsociado)
        IdMovCapitalizacion = blAportacion.GetIdMovAportacion(ComprobanteCapitalizacion, entSolicitudFondo.IdAsociado)
        UltMovAportacion = blAportacion.GetUltMovAporta(entSolicitudFondo.IdAsociado)
        If IdMovCapitalizacion > 0 Then
            If UltMovAportacion > IdMovCapitalizacion Then
                MsgBox("La Cuenta de Aportacion, Ya posee movimientos Posteriores", MsgBoxStyle.Critical, "Imposible continuar")
                Return False
            End If
        End If
        If IdMovCapitalizacion = 0 Then
            If IdMovAportacion > 0 Then
                If UltMovAportacion > IdMovAportacion Then
                    MsgBox("La Cuenta de Aportacion, Ya posee movimientos Posteriores", MsgBoxStyle.Critical, "Imposible continuar")
                    Return False
                End If
            End If
        End If
        IdMovDeposito = blAhorro.GetIdMovAhorro(entPrestamoDesembolso.NumeroComprobante, entPrestamoDesembolso.IdCuenta)
        UltMovAhorro = blAhorro.GetUltMovAhorro(entPrestamoDesembolso.IdCuenta)
        If IdMovDeposito > 0 Then
            If UltMovAhorro > IdMovDeposito Then
                MsgBox("La Cuenta de Ahorro, Ya posee movimientos Posteriores", MsgBoxStyle.Critical, "Imposible continuar")
                Return False
            End If
        End If
        Return True
    End Function

End Class
