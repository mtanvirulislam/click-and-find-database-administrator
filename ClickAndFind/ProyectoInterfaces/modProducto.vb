Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogModificarProducto
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
                cBox_mod_producto.DataSource = dt
                cBox_mod_producto.DisplayMember = "nombre"
                cBox_mod_producto.ValueMember = "id"
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
                mod_producto_tienda.DataSource = dt
                mod_producto_tienda.DisplayMember = "nombre"
                mod_producto_tienda.ValueMember = "id"
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
                mod_prodcto_categorias.DataSource = dt
                mod_prodcto_categorias.DisplayMember = "nombre"
                mod_prodcto_categorias.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    Private Sub DialogModificarProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        CargarComboBoxTiendas()
        CargarCheckListBoxCategorias()
    End Sub


    Private Sub LimpiarListBox()
        For i As Integer = 0 To mod_prodcto_categorias.Items.Count - 1
            mod_prodcto_categorias.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub cBox_mod_producto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_mod_producto.SelectedIndexChanged
        If (saltar = 1) Then
            LimpiarListBox()
            CargarCheckListBoxCategorias()
            CargarComboBoxTiendas()
            mod_producto_nombre.Text = ""
            mod_producto_marca.Text = ""
            mod_producto_img.Text = ""
            mod_producto_precio.Text = ""
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT p.*, t.nombre 'nombretienda', t.id 'idtienda', pt.precio FROM productos p, tiendas t, producto_tienda pt WHERE p.id = pt.id_producto AND t.id = pt.id_tienda AND p.id = " + cBox_mod_producto.SelectedValue.ToString
                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("productos")
                da.Fill(dt)
                For Each c In dt.Rows
                    mod_producto_nombre.Text = c("nombre")
                    mod_producto_marca.Text = c("marca")
                    mod_producto_img.Text = c("foto")
                    mod_producto_precio.Text = c("precio")
                    mod_producto_tienda.SelectedValue = c("idtienda")
                Next

                consulta = "SELECT c.id, c.nombre FROM categorias c, producto_categoria pc where c.id = pc.id_cat and pc.id_pro = " + cBox_mod_producto.SelectedValue.ToString
                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("categorias")
                da1.Fill(dt1)
                If dt1.Rows.Count > 0 Then
                    For Each c In dt1.Rows
                        For i As Integer = 0 To mod_prodcto_categorias.Items.Count - 1
                            If mod_prodcto_categorias.Items(i).Item("nombre") = c("nombre") Then
                                mod_prodcto_categorias.SetItemChecked(i, True)
                            End If
                        Next
                    Next
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_mod_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_tienda.Click
        If mod_producto_nombre.Text.Trim.Length > 0 And mod_producto_precio.Text.Trim.Length > 0 And mod_producto_marca.Text.Trim.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                Dim precio As Decimal = CDec(mod_producto_precio.Text.Trim)

                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sqlProducto As String = "UPDATE productos SET nombre = @nombre, marca = @marca, foto = @foto where id = @id"
                Dim sqlDeleteProTienda As String = "DELETE FROM producto_tienda WHERE id_producto = @id_producto AND id_tienda = @id_tienda"
                Dim sqlProTienda As String = "UPDATE producto_tienda SET precio = @precio WHERE id_producto = @id_producto AND id_tienda = @id_tienda"
                Dim sqlDeleteProCate As String = "DELETE FROM producto_categoria WHERE id_pro = @id_pro"
                MysqlCnn.Open()
                'actualizar tabla producto
                Dim cmdProducto = New MySqlCommand(sqlProducto, MysqlCnn)
                cmdProducto.Parameters.AddWithValue("@nombre", mod_producto_nombre.Text.Trim)
                cmdProducto.Parameters.AddWithValue("@marca", mod_producto_marca.Text.Trim)
                cmdProducto.Parameters.AddWithValue("@foto", mod_producto_img.Text.Trim)
                cmdProducto.Parameters.AddWithValue("@id", cBox_mod_producto.SelectedValue)
                cmdProducto.ExecuteNonQuery()

                'borrar relacion entre producto tienda
                Dim cmdProTienda = New MySqlCommand(sqlProTienda, MysqlCnn)
                cmdProTienda.Parameters.AddWithValue("@precio", precio)
                cmdProTienda.Parameters.AddWithValue("@id_producto", cBox_mod_producto.SelectedValue)
                cmdProTienda.Parameters.AddWithValue("@id_tienda", mod_producto_tienda.SelectedValue)
                cmdProTienda.ExecuteNonQuery()

                'borrar relaciones producto categorias
                Dim cmdDeleteProCat = New MySqlCommand(sqlDeleteProCate, MysqlCnn)
                cmdDeleteProCat.Parameters.AddWithValue("@id_pro", cBox_mod_producto.SelectedValue)
                cmdDeleteProCat.ExecuteNonQuery()

                'relacion entre producto categoria
                If mod_prodcto_categorias.CheckedItems.Count > 0 Then
                    For Each item In mod_prodcto_categorias.CheckedItems
                        Dim sqlInsProCat As String = "insert into producto_categoria(id_pro, id_cat) values(@id_pro, @id_cat)"
                        Dim cmdInsProCat = New MySqlCommand(sqlInsProCat, MysqlCnn)
                        cmdInsProCat.Parameters.AddWithValue("@id_cat", item.Item("id"))
                        cmdInsProCat.Parameters.AddWithValue("@id_pro", cBox_mod_producto.SelectedValue)
                        cmdInsProCat.ExecuteNonQuery()
                    Next
                End If

                MessageBox.Show("Actualizado correctamente !!!")
                CargarComboBoxNombres()
                CargarComboBoxTiendas()
                CargarCheckListBoxCategorias()
                CargarComboBoxTiendas()
                mod_producto_nombre.Text = ""
                mod_producto_marca.Text = ""
                mod_producto_img.Text = ""
                mod_producto_precio.Text = ""
                LimpiarListBox()
            Catch ex As Exception
                MessageBox.Show("No ha podido Actualizar !!" & vbLf & ex.Message)
            End Try
        Else
            MessageBox.Show("No ha cargado ningun producto !!!")
        End If


    End Sub
End Class
