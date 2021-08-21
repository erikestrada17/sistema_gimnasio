<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfoPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfoPago))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.lblLocalidad = New System.Windows.Forms.Label()
        Me.lblCp = New System.Windows.Forms.Label()
        Me.lblPago = New System.Windows.Forms.Label()
        Me.lblAcceso = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.gpbSocio = New System.Windows.Forms.GroupBox()
        Me.gpbPago = New System.Windows.Forms.GroupBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.gpbSocio.SuspendLayout()
        Me.gpbPago.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(8, 33)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(63, 16)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre: "
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(8, 60)
        Me.lblApellido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(64, 16)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido: "
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Location = New System.Drawing.Point(8, 89)
        Me.lblDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(37, 16)
        Me.lblDni.TabIndex = 2
        Me.lblDni.Text = "DNI: "
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New System.Drawing.Point(8, 117)
        Me.lblDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(71, 16)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección: "
        '
        'lblLocalidad
        '
        Me.lblLocalidad.AutoSize = True
        Me.lblLocalidad.Location = New System.Drawing.Point(8, 144)
        Me.lblLocalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocalidad.Name = "lblLocalidad"
        Me.lblLocalidad.Size = New System.Drawing.Size(74, 16)
        Me.lblLocalidad.TabIndex = 4
        Me.lblLocalidad.Text = "Localidad: "
        '
        'lblCp
        '
        Me.lblCp.AutoSize = True
        Me.lblCp.Location = New System.Drawing.Point(8, 174)
        Me.lblCp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCp.Name = "lblCp"
        Me.lblCp.Size = New System.Drawing.Size(32, 16)
        Me.lblCp.TabIndex = 5
        Me.lblCp.Text = "CP: "
        '
        'lblPago
        '
        Me.lblPago.AutoSize = True
        Me.lblPago.Location = New System.Drawing.Point(24, 49)
        Me.lblPago.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPago.Name = "lblPago"
        Me.lblPago.Size = New System.Drawing.Size(88, 16)
        Me.lblPago.TabIndex = 6
        Me.lblPago.Text = "Ultimo Pago: "
        '
        'lblAcceso
        '
        Me.lblAcceso.AutoSize = True
        Me.lblAcceso.Location = New System.Drawing.Point(24, 117)
        Me.lblAcceso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAcceso.Name = "lblAcceso"
        Me.lblAcceso.Size = New System.Drawing.Size(57, 16)
        Me.lblAcceso.TabIndex = 7
        Me.lblAcceso.Text = "Acceso:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(115, 117)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(64, 16)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "<estado>"
        '
        'gpbSocio
        '
        Me.gpbSocio.Controls.Add(Me.lblNombre)
        Me.gpbSocio.Controls.Add(Me.lblApellido)
        Me.gpbSocio.Controls.Add(Me.lblDni)
        Me.gpbSocio.Controls.Add(Me.lblDireccion)
        Me.gpbSocio.Controls.Add(Me.lblCp)
        Me.gpbSocio.Controls.Add(Me.lblLocalidad)
        Me.gpbSocio.Location = New System.Drawing.Point(16, 15)
        Me.gpbSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbSocio.Name = "gpbSocio"
        Me.gpbSocio.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbSocio.Size = New System.Drawing.Size(347, 206)
        Me.gpbSocio.TabIndex = 9
        Me.gpbSocio.TabStop = False
        Me.gpbSocio.Text = "Info. Personal"
        '
        'gpbPago
        '
        Me.gpbPago.Controls.Add(Me.lblPago)
        Me.gpbPago.Controls.Add(Me.lblAcceso)
        Me.gpbPago.Controls.Add(Me.lblEstado)
        Me.gpbPago.Location = New System.Drawing.Point(391, 15)
        Me.gpbPago.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbPago.Name = "gpbPago"
        Me.gpbPago.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbPago.Size = New System.Drawing.Size(347, 206)
        Me.gpbPago.TabIndex = 10
        Me.gpbPago.TabStop = False
        Me.gpbPago.Text = "Info. Pago"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(620, 249)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(117, 28)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmInfoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 292)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.gpbPago)
        Me.Controls.Add(Me.gpbSocio)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmInfoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInfoPago"
        Me.gpbSocio.ResumeLayout(False)
        Me.gpbSocio.PerformLayout()
        Me.gpbPago.ResumeLayout(False)
        Me.gpbPago.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblApellido As System.Windows.Forms.Label
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblDireccion As System.Windows.Forms.Label
    Friend WithEvents lblLocalidad As System.Windows.Forms.Label
    Friend WithEvents lblCp As System.Windows.Forms.Label
    Friend WithEvents lblPago As System.Windows.Forms.Label
    Friend WithEvents lblAcceso As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents gpbSocio As System.Windows.Forms.GroupBox
    Friend WithEvents gpbPago As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
