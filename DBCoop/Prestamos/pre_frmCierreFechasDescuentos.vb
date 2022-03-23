Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Public Class pre_frmCierreFechasDescuentos
    Dim bl As New PrestamosBLL()
    Dim entFechas As coo_FechasDescuentos


    Private Sub beNumeroCuenta_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beFechaDescuento.ButtonClick
        teIdComprobante.EditValue = SiEsNulo(objConsultas.ConsultaFechasDescuentos(frmConsultas), 0)
        beFechaDescuento_Validated(e, New EventArgs)
    End Sub

    Private Sub beFechaDescuento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beFechaDescuento.Validated
        If teIdComprobante.EditValue = 0 Then
            teIdComprobante.EditValue = 0
            Exit Sub
        End If

        entFechas = objTablas.coo_FechasDescuentosSelectByPK(teIdComprobante.EditValue)
        beFechaDescuento.EditValue = entFechas.FechaDescuento
        ' teIdComprobante.EditValue = bl.ObtenerFechaDescuento(beFechaDescuento.EditValue)

        If teIdComprobante.EditValue = 0 Then
            MsgBox("No existe la fecha de descuento", MsgBoxStyle.Exclamation, "Nota")
            beFechaDescuento.EditValue = Nothing
            beFechaDescuento.Focus()
            Exit Sub
        End If
        cmdCerrar.Enabled = True
    End Sub

    Private Sub cmdCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCerrar.Click

        If MsgBox("Está seguro(a) de cerrar la fecha de descuento?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            Exit Sub
        End If

        If teIdComprobante.EditValue = 0 Then
            MsgBox("No existe la fecha de descuento", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        If entFechas.Activo = 0 Then
            MsgBox("La fecha de descuento ya se encuentra cerrada", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Try
            bl.CierreFechaDescuento(teIdComprobante.EditValue, objMenu.User, Now)
            MsgBox("El documento ha sido elminado con éxito", MsgBoxStyle.Information, "Nota")
        Catch ex As Exception

            MsgBox("No fue posible cerrar la fecha de descuento" + Chr(13) + ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        beFechaDescuento.EditValue = Nothing
        teIdComprobante.EditValue = 0
        cmdCerrar.Enabled = False
        beFechaDescuento.Focus()

    End Sub

    Private Sub pre_frmCierreFechasDescuentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        teIdComprobante.EditValue = 0
    End Sub


End Class
