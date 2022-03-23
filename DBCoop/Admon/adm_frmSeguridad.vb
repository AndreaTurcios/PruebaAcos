Imports DevExpress.XtraReports.UI
Imports DBCoopBL
Imports DevExpress.XtraNavBar


Public Class adm_frmSeguridad

    Dim el As New TableBusiness()
    Dim bl As New AdmonBLL()
    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaModulos()
        CargaUsuarios()
        Me.Refresh()
        TreeViewMenu.Visible = True
    End Sub

    Private Sub CargaModulos()
        Dim dt = bl.GetModulos()
        For Each fila As DataRow In dt.Rows
            Dim item As New NavBarItem
            item.Caption = fila.Item("Nombre").ToString
            item.LargeImageIndex = 0
            item.SmallImageIndex = 0
            nvModulos.ItemLinks.Add(item)
        Next
        lblModulo.Text = "S/N"
    End Sub

    Private Sub CargaUsuarios()
        Dim dt = bl.GetUsuarios()
        nvUsuarios.ItemLinks.Clear()
        For Each fila As DataRow In dt.Rows
            Dim item As New NavBarItem
            item.Caption = fila.Item("IdUsuario").ToString
            item.LargeImageIndex = 1
            item.SmallImageIndex = 1
            nvUsuarios.ItemLinks.Add(item)
        Next
        nvUsuarios.SelectedLinkIndex = 0
        nvUsuarios.SelectedLink = nvUsuarios.ItemLinks(0)
        lblUsuario.Text = "S/N"
    End Sub

    Private Function GetPermisoUsuario(ByVal OptionId As String) As DataTable
        Return bl.GetPermisosUsuario(lblUsuario.Text, lblModulo.Text, OptionId)
    End Function
    Dim arregloPermisos(0, 2) As Boolean

    Private Sub GetMenu(ByVal ModuloName As String)

        TreeViewMenu.Nodes.Clear()
        Dim dt = bl.getOpciones(ModuloName, "")

        Dim CaracteresPorNivel As Integer = 3

        Dim RowCount As Integer = dt.Rows.Count

        Dim objNodo(RowCount - 1) As TreeNode
        'Dim arregloPermisos(RowCount - 1, 2)
        ReDim arregloPermisos(RowCount - 1, 2)

        Dim i As Integer = 0

        For Each fila As DataRow In dt.Rows
            objNodo(i) = New TreeNode
            objNodo(i).Name = fila.Item("IdOpcion")
            objNodo(i).Text = fila.Item("Nombre")
            objNodo(i).Tag = i

            Dim dtPermisos As DataTable = GetPermisoUsuario(fila.Item("IdOpcion"))
            If dtPermisos.Rows.Count > 0 Then
                objNodo(i).Checked = True
                arregloPermisos(i, 0) = dtPermisos.Rows(0).Item("SnInsert")
                arregloPermisos(i, 1) = dtPermisos.Rows(0).Item("SnDelete")
                arregloPermisos(i, 2) = dtPermisos.Rows(0).Item("SnEdit")
            End If
            i += 1
        Next

        i = 0

        For Each fila As DataRow In dt.Rows
            Dim largoMenu As Integer = CType(fila.Item("IdOpcion"), String).Length

            If largoMenu = CaracteresPorNivel Then
                TreeViewMenu.Nodes.Add(objNodo(i))
            Else
                TreeViewMenu.SelectedNode = objNodo(GetNodoPadre(fila.Item("IdOpcion"), dt))
                TreeViewMenu.SelectedNode.Nodes.Add(objNodo(i))
            End If
            i += 1
        Next
        TreeViewMenu.ExpandAll()
    End Sub

    Private Function GetNodoPadre(ByVal nivel As String, ByVal dt As DataTable) As Integer
        Dim i As Integer = 0
        For Each fila As DataRow In dt.Rows
            Dim largo As Integer = nivel.Length
            If nivel.Substring(0, largo - 3) = fila.Item("IdOpcion") Then
                GetNodoPadre = i
                Exit Function
            End If
            i += 1
        Next
    End Function

    Private Sub nvModulos_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nvModulos.ItemChanged
        Try
            lblModulo.Text = nvModulos.SelectedLink.Caption
        Catch ex As Exception

        End Try
    End Sub

    Private Sub nvUsuarios_ItemChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nvUsuarios.ItemChanged
        Try
            lblUsuario.Text = nvUsuarios.SelectedLink.Caption
        Catch ex As Exception

        End Try
    End Sub


    Private Sub cmdGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGuardar.Click
        bl.Elimina_Opciones_Usuario(lblUsuario.Text, lblModulo.Text)

        For Each nodo As TreeNode In TreeViewMenu.Nodes
            If nodo.Checked Then
                Debug.Print(nodo.Name)
                bl.Inserta_Opcion_Usuario(lblUsuario.Text, lblModulo.Text, _
                                    nodo.Name, _
                                    arregloPermisos(nodo.Tag, 0), _
                                    arregloPermisos(nodo.Tag, 1), _
                                    arregloPermisos(nodo.Tag, 2))



            End If
            If nodo.Nodes.Count > 0 Then
                RecorreNodos(nodo)
            End If
        Next

        TreeViewMenu.Nodes.Clear()
        cmdGuardar.Visible = False
        cmdCancelar.Visible = False
        NavBar.Enabled = True
        ShowCheckboxes(False)
    End Sub

    Private Sub RecorreNodos(ByVal nodo As TreeNode)
        For Each subNodo As TreeNode In nodo.Nodes
            If subNodo.Checked Then
                Debug.Print(subNodo.Name)
                bl.Inserta_Opcion_Usuario(lblUsuario.Text, lblModulo.Text, _
                                    subNodo.Name, _
                                    arregloPermisos(subNodo.Tag, 0), _
                                    arregloPermisos(subNodo.Tag, 1), _
                                    arregloPermisos(subNodo.Tag, 2))
            End If
            If subNodo.Nodes.Count > 0 Then
                RecorreNodos(subNodo)
            End If
        Next
    End Sub

    Private Sub TreeViewMenu_AfterCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewMenu.AfterCheck
        TreeViewMenu.SelectedNode = e.Node
        If e.Node.Checked Then
            For Each nodo As TreeNode In e.Node.Nodes
                nodo.Checked = True
            Next
        Else
            For Each nodo As TreeNode In e.Node.Nodes
                nodo.Checked = False
            Next
        End If

        If e.Node.Checked Then
            ShowCheckboxes(True)
            lblMenu.Text = e.Node.Text
            TreeViewMenu.SelectedNode = e.Node
            CheckBoxInsert.Checked = arregloPermisos(e.Node.Tag, 0)
            CheckBoxDelete.Checked = arregloPermisos(e.Node.Tag, 1)
            CheckBoxUpdate.Checked = arregloPermisos(e.Node.Tag, 2)
        Else
            lblMenu.Text = ""
            ShowCheckboxes(False)
            arregloPermisos(e.Node.Tag, 0) = False
            arregloPermisos(e.Node.Tag, 1) = False
            arregloPermisos(e.Node.Tag, 2) = False
        End If
    End Sub

    Private Sub TreeViewMenu_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeViewMenu.AfterSelect
        If e.Node.Checked Then
            CheckBoxInsert.Visible = True
            CheckBoxDelete.Visible = True
            CheckBoxUpdate.Visible = True
            TreeViewMenu.SelectedNode = e.Node
            lblMenu.Text = e.Node.Text
            CheckBoxInsert.Checked = arregloPermisos(e.Node.Tag, 0)
            CheckBoxDelete.Checked = arregloPermisos(e.Node.Tag, 1)
            CheckBoxUpdate.Checked = arregloPermisos(e.Node.Tag, 2)
        Else
            lblMenu.Text = ""
            CheckBoxInsert.Visible = False
            CheckBoxDelete.Visible = False
            CheckBoxUpdate.Visible = False

        End If
    End Sub

    Private Sub CheckBoxDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxDelete.CheckedChanged
        arregloPermisos(TreeViewMenu.SelectedNode.Tag, 1) = CheckBoxDelete.Checked
    End Sub

    Private Sub CheckBoxInsert_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxInsert.CheckedChanged
        arregloPermisos(TreeViewMenu.SelectedNode.Tag, 0) = CheckBoxInsert.Checked
    End Sub

    Private Sub CheckBoxUpdate_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBoxUpdate.CheckStateChanged
        arregloPermisos(TreeViewMenu.SelectedNode.Tag, 2) = CheckBoxUpdate.Checked
    End Sub

    Private Sub ShowCheckboxes(ByVal SiNo As Boolean)
        CheckBoxInsert.Visible = SiNo
        CheckBoxDelete.Visible = SiNo
        CheckBoxUpdate.Visible = SiNo
    End Sub

    Private Sub cmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelar.Click
        TreeViewMenu.Nodes.Clear()
        cmdGuardar.Visible = False
        cmdCancelar.Visible = False
        NavBar.Enabled = True
        ShowCheckboxes(False)
    End Sub
    Private Sub cmdCargarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCargarMenu.Click
        If lblModulo.Text = "S/N" Or lblUsuario.Text = "S/N" Then
            MsgBox("Debe seleccionar un modulo y un usuario", MsgBoxStyle.Information)
        Else
            TreeViewMenu.Visible = False
            GetMenu(lblModulo.Text)
            TreeViewMenu.Visible = True
            NavBar.Enabled = False
            cmdGuardar.Visible = True
            cmdCancelar.Visible = True
            ShowCheckboxes(False)
        End If
    End Sub
    Private Sub cmdControlTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdControlTotal.Click
        If lblModulo.Text = "S/N" Or lblUsuario.Text = "S/N" Then
            MsgBox("Debe seleccionar un modulo y un usuario", MsgBoxStyle.Information)
        Else
            TreeViewMenu.Visible = False
            GetMenuControlTotal(lblModulo.Text)
            TreeViewMenu.Visible = True
            NavBar.Enabled = False
            cmdGuardar.Visible = True
            cmdCancelar.Visible = True
            ShowCheckboxes(False)
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        If lblUsuario.Text = "" Or lblUsuario.Text = "S/N" Then
            MsgBox("Debe de seleccionar un usuario", MsgBoxStyle.Exclamation, "Nota")
        End If
        If MsgBox("Está seguro(a) de eliminar al usuario?", MsgBoxStyle.YesNo, "Confirme") = MsgBoxResult.No Then
            Exit Sub
        End If
        el.adm_UsuariosDeleteByPK(lblUsuario.Text)
        bl.Elimina_Opciones_Usuario(lblUsuario.Text, "TODOS")
        CargaUsuarios()
    End Sub


    Private Sub GetMenuControlTotal(ByVal ModuloName As String)

        TreeViewMenu.Nodes.Clear()
        Dim dt = bl.getOpciones(ModuloName, "")

        Dim CaracteresPorNivel As Integer = 3

        Dim RowCount As Integer = dt.Rows.Count

        Dim objNodo(RowCount - 1) As TreeNode
        ReDim arregloPermisos(RowCount - 1, 2)

        Dim i As Integer = 0

        For Each fila As DataRow In dt.Rows
            objNodo(i) = New TreeNode
            objNodo(i).Name = fila.Item("IdOpcion")
            objNodo(i).Text = fila.Item("Nombre")
            objNodo(i).Tag = i

            objNodo(i).Checked = True
            arregloPermisos(i, 0) = True
            arregloPermisos(i, 1) = True
            arregloPermisos(i, 2) = True
            i += 1
        Next

        i = 0

        For Each fila As DataRow In dt.Rows
            Dim largoMenu As Integer = CType(fila.Item("IdOpcion"), String).Length

            If largoMenu = CaracteresPorNivel Then
                TreeViewMenu.Nodes.Add(objNodo(i))
            Else
                TreeViewMenu.SelectedNode = objNodo(GetNodoPadre(fila.Item("IdOpcion"), dt))
                TreeViewMenu.SelectedNode.Nodes.Add(objNodo(i))
            End If
            i += 1
        Next
        TreeViewMenu.ExpandAll()
    End Sub


    Private Sub sbCrearUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCrearUsuario.Click
        adm_frmCrearUsuario.ShowDialog()

        CargaUsuarios()
    End Sub

    Private Sub sbModifica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbModifica.Click
        If lblUsuario.Text = "" Or lblUsuario.Text = "S/N" Then
            MsgBox("Debe de seleccionar un usuario", MsgBoxStyle.Exclamation, "Nota")
        End If
        adm_frmModificaUsuario.IdUsuario = lblUsuario.Text
        adm_frmModificaUsuario.ShowDialog()
        CargaUsuarios()

    End Sub

    Private Sub sbImprimir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbImprimir.Click
        If lblUsuario.Text = "" Or lblUsuario.Text = "S/N" Then
            MsgBox("Debe de seleccionar un usuario", MsgBoxStyle.Exclamation, "Nota")
        End If
        Dim rpt As New adm_rptPermisosUsuarios
        rpt.DataSource = bl.rptPermisosUsuarios(lblUsuario.Text)
        rpt.DataMember = ""
        rpt.xrlEmpresa.Text = gsNombre_Empresa
        rpt.xrlUsuario.Text = lblUsuario.Text
        rpt.ShowPreviewDialog()
    End Sub
End Class
