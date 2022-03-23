Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Public Class BravioMain

    Private Sub NexusMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RibbonControl.SelectedPage = Administracion
        CargaMenu()
        HideQuickBar()
    End Sub
    Public Sub CargaMenu()
        Dim Modulo As String
        Dim Opcion As String

        For Each Pagina As RibbonPage In RibbonControl.Pages
            Modulo = Pagina.Text
            Pagina.Visible = objMenu.IsMenuActivo(objMenu.User, Modulo)
            For Each grupo As RibbonPageGroup In Pagina.Groups
                Opcion = Mid(grupo.Name, 2)
                grupo.Visible = objMenu.IsMenuActivo(objMenu.User, Modulo, Opcion)
                For i = 0 To grupo.ItemLinks.Count - 1

                    If TypeOf grupo.ItemLinks(i) Is BarSubItemLink Then 'Menu
                        Dim menu As BarSubItemLink = grupo.ItemLinks(i)
                        Opcion = Mid(menu.Item.Name, 2)
                        menu.Visible = objMenu.IsMenuActivo(objMenu.User, Modulo, Opcion)
                        For Each submenu As BarButtonItemLink In menu.VisibleLinks
                            Opcion = Mid(submenu.Item.Name, 2)
                            submenu.Visible = objMenu.IsMenuActivo(objMenu.User, Modulo, Opcion)
                        Next
                    ElseIf TypeOf grupo.ItemLinks(i) Is BarButtonItemLink Then
                        Dim menu As BarButtonItemLink = grupo.ItemLinks(i)
                        Opcion = Mid(menu.Item.Name, 2)
                        menu.Visible = objMenu.IsMenuActivo(objMenu.User, Modulo, Opcion)
                    End If
                Next
            Next
        Next

    End Sub
    Public Sub HideQuickBar()
        qbNew.Visibility = BarItemVisibility.Never
        qbEdit.Visibility = BarItemVisibility.Never
        qbSave.Visibility = BarItemVisibility.Never
        qbDelete.Visibility = BarItemVisibility.Never
        qbFind.Visibility = BarItemVisibility.Never
        qbReport.Visibility = BarItemVisibility.Never
        qbUndo.Visibility = BarItemVisibility.Never
        qbBack.Visibility = BarItemVisibility.Never
        qbNext.Visibility = BarItemVisibility.Never
        qbExcel.Visibility = BarItemVisibility.Never
    End Sub
    Private Sub qbNew_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbNew.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.NuevoBase()
    End Sub
    Private Sub qbSave_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbSave.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.GuardarBase()
    End Sub
    Private Sub qbEdit_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbEdit.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.EditarBase()
    End Sub
    Private Sub qbDelete_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbDelete.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        Try
            obj.EliminarBase()
        Catch ex As Exception
            MsgBox("NO FUE POSIBLE ELIMINAR" + ex.Message(), MsgBoxStyle.Critical, "Nota")
        End Try
    End Sub
    Private Sub qbUndo_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbUndo.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.RevertirBase()
    End Sub
    Private Sub qbFind_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbFind.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.ConsultarBase()
    End Sub
    Private Sub qbReport_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbReport.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.ReporteBase()
    End Sub
    Private Sub qbBack_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbBack.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        Try
            obj.CargaControles(-1)
        Catch ex As Exception
            MsgBox("No se ha configurado éste proceso, consulte con I. T. O.", MsgBoxStyle.Information, "Nota")
        End Try
    End Sub
    Private Sub qbNext_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbNext.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        Try
            obj.CargaControles(1)
        Catch ex As Exception
            MsgBox("No se ha configurado éste proceso, consulte con I. T. O.", MsgBoxStyle.Information, "Nota")
        End Try
    End Sub
    Private Sub qbExcel_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles qbExcel.ItemClick
        Dim obj As Object = Me.ActiveMdiChild
        obj.ExcelBase()
    End Sub

    Private Sub CargaForma(ByVal forma As Object)
        forma.MdiParent = Me
        forma.rbMenu = Me
        forma.Show()
    End Sub
