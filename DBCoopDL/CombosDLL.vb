Imports Microsoft.Practices.EnterpriseLibrary.Data


Public Class CombosDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()


    Public Sub CargaCombo(ByRef Combo As Object _
                       , ByVal Tabla As String, ByVal ValueMember As String, ByVal DisplayMember As String _
                      , ByVal Condicion As String, Optional ByVal TipoSQL As String = "")

        Dim sql As String = ""

        If Condicion <> "" Then
            Condicion = " where " & Condicion   'no incluir el and en la condicion en la primer condicion del where
        End If
        If TipoSQL <> "" Then
            sql = "select -1 Id, '" & TipoSQL & "' " & DisplayMember & " union all "
        End If
        sql &= String.Format("select {0} Id,{1} from {2} {3} order by Id", ValueMember, DisplayMember, Tabla, Condicion)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sql).Tables(0)

        With Combo.Properties
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
            .datasource = dl
        End With
        Try
            Combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargaComboCaracter(ByRef Combo As Object _
                   , ByVal Tabla As String, ByVal ValueMember As String, ByVal DisplayMember As String _
                  , ByVal Condicion As String, Optional ByVal TipoSQL As String = "")

        Dim sql As String = ""

        If Condicion <> "" Then
            Condicion = " where " & Condicion   'no incluir el and en la condicion en la primer condicion del where
        End If
        If TipoSQL <> "" Then
            sql = "select '' Id, '" & TipoSQL & "' " & DisplayMember & " union all "
        End If
        sql &= String.Format("select {0} Id,{1} from {2} {3} order by Id", ValueMember, DisplayMember, Tabla, Condicion)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sql).Tables(0)

        With Combo.Properties
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
            .datasource = dl
        End With
        Try
            Combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargaComboFiador(ByRef Combo As Object _
                    , ByVal Tabla As String, ByVal ValueMember As String, ByVal DisplayMember As String _
                   , ByVal Condicion As String, Optional ByVal TipoSQL As String = "")

        Dim sql As String = ""

        If Condicion <> "" Then
            Condicion = " where " & Condicion   'no incluir el and en la condicion en la primer condicion del where
        End If
        If TipoSQL <> "" Then
            sql = "select -1 Id, '" & TipoSQL & "' " & DisplayMember & " union all "
        End If
        sql &= String.Format("select {0} Id,{1} from {2} {3} order by Id", ValueMember, DisplayMember, Tabla, Condicion)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sql).Tables(0)

        With Combo.Properties
            .DisplayMember = "NombresApellidos"
            .ValueMember = "Id"
            .datasource = dl
        End With
        Try
            Combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub

    Public Sub CargaLookUpEdit(ByRef combo As Object _
                       , ByVal Tabla As String _
                      , ByVal ValueMember As String _
                      , ByVal DisplayMember As String _
                      , ByVal sCondic As String _
                      , Optional ByVal sTipoSelect As String = "")

        Dim sSQL As String = ""
        If sCondic <> "" Then
            sCondic = " where " & sCondic   'no incluir el and en la condicion en la primer condicion del where
        End If
        If sTipoSelect <> "" Then
            sSQL = String.Format("select top 1 ' ' {0}, '{1}' {2} from {3} union all ", ValueMember, sTipoSelect, DisplayMember, Tabla)
        End If
        sSQL &= String.Format("select {0},{1} from {2} {3} order by {0}", ValueMember, DisplayMember, Tabla, sCondic)
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)

        With combo.Properties
            .DisplayMember = "Nombre"
            .ValueMember = ValueMember
            .datasource = dl
        End With
        Try
            combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub
    Public Sub ComboReferencia(ByRef combo As Object, ByVal Mes As Integer, ByVal Periodo As Integer)
        Dim sSQL As String = ""

        sSQL &= String.Format("SELECT Id=Numero,Nombre=Numero+' '+Convert(VARCHAR(12),FEcha,103) FROM coo_PrestamosDetalle WHERE month(Fecha)=" & Mes & " and Year(fecha)=" & Periodo & " and TipoAplicacion=1   GROUP BY Numero,FEcha ORDER BY FEcha")
        Dim dl As DataTable = db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)

        With combo.Properties
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
            .datasource = dl
        End With
        Try
            combo.ItemIndex = 0
        Catch ex As Exception

        End Try

    End Sub
End Class
