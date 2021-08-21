Public Class frmEmitirCred

    Private Sub frmEmitirCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'al selecionar la foto, se minimiza el programa. Con lo siguiente se vuelve a mostrar el form.
        Me.Focus()
        Me.Select()
        Me.Show()
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
        Call cargarComprobante()
        frmEmitirComp.Show()
    End Sub

End Class