Public Class aso_frmAutoriza

    Private Sub sbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancel.Click
        Me.Close()
    End Sub

    Private Sub aso_frmAutoriza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tePass.Focus()
    End Sub
End Class