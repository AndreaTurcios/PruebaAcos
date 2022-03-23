Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmEliminaSolicitudFondos

    Dim bl As New DBCoopBL.TableBusiness()
    Dim blPrestamo As New DBCoopBL.PrestamosBLL()

    Private Sub pre_frmIngresoDesembolsos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub pre_frmIngresoDesembolsos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles()
        seNumeroDesembolso.Properties.ReadOnly = True
        deFecha.Properties.ReadOnly = True
        teNumSolicitud.Properties.ReadOnly = True
        teNombre.Properties.ReadOnly = True
        teMontoLiquido.Properties.ReadOnly = True
        teIdSolicitudFondo.Focus()
    End Sub

    Private Sub CargaControles()
        teNombre.EditValue = ""
        seNumeroDesembolso.EditValue = 1
        teNumSolicitud.EditValue = ""
        deFecha.EditValue = Today
        teMontoLiquido.EditValue = 0.0
    End Sub

    Private Sub teIdSolicitudFondo_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles teIdSolicitudFondo.MouseClick
        frmConsultaSolicitudFondos.ShowDialog()
        teIdSolicitudFondo.EditValue = frmConsultaSolicitudFondos.IdSolicitudFondo
        teIdSolicitudFondo_Validated(e, New EventArgs)
    End Sub

    Private Sub teIdSolicitudFondo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teIdSolicitudFondo.Validated
        Dim entSolicitudFondo As New coo_SolicitudFondos
        Dim entSolicitudCredito As New coo_Solicitudes
        Dim entAsociados As New coo_Asociados
        Dim IdSolicitudFondo As Integer
        Dim NumeroPrestamo As String
        Dim ValorCheques As Decimal

        If teIdSolicitudFondo.EditValue = Nothing Then
            IdSolicitudFondo = Nothing
        Else
            IdSolicitudFondo = teIdSolicitudFondo.EditValue
        End If

        If teIdSolicitudFondo.EditValue = Nothing Then
            Exit Sub
        End If

        entSolicitudFondo = bl.coo_SolicitudFondosSelectByPK(IdSolicitudFondo)
        entSolicitudCredito = bl.coo_SolicitudesSelectByPK(entSolicitudFondo.IdSolicitud)
        entAsociados = bl.coo_AsociadosSelectByPK(entSolicitudCredito.IdAsociado)
        If entSolicitudFondo.IdSolicitudFondo <= 0 Then
            MsgBox("La solicitud de fondos no existe", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If

        If entSolicitudFondo.IdDesembolso = 99 Then
            MsgBox("La solicitud de fondos corresponde a prestamo en efectivo", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If

        If entSolicitudFondo.Entregado = True Then
            MsgBox("No es posible Eliminar la solicitud de fondo ya fue Desembolsada", MsgBoxStyle.Critical, "Error")
            CargaControles()
            Exit Sub
        End If
        teIdSolicitudFondo.EditValue = entSolicitudFondo.IdSolicitudFondo
        teNombre.EditValue = String.Format("{0} - {1} {2}", entSolicitudCredito.Numero, entAsociados.Nombres, entAsociados.Apellidos)
        seNumeroDesembolso.EditValue = entSolicitudFondo.IdDesembolso
        teNumSolicitud.EditValue = entSolicitudCredito.Numero
        deFecha.EditValue = entSolicitudCredito.FechaSolicitud
        ValorCheques = blPrestamo.ValorChequesDesembolso(entSolicitudFondo.IdSolicitud)
        teMontoLiquido.EditValue = entSolicitudFondo.MontoDesembolso - (entSolicitudFondo.TotalRefinanciamiento + entSolicitudFondo.Capitalizacion + entSolicitudFondo.Aportacion + entSolicitudFondo.Ahorro + entSolicitudFondo.TotalOtrasDeducciones + entSolicitudFondo.Iva + ValorCheques)
        NumeroPrestamo = blPrestamo.ExisteSolicitudPrestamo(entSolicitudFondo.IdSolicitud)
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        Dim msj As String = ""
        If MsgBox("Está seguro(a) de eliminar la Solicitud de Fondos?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Try
                objTablas.coo_SolicitudFondosDeleteByPK(teIdSolicitudFondo.EditValue)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Solicitud de Fondos ha sido Eliminado Con Exito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible eliminar la Solicitud de Fondos" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
        CargaControles()
        Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim entSolicitudFondo As coo_SolicitudFondos

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

        entSolicitudFondo = bl.coo_SolicitudFondosSelectByPK(teIdSolicitudFondo.EditValue)

        Dim dFechaContable As Date = objFunciones.GetFechaContable(gIdSucursal)
        If dFechaContable > entSolicitudFondo.FechaEntrega Then
            MsgBox("No es posible eliminar la Solicitud de Fondos, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error al elminar el registro")
            Return False
        End If

        If seNumeroDesembolso.EditValue = 0 Then
            MsgBox(String.Format("El Número de desembolso debe ser Mayor a cero{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teIdSolicitudFondo.Focus()
            Return False
        End If

        If blPrestamo.ExisteDesembolso(teIdSolicitudFondo.EditValue) > 0 Then
            MsgBox("No es posible elminarlo ya existe un Desembolso para el credito", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function

End Class
