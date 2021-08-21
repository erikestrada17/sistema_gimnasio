Public Class frmPagarCuotas

    Private Sub frmPagarCuotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click

    End Sub

    Private Sub btnAñadirCA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAñadirCA.Click

    End Sub

    Private Sub btnRegistrarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarPago.Click

    End Sub

    Private Sub btnVolverAlMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverAlMenu.Click
        Me.Hide()
        frmMenu.Show()
    End Sub

    Private Sub btnEmitirCompPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirCompPago.Click
        Me.Hide()
        frmEmitirCompPago.Show()

    End Sub
End Class