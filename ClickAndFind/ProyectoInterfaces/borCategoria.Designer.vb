<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBorrarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogBorrarCategoria))
        Me.cBox_bor_categoria = New System.Windows.Forms.ComboBox()
        Me.bor_categoria_esSuperior = New System.Windows.Forms.CheckBox()
        Me.btn_bor_categoria = New System.Windows.Forms.Button()
        Me.bor_categoria_superior = New System.Windows.Forms.ComboBox()
        Me.bor_categoria_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cBox_bor_categoria
        '
        Me.cBox_bor_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_bor_categoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_bor_categoria.FormattingEnabled = True
        Me.cBox_bor_categoria.Items.AddRange(New Object() {"aa"})
        Me.cBox_bor_categoria.Location = New System.Drawing.Point(211, 54)
        Me.cBox_bor_categoria.Name = "cBox_bor_categoria"
        Me.cBox_bor_categoria.Size = New System.Drawing.Size(408, 42)
        Me.cBox_bor_categoria.TabIndex = 0
        '
        'bor_categoria_esSuperior
        '
        Me.bor_categoria_esSuperior.AutoSize = True
        Me.bor_categoria_esSuperior.Enabled = False
        Me.bor_categoria_esSuperior.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_categoria_esSuperior.Location = New System.Drawing.Point(211, 220)
        Me.bor_categoria_esSuperior.Name = "bor_categoria_esSuperior"
        Me.bor_categoria_esSuperior.Size = New System.Drawing.Size(136, 27)
        Me.bor_categoria_esSuperior.TabIndex = 2
        Me.bor_categoria_esSuperior.Text = "Es superior"
        Me.bor_categoria_esSuperior.UseVisualStyleBackColor = True
        '
        'btn_bor_categoria
        '
        Me.btn_bor_categoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bor_categoria.Location = New System.Drawing.Point(334, 438)
        Me.btn_bor_categoria.Name = "btn_bor_categoria"
        Me.btn_bor_categoria.Size = New System.Drawing.Size(285, 61)
        Me.btn_bor_categoria.TabIndex = 4
        Me.btn_bor_categoria.Text = "Baja"
        Me.btn_bor_categoria.UseVisualStyleBackColor = True
        '
        'bor_categoria_superior
        '
        Me.bor_categoria_superior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bor_categoria_superior.Enabled = False
        Me.bor_categoria_superior.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_categoria_superior.FormattingEnabled = True
        Me.bor_categoria_superior.Items.AddRange(New Object() {"aa"})
        Me.bor_categoria_superior.Location = New System.Drawing.Point(211, 278)
        Me.bor_categoria_superior.Name = "bor_categoria_superior"
        Me.bor_categoria_superior.Size = New System.Drawing.Size(408, 42)
        Me.bor_categoria_superior.TabIndex = 3
        '
        'bor_categoria_nombre
        '
        Me.bor_categoria_nombre.Enabled = False
        Me.bor_categoria_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_categoria_nombre.Location = New System.Drawing.Point(211, 145)
        Me.bor_categoria_nombre.Name = "bor_categoria_nombre"
        Me.bor_categoria_nombre.Size = New System.Drawing.Size(408, 42)
        Me.bor_categoria_nombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 30)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Superior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nombre:"
        '
        'DialogBorrarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_bor_categoria)
        Me.Controls.Add(Me.bor_categoria_esSuperior)
        Me.Controls.Add(Me.btn_bor_categoria)
        Me.Controls.Add(Me.bor_categoria_superior)
        Me.Controls.Add(Me.bor_categoria_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogBorrarCategoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Baja Categoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cBox_bor_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents bor_categoria_esSuperior As System.Windows.Forms.CheckBox
    Friend WithEvents btn_bor_categoria As System.Windows.Forms.Button
    Friend WithEvents bor_categoria_superior As System.Windows.Forms.ComboBox
    Friend WithEvents bor_categoria_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
