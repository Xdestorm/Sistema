Imports System.Data.SqlClient

Module conexion

    Friend cnn As SqlConnection, cmd As SqlCommand, adp As SqlDataAdapter, dt As DataTable

    'CONEXION SQL
    '*************************************************************************************************************************

    'AZURE 

    'cnn = New SqlConnection("Server=tcp:vmsql-01.database.windows.net,1433;Initial Catalog=InvSoporte;Persist Security Info=False;User ID=test;Password=********;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;")

    Public Sub ConectarSQL(Optional ByVal Server As String = "XDESTORM-NV", Optional ByVal DB As String = "InvSoporte")

        cnn = New SqlConnection("Server=" & Server & ";Database=" & DB & ";Integrated Security=true")

        Try

            cnn.Open()
            'MsgBox("conexion realizada con exito")

        Catch ex As Exception

            MessageBox.Show("Error al conectar: " & vbCrLf & ex.Message)

        End Try
    End Sub
    'DESCONECTA LA CONEXION SQL
    Public Sub DesconectarSQL()

        cnn.Close()

    End Sub

End Module
