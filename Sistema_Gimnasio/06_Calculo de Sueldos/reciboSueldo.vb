Public Class reciboSueldo

    Private Sub reciboSueldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        llenarDocumento()



    End Sub

    Private Sub llenarDocumento()

        Dim salario As Single
        Dim bonoAsist As Single = 0

        Dim descJub As Single = (salario * 11) / 100
        Dim descObr As Single = (salario * 3) / 100

        salario = frmInfoLiquidacion.salTot

        lblBasicoSueldo.Text = salario

        If frmInfoLiquidacion.asist = True Then

            bonoAsist = (salario * 8.3) / 100
            lblAsistSueldo.Text = bonoAsist

        Else
            lblAsistSueldo.Text = 0
        End If

        lblJubilSueldo.Text = descJub
        lblObraSueldo.Text = descObr

        lblRemSueldo.Text = salario + bonoAsist
        lblDescSueldo.Text = descJub + descObr

        lblTotalSueldo.Text = salario + bonoAsist - descJub - descObr
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        If PrintDialog1.ShowDialog() Then
            PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings
            Me.PrintForm1.Print()
        End If
        btnImprimir.Visible = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Hide()
        frmMenu.Show()
    End Sub
End Class