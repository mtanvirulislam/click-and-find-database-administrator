Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DialogModificarCaracteristica
    Private saltar As Integer = 0

    Public Sub CargarComboBoxNombres()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from caracteristicas"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("caracteristicas")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cBox_mod_caracteristica.DataSource = dt
                cBox_mod_caracteristica.DisplayMember = "nombre"
                cBox_mod_caracteristica.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Public Sub CargarListBoxCategorias()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                mod_caracteristica_cate.DataSource = dt
                mod_caracteristica_cate.DisplayMember = "nombre"
                mod_caracteristica_cate.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub



    Private Sub DialogModificarCaracteristica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        CargarListBoxCategorias()
    End Sub

    Private Sub cBox_mod_caracteristica_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_mod_caracteristica.SelectedIndexChanged
        If saltar = 1 Then
            LimpiarListBox()
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM caracteristicas where id = " + cBox_mod_caracteristica.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("caracteristicas")
                da.Fill(dt)
                For Each c In dt.Rows
                    mod_caracteristica_nombre.Text = c("nombre")
                Next

                consulta = "SELECT c.id, c.nombre FROM categorias c, cate_carac cc where c.id = cc.id_cat and cc.id_car = " + cBox_mod_caracteristica.SelectedValue.ToString + ""
                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("categorias")
                da1.Fill(dt1)
                For Each c In dt1.Rows
                    For i As Integer = 0 To mod_caracteristica_cate.Items.Count - 1
                        If mod_caracteristica_cate.Items(i).Item("nombre") = c("nombre") Then
                            mod_caracteristica_cate.SetItemChecked(i, True)
                        End If
                    Next
                    'For Each item In mod_caracteristica_cate.Items
                    '    MessageBox.Show(item.Item("id"))
                    'Next
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub LimpiarListBox()
        For i As Integer = 0 To mod_caracteristica_cate.Items.Count - 1
            mod_caracteristica_cate.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub btn_mod_caracteristica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_caracteristica.Click
        If Not mod_caracteristica_nombre.Text.Trim = "" Then
            Dim MysqlCnn As New MySqlConnection
            Try
                

                If mod_caracteristica_cate.CheckedItems.Count > 0 Then
                    MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                    Dim sql As String = "UPDATE caracteristicas SET nombre = @nombre where id = " + cBox_mod_caracteristica.SelectedValue.ToString
                    Dim sqlDelete As String = "DELETE FROM cate_carac WHERE id_car = @id_car"
                    MysqlCnn.Open()

                    Dim cmd = New MySqlCommand(Sql, MysqlCnn)

                    'insertar caracteristica
                    cmd.Parameters.AddWithValue("@nombre", mod_caracteristica_nombre.Text.Trim)
                    cmd.ExecuteNonQuery()

                    'borrar relaciones
                    Dim cmdDelete = New MySqlCommand(sqlDelete, MysqlCnn)
                    cmdDelete.Parameters.AddWithValue("@id_car", cBox_mod_caracteristica.SelectedValue)
                    cmdDelete.ExecuteNonQuery()

                    'relacionar con categorias
                    For Each item In mod_caracteristica_cate.CheckedItems
                        Dim sql2 As String = "insert into cate_carac(id_cat, id_car) values(@id_cat, @id_car)"
                        Dim cmd2 = New MySqlCommand(sql2, MysqlCnn)
                        cmd2.Parameters.AddWithValue("@id_cat", item.Item("id"))
                        cmd2.Parameters.AddWithValue("@id_car", cBox_mod_caracteristica.SelectedValue)
                        cmd2.ExecuteNonQuery()
                    Next

                    MessageBox.Show("Actualizado correctamente !!")
                    'limpiar list
                    CargarComboBoxNombres()
                    'limpiar nombre
                    mod_caracteristica_nombre.Text = ""
                    LimpiarListBox()
                Else
                    MessageBox.Show("Hay que elegir minimo una categoria !!")
                End If

            Catch ex As Exception
                MessageBox.Show("No ha podido Actualizar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Nombre no puede estar vacio !!")
        End If
    End Sub
End Class
