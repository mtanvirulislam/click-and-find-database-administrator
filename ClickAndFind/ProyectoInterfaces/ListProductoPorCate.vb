Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogListarProPorCategoria

    Public Sub CargarComboBox()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select superior,nombre from categorias"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ComboBoxCategoria.DataSource = dt
                ComboBoxCategoria.DisplayMember = "nombre"
                ComboBoxCategoria.ValueMember = "superior"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
        ListBoxProductos.Items.Clear()
    End Sub

    Private Sub DialogListarProPorCategoria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBox()
    End Sub


    Private Sub ComboBoxCategoria_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxCategoria.SelectedIndexChanged
        ListBoxProductos.Items.Clear()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String
            If ComboBoxCategoria.SelectedValue.ToString = "0" Then
                consulta = "SELECT p.nombre 'nombre' FROM productos p, categorias c, producto_categoria pc where p.id = pc.id_pro and c.id = pc.id_cat AND c.id IN (SELECT caS.id FROM categorias caS, categorias caU WHERE caS.superior=caU.id AND caU.nombre LIKE '" + ComboBoxCategoria.Text + "')"
            Else
                consulta = "SELECT p.nombre 'nombre' FROM productos p, categorias c, producto_categoria pc where p.id = pc.id_pro and c.id = pc.id_cat AND c.nombre LIKE '" + ComboBoxCategoria.Text + "'"
            End If

            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("productos")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each q In dt.Rows
                    ListBoxProductos.Items.Add(q("nombre"))
                Next
                'ListBoxProductos.DataSource = dt
                'ListBoxProductos.DisplayMember = "nombre"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub
End Class

