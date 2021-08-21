Public Class frmRegistrarProf

    Private Sub frmRegistrarProf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnEstablecerHC.Enabled = False
    End Sub

    Private Sub btnRegistrarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarDatos.Click
        Dim texto As String
        Dim estilo As MsgBoxStyle
        Dim respuesta As MsgBoxResult

        texto = "DATOS INGRESADOS" & Environment.NewLine &
            "Nombre: " & txtNombre.Text & Environment.NewLine &
            "Apellido: " & txtApellido.Text & Environment.NewLine &
            "DNI: " & txtDNI.Text & Environment.NewLine &
            "Teléfono: " & txtTelefono.Text & Environment.NewLine & Environment.NewLine &
            "Desea registrarlos?"
        estilo = MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo
        respuesta = MsgBox(texto, estilo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                sql = "select max(codProfesor) from Profesores"
                Dim idMax As Object = retornarValor(sql)
                If System.DBNull.Value.Equals(idMax) Then
                    idS = 1
                Else
                    idS = CInt(idMax) + 1
                End If
                nombre = txtNombre.Text
                apellido = txtApellido.Text
                dni = txtDNI.Text
                direccion = txtTelefono.Text
                sql = "insert into Profesores value('','" & nombre & "','" & apellido & "','" & dni & "','" & telefono & "')"
                Call consultar(sql)
                'Inhabilito los botones para registrar una sola vez y seguir con establecer horario y clase
                btnVolverAlMenu.Enabled = False
                btnRegistrarDatos.Enabled = False
                btnEstablecerHC.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnEstablecerHC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstablecerHC.Click
        Me.Hide()
        frmEstablecerHC.Show()
        btnRegistrarDatos.Enabled = True
        btnVolverAlMenu.Enabled = True
    End Sub

    Private Sub btnVolverAlMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAlMenu.Click
        Me.Hide()
        frmMenuAdmi.Show()
    End Sub
End Class