#Region "Administración"
    Private Sub a001001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001001.ItemClick
        CargaForma(adm_frmSeguridad)
    End Sub

    Private Sub a001002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001002.ItemClick
        CargaForma(adm_frmSetup)
    End Sub

    Private Sub a001003_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001003.ItemClick
        CargaForma(adm_frmFormasPagoCaja)
    End Sub

    Private Sub a001004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001004.ItemClick
        CargaForma(adm_frmTipoMovimientoCaja)
    End Sub

    Private Sub a001005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001005.ItemClick
        CargaForma(adm_frmCantones)
    End Sub

    Private Sub a001006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001006.ItemClick
        CargaForma(adm_frmActividades)
    End Sub

    Private Sub a001007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001007.ItemClick
        CargaForma(adm_frmProfesiones)
    End Sub
    Private Sub a001008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001009.ItemClick
        CargaForma(adm_frmCierreDia)
    End Sub
    Private Sub a001010_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001008.ItemClick
        CargaForma(adm_frmEditarPlantillas)
    End Sub
    Private Sub a001010_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001010.ItemClick
        CargaForma(adm_frmEnvioArchivo)
    End Sub
    Private Sub a001011_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001011.ItemClick
        CargaForma(adm_frmSucursales)
    End Sub
    Private Sub a001012_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001012.ItemClick
        CargaForma(adm_frmRecuperarArchivo)
    End Sub
    Private Sub a001013_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001013.ItemClick
        CargaForma(adm_frmAlertas)
    End Sub
    Private Sub a001014_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001014.ItemClick
        CargaForma(adm_frmFirmantes)
    End Sub
    Private Sub a001015_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001015.ItemClick
        CargaForma(adm_frmRevertirPlanilla)
    End Sub
    Private Sub a001016_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001016.ItemClick
        CargaForma(pre_frmAplicacionPlanillaConsolidada)
    End Sub
    Private Sub a001017_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001017.ItemClick
        CargaForma(adm_frmCierreDiaAnexo)
    End Sub
    Private Sub a001018_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001018.ItemClick
        CargaForma(adm_frmGenerarPartida)
    End Sub
    Private Sub a001019_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles a001019.ItemClick
        CargaForma(adm_frmGenerarPartidadiaria)
    End Sub
#End Region

#Region "Asociados"
    Private Sub b001001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001001.ItemClick
        CargaForma(aso_frmAsociados)
    End Sub
    Private Sub b001002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001002.ItemClick
        'pendiente de desarrollo
    End Sub

    Private Sub b001003_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        'pendiente de desarrollo
    End Sub

    Private Sub b001004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001004.ItemClick
        CargaForma(apo_frmRetirarSocio) 'CargaForma(apo_frmRetiroAsociados)  'apo_frmRetirarSocio
    End Sub
    Private Sub b001005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001005.ItemClick
        CargaForma(aso_frmUbicaciones)
    End Sub
    Private Sub b001006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001006.ItemClick
        CargaForma(aso_frmAyudaFuneraria)
    End Sub
    Private Sub b001007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b001007.ItemClick
        CargaForma(aso_frmCambioValorPresEfectivo)
    End Sub
    Private Sub b002006_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles b002006.ItemClick
        CargaForma(aso_frmAsociadosGenero)
    End Sub
    Private Sub b002001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002001.ItemClick
        CargaForma(aso_frmListadoAspirantes)
    End Sub

    Private Sub b002002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002002.ItemClick
        CargaForma(aso_frmListadoAsociadosActivos)
    End Sub

    Private Sub b002003_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002003.ItemClick
        CargaForma(aso_frmListadoAsociadosInactivos)
    End Sub

    Private Sub b002004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002004.ItemClick
        CargaForma(aso_frmListadoAsociadosRetirados)
    End Sub

    Private Sub b002005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002005.ItemClick
        CargaForma(aso_frmListadoGeneralAsociados)
    End Sub

    Private Sub b002007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002007.ItemClick
        CargaForma(aso_frmListadoIngresosAsociados)
    End Sub

    Private Sub b002008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002008.ItemClick
        CargaForma(aso_frmListadoIngresosAfiliaciones)
    End Sub
    Private Sub b002009_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002009.ItemClick
        CargaForma(aso_frmListadoAyudaFuneraria)
    End Sub
    Private Sub b002010_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002010.ItemClick
        CargaForma(aso_frmListadoAsociadosSinActividad)
    End Sub
    Private Sub b002011_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002011.ItemClick
        CargaForma(aso_frmListadoAsociadosSinAhoSinPres)
    End Sub
    Private Sub b002012_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002012.ItemClick
        CargaForma(aso_frmListadoAsociadosconDescMenor)
    End Sub
    Private Sub b002013_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002013.ItemClick
        CargaForma(aso_frmProgramacionSocio)
    End Sub
    Private Sub b002014_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002014.ItemClick
        CargaForma(aso_frmListadoCambioDescuentosSocio)
    End Sub
    Private Sub b002015_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002015.ItemClick
        CargaForma(aso_frmListadoReintegros)
    End Sub
    Private Sub b002016_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002016.ItemClick
        CargaForma(aso_frmListadoAsociadosSobregirados)
    End Sub
    Private Sub b002017_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002017.ItemClick
        CargaForma(aso_frmSaldosAsociados)
    End Sub
    Private Sub b002018_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles b002018.ItemClick
        CargaForma(aso_frmEstadoCuentaGeneral)
    End Sub
