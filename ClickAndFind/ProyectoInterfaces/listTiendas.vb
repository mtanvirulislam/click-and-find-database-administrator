Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogListarTiendas

    Private dt As DataTable

    Public Sub CargarListBox()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select nombre from tiendas"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            dt = New DataTable("tiendas")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ListBoxTiendas.DataSource = dt
                ListBoxTiendas.DisplayMember = "nombre"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub buscador_tiendas_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles buscador_tiendas.TextChanged
        Dim dvProductos As DataView
        dvProductos = dt.DefaultView
        dvProductos.RowFilter = "nombre like '%" + buscador_tiendas.Text + "%'"
    End Sub

    Private Sub DialogListarTiendas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarListBox()
    End Sub
End Class
