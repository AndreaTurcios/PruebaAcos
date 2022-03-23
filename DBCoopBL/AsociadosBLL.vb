Imports DBCoopDL
Imports DBCoopEL.TableEntities

Public Class AsociadosBLL
    Dim dl As New AsociadosDLL
    
    Public Function DatosGeneralesAsociadoPorNumero(ByVal NumAsociado As String) As DataTable
        Return dl.DatosGeneralesAsociadoPorNumero(NumAsociado)
    End Function
    Public Function MaxCorrelativoSolEfectivo(ByVal IsssAfp As String) As Integer
        Return dl.MaxCorrelativoSolEfectivo(IsssAfp)
    End Function
    Public Function VerificaAsociado(ByVal IdAsociado As Integer) As String
        Return dl.VerificaAsociado(IdAsociado)
    End Function
    Public Function DatosGeneralesAsociadoPorNumeroBoleta(ByVal NumAsociado As String, ByVal IdAsociado As Integer) As DataTable
        Return dl.DatosGeneralesAsociadoPorNumeroBoleta(NumAsociado, IdAsociado)
    End Function
    Public Function aso_ListadoSaldosAsociados() As DataTable
        Return dl.aso_ListadoSaldosAsociados()
    End Function
    Public Function aso_HistoricoSaldosTelefonia(ByVal IdAsociado As Integer, ByVal NTelefono As String, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.aso_HistoricoSaldosTelefonia(IdAsociado, NTelefono, DesdeFecha, HastaFecha)
    End Function
    Public Function DescuentosAsociados(ByVal IdAsociado As Integer) As DataTable
        Return dl.DescuentosAsociados(IdAsociado)
    End Function
    Public Function ListadoTelefonia(ByVal IdAsociado As Integer) As DataTable
        Return dl.ListadoTelefonia(IdAsociado)
    End Function
    Public Function DatosAsociadoParaConsulta(ByVal Nombre As String, ByVal Apellido As String, ByVal Incluir As Boolean) As DataTable
        Return dl.DatosAsociadoParaConsulta(Nombre, Apellido, Incluir)
    End Function
    Public Function DatosAsociadoParaConsultaReintegro(ByVal Nombre As String, ByVal Apellido As String) As DataTable
        Return dl.DatosAsociadoParaConsultaReintegro(Nombre, Apellido)
    End Function
    Public Function CambioPrestamosEfectivo(ByVal IdAsociado As Integer, ByVal Valor As Decimal _
    , ByVal RubroCambiar As Integer, ByRef entCambioDescuentos As List(Of coo_AsociadosCambioDescuentos)) As String
        Return dl.CambioPrestamosEfectivo(IdAsociado, Valor, RubroCambiar, entCambioDescuentos)
    End Function
    Public Function rptAsociadosGenero(ByVal IdSucursal As Integer, ByVal DesdeFecha As DateTime, ByVal HastaFecha As DateTime) As DataTable
        Return dl.rptAsociadosGenero(IdSucursal, DesdeFecha, HastaFecha)
    End Function

    Public Function rptFolioAsociado(ByVal IdAsociado As Integer) As DataTable
        Return dl.rptFolioAsociado(IdAsociado)
    End Function

    Public Function rptAyudaFuneraria(ByVal IdMovimiento As Integer) As DataTable
        Return dl.rptAyudaFuneraria(IdMovimiento)
    End Function

End Class
