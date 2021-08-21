<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLiquidacionProf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLiquidacionProf))
        Me.lblLiquidacion1 = New System.Windows.Forms.Label()
        Me.dgvProfesoresLiq = New System.Windows.Forms.DataGridView()
        Me.btnAgregarLiq = New System.Windows.Forms.Button()
        Me.btnQuitarLiq = New System.Windows.Forms.Button()
        Me.lstLiq = New System.Windows.Forms.ListBox()
        Me.btnAtrasLiq = New System.Windows.Forms.Button()
        Me.btnCalcularLiq = New System.Windows.Forms.Button()
        CType(Me.dgvProfesoresLiq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLiquidacion1
        '
        Me.lblLiquidacion1.AutoSize = True
        Me.lblLiquidacion1.Location = New System.Drawing.Point(12, 11)
        Me.lblLiquidacion1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLiquidacion1.Name = "lblLiquidacion1"
        Me.lblLiquidacion1.Size = New System.Drawing.Size(350, 16)
        Me.lblLiquidacion1.TabIndex = 1
        Me.lblLiquidacion1.Text = "Seleccione los profesores cuyos sueldos desea calcular:"
        '
        'dgvProfesoresLiq
        '
        Me.dgvProfesoresLiq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProfesoresLiq.Location = New System.Drawing.Point(16, 42)
        Me.dgvProfesoresLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvProfesoresLiq.Name = "dgvProfesoresLiq"
        Me.dgvProfesoresLiq.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvProfesoresLiq.Size = New System.Drawing.Size(588, 185)
        Me.dgvProfesoresLiq.TabIndex = 2
        '
        'btnAgregarLiq
        '
        Me.btnAgregarLiq.Location = New System.Drawing.Point(612, 90)
        Me.btnAgregarLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarLiq.Name = "btnAgregarLiq"
        Me.btnAgregarLiq.Size = New System.Drawing.Size(49, 28)
        Me.btnAgregarLiq.TabIndex = 3
        Me.btnAgregarLiq.Text = ">>"
        Me.btnAgregarLiq.UseVisualStyleBackColor = True
        '
        'btnQuitarLiq
        '
        Me.btnQuitarLiq.Location = New System.Drawing.Point(612, 151)
        Me.btnQuitarLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnQuitarLiq.Name = "btnQuitarLiq"
        Me.btnQuitarLiq.Size = New System.Drawing.Size(49, 28)
        Me.btnQuitarLiq.TabIndex = 4
        Me.btnQuitarLiq.Text = "<<"
        Me.btnQuitarLiq.UseVisualStyleBackColor = True
        '
        'lstLiq
        '
        Me.lstLiq.FormattingEnabled = True
        Me.lstLiq.ItemHeight = 16
        Me.lstLiq.Location = New System.Drawing.Point(669, 46)
        Me.lstLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstLiq.Name = "lstLiq"
        Me.lstLiq.Size = New System.Drawing.Size(169, 180)
        Me.lstLiq.TabIndex = 5
        '
        'btnAtrasLiq
        '
        Me.btnAtrasLiq.Location = New System.Drawing.Point(619, 246)
        Me.btnAtrasLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAtrasLiq.Name = "btnAtrasLiq"
        Me.btnAtrasLiq.Size = New System.Drawing.Size(81, 28)
        Me.btnAtrasLiq.TabIndex = 6
        Me.btnAtrasLiq.Text = "Atras"
        Me.btnAtrasLiq.UseVisualStyleBackColor = True
        '
        'btnCalcularLiq
        '
        Me.btnCalcularLiq.Location = New System.Drawing.Point(708, 246)
        Me.btnCalcularLiq.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCalcularLiq.Name = "btnCalcularLiq"
        Me.btnCalcularLiq.Size = New System.Drawing.Size(132, 28)
        Me.btnCalcularLiq.TabIndex = 7
        Me.btnCalcularLiq.Text = "Calcular Salarios"
        Me.btnCalcularLiq.UseVisualStyleBackColor = True
        '
        'frmLiquidacionProf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 289)
        Me.Controls.Add(Me.btnCalcularLiq)
        Me.Controls.Add(Me.btnAtrasLiq)
        Me.Controls.Add(Me.btnQuitarLiq)
        Me.Controls.Add(Me.btnAgregarLiq)
        Me.Controls.Add(Me.dgvProfesoresLiq)
        Me.Controls.Add(Me.lblLiquidacion1)
        Me.Controls.Add(Me.lstLiq)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLiquidacionProf"
        Me.Text = "LIQUIDACION DE SALARIOS"
        CType(Me.dgvProfesoresLiq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblLiquidacion1 As System.Windows.Forms.Label
    Friend WithEvents btnAgregarLiq As System.Windows.Forms.Button
    Friend WithEvents btnQuitarLiq As System.Windows.Forms.Button
    Friend WithEvents btnAtrasLiq As System.Windows.Forms.Button
    Friend WithEvents btnCalcularLiq As System.Windows.Forms.Button
    Public WithEvents dgvProfesoresLiq As System.Windows.Forms.DataGridView
    Public WithEvents lstLiq As System.Windows.Forms.ListBox

End Class
