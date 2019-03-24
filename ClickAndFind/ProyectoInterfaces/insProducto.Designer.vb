<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogInsertarProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogInsertarProducto))
        Me.ins_producto_img = New System.Windows.Forms.TextBox()
        Me.ins_producto_nombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ins_producto_marca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ins_prodcto_categorias = New System.Windows.Forms.CheckedListBox()
        Me.btn_ins_tienda = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ins_producto_tienda = New System.Windows.Forms.ComboBox()
        Me.ins_producto_precio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ins_producto_img
        '
        Me.ins_producto_img.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_producto_img.Location = New System.Drawing.Point(202, 186)
        Me.ins_producto_img.Name = "ins_producto_img"
        Me.ins_producto_img.Size = New System.Drawing.Size(408, 42)
        Me.ins_producto_img.TabIndex = 2
        '
        'ins_producto_nombre
        '
        Me.ins_producto_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_producto_nombre.Location = New System.Drawing.Point(202, 45)
        Me.ins_producto_nombre.Name = "ins_producto_nombre"
        Me.ins_producto_nombre.Size = New System.Drawing.Size(408, 42)
        Me.ins_producto_nombre.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "URL Foto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre:"
        '
        'ins_producto_marca
        '
        Me.ins_producto_marca.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_producto_marca.Location = New System.Drawing.Point(202, 116)
        Me.ins_producto_marca.Name = "ins_producto_marca"
        Me.ins_producto_marca.Size = New System.Drawing.Size(408, 42)
        Me.ins_producto_marca.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(653, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 30)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Categorias:"
        '
        'ins_prodcto_categorias
        '
        Me.ins_prodcto_categorias.FormattingEnabled = True
        Me.ins_prodcto_categorias.Location = New System.Drawing.Point(648, 83)
        Me.ins_prodcto_categorias.Name = "ins_prodcto_categorias"
        Me.ins_prodcto_categorias.Size = New System.Drawing.Size(311, 319)
        Me.ins_prodcto_categorias.TabIndex = 5
        '
        'btn_ins_tienda
        '
        Me.btn_ins_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ins_tienda.Location = New System.Drawing.Point(325, 472)
        Me.btn_ins_tienda.Name = "btn_ins_tienda"
        Me.btn_ins_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_ins_tienda.TabIndex = 6
        Me.btn_ins_tienda.Text = "Insertar"
        Me.btn_ins_tienda.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 30)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tienda:"
        '
        'ins_producto_tienda
        '
        Me.ins_producto_tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ins_producto_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_producto_tienda.FormattingEnabled = True
        Me.ins_producto_tienda.Location = New System.Drawing.Point(202, 264)
        Me.ins_producto_tienda.Name = "ins_producto_tienda"
        Me.ins_producto_tienda.Size = New System.Drawing.Size(408, 42)
        Me.ins_producto_tienda.TabIndex = 3
        '
        'ins_producto_precio
        '
        Me.ins_producto_precio.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_producto_precio.Location = New System.Drawing.Point(202, 340)
        Me.ins_producto_precio.Name = "ins_producto_precio"
        Me.ins_producto_precio.Size = New System.Drawing.Size(408, 42)
        Me.ins_producto_precio.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 347)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 30)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Precio:"
        '
        'DialogInsertarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.ins_producto_precio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ins_producto_tienda)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_ins_tienda)
        Me.Controls.Add(Me.ins_prodcto_categorias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ins_producto_marca)
        Me.Controls.Add(Me.ins_producto_img)
        Me.Controls.Add(Me.ins_producto_nombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogInsertarProducto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insertar Producto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ins_producto_img As System.Windows.Forms.TextBox
    Friend WithEvents ins_producto_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ins_producto_marca As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ins_prodcto_categorias As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_ins_tienda As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ins_producto_tienda As System.Windows.Forms.ComboBox
    Friend WithEvents ins_producto_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
