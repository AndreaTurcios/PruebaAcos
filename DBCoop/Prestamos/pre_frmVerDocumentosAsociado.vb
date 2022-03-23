Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class pre_frmVerDocumentosAsociado
    Dim _IdAsociado As Integer = 0
    Dim entAsociado As coo_Asociados
    Dim myBL As New AdmonBLL()
    

    Public Property IdAsociado() As Integer
        Get
            Return _IdAsociado
        End Get
        Set(ByVal value As Integer)
            _IdAsociado = value
        End Set
    End Property

    Private Sub CargaImagenDui(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peDui.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peDui.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peDui.Image = bm
        End If
    End Sub

    Private Sub CargaImagenNit(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peNit.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peNit.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peNit.Image = bm
        End If
    End Sub

    Private Sub CargaImagenFirma(ByVal FileName As String)
        Dim FileNameTMP As String
        FileNameTMP = FileName & ".jpg"
        If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
            FileNameTMP = FileName & ".bmp"
            If Not FileIO.FileSystem.FileExists(FileNameTMP) Or FileNameTMP = "" Then
                peFirma.Image = Nothing
            Else
                Dim bm As New Bitmap(FileNameTMP)
                peFirma.Image = bm
            End If
        Else
            Dim bm As New Bitmap(FileNameTMP)
            peFirma.Image = bm
        End If
    End Sub

    Private Sub pre_frmVerDocumentosAsociado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargaControles(0)
    End Sub

    Private Sub CargaControles(ByVal TipoAvance As Integer)
        entAsociado = objTablas.coo_AsociadosSelectByPK(IdAsociado)
        Dim dt As DataTable = myBL.ObtieneParametros

        CargaImagenDui(dt.Rows(0).Item("RutaImagenes") & "\Dui-" & LTrim(entAsociado.Numero))
        CargaImagenNit(dt.Rows(0).Item("RutaImagenes") & "\Nit-" & LTrim(entAsociado.Numero))
        CargaImagenFirma(dt.Rows(0).Item("RutaImagenes") & "\Firma-" & LTrim(entAsociado.Numero))
    End Sub
End Class