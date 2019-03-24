Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DialogModificarCategoria
    Private saltar As Integer = 0

    Public Sub CargarComboBoxSuperior()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias where superior = 0"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                mod_categoria_superior.DataSource = dt
                mod_categoria_superior.DisplayMember = "nombre"
                mod_categoria_superior.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Public Sub CargarComboBoxNombres()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cBox_mod_categoria.DataSource = dt
                cBox_mod_categoria.DisplayMember = "nombre"
                cBox_mod_categoria.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub mod_categoria_esSuperior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mod_categoria_esSuperior.CheckedChanged
        If mod_categoria_esSuperior.Checked Then
            mod_categoria_superior.Enabled = False
        Else
            mod_categoria_superior.Enabled = True
        End If
    End Sub

    Private Sub DialogModificarCategoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        CargarComboBoxSuperior()
    End Sub


    Private Sub cBox_mod_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_mod_categoria.SelectedIndexChanged
        If saltar = 1 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM categorias where id = " + cBox_mod_categoria.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("categorias")
                da.Fill(dt)
                For Each c In dt.Rows
                    mod_categoria_nombre.Text = c("nombre")
                    If c("superior") = "0" Then
                        mod_categoria_esSuperior.Checked = True
                        mod_categoria_superior.SelectedValue = c("id")
                    Else
                        mod_categoria_esSuperior.Checked = False
                        mod_categoria_superior.SelectedValue = c("superior")
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub btn_mod_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_categoria.Click
        If Not mod_categoria_nombre.Text.Trim = "" Then
            Dim MysqlCnn As New MySqlConnection
            Dim idSup As Integer
            If mod_categoria_esSuperior.Checked Then
                idSup = 0
            Else
                idSup = mod_categoria_superior.SelectedValue
            End If
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "UPDATE categorias SET nombre = @nombre, superior = @superior where id = " + cBox_mod_categoria.SelectedValue.ToString + ""
                MysqlCnn.Open()
                Dim cmd = New MySqlCommand(sql, MysqlCnn)
                cmd.Parameters.AddWithValue("@nombre", mod_categoria_nombre.Text)
                cmd.Parameters.AddWithValue("@superior", idSup)
                If cmd.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Actualizado correctamente !!")
                End If
                mod_categoria_esSuperior.Checked = False
                CargarComboBoxNombres()
                CargarComboBoxSuperior()
                mod_categoria_nombre.Text = ""
            Catch ex As Exception
                MessageBox.Show("No ha podido actualizar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("No ha cargado ninguna categoria !!")
        End If
    End Sub
End Class
