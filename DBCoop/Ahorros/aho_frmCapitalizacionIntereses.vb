Imports DBCoopBL
Imports DBCoopEL.TableEntities


Public Class aho_frmCapitalizacionIntereses
    Dim blAhorro As New AhorrosBLL()
    

    Private Sub aho_frmCapitalizacionIntereses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim entCierre As coo_CierresAhorro = blAhorro.coo_UltCierreAhorroSelectBy()
        deDesde.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        deFechaUltCap.EditValue = entCierre.HastaCierre

        If entCierre.FechaHoraCreacion = Nothing Then
            'SpinEdit1.Value = piPeriodo
            'MonthEdit1.Month = piMesCerrado + 1
            'If piMesCerrado = 12 Then
            '    MonthEdit1.Month = 1
            '    SpinEdit1.Value = piPeriodo + 1
            'End If
            deDesde.EditValue = CDate("31" + "/" + "12" + "/" + (piPeriodo + 1).ToString)

            cmdReport.Visible = False
        Else
            'SpinEdit1.Value = entCierre.ejercicio
            'MonthEdit1.Month = entCierre.mes + 12 '3 lo cambie porque en acelca cad 12 meses capitalizan

            'If entCierre.mes = 12 Then
            '    MonthEdit1.Month = 12 '3 lo cambie porque en acelca cad 12 meses capitalizan
            '    SpinEdit1.Value = entCierre.ejercicio + 1
            'End If

            Dim cFec As Date = entCierre.HastaCierre
            deHasta.EditValue = DateAdd(DateInterval.Month, 12, cFec) ' le sumo 12 meses desde la ultima capitalizacion
            cmdReport.Visible = False
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SimpleButton1.Click

        Dim msj As String
        'Dim Fecha As String = "01/" + MonthEdit1.EditValue.ToString.PadLeft(2, "0") + "/" + SpinEdit1.EditValue.ToString.PadLeft(4, "0")
        'Dim Fec As Date = CDate(Fecha)
        'Fec = DateAdd(DateInterval.Month, 1, Fec)
        'Fec = DateAdd(DateInterval.Day, -1, Fec)
        'Fecha = Format(Fec, "yyyyMMdd")

        Dim Periodo As String = String.Format("IN-{0}{1}/", Month(deDesde.EditValue).ToString.PadLeft(2, "0"), Year(deDesde.EditValue).ToString.PadLeft(4, "0"))
        If blAhorro.ExisteCapitalizacionAhorro(deDesde.EditValue, Periodo) > 0 Then
            MsgBox("Ya existe una capitalización de intereses en esta fecha", MsgBoxStyle.Critical)
            Return
        End If

        If deDesde.EditValue <= deFechaUltCap.EditValue Then
            MsgBox("La capitalización debe ser mayor a la ultima fecha capitalizada", MsgBoxStyle.Critical)
            Return
        End If

        If deDesde.EditValue > deHasta.EditValue Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final de capitalización", MsgBoxStyle.Critical)
            Return
        End If


        If MsgBox("Está seguro(a) de realizar la capitalización?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        'Dim dFechaInicial As Date, dFechaFinal As Date
        'dFechaInicial = CDate(CStr(SpinEdit1.EditValue) & "/" & (MonthEdit1.EditValue - 2).ToString.PadLeft(2, "0") & "/01")
        'dFechaFinal = CDate(CStr(SpinEdit1.EditValue) & "/" & (MonthEdit1.EditValue).ToString.PadLeft(2, "0") & "/01")
        'dFechaFinal = DateAdd(DateInterval.Month, 1, dFechaFinal)
        'dFechaFinal = DateAdd(DateInterval.Day, -1, dFechaFinal)

        msj = blAhorro.CapitalizacionAhorro(deDesde.EditValue, deHasta.EditValue, Year(deHasta.EditValue), Month(deHasta.EditValue), objMenu.User)
        If msj = "" Then
            MsgBox("Capitalización realizada con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("No fue posible realizar la capitalización" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If

        Me.Close()
    End Sub

End Class
