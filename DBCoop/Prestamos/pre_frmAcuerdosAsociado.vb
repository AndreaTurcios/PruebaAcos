Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmAcuerdosAsociado
    Dim entSeguimiento As New coo_SeguimientoCobros
    Dim entPrestamo As New coo_Prestamos
    Dim blAporta As New AportacionesBLL()
    Dim entAsociados As New coo_Asociados
    Dim entHistorial As New List(Of coo_SeguimientoCobros)
    Dim _IdPrestamo As Integer = 0, dtParam As DataTable = blAporta.ObtenerParametrosGenerales()
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

    Private Sub pre_frmAcuerdosAsociado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaCombos()
        gcMov.DataSource = bl.GetSeguimientoCobros(IdPrestamo)
        entPrestamo = blCaja.coo_PrestamosSelectByPK(IdPrestamo)
        beNumPrestamo.EditValue = entPrestamo.Numero
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        entAsociados = blCaja.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        teNombre.EditValue = String.Format("{0} {1}", entAsociados.Nombres, entAsociados.Apellidos)
        teSaldo.EditValue = bl.GetSaldoCapitalPrestamo(IdPrestamo)
        beNumPrestamo.Properties.ReadOnly = True
        teIdPrestamo.Properties.ReadOnly = True
        teNombre.Properties.ReadOnly = True
        deFechaAcuerdo.EditValue = Today
        leTipoCarta.EditValue = 1
        teAcuerdo.EditValue = ""
        deFechaVencimiento.EditValue = Today
        deFechaAcuerdo.Focus()
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_CartaCobro(leTipoCarta, "")
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        Dim msj As String = ""
        If teIdPrestamo.EditValue <= 0 Then
            MsgBox("Debe especificar el Numero de Prestamo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            deFechaAcuerdo.Focus()
            Exit Sub
        End If
        If teAcuerdo.EditValue = "" Then
            MsgBox("Debe especificar el Acuerdo" + Chr(13) + "Imposible Continuar", MsgBoxStyle.Critical, "Error al Guardar")
            teAcuerdo.Focus()
            Exit Sub
        End If

        With entSeguimiento
            .IdPrestamo = teIdPrestamo.EditValue
            .Fecha = deFechaAcuerdo.EditValue
            .TipoCarta = leTipoCarta.EditValue
            .Saldo = teSaldo.EditValue
            .Acuerdos = teAcuerdo.EditValue
            .FechaVencimiento = deFechaVencimiento.EditValue
            .CreadoPor = objMenu.User
            .FHCreacion = Now
        End With
        msj = bl.InsertaSeguimientoCobro(entSeguimiento)
        If msj = "" Then

        Else
            MsgBox("No fue posible actualizar el Seguimiento Fiador" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If
        teAcuerdo.EditValue = ""
        gcMov.DataSource = bl.GetSeguimientoCobros(IdPrestamo)
    End Sub

    Private Sub sbEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbEliminar.Click
        Dim IdSeguimiento As Integer = SiEsNulo(gvMov.GetFocusedRowCellValue("IdSeguimiento"), 0)
        If MsgBox("Está seguro(a) de eliminar el Acuerdo?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj As String = ""
            Try
                objTablas.coo_SeguimientoCobrosDeleteByPK(IdSeguimiento)
            Catch ex As Exception
                msj = ex.Message()
            End Try
            If msj = "" Then
                MsgBox("El Acuerdo ha sido eliminado con éxito", MsgBoxStyle.Information)
                gcMov.DataSource = bl.GetSeguimientoCobros(IdPrestamo)
            Else
                MsgBox("No fue posible eliminar el Acuerdo" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
    End Sub

    Private Sub sbRegresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRegresar.Click
        Close()
    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImprimir.Click
        Dim rpt As New pre_rptImprimeAcuerdo
        rpt.DataSource = bl.rptImprimeAcuerdo(gvMov.GetFocusedRowCellValue("IdSeguimiento"))
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.XrPictureBox1.ImageUrl = dtParam.Rows(0).Item("RutaLogo")
        rpt.ShowPreviewDialog()
    End Sub

End Class