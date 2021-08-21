<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirCredProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitirCredProf))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblDireccionGim = New System.Windows.Forms.Label()
        Me.lblTelefonoGim = New System.Windows.Forms.Label()
        Me.lblNroProf = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreApellido = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombreClase = New System.Windows.Forms.Label()
        Me.lblNombreSalon = New System.Windows.Forms.Label()
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
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(605, 306)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 28)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'lblDireccionGim
        '
        Me.lblDireccionGim.AutoSize = True
        Me.lblDireccionGim.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDireccionGim.Location = New System.Drawing.Point(43, 281)
        Me.lblDireccionGim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccionGim.Name = "lblDireccionGim"
        Me.lblDireccionGim.Size = New System.Drawing.Size(87, 16)
        Me.lblDireccionGim.TabIndex = 1
        Me.lblDireccionGim.Text = "direccionGim"
        '
        'lblTelefonoGim
        '
        Me.lblTelefonoGim.AutoSize = True
        Me.lblTelefonoGim.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTelefonoGim.Location = New System.Drawing.Point(43, 306)
        Me.lblTelefonoGim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefonoGim.Name = "lblTelefonoGim"
        Me.lblTelefonoGim.Size = New System.Drawing.Size(80, 16)
        Me.lblTelefonoGim.TabIndex = 2
        Me.lblTelefonoGim.Text = "telefonoGim"
        '
        'lblNroProf
        '
        Me.lblNroProf.AutoSize = True
        Me.lblNroProf.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNroProf.Location = New System.Drawing.Point(409, 98)
        Me.lblNroProf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNroProf.Name = "lblNroProf"
        Me.lblNroProf.Size = New System.Drawing.Size(51, 16)
        Me.lblNroProf.TabIndex = 3
        Me.lblNroProf.Text = "nroProf"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(295, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DNI:"
        '
        'lblNombreApellido
        '
        Me.lblNombreApellido.AutoSize = True
        Me.lblNombreApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreApellido.Location = New System.Drawing.Point(295, 225)
        Me.lblNombreApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreApellido.Name = "lblNombreApellido"
        Me.lblNombreApellido.Size = New System.Drawing.Size(104, 16)
        Me.lblNombreApellido.TabIndex = 5
        Me.lblNombreApellido.Text = "nombreApellido"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(295, 273)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Clase:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(295, 306)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Salón:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(508, 76)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(192, 135)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(397, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Credencial de Profesor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(295, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nro de Profesor:"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDNI.Location = New System.Drawing.Point(337, 135)
        Me.lblDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(50, 16)
        Me.lblDNI.TabIndex = 12
        Me.lblDNI.Text = "nroDNI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(295, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Teléfono:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTelefono.Location = New System.Drawing.Point(368, 171)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(81, 16)
        Me.lblTelefono.TabIndex = 14
        Me.lblTelefono.Text = "nroTelefono"
        '
        'lblNombreClase
        '
        Me.lblNombreClase.AutoSize = True
        Me.lblNombreClase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreClase.Location = New System.Drawing.Point(349, 273)
        Me.lblNombreClase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreClase.Name = "lblNombreClase"
        Me.lblNombreClase.Size = New System.Drawing.Size(89, 16)
        Me.lblNombreClase.TabIndex = 15
        Me.lblNombreClase.Text = "nombreClase"
        '
        'lblNombreSalon
        '
        Me.lblNombreSalon.AutoSize = True
        Me.lblNombreSalon.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNombreSalon.Location = New System.Drawing.Point(349, 306)
        Me.lblNombreSalon.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreSalon.Name = "lblNombreSalon"
        Me.lblNombreSalon.Size = New System.Drawing.Size(89, 16)
        Me.lblNombreSalon.TabIndex = 16
        Me.lblNombreSalon.Text = "nombreSalon"
        '
        'frmEmitirCredProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.CredencialDeProfesor
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(719, 348)
        Me.Controls.Add(Me.lblNombreSalon)
        Me.Controls.Add(Me.lblNombreClase)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDNI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNombreApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNroProf)
        Me.Controls.Add(Me.lblTelefonoGim)
        Me.Controls.Add(Me.lblDireccionGim)
        Me.Controls.Add(Me.btnImprimir)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmEmitirCredProf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credencial de Profesor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNombreApellido As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNroProf As System.Windows.Forms.Label
    Friend WithEvents lblTelefonoGim As System.Windows.Forms.Label
    Friend WithEvents lblDireccionGim As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDNI As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNombreSalon As System.Windows.Forms.Label
    Friend WithEvents lblNombreClase As System.Windows.Forms.Label
End Class
