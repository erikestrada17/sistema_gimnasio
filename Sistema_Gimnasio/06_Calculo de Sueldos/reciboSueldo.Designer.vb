<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reciboSueldo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(reciboSueldo))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalSueldo = New System.Windows.Forms.Label()
        Me.lblBasicoSueldo = New System.Windows.Forms.Label()
        Me.lblAsistSueldo = New System.Windows.Forms.Label()
        Me.lblObraSueldo = New System.Windows.Forms.Label()
        Me.lblJubilSueldo = New System.Windows.Forms.Label()
        Me.lblRemSueldo = New System.Windows.Forms.Label()
        Me.lblDescSueldo = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(550, 333)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblTotalSueldo
        '
        Me.lblTotalSueldo.AutoSize = True
        Me.lblTotalSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblTotalSueldo.Location = New System.Drawing.Point(390, 296)
        Me.lblTotalSueldo.Name = "lblTotalSueldo"
        Me.lblTotalSueldo.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalSueldo.TabIndex = 1
        Me.lblTotalSueldo.Text = "Total"
        '
        'lblBasicoSueldo
        '
        Me.lblBasicoSueldo.AutoSize = True
        Me.lblBasicoSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblBasicoSueldo.Location = New System.Drawing.Point(317, 144)
        Me.lblBasicoSueldo.Name = "lblBasicoSueldo"
        Me.lblBasicoSueldo.Size = New System.Drawing.Size(38, 13)
        Me.lblBasicoSueldo.TabIndex = 2
        Me.lblBasicoSueldo.Text = "basico"
        '
        'lblAsistSueldo
        '
        Me.lblAsistSueldo.AutoSize = True
        Me.lblAsistSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblAsistSueldo.Location = New System.Drawing.Point(317, 157)
        Me.lblAsistSueldo.Name = "lblAsistSueldo"
        Me.lblAsistSueldo.Size = New System.Drawing.Size(54, 13)
        Me.lblAsistSueldo.TabIndex = 3
        Me.lblAsistSueldo.Text = "asistencia"
        '
        'lblObraSueldo
        '
        Me.lblObraSueldo.AutoSize = True
        Me.lblObraSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblObraSueldo.Location = New System.Drawing.Point(428, 226)
        Me.lblObraSueldo.Name = "lblObraSueldo"
        Me.lblObraSueldo.Size = New System.Drawing.Size(55, 13)
        Me.lblObraSueldo.TabIndex = 4
        Me.lblObraSueldo.Text = "obrasocial"
        '
        'lblJubilSueldo
        '
        Me.lblJubilSueldo.AutoSize = True
        Me.lblJubilSueldo.BackColor = System.Drawing.SystemColors.Window
        Me.lblJubilSueldo.Location = New System.Drawing.Point(428, 201)
        Me.lblJubilSueldo.Name = "lblJubilSueldo"
        Me.lblJubilSueldo.Size = New System.Drawing.Size(51, 13)
        Me.lblJubilSueldo.TabIndex = 4
        Me.lblJubilSueldo.Text = "jubilacion"
        '
        'lblRemSueldo
        '
        Me.lblRemSueldo.AutoSize = True
        Me.lblRemSueldo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblRemSueldo.Location = New System.Drawing.Point(317, 282)
        Me.lblRemSueldo.Name = "lblRemSueldo"
        Me.lblRemSueldo.Size = New System.Drawing.Size(44, 13)
        Me.lblRemSueldo.TabIndex = 5
        Me.lblRemSueldo.Text = "subtotal"
        '
        'lblDescSueldo
        '
        Me.lblDescSueldo.AutoSize = True
        Me.lblDescSueldo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblDescSueldo.Location = New System.Drawing.Point(428, 282)
        Me.lblDescSueldo.Name = "lblDescSueldo"
        Me.lblDescSueldo.Size = New System.Drawing.Size(44, 13)
        Me.lblDescSueldo.TabIndex = 6
        Me.lblDescSueldo.Text = "subtotal"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(448, 364)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(102, 34)
        Me.btnImprimir.TabIndex = 7
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.Location = New System.Drawing.Point(340, 364)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(102, 35)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'reciboSueldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 409)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblDescSueldo)
        Me.Controls.Add(Me.lblRemSueldo)
        Me.Controls.Add(Me.lblJubilSueldo)
        Me.Controls.Add(Me.lblObraSueldo)
        Me.Controls.Add(Me.lblAsistSueldo)
        Me.Controls.Add(Me.lblBasicoSueldo)
        Me.Controls.Add(Me.lblTotalSueldo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "reciboSueldo"
        Me.Text = "reciboSueldo"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalSueldo As System.Windows.Forms.Label
    Friend WithEvents lblBasicoSueldo As System.Windows.Forms.Label
    Friend WithEvents lblAsistSueldo As System.Windows.Forms.Label
    Friend WithEvents lblObraSueldo As System.Windows.Forms.Label
    Friend WithEvents lblJubilSueldo As System.Windows.Forms.Label
    Friend WithEvents lblRemSueldo As System.Windows.Forms.Label
    Friend WithEvents lblDescSueldo As System.Windows.Forms.Label
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
