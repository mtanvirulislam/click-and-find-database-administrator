Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogListarProductos

    Private dt As DataTable

    Public Sub CargarListBox()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select nombre from productos"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            dt = New DataTable("productos")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ListBoxProductos.DataSource = dt
                ListBoxProductos.DisplayMember = "nombre"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub buscador_productos_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscador_productos.TextChanged
        Dim dvProductos As DataView
        dvProductos = dt.DefaultView
        dvProductos.RowFilter = "nombre like '%" + buscador_productos.Text + "%'"
    End Sub

    Private Sub DialogListarProductos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListBox()
    End Sub

End Class
