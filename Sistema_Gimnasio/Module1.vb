Imports System.Data.Odbc
Imports System.Globalization

Module Module1
    'declaración de variables para el inicio de sesión
    Public Usuario As String
    Public Contraseña As String

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public ds As New DataSet
    Public adp As OdbcDataAdapter

    Public sql As String

    Public idS As String
    Public nombre As String
    Public apellido As String
    Public dni As String
    Public direccion As String
    Public localidad As String
    Public codPostal As String

    Public listaPrecios As New ArrayList() 'declaracion correcta de nueva lista

    Public codPago As String 'para comprobante de pago

    Public telefono 'para telefono del profesor(reutilizable para otros tambien)
    'Se reutilizar las variables; idS, nombre, apellido y dni para el profesor

    Public Sub conectarBD(ByVal nombreBD As String)
        Try
            cnn = New OdbcConnection("DSN=" & nombreBD)
            cnn.Open()
            MsgBox("Se establecio la conexion con exito!", vbInformation, "CONEXION")
            Call cambiarSignoDecimal(".")
        Catch ex As Exception
            MsgBox("Falla en el intento de conexión!", vbCritical, "ERRORES")
        End Try
    End Sub

    Public Sub cambiarSignoDecimal(ByVal signo As String)
        Dim cambio As New Globalization.CultureInfo("es-ES")
        cambio.NumberFormat.NumberDecimalSeparator = (signo)
        System.Threading.Thread.CurrentThread.CurrentCulture = cambio
    End Sub

    Public Sub consultar(ByVal sql As String)
        Try
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub agregarAGrilla(ByVal sql As String, ByVal grilla As Object) 'limpia y agrega una consulta a una tabla para la grilla
        ds.Tables.Clear()
        ds.Tables.Add("t1")
        adp = New OdbcDataAdapter(sql, cnn)
        adp.Fill(ds.Tables("t1"))
        grilla.DataSource = ds.Tables("t1")
    End Sub

    Public Function retornarValor(ByVal sql As String) As Object 'funcion para me retorne un valor de una consulta
        Try
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            Dim rs As Object = cmd.ExecuteScalar()
            cmd.Dispose()
            retornarValor = rs
        Catch ex As Exception
            retornarValor = MsgBox(ex.Message)
        End Try
    End Function

    Public Sub cargarCredencial()
        Try
            frmEmitirCred.lblDireccionGim.Text = "Av Rivadavia 12500"
            frmEmitirCred.lblTelefonoGim.Text = "4456-5567"
            frmEmitirCred.lblNroSocio.Text = idS
            frmEmitirCred.lblFechaIngreso.Text = Format(frmRegistrarPago.dtpFecha.Value.Date, "yyyy/MM/dd")
            frmEmitirCred.lblNombreApellido.Text = nombre & " " & apellido
            frmEmitirCred.lblDireccion.Text = direccion
            frmEmitirCred.lblLocalidad.Text = localidad
            frmEmitirCred.lblCodPostal.Text = codPostal
            'para agregar la imagen del cliente
            frmEmitirCred.OpenFileDialog1.InitialDirectory = "D:\img_Gimnasio\usuario-sin-foto.png"
            If frmEmitirCred.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                frmEmitirCred.PictureBox1.Image = Image.FromFile(frmEmitirCred.OpenFileDialog1.FileName)
                frmEmitirCred.Focus()
                frmEmitirCred.Select()
                frmEmitirCred.Show()
            End If
            frmEmitirCred.Focus()
            frmEmitirCred.Select()
            frmEmitirCred.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cargarComprobante()
        Try
            frmEmitirComp.lblCodPago.Text = codPago
            frmEmitirComp.lblNombreApellido.Text = frmEmitirCred.lblNombreApellido.Text
            frmEmitirComp.lblNroDNI.Text = dni
            frmEmitirComp.lblPrecio.Text = frmRegistrarPago.lblMonto.Text
            frmEmitirComp.lblDescripcion.Text = frmRegistrarPago.txtDescripcion.Text
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarDocumentos()
        Try
            frmEmitirCred.lblDireccionGim.Text = ""
            frmEmitirCred.lblTelefonoGim.Text = ""
            frmEmitirCred.lblNroSocio.Text = ""
            frmEmitirCred.lblFechaIngreso.Text = ""
            frmEmitirCred.lblNombreApellido.Text = ""
            frmEmitirCred.lblDireccion.Text = ""
            frmEmitirCred.lblLocalidad.Text = ""
            frmEmitirCred.lblCodPostal.Text = ""
            frmEmitirCred.OpenFileDialog1.InitialDirectory = "D:\img_Gimnasio\usuario-sin-foto.png"
            frmEmitirComp.lblCodPago.Text = ""
            frmEmitirComp.lblNombreApellido.Text = ""
            frmEmitirComp.lblNroDNI.Text = ""
            frmEmitirComp.lblPrecio.Text = ""
            frmEmitirComp.lblDescripcion.Text = ""
            'agrego lo siguiente para que limpie tambien los txt y lbl de los procesos
            Call frmRegistrarSocio.limpiarDatos()
            Call frmRegistrarPago.limpiarDatos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cargarCredProf()
        Try
            frmEmitirCredProf.lblDireccionGim.Text = "Av Rivadavia 12500"
            frmEmitirCredProf.lblTelefonoGim.Text = "4456-5567"
            frmEmitirCredProf.lblNroProf.Text = idS
            frmEmitirCredProf.lblDNI.Text = dni
            frmEmitirCredProf.lblNombreApellido.Text = nombre & " " & apellido
            frmEmitirCredProf.lblTelefono.Text = telefono
            'para agregar la imagen del cliente
            frmEmitirCredProf.OpenFileDialog1.InitialDirectory = "D:\Sistema_Gimnasio\Sistema_Gimnasio\Resources\usuario-sin-foto.png"
            If frmEmitirCredProf.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                frmEmitirCredProf.PictureBox1.Image = Image.FromFile(frmEmitirCredProf.OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
