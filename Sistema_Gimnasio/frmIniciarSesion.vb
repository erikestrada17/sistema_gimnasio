Public Class frmIniciarSesion

    Private Sub frmIniciarSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectarBD("gim")
    End Sub

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        'Simpre se guarda el codUsuario del administrador para el ingreso al menu de admi.
        Dim codAdmi As String = 208
        Dim usuario As String = txtUsuario.Text
        Dim contraseña As String = txtContraseña.Text
        'consultas a la tabla Usuarios
        sql = "select nombre from Usuarios where nombre = '" & usuario & "'"
        usuario = retornarValor(sql)
        sql = "select codUsuario from Usuarios where nombre = '" & usuario & "'"
        Dim codUsuario = retornarValor(sql)
        sql = "select contrasena from Usuarios where codUsuario = '" & codUsuario & "'"
        contraseña = retornarValor(sql)
        If txtUsuario.Text = usuario AndAlso txtContraseña.Text = contraseña Then
            If codUsuario <> codAdmi Then
                Me.Hide()
                frmMenu.Show()
            End If
            If codUsuario = codAdmi Then
                Me.Hide()
                frmMenuAdmi.Show()
            End If
        Else
            MsgBox("Usuario o Contraseña incorrectos. Vuelva a intentar", vbCritical, "ERROR")
        End If
    End Sub

    Private Sub chkMostrarC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMostrarC.CheckedChanged
        If chkMostrarC.Checked = True Then
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

End Class