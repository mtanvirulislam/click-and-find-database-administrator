Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DialogInsertarCategoria

    Public Sub CargarComboBox()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias where superior = 0"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ins_categoria_superior.DataSource = dt
                ins_categoria_superior.DisplayMember = "nombre"
                ins_categoria_superior.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub DialogInsertarCategoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBox()
    End Sub

    Private Sub ins_categoria_esSuperior_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ins_categoria_esSuperior.CheckedChanged
        If ins_categoria_esSuperior.Checked Then
            ins_categoria_superior.Enabled = False
        Else
            ins_categoria_superior.Enabled = True
        End If
    End Sub

    Private Sub btn_ins_categoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ins_categoria.Click
        If Not ins_categoria_nombre.Text.Trim = "" Then
            Dim MysqlCnn As New MySqlConnection
            Dim idSup As Integer
            If ins_categoria_esSuperior.Checked Then
                idSup = 0
            Else
                idSup = ins_categoria_superior.SelectedValue
            End If
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "insert into categorias(nombre,superior) values(@nombre,@superior)"
                MysqlCnn.Open()
                Dim cmd = New MySqlCommand(sql, MysqlCnn)
                cmd.Parameters.AddWithValue("@nombre", ins_categoria_nombre.Text)
                cmd.Parameters.AddWithValue("@superior", idSup)
                If cmd.ExecuteNonQuery() = 1 Then
                    MessageBox.Show("Ha insertado correctamente !!")
                End If
                ins_categoria_nombre.Text = ""
                ins_categoria_esSuperior.Checked = False
                CargarComboBox()
            Catch ex As Exception
                MessageBox.Show("No ha podido insertar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Nombre no puede estar vacio !!")
        End If
    End Sub

    Private Sub DialogInsertarCategoria_Load()
        Throw New NotImplementedException
    End Sub

End Class
