Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class pre_frmVerFirmasAsociado
    Dim _IdAsociado As Integer = 0
    Dim entAsociado As coo_Asociados
    Dim myBL As New CajaBusiness


    Public Property IdAsociado() As Integer
        Get
            Return _IdAsociado
        End Get
        Set(ByVal value As Integer)
            _IdAsociado = value
        End Set
    End Property

    Private Sub CargaImagenFirma1(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peFirma1.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peFirma1.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peFirma1.Image = bm
        End If
    End Sub

    Private Sub CargaImagenFirma2(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peFirma2.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peFirma2.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peFirma2.Image = bm
        End If
    End Sub

    Private Sub CargaImagenFirma3(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peFirma3.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peFirma3.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peFirma3.Image = bm
        End If
    End Sub

    Private Sub pre_frmVerDocumentosAsociado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles(0)
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entAsociado = objTablas.coo_AsociadosSelectByPK(IdAsociado)
        Dim dt As DataTable = myBL.ObtieneParametros
        CargaImagenFirma1(dt.Rows(0).Item("RutaImagenes") & "\Firma1-" & LTrim(entAsociado.Numero))
        CargaImagenFirma2(dt.Rows(0).Item("RutaImagenes") & "\Firma2-" & LTrim(entAsociado.Numero))
        CargaImagenFirma3(dt.Rows(0).Item("RutaImagenes") & "\firma3-" & LTrim(entAsociado.Numero))
    End Sub
End Class