#End Region

#Region "Aportaciones"
    Private Sub c001001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles c001001.ItemClick
        CargaForma(apo_frmEliminaAportacion)
    End Sub

    Private Sub c001002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles c001002.ItemClick
        CargaForma(apo_frmLiquidacionAportacion) 'apo_frmLiquidacionAportacion
    End Sub
    Private Sub c001003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles c001003.ItemClick
        CargaForma(apo_frmLiquidacionAsociados)
    End Sub
    Private Sub c001004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles c001004.ItemClick
        CargaForma(apo_frmEliminaAyudaFuneraria)
    End Sub
    Private Sub c001005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles c001005.ItemClick
        CargaForma(apo_frmRevierteDividendos)
    End Sub

    Private Sub c002001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002001.ItemClick
        CargaForma(apo_frmEstadoCuentaAportacion)
    End Sub

    Private Sub c002002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002002.ItemClick
        CargaForma(apo_frmMovimientoFechaAportacion)
    End Sub

    Private Sub c002003_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002003.ItemClick
        CargaForma(apo_frmSaldosAsociados)
    End Sub

    Private Sub c002004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002004.ItemClick
        CargaForma(apo_frmAportacionesFechaSexo)
    End Sub

    Private Sub c002005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002005.ItemClick
        CargaForma(apo_frmRepartoDividendos)
    End Sub
    Private Sub c002006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002006.ItemClick
        CargaForma(apo_frmGenerarArchivoF915)
    End Sub
    Private Sub c002007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002007.ItemClick
        CargaForma(apo_frmEstadoCuentaAyuda)
    End Sub
    Private Sub c002008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002008.ItemClick
        CargaForma(apo_frmMovimientoFechaAyuda)
    End Sub
    Private Sub c002009_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002009.ItemClick
        CargaForma(apo_frmBoletasDividendos)
    End Sub
    Private Sub c002010_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002010.ItemClick
        CargaForma(apo_frmAportacionesPagarRetiros)
    End Sub
    Private Sub c002011_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles c002011.ItemClick
        CargaForma(apo_frmDividendosHistorico)
    End Sub

#End Region

#Region "Ahorros"
    Private Sub d001001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d001001.ItemClick
        CargaForma(aho_frmTiposCuenta)
    End Sub

    Private Sub d002001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002001.ItemClick
        CargaForma(aho_frmIngresoCuentas)
    End Sub

    Private Sub d002002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002002.ItemClick
        CargaForma(aho_frmEliminaComprob)
    End Sub

    Private Sub d002003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002003.ItemClick
        CargaForma(aho_frmPignoracionCuentas)
    End Sub

    Private Sub d002004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002004.ItemClick
        CargaForma(aho_frmRevertirPignoraciones)
    End Sub

    Private Sub d002005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002005.ItemClick
        CargaForma(aho_frmCapitalizacionIntereses)
    End Sub

    Private Sub d002006_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002006.ItemClick
        CargaForma(aho_frmRevierteCapitalizacion)
    End Sub
    Private Sub d002007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002007.ItemClick
        CargaForma(aho_frmLiberarFondos)
    End Sub
    Private Sub d002008_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002008.ItemClick
        CargaForma(aho_frmCambioTasaAhorro)
    End Sub
    Private Sub d002009_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002009.ItemClick
        CargaForma(aho_frmDevolucionAhorro)
    End Sub
    Private Sub d002010_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d002010.ItemClick
        CargaForma(aho_frmRevierteDevAhorro)
    End Sub

    Private Sub d003001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d003001.ItemClick
        CargaForma(aho_frmMovimientoCuenta)
    End Sub

    Private Sub d003002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d003002.ItemClick
        CargaForma(aho_frmListadoCuentas)
    End Sub

    Private Sub d003003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d003003.ItemClick
        CargaForma(aho_frmDetalleMovimientos)
    End Sub

    Private Sub d003004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003004.ItemClick
        CargaForma(aho_frmAcumuladoMovimientos)
    End Sub

    Private Sub d003005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003005.ItemClick
        CargaForma(aho_frmInteresesCuenta)
    End Sub

    Private Sub d003006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003006.ItemClick
        CargaForma(aho_frmListadoDepositosVencer)
    End Sub

    Private Sub d003008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003008.ItemClick
        CargaForma(aho_frmProvisionIntereses)
    End Sub

    Private Sub d003009_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003009.ItemClick
        CargaForma(aho_frmReporteCapitalizacion)
    End Sub

    Private Sub d003010_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003010.ItemClick
        CargaForma(aho_frmListadoCuentasMesTipo)
    End Sub

    Private Sub d003011_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003011.ItemClick
        CargaForma(aho_frmProvisionIsrInteres)
    End Sub

    Private Sub d003012_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003012.ItemClick
        CargaForma(aho_frmIsrAplicadoIntereses)
    End Sub
    Private Sub d003007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles d003007.ItemClick
        CargaForma(aho_frmListadoDepositosPlazo)
    End Sub
    Private Sub d003013_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003013.ItemClick
        CargaForma(aho_frmBoletasDevolucion)
    End Sub
    Private Sub d003014_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles d003014.ItemClick
        CargaForma(aho_frmPignoracionesCuenta)
    End Sub

