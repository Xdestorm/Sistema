Imports System.Data.SqlClient

Public Class dbBackup

    Public Sub backupandrestore(ByVal direccion As String, ByVal accion As Integer, ByRef msg As String)

        Try
            cmd = New SqlCommand("Backupdb", cnn) With {
                    .CommandType = CommandType.StoredProcedure
                }

            cmd.Parameters.Add("@accion", SqlDbType.Int).Value = accion
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = direccion
            cmd.Parameters.Add("@msg", SqlDbType.VarChar).Value = msg

            cmd.ExecuteNonQuery()

            '*******************************************************************
            Dim data_reader As SqlDataReader
            data_reader = cmd.ExecuteReader
            If data_reader.Read Then
                msg = data_reader(0)
            End If


        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
