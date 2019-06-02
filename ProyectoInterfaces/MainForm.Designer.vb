<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportarDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportarDBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InsertarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaracteristicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaracteristicaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiendaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaracteristicaToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarTiendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPorCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MainMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.InsertarToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.BorrarToolStripMenuItem, Me.ListarToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(978, 31)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportarDBToolStripMenuItem, Me.ExportarDBToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(97, 27)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ImportarDBToolStripMenuItem
        '
        Me.ImportarDBToolStripMenuItem.Name = "ImportarDBToolStripMenuItem"
        Me.ImportarDBToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.ImportarDBToolStripMenuItem.Text = "Importar DB"
        '
        'ExportarDBToolStripMenuItem
        '
        Me.ExportarDBToolStripMenuItem.Name = "ExportarDBToolStripMenuItem"
        Me.ExportarDBToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.ExportarDBToolStripMenuItem.Text = "Exportar DB"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(196, 28)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'InsertarToolStripMenuItem
        '
        Me.InsertarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.CaracteristicaToolStripMenuItem})
        Me.InsertarToolStripMenuItem.Name = "InsertarToolStripMenuItem"
        Me.InsertarToolStripMenuItem.Size = New System.Drawing.Size(63, 27)
        Me.InsertarToolStripMenuItem.Text = "Alta"
        '
        'TiendaToolStripMenuItem
        '
        Me.TiendaToolStripMenuItem.Name = "TiendaToolStripMenuItem"
        Me.TiendaToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.TiendaToolStripMenuItem.Text = "Tienda"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'CaracteristicaToolStripMenuItem
        '
        Me.CaracteristicaToolStripMenuItem.Name = "CaracteristicaToolStripMenuItem"
        Me.CaracteristicaToolStripMenuItem.Size = New System.Drawing.Size(217, 28)
        Me.CaracteristicaToolStripMenuItem.Text = "Caracteristica"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripMenuItem1, Me.ProductoToolStripMenuItem1, Me.CategoriaToolStripMenuItem1, Me.CaracteristicaToolStripMenuItem1})
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(146, 27)
        Me.ModificarToolStripMenuItem.Text = "Modificacion"
        '
        'TiendaToolStripMenuItem1
        '
        Me.TiendaToolStripMenuItem1.Name = "TiendaToolStripMenuItem1"
        Me.TiendaToolStripMenuItem1.Size = New System.Drawing.Size(217, 28)
        Me.TiendaToolStripMenuItem1.Text = "Tienda"
        '
        'ProductoToolStripMenuItem1
        '
        Me.ProductoToolStripMenuItem1.Name = "ProductoToolStripMenuItem1"
        Me.ProductoToolStripMenuItem1.Size = New System.Drawing.Size(217, 28)
        Me.ProductoToolStripMenuItem1.Text = "Producto"
        '
        'CategoriaToolStripMenuItem1
        '
        Me.CategoriaToolStripMenuItem1.Name = "CategoriaToolStripMenuItem1"
        Me.CategoriaToolStripMenuItem1.Size = New System.Drawing.Size(217, 28)
        Me.CategoriaToolStripMenuItem1.Text = "Categoria"
        '
        'CaracteristicaToolStripMenuItem1
        '
        Me.CaracteristicaToolStripMenuItem1.Name = "CaracteristicaToolStripMenuItem1"
        Me.CaracteristicaToolStripMenuItem1.Size = New System.Drawing.Size(217, 28)
        Me.CaracteristicaToolStripMenuItem1.Text = "Caracteristica"
        '
        'BorrarToolStripMenuItem
        '
        Me.BorrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TiendaToolStripMenuItem2, Me.ProductoToolStripMenuItem2, Me.CategoriaToolStripMenuItem2, Me.CaracteristicaToolStripMenuItem2})
        Me.BorrarToolStripMenuItem.Name = "BorrarToolStripMenuItem"
        Me.BorrarToolStripMenuItem.Size = New System.Drawing.Size(64, 27)
        Me.BorrarToolStripMenuItem.Text = "Baja"
        '
        'TiendaToolStripMenuItem2
        '
        Me.TiendaToolStripMenuItem2.Name = "TiendaToolStripMenuItem2"
        Me.TiendaToolStripMenuItem2.Size = New System.Drawing.Size(217, 28)
        Me.TiendaToolStripMenuItem2.Text = "Tienda"
        '
        'ProductoToolStripMenuItem2
        '
        Me.ProductoToolStripMenuItem2.Name = "ProductoToolStripMenuItem2"
        Me.ProductoToolStripMenuItem2.Size = New System.Drawing.Size(217, 28)
        Me.ProductoToolStripMenuItem2.Text = "Producto"
        '
        'CategoriaToolStripMenuItem2
        '
        Me.CategoriaToolStripMenuItem2.Name = "CategoriaToolStripMenuItem2"
        Me.CategoriaToolStripMenuItem2.Size = New System.Drawing.Size(217, 28)
        Me.CategoriaToolStripMenuItem2.Text = "Categoria"
        '
        'CaracteristicaToolStripMenuItem2
        '
        Me.CaracteristicaToolStripMenuItem2.Name = "CaracteristicaToolStripMenuItem2"
        Me.CaracteristicaToolStripMenuItem2.Size = New System.Drawing.Size(217, 28)
        Me.CaracteristicaToolStripMenuItem2.Text = "Caracteristica"
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarTiendasToolStripMenuItem, Me.ListarProductosToolStripMenuItem, Me.ProductosPorCategoriaToolStripMenuItem})
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(69, 27)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'ListarTiendasToolStripMenuItem
        '
        Me.ListarTiendasToolStripMenuItem.Name = "ListarTiendasToolStripMenuItem"
        Me.ListarTiendasToolStripMenuItem.Size = New System.Drawing.Size(319, 28)
        Me.ListarTiendasToolStripMenuItem.Text = "Listar Tiendas"
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(319, 28)
        Me.ListarProductosToolStripMenuItem.Text = "Listar Productos"
        '
        'ProductosPorCategoriaToolStripMenuItem
        '
        Me.ProductosPorCategoriaToolStripMenuItem.Name = "ProductosPorCategoriaToolStripMenuItem"
        Me.ProductosPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(319, 28)
        Me.ProductosPorCategoriaToolStripMenuItem.Text = "Productos por categoria"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(88, 27)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(253, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(469, 120)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(243, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(711, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Administrador de base de datos"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = """SQL files (*.sql)|*.sql|All files (*.*)|*.*"""
        Me.SaveFileDialog1.Title = "Exportar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = """SQL files (*.sql)|*.sql|All files (*.*)|*.*"""
        Me.OpenFileDialog1.Title = "Importar"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(978, 544)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1000, 600)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Click & Find"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportarDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportarDBToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaracteristicaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiendaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaracteristicaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BorrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TiendaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaracteristicaToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarTiendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosPorCategoriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
