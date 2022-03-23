Imports DBCoopDL
Imports DBCoopEL.TableEntities
Public Class IndicadoresBLL
    ReadOnly dl As New IndicadoresDLL()

    Public Function GetParametrosIndicador(ByVal IdParametro As String, ByVal Anio As Integer) As DataTable
        Return dl.GetParametrosIndicador(IdParametro, Anio)
    End Function

    Public Function PenetracionMercado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.PenetracionMercado(Anio, Mes)
    End Function

    Public Function rptComparativoAnualColac(ByVal Anio As Integer, ByVal IdVariable As Integer) As DataTable
        Return dl.rptComparativoAnualColac(Anio, IdVariable)
    End Function

    Public Function PrestamosPorCliente(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.PrestamosPorCliente(Anio, Mes)
    End Function

    Public Function AhorrosPorAsociado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.AhorrosPorAsociado(Anio, Mes)
    End Function


    Public Function AportacionesPorAsociado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.AportacionesPorAsociado(Anio, Mes)
    End Function


    Public Function ActivosPorAsociado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.ActivosPorAsociado(Anio, Mes)
    End Function

    Public Function MorosidadCartera(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.MorosidadCartera(Anio, Mes)
    End Function


    Public Function ParticipacionCartera(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.ParticipacionCartera(Anio, Mes)
    End Function

    Public Function ActivosPorEmpleado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.ActivosPorEmpleado(Anio, Mes)
    End Function

    Public Function CrecimientoPrestamos(ByVal Anio As Integer, ByVal Mes As Integer) As Decimal
        Return dl.CrecimientoPrestamos(Anio, Mes)
    End Function

    Public Function CrecimientoAhorros(ByVal Anio As Integer, ByVal Mes As Integer) As Decimal
        Return dl.CrecimientoAhorros(Anio, Mes)
    End Function

    Public Function CrecimientoClientesActivo(ByVal Anio As Integer, ByVal Mes As Integer) As Decimal
        Return dl.CrecimientoClientesActivo(Anio, Mes)
    End Function

    Public Function CrecimientoNivelPublicidad(ByVal Anio As Integer, ByVal Mes As Integer) As Decimal
        Return dl.CrecimientoNivelPublicidad(Anio, Mes)
    End Function

    Public Function CrecimientoPratrimonio(ByVal Anio As Integer, ByVal Mes As Integer) As Decimal
        Return dl.CrecimientoPatrimonio(Anio, Mes)
    End Function

    Public Function CrecimientoActivos(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.CrecimientoActivos(Anio, Mes)
    End Function

    Public Function IngresosPorEmpleado(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.IngresosPorEmpleado(Anio, Mes)
    End Function

    Public Function ProvisionCuentasMalas(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.ProvisionCuentasMalas(Anio, Mes)
    End Function

    Public Function ProvisionCuentasMalas90(ByVal Anio As Integer, ByVal Mes As Integer) As DataTable
        Return dl.ProvisionCuentasMalas90(Anio, Mes)
    End Function


    Public Function rptIndicador(ByVal IdFormula As Integer, ByVal Mes As Integer, ByVal Anio As Integer, ByVal Tipo As Integer) As Decimal
        Return dl.rptIndicador(IdFormula, Mes, Anio, Tipo)
    End Function

    Public Function Get_CuentasIndicadores() As DataTable
        Return dl.Get_CuentasIndicadores()
    End Function

    Public Function Get_FormulasFinancieras(ByVal IdFormula As Integer) As DataTable
        Return dl.Get_FormulasFinancieras(IdFormula)
    End Function


    Public Function InsertaFormulaFinanciera(ByRef entFormula As List(Of col_FormulasFinancieras) _
, ByVal IdFormula As Integer) As String
        Return dl.InsertaFormulaFinanciera(entFormula, IdFormula)
    End Function

    Public Function EliminaFormulaFinanciera(ByVal IdFormula As Integer) As String
        Return dl.EliminaFormulaFinanciera(IdFormula)
    End Function

    Public Function ActualizaCuentaIndicador(ByVal IdCuenta As String, ByVal Cuenta As String) As String
        Return dl.ActualizaCuentaIndicador(IdCuenta, Cuenta)
    End Function


    Public Function InsertaParametrosIndicadores(ByRef entDetalleParametros As List(Of col_ParametrosDetalle) _
, ByVal Anio As Integer, ByVal Variable As String) As String
        Return dl.InsertaParametrosIndicadores(entDetalleParametros, Anio, Variable)
    End Function

    Public Function InsertaCalculoColac(ByRef entColac As List(Of col_Colac) _
, ByVal Anio As Integer, ByVal mes As Integer) As String
        Return dl.InsertaCalculoColac(entColac, Anio, mes)
    End Function

End Class
