Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Public Class DialogBorrarTienda

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
                cBox_bor_tienda.DataSource = dt
                cBox_bor_tienda.DisplayMember = "nombre"
                cBox_bor_tienda.ValueMember = "id"
                saltar = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlCnn.Close()
        End Try
    End Sub



    Private Sub cBox_bor_tienda_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cBox_bor_tienda.SelectedIndexChanged
        If saltar = 1 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim consulta As String = "SELECT * FROM tiendas where id = " + cBox_bor_tienda.SelectedValue.ToString + ""

                MysqlCnn.Open()
                Dim da As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt As New DataTable("tiendas")
                da.Fill(dt)
                For Each c In dt.Rows
                    bor_tienda_nombre.Text = c("nombre")
                    bor_tienda_tipo.SelectedItem = c("tipo")
                    bor_tienda_latitud.Text = c("latitud").ToString
                    bor_tienda_longitud.Text = c("longitud")
                Next

                consulta = "SELECT o.url FROM tiendaonline o, tiendas t where o.id = t.id and t.id = " + cBox_bor_tienda.SelectedValue.ToString + ""

                Dim da1 As New MySqlDataAdapter(consulta, MysqlCnn)
                Dim dt1 As New DataTable("tiendaonline")
                da1.Fill(dt1)
                For Each c In dt1.Rows
                    bor_tienda_web.Text = c("url")
                Next
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        End If
    End Sub

    Private Sub bor_tienda_tipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bor_tienda_tipo.SelectedIndexChanged
        If bor_tienda_tipo.SelectedIndex = 1 Then
            Label5.Visible = True
            bor_tienda_web.Visible = True
        Else
            Label5.Visible = False
            bor_tienda_web.Visible = False
        End If
    End Sub

    'comprobar campos latitud longitud
    Private Sub comprobarLatLon()
        Dim latitud As String = bor_tienda_latitud.Text.Trim
        Dim longitud As String = bor_tienda_longitud.Text.Trim
        If latitud.Length > 0 And longitud.Length > 0 Then
            mapa(latitud, longitud)
        Else
            bor_WebBrowser.Navigate("")
        End If
    End Sub

    'metodo cargar mapa
    Sub mapa(ByVal lat, ByVal lon)
        Dim url As String = "https://www.openstreetmap.org/?mlat=" & lat & "&mlon=" & lon & "#map=15/" & lat & "/" & lon
        bor_WebBrowser.Navigate(url) 'carga una pagina web, usa el motoro del IE
    End Sub

    'eventos camops latitud longitud
    Private Sub bor_tienda_latitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bor_tienda_latitud.TextChanged
        comprobarLatLon()
    End Sub

    Private Sub bor_tienda_longitud_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bor_tienda_longitud.TextChanged
        comprobarLatLon()
    End Sub

    'limpiar campos
    Private Sub LimpiarCampos()
        bor_tienda_nombre.Text = ""
        bor_tienda_tipo.SelectedIndex = 0
        bor_tienda_latitud.Text = ""
        bor_tienda_longitud.Text = ""
        bor_tienda_web.Text = ""
    End Sub

    Private Sub btn_bor_tienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bor_tienda.Click
        Dim nombre As String = bor_tienda_nombre.Text.Trim
        Dim latitud As String = bor_tienda_latitud.Text.Trim
        Dim longitud As String = bor_tienda_longitud.Text.Trim
        If nombre.Length > 0 And latitud.Length > 0 And longitud.Length > 0 Then
            Dim MysqlCnn As New MySqlConnection
            Try
                MysqlCnn.ConnectionString = "Server=localhost;Database=12204-dm2e;Uid=root;Pwd=;"
                Dim sql As String = "DELETE FROM tiendas WHERE id = @id"
                MysqlCnn.Open()

                Dim cmd = New MySqlCommand(sql, MysqlCnn)
                cmd.Parameters.AddWithValue("@id", cBox_bor_tienda.SelectedValue.ToString)
                cmd.ExecuteNonQuery()


                MessageBox.Show("Borrado correctamente !!")
                CargarComboBoxNombres()
                LimpiarCampos()
                
            Catch ex As Exception
                MessageBox.Show("No ha podido borrar !!" & vbLf & ex.Message)
            Finally
                MysqlCnn.Close()
            End Try
        Else
            MessageBox.Show("No ha cargado ninguna tienda !!")
        End If
    End Sub

    Private Sub DialogBorrarTienda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarComboBoxNombres()
        bor_tienda_tipo.SelectedIndex = 0
    End Sub
End Class
