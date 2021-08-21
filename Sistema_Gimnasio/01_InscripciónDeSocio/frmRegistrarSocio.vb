Imports System.Data.Odbc
Imports System.Text.RegularExpressions

Public Class frmRegistrarSocio
    Private Sub frmRegistrarSocio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectarBD("gim")
        Call cambiarSignoDecimal(".")
        btnSeguirConRP.Enabled = False
    End Sub

    Private Sub btnRegistrarSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarSocio.Click
        Dim texto As String
        Dim estilo As MsgBoxStyle
        Dim respuesta As MsgBoxResult

        texto = "DATOS INGRESADOS" & Environment.NewLine &
            "Nombre: " & txtNombre.Text & Environment.NewLine &
            "Apellido: " & txtApellido.Text & Environment.NewLine &
            "DNI: " & txtDNI.Text & Environment.NewLine &
            "Dirección: " & txtDireccion.Text & Environment.NewLine &
            "Localidad: " & txtLocalidad.Text & Environment.NewLine &
            "Cod. Postal:: " & txtCodPostal.Text & Environment.NewLine & Environment.NewLine &
            "Desea registrarlos?"
        estilo = MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo
        respuesta = MsgBox(texto, estilo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                sql = "select max(codSocio) from socios"
                Dim idMax As Object = retornarValor(sql)
                If System.DBNull.Value.Equals(idMax) Then
                    idS = 1
                Else
                    idS = CInt(idMax) + 1
                End If
                nombre = txtNombre.Text
                apellido = txtApellido.Text
                dni = txtDNI.Text
                direccion = txtDireccion.Text
                localidad = txtLocalidad.Text
                codPostal = txtCodPostal.Text
                sql = "insert into socios value('','" & nombre & "','" & apellido & "','" & dni & "','" & direccion & "','" & localidad & "','" & codPostal & "')"
                Call consultar(sql)
                'Inhabilito los botones para registrar una sola vez y seguir hacia Registrar Pago
                btnVolverAlMenu.Enabled = False
                btnLimpiar.Enabled = False
                btnRegistrarSocio.Enabled = False
                btnSeguirConRP.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Call limpiarDatos()
    End Sub

    Public Sub limpiarDatos()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDNI.Clear()
        txtDireccion.Clear()
        txtLocalidad.Clear()
        txtCodPostal.Clear()
    End Sub

    Private Sub btnSeguirConRP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeguirConRP.Click
        'antes de de mostrar el Form2, paso el codigo de socio en una variable global(idS).
        Me.Hide()
        frmRegistrarPago.Show()
        'Se habilata los botones una vez motrado el formulario Registrar Pago(Form2)
        btnVolverAlMenu.Enabled = True
        btnLimpiar.Enabled = True
        btnRegistrarSocio.Enabled = True
        btnSeguirConRP.Enabled = False
    End Sub

    Private Sub btnVolverAlMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAlMenu.Click
        'cod. al menu principal
        Me.Hide()
        frmMenu.Show()
    End Sub

End Class
