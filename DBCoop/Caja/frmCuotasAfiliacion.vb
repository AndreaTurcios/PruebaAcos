Imports DevExpress.XtraReports.UI
Imports DBCoopEL.TableEntities
Imports DBCoopBL
Public Class frmCuotasAfiliacion
    Dim blCaja As New CajaBusiness()
    Dim EntAsociado As coo_Asociados

    Private Sub frmCuotasAfiliacion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmCuotaAfiliacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.cooPtmoFmaPago(_FormaPago)
        gc.DataSource = blCaja.ObtenerAfiliaciones(gIdSucursal)
        gv.Columns("IdAsociado").Visible = False
        gv.BestFitColumns()
    End Sub

    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbGuardar.Click

        If MsgBox("¿Está seguro(a) de aceptar éstos datos?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim IdAsociado As Integer = gv.GetFocusedRowCellValue("IdAsociado")
        Dim CuotaIngreso As Decimal = gv.GetFocusedRowCellValue("CuotaIngreso")
        Dim CuotaAportacion As Decimal = 0.0 'gv.GetFocusedRowCellValue("AporteInicial")
        Dim Papeleria As Decimal = gv.GetFocusedRowCellValue("Papeleria")
        Dim Otros As Decimal = gv.GetFocusedRowCellValue("Otros")
        Dim Nombres As String = gv.GetFocusedRowCellValue("Nombres")
        Dim Apellidos As String = gv.GetFocusedRowCellValue("Apellidos")
        Dim NumeroAsociado As String = gv.GetFocusedRowCellValue("Numero")
        Dim Total As Decimal = CuotaIngreso + CuotaAportacion + Papeleria + Otros

        Dim Fecha As Date = blCaja.GetFechaContable(gIdSucursal)
        blCaja.ActualizarEstadoAfiliacion(IdAsociado, Fecha, objMenu.User, _FormaPago.EditValue)

        'crear proceso para hacer el Insert en aportaciones
        If MsgBox("¿Imprimir el comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then

            Dim rpt As New apo_rptAfiliacion
            Dim sDecimal = String.Format("{0:c}", Format(CDec(Total), "##,##0.00"))
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            rpt.xrlIngreso.Text = CuotaIngreso
            rpt.xrlTramite.Text = Papeleria
            rpt.xrlOtros.Text = Otros
            rpt.xrlTotal.Text = Total
            rpt.xrlFecha.Text = FechaToString(Fecha, Fecha)
            rpt.xrlNombre.Text = Nombres
            rpt.xrlApellido.Text = Apellidos
            rpt.xrlNumero.Text = NumeroAsociado
            rpt.xrlCantidadLetras.Text = Num2Text(Int(Total)) & " " & sDecimal & " DÓLARES"
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("¿Se imprimió correctamente el comprobante?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If
        'gc.DataSource = blCaja.ObtenerAfiliaciones(gIdSucursal)
        'gv.BestFitColumns()
        Close()
    End Sub


End Class