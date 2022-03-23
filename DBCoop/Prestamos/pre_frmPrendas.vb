Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmPrendas
    Dim entPrenda As coo_GarantiasPrendaria
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

    Private Sub pre_frmPrendas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles(0)
        teTipoPrenda.Focus()
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entPrenda = objTablas.coo_GarantiasPrendariaSelectByPK(IdGarantia, IdSolicitud)
        If entPrenda.TipoPrenda = "" Then
            teTipoPrenda.EditValue = ""
            teMarca.EditValue = ""
            teModelo.EditValue = ""
            teSerie.EditValue = ""
            teColor.EditValue = ""
            teMotor.EditValue = ""
            teChasis.EditValue = ""
            teValorAproximado.EditValue = 0.0
            teDescripcion.EditValue = ""
        Else
            With entPrenda
                teTipoPrenda.EditValue = .TipoPrenda
                teMarca.EditValue = .Marca
                teModelo.EditValue = .Modelo
                teSerie.EditValue = .Serie
                teColor.EditValue = .Color
                teMotor.EditValue = .Motor
                teChasis.EditValue = .Chasis
                teValorAproximado.EditValue = .ValorAproximado
                teDescripcion.EditValue = .Descripcion
            End With
        End If
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        If Not DatosValidos() Then
            Exit Sub
        End If
        CargaEntidades()
        Dim msj As String = ""

        If bl.ExistePrendaSolicitud(IdSolicitud, IdGarantia) > 0 Then
            msj = bl.UpdatePrendaSolicitud(entPrenda)
            If msj = "" Then
                MsgBox("La Prenda ha sido actualizada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la Prenda" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al crear el registro")
                Return
            End If
        Else
            msj = bl.InsertaPrendaSolicitud(entPrenda)
            If msj = "" Then
                MsgBox("La Prenda ha sido guardada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar la Prenda" + Chr(13) + msj, MsgBoxStyle.Critical)
                Return
            End If
        End If
        Me.Close()
    End Sub

    Function DatosValidos() As Boolean
        If teTipoPrenda.EditValue = "" Then
            MsgBox("Debe especificar el Tipo de Prenda" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teTipoPrenda.Focus()
            Return False
        End If
        If teDescripcion.Text = "" Then
            MsgBox("Debe especificar la descripción de la Prenda" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teDescripcion.Focus()
            Return False
        End If
        If teValorAproximado.Text <= 0 Then
            MsgBox("Debe especificar el Valor Aproximado de la Prenda" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teValorAproximado.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub CargaEntidades()
        With entPrenda
            .IdGarantia = IdGarantia
            .IdSolicitud = IdSolicitud
            .TipoPrenda = teTipoPrenda.EditValue
            .Marca = teMarca.EditValue
            .Modelo = teModelo.EditValue
            .Serie = teSerie.EditValue
            .Color = teColor.EditValue
            .Motor = teMotor.EditValue
            .Chasis = teChasis.EditValue
            .ValorAproximado = teValorAproximado.EditValue
            .Descripcion = teDescripcion.EditValue
        End With
    End Sub

End Class