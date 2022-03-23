Imports DBCoopBL
Imports DBCoopEL.TableEntities
Imports DevExpress.XtraGrid.Columns
Imports System.Math
Public Class aho_frmPignoracionCuentas
    Dim blAhorro As New AhorrosBLL()
    Dim bl As New AdmonBLL()
    Dim blPres As New PrestamosBLL()
    Dim blFun As New FuncionesBLL()

    Private Sub beNumeroCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuenta.Click
        frmConsultaCuentasAhorro.ShowDialog()
        beNumeroCuenta.EditValue = frmConsultaCuentasAhorro.Numero
        teIdCuenta.EditValue = frmConsultaCuentasAhorro.IdCuenta
        beNumeroCuenta_Validated(e, New EventArgs)
    End Sub

    Private Sub beNumeroCuenta_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles beNumeroCuenta.Validated
        Dim entPignorado As New coo_Pignoraciones
        If beNumeroCuenta.EditValue = "" Then
            teIdCuenta.EditValue = 0
            Exit Sub
        End If
        teIdCuenta.EditValue = blAhorro.ObtenerIdCuentaByNumero(beNumeroCuenta.EditValue)
        If teIdCuenta.EditValue = 0 Then
            MsgBox("No existe la cuenta especificada", MsgBoxStyle.Exclamation, "Nota")
            beNumeroCuenta.EditValue = ""
            teIdCuenta.EditValue = 0
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        entPignorado = blAhorro.coo_PignoracionesSelectByCuenta(teIdCuenta.EditValue)
        If entPignorado.IdCuenta > 0 Then
            MsgBox("La Cuenta ya ha sido Pignorada", MsgBoxStyle.Exclamation, "Nota")
            beNumeroCuenta.EditValue = ""
            teIdCuenta.EditValue = 0
            beNumeroCuenta.Focus()
            Exit Sub
        End If


        Dim entCuenta As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        Dim entAsociados As coo_Asociados = objTablas.coo_AsociadosSelectByPK(entCuenta.IdAsociado)
        teAsociado.EditValue = String.Format("{0}, {1} {2}", entCuenta.Numero, entAsociados.Nombres, entAsociados.Apellidos)

        Dim UltMov As coo_UltMovAhorro = blAhorro.coo_UltMovAhorroSelectBy(teIdCuenta.EditValue)
        Dim entMov As coo_CuentasAhorroMov = objTablas.coo_CuentasAhorroMovSelectByPK(teIdCuenta.EditValue, UltMov.IdMov)

        If entMov.IdCuenta = 0 Then
            MsgBox("La cuenta no Existe", MsgBoxStyle.Critical, "Nota")
            Exit Sub
        End If
        teValor.EditValue = entMov.Saldo
        teSaldo.EditValue = entMov.Saldo
    End Sub

    Private Sub ahor_frmPignoracionCuentas_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        beNumeroCuenta.Focus()
    End Sub

    Private Sub ahor_frmPignoracionCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub

    Private Sub btNumPrestamo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btNumPrestamo.ButtonClick
        frmConsultaPrestamos.ShowDialog()
        btNumPrestamo.EditValue = frmConsultaPrestamos.NumPrestamo
        btNumPrestamo_Validated(e, New EventArgs)
    End Sub

    Private Sub btNumPrestamo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles btNumPrestamo.Validated
        Dim IdMov As Integer
        Dim entPago As New coo_PrestamosDetalle
        If SiEsNulo(btNumPrestamo.EditValue, "") = "" Then
            Exit Sub
        End If
        Dim entPrestamo = blPres.coo_PrestamosSelectByNumero(btNumPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If teIdPrestamo.EditValue = 0 Or entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If
        IdMov = blPres.GetUltMovPrestamo(entPrestamo.IdPrestamo)
        entPago = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, IdMov)
        Dim entCuenta As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entPago.SaldoCapital <= 0.0 Then
            MsgBox("El Prestamo ya esta Cancelado", MsgBoxStyle.Exclamation, "Nota")
            btNumPrestamo.EditValue = ""
            teIdPrestamo.EditValue = 0
            Exit Sub
        End If
        If entCuenta.IdAsociado <> entPrestamo.IdAsociado Then
            MsgBox("El Prestamo no Pertenece al Asociado", MsgBoxStyle.Exclamation, "Nota")
            btNumPrestamo.EditValue = ""
            teIdPrestamo.EditValue = 0
            Exit Sub
        End If
        With entPago
            _FechaOtorgamiento.EditValue = entPrestamo.FechaOtorgado
            deFechaVencimiento.EditValue = entPrestamo.FechaVencimiento
            teMontoOtorgado.EditValue = entPrestamo.MontoDesembolsado
            teSaldoCapital.EditValue = entPago.SaldoCapital
        End With
    End Sub

    Private Sub sbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAceptar.Click
        Dim msj As String = ""
        Dim IdMov As Integer
        Dim entPago As New coo_PrestamosDetalle
        Dim entPignorado As New coo_Pignoraciones
        If teIdCuenta.EditValue = 0 Then
            MsgBox("No existe la cuenta especificada", MsgBoxStyle.Exclamation, "Nota")
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        entPignorado = blAhorro.coo_PignoracionesSelectByCuenta(teIdCuenta.EditValue)
        If entPignorado.IdCuenta > 0 Then
            MsgBox("La Cuenta ya ha sido Pignorada", MsgBoxStyle.Exclamation, "Nota")
            beNumeroCuenta.Focus()
            Exit Sub
        End If
        If teValor.EditValue > teSaldo.EditValue Then
            MsgBox("El Valor a Pignorar es Mayor al Saldo de la Cuenta", MsgBoxStyle.Exclamation, "Nota")
            teValor.Focus()
            Exit Sub
        End If
        Dim entPrestamo = blPres.coo_PrestamosSelectByNumero(btNumPrestamo.EditValue)
        teIdPrestamo.EditValue = entPrestamo.IdPrestamo
        If teIdPrestamo.EditValue = 0 Or entPrestamo.IdPrestamo = 0 Then
            Exit Sub
        End If
        IdMov = blPres.GetUltMovPrestamo(entPrestamo.IdPrestamo)
        entPago = objTablas.coo_PrestamosDetalleSelectByPK(entPrestamo.IdPrestamo, IdMov)
        Dim entCuenta As coo_CuentasAhorro = objTablas.coo_CuentasAhorroSelectByPK(teIdCuenta.EditValue)
        If entPago.SaldoCapital <= 0.0 Then
            MsgBox("El Prestamo ya esta Cancelado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If
        If entCuenta.IdAsociado <> entPrestamo.IdAsociado Then
            MsgBox("El Prestamo no Pertenece al Asociado", MsgBoxStyle.Exclamation, "Nota")
            Exit Sub
        End If

        Dim entPignoracion As New coo_Pignoraciones
        With entPignoracion
            .IdPignoracion = 0
            .IdSolicitud = entPrestamo.IdSolicitud
            .IdPrestamo = teIdPrestamo.EditValue
            .IdCuenta = teIdCuenta.EditValue
            .IdAsociado = entPrestamo.IdAsociado
            .Valor = teValor.EditValue
            .Activa = True
            .Manual = True
            .FechaReversion = Nothing
            .RevertidoPor = Nothing
            .CreadoPor = objMenu.User
            .FechaPignoracion = blFun.GetFechaContable(gIdSucursal)
            .FechaHoraCreacion = Today
        End With

        msj = blAhorro.InsertaPignoracion(entPignoracion)

        If msj = "" Then
            MsgBox("La Pignoración ha sido aplicada con éxito" + Chr(13), MsgBoxStyle.Information, "Nota")
        Else
            MsgBox("No fue posible guardar la Pignoración" + Chr(13) + msj, MsgBoxStyle.Critical)
            Return
        End If
        Close()
    End Sub
End Class
