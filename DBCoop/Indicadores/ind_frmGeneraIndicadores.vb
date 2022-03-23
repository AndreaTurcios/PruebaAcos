Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports Bravio
Imports DevExpress.XtraGrid.Columns
Imports Microsoft.VisualBasic
Imports System.Math
Public Class ind_frmGeneraIndicadores
    Dim blPrestamo As New PrestamosBLL()
    Dim blCaja As New TableBusiness()
    Dim funCaja As New FuncionesBLL()
    Dim cn As New AdmonBLL()

    Private Sub ind_frmGeneraIndicadores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.col_Variables(leVariable, "")
        objCombos.col_Indicadores(leIndicador, 1)
    End Sub



    Private Sub leVariable_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles leVariable.EditValueChanged
        objCombos.col_Indicadores(leIndicador, leVariable.EditValue)
    End Sub

    Private Sub sbVer_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbVer.Click
        Select Case leIndicador.EditValue
            Case 1
                col_frmPenetracionDeMercado.ShowDialog()
            Case 2
                col_frmPrestamosPorCliente.ShowDialog()
            Case 3
                col_frmGastosGobernabilidad.ShowDialog()
            Case 4
                col_frmParticipacionDeCartera.ShowDialog()
            Case 5
                col_frmParticipacionDeInversiones.ShowDialog()
            Case 6
                col_frmParticipacionActivoFijo.ShowDialog()
            Case 7
                col_frmNivelActivoImproductivo.ShowDialog()
            Case 8
                col_frmRendimientoFinanciero.ShowDialog()
            Case 9
                col_frmCostoFinanciero.ShowDialog()
            Case 10
                col_frmMargenContribucionSPREADFinanciero.ShowDialog()
            Case 11
                col_frmMargenExcedente.ShowDialog()
            Case 12
                col_frmRentabilidadActivoROA.ShowDialog()
            Case 13
                col_frmRentabilidadPatrimonio.ShowDialog()
            Case 14
                col_frmIndiceLiquidez.ShowDialog()
            Case 15
                col_frmPruebaAcida.ShowDialog()
            Case 16
                col_frmRazonEndeudamiento.ShowDialog()
            Case 17
                col_frmPalancaPatrimonial.ShowDialog()
            Case 18
                col_frmPalancaPatrimonialInstritucional.ShowDialog()
            Case 19
                col_frmEficienciaEconomica.ShowDialog()
            Case 20
                col_frmEficienciaAdministrativa.ShowDialog()
            Case 21
                col_frmMorosidadCartera.ShowDialog()
            Case 22
                col_frmProvisionCuentasMalas.ShowDialog()
            Case 23
                col_frmProvisionCuentasMalas90.ShowDialog()
            Case 24
                col_frmFormacionRecursoHumano.ShowDialog()
            Case 25
                col_frmActivosPorEmpleados.ShowDialog()
            Case 26
                col_frmIngresosPorEmpleados.ShowDialog()
            Case 27
                col_frmCrecimientoDeActivos.ShowDialog()
            Case 28
                col_frmCrecimientoPrestamos.ShowDialog()
            Case 29
                col_frmCrecimientoPatrimonio.ShowDialog()
            Case 30
                col_frmCrecimientoClientesActivos.ShowDialog()
            Case 31
                col_frmNivelPublicidad.ShowDialog()
            Case 32
                col_frmGastosTecnologia.ShowDialog()
            Case 33
                col_frmEquiposTecnologicos.ShowDialog()
            Case 34
                col_frmActivosPorAsociado.ShowDialog()
            Case 35
                col_frmAportacionesPorAsociado.ShowDialog()
            Case 36
                col_frmAhorrosPorAsociado.ShowDialog()
            Case 37
                col_frmActividadCooperativa.ShowDialog()
            Case 38
                col_frmCrecimientoAhorros.ShowDialog()
        End Select

    End Sub
End Class
