Imports System.Math
Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class pre_frmActualizaPrestamo
    Dim blPres As New PrestamosBLL()
    Dim blAdmon As New AdmonBLL()
    Dim entPago As coo_PrestamosDetalle
    Dim entAsociado As coo_Asociados
    Dim entProgramacion As List(Of coo_PrestamosDetalleDescuentos)

    Private Sub pre_frmActualizaPrestamo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        btNumPrestamo.Focus()
    End Sub

    Private Sub pre_frmActualizaPrestamo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub pre_frmActualizaPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        objCombos.coo_Lineas(leLinea, "")
        objCombos.coo_Tecnicos(leTecnico, "")
        objCombos.coo_Fuentes(leFuente, "")
        objCombos.adm_Cantones(leCanton, "", "")
    End Sub

    Private Sub btIdPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btNumPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        btNumPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        btNumPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub btNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btNumPrestamo.Validated
        If SiEsNulo(btNumPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If

        Dim entPrestamo = blPres.coo_PrestamosSelectByNumero(btNumPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If teIdPrestamo.EditValue = 0 Or entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If
        entAsociado = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)
        With entPrestamo
            _Cliente.EditValue = entAsociado.Nombres & " " & entAsociado.Apellidos
            teMontoPrestamo.EditValue = .MontoAprobado
            _FechaOtorgamiento.EditValue = .FechaOtorgado
            _FechaPrimerPago.EditValue = .FechaPrimerPago
            leLinea.EditValue = .IdLinea
            leTecnico.EditValue = .IdTecnico
            leFuente.EditValue = .IdFuente
            leCanton.EditValue = .IdCanton
            teGestion.EditValue = .CuotaGestion
            rgFormaPago.EditValue = .IdFormaPago
            rgTipoAplicacion.EditValue = .IdTipoAplicacion
            teValorCuota.EditValue = .ValorCuota
        End With
        'If entPrestamo.TasaInteres > 0.0 Then
        '    Me.GridColumn15.OptionsColumn.ReadOnly = True
        '    Me.gcValorCol.OptionsColumn.ReadOnly = True
        'Else
        '    Me.GridColumn15.OptionsColumn.ReadOnly = False
        '    Me.gcValorCol.OptionsColumn.ReadOnly = False
        'End If
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSalir.Click
        Close()
    End Sub

    Private Sub sbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btAceptar.Click
        Dim msj As String = ""
        Dim entPres2 As New coo_Prestamos
        If teIdPrestamo.EditValue <= 0 Then
            Exit Sub
        End If

        DatosValidos()

        If Not DatosValidos() Then
            Exit Sub
        End If

        LlenarEntidad()

        entPres2 = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)
        If MsgBox("Está seguro(a) de Actualizar los Datos del Préstamo?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
            msj = blPres.ActualizaPrestamo(teIdPrestamo.EditValue, leLinea.EditValue, leTecnico.EditValue, _
                         leFuente.EditValue, leCanton.EditValue, objMenu.User, teGestion.EditValue, _FechaPrimerPago.EditValue, rgFormaPago.EditValue, rgTipoAplicacion.EditValue, teValorCuota.EditValue)
            If msj = "" Then
                MsgBox("El préstamo fue Actualizado con éxito", MsgBoxStyle.Information)
            Else
                MsgBox("No fue posible actualizar el préstamo" + Chr(13) + msj, MsgBoxStyle.Critical, "Error al elminar el registro")
            End If
        End If
        Close()
    End Sub

    Function DatosValidos() As Boolean
        Dim entPrestamo = objTablas.coo_PrestamosSelectByPK(teIdPrestamo.EditValue)

        'If entPrestamo.TasaInteres > 0.0 Then
        '    MsgBox(String.Format("El prestamo tiene interes.{0}Imposible Continuar", Chr(13)), MsgBoxStyle.Critical, "Error al Guardar")
        '    Return False
        'End If

        Dim entAsociado As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entPrestamo.IdAsociado)


        Return True
    End Function

    Private Sub LlenarEntidad()

    End Sub


End Class