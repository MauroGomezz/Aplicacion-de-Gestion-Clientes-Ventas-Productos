<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Examen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Clientetxt = New System.Windows.Forms.TextBox()
        Me.Telefonotxt = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Idtext = New System.Windows.Forms.TextBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(513, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.ReadOnly = True
        Me.DataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(685, 637)
        Me.DataGridView1.TabIndex = 0
        '
        'Clientetxt
        '
        Me.Clientetxt.Location = New System.Drawing.Point(41, 241)
        Me.Clientetxt.Name = "Clientetxt"
        Me.Clientetxt.Size = New System.Drawing.Size(114, 20)
        Me.Clientetxt.TabIndex = 1
        '
        'Telefonotxt
        '
        Me.Telefonotxt.Location = New System.Drawing.Point(41, 314)
        Me.Telefonotxt.Name = "Telefonotxt"
        Me.Telefonotxt.Size = New System.Drawing.Size(114, 20)
        Me.Telefonotxt.TabIndex = 2
        '
        'Correotxt
        '
        Me.Correotxt.Location = New System.Drawing.Point(41, 386)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(114, 20)
        Me.Correotxt.TabIndex = 3
        '
        'Agregar
        '
        Me.Agregar.Location = New System.Drawing.Point(78, 524)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(76, 37)
        Me.Agregar.TabIndex = 4
        Me.Agregar.Text = "Agregar"
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Idtext
        '
        Me.Idtext.Location = New System.Drawing.Point(41, 168)
        Me.Idtext.Name = "Idtext"
        Me.Idtext.Size = New System.Drawing.Size(114, 20)
        Me.Idtext.TabIndex = 5
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(242, 524)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(76, 37)
        Me.Borrar.TabIndex = 6
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(41, 468)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 20)
        Me.TextBox1.TabIndex = 7
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(160, 524)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(76, 37)
        Me.Actualizar.TabIndex = 9
        Me.Actualizar.Text = "Editar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(287, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(76, 37)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(205, 406)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(76, 37)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Guardar"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.VentasToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(309, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'Examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1198, 637)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Idtext)
        Me.Controls.Add(Me.Agregar)
        Me.Controls.Add(Me.Correotxt)
        Me.Controls.Add(Me.Telefonotxt)
        Me.Controls.Add(Me.Clientetxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Examen"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Clientetxt As TextBox
    Friend WithEvents Telefonotxt As TextBox
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents Agregar As Button
    Friend WithEvents Idtext As TextBox
    Friend WithEvents Borrar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Actualizar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
End Class
