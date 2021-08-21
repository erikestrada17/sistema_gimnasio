<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoLiquidacion))
        Me.lblNombreLiq = New System.Windows.Forms.Label()
        Me.lblApellidoLiq = New System.Windows.Forms.Label()
        Me.lblSalarioLiq = New System.Windows.Forms.Label()
        Me.dgvClasesLiq = New System.Windows.Forms.DataGridView()
        Me.btnCancelarTodoLiq = New System.Windows.Forms.Button()
        Me.btnCancelarLiq = New System.Windows.Forms.Button()
        Me.btnReciboLiq = New System.Windows.Forms.Button()
        Me.lblLiq1 = New System.Windows.Forms.Label()
        Me.cboMesLiq = New System.Windows.Forms.ComboBox()
        Me.cboAnioLiq = New System.Windows.Forms.ComboBox()
        Me.gpbDatosLiq = New System.Windows.Forms.GroupBox()
        Me.lblSalTot = New System.Windows.Forms.Label()
        Me.lblAsistenciaLiq = New System.Windows.Forms.Label()
        Me.gpbClasesLiq = New System.Windows.Forms.GroupBox()
        CType(Me.dgvClasesLiq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDatosLiq.SuspendLayout()
        Me.gpbClasesLiq.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombreLiq
        '
        Me.lblNombreLiq.AutoSize = True
        Me.lblNombreLiq.Location = New System.Drawing.Point(9, 39)
        Me.lblNombreLiq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreLiq.Name = "lblNombreLiq"
        Me.lblNombreLiq.Size = New System.Drawing.Size(63, 16)
        Me.lblNombreLiq.TabIndex = 0
        Me.lblNombreLiq.Text = "Nombre: "
        '
        'lblApellidoLiq
        '
        Me.lblApellidoLiq.AutoSize = True
        Me.lblApellidoLiq.Location = New System.Drawing.Point(9, 76)
        Me.lblApellidoLiq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellidoLiq.Name = "lblApellidoLiq"
        Me.lblApellidoLiq.Size = New System.Drawing.Size(64, 16)
        Me.lblApellidoLiq.TabIndex = 1
        Me.lblApellidoLiq.Text = "Apellido: "
        '
        'lblSalarioLiq
        '
        Me.lblSalarioLiq.AutoSize = True
        Me.lblSalarioLiq.Location = New System.Drawing.Point(9, 167)
        Me.lblSalarioLiq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalarioLiq.Name = "lblSalarioLiq"
        Me.lblSalarioLiq.Size = New System.Drawing.Size(91, 16)
        Me.lblSalarioLiq.TabIndex = 3
        Me.lblSalarioLiq.Text = "Salario Total: "
        '
        'dgvClasesLiq
        '
        Me.dgvClasesLiq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClasesLiq.Location = New System.Drawing.Point(11, 23)
        Me.dgvClasesLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvClasesLiq.Name = "dgvClasesLiq"
        Me.dgvClasesLiq.Size = New System.Drawing.Size(528, 185)
        Me.dgvClasesLiq.TabIndex = 4
        '
        'btnCancelarTodoLiq
        '
        Me.btnCancelarTodoLiq.Location = New System.Drawing.Point(412, 319)
        Me.btnCancelarTodoLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelarTodoLiq.Name = "btnCancelarTodoLiq"
        Me.btnCancelarTodoLiq.Size = New System.Drawing.Size(141, 28)
        Me.btnCancelarTodoLiq.TabIndex = 5
        Me.btnCancelarTodoLiq.Text = "Cancelar todo"
        Me.btnCancelarTodoLiq.UseVisualStyleBackColor = True
        '
        'btnCancelarLiq
        '
        Me.btnCancelarLiq.Location = New System.Drawing.Point(561, 319)
        Me.btnCancelarLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancelarLiq.Name = "btnCancelarLiq"
        Me.btnCancelarLiq.Size = New System.Drawing.Size(141, 28)
        Me.btnCancelarLiq.TabIndex = 6
        Me.btnCancelarLiq.Text = "Cancelar"
        Me.btnCancelarLiq.UseVisualStyleBackColor = True
        '
        'btnReciboLiq
        '
        Me.btnReciboLiq.Location = New System.Drawing.Point(711, 319)
        Me.btnReciboLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReciboLiq.Name = "btnReciboLiq"
        Me.btnReciboLiq.Size = New System.Drawing.Size(141, 28)
        Me.btnReciboLiq.TabIndex = 7
        Me.btnReciboLiq.Text = "Generar recibo"
        Me.btnReciboLiq.UseVisualStyleBackColor = True
        '
        'lblLiq1
        '
        Me.lblLiq1.AutoSize = True
        Me.lblLiq1.Location = New System.Drawing.Point(8, 230)
        Me.lblLiq1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLiq1.Name = "lblLiq1"
        Me.lblLiq1.Size = New System.Drawing.Size(185, 16)
        Me.lblLiq1.TabIndex = 9
        Me.lblLiq1.Text = "Corresponde al año y mes de"
        '
        'cboMesLiq
        '
        Me.cboMesLiq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMesLiq.Enabled = False
        Me.cboMesLiq.FormattingEnabled = True
        Me.cboMesLiq.Location = New System.Drawing.Point(295, 226)
        Me.cboMesLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.cboMesLiq.Name = "cboMesLiq"
        Me.cboMesLiq.Size = New System.Drawing.Size(115, 24)
        Me.cboMesLiq.TabIndex = 10
        '
        'cboAnioLiq
        '
        Me.cboAnioLiq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnioLiq.FormattingEnabled = True
        Me.cboAnioLiq.Location = New System.Drawing.Point(208, 226)
        Me.cboAnioLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAnioLiq.Name = "cboAnioLiq"
        Me.cboAnioLiq.Size = New System.Drawing.Size(77, 24)
        Me.cboAnioLiq.TabIndex = 11
        '
        'gpbDatosLiq
        '
        Me.gpbDatosLiq.Controls.Add(Me.lblSalTot)
        Me.gpbDatosLiq.Controls.Add(Me.lblNombreLiq)
        Me.gpbDatosLiq.Controls.Add(Me.lblApellidoLiq)
        Me.gpbDatosLiq.Controls.Add(Me.lblAsistenciaLiq)
        Me.gpbDatosLiq.Controls.Add(Me.lblSalarioLiq)
        Me.gpbDatosLiq.Location = New System.Drawing.Point(7, 5)
        Me.gpbDatosLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbDatosLiq.Name = "gpbDatosLiq"
        Me.gpbDatosLiq.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbDatosLiq.Size = New System.Drawing.Size(267, 273)
        Me.gpbDatosLiq.TabIndex = 12
        Me.gpbDatosLiq.TabStop = False
        Me.gpbDatosLiq.Text = "Datos del Profesor"
        '
        'lblSalTot
        '
        Me.lblSalTot.AutoSize = True
        Me.lblSalTot.Location = New System.Drawing.Point(108, 167)
        Me.lblSalTot.Name = "lblSalTot"
        Me.lblSalTot.Size = New System.Drawing.Size(0, 16)
        Me.lblSalTot.TabIndex = 4
        '
        'lblAsistenciaLiq
        '
        Me.lblAsistenciaLiq.AutoSize = True
        Me.lblAsistenciaLiq.Location = New System.Drawing.Point(9, 123)
        Me.lblAsistenciaLiq.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAsistenciaLiq.Name = "lblAsistenciaLiq"
        Me.lblAsistenciaLiq.Size = New System.Drawing.Size(196, 16)
        Me.lblAsistenciaLiq.TabIndex = 2
        Me.lblAsistenciaLiq.Text = "Bono adicional por Asistencias:"
        '
        'gpbClasesLiq
        '
        Me.gpbClasesLiq.Controls.Add(Me.dgvClasesLiq)
        Me.gpbClasesLiq.Controls.Add(Me.cboAnioLiq)
        Me.gpbClasesLiq.Controls.Add(Me.lblLiq1)
        Me.gpbClasesLiq.Controls.Add(Me.cboMesLiq)
        Me.gpbClasesLiq.Location = New System.Drawing.Point(305, 5)
        Me.gpbClasesLiq.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbClasesLiq.Name = "gpbClasesLiq"
        Me.gpbClasesLiq.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbClasesLiq.Size = New System.Drawing.Size(547, 273)
        Me.gpbClasesLiq.TabIndex = 13
        Me.gpbClasesLiq.TabStop = False
        Me.gpbClasesLiq.Text = "Información de Clases"
        '
        'frmInfoLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 362)
        Me.Controls.Add(Me.gpbClasesLiq)
        Me.Controls.Add(Me.gpbDatosLiq)
        Me.Controls.Add(Me.btnReciboLiq)
        Me.Controls.Add(Me.btnCancelarLiq)
        Me.Controls.Add(Me.btnCancelarTodoLiq)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmInfoLiquidacion"
        Me.Text = "INFORMACION DE PROFESOR"
        CType(Me.dgvClasesLiq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDatosLiq.ResumeLayout(False)
        Me.gpbDatosLiq.PerformLayout()
        Me.gpbClasesLiq.ResumeLayout(False)
        Me.gpbClasesLiq.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblSalarioLiq As System.Windows.Forms.Label
    Friend WithEvents dgvClasesLiq As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancelarTodoLiq As System.Windows.Forms.Button
    Friend WithEvents btnCancelarLiq As System.Windows.Forms.Button
    Friend WithEvents btnReciboLiq As System.Windows.Forms.Button
    Friend WithEvents lblLiq1 As System.Windows.Forms.Label
    Friend WithEvents cboMesLiq As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnioLiq As System.Windows.Forms.ComboBox
    Friend WithEvents gpbDatosLiq As System.Windows.Forms.GroupBox
    Friend WithEvents gpbClasesLiq As System.Windows.Forms.GroupBox
    Public WithEvents lblNombreLiq As System.Windows.Forms.Label
    Public WithEvents lblApellidoLiq As System.Windows.Forms.Label
    Friend WithEvents lblAsistenciaLiq As System.Windows.Forms.Label
    Friend WithEvents lblSalTot As System.Windows.Forms.Label
End Class
