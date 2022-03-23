Imports DevExpress.XtraReports.UI
Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop
Imports System
Imports System.Data
Imports System.Data.OleDb
Imports DBCoopBL
Imports System.Text
Imports System.Net.Mail

Module ModuleMain
    Public objMenu As DBCoopBL.MenusBLL
    Public objTablas As DBCoopBL.TableBusiness
    Public objFunciones As DBCoopBL.FuncionesBLL
    Public objCombos As DBCoopBL.CombosBLL
    Public objConsultas As DBCoopBL.ConsultasBLL

    'declaracion de variables globales y constantes
    Public pnIVA As Decimal = 0.0
    Public gsNombre_Empresa As String = "SU EMPRESA, S.A. DE C.V."
    Public gsDesc_Moneda As String = "VALORES EXPRESADOS EN DÓLARES DE LOS ESTADOS UNIDOS DE AMÉRICA"
    Public gIdSucursal As Integer = 1
    Public piPeriodo As Integer = Now.Year, gSystemName As String = "DBCoop v2013"
    Public piMesCerrado As Integer = Now.Month
    Public giDiasPorAnioPrestamo As Integer
    Public glPjeRenta As Decimal
    Public gsImpresorDefault As String = ""
    Public glCuotaAportacion As Decimal
    Dim blCaja As DBCoopBL.CajaBusiness

    Public Enum DbModeType
        insert = 0
        update = 1
    End Enum



    Sub main()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.UserSkins.OfficeSkins.Register()
        Application.Run(New adm_frmLogin)
        Application.Run(New BravioMain)
        DestruirObjetos()
    End Sub

    Public Sub CrearObjetos()
        objMenu = New DBCoopBL.MenusBLL()
        objTablas = New DBCoopBL.TableBusiness()
        objFunciones = New DBCoopBL.FuncionesBLL()
        objCombos = New DBCoopBL.CombosBLL()
        objConsultas = New DBCoopBL.ConsultasBLL()
    End Sub

    Private Sub DestruirObjetos()
        objMenu = Nothing
        objTablas = Nothing
        objFunciones = Nothing
        objCombos = Nothing
        objConsultas = Nothing
    End Sub

    Public Sub CrearVariablesGlobales()
        Dim myBL As New DBCoopBL.AdmonBLL()

        Dim dt As DataTable = myBL.ObtieneParametros

        With dt.Rows(0)
            gsNombre_Empresa = .Item("NombreEmpresa")
            pnIVA = .Item("PorcIVA") / 100
            gsDesc_Moneda = .Item("DescMoneda")
            gIdSucursal = .Item("IdSucursal")
            giDiasPorAnioPrestamo = .Item("DiasPrestamo")
            glCuotaAportacion = .Item("CuotaAportacion")
            glPjeRenta = Decimal.Round(.Item("PorcRenta") / 100, 2)
        End With

    End Sub
    Public Function ValidarFechaCierre(ByVal Fecha As Date) As Boolean
        Dim myBL As New DBCoopBL.AdmonBLL()
        Dim dt As DataTable = myBL.ObtieneParametros
        If Fecha < dt.Rows(0).Item("FechaCierre") OrElse Fecha > dt.Rows(0).Item("FechaLimite") Then
            Return False
        End If
        Return True
    End Function

    Public Function SiEsNulo(ByVal value As Object, ByVal valueNoNull As Object) As Object
        If value Is Nothing Or IsDBNull(value) Then Return valueNoNull
        Return value
    End Function

    Public Sub ExportToExcel(ByVal objDT As DataTable)
        Dim Excel As Object = CreateObject("Excel.Application")

        If Excel Is Nothing Then
            MsgBox("No se encuentra instalado Excel en éste equipo, es necesario para generar el archivo a Excel", MsgBoxStyle.Critical)
            Return
        End If
        Dim strFilename As String
        Dim intCol, intRow As Integer
        Dim strPath As String = "c:\"

        Try
            With Excel
                .SheetsInNewWorkbook = 1
                .Workbooks.Add()
                .Worksheets(1).Select()

                .cells(1, 1).value = "Encabezao" 'Heading of the excel file
                .cells(1, 1).EntireRow.Font.Bold = True


                Dim intI As Integer = 1
                For intCol = 0 To objDT.Columns.Count - 1
                    .cells(2, intI).value = objDT.Columns(intCol).ColumnName
                    .cells(2, intI).EntireRow.Font.Bold = True
                    intI += 1
                Next
                intI = 3
                Dim intK As Integer = 1
                For intCol = 0 To objDT.Columns.Count - 1
                    intI = 3
                    For intRow = 0 To objDT.Rows.Count - 1
                        .Cells(intI, intK).Value = objDT.Rows(intRow).ItemArray(intCol)
                        intI += 1
                    Next
                    intK += 1
                Next
                If Mid$(strPath, strPath.Length, 1) <> "\" Then
                    strPath = strPath & "\"
                End If
                strFilename = strPath & "Excel.xls"
                .ActiveCell.Worksheet.SaveAs(strFilename)
            End With
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excel)
            Excel = Nothing
            MsgBox("El archivo ha sido exportado a Excel en '" & strFilename & "'", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ' The excel is created and opened for insert value. We most close this excel using this system
        Dim pro() As Process = System.Diagnostics.Process.GetProcessesByName("EXCEL")
        For Each i As Process In pro
            i.Kill()
        Next
    End Sub

    Public Sub DataTableToExcel(ByVal pDataTable As DataTable, ByVal File As String)
        Dim fbd As New FolderBrowserDialog
        fbd.ShowDialog()
        If fbd.SelectedPath = "" Then
            Return
        End If
        Dim NombreArchivo As String = InputBox("Nombre del archivo", "Caption", File)
        If NombreArchivo = "" Then
            Return
        End If
        Dim vFileName As String = fbd.SelectedPath & "\" & NombreArchivo & ".tmp"
        Dim vFileExcel As String = fbd.SelectedPath & "\" & NombreArchivo & ".xls"
        ''Path.GetTempFileName()
        FileOpen(1, vFileName, OpenMode.Output)
        Dim sb As String = ""
        Dim dc As DataColumn
        For Each dc In pDataTable.Columns
            sb &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
        Next
        PrintLine(1, sb)
        Dim i As Integer = 0
        Dim dr As DataRow
        For Each dr In pDataTable.Rows
            i = 0 : sb = ""
            For Each dc In pDataTable.Columns
                If Not IsDBNull(dr(i)) Then
                    sb &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                Else
                    sb &= Microsoft.VisualBasic.ControlChars.Tab
                End If
                i += 1
            Next
            PrintLine(1, sb)
        Next
        FileClose(1)
        TextToExcel(vFileName, vFileExcel)
        MsgBox("El Archivo ha sido guardado con éxito", MsgBoxStyle.Information)
    End Sub

    Public Sub TextToExcel(ByVal pFileName As String, ByVal pFileNameExcel As String)
        Dim Valor As Integer
        Dim vFormato As Excel.XlRangeAutoFormat
        Dim vCultura As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture()
        'Es importante definirle la cultura al sistema
        'ya que podria generar errores
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("es-SV")
        Dim Exc As Excel.Application = New Excel.Application

        Exc.Workbooks.OpenText(pFileName, , , , Excel.XlTextQualifier.xlTextQualifierNone, , True)

        Dim Wb As Excel.Workbook = Exc.ActiveWorkbook
        Dim Ws As Excel.Worksheet = Wb.ActiveSheet
        vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple

        'En el ejemplo vienen otros formatos posibles
        Ws.Range(Ws.Cells(1, 1), Ws.Cells(Ws.UsedRange.Rows.Count, Ws.UsedRange.Columns.Count)).AutoFormat(vFormato)
        Exc.ActiveWorkbook.SaveAs(pFileNameExcel, Excel.XlTextQualifier.xlTextQualifierNone - 1)
        Exc.Quit()
        Ws = Nothing
        Wb = Nothing
        Exc = Nothing
        GC.Collect()
        If Valor > -1 Then
            Dim p As System.Diagnostics.Process = New System.Diagnostics.Process
            p.EnableRaisingEvents = False
        End If
        System.Threading.Thread.CurrentThread.CurrentCulture = vCultura
        File.Delete(pFileName)
    End Sub
    'Public Function EnviarCorreo(ByVal Mensaje As StringBuilder, ByVal Correo As String, ByVal Asunto As String) As String
    '    Dim myBL As New DBCoopBL.AdmonBLL()
    '    Dim dtParam As DataTable = myBL.ObtieneParametros()
    '    Dim _Message As New MailMessage()
    '    Dim _SMTP As New System.Net.Mail.SmtpClient

    '    ''CONFIGURACIÓN DEL SMTP
    '    _SMTP.Credentials = New System.Net.NetworkCredential(dtParam.Rows(0).Item("Email"), dtParam.Rows(0).Item("EmailPassword"))
    '    _SMTP.Host = dtParam.Rows(0).Item("ServerEmail")
    '    ''_SMTP.Host = "smtp.gmail.com"
    '    _SMTP.Port = dtParam.Rows(0).Item("PortEmail")
    '    ''587
    '    _SMTP.EnableSsl = dtParam.Rows(0).Item("Ssl")
    '    ''_SMTP.EnableSsl = True


    '    ''CONFIGURACIÓN DEL MENSAJE
    '    _Message.[To].Add(Correo)
    '    _Message.From = New System.Net.Mail.MailAddress(dtParam.Rows(0).Item("Email"), "ESTADO DE CUENTA CONSOLIDADO ACOSIEMENS", System.Text.Encoding.UTF8)
    '    ''"Itosa08$"
    '    ''"planillaito@gmail.com"
    '    _Message.Subject = Asunto
    '    ''_Message.SubjectEncoding = System.Text.Encoding.UTF8
    '    _Message.Body = Mensaje.ToString()
    '    ''  _Message.BodyEncoding = System.Text.Encoding.UTF8
    '    _Message.Priority = System.Net.Mail.MailPriority.High
    '    _Message.IsBodyHtml = True

    '    ''ENVIO DE CORREO
    '    Try
    '        _SMTP.Send(_Message)
    '        Return ""
    '    Catch ex As System.Net.Mail.SmtpException
    '        MessageBox.Show(ex.ToString, "Error!", MessageBoxButtons.OK)
    '        Return ex.ToString
    '    End Try
    'End Function

    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "UN MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function

    Public Function FechaToString(ByVal FechaI As Date, ByVal FechaF As Date) As String
        If FechaF < FechaI Then
            FechaF = FechaI
        End If
        Dim sMesI As String = ObtieneMesString(FechaI.Month)
        Dim sMesF As String = ObtieneMesString(FechaF.Month)
        Dim sAnioI As String = FechaI.Year
        Dim sAnioF As String = FechaF.Year

        Dim sDiaI As String = FechaI.Day
        Dim sDiaF As String = FechaF.Day
        Dim sStringDate As String = ""
        If FechaI = FechaF Then
            sStringDate = sDiaI + " de " + sMesI + " de " + sAnioI
        Else
            If FechaI.Month = FechaF.Month Then
                If FechaI.Year = FechaF.Year Then
                    sStringDate = "del " + sDiaI + " al " + sDiaF + " de " + sMesI + " de " + sAnioI
                Else
                    sStringDate = "del " + sDiaI + " de " + sMesI + " de " + sAnioI + " al " + sDiaF + " de " + sMesF + " de " + sAnioF
                End If
            Else
                If sAnioI = sAnioF Then
                    sStringDate = "del " + sDiaI + " de " + sMesI + " al " + sDiaF + " de " + sMesF + " de " + sAnioI
                Else
                    sStringDate = "del " + sDiaI + " de " + sMesI + " de " + sAnioI + " al " + sDiaF + " de " + sMesF + " de " + sAnioF
                End If
            End If
        End If

        Return sStringDate

    End Function

    Public Function ObtieneMesString(ByVal value As Integer) As String
        Dim sMes As String = ""
        Select Case value
            Case 1 : sMes = "Enero"
            Case 2 : sMes = "Febrero"
            Case 3 : sMes = "Marzo"
            Case 4 : sMes = "Abril"
            Case 5 : sMes = "Mayo"
            Case 6 : sMes = "Junio"
            Case 7 : sMes = "Julio"
            Case 8 : sMes = "Agosto"
            Case 9 : sMes = "Septiembre"
            Case 10 : sMes = "Octubre"
            Case 11 : sMes = "Noviembre"
            Case 12 : sMes = "Diciembre"
        End Select
        Return sMes
    End Function
    Public Function ObtinesDiaString(ByVal value As Integer) As String
        Dim sDia As String = ""
        Select Case value
            Case 2 : sDia = "Lunes"
            Case 3 : sDia = "Martes"
            Case 4 : sDia = "Miercoles"
            Case 5 : sDia = "Jueves"
            Case 6 : sDia = "Viernes"
            Case 7 : sDia = "Sabado"
            Case 1 : sDia = "Domingo"

        End Select
        Return sDia
    End Function

    Public Function RetornaRtf(ByVal archivo As String) As String
        Dim sr As New StreamReader(archivo)
        Return sr.ReadToEnd()
    End Function


    Public Function ConstruirDatatable(ByVal RutaCompletaArchivo As String, ByVal Separador As Char) As DataTable
        'declaramos la Tabla donde añadiremos los datos y la fila correspondient
        Dim MiTabla As DataTable = New DataTable("MyTable")
        Dim MiFila As DataRow
        'declaramos el resto de variables que nos harán falta

        Dim pos As Boolean = False
        Dim i As Integer
        Dim fieldValues As String()
        Dim miReader As IO.StreamReader
        Try
            'Abrimos el fichero y leemos la primera linea con el fin de determinar cuantos campos tenemos
            miReader = File.OpenText(RutaCompletaArchivo)
            fieldValues = miReader.ReadLine().Split(Separador)
            'Creamos las columnas de la cabecera
            For i = 0 To fieldValues.Length() - 1
                MiTabla.Columns.Add(New DataColumn(fieldValues(i).ToString()))
            Next
            'Continuamos leyendo el resto de filas y añadiendolas a la tabla
            While miReader.Peek() <> -1
                fieldValues = miReader.ReadLine().Split(Separador)
                MiFila = MiTabla.NewRow
                For i = 0 To fieldValues.Length() - 1
                    MiFila.Item(i) = fieldValues(i).ToString
                Next
                MiTabla.Rows.Add(MiFila)
            End While

            'Cerramos el reader
            miReader.Close()
        Catch ex As Exception
            'Gestionamos las excepciones, Aqui cada uno puede hacer lo que crea conveniente: Mostrar un error en Javascript en este caso y devolver el Datatable vacío
            Dim mensaje As String
            mensaje = "alert ('Ha ocurrido el siguiente error al importar el archivo: " + ex.ToString + "');"
            MsgBox(mensaje, MsgBoxStyle.Information)
            Return New DataTable("Empty")
        Finally
            'Si queremos ejecutar algo exista excepción o no
        End Try
        'Devolvemos el DataTable si todo ha ido bien
        Return MiTabla
    End Function
    Public Class RawPrinterHelper
        ' Structure and API declarions:
        <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
        Structure DOCINFOW
            <MarshalAs(UnmanagedType.LPWStr)> Public pDocName As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pOutputFile As String
            <MarshalAs(UnmanagedType.LPWStr)> Public pDataType As String
        End Structure

        <DllImport("winspool.Drv", EntryPoint:="OpenPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function OpenPrinter(ByVal src As String, ByRef hPrinter As IntPtr, ByVal pd As Long) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="ClosePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function ClosePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        '[DllImport("winspool.Drv", EntryPoint="ClosePrinter", SetLastError=true, ExactSpelling=true, CallingConvention=CallingConvention.StdCall)]
        ' public static extern bool ClosePrinter(IntPtr hPrinter);

        <DllImport("winspool.Drv", EntryPoint:="StartDocPrinterW", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartDocPrinter(ByVal hPrinter As IntPtr, ByVal level As Int32, ByRef pDI As DOCINFOW) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndDocPrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndDocPrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="StartPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function StartPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="EndPagePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function EndPagePrinter(ByVal hPrinter As IntPtr) As Boolean
        End Function
        <DllImport("winspool.Drv", EntryPoint:="WritePrinter", _
           SetLastError:=True, CharSet:=CharSet.Unicode, _
           ExactSpelling:=True, CallingConvention:=CallingConvention.StdCall)> _
        Public Shared Function WritePrinter(ByVal hPrinter As IntPtr, ByVal pBytes As IntPtr, ByVal dwCount As Int32, ByRef dwWritten As Int32) As Boolean
        End Function

        ' SendBytesToPrinter()
        ' When the function is given a printer name and an unmanaged array of  
        ' bytes, the function sends those bytes to the print queue.
        ' Returns True on success or False on failure.
        Public Shared Function SendBytesToPrinter(ByVal szPrinterName As String, ByVal pBytes As IntPtr, ByVal dwCount As Int32) As Boolean
            Dim hPrinter As New IntPtr(0)      ' The printer handle.
            Dim dwError As Int32 = 0        ' Last error - in case there was trouble.
            Dim di As New DOCINFOW      ' Describes your document (name, port, data type).
            Dim dwWritten As Int32 = 0     ' The number of bytes written by WritePrinter().
            Dim bSuccess As Boolean     ' Your success code.

            ' Set up the DOCINFO structure.
            'With di
            di.pDocName = "RAW Document"
            di.pDataType = "RAW"

            'End With
            ' Assume failure unless you specifically succeed.
            bSuccess = False
            If OpenPrinter(szPrinterName.Normalize(), hPrinter, IntPtr.Zero) Then
                If StartDocPrinter(hPrinter, 1, di) Then
                    If StartPagePrinter(hPrinter) Then
                        ' Write your printer-specific bytes to the printer.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, dwWritten)
                        EndPagePrinter(hPrinter)
                    End If
                    EndDocPrinter(hPrinter)
                End If
                ClosePrinter(hPrinter)
            End If
            '    if( OpenPrinter( szPrinterName.Normalize(), out hPrinter, IntPtr.Zero ) )
            '{
            '    // Start a document.
            '        If (StartDocPrinter(hPrinter, 1, di)) Then
            '    {
            '        // Start a page.
            '            If (StartPagePrinter(hPrinter)) Then
            '        {
            '            // Write your bytes.
            '            bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
            '            EndPagePrinter(hPrinter);
            '        }
            '        EndDocPrinter(hPrinter);
            '    }
            '    ClosePrinter(hPrinter);
            ' If you did not succeed, GetLastError may give more information
            ' about why not.
            If bSuccess = False Then
                dwError = Marshal.GetLastWin32Error()
            End If
            Return bSuccess
        End Function ' SendBytesToPrinter()

        ' SendFileToPrinter()
        ' When the function is given a file name and a printer name, 
        ' the function reads the contents of the file and sends the
        ' contents to the printer.
        ' Presumes that the file contains printer-ready data.
        ' Shows how to use the SendBytesToPrinter function.
        ' Returns True on success or False on failure.
        Public Shared Function SendFileToPrinter(ByVal szPrinterName As String, ByVal szFileName As String) As Boolean
            ' Open the file.
            Dim fs As New FileStream(szFileName, FileMode.Open)
            ' Create a BinaryReader on the file.
            Dim br As New BinaryReader(fs)
            ' Dim an array of bytes large enough to hold the file's contents.
            Dim bytes(fs.Length) As Byte
            Dim bSuccess As Boolean
            ' Your unmanaged pointer.
            Dim pUnmanagedBytes As IntPtr

            ' Read the contents of the file into the array.
            bytes = br.ReadBytes(fs.Length)
            ' Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(fs.Length)
            ' Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, fs.Length)
            ' Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, fs.Length)
            ' Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes)
            Return bSuccess
        End Function ' SendFileToPrinter()

        ' When the function is given a string and a printer name,
        ' the function sends the string to the printer as raw bytes.
        Public Shared Function SendStringToPrinter(ByVal szPrinterName As String, ByVal szString As String)
            Dim pBytes As IntPtr
            Dim dwCount As Int32
            ' How many characters are in the string?
            dwCount = szString.Length()
            ' Assume that the printer is expecting ANSI text, and then convert
            ' the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString)
            ' Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount)
            Marshal.FreeCoTaskMem(pBytes)
            Return True
        End Function
    End Class

    Public Function ActualizaLibretaAhorroPorCodigo(ByVal Id As Integer, ByVal Linea As Integer, ByVal TotLineas As Integer) As String
        blCaja = New DBCoopBL.CajaBusiness()
        Dim str As String = "", s As String
        Dim NumLinea As Integer = Linea
        Dim dt As DataTable = blCaja.coo_AhorroSelectNoImpresos(Id)

        If Linea > 23 Then
            Linea = 1
        End If
        str += Chr(27) & Chr(33) & Chr(1) & Chr(10) & Chr(10)

        For i = 1 To Linea - 1
            If i = 12 Then
                str += Chr(10) & Chr(10) & Chr(10) & Chr(10)
            End If
            str += Chr(10)
        Next
        For Each Fila As DataRow In dt.Rows
            If NumLinea = 12 Then
                str += Chr(10) & Chr(10) & Chr(10) & Chr(10)
            End If
            With Fila
                str += Space(8) & Format(.Item("Fecha"), "dd/MM/yy")

                s = Fila.Item("NumeroDoc") + Space(16)
                s = " " + s.Substring(0, 16)  'se extraen 16 caracteres del numero de documento

                str += s
                'hasta acá se llevan 31 caracteres
                If "2".IndexOf(.Item("IdTipo")) <> -1 Then  'retiros
                    str += (Format(Fila.Item("Valor"), "###,##0.00")).PadLeft(16, " ")
                    str += (Format(Fila.Item("Saldo"), "###,##0.00")).PadLeft(35, " ")
                Else 'depósitos, pago de intereses
                    str += (Format(Fila.Item("Valor"), "###,##0.00")).PadLeft(35, " ")
                    str += (Format(Fila.Item("Saldo"), "###,##0.00")).PadLeft(16, " ")
                End If
            End With

            str += Chr(10)
            NumLinea = NumLinea + 1
            If NumLinea = 24 Then
                str += Chr(27) + "e10" + Chr(70) + "q"
                MsgBox("Coloque la Libreta de ahorro en el impresor", MsgBoxStyle.Information)
                RawPrinterHelper.SendStringToPrinter(gsImpresorDefault, str)
                str = ""
                NumLinea = 1
            End If
        Next
        If str <> "" Then
            str += Chr(27) + "e10" + Chr(70) + "q"
            MsgBox("Coloque la libreta de ahorro en el impresor...", MsgBoxStyle.Information, "Nota")
            RawPrinterHelper.SendStringToPrinter(gsImpresorDefault, str)
        End If
        Dim sql As String = "update coo_CuentasAhorroMov set Impreso = 1 WHERE Impreso=0 and IdCuenta=" & Id

        blCaja.EjecutaInstruccionSql(sql)
        Return ""
    End Function
    Public Function ActualizaLibretaAportaPorCodigo(ByVal Id As Integer, ByVal Linea As Integer, ByVal TotLineas As Integer) As String
        Dim str As String = "", s As String
        Dim NumLinea As Integer = Linea
        Dim dt As DataTable = blCaja.coo_AportacionesSelectNoImpresos(Id)

        If Linea > 23 Then
            Linea = 1
        End If
        str += Chr(27) & Chr(33) & Chr(1) & Chr(10) & Chr(10)

        For i = 1 To Linea - 1
            If i = 12 Then
                str += Chr(10) & Chr(10) & Chr(10) & Chr(10)
            End If
            str += Chr(10)
        Next
        For Each Fila As DataRow In dt.Rows
            If NumLinea = 12 Then
                str += Chr(10) & Chr(10) & Chr(10) & Chr(10)
            End If
            With Fila
                str += Space(8) & Format(.Item("Fecha"), "dd/MM/yy")

                s = Fila.Item("NumeroDoc") + Space(16)
                s = " " + s.Substring(0, 16)  'se extraen 16 caracteres del numero de documento

                str += s
                'hasta acá se llevan 31 caracteres
                If .Item("Cargo") > 0.0 Then  'retiros
                    str += (Format(Fila.Item("Cargo"), "###,##0.00")).PadLeft(16, " ")
                    str += (Format(Fila.Item("Saldo"), "###,##0.00")).PadLeft(35, " ")
                Else 'depósitos, pago de intereses
                    str += (Format(Fila.Item("Abono"), "###,##0.00")).PadLeft(35, " ")
                    str += (Format(Fila.Item("Saldo"), "###,##0.00")).PadLeft(16, " ")
                End If
            End With

            str += Chr(10)
            NumLinea = NumLinea + 1
            If NumLinea = 24 Then
                str += Chr(27) + "e10" + Chr(70) + "q"
                MsgBox("Coloque la Libreta de aportación en el impresor", MsgBoxStyle.Information)
                RawPrinterHelper.SendStringToPrinter(gsImpresorDefault, str)
                str = ""
                NumLinea = 1
            End If
        Next
        If str <> "" Then
            str += Chr(27) + "e10" + Chr(70) + "q"
            MsgBox("Coloque la libreta de aportación en el impresor...", MsgBoxStyle.Information, "Nota")
            RawPrinterHelper.SendStringToPrinter(gsImpresorDefault, str)
        End If
        Dim sql As String = "update coo_Aportaciones set Impreso = 1 WHERE Impreso=0 and IdAsociado =" & Id
        blCaja.EjecutaInstruccionSql(sql)
        Return ""
    End Function
    Public Sub ImprimeLibretaAportacion(ByVal IdAsociado As Integer, ByVal LineaLibreta As Integer, ByVal TotalLineasLibreta As Integer)

        Dim dt As DataTable = blCaja.coo_AportacionesSelectNoImpresos(IdAsociado)
        Dim NumLinea As Integer = LineaLibreta
        Dim Libreta As New DataTable("Libreta1")
        Libreta.Columns.Add("Linea", GetType(Integer))
        Libreta.Columns.Add("Referencia", GetType(String))
        Libreta.Columns.Add("IdTipo", GetType(Integer))
        Libreta.Columns.Add("Retiro", GetType(Decimal))
        Libreta.Columns.Add("Deposito", GetType(Decimal))
        Libreta.Columns.Add("Saldo", GetType(Decimal))

        'inserto las líneas que hacen falta para llegar a la línea deseada
        Dim Row As DataRow = Nothing
        For j = 1 To 15
            Libreta.Rows.Add(Libreta.NewRow())
        Next

        For i = 1 To NumLinea - 1
            Libreta.Rows.Add(Libreta.NewRow())
            If NumLinea = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
        Next
        Dim Pendiente As Boolean
        'recorro las filas a imprimir
        For Each Linea As DataRow In dt.Rows
            If NumLinea = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
            Pendiente = True
            Row = Libreta.NewRow()
            Row("Linea") = NumLinea
            Row("Referencia") = String.Format("{0} {1}", Format(Linea.Item("Fecha"), "dd/MM/yy"), Linea.Item("NumeroDoc"))
            '
            If Linea.Item("Abono") > 0 Then
                Row("Deposito") = Linea.Item("Abono")
            Else
                Row("Retiro") = Linea.Item("Cargo")
            End If
            Row("Saldo") = Linea.Item("Saldo")

            Libreta.Rows.Add(Row)
            NumLinea += 1

            'si ya se incluyeron las lineas que se imprimen por libreta, pedirlas nuevamente
            If NumLinea = TotalLineasLibreta + 1 Then
                GeneraImpresionLibretaAportacion(Libreta)
                Pendiente = False
                Libreta.Rows.Clear()
                NumLinea = 1
            End If
        Next
        If Pendiente Then
            GeneraImpresionLibretaAportacion(Libreta)
        End If

        Dim sql As String = "update coo_Aportaciones set Impreso = 1 WHERE Impreso = 0 and IdAsociado=" & IdAsociado
        blCaja.EjecutaInstruccionSql(sql)
    End Sub
    Public Sub ImprimeLibretaAhorro(ByVal IdCuenta As Integer, ByVal LineaLibreta As Integer, ByVal TotalLineasLibreta As Integer)
        Dim NumLinea As Integer = LineaLibreta
        Dim Libreta As New DataTable("Libreta1")
        Libreta.Columns.Add("Linea", GetType(Integer))
        Libreta.Columns.Add("Referencia", GetType(String))
        Libreta.Columns.Add("IdTipo", GetType(Integer))
        Libreta.Columns.Add("Retiro", GetType(Decimal))
        Libreta.Columns.Add("Deposito", GetType(Decimal))
        Libreta.Columns.Add("Saldo", GetType(Decimal))

        'inserto las líneas que hacen falta para llegar a la línea deseada
        Dim Row As DataRow = Nothing
        For j = 1 To 15
            Libreta.Rows.Add(Libreta.NewRow())
        Next

        For i = 1 To NumLinea - 1
            Libreta.Rows.Add(Libreta.NewRow())
            If i = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
        Next
        Dim Pendiente As Boolean
        blCaja = New DBCoopBL.CajaBusiness()
        Dim dt As DataTable = blCaja.coo_AhorroSelectNoImpresos(IdCuenta)
        For Each fila As DataRow In dt.Rows
            If NumLinea = 12 And gsNombre_Empresa.StartsWith("ACAPRO") Then  'cambio exclusivo para ACAPRODUSCA, POR EL ESPACIO QUE EXISTE EN MEDIO DE LA LIBRETA
                For j = 1 To 3
                    Libreta.Rows.Add(Libreta.NewRow())
                Next
            End If
            Pendiente = True
            Row = Libreta.NewRow()
            Row("Linea") = NumLinea
            Row("Referencia") = String.Format("{0} {1}", Format(fila.Item("Fecha"), "dd/MM/yy"), fila.Item("NumeroDoc"))
            Row("IdTipo") = fila.Item("IdTipo")

            If "2".IndexOf(fila.Item("IdTipo")) <> -1 Then
                Row("Retiro") = fila.Item("Valor")
            Else
                Row("Deposito") = fila.Item("Valor")
            End If
            Row("Saldo") = fila.Item("Saldo")

            Libreta.Rows.Add(Row)
            NumLinea += 1

            'si ya se incluyeron las lineas que se imprimen por libreta, pedirla nuevamente
            If NumLinea = TotalLineasLibreta + 1 Then
                GeneraImpresionLibretaAhorro(Libreta)
                Pendiente = False
                Libreta.Rows.Clear()
                NumLinea = 1
            End If
        Next
        If Pendiente Then
            GeneraImpresionLibretaAhorro(Libreta)
        End If

        Dim sql As String = "update coo_CuentasAhorroMov set Impreso = 1 WHERE Impreso = 0 and IdCuenta=" & IdCuenta
        blCaja.EjecutaInstruccionSql(sql)

    End Sub

    Private Sub GeneraImpresionLibretaAportacion(ByVal Libreta As DataTable)
        MsgBox("Coloque la libreta de aportaciones en el impresor", MsgBoxStyle.Information, "Nota")
        Using rpt As New rptLibretaAportacion()
            rpt.LoadLayout("Plantillas/LibretaAportacion.repx")
            rpt.DataSource = Libreta
            rpt.DataMember = ""
            rpt.PrinterName = gsImpresorDefault
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End Using
    End Sub
    Private Sub GeneraImpresionLibretaAhorro(ByVal Libreta As DataTable)
        MsgBox("Coloque la libreta de ahorros en el impresor", MsgBoxStyle.Information, "Nota")
        Using rpt As New rptLibretaAhorro()
            rpt.LoadLayout("Plantillas/LibretaAhorro.repx")
            rpt.DataSource = Libreta
            rpt.DataMember = ""
            rpt.PrinterName = gsImpresorDefault
            rpt.ShowPrintMarginsWarning = False
            rpt.PrintDialog()
        End Using
    End Sub
End Module