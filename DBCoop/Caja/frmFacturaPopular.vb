Imports DevExpress.XtraReports.UI
Imports CajaBL
Public Class frmFacturaPopular
    Dim blcaja As New CajaBusiness()

    Private Sub frmFacturaPopular_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub frmFacturaPopular_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        CargaCombos()
        _FechaIngreso.EditValue = blcaja.GetFechaContable(gIdSucursal)
        leSucursal.EditValue = gIdSucursal
    End Sub

    Private Sub CargaCombos()
        objCombos.adm_Sucursales(leSucursal, "")
        objCombos.cooPtmoFmaPago(_formPago)
    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImprimir.Click
        If MsgBox("Desea imprimir el comprobante en éste momento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.Yes Then
            Dim rpt As New pre_rptFacturaPopular
            rpt.xrlFechaContable.Text = _FechaIngreso.EditValue
            rpt.xrlNombre.Text = _NombreAsociado.EditValue

            Dim Capital As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("CapitalPagado")
            Dim Aportacion As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("Aportacion")
            Dim Ahorro As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("CuotaAhorro")
            Dim Interes As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("InteresPagado")
            Dim Mora As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("InteresMoraPagado")
            Dim Seguro As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("ValorSeguro")
            Dim Manejo As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("CuotaManejo")
            Dim Total As Decimal = blcaja.rptFacturaPopular(leSucursal.EditValue, _formPago.EditValue, _FechaIngreso.EditValue).Rows(0).Item("MontoAplicado")

            rpt.xrlCapital.Text = Capital
            rpt.xrlAportacion.Text = Aportacion
            rpt.xrlAhorro.Text = Ahorro
            rpt.xrlInteres.Text = Interes
            rpt.xrlMora.Text = Mora
            rpt.xrlSeguro.Text = Seguro
            rpt.xrlManejo.Text = Manejo

            rpt.xrlTotalOtros.Text = Capital + Aportacion + Ahorro
            rpt.xrlTotalExento.Text = Interes + Mora + Seguro
            rpt.xrlTotalGravado.Text = Manejo
            rpt.xrlTotalExento2.Text = Interes + Mora + Seguro
            rpt.xrlTotalPagado.Text = Total

            Dim sDecimal = String.Format("{0:c}", Total)
            sDecimal = sDecimal.Substring(sDecimal.Length - 2) & "/100"
            rpt.xrlCantidadLetras.Text = Num2Text(Int(Total)) & " " & sDecimal & " DÓLARES"

            While True
                rpt.ShowPreviewDialog()
                If MsgBox("¿Generar otra impresión del documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Imprimir") = MsgBoxResult.No Then
                    Exit While
                End If
            End While
        End If
    End Sub

End Class