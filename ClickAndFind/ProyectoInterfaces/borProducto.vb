Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogBorrarProducto

    Private saltar As Integer = 0

    Public Sub CargarComboBoxNombres()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from productos"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("productos")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cBox_bor_producto.DataSource = dt
                cBox_bor_producto.DisplayMember = "nombre"
                cBox_bor_producto.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    'cargar tiendas
    Public Sub CargarComboBoxTiendas()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from tiendas"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("tiendas")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                bor_producto_tienda.DataSource = dt
                bor_producto_tienda.DisplayMember = "nombre"
                bor_producto_tienda.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    'cargar categorias
    Public Sub CargarCheckListBoxCategorias()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from categorias where superior > 0"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("categorias")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                bor_prodcto_categorias.DataSource = dt
                bor_prodcto_categorias.DisplayMember = "nombre"
                bor_prodcto_categorias.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub



    Private Sub DialogBorrarProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        CargarComboBoxTiendas()
        CargarCheckListBoxCategorias()
    End Sub

    Private Sub LimpiarListBox()
        For i As Integer = 0 To bor_prodcto_categorias.Items.Count - 1
            bor_prodcto_categorias.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub cBox_bor_producto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_bor_producto.SelectedIndexChanged
        If (saltar = 1) Then
            LimpiarListBox()
            CargarCheckListBoxCategorias()
            CargarComboBoxTiendas()
            bor_producto_nombre.Text = ""
            bor_producto_marca.Text = ""
            bor_producto_img.Text = ""
            bor_producto_precio.Text = ""
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT p.*, t.nombre 'nombretienda', t.id 'idtienda', pt.precio FROM productos p, tiendas t, producto_tienda pt WHERE p.id = pt.id_producto AND t.id = pt.id_tienda AND p.id = " + cBox_bor_producto.SelectedValue.ToString
                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("productos")
                da.Fill(dt)
                For Each c In dt.Rows
                    bor_producto_nombre.Text = c("nombre")
                    bor_producto_marca.Text = c("marca")
                    bor_producto_img.Text = c("foto")
                    bor_producto_precio.Text = c("precio")
                    bor_producto_tienda.SelectedValue = c("idtienda")
                Next

                consulta = "SELECT c.id, c.nombre FROM categorias c, producto_categoria pc where c.id = pc.id_cat and pc.id_pro = " + cBox_bor_producto.SelectedValue.ToString
                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("categorias")
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    For Each c In dt1.Rows
                        For i As Integer = 0 To bor_prodcto_categorias.Items.Count - 1
                            If bor_prodcto_categorias.Items(i).Item("nombre") = c("nombre") Then
                                bor_prodcto_categorias.SetItemChecked(i, True)
                            End If
                        Next
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btn_bor_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bor_tienda.Click
        If bor_producto_nombre.Text.Trim.Length > 0 And bor_producto_precio.Text.Trim.Length > 0 And bor_producto_marca.Text.Trim.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection

            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sqlDeleteProducto As String = "DELETE FROM productos where id = @id"
                MysqlCnn.Open()

                Dim cmdDeleteProducto = New MySqlCommand(sqlDeleteProducto, MysqlCnn)
                cmdDeleteProducto.Parameters.AddWithValue("@id", cBox_bor_producto.SelectedValue)
                cmdDeleteProducto.ExecuteNonQuery()

                MessageBox.Show("Borrado correctamente !!!")
                CargarComboBoxNombres()
                CargarComboBoxTiendas()
                CargarCheckListBoxCategorias()
                CargarComboBoxTiendas()
                bor_producto_nombre.Text = ""
                bor_producto_marca.Text = ""
                bor_producto_img.Text = ""
                bor_producto_precio.Text = ""
                LimpiarListBox()
            Catch ex As Exception
                MessageBox.Show("No ha podido Actualizar !!" & vbLf & ex.Message)
            End Try
        Else
            MessageBox.Show("No ha cargado ningun producto !!!")
        End If
    End Sub
End Class
