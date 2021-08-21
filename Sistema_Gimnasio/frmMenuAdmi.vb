Public Class frmMenuAdmi

    Private Sub frmMenuAdmi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Hide()
        frmIniciarSesion.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnInscribirNuevoProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInscribirNuevoProf.Click
        Me.Hide()
        frmRegistrarProf.Show()
    End Sub

    Private Sub btnDefinirNuevoPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefinirNuevoPrecio.Click
        Me.Hide()
        frmDefinirNuevoPrecio.Show()
    End Sub

    Private Sub btnCrearNuevaClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearNuevaClase.Click
        Me.Hide()
        frmCrearNuevaClase.Show()
    End Sub

    Private Sub btnInscribirNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInscribirNuevoUsuario.Click
        Me.Hide()
        frmInscribirUsuario.Show()
    End Sub

    Private Sub btnLiquidacionSueldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLiquidacionSueldo.Click

    End Sub

    Private Sub btnConfiguracion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfiguracion.Click
        Me.Hide()
        frmConfiguracionCuenta.Show()
    End Sub

    Private Sub btnEliminarProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarProf.Click
        Me.Hide()
        frmEliminarProf.Show()
    End Sub

    Private Sub btnEliminarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarPrecio.Click
        Me.Hide()
        frmEliminarPrecio.Show()
    End Sub

    Private Sub btnEliminarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarClase.Click
        Me.Hide()
        frmEliminarClase.Show()
    End Sub

    Private Sub btnEliminarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarUsuario.Click
        Me.Hide()
        frmEliminarUsuario.Show()
    End Sub

    Private Sub btnActualizarProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarProf.Click
        Me.Hide()
        frmActualizarProf.Show()
    End Sub

    Private Sub btnActualizarPrecio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarPrecio.Click
        Me.Hide()
        frmActualizarPrecio.Show()
    End Sub

    Private Sub btnActualizarClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarClase.Click
        Me.Hide()
        frmActualizarClase.Show()
    End Sub

    Private Sub btnActualizarUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarUsuario.Click
        Me.Hide()
        frmActualizarUsuario.Show()
    End Sub
End Class