<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMantenimiento))
        Me.gboClasesHorarios = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVMantenimiento = New System.Windows.Forms.DataGridView()
        Me.DGVEquipos = New System.Windows.Forms.DataGridView()
        Me.btnRegistrarCambios = New System.Windows.Forms.Button()
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.btnEmitirPlanilla = New System.Windows.Forms.Button()
        Me.gboClasesHorarios.SuspendLayout()
        CType(Me.DGVMantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboClasesHorarios
        '
        Me.gboClasesHorarios.Controls.Add(Me.Label2)
        Me.gboClasesHorarios.Controls.Add(Me.Label1)
        Me.gboClasesHorarios.Controls.Add(Me.DGVMantenimiento)
        Me.gboClasesHorarios.Controls.Add(Me.DGVEquipos)
        Me.gboClasesHorarios.Location = New System.Drawing.Point(36, 25)
        Me.gboClasesHorarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboClasesHorarios.Name = "gboClasesHorarios"
        Me.gboClasesHorarios.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gboClasesHorarios.Size = New System.Drawing.Size(973, 345)
        Me.gboClasesHorarios.TabIndex = 12
        Me.gboClasesHorarios.TabStop = False
        Me.gboClasesHorarios.Text = "Puede editar el Estado del Equipo y las Observaciones del Mantenimiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(539, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Mantenimiento del equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Equipos"
        '
        'DGVMantenimiento
        '
        Me.DGVMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMantenimiento.Location = New System.Drawing.Point(543, 71)
        Me.DGVMantenimiento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVMantenimiento.Name = "DGVMantenimiento"
        Me.DGVMantenimiento.Size = New System.Drawing.Size(400, 255)
        Me.DGVMantenimiento.TabIndex = 14
        '
        'DGVEquipos
        '
        Me.DGVEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEquipos.Location = New System.Drawing.Point(33, 71)
        Me.DGVEquipos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVEquipos.Name = "DGVEquipos"
        Me.DGVEquipos.Size = New System.Drawing.Size(400, 255)
        Me.DGVEquipos.TabIndex = 0
        '
        'btnRegistrarCambios
        '
        Me.btnRegistrarCambios.Location = New System.Drawing.Point(432, 380)
        Me.btnRegistrarCambios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistrarCambios.Name = "btnRegistrarCambios"
        Me.btnRegistrarCambios.Size = New System.Drawing.Size(187, 49)
        Me.btnRegistrarCambios.TabIndex = 16
        Me.btnRegistrarCambios.Text = "Registrar Cambios"
        Me.btnRegistrarCambios.UseVisualStyleBackColor = True
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(16, 380)
        Me.btnVolverAlMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(133, 49)
        Me.btnVolverAlMenu.TabIndex = 13
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'btnEmitirPlanilla
        '
        Me.btnEmitirPlanilla.Location = New System.Drawing.Point(843, 380)
        Me.btnEmitirPlanilla.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmitirPlanilla.Name = "btnEmitirPlanilla"
        Me.btnEmitirPlanilla.Size = New System.Drawing.Size(187, 49)
        Me.btnEmitirPlanilla.TabIndex = 17
        Me.btnEmitirPlanilla.Text = "Emitir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Planilla de Mantenimiento"
        Me.btnEmitirPlanilla.UseVisualStyleBackColor = True
        '
        'frmMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 444)
        Me.Controls.Add(Me.btnEmitirPlanilla)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.btnRegistrarCambios)
        Me.Controls.Add(Me.gboClasesHorarios)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMantenimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Máquinas"
        Me.gboClasesHorarios.ResumeLayout(False)
        Me.gboClasesHorarios.PerformLayout()
        CType(Me.DGVMantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gboClasesHorarios As System.Windows.Forms.GroupBox
    Friend WithEvents DGVMantenimiento As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegistrarCambios As System.Windows.Forms.Button
    Friend WithEvents DGVEquipos As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEmitirPlanilla As System.Windows.Forms.Button
End Class
