Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogBorrarCaracteristica
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
                cBox_bor_caracteristica.DataSource = dt
                cBox_bor_caracteristica.DisplayMember = "nombre"
                cBox_bor_caracteristica.ValueMember = "id"
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
                bor_caracteristica_cate.DataSource = dt
                bor_caracteristica_cate.DisplayMember = "nombre"
                bor_caracteristica_cate.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub



    Private Sub DialogborificarCaracteristica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        'CargarListBoxCategorias()
    End Sub

    Private Sub cBox_bor_caracteristica_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_bor_caracteristica.SelectedIndexChanged
        If saltar = 1 Then
            LimpiarListBox()
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM caracteristicas where id = " + cBox_bor_caracteristica.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("caracteristicas")
                da.Fill(dt)
                For Each c In dt.Rows
                    bor_caracteristica_nombre.Text = c("nombre")
                Next

                consulta = "SELECT c.id, c.nombre FROM categorias c, cate_carac cc where c.id = cc.id_cat and cc.id_car = " + cBox_bor_caracteristica.SelectedValue.ToString + ""
                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("categorias")
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    bor_caracteristica_cate.DataSource = dt1
                    bor_caracteristica_cate.DisplayMember = "nombre"
                    bor_caracteristica_cate.ValueMember = "id"
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub LimpiarListBox()
        For i As Integer = 0 To bor_caracteristica_cate.Items.Count - 1
            bor_caracteristica_cate.SetItemChecked(i, False)
            'bor_caracteristica_cate.Items.RemoveAt(i)
        Next
    End Sub

    Private Sub btn_bor_caracteristica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bor_caracteristica.Click
        If Not bor_caracteristica_nombre.Text.Trim = "" Then
            Dim marked As Integer = bor_caracteristica_cate.CheckedItems.Count
            Dim total As Integer = bor_caracteristica_cate.Items.Count

            Dim MysqlCnn As New MySqlConnection
            Try
                If bor_caracteristica_cate.CheckedItems.Count > 0 Then
                    MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                    Dim sql As String = "DELETE FROM caracteristicas WHERE id = @id"
                    MysqlCnn.Open()
                    Dim cmdDeleteAll = New MySqlCommand(sql, MysqlCnn)

                    If marked = total Then
                        cmdDeleteAll.Parameters.AddWithValue("@id", cBox_bor_caracteristica.SelectedValue.ToString)
                        cmdDeleteAll.ExecuteNonQuery()
                    Else
                        For Each item In bor_caracteristica_cate.CheckedItems
                            Dim sqlDeleteCat As String = "DELETE FROM cate_carac WHERE id_car = @id_car and id_cat = @id_cat"
                            Dim cmdDeleteCat = New MySqlCommand(sqlDeleteCat, MysqlCnn)
                            cmdDeleteCat.Parameters.AddWithValue("@id_cat", item.Item("id"))
                            cmdDeleteCat.Parameters.AddWithValue("@id_car", cBox_bor_caracteristica.SelectedValue)
                            cmdDeleteCat.ExecuteNonQuery()
                        Next
                    End If
                    

                    MessageBox.Show("Borrado correctamente !!")
                    'limpiar list
                    CargarComboBoxNombres()
                    'limpiar nombre
                    bor_caracteristica_nombre.Text = ""
                    LimpiarListBox()
                    bor_categorias_todas.Checked = False
                Else
                    MessageBox.Show("Hay que elegir minimo una categoria !!")
                End If

            Catch ex As Exception
                MessageBox.Show("No ha podido borrar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Nombre no puede estar vacio !!")
        End If
    End Sub

    Private Sub bor_categorias_todas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bor_categorias_todas.CheckedChanged
        If bor_categorias_todas.Checked Then
            For i As Integer = 0 To bor_caracteristica_cate.Items.Count - 1
                bor_caracteristica_cate.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To bor_caracteristica_cate.Items.Count - 1
                bor_caracteristica_cate.SetItemChecked(i, False)
            Next
        End If
    End Sub


End Class
