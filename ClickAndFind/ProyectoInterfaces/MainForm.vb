Imports MySql.Data.MySqlClient
Public Class MainForm
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TiendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiendaToolStripMenuItem.Click
        DialogInsertarTienda.ShowDialog()
    End Sub

    Private Sub AyudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AyudaToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        DialogInsertarProducto.ShowDialog()
    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem.Click
        DialogInsertarCategoria.ShowDialog()
    End Sub

    Private Sub CaracteristicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaracteristicaToolStripMenuItem.Click
        DialogInsertarCaracteristica.ShowDialog()
    End Sub

    Private Sub TiendaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiendaToolStripMenuItem1.Click
        DialogModificarTienda.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem1.Click
        DialogModificarProducto.ShowDialog()
    End Sub

    Private Sub CategoriaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem1.Click
        DialogModificarCategoria.ShowDialog()
    End Sub

    Private Sub CaracteristicaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaracteristicaToolStripMenuItem1.Click
        DialogModificarCaracteristica.ShowDialog()
    End Sub

    Private Sub ListarTiendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarTiendasToolStripMenuItem.Click
        DialogListarTiendas.ShowDialog()
    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarProductosToolStripMenuItem.Click
        DialogListarProductos.ShowDialog()
    End Sub


    Private Sub ProductosPorCategoriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosPorCategoriaToolStripMenuItem.Click
        DialogListarProPorCategoria.ShowDialog()
    End Sub

    Private Sub TiendaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiendaToolStripMenuItem2.Click
        DialogBorrarTienda.ShowDialog()
    End Sub

    Private Sub CaracteristicaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaracteristicaToolStripMenuItem2.Click
        DialogBorrarCaracteristica.ShowDialog()
    End Sub

    Private Sub ExportarDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportarDBToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim con = New MySqlConnection("server=localhost;user=root;pwd=;database=12204-dm2e;")
                Dim sqlCom As New MySqlCommand
                sqlCom.Connection = con
                Dim mb As New MySqlBackup(sqlCom)
                con.Open()
                mb.ExportToFile(SaveFileDialog1.FileName)
                MessageBox.Show("Exportado en el fichero: " & vbLf & SaveFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show("Error al exportar !!" & vbLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ImportarDBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportarDBToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Try
                Dim con = New MySqlConnection("server=localhost;user=root;pwd=;database=12204-dm2e;")
                Dim sqlCom As New MySqlCommand
                sqlCom.Connection = con
                'Dim file As String = "C:\Users\Tanvir\Documents\backup.sql"
                Dim mb As New MySqlBackup(sqlCom)
                con.Open()
                mb.ImportFromFile(OpenFileDialog1.FileName)
                MessageBox.Show("Importado desde el fichero: " & vbLf & OpenFileDialog1.FileName)
            Catch ex As Exception
                MessageBox.Show("Error al importar !!" & vbLf & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ProductoToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem2.Click
        DialogBorrarProducto.ShowDialog()
    End Sub

    Private Sub CategoriaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CategoriaToolStripMenuItem2.Click
        DialogBorrarCategoria.ShowDialog()
    End Sub
End Class
