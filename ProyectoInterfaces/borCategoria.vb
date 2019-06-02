Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DialogBorrarCategoria

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
                bor_categoria_superior.DataSource = dt
                bor_categoria_superior.DisplayMember = "nombre"
                bor_categoria_superior.ValueMember = "id"
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
                cBox_bor_categoria.DataSource = dt
                cBox_bor_categoria.DisplayMember = "nombre"
                cBox_bor_categoria.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub mod_categoria_esSuperior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bor_categoria_esSuperior.CheckedChanged
        If bor_categoria_esSuperior.Checked Then
            bor_categoria_superior.Enabled = False
        Else
            bor_categoria_superior.Enabled = True
        End If
    End Sub

    Private Sub DialogModificarCategoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        CargarComboBoxSuperior()
    End Sub


    Private Sub cBox_mod_categoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_bor_categoria.SelectedIndexChanged
        If saltar = 1 Then

            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM categorias where id = " + cBox_bor_categoria.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("categorias")
                da.Fill(dt)
                For Each c In dt.Rows
                    bor_categoria_nombre.Text = c("nombre")
                    If c("superior") = "0" Then
                        bor_categoria_esSuperior.Checked = True
                        bor_categoria_superior.SelectedValue = c("id")
                    Else
                        bor_categoria_esSuperior.Checked = False
                        bor_categoria_superior.SelectedValue = c("superior")
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub btn_bor_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bor_categoria.Click

        If Not bor_categoria_nombre.Text.Trim = "" Then
            Dim MysqlCnn As New MySqlConnection
            Dim idSup As Integer
            If bor_categoria_esSuperior.Checked Then
                idSup = 0
            Else
                idSup = bor_categoria_superior.SelectedValue
            End If
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                MysqlCnn.Open()
                Dim result As Integer = MessageBox.Show("Quiere borrar los productos y sub categorias de esta categoria ?", "Borrar categoria", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    If idSup = 0 Then

                    Else
                        
                    End If
                ElseIf result = DialogResult.No Then
                    If idSup = 0 Then
                        'poner su categorias como categoria principal y borrar la categoria
                        Dim sqlUpdateSubCat As String = "UPDATE categorias SET superior = 0 WHERE superior = " + cBox_bor_categoria.SelectedValue.ToString
                        Dim cmdUpdateSubCategoria = New MySqlCommand(sqlUpdateSubCat, MysqlCnn)
                        'borrar la categoria
                        Dim sqlDeleteCategoria As String = "DELETE FROM categorias WHERE id = " + cBox_bor_categoria.SelectedValue.ToString
                        Dim cmdDeleteCategoria = New MySqlCommand(sqlDeleteCategoria, MysqlCnn)
                        cmdDeleteCategoria.ExecuteNonQuery()
                    Else
                        Dim sqlDeleteSubCategoria As String = "DELETE FROM categorias WHERE id = " + cBox_bor_categoria.SelectedValue.ToString
                        Dim cmdDeleteSubCategoria = New MySqlCommand(sqlDeleteSubCategoria, MysqlCnn)
                        cmdDeleteSubCategoria.ExecuteNonQuery()
                    End If
                End If


                Dim sql As String = "UPDATE categorias SET nombre = @nombre, superior = @superior where id = " + cBox_bor_categoria.SelectedValue.ToString + ""


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
