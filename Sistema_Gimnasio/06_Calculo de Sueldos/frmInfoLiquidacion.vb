Imports System.Data.Odbc
Public Class frmInfoLiquidacion

    Private anio As Integer
    Private mes As Integer

    Public salTot As Single
    Private salString As String
    Public asist As Boolean = True

    Private meses As String() = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}


    Private Sub frmInfoLiquidacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cargarComboAnio()


    End Sub

    Private Sub cargarGrillaClases()

        Dim ds As New DataSet
        Dim adp As OdbcDataAdapter
        Dim sql As String

        sql = "CALL calcularSalario(" & frmLiquidacionProf.codProf & "," & anio & "," & mes & ")"
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        cmd.Dispose()


        sql = "SELECT Clase, Salario, Asistencias AS 'Clases Asistidas', Total AS 'Clases Totales', Horas AS 'Horas Trabajadas' FROM AsisProceso"
        ds.Tables.Add("asistencias")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("asistencias"))

        Me.dgvClasesLiq.DataSource = ds.Tables("asistencias")

        salTot = 0
        asist = True

        For Each row As DataGridViewRow In Me.dgvClasesLiq.Rows

            salTot += (row.Cells("Salario").Value) * (row.Cells("Horas Trabajadas").Value)

            If row.Cells("Clases Totales").Value - row.Cells("Clases Asistidas").Value > 1 Then
                asist = False
            End If

        Next

        salString = salTot.ToString.Replace(",", ".")

        lblAsistenciaLiq.Text = "Bono adicional por Asistencias: "
        lblSalTot.Text = "Salario Total: "

        If asist = True Then
            lblAsistenciaLiq.Text = lblAsistenciaLiq.Text & "Si"
        Else
            lblAsistenciaLiq.Text = lblAsistenciaLiq.Text & "No"
        End If

        lblSalTot.Text = lblSalTot.Text & salTot

    End Sub

    Private Sub cargarComboAnio()

        Dim sql As String
        Dim rsAnios As OdbcDataReader


        sql = "SELECT DISTINCT YEAR(Fecha) FROM RegistrosClases RC INNER JOIN ProfesoresClases PC ON RC.CodPC = PC.CodPC WHERE CodProfesor = " & frmLiquidacionProf.codProf
        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        rsAnios = cmd.ExecuteReader()

        cmd.Dispose()

        While rsAnios.Read()

            cboAnioLiq.Items.Add(rsAnios(0))

        End While


    End Sub

    Private Sub cboAnioLiq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnioLiq.SelectedIndexChanged

        If cboMesLiq.Enabled = False Then
            cboMesLiq.Enabled = True
        End If

        anio = cboAnioLiq.SelectedItem

        cargarComboMes()


    End Sub

    Private Sub cargarComboMes()

        For i As Integer = 0 To cboMesLiq.Items.Count - 1
            cboMesLiq.Items.RemoveAt(i)
        Next


        Dim sql = "SELECT DISTINCT MONTH(Fecha) FROM RegistrosClases RC INNER JOIN ProfesoresClases PC ON RC.CodPC = PC.CodPC WHERE CodProfesor = " & frmLiquidacionProf.codProf & " AND YEAR(FECHA) ='" & anio & "'"
        Dim rsMes As OdbcDataReader

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text

        rsMes = cmd.ExecuteReader()

        cmd.Dispose()

        While rsMes.Read()
            cboMesLiq.Items.Add(rsMes(0))
        End While

    End Sub

    Private Sub cboMesLiq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMesLiq.SelectedIndexChanged

        mes = cboMesLiq.SelectedItem

        cargarGrillaClases()
    End Sub

    Private Sub btnReciboLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReciboLiq.Click

        Dim sql As String

        sql = "INSERT INTO PagosSueldos VALUES(''," & frmLiquidacionProf.codProf & "," & salString & ",CURDATE(), '" & meses(cboMesLiq.SelectedItem - 1) & "')"

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()
        cmd.Dispose()

        reciboSueldo.ShowDialog()


    End Sub

    Private Sub btnCancelarLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarLiq.Click
        Me.Close()
    End Sub

    Private Sub btnCancelarTodoLiq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTodoLiq.Click
        frmLiquidacionProf.salir = True
        Me.Close()
    End Sub
End Class