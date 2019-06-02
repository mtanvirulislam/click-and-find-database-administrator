<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogModificarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogModificarCategoria))
        Me.mod_categoria_esSuperior = New System.Windows.Forms.CheckBox()
        Me.btn_mod_categoria = New System.Windows.Forms.Button()
        Me.mod_categoria_superior = New System.Windows.Forms.ComboBox()
        Me.mod_categoria_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cBox_mod_categoria = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'mod_categoria_esSuperior
        '
        Me.mod_categoria_esSuperior.AutoSize = True
        Me.mod_categoria_esSuperior.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_categoria_esSuperior.Location = New System.Drawing.Point(222, 226)
        Me.mod_categoria_esSuperior.Name = "mod_categoria_esSuperior"
        Me.mod_categoria_esSuperior.Size = New System.Drawing.Size(136, 27)
        Me.mod_categoria_esSuperior.TabIndex = 2
        Me.mod_categoria_esSuperior.Text = "Es superior"
        Me.mod_categoria_esSuperior.UseVisualStyleBackColor = True
        '
        'btn_mod_categoria
        '
        Me.btn_mod_categoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod_categoria.Location = New System.Drawing.Point(345, 444)
        Me.btn_mod_categoria.Name = "btn_mod_categoria"
        Me.btn_mod_categoria.Size = New System.Drawing.Size(285, 61)
        Me.btn_mod_categoria.TabIndex = 4
        Me.btn_mod_categoria.Text = "Modificar"
        Me.btn_mod_categoria.UseVisualStyleBackColor = True
        '
        'mod_categoria_superior
        '
        Me.mod_categoria_superior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mod_categoria_superior.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_categoria_superior.FormattingEnabled = True
        Me.mod_categoria_superior.Items.AddRange(New Object() {"aa"})
        Me.mod_categoria_superior.Location = New System.Drawing.Point(222, 284)
        Me.mod_categoria_superior.Name = "mod_categoria_superior"
        Me.mod_categoria_superior.Size = New System.Drawing.Size(408, 42)
        Me.mod_categoria_superior.TabIndex = 3
        '
        'mod_categoria_nombre
        '
        Me.mod_categoria_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_categoria_nombre.Location = New System.Drawing.Point(222, 151)
        Me.mod_categoria_nombre.Name = "mod_categoria_nombre"
        Me.mod_categoria_nombre.Size = New System.Drawing.Size(408, 42)
        Me.mod_categoria_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Superior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre:"
        '
        'cBox_mod_categoria
        '
        Me.cBox_mod_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_mod_categoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_mod_categoria.FormattingEnabled = True
        Me.cBox_mod_categoria.Items.AddRange(New Object() {"aa"})
        Me.cBox_mod_categoria.Location = New System.Drawing.Point(222, 60)
        Me.cBox_mod_categoria.Name = "cBox_mod_categoria"
        Me.cBox_mod_categoria.Size = New System.Drawing.Size(408, 42)
        Me.cBox_mod_categoria.TabIndex = 0
        '
        'DialogModificarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_mod_categoria)
        Me.Controls.Add(Me.mod_categoria_esSuperior)
        Me.Controls.Add(Me.btn_mod_categoria)
        Me.Controls.Add(Me.mod_categoria_superior)
        Me.Controls.Add(Me.mod_categoria_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogModificarCategoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mod_categoria_esSuperior As System.Windows.Forms.CheckBox
    Friend WithEvents btn_mod_categoria As System.Windows.Forms.Button
    Friend WithEvents mod_categoria_superior As System.Windows.Forms.ComboBox
    Friend WithEvents mod_categoria_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cBox_mod_categoria As System.Windows.Forms.ComboBox

End Class
