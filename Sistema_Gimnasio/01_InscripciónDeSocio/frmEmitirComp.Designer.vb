<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmitirComp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmitirComp))
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombreApellido = New System.Windows.Forms.Label()
        Me.lblNroDNI = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodPago = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(572, 377)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(100, 30)
        Me.btnImprimir.TabIndex = 0
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.firma
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 274)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblNombreApellido
        '
        Me.lblNombreApellido.AutoSize = True
        Me.lblNombreApellido.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombreApellido.Location = New System.Drawing.Point(160, 169)
        Me.lblNombreApellido.Name = "lblNombreApellido"
        Me.lblNombreApellido.Size = New System.Drawing.Size(79, 13)
        Me.lblNombreApellido.TabIndex = 2
        Me.lblNombreApellido.Text = "nombreApellido"
        '
        'lblNroDNI
        '
        Me.lblNroDNI.AutoSize = True
        Me.lblNroDNI.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNroDNI.Location = New System.Drawing.Point(346, 169)
        Me.lblNroDNI.Name = "lblNroDNI"
        Me.lblNroDNI.Size = New System.Drawing.Size(41, 13)
        Me.lblNroDNI.TabIndex = 3
        Me.lblNroDNI.Text = "nroDNI"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio.Location = New System.Drawing.Point(130, 200)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(36, 13)
        Me.lblPrecio.TabIndex = 4
        Me.lblPrecio.Text = "precio"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblDescripcion.Location = New System.Drawing.Point(160, 235)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(61, 13)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "descripcion"
        '
        'lblCodPago
        '
        Me.lblCodPago.AutoSize = True
        Me.lblCodPago.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCodPago.Location = New System.Drawing.Point(218, 64)
        Me.lblCodPago.Name = "lblCodPago"
        Me.lblCodPago.Size = New System.Drawing.Size(50, 13)
        Me.lblCodPago.TabIndex = 6
        Me.lblCodPago.Text = "codPago"
        '
        'frmEmitirComp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ComprobanteDePago
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 419)
        Me.Controls.Add(Me.lblCodPago)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblNroDNI)
        Me.Controls.Add(Me.lblNombreApellido)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEmitirComp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comprobante de Pago"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblNroDNI As System.Windows.Forms.Label
    Friend WithEvents lblNombreApellido As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblCodPago As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
End Class
