Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class DialogInsertarTienda

    Private Sub DialogInsertarTienda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'default value
        ins_tienda_tipo.SelectedIndex = 0
    End Sub

    'evento boton
    'insertar tienda
    Private Sub btn_ins_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ins_tienda.Click
        Dim nombre As String = ins_tienda_nombre.Text.Trim
        Dim latitud As String = ins_tienda_latitud.Text.Trim
        Dim longitud As String = ins_tienda_longitud.Text.Trim
        If nombre.Length > 0 And latitud.Length > 0 And longitud.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "insert into tiendas(nombre,tipo,latitud,longitud) values(@nombre,@tipo,@latitud,@longitud)"
                Dim sql2 As String = "insert into tiendaonline(id,url) values((SELECT  MAX(id) FROM tiendas),@url)"
                MysqlCnn.Open()

                'si la tienda es fisica
                If ins_tienda_tipo.SelectedIndex = 0 Then
                    Dim cmd = New MySqlCommand(sql, MysqlCnn)
                    cmd.Parameters.AddWithValue("@nombre", ins_tienda_nombre.Text)
                    cmd.Parameters.AddWithValue("@tipo", ins_tienda_tipo.SelectedItem.ToString)
                    cmd.Parameters.AddWithValue("@latitud", latitud)
                    cmd.Parameters.AddWithValue("@longitud", longitud)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Ha insertado correctamente !!")
                    ins_tienda_nombre.Text = ""
                    ins_tienda_tipo.SelectedIndex = 0
                    ins_tienda_latitud.Text = ""
                    ins_tienda_longitud.Text = ""

                    'si la tienda es online
                Else
                    If ins_tienda_web.Text.Trim.Length > 0 Then
                        Dim cmd = New MySqlCommand(sql, MysqlCnn)
                        cmd.Parameters.AddWithValue("@nombre", ins_tienda_nombre.Text)
                        cmd.Parameters.AddWithValue("@latitud", latitud)
                        cmd.Parameters.AddWithValue("@longitud", longitud)
                        cmd.Parameters.AddWithValue("@tipo", ins_tienda_tipo.SelectedItem.ToString)
                        cmd.ExecuteNonQuery()

                        Dim cmd2 = New MySqlCommand(sql2, MysqlCnn)
                        cmd2.Parameters.AddWithValue("@url", ins_tienda_web.Text.Trim)
                        cmd2.ExecuteNonQuery()
                        MessageBox.Show("Ha insertado correctamente !!")
                        ins_tienda_nombre.Text = ""
                        ins_tienda_tipo.SelectedIndex = 0
                        ins_tienda_latitud.Text = ""
                        ins_tienda_longitud.Text = ""
                        ins_tienda_web.Text = ""
                    Else
                        MessageBox.Show("Campo web no puede estar vacio !!")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("No ha podido insertar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("Los campos no pueden estar vacios" & ins_tienda_tipo.SelectedItem)
        End If
    End Sub



    'mostrar ocultar image box
    Private Sub ins_tienda_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ins_tienda_tipo.SelectedIndexChanged
        If ins_tienda_tipo.SelectedIndex = 1 Then
            Label5.Visible = True
            ins_tienda_web.Visible = True
        Else
            Label5.Visible = False
            ins_tienda_web.Visible = False
        End If
    End Sub

    'comprobar campos latitud longitud
    Private Sub comprobarLatLon()
        Dim latitud As String = ins_tienda_latitud.Text.Trim
        Dim longitud As String = ins_tienda_longitud.Text.Trim
        If latitud.Length > 0 And longitud.Length > 0 Then
            mapa(latitud, longitud)
        Else
            WebBrowser1.Navigate("")
        End If
    End Sub

    'metodo cargar mapa
    Sub mapa(ByVal lat, ByVal lon)
        Dim url As String = "https://www.openstreetmap.org/?mlat=" & lat & "&mlon=" & lon & "#map=15/" & lat & "/" & lon
        WebBrowser1.Navigate(url) 'carga una pagina web, usa el motoro del IE
    End Sub

    'eventos camops latitud longitud
    Private Sub ins_tienda_latitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ins_tienda_latitud.TextChanged
        comprobarLatLon()
    End Sub

    Private Sub ins_tienda_longitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ins_tienda_longitud.TextChanged
        comprobarLatLon()
    End Sub
End Class