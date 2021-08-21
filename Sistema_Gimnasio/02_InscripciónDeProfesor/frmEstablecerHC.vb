Public Class frmEstablecerHC

    Dim codClaseElegida As Integer
    Dim codHorarioClase As Integer
    Dim dia As String
    Dim horario As String

    Private Sub DGVHorariosClases_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVHorariosClases.CellClick
        Try
            codHorarioClase = DGVHorariosClases.CurrentRow.Cells(0).Value
            dia = DGVHorariosClases.CurrentRow.Cells(2).Value
            horario = DGVHorariosClases.CurrentRow.Cells(3).Value
            btnEstablecerHC.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub DGVClases_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVClases.CellClick
        Try
            If DGVClases.SelectedRows.Count > 0 Then
                codClaseElegida = DGVClases.CurrentRow.Cells(0).Value
                DGVHorariosClases.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'para seleccionar toda la fila
                DGVHorariosClases.ReadOnly = True 'para no hacer editable los valores en celdas (solo lectura)
                sql = "select * from HorariosClases where codClase = " & codClaseElegida
                Call agregarAGrilla(sql, DGVHorariosClases)
                DGVHorariosClases.Columns(0).Visible = False 'hago no visible el codHorarioClase
                DGVHorariosClases.Columns(1).Visible = False 'hago no visible el codSocio
                MsgBox("Seleccione la fila de algún Horario", vbInformation, "HORARIOS DE CLASES")
            Else
                MsgBox("Seleccione alguna fila", vbInformation, "CLASES")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        
    End Sub

    Private Sub frmEstablecerHC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'consultar Clases y HorariosClases
        '...
        DGVClases.SelectionMode = DataGridViewSelectionMode.FullRowSelect 'para seleccionar toda la fila
        DGVClases.ReadOnly = True 'para no hacer editable los valores en celdas (solo lectura)
        sql = "select * from Clases"
        Call agregarAGrilla(sql, DGVClases) 'procedimiento que agrega la consulta a la grilla
        DGVClases.Columns(0).Visible = False 'hago no visible el codSocio
        Me.Show()
        MsgBox("Seleccione la fila de alguna clase", vbInformation, "CLASES")

        btnEstablecerHC.Enabled = False
        btnIncluirProfEnClase.Enabled = False
        btnGenerarDoc.Enabled = False
    End Sub

    Private Sub btnEstablecerHC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstablecerHC.Click
        'EstablecerHC
        lblClase.Text = "Clase: " & DGVClases.CurrentRow.Cells(1).Value
        lblSalario.Text = "Salario: " & DGVClases.CurrentRow.Cells("Salario").Value 'en Cells(indice o nombre)
        lblHorario.Text = "Dia y Horario: " & dia & " " & horario

        'Habilitar o inhabilitar una vez EstablecidoHC
        gboClases.Enabled = True
        gboHorariosClases.Enabled = True
        btnEstablecerHC.Enabled = False
        btnIncluirProfEnClase.Enabled = True
        btnGenerarDoc.Enabled = False
    End Sub

    Private Sub btnIncluirProfEnClase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirProfEnClase.Click
        'Insertar profesor en la clase
        sql = "insert into ProfesoresClases value(''," & idS & "," & codHorarioClase & ")"
        Call consultar(sql)

        btnEstablecerHC.Enabled = False
        btnIncluirProfEnClase.Enabled = False
        btnGenerarDoc.Enabled = True
        'Mas tarde contemplar Salario, talvez consultar salarios ya definidos en Precios
    End Sub

    Private Sub btnGenerarDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarDoc.Click
        MsgBox("Para continuar. Debe ingresar la foto del usuario", vbInformation, "FOTO DE USUARIO")
        Me.Hide()
        Call cargarCredProf()
        frmEmitirCredProf.Show()
    End Sub

End Class