<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstablecerHC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstablecerHC))
        Me.btnEstablecerHC = New System.Windows.Forms.Button()
        Me.btnIncluirProfEnClase = New System.Windows.Forms.Button()
        Me.btnGenerarDoc = New System.Windows.Forms.Button()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.lblClase = New System.Windows.Forms.Label()
        Me.DGVClases = New System.Windows.Forms.DataGridView()
        Me.gboClases = New System.Windows.Forms.GroupBox()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.DGVHorariosClases = New System.Windows.Forms.DataGridView()
        Me.gboHorariosClases = New System.Windows.Forms.GroupBox()
        CType(Me.DGVClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboClases.SuspendLayout()
        CType(Me.DGVHorariosClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboHorariosClases.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEstablecerHC
        '
        Me.btnEstablecerHC.Location = New System.Drawing.Point(33, 380)
        Me.btnEstablecerHC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEstablecerHC.Name = "btnEstablecerHC"
        Me.btnEstablecerHC.Size = New System.Drawing.Size(187, 49)
        Me.btnEstablecerHC.TabIndex = 6
        Me.btnEstablecerHC.Text = "Establecer Horario y Clase elegidos"
        Me.btnEstablecerHC.UseVisualStyleBackColor = True
        '
        'btnIncluirProfEnClase
        '
        Me.btnIncluirProfEnClase.Location = New System.Drawing.Point(432, 380)
        Me.btnIncluirProfEnClase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnIncluirProfEnClase.Name = "btnIncluirProfEnClase"
        Me.btnIncluirProfEnClase.Size = New System.Drawing.Size(187, 49)
        Me.btnIncluirProfEnClase.TabIndex = 7
        Me.btnIncluirProfEnClase.Text = "Incluir Profesor en Clase"
        Me.btnIncluirProfEnClase.UseVisualStyleBackColor = True
        '
        'btnGenerarDoc
        '
        Me.btnGenerarDoc.Location = New System.Drawing.Point(855, 380)
        Me.btnGenerarDoc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerarDoc.Name = "btnGenerarDoc"
        Me.btnGenerarDoc.Size = New System.Drawing.Size(160, 49)
        Me.btnGenerarDoc.TabIndex = 9
        Me.btnGenerarDoc.Text = "Generar Documentos"
        Me.btnGenerarDoc.UseVisualStyleBackColor = True
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(239, 295)
        Me.lblSalario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(132, 16)
        Me.lblSalario.TabIndex = 8
        Me.lblSalario.Text = "Salario de esa clase"
        '
        'lblClase
        '
        Me.lblClase.AutoSize = True
        Me.lblClase.Location = New System.Drawing.Point(31, 295)
        Me.lblClase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(93, 16)
        Me.lblClase.TabIndex = 4
        Me.lblClase.Text = "Clase Elegida"
        '
        'DGVClases
        '
        Me.DGVClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClases.Location = New System.Drawing.Point(35, 32)
        Me.DGVClases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVClases.Name = "DGVClases"
        Me.DGVClases.Size = New System.Drawing.Size(400, 246)
        Me.DGVClases.TabIndex = 0
        '
        'gboClases
        '
        Me.gboClases.Controls.Add(Me.DGVClases)
        Me.gboClases.Controls.Add(Me.lblClase)
        Me.gboClases.Controls.Add(Me.lblSalario)
        Me.gboClases.Location = New System.Drawing.Point(33, 23)
        Me.gboClases.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboClases.Name = "gboClases"
        Me.gboClases.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboClases.Size = New System.Drawing.Size(467, 332)
        Me.gboClases.TabIndex = 10
        Me.gboClases.TabStop = False
        Me.gboClases.Text = "Clases"
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(31, 295)
        Me.lblHorario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(184, 16)
        Me.lblHorario.TabIndex = 5
        Me.lblHorario.Text = "Horario Elegido de esa clase"
        '
        'DGVHorariosClases
        '
        Me.DGVHorariosClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHorariosClases.Location = New System.Drawing.Point(35, 32)
        Me.DGVHorariosClases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVHorariosClases.Name = "DGVHorariosClases"
        Me.DGVHorariosClases.Size = New System.Drawing.Size(400, 246)
        Me.DGVHorariosClases.TabIndex = 3
        '
        'gboHorariosClases
        '
        Me.gboHorariosClases.Controls.Add(Me.DGVHorariosClases)
        Me.gboHorariosClases.Controls.Add(Me.lblHorario)
        Me.gboHorariosClases.Location = New System.Drawing.Point(548, 23)
        Me.gboHorariosClases.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboHorariosClases.Name = "gboHorariosClases"
        Me.gboHorariosClases.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gboHorariosClases.Size = New System.Drawing.Size(467, 332)
        Me.gboHorariosClases.TabIndex = 11
        Me.gboHorariosClases.TabStop = False
        Me.gboHorariosClases.Text = "Horarios de Clases"
        '
        'frmEstablecerHC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 444)
        Me.Controls.Add(Me.gboHorariosClases)
        Me.Controls.Add(Me.gboClases)
        Me.Controls.Add(Me.btnGenerarDoc)
        Me.Controls.Add(Me.btnIncluirProfEnClase)
        Me.Controls.Add(Me.btnEstablecerHC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEstablecerHC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Establecer Horario de Clase"
        CType(Me.DGVClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboClases.ResumeLayout(False)
        Me.gboClases.PerformLayout()
        CType(Me.DGVHorariosClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboHorariosClases.ResumeLayout(False)
        Me.gboHorariosClases.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEstablecerHC As System.Windows.Forms.Button
    Friend WithEvents btnIncluirProfEnClase As System.Windows.Forms.Button
    Friend WithEvents btnGenerarDoc As System.Windows.Forms.Button
    Friend WithEvents lblSalario As System.Windows.Forms.Label
    Friend WithEvents lblClase As System.Windows.Forms.Label
    Friend WithEvents DGVClases As System.Windows.Forms.DataGridView
    Friend WithEvents gboClases As System.Windows.Forms.GroupBox
    Friend WithEvents lblHorario As System.Windows.Forms.Label
    Friend WithEvents DGVHorariosClases As System.Windows.Forms.DataGridView
    Friend WithEvents gboHorariosClases As System.Windows.Forms.GroupBox
End Class
