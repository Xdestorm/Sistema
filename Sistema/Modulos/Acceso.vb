Imports System.Data.SqlClient
Module Acceso
    'valida usuario y clave de acceso al programa
#Disable Warning IDE1006 ' Estilos de nombres
    Public Sub spLogin(ByVal user As TextBox, ByVal psw As TextBox, ByRef acceso As Integer, ByRef tipo As Integer)
#Enable Warning IDE1006 ' Estilos de nombres

        Try
            cmd = New SqlCommand("spAcceso", cnn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("@user", SqlDbType.VarChar).Value = user.Text.Trim()
            cmd.Parameters.Add("@psw", SqlDbType.VarChar).Value = psw.Text.Trim()
            cmd.Parameters.Add("@tipo", SqlDbType.Int).Value = tipo

            cmd.ExecuteNonQuery()

            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                user.Text = data_reader(0)
                psw.Text = data_reader(1)
                tipo = data_reader(2)
                'condicion donde se valida si el dato es igual 
                If user.Text = data_reader(0) And psw.Text = data_reader(1) Then
                    'concede acceso 
                    acceso = 1

                    If data_reader(2) = 1 Then
                        'acceso administrador
                        tipo = 1
                    Else

                        tipo = 0
                    End If
                Else
                    acceso = 0
                    MsgBox("datos no son validos")
                End If

                data_reader.Close()

            Else
                MsgBox("no se encontro el usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Module
