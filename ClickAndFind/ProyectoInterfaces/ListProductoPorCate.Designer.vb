<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogListarProPorCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DialogListarProPorCategoria))
        Me.ListBoxProductos = New System.Windows.Forms.ListBox()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ListBoxProductos
        '
        Me.ListBoxProductos.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxProductos.FormattingEnabled = True
        Me.ListBoxProductos.ItemHeight = 34
        Me.ListBoxProductos.Location = New System.Drawing.Point(202, 135)
        Me.ListBoxProductos.Name = "ListBoxProductos"
        Me.ListBoxProductos.Size = New System.Drawing.Size(565, 310)
        Me.ListBoxProductos.TabIndex = 1
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCategoria.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(202, 79)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(565, 42)
        Me.ComboBoxCategoria.TabIndex = 0
        '
        'DialogListarProPorCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 560)
        Me.Controls.Add(Me.ComboBoxCategoria)
        Me.Controls.Add(Me.ListBoxProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DialogListarProPorCategoria"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listar producto por Categoria"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxProductos As System.Windows.Forms.ListBox
    Friend WithEvents ComboBoxCategoria As System.Windows.Forms.ComboBox

End Class