#End Region

#Region "Préstamos"
    Private Sub e001001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e001001.ItemClick
        CargaForma(pre_frmTiposCredito)
    End Sub
    Private Sub e001002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e001002.ItemClick
        CargaForma(pre_frmLineas)
    End Sub
    Private Sub e001003_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001003.ItemClick
        CargaForma(pre_frmTecnicos)
    End Sub
    Private Sub e001004_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001004.ItemClick
        CargaForma(pre_frmFuentesFinanciamiento)
    End Sub
    Private Sub e001005_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001005.ItemClick
        CargaForma(pre_frmDeduccionesPrestamo)
    End Sub
    Private Sub e001006_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001006.ItemClick
        CargaForma(pre_frmCalculoCuotas)
    End Sub
    Private Sub e001007_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001007.ItemClick
        CargaForma(pre_frmFondosCaja)
    End Sub
    Private Sub e001008_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001008.ItemClick
        CargaForma(pre_frmFechasDescuentos)
    End Sub
    Private Sub e001009_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e001009.ItemClick
        CargaForma(pre_frmCierreFechasDescuentos)
    End Sub

    Private Sub e002001_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e002001.ItemClick
        CargaForma(pre_frmConsultaAsociados)
    End Sub

    Private Sub e002002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
        'pendiente de desarrollo
    End Sub

    Private Sub e002003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e002003.ItemClick
        CargaForma(pre_frmEstadoCuentaPrestamo)
    End Sub

    Private Sub e003001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003001.ItemClick
        CargaForma(pre_frmSolicitudPrestamo)
    End Sub

    Private Sub e003002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003004.ItemClick
        CargaForma(pre_frmSolicitudFondos)
    End Sub

    Private Sub e003003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003005.ItemClick
        CargaForma(pre_frmEliminaSolicitudFondos)
    End Sub

    Private Sub e003004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003006.ItemClick
        CargaForma(pre_frmAnulaDesembolsoPrestamo)
    End Sub

    Private Sub e003005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003007.ItemClick
        CargaForma(pre_frmAnularPago)
    End Sub

    Private Sub e003006_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003003.ItemClick
        CargaForma(pre_frmDocumentosCredito)
    End Sub

    Private Sub e004001001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001001.ItemClick
        CargaForma(pre_frmListadoSolicitudesPrestamo)
    End Sub

    Private Sub e004001002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001002.ItemClick
        CargaForma(pre_frmPrestamosRegistrados)
    End Sub

    Private Sub e004001003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001003.ItemClick
        CargaForma(pre_frmListadoGeneralPrestamos)
    End Sub

    Private Sub e004001004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004001004.ItemClick
        CargaForma(pre_frmListadoPrestamosCancelados)
    End Sub

    Private Sub e004001005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004001005.ItemClick
        CargaForma(pre_frmListadoFiadores)
    End Sub

    Private Sub e004001006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004001006.ItemClick
        CargaForma(pre_frmListadoDesembolsos)
    End Sub

    Private Sub e004001007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004001007.ItemClick
        CargaForma(pre_frmListadoGeneralPagos)
    End Sub

    Private Sub e004001008_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001008.ItemClick
        CargaForma(pre_frmListadoPagosLinea)
    End Sub

    Private Sub e004001009_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001009.ItemClick
        CargaForma(pre_frmEstadoCuentaPrestamo)
    End Sub

    Private Sub e004001010_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001010.ItemClick
        CargaForma(pre_frmPrestamosTipoGarantia)
    End Sub

    Private Sub e004001011_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001011.ItemClick
        CargaForma(pre_frmPrestamosTipoCredito)
    End Sub
    Private Sub e004001012_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001012.ItemClick
        CargaForma(pre_frmPrestamosSaldosFacturas)
    End Sub
    Private Sub e004001013_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001013.ItemClick
        CargaForma(pre_frmPrestamosFacCobradasCanceladas)
    End Sub
    Private Sub e004001014_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001014.ItemClick
        CargaForma(pre_frmListadoCruces)
    End Sub
    Private Sub e004001016_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001016.ItemClick
        CargaForma(pre_frmMovimientosRubros)
    End Sub
    Private Sub e004001017_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004001017.ItemClick
        CargaForma(pre_frmListadoPrestamosRapidos)
    End Sub


    Private Sub e004002001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002001.ItemClick
        CargaForma(pre_frmConsolidadoGeneralCartera)
    End Sub
    Private Sub e003007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003010.ItemClick
        CargaForma(pre_frmGeneracionCartas)
    End Sub
    Private Sub e003011_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003011.ItemClick
        CargaForma(pre_frmPrestamosEfectivo)
    End Sub
    Private Sub e003012_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003012.ItemClick
        CargaForma(pre_frmSolicitudCruces)
    End Sub
    Private Sub e004002002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002002.ItemClick
        CargaForma(pre_frmConsolidadoCarteraFuente)
    End Sub

    Private Sub e004002003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002003.ItemClick
        CargaForma(pre_frmConsolidadoCarteraLinea)
    End Sub

    Private Sub e004002004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002004.ItemClick
        CargaForma(pre_frmConsolidadoCarteraComunidad)
    End Sub

    Private Sub e004002005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002005.ItemClick
        CargaForma(pre_frmDetalleGeneralCartera)
    End Sub

    Private Sub e004003003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003003.ItemClick
        CargaForma(pre_frmReporteTecnicoLinea)
    End Sub

    Private Sub e004003002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003002.ItemClick
        CargaForma(pre_frmReporteTecnicoFuente)
    End Sub

    Private Sub e004003008_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003008.ItemClick
        CargaForma(pre_frmCuadroMora)
    End Sub

    Private Sub e003008_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003008.ItemClick
        CargaForma(pre_frmCambioTasaInteres)
    End Sub

    'Private Sub e003009_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003009.ItemClick
    '    CargaForma(pre_frmTrasladoPrestamos)
    'End Sub

    Private Sub e004004001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004004001.ItemClick
        CargaForma(pre_frmResumenIngresosEgresos)
    End Sub

    Private Sub e003009001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003009001.ItemClick
        CargaForma(pre_frmTrasladoPrestamos)
    End Sub
    Private Sub e003009002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003009002.ItemClick
        CargaForma(pre_frmGenerarArchivoInfored)
    End Sub
    Private Sub e003009003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e003009003.ItemClick
        CargaForma(pre_frmInformeAseguradora)
    End Sub


    ' reportes de préstamos
    Private Sub e004002007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004002007.ItemClick
        CargaForma(pre_frmDetalleCarteraLinea)
    End Sub
    Private Sub e004003007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003007.ItemClick
        CargaForma(pre_frmClientesPorTecnico)
    End Sub

    Private Sub e004004002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004004002.ItemClick
        CargaForma(pre_frmCorteCaja)
    End Sub

    Private Sub e004004003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004004003.ItemClick
        CargaForma(pre_frmIngresosEgresos)
    End Sub
    Private Sub e004004004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004004004.ItemClick
        CargaForma(pre_frmInformeRemesas)
    End Sub



    Private Sub e004005001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004005001.ItemClick
        CargaForma(pre_frmAntiguedadGeneral)
    End Sub
    Private Sub e004005002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004005002.ItemClick
        CargaForma(pre_frmAntiguedadFuente)
    End Sub
    Private Sub e004005003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004005003.ItemClick
        CargaForma(pre_frmAntiguedadTecnicoLinea)
    End Sub

    Private Sub e004005004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004005004.ItemClick
        CargaForma(pre_frmAntiguedadPlazoLinea)
    End Sub



    Private Sub e004002006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004002006.ItemClick
        CargaForma(pre_frmDetalleCarteraFuente)
    End Sub

    Private Sub e004002008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004002008.ItemClick
        CargaForma(pre_frmDetalleCarteraComunidad)
    End Sub

    Private Sub e004003001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004003001.ItemClick
        CargaForma(pre_frmConsolidadoCarteraTecnico)
    End Sub

    Private Sub e004003004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003004.ItemClick
        CargaForma(pre_frmReporteTecnicoCanton)
    End Sub

    Private Sub e004003005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003005.ItemClick
        CargaForma(pre_frmDetalleClasificacionTecnico)
    End Sub

    Private Sub e004003006_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles e004003006.ItemClick
        CargaForma(pre_frmPrestamosPorVencerTecnico)
    End Sub

    Private Sub e003002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e003002.ItemClick
        CargaForma(pre_frmResolucionesCredito)
    End Sub

    Private Sub e003009004_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e003009004.ItemClick
        CargaForma(pre_frmActualizaPrestamo)
    End Sub
    Private Sub e003009005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e003009005.ItemClick
        CargaForma(pre_frmAplicarReintegros)
    End Sub

    Private Sub e004006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004006.ItemClick
        CargaForma(pre_frmReportesEstadisticos)
    End Sub

    Private Sub e004005005_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004005005.ItemClick
        CargaForma(pre_frmConsolidadoCreditosVencidos)
    End Sub

    Private Sub e004005006_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004005006.ItemClick
        CargaForma(pre_frmProyeccionRecuperaciones)
    End Sub

    Private Sub e004007_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004007.ItemClick
        CargaForma(pre_frmListadoLiquidacionCaja)
    End Sub
    Private Sub e004008_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles e004008.ItemClick
        CargaForma(pre_frmAplicacionPlanilla)
    End Sub

