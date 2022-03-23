Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class pre_frmHipotecas
    Dim entHipoteca As coo_GarantiasHipoteca
    Dim _IdSolicitud As Integer = 0
    Dim _IdGarantia As Integer = 0
    Dim bl As New PrestamosBLL()
    

    Public Property IdSolicitud() As Integer
        Get
            Return _IdSolicitud
        End Get
        Set(ByVal value As Integer)
            _IdSolicitud = value
        End Set
    End Property

    Public Property IdGarantia() As Integer
        Get
            Return _IdGarantia
        End Get
        Set(ByVal value As Integer)
            _IdGarantia = value
        End Set
    End Property

    Private Sub pre_frmHipotecas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        CargaControles(0)
        tePropiedad.Focus()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_TipoHipoteca(cboSituacion, "")
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entHipoteca = objTablas.coo_GarantiasHipotecaSelectByPK(IdSolicitud, IdGarantia)
        If entHipoteca.Propietario = "" Then
            tePropiedad.EditValue = ""
            teDireccion.EditValue = ""
            teArea.EditValue = ""
            teDescripcion.EditValue = ""
            teValorPropiedad.EditValue = 0.0
            teRegistrada.EditValue = ""
            teNumeroFolio.EditValue = ""
            teNumeroLibro.EditValue = ""
            chkGravada.EditValue = True
            cboSituacion.EditValue = 1
        Else
            With entHipoteca
                tePropiedad.EditValue = .Propietario
                teDireccion.EditValue = .DireccionPropiedad
                teArea.EditValue = .AreaPropiedad
                teDescripcion.EditValue = .DescripcionPropiedad
                teValorPropiedad.EditValue = .ValorPropiedad
                teRegistrada.EditValue = .Registro
                teNumeroFolio.EditValue = .NumeroFolio
                teNumeroLibro.EditValue = .NumeroLibro
                chkGravada.EditValue = .Gravada
                cboSituacion.EditValue = .IdSituacion
            End With
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""

        If bl.ExisteHipotecaSolicitud(IdSolicitud, IdGarantia) > 0 Then
            msj = bl.UpdateHipotecaSolicitud(entHipoteca)
            If msj = "" Then
                MsgBox("La Hipoteca ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la Hipoteca" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaHipotecaSolicitud(entHipoteca)
            If msj = "" Then
                MsgBox("La Hipoteca ha sido guardada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la Hipoteca" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If
        Me.Close()
    End Sub

    Function DatosValidos() As Boolean
        If tePropiedad.EditValue = "" Then
            MsgBox("Debe especificar el Nombre del Titular de la Propiedad" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            tePropiedad.Focus()
            Return False
        End If
        If teDireccion.Text = "" Then
            MsgBox("Debe especificar la Dirección de la Propiedad" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teDireccion.Focus()
            Return False
        End If
        If teDescripcion.Text = "" Then
            MsgBox("Debe especificar la Descripcion de la Propiedad" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teDescripcion.Focus()
            Return False
        End If
        If teValorPropiedad.EditValue <= 0 Then
            MsgBox("Debe especificar el Valor Aproximado de la Propiedad" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teValorPropiedad.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entHipoteca
            .IdGarantia = IdGarantia
            .IdSolicitud = IdSolicitud
            .Propietario = tePropiedad.EditValue
            .DireccionPropiedad = teDireccion.EditValue
            .AreaPropiedad = teArea.EditValue
            .DescripcionPropiedad = teDescripcion.EditValue
            .ValorPropiedad = teValorPropiedad.EditValue
            .Registro = teRegistrada.EditValue
            .NumeroFolio = teNumeroFolio.EditValue
            .NumeroLibro = teNumeroLibro.EditValue
            .Gravada = chkGravada.EditValue
            .IdSituacion = cboSituacion.EditValue
        End With
    End Sub

End Class