Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmSeguimientosPrestamo
    Dim entSeguimiento As New coo_SeguimientoPrestamos
    Dim entPrestamo As New coo_Prestamos
    Dim entAsociados As New coo_Asociados
    Dim entHistorial As New List(Of coo_SeguimientoPrestamos)
    Dim _IdPrestamo As Integer = 0
    Dim bl As New PrestamosBLL()
    Dim blCaja As New TableBusiness()

    Public Property IdPrestamo() As Integer
        Get
            Return _IdPrestamo
        End Get
        Set(ByVal value As Integer)
            _IdPrestamo = value
        End Set
    End Property

    Private Sub pre_frmSeguimientoPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        gcMov.DataSource = bl.GetSeguimientoPrestamos(IdPrestamo)
        entPrestamo = blCaja.coo_PrestamosSelectByPK(IdPrestamo)
        beNumPrestamo.EditValue = entPrestamo.Numero
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        entAsociados = blCaja.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teNombre.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)
        teSaldo.EditValue = bl.GetSaldoCapitalPrestamo(IdPrestamo)
        beNumPrestamo.Properties.ReadOnly = True
        teIdPrestamo.Properties.ReadOnly = True
        teNombre.Properties.ReadOnly = True
        deFechaVisita.EditValue = Today
        teNota.EditValue = ""
        deFechaVisita.Focus()
    End Sub


    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        Dim msj As String = ""
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe especificar el Numero de Prestamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFechaVisita.Focus()
            Exit Sub
        End If
        If teNota.EditValue = "" Then
            MsgBox("Debe especificar la Nota" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teNota.Focus()
            Exit Sub
        End If

        With entSeguimiento
            .IdPrestamo = teIdPrestamo.EditValue
            .Fecha = deFechaVisita.EditValue
            .Saldo = teSaldo.EditValue
            .Seguimiento = teNota.EditValue
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
        End With
        msj = bl.InsertaSeguimientoPrestamo(entSeguimiento)
        If msj = "" Then

        Else
            MsgBox("No fue posible actualizar el Seguimiento al Préstamo" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If
        teNota.EditValue = ""
        gcMov.DataSource = bl.GetSeguimientoPrestamos(IdPrestamo)
    End Sub

    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbEliminar.Click
        Dim IdSeguimiento As Integer = SiEsNulo(gvMov.GetFocusedRowCellValue("IdSeguimiento"), 0)
        If MsgBox("Está seguro(a) de eliminar la Nota?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_SeguimientoPrestamosDeleteByPK(IdSeguimiento)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("La Nota ha sido eliminada con éxito", MsgBoxStyle.Information)
                gcMov.DataSource = bl.GetSeguimientoPrestamos(IdPrestamo)
            Else
                MsgBox("No fue posible eliminar la Nota" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub sbRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRegresar.Click
        Close()
    End Sub
End Class