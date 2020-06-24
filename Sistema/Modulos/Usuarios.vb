Imports System.Data.SqlClient
Module Usuarios
    'FORMULARIO USUARIOS
    'Plantas
    Dim valor As String
    Dim msg As SqlParameter
    Public Sub CbPlanta(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomSitio] from [dbo].[Tb_Sitios] ORDER BY NomSitio ASC", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomSitio"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Empresas
    Public Sub CbEmpresas(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomEmpresa] from [dbo].[Tb_Empresas] ORDER BY NomEmpresa ASC", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomEmpresa"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Tipos de Usuarios
    Public Sub CbTipos(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomTipoPer] from [dbo].[Tb_TipoPersona] ORDER BY NomTipoPer ASC", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomTipoPer"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Estado del usuario
    Public Sub Cbestados(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomEstado] from [dbo].[Tb_Estados]", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomEstado"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Agregar usuario nuevo, actualizar, eliminar o consultar
    Public Sub AgregarUsuario(ByVal correo As String, ByRef nom As TextBox, ByRef apell As TextBox, ByRef ubicacion As TextBox, ByRef planta As ComboBox, ByRef empresa As ComboBox, ByRef anexo As Integer, ByRef tipo As ComboBox, ByRef estado As ComboBox, ByVal accion As Integer, ByVal clave As TextBox, ByRef i As Integer)

        'procedimiento que crea al usuario, lo actualiza, elimina 
        Try
            cmd = New SqlCommand("spMultiUsuario", cnn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("@correo", SqlDbType.VarChar).Value = correo.Trim()
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nom.Text.Trim()
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apell.Text.Trim()
            cmd.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = ubicacion.Text.Trim()
            cmd.Parameters.Add("@planta", SqlDbType.VarChar).Value = planta.Text.Trim()
            cmd.Parameters.Add("@empresa", SqlDbType.VarChar).Value = empresa.Text.Trim()
            cmd.Parameters.Add("@anexo", SqlDbType.Int).Value = anexo
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo.Text.Trim()
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado.Text.Trim()
            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = accion
            cmd.Parameters.Add("@cla", SqlDbType.VarChar).Value = clave.Text.Trim()
            'se usa para retornar un valor
            msg = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100)
            msg.Direction = ParameterDirection.Output

            cmd.ExecuteNonQuery()

            'si la accion es consultar traemos los datos si existen
            If accion = 4 Then
                Dim data_reader As SqlDataReader
                data_reader = cmd.ExecuteReader
                If data_reader.Read Then
                    nom.Text = data_reader(0)
                    apell.Text = data_reader(1)
                    anexo = data_reader(2)
                    planta.Text = data_reader(3)
                    ubicacion.Text = data_reader(4)
                    empresa.Text = data_reader(5)
                    estado.Text = data_reader(6)
                    tipo.Text = data_reader(7)

                    data_reader.Close()
                    i = 1
                Else
                    MessageBox.Show("Usuario sin registros", "Info")
                    i = 2
                End If
            End If
            '*******************************************************************

            valor = msg.Value 'este es el valor retornado de la consulta

            '10 = inserta
            '20 = actualiza
            '30 = elimina
            '40 = selecciona
            '50 = actualiza clave
            '60 = error o existe usuario

            'validaciones de valor retornado
            If accion = 1 And valor = "10" Then

                MessageBox.Show("Se a creado nuevo registro", "Agregar")

            ElseIf accion = 2 And valor = "20" Then

                MessageBox.Show("Se a actualizo el registro", "Actualizar")

            ElseIf accion = 3 And valor = "30" Then

                MessageBox.Show("Se a eliminado el registro", "Eliminar")

            ElseIf accion = 5 And valor = "50" Then

                MessageBox.Show("Se actualizo la clave de usuario", "Clave")

            ElseIf valor = "60" Then

                MessageBox.Show("Usuario ya existe")

            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
