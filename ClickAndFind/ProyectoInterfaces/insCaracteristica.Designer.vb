<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogInsertarCaracteristica
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogInsertarCaracteristica))
        Me.ins_caracteristica_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ins_caracteristica_cate = New System.Windows.Forms.CheckedListBox()
        Me.btn_ins_tienda = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ins_caracteristica_nombre
        '
        Me.ins_caracteristica_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_caracteristica_nombre.Location = New System.Drawing.Point(211, 100)
        Me.ins_caracteristica_nombre.Name = "ins_caracteristica_nombre"
        Me.ins_caracteristica_nombre.Size = New System.Drawing.Size(408, 42)
        Me.ins_caracteristica_nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Categorias:"
        '
        'ins_caracteristica_cate
        '
        Me.ins_caracteristica_cate.FormattingEnabled = True
        Me.ins_caracteristica_cate.Location = New System.Drawing.Point(211, 202)
        Me.ins_caracteristica_cate.Name = "ins_caracteristica_cate"
        Me.ins_caracteristica_cate.Size = New System.Drawing.Size(408, 214)
        Me.ins_caracteristica_cate.TabIndex = 1
        '
        'btn_ins_tienda
        '
        Me.btn_ins_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ins_tienda.Location = New System.Drawing.Point(334, 456)
        Me.btn_ins_tienda.Name = "btn_ins_tienda"
        Me.btn_ins_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_ins_tienda.TabIndex = 2
        Me.btn_ins_tienda.Text = "Insertar"
        Me.btn_ins_tienda.UseVisualStyleBackColor = True
        '
        'DialogInsertarCaracteristica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.btn_ins_tienda)
        Me.Controls.Add(Me.ins_caracteristica_cate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ins_caracteristica_nombre)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogInsertarCaracteristica"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insertar Caracteristica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ins_caracteristica_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ins_caracteristica_cate As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_ins_tienda As System.Windows.Forms.Button

End Class
