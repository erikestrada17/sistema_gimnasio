<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesoSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccesoSocio))
        Me.lblAccesoSocio1 = New System.Windows.Forms.Label()
        Me.txtSocio = New System.Windows.Forms.TextBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAccesoSocio1
        '
        Me.lblAccesoSocio1.AutoSize = True
        Me.lblAccesoSocio1.Location = New System.Drawing.Point(16, 34)
        Me.lblAccesoSocio1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccesoSocio1.Name = "lblAccesoSocio1"
        Me.lblAccesoSocio1.Size = New System.Drawing.Size(116, 16)
        Me.lblAccesoSocio1.TabIndex = 0
        Me.lblAccesoSocio1.Text = "Numero de Socio:"
        '
        'txtSocio
        '
        Me.txtSocio.Location = New System.Drawing.Point(147, 31)
        Me.txtSocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSocio.Name = "txtSocio"
        Me.txtSocio.Size = New System.Drawing.Size(132, 22)
        Me.txtSocio.TabIndex = 1
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(180, 82)
        Me.btnVerificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(100, 28)
        Me.btnVerificar.TabIndex = 2
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'frmAccesoSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 126)
        Me.Controls.Add(Me.btnVerificar)
        Me.Controls.Add(Me.txtSocio)
        Me.Controls.Add(Me.lblAccesoSocio1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmAccesoSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAccesoSocio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAccesoSocio1 As System.Windows.Forms.Label
    Friend WithEvents txtSocio As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
End Class
