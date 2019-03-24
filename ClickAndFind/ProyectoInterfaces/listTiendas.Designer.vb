<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogListarTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogListarTiendas))
        Me.buscador_tiendas = New System.Windows.Forms.TextBox()
        Me.ListBoxTiendas = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'buscador_tiendas
        '
        Me.buscador_tiendas.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscador_tiendas.Location = New System.Drawing.Point(205, 73)
        Me.buscador_tiendas.Name = "buscador_tiendas"
        Me.buscador_tiendas.Size = New System.Drawing.Size(565, 42)
        Me.buscador_tiendas.TabIndex = 0
        '
        'ListBoxTiendas
        '
        Me.ListBoxTiendas.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTiendas.FormattingEnabled = True
        Me.ListBoxTiendas.ItemHeight = 34
        Me.ListBoxTiendas.Location = New System.Drawing.Point(205, 131)
        Me.ListBoxTiendas.Name = "ListBoxTiendas"
        Me.ListBoxTiendas.Size = New System.Drawing.Size(565, 310)
        Me.ListBoxTiendas.TabIndex = 1
        '
        'DialogListarTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.ListBoxTiendas)
        Me.Controls.Add(Me.buscador_tiendas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogListarTiendas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tiendas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buscador_tiendas As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxTiendas As System.Windows.Forms.ListBox

End Class
