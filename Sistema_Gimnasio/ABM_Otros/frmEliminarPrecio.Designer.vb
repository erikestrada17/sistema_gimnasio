<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarPrecio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEliminarPrecio))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarPrecio = New System.Windows.Forms.Button()
        Me.lblPrecioSeleccionado = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnEliminarPrecio)
        Me.GroupBox1.Controls.Add(Me.lblPrecioSeleccionado)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(53, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 271)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione el precio que desea eliminar"
        '
        'btnEliminarPrecio
        '
        Me.btnEliminarPrecio.Location = New System.Drawing.Point(205, 222)
        Me.btnEliminarPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarPrecio.Name = "btnEliminarPrecio"
        Me.btnEliminarPrecio.Size = New System.Drawing.Size(187, 49)
        Me.btnEliminarPrecio.TabIndex = 14
        Me.btnEliminarPrecio.Text = "Eliminar Precio"
        Me.btnEliminarPrecio.UseVisualStyleBackColor = True
        '
        'lblPrecioSeleccionado
        '
        Me.lblPrecioSeleccionado.AutoSize = True
        Me.lblPrecioSeleccionado.Location = New System.Drawing.Point(8, 206)
        Me.lblPrecioSeleccionado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioSeleccionado.Name = "lblPrecioSeleccionado"
        Me.lblPrecioSeleccionado.Size = New System.Drawing.Size(130, 16)
        Me.lblPrecioSeleccionado.TabIndex = 13
        Me.lblPrecioSeleccionado.Text = "precioSeleccionado"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(8, 23)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(384, 172)
        Me.DataGridView1.TabIndex = 12
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(16, 319)
        Me.btnVolverAlMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(133, 49)
        Me.btnVolverAlMenu.TabIndex = 12
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'frmEliminarPrecio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 383)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEliminarPrecio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar un Precio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrecioSeleccionado As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarPrecio As System.Windows.Forms.Button
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
End Class
