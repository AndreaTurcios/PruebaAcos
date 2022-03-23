Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmDictamenTecnico
    Dim entDictamen As coo_DictamenTecnico
    Dim _IdSolicitud As Integer = 0
    Dim bl As New PrestamosBLL()

    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Private _MontoPropuesto As System.Decimal
    Public Property MontoPropuesto() As System.Decimal
        Get
            Return _MontoPropuesto
        End Get
        Set(ByVal value As System.Decimal)
            _MontoPropuesto = value
        End Set
    End Property

    Private _CuotasPropuestas As System.Int32
    Public Property CuotasPropuestas() As System.Int32
        Get
            Return _CuotasPropuestas
        End Get
        Set(ByVal value As System.Int32)
            _CuotasPropuestas = value
        End Set
    End Property

    Private _IdFormaPago As System.Int32
    Public Property IdFormaPago() As System.Int32
        Get
            Return _IdFormaPago
        End Get
        Set(ByVal value As System.Int32)
            _IdFormaPago = value
        End Set
    End Property

    Private Sub pre_frmDictamenTecnico_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles()
        meComentario.Focus()
    End Sub

    Private Sub CargaControles()
        entDictamen = objTablas.coo_DictamenTecnicoSelectByPK(IdSolicitud)
        If entDictamen.ComentarioProyecto = "" Then
            meComentario.EditValue = ""
            meCalidadAsociado.EditValue = ""
            meValoracionProyecto.EditValue = ""
            meOtrasCondiciones.EditValue = ""
            meOrganizacionProduccion.EditValue = ""
            meCalidadGarantia.EditValue = ""
            mePropuestaFinanciamiento.EditValue = ""
            teMontoPropuesto.EditValue = MontoPropuesto
            sePlazoCuotas.EditValue = CuotasPropuestas
            rgFormaPago.EditValue = IdFormaPago
            seMesesGracia.EditValue = 0
            deFechaAnalisis.EditValue = Today
            teClasificacionDeudor.EditValue = ""
            teClasificacionFiador.EditValue = ""
        Else
            With entDictamen
                meComentario.EditValue = .ComentarioProyecto
                meCalidadAsociado.EditValue = .CalidadAsociado
                meValoracionProyecto.EditValue = .ValoracionProyecto
                meOtrasCondiciones.EditValue = .OtrasCondiciones
                meOrganizacionProduccion.EditValue = .OrganizacionProduccion
                meCalidadGarantia.EditValue = .CalidadGarantia
                mePropuestaFinanciamiento.EditValue = .PropuestaFinanciamiento
                teMontoPropuesto.EditValue = .MontoPropuesto
                sePlazoCuotas.EditValue = .CuotasPropuestas
                rgFormaPago.EditValue = .IdFormaPago
                seFrecuencia.EditValue = .FrecuenciaPago
                seMesesGracia.EditValue = .MesesGracia
                deFechaAnalisis.EditValue = .FechaAnalisis
                teClasificacionDeudor.EditValue = .ClasificacionDeudor
                teClasificacionFiador.EditValue = .ClasificacionFiador
            End With
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""

        If bl.ExisteDictamenTecnico(IdSolicitud) > 0 Then
            msj = bl.UpdateDictamenTecnico(entDictamen)
            If msj = "" Then
                MsgBox("El dictamen del técnico ha sido actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar el dictamen del técnico{0}{1}", Chr(13), msj), MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaDictamenTecnico(entDictamen)
            If msj = "" Then
                MsgBox("El dictamen del técnico ha sido guardado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar el dictamen del técnico{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        End If
        Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim msj As String = meComentario.Text + meOrganizacionProduccion.Text + meCalidadAsociado.EditValue + meCalidadGarantia.Text + mePropuestaFinanciamiento.Text
        If msj = "" Then
            MsgBox(String.Format("Es necesario especificar por lo menos una valoración técnica{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error de usuario")
            Exit Function
        End If
        'If meCalidadAsociado.EditValue = "" Then
        '    
        '    meCalidadAsociado.Focus()
        '    Return False
        'End If
        'If meCalidadGarantia.Text = "" Then
        '    MsgBox("Debe especificar la calidad de la garantía " + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    meCalidadGarantia.Focus()
        '    Return False
        'End If
        'If mePropuestaFinanciamiento.Text = "" Then
        '    MsgBox("Debe especificar la propuesta de financiamiento" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
        '    mePropuestaFinanciamiento.Focus()
        '    Return False
        'End If
        If teMontoPropuesto.Text <= 0 Then
            MsgBox(String.Format("Debe especificar el monto propuesto por el técnico{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            teMontoPropuesto.Focus()
            Return False
        End If
        If deFechaAnalisis.EditValue = Nothing Then
            MsgBox(String.Format("Debe de especificar la Fecha de Análisis{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
            deFechaAnalisis.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entDictamen
            .IdSolicitud = IdSolicitud
            .ComentarioProyecto = meComentario.EditValue
            .CalidadAsociado = meCalidadAsociado.EditValue
            .ValoracionProyecto = meValoracionProyecto.EditValue
            .OtrasCondiciones = meOtrasCondiciones.EditValue
            .OrganizacionProduccion = meOrganizacionProduccion.EditValue
            .CalidadGarantia = meCalidadGarantia.EditValue
            .PropuestaFinanciamiento = mePropuestaFinanciamiento.EditValue
            .MontoPropuesto = teMontoPropuesto.EditValue
            .CuotasPropuestas = sePlazoCuotas.EditValue
            .IdFormaPago = rgFormaPago.EditValue
            .FrecuenciaPago = seFrecuencia.EditValue
            .MesesGracia = seMesesGracia.EditValue
            .FechaAnalisis = deFechaAnalisis.EditValue
            .ClasificacionDeudor = teClasificacionDeudor.EditValue
            .ClasificacionFiador = teClasificacionFiador.EditValue
        End With
    End Sub

End Class