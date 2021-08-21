Public Class frmEmitirCredProf

    Private Sub frmEmitirCredProf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        'Call cargarItinerario()
        frmEmitirItinerario.Show()
    End Sub
End Class