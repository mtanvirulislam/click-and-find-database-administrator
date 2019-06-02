<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogInsertarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogInsertarCategoria))
        Me.ins_categoria_superior = New System.Windows.Forms.ComboBox()
        Me.ins_categoria_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ins_categoria = New System.Windows.Forms.Button()
        Me.ins_categoria_esSuperior = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ins_categoria_superior
        '
        Me.ins_categoria_superior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ins_categoria_superior.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_categoria_superior.FormattingEnabled = True
        Me.ins_categoria_superior.Items.AddRange(New Object() {"aa"})
        Me.ins_categoria_superior.Location = New System.Drawing.Point(213, 224)
        Me.ins_categoria_superior.Name = "ins_categoria_superior"
        Me.ins_categoria_superior.Size = New System.Drawing.Size(408, 42)
        Me.ins_categoria_superior.TabIndex = 2
        '
        'ins_categoria_nombre
        '
        Me.ins_categoria_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_categoria_nombre.Location = New System.Drawing.Point(213, 91)
        Me.ins_categoria_nombre.Name = "ins_categoria_nombre"
        Me.ins_categoria_nombre.Size = New System.Drawing.Size(408, 42)
        Me.ins_categoria_nombre.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Superior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre:"
        '
        'btn_ins_categoria
        '
        Me.btn_ins_categoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ins_categoria.Location = New System.Drawing.Point(336, 443)
        Me.btn_ins_categoria.Name = "btn_ins_categoria"
        Me.btn_ins_categoria.Size = New System.Drawing.Size(285, 61)
        Me.btn_ins_categoria.TabIndex = 3
        Me.btn_ins_categoria.Text = "Insertar"
        Me.btn_ins_categoria.UseVisualStyleBackColor = True
        '
        'ins_categoria_esSuperior
        '
        Me.ins_categoria_esSuperior.AutoSize = True
        Me.ins_categoria_esSuperior.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_categoria_esSuperior.Location = New System.Drawing.Point(213, 166)
        Me.ins_categoria_esSuperior.Name = "ins_categoria_esSuperior"
        Me.ins_categoria_esSuperior.Size = New System.Drawing.Size(136, 27)
        Me.ins_categoria_esSuperior.TabIndex = 1
        Me.ins_categoria_esSuperior.Text = "Es superior"
        Me.ins_categoria_esSuperior.UseVisualStyleBackColor = True
        '
        'DialogInsertarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.ins_categoria_esSuperior)
        Me.Controls.Add(Me.btn_ins_categoria)
        Me.Controls.Add(Me.ins_categoria_superior)
        Me.Controls.Add(Me.ins_categoria_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogInsertarCategoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insertar Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ins_categoria_superior As System.Windows.Forms.ComboBox
    Friend WithEvents ins_categoria_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_ins_categoria As System.Windows.Forms.Button
    Friend WithEvents ins_categoria_esSuperior As System.Windows.Forms.CheckBox

End Class
