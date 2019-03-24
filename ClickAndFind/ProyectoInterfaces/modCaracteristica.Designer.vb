<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogModificarCaracteristica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogModificarCaracteristica))
        Me.btn_mod_caracteristica = New System.Windows.Forms.Button()
        Me.mod_caracteristica_cate = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mod_caracteristica_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cBox_mod_caracteristica = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_mod_caracteristica
        '
        Me.btn_mod_caracteristica.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod_caracteristica.Location = New System.Drawing.Point(360, 464)
        Me.btn_mod_caracteristica.Name = "btn_mod_caracteristica"
        Me.btn_mod_caracteristica.Size = New System.Drawing.Size(285, 61)
        Me.btn_mod_caracteristica.TabIndex = 3
        Me.btn_mod_caracteristica.Text = "Modificar"
        Me.btn_mod_caracteristica.UseVisualStyleBackColor = True
        '
        'mod_caracteristica_cate
        '
        Me.mod_caracteristica_cate.FormattingEnabled = True
        Me.mod_caracteristica_cate.Location = New System.Drawing.Point(237, 210)
        Me.mod_caracteristica_cate.Name = "mod_caracteristica_cate"
        Me.mod_caracteristica_cate.Size = New System.Drawing.Size(408, 214)
        Me.mod_caracteristica_cate.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 30)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Categorias:"
        '
        'mod_caracteristica_nombre
        '
        Me.mod_caracteristica_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_caracteristica_nombre.Location = New System.Drawing.Point(237, 124)
        Me.mod_caracteristica_nombre.Name = "mod_caracteristica_nombre"
        Me.mod_caracteristica_nombre.Size = New System.Drawing.Size(408, 42)
        Me.mod_caracteristica_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre:"
        '
        'cBox_mod_caracteristica
        '
        Me.cBox_mod_caracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_mod_caracteristica.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_mod_caracteristica.FormattingEnabled = True
        Me.cBox_mod_caracteristica.Items.AddRange(New Object() {"aa"})
        Me.cBox_mod_caracteristica.Location = New System.Drawing.Point(237, 45)
        Me.cBox_mod_caracteristica.Name = "cBox_mod_caracteristica"
        Me.cBox_mod_caracteristica.Size = New System.Drawing.Size(408, 42)
        Me.cBox_mod_caracteristica.TabIndex = 0
        '
        'DialogModificarCaracteristica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_mod_caracteristica)
        Me.Controls.Add(Me.btn_mod_caracteristica)
        Me.Controls.Add(Me.mod_caracteristica_cate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mod_caracteristica_nombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogModificarCaracteristica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Caracteristica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_mod_caracteristica As System.Windows.Forms.Button
    Friend WithEvents mod_caracteristica_cate As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mod_caracteristica_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cBox_mod_caracteristica As System.Windows.Forms.ComboBox

End Class
