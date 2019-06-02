Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogInsertarCaracteristica

    Public Sub CargarCheckListBox()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias where superior > 0"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ins_caracteristica_cate.DataSource = dt
                ins_caracteristica_cate.DisplayMember = "nombre"
                ins_caracteristica_cate.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub DialogInsertarCaracteristica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarCheckListBox()
    End Sub

    Private Sub btn_ins_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ins_tienda.Click
        If Not ins_caracteristica_nombre.Text.Trim = "" Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "insert into caracteristicas(nombre) values(@nombre)"
                'Dim sql2 As String = "insert into cate_carac(id_cat, id_car) values(@id_cat, (SELECT  MAX(id) FROM caracteristicas))"
                MysqlCnn.Open()

                If ins_caracteristica_cate.CheckedItems.Count > 0 Then
                    Dim cmd = New MySqlCommand(sql, MysqlCnn)

                    'insertar caracteristica
                    cmd.Parameters.AddWithValue("@nombre", ins_caracteristica_nombre.Text.Trim)
                    cmd.ExecuteNonQuery()

                    'relacionar con categorias
                    For Each item In ins_caracteristica_cate.CheckedItems
                        Dim sql2 As String = "insert into cate_carac(id_cat, id_car) values(@id_cat, (SELECT  MAX(id) FROM caracteristicas))"
                        Dim cmd2 = New MySqlCommand(sql2, MysqlCnn)
                        cmd2.Parameters.AddWithValue("@id_cat", item.Item("id"))
                        cmd2.ExecuteNonQuery()
                    Next

                    MessageBox.Show("Ha insertado correctamente !!")
                    'limpiar nombre
                    ins_caracteristica_nombre.Text = ""
                    'limpiar list
                    For i As Integer = 0 To ins_caracteristica_cate.Items.Count - 1
                        ins_caracteristica_cate.SetItemChecked(i, False)
                    Next
                Else
                    MessageBox.Show("Hay que elegir minimo una categoria !!")
                End If

            Catch ex As Exception
                MessageBox.Show("No ha podido insertar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Nombre no puede estar vacio !!")
        End If
    End Sub
End Class
