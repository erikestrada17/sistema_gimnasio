<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionRutinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionRutinas))
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.gboRutina = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPorDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gboRutina.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(151, 286)
        Me.btnRegistrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(187, 49)
        Me.btnRegistrar.TabIndex = 21
        Me.btnRegistrar.Text = "Registrar Rutina"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(16, 380)
        Me.btnVolverAlMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(133, 49)
        Me.btnVolverAlMenu.TabIndex = 19
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'gboRutina
        '
        Me.gboRutina.Controls.Add(Me.DateTimePicker2)
        Me.gboRutina.Controls.Add(Me.Label4)
        Me.gboRutina.Controls.Add(Me.btnRegistrar)
        Me.gboRutina.Controls.Add(Me.Label3)
        Me.gboRutina.Controls.Add(Me.DateTimePicker1)
        Me.gboRutina.Controls.Add(Me.TextBox1)
        Me.gboRutina.Controls.Add(Me.Label2)
        Me.gboRutina.Controls.Add(Me.txtPorDNI)
        Me.gboRutina.Controls.Add(Me.Label1)
        Me.gboRutina.Location = New System.Drawing.Point(36, 39)
        Me.gboRutina.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboRutina.Name = "gboRutina"
        Me.gboRutina.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboRutina.Size = New System.Drawing.Size(337, 335)
        Me.gboRutina.TabIndex = 18
        Me.gboRutina.TabStop = False
        Me.gboRutina.Text = "Ingresar datos de Rutina:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(156, 199)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 22)
        Me.DateTimePicker2.TabIndex = 15
        Me.DateTimePicker2.Value = New Date(2021, 7, 19, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fecha de Fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha de Inicio:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(156, 155)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(105, 22)
        Me.DateTimePicker1.TabIndex = 12
        Me.DateTimePicker1.Value = New Date(2021, 7, 19, 0, 0, 0, 0)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 113)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 22)
        Me.TextBox1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código de Profesor:"
        '
        'txtPorDNI
        '
        Me.txtPorDNI.Location = New System.Drawing.Point(63, 53)
        Me.txtPorDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPorDNI.Name = "txtPorDNI"
        Me.txtPorDNI.Size = New System.Drawing.Size(199, 22)
        Me.txtPorDNI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Socio:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(409, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(337, 335)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresar datos de Ejercicios"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(151, 286)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 49)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Registrar Ejercicio " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en Rutina"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(63, 113)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 122)
        Me.TextBox2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Descripción"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(63, 53)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 22)
        Me.TextBox3.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre:"
        '
        'frmGestionRutinas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.gboRutina)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmGestionRutinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de Rutinas"
        Me.gboRutina.ResumeLayout(False)
        Me.gboRutina.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents gboRutina As System.Windows.Forms.GroupBox
    Friend WithEvents txtPorDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
