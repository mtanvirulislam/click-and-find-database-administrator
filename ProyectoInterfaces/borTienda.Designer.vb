<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogBorrarTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogBorrarTienda))
        Me.cBox_bor_tienda = New System.Windows.Forms.ComboBox()
        Me.bor_WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.bor_tienda_web = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_bor_tienda = New System.Windows.Forms.Button()
        Me.bor_tienda_tipo = New System.Windows.Forms.ComboBox()
        Me.bor_tienda_longitud = New System.Windows.Forms.TextBox()
        Me.bor_tienda_latitud = New System.Windows.Forms.TextBox()
        Me.bor_tienda_nombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cBox_bor_tienda
        '
        Me.cBox_bor_tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_bor_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBox_bor_tienda.FormattingEnabled = True
        Me.cBox_bor_tienda.Items.AddRange(New Object() {"aa"})
        Me.cBox_bor_tienda.Location = New System.Drawing.Point(180, 26)
        Me.cBox_bor_tienda.Name = "cBox_bor_tienda"
        Me.cBox_bor_tienda.Size = New System.Drawing.Size(408, 42)
        Me.cBox_bor_tienda.TabIndex = 0
        '
        'bor_WebBrowser
        '
        Me.bor_WebBrowser.Location = New System.Drawing.Point(594, -84)
        Me.bor_WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.bor_WebBrowser.Name = "bor_WebBrowser"
        Me.bor_WebBrowser.Size = New System.Drawing.Size(403, 647)
        Me.bor_WebBrowser.TabIndex = 37
        Me.bor_WebBrowser.Url = New System.Uri("", System.UriKind.Relative)
        '
        'bor_tienda_web
        '
        Me.bor_tienda_web.Enabled = False
        Me.bor_tienda_web.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_tienda_web.Location = New System.Drawing.Point(180, 390)
        Me.bor_tienda_web.Name = "bor_tienda_web"
        Me.bor_tienda_web.Size = New System.Drawing.Size(408, 42)
        Me.bor_tienda_web.TabIndex = 5
        Me.bor_tienda_web.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 30)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Web:"
        Me.Label5.Visible = False
        '
        'btn_bor_tienda
        '
        Me.btn_bor_tienda.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bor_tienda.Location = New System.Drawing.Point(303, 462)
        Me.btn_bor_tienda.Name = "btn_bor_tienda"
        Me.btn_bor_tienda.Size = New System.Drawing.Size(285, 61)
        Me.btn_bor_tienda.TabIndex = 6
        Me.btn_bor_tienda.Text = "Modificar"
        Me.btn_bor_tienda.UseVisualStyleBackColor = True
        '
        'bor_tienda_tipo
        '
        Me.bor_tienda_tipo.DisplayMember = "1"
        Me.bor_tienda_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bor_tienda_tipo.Enabled = False
        Me.bor_tienda_tipo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_tienda_tipo.FormattingEnabled = True
        Me.bor_tienda_tipo.Items.AddRange(New Object() {"Fisica", "Online"})
        Me.bor_tienda_tipo.Location = New System.Drawing.Point(180, 170)
        Me.bor_tienda_tipo.Name = "bor_tienda_tipo"
        Me.bor_tienda_tipo.Size = New System.Drawing.Size(408, 42)
        Me.bor_tienda_tipo.TabIndex = 2
        '
        'bor_tienda_longitud
        '
        Me.bor_tienda_longitud.Enabled = False
        Me.bor_tienda_longitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_tienda_longitud.Location = New System.Drawing.Point(180, 314)
        Me.bor_tienda_longitud.Name = "bor_tienda_longitud"
        Me.bor_tienda_longitud.Size = New System.Drawing.Size(408, 42)
        Me.bor_tienda_longitud.TabIndex = 4
        '
        'bor_tienda_latitud
        '
        Me.bor_tienda_latitud.Enabled = False
        Me.bor_tienda_latitud.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_tienda_latitud.Location = New System.Drawing.Point(180, 240)
        Me.bor_tienda_latitud.Name = "bor_tienda_latitud"
        Me.bor_tienda_latitud.Size = New System.Drawing.Size(408, 42)
        Me.bor_tienda_latitud.TabIndex = 3
        '
        'bor_tienda_nombre
        '
        Me.bor_tienda_nombre.Enabled = False
        Me.bor_tienda_nombre.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bor_tienda_nombre.Location = New System.Drawing.Point(180, 99)
        Me.bor_tienda_nombre.Name = "bor_tienda_nombre"
        Me.bor_tienda_nombre.Size = New System.Drawing.Size(408, 42)
        Me.bor_tienda_nombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 30)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Longitud:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 30)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Latitud:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 30)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 30)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nombre:"
        '
        'DialogBorrarTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.cBox_bor_tienda)
        Me.Controls.Add(Me.bor_WebBrowser)
        Me.Controls.Add(Me.bor_tienda_web)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_bor_tienda)
        Me.Controls.Add(Me.bor_tienda_tipo)
        Me.Controls.Add(Me.bor_tienda_longitud)
        Me.Controls.Add(Me.bor_tienda_latitud)
        Me.Controls.Add(Me.bor_tienda_nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogBorrarTienda"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Baja Tienda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cBox_bor_tienda As System.Windows.Forms.ComboBox
    Friend WithEvents bor_WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents bor_tienda_web As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_bor_tienda As System.Windows.Forms.Button
    Friend WithEvents bor_tienda_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents bor_tienda_longitud As System.Windows.Forms.TextBox
    Friend WithEvents bor_tienda_latitud As System.Windows.Forms.TextBox
    Friend WithEvents bor_tienda_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
