Imports System.Data.Odbc
Public Class frmLiquidacionProf

    Public codProf As Integer

    Dim nombre As String = ""
    Dim apellido As String = ""
    Dim idCelda As Integer = 0
    Dim listaID As New List(Of Integer)

    Public salir As Boolean = False

    Private Sub btnCalcularLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcularLiq.Click

        Dim frmProfesor As frmInfoLiquidacion
        Dim nombreSeleccion As String
        Dim apellidoSeleccion As String

        For i As Integer = 0 To lstLiq.Items.Count - 1
            frmProfesor = New frmInfoLiquidacion

            nombreSeleccion = dgvProfesoresLiq.Rows(listaID.Item(i)).Cells("Nombre").Value.ToString
            apellidoSeleccion = dgvProfesoresLiq.Rows(listaID.Item(i)).Cells("Apellido").Value.ToString
            codProf = dgvProfesoresLiq.Rows(listaID.Item(i)).Cells("CodProfesor").Value

            frmProfesor.lblNombreLiq.Text = frmProfesor.lblNombreLiq.Text + nombreSeleccion
            frmProfesor.lblApellidoLiq.Text = frmProfesor.lblApellidoLiq.Text + apellidoSeleccion

            frmProfesor.ShowDialog()

            frmProfesor.Dispose()

            If salir = True Then
                Exit Sub
            End If

        Next

    End Sub

    Private Sub frmLiquidacionProf_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call conectarBD("gim")
        Call cargarGrillaProfesores()

    End Sub

    Private Sub cargarGrillaProfesores()
        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter
        Dim sql As String

        sql = "select Nombre, Apellido, DNI, Telefono, CodProfesor from Profesores"

        ds.Tables.Add("profesores")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("profesores"))

        Me.dgvProfesoresLiq.DataSource = ds.Tables("profesores")

    End Sub

    Private Sub btnAgregarLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarLiq.Click
        lstLiq.Items.Add(nombre + " " + apellido)
        listaID.Add(idCelda)

    End Sub

    Private Sub dgvProfesoresLiq_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProfesoresLiq.CellClick
        idCelda = e.RowIndex
        nombre = dgvProfesoresLiq.Rows(idCelda).Cells("Nombre").Value.ToString()
        apellido = dgvProfesoresLiq.Rows(idCelda).Cells("Apellido").Value.ToString()

    End Sub

    Private Sub btnQuitarLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarLiq.Click
        listaID.RemoveAt(lstLiq.SelectedIndex)
        lstLiq.Items.RemoveAt(lstLiq.SelectedIndex)

    End Sub

End Class
