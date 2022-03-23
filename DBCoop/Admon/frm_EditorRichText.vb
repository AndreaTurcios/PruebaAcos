Imports DevExpress.XtraRichEdit
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class frm_EditorRichText
    Dim bl As New TableBusiness()
    Dim _NombreArchivoRTF As String

    Property NombreArchivoRTF() As String
        Get
            Return _NombreArchivoRTF
        End Get
        Set(ByVal value As String)
            _NombreArchivoRTF = value
        End Set
    End Property


    Private Sub frm_EditorRichText_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim entDocumentos As New coo_Documentos
        entDocumentos = bl.coo_DocumentosSelectByPK(_NombreArchivoRTF)
        Me.RichEditControl1.RtfText = entDocumentos.Contenido
    End Sub

    Private Sub GrabarItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles GrabarItem.ItemClick
        Dim RutaYArchivo As String = System.IO.Path.GetTempPath + _NombreArchivoRTF + ".rtf"
        If _NombreArchivoRTF = "" Then ''Cuando se abre un archivo o se graba un archivo nuevo que no está grabado en la base de datos.
            Dim AbrirArchivo As String
            AbrirArchivo = Me.RichEditControl1.Options.DocumentSaveOptions.CurrentFileName.Substring(Me.RichEditControl1.Options.DocumentSaveOptions.CurrentFileName.LastIndexOf("\") + 1) ''Ubicación y nombre del archivo que se abrió. De esto solo obtengo el nombre
            _NombreArchivoRTF = AbrirArchivo.Substring(0, AbrirArchivo.LastIndexOf("."))
            RutaYArchivo = System.IO.Path.GetTempPath + _NombreArchivoRTF + ".rtf"
            Me.Text += " - ( " + _NombreArchivoRTF + " )"
        End If

        
        Me.RichEditControl1.SaveDocument(RutaYArchivo, DocumentFormat.Rtf)
        bl.coo_DocumentosDeleteByPK(_NombreArchivoRTF)
        Dim textoRTF As String = RetornaRtf(RutaYArchivo)
        Dim entDocumentos As New coo_Documentos
        entDocumentos.Documento = _NombreArchivoRTF
        entDocumentos.Contenido = textoRTF
        bl.coo_DocumentosInsert(entDocumentos)
    End Sub

    Private Sub FileOpenItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles FileOpenItem1.ItemClick
        ''Se limpia el nombre de archivo, pues en estos momentos 
        ''se está abriendo una archivo, que no es de la base de datos, 
        ''sino de fuentes externas
        _NombreArchivoRTF = ""
        Me.Text = "Editor de Plantillas"
    End Sub

    
    Private Sub RichEditControl1_DocumentLoaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichEditControl1.DocumentLoaded
        If _NombreArchivoRTF = "" Then ''Cuando se abre un archivo que no está grabado en la base de datos.
            Dim AbrirArchivo As String
            AbrirArchivo = Me.RichEditControl1.Options.DocumentSaveOptions.CurrentFileName.Substring(Me.RichEditControl1.Options.DocumentSaveOptions.CurrentFileName.LastIndexOf("\") + 1) ''Ubicación y nombre del archivo que se abrió. De esto solo obtengo el nombre
            Me.Text += " - ( " + AbrirArchivo.Substring(0, AbrirArchivo.LastIndexOf(".")) + " )"
        End If
    End Sub

    Private Sub FileNewItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles FileNewItem1.ItemClick
        ''Se limpia el nombre de archivo, pues en estos momentos 
        ''se está creando uno nuevo, que no es de la base de datos, 
        _NombreArchivoRTF = ""
        Me.Text = "Editor de Plantillas"
    End Sub
End Class