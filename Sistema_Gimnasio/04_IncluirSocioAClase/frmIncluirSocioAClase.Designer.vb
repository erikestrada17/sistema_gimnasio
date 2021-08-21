<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncluirSocioAClase
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncluirSocioAClase))
        Me.gboClasesHorarios = New System.Windows.Forms.GroupBox()
        Me.DGVClases = New System.Windows.Forms.DataGridView()
        Me.lblClase = New System.Windows.Forms.Label()
        Me.btnRegistrarSocioEnClase = New System.Windows.Forms.Button()
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNoExiste = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.txtPorDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVHorariosClases = New System.Windows.Forms.DataGridView()
        Me.btnEstablecerHC = New System.Windows.Forms.Button()
        Me.lblHorario = New System.Windows.Forms.Label()
        Me.gboClasesHorarios.SuspendLayout()
        CType(Me.DGVClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVHorariosClases, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboClasesHorarios
        '
        Me.gboClasesHorarios.Controls.Add(Me.DGVHorariosClases)
        Me.gboClasesHorarios.Controls.Add(Me.btnEstablecerHC)
        Me.gboClasesHorarios.Controls.Add(Me.lblHorario)
        Me.gboClasesHorarios.Controls.Add(Me.DGVClases)
        Me.gboClasesHorarios.Controls.Add(Me.lblClase)
        Me.gboClasesHorarios.Location = New System.Drawing.Point(26, 94)
        Me.gboClasesHorarios.Margin = New System.Windows.Forms.Padding(2)
        Me.gboClasesHorarios.Name = "gboClasesHorarios"
        Me.gboClasesHorarios.Padding = New System.Windows.Forms.Padding(2)
        Me.gboClasesHorarios.Size = New System.Drawing.Size(730, 250)
        Me.gboClasesHorarios.TabIndex = 11
        Me.gboClasesHorarios.TabStop = False
        Me.gboClasesHorarios.Text = "Seleccione la Clase y el Horario en el que desea registrarse el socio:"
        '
        'DGVClases
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVClases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVClases.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVClases.Location = New System.Drawing.Point(26, 26)
        Me.DGVClases.Name = "DGVClases"
        Me.DGVClases.Size = New System.Drawing.Size(300, 150)
        Me.DGVClases.TabIndex = 0
        '
        'lblClase
        '
        Me.lblClase.AutoSize = True
        Me.lblClase.Location = New System.Drawing.Point(23, 179)
        Me.lblClase.Name = "lblClase"
        Me.lblClase.Size = New System.Drawing.Size(71, 13)
        Me.lblClase.TabIndex = 4
        Me.lblClase.Text = "Clase Elegida"
        '
        'btnRegistrarSocioEnClase
        '
        Me.btnRegistrarSocioEnClase.Location = New System.Drawing.Point(632, 359)
        Me.btnRegistrarSocioEnClase.Name = "btnRegistrarSocioEnClase"
        Me.btnRegistrarSocioEnClase.Size = New System.Drawing.Size(140, 40)
        Me.btnRegistrarSocioEnClase.TabIndex = 14
        Me.btnRegistrarSocioEnClase.Text = "Registrar Socio en Clase"
        Me.btnRegistrarSocioEnClase.UseVisualStyleBackColor = True
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(12, 359)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(100, 40)
        Me.btnVolverAlMenu.TabIndex = 16
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblNoExiste)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.txtPorDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(250, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 85)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verifique el identificador del Socio..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Resultado:"
        '
        'lblNoExiste
        '
        Me.lblNoExiste.AutoSize = True
        Me.lblNoExiste.Location = New System.Drawing.Point(91, 64)
        Me.lblNoExiste.Name = "lblNoExiste"
        Me.lblNoExiste.Size = New System.Drawing.Size(119, 13)
        Me.lblNoExiste.TabIndex = 16
        Me.lblNoExiste.Text = "resultadoDeVerificacion"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(195, 33)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(75, 23)
        Me.btnVerificar.TabIndex = 15
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'txtPorDNI
        '
        Me.txtPorDNI.Location = New System.Drawing.Point(30, 36)
        Me.txtPorDNI.Name = "txtPorDNI"
        Me.txtPorDNI.Size = New System.Drawing.Size(150, 20)
        Me.txtPorDNI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "por Código de Socio:"
        '
        'DGVHorariosClases
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHorariosClases.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVHorariosClases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVHorariosClases.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVHorariosClases.Location = New System.Drawing.Point(412, 26)
        Me.DGVHorariosClases.Name = "DGVHorariosClases"
        Me.DGVHorariosClases.Size = New System.Drawing.Size(300, 150)
        Me.DGVHorariosClases.TabIndex = 14
        '
        'btnEstablecerHC
        '
        Me.btnEstablecerHC.Location = New System.Drawing.Point(264, 210)
        Me.btnEstablecerHC.Name = "btnEstablecerHC"
        Me.btnEstablecerHC.Size = New System.Drawing.Size(200, 40)
        Me.btnEstablecerHC.TabIndex = 16
        Me.btnEstablecerHC.Text = "Establecer Horario y Clase elegidos"
        Me.btnEstablecerHC.UseVisualStyleBackColor = True
        '
        'lblHorario
        '
        Me.lblHorario.AutoSize = True
        Me.lblHorario.Location = New System.Drawing.Point(409, 179)
        Me.lblHorario.Name = "lblHorario"
        Me.lblHorario.Size = New System.Drawing.Size(142, 13)
        Me.lblHorario.TabIndex = 15
        Me.lblHorario.Text = "Horario Elegido de esa clase"
        '
        'frmIncluirSocioAClase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.btnRegistrarSocioEnClase)
        Me.Controls.Add(Me.gboClasesHorarios)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIncluirSocioAClase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Incluir Socio a Clase"
        Me.gboClasesHorarios.ResumeLayout(False)
        Me.gboClasesHorarios.PerformLayout()
        CType(Me.DGVClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVHorariosClases, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboClasesHorarios As System.Windows.Forms.GroupBox
    Friend WithEvents DGVClases As System.Windows.Forms.DataGridView
    Friend WithEvents lblClase As System.Windows.Forms.Label
    Friend WithEvents btnRegistrarSocioEnClase As System.Windows.Forms.Button
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNoExiste As System.Windows.Forms.Label
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents txtPorDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGVHorariosClases As System.Windows.Forms.DataGridView
    Friend WithEvents btnEstablecerHC As System.Windows.Forms.Button
    Friend WithEvents lblHorario As System.Windows.Forms.Label
End Class
