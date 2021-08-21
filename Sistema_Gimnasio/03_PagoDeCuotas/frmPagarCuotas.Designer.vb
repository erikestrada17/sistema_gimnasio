<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagarCuotas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagarCuotas))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPrecios = New System.Windows.Forms.ComboBox()
        Me.btnRegistrarPago = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnVolverAlMenu = New System.Windows.Forms.Button()
        Me.btnAñadirCA = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCostoMatricula = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblFechaUltimoPago = New System.Windows.Forms.Label()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtPorDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEmitirCompPago = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cboPrecios)
        Me.GroupBox2.Controls.Add(Me.btnRegistrarPago)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.txtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblMonto)
        Me.GroupBox2.Location = New System.Drawing.Point(475, 27)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(400, 338)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Complete los datos de pago"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Monto:"
        '
        'cboPrecios
        '
        Me.cboPrecios.FormattingEnabled = True
        Me.cboPrecios.Location = New System.Drawing.Point(84, 23)
        Me.cboPrecios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboPrecios.Name = "cboPrecios"
        Me.cboPrecios.Size = New System.Drawing.Size(239, 24)
        Me.cboPrecios.TabIndex = 22
        Me.cboPrecios.Text = "Seleccione uno de los precios"
        '
        'btnRegistrarPago
        '
        Me.btnRegistrarPago.Location = New System.Drawing.Point(136, 289)
        Me.btnRegistrarPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRegistrarPago.Name = "btnRegistrarPago"
        Me.btnRegistrarPago.Size = New System.Drawing.Size(133, 49)
        Me.btnRegistrarPago.TabIndex = 20
        Me.btnRegistrarPago.Text = "Registrar Pago"
        Me.btnRegistrarPago.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(175, 101)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(132, 22)
        Me.dtpFecha.TabIndex = 19
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(84, 167)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(239, 98)
        Me.txtDescripcion.TabIndex = 18
        Me.txtDescripcion.Text = "Con costo adicional (se borra msg si no hay)."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(80, 149)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Descripción:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Fecha:"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(175, 64)
        Me.lblMonto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(131, 16)
        Me.lblMonto.TabIndex = 15
        Me.lblMonto.Text = "precio seleccionado"
        '
        'btnVolverAlMenu
        '
        Me.btnVolverAlMenu.Location = New System.Drawing.Point(16, 380)
        Me.btnVolverAlMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVolverAlMenu.Name = "btnVolverAlMenu"
        Me.btnVolverAlMenu.Size = New System.Drawing.Size(133, 49)
        Me.btnVolverAlMenu.TabIndex = 17
        Me.btnVolverAlMenu.Text = "Volver al Menú"
        Me.btnVolverAlMenu.UseVisualStyleBackColor = True
        '
        'btnAñadirCA
        '
        Me.btnAñadirCA.Location = New System.Drawing.Point(101, 289)
        Me.btnAñadirCA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAñadirCA.Name = "btnAñadirCA"
        Me.btnAñadirCA.Size = New System.Drawing.Size(200, 49)
        Me.btnAñadirCA.TabIndex = 19
        Me.btnAñadirCA.Text = "Añadir Costo Adicional"
        Me.btnAñadirCA.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCostoMatricula)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblFechaUltimoPago)
        Me.GroupBox1.Controls.Add(Me.btnAñadirCA)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.txtPorDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(400, 338)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Verifique el último pago..."
        '
        'lblCostoMatricula
        '
        Me.lblCostoMatricula.AutoSize = True
        Me.lblCostoMatricula.Location = New System.Drawing.Point(115, 245)
        Me.lblCostoMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostoMatricula.Name = "lblCostoMatricula"
        Me.lblCostoMatricula.Size = New System.Drawing.Size(231, 16)
        Me.lblCostoMatricula.TabIndex = 26
        Me.lblCostoMatricula.Text = "costoMatricula(cero si no hay retraso)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 223)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Adicional:"
        '
        'lblFechaUltimoPago
        '
        Me.lblFechaUltimoPago.AutoSize = True
        Me.lblFechaUltimoPago.Location = New System.Drawing.Point(115, 223)
        Me.lblFechaUltimoPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaUltimoPago.Name = "lblFechaUltimoPago"
        Me.lblFechaUltimoPago.Size = New System.Drawing.Size(112, 16)
        Me.lblFechaUltimoPago.TabIndex = 23
        Me.lblFechaUltimoPago.Text = "fechaUltimoPago"
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(260, 52)
        Me.btnVerificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(100, 28)
        Me.btnVerificar.TabIndex = 15
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 87)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(317, 123)
        Me.DataGridView1.TabIndex = 14
        '
        'txtPorDNI
        '
        Me.txtPorDNI.Location = New System.Drawing.Point(40, 55)
        Me.txtPorDNI.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPorDNI.Name = "txtPorDNI"
        Me.txtPorDNI.Size = New System.Drawing.Size(199, 22)
        Me.txtPorDNI.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "por Código de Socio:"
        '
        'btnEmitirCompPago
        '
        Me.btnEmitirCompPago.Enabled = False
        Me.btnEmitirCompPago.Location = New System.Drawing.Point(709, 380)
        Me.btnEmitirCompPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEmitirCompPago.Name = "btnEmitirCompPago"
        Me.btnEmitirCompPago.Size = New System.Drawing.Size(187, 49)
        Me.btnEmitirCompPago.TabIndex = 21
        Me.btnEmitirCompPago.Text = "Emitir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comprobante de Pago"
        Me.btnEmitirCompPago.UseVisualStyleBackColor = True
        '
        'frmPagarCuotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 444)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEmitirCompPago)
        Me.Controls.Add(Me.btnVolverAlMenu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPagarCuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Cuotas del Socio"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVolverAlMenu As System.Windows.Forms.Button
    Friend WithEvents btnAñadirCA As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtPorDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblCostoMatricula As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFechaUltimoPago As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPrecios As System.Windows.Forms.ComboBox
    Friend WithEvents btnRegistrarPago As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents btnEmitirCompPago As System.Windows.Forms.Button
End Class
