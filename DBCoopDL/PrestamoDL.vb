Imports Microsoft.Practices.EnterpriseLibrary.Data
Public Class PrestamoDL
    Dim db As Database = DatabaseFactory.CreateDatabase()

    Public Function GetCuotasAportes(ByVal IdPrestamo As Integer, ByVal NroCuota As Integer, ByVal Fecha As Date) As DataTable
        Return db.ExecuteDataSet("coo_spGetCuotasAportes", IdPrestamo, NroCuota, Fecha).Tables(0)
    End Function

    Public Function GetDiasMora(ByVal IdPrestamo As Integer, ByVal HastaFecha As DateTime) As Integer
        Dim DiasMora As Integer = db.ExecuteScalar("coo_spDiasMora", IdPrestamo, HastaFecha)
        Return DiasMora
    End Function

    Public Function GetUltMovPrestamo(ByVal IdPrestamo As Integer) As Integer
        Dim IdMov As Integer = db.ExecuteScalar("coo_spGetUlMovPrestamo", IdPrestamo)
        Return IdMov
    End Function
End Class