#End Region

#Region "Consultas y Reportes"
    Private Sub g001001_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001001.ItemClick
        CargaForma(pre_frmProvisionIntereses)
    End Sub
    Private Sub g001002_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001002.ItemClick
        CargaForma(pre_frmReportesAuditoria)
    End Sub
    Private Sub g001003_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001003.ItemClick
        CargaForma(pre_frmGenerador)
    End Sub
    Private Sub g001004_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001004.ItemClick
        CargaForma(aho_frmListadoCuentasInactivas)
    End Sub
    Private Sub g001005_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001005.ItemClick
        CargaForma(con_frmInformeGerencial1)
    End Sub
    Private Sub g001006_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001006.ItemClick
        CargaForma(con_frmAnalisisDepositosPlazo)
    End Sub

    Private Sub g001007_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles g001007.ItemClick
        CargaForma(con_frmReporteLiquidez)
    End Sub
#End Region

#Region "Caja"
    Private Sub f001001_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001001.ItemClick
        frmCuotasAfiliacion.MdiParent = Me
        frmCuotasAfiliacion.Show()
    End Sub

    Private Sub f001002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001002.ItemClick
        frmAportaciones.MdiParent = Me
        frmAportaciones.Show()
    End Sub

    Private Sub f001003_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001003.ItemClick
        frmPagos.MdiParent = Me
        frmPagos.Show()
    End Sub

    Private Sub f001004_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001004.ItemClick
        FrmDepositos.MdiParent = Me
        FrmDepositos.Show()
    End Sub
    Private Sub f001005_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001005.ItemClick
        frmOtrosIngresos.MdiParent = Me
        frmOtrosIngresos.Show()
    End Sub
    Private Sub f001006_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f001006.ItemClick
        frmAyudaFuneraria.MdiParent = Me
        frmAyudaFuneraria.Show()
    End Sub
    Private Sub f002001_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f002001.ItemClick
        frmRetiros.MdiParent = Me
        frmRetiros.Show()
    End Sub

    Private Sub f002002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f002002.ItemClick
        frmCancelacionCuentas.MdiParent = Me
        frmCancelacionCuentas.Show()
    End Sub

    Private Sub f002003_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f002003.ItemClick
        frmRetiroAportaciones.MdiParent = Me
        frmRetiroAportaciones.Show()
    End Sub

    Private Sub f002004_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f002004.ItemClick
        frmOtrosEgresos.MdiParent = Me
        frmOtrosEgresos.Show()
    End Sub
    Private Sub f002005_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f002005.ItemClick
        frmIngresoDesembolsos.MdiParent = Me
        frmIngresoDesembolsos.Show()
    End Sub

    Private Sub f003001_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f003001.ItemClick
        pre_frmConsultaAsociados.MdiParent = Me
        pre_frmConsultaAsociados.Show()

    End Sub

    Private Sub f003002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f003002.ItemClick
        'apo_frmEstadoCuentaAportacion.MdiParent = Me
        'apo_frmEstadoCuentaAportacion.Show()
        CargaForma(apo_frmEstadoCuentaAportacion)
    End Sub

    Private Sub f003003_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f003003.ItemClick
        'pre_frmEstadoCuentaPrestamo.MdiParent = Me
        'pre_frmEstadoCuentaPrestamo.Show()
        CargaForma(pre_frmEstadoCuentaPrestamo)
    End Sub

    Private Sub f003004_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f003004.ItemClick
        'aho_frmMovimientoCuenta.MdiParent = Me
        'aho_frmMovimientoCuenta.Show()
        CargaForma(aho_frmMovimientoCuenta)
    End Sub
    Private Sub f003005_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f003005.ItemClick
        'pre_frmCalculoCuotas.MdiParent = Me
        'pre_frmCalculoCuotas.Show()
        CargaForma(pre_frmCalculoCuotas)
    End Sub

    Private Sub f004001_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f004001.ItemClick
        frmEliminaOtrosEgresos.MdiParent = Me
        frmEliminaOtrosEgresos.Show()
    End Sub

    Private Sub f004002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f004002.ItemClick
        frmEliminarOtrosIngresos.MdiParent = Me
        frmEliminarOtrosIngresos.Show()
    End Sub

    Private Sub f004003_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f004003.ItemClick
        frmEliminaOperacionCaja.MdiParent = Me
        frmEliminaOperacionCaja.Show()
    End Sub

    Private Sub f004004_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f004004.ItemClick
        frmEliminarCuotasAfiliacion.MdiParent = Me
        frmEliminarCuotasAfiliacion.Show()
    End Sub

    Private Sub f005001001_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001001.ItemClick
        frmPreCorteCaja.MdiParent = Me
        frmPreCorteCaja.Show()
    End Sub
    Private Sub f005001002_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001002.ItemClick
        frmCorteCaja.MdiParent = Me
        frmCorteCaja.Show()
    End Sub
    Private Sub f005001003_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001003.ItemClick
        frmRptIngresosEgresos.MdiParent = Me
        frmRptIngresosEgresos.Show()
    End Sub
    Private Sub f005001004_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001004.ItemClick
        frmActualizacionLibretaAportacion.MdiParent = Me
        frmActualizacionLibretaAportacion.Show()

    End Sub
    Private Sub f005001005_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001005.ItemClick
        frmActualizacionLibretaAhorro.MdiParent = Me
        frmActualizacionLibretaAhorro.Show()

    End Sub
    Private Sub f005001006_ItemClick_1(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles f005001006.ItemClick
        frmActualizarLibretaPrestamo.MdiParent = Me
        frmActualizarLibretaPrestamo.Show()
    End Sub
#End Region

#Region "Indicadores"
    Private Sub h001001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles h001001.ItemClick
        CargaForma(ind_frmParametros)
    End Sub

    Private Sub i001001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles i002001.ItemClick
        CargaForma(ind_frmGeneraIndicadores)
    End Sub

    Private Sub i001002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles i002002.ItemClick
        CargaForma(ind_frmCalcularIndicadores)
    End Sub

    Private Sub j001001_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles j003001.ItemClick
        CargaForma(ind_frmComparativoAnualColac)
    End Sub

    Private Sub j001002_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles j003002.ItemClick
        CargaForma(ind_frmGenerador)
    End Sub

#End Region


    Private Sub a001020_ItemClick(sender As Object, e As ItemClickEventArgs) Handles a001020.ItemClick
        CargaForma(aso_frmInformeTelefonia)
    End Sub

    Private Sub g001008_ItemClick(sender As Object, e As ItemClickEventArgs) Handles g001008.ItemClick
        CargaForma(con_frmInteresesAnuales)
    End Sub
End Class