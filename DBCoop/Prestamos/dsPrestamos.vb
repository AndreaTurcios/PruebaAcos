Partial Class dsPrestamos
    Partial Public Class InformeAseguradoraDataTable
        Private Sub InformeAseguradoraDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.NombreCompletoColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub InformeAseguradoraDataTable_InformeAseguradoraRowChanging(sender As Object, e As InformeAseguradoraRowChangeEvent) Handles Me.InformeAseguradoraRowChanging

        End Sub

    End Class

    Partial Class DescuentosAplicarPlanillDataTable

        Private Sub DescuentosAplicarPlanillDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging


        End Sub

    End Class

End Class
