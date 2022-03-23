Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Data.Common
Imports DBCoopEL.TableEntities
Public Class IndicadoresDLL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Dim fd As New FuncionesDLL
    Dim objTabla As New TableData

    Public Function GetParametrosIndicador(ByVal IdParametro As String, ByVal Anio As Integer) As DataTable
        Return db.ExecuteDataSet("col_spGetParametrosIndicador", IdParametro, Anio).Tables(0)
    End Function

    Public Function PenetracionMercado(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spPenetracionMercado", Anio, Mes).Tables(0)
    End Function

    Public Function PrestamosPorCliente(ByVal Anio As Integer, ByVal mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spPrestamosPorCliente", Anio, mes).Tables(0)
    End Function

    Public Function AhorrosPorAsociado(ByVal Anio As Integer, ByVal mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spAhorrosPorAsociado", Anio, mes).Tables(0)
    End Function

    Public Function AportacionesPorAsociado(ByVal Anio As Integer, ByVal mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spAportacionesPorAsociado", Anio, mes).Tables(0)
    End Function


    Public Function ActivosPorAsociado(ByVal Anio As Integer, ByVal mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spActivosPorAsociado", Anio, mes).Tables(0)
    End Function


    Public Function rptComparativoAnualColac(ByVal Anio As Integer, ByVal IdVariable As Integer) As DataTable
        Return db.ExecuteDataSet("col_spComparativoAnualColac", Anio, IdVariable).Tables(0)
    End Function

    Public Function MorosidadCartera(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spMorosidadCartera", Anio, Mes).Tables(0)
    End Function

    Public Function ParticipacionCartera(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spParticipacionCartera", Anio, Mes).Tables(0)
    End Function

    Public Function CrecimientoActivos(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spCrecimientoActivos", Anio, Mes).Tables(0)
    End Function

    Public Function ActivosPorEmpleado(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spActivosPorEmpleado", Anio, Mes).Tables(0)
    End Function

    Public Function CrecimientoPrestamos(ByVal Anio As String, ByVal Mes As Integer) As Decimal
        Return db.ExecuteScalar("col_spCrecimientoPrestamos", Anio, Mes)
    End Function

    Public Function CrecimientoAhorros(ByVal Anio As String, ByVal Mes As Integer) As Decimal
        Return db.ExecuteScalar("col_spCrecimientoAhorros", Anio, Mes)
    End Function

    Public Function CrecimientoClientesActivo(ByVal Anio As String, ByVal Mes As Integer) As Decimal
        Return db.ExecuteScalar("col_spCrecimientoClientesActivo", Anio, Mes)
    End Function

    Public Function CrecimientoNivelPublicidad(ByVal Anio As String, ByVal Mes As Integer) As Decimal
        Return db.ExecuteScalar("col_spCrecimientoNivelPublicidad", Anio, Mes)
    End Function

    Public Function CrecimientoPatrimonio(ByVal Anio As String, ByVal Mes As Integer) As Decimal
        Return db.ExecuteScalar("col_spCrecimientoPatrimonio", Anio, Mes)
    End Function

    Public Function IngresosPorEmpleado(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spIngresosPorEmpleado", Anio, Mes).Tables(0)
    End Function


    Public Function ProvisionCuentasMalas(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spProvisionCuentasMalas", Anio, Mes).Tables(0)
    End Function

    Public Function ProvisionCuentasMalas90(ByVal Anio As String, ByVal Mes As Integer) As DataTable
        Return db.ExecuteDataSet("col_spProvisionCuentasMalas90", Anio, Mes).Tables(0)
    End Function


    Public Function rptIndicador(ByVal IdFormula As Integer, ByVal mes As Integer, ByVal Anio As Integer, ByVal Tipo As Integer) As Decimal
        Return db.ExecuteScalar("col_spIndicador", IdFormula, mes, Anio, Tipo)
    End Function

    Public Function InsertaParametrosIndicadores _
(ByRef entParametrosDetalle As List(Of col_ParametrosDetalle), ByVal Anio As Integer, ByVal IdParametro As String) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()

        Try
            Dim sSQL As String = "delete col_ParametrosDetalle where Anio=" & Anio & " AND IdParametro='" & IdParametro & "'"
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As col_ParametrosDetalle In entParametrosDetalle
                objTabla.col_ParametrosDetalleInsert(detalle, tran)
            Next
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function


    Public Function InsertaCalculoColac(ByRef entColac As List(Of col_Colac), ByVal Anio As Integer, ByVal mes As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Dim msj As String = ""
        Try
            Dim sSQL As String = "delete col_colac where Anio=" & Anio & " AND mes='" & mes & "'"
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As col_Colac In entColac
                objTabla.col_ColacInsert(detalle, tran)
            Next
            tran.Commit()
        Catch ex As Exception
            tran.Rollback()
            msj = ex.Message()
        Finally
            cn.Close()
        End Try

        Return msj

    End Function



    Public Function Get_FormulasFinancieras(ByVal IdFormula As Integer) As DataTable
        Dim sSQL As String = "select * from col_FormulasFinancieras "
        If IdFormula = -999 Then
            sSQL &= "where 1=2"
        Else
            sSQL &= "where IdFormula=" & IdFormula & " ORDER BY IdFormula,Id "
        End If
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function Get_CuentasIndicadores() As DataTable
        Dim sSQL As String = "select * from col_CuentasIndicadores "
        Return db.ExecuteDataSet(CommandType.Text, sSQL).Tables(0)
    End Function

    Public Function InsertaFormulaFinanciera _
(ByRef entFormulaFinanciera As List(Of col_FormulasFinancieras), ByVal IdFormula As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            Dim Id As Integer

            Id = fd.ObtenerUltimoId("Col_FormulasFinancieras", "Id") + 1

            Dim sSQL As String = "delete col_FormulasFinancieras where IdFormula=" & IdFormula
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

            For Each detalle As col_FormulasFinancieras In entFormulaFinanciera
                detalle.Id = Id
                objTabla.col_FormulasFinancierasInsert(detalle, tran)
                Id = Id + 1
            Next
        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""

    End Function

    Public Function EliminaFormulaFinanciera _
(ByVal IdFormula As Integer) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            Dim sSQL As String = "delete col_FormulasFinancieras where IdFormula=" & IdFormula
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function

    Public Function ActualizaCuentaIndicador _
(ByVal IdCuenta As String, ByVal Cuenta As String) As String
        Dim cn As DbConnection = db.CreateConnection
        cn.Open()
        Dim tran As DbTransaction = cn.BeginTransaction()
        Try
            Dim sSQL As String = "update col_CuentasIndicadores set " & Cuenta & "='" & IdCuenta & "'"
            db.ExecuteNonQuery(tran, CommandType.Text, sSQL)

        Catch ex As Exception
            tran.Rollback()
            Return ex.Message()
        End Try

        tran.Commit()
        cn.Close()
        Return ""
    End Function
End Class
