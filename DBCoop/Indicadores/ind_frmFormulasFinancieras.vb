Imports DBCoopBL
Imports DBCoopEL.TableEntities
Public Class ind_frmFormulasFinancieras
    Dim bl As New IndicadoresBLL()
    Dim entFormulaFinanciera As New List(Of col_FormulasFinancieras)
    Dim dt As DataTable
    Dim _IdFormula As Integer = 0
    Public Property IdFormula() As Integer
        Get
            Return _IdFormula
        End Get
        Set(ByVal value As Integer)
            _IdFormula = value
        End Set
    End Property
    Dim _cIndice As String = ""
    Public Property cIndice() As String
        Get
            Return _cIndice
        End Get
        Set(ByVal value As String)
            _cIndice = value
        End Set
    End Property

    Private Sub ind_frmFormulasFinancieras_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        entFormulaFinanciera.Clear()
        teFormula.EditValue = ""
        LblCuenta.Visible = True
        LblValor.Visible = False
        teValor.Visible = False
        beCta01.Visible = True
        teValor.EditValue = 0.0
        rgTipoOperacion.EditValue = CInt(1)
        CargaControles()
    End Sub

    Private Sub CargaControles()
        Me.Text = cIndice
        dt = bl.Get_FormulasFinancieras(IdFormula)
        For Each row As DataRow In dt.Rows
            teFormula.EditValue = teFormula.EditValue + LTrim(row.Item("Descripcion")) + " "
        Next
    End Sub

    Private Sub sbGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbGuardar.Click
        CargaEntidades()
        Dim msj As String = ""
        If teFormula.EditValue = "" Then
            msj = bl.EliminaFormulaFinanciera(IdFormula)
            If msj = "" Then
                MsgBox("La Formula Financiera ha sido Eliminada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible Eliminar la Formula {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        Else
            msj = bl.InsertaFormulaFinanciera(entFormulaFinanciera, IdFormula)
            If msj = "" Then
                MsgBox("La Formula Financiera ha sido guardada con éxito", MsgBoxStyle.Information)
            Else
                MsgBox(String.Format("No fue posible actualizar la Formula {0}{1}", Chr(13), msj), MsgBoxStyle.Critical)
                Return
            End If
        End If
        Close()
    End Sub

    Private Sub CargaEntidades()
        For Each row As DataRow In dt.Rows
            Dim entFormula As New col_FormulasFinancieras
            entFormula.Id = 1
            entFormula.IdFormula = IdFormula
            entFormula.Descripcion = row.Item("Descripcion")
            entFormula.ValorFormula = row.Item("ValorFormula")
            entFormula.TipoValor = row.Item("TipoValor")
            entFormulaFinanciera.Add(entFormula)
        Next
    End Sub

    Private Sub rgTipoOperacion_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rgTipoOperacion.EditValueChanged
        If rgTipoOperacion.EditValue = 1 Then
            LblCuenta.Visible = True
            LblValor.Visible = False
            teValor.Visible = False
            beCta01.Visible = True
        Else
            LblCuenta.Visible = False
            LblValor.Visible = True
            teValor.Visible = True
            beCta01.Visible = False
        End If
    End Sub

    Private Sub teValor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles teValor.KeyDown
        If e.KeyValue = 13 Then
            teFormula.EditValue = teFormula.EditValue + LTrim((teValor.EditValue).ToString)
            Dim workRow As DataRow
            workRow = dt.NewRow()
            workRow("Id") = 1
            workRow("IdFormula") = IdFormula
            workRow("ValorFormula") = LTrim((teValor.EditValue).ToString)
            workRow("Descripcion") = LTrim((teValor.EditValue).ToString)
            workRow("TipoValor") = 2
            dt.Rows.Add(workRow)
            teValor.EditValue = 0.0
        End If
    End Sub

    Private Sub sbSuma_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbSuma.Click
        teFormula.EditValue = teFormula.EditValue + " + "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = "+"
        workRow("Descripcion") = "+"
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub

    Private Sub sbResta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbResta.Click
        teFormula.EditValue = teFormula.EditValue + " - "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = "-"
        workRow("Descripcion") = "-"
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub

    Private Sub sbMulti_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbMulti.Click
        teFormula.EditValue = teFormula.EditValue + " * "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = "*"
        workRow("Descripcion") = "*"
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub

    Private Sub sbAbreParentesis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAbreParentesis.Click
        teFormula.EditValue = teFormula.EditValue + " ( "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = "("
        workRow("Descripcion") = "("
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub

    Private Sub sbCierraParentesis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbCierraParentesis.Click
        teFormula.EditValue = teFormula.EditValue + " ) "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = ")"
        workRow("Descripcion") = ")"
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub

    Private Sub beCta01_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles beCta01.ButtonClick
        Dim entCuentas As con_Cuentas
        beCta01.EditValue = ""
        entCuentas = objConsultas.cnsCuentas(frmConsultas, beCta01.EditValue)
        beCta01.EditValue = entCuentas.IdCuenta
    End Sub

    Private Sub beCta01_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles beCta01.KeyDown
        If e.KeyValue = 13 Then
            Dim entCuentas As con_Cuentas
            entCuentas = objTablas.con_CuentasSelectByPK(beCta01.EditValue)
            If entCuentas.Nombre <> "" Then
                teFormula.EditValue = teFormula.EditValue + LTrim(entCuentas.Nombre) + " "
                Dim workRow As DataRow
                workRow = dt.NewRow()
                workRow("Id") = 1
                workRow("IdFormula") = IdFormula
                workRow("ValorFormula") = LTrim((beCta01.EditValue).ToString)
                workRow("Descripcion") = LTrim(entCuentas.Nombre)
                workRow("TipoValor") = 1
                dt.Rows.Add(workRow)
                beCta01.EditValue = ""
            End If
        End If
    End Sub

    Private Sub sbLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbLimpiar.Click
        teFormula.EditValue = ""
        dt.Clear()
    End Sub

    Private Sub sbDivision_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbDivision.Click
        teFormula.EditValue = teFormula.EditValue + " / "
        Dim workRow As DataRow
        workRow = dt.NewRow()
        workRow("Id") = 1
        workRow("IdFormula") = IdFormula
        workRow("ValorFormula") = "/"
        workRow("Descripcion") = "/"
        workRow("TipoValor") = 3
        dt.Rows.Add(workRow)
    End Sub
End Class