Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class ind_frmCalcularIndicadores
    Dim blIndicador As New IndicadoresBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()
    Dim entColac As New List(Of col_Colac)
    Dim dtIndicador As New DataTable

    Private Sub ind_frmGeneraIndicadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        seAnio.EditValue = Year(Now)
        meMes.EditValue = Month(Now)
    End Sub


    Private Sub sbCalcular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCalcular.Click
        dtIndicador = blCaja.col_indicadoresSelectAll
        Dim dt As New DataTable
        Dim Valor As Decimal
        Dim Valor1 As Decimal
        Dim Valor2 As Decimal
        For Each row As DataRow In dtIndicador.Rows
            Dim entInd As New col_Colac
            entInd.IdIndicador = row("IdIndicador")
            Select Case row("IdIndicador")
                Case 1
                    dt = blIndicador.PenetracionMercado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Porcentaje")
                Case 2
                    dt = blIndicador.PrestamosPorCliente(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Salarios")
                Case 3
                    Valor = blIndicador.rptIndicador(32, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 4
                    dt = blIndicador.ParticipacionCartera(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 5
                    Valor = blIndicador.rptIndicador(34, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 6
                    Valor = blIndicador.rptIndicador(35, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 7
                    Valor = blIndicador.rptIndicador(36, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 8
                    Valor = blIndicador.rptIndicador(37, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 9
                    Valor = blIndicador.rptIndicador(38, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 10
                    Valor1 = blIndicador.rptIndicador(37, meMes.EditValue, seAnio.EditValue, 2)
                    Valor2 = blIndicador.rptIndicador(38, meMes.EditValue, seAnio.EditValue, 2)
                    If Valor2 <> 0 Then
                        entInd.Valor = Round(Valor1 / Valor2, 2)
                    Else
                        entInd.Valor = 0.0
                    End If
                Case 11
                    Valor = blIndicador.rptIndicador(39, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 12
                    Valor = blIndicador.rptIndicador(40, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 13
                    Valor = blIndicador.rptIndicador(41, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 14
                    Valor = blIndicador.rptIndicador(42, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 15
                    Valor = blIndicador.rptIndicador(43, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 16
                    Valor = blIndicador.rptIndicador(44, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 17
                    Valor = blIndicador.rptIndicador(45, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 18
                    Valor = blIndicador.rptIndicador(46, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 19
                    Valor = blIndicador.rptIndicador(47, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 20
                    Valor = blIndicador.rptIndicador(48, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 21
                    dt = blIndicador.MorosidadCartera(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 22
                    dt = blIndicador.ProvisionCuentasMalas(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 23
                    dt = blIndicador.ProvisionCuentasMalas90(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 24
                    Valor = blIndicador.rptIndicador(49, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 25
                    dt = blIndicador.ActivosPorEmpleado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 26
                    dt = blIndicador.IngresosPorEmpleado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 27
                    dt = blIndicador.CrecimientoActivos(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 28
                    Valor = blIndicador.CrecimientoPrestamos(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 29
                    Valor = blIndicador.CrecimientoPratrimonio(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 30
                    Valor = blIndicador.CrecimientoClientesActivo(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = Valor
                Case 31
                    Valor = blIndicador.CrecimientoNivelPublicidad(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = Valor
                Case 32
                    Valor = blIndicador.rptIndicador(50, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 33
                    Valor = blIndicador.rptIndicador(51, meMes.EditValue, seAnio.EditValue, 2)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 34
                    dt = blIndicador.ActivosPorAsociado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 35
                    dt = blIndicador.AportacionesPorAsociado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Valor")
                Case 36
                    dt = blIndicador.AhorrosPorAsociado(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = dt.Rows(0).Item("Salarios")
                Case 37
                    Valor = blIndicador.rptIndicador(52, meMes.EditValue, seAnio.EditValue, 1)
                    entInd.Valor = Round(Valor * 1, 2)
                Case 38
                    Valor = blIndicador.CrecimientoAhorros(seAnio.EditValue, meMes.EditValue)
                    entInd.Valor = Round(Valor * 1, 2)
            End Select
            entInd.Anio = seAnio.EditValue
            entInd.Mes = meMes.EditValue
            entColac.Add(entInd)
        Next
        Dim msj As String = ""
        msj = blIndicador.InsertaCalculoColac(entColac, seAnio.EditValue, meMes.EditValue)
        If msj = "" Then
            MsgBox("Los Indices han sido Calculados con éxito", MsgBoxStyle.Information)
        Else
            MsgBox(String.Format("No fue posible Calcular los Indices{0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
            Return
        End If
        Close()
    End Sub

End Class
