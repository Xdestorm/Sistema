Imports System.Data.SqlClient
Module informes

#Disable Warning IDE1006 ' Estilos de nombres
    Public Sub inventario(ByVal sitio As ComboBox, ByRef msg As String, ByRef datos As DataGridView)
#Enable Warning IDE1006 ' Estilos de nombres
        cmd = New SqlCommand("spInventario", cnn) With {
            .CommandType = CommandType.StoredProcedure
        }
        adp = New SqlDataAdapter(cmd)
        dt = New DataTable

        With cmd.Parameters
            'Envió los parámetros que necesito
            .Add(New SqlParameter("@sitio", SqlDbType.VarChar)).Value = sitio.Text.Trim()
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

#Disable Warning IDE1006 ' Estilos de nombres
    Public Sub inventariomulti(ByVal sitio As ComboBox, ByVal estado As String, ByVal accion As Integer, ByVal host As String, ByRef msg As String, ByRef datos As DataGridView)
#Enable Warning IDE1006 ' Estilos de nombres
        cmd = New SqlCommand("spInventarioMulti", cnn) With {
            .CommandType = CommandType.StoredProcedure
        }
        adp = New SqlDataAdapter(cmd)
        dt = New DataTable

        With cmd.Parameters
            'Envió los parámetros que necesito
            .Add(New SqlParameter("@sitio", SqlDbType.VarChar)).Value = sitio.Text.Trim()
            .Add(New SqlParameter("@estado", SqlDbType.VarChar)).Value = estado.Trim()
            .Add(New SqlParameter("@accion", SqlDbType.VarChar)).Value = accion
            .Add(New SqlParameter("@host", SqlDbType.VarChar)).Value = host.Trim()
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

End Module
