Imports System.Data.SqlClient
Module Productos
    'FORMULARIO PRODUCTOS
    'Marcas
    Dim valor As String
    Dim msg As SqlParameter
    Public Sub CbMarcas(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select NomMarca from [dbo].[Tb_ProMarcas]", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomMarca"))
            End While

            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Id de la marca
    Public Sub IdMarca(ByRef Id_Marca As Integer, ByVal NomMarca As String)
        Try
            cmd = New SqlCommand("select IdMarca from [dbo].[Tb_ProMarcas] where NomMarca ='" & NomMarca & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                Id_Marca = data_reader(0)
                data_reader.Close()
            End If
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub IdTipo(ByRef Id_Tipo As Integer, ByVal NomTipo As String)
        Try
            cmd = New SqlCommand("SELECT dbo.Tb_ProModelos.IdTipo
                                  FROM dbo.Tb_ProMarcas INNER JOIN
                                       dbo.Tb_ProModelos ON dbo.Tb_ProMarcas.IdMarca = dbo.Tb_ProModelos.IdMarcaModelo INNER JOIN
                                       dbo.Tb_ProTipos ON dbo.Tb_ProModelos.IdTipo = dbo.Tb_ProTipos.IdTipoProd 
                                  WHERE dbo.Tb_ProTipos.NomTipoProd ='" & NomTipo & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                Id_Tipo = data_reader(0)
                data_reader.Close()
            End If
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Modelos segun id de la marca
    Public Sub CbModelos(ByVal cb As ComboBox, ByVal Id_Marca As Integer, ByVal Id_tipo As Integer)
        Try
            cmd = New SqlCommand("SELECT dbo.Tb_ProModelos.NomModelo
                                  FROM dbo.Tb_ProMarcas INNER JOIN
                                       dbo.Tb_ProModelos ON dbo.Tb_ProMarcas.IdMarca = dbo.Tb_ProModelos.IdMarcaModelo INNER JOIN
                                       dbo.Tb_ProTipos ON dbo.Tb_ProModelos.IdTipo = dbo.Tb_ProTipos.IdTipoProd 
                                  WHERE dbo.Tb_ProMarcas.IdMarca ='" & Id_Marca & "' AND dbo.Tb_ProTipos.IdTipoProd ='" & Id_tipo & "'", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomModelo"))
            End While

            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Estado de los productos
    Public Sub CbEstadosProd(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomEstado] from [dbo].[Tb_ProEstados]", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomEstado"))
            End While

            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Tipos de productos
    Public Sub CbTiposProd(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomTipoProd] from [dbo].[Tb_ProTipos]", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomTipoProd"))
            End While

            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Tipo de contrato
    Public Sub CbContratos(ByVal cb As ComboBox)
        Try
            cmd = New SqlCommand("select [NomContrato] from [dbo].[Tb_ProContratos]", cnn)
            Dim data_reader = cmd.ExecuteReader

            While data_reader.Read
                cb.Items.Add(data_reader.Item("NomContrato"))
            End While

            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Agrega producto nuevo o actualiza
    Public Sub AgregarProducto(ByVal id As TextBox, ByRef marca As ComboBox, ByRef modelo As ComboBox, ByRef tipo As ComboBox, ByRef descripcion As TextBox, ByRef estado As ComboBox, ByRef contrato As ComboBox, ByRef sitio As ComboBox, ByRef accion As Integer, ByRef p As Integer)

        Try
            cmd = New SqlCommand("spMultiProducto", cnn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = accion
            cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = id.Text.Trim()
            cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = modelo.Text.Trim()
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = tipo.Text.Trim()
            cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = descripcion.Text.Trim()
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = estado.Text.Trim()
            cmd.Parameters.Add("@contrato", SqlDbType.VarChar).Value = contrato.Text.Trim()
            cmd.Parameters.Add("@sitio", SqlDbType.VarChar).Value = sitio.Text.Trim()
            'se usa para retornar un valor
            msg = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100)
            msg.Direction = ParameterDirection.Output


            cmd.ExecuteNonQuery()

            valor = msg.Value

            If accion = 1 And valor = "10" Then
                MessageBox.Show("Se a creado nuevo registro", "Agregar")
            ElseIf valor = "50" Then
                MessageBox.Show("Service Tag ya existe")
            End If

            If accion = 2 Then
                MessageBox.Show("Se a actualizo el registro", "Actualizar")
            End If
            If accion = 3 Then

            End If

            If accion = 4 Then
                Dim data_reader As SqlDataReader
                data_reader = cmd.ExecuteReader
                If data_reader.Read Then
                    marca.Text = data_reader(0)
                    modelo.Text = data_reader(1)
                    tipo.Text = data_reader(2)
                    descripcion.Text = data_reader(3)
                    estado.Text = data_reader(4)
                    contrato.Text = data_reader(5)
                    sitio.Text = data_reader(6)

                    data_reader.Close()
                    p = 1
                Else
                    MessageBox.Show("Usuario sin registros", "Info")
                    p = 2
                End If
            End If
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
