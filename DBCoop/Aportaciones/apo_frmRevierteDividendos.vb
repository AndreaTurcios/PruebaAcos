Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Public Class apo_frmRevierteDividendos


    Dim blApor As New DBCoopBL.AportacionesBLL()
    Dim blCaja As New DBCoopBL.TableBusiness()
    Dim funCaja As New DBCoopBL.FuncionesBLL()
    Dim cn As New DBCoopBL.AdmonBLL()

    Private Sub aho_frmRevierteCapitalizacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        SpinEdit1.Value = Year(Today)

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        'Dim dFechaContable As New Date

        'dFechaContable = funCaja.GetFechaContable(gIdSucursal)
        'If dFechaContable > Today Then
        '    MsgBox("No es posible revertir la Capitalizacion, El periodo ya esta cerrado", MsgBoxStyle.Critical, "Error Reversion")
        '    Return
        'End If

        If MsgBox("Está seguro(a) de realizar la Reversion de los Dividendos?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Return
        End If

        If blApor.RevierteDividendos(SpinEdit1.EditValue) > 0 Then
            MsgBox("No fue Posible revertir los Dividendos", MsgBoxStyle.Critical)
            Return
        End If

        Me.Close()
    End Sub
End Class
