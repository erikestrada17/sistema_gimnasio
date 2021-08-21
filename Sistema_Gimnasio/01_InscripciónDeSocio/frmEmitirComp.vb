Public Class frmEmitirComp

    Private Sub frmEmitirComp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        If PrintDialog1.ShowDialog() Then
            'Me.Select()
            PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
            Me.PrintForm1.Print()
        End If
        btnImprimir.Visible = True
        Me.Hide()
        frmRegistrarSocio.Show()
        MsgBox("Fin de Inscripción del Socio. Puede registrar otro o volver a menú", vbInformation, "REGISTRO")
        Call LimpiarDocumentos()
    End Sub
End Class