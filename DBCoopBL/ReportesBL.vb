Imports DBCoopDL
Public Class ReportesBL
    ReadOnly dl As New ReportesDL()
    Public Function InformeGerencial1(ByVal IdSucursal As Integer, ByVal Hasta As Date) As DataTable
        Return dl.InformeGerencial1(IdSucursal, Hasta)
    End Function

    Public Function rptAnalisisDepositosPlazo(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return dl.rptAnalisisDepositosPlazo(IdSucursal, Desde, Hasta)
    End Function

    Public Function rptReporteLiquidez(ByVal IdSucursal As Integer, ByVal Mes As Integer, ByVal Anio As Integer) As DataTable
        Return dl.rptReporteLiquidez(IdSucursal, Mes, Anio)
    End Function
    Public Function rptReporteInteresesAnualesSocio(ByVal Anio As Integer) As DataTable
        Return dl.rptReporteInteresesAnualesSocio(Anio)
    End Function
End Class
