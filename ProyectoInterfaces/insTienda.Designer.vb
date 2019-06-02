<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogInsertarTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogInsertarTienda))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ins_tienda_nombre = New System.Windows.Forms.TextBox()
        Me.ins_tienda_latitud = New System.Windows.Forms.TextBox()
        Me.ins_tienda_longitud = New System.Windows.Forms.TextBox()
        Me.ins_tienda_tipo = New System.Windows.Forms.ComboBox()
        Me.btn_ins_tienda = New System.Windows.Forms.Button()
        Me.ins_tienda_web = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Latitud:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 283)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Longitud:"
        '
        'ins_tienda_nombre
        '
        Me.ins_tienda_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_tienda_nombre.Location = New System.Drawing.Point(174, 61)
        Me.ins_tienda_nombre.Name = "ins_tienda_nombre"
        Me.ins_tienda_nombre.Size = New System.Drawing.Size(408, 42)
        Me.ins_tienda_nombre.TabIndex = 0
        '
        'ins_tienda_latitud
        '
        Me.ins_tienda_latitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_tienda_latitud.Location = New System.Drawing.Point(174, 202)
        Me.ins_tienda_latitud.Name = "ins_tienda_latitud"
        Me.ins_tienda_latitud.Size = New System.Drawing.Size(408, 42)
        Me.ins_tienda_latitud.TabIndex = 2
        '
        'ins_tienda_longitud
        '
        Me.ins_tienda_longitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_tienda_longitud.Location = New System.Drawing.Point(174, 276)
        Me.ins_tienda_longitud.Name = "ins_tienda_longitud"
        Me.ins_tienda_longitud.Size = New System.Drawing.Size(408, 42)
        Me.ins_tienda_longitud.TabIndex = 3
        '
        'ins_tienda_tipo
        '
        Me.ins_tienda_tipo.DisplayMember = "1"
        Me.ins_tienda_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ins_tienda_tipo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_tienda_tipo.FormattingEnabled = True
        Me.ins_tienda_tipo.Items.AddRange(New Object() {"Fisica", "Online"})
        Me.ins_tienda_tipo.Location = New System.Drawing.Point(174, 132)
        Me.ins_tienda_tipo.Name = "ins_tienda_tipo"
        Me.ins_tienda_tipo.Size = New System.Drawing.Size(408, 42)
        Me.ins_tienda_tipo.TabIndex = 1
        '
        'btn_ins_tienda
        '
        Me.btn_ins_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ins_tienda.Location = New System.Drawing.Point(297, 461)
        Me.btn_ins_tienda.Name = "btn_ins_tienda"
        Me.btn_ins_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_ins_tienda.TabIndex = 5
        Me.btn_ins_tienda.Text = "Insertar"
        Me.btn_ins_tienda.UseVisualStyleBackColor = True
        '
        'ins_tienda_web
        '
        Me.ins_tienda_web.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ins_tienda_web.Location = New System.Drawing.Point(174, 352)
        Me.ins_tienda_web.Name = "ins_tienda_web"
        Me.ins_tienda_web.Size = New System.Drawing.Size(408, 42)
        Me.ins_tienda_web.TabIndex = 4
        Me.ins_tienda_web.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 359)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Web:"
        Me.Label5.Visible = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(588, -85)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(403, 647)
        Me.WebBrowser1.TabIndex = 12
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'DialogInsertarTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ins_tienda_web)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_ins_tienda)
        Me.Controls.Add(Me.ins_tienda_tipo)
        Me.Controls.Add(Me.ins_tienda_longitud)
        Me.Controls.Add(Me.ins_tienda_latitud)
        Me.Controls.Add(Me.ins_tienda_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogInsertarTienda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insertar Tienda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ins_tienda_nombre As System.Windows.Forms.TextBox
    Friend WithEvents ins_tienda_latitud As System.Windows.Forms.TextBox
    Friend WithEvents ins_tienda_longitud As System.Windows.Forms.TextBox
    Friend WithEvents ins_tienda_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents btn_ins_tienda As System.Windows.Forms.Button
    Friend WithEvents ins_tienda_web As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
