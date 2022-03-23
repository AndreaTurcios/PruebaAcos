Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DBCoopEL.TableEntities

Public Class frmRequisicion
    Dim funCaja As New CajaBL.FuncionesBusiness()
    Dim blCaja As New CajaBusiness
    Dim entSucursal As New adm_Sucursales

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdGuardar.Click

        Dim msj As String = ""
        If _NroComprobante.Text = "" Then
            entSucursal = objTablas.adm_SucursalesSelectByPK(gIdSucursal)
            _NroComprobante.EditValue = gIdSucursal.ToString.PadLeft(2, "0") & "-" & (entSucursal.CorrelativoRequisicion + 1).ToString.PadLeft(6, "0")
        End If
        If _NroComprobante.Text = "" Then
            MsgBox("Numero de comprobante en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If _Fecha.Text = "" Then
            MsgBox("Fecha en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If Val(_Monto.Text) = 0 Then
            MsgBox("Monto en blanco", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim entRemision As New coo_OperacionesCaja

        With entRemision
            .IdOperacion = funCaja.ObtenerCorrelativo("OPERACION_CAJA")
            .Fecha = _Fecha.EditValue
            .Numero = _NroComprobante.EditValue
            .Tipo = 1
            .Monto = _Monto.EditValue
            .Concepto = _Observa.Text
            .IdSucursal = gIdSucursal
            .CreadoPor = objMenu.User
            .FechaHoraCreacion = Now
            .Excluir = 0
        End With
        If blCaja.ExisteComprobanteRequisicion(entRemision.Numero, entRemision.IdSucursal) <> "" Then
            MsgBox("Numero de Comprobante ya Existe", MsgBoxStyle.Critical, "Error de usuario")
            Exit Sub
        End If
        msj = blCaja.InsertaRequisicion(entRemision, gIdSucursal)

        If msj = "" Then
            MsgBox("La Requisición ha sido guardada con éxito", MsgBoxStyle.Information)
        Else
            MsgBox("No fue posible guardar la requisición" + Chr(13) + msj, MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MsgBox("Postear el Comprobante ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New rptPosteo
            rpt.xrlComprobante.Text = _NroComprobante.EditValue.ToString()
            rpt.xrlCuenta.Text = ""
            rpt.xrlFecha.Text = _Fecha.DateTime.Day & "/" & _Fecha.DateTime.Month & "/" & _Fecha.DateTime.Year
            rpt.xrlValor.Text = Format(CDec(_Monto.EditValue), "##,##0.00")
            rpt.xrlCajero.Text = objMenu.User
            rpt.PrinterName = gsImpresorDefault
            While True
                rpt.PrintDialog()
                If MsgBox("Se imprimió correctamente el posteo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
                    Exit While
                End If
            End While
        End If

        'For Each c As Control In GroupBox1.Controls
        '    If TypeOf c Is DevExpress.XtraEditors.TextEdit Then
        '        c.Text = ""
        '    End If
        'Next
        '_NroComprobante.Focus()
        Dim FechaContable As Date = blCaja.GetFechaContable(gIdSucursal)
        If Not blCaja.IsCajaAbierta(gIdSucursal, FechaContable, objMenu.User) Then
            blCaja.AperturarCaja(gIdSucursal, FechaContable, objMenu.User)
        End If
        Close()
    End Sub

    Private Sub frmRequisicion_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        _NroComprobante.Focus()
    End Sub

    Private Sub frmRequisicion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmRequisicion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Fecha.EditValue = objFunciones.GetFechaContable(gIdSucursal)
        _Monto.EditValue = 0.0
    End Sub
End Class