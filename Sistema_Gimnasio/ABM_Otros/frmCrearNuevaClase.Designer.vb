<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearNuevaClase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCrearNuevaClase))
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblNombreSalon = New System.Windows.Forms.Label()
        Me.btnCrearClase = New System.Windows.Forms.Button()
        Me.cboSalones = New System.Windows.Forms.ComboBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDefinirHorario = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lbldiaSeleccionado = New System.Windows.Forms.Label()
        Me.cboDias = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblClaseSeleccionada = New System.Windows.Forms.Label()
        Me.cboHorarios = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(16, 380)
        Me.btnVolverAlMenu.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(133, 49)
        Me.btnVolverAlMenu.TabIndex = 9
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNombreSalon)
        Me.GroupBox1.Controls.Add(Me.btnCrearClase)
        Me.GroupBox1.Controls.Add(Me.cboSalones)
        Me.GroupBox1.Controls.Add(Me.txtSalario)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 25)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(333, 308)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos de la Nueva Clase"
        '
        'lblNombreSalon
        '
        Me.lblNombreSalon.AutoSize = True
        Me.lblNombreSalon.Location = New System.Drawing.Point(83, 142)
        Me.lblNombreSalon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreSalon.Name = "lblNombreSalon"
        Me.lblNombreSalon.Size = New System.Drawing.Size(173, 16)
        Me.lblNombreSalon.TabIndex = 13
        Me.lblNombreSalon.Text = "nombreSalonSeleccionado"
        '
        'btnCrearClase
        '
        Me.btnCrearClase.Location = New System.Drawing.Point(87, 258)
        Me.btnCrearClase.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCrearClase.Name = "btnCrearClase"
        Me.btnCrearClase.Size = New System.Drawing.Size(160, 49)
        Me.btnCrearClase.TabIndex = 7
        Me.btnCrearClase.Text = "Crear Nueva Clase"
        Me.btnCrearClase.UseVisualStyleBackColor = True
        '
        'cboSalones
        '
        Me.cboSalones.FormattingEnabled = True
        Me.cboSalones.Location = New System.Drawing.Point(17, 105)
        Me.cboSalones.Margin = New System.Windows.Forms.Padding(4)
        Me.cboSalones.Name = "cboSalones"
        Me.cboSalones.Size = New System.Drawing.Size(288, 24)
        Me.cboSalones.TabIndex = 12
        Me.cboSalones.Text = "Seleccione uno de los salones"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(87, 193)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(219, 22)
        Me.txtSalario.TabIndex = 9
        Me.txtSalario.Text = "salario de clase por hora"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 46)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 142)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Salón:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 197)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Salario:"
        '
        'btnDefinirHorario
        '
        Me.btnDefinirHorario.Location = New System.Drawing.Point(87, 258)
        Me.btnDefinirHorario.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDefinirHorario.Name = "btnDefinirHorario"
        Me.btnDefinirHorario.Size = New System.Drawing.Size(160, 49)
        Me.btnDefinirHorario.TabIndex = 12
        Me.btnDefinirHorario.Text = "Definir Horario"
        Me.btnDefinirHorario.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.lbldiaSeleccionado)
        Me.GroupBox2.Controls.Add(Me.cboDias)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblClaseSeleccionada)
        Me.GroupBox2.Controls.Add(Me.cboHorarios)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnDefinirHorario)
        Me.GroupBox2.Location = New System.Drawing.Point(407, 25)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(333, 308)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Puede Definir el Horario de una Clase"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(87, 217)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(165, 22)
        Me.NumericUpDown1.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Duración:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(87, 172)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 22)
        Me.DateTimePicker1.TabIndex = 26
        Me.DateTimePicker1.Value = New Date(2021, 7, 16, 12, 0, 0, 0)
        '
        'lbldiaSeleccionado
        '
        Me.lbldiaSeleccionado.AutoSize = True
        Me.lbldiaSeleccionado.Location = New System.Drawing.Point(83, 134)
        Me.lbldiaSeleccionado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbldiaSeleccionado.Name = "lbldiaSeleccionado"
        Me.lbldiaSeleccionado.Size = New System.Drawing.Size(111, 16)
        Me.lbldiaSeleccionado.TabIndex = 24
        Me.lbldiaSeleccionado.Text = "diaSeleccionada"
        '
        'cboDias
        '
        Me.cboDias.FormattingEnabled = True
        Me.cboDias.Location = New System.Drawing.Point(17, 105)
        Me.cboDias.Margin = New System.Windows.Forms.Padding(4)
        Me.cboDias.Name = "cboDias"
        Me.cboDias.Size = New System.Drawing.Size(288, 24)
        Me.cboDias.TabIndex = 22
        Me.cboDias.Text = "Seleccione un dia de la semana"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Clase:"
        '
        'lblClaseSeleccionada
        '
        Me.lblClaseSeleccionada.AutoSize = True
        Me.lblClaseSeleccionada.Location = New System.Drawing.Point(83, 64)
        Me.lblClaseSeleccionada.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClaseSeleccionada.Name = "lblClaseSeleccionada"
        Me.lblClaseSeleccionada.Size = New System.Drawing.Size(173, 16)
        Me.lblClaseSeleccionada.TabIndex = 18
        Me.lblClaseSeleccionada.Text = "nombreClaseSeleccionada"
        '
        'cboHorarios
        '
        Me.cboHorarios.FormattingEnabled = True
        Me.cboHorarios.Location = New System.Drawing.Point(17, 31)
        Me.cboHorarios.Margin = New System.Windows.Forms.Padding(4)
        Me.cboHorarios.Name = "cboHorarios"
        Me.cboHorarios.Size = New System.Drawing.Size(288, 24)
        Me.cboHorarios.TabIndex = 17
        Me.cboHorarios.Text = "Seleccione una de las clases"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Horario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 134)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Día:"
        '
        'frmCrearNuevaClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCrearNuevaClase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Nueva Clase"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCrearClase As System.Windows.Forms.Button
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSalones As System.Windows.Forms.ComboBox
    Friend WithEvents lblNombreSalon As System.Windows.Forms.Label
    Friend WithEvents btnDefinirHorario As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblClaseSeleccionada As System.Windows.Forms.Label
    Friend WithEvents cboHorarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbldiaSeleccionado As System.Windows.Forms.Label
    Friend WithEvents cboDias As System.Windows.Forms.ComboBox
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
End Class
