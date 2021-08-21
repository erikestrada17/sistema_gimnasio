<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirCred
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitirCred))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNroSocio = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNombreApellido = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblCodPostal = New System.Windows.Forms.Label()
        Me.lblTelefonoGim = New System.Windows.Forms.Label()
        Me.lblDireccionGim = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(606, 307)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 28)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(409, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 26)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Credencial de Socio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(362, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Activo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(284, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nro. de Socio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(284, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Fecha de ingreso:"
        '
        'lblNroSocio
        '
        Me.lblNroSocio.AutoSize = True
        Me.lblNroSocio.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNroSocio.Location = New System.Drawing.Point(385, 121)
        Me.lblNroSocio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNroSocio.Name = "lblNroSocio"
        Me.lblNroSocio.Size = New System.Drawing.Size(62, 16)
        Me.lblNroSocio.TabIndex = 15
        Me.lblNroSocio.Text = "nroSocio"
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.AutoSize = True
        Me.lblFechaIngreso.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblFechaIngreso.Location = New System.Drawing.Point(408, 159)
        Me.lblFechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(41, 16)
        Me.lblFechaIngreso.TabIndex = 16
        Me.lblFechaIngreso.Text = "fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(284, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nombre y Apellido:"
        '
        'lblNombreApellido
        '
        Me.lblNombreApellido.AutoSize = True
        Me.lblNombreApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreApellido.Location = New System.Drawing.Point(415, 226)
        Me.lblNombreApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreApellido.Name = "lblNombreApellido"
        Me.lblNombreApellido.Size = New System.Drawing.Size(104, 16)
        Me.lblNombreApellido.TabIndex = 18
        Me.lblNombreApellido.Text = "nombreApellido"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDireccion.Location = New System.Drawing.Point(284, 272)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(63, 16)
        Me.lblDireccion.TabIndex = 19
        Me.lblDireccion.Text = "direccion"
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLocalidad.Location = New System.Drawing.Point(284, 307)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(64, 16)
        Me.lblLocalidad.TabIndex = 20
        Me.lblLocalidad.Text = "localidad"
        '
        'lblCodPostal
        '
        Me.lblCodPostal.AutoSize = True
        Me.lblCodPostal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCodPostal.Location = New System.Drawing.Point(514, 307)
        Me.lblCodPostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(69, 16)
        Me.lblCodPostal.TabIndex = 21
        Me.lblCodPostal.Text = "codPostal"
        '
        'lblTelefonoGim
        '
        Me.lblTelefonoGim.AutoSize = True
        Me.lblTelefonoGim.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTelefonoGim.Location = New System.Drawing.Point(44, 307)
        Me.lblTelefonoGim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonoGim.Name = "lblTelefonoGim"
        Me.lblTelefonoGim.Size = New System.Drawing.Size(80, 16)
        Me.lblTelefonoGim.TabIndex = 22
        Me.lblTelefonoGim.Text = "telefonoGim"
        '
        'lblDireccionGim
        '
        Me.lblDireccionGim.AutoSize = True
        Me.lblDireccionGim.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDireccionGim.Location = New System.Drawing.Point(44, 282)
        Me.lblDireccionGim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccionGim.Name = "lblDireccionGim"
        Me.lblDireccionGim.Size = New System.Drawing.Size(87, 16)
        Me.lblDireccionGim.TabIndex = 23
        Me.lblDireccionGim.Text = "direccionGim"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(510, 76)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(190, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmEmitirCred
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CredencialDeProfesor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(719, 348)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDireccionGim)
        Me.Controls.Add(Me.lblTelefonoGim)
        Me.Controls.Add(Me.lblCodPostal)
        Me.Controls.Add(Me.lblLocalidad)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.lblNombreApellido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFechaIngreso)
        Me.Controls.Add(Me.lblNroSocio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmEmitirCred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credencial de Socio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lblNroSocio As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblDireccionGim As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoGim As System.Windows.Forms.Label
    Friend WithEvents lblCodPostal As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblNombreApellido As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
