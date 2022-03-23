Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class frmRemision
    Dim funCaja As New CajaBL.FuncionesBusiness()
    Dim blCaja As New CajaBusiness()
    Dim EntSucursal As New adm_Sucursales

    Private Sub cmdGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click
        Dim msj As String = ""

        If _NroComprobante.Text = "" Then
            EntSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            _NroComprobante.EditValue = gIdSucursal.ToString.PadLeft(2, "0") & "-" & (EntSucursal.CorrelativoRemision + 1).ToString.PadLeft(6, "0")
        End If
        If _NroComprobante.Text = "" Then
            MsgBox("Numero de comprobante en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _fecha.Text = "" Then
            MsgBox("Fecha en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Val(_monto.Text) = 0 Then
            MsgBox("Monto en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim entRemision As New coo_OperacionesCaja

        With entRemision
            .IdOperacion = funCaja.ObtenerCorrelativo("OPERACION_CAJA")
            .Fecha = _fecha.EditValue
            .Numero = _NroComprobante.EditValue
            .Tipo = 2
            .Monto = _monto.EditValue
            .Concepto = _observa.Text
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .Excluir = chkFinal.EditValue
        End With
        If blCaja.ExisteComprobanteRemision(entRemision.Numero, entRemision.IdSucursal) <> "" Then
            MsgBox("Numero de Comprobante ya Existe", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If

        msj = blCaja.InsertaRemision(entRemision, gIdSucursal)

        If msj = "" Then
            MsgBox("La remisión ha sido guardado con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("No fue posible guardar la remisión" + Chr(13) + msj, MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim myRpt3 As New rptPosteo
            myRpt3.xrlComprobante.Text = _NroComprobante.EditValue.ToString()
            myRpt3.xrlCuenta.Text = ""
            myRpt3.xrlFecha.Text = _fecha.DateTime.Day & "/" & _fecha.DateTime.Month & "/" & _fecha.DateTime.Year
            myRpt3.xrlValor.Text = Format(CDec(_monto.EditValue), "##,##0.00")
            myRpt3.xrlCajero.Text = objMenu.User
            myRpt3.PrinterName = gsImpresorDefault
            While True
                myRpt3.PrintDialog()
                If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If
        Close()
        'For Each c As Control In GroupBox1.Controls
        '    If TypeOf c Is DevExpress.XtraEditors.TextEdit Then
        '        c.Text = ""
        '    End If
        'Next
        '_NroComprobante.Focus()
    End Sub

    Private Sub frmRemision_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        _NroComprobante.Focus()
    End Sub

    Private Sub frmRemision_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmRemision_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        _fecha.EditValue = blCaja.GetFechaContable(gIdSucursal)
        _monto.EditValue = 0.0
    End Sub
End Class