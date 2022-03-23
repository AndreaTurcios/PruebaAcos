Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Public Class pre_frmCuadroMora
    Dim bl As New PrestamosBLL
    Private Sub pre_frmCuadroMora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objCombos.adm_Sucursales(leSucursal, "-- TODAS --")
        objCombos.coo_Tecnicos(leTecnico, "")
        deFecha.EditValue = Today
    End Sub

    Private Sub pre_frmCuadroMora_Reporte() Handles Me.Reporte
        Dim ds As DataSet = bl.rptCuadroMora(leSucursal.EditValue, leTecnico.EditValue, deFecha.EditValue, rgTipo.EditValue)
        Dim rpt As New pre_rptCuadroMora

        rpt.DataSource = ds.Tables(0)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlTitulo1.Text = "CUADRO ANALÍTICO DE MOROSIDAD AL " + (FechaToString(deFecha.EditValue, deFecha.EditValue)).ToUpper

        If rgTipo.EditValue = 1 Then
            rpt.xrlTitulo2.Text = IIf(leSucursal.EditValue = -1, "CONSOLIDADO INSTITUCIONAL POR TODAS LAS SUCURSALES", "SUCURSAL: " + leSucursal.Text)
        Else
            rpt.xrlTitulo2.Text = "TÉCNICO: " + leTecnico.Text
        End If
        'PorcMora1,PorcMora2,PorcMora3,PorcMora4,PorcMora5,PorcMora6,PorcMora7,PorcMora8,PorcMoraMas1,PorcMoraMas90
        ',Dist1,Dist2,Dist3,Dist4,Dist5,Dist6,Dist7
        With ds.Tables(1).Rows(0)
            rpt.xrlPorc1.Text = Format(.Item("PorcMora1"), "###,##0.00") + "%"
            rpt.xrlPorc2.Text = Format(.Item("PorcMora2"), "###,##0.00") + "%"
            rpt.xrlPorc3.Text = Format(.Item("PorcMora3"), "###,##0.00") + "%"
            rpt.xrlPorc4.Text = Format(.Item("PorcMora4"), "###,##0.00") + "%"
            rpt.xrlPorc5.Text = Format(.Item("PorcMora5"), "###,##0.00") + "%"
            rpt.xrlPorc6.Text = Format(.Item("PorcMora6"), "###,##0.00") + "%"
            rpt.xrlPorc7.Text = Format(.Item("PorcMora7"), "###,##0.00") + "%"
            rpt.xrlPorc8.Text = Format(.Item("PorcMora8"), "###,###0.00") + "%"
            rpt.xrlPorcMora1.Text = Format(.Item("PorcMoraMas1"), "###,##0.00") + "%"
            rpt.xrlPorcMora2.Text = Format(.Item("PorcMoraMas90"), "###,##0.00") + "%"
            rpt.xrlProv1.Text = Format(.Item("Dist1"), "###,##0.00")
            rpt.xrlProv2.Text = Format(.Item("Dist2"), "###,##0.00")
            rpt.xrlProv3.Text = Format(.Item("Dist3"), "###,##0.00")
            rpt.xrlProv4.Text = Format(.Item("Dist4"), "###,##0.00")
            rpt.xrlProv5.Text = Format(.Item("Dist5"), "###,##0.00")
            rpt.xrlProv6.Text = Format(.Item("Dist6"), "###,##0.00")
            Dim Total As Decimal = .Item("Dist1") + .Item("Dist2") + .Item("Dist3") + .Item("Dist4") + .Item("Dist5") + .Item("Dist6")
            rpt.xrlProvTotal.Text = Format(Total, "###,##0.00")
            rpt.xrlProvActual.Text = Format(seProvision.EditValue, "###,##0.00")
            rpt.xrlExceso.Text = Format(seProvision.EditValue - Total, "###,##0.00")
        End With
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rgTipo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipo.EditValueChanged
        lcSucursal.Visible = rgTipo.EditValue = 1
        leSucursal.Visible = rgTipo.EditValue = 1
        lcTecnico.Visible = rgTipo.EditValue = 2
        leTecnico.Visible = rgTipo.EditValue = 2
        leSucursal.ItemIndex = 0
        leTecnico.ItemIndex = 0
    End Sub

    Private Sub pre_frmCuadroMora_ReporteExcel() Handles Me.ReporteExcel
        DataTableToExcel(bl.rptCuadroMora(leSucursal.EditValue, leTecnico.EditValue, deFecha.EditValue, rgTipo.EditValue).Tables(0), "")
    End Sub
End Class