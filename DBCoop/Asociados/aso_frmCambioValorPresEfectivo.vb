Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class aso_frmCambioValorPresEfectivo
    Dim blAsoc As New AsociadosBLL()
    Dim entCambioDescuentos As List(Of coo_AsociadosCambioDescuentos)
    Dim dtAsociados As New DataTable

    Private Sub aso_frmCambioValorPresEfectivo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        teIdAsociado.EditValue = 0
        seTasa.EditValue = 0
    End Sub
    Private Sub teNumAsociado_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teNumAsociado.ButtonClick
        frmConsultaAsociados.ShowDialog()
        teNumAsociado.EditValue = frmConsultaAsociados.NumAsociado
        teIdAsociado.EditValue = frmConsultaAsociados.IdAsociado
        teNumAsociado_Validated(e, New EventArgs)
    End Sub


    Private Sub teNumAsociado_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles teNumAsociado.Validated

        If SiEsNulo(teNumAsociado.EditValue, "") = "" Then
            teIdAsociado.EditValue = 0
            Exit Sub
        End If

        Dim dt As DataTable = blAsoc.DatosGeneralesAsociadoPorNumero(teNumAsociado.EditValue)
        If dt.Rows.Count = 0 Then
            MsgBox("No se encuentra el asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        With dt.Rows(0)
            teIdAsociado.EditValue = .Item("IdAsociado")
            teNombreAsociado.EditValue = .Item("Nombres") + " " + .Item("Apellidos")
        End With
    End Sub

    Private Sub btCambio_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btCambio.Click
        Dim msj As String = ""

        If teNumAsociado.EditValue = "" Then
            teIdAsociado.EditValue = 0
        End If

        If seTasa.EditValue = 0 Then
            MsgBox("Debe de colocar un valor mayor de cero", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        If teMotivo.EditValue = "" Then
            MsgBox("Debe de colocar el motivo de cambio", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de Cambiar estos valores?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            LlenaEntidad()
            blAsoc.CambioPrestamosEfectivo(teIdAsociado.EditValue, seTasa.EditValue, rgOpcion.SelectedIndex, entCambioDescuentos)
            Close()
        End If
    End Sub

    Private Sub LlenaEntidad()
        Dim Rubro As Integer = 0

        If rgOpcion.SelectedIndex = 0 Then
            Rubro = 99
        End If
        If rgOpcion.SelectedIndex = 1 Then
            Rubro = 1
        End If
        If rgOpcion.SelectedIndex = 2 Then
            Rubro = 3
        End If
        If rgOpcion.SelectedIndex = 3 Then
            Rubro = 2
        End If
        entCambioDescuentos = New List(Of coo_AsociadosCambioDescuentos)
        If teIdAsociado.EditValue > 0 Then ' SOLO ES UN ASOCIADO EL QUE SE ESTA CAMBIANDO
            Dim entDetalle As New coo_AsociadosCambioDescuentos
            With entDetalle
                .IdAsociado = teIdAsociado.EditValue
                .IdDetalle = 1
                .Fecha = objFunciones.GetFechaContable(gIdSucursal)
                .FechaHoraCreacion = Now
                .CreadoPor = objMenu.User
                .IdRubro = Rubro
                .Valor = seTasa.EditValue
                .MotivoCambio = teMotivo.EditValue
            End With
            entCambioDescuentos.Add(entDetalle)
        Else
            dtAsociados = objTablas.coo_AsociadosSelectAll

            For i = 0 To dtAsociados.Rows.Count - 1
                If dtAsociados.Rows(0).Item("IdEstado") = 1 Then 'SOLO SE CAMBIAN SI LOS ASOCIADOS SON ACTIVOS 
                    Dim entDetalle As New coo_AsociadosCambioDescuentos
                    With entDetalle
                        .IdAsociado = dtAsociados.Rows(i).Item("IdAsociado")
                        .IdDetalle = i
                        .Fecha = objFunciones.GetFechaContable(gIdSucursal)
                        .FechaHoraCreacion = Now
                        .CreadoPor = objMenu.User
                        .IdRubro = Rubro
                        .Valor = seTasa.EditValue
                        .MotivoCambio = teMotivo.EditValue
                    End With
                    entCambioDescuentos.Add(entDetalle)
                End If
            Next

        End If

    End Sub
End Class
