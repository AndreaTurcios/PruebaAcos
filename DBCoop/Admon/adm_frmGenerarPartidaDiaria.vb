Imports DBCoopBL
Public Class adm_frmGenerarPartidaDiaria
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()

    Private Sub adm_frmCierreDia_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        objCombos.adm_Sucursales(leSucursal, "")
        leSucursal.EditValue = gIdSucursal
        leSucursal.Properties.ReadOnly = True
        deDesde.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deHasta.EditValue = objFunciones.GetFechaContable(gIdSucursal)
    End Sub
    Private Sub btProceder_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btProceder.Click
        If deDesde.DateTime.Month <> deHasta.DateTime.Month Then
            MsgBox("Los meses deben ser iguales", MsgBoxStyle.Exclamation, "Nota")
            Return
        End If

        Dim EsOk As Boolean = ValidarFechaCierre(deDesde.EditValue)
        If Not EsOk Then
            MsgBox("La fecha inicial está fuera del período permitido", MsgBoxStyle.Information, "Nota")
            Exit Sub
        End If

        If MsgBox("Está seguro(a) de generar la partida contable?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            Dim msj2 As String = ""
            Dim desde As Date = deDesde.EditValue

            While desde <= deHasta.EditValue
                Dim Fecha As String = desde.Day.ToString.PadLeft(2, "0") + "/" + desde.Month.ToString.PadLeft(2, "0") + "/" + desde.Year.ToString.PadLeft(2, "0000") '  MonthEdit1.EditValue.ToString.PadLeft(2, "0") + "/" + SpinEdit1.EditValue.ToString.PadLeft(4, "0")
                Dim Fec As Date = CDate(Fecha)
                msj2 += blPres.adm_GenerarPartidasDiarias(leSucursal.EditValue, Fec, objMenu.User, 0)
                If msj2 = "Ok" Then
                    msj2 = ""
                End If
                desde = DateAdd(DateInterval.Day, 1, desde)
            End While

            If msj2 = "" Then
                MsgBox("La Partida  ha sido generada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar los Descuentos{0}{1}", Chr(13), msj2), MsgBoxStyle.Critical)
                Return
            End If
        End If
    End Sub
End Class
