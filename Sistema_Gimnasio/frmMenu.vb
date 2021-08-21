Public Class frmMenu

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        frmIniciarSesion.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnControlAccesoSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnControlAccesoSocio.Click
        Me.Hide()
        frmAccesoSocio.Show()
    End Sub

    Private Sub btnInscribirNuevoSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInscribirNuevoSocio.Click
        Me.Hide()
        frmRegistrarSocio.Show()
    End Sub

    Private Sub btnIncluirSocioAClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirSocioAClase.Click
        Me.Hide()
        frmIncluirSocioAClase.Show()
    End Sub

    Private Sub btnMantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMantenimiento.Click

    End Sub

    Private Sub btnIngresoAClaseGratis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresoAClaseGratis.Click
        Me.Hide()
        frmClaseGratis.Show()
    End Sub

    Private Sub btnPagoCuotasSocio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPagoCuotasSocio.Click
        Me.Hide()
        frmPagarCuotas.Show()
    End Sub

    Private Sub btnGestionRutinas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestionRutinas.Click

    End Sub

    Private Sub btnAtencionConN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtencionConN.Click
        Me.Hide()
        frmAtencionConN.Show()
    End Sub
End Class