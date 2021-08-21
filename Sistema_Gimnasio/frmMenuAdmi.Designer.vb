<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuAdmi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuAdmi))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnDefinirNuevoPrecio = New System.Windows.Forms.Button()
        Me.btnInscribirNuevoUsuario = New System.Windows.Forms.Button()
        Me.btnCrearNuevaClase = New System.Windows.Forms.Button()
        Me.btnInscribirNuevoProf = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnEliminarUsuario = New System.Windows.Forms.Button()
        Me.btnEliminarClase = New System.Windows.Forms.Button()
        Me.btnEliminarPrecio = New System.Windows.Forms.Button()
        Me.btnEliminarProf = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnActualizarUsuario = New System.Windows.Forms.Button()
        Me.btnActualizarClase = New System.Windows.Forms.Button()
        Me.btnActualizarPrecio = New System.Windows.Forms.Button()
        Me.btnActualizarProf = New System.Windows.Forms.Button()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnLiquidacionSueldo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(467, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ABM"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(29, 34)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(413, 185)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnDefinirNuevoPrecio)
        Me.TabPage1.Controls.Add(Me.btnInscribirNuevoUsuario)
        Me.TabPage1.Controls.Add(Me.btnCrearNuevaClase)
        Me.TabPage1.Controls.Add(Me.btnInscribirNuevoProf)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage1.Size = New System.Drawing.Size(405, 153)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "AGREGAR"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnDefinirNuevoPrecio
        '
        Me.btnDefinirNuevoPrecio.Location = New System.Drawing.Point(8, 76)
        Me.btnDefinirNuevoPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDefinirNuevoPrecio.Name = "btnDefinirNuevoPrecio"
        Me.btnDefinirNuevoPrecio.Size = New System.Drawing.Size(187, 49)
        Me.btnDefinirNuevoPrecio.TabIndex = 6
        Me.btnDefinirNuevoPrecio.Text = "Definir nuevo precio"
        Me.btnDefinirNuevoPrecio.UseVisualStyleBackColor = True
        '
        'btnInscribirNuevoUsuario
        '
        Me.btnInscribirNuevoUsuario.Location = New System.Drawing.Point(208, 76)
        Me.btnInscribirNuevoUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInscribirNuevoUsuario.Name = "btnInscribirNuevoUsuario"
        Me.btnInscribirNuevoUsuario.Size = New System.Drawing.Size(187, 49)
        Me.btnInscribirNuevoUsuario.TabIndex = 7
        Me.btnInscribirNuevoUsuario.Text = "Inscribir nuevo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario/Recepcionista"
        Me.btnInscribirNuevoUsuario.UseVisualStyleBackColor = True
        '
        'btnCrearNuevaClase
        '
        Me.btnCrearNuevaClase.Location = New System.Drawing.Point(208, 15)
        Me.btnCrearNuevaClase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCrearNuevaClase.Name = "btnCrearNuevaClase"
        Me.btnCrearNuevaClase.Size = New System.Drawing.Size(187, 49)
        Me.btnCrearNuevaClase.TabIndex = 6
        Me.btnCrearNuevaClase.Text = "Crear nueva clase"
        Me.btnCrearNuevaClase.UseVisualStyleBackColor = True
        '
        'btnInscribirNuevoProf
        '
        Me.btnInscribirNuevoProf.Location = New System.Drawing.Point(8, 15)
        Me.btnInscribirNuevoProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnInscribirNuevoProf.Name = "btnInscribirNuevoProf"
        Me.btnInscribirNuevoProf.Size = New System.Drawing.Size(187, 49)
        Me.btnInscribirNuevoProf.TabIndex = 5
        Me.btnInscribirNuevoProf.Text = "Inscribir nuevo profesor"
        Me.btnInscribirNuevoProf.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnEliminarUsuario)
        Me.TabPage2.Controls.Add(Me.btnEliminarClase)
        Me.TabPage2.Controls.Add(Me.btnEliminarPrecio)
        Me.TabPage2.Controls.Add(Me.btnEliminarProf)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage2.Size = New System.Drawing.Size(405, 156)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BORRAR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnEliminarUsuario
        '
        Me.btnEliminarUsuario.Location = New System.Drawing.Point(208, 79)
        Me.btnEliminarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarUsuario.Name = "btnEliminarUsuario"
        Me.btnEliminarUsuario.Size = New System.Drawing.Size(187, 49)
        Me.btnEliminarUsuario.TabIndex = 11
        Me.btnEliminarUsuario.Text = "Eliminar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario/Recepcionista"
        Me.btnEliminarUsuario.UseVisualStyleBackColor = True
        '
        'btnEliminarClase
        '
        Me.btnEliminarClase.Location = New System.Drawing.Point(208, 17)
        Me.btnEliminarClase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarClase.Name = "btnEliminarClase"
        Me.btnEliminarClase.Size = New System.Drawing.Size(187, 49)
        Me.btnEliminarClase.TabIndex = 10
        Me.btnEliminarClase.Text = "Eliminar una clase"
        Me.btnEliminarClase.UseVisualStyleBackColor = True
        '
        'btnEliminarPrecio
        '
        Me.btnEliminarPrecio.Location = New System.Drawing.Point(8, 79)
        Me.btnEliminarPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarPrecio.Name = "btnEliminarPrecio"
        Me.btnEliminarPrecio.Size = New System.Drawing.Size(187, 49)
        Me.btnEliminarPrecio.TabIndex = 9
        Me.btnEliminarPrecio.Text = "Eliminar un precio"
        Me.btnEliminarPrecio.UseVisualStyleBackColor = True
        '
        'btnEliminarProf
        '
        Me.btnEliminarProf.Location = New System.Drawing.Point(8, 17)
        Me.btnEliminarProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminarProf.Name = "btnEliminarProf"
        Me.btnEliminarProf.Size = New System.Drawing.Size(187, 49)
        Me.btnEliminarProf.TabIndex = 8
        Me.btnEliminarProf.Text = "Eliminar un profesor"
        Me.btnEliminarProf.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnActualizarUsuario)
        Me.TabPage3.Controls.Add(Me.btnActualizarClase)
        Me.TabPage3.Controls.Add(Me.btnActualizarPrecio)
        Me.TabPage3.Controls.Add(Me.btnActualizarProf)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabPage3.Size = New System.Drawing.Size(405, 156)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "MODIFICAR"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnActualizarUsuario
        '
        Me.btnActualizarUsuario.Location = New System.Drawing.Point(208, 81)
        Me.btnActualizarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizarUsuario.Name = "btnActualizarUsuario"
        Me.btnActualizarUsuario.Size = New System.Drawing.Size(187, 49)
        Me.btnActualizarUsuario.TabIndex = 11
        Me.btnActualizarUsuario.Text = "Actualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuario/Recepcionista"
        Me.btnActualizarUsuario.UseVisualStyleBackColor = True
        '
        'btnActualizarClase
        '
        Me.btnActualizarClase.Location = New System.Drawing.Point(208, 20)
        Me.btnActualizarClase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizarClase.Name = "btnActualizarClase"
        Me.btnActualizarClase.Size = New System.Drawing.Size(187, 49)
        Me.btnActualizarClase.TabIndex = 10
        Me.btnActualizarClase.Text = "Actualizar una clase"
        Me.btnActualizarClase.UseVisualStyleBackColor = True
        '
        'btnActualizarPrecio
        '
        Me.btnActualizarPrecio.Location = New System.Drawing.Point(8, 81)
        Me.btnActualizarPrecio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizarPrecio.Name = "btnActualizarPrecio"
        Me.btnActualizarPrecio.Size = New System.Drawing.Size(187, 49)
        Me.btnActualizarPrecio.TabIndex = 9
        Me.btnActualizarPrecio.Text = "Actualizar un precio"
        Me.btnActualizarPrecio.UseVisualStyleBackColor = True
        '
        'btnActualizarProf
        '
        Me.btnActualizarProf.Location = New System.Drawing.Point(8, 20)
        Me.btnActualizarProf.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizarProf.Name = "btnActualizarProf"
        Me.btnActualizarProf.Size = New System.Drawing.Size(187, 49)
        Me.btnActualizarProf.TabIndex = 8
        Me.btnActualizarProf.Text = "Actualizar un profesor"
        Me.btnActualizarProf.UseVisualStyleBackColor = True
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(24, 401)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(133, 28)
        Me.btnCerrarSesion.TabIndex = 2
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(391, 401)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnConfiguracion)
        Me.GroupBox2.Controls.Add(Me.btnLiquidacionSueldo)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 270)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(467, 123)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Otros"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.Location = New System.Drawing.Point(243, 42)
        Me.btnConfiguracion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(187, 49)
        Me.btnConfiguracion.TabIndex = 8
        Me.btnConfiguracion.Text = "Configuración de Cuenta"
        Me.btnConfiguracion.UseVisualStyleBackColor = True
        '
        'btnLiquidacionSueldo
        '
        Me.btnLiquidacionSueldo.Location = New System.Drawing.Point(43, 42)
        Me.btnLiquidacionSueldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLiquidacionSueldo.Name = "btnLiquidacionSueldo"
        Me.btnLiquidacionSueldo.Size = New System.Drawing.Size(187, 49)
        Me.btnLiquidacionSueldo.TabIndex = 7
        Me.btnLiquidacionSueldo.Text = "Liquidación de sueldo"
        Me.btnLiquidacionSueldo.UseVisualStyleBackColor = True
        '
        'frmMenuAdmi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 444)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenuAdmi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Adminstrador"
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnInscribirNuevoUsuario As System.Windows.Forms.Button
    Friend WithEvents btnCrearNuevaClase As System.Windows.Forms.Button
    Friend WithEvents btnDefinirNuevoPrecio As System.Windows.Forms.Button
    Friend WithEvents btnInscribirNuevoProf As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnEliminarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnEliminarClase As System.Windows.Forms.Button
    Friend WithEvents btnEliminarPrecio As System.Windows.Forms.Button
    Friend WithEvents btnEliminarProf As System.Windows.Forms.Button
    Friend WithEvents btnActualizarUsuario As System.Windows.Forms.Button
    Friend WithEvents btnActualizarClase As System.Windows.Forms.Button
    Friend WithEvents btnActualizarPrecio As System.Windows.Forms.Button
    Friend WithEvents btnActualizarProf As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLiquidacionSueldo As System.Windows.Forms.Button
    Friend WithEvents btnConfiguracion As System.Windows.Forms.Button
End Class
