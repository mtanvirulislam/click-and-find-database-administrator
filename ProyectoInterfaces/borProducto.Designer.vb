<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBorrarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogBorrarProducto))
        Me.cBox_bor_producto = New System.Windows.Forms.ComboBox()
        Me.bor_producto_precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bor_producto_tienda = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_bor_tienda = New System.Windows.Forms.Button()
        Me.bor_prodcto_categorias = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bor_producto_marca = New System.Windows.Forms.TextBox()
        Me.bor_producto_img = New System.Windows.Forms.TextBox()
        Me.bor_producto_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cBox_bor_producto
        '
        Me.cBox_bor_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_bor_producto.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_bor_producto.FormattingEnabled = True
        Me.cBox_bor_producto.Items.AddRange(New Object() {"aa"})
        Me.cBox_bor_producto.Location = New System.Drawing.Point(203, 30)
        Me.cBox_bor_producto.Name = "cBox_bor_producto"
        Me.cBox_bor_producto.Size = New System.Drawing.Size(408, 42)
        Me.cBox_bor_producto.TabIndex = 0
        '
        'bor_producto_precio
        '
        Me.bor_producto_precio.Enabled = False
        Me.bor_producto_precio.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_producto_precio.Location = New System.Drawing.Point(203, 396)
        Me.bor_producto_precio.Name = "bor_producto_precio"
        Me.bor_producto_precio.Size = New System.Drawing.Size(408, 42)
        Me.bor_producto_precio.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 403)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 30)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Precio:"
        '
        'bor_producto_tienda
        '
        Me.bor_producto_tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bor_producto_tienda.Enabled = False
        Me.bor_producto_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_producto_tienda.FormattingEnabled = True
        Me.bor_producto_tienda.Location = New System.Drawing.Point(203, 320)
        Me.bor_producto_tienda.Name = "bor_producto_tienda"
        Me.bor_producto_tienda.Size = New System.Drawing.Size(408, 42)
        Me.bor_producto_tienda.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 327)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 30)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Tienda:"
        '
        'btn_bor_tienda
        '
        Me.btn_bor_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bor_tienda.Location = New System.Drawing.Point(326, 469)
        Me.btn_bor_tienda.Name = "btn_bor_tienda"
        Me.btn_bor_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_bor_tienda.TabIndex = 7
        Me.btn_bor_tienda.Text = "Baja"
        Me.btn_bor_tienda.UseVisualStyleBackColor = True
        '
        'bor_prodcto_categorias
        '
        Me.bor_prodcto_categorias.Enabled = False
        Me.bor_prodcto_categorias.FormattingEnabled = True
        Me.bor_prodcto_categorias.Location = New System.Drawing.Point(649, 80)
        Me.bor_prodcto_categorias.Name = "bor_prodcto_categorias"
        Me.bor_prodcto_categorias.Size = New System.Drawing.Size(311, 361)
        Me.bor_prodcto_categorias.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(654, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 30)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Categorias:"
        '
        'bor_producto_marca
        '
        Me.bor_producto_marca.Enabled = False
        Me.bor_producto_marca.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_producto_marca.Location = New System.Drawing.Point(203, 172)
        Me.bor_producto_marca.Name = "bor_producto_marca"
        Me.bor_producto_marca.Size = New System.Drawing.Size(408, 42)
        Me.bor_producto_marca.TabIndex = 2
        '
        'bor_producto_img
        '
        Me.bor_producto_img.Enabled = False
        Me.bor_producto_img.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_producto_img.Location = New System.Drawing.Point(203, 242)
        Me.bor_producto_img.Name = "bor_producto_img"
        Me.bor_producto_img.Size = New System.Drawing.Size(408, 42)
        Me.bor_producto_img.TabIndex = 3
        '
        'bor_producto_nombre
        '
        Me.bor_producto_nombre.Enabled = False
        Me.bor_producto_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_producto_nombre.Location = New System.Drawing.Point(203, 101)
        Me.bor_producto_nombre.Name = "bor_producto_nombre"
        Me.bor_producto_nombre.Size = New System.Drawing.Size(408, 42)
        Me.bor_producto_nombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 30)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "URL Foto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 30)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Nombre:"
        '
        'DialogBorrarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_bor_producto)
        Me.Controls.Add(Me.bor_producto_precio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bor_producto_tienda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_bor_tienda)
        Me.Controls.Add(Me.bor_prodcto_categorias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bor_producto_marca)
        Me.Controls.Add(Me.bor_producto_img)
        Me.Controls.Add(Me.bor_producto_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogBorrarProducto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Baja Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cBox_bor_producto As System.Windows.Forms.ComboBox
    Friend WithEvents bor_producto_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents bor_producto_tienda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_bor_tienda As System.Windows.Forms.Button
    Friend WithEvents bor_prodcto_categorias As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents bor_producto_marca As System.Windows.Forms.TextBox
    Friend WithEvents bor_producto_img As System.Windows.Forms.TextBox
    Friend WithEvents bor_producto_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
