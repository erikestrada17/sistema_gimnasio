Public Class frmRegistrarPago

    Private Sub frmRegistrarPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'consulta a Precios para para agregarlos como items de cboPrecios
        Try
            sql = "select count(*) from precios"
            Dim cantidadPrecios As Integer = CInt(retornarValor(sql))

            listaPrecios.Clear()
            For i = 1 To cantidadPrecios Step 1
                sql = "select monto from precios limit '" & cantidadPrecios - i & "',1"
                sql = sql.Replace("'", "")
                Dim precio = retornarValor(sql)
                sql = "select descripcion from precios limit '" & cantidadPrecios - i & "',1"
                sql = sql.Replace("'", "")
                Dim descripcion = retornarValor(sql)
                sql = "'" & descripcion & "':'" & precio & "'" 'se guarda en sql los valores retornados
                sql = sql.Replace("'", "") 'se elimina todas las comillas simples dentro sql
                cboPrecios.Items.Add(sql) 'y ahora si se agrega a cboPrecios
                listaPrecios.Add(precio) 'asignacion correcta
            Next (i)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim monto As Single = CSng(lblMonto.Text)
        Dim fecha As String = Format(dtpFecha.Value.Date, "yyyy/MM/dd")
        Dim descripcion As String = txtDescripcion.Text

        Dim texto As String
        Dim estilo As MsgBoxStyle
        Dim respuesta As MsgBoxResult

        texto = "DATOS INGRESADOS" & Environment.NewLine &
            "Monto: " & monto & Environment.NewLine &
            "Fecha: " & fecha & Environment.NewLine &
            "Descripción: " & descripcion & Environment.NewLine & Environment.NewLine &
            "Desea registrarlos?"
        estilo = MsgBoxStyle.Question Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo
        respuesta = MsgBox(texto, estilo)

        If respuesta = MsgBoxResult.Yes Then
            Try
                sql = "select max(codPago) from pagos"
                Dim codPagoMax As Object = retornarValor(sql)
                If System.DBNull.Value.Equals(codPagoMax) Then
                    codPago = 1
                Else
                    codPago = CInt(codPagoMax) + 1
                End If
                'en la variable "idS" se almacena el codigo de socio de la inscripción
                sql = "insert into pagos value('','" & idS & "','" & monto & "','" & fecha & "','" & descripcion & "')"
                Call consultar(sql)
                'lo sig para habilitar el botón Emitir Documentos 
                'e inhabilitar btnRegistrar para q solo pueda registrar una vez
                btnEmitirDoc.Enabled = True
                btnRegistrar.Enabled = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Public Sub limpiarDatos()
        'se limpia los datos ingresados 
        'y se aprovecha usar el procedimiento para que vuela los Text, como estaba antes de ingresar datos
        txtDescripcion.Clear()
        cboPrecios.Text = "Seleccione uno de los precios"
        lblMonto.Text = "precio seleccionado"
    End Sub

    Private Sub btnEmitirDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmitirDoc.Click
        MsgBox("Para continuar. Debe ingresar la foto del usuario", vbInformation, "FOTO DE USUARIO")
        btnRegistrar.Enabled = True
        btnEmitirDoc.Enabled = False
        'proceso para emitir los documentos "Credencial de Cliente"(Form3) y "Comprobante de Pago"(Form4)
        Me.Hide()
        'cargar datos a formularios de los doc.
        Call cargarCredencial()
        frmEmitirCred.Show()
    End Sub

    Private Sub cboPrecios_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPrecios.SelectionChangeCommitted
        Dim indice As Integer = cboPrecios.SelectedIndex
        lblMonto.Text = listaPrecios(indice)
    End Sub
End Class