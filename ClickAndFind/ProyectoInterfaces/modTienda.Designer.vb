<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogModificarTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogModificarTienda))
        Me.mod_WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.mod_tienda_web = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_mod_tienda = New System.Windows.Forms.Button()
        Me.mod_tienda_tipo = New System.Windows.Forms.ComboBox()
        Me.mod_tienda_longitud = New System.Windows.Forms.TextBox()
        Me.mod_tienda_latitud = New System.Windows.Forms.TextBox()
        Me.mod_tienda_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cBox_mod_tienda = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'mod_WebBrowser
        '
        Me.mod_WebBrowser.Location = New System.Drawing.Point(593, -84)
        Me.mod_WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.mod_WebBrowser.Name = "mod_WebBrowser"
        Me.mod_WebBrowser.Size = New System.Drawing.Size(403, 647)
        Me.mod_WebBrowser.TabIndex = 24
        Me.mod_WebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'mod_tienda_web
        '
        Me.mod_tienda_web.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_tienda_web.Location = New System.Drawing.Point(179, 390)
        Me.mod_tienda_web.Name = "mod_tienda_web"
        Me.mod_tienda_web.Size = New System.Drawing.Size(408, 42)
        Me.mod_tienda_web.TabIndex = 5
        Me.mod_tienda_web.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Web:"
        Me.Label5.Visible = False
        '
        'btn_mod_tienda
        '
        Me.btn_mod_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod_tienda.Location = New System.Drawing.Point(302, 462)
        Me.btn_mod_tienda.Name = "btn_mod_tienda"
        Me.btn_mod_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_mod_tienda.TabIndex = 6
        Me.btn_mod_tienda.Text = "Modificar"
        Me.btn_mod_tienda.UseVisualStyleBackColor = True
        '
        'mod_tienda_tipo
        '
        Me.mod_tienda_tipo.DisplayMember = "1"
        Me.mod_tienda_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.mod_tienda_tipo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_tienda_tipo.FormattingEnabled = True
        Me.mod_tienda_tipo.Items.AddRange(New Object() {"Fisica", "Online"})
        Me.mod_tienda_tipo.Location = New System.Drawing.Point(179, 170)
        Me.mod_tienda_tipo.Name = "mod_tienda_tipo"
        Me.mod_tienda_tipo.Size = New System.Drawing.Size(408, 42)
        Me.mod_tienda_tipo.TabIndex = 2
        '
        'mod_tienda_longitud
        '
        Me.mod_tienda_longitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_tienda_longitud.Location = New System.Drawing.Point(179, 314)
        Me.mod_tienda_longitud.Name = "mod_tienda_longitud"
        Me.mod_tienda_longitud.Size = New System.Drawing.Size(408, 42)
        Me.mod_tienda_longitud.TabIndex = 4
        '
        'mod_tienda_latitud
        '
        Me.mod_tienda_latitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_tienda_latitud.Location = New System.Drawing.Point(179, 240)
        Me.mod_tienda_latitud.Name = "mod_tienda_latitud"
        Me.mod_tienda_latitud.Size = New System.Drawing.Size(408, 42)
        Me.mod_tienda_latitud.TabIndex = 3
        '
        'mod_tienda_nombre
        '
        Me.mod_tienda_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mod_tienda_nombre.Location = New System.Drawing.Point(179, 99)
        Me.mod_tienda_nombre.Name = "mod_tienda_nombre"
        Me.mod_tienda_nombre.Size = New System.Drawing.Size(408, 42)
        Me.mod_tienda_nombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Longitud:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Latitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 30)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre:"
        '
        'cBox_mod_tienda
        '
        Me.cBox_mod_tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_mod_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_mod_tienda.FormattingEnabled = True
        Me.cBox_mod_tienda.Items.AddRange(New Object() {"aa"})
        Me.cBox_mod_tienda.Location = New System.Drawing.Point(179, 26)
        Me.cBox_mod_tienda.Name = "cBox_mod_tienda"
        Me.cBox_mod_tienda.Size = New System.Drawing.Size(408, 42)
        Me.cBox_mod_tienda.TabIndex = 0
        '
        'DialogModificarTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_mod_tienda)
        Me.Controls.Add(Me.mod_WebBrowser)
        Me.Controls.Add(Me.mod_tienda_web)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_mod_tienda)
        Me.Controls.Add(Me.mod_tienda_tipo)
        Me.Controls.Add(Me.mod_tienda_longitud)
        Me.Controls.Add(Me.mod_tienda_latitud)
        Me.Controls.Add(Me.mod_tienda_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogModificarTienda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Tienda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mod_WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents mod_tienda_web As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_mod_tienda As System.Windows.Forms.Button
    Friend WithEvents mod_tienda_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents mod_tienda_longitud As System.Windows.Forms.TextBox
    Friend WithEvents mod_tienda_latitud As System.Windows.Forms.TextBox
    Friend WithEvents mod_tienda_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cBox_mod_tienda As System.Windows.Forms.ComboBox

End Class
