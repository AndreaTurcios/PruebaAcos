Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class ReportesDL
    Dim db As Database = DatabaseFactory.CreateDatabase()
    Public Function InformeGerencial1(ByVal IdSucursal As Integer, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptInformeGerencial1", IdSucursal, Hasta).Tables(0)
    End Function
    Public Function rptAnalisisDepositosPlazo(ByVal IdSucursal As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
        Return db.ExecuteDataSet("coo_spRptAnalisisDepositosPlazo", IdSucursal, Desde, Hasta).Tables(0)
    End Function

    Public Function rptReporteLiquidez(ByVal IdSucursal As Integer, ByVal Mes As Integer, ByVal Anio As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spRptLiquidez", IdSucursal, Mes, Anio).Tables(0)
    End Function
    Public Function rptReporteInteresesAnualesSocio(ByVal Anio As Integer) As DataTable
        Return db.ExecuteDataSet("coo_spListadoGeneralInteresesPagos", Anio).Tables(0)
    End Function
End Class
