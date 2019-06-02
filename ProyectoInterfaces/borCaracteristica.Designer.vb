<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBorrarCaracteristica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogBorrarCaracteristica))
        Me.cBox_bor_caracteristica = New System.Windows.Forms.ComboBox()
        Me.btn_bor_caracteristica = New System.Windows.Forms.Button()
        Me.bor_caracteristica_cate = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bor_caracteristica_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bor_categorias_todas = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cBox_bor_caracteristica
        '
        Me.cBox_bor_caracteristica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_bor_caracteristica.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_bor_caracteristica.FormattingEnabled = True
        Me.cBox_bor_caracteristica.Items.AddRange(New Object() {"aa"})
        Me.cBox_bor_caracteristica.Location = New System.Drawing.Point(232, 43)
        Me.cBox_bor_caracteristica.Name = "cBox_bor_caracteristica"
        Me.cBox_bor_caracteristica.Size = New System.Drawing.Size(408, 42)
        Me.cBox_bor_caracteristica.TabIndex = 0
        '
        'btn_bor_caracteristica
        '
        Me.btn_bor_caracteristica.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bor_caracteristica.Location = New System.Drawing.Point(355, 462)
        Me.btn_bor_caracteristica.Name = "btn_bor_caracteristica"
        Me.btn_bor_caracteristica.Size = New System.Drawing.Size(285, 61)
        Me.btn_bor_caracteristica.TabIndex = 4
        Me.btn_bor_caracteristica.Text = "Modificar"
        Me.btn_bor_caracteristica.UseVisualStyleBackColor = True
        '
        'bor_caracteristica_cate
        '
        Me.bor_caracteristica_cate.FormattingEnabled = True
        Me.bor_caracteristica_cate.Location = New System.Drawing.Point(232, 237)
        Me.bor_caracteristica_cate.Name = "bor_caracteristica_cate"
        Me.bor_caracteristica_cate.Size = New System.Drawing.Size(408, 172)
        Me.bor_caracteristica_cate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 30)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Categorias:"
        '
        'bor_caracteristica_nombre
        '
        Me.bor_caracteristica_nombre.Enabled = False
        Me.bor_caracteristica_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_caracteristica_nombre.Location = New System.Drawing.Point(232, 122)
        Me.bor_caracteristica_nombre.Name = "bor_caracteristica_nombre"
        Me.bor_caracteristica_nombre.Size = New System.Drawing.Size(408, 42)
        Me.bor_caracteristica_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Nombre:"
        '
        'bor_categorias_todas
        '
        Me.bor_categorias_todas.AutoSize = True
        Me.bor_categorias_todas.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_categorias_todas.Location = New System.Drawing.Point(236, 200)
        Me.bor_categorias_todas.Name = "bor_categorias_todas"
        Me.bor_categorias_todas.Size = New System.Drawing.Size(93, 27)
        Me.bor_categorias_todas.TabIndex = 2
        Me.bor_categorias_todas.Text = "Todas"
        Me.bor_categorias_todas.UseVisualStyleBackColor = True
        '
        'DialogBorrarCaracteristica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.bor_categorias_todas)
        Me.Controls.Add(Me.cBox_bor_caracteristica)
        Me.Controls.Add(Me.btn_bor_caracteristica)
        Me.Controls.Add(Me.bor_caracteristica_cate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.bor_caracteristica_nombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogBorrarCaracteristica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Baja Caracteristica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cBox_bor_caracteristica As System.Windows.Forms.ComboBox
    Friend WithEvents btn_bor_caracteristica As System.Windows.Forms.Button
    Friend WithEvents bor_caracteristica_cate As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bor_caracteristica_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bor_categorias_todas As System.Windows.Forms.CheckBox

End Class
