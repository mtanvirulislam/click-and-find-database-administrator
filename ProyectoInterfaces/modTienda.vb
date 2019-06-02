Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogModificarTienda
    Private saltar As Integer = 0

    Public Sub CargarComboBoxNombres()
        Dim MysqlCnn As New MySqlConnection
        Try
            MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
            Dim consulta As String = "Select id,nombre from tiendas"
            MysqlCnn.Open()
            Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
            Dim dt As New DataTable("tiendas")
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                cBox_mod_tienda.DataSource = dt
                cBox_mod_tienda.DisplayMember = "nombre"
                cBox_mod_tienda.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub


    Private Sub DialogModificarTienda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        mod_tienda_tipo.SelectedIndex = 0
    End Sub

    Private Sub cBox_mod_tienda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_mod_tienda.SelectedIndexChanged
        If saltar = 1 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM tiendas where id = " + cBox_mod_tienda.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("tiendas")
                da.Fill(dt)
                For Each c In dt.Rows
                    mod_tienda_nombre.Text = c("nombre")
                    mod_tienda_tipo.SelectedItem = c("tipo")
                    mod_tienda_latitud.Text = c("latitud").ToString
                    mod_tienda_longitud.Text = c("longitud")
                Next

                consulta = "SELECT o.url FROM tiendaonline o, tiendas t where o.id = t.id and t.id = " + cBox_mod_tienda.SelectedValue.ToString + ""

                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("tiendaonline")
                da1.Fill(dt1)
                For Each c In dt1.Rows
                    mod_tienda_web.Text = c("url")
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub mod_tienda_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mod_tienda_tipo.SelectedIndexChanged
        If mod_tienda_tipo.SelectedIndex = 1 Then
            Label5.Visible = True
            mod_tienda_web.Visible = True
        Else
            Label5.Visible = False
            mod_tienda_web.Visible = False
        End If
    End Sub

    'comprobar campos latitud longitud
    Private Sub comprobarLatLon()
        Dim latitud As String = mod_tienda_latitud.Text.Trim
        Dim longitud As String = mod_tienda_longitud.Text.Trim
        If latitud.Length > 0 And longitud.Length > 0 Then
            mapa(latitud, longitud)
        Else
            mod_WebBrowser.Navigate("")
        End If
    End Sub

    'metodo cargar mapa
    Sub mapa(ByVal lat, ByVal lon)
        Dim url As String = "https://www.openstreetmap.org/?mlat=" & lat & "&mlon=" & lon & "#map=15/" & lat & "/" & lon
        mod_WebBrowser.Navigate(url) 'carga una pagina web, usa el motoro del IE
    End Sub

    'eventos camops latitud longitud
    Private Sub mod_tienda_latitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mod_tienda_latitud.TextChanged
        comprobarLatLon()
    End Sub

    Private Sub mod_tienda_longitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mod_tienda_longitud.TextChanged
        comprobarLatLon()
    End Sub

    'limpiar campos
    Private Sub LimpiarCampos()
        mod_tienda_nombre.Text = ""
        mod_tienda_tipo.SelectedIndex = 0
        mod_tienda_latitud.Text = ""
        mod_tienda_longitud.Text = ""
        mod_tienda_web.Text = ""
    End Sub

    Private Sub btn_mod_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_mod_tienda.Click
        Dim nombre As String = mod_tienda_nombre.Text.Trim
        Dim latitud As String = mod_tienda_latitud.Text.Trim
        Dim longitud As String = mod_tienda_longitud.Text.Trim
        If nombre.Length > 0 And latitud.Length > 0 And longitud.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "UPDATE tiendas SET nombre = @nombre,tipo = @tipo,latitud = @latitud,longitud = @longitud WHERE id = " + cBox_mod_tienda.SelectedValue.ToString
                Dim sql2 As String = "insert into tiendaonline(id,url) values(@id,@url)"
                MysqlCnn.Open()

                'si la tienda es fisica
                If mod_tienda_tipo.SelectedIndex = 0 Then
                    Dim cmd = New MySqlCommand(sql, MysqlCnn)
                    cmd.Parameters.AddWithValue("@nombre", mod_tienda_nombre.Text)
                    cmd.Parameters.AddWithValue("@tipo", mod_tienda_tipo.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@latitud", latitud)
                    cmd.Parameters.AddWithValue("@longitud", longitud)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Actualizado correctamente !!")
                    CargarComboBoxNombres()
                    LimpiarCampos()
                    'si la tienda es online
                Else
                    If mod_tienda_web.Text.Trim.Length > 0 Then
                        Dim cmd = New MySqlCommand(sql, MysqlCnn)
                        cmd.Parameters.AddWithValue("@nombre", mod_tienda_nombre.Text)
                        cmd.Parameters.AddWithValue("@latitud", latitud)
                        cmd.Parameters.AddWithValue("@longitud", longitud)
                        cmd.Parameters.AddWithValue("@tipo", mod_tienda_tipo.SelectedItem.ToString)
                        cmd.ExecuteNonQuery()

                        'antes borrar la relacion
                        Dim sqlDelete As String = "DELETE FROM tiendaonline WHERE id = @id"
                        Dim cmdDelete = New MySqlCommand(sqlDelete, MysqlCnn)
                        cmdDelete.Parameters.AddWithValue("@id", cBox_mod_tienda.SelectedValue)
                        cmdDelete.ExecuteNonQuery()


                        Dim cmd2 = New MySqlCommand(sql2, MysqlCnn)
                        cmd2.Parameters.AddWithValue("@id", cBox_mod_tienda.SelectedValue)
                        cmd2.Parameters.AddWithValue("@url", mod_tienda_web.Text.Trim)
                        cmd2.ExecuteNonQuery()
                        MessageBox.Show("Actualizado correctamente !!")
                        CargarComboBoxNombres()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("Campo web no puede estar vacio !!")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("No ha podido Actualizado !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Los campos no pueden estar vacios !!")
        End If
    End Sub
End Class
