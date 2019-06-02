Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class DialogInsertarProducto

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
                ins_prodcto_categorias.DataSource = dt
                ins_prodcto_categorias.DisplayMember = "nombre"
                ins_prodcto_categorias.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub

    'cargar caracteristicas
    

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
                ins_producto_tienda.DataSource = dt
                ins_producto_tienda.DisplayMember = "nombre"
                ins_producto_tienda.ValueMember = "id"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub


    Private Sub DialogInsertarProducto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarCheckListBoxCategorias()
        CargarComboBoxTiendas()
    End Sub


    Private Sub btn_ins_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ins_tienda.Click
        'variables
        Dim nombre As String = ins_producto_nombre.Text.Trim
        Dim marca As String = ins_producto_marca.Text.Trim
        Dim urlFoto As String = ins_producto_img.Text.Trim
        Dim precio As String = ins_producto_precio.Text.Trim

        If nombre.Length > 0 And marca.Length > 0 And urlFoto.Length > 0 And precio.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                Dim precioDecimal As Decimal = CDec(precio)
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sqlInsPro As String = "INSERT INTO productos(nombre, marca, foto) VALUES(@nombre, @marca, @foto)"
                Dim sqlInsProTienda As String = "INSERT INTO producto_tienda(id_tienda, id_producto, precio) VALUES(@id_tienda, (SELECT MAX(id) FROM productos), @precio)"
                MysqlCnn.Open()

                'insertar producto
                Dim cmdInsPro = New MySqlCommand(sqlInsPro, MysqlCnn)
                cmdInsPro.Parameters.AddWithValue("@nombre", nombre)
                cmdInsPro.Parameters.AddWithValue("@marca", marca)
                cmdInsPro.Parameters.AddWithValue("@foto", urlFoto)
                cmdInsPro.ExecuteNonQuery()

                'insertar precio tienda
                Dim cmdInsProTienda = New MySqlCommand(sqlInsProTienda, MysqlCnn)
                cmdInsProTienda.Parameters.AddWithValue("@id_tienda", ins_producto_tienda.SelectedValue)
                cmdInsProTienda.Parameters.AddWithValue("@precio", precioDecimal)
                cmdInsProTienda.ExecuteNonQuery()

                'insertar relacion pro categoria
                If ins_prodcto_categorias.CheckedItems.Count > 0 Then
                    For Each item In ins_prodcto_categorias.CheckedItems
                        Dim sqlInsProCat As String = "insert into producto_categoria(id_pro, id_cat) values((SELECT  MAX(id) FROM productos), @id_cat)"
                        Dim cmdInsProCat = New MySqlCommand(sqlInsProCat, MysqlCnn)
                        cmdInsProCat.Parameters.AddWithValue("@id_cat", item.Item("id"))
                        cmdInsProCat.ExecuteNonQuery()
                    Next
                End If

                MessageBox.Show("Ha insertado correctamete !!")

                CargarCheckListBoxCategorias()
                CargarComboBoxTiendas()
                ins_producto_nombre.Text = ""
                ins_producto_marca.Text = ""
                ins_producto_img.Text = ""
                ins_producto_precio.Text = ""
                LimpiarListBox()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            MessageBox.Show("Los campos no pueden estar vacios !!")
        End If
    End Sub

    Private Sub LimpiarListBox()
        For i As Integer = 0 To ins_prodcto_categorias.Items.Count - 1
            ins_prodcto_categorias.SetItemChecked(i, False)
        Next
    End Sub
End Class
