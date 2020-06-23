Imports System.Data.SqlClient
Module Asignaciones
    Dim msg As SqlParameter
    Dim valor As String
    'FORMULARIO ASIGNACIONES
    'Consulta usuarios
#Disable Warning IDE1006 ' Estilos de nombres
    Public Sub consultaUsuario(ByVal correo As TextBox, ByRef msg As String, ByRef datos As DataGridView)
#Enable Warning IDE1006 ' Estilos de nombres
        cmd = New SqlCommand("spConsultaUsuario", cnn) With {
            .CommandType = CommandType.StoredProcedure
        }
        adp = New SqlDataAdapter(cmd)
        dt = New DataTable

        With cmd.Parameters
            'Envió los parámetros que necesito
            .Add(New SqlParameter("@correo", SqlDbType.VarChar)).Value = correo.Text.Trim()
            .Add(New SqlParameter("@msg", SqlDbType.VarChar)).Value = msg

        End With
        Try
            'Aquí ejecuto el SP y lo lleno en el DataTable
            adp.Fill(dt)
            'Enlazo mis datos obtenidos en el DataTable con el grid
            datos.DataSource = dt


        Catch e As SqlException
            MsgBox(e.ToString, MsgBoxStyle.OkOnly, "SQL Exception")
            Exit Sub
        End Try


    End Sub

    'Consulta asignaciones

#Disable Warning IDE1006 ' Estilos de nombres
    Public Sub consultaAsignaciones(ByVal correo As TextBox, ByRef msg As String, ByRef datos As DataGridView)
#Enable Warning IDE1006 ' Estilos de nombres
        cmd = New SqlCommand("spConsultaAsignaciones", cnn) With {
            .CommandType = CommandType.StoredProcedure
        }
        adp = New SqlDataAdapter(cmd)
        dt = New DataTable

        With cmd.Parameters
            'Envió los parámetros que necesito
            .Add(New SqlParameter("@correo", SqlDbType.VarChar)).Value = correo.Text.Trim()
            .Add(New SqlParameter("@msg", SqlDbType.VarChar)).Value = msg

        End With
        Try
            'Aquí ejecuto el SP y lo lleno en el DataTable
            adp.Fill(dt)
            'Enlazo mis datos obtenidos en el DataTable con el grid
            datos.DataSource = dt


        Catch e As SqlException
            MsgBox(e.ToString, MsgBoxStyle.OkOnly, "SQL Exception")
            Exit Sub
        End Try


    End Sub


    'Trae las marcas del producto seleccionado
    Public Sub NomMarca(ByRef Tipo As ComboBox, ByRef NomMarca As ComboBox)
        Try
            cmd = New SqlCommand("SELECT DISTINCT dbo.Tb_ProMarcas.NomMarca
                                  FROM  dbo.Tb_Productos INNER JOIN 
                                    dbo.Tb_ProTipos ON dbo.Tb_Productos.IdTipoProducto = dbo.Tb_ProTipos.IdTipoProd INNER JOIN 
                                    dbo.Tb_ProModelos ON dbo.Tb_Productos.IdModelo = dbo.Tb_ProModelos.IdModelo INNER JOIN 
                                    dbo.Tb_ProMarcas ON dbo.Tb_ProModelos.IdMarcaModelo = dbo.Tb_ProMarcas.IdMarca
                                  WHERE dbo.Tb_ProTipos.NomTipoProd = '" & Tipo.Text & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            While data_reader.Read
                NomMarca.Items.Add(data_reader.Item("NomMarca"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'llena el CB Modelo 
    Public Sub NomModelo(ByRef NomModelo As ComboBox, ByVal NomMarca As ComboBox, ByVal CbTipoProductoAsig As ComboBox)
        Try
            cmd = New SqlCommand("SELECT DISTINCT dbo.Tb_ProModelos.NomModelo
                                  FROM dbo.Tb_Productos INNER JOIN
                                    dbo.Tb_ProTipos ON dbo.Tb_Productos.IdTipoProducto = dbo.Tb_ProTipos.IdTipoProd INNER JOIN
                                    dbo.Tb_ProModelos ON dbo.Tb_Productos.IdModelo = dbo.Tb_ProModelos.IdModelo INNER JOIN
                                    dbo.Tb_ProMarcas ON dbo.Tb_ProModelos.IdMarcaModelo = dbo.Tb_ProMarcas.IdMarca
                                  WHERE dbo.Tb_ProTipos.NomTipoProd = '" & CbTipoProductoAsig.Text & "' AND dbo.Tb_ProMarcas.NomMarca = '" & NomMarca.Text & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            While data_reader.Read
                NomModelo.Items.Add(data_reader.Item("NomModelo"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'llena el CB Disponibles
    Public Sub Disponibles(ByRef ProDis As ComboBox, ByVal modelo As String)
        Dim estado As String
        estado = "Disponible"
        Try
            cmd = New SqlCommand("SELECT DISTINCT dbo.Tb_Productos.IdServiceTag
                                  FROM dbo.Tb_Productos INNER JOIN
                                    dbo.Tb_ProTipos ON dbo.Tb_Productos.IdTipoProducto = dbo.Tb_ProTipos.IdTipoProd INNER JOIN
                                    dbo.Tb_ProModelos ON dbo.Tb_Productos.IdModelo = dbo.Tb_ProModelos.IdModelo INNER JOIN
                                    dbo.Tb_ProMarcas ON dbo.Tb_ProModelos.IdMarcaModelo = dbo.Tb_ProMarcas.IdMarca INNER JOIN
                                    dbo.Tb_ProEstados ON dbo.Tb_Productos.IdEstadoProducto = dbo.Tb_ProEstados.IdEstadosProductos
                                  WHERE dbo.Tb_ProEstados.NomEstado = '" & estado & "' AND dbo.Tb_ProModelos.NomModelo = '" & modelo & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            While data_reader.Read
                ProDis.Items.Add(data_reader.Item("IdServiceTag"))
            End While
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AsignarProductos(ByVal accion As String, ByRef usuario As TextBox, ByRef producto As ComboBox, ByVal host As TextBox, ByVal multi As Integer)

        Try
            cmd = New SqlCommand("spAsignaciones", cnn) With {
                .CommandType = CommandType.StoredProcedure
            }

            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = accion
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.Text.Trim()
            cmd.Parameters.Add("@producto", SqlDbType.VarChar).Value = producto.Text.Trim()
            cmd.Parameters.Add("@host", SqlDbType.VarChar).Value = host.Text.Trim()
            cmd.Parameters.Add("@multi", SqlDbType.Int).Value = multi
            'se usa para retornar un valor
            msg = cmd.Parameters.Add("@msg", SqlDbType.VarChar, 100)
            msg.Direction = ParameterDirection.Output


            cmd.ExecuteNonQuery()

            valor = msg.Value

            If accion = 1 And valor = 20 Then
                MessageBox.Show("Se agrego nuevo producto", "Agregar")
            ElseIf accion = 1 And valor = 30 Then
                MessageBox.Show("Producto ya se encuentra asignado al usuario")
                Limpiar(FrmAsignaciones)
            End If

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub
    'descripccion
    Public Sub Descripcion(ByVal CbProDisp As ComboBox, ByRef TbDescripcion As String)
        Try
            cmd = New SqlCommand("SELECT Descripcion  FROM Tb_Productos  WHERE IdServiceTag ='" & CbProDisp.Text & "'", cnn)
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                TbDescripcion = data_reader(0)
                data_reader.Close()
            End If
            data_reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
