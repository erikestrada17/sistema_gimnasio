Imports System.Data.Odbc
Public Class frmAccesoSocio

    Public nombre, apellido, dni, direccion, localidad, cp As String
    Public fecha As Date


    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click

        Dim sql As String
        Dim rs As OdbcDataReader

        sql = "select * from socio where codsocio = " & txtSocio.Text

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader()
        cmd.Dispose()


        If (rs.Read()) Then

            nombre = rs(1)
            apellido = rs(2)
            dni = rs(3)
            direccion = rs(4)
            localidad = rs(5)
            cp = rs(6)

            sql = "select MAX(FechaPago) from Pagos where CodSocio = " & txtSocio.Text
            cmd = New OdbcCommand(sql, cnn)
            cmd.CommandType = CommandType.Text
            rs = cmd.ExecuteReader()
            cmd.Dispose()


            If rs.Read() Then

                fecha = rs(0)

                frmInfoPago.ShowDialog()


            Else
                MsgBox("El socio no tiene pagos registrados", vbInformation)
            End If

        Else
            MsgBox("El socio ingresado no existe", vbCritical)
        End If
    End Sub
End Class