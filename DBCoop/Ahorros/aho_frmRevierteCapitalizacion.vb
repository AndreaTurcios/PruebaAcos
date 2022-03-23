Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Public Class aho_frmRevierteCapitalizacion
    Dim blAhorro As New DBCoopBL.AhorrosBLL()
    Dim blCaja As New DBCoopBL.TableBusiness()
    Dim funCaja As New DBCoopBL.FuncionesBLL()
    Dim cn As New DBCoopBL.AdmonBLL()

    Private Sub aho_frmRevierteCapitalizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim entCierre As coo_CierresAhorro = blAhorro.coo_UltCierreAhorroSelectBy()
        If entCierre.FechaHoraCreacion = Nothing Then
            SpinEdit1.Value = piPeriodo
            MonthEdit1.Month = piMesCerrado
            cmdReport.Visible = False
        Else
            SpinEdit1.Value = entCierre.ejercicio
            MonthEdit1.Month = entCierre.mes
            cmdReport.Visible = False
        End If
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dFechaContable As New Date
        If blAhorro.ValidaCapitalizacion(SpinEdit1.EditValue, MonthEdit1.EditValue) > 0 Then
            MsgBox("No es Posible revertir la Capitalizacion, Ya se ingresaron movimientos despues de la Capitalizacion", MsgBoxStyle.Critical)
            Return
        End If
        dFechaContable = funCaja.GetFechaContable(gIdSucursal)
        If dFechaContable > Today Then
            MsgBox("No es posible revertir la Capitalizacion, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error Reversion")
            Return
        End If

        If MsgBox("Está seguro(a) de realizar la Reversion de la Capitalizacion de Ahorro?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        If blAhorro.RevierteCapitalizacion(SpinEdit1.EditValue, MonthEdit1.EditValue) > 0 Then
            MsgBox("No fue Posible revertir la Capitalizacion", MsgBoxStyle.Critical)
            Return
        End If

        Me.Close()
    End Sub
End Class
