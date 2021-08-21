Public Class frmInfoPago


    Private Sub frmInfoPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblNombre.Text = lblNombre.Text & frmAccesoSocio.nombre
        lblApellido.Text = lblApellido.Text & frmAccesoSocio.apellido
        lblDni.Text = lblDni.Text & frmAccesoSocio.dni
        lblDireccion.Text = lblDireccion.Text & frmAccesoSocio.direccion
        lblLocalidad.Text = lblLocalidad.Text & frmAccesoSocio.localidad
        lblCp.Text = lblCp.Text & frmAccesoSocio.cp

        lblPago.Text = lblPago.Text & frmAccesoSocio.fecha

        verificarEstado()


    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub verificarEstado()

        Dim t As TimeSpan = Now - frmAccesoSocio.fecha

        If (t.TotalDays < 31) Then
            lblEstado.Text = "ADMITIDO"
            lblEstado.BackColor = Color.Green
        Else
            lblEstado.Text = "RECHAZADO"
            lblEstado.BackColor = Color.Red
        End If

    End Sub


End